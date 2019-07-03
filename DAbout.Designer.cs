namespace Hotelogram
{
    partial class DAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DAbout));
            this.LabelContent = new System.Windows.Forms.Label();
            this.PictureBoxKTO = new System.Windows.Forms.PictureBox();
            this.PictureBoxIT = new System.Windows.Forms.PictureBox();
            this.LabelWrittenBy = new System.Windows.Forms.Label();
            this.TextBoxInformation = new System.Windows.Forms.TextBox();
            this.LabelInstructor = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.PanelButtons = new Hotelogram.BorderedFlowLayoutPanel();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.panelHeader = new Hotelogram.BorderedFlowLayoutPanel();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.PictureBoxHotelogram = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxKTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIT)).BeginInit();
            this.PanelButtons.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHotelogram)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelContent
            // 
            this.LabelContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelContent.Location = new System.Drawing.Point(7, 148);
            this.LabelContent.Name = "LabelContent";
            this.LabelContent.Size = new System.Drawing.Size(579, 29);
            this.LabelContent.TabIndex = 4;
            this.LabelContent.Text = "Hotelogram is a hotel management automation solution written as a Object Oriented" +
    " Programming course project. This project is later adapted to have a RDF databas" +
    "e for Semantic Web course project.";
            // 
            // PictureBoxKTO
            // 
            this.PictureBoxKTO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxKTO.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxKTO.Image = global::Hotelogram.Properties.Resources.KTO_Karatay_Üniversitesi_Logo;
            this.PictureBoxKTO.Location = new System.Drawing.Point(364, 225);
            this.PictureBoxKTO.Name = "PictureBoxKTO";
            this.PictureBoxKTO.Size = new System.Drawing.Size(220, 144);
            this.PictureBoxKTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxKTO.TabIndex = 7;
            this.PictureBoxKTO.TabStop = false;
            // 
            // PictureBoxIT
            // 
            this.PictureBoxIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureBoxIT.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxIT.Image = global::Hotelogram.Properties.Resources.IT_Hotelogram1;
            this.PictureBoxIT.Location = new System.Drawing.Point(7, 225);
            this.PictureBoxIT.Name = "PictureBoxIT";
            this.PictureBoxIT.Size = new System.Drawing.Size(144, 144);
            this.PictureBoxIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxIT.TabIndex = 6;
            this.PictureBoxIT.TabStop = false;
            // 
            // LabelWrittenBy
            // 
            this.LabelWrittenBy.AutoSize = true;
            this.LabelWrittenBy.Location = new System.Drawing.Point(7, 177);
            this.LabelWrittenBy.Name = "LabelWrittenBy";
            this.LabelWrittenBy.Size = new System.Drawing.Size(62, 13);
            this.LabelWrittenBy.TabIndex = 8;
            this.LabelWrittenBy.Text = "Written by:";
            // 
            // TextBoxInformation
            // 
            this.TextBoxInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxInformation.BackColor = System.Drawing.Color.White;
            this.TextBoxInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxInformation.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextBoxInformation.Location = new System.Drawing.Point(66, 177);
            this.TextBoxInformation.Multiline = true;
            this.TextBoxInformation.Name = "TextBoxInformation";
            this.TextBoxInformation.ReadOnly = true;
            this.TextBoxInformation.Size = new System.Drawing.Size(267, 40);
            this.TextBoxInformation.TabIndex = 9;
            this.TextBoxInformation.Text = "Ş. Mert \"InfraTau\" BÜYÜKKALKAN\r\nComputer Engineering Department 4th Class\r\n215013" +
    "23";
            // 
            // LabelInstructor
            // 
            this.LabelInstructor.AutoSize = true;
            this.LabelInstructor.Location = new System.Drawing.Point(157, 343);
            this.LabelInstructor.Name = "LabelInstructor";
            this.LabelInstructor.Size = new System.Drawing.Size(175, 13);
            this.LabelInstructor.TabIndex = 10;
            this.LabelInstructor.Text = "Course instructor: Semih YUMUŞAK";
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.Location = new System.Drawing.Point(157, 356);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(135, 13);
            this.LabelVersion.TabIndex = 11;
            this.LabelVersion.Text = "v0.3 Build 21062019_1210";
            // 
            // PanelButtons
            // 
            this.PanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelButtons.BackColor = System.Drawing.SystemColors.Control;
            this.PanelButtons.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.PanelButtons.BorderDraw = true;
            this.PanelButtons.BorderWidth = 1;
            this.PanelButtons.Controls.Add(this.ButtonClose);
            this.PanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.PanelButtons.GradientColors = new System.Drawing.Color[] {
        System.Drawing.Color.SkyBlue,
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DodgerBlue};
            this.PanelButtons.GradientEnable = false;
            this.PanelButtons.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.PanelButtons.GradientPositions = new float[] {
        0F,
        0.5F,
        1F};
            this.PanelButtons.Location = new System.Drawing.Point(-1, 375);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Padding = new System.Windows.Forms.Padding(0, 6, 6, 0);
            this.PanelButtons.Size = new System.Drawing.Size(594, 43);
            this.PanelButtons.TabIndex = 3;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(510, 9);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BorderColor = System.Drawing.Color.Cyan;
            this.panelHeader.BorderDraw = false;
            this.panelHeader.BorderWidth = 1;
            this.panelHeader.Controls.Add(this.PictureBoxLogo);
            this.panelHeader.Controls.Add(this.PictureBoxHotelogram);
            this.panelHeader.GradientColors = new System.Drawing.Color[] {
        System.Drawing.Color.DodgerBlue,
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.SkyBlue};
            this.panelHeader.GradientEnable = true;
            this.panelHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.panelHeader.GradientPositions = new float[] {
        0F,
        0.5F,
        1F};
            this.panelHeader.Location = new System.Drawing.Point(-1, -1);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.panelHeader.Size = new System.Drawing.Size(594, 143);
            this.panelHeader.TabIndex = 5;
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxLogo.Image = global::Hotelogram.Properties.Resources.Hotelogram_128;
            this.PictureBoxLogo.Location = new System.Drawing.Point(8, 8);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(128, 128);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBoxLogo.TabIndex = 0;
            this.PictureBoxLogo.TabStop = false;
            // 
            // PictureBoxHotelogram
            // 
            this.PictureBoxHotelogram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxHotelogram.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxHotelogram.Image = global::Hotelogram.Properties.Resources.Hotelogram__Label__Segoe_UI__Shadow;
            this.PictureBoxHotelogram.Location = new System.Drawing.Point(142, 8);
            this.PictureBoxHotelogram.Name = "PictureBoxHotelogram";
            this.PictureBoxHotelogram.Size = new System.Drawing.Size(416, 128);
            this.PictureBoxHotelogram.TabIndex = 1;
            this.PictureBoxHotelogram.TabStop = false;
            // 
            // DAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 417);
            this.Controls.Add(this.LabelInstructor);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.TextBoxInformation);
            this.Controls.Add(this.LabelWrittenBy);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.PictureBoxKTO);
            this.Controls.Add(this.PictureBoxIT);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.LabelContent);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About | Hotelogram";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DAbout_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxKTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIT)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHotelogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private BorderedFlowLayoutPanel PanelButtons;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label LabelContent;
        private BorderedFlowLayoutPanel panelHeader;
        private System.Windows.Forms.PictureBox PictureBoxIT;
        private System.Windows.Forms.PictureBox PictureBoxKTO;
        private System.Windows.Forms.PictureBox PictureBoxHotelogram;
        private System.Windows.Forms.Label LabelWrittenBy;
        private System.Windows.Forms.TextBox TextBoxInformation;
        private System.Windows.Forms.Label LabelInstructor;
        private System.Windows.Forms.Label LabelVersion;
    }
}