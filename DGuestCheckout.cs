using System;
using System.Windows.Forms;

namespace Hotelogram
{
    public partial class DGuestCheckout : Form
    {
        private Guest g;
        public DGuestCheckout()
        {
            InitializeComponent();
        }

        public void ShowDialog (Guest guest)
        {
            g = guest;
            ShowDialog();
        }

        private void DGuestCheckout_Load(object sender, EventArgs e)
        {
            labelHeader.Text = $"Check-out of {g.Name}";
            textBoxID.Text = g.ID.ToString();
            textBoxTCID.Text = g.TCID.ToString();
            textBoxName.Text = g.Name;
            textBoxGSMNumber.Text = g.GSMNumber;

            if (g.Room != null)
                textBoxRoom.Text = $"Room #{g.Room.No.ToString()} - {g.Room.Floor.ToString()}. floor" + (g.Room.Type != "" ? $" - {g.Room.Type}" : "");
            else
                textBoxRoom.Text = "No room";
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (g.IsRegistered) { Guest.AllRegisteredGuests.Remove(g); } else { Guest.AllReservedGuests.Remove(g); }
            FormHelper.FGuests.UpdateList();
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DGuestCheckout_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.DGuestCheckout = null;
        }
    }
}
