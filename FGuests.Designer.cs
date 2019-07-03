namespace Hotelogram
{
    partial class FGuests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGuests));
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelSubheader = new System.Windows.Forms.Label();
            this.dataGridViewGuests = new System.Windows.Forms.DataGridView();
            this.guestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gsmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonViewBill = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::Hotelogram.Properties.Resources.guest_win10_32;
            this.pictureBoxIcon.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 1;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.labelHeader.Location = new System.Drawing.Point(50, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(117, 21);
            this.labelHeader.TabIndex = 2;
            this.labelHeader.Text = "Manage Guests";
            // 
            // labelSubheader
            // 
            this.labelSubheader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSubheader.AutoEllipsis = true;
            this.labelSubheader.Location = new System.Drawing.Point(51, 30);
            this.labelSubheader.Name = "labelSubheader";
            this.labelSubheader.Size = new System.Drawing.Size(724, 13);
            this.labelSubheader.TabIndex = 3;
            this.labelSubheader.Text = "View, reserve, register, remove guests, check and edit bills and edit information" +
    " about existing guests.";
            // 
            // dataGridViewGuests
            // 
            this.dataGridViewGuests.AllowUserToAddRows = false;
            this.dataGridViewGuests.AllowUserToDeleteRows = false;
            this.dataGridViewGuests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGuests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guestID,
            this.TCID,
            this.name,
            this.gsmNumber,
            this.room,
            this.bill});
            this.dataGridViewGuests.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewGuests.Name = "dataGridViewGuests";
            this.dataGridViewGuests.ReadOnly = true;
            this.dataGridViewGuests.Size = new System.Drawing.Size(644, 422);
            this.dataGridViewGuests.TabIndex = 4;
            this.dataGridViewGuests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // guestID
            // 
            this.guestID.HeaderText = "Guest ID";
            this.guestID.Name = "guestID";
            this.guestID.ReadOnly = true;
            // 
            // TCID
            // 
            this.TCID.HeaderText = "T.C. ID";
            this.TCID.Name = "TCID";
            this.TCID.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Full Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // gsmNumber
            // 
            this.gsmNumber.HeaderText = "GSM Number";
            this.gsmNumber.Name = "gsmNumber";
            this.gsmNumber.ReadOnly = true;
            // 
            // room
            // 
            this.room.HeaderText = "Room No";
            this.room.Name = "room";
            this.room.ReadOnly = true;
            // 
            // bill
            // 
            this.bill.HeaderText = "Bill Amount";
            this.bill.Name = "bill";
            this.bill.ReadOnly = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(662, 50);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(105, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add a guest";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Enabled = false;
            this.buttonRemove.Location = new System.Drawing.Point(662, 108);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(105, 23);
            this.buttonRemove.TabIndex = 7;
            this.buttonRemove.Text = "Check-out";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonViewBill
            // 
            this.buttonViewBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewBill.Enabled = false;
            this.buttonViewBill.Location = new System.Drawing.Point(662, 137);
            this.buttonViewBill.Name = "buttonViewBill";
            this.buttonViewBill.Size = new System.Drawing.Size(105, 23);
            this.buttonViewBill.TabIndex = 8;
            this.buttonViewBill.Text = "View bill";
            this.buttonViewBill.UseVisualStyleBackColor = true;
            this.buttonViewBill.Click += new System.EventHandler(this.buttonCheckBill_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Location = new System.Drawing.Point(662, 79);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(105, 23);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Edit guest";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.Location = new System.Drawing.Point(662, 166);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(105, 23);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Update list";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // FGuests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 484);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonViewBill);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewGuests);
            this.Controls.Add(this.labelSubheader);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.pictureBoxIcon);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FGuests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Guests";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FGuests_FormClosed);
            this.Load += new System.EventHandler(this.FGuests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelSubheader;
        private System.Windows.Forms.DataGridView dataGridViewGuests;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonViewBill;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gsmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill;
        private System.Windows.Forms.Button buttonUpdate;
    }
}