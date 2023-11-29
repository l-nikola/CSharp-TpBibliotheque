
namespace WinMediatheque
{
    partial class AjoutLivre
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Auteur = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_ref = new System.Windows.Forms.TextBox();
            this.txb_nbpages = new System.Windows.Forms.TextBox();
            this.txb_auteur = new System.Windows.Forms.TextBox();
            this.txb_titre = new System.Windows.Forms.TextBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(210, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajout d\'un nouveau livre au catalogue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Référence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titre";
            // 
            // label_Auteur
            // 
            this.label_Auteur.AutoSize = true;
            this.label_Auteur.Location = new System.Drawing.Point(155, 189);
            this.label_Auteur.Name = "label_Auteur";
            this.label_Auteur.Size = new System.Drawing.Size(38, 13);
            this.label_Auteur.TabIndex = 3;
            this.label_Auteur.Text = "Auteur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nb de pages";
            // 
            // txb_ref
            // 
            this.txb_ref.Location = new System.Drawing.Point(463, 104);
            this.txb_ref.Name = "txb_ref";
            this.txb_ref.Size = new System.Drawing.Size(100, 20);
            this.txb_ref.TabIndex = 5;
            // 
            // txb_nbpages
            // 
            this.txb_nbpages.Location = new System.Drawing.Point(463, 235);
            this.txb_nbpages.Name = "txb_nbpages";
            this.txb_nbpages.Size = new System.Drawing.Size(100, 20);
            this.txb_nbpages.TabIndex = 6;
            // 
            // txb_auteur
            // 
            this.txb_auteur.Location = new System.Drawing.Point(463, 186);
            this.txb_auteur.Name = "txb_auteur";
            this.txb_auteur.Size = new System.Drawing.Size(100, 20);
            this.txb_auteur.TabIndex = 7;
            // 
            // txb_titre
            // 
            this.txb_titre.Location = new System.Drawing.Point(463, 143);
            this.txb_titre.Name = "txb_titre";
            this.txb_titre.Size = new System.Drawing.Size(100, 20);
            this.txb_titre.TabIndex = 8;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(356, 316);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 9;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // AjoutLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.txb_titre);
            this.Controls.Add(this.txb_auteur);
            this.Controls.Add(this.txb_nbpages);
            this.Controls.Add(this.txb_ref);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_Auteur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AjoutLivre";
            this.Text = "AjoutLivre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Auteur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_ref;
        private System.Windows.Forms.TextBox txb_nbpages;
        private System.Windows.Forms.TextBox txb_auteur;
        private System.Windows.Forms.TextBox txb_titre;
        private System.Windows.Forms.Button btn_ajouter;
    }
}