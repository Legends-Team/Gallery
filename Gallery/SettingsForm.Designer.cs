
namespace Gallery
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.OptionsApplyButton = new System.Windows.Forms.Button();
            this.RecursivePanel = new System.Windows.Forms.Panel();
            this.RecursiveRadioFalse = new System.Windows.Forms.RadioButton();
            this.RecursiveRadioTrue = new System.Windows.Forms.RadioButton();
            this.FilterBox = new System.Windows.Forms.TextBox();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.RecursiveLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.OptionsCancelButton = new System.Windows.Forms.Button();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.SizeXTrackBar = new System.Windows.Forms.TrackBar();
            this.SizeXYLabel = new System.Windows.Forms.Label();
            this.SizeYTrackBar = new System.Windows.Forms.TrackBar();
            this.OptionsDefaultsButton = new System.Windows.Forms.Button();
            this.RecursivePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeXTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeYTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // OptionsApplyButton
            // 
            this.OptionsApplyButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OptionsApplyButton.Location = new System.Drawing.Point(390, 193);
            this.OptionsApplyButton.Name = "OptionsApplyButton";
            this.OptionsApplyButton.Size = new System.Drawing.Size(80, 31);
            this.OptionsApplyButton.TabIndex = 5;
            this.OptionsApplyButton.Text = "Apply";
            this.OptionsApplyButton.UseVisualStyleBackColor = true;
            this.OptionsApplyButton.Click += new System.EventHandler(this.OptionsApplyButton_Click);
            // 
            // RecursivePanel
            // 
            this.RecursivePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RecursivePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RecursivePanel.Controls.Add(this.RecursiveRadioFalse);
            this.RecursivePanel.Controls.Add(this.RecursiveRadioTrue);
            this.RecursivePanel.Location = new System.Drawing.Point(150, 51);
            this.RecursivePanel.Name = "RecursivePanel";
            this.RecursivePanel.Size = new System.Drawing.Size(320, 31);
            this.RecursivePanel.TabIndex = 1;
            // 
            // RecursiveRadioFalse
            // 
            this.RecursiveRadioFalse.AutoSize = true;
            this.RecursiveRadioFalse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RecursiveRadioFalse.Location = new System.Drawing.Point(148, 4);
            this.RecursiveRadioFalse.Name = "RecursiveRadioFalse";
            this.RecursiveRadioFalse.Size = new System.Drawing.Size(103, 19);
            this.RecursiveRadioFalse.TabIndex = 2;
            this.RecursiveRadioFalse.Text = "Non-Recursive";
            this.RecursiveRadioFalse.UseVisualStyleBackColor = true;
            // 
            // RecursiveRadioTrue
            // 
            this.RecursiveRadioTrue.AutoSize = true;
            this.RecursiveRadioTrue.Checked = true;
            this.RecursiveRadioTrue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RecursiveRadioTrue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RecursiveRadioTrue.Location = new System.Drawing.Point(42, 2);
            this.RecursiveRadioTrue.Name = "RecursiveRadioTrue";
            this.RecursiveRadioTrue.Size = new System.Drawing.Size(84, 23);
            this.RecursiveRadioTrue.TabIndex = 1;
            this.RecursiveRadioTrue.TabStop = true;
            this.RecursiveRadioTrue.Text = "Recursive";
            this.RecursiveRadioTrue.UseVisualStyleBackColor = true;
            // 
            // FilterBox
            // 
            this.FilterBox.Location = new System.Drawing.Point(76, 12);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(394, 23);
            this.FilterBox.TabIndex = 0;
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilterLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FilterLabel.Location = new System.Drawing.Point(12, 12);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(58, 25);
            this.FilterLabel.TabIndex = 50;
            this.FilterLabel.Text = "Filters";
            // 
            // RecursiveLabel
            // 
            this.RecursiveLabel.AutoSize = true;
            this.RecursiveLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RecursiveLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RecursiveLabel.Location = new System.Drawing.Point(12, 51);
            this.RecursiveLabel.Name = "RecursiveLabel";
            this.RecursiveLabel.Size = new System.Drawing.Size(132, 25);
            this.RecursiveLabel.TabIndex = 51;
            this.RecursiveLabel.Text = "Sub-directories";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.VersionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VersionLabel.Location = new System.Drawing.Point(12, 212);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(40, 15);
            this.VersionLabel.TabIndex = 54;
            this.VersionLabel.Text = "0.0.0.0";
            // 
            // OptionsCancelButton
            // 
            this.OptionsCancelButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OptionsCancelButton.Location = new System.Drawing.Point(306, 193);
            this.OptionsCancelButton.Name = "OptionsCancelButton";
            this.OptionsCancelButton.Size = new System.Drawing.Size(80, 31);
            this.OptionsCancelButton.TabIndex = 6;
            this.OptionsCancelButton.Text = "Cancel";
            this.OptionsCancelButton.UseVisualStyleBackColor = true;
            this.OptionsCancelButton.Click += new System.EventHandler(this.OptionsCancelButton_Click);
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SizeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SizeLabel.Location = new System.Drawing.Point(12, 92);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(83, 25);
            this.SizeLabel.TabIndex = 52;
            this.SizeLabel.Text = "Grid size:";
            // 
            // SizeXTrackBar
            // 
            this.SizeXTrackBar.Location = new System.Drawing.Point(150, 92);
            this.SizeXTrackBar.Maximum = 200;
            this.SizeXTrackBar.Minimum = 1;
            this.SizeXTrackBar.Name = "SizeXTrackBar";
            this.SizeXTrackBar.Size = new System.Drawing.Size(320, 45);
            this.SizeXTrackBar.TabIndex = 3;
            this.SizeXTrackBar.Value = 1;
            this.SizeXTrackBar.Scroll += new System.EventHandler(this.SizeXTrackBar_Scroll);
            // 
            // SizeXYLabel
            // 
            this.SizeXYLabel.AutoSize = true;
            this.SizeXYLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SizeXYLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SizeXYLabel.Location = new System.Drawing.Point(12, 130);
            this.SizeXYLabel.Name = "SizeXYLabel";
            this.SizeXYLabel.Size = new System.Drawing.Size(118, 25);
            this.SizeXYLabel.TabIndex = 53;
            this.SizeXYLabel.Text = "000 × 000 px";
            // 
            // SizeYTrackBar
            // 
            this.SizeYTrackBar.Location = new System.Drawing.Point(150, 130);
            this.SizeYTrackBar.Maximum = 200;
            this.SizeYTrackBar.Minimum = 1;
            this.SizeYTrackBar.Name = "SizeYTrackBar";
            this.SizeYTrackBar.Size = new System.Drawing.Size(320, 45);
            this.SizeYTrackBar.TabIndex = 4;
            this.SizeYTrackBar.Value = 1;
            this.SizeYTrackBar.Scroll += new System.EventHandler(this.SizeYTrackBar_Scroll);
            // 
            // OptionsDefaultsButton
            // 
            this.OptionsDefaultsButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OptionsDefaultsButton.Location = new System.Drawing.Point(222, 193);
            this.OptionsDefaultsButton.Name = "OptionsDefaultsButton";
            this.OptionsDefaultsButton.Size = new System.Drawing.Size(80, 31);
            this.OptionsDefaultsButton.TabIndex = 7;
            this.OptionsDefaultsButton.Text = "Defaults";
            this.OptionsDefaultsButton.UseVisualStyleBackColor = true;
            this.OptionsDefaultsButton.Click += new System.EventHandler(this.OptionsDefaultsButton_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(484, 236);
            this.Controls.Add(this.OptionsDefaultsButton);
            this.Controls.Add(this.SizeYTrackBar);
            this.Controls.Add(this.SizeXYLabel);
            this.Controls.Add(this.SizeXTrackBar);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.OptionsCancelButton);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.RecursiveLabel);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.FilterBox);
            this.Controls.Add(this.RecursivePanel);
            this.Controls.Add(this.OptionsApplyButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 275);
            this.MinimumSize = new System.Drawing.Size(500, 275);
            this.Name = "OptionsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Options";
            this.RecursivePanel.ResumeLayout(false);
            this.RecursivePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeXTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeYTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OptionsApplyButton;
        private System.Windows.Forms.Panel RecursivePanel;
        private System.Windows.Forms.RadioButton RecursiveRadioFalse;
        private System.Windows.Forms.RadioButton RecursiveRadioTrue;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.Label RecursiveLabel;
        protected internal System.Windows.Forms.TextBox FilterBox;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Button OptionsCancelButton;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label SizeXYLabel;
        private System.Windows.Forms.TrackBar SizeXTrackBar;
        private System.Windows.Forms.TrackBar SizeYTrackBar;
        private System.Windows.Forms.Button OptionsDefaultsButton;
    }
}