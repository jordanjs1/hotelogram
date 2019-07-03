namespace Hotelogram
{
    partial class DBillInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBillInfo));
            this.LabelHeader = new System.Windows.Forms.Label();
            this.DataGridViewBillInfo = new System.Windows.Forms.DataGridView();
            this.actionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.PictureBoxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBillInfo)).BeginInit();
            this.PanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.LabelHeader.Location = new System.Drawing.Point(50, 9);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(201, 21);
            this.LabelHeader.TabIndex = 0;
            this.LabelHeader.Text = "Bill Information of <Guest>";
            // 
            // DataGridViewBillInfo
            // 
            this.DataGridViewBillInfo.AllowUserToAddRows = false;
            this.DataGridViewBillInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewBillInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewBillInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actionID,
            this.action,
            this.amount});
            this.DataGridViewBillInfo.Location = new System.Drawing.Point(12, 50);
            this.DataGridViewBillInfo.Name = "DataGridViewBillInfo";
            this.DataGridViewBillInfo.ReadOnly = true;
            this.DataGridViewBillInfo.Size = new System.Drawing.Size(344, 181);
            this.DataGridViewBillInfo.TabIndex = 2;
            this.DataGridViewBillInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBillInfo_CellClick);
            // 
            // actionID
            // 
            this.actionID.HeaderText = "Action ID";
            this.actionID.Name = "actionID";
            this.actionID.ReadOnly = true;
            // 
            // action
            // 
            this.action.HeaderText = "Action";
            this.action.Name = "action";
            this.action.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // PanelButtons
            // 
            this.PanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelButtons.BackColor = System.Drawing.SystemColors.Control;
            this.PanelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelButtons.Controls.Add(this.ButtonClose);
            this.PanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.PanelButtons.Location = new System.Drawing.Point(-1, 237);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Padding = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.PanelButtons.Size = new System.Drawing.Size(464, 41);
            this.PanelButtons.TabIndex = 3;
            // 
            // ButtonClose
            // 
            this.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonClose.Location = new System.Drawing.Point(379, 8);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAdd.Location = new System.Drawing.Point(362, 50);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(88, 23);
            this.ButtonAdd.TabIndex = 5;
            this.ButtonAdd.Text = "Add action";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRemove.Location = new System.Drawing.Point(362, 79);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(88, 23);
            this.ButtonRemove.TabIndex = 6;
            this.ButtonRemove.Text = "Remove action";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // PictureBoxIcon
            // 
            this.PictureBoxIcon.Image = global::Hotelogram.Properties.Resources._1485377761_invoice;
            this.PictureBoxIcon.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxIcon.Name = "PictureBoxIcon";
            this.PictureBoxIcon.Size = new System.Drawing.Size(32, 32);
            this.PictureBoxIcon.TabIndex = 4;
            this.PictureBoxIcon.TabStop = false;
            // 
            // DBillInfo
            // 
            this.AcceptButton = this.ButtonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.ButtonClose;
            this.ClientSize = new System.Drawing.Size(462, 277);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.PictureBoxIcon);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.DataGridViewBillInfo);
            this.Controls.Add(this.LabelHeader);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DBillInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bill Information of <Guest> | Hotelogram";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DBillInfo_FormClosed);
            this.Load += new System.EventHandler(this.DBillInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBillInfo)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.DataGridView DataGridViewBillInfo;
        private System.Windows.Forms.FlowLayoutPanel PanelButtons;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.PictureBox PictureBoxIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonRemove;
    }
}