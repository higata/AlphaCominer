using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlpaCombiner
{
    public partial class MainWindow : Form
    {
        AppConfig config = new AppConfig();
        AlphaCombinerLogic logic = new AlphaCombinerLogic();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.Text = "AlphaCombiner -v" + Program.version;
            if (config.LastWindowSize.Width == 0)
            {
                this.ClientSize = new System.Drawing.Size(800, 450);
            }
            else
            {
                this.ClientSize = config.LastWindowSize;
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            config.LastWindowSize = this.ClientSize;
            config.Save();
        }

        private void SrcImageOpenButton_Click(object sender, EventArgs e)
        {
            var img = OpenPNGFileImage(true);
            if (img != null)
            {
                srcImagebox.Image = img;
            }
        }
        private void GrayImageOpenButton_Click(object sender, EventArgs e)
        {
            var img = OpenPNGFileImage(false);
            if (img != null)
            {
                grayImagebox.Image = img;
            }
        }
        private Image OpenPNGFileImage(bool isSrc)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string p = isSrc ? config.LastLoadedSrcImagePath : config.LastLoadedGrayscaleImagePath;
                if (p == null
                    || p.Equals("")
                    || Directory.Exists(p) == false)
                {
                    openFileDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                }
                else
                {
                    openFileDialog.InitialDirectory = p;
                }
                openFileDialog.Filter = "png files (*.png)|*.png";
                openFileDialog.FilterIndex = 0;
                openFileDialog.RestoreDirectory = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Console.WriteLine(openFileDialog.FileName);

                    if (isSrc)
                    {
                        config.LastLoadedSrcImagePath = Path.GetDirectoryName(openFileDialog.FileName);
                    }
                    else
                    {
                        config.LastLoadedGrayscaleImagePath = Path.GetDirectoryName(openFileDialog.FileName);
                    }
                    config.Save();

                    return Image.FromFile(openFileDialog.FileName);
                }
            }
            return null;
        }

        private void ExecButton_Click(object sender, EventArgs e)
        {
            if (srcImagebox.Image == null || grayImagebox.Image == null)
            {
                SystemSounds.Beep.Play();
                return;
            }
            var result = logic.Combine(srcImagebox.Image, grayImagebox.Image, isAlphaKeepCheck.Checked);
            if (result != null)
            {
                resultImageBox.Image = result;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (resultImageBox.Image == null)
            {
                SystemSounds.Beep.Play();
                return;
            }
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                string p = config.LastSaveResultImagePath;
                if (p == null
                    || p.Equals("")
                    || Directory.Exists(p) == false)
                {
                    saveFileDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                }
                else
                {
                    saveFileDialog.InitialDirectory = p;
                }
                saveFileDialog.Filter = "png files (*.png)|*.png";
                saveFileDialog.FilterIndex = 0;
                saveFileDialog.RestoreDirectory = false;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    config.LastSaveResultImagePath = Path.GetDirectoryName(saveFileDialog.FileName);
                    config.Save();
                    resultImageBox.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
                }
            }
        }
    }
}
