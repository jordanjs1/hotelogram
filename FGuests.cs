using System;
using System.Windows.Forms;

namespace Hotelogram
{
    public partial class FGuests : Form
    {
        public FGuests()
        {
            InitializeComponent();
        }

        public void UpdateList()
        {
            dataGridViewGuests.Rows.Clear();
            foreach (var g in Guest.AllReservedGuests)
                dataGridViewGuests.Rows.Add($"{g.ID}", $"{g.TCID}", $"{g.Name}", $"{g.GSMNumber}", g.Room != null ? $"{g.Room.No}" : "Reserved", $"Reserved");

            foreach (var g in Guest.AllRegisteredGuests)
                dataGridViewGuests.Rows.Add($"{g.ID}", $"{g.TCID}", $"{g.Name}", $"{g.GSMNumber}", $"{g.Room.No}", $"{g.Bill.Amount} ₺");
        }

        private void FGuests_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.FGuests = null;
        }

        private void FGuests_Load(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonEdit.Enabled = e.ColumnIndex == 0;
            buttonRemove.Enabled = e.ColumnIndex == 0;
            buttonViewBill.Enabled = e.ColumnIndex == 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //BUG: User with REGISTER_GUEST permission can reserve a guest and vice versa.
            //FIX: Create flags (bool) that determines whether the user can register and reserve guests.
            if (User.LoggedUser.Permissions.GuestPermissions.HasFlag(GuestPermission.Register | GuestPermission.Reserve))
            {
                FormHelper.DAddGuest.SetMode(true);
                FormHelper.DAddGuest.MdiParent = FormHelper.FMainMenu;
                FormHelper.DAddGuest.Show();
            }
            else
                MessageBox.Show($"Sorry {User.LoggedUser.Name}, you do not have permissions to add guests.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void buttonCheckBill_Click(object sender, EventArgs e)
        {
            if (Guest.GetGuestByID(int.Parse(dataGridViewGuests.SelectedCells[0].Value.ToString())).Bill == null)
            {
                MessageBox.Show("Reserved guests don't have bills.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            if (User.LoggedUser.Permissions.GuestPermissions.HasFlag(GuestPermission.ViewGuestBill))
            {
                FormHelper.DBillInfo.MdiParent = FormHelper.FMainMenu;
                FormHelper.DBillInfo.Show(Guest.GetGuestByID(int.Parse(dataGridViewGuests.SelectedCells[0].Value.ToString())).Bill);
            }
            else
                MessageBox.Show($"Sorry {User.LoggedUser.Name}, you do not have permissions to view bills.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (User.LoggedUser.Permissions.GuestPermissions.HasFlag(GuestPermission.Edit))
            {
                var g = Guest.GetGuestByID(int.Parse(dataGridViewGuests.SelectedCells[0].Value.ToString()));
                FormHelper.DAddGuest.SetMode(false);
                FormHelper.DAddGuest.MdiParent = FormHelper.FMainMenu;
                FormHelper.DAddGuest.Show(g);
            }
            else
            {
                MessageBox.Show($"Sorry {User.LoggedUser.Name}, you do not have permissions to edit guests.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (User.LoggedUser.Permissions.GuestPermissions.HasFlag(GuestPermission.Remove))
            {
                var g = Guest.GetGuestByID(int.Parse(dataGridViewGuests.SelectedCells[0].Value.ToString()));
                FormHelper.DGuestCheckout.ShowDialog(g);
            }
            else
                MessageBox.Show($"Sorry {User.LoggedUser.Name}, you do not have permissions to edit guests.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateList();
        }
    }
}
