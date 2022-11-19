namespace YTConvert
{
    partial class frmYTCPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYTCPlaylist));
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.lblFeedBack = new System.Windows.Forms.Label();
            this.linklblExplications = new System.Windows.Forms.LinkLabel();
            this.lblExplications1 = new System.Windows.Forms.Label();
            this.txtURLPlaylist = new System.Windows.Forms.TextBox();
            this.cmdConvertir = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.cmdQuitter.TabIndex = 18;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = false;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // lblFeedBack
            // 
            this.lblFeedBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFeedBack.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFeedBack.Location = new System.Drawing.Point(237, 407);
            this.lblFeedBack.Name = "lblFeedBack";
            this.lblFeedBack.Size = new System.Drawing.Size(330, 28);
            this.lblFeedBack.TabIndex = 17;
            this.lblFeedBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linklblExplications
            // 
            this.linklblExplications.AutoSize = true;
            this.linklblExplications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklblExplications.Location = new System.Drawing.Point(12, 194);
            this.linklblExplications.Name = "linklblExplications";
            this.linklblExplications.Size = new System.Drawing.Size(95, 15);
            this.linklblExplications.TabIndex = 15;
            this.linklblExplications.TabStop = true;
            this.linklblExplications.Text = "Comment faire ?";
            this.linklblExplications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linklblExplications.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblExplications_LinkClicked);
            // 
            // lblExplications1
            // 
            this.lblExplications1.AutoSize = true;
            this.lblExplications1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblExplications1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExplications1.Location = new System.Drawing.Point(12, 121);
            this.lblExplications1.Name = "lblExplications1";
            this.lblExplications1.Size = new System.Drawing.Size(339, 28);
            this.lblExplications1.TabIndex = 14;
            this.lblExplications1.Text = "1 - Saisir l\'URL de la Playlist YouTube :";
            this.lblExplications1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtURLPlaylist
            // 
            this.txtURLPlaylist.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtURLPlaylist.Location = new System.Drawing.Point(12, 163);
            this.txtURLPlaylist.Multiline = true;
            this.txtURLPlaylist.Name = "txtURLPlaylist";
            this.txtURLPlaylist.Size = new System.Drawing.Size(780, 28);
            this.txtURLPlaylist.TabIndex = 13;
            this.txtURLPlaylist.MouseLeave += new System.EventHandler(this.txtURLPlaylist_MouseLeave);
            // 
            // cmdConvertir
            // 
            this.cmdConvertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.cmdConvertir.Enabled = false;
            this.cmdConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdConvertir.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdConvertir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmdConvertir.Location = new System.Drawing.Point(658, 393);
            this.cmdConvertir.Name = "cmdConvertir";
            this.cmdConvertir.Size = new System.Drawing.Size(134, 46);
            this.cmdConvertir.TabIndex = 12;
            this.cmdConvertir.Text = "Convertir !";
            this.cmdConvertir.UseVisualStyleBackColor = false;
            this.cmdConvertir.Click += new System.EventHandler(this.cmdConvertir_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitre.Location = new System.Drawing.Point(84, 17);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(637, 37);
            this.lblTitre.TabIndex = 11;
            this.lblTitre.Text = "Télécharger une playlist YouTube à partir de son URL";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmYTCPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.lblFeedBack);
            this.Controls.Add(this.linklblExplications);
            this.Controls.Add(this.lblExplications1);
            this.Controls.Add(this.txtURLPlaylist);
            this.Controls.Add(this.cmdConvertir);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "frmYTCPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "URL Playlist - YoutubeConvert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cmdQuitter;
        private Label lblFeedBack;
        private LinkLabel linklblExplications;
        private Label lblExplications1;
        private TextBox txtURLPlaylist;
        private Button cmdConvertir;
        private Label lblTitre;
    }
}