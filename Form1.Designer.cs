namespace Bluetooth_Connect
{
    partial class Form1
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
            this.Connect = new System.Windows.Forms.Button();
            this.AvailableDevices = new System.Windows.Forms.ListBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(12, 118);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // AvailableDevices
            // 
            this.AvailableDevices.FormattingEnabled = true;
            this.AvailableDevices.Location = new System.Drawing.Point(12, 12);
            this.AvailableDevices.Name = "AvailableDevices";
            this.AvailableDevices.Size = new System.Drawing.Size(120, 95);
            this.AvailableDevices.TabIndex = 1;
            this.AvailableDevices.SelectedIndexChanged += new System.EventHandler(this.AvailableDevices_SelectedIndexChanged);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(105, 119);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 2;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.AvailableDevices);
            this.Controls.Add(this.Connect);
            this.Name = "Form1";
            this.Text = "Bluetooth Connect";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.ListBox AvailableDevices;
        private System.Windows.Forms.Button Refresh;
    }
}

