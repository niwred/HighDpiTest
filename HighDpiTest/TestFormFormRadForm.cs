using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace HighDpiTest
{
    public partial class TestFormRadForm1: RadForm
    {
        public TestFormRadForm1()
        {
            InitializeComponent();
        }

        private void TestFormRadForm1_Load(object sender, EventArgs e)
        {
            this.deviceDPILabel.Text = $"Device DPI: {this.DeviceDpi} Font: {this.Font.Name} Size: {this.Font.Size}";

        }
    }
}
