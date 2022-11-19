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
    public partial class frmYTCPlaylist : Form
    {
        public frmYTCPlaylist()
        {
            InitializeComponent();
        }

        private void linklblExplications_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = "     Pour convertir une Playlist YouTube au format MP3, vous devez entrer l'URL de la Playlist YouTube dans la zone de texte dédier." +
                             "\nPour cela, copier l'URL de votre playlist sur YouTube et coller l'URL dans la zone de texte." +
                             "\nLa Playlist doit être publique !" +
                             "\n\nAttention, veillez entrer une seule URL !" +
                             "\n\nUne fois que vous avez terminé d'entrer l'URL dans la zone de texte, appuyez sur le bouton 'Convertir !'. " +
                             "L'application téléchargera toutes les vidéos YouTube au format MP3 contenu dans votre Playlist." +
                             "\n\nUne fois le téléchargement terminé, un message le disant s'affichera." +
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
            // Variables
            lblFeedBack.Text = "En cours de téléchargement ...";

            // On convertit les musiques
            try
            {   
                ClassYTConvert.ClassYTConv.CreateFolder(); 
                await ClassYTConvert.ClassYTConv.MP3ConvertPlaylist(txtURLPlaylist.Lines[0]);
            }
            catch (Exception)
            {
                MessageBox.Show("L'URL que vous avez entré n'existe pas !", "Erreur de téléchargement", MessageBoxButtons.OK);
            }

            lblFeedBack.Text = "Téléchargement terminé !";
        }

        private void txtURLPlaylist_MouseLeave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtURLPlaylist.Text))
                cmdConvertir.Enabled = false;
            else
                cmdConvertir.Enabled = true;
        }
    }
}
