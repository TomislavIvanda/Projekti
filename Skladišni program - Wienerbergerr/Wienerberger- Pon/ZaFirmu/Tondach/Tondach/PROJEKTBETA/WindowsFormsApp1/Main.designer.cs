namespace Main
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MainNapravi = new System.Windows.Forms.Button();
            this.MainOdaberi = new System.Windows.Forms.Button();
            this.MainTjedna = new System.Windows.Forms.Button();
            this.MainIzlaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainNapravi
            // 
            this.MainNapravi.BackColor = System.Drawing.Color.Crimson;
            this.MainNapravi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainNapravi.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainNapravi.Location = new System.Drawing.Point(155, 92);
            this.MainNapravi.Name = "MainNapravi";
            this.MainNapravi.Size = new System.Drawing.Size(276, 107);
            this.MainNapravi.TabIndex = 0;
            this.MainNapravi.Text = "Napravi svoju palačinku";
            this.MainNapravi.UseVisualStyleBackColor = false;
            this.MainNapravi.Click += new System.EventHandler(this.MainNapravi_Click);
            // 
            // MainOdaberi
            // 
            this.MainOdaberi.BackColor = System.Drawing.Color.Crimson;
            this.MainOdaberi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainOdaberi.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainOdaberi.Location = new System.Drawing.Point(637, 92);
            this.MainOdaberi.Name = "MainOdaberi";
            this.MainOdaberi.Size = new System.Drawing.Size(275, 107);
            this.MainOdaberi.TabIndex = 1;
            this.MainOdaberi.Text = "Odaberi palačinku";
            this.MainOdaberi.UseVisualStyleBackColor = false;
            this.MainOdaberi.Click += new System.EventHandler(this.MainOdaberi_Click);
            // 
            // MainTjedna
            // 
            this.MainTjedna.BackColor = System.Drawing.Color.Crimson;
            this.MainTjedna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainTjedna.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTjedna.Location = new System.Drawing.Point(386, 256);
            this.MainTjedna.Name = "MainTjedna";
            this.MainTjedna.Size = new System.Drawing.Size(276, 107);
            this.MainTjedna.TabIndex = 2;
            this.MainTjedna.Text = "Odaberi tjednu palačinku";
            this.MainTjedna.UseVisualStyleBackColor = false;
            this.MainTjedna.Click += new System.EventHandler(this.MainTjedna_Click);
            // 
            // MainIzlaz
            // 
            this.MainIzlaz.BackColor = System.Drawing.Color.Crimson;
            this.MainIzlaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainIzlaz.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainIzlaz.Location = new System.Drawing.Point(414, 422);
            this.MainIzlaz.Name = "MainIzlaz";
            this.MainIzlaz.Size = new System.Drawing.Size(221, 57);
            this.MainIzlaz.TabIndex = 3;
            this.MainIzlaz.Text = "Izlaz";
            this.MainIzlaz.UseVisualStyleBackColor = false;
            this.MainIzlaz.Click += new System.EventHandler(this.MainIzlaz_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 529);
            this.Controls.Add(this.MainIzlaz);
            this.Controls.Add(this.MainTjedna);
            this.Controls.Add(this.MainOdaberi);
            this.Controls.Add(this.MainNapravi);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainNapravi;
        private System.Windows.Forms.Button MainOdaberi;
        private System.Windows.Forms.Button MainTjedna;
        private System.Windows.Forms.Button MainIzlaz;
    }
}

