using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hotelogram
{
    public partial class DAddRoom : Form
    {
        private string _mboxTypeString;
        private string _mboxFurnitureString;
        private Room _room;
        private bool _mode = true;
        public List<Furniture> Furnitures = new List<Furniture>();
        public Furniture Furniture;

        public DAddRoom()
        {
            InitializeComponent();
        }

        public void Show(Room r)
        {
            _room = r;
            Show();
        }

        public void setMode(bool mode)
        {
            _mode = mode;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(!_mode)
                Room.AllRooms.Remove(_room);

            try
            {
                if (Room.GetRoomByNo(uint.Parse(NumericUpDownNo.Value.ToString())) != null)
                {
                    MessageBox.Show($"You already have a room with number {NumericUpDownNo.Value}. Please change it and try again.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("You haven't selected a valid room number. Please check and try again.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            try
            {
                if (TextBoxFloor.Text != "")
                {
                    if (TextBoxType.Text != "")
                    {
                        if (ListBoxFurniture.Items.Count != 0)
                        {
                            new Room(int.Parse(NumericUpDownNo.Value.ToString()), short.Parse(TextBoxFloor.Text), TextBoxType.Text, Furnitures);
                            FormHelper.FRooms.updateList();
                            Close();
                        }
                        else
                        {
                            if (MessageBox.Show(_mboxFurnitureString, "Hotelogram", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                new Room(int.Parse(NumericUpDownNo.Value.ToString()), short.Parse(TextBoxFloor.Text), TextBoxType.Text, Furnitures);
                                FormHelper.FRooms.updateList();
                                Close();
                            }
                        }
                    }
                    else
                    {
                        if (MessageBox.Show(_mboxTypeString, "Hotelogram", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            new Room(int.Parse(NumericUpDownNo.Value.ToString()), short.Parse(TextBoxFloor.Text), TextBoxType.Text, Furnitures);
                            FormHelper.FRooms.updateList();
                            Close();
                        }
                    }
                }
                else
                    MessageBox.Show($"Floor cannot be empty. Please enter a floor.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            catch
            {
                MessageBox.Show("You haven't entered a valid floor. Please check and try again.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void buttonAddFurniture_Click(object sender, EventArgs e)
        {
            var dontAdd = false;
            FormHelper.DAddFurniture.ShowDialog();

            if (Furniture == null) return;

            foreach (var f in Furnitures)
            {
                if (f.Name != Furniture.Name) continue;

                f.Count += Furniture.Count;
                dontAdd = true;
            }

            if (!dontAdd)
                Furnitures.Add(Furniture);

            ListBoxFurniture.Items.Clear();
            foreach (var f in Furnitures) { ListBoxFurniture.Items.Add($"{f.Name} ({f.Count})"); }
        }

        private void DAddRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.DAddRoom = null;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DAddRoom_Load(object sender, EventArgs e)
        {
            if(_mode)
            {
                Text = "Add a Room | Hotelogram";
                LabelHeader.Text = "Add a Room";
                ButtonAdd.Text = "Add";
                _mboxTypeString = "That room has no type. Do you wish to add this room?";
                _mboxFurnitureString = "That room has no furniture. Do you wish to add this room?";
            }
            else
            {
                Text = "Edit a Room | Hotelogram";
                LabelHeader.Text = "Edit a Room";
                ButtonAdd.Text = "Done";
                _mboxTypeString = "That room has no type. Do you wish to continue?";
                _mboxFurnitureString = "That room has no furniture. Do you wish to continue?";
                NumericUpDownNo.Value = _room.No;
                TextBoxFloor.Text = _room.Floor.ToString();
                TextBoxType.Text = _room.Type;
                Furnitures = _room.FurnitureList;
                foreach (var f in Furnitures) { ListBoxFurniture.Items.Add($"{f.Name} ({f.Count})"); }

                foreach (var g in Guest.AllReservedGuests) { if (g.Room != null && g.Room.No == _room.No) { NumericUpDownNo.Enabled = false; } else { NumericUpDownNo.Enabled = true; } }
                foreach (var g in Guest.AllRegisteredGuests) { if (g.Room != null && g.Room.No == _room.No) { NumericUpDownNo.Enabled = false; } else { NumericUpDownNo.Enabled = true; } }
            }
        }

        private void buttonRemoveAllFurniture_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to remove all furniture you have added?", "Hotelogram", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Furnitures.Clear();
                ListBoxFurniture.Items.Clear();
            }
        }
    }
}