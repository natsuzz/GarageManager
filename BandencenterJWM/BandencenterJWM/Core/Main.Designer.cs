namespace BandencenterJWM
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
            this.btnFactuur = new System.Windows.Forms.Button();
            this.btnScanner = new System.Windows.Forms.Button();
            this.btnMailFac = new System.Windows.Forms.Button();
            this.btnKlanten = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFactuur
            // 
            this.btnFactuur.Location = new System.Drawing.Point(147, 166);
            this.btnFactuur.Name = "btnFactuur";
            this.btnFactuur.Size = new System.Drawing.Size(210, 49);
            this.btnFactuur.TabIndex = 0;
            this.btnFactuur.Text = "Factuur";
            this.btnFactuur.UseVisualStyleBackColor = true;
            this.btnFactuur.Click += new System.EventHandler(this.btnFactuur_Click);
            // 
            // btnScanner
            // 
            this.btnScanner.Location = new System.Drawing.Point(363, 221);
            this.btnScanner.Name = "btnScanner";
            this.btnScanner.Size = new System.Drawing.Size(210, 49);
            this.btnScanner.TabIndex = 1;
            this.btnScanner.Text = "Klant toevoegen";
            this.btnScanner.UseVisualStyleBackColor = true;
            this.btnScanner.Click += new System.EventHandler(this.btnScanner_Click);
            // 
            // btnMailFac
            // 
            this.btnMailFac.Location = new System.Drawing.Point(147, 276);
            this.btnMailFac.Name = "btnMailFac";
            this.btnMailFac.Size = new System.Drawing.Size(210, 49);
            this.btnMailFac.TabIndex = 2;
            this.btnMailFac.Text = "Factuur Mailen";
            this.btnMailFac.UseVisualStyleBackColor = true;
            // 
            // btnKlanten
            // 
            this.btnKlanten.Location = new System.Drawing.Point(363, 166);
            this.btnKlanten.Name = "btnKlanten";
            this.btnKlanten.Size = new System.Drawing.Size(210, 49);
            this.btnKlanten.TabIndex = 3;
            this.btnKlanten.Text = "Klanten";
            this.btnKlanten.UseVisualStyleBackColor = true;
            this.btnKlanten.Click += new System.EventHandler(this.btnKlanten_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(148, 221);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(209, 49);
            this.btnStock.TabIndex = 4;
            this.btnStock.Text = "Voorraad 2de hands banden";
            this.btnStock.UseVisualStyleBackColor = true;
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(363, 276);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(210, 49);
            this.btnCalculator.TabIndex = 5;
            this.btnCalculator.Text = "Rekenmachine";
            this.btnCalculator.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(164, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 90);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnKlanten);
            this.Controls.Add(this.btnMailFac);
            this.Controls.Add(this.btnScanner);
            this.Controls.Add(this.btnFactuur);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFactuur;
        private System.Windows.Forms.Button btnScanner;
        private System.Windows.Forms.Button btnMailFac;
        private System.Windows.Forms.Button btnKlanten;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

