using System.Drawing.Text;
using YoutubeDownloader;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace JanrosMediaPlayer
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void MostrarFormulario(Form form) 
        { 
            panelMain.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            panelMain.Controls.Add(form);
            form.Show();
        }


        private void btnDescargar_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new Descargar());

        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {

        }
    }
}
