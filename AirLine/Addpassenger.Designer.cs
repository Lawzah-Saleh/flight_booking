namespace AirLine
{
    partial class Addpassenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addpassenger));
            this.nationaltycb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passaddress = new System.Windows.Forms.TextBox();
            this.passporttd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gendercb = new System.Windows.Forms.ComboBox();
            this.phonetb = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nationaltycb
            // 
            this.nationaltycb.FormattingEnabled = true;
            this.nationaltycb.Items.AddRange(new object[] {
            "YEMEN",
            "AMERICA",
            "QATAR",
            "CANADA",
            "CHINA",
            "KORIA"});
            this.nationaltycb.Location = new System.Drawing.Point(252, 390);
            this.nationaltycb.Name = "nationaltycb";
            this.nationaltycb.Size = new System.Drawing.Size(248, 24);
            this.nationaltycb.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Farsi Simple Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(21, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 43);
            this.label6.TabIndex = 23;
            this.label6.Text = "passport Num";
            // 
            // passname
            // 
            this.passname.Location = new System.Drawing.Point(256, 199);
            this.passname.Name = "passname";
            this.passname.Size = new System.Drawing.Size(244, 22);
            this.passname.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Farsi Simple Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(21, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 43);
            this.label5.TabIndex = 21;
            this.label5.Text = "Passenger Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Farsi Simple Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(21, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 43);
            this.label4.TabIndex = 20;
            this.label4.Text = "passport Address";
            // 
            // passid
            // 
            this.passid.Location = new System.Drawing.Point(256, 147);
            this.passid.Name = "passid";
            this.passid.Size = new System.Drawing.Size(244, 22);
            this.passid.TabIndex = 19;
            this.passid.TextChanged += new System.EventHandler(this.passid_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Farsi Simple Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(21, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 43);
            this.label3.TabIndex = 18;
            this.label3.Text = "passenger id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(301, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Record Passenger";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(320, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "AirLine system";
            // 
            // passaddress
            // 
            this.passaddress.Location = new System.Drawing.Point(252, 299);
            this.passaddress.Name = "passaddress";
            this.passaddress.Size = new System.Drawing.Size(248, 22);
            this.passaddress.TabIndex = 27;
            // 
            // passporttd
            // 
            this.passporttd.Location = new System.Drawing.Point(252, 250);
            this.passporttd.Name = "passporttd";
            this.passporttd.Size = new System.Drawing.Size(248, 22);
            this.passporttd.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Farsi Simple Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(21, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 43);
            this.label7.TabIndex = 29;
            this.label7.Text = "Nationalty";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Farsi Simple Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(21, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 43);
            this.label8.TabIndex = 30;
            this.label8.Text = "Gender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Farsi Simple Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(21, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 43);
            this.label9.TabIndex = 31;
            this.label9.Text = "Phone";
            // 
            // gendercb
            // 
            this.gendercb.FormattingEnabled = true;
            this.gendercb.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.gendercb.Location = new System.Drawing.Point(252, 456);
            this.gendercb.Name = "gendercb";
            this.gendercb.Size = new System.Drawing.Size(248, 24);
            this.gendercb.TabIndex = 32;
            // 
            // phonetb
            // 
            this.phonetb.Location = new System.Drawing.Point(252, 347);
            this.phonetb.Name = "phonetb";
            this.phonetb.Size = new System.Drawing.Size(248, 22);
            this.phonetb.TabIndex = 33;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkCyan;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(365, 546);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 44);
            this.button4.TabIndex = 36;
            this.button4.Text = "reset";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(196, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 44);
            this.button1.TabIndex = 35;
            this.button1.Text = "record";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(898, -1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 32);
            this.label10.TabIndex = 37;
            this.label10.Text = "x";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(520, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(861, -2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 32);
            this.label11.TabIndex = 39;
            this.label11.Text = "x";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(326, 616);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 44);
            this.button2.TabIndex = 40;
            this.button2.Text = "view passenger";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkCyan;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(532, 546);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 44);
            this.button3.TabIndex = 41;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Addpassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 687);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phonetb);
            this.Controls.Add(this.gendercb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.passporttd);
            this.Controls.Add(this.passaddress);
            this.Controls.Add(this.nationaltycb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Addpassenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Addpassengers";
            this.Load += new System.EventHandler(this.Addpassenger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox nationaltycb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passaddress;
        private System.Windows.Forms.TextBox passporttd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox gendercb;
        private System.Windows.Forms.TextBox phonetb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}