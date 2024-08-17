using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YoutubeDownloader
{
    public partial class Descargar : Form
    {
        public Descargar()
        {
            InitializeComponent();
        }

        private void Descargar_Load(object sender, EventArgs e)
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


        private void btnPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowser.Description = "Selecciona la carpeta de descarga";
            folderBrowser.ShowNewFolderButton = true;

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowser.SelectedPath;
            }
        }

        private void btnComenzarDescarga_Click(object sender, EventArgs e)
        {
            ComenzarDescarga();
        }
    }
}
