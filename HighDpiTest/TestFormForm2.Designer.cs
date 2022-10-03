namespace HighDpiTest
{
    partial class TestFormForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.deviceDPILabel = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceDPILabel)).BeginInit();
            this.SuspendLayout();
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(301, 78);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(437, 20);
            this.radTextBox1.TabIndex = 0;
            this.radTextBox1.Text = "RadTextBox";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(301, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(437, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Standard Winform Textbox";
            // 
            // deviceDPILabel
            // 
            this.deviceDPILabel.Location = new System.Drawing.Point(80, 288);
            this.deviceDPILabel.Name = "deviceDPILabel";
            this.deviceDPILabel.Size = new System.Drawing.Size(49, 18);
            this.deviceDPILabel.TabIndex = 2;
            this.deviceDPILabel.Text = "dpiLabel";
            // 
            // TestFormForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deviceDPILabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radTextBox1);
            this.Name = "TestFormForm2";
            this.Text = "TestFormForm2";
            this.Load += new System.EventHandler(this.TestFormForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceDPILabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private Telerik.WinControls.UI.RadLabel deviceDPILabel;
    }
}