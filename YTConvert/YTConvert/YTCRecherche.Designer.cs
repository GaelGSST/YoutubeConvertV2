namespace YTConvert
{
    partial class frmYTCRecherche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYTCRecherche));
            this.linklblExplications = new System.Windows.Forms.LinkLabel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtNomVideo = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pnlResultat = new System.Windows.Forms.Panel();
            this.optRes2 = new System.Windows.Forms.CheckBox();
            this.optRes1 = new System.Windows.Forms.CheckBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.cmdConvertir = new System.Windows.Forms.Button();
            this.cmdRecherche = new System.Windows.Forms.Button();
            this.lblFeedBack = new System.Windows.Forms.Label();
            this.pnlResultat.SuspendLayout();
            this.SuspendLayout();
            // 
            // linklblExplications
            // 
            this.linklblExplications.AutoSize = true;
            this.linklblExplications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklblExplications.Location = new System.Drawing.Point(12, 416);
            this.linklblExplications.Name = "linklblExplications";
            this.linklblExplications.Size = new System.Drawing.Size(95, 15);
            this.linklblExplications.TabIndex = 19;
            this.linklblExplications.TabStop = true;
            this.linklblExplications.Text = "Comment faire ?";
            this.linklblExplications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(12, 58);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(262, 28);
            this.lbl1.TabIndex = 18;
            this.lbl1.Text = "1 - Saisir le nom de la vidéo :";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomVideo
            // 
            this.txtNomVideo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomVideo.Location = new System.Drawing.Point(12, 100);
            this.txtNomVideo.Name = "txtNomVideo";
            this.txtNomVideo.Size = new System.Drawing.Size(696, 27);
            this.txtNomVideo.TabIndex = 17;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitre.Location = new System.Drawing.Point(266, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(332, 37);
            this.lblTitre.TabIndex = 16;
            this.lblTitre.Text = "Recherches puis convertis !";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlResultat
            // 
            this.pnlResultat.AutoScroll = true;
            this.pnlResultat.BackColor = System.Drawing.Color.Transparent;
            this.pnlResultat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResultat.Controls.Add(this.optRes2);
            this.pnlResultat.Controls.Add(this.optRes1);
            this.pnlResultat.Enabled = false;
            this.pnlResultat.Location = new System.Drawing.Point(12, 173);
            this.pnlResultat.Name = "pnlResultat";
            this.pnlResultat.Size = new System.Drawing.Size(840, 240);
            this.pnlResultat.TabIndex = 20;
            this.pnlResultat.MouseLeave += new System.EventHandler(this.pnlResultat_MouseLeave);
            // 
            // optRes2
            // 
            this.optRes2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.optRes2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.optRes2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.optRes2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.optRes2.ForeColor = System.Drawing.Color.White;
            this.optRes2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optRes2.Location = new System.Drawing.Point(18, 74);
            this.optRes2.Name = "optRes2";
            this.optRes2.Size = new System.Drawing.Size(802, 65);
            this.optRes2.TabIndex = 1;
            this.optRes2.Text = "Nom vidéo n°2";
            this.optRes2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optRes2.UseVisualStyleBackColor = false;
            // 
            // optRes1
            // 
            this.optRes1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.optRes1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.optRes1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.optRes1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.optRes1.ForeColor = System.Drawing.Color.White;
            this.optRes1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optRes1.Location = new System.Drawing.Point(18, 3);
            this.optRes1.Name = "optRes1";
            this.optRes1.Size = new System.Drawing.Size(802, 65);
            this.optRes1.TabIndex = 0;
            this.optRes1.Text = "Nom vidéo n°1";
            this.optRes1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optRes1.UseVisualStyleBackColor = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(12, 142);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(406, 28);
            this.lbl2.TabIndex = 21;
            this.lbl2.Text = "2 - Sélectionner la(es) vidéo(s) recherchée(s)  :";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.cmdQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdQuitter.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdQuitter.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmdQuitter.Location = new System.Drawing.Point(12, 468);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(79, 31);
            this.cmdQuitter.TabIndex = 24;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = false;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // cmdConvertir
            // 
            this.cmdConvertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.cmdConvertir.Enabled = false;
            this.cmdConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdConvertir.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdConvertir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmdConvertir.Location = new System.Drawing.Point(718, 453);
            this.cmdConvertir.Name = "cmdConvertir";
            this.cmdConvertir.Size = new System.Drawing.Size(134, 46);
            this.cmdConvertir.TabIndex = 22;
            this.cmdConvertir.Text = "Convertir !";
            this.cmdConvertir.UseVisualStyleBackColor = false;
            this.cmdConvertir.Click += new System.EventHandler(this.cmdConvertir_Click);
            // 
            // cmdRecherche
            // 
            this.cmdRecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.cmdRecherche.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdRecherche.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdRecherche.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmdRecherche.Location = new System.Drawing.Point(718, 100);
            this.cmdRecherche.Name = "cmdRecherche";
            this.cmdRecherche.Size = new System.Drawing.Size(134, 28);
            this.cmdRecherche.TabIndex = 25;
            this.cmdRecherche.Text = "Rechercher !";
            this.cmdRecherche.UseVisualStyleBackColor = false;
            this.cmdRecherche.Click += new System.EventHandler(this.cmdRecherche_Click);
            // 
            // lblFeedBack
            // 
            this.lblFeedBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFeedBack.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFeedBack.Location = new System.Drawing.Point(267, 462);
            this.lblFeedBack.Name = "lblFeedBack";
            this.lblFeedBack.Size = new System.Drawing.Size(330, 28);
            this.lblFeedBack.TabIndex = 26;
            this.lblFeedBack.Text = ".";
            this.lblFeedBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmYTCRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 511);
            this.Controls.Add(this.lblFeedBack);
            this.Controls.Add(this.cmdRecherche);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdConvertir);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.pnlResultat);
            this.Controls.Add(this.linklblExplications);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtNomVideo);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "frmYTCRecherche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recherche - YoutubeConvert";
            this.pnlResultat.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linklblExplications;
        private Label lbl1;
        private TextBox txtNomVideo;
        private Label lblTitre;
        private Panel pnlResultat;
        private Label lbl2;
        private Button cmdQuitter;
        private Button cmdConvertir;
        private CheckBox optRes1;
        private Button cmdRecherche;
        private CheckBox optRes2;
        private Label lblFeedBack;
    }
}