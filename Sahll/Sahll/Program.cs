using Sahll.JUI.Car;
using Sahll.JUI.Car.InfoForms;
using Sahll.JUI.Car.SubForms;
using Sahll.JUI.Customer.CustomerProduct;
using Sahll.JUI.PL;
using Sahll.JUI.Selling;
using Sahll.JUI.Store;
using Sahll.JUI.Treasury;
using Sahll.JUI.User;

namespace Sahll
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new DialogFRM("how are you", Color.FromArgb(83, 4, 128)));
            Application.Run(new Main());
        }
    }
}