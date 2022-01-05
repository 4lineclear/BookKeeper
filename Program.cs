using System;
using System.Windows.Forms;
using BookKeeper.Model.Repositories;
using BookKeeper.Presenters;

namespace BookKeeper
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
            var repository = new UserRepository(Application.StartupPath);
            var view = new MainForm();

            var presenter = new UserPresenter(repository,view);

            Application.Run(view);
        }
    }
}
