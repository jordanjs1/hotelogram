using System;
using System.Windows.Forms;

namespace Hotelogram
{
    public partial class DLogin : Form
    {
        public DLogin()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormHelper.FMainMenu.AlreadyClosing = true;
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            User user = null;

            foreach (var u in User.AllUsers)
            {
                if (!TextBoxUserName.Text.Equals(u.Name, StringComparison.CurrentCultureIgnoreCase)) continue;

                user = u;
                break;
            }

            if (user == null)
                MessageBox.Show($"No users are found with user name \"{TextBoxUserName.Text}\". Please check your user name.", "User not found", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            else
            {
                if (TextBoxPassword.Text == user.Password)
                {
                    User.LoggedUser = user;
                    FormHelper.FMainMenu.OnUserLogin();
                    FormHelper.FMainMenu.Show();
                    TextBoxUserName.Clear();
                    TextBoxPassword.Clear();
                    Hide();
                }
                else
                    MessageBox.Show($"The password you have entered is not correct. Passwords are case sensitive. Please check your password.", "Wrong password", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void panelShowPassword_MouseEnter(object sender, EventArgs e)
        {
            TextBoxPassword.UseSystemPasswordChar = false;
        }

        private void panelShowPassword_MouseLeave(object sender, EventArgs e)
        {
            TextBoxPassword.UseSystemPasswordChar = true;
        }

        private void DLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
