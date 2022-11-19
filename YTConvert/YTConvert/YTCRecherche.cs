using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YTConvert
{
    public partial class frmYTCRecherche : Form
    {
        public static List<CheckBox> CheckBoxes = new List<CheckBox>();

        public frmYTCRecherche()
        {
            InitializeComponent();
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void cmdConvertir_Click(object sender, EventArgs e)
        {

            DialogResult awnser = MessageBox.Show("Etes-vous sur de vouloir télécharger la(es) vidéo(s) YouTube cochée(s) ?", "Confirmation", MessageBoxButtons.YesNo);

            if (awnser == DialogResult.Yes) { 
                string url;
                string videoName;

                // Create a repertory for downloaded mp3
                try
                {
                    ClassYTConvert.ClassYTConv.CreateFolder();
                }
                catch
                {
                    //pass
                }

                // Take all checkBox where checked state is true
                for (int i = 0; i < CheckBoxes.Count; i++)
                {
                    if (CheckBoxes[i].Checked == true)
                    {
                        // Download the music in MP3
                        url = ClassYTConvert.ClassYTConv.URLVideoRes[i];
                        videoName = ClassYTConvert.ClassYTConv.nameVideo(url);
                        try
                        {
                            await ClassYTConvert.ClassYTConv.MP3Convert(url, videoName);
                        }
                        catch (Exception)
                        {
                            //pass
                        }

                        // Uncheck
                        CheckBoxes[i].Checked = false;
                    }
                }

                lblFeedBack.Text = "Convertion terminée";
            }
        }

        private async void cmdRecherche_Click(object sender, EventArgs e)
        {
            string nomVideo;

            lblFeedBack.Text = "Recherche en cours ...";

            // Search the music
            try
            {
                await ClassYTConvert.ClassYTConv.MP3ConvertRecherche(txtNomVideo.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur de recherche, veillez réessayer.", "Erreur", MessageBoxButtons.OK);
            }

            // Take datas of music and put in the panel
            pnlResultat.SuspendLayout();
            pnlResultat.Enabled = false;

            // If CheckBoxes List is full we do not need to recreate Checkbox items
            // Just rename them
            if (CheckBoxes.Count == 6)
            {
                for(int i = 0; i < CheckBoxes.Count; i++)
                {
                    nomVideo = ClassYTConvert.ClassYTConv.NomVideoRes[i];
                    CheckBoxes[i].Text = nomVideo;
                }
            }
            else 
            { 
                for (int i = 1; i <= ClassYTConvert.ClassYTConv.NomVideoRes.Count; i++)
                {
                    nomVideo = ClassYTConvert.ClassYTConv.NomVideoRes[i - 1];

                    if (i == 1)
                    {
                        optRes1.Text = nomVideo;

                        // Add checkBox in the list
                        CheckBoxes.Add(optRes1);
                    }
                    else if (i == 2)
                    {
                        optRes2.Text = nomVideo;

                        // Add checkBox in the list
                        CheckBoxes.Add(optRes2);
                    }
                    else
                    {
                        // Create another checkBox
                        CheckBox newOPT = new CheckBox();

                        int OPThauteur = optRes1.Size.Height;
                        int OPTlargeur = optRes1.Size.Width;

                        int OPTDist = optRes2.Location.Y - optRes1.Location.Y;
                        int OPTx = optRes1.Location.X;
                        int OPTy = pnlResultat.Controls[$"optRes{i - 1}"].Location.Y + OPTDist;

                        newOPT.Name = $"optRes{i}";
                        newOPT.Size = new Size(OPTlargeur, OPThauteur);
                        newOPT.Location = new Point(OPTx, OPTy);

                        newOPT.Font = new Font(optRes1.Font, FontStyle.Regular);
                        newOPT.ForeColor = Color.White;
                        newOPT.BackColor = optRes1.BackColor;
                        newOPT.FlatStyle = optRes1.FlatStyle;

                        newOPT.Text = $"{nomVideo}";
                        newOPT.TextAlign = ContentAlignment.MiddleCenter;

                        // Add checkBox in the list
                        CheckBoxes.Add(newOPT);

                        // Display checkBox
                        pnlResultat.Controls.Add(newOPT);
                    }
                }
            }

            pnlResultat.ResumeLayout();
            pnlResultat.Enabled = true;

            lblFeedBack.Text = "Recherche terminée";
        }

        private void pnlResultat_MouseLeave(object sender, EventArgs e)
        {
            bool verification = false;

            for(int i = 0; i < CheckBoxes.Count; i++)
            {
                if (CheckBoxes[i].Checked)
                    verification = true;
            }

            if (verification == true)
                cmdConvertir.Enabled = true;
            else
                cmdConvertir.Enabled = false;
        }
    }
}
