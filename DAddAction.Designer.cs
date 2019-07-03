namespace Hotelogram
{
    partial class DAddAction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DAddAction));
            this.LabelHeader = new System.Windows.Forms.Label();
            this.PanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.LabelAction = new System.Windows.Forms.Label();
            this.LabelAmount = new System.Windows.Forms.Label();
            this.TextBoxAction = new System.Windows.Forms.TextBox();
            this.TextBoxAmount = new System.Windows.Forms.TextBox();
            this.labelTL = new System.Windows.Forms.Label();
            this.PanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.LabelHeader.Location = new System.Drawing.Point(12, 9);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(107, 21);
            this.LabelHeader.TabIndex = 0;
            this.LabelHeader.Text = "Add an Action";
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
            this.PanelButtons.Location = new System.Drawing.Point(-1, 92);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Padding = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.PanelButtons.Size = new System.Drawing.Size(238, 41);
            this.PanelButtons.TabIndex = 1;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(153, 8);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(72, 8);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // LabelAction
            // 
            this.LabelAction.AutoSize = true;
            this.LabelAction.Location = new System.Drawing.Point(13, 36);
            this.LabelAction.Name = "LabelAction";
            this.LabelAction.Size = new System.Drawing.Size(41, 13);
            this.LabelAction.TabIndex = 2;
            this.LabelAction.Text = "Action:";
            // 
            // LabelAmount
            // 
            this.LabelAmount.AutoSize = true;
            this.LabelAmount.Location = new System.Drawing.Point(13, 63);
            this.LabelAmount.Name = "LabelAmount";
            this.LabelAmount.Size = new System.Drawing.Size(48, 13);
            this.LabelAmount.TabIndex = 3;
            this.LabelAmount.Text = "Amount:";
            // 
            // TextBoxAction
            // 
            this.TextBoxAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxAction.Location = new System.Drawing.Point(67, 33);
            this.TextBoxAction.Name = "TextBoxAction";
            this.TextBoxAction.Size = new System.Drawing.Size(157, 21);
            this.TextBoxAction.TabIndex = 4;
            // 
            // TextBoxAmount
            // 
            this.TextBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxAmount.Location = new System.Drawing.Point(67, 60);
            this.TextBoxAmount.Name = "TextBoxAmount";
            this.TextBoxAmount.Size = new System.Drawing.Size(137, 21);
            this.TextBoxAmount.TabIndex = 5;
            // 
            // labelTL
            // 
            this.labelTL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTL.AutoSize = true;
            this.labelTL.Location = new System.Drawing.Point(210, 63);
            this.labelTL.Name = "labelTL";
            this.labelTL.Size = new System.Drawing.Size(13, 13);
            this.labelTL.TabIndex = 6;
            this.labelTL.Text = "₺";
            // 
            // DAddAction
            // 
            this.AcceptButton = this.ButtonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(236, 132);
            this.Controls.Add(this.labelTL);
            this.Controls.Add(this.TextBoxAmount);
            this.Controls.Add(this.TextBoxAction);
            this.Controls.Add(this.LabelAmount);
            this.Controls.Add(this.LabelAction);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.LabelHeader);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(9999, 171);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(234, 171);
            this.Name = "DAddAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add an Action | Hotelogram";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DAddAction_FormClosed);
            this.PanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.FlowLayoutPanel PanelButtons;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label LabelAction;
        private System.Windows.Forms.Label LabelAmount;
        private System.Windows.Forms.TextBox TextBoxAction;
        private System.Windows.Forms.TextBox TextBoxAmount;
        private System.Windows.Forms.Label labelTL;
    }
}