namespace Hotelogram
{
    partial class DAddGuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DAddGuest));
            this.PictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelGSMNumber = new System.Windows.Forms.Label();
            this.LabelRoom = new System.Windows.Forms.Label();
            this.ComboBoxRooms = new System.Windows.Forms.ComboBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxGSMNumber = new System.Windows.Forms.TextBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.PanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.ButtonReserve = new System.Windows.Forms.Button();
            this.LabelTCID = new System.Windows.Forms.Label();
            this.TextBoxTCID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).BeginInit();
            this.PanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBoxIcon
            // 
            this.PictureBoxIcon.Image = global::Hotelogram.Properties.Resources.guest_win10_32;
            this.PictureBoxIcon.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxIcon.Name = "PictureBoxIcon";
            this.PictureBoxIcon.Size = new System.Drawing.Size(32, 32);
            this.PictureBoxIcon.TabIndex = 0;
            this.PictureBoxIcon.TabStop = false;
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.LabelHeader.Location = new System.Drawing.Point(50, 9);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(94, 21);
            this.LabelHeader.TabIndex = 1;
            this.LabelHeader.Text = "Add a Guest";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(9, 80);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(56, 13);
            this.LabelName.TabIndex = 3;
            this.LabelName.Text = "Full name:";
            // 
            // LabelGSMNumber
            // 
            this.LabelGSMNumber.AutoSize = true;
            this.LabelGSMNumber.Location = new System.Drawing.Point(9, 107);
            this.LabelGSMNumber.Name = "LabelGSMNumber";
            this.LabelGSMNumber.Size = new System.Drawing.Size(71, 13);
            this.LabelGSMNumber.TabIndex = 4;
            this.LabelGSMNumber.Text = "GSM number:";
            // 
            // LabelRoom
            // 
            this.LabelRoom.AutoSize = true;
            this.LabelRoom.Location = new System.Drawing.Point(9, 134);
            this.LabelRoom.Name = "LabelRoom";
            this.LabelRoom.Size = new System.Drawing.Size(38, 13);
            this.LabelRoom.TabIndex = 5;
            this.LabelRoom.Text = "Room:";
            // 
            // ComboBoxRooms
            // 
            this.ComboBoxRooms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRooms.FormattingEnabled = true;
            this.ComboBoxRooms.Location = new System.Drawing.Point(86, 131);
            this.ComboBoxRooms.Name = "ComboBoxRooms";
            this.ComboBoxRooms.Size = new System.Drawing.Size(232, 21);
            this.ComboBoxRooms.TabIndex = 6;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxName.Location = new System.Drawing.Point(86, 77);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(232, 21);
            this.TextBoxName.TabIndex = 7;
            // 
            // TextBoxGSMNumber
            // 
            this.TextBoxGSMNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxGSMNumber.Location = new System.Drawing.Point(86, 104);
            this.TextBoxGSMNumber.Name = "TextBoxGSMNumber";
            this.TextBoxGSMNumber.Size = new System.Drawing.Size(232, 21);
            this.TextBoxGSMNumber.TabIndex = 8;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(247, 8);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 10;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // PanelButtons
            // 
            this.PanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelButtons.BackColor = System.Drawing.SystemColors.Control;
            this.PanelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelButtons.Controls.Add(this.ButtonCancel);
            this.PanelButtons.Controls.Add(this.ButtonRegister);
            this.PanelButtons.Controls.Add(this.ButtonReserve);
            this.PanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.PanelButtons.Location = new System.Drawing.Point(-1, 161);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Padding = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.PanelButtons.Size = new System.Drawing.Size(332, 43);
            this.PanelButtons.TabIndex = 11;
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.Location = new System.Drawing.Point(166, 8);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(75, 23);
            this.ButtonRegister.TabIndex = 12;
            this.ButtonRegister.Text = "Register";
            this.ButtonRegister.UseVisualStyleBackColor = true;
            this.ButtonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // ButtonReserve
            // 
            this.ButtonReserve.Location = new System.Drawing.Point(85, 8);
            this.ButtonReserve.Name = "ButtonReserve";
            this.ButtonReserve.Size = new System.Drawing.Size(75, 23);
            this.ButtonReserve.TabIndex = 12;
            this.ButtonReserve.Text = "Reserve";
            this.ButtonReserve.UseVisualStyleBackColor = true;
            this.ButtonReserve.Click += new System.EventHandler(this.buttonReserve_Click);
            // 
            // LabelTCID
            // 
            this.LabelTCID.AutoSize = true;
            this.LabelTCID.Location = new System.Drawing.Point(9, 53);
            this.LabelTCID.Name = "LabelTCID";
            this.LabelTCID.Size = new System.Drawing.Size(46, 13);
            this.LabelTCID.TabIndex = 12;
            this.LabelTCID.Text = "T.C. ID:";
            // 
            // TextBoxTCID
            // 
            this.TextBoxTCID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxTCID.Location = new System.Drawing.Point(86, 50);
            this.TextBoxTCID.MaxLength = 11;
            this.TextBoxTCID.Name = "TextBoxTCID";
            this.TextBoxTCID.Size = new System.Drawing.Size(232, 21);
            this.TextBoxTCID.TabIndex = 13;
            // 
            // DAddGuest
            // 
            this.AcceptButton = this.ButtonRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(330, 203);
            this.Controls.Add(this.TextBoxTCID);
            this.Controls.Add(this.LabelTCID);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.TextBoxGSMNumber);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.ComboBoxRooms);
            this.Controls.Add(this.LabelRoom);
            this.Controls.Add(this.LabelGSMNumber);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelHeader);
            this.Controls.Add(this.PictureBoxIcon);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(9999, 242);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(269, 242);
            this.Name = "DAddGuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add a Guest | Hotelogram";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DAddGuest_FormClosed_1);
            this.Load += new System.EventHandler(this.DAddGuest_Load);
            this.Shown += new System.EventHandler(this.DAddGuest_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxIcon;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelGSMNumber;
        private System.Windows.Forms.Label LabelRoom;
        private System.Windows.Forms.ComboBox ComboBoxRooms;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxGSMNumber;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.FlowLayoutPanel PanelButtons;
        private System.Windows.Forms.Button ButtonRegister;
        private System.Windows.Forms.Button ButtonReserve;
        private System.Windows.Forms.Label LabelTCID;
        private System.Windows.Forms.TextBox TextBoxTCID;
    }
}