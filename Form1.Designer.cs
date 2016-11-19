namespace Dev_School
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGetPublicIP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxPublicIP = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnShuddarun = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 48);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "It\'s Dangerous to go alone";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGetPublicIP
            // 
            this.btnGetPublicIP.Location = new System.Drawing.Point(10, 16);
            this.btnGetPublicIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetPublicIP.Name = "btnGetPublicIP";
            this.btnGetPublicIP.Size = new System.Drawing.Size(194, 29);
            this.btnGetPublicIP.TabIndex = 2;
            this.btnGetPublicIP.Text = "Get Public IP";
            this.btnGetPublicIP.UseVisualStyleBackColor = true;
            this.btnGetPublicIP.Click += new System.EventHandler(this.btnGetPublicIP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxPublicIP);
            this.groupBox1.Controls.Add(this.btnGetPublicIP);
            this.groupBox1.Location = new System.Drawing.Point(12, 179);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(213, 216);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // tbxPublicIP
            // 
            this.tbxPublicIP.Location = new System.Drawing.Point(10, 58);
            this.tbxPublicIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxPublicIP.Multiline = true;
            this.tbxPublicIP.Name = "tbxPublicIP";
            this.tbxPublicIP.Size = new System.Drawing.Size(196, 149);
            this.tbxPublicIP.TabIndex = 3;
            this.tbxPublicIP.UseWaitCursor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 85);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "kerst";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnShuddarun
            // 
            this.btnShuddarun.Location = new System.Drawing.Point(12, 123);
            this.btnShuddarun.Name = "btnShuddarun";
            this.btnShuddarun.Size = new System.Drawing.Size(215, 28);
            this.btnShuddarun.TabIndex = 5;
            this.btnShuddarun.Text = "Shuddarun";
            this.btnShuddarun.UseVisualStyleBackColor = true;
            this.btnShuddarun.Click += new System.EventHandler(this.btnShuddarun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 385);
            this.Controls.Add(this.btnShuddarun);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGetPublicIP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxPublicIP;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnShuddarun;
    }
}

