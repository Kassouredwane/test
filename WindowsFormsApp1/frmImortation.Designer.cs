namespace WindowsFormsApp1
{
    partial class frmImortation
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.btn_lancerImport = new System.Windows.Forms.Button();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.btn_choisirFichier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fichier :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Societé :";
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(203, 46);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(201, 20);
            this.txt_login.TabIndex = 6;
            // 
            // btn_lancerImport
            // 
            this.btn_lancerImport.Location = new System.Drawing.Point(161, 169);
            this.btn_lancerImport.Name = "btn_lancerImport";
            this.btn_lancerImport.Size = new System.Drawing.Size(107, 24);
            this.btn_lancerImport.TabIndex = 10;
            this.btn_lancerImport.Text = "Lancer l\'import";
            this.btn_lancerImport.UseVisualStyleBackColor = true;
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(283, 169);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(107, 24);
            this.btn_fermer.TabIndex = 11;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // btn_choisirFichier
            // 
            this.btn_choisirFichier.Location = new System.Drawing.Point(412, 110);
            this.btn_choisirFichier.Name = "btn_choisirFichier";
            this.btn_choisirFichier.Size = new System.Drawing.Size(37, 19);
            this.btn_choisirFichier.TabIndex = 12;
            this.btn_choisirFichier.Text = "...";
            this.btn_choisirFichier.UseVisualStyleBackColor = true;
            // 
            // frmImortation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 247);
            this.Controls.Add(this.btn_choisirFichier);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.btn_lancerImport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_login);
            this.Name = "frmImortation";
            this.Text = "frmImortation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Button btn_lancerImport;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.Button btn_choisirFichier;
    }
}