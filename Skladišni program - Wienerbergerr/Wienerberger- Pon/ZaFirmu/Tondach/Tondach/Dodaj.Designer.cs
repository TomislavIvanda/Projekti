namespace Tondach
{
    partial class Dodaj
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.DodajNovi = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.stanjeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.stanjeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.stanjeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stanjeBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.stanjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanjeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanjeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanjeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanjeBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAZIV  ARTIKLA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "DODAJ NA SKLADIŠTE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "UZMI SKLADIŠTA";
            // 
            // stanjeBindingSource
            // 
            this.stanjeBindingSource.DataMember = "Stanje";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 692);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 107);
            this.button1.TabIndex = 7;
            this.button1.Text = "SPREMI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Spremi);
            // 
            // DodajNovi
            // 
            this.DodajNovi.Location = new System.Drawing.Point(102, 692);
            this.DodajNovi.Name = "DodajNovi";
            this.DodajNovi.Size = new System.Drawing.Size(215, 107);
            this.DodajNovi.TabIndex = 8;
            this.DodajNovi.Text = "DODAJ NOVI ";
            this.DodajNovi.UseVisualStyleBackColor = true;
            this.DodajNovi.Click += new System.EventHandler(this.DodajNoviP);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(959, 692);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 107);
            this.button3.TabIndex = 9;
            this.button3.Text = "IZLAZ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // stanjeBindingSource3
            // 
            this.stanjeBindingSource3.DataMember = "Stanje";
            // 
            // stanjeBindingSource2
            // 
            this.stanjeBindingSource2.DataMember = "Stanje";
            // 
            // stanjeBindingSource1
            // 
            this.stanjeBindingSource1.DataMember = "Stanje";
            // 
            // stanjeBindingSource4
            // 
            this.stanjeBindingSource4.DataMember = "Stanje";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(215, 255);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(680, 692);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 107);
            this.button2.TabIndex = 11;
            this.button2.Text = "OBRISI ARTIKL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(215, 190);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(162, 24);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "NAZIV  SKLADIŠTA";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(257, 317);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 14;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(257, 389);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 15;
            // 
            // Dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1882, 1033);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DodajNovi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Dodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj";
            ((System.ComponentModel.ISupportInitialize)(this.stanjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanjeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanjeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanjeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanjeBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DodajNovi;
        private System.Windows.Forms.Button button3;
      
        private System.Windows.Forms.BindingSource stanjeBindingSource;
       
        private System.Windows.Forms.BindingSource stanjeBindingSource1;
      
        private System.Windows.Forms.BindingSource stanjeBindingSource2;
        
      
        private System.Windows.Forms.BindingSource stanjeBindingSource3;
        
        private System.Windows.Forms.BindingSource stanjeBindingSource4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}