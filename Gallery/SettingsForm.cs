using GalleryData;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Gallery
{
    public partial class OptionsForm : Form
    {
        
        public OptionsForm()
        {
            InitializeComponent();
            // Window properties
            TopMost = true;
            MinimizeBox = false;
            MaximizeBox = false;
            StartPosition = FormStartPosition.Manual;
            Location = new Point(
                (Screen.PrimaryScreen.Bounds.Width / 2) - Size.Width ,
                (Screen.PrimaryScreen.Bounds.Height / 2) - Size.Height);
            // Display version
            VersionLabel.Text = System.Reflection.Assembly.GetExecutingAssembly()
                .GetName().Version.ToString();
            // Display filters
            foreach (var item in DataClass.filters)
            {
                FilterBox.Text += item.ToString() + " ";
            }
            // Display recursive state
            if (DataClass.recursiveLookup)
            {
                RecursiveRadioTrue.Checked = true;
                RecursiveRadioFalse.Checked = false;
            }
            else
            {
                RecursiveRadioTrue.Checked = false;
                RecursiveRadioFalse.Checked = true;
            }
            // Display size
            SizeXTrackBar.Value = DataClass.sizeX;
            SizeYTrackBar.Value = DataClass.sizeY;
            SizeXYLabel.Text = $"{SizeXTrackBar.Value} × {SizeYTrackBar.Value} px";
        }

        private void OptionsApplyButton_Click(object sender, EventArgs e)
        {
            DataClass.filters = FilterBox.Text.Split(' ').ToList();
            if (RecursiveRadioTrue.Checked)
                DataClass.recursiveLookup = true;
            else
                DataClass.recursiveLookup = false;
            Close();
        }

        private void OptionsCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SizeXTrackBar_Scroll(object sender, EventArgs e)
        {
            DataClass.sizeX = Convert.ToInt32(SizeXTrackBar.Value);
            SizeXYLabel.Text = $"{SizeXTrackBar.Value} × {SizeYTrackBar.Value} px";
        }

        private void SizeYTrackBar_Scroll(object sender, EventArgs e)
        {
            DataClass.sizeY = Convert.ToInt32(SizeYTrackBar.Value);
            SizeXYLabel.Text = $"{SizeXTrackBar.Value} × {SizeYTrackBar.Value} px";
        }

        private void OptionsDefaultsButton_Click(object sender, EventArgs e)
        {
            string[] defaultFilters = { "jpg", "jpeg", "jfif", "png", "gif", "tiff", "bmp", "svg" };
            DataClass.filters = defaultFilters.ToList();
            FilterBox.Text = "";
            foreach (var item in DataClass.filters)
            {
                FilterBox.Text += item.ToString() + " ";
            }
            DataClass.recursiveLookup = true;
            RecursiveRadioTrue.Checked = true;
            DataClass.sizeX = 102;
            DataClass.sizeY = 102;
            SizeXTrackBar.Value = DataClass.sizeX;
            SizeYTrackBar.Value = DataClass.sizeY;
            SizeXYLabel.Text = $"{SizeXTrackBar.Value} × {SizeYTrackBar.Value} px";
        }
    }
}
