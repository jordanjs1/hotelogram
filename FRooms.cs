using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelogram
{
    public partial class FRooms : Form
    {
        public void updateList()
        {
            dataGridViewRooms.Rows.Clear();
            foreach (Room r in Room.AllRooms)
            {
                dataGridViewRooms.Rows.Add($"{r.No}", $"{r.Floor}", $"{r.Type}", $"{r.FurnitureString}");
            }
        }

        public FRooms()
        {
            InitializeComponent();
        }

        private void FRooms_Load(object sender, EventArgs e)
        {
            updateList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (User.LoggedUser.Permissions.RoomPermissions.HasFlag(RoomPermission.Add))
            {
                FormHelper.DAddRoom.setMode(true);
                FormHelper.DAddRoom.MdiParent = FormHelper.FMainMenu;
                FormHelper.DAddRoom.Show();
            }
            else
                MessageBox.Show($"Sorry {User.LoggedUser.Name}, you do not have permissions to add rooms.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void FRooms_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.FRooms = null;
        }

        private void dataGridViewRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonEdit.Enabled = e.ColumnIndex == 0;
            buttonRemove.Enabled = e.ColumnIndex == 0;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (User.LoggedUser.Permissions.RoomPermissions.HasFlag(RoomPermission.Edit))
            {
                FormHelper.DAddRoom.setMode(false);
                FormHelper.DAddRoom.MdiParent = FormHelper.FMainMenu;
                FormHelper.DAddRoom.Show(Room.GetRoomByNo(uint.Parse(dataGridViewRooms.SelectedCells[0].Value.ToString())));
            }
            else
                MessageBox.Show($"Sorry {User.LoggedUser.Name}, you do not have permissions to edit rooms.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            foreach (var g in Guest.AllReservedGuests)
            {
                if (g.Room == Room.GetRoomByNo(uint.Parse(dataGridViewRooms.SelectedCells[0].Value.ToString())))
                {
                    MessageBox.Show("Non-empty rooms cannot be removed. Remove any guests from this room first.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    if (MessageBox.Show("Do you really want to remove this room?", "Hotelogram", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        Room.AllRooms.Remove(Room.GetRoomByNo(uint.Parse(dataGridViewRooms.SelectedCells[0].Value.ToString())));
                        updateList();
                    }
                }
            }

            foreach (Guest g in Guest.AllRegisteredGuests)
            {
                if (g.Room == Room.GetRoomByNo(uint.Parse(dataGridViewRooms.SelectedCells[0].Value.ToString())))
                {
                    MessageBox.Show("Non-empty rooms cannot be removed. Remove any guests from this room first.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    if (MessageBox.Show("Do you really want to remove this room?", "Hotelogram", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        Room.AllRooms.Remove(Room.GetRoomByNo(uint.Parse(dataGridViewRooms.SelectedCells[0].Value.ToString())));
                        updateList();
                    }
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            updateList();
        }
    }
}
