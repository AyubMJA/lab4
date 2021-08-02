using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        string filePath; // This holds the filePath of the doc in system.
        string fileName; // This holds the name of the doc.

        public Form1()
        {
            InitializeComponent();
        }
         

        /// <summary>
        /// This is the file tool bar. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openHTMLFile.ShowDialog() == DialogResult.OK)
            {
                filePath = openHTMLFile.FileName;
                fileName = filePath.Split('\\')[^1];
                checkTagBTN.Enabled = true;
                FileStatus($"Loaded: {fileName}",Color.Green);
            }
            else
            {
                FileStatus("File Not Found!", Color.Red);
            }
        }

        /// <summary>
        /// This is a method its only job is to change the text colour. Green and Red.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="colour"></param>
        public void FileStatus(string text, Color colour)
        {
            filestatusLB.ForeColor = colour;
            filestatusLB.Text = text;
        }

        /// <summary>
        /// This method is connect to the exit button. Closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        /// <summary>
        /// This method is responsible for importing and loading file to the windows form. Also 
        /// checking if the file is open and closed tags are correct.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stack<string> htmlTags = new Stack<string>();

            string whiteSpace = ""; //this creates white space like who a tab does on a keyboard.

            if (File.Exists(filePath))
            {
                FileStream fileStream = null;
                StreamReader streamReader = null;

                try
                {
                    fileStream = new FileStream(filePath, FileMode.Open);
                    streamReader = new StreamReader(fileStream);

                    while (!streamReader.EndOfStream)
                    {
                        string input = streamReader.ReadLine();
                        if (input != "")
                        {
                            string[] values = input.Split('<');

                            //change to linq setup error using pervious method.
                            foreach (var (value, tag) in from string value in values
                                                         where !string.IsNullOrWhiteSpace(value)
                                                         let htmlTag = value.Split('>')[0]
                                                         let tag = htmlTag.Split(' ')[0].ToLower()
                                                         where tag != ""
                                                         select (value, tag))
                            {
                                if (value.StartsWith("img") || value.StartsWith("hr") || value.StartsWith("br"))
                                {
                                    htmlTagLB.Items.Add($"{whiteSpace}Found non-container tag: <{tag}>");
                                }
                                else if (tag.StartsWith("/"))
                                {
                                    whiteSpace = whiteSpace[0..^2];

                                    
                                    if (htmlTags.Peek() != tag[1..])
                                    {
                                        FileStatus($"{fileName} Tags are not balanced", Color.Red);
                                        return;
                                    }
                                    else
                                        htmlTags.Pop();

                                    htmlTagLB.Items.Add($"{whiteSpace}Found closing tag: <{tag}>");
                                }
                                else
                                {
                                    htmlTagLB.Items.Add($"{whiteSpace}Found opening tag: <{tag}>");
                                    whiteSpace += "  ";
                                    htmlTags.Push(tag);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    FileStatus("Failed to read document", Color.Red);
                    MessageBox.Show($"Failed to read document because of:\n{ex}", "Failed to process file!");
                    checkTagBTN.Enabled = false;
                }
                finally
                {
                    if(fileStream != null || streamReader != null)
                    {
                        fileStream.Close();
                        streamReader.Close();
                    }
                }
            }
            else
            {
                FileStatus("No File Selected", Color.Red);
            }
        }
    }
}
