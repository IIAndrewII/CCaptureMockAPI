using System;
using System.Configuration;
using System.Windows.Forms;

namespace CCaptureWinForm
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var _ = ConfigurationManager.AppSettings;
            Application.Run(new MainForm());
        }
    }
}