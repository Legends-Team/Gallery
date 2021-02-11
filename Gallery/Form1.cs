using GalleryData;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Gallery
{
    public partial class Form1 : Form
    {
        // Initialization
        public Form1()
        {
            InitializeComponent();
            MainPanel.HorizontalScroll.Maximum = 0;
        }

        // Clean up MainPanel
        private void DisposeControls()
        {
            MainPanel.Controls.Clear();
            foreach (Control control in MainPanel.Controls)
            {
                control.Dispose();
            }
        }

        // Search for files
        private List<string> FindFiles()
        {
            try
            {
                return DataClass.GetFilesFrom(ManagePath(), DataClass.filters.ToArray(), DataClass.recursiveLookup);
            }
            catch (DirectoryNotFoundException e)
            {
                MessageBox.Show("Directory not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return new List<string>();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return new List<string>();
            }
        }

        // Draw in DrawPanel
        private void Draw(List<string> files)
        {
            if (files.Count < 1)
            {
                if (ZeroFilesFound())
                    Draw(FindFiles());
            }

            var DrawX = 0;
            var DrawY = 0;

            foreach (var file in files)
            {
                DrawMediaBox(file, DrawX, DrawY);

                DrawX += DataClass.sizeX;
                if (DrawX >= (MainPanel.Width) - DataClass.sizeX)
                {
                    DrawX = 0;
                    DrawY += DataClass.sizeY;
                }
            }
        }

        // Retry Draw
        private bool ZeroFilesFound()
        {
            var selectedOption = MessageBox.Show("No files found. Try changing the search filters.", "Info",
                   MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            if (selectedOption == DialogResult.Retry)
                return true;
            else
                return false;
        }

        // Show all the images
        private void DrawMediaBox(string file, int DrawX, int DrawY)
        {
            PictureBox MediaBox = new PictureBox();
            MediaBox.Size = new Size(DataClass.sizeX, DataClass.sizeY);
            try
            {
                MediaBox.Image = Image.FromFile(file);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            MediaBox.SizeMode = PictureBoxSizeMode.StretchImage;
            MainPanel.Controls.Add(MediaBox);
            MediaBox.Location = new Point(DrawX, DrawY);
            MediaBox.Show();

            MediaBox.Click += (sender, EventArgs) =>
            {
                DataClass.OpenPhotos(file);
            };

        }

        // Path to directory
        private string ManagePath()
        {
            string path = string.Empty;
            if (SearchBox.Text.Equals(string.Empty))
            {
                path = Path.GetDirectoryName(Application.ExecutablePath);
                SearchBox.Text = path.ToString();
            }
            else
            {
                path = SearchBox.Text;
            }
            return path;
        }

        // Show options
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm = new OptionsForm();
            optionsForm.Show();
        }

        // Initiate search
        private void SearchButton_Click(object sender, EventArgs e)
        {
            DisposeControls();
            Draw(FindFiles());
        }
    }
}
