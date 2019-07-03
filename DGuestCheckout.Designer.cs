namespace Hotelogram
{
    partial class DGuestCheckout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DGuestCheckout));
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelSubheader = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTCID = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelRoom = new System.Windows.Forms.Label();
            this.labelGSMNumber = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxTCID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxGSMNumber = new System.Windows.Forms.TextBox();
            this.textBoxRoom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::Hotelogram.Properties.Resources.question_win10_32;
            this.pictureBoxIcon.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.labelHeader.Location = new System.Drawing.Point(49, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(165, 21);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Check-out of <Guest>";
            // 
            // labelSubheader
            // 
            this.labelSubheader.AutoSize = true;
            this.labelSubheader.Location = new System.Drawing.Point(50, 30);
            this.labelSubheader.Name = "labelSubheader";
            this.labelSubheader.Size = new System.Drawing.Size(172, 13);
            this.labelSubheader.TabIndex = 2;
            this.labelSubheader.Text = "Do you wish to remove this guest?";
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtons.BackColor = System.Drawing.SystemColors.Control;
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.Controls.Add(this.buttonCancel);
            this.panelButtons.Controls.Add(this.buttonRemove);
            this.panelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelButtons.Location = new System.Drawing.Point(-1, 190);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.panelButtons.Size = new System.Drawing.Size(238, 41);
            this.panelButtons.TabIndex = 3;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(153, 8);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(72, 8);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 0;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 103);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Full name:";
            // 
            // labelTCID
            // 
            this.labelTCID.AutoSize = true;
            this.labelTCID.Location = new System.Drawing.Point(9, 76);
            this.labelTCID.Name = "labelTCID";
            this.labelTCID.Size = new System.Drawing.Size(46, 13);
            this.labelTCID.TabIndex = 5;
            this.labelTCID.Text = "T.C. ID:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(9, 49);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(22, 13);
            this.labelID.TabIndex = 6;
            this.labelID.Text = "ID:";
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(9, 157);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(38, 13);
            this.labelRoom.TabIndex = 7;
            this.labelRoom.Text = "Room:";
            // 
            // labelGSMNumber
            // 
            this.labelGSMNumber.AutoSize = true;
            this.labelGSMNumber.Location = new System.Drawing.Point(9, 130);
            this.labelGSMNumber.Name = "labelGSMNumber";
            this.labelGSMNumber.Size = new System.Drawing.Size(72, 13);
            this.labelGSMNumber.TabIndex = 8;
            this.labelGSMNumber.Text = "GSM Number:";
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxID.Location = new System.Drawing.Point(87, 46);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(137, 21);
            this.textBoxID.TabIndex = 9;
            // 
            // textBoxTCID
            // 
            this.textBoxTCID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTCID.Location = new System.Drawing.Point(87, 73);
            this.textBoxTCID.Name = "textBoxTCID";
            this.textBoxTCID.ReadOnly = true;
            this.textBoxTCID.Size = new System.Drawing.Size(137, 21);
            this.textBoxTCID.TabIndex = 9;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(87, 100);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(137, 21);
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxGSMNumber
            // 
            this.textBoxGSMNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGSMNumber.Location = new System.Drawing.Point(87, 127);
            this.textBoxGSMNumber.Name = "textBoxGSMNumber";
            this.textBoxGSMNumber.ReadOnly = true;
            this.textBoxGSMNumber.Size = new System.Drawing.Size(137, 21);
            this.textBoxGSMNumber.TabIndex = 9;
            // 
            // textBoxRoom
            // 
            this.textBoxRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRoom.Location = new System.Drawing.Point(87, 154);
            this.textBoxRoom.Name = "textBoxRoom";
            this.textBoxRoom.ReadOnly = true;
            this.textBoxRoom.Size = new System.Drawing.Size(137, 21);
            this.textBoxRoom.TabIndex = 9;
            // 
            // DGuestCheckout
            // 
            this.AcceptButton = this.buttonRemove;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(236, 230);
            this.Controls.Add(this.textBoxRoom);
            this.Controls.Add(this.textBoxGSMNumber);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxTCID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelGSMNumber);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelTCID);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.labelSubheader);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.pictureBoxIcon);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(9999, 269);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(16, 269);
            this.Name = "DGuestCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest Check-out | Hotelogram";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DGuestCheckout_FormClosed);
            this.Load += new System.EventHandler(this.DGuestCheckout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelSubheader;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTCID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.Label labelGSMNumber;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxTCID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxGSMNumber;
        private System.Windows.Forms.TextBox textBoxRoom;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRemove;
    }
}