using System.Drawing.Text;
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

        private async void ComenzarDescarga()
        {

            //Validar URL
            if (string.IsNullOrWhiteSpace(txtUrl.Text))
            {
                MessageBox.Show("Ingresa una URL Válida");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPath.Text) || !Directory.Exists(txtPath.Text))
            {
                MessageBox.Show("Por favor seleccione una ruta de descarga válida.");
                return;
            }

            //Se crea una instancia de la clase YoutubeClient
            var client = new YoutubeClient();

            //Se obtiene la información del video
            var video = await client.Videos.GetAsync(txtUrl.Text);

            //Se obtiene la información de los streams del video
            var streamInfoSet = await client.Videos.Streams.GetManifestAsync(txtUrl.Text);

            //Se selecciona el stream de mayor calidad
            var streamInfo = streamInfoSet.GetMuxedStreams().GetWithHighestVideoQuality();

            // Deshabilitar botón y mostrar indicador
            btnComenzarDescarga.Enabled = false;
            lblStatus.Text = "Descargando...";

            //Se descarga el video
            if (streamInfo != null)
            {
                //Se selecciona el lugar de descarga utilizando el txtPath
                var path = txtPath.Text + "\\" + video.Title + ".mp4";
                //Se descarga el video en esa ruta
                await client.Videos.Streams.DownloadAsync(streamInfo, path);

                //Mostrar un panel de información que diga si se pudo descargar
                MessageBox.Show("Video descargado con éxito");
            }
            else
            {
                MessageBox.Show("No se pudo descargar el video");
            }
            btnComenzarDescarga.Enabled = true;
            lblStatus.Text = "...";
        }

        private void btnComenzarDescarga_Click(object sender, EventArgs e)
        {
            ComenzarDescarga();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            folderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowser.Description = "Selecciona la carpeta de descarga";
            folderBrowser.ShowNewFolderButton = true;

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowser.SelectedPath;
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            tabControlMenu.SelectedTab = tabPage1;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            tabControlMenu.SelectedTab = tabPage2;
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            tabControlMenu.SelectedTab = tabPage3;
        }
    }
}
