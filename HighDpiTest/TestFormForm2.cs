using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HighDpiTest
{
    public partial class TestFormForm2 : Form
    {
        public TestFormForm2()
        {
            InitializeComponent();
        }

        private void TestFormForm2_Load(object sender, EventArgs e)
        {
            this.deviceDPILabel.Text = $"Device DPI: {this.DeviceDpi} Font: {this.Font.Name} Size: {this.Font.Size}";

        }
    }
}
