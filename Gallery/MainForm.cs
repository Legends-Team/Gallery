using GalleryData;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Gallery
{
    public partial class MainForm : Form
    {
        // Fields
        private Size preferedSize;
        private VScrollBar vbar;

        // Initialization
        public MainForm()
        {
            InitializeComponent();
            vbar = new VScrollBar();
            vbar.Height = MainPanel.Height;
            vbar.Location = new Point(MainPanel.Width - vbar.Width, MainPanel.Height - vbar.Height);
            vbar.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            vbar.Value = 0;
            vbar.Minimum = 0;
            vbar.Maximum = MainPanel.Height;
            vbar.SmallChange = 50;
            preferedSize = new Size(0, DataClass.sizeY);
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
                MessageBox.Show("Directory not found", "Warning: " + e.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return new List<string>();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return new List<string>();
            }
        }

        // Window sizing options
        private void ResizeWindow()
        {
            MainForm.ActiveForm.AutoSize = false;
            MainForm.ActiveForm.AutoScroll = false;
            MainForm.ActiveForm.VerticalScroll.Enabled = true;
            MainForm.ActiveForm.HorizontalScroll.Enabled = false;
            MainForm.ActiveForm.HorizontalScroll.Maximum = 0;
        }

        // Panel sizing options
        private void ResizePanel()
        {
            MainPanel.AutoScroll = false;
            MainPanel.AutoSize = false;
            MainPanel.AutoSizeMode = AutoSizeMode.GrowOnly;
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
            MediaBox.Anchor = AnchorStyles.Right;
            MediaBox.Size = new Size(DataClass.sizeX, DataClass.sizeY);
            MediaBox.SizeMode = PictureBoxSizeMode.StretchImage;

            try
            {
                MediaBox.Image = Image.FromFile(file);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Loading error");
            }

            MainPanel.Controls.Add(MediaBox);

            RedrawMediaBox(DrawX, DrawY, MediaBox);

            MediaBox.Click += (sender, EventArgs) =>
            {
                DataClass.OpenPhotos(file);
            };

        }

        // Show images based on the window size
        private static void RedrawMediaBox(int DrawX, int DrawY, PictureBox MediaBox)
        {
            MediaBox.Location = new Point(DrawX, DrawY);
            MediaBox.Show();
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

        // Prepare everything
        private void ActivateSequence()
        {
            DisposeControls();
            ResizeWindow();
            ResizePanel();
            Draw(FindFiles());
            ScrollPanel();
        }

        // Reimplement scrolling in MainPanel
        private void ScrollPanel()
        {
            MainPanel.Controls.Add(vbar);

            vbar.Scroll += (sender, EventArgs) =>
            {
                var DrawX = 0;
                var DrawY = 0;
                var counter = 0;

                try
                {
                    foreach (PictureBox control in MainPanel.Controls.OfType<PictureBox>())
                    {
                        control.Location = new Point(DrawX, DrawY - vbar.Value);
                        DrawX += DataClass.sizeX;
                        if (DrawX >= (MainPanel.Width) - DataClass.sizeX)
                        {
                            DrawX = 0;
                            DrawY += DataClass.sizeY;
                            counter++;
                        }
                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    vbar.Value = vbar.Minimum;
                    MessageBox.Show(e.Message, "Warning: " + e.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                vbar.Maximum = (DataClass.sizeY * counter);
                ActiveControl = vbar;
                vbar.Focus();
            };

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
            ActivateSequence();
        }

        // Key press behaviors
        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                ActivateSequence();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                Application.Exit();
            }
        }

        // Redraw on window resize
        private void MainPanel_SizeChanged(object sender, EventArgs e)
        {
            var DrawX = 0;
            var DrawY = 0;

            foreach (PictureBox control in MainPanel.Controls.OfType<PictureBox>())
            {
                RedrawMediaBox(DrawX, DrawY, control);
                DrawX += DataClass.sizeX;
                if (DrawX >= (MainPanel.Width) - DataClass.sizeX)
                {
                    DrawX = 0;
                    DrawY += DataClass.sizeY;
                }
            }
        }
    }
}
