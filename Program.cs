using System.Globalization;

namespace Coursework
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainPage());
            //LoginPage loginForm = new LoginPage();
            //if (loginForm.ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new MainPage());
            //}
        }
    }
}