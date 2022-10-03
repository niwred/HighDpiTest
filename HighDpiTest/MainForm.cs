using HighDpiTest.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinForms.Documents.FormatProviders.OpenXml.Docx;

namespace HighDpiTest
{
    public partial class MainForm : RadForm
    {
        public MainForm()
        {



            InitializeComponent();
            this.radDropDownList1.Items.Add("Segoe UI, 8.25pt");
            this.radDropDownList1.Items.Add("Segoe UI, 9pt");
            this.radDropDownList1.Items.Add("MessageBoxFont");

            /*

            if (Settings1.Default.SetDefaultFont)
            {
                if (Settings1.Default.FontIndex == 0)
                {
                    this.Font = new Font(new FontFamily("Segoe UI"), 8.25f);
                }

                if (Settings1.Default.FontIndex == 1)
                {
                    this.Font = new Font(new FontFamily("Segoe UI"), 9f);
                }

                this.PerformAutoScale();
            }*/
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            TestFormForm1 dlg = new();
            dlg.ShowDialog(this);
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            TestFormForm2 dlg = new();
            dlg.ShowDialog(this);
        }


        private void radButton3_Click(object sender, EventArgs e)
        {
            Settings1.Default.EnableRadAutoScale = this.enableRadAutoScaleCheckBox.Checked;
            Settings1.Default.HighDPI = this.enableHighDpiCheckBox.Checked;
            Settings1.Default.SetDefaultFont = this.defaultFontCheckBox.Checked;
            Settings1.Default.FontIndex = this.radDropDownList1.SelectedIndex;

            // Save settings
            Settings1.Default.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.enableHighDpiCheckBox.Checked = Settings1.Default.HighDPI;
            this.enableRadAutoScaleCheckBox.Checked = Settings1.Default.EnableRadAutoScale;
            this.defaultFontCheckBox.Checked = Settings1.Default.SetDefaultFont;
            this.deviceDpiLabel.Text = $"Device DPI: {this.DeviceDpi} Font: {this.Font.Name} Size: {this.Font.Size}";
            this.radDropDownList1.SelectedIndex = Settings1.Default.FontIndex;

        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            TestFormRadForm1 dlg = new();
            dlg.ShowDialog(this);
        }

    }
}
