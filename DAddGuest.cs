using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
//using VDS.RDF;

//BUG: Editing reserved guest adds the edited guest but doesn't remove the old guest.

namespace Hotelogram
{
    public partial class DAddGuest : Form
    {
        private Bill _tempBill;
        private Guest _g;
        private bool _addOrEdit = true;

        public DAddGuest()
        {
            InitializeComponent();
        }

        public void Show(Guest guest)
        {
            _g = guest;
            Show();
        }

        public void SetMode(bool addOrEdit)
        {
            _addOrEdit = addOrEdit;
        }

        private void DAddGuest_Shown(object sender, EventArgs e)
        {
            if (ComboBoxRooms.Items.Count != 1) return;

            MessageBox.Show("No rooms are added. Registration is disabled until at least a room is added.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            ButtonRegister.Enabled = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DAddGuest_Load(object sender, EventArgs e)
        {
            ComboBoxRooms.Items.Add("No room");
            ComboBoxRooms.Text = "No room";

            foreach (var r in Room.AllRooms)
                ComboBoxRooms.Items.Add($"Room #{r.No.ToString()} - {r.Floor.ToString()}. floor" + (r.Type != "" ? $" - {r.Type}" : ""));

            if (_addOrEdit)
            {
                Text = "Add a Guest | Hotelogram";
                LabelHeader.Text = "Add a Guest";
                ButtonReserve.Visible = true;
                ButtonRegister.Text = "Register";
            }
            else
            {
                Text = "Edit Guest | Hotelogram";
                LabelHeader.Text = "Edit Guest";
                ButtonReserve.Visible = true;
                //buttonRegister.Text = "Done";

                TextBoxTCID.Text = _g.TCID.ToString();
                TextBoxName.Text = _g.Name;
                TextBoxGSMNumber.Text = _g.GSMNumber;

                if (_g.Room != null)
                    ComboBoxRooms.Text = $"Room #{_g.Room.No} - {_g.Room.Floor}. floor" + (_g.Room.Type != "" ? $" - {_g.Room.Type}" : "");
            }
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            if (!_addOrEdit)
            {
                _tempBill = _g.Bill;
                if (_g.IsRegistered == true)
                    Guest.AllRegisteredGuests.Remove(_g);
                else
                    Guest.AllReservedGuests.Remove(_g);
            }

            try
            {
                if (TextBoxName.Text != "")
                {
                    if (TextBoxTCID.Text != "")
                    {
                        if (TextBoxGSMNumber.Text != "")
                        {
                            if(ComboBoxRooms.Text != "No room")
                            {
                                new Guest(long.Parse(TextBoxTCID.Text), TextBoxName.Text, TextBoxGSMNumber.Text, Room.GetRoomByNo(uint.Parse(Regex.Match(ComboBoxRooms.SelectedItem.ToString(), @"\d+").Value)), false);
                                FormHelper.FGuests.UpdateList();
                                Close();
                            }
                            else
                            {
                                new Guest(long.Parse(TextBoxTCID.Text), TextBoxName.Text, TextBoxGSMNumber.Text);
                                FormHelper.FGuests.UpdateList();
                                Close();
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("The guest has no GSM number. Do you wish to continue?", "Hotelogram", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                new Guest(long.Parse(TextBoxTCID.Text), TextBoxName.Text, "");
                                FormHelper.FGuests.UpdateList();
                                Close();
                            }
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("The guest has no T.C. ID. Do you wish to continue?", "Hotelogram", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            new Guest(0, TextBoxName.Text, TextBoxGSMNumber.Text);
                            FormHelper.FGuests.UpdateList();
                            Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the guest's name.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please enter a T.C. ID.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            catch (FormatException)
            {
                MessageBox.Show("You have not entered a valid T.C. ID. Please check and try again.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            catch (OverflowException)
            {
                MessageBox.Show("You have not entered a valid T.C. ID. Please check and try again.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if(!_addOrEdit)
            {
                _tempBill = _g.Bill;
                if (_g.IsRegistered)
                    Guest.AllRegisteredGuests.Remove(_g);
                else
                    Guest.AllReservedGuests.Remove(_g);
            }

            try
            {
                if (TextBoxName.Text != "")
                {
                    if (ComboBoxRooms.Text != "No room")
                    {
                        if (TextBoxGSMNumber.Text != "")
                        {
                            if(TextBoxTCID.Text != "")
                            {
                                var a = new Guest(long.Parse(TextBoxTCID.Text), TextBoxName.Text, TextBoxGSMNumber.Text, Room.GetRoomByNo(uint.Parse(Regex.Match(ComboBoxRooms.SelectedItem.ToString(), @"\d+").Value)), true);
                                if (!_addOrEdit && _g.IsRegistered)
                                    a.Bill = _tempBill;

                                FormHelper.FGuests.UpdateList();
                                Close();
                            }
                            else
                            {
                                if (MessageBox.Show("The guest has no T.C. ID. Do you wish to continue?", "Hotelogram", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                                {
                                    var a = new Guest(long.Parse(TextBoxTCID.Text), TextBoxName.Text, TextBoxGSMNumber.Text, Room.GetRoomByNo(uint.Parse(Regex.Match(ComboBoxRooms.SelectedItem.ToString(), @"\d+").Value)), true);
                                    if (!_addOrEdit && _g.IsRegistered)
                                        a.Bill = _tempBill;

                                    FormHelper.FGuests.UpdateList();
                                    Close();
                                }
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("The guest has no GSM number. Do you wish to continue?", "Hotelogram", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                var a = new Guest(long.Parse(TextBoxTCID.Text), TextBoxName.Text, TextBoxGSMNumber.Text, Room.GetRoomByNo(uint.Parse(Regex.Match(ComboBoxRooms.SelectedItem.ToString(), @"\d+").Value)), true);
                                if (!_addOrEdit && _g.IsRegistered)
                                    a.Bill = _tempBill;

                                FormHelper.FGuests.UpdateList();
                                Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a room to register the guest.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the guest's name.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("An NullReferenceException was caught.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            catch (Exception)
            {
                MessageBox.Show("You have not entered a valid T.C. ID. Please check and try again.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void DAddGuest_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            FormHelper.DAddGuest = null;
        }
    }
}
