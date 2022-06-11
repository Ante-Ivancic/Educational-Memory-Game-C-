namespace EdukacijskiMemory
{
    partial class Profil
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
            this.lblDobrodosli = new System.Windows.Forms.Label();
            this.lblEngleski = new System.Windows.Forms.Label();
            this.lblMatematika = new System.Windows.Forms.Label();
            this.lblNjemacki = new System.Windows.Forms.Label();
            this.lblTalijanski = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDobrodosli
            // 
            this.lblDobrodosli.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDobrodosli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDobrodosli.Location = new System.Drawing.Point(12, 34);
            this.lblDobrodosli.Name = "lblDobrodosli";
            this.lblDobrodosli.Size = new System.Drawing.Size(300, 48);
            this.lblDobrodosli.TabIndex = 0;
            this.lblDobrodosli.Text = "label1";
            this.lblDobrodosli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEngleski
            // 
            this.lblEngleski.ForeColor = System.Drawing.Color.Black;
            this.lblEngleski.Location = new System.Drawing.Point(12, 120);
            this.lblEngleski.Name = "lblEngleski";
            this.lblEngleski.Size = new System.Drawing.Size(300, 23);
            this.lblEngleski.TabIndex = 1;
            this.lblEngleski.Text = "label2";
            this.lblEngleski.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatematika
            // 
            this.lblMatematika.ForeColor = System.Drawing.Color.Black;
            this.lblMatematika.Location = new System.Drawing.Point(12, 175);
            this.lblMatematika.Name = "lblMatematika";
            this.lblMatematika.Size = new System.Drawing.Size(300, 23);
            this.lblMatematika.TabIndex = 2;
            this.lblMatematika.Text = "label3";
            this.lblMatematika.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNjemacki
            // 
            this.lblNjemacki.ForeColor = System.Drawing.Color.Black;
            this.lblNjemacki.Location = new System.Drawing.Point(12, 230);
            this.lblNjemacki.Name = "lblNjemacki";
            this.lblNjemacki.Size = new System.Drawing.Size(300, 23);
            this.lblNjemacki.TabIndex = 3;
            this.lblNjemacki.Text = "label4";
            this.lblNjemacki.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTalijanski
            // 
            this.lblTalijanski.ForeColor = System.Drawing.Color.Black;
            this.lblTalijanski.Location = new System.Drawing.Point(12, 285);
            this.lblTalijanski.Name = "lblTalijanski";
            this.lblTalijanski.Size = new System.Drawing.Size(300, 23);
            this.lblTalijanski.TabIndex = 4;
            this.lblTalijanski.Text = "label5";
            this.lblTalijanski.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(323, 352);
            this.Controls.Add(this.lblTalijanski);
            this.Controls.Add(this.lblNjemacki);
            this.Controls.Add(this.lblMatematika);
            this.Controls.Add(this.lblEngleski);
            this.Controls.Add(this.lblDobrodosli);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Profil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDobrodosli;
        private System.Windows.Forms.Label lblEngleski;
        private System.Windows.Forms.Label lblMatematika;
        private System.Windows.Forms.Label lblNjemacki;
        private System.Windows.Forms.Label lblTalijanski;
    }
}