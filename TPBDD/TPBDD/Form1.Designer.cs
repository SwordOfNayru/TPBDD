namespace TPBDD
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LBL_Pseudo = new System.Windows.Forms.Label();
            this.LBL_MotDePasse = new System.Windows.Forms.Label();
            this.B_Connect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.B_Connect);
            this.groupBox1.Controls.Add(this.LBL_MotDePasse);
            this.groupBox1.Controls.Add(this.LBL_Pseudo);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 20);
            this.textBox2.TabIndex = 1;
            // 
            // LBL_Pseudo
            // 
            this.LBL_Pseudo.AutoSize = true;
            this.LBL_Pseudo.Location = new System.Drawing.Point(6, 23);
            this.LBL_Pseudo.Name = "LBL_Pseudo";
            this.LBL_Pseudo.Size = new System.Drawing.Size(43, 13);
            this.LBL_Pseudo.TabIndex = 2;
            this.LBL_Pseudo.Text = "Pseudo";
            // 
            // LBL_MotDePasse
            // 
            this.LBL_MotDePasse.AutoSize = true;
            this.LBL_MotDePasse.Location = new System.Drawing.Point(6, 50);
            this.LBL_MotDePasse.Name = "LBL_MotDePasse";
            this.LBL_MotDePasse.Size = new System.Drawing.Size(72, 13);
            this.LBL_MotDePasse.TabIndex = 3;
            this.LBL_MotDePasse.Text = "Mot de Passe";
            // 
            // B_Connect
            // 
            this.B_Connect.Location = new System.Drawing.Point(9, 73);
            this.B_Connect.Name = "B_Connect";
            this.B_Connect.Size = new System.Drawing.Size(287, 75);
            this.B_Connect.TabIndex = 4;
            this.B_Connect.Text = "button1";
            this.B_Connect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 477);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button B_Connect;
        private System.Windows.Forms.Label LBL_MotDePasse;
        private System.Windows.Forms.Label LBL_Pseudo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

