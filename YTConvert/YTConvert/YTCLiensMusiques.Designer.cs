namespace YTConvert
{
    partial class frmYTCLiensMusiques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYTCLiensMusiques));
            this.cmdConvertir = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.txtURLMusiques = new System.Windows.Forms.TextBox();
            this.lblExplications1 = new System.Windows.Forms.Label();
            this.linklblExplications = new System.Windows.Forms.LinkLabel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblFeedBack = new System.Windows.Forms.Label();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.cmdConvertir.TabIndex = 3;
            this.cmdConvertir.Text = "Convertir !";
            this.cmdConvertir.UseVisualStyleBackColor = false;
            this.cmdConvertir.Click += new System.EventHandler(this.cmdConvertir_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitre.Location = new System.Drawing.Point(56, 22);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(693, 37);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Téléchargement des vidéos YouTube à partir de leurs URL";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtURLMusiques
            // 
            this.txtURLMusiques.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtURLMusiques.Location = new System.Drawing.Point(12, 130);
            this.txtURLMusiques.Multiline = true;
            this.txtURLMusiques.Name = "txtURLMusiques";
            this.txtURLMusiques.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtURLMusiques.Size = new System.Drawing.Size(780, 189);
            this.txtURLMusiques.TabIndex = 4;
            this.txtURLMusiques.MouseLeave += new System.EventHandler(this.txtURLMusiques_MouseLeave);
            // 
            // lblExplications1
            // 
            this.lblExplications1.AutoSize = true;
            this.lblExplications1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblExplications1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExplications1.Location = new System.Drawing.Point(12, 88);
            this.lblExplications1.Name = "lblExplications1";
            this.lblExplications1.Size = new System.Drawing.Size(341, 28);
            this.lblExplications1.TabIndex = 5;
            this.lblExplications1.Text = "1 - Saisir les URL des vidéos YouTube :";
            this.lblExplications1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linklblExplications
            // 
            this.linklblExplications.AutoSize = true;
            this.linklblExplications.Location = new System.Drawing.Point(12, 322);
            this.linklblExplications.Name = "linklblExplications";
            this.linklblExplications.Size = new System.Drawing.Size(95, 15);
            this.linklblExplications.TabIndex = 7;
            this.linklblExplications.TabStop = true;
            this.linklblExplications.Text = "Comment faire ?";
            this.linklblExplications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linklblExplications.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblExplications_LinkClicked);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(237, 408);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(330, 31);
            this.progressBar.TabIndex = 8;
            // 
            // lblFeedBack
            // 
            this.lblFeedBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFeedBack.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFeedBack.Location = new System.Drawing.Point(237, 377);
            this.lblFeedBack.Name = "lblFeedBack";
            this.lblFeedBack.Size = new System.Drawing.Size(330, 28);
            this.lblFeedBack.TabIndex = 9;
            this.lblFeedBack.Text = ".";
            this.lblFeedBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cmdQuitter.TabIndex = 10;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = false;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(701, 325);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 26);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "réinitialiser";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmYTCLiensMusiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.lblFeedBack);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.linklblExplications);
            this.Controls.Add(this.lblExplications1);
            this.Controls.Add(this.txtURLMusiques);
            this.Controls.Add(this.cmdConvertir);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "frmYTCLiensMusiques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "URL YouTube - YoutubeConvert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cmdConvertir;
        private Label lblTitre;
        private TextBox txtURLMusiques;
        private Label lblExplications1;
        private LinkLabel linklblExplications;
        private ProgressBar progressBar;
        private Label lblFeedBack;
        private Button cmdQuitter;
        private Button btnClear;
    }
}