
namespace WinMediatheque
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDesLivresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toutLesLivresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livresParRéférenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livresParAuteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livresParTitreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesLivresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDesLivresToolStripMenuItem
            // 
            this.gestionDesLivresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutToolStripMenuItem,
            this.modificationToolStripMenuItem,
            this.consultationToolStripMenuItem,
            this.suppressionToolStripMenuItem});
            this.gestionDesLivresToolStripMenuItem.Name = "gestionDesLivresToolStripMenuItem";
            this.gestionDesLivresToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.gestionDesLivresToolStripMenuItem.Text = "Gestion des livres";
            // 
            // ajoutToolStripMenuItem
            // 
            this.ajoutToolStripMenuItem.Name = "ajoutToolStripMenuItem";
            this.ajoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajoutToolStripMenuItem.Text = "Ajout";
            this.ajoutToolStripMenuItem.Click += new System.EventHandler(this.ajoutToolStripMenuItem_Click);
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificationToolStripMenuItem.Text = "Modification";
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toutLesLivresToolStripMenuItem,
            this.livresParRéférenceToolStripMenuItem,
            this.livresParAuteursToolStripMenuItem,
            this.livresParTitreToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // suppressionToolStripMenuItem
            // 
            this.suppressionToolStripMenuItem.Name = "suppressionToolStripMenuItem";
            this.suppressionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.suppressionToolStripMenuItem.Text = "Suppression";
            // 
            // toutLesLivresToolStripMenuItem
            // 
            this.toutLesLivresToolStripMenuItem.Name = "toutLesLivresToolStripMenuItem";
            this.toutLesLivresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toutLesLivresToolStripMenuItem.Text = "Tous les livres ";
            // 
            // livresParRéférenceToolStripMenuItem
            // 
            this.livresParRéférenceToolStripMenuItem.Name = "livresParRéférenceToolStripMenuItem";
            this.livresParRéférenceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.livresParRéférenceToolStripMenuItem.Text = "Livres par référence ";
            // 
            // livresParAuteursToolStripMenuItem
            // 
            this.livresParAuteursToolStripMenuItem.Name = "livresParAuteursToolStripMenuItem";
            this.livresParAuteursToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.livresParAuteursToolStripMenuItem.Text = "Livres par auteur";
            // 
            // livresParTitreToolStripMenuItem
            // 
            this.livresParTitreToolStripMenuItem.Name = "livresParTitreToolStripMenuItem";
            this.livresParTitreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.livresParTitreToolStripMenuItem.Text = "Livres par titre";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesLivresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toutLesLivresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livresParRéférenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livresParAuteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livresParTitreToolStripMenuItem;
    }
}