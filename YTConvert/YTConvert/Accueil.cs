using System.Diagnostics;

namespace YTConvert
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void cmdMusiques_Click(object sender, EventArgs e)
        {
            frmYTCLiensMusiques frmYTCLiensMusiques;
            frmYTCLiensMusiques = new frmYTCLiensMusiques();
            frmYTCLiensMusiques.ShowDialog();
        }

        private void cmdPlaylist_Click(object sender, EventArgs e)
        {
            frmYTCPlaylist frmYTCPlaylist;
            frmYTCPlaylist = new frmYTCPlaylist();
            frmYTCPlaylist.ShowDialog();
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdRechercher_Click(object sender, EventArgs e)
        {
            frmYTCRecherche frmYTCRecherche;
            frmYTCRecherche = new frmYTCRecherche();
            frmYTCRecherche.ShowDialog();
        }

        private void linkLbl1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/YoutubeConvertWF/YTConvertRuleWebsite/index.html",
                UseShellExecute = true
            };

            Process.Start(psInfo);
        }
    }
}