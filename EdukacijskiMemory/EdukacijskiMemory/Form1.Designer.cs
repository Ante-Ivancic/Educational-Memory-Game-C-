namespace EdukacijskiMemory
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblSifra = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(139, 107);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(43, 17);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            this.lblLogin.Visible = false;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(77, 165);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(34, 17);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "ime:";
            this.lblIme.Visible = false;
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(73, 226);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(39, 17);
            this.lblSifra.TabIndex = 2;
            this.lblSifra.Text = "šifra:";
            this.lblSifra.Visible = false;
            // 
            // tbIme
            // 
            this.tbIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbIme.Location = new System.Drawing.Point(127, 181);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(148, 20);
            this.tbIme.TabIndex = 3;
            // 
            // tbSifra
            // 
            this.tbSifra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSifra.Location = new System.Drawing.Point(127, 227);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.PasswordChar = '*';
            this.tbSifra.Size = new System.Drawing.Size(148, 20);
            this.tbSifra.TabIndex = 4;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfirm.Location = new System.Drawing.Point(117, 364);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(110, 34);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(332, 450);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbSifra);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblLogin);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.Button btnConfirm;
    }
}

