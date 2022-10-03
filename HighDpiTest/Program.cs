using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HighDpiTest.Properties;
using Telerik.WinControls;

namespace HighDpiTest
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            if (Settings1.Default.HighDPI)
            {
                if (!Application.SetHighDpiMode(HighDpiMode.PerMonitorV2))
                {
                    MessageBox.Show("Could not set high dpi mode");
                }
            }

            // NB: Application.SetDefaultFont seems to be ignored by RadForm 2022 R3 SP1
            // on RadForm it's always Segoe UI 8.25

            if (Settings1.Default.SetDefaultFont)
            {
                switch (Settings1.Default.FontIndex)
                {
                    case 0:
                        Application.SetDefaultFont(new Font(new FontFamily("Segoe UI"), 8.25f));
                        break;

                    case 1:
                        Application.SetDefaultFont(new Font(new FontFamily("Segoe UI"), 9f));
                        break;
                    case 2:
                        Application.SetDefaultFont(System.Drawing.SystemFonts.MessageBoxFont);
                        break;

                    default:
                        MessageBox.Show($"Invalid Font Index: {Settings1.Default.FontIndex}");
                        break;
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            if (!Settings1.Default.EnableRadAutoScale)
            {
                RadControl.EnableRadAutoScale = false;
            }

            Application.Run(new MainForm());
        }
    }
}
