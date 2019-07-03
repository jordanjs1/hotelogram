namespace Hotelogram
{
    partial class DLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DLogin));
            this.PictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.LabelContent = new System.Windows.Forms.Label();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.PanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.TextBoxUserName = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.PanelShowPassword = new System.Windows.Forms.Panel();
            this.PictureBoxFooterIcon = new System.Windows.Forms.PictureBox();
            this.LabelFooter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).BeginInit();
            this.PanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFooterIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxIcon
            // 
            this.PictureBoxIcon.Image = global::Hotelogram.Properties.Resources.password_win10_32;
            this.PictureBoxIcon.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxIcon.Name = "PictureBoxIcon";
            this.PictureBoxIcon.Size = new System.Drawing.Size(32, 32);
            this.PictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxIcon.TabIndex = 0;
            this.PictureBoxIcon.TabStop = false;
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.LabelHeader.Location = new System.Drawing.Point(50, 9);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(154, 21);
            this.LabelHeader.TabIndex = 1;
            this.LabelHeader.Text = "Login to Hotelogram";
            // 
            // LabelContent
            // 
            this.LabelContent.AutoSize = true;
            this.LabelContent.Location = new System.Drawing.Point(12, 47);
            this.LabelContent.Name = "LabelContent";
            this.LabelContent.Size = new System.Drawing.Size(264, 13);
            this.LabelContent.TabIndex = 3;
            this.LabelContent.Text = "Please enter your credentials to login to the program.";
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.Location = new System.Drawing.Point(12, 77);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(63, 13);
            this.LabelUserName.TabIndex = 4;
            this.LabelUserName.Text = "User Name:";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(12, 104);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(57, 13);
            this.LabelPassword.TabIndex = 5;
            this.LabelPassword.Text = "Password:";
            // 
            // PanelButtons
            // 
            this.PanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelButtons.BackColor = System.Drawing.SystemColors.Control;
            this.PanelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelButtons.Controls.Add(this.ButtonExit);
            this.PanelButtons.Controls.Add(this.ButtonLogin);
            this.PanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.PanelButtons.Location = new System.Drawing.Point(-1, 160);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Padding = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.PanelButtons.Size = new System.Drawing.Size(280, 41);
            this.PanelButtons.TabIndex = 6;
            // 
            // ButtonExit
            // 
            this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonExit.Location = new System.Drawing.Point(195, 8);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 23);
            this.ButtonExit.TabIndex = 8;
            this.ButtonExit.Text = "&Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Location = new System.Drawing.Point(114, 8);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(75, 23);
            this.ButtonLogin.TabIndex = 7;
            this.ButtonLogin.Text = "&Login";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxUserName.Location = new System.Drawing.Point(80, 74);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(190, 21);
            this.TextBoxUserName.TabIndex = 7;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPassword.Location = new System.Drawing.Point(80, 101);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(150, 21);
            this.TextBoxPassword.TabIndex = 8;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            // 
            // PanelShowPassword
            // 
            this.PanelShowPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelShowPassword.BackColor = System.Drawing.SystemColors.Control;
            this.PanelShowPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelShowPassword.Location = new System.Drawing.Point(236, 101);
            this.PanelShowPassword.Name = "PanelShowPassword";
            this.PanelShowPassword.Size = new System.Drawing.Size(34, 21);
            this.PanelShowPassword.TabIndex = 9;
            this.PanelShowPassword.MouseEnter += new System.EventHandler(this.panelShowPassword_MouseEnter);
            this.PanelShowPassword.MouseLeave += new System.EventHandler(this.panelShowPassword_MouseLeave);
            // 
            // PictureBoxFooterIcon
            // 
            this.PictureBoxFooterIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureBoxFooterIcon.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxFooterIcon.Image")));
            this.PictureBoxFooterIcon.Location = new System.Drawing.Point(12, 138);
            this.PictureBoxFooterIcon.Name = "PictureBoxFooterIcon";
            this.PictureBoxFooterIcon.Size = new System.Drawing.Size(16, 16);
            this.PictureBoxFooterIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxFooterIcon.TabIndex = 10;
            this.PictureBoxFooterIcon.TabStop = false;
            // 
            // LabelFooter
            // 
            this.LabelFooter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelFooter.AutoSize = true;
            this.LabelFooter.Location = new System.Drawing.Point(30, 139);
            this.LabelFooter.Name = "LabelFooter";
            this.LabelFooter.Size = new System.Drawing.Size(235, 13);
            this.LabelFooter.TabIndex = 11;
            this.LabelFooter.Text = "Hover mouse over gray panel to see password.";
            // 
            // DLogin
            // 
            this.AcceptButton = this.ButtonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.ButtonExit;
            this.ClientSize = new System.Drawing.Size(277, 200);
            this.Controls.Add(this.LabelFooter);
            this.Controls.Add(this.PictureBoxFooterIcon);
            this.Controls.Add(this.PanelShowPassword);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUserName);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelUserName);
            this.Controls.Add(this.LabelContent);
            this.Controls.Add(this.LabelHeader);
            this.Controls.Add(this.PictureBoxIcon);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(9999, 239);
            this.MinimumSize = new System.Drawing.Size(293, 239);
            this.Name = "DLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login | Hotelogram";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DLogin_FormClosing);
            this.Load += new System.EventHandler(this.DLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFooterIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxIcon;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.Label LabelContent;
        private System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.FlowLayoutPanel PanelButtons;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.TextBox TextBoxUserName;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Panel PanelShowPassword;
        private System.Windows.Forms.PictureBox PictureBoxFooterIcon;
        private System.Windows.Forms.Label LabelFooter;
    }
}