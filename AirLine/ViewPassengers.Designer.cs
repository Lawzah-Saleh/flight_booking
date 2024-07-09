namespace AirLine
{
    partial class ViewPassengers
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
            this.PphoneTb = new System.Windows.Forms.TextBox();
            this.gendcb = new System.Windows.Forms.ComboBox();
            this.Pphone = new System.Windows.Forms.Label();
            this.Pgend = new System.Windows.Forms.Label();
            this.PnatiTb = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.PaddressTb = new System.Windows.Forms.TextBox();
            this.Pnatcb = new System.Windows.Forms.ComboBox();
            this.PpassTb = new System.Windows.Forms.Label();
            this.PnameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PaddresTb = new System.Windows.Forms.Label();
            this.pidTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.passengerDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.passengerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // PphoneTb
            // 
            this.PphoneTb.Location = new System.Drawing.Point(727, 210);
            this.PphoneTb.Name = "PphoneTb";
            this.PphoneTb.Size = new System.Drawing.Size(214, 22);
            this.PphoneTb.TabIndex = 47;
            // 
            // gendcb
            // 
            this.gendcb.FormattingEnabled = true;
            this.gendcb.Items.AddRange(new object[] {
            "Famale",
            "Male"});
            this.gendcb.Location = new System.Drawing.Point(236, 271);
            this.gendcb.Name = "gendcb";
            this.gendcb.Size = new System.Drawing.Size(219, 24);
            this.gendcb.TabIndex = 46;
            // 
            // Pphone
            // 
            this.Pphone.AutoSize = true;
            this.Pphone.Font = new System.Drawing.Font("Farsi Simple Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Pphone.ForeColor = System.Drawing.Color.DarkCyan;
            this.Pphone.Location = new System.Drawing.Point(467, 210);
            this.Pphone.Name = "Pphone";
            this.Pphone.Size = new System.Drawing.Size(97, 43);
            this.Pphone.TabIndex = 45;
            this.Pphone.Text = "Phone";
            // 
            // Pgend
            // 
            this.Pgend.AutoSize = true;
            this.Pgend.Font = new System.Drawing.Font("Farsi Simple Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Pgend.ForeColor = System.Drawing.Color.DarkCyan;
            this.Pgend.Location = new System.Drawing.Point(3, 271);
            this.Pgend.Name = "Pgend";
            this.Pgend.Size = new System.Drawing.Size(110, 43);
            this.Pgend.TabIndex = 44;
            this.Pgend.Text = "Gender";
            // 
            // PnatiTb
            // 
            this.PnatiTb.AutoSize = true;
            this.PnatiTb.Font = new System.Drawing.Font("Farsi Simple Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PnatiTb.ForeColor = System.Drawing.Color.DarkCyan;
            this.PnatiTb.Location = new System.Drawing.Point(3, 218);
            this.PnatiTb.Name = "PnatiTb";
            this.PnatiTb.Size = new System.Drawing.Size(143, 43);
            this.PnatiTb.TabIndex = 43;
            this.PnatiTb.Text = "Nationalty";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(727, 112);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(214, 22);
            this.textBox4.TabIndex = 42;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // PaddressTb
            // 
            this.PaddressTb.Location = new System.Drawing.Point(727, 163);
            this.PaddressTb.Name = "PaddressTb";
            this.PaddressTb.Size = new System.Drawing.Size(214, 22);
            this.PaddressTb.TabIndex = 41;
            // 
            // Pnatcb
            // 
            this.Pnatcb.FormattingEnabled = true;
            this.Pnatcb.Items.AddRange(new object[] {
            "YEMEN",
            "CANADA",
            "CHINA",
            "AMERICA",
            "KORIA",
            "TERKEY",
            "QATAR"});
            this.Pnatcb.Location = new System.Drawing.Point(236, 218);
            this.Pnatcb.Name = "Pnatcb";
            this.Pnatcb.Size = new System.Drawing.Size(219, 24);
            this.Pnatcb.TabIndex = 40;
            this.Pnatcb.SelectedIndexChanged += new System.EventHandler(this.natcb_SelectedIndexChanged);
            // 
            // PpassTb
            // 
            this.PpassTb.AutoSize = true;
            this.PpassTb.Font = new System.Drawing.Font("Farsi Simple Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PpassTb.ForeColor = System.Drawing.Color.DarkCyan;
            this.PpassTb.Location = new System.Drawing.Point(467, 112);
            this.PpassTb.Name = "PpassTb";
            this.PpassTb.Size = new System.Drawing.Size(189, 43);
            this.PpassTb.TabIndex = 39;
            this.PpassTb.Text = "passport Num";
            this.PpassTb.Click += new System.EventHandler(this.label6_Click);
            // 
            // PnameTb
            // 
            this.PnameTb.Location = new System.Drawing.Point(236, 166);
            this.PnameTb.Name = "PnameTb";
            this.PnameTb.Size = new System.Drawing.Size(215, 22);
            this.PnameTb.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Farsi Simple Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(3, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 43);
            this.label5.TabIndex = 37;
            this.label5.Text = "Passenger Name";
            // 
            // PaddresTb
            // 
            this.PaddresTb.AutoSize = true;
            this.PaddresTb.Font = new System.Drawing.Font("Farsi Simple Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PaddresTb.ForeColor = System.Drawing.Color.DarkCyan;
            this.PaddresTb.Location = new System.Drawing.Point(467, 155);
            this.PaddresTb.Name = "PaddresTb";
            this.PaddresTb.Size = new System.Drawing.Size(254, 43);
            this.PaddresTb.TabIndex = 36;
            this.PaddresTb.Text = "passenger Address";
            // 
            // pidTb
            // 
            this.pidTb.Location = new System.Drawing.Point(236, 112);
            this.pidTb.Name = "pidTb";
            this.pidTb.Size = new System.Drawing.Size(215, 22);
            this.pidTb.TabIndex = 35;
            this.pidTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Farsi Simple Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(3, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 43);
            this.label3.TabIndex = 34;
            this.label3.Text = "passenger id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(302, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 32);
            this.label2.TabIndex = 49;
            this.label2.Text = "View Passenger";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 48;
            this.label1.Text = "AirLine system";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(625, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 46);
            this.button3.TabIndex = 54;
            this.button3.Text = "back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(308, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 44);
            this.button4.TabIndex = 53;
            this.button4.Text = "delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(462, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 44);
            this.button2.TabIndex = 52;
            this.button2.Text = "reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(144, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 44);
            this.button1.TabIndex = 51;
            this.button1.Text = "update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passengerDGV
            // 
            this.passengerDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passengerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passengerDGV.Location = new System.Drawing.Point(28, 397);
            this.passengerDGV.Name = "passengerDGV";
            this.passengerDGV.RowTemplate.Height = 24;
            this.passengerDGV.Size = new System.Drawing.Size(895, 278);
            this.passengerDGV.TabIndex = 50;
            this.passengerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ViewPassengers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 701);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passengerDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PphoneTb);
            this.Controls.Add(this.gendcb);
            this.Controls.Add(this.Pphone);
            this.Controls.Add(this.Pgend);
            this.Controls.Add(this.PnatiTb);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.PaddressTb);
            this.Controls.Add(this.Pnatcb);
            this.Controls.Add(this.PpassTb);
            this.Controls.Add(this.PnameTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PaddresTb);
            this.Controls.Add(this.pidTb);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPassengers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPassengers";
            this.Load += new System.EventHandler(this.ViewPassengers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passengerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PphoneTb;
        private System.Windows.Forms.ComboBox gendcb;
        private System.Windows.Forms.Label Pphone;
        private System.Windows.Forms.Label Pgend;
        private System.Windows.Forms.Label PnatiTb;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox PaddressTb;
        private System.Windows.Forms.ComboBox Pnatcb;
        private System.Windows.Forms.Label PpassTb;
        private System.Windows.Forms.TextBox PnameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PaddresTb;
        private System.Windows.Forms.TextBox pidTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView passengerDGV;
    }
}