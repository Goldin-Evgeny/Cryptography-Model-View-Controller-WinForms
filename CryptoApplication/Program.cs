using Contracts;
using DefaultCryptoBLL.Cryptography.Model;
using System;
using System.Windows.Forms;

namespace CryptoApplication
{
    /// <summary>
    /// Cryptography main proccess.
    /// </summary>
    class Program
    {
        #region Static methods

        [STAThread]
        static void Main(string[] args)
        {
            Run();
        }

        /// <summary>
        /// Begins the user interaction mechanism.
        /// </summary>
        private static void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);//Mother fucker according to MSDN must be called
                                                                 //before the first form is constructed
            MainForm mainForm = new MainForm();//View
            Application.Run(mainForm);
        }

        #endregion
    }
}
