namespace Affine_cipher
{
    partial class Affine
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.combo_k1 = new System.Windows.Forms.ComboBox();
            this.combo_k2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ctext_1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.ptext_2 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.combo_k2_2 = new System.Windows.Forms.ComboBox();
            this.combo_k1_2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.ptext_1 = new System.Windows.Forms.RichTextBox();
            this.ctext_2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.msg_1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plain Text";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(311, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.msg_1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ptext_1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ctext_1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.combo_k2);
            this.panel1.Controls.Add(this.combo_k1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 328);
            this.panel1.TabIndex = 6;
            // 
            // combo_k1
            // 
            this.combo_k1.FormattingEnabled = true;
            this.combo_k1.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "9",
            "11",
            "13",
            "17",
            "19",
            "23",
            "21",
            "25"});
            this.combo_k1.Location = new System.Drawing.Point(83, 163);
            this.combo_k1.Name = "combo_k1";
            this.combo_k1.Size = new System.Drawing.Size(52, 21);
            this.combo_k1.TabIndex = 5;
            // 
            // combo_k2
            // 
            this.combo_k2.FormattingEnabled = true;
            this.combo_k2.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "9",
            "11",
            "13",
            "17",
            "19",
            "23",
            "21",
            "25"});
            this.combo_k2.Location = new System.Drawing.Point(231, 163);
            this.combo_k2.Name = "combo_k2";
            this.combo_k2.Size = new System.Drawing.Size(52, 21);
            this.combo_k2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Key 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Key 2";
            // 
            // ctext_1
            // 
            this.ctext_1.Location = new System.Drawing.Point(83, 206);
            this.ctext_1.Name = "ctext_1";
            this.ctext_1.Size = new System.Drawing.Size(200, 103);
            this.ctext_1.TabIndex = 9;
            this.ctext_1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cipher Text";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.ctext_2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.ptext_2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.combo_k2_2);
            this.panel2.Controls.Add(this.combo_k1_2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(432, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 328);
            this.panel2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cipher Text";
            // 
            // ptext_2
            // 
            this.ptext_2.Location = new System.Drawing.Point(83, 206);
            this.ptext_2.Name = "ptext_2";
            this.ptext_2.Size = new System.Drawing.Size(200, 103);
            this.ptext_2.TabIndex = 9;
            this.ptext_2.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Key 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Key 1";
            // 
            // combo_k2_2
            // 
            this.combo_k2_2.FormattingEnabled = true;
            this.combo_k2_2.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "9",
            "11",
            "13",
            "17",
            "19",
            "23",
            "21",
            "25"});
            this.combo_k2_2.Location = new System.Drawing.Point(231, 163);
            this.combo_k2_2.Name = "combo_k2_2";
            this.combo_k2_2.Size = new System.Drawing.Size(52, 21);
            this.combo_k2_2.TabIndex = 6;
            // 
            // combo_k1_2
            // 
            this.combo_k1_2.FormattingEnabled = true;
            this.combo_k1_2.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "9",
            "11",
            "13",
            "17",
            "19",
            "23",
            "21",
            "25"});
            this.combo_k1_2.Location = new System.Drawing.Point(83, 163);
            this.combo_k1_2.Name = "combo_k1_2";
            this.combo_k1_2.Size = new System.Drawing.Size(52, 21);
            this.combo_k1_2.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Plain Text";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(312, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "Decrypt";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ptext_1
            // 
            this.ptext_1.Location = new System.Drawing.Point(83, 29);
            this.ptext_1.Name = "ptext_1";
            this.ptext_1.Size = new System.Drawing.Size(200, 103);
            this.ptext_1.TabIndex = 11;
            this.ptext_1.Text = "";
            // 
            // ctext_2
            // 
            this.ctext_2.Location = new System.Drawing.Point(83, 29);
            this.ctext_2.Name = "ctext_2";
            this.ctext_2.Size = new System.Drawing.Size(200, 103);
            this.ctext_2.TabIndex = 11;
            this.ctext_2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Encrypt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(175, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Decrypt";
            // 
            // msg_1
            // 
            this.msg_1.AutoSize = true;
            this.msg_1.BackColor = System.Drawing.Color.LightGray;
            this.msg_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_1.ForeColor = System.Drawing.Color.Red;
            this.msg_1.Location = new System.Drawing.Point(80, 135);
            this.msg_1.Name = "msg_1";
            this.msg_1.Size = new System.Drawing.Size(0, 16);
            this.msg_1.TabIndex = 13;
            // 
            // Affine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 351);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Affine";
            this.Text = "Affine Cipher (Encrypt / Decrypt)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox ctext_1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_k2;
        private System.Windows.Forms.ComboBox combo_k1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox ptext_2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combo_k2_2;
        private System.Windows.Forms.ComboBox combo_k1_2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox ptext_1;
        private System.Windows.Forms.RichTextBox ctext_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label msg_1;
    }
}

