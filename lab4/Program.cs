using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Ayub Ali
 * 2021-07-31
 * 
 * Lab 4 loading html files and checking if it has all of its closing tags
 * 
 * I, Ayub Ali, 000354446 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement. 
 * 
 * Resources used while building this application:
 * https://www.softwaretestinghelp.com/c-sharp/csharp-filestream-streamwriter-streamreader/
 * https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/working-with-linq
 * https://www.codecademy.com/learn/paths/build-web-apps-with-asp-net
 * https://www.codecademy.com/paths/build-web-apps-with-asp-net/tracks/build-web-apps-asp-net-intermediate-c-sharp/modules/learn-csharp-lists-and-linq/lessons/csharp-lists
 * https://stackoverflow.com/questions/49417959/c-sharp-pairing-html-tags-to-check-if-they-are-properly-balanced
 * https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog?view=net-5.0
 * 
 */
namespace lab4
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
