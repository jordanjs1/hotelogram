using System;
using System.Windows.Forms;

namespace Hotelogram
{
    public partial class FMainMenu : Form
    {
        public bool AlreadyClosing;    //Flag for FormClosing event. "true" if the program is exiting.
        bool _exitAction = true;    //Flag for form closing reason. "true" means program exit, "false" means user logout.

        public void OnUserLogin()
        {
            Text = $"Main Menu | Hotelogram - {User.LoggedUser.Name}";
        }

        public void OnUserLogout()
        {
            User.LoggedUser = User.NullUser;
        }

        public FMainMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// "Exit" tool strip menu item.
        /// </summary>
        /// <param name="sender">Event sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _exitAction = true;
            Close();
        }

        private void FMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AlreadyClosing) return;

            if (_exitAction)
            {
                if (MessageBox.Show("Do you wish to exit?", "Hotelogram", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    e.Cancel = false;
                    AlreadyClosing = true;
                    Application.Exit();
                }
                else
                    e.Cancel = true;
            }
            else
            {
                if (MessageBox.Show("Do you wish to logout?", "Hotelogram", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    OnUserLogout();
                    FormHelper.FMainMenu = null;
                    FormHelper.DLogin.Show();
                }
                else
                    e.Cancel = true;
            }
        }

        /// <summary>
        /// "Logout" tool strip menu item.
        /// </summary>
        /// <param name="sender">Event sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _exitAction = false;
            Close();
        }

        /// <summary>
        /// "Guests" tool strip menu item.
        /// </summary>
        /// <param name="sender">Event sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void guestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(User.LoggedUser.Permissions.GuestPermissions.HasFlag(GuestPermission.View))
            {
                FormHelper.FGuests.MdiParent = this;
                FormHelper.FGuests.Show();
            }
            else
                MessageBox.Show($"Sorry {User.LoggedUser.Name}, you do not have permissions to view guests.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// "Employees" tool strip menu item.
        /// </summary>
        /// <param name="sender">Event sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (User.LoggedUser.Permissions.EmployeePermissions.HasFlag(EmployeePermission.View))
            {
                FormHelper.FEmployees.MdiParent = this;
                FormHelper.FEmployees.Show();
            }
            else
                MessageBox.Show($"Sorry {User.LoggedUser.Name}, you do not have permissions to view employees.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// "Rooms" tool strip menu item.
        /// </summary>
        /// <param name="sender">Event sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (User.LoggedUser.Permissions.UserPermissions.HasFlag(UserPermission.View))
            {
                FormHelper.FRooms.MdiParent = this;
                FormHelper.FRooms.Show();
            }
            else
                MessageBox.Show($"Sorry {User.LoggedUser.Name}, you do not have permissions to view rooms.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.DAbout.ShowDialog();
        }

        private void QueryTheDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (User.LoggedUser.Permissions.UserPermissions.HasFlag(UserPermission.QueryDatabase))
            {
                //FormHelper.FQueryDatabase.MdiParent = this;
                //FormHelper.FQueryDatabase.Show();
            }
            else
                MessageBox.Show($"Sorry {User.LoggedUser.Name}, you do not have permissions to query the database.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
    }
}
