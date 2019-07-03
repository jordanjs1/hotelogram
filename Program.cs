using System;
using System.Windows.Forms;

namespace Hotelogram
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Database.LoadUsers();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DLogin());
            //Database.SaveRDFDatabaseToFileSystem();
        }
    }
}

//PROGRAM DESIGN LIST
//Bugs
//  [ ] T.C. ID can be negative.
//  [ ] T.C. ID text box in dAddGuest (Add or Edit Guest) form.
//  