using System;
using System.Windows.Forms;

namespace Hotelogram
{
    public partial class DAddAction : Form
    {
        public Bill Bill;

        public DAddAction()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DAddAction_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.DAddAction = null;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxAction.Text != "")
                {
                    if (TextBoxAmount.Text != "")
                    {
                        Bill.AddAction(TextBoxAction.Text, float.Parse(TextBoxAmount.Text.Replace('.', ',')));
                        FormHelper.DBillInfo.UpdateList();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Please enter an amount for the action.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a description for the action.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("You haven't entered a valid amount. Please check and try again.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (OverflowException)
            {
                MessageBox.Show("You haven't entered a valid amount. Please check and try again.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
