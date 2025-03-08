using System.Diagnostics;
using System.Numerics;
using gk___projekt_2.Configuration;
using gk___projekt_2.FastGraphics;
using gk___projekt_2.IO;
using gk___projekt_2.Models;
using gk___projekt_2.Models.Core;
using gk___projekt_2.Rendering;
using Timer = System.Windows.Forms.Timer;

namespace gk___projekt_2
{
    public partial class Form1 : Form
    {
        private DirectBitmap FastBitmap;
        private BezierSurface bezierSurface;
        private LightSource lightSource;
        private WaveFunction waveFunction;
        private Timer animationTimer;
        private Timer waveTimer;
        private Stopwatch stopwatch;
        public Form1()
        {
            InitializeComponent();
            Width = AppConfig.WindowWidth;
            Height = AppConfig.WindowHeight;
            AppConfig.CanvasWidth = Canvas.Width;
            AppConfig.CanvasHeight = Canvas.Height;

            FastBitmap = new DirectBitmap(Canvas.Width, Canvas.Height);
            Canvas.Image = FastBitmap.Bitmap;

            List<ControlPoint> controlPoints = ControlPointsFileReader.ReadFromFile(AppConfig.ControlPointsFile);

            Texture surfaceTexture = new Texture(DrawingConfig.DefaultSourfaceColor);

            bezierSurface = new BezierSurface(controlPoints, surfaceTexture, ResolutionSlider.Value, 0.5f, 1.0f, 50.0f);
            lightSource = new LightSource(0, 200, 800, DrawingConfig.DefaultLightColor);


            animationTimer = new Timer();
            animationTimer.Interval = 150;
            animationTimer.Tick += OnTimedEvent;

            waveTimer = new Timer();
            waveTimer.Interval = 80;
            waveTimer.Tick += OnWaveTimedEvent;

            waveFunction = new WaveFunction(100, 1200, 0.5f);
            stopwatch = new Stopwatch();
            UpdateCanvas();
        }

        private void UpdateCanvas()
        {
            BezierSurfaceRenderer.Render(bezierSurface, FastBitmap, lightSource);
            Canvas.Invalidate();
            Canvas.Update();
        }

        private void AlphaAngleSlider_Scroll(object sender, EventArgs e)
        {

            if (sender is TrackBar slider)
            {
                AlphaTextBox.Text = slider.Value.ToString();
                bezierSurface.AlphaDeg = slider.Value;
                UpdateCanvas();
            }

        }

        private void BetaAngleSlider_Scroll(object sender, EventArgs e)
        {
            if (sender is TrackBar slider)
            {
                BetaTextBox.Text = slider.Value.ToString();
                bezierSurface.BetaDeg = slider.Value;
                UpdateCanvas();
            }
        }

        private void ResolutionSlider_Scroll(object sender, EventArgs e)
        {
            if (sender is TrackBar slider)
            {
                ResolutionTextBox.Text = slider.Value.ToString();
                bezierSurface.Resolution = slider.Value;
                UpdateCanvas();
            }
        }

        private void KsSlider_Scroll(object sender, EventArgs e)
        {
            if (sender is TrackBar slider)
            {
                KsTextBox.Text = (slider.Value / (float)slider.Maximum).ToString();
                bezierSurface.Ks = slider.Value / (float)slider.Maximum;
                UpdateCanvas();
            }
        }

        private void KdSlider_Scroll(object sender, EventArgs e)
        {
            if (sender is TrackBar slider)
            {
                KdTextBox.Text = (slider.Value / (float)slider.Maximum).ToString();
                bezierSurface.Kd = slider.Value / (float)slider.Maximum;
                UpdateCanvas();
            }
        }

        private void MSlider_Scroll(object sender, EventArgs e)
        {
            if (sender is TrackBar slider)
            {
                MTextBox.Text = slider.Value.ToString();
                bezierSurface.M = slider.Value;
                UpdateCanvas();
            }
        }

        private void PolygonMeshCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                BezierSurfaceRenderer.DrawPolygonMesh = checkBox.Checked;
                UpdateCanvas();
            }
        }

        private void ControlPointsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                BezierSurfaceRenderer.DrawControlPoints = checkBox.Checked;
                UpdateCanvas();
            }
        }

        private void SurfaceColorButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                ColorDialog colorDialog = new ColorDialog();
                colorDialog.FullOpen = true;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color pickedColor = colorDialog.Color;
                    button.BackColor = pickedColor;
                    bezierSurface.Texture.ChangeTextureColor(pickedColor);
                    UpdateCanvas();
                }
            }
        }

        private void LightColorButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                ColorDialog colorDialog = new ColorDialog();
                colorDialog.FullOpen = true;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color pickedColor = colorDialog.Color;
                    button.BackColor = pickedColor;
                    lightSource.LightColor = pickedColor;
                    UpdateCanvas();
                }
            }
        }

        private void SelectTextureButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                string initialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, AppConfig.TextureFilesDirectory);
                openFileDialog.InitialDirectory = initialDirectory;
                openFileDialog.Filter = "Pliki obrazów (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bezierSurface.Texture.ChangeTextureImage(openFileDialog.FileName);
                    UpdateCanvas();
                }

            }
        }
        private void SelectNormalMapButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                string initialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, AppConfig.NormalMapsDirectory);
                openFileDialog.InitialDirectory = initialDirectory;
                openFileDialog.Filter = "Pliki obrazów (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bezierSurface.Texture.ChangeNormalMap(openFileDialog.FileName);
                    UpdateCanvas();
                }

            }
        }

        private void AnimationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox.Checked) { animationTimer.Start(); }
                else { animationTimer.Stop(); }
            }
        }
        private void OnTimedEvent(object? sender, EventArgs e)
        {
            lightSource.Rotate(Quaternion.CreateFromAxisAngle(Vector3.UnitZ, 0.3f));
            UpdateCanvas();
        }
        private void OnWaveTimedEvent( object? sender, EventArgs e)
        {
            bezierSurface.WaveSurface(waveFunction, stopwatch.ElapsedMilliseconds / 1000.0f);
            UpdateCanvas();
        }

        private void LightDistanceSlider_Scroll(object sender, EventArgs e)
        {
            if (sender is TrackBar trackBar)
            {
                LightDistanceTextBox.Text = trackBar.Value.ToString();
                lightSource.ChangeZCoordinate(trackBar.Value);
                UpdateCanvas();
            }
        }

        private void TextureCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox.Checked)
                {
                    SelectTextureButton.Enabled = true;
                    bezierSurface.Texture.ChangeTextureImage(AppConfig.DefaultTextureFile);
                }
                else
                {
                    SelectTextureButton.Enabled = false;
                    bezierSurface.Texture.ChangeTextureColor(SurfaceColorButton.BackColor);
                }
            }
            UpdateCanvas();
        }

        private void NormalMapCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox.Checked)
                {
                    SelectNormalMapButton.Enabled = true;
                    bezierSurface.Texture.ChangeNormalMap(AppConfig.DefaultNormalMapFile);
                }
                else
                {
                    SelectNormalMapButton.Enabled = false;
                    bezierSurface.Texture.RemoveNormalMap();
                }
            }
            UpdateCanvas();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                lightSource.isReflector = checkBox.Checked;
                UpdateCanvas();
            }
        }

        private void MLigthSlider_Scroll(object sender, EventArgs e)
        {
            if (sender is TrackBar trackBar)
            {
                lightSource.MValue = trackBar.Value;
                UpdateCanvas();
            }
        }

        private void SurfaceWaveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is CheckBox checkbox)
            {
                if(checkbox.Checked)
                {
                    stopwatch = new Stopwatch();
                    stopwatch.Start();
                    waveTimer.Start();
                }
                else
                {
                    waveTimer.Stop();
                    stopwatch.Stop();
                }
            }
        }
    }
}
