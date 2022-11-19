namespace YTConvert
{
    partial class frmAccueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueil));
            this.lblTitre = new System.Windows.Forms.Label();
            this.cmdMusiques = new System.Windows.Forms.Button();
            this.cmdPlaylist = new System.Windows.Forms.Button();
            this.cmdRechercher = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.lblitre2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLbl1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitre.Location = new System.Drawing.Point(204, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(397, 37);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Convertisseur de vidéo YouTube";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdMusiques
            // 
            this.cmdMusiques.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.cmdMusiques.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdMusiques.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdMusiques.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmdMusiques.Location = new System.Drawing.Point(165, 131);
            this.cmdMusiques.Name = "cmdMusiques";
            this.cmdMusiques.Size = new System.Drawing.Size(176, 65);
            this.cmdMusiques.TabIndex = 1;
            this.cmdMusiques.TabStop = false;
            this.cmdMusiques.Text = "URL Vidéos";
            this.cmdMusiques.UseVisualStyleBackColor = false;
            this.cmdMusiques.Click += new System.EventHandler(this.cmdMusiques_Click);
            // 
            // cmdPlaylist
            // 
            this.cmdPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.cmdPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdPlaylist.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdPlaylist.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmdPlaylist.Location = new System.Drawing.Point(463, 131);
            this.cmdPlaylist.Name = "cmdPlaylist";
            this.cmdPlaylist.Size = new System.Drawing.Size(176, 65);
            this.cmdPlaylist.TabIndex = 2;
            this.cmdPlaylist.TabStop = false;
            this.cmdPlaylist.Text = "URL Playlist";
            this.cmdPlaylist.UseVisualStyleBackColor = false;
            this.cmdPlaylist.Click += new System.EventHandler(this.cmdPlaylist_Click);
            // 
            // cmdRechercher
            // 
            this.cmdRechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.cmdRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdRechercher.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdRechercher.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmdRechercher.Location = new System.Drawing.Point(165, 283);
            this.cmdRechercher.Name = "cmdRechercher";
            this.cmdRechercher.Size = new System.Drawing.Size(474, 65);
            this.cmdRechercher.TabIndex = 3;
            this.cmdRechercher.TabStop = false;
            this.cmdRechercher.Text = "Rechercher des musiques";
            this.cmdRechercher.UseVisualStyleBackColor = false;
            this.cmdRechercher.Click += new System.EventHandler(this.cmdRechercher_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.cmdQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdQuitter.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdQuitter.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmdQuitter.Location = new System.Drawing.Point(12, 408);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(79, 31);
            this.cmdQuitter.TabIndex = 11;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = false;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // lblitre2
            // 
            this.lblitre2.AutoSize = true;
            this.lblitre2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblitre2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblitre2.Location = new System.Drawing.Point(12, 88);
            this.lblitre2.Name = "lblitre2";
            this.lblitre2.Size = new System.Drawing.Size(414, 28);
            this.lblitre2.TabIndex = 12;
            this.lblitre2.Text = "1 - Télécharger des musiques à partir des URL :";
            this.lblitre2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "2 - Chercher et télécharger directement les musiques  :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLbl1
            // 
            this.linkLbl1.AutoSize = true;
            this.linkLbl1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLbl1.Location = new System.Drawing.Point(683, 422);
            this.linkLbl1.Name = "linkLbl1";
            this.linkLbl1.Size = new System.Drawing.Size(109, 20);
            this.linkLbl1.TabIndex = 14;
            this.linkLbl1.TabStop = true;
            this.linkLbl1.Text = "Besoin d\'aide ?";
            this.linkLbl1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl1_LinkClicked);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.linkLbl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblitre2);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdRechercher);
            this.Controls.Add(this.cmdPlaylist);
            this.Controls.Add(this.cmdMusiques);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "frmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil - YoutubeConvert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitre;
        private Button cmdMusiques;
        private Button cmdPlaylist;
        private Button cmdRechercher;
        private Button cmdQuitter;
        private Label lblitre2;
        private Label label1;
        private LinkLabel linkLbl1;
    }
}