namespace Hotelogram
{
    partial class DAddRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DAddRoom));
            this.PictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.LabelNo = new System.Windows.Forms.Label();
            this.LabelFloor = new System.Windows.Forms.Label();
            this.PanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.LabelType = new System.Windows.Forms.Label();
            this.LabelFurniture = new System.Windows.Forms.Label();
            this.TextBoxFloor = new System.Windows.Forms.TextBox();
            this.TextBoxType = new System.Windows.Forms.TextBox();
            this.ListBoxFurniture = new System.Windows.Forms.ListBox();
            this.ButtonAddFurniture = new System.Windows.Forms.Button();
            this.NumericUpDownNo = new System.Windows.Forms.NumericUpDown();
            this.ButtonRemoveAllFurniture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).BeginInit();
            this.PanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownNo)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxIcon
            // 
            this.PictureBoxIcon.Image = global::Hotelogram.Properties.Resources._1485377478_door_open;
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
            this.LabelHeader.Size = new System.Drawing.Size(96, 21);
            this.LabelHeader.TabIndex = 1;
            this.LabelHeader.Text = "Add a Room";
            // 
            // LabelNo
            // 
            this.LabelNo.AutoSize = true;
            this.LabelNo.Location = new System.Drawing.Point(9, 52);
            this.LabelNo.Name = "LabelNo";
            this.LabelNo.Size = new System.Drawing.Size(24, 13);
            this.LabelNo.TabIndex = 2;
            this.LabelNo.Text = "No:";
            // 
            // LabelFloor
            // 
            this.LabelFloor.AutoSize = true;
            this.LabelFloor.Location = new System.Drawing.Point(9, 80);
            this.LabelFloor.Name = "LabelFloor";
            this.LabelFloor.Size = new System.Drawing.Size(35, 13);
            this.LabelFloor.TabIndex = 3;
            this.LabelFloor.Text = "Floor:";
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
            this.PanelButtons.Location = new System.Drawing.Point(-1, 275);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Padding = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.PanelButtons.Size = new System.Drawing.Size(314, 43);
            this.PanelButtons.TabIndex = 4;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(229, 8);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 0;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(148, 8);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 1;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Location = new System.Drawing.Point(9, 107);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(35, 13);
            this.LabelType.TabIndex = 5;
            this.LabelType.Text = "Type:";
            // 
            // LabelFurniture
            // 
            this.LabelFurniture.AutoSize = true;
            this.LabelFurniture.Location = new System.Drawing.Point(9, 133);
            this.LabelFurniture.Name = "LabelFurniture";
            this.LabelFurniture.Size = new System.Drawing.Size(55, 13);
            this.LabelFurniture.TabIndex = 6;
            this.LabelFurniture.Text = "Furniture:";
            // 
            // TextBoxFloor
            // 
            this.TextBoxFloor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFloor.Location = new System.Drawing.Point(70, 77);
            this.TextBoxFloor.Name = "TextBoxFloor";
            this.TextBoxFloor.Size = new System.Drawing.Size(230, 21);
            this.TextBoxFloor.TabIndex = 8;
            // 
            // TextBoxType
            // 
            this.TextBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxType.Location = new System.Drawing.Point(70, 104);
            this.TextBoxType.Name = "TextBoxType";
            this.TextBoxType.Size = new System.Drawing.Size(230, 21);
            this.TextBoxType.TabIndex = 9;
            // 
            // ListBoxFurniture
            // 
            this.ListBoxFurniture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBoxFurniture.FormattingEnabled = true;
            this.ListBoxFurniture.Location = new System.Drawing.Point(70, 131);
            this.ListBoxFurniture.Name = "ListBoxFurniture";
            this.ListBoxFurniture.Size = new System.Drawing.Size(230, 108);
            this.ListBoxFurniture.TabIndex = 10;
            // 
            // ButtonAddFurniture
            // 
            this.ButtonAddFurniture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonAddFurniture.Location = new System.Drawing.Point(69, 246);
            this.ButtonAddFurniture.Name = "ButtonAddFurniture";
            this.ButtonAddFurniture.Size = new System.Drawing.Size(107, 23);
            this.ButtonAddFurniture.TabIndex = 11;
            this.ButtonAddFurniture.Text = "Add a furniture";
            this.ButtonAddFurniture.UseVisualStyleBackColor = true;
            this.ButtonAddFurniture.Click += new System.EventHandler(this.buttonAddFurniture_Click);
            // 
            // NumericUpDownNo
            // 
            this.NumericUpDownNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericUpDownNo.Location = new System.Drawing.Point(70, 50);
            this.NumericUpDownNo.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NumericUpDownNo.Name = "NumericUpDownNo";
            this.NumericUpDownNo.Size = new System.Drawing.Size(230, 21);
            this.NumericUpDownNo.TabIndex = 12;
            // 
            // ButtonRemoveAllFurniture
            // 
            this.ButtonRemoveAllFurniture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonRemoveAllFurniture.Location = new System.Drawing.Point(183, 246);
            this.ButtonRemoveAllFurniture.Name = "ButtonRemoveAllFurniture";
            this.ButtonRemoveAllFurniture.Size = new System.Drawing.Size(118, 23);
            this.ButtonRemoveAllFurniture.TabIndex = 13;
            this.ButtonRemoveAllFurniture.Text = "Remove all furniture";
            this.ButtonRemoveAllFurniture.UseVisualStyleBackColor = true;
            this.ButtonRemoveAllFurniture.Click += new System.EventHandler(this.buttonRemoveAllFurniture_Click);
            // 
            // DAddRoom
            // 
            this.AcceptButton = this.ButtonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(312, 317);
            this.Controls.Add(this.ButtonRemoveAllFurniture);
            this.Controls.Add(this.NumericUpDownNo);
            this.Controls.Add(this.ButtonAddFurniture);
            this.Controls.Add(this.ListBoxFurniture);
            this.Controls.Add(this.TextBoxType);
            this.Controls.Add(this.TextBoxFloor);
            this.Controls.Add(this.LabelFurniture);
            this.Controls.Add(this.LabelType);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.LabelFloor);
            this.Controls.Add(this.LabelNo);
            this.Controls.Add(this.LabelHeader);
            this.Controls.Add(this.PictureBoxIcon);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(328, 356);
            this.Name = "DAddRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add a Room | Hotelogram";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DAddRoom_FormClosed);
            this.Load += new System.EventHandler(this.DAddRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxIcon;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.Label LabelNo;
        private System.Windows.Forms.Label LabelFloor;
        private System.Windows.Forms.FlowLayoutPanel PanelButtons;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.Label LabelFurniture;
        private System.Windows.Forms.TextBox TextBoxFloor;
        private System.Windows.Forms.TextBox TextBoxType;
        private System.Windows.Forms.ListBox ListBoxFurniture;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonAddFurniture;
        private System.Windows.Forms.NumericUpDown NumericUpDownNo;
        private System.Windows.Forms.Button ButtonRemoveAllFurniture;
    }
}