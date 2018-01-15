using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ljudi2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //DatabaseBroker databaseBroker = new DatabaseBroker();
            ////databaseBroker.Insert("maja", "h", 26);
            //List<Person> novalista = databaseBroker.SelectAll();
            //for (int i = 0; i < novalista.Count(); i++)
            //{
            //    Console.WriteLine("ID: " + novalista[i].Id + " First Name " + novalista[i].FirstName + "Last Name: " + novalista[i].LastName + " Age: " + novalista[i].Age);
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
