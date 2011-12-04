using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

using AForge.Video.DirectShow;
using AForge.Video;
using AForge.Vision.Motion;

namespace DetectorMovimento
{
    public partial class Main : Form
    {
        private FilterInfoCollection dispositivos;
        private IVideoSource videoSource = null;
        private MotionDetector detector = new MotionDetector(
            new TwoFramesDifferenceDetector(),
            new MotionAreaHighlighting());
        private int flash = 0;
        private float motionAlarmLevel = 0.015f;

        public Main()
        {
            InitializeComponent();
        }

        #region Eventos
        private void Main_Load(object sender, EventArgs e)
        {
            CarregarDispositivos();
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            if (cbxDispositivos.SelectedIndex >= 0)
            {
                string dispositivo = dispositivos[cbxDispositivos.SelectedIndex].MonikerString;
                VideoCaptureDevice fonteVideo = new VideoCaptureDevice(dispositivo);
                AbrirDispositivoVideo(fonteVideo);
                PararDeteccao();
            }
            else
            {
                MessageBox.Show("Selecione um dispositivo.", "Atenção!");
            }
        }

        private void Main_Deactivate(object sender, EventArgs e)
        {
            FecharDispositivosVideo();
        }

        private void btnDetectarMovimento_Click(object sender, EventArgs e)
        {
            IMotionDetector detectionAlgorithm;            
            IMotionProcessing detectionProcessing;

            if (rbtSimples.Checked)
                detectionAlgorithm = new SimpleBackgroundModelingDetector(true, true);
            else
                detectionAlgorithm = new TwoFramesDifferenceDetector();

            if (rbtContorno.Checked)
                detectionProcessing = new MotionBorderHighlighting();
            else                
                detectionProcessing = new MotionAreaHighlighting();
            
            detector.MotionDetectionAlgorthm = detectionAlgorithm;
            detector.MotionProcessingAlgorithm = detectionProcessing;

            btnParar.Enabled = true;
            btnDetectarMovimento.Enabled = false;
            gbTipoDestaque.Enabled = false;
            gbTipoCaptura.Enabled = false;
        }

        private void videoSourcePlayer_NewFrame(object sender, ref Bitmap image)
        {
            lock (this)
            {
                if (detector != null)
                {
                    float motionLevel = detector.ProcessFrame(image);

                    if (motionLevel > motionAlarmLevel)
                        flash = (int)(2 * (1000 / 200));
                }
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            PararDeteccao();
        }
        #endregion

        #region Métodos
        private void CarregarDispositivos()
        {
            dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (dispositivos.Count > 0)
            {
                foreach (FilterInfo dispositivo in dispositivos)
                {
                    cbxDispositivos.Items.Add(dispositivo.Name);
                }
            }
        }

        private void AbrirDispositivoVideo(IVideoSource source)
        {
            this.Cursor = Cursors.WaitCursor;            
            FecharDispositivosVideo();
            videoSourcePlayer.VideoSource = source;
            videoSourcePlayer.Start();
            videoSource = source;
            this.Cursor = Cursors.Default;
        }

        private void FecharDispositivosVideo()
        {
            this.Cursor = Cursors.WaitCursor;
            videoSourcePlayer.SignalToStop();

            for (int i = 0; (i < 50) && (videoSourcePlayer.IsRunning); i++)
            {
                Thread.Sleep(100);
            }

            if (videoSourcePlayer.IsRunning)
                videoSourcePlayer.Stop();

            if (detector != null)
                detector.Reset();

            videoSourcePlayer.BorderColor = Color.Black;
            this.Cursor = Cursors.Default;
        }

        private void PararDeteccao()
        {
            detector.MotionDetectionAlgorthm = null;
            detector.MotionProcessingAlgorithm = null;

            btnParar.Enabled = false;
            btnDetectarMovimento.Enabled = true;
            gbTipoDestaque.Enabled = true;
            gbTipoCaptura.Enabled = true;
        }
        #endregion             
    }
}