namespace Hotelogram
{
    partial class FQueryDatabase
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
            this.PictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.LabelSubheader = new System.Windows.Forms.Label();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.TextBoxOutput = new System.Windows.Forms.TextBox();
            this.SplitContainerMain = new System.Windows.Forms.SplitContainer();
            this.ButtonQuery = new System.Windows.Forms.Button();
            this.ButtonClearIpnut = new System.Windows.Forms.Button();
            this.ButtonClearOutput = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.PanelButtons = new Hotelogram.BorderedFlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).BeginInit();
            this.SplitContainerMain.Panel1.SuspendLayout();
            this.SplitContainerMain.Panel2.SuspendLayout();
            this.SplitContainerMain.SuspendLayout();
            this.PanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBoxIcon
            // 
            this.PictureBoxIcon.Image = global::Hotelogram.Properties.Resources.question_win10_32;
            this.PictureBoxIcon.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxIcon.Name = "PictureBoxIcon";
            this.PictureBoxIcon.Size = new System.Drawing.Size(32, 32);
            this.PictureBoxIcon.TabIndex = 0;
            this.PictureBoxIcon.TabStop = false;
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.LabelHeader.Location = new System.Drawing.Point(50, 12);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(150, 21);
            this.LabelHeader.TabIndex = 1;
            this.LabelHeader.Text = "Query The Database";
            // 
            // LabelSubheader
            // 
            this.LabelSubheader.AutoSize = true;
            this.LabelSubheader.Location = new System.Drawing.Point(51, 31);
            this.LabelSubheader.Name = "LabelSubheader";
            this.LabelSubheader.Size = new System.Drawing.Size(308, 13);
            this.LabelSubheader.TabIndex = 2;
            this.LabelSubheader.Text = "Here you can send queries to the database and obtain results.";
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxInput.Location = new System.Drawing.Point(0, 0);
            this.TextBoxInput.Multiline = true;
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(214, 239);
            this.TextBoxInput.TabIndex = 3;
            // 
            // TextBoxOutput
            // 
            this.TextBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.TextBoxOutput.Multiline = true;
            this.TextBoxOutput.Name = "TextBoxOutput";
            this.TextBoxOutput.ReadOnly = true;
            this.TextBoxOutput.Size = new System.Drawing.Size(210, 239);
            this.TextBoxOutput.TabIndex = 4;
            // 
            // SplitContainerMain
            // 
            this.SplitContainerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplitContainerMain.Location = new System.Drawing.Point(12, 50);
            this.SplitContainerMain.Name = "SplitContainerMain";
            // 
            // SplitContainerMain.Panel1
            // 
            this.SplitContainerMain.Panel1.Controls.Add(this.TextBoxInput);
            // 
            // SplitContainerMain.Panel2
            // 
            this.SplitContainerMain.Panel2.Controls.Add(this.TextBoxOutput);
            this.SplitContainerMain.Size = new System.Drawing.Size(432, 241);
            this.SplitContainerMain.SplitterDistance = 216;
            this.SplitContainerMain.TabIndex = 6;
            // 
            // ButtonQuery
            // 
            this.ButtonQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonQuery.Location = new System.Drawing.Point(450, 50);
            this.ButtonQuery.Name = "ButtonQuery";
            this.ButtonQuery.Size = new System.Drawing.Size(75, 23);
            this.ButtonQuery.TabIndex = 7;
            this.ButtonQuery.Text = "Query";
            this.ButtonQuery.UseVisualStyleBackColor = true;
            this.ButtonQuery.Click += new System.EventHandler(this.ButtonQuery_Click);
            // 
            // ButtonClearIpnut
            // 
            this.ButtonClearIpnut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClearIpnut.Location = new System.Drawing.Point(450, 79);
            this.ButtonClearIpnut.Name = "ButtonClearIpnut";
            this.ButtonClearIpnut.Size = new System.Drawing.Size(75, 23);
            this.ButtonClearIpnut.TabIndex = 8;
            this.ButtonClearIpnut.Text = "Clear input";
            this.ButtonClearIpnut.UseVisualStyleBackColor = true;
            // 
            // ButtonClearOutput
            // 
            this.ButtonClearOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClearOutput.Location = new System.Drawing.Point(450, 108);
            this.ButtonClearOutput.Name = "ButtonClearOutput";
            this.ButtonClearOutput.Size = new System.Drawing.Size(75, 23);
            this.ButtonClearOutput.TabIndex = 9;
            this.ButtonClearOutput.Text = "Clear output";
            this.ButtonClearOutput.UseVisualStyleBackColor = true;
            // 
            // ButtonClose
            // 
            this.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonClose.Location = new System.Drawing.Point(451, 10);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
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
            this.PanelButtons.Location = new System.Drawing.Point(-1, 297);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Padding = new System.Windows.Forms.Padding(0, 7, 6, 0);
            this.PanelButtons.Size = new System.Drawing.Size(535, 43);
            this.PanelButtons.TabIndex = 5;
            // 
            // FQueryDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.ButtonClose;
            this.ClientSize = new System.Drawing.Size(533, 339);
            this.Controls.Add(this.ButtonClearOutput);
            this.Controls.Add(this.ButtonClearIpnut);
            this.Controls.Add(this.LabelHeader);
            this.Controls.Add(this.ButtonQuery);
            this.Controls.Add(this.SplitContainerMain);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.LabelSubheader);
            this.Controls.Add(this.PictureBoxIcon);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FQueryDatabase";
            this.Text = "Query The Database | Hotelogram";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).EndInit();
            this.SplitContainerMain.Panel1.ResumeLayout(false);
            this.SplitContainerMain.Panel1.PerformLayout();
            this.SplitContainerMain.Panel2.ResumeLayout(false);
            this.SplitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).EndInit();
            this.SplitContainerMain.ResumeLayout(false);
            this.PanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxIcon;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.Label LabelSubheader;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.TextBox TextBoxOutput;
        private BorderedFlowLayoutPanel PanelButtons;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.SplitContainer SplitContainerMain;
        private System.Windows.Forms.Button ButtonQuery;
        private System.Windows.Forms.Button ButtonClearIpnut;
        private System.Windows.Forms.Button ButtonClearOutput;
    }
}