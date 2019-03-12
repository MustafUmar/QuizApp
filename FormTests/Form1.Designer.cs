namespace FormTests
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.firstpanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowitem1 = new System.Windows.Forms.Label();
            this.flowitem2 = new System.Windows.Forms.Label();
            this.flowitem3 = new System.Windows.Forms.Label();
            this.flowitem4 = new System.Windows.Forms.Label();
            this.flowitem5 = new System.Windows.Forms.Label();
            this.secondpanel = new System.Windows.Forms.Panel();
            this.secondlb = new System.Windows.Forms.Label();
            this.flowpane1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowpane2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowpane3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.firstpanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.secondpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.firstpanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 375);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 75);
            this.panel3.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(432, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "SwitchPane2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(284, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "SwitchPane1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstpanel
            // 
            this.firstpanel.BackColor = System.Drawing.Color.SkyBlue;
            this.firstpanel.Controls.Add(this.flowitem5);
            this.firstpanel.Controls.Add(this.flowitem4);
            this.firstpanel.Controls.Add(this.flowitem3);
            this.firstpanel.Controls.Add(this.flowitem2);
            this.firstpanel.Controls.Add(this.flowitem1);
            this.firstpanel.Controls.Add(this.flowLayoutPanel1);
            this.firstpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstpanel.Location = new System.Drawing.Point(0, 0);
            this.firstpanel.Name = "firstpanel";
            this.firstpanel.Size = new System.Drawing.Size(800, 450);
            this.firstpanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.flowpane1);
            this.flowLayoutPanel1.Controls.Add(this.flowpane2);
            this.flowLayoutPanel1.Controls.Add(this.flowpane3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(43, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(192, 185);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowitem1
            // 
            this.flowitem1.AutoSize = true;
            this.flowitem1.Location = new System.Drawing.Point(517, 90);
            this.flowitem1.Name = "flowitem1";
            this.flowitem1.Size = new System.Drawing.Size(274, 13);
            this.flowitem1.TabIndex = 0;
            this.flowitem1.Text = "Ano moshi moshi dsadasdasfsadsdasdasdadasdasdsada";
            // 
            // flowitem2
            // 
            this.flowitem2.AutoSize = true;
            this.flowitem2.Location = new System.Drawing.Point(517, 163);
            this.flowitem2.Name = "flowitem2";
            this.flowitem2.Size = new System.Drawing.Size(35, 13);
            this.flowitem2.TabIndex = 1;
            this.flowitem2.Text = "label1";
            // 
            // flowitem3
            // 
            this.flowitem3.AutoSize = true;
            this.flowitem3.Location = new System.Drawing.Point(604, 163);
            this.flowitem3.Name = "flowitem3";
            this.flowitem3.Size = new System.Drawing.Size(35, 13);
            this.flowitem3.TabIndex = 2;
            this.flowitem3.Text = "label1";
            // 
            // flowitem4
            // 
            this.flowitem4.AutoSize = true;
            this.flowitem4.Location = new System.Drawing.Point(517, 124);
            this.flowitem4.Name = "flowitem4";
            this.flowitem4.Size = new System.Drawing.Size(35, 13);
            this.flowitem4.TabIndex = 3;
            this.flowitem4.Text = "label1";
            // 
            // flowitem5
            // 
            this.flowitem5.AutoSize = true;
            this.flowitem5.Location = new System.Drawing.Point(604, 124);
            this.flowitem5.Name = "flowitem5";
            this.flowitem5.Size = new System.Drawing.Size(35, 13);
            this.flowitem5.TabIndex = 4;
            this.flowitem5.Text = "label1";
            // 
            // secondpanel
            // 
            this.secondpanel.BackColor = System.Drawing.Color.DarkKhaki;
            this.secondpanel.Controls.Add(this.secondlb);
            this.secondpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondpanel.Location = new System.Drawing.Point(371, 162);
            this.secondpanel.Name = "secondpanel";
            this.secondpanel.Size = new System.Drawing.Size(200, 100);
            this.secondpanel.TabIndex = 0;
            // 
            // secondlb
            // 
            this.secondlb.AutoSize = true;
            this.secondlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondlb.Location = new System.Drawing.Point(315, 165);
            this.secondlb.Name = "secondlb";
            this.secondlb.Size = new System.Drawing.Size(195, 33);
            this.secondlb.TabIndex = 1;
            this.secondlb.Text = "Second Panel";
            // 
            // flowpane1
            // 
            this.flowpane1.Location = new System.Drawing.Point(3, 3);
            this.flowpane1.Name = "flowpane1";
            this.flowpane1.Size = new System.Drawing.Size(142, 47);
            this.flowpane1.TabIndex = 0;
            // 
            // flowpane2
            // 
            this.flowpane2.Location = new System.Drawing.Point(3, 56);
            this.flowpane2.Name = "flowpane2";
            this.flowpane2.Size = new System.Drawing.Size(131, 47);
            this.flowpane2.TabIndex = 1;
            // 
            // flowpane3
            // 
            this.flowpane3.Location = new System.Drawing.Point(3, 109);
            this.flowpane3.Name = "flowpane3";
            this.flowpane3.Size = new System.Drawing.Size(31, 46);
            this.flowpane3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.firstpanel.ResumeLayout(false);
            this.firstpanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.secondpanel.ResumeLayout(false);
            this.secondpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel firstpanel;
        private System.Windows.Forms.Panel secondpanel;
        private System.Windows.Forms.Label secondlb;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label flowitem1;
        private System.Windows.Forms.Label flowitem2;
        private System.Windows.Forms.Label flowitem3;
        private System.Windows.Forms.Label flowitem4;
        private System.Windows.Forms.Label flowitem5;
        private System.Windows.Forms.FlowLayoutPanel flowpane1;
        private System.Windows.Forms.FlowLayoutPanel flowpane2;
        private System.Windows.Forms.FlowLayoutPanel flowpane3;
    }
}

