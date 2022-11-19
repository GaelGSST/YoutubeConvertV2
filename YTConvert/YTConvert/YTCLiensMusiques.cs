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
    public partial class frmYTCLiensMusiques : Form
    {
        public frmYTCLiensMusiques()
        {
            InitializeComponent();
        }

        private void linklblExplications_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = "     Pour convertir des vidéos YouTube au format MP3, vous devez entrer les URL des vidéos YouTube dans la zone de texte dédier." +
                "\nPour cela, copier l'URL de votre musique sur YouTube et coller l'URL dans la zone de texte." +
                "\n\nAttention, veillez entrer les URL ligne par ligne !" +
                "\n\nUne fois que vous avez terminé d'entrer tous les URL dans la zone de texte, appuyez sur le bouton 'Convertir !'. " +
                "L'application téléchargera toutes les vidéos YouTube à partir de vos URL. Une barre de progression vous donnera un ordre d'idées sur l'avancée des téléchargements." +
                "\n\nUne fois le téléchargement terminé, la barre de progression sera pleine." +
                "\n\nToutes les musiques téléchargées se situeront sur votre bureau." +
                "\n\nMade by Gaël. Tous droits réservés YouTubeConvert.";

            MessageBox.Show(message, "Comment faire ?", MessageBoxButtons.OK);
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void cmdConvertir_Click(object sender, EventArgs e)
        {
            string videoName;
            List<string> ListLienMusique = new List<string>();

            int barProgValue = 0;
            progressBar.Value = barProgValue;

            lblFeedBack.Text = "En cours de téléchargement ...";

            /// Take all User's URL
            foreach (string liens in txtURLMusiques.Lines)
            {
                if (!String.IsNullOrWhiteSpace(liens)) // Don't take blank line
                    ListLienMusique.Add(liens);
            }

            // Convert all music
            barProgValue = 100 / Convert.ToInt32(ListLienMusique.Count);

            for (int i = 0; i < ListLienMusique.Count; i++)
            {
                try
                {
                    ClassYTConvert.ClassYTConv.CreateFolder();
                    videoName = ClassYTConvert.ClassYTConv.nameVideo(ListLienMusique[i]);
                    await ClassYTConvert.ClassYTConv.MP3Convert(ListLienMusique[i], videoName);
                }
                catch (Exception)
                {
                    MessageBox.Show($"L'URL de la ligne {i + 1} est erroné ou incorrect.", "Erreur URL", MessageBoxButtons.OK);
                }
                progressBar.Value += barProgValue;
            }

            progressBar.Value = 100;
            lblFeedBack.Text = "Téléchargement terminé !";
        }

        private void txtURLMusiques_MouseLeave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtURLMusiques.Text))
                cmdConvertir.Enabled = false;
            else
                cmdConvertir.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtURLMusiques.Clear();
        }
    }
}
