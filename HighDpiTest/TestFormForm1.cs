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
    public partial class TestFormForm1: Form //: RadForm
    {
        public TestFormForm1()
        {
            InitializeComponent();
        }

        private void TestFormForm1_Load(object sender, EventArgs e)
        {
            this.deviceDPILabel.Text = $"Device DPI: {this.DeviceDpi} Font: {this.Font.Name} Size: {this.Font.Size}";
        }
    }
}
