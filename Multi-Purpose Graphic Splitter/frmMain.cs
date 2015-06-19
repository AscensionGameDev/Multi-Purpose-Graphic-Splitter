using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Purpose_Graphic_Splitter
{
    public partial class frmMain : Form
    {
        private Bitmap sampleImg;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnChooseSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            grpStep2.Hide();
            grpStep3.Hide();
            btnSplit.Hide();
            txtDestination.Text = "";
            scrlSplitColumns.Value = 0;
            scrlSplitRows.Value = 0;
            lblSplitColumns.Text = "Split Columns: " + scrlSplitColumns.Value;
            lblSplitRows.Text = "Split Rows: " + scrlSplitRows.Value;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtSource.Text = fbd.SelectedPath;
                List<string> filenames = new List<string>();
                filenames.AddRange(Directory.GetFiles(fbd.SelectedPath, "*.png"));
                filenames.AddRange(Directory.GetFiles(fbd.SelectedPath, "*.bmp"));
                filenames.AddRange(Directory.GetFiles(fbd.SelectedPath, "*.gif"));
                filenames.Sort();
                if (filenames.Count > 0)
                {
                    grpStep2.Show();
                    grpStep3.Show();
                    sampleImg = new Bitmap(filenames[0]);
                    scrlSplitColumns.Maximum = sampleImg.Width - 1;
                    scrlSplitRows.Maximum = sampleImg.Height - 1;
                    UpdatePreview();
                }
                else
                {
                    MessageBox.Show("No images found. (Supported formats are .png, .bmp, and .gif)");
                }
            }
        }

        private void UpdatePreview()
        {
            int i = 0;
            int w = 0;
            int h = 0;
            Graphics g = pnlSampleImg.CreateGraphics();
            g.FillRectangle(Brushes.Transparent, new Rectangle(0, 0, pnlSampleImg.Width, pnlSampleImg.Height));
            g.DrawImage(sampleImg, new Point(0, 0));
            if (scrlSplitColumns.Value > 0)
            {
                i = scrlSplitColumns.Value + 1;
                w = sampleImg.Width / i;
                for (int x = 0; x < i; x++)
                {
                    g.DrawLine(Pens.Black, new Point(x * w, 0), new Point(x * w, sampleImg.Height));
                }
            }
            if (scrlSplitRows.Value > 0)
            {
                i = scrlSplitRows.Value + 1;
                h = sampleImg.Height / i;
                for (int x = 0; x < i; x++)
                {
                    g.DrawLine(Pens.Black, new Point(0, h * x), new Point(sampleImg.Width, h * x));
                }
            }
            g.Dispose();
        }

        private void scrlSplitColumns_Scroll(object sender, ScrollEventArgs e)
        {
            lblSplitColumns.Text = "Split Columns: " + scrlSplitColumns.Value;
            UpdatePreview();
        }

        private void scrlSplitRows_Scroll(object sender, ScrollEventArgs e)
        {
            lblSplitRows.Text = "Split Rows: " + scrlSplitRows.Value;
            UpdatePreview();
        }

        private void btnBrowseDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            btnSplit.Hide();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtDestination.Text = fbd.SelectedPath;
                List<string> filenames = new List<string>();
                filenames.AddRange(Directory.GetFiles(fbd.SelectedPath, "*"));
                if (filenames.Count == 0)
                {
                    btnSplit.Show();
                }
            }
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            Bitmap tmpBitmap;
            Bitmap saveBitmap;
            Graphics g;
            int w, h;
            int filenum = 1;

            //Get the files again
            List<string> filenames = new List<string>();
            filenames.AddRange(Directory.GetFiles(txtSource.Text, "*.png"));
            filenames.AddRange(Directory.GetFiles(txtSource.Text, "*.bmp"));
            filenames.AddRange(Directory.GetFiles(txtSource.Text, "*.gif"));
            filenames.Sort();

            for (int i = 0; i < filenames.Count; i++)
            {
                tmpBitmap = new Bitmap(filenames[i]);
                w = tmpBitmap.Width;
                h = tmpBitmap.Height;
                if (scrlSplitColumns.Value > 0)
                {
                    w = sampleImg.Width / (scrlSplitColumns.Value + 1);
                }
                if (scrlSplitRows.Value > 0)
                {
                    h = sampleImg.Height / (scrlSplitRows.Value + 1);
                }
                for (int x = 0; x < scrlSplitColumns.Value + 1; x++)
                {
                    for (int y = 0; y < scrlSplitRows.Value + 1; y++)
                    {
                        saveBitmap = new Bitmap(w, h);
                        g = Graphics.FromImage(saveBitmap);
                        g.DrawImage(tmpBitmap, new Rectangle(0, 0, w, h), new Rectangle(x * w, y * h, w, h), GraphicsUnit.Pixel);
                        g.Dispose();
                        saveBitmap.Save(txtDestination.Text + "/" + filenum + ".png", System.Drawing.Imaging.ImageFormat.Png);
                        filenum++;
                    }
                }
            }
            MessageBox.Show("Images successfully split! Image splitter courtosy of Ascension Game Dev. http://www.ascensiongamedev.com \nHave a great day!");
            Application.Exit();
        }

        void frmMain_Resize(object sender, System.EventArgs e)
        {
            if (sampleImg != null) { UpdatePreview(); }
        }

        void frmMain_VisibleChanged(object sender, System.EventArgs e)
        {
            if (sampleImg != null) { UpdatePreview(); }
        }
    }
}
