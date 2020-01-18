namespace Main

{
    partial class Tjedna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tjedna));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.natrag = new System.Windows.Forms.Button();
            this.textbox10 = new System.Windows.Forms.Button();
            this.Izlaz_text12 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(44, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 79);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tjedna Palačinka";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxx);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(44, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 295);
            this.panel2.TabIndex = 1;
            // 
            // textBoxx
            // 
            this.textBoxx.Location = new System.Drawing.Point(201, 252);
            this.textBoxx.Name = "textBoxx";
            this.textBoxx.Size = new System.Drawing.Size(51, 22);
            this.textBoxx.TabIndex = 32;
            this.textBoxx.Click += new System.EventHandler(this.Nastavi_Tjedna);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(497, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "15 Kn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "i preljevom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Američka palačinka sa bananama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unesi količinu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(212, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // natrag
            // 
            this.natrag.BackColor = System.Drawing.Color.SandyBrown;
            this.natrag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.natrag.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.natrag.Location = new System.Drawing.Point(44, 444);
            this.natrag.Name = "natrag";
            this.natrag.Size = new System.Drawing.Size(150, 65);
            this.natrag.TabIndex = 4;
            this.natrag.Text = "Natrag";
            this.natrag.UseVisualStyleBackColor = false;
            this.natrag.Click += new System.EventHandler(this.Natrag_Click);
            // 
            // textbox10
            // 
            this.textbox10.BackColor = System.Drawing.Color.SandyBrown;
            this.textbox10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox10.Location = new System.Drawing.Point(325, 444);
            this.textbox10.Name = "textbox10";
            this.textbox10.Size = new System.Drawing.Size(150, 65);
            this.textbox10.TabIndex = 7;
            this.textbox10.Text = "Nastavi";
            this.textbox10.UseVisualStyleBackColor = false;
            this.textbox10.Click += new System.EventHandler(this.Nastavi_Tjedna);
            // 
            // Izlaz_text12
            // 
            this.Izlaz_text12.BackColor = System.Drawing.Color.SandyBrown;
            this.Izlaz_text12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Izlaz_text12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Izlaz_text12.Location = new System.Drawing.Point(597, 444);
            this.Izlaz_text12.Name = "Izlaz_text12";
            this.Izlaz_text12.Size = new System.Drawing.Size(150, 65);
            this.Izlaz_text12.TabIndex = 8;
            this.Izlaz_text12.Text = "Izlaz";
            this.Izlaz_text12.UseVisualStyleBackColor = false;
            this.Izlaz_text12.Click += new System.EventHandler(this.Izlaz_Click);
            // 
            // Tjedna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.Izlaz_text12);
            this.Controls.Add(this.textbox10);
            this.Controls.Add(this.natrag);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tjedna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tjedna ";
            this.Load += new System.EventHandler(this.Tjedna_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button natrag;
        private System.Windows.Forms.Button textbox10;
        private System.Windows.Forms.Button Izlaz_text12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxx;
    }
}