namespace AirLine
{
    partial class Cancellation
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
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TidCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CanId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CancellationDGV = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Cancdate = new System.Windows.Forms.DateTimePicker();
            this.FcodeTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CancellationDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Farsi Simple Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(513, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 43);
            this.label9.TabIndex = 84;
            this.label9.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Farsi Simple Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(92, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 43);
            this.label4.TabIndex = 79;
            this.label4.Text = "Flight Code";
            // 
            // TidCb
            // 
            this.TidCb.FormattingEnabled = true;
            this.TidCb.Location = new System.Drawing.Point(654, 132);
            this.TidCb.Name = "TidCb";
            this.TidCb.Size = new System.Drawing.Size(198, 24);
            this.TidCb.TabIndex = 78;
            this.TidCb.SelectedIndexChanged += new System.EventHandler(this.TidCb_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Farsi Simple Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(499, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 43);
            this.label5.TabIndex = 77;
            this.label5.Text = "Ticket id";
            // 
            // CanId
            // 
            this.CanId.Location = new System.Drawing.Point(257, 132);
            this.CanId.Name = "CanId";
            this.CanId.Size = new System.Drawing.Size(206, 22);
            this.CanId.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Farsi Simple Outline", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(98, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 43);
            this.label3.TabIndex = 75;
            this.label3.Text = "Cancel id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(343, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 32);
            this.label2.TabIndex = 74;
            this.label2.Text = "Ticket Cancellation";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(373, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 73;
            this.label1.Text = "AirLine system";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(357, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 29);
            this.label6.TabIndex = 91;
            this.label6.Text = "Cancellation list";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CancellationDGV
            // 
            this.CancellationDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancellationDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CancellationDGV.Location = new System.Drawing.Point(51, 352);
            this.CancellationDGV.Name = "CancellationDGV";
            this.CancellationDGV.RowTemplate.Height = 24;
            this.CancellationDGV.Size = new System.Drawing.Size(854, 325);
            this.CancellationDGV.TabIndex = 92;
            this.CancellationDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CancellationDGV_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(912, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 32);
            this.label12.TabIndex = 93;
            this.label12.Text = "x";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(418, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 46);
            this.button2.TabIndex = 96;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(567, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 46);
            this.button1.TabIndex = 95;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkCyan;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(270, 247);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 46);
            this.button3.TabIndex = 94;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Cancdate
            // 
            this.Cancdate.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancdate.Location = new System.Drawing.Point(654, 179);
            this.Cancdate.Name = "Cancdate";
            this.Cancdate.Size = new System.Drawing.Size(198, 22);
            this.Cancdate.TabIndex = 97;
            // 
            // FcodeTb
            // 
            this.FcodeTb.Location = new System.Drawing.Point(257, 187);
            this.FcodeTb.Name = "FcodeTb";
            this.FcodeTb.Size = new System.Drawing.Size(206, 22);
            this.FcodeTb.TabIndex = 98;
            // 
            // Cancellation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 706);
            this.Controls.Add(this.FcodeTb);
            this.Controls.Add(this.Cancdate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CancellationDGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TidCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CanId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cancellation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancellation";
            this.Load += new System.EventHandler(this.Cancellation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CancellationDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TidCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CanId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView CancellationDGV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker Cancdate;
        private System.Windows.Forms.TextBox FcodeTb;
    }
}