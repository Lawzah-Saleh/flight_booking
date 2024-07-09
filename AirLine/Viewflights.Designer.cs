namespace AirLine
{
    partial class Viewflights
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fdate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.fdestcb = new System.Windows.Forms.ComboBox();
            this.sourcecb = new System.Windows.Forms.ComboBox();
            this.dstcb = new System.Windows.Forms.Label();
            this.seatnum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fcodeTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flightsDGV = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(251, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "View scheduled flight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "AirLine system";
            // 
            // fdate
            // 
            this.fdate.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdate.Location = new System.Drawing.Point(189, 188);
            this.fdate.Name = "fdate";
            this.fdate.Size = new System.Drawing.Size(219, 22);
            this.fdate.TabIndex = 30;
            this.fdate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Farsi Simple Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 43);
            this.label7.TabIndex = 29;
            this.label7.Text = "TakeofDate";
            // 
            // fdestcb
            // 
            this.fdestcb.FormattingEnabled = true;
            this.fdestcb.Items.AddRange(new object[] {
            "Sana\'a",
            "Dubai",
            "London",
            "Madrid",
            "Beijing",
            "Dohah"});
            this.fdestcb.Location = new System.Drawing.Point(581, 190);
            this.fdestcb.Name = "fdestcb";
            this.fdestcb.Size = new System.Drawing.Size(237, 24);
            this.fdestcb.TabIndex = 28;
            // 
            // sourcecb
            // 
            this.sourcecb.FormattingEnabled = true;
            this.sourcecb.Items.AddRange(new object[] {
            "Sana\'a",
            "Dubai",
            "London",
            "Madrid",
            "Beijing",
            "Dohah"});
            this.sourcecb.Location = new System.Drawing.Point(574, 132);
            this.sourcecb.Name = "sourcecb";
            this.sourcecb.Size = new System.Drawing.Size(237, 24);
            this.sourcecb.TabIndex = 27;
            // 
            // dstcb
            // 
            this.dstcb.AutoSize = true;
            this.dstcb.Font = new System.Drawing.Font("Farsi Simple Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dstcb.ForeColor = System.Drawing.Color.Black;
            this.dstcb.Location = new System.Drawing.Point(417, 182);
            this.dstcb.Name = "dstcb";
            this.dstcb.Size = new System.Drawing.Size(158, 43);
            this.dstcb.TabIndex = 26;
            this.dstcb.Text = "Destination";
            this.dstcb.Click += new System.EventHandler(this.label6_Click);
            // 
            // seatnum
            // 
            this.seatnum.Location = new System.Drawing.Point(198, 236);
            this.seatnum.Name = "seatnum";
            this.seatnum.Size = new System.Drawing.Size(210, 22);
            this.seatnum.TabIndex = 25;
            this.seatnum.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Farsi Simple Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(422, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 43);
            this.label5.TabIndex = 24;
            this.label5.Text = "Source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Farsi Simple Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 43);
            this.label4.TabIndex = 23;
            this.label4.Text = "Num of Seats";
            // 
            // fcodeTb
            // 
            this.fcodeTb.Location = new System.Drawing.Point(189, 134);
            this.fcodeTb.Name = "fcodeTb";
            this.fcodeTb.Size = new System.Drawing.Size(219, 22);
            this.fcodeTb.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Farsi Simple Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 43);
            this.label3.TabIndex = 21;
            this.label3.Text = "Flight Code";
            // 
            // flightsDGV
            // 
            this.flightsDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flightsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightsDGV.Location = new System.Drawing.Point(20, 345);
            this.flightsDGV.Name = "flightsDGV";
            this.flightsDGV.RowTemplate.Height = 24;
            this.flightsDGV.Size = new System.Drawing.Size(772, 288);
            this.flightsDGV.TabIndex = 31;
            this.flightsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.flightsDGV_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(407, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 44);
            this.button2.TabIndex = 33;
            this.button2.Text = "reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(111, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 44);
            this.button1.TabIndex = 32;
            this.button1.Text = "update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(574, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 46);
            this.button3.TabIndex = 35;
            this.button3.Text = "back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(257, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 44);
            this.button4.TabIndex = 34;
            this.button4.Text = "delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Viewflights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 645);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flightsDGV);
            this.Controls.Add(this.fdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fdestcb);
            this.Controls.Add(this.sourcecb);
            this.Controls.Add(this.dstcb);
            this.Controls.Add(this.seatnum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fcodeTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Viewflights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viewflights";
            this.Load += new System.EventHandler(this.Viewflights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox fdestcb;
        private System.Windows.Forms.ComboBox sourcecb;
        private System.Windows.Forms.Label dstcb;
        private System.Windows.Forms.TextBox seatnum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fcodeTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView flightsDGV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}