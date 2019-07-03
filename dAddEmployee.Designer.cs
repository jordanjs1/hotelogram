namespace Hotelogram
{
    partial class DAddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DAddEmployee));
            this.LabelHeader = new System.Windows.Forms.Label();
            this.PanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.LabelJob = new System.Windows.Forms.Label();
            this.TextBoxJob = new System.Windows.Forms.TextBox();
            this.LabelWorkingDays = new System.Windows.Forms.Label();
            this.CheckedListBoxWorkingDays = new System.Windows.Forms.CheckedListBox();
            this.MaskedTextBoxHours = new System.Windows.Forms.MaskedTextBox();
            this.LabelWorkingHours = new System.Windows.Forms.Label();
            this.LabelTLSign = new System.Windows.Forms.Label();
            this.TextBoxSalary = new System.Windows.Forms.TextBox();
            this.LabelSalary = new System.Windows.Forms.Label();
            this.LabelTCID = new System.Windows.Forms.Label();
            this.LabelFullName = new System.Windows.Forms.Label();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.LabelGSMNumber = new System.Windows.Forms.Label();
            this.MaskedTextBoxTCID = new System.Windows.Forms.MaskedTextBox();
            this.TextBoxFullName = new System.Windows.Forms.TextBox();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.TextBoxGSMNumber = new System.Windows.Forms.TextBox();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.PanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.LabelHeader.Location = new System.Drawing.Point(50, 9);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(131, 21);
            this.LabelHeader.TabIndex = 0;
            this.LabelHeader.Text = "Add an Employee";
            // 
            // PanelButtons
            // 
            this.PanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelButtons.BackColor = System.Drawing.SystemColors.Control;
            this.PanelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelButtons.Controls.Add(this.ButtonCancel);
            this.PanelButtons.Controls.Add(this.ButtonAdd);
            this.PanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.PanelButtons.Location = new System.Drawing.Point(-1, 363);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Padding = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.PanelButtons.Size = new System.Drawing.Size(298, 41);
            this.PanelButtons.TabIndex = 0;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(213, 8);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 10;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(132, 8);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 9;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // LabelJob
            // 
            this.LabelJob.AutoSize = true;
            this.LabelJob.Location = new System.Drawing.Point(9, 160);
            this.LabelJob.Name = "LabelJob";
            this.LabelJob.Size = new System.Drawing.Size(28, 13);
            this.LabelJob.TabIndex = 0;
            this.LabelJob.Text = "Job:";
            // 
            // TextBoxJob
            // 
            this.TextBoxJob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxJob.Location = new System.Drawing.Point(98, 157);
            this.TextBoxJob.Name = "TextBoxJob";
            this.TextBoxJob.Size = new System.Drawing.Size(189, 21);
            this.TextBoxJob.TabIndex = 5;
            // 
            // LabelWorkingDays
            // 
            this.LabelWorkingDays.AutoSize = true;
            this.LabelWorkingDays.Location = new System.Drawing.Point(9, 186);
            this.LabelWorkingDays.Name = "LabelWorkingDays";
            this.LabelWorkingDays.Size = new System.Drawing.Size(76, 13);
            this.LabelWorkingDays.TabIndex = 0;
            this.LabelWorkingDays.Text = "Working days:";
            // 
            // CheckedListBoxWorkingDays
            // 
            this.CheckedListBoxWorkingDays.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckedListBoxWorkingDays.CheckOnClick = true;
            this.CheckedListBoxWorkingDays.FormattingEnabled = true;
            this.CheckedListBoxWorkingDays.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.CheckedListBoxWorkingDays.Location = new System.Drawing.Point(98, 184);
            this.CheckedListBoxWorkingDays.Name = "CheckedListBoxWorkingDays";
            this.CheckedListBoxWorkingDays.Size = new System.Drawing.Size(189, 116);
            this.CheckedListBoxWorkingDays.TabIndex = 6;
            // 
            // MaskedTextBoxHours
            // 
            this.MaskedTextBoxHours.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaskedTextBoxHours.Location = new System.Drawing.Point(98, 306);
            this.MaskedTextBoxHours.Mask = "00:00 - 00:00";
            this.MaskedTextBoxHours.Name = "MaskedTextBoxHours";
            this.MaskedTextBoxHours.Size = new System.Drawing.Size(189, 21);
            this.MaskedTextBoxHours.TabIndex = 7;
            // 
            // LabelWorkingHours
            // 
            this.LabelWorkingHours.AutoSize = true;
            this.LabelWorkingHours.Location = new System.Drawing.Point(9, 309);
            this.LabelWorkingHours.Name = "LabelWorkingHours";
            this.LabelWorkingHours.Size = new System.Drawing.Size(80, 13);
            this.LabelWorkingHours.TabIndex = 0;
            this.LabelWorkingHours.Text = "Working hours:";
            // 
            // LabelTLSign
            // 
            this.LabelTLSign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTLSign.AutoSize = true;
            this.LabelTLSign.Location = new System.Drawing.Point(270, 337);
            this.LabelTLSign.Name = "LabelTLSign";
            this.LabelTLSign.Size = new System.Drawing.Size(13, 13);
            this.LabelTLSign.TabIndex = 11;
            this.LabelTLSign.Text = "₺";
            // 
            // TextBoxSalary
            // 
            this.TextBoxSalary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSalary.Location = new System.Drawing.Point(98, 333);
            this.TextBoxSalary.Name = "TextBoxSalary";
            this.TextBoxSalary.Size = new System.Drawing.Size(170, 21);
            this.TextBoxSalary.TabIndex = 8;
            // 
            // LabelSalary
            // 
            this.LabelSalary.AutoSize = true;
            this.LabelSalary.Location = new System.Drawing.Point(9, 336);
            this.LabelSalary.Name = "LabelSalary";
            this.LabelSalary.Size = new System.Drawing.Size(41, 13);
            this.LabelSalary.TabIndex = 0;
            this.LabelSalary.Text = "Salary:";
            // 
            // LabelTCID
            // 
            this.LabelTCID.AutoSize = true;
            this.LabelTCID.Location = new System.Drawing.Point(9, 52);
            this.LabelTCID.Name = "LabelTCID";
            this.LabelTCID.Size = new System.Drawing.Size(46, 13);
            this.LabelTCID.TabIndex = 0;
            this.LabelTCID.Text = "T.C. ID:";
            // 
            // LabelFullName
            // 
            this.LabelFullName.AutoSize = true;
            this.LabelFullName.Location = new System.Drawing.Point(9, 79);
            this.LabelFullName.Name = "LabelFullName";
            this.LabelFullName.Size = new System.Drawing.Size(56, 13);
            this.LabelFullName.TabIndex = 0;
            this.LabelFullName.Text = "Full name:";
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Location = new System.Drawing.Point(9, 106);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(50, 13);
            this.LabelAddress.TabIndex = 0;
            this.LabelAddress.Text = "Address:";
            // 
            // LabelGSMNumber
            // 
            this.LabelGSMNumber.AutoSize = true;
            this.LabelGSMNumber.Location = new System.Drawing.Point(9, 133);
            this.LabelGSMNumber.Name = "LabelGSMNumber";
            this.LabelGSMNumber.Size = new System.Drawing.Size(71, 13);
            this.LabelGSMNumber.TabIndex = 0;
            this.LabelGSMNumber.Text = "GSM number:";
            // 
            // MaskedTextBoxTCID
            // 
            this.MaskedTextBoxTCID.AllowPromptAsInput = false;
            this.MaskedTextBoxTCID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaskedTextBoxTCID.BeepOnError = true;
            this.MaskedTextBoxTCID.HidePromptOnLeave = true;
            this.MaskedTextBoxTCID.Location = new System.Drawing.Point(98, 49);
            this.MaskedTextBoxTCID.Mask = "00000000000";
            this.MaskedTextBoxTCID.Name = "MaskedTextBoxTCID";
            this.MaskedTextBoxTCID.ResetOnSpace = false;
            this.MaskedTextBoxTCID.Size = new System.Drawing.Size(189, 21);
            this.MaskedTextBoxTCID.TabIndex = 1;
            // 
            // TextBoxFullName
            // 
            this.TextBoxFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFullName.Location = new System.Drawing.Point(98, 76);
            this.TextBoxFullName.Name = "TextBoxFullName";
            this.TextBoxFullName.Size = new System.Drawing.Size(189, 21);
            this.TextBoxFullName.TabIndex = 2;
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxAddress.Location = new System.Drawing.Point(98, 103);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(189, 21);
            this.TextBoxAddress.TabIndex = 3;
            // 
            // TextBoxGSMNumber
            // 
            this.TextBoxGSMNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxGSMNumber.Location = new System.Drawing.Point(98, 130);
            this.TextBoxGSMNumber.Name = "TextBoxGSMNumber";
            this.TextBoxGSMNumber.Size = new System.Drawing.Size(189, 21);
            this.TextBoxGSMNumber.TabIndex = 4;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::Hotelogram.Properties.Resources.users_win10_32;
            this.pictureBoxIcon.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // DAddEmployee
            // 
            this.AcceptButton = this.ButtonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(296, 403);
            this.Controls.Add(this.TextBoxGSMNumber);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.TextBoxFullName);
            this.Controls.Add(this.MaskedTextBoxTCID);
            this.Controls.Add(this.LabelGSMNumber);
            this.Controls.Add(this.LabelAddress);
            this.Controls.Add(this.LabelFullName);
            this.Controls.Add(this.LabelTCID);
            this.Controls.Add(this.LabelSalary);
            this.Controls.Add(this.TextBoxSalary);
            this.Controls.Add(this.LabelTLSign);
            this.Controls.Add(this.LabelWorkingHours);
            this.Controls.Add(this.MaskedTextBoxHours);
            this.Controls.Add(this.CheckedListBoxWorkingDays);
            this.Controls.Add(this.LabelWorkingDays);
            this.Controls.Add(this.TextBoxJob);
            this.Controls.Add(this.LabelJob);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.LabelHeader);
            this.Controls.Add(this.pictureBoxIcon);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(9999, 442);
            this.MinimumSize = new System.Drawing.Size(312, 442);
            this.Name = "DAddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add an Employee | Hotelogram";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DAddEmployee_FormClosed);
            this.Load += new System.EventHandler(this.DAddEmployee_Load);
            this.PanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.FlowLayoutPanel PanelButtons;
        private System.Windows.Forms.Label LabelJob;
        private System.Windows.Forms.TextBox TextBoxJob;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label LabelWorkingDays;
        private System.Windows.Forms.CheckedListBox CheckedListBoxWorkingDays;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxHours;
        private System.Windows.Forms.Label LabelWorkingHours;
        private System.Windows.Forms.Label LabelTLSign;
        private System.Windows.Forms.TextBox TextBoxSalary;
        private System.Windows.Forms.Label LabelSalary;
        private System.Windows.Forms.Label LabelTCID;
        private System.Windows.Forms.Label LabelFullName;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.Label LabelGSMNumber;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxTCID;
        private System.Windows.Forms.TextBox TextBoxFullName;
        private System.Windows.Forms.TextBox TextBoxAddress;
        private System.Windows.Forms.TextBox TextBoxGSMNumber;
    }
}