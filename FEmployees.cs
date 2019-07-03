using System;
using System.Windows.Forms;

namespace Hotelogram
{
    public partial class FEmployees : Form
    {
        public FEmployees()
        {
            InitializeComponent();
        }

        public void UpdateList()
        {
            var hour = new string[2];
            var minute = new string[2];
            var days = string.Empty;

            dataGridViewEmployees.Rows.Clear();

            foreach (var e in Employee.AllEmployees)
            {
                days = "";
                hour[0] = e.WorkingHourStart.Hour.ToString();
                hour[1] = e.WorkingHourEnd.Hour.ToString();
                minute[0] = e.WorkingHourStart.Minute.ToString();
                minute[1] = e.WorkingHourEnd.Minute.ToString();

                if (e.WorkingHourStart.Hour < 10)
                {
                    hour[0] = "0" + e.WorkingHourStart.Hour.ToString();
                }

                if(e.WorkingHourStart.Minute < 10)
                {
                    minute[0] = "0" + e.WorkingHourStart.Minute.ToString();
                }

                if (e.WorkingHourEnd.Hour < 10)
                {
                    hour[1] = "0" + e.WorkingHourEnd.Hour.ToString();
                }

                if (e.WorkingHourEnd.Minute < 10)
                {
                    minute[1] = "0" + e.WorkingHourEnd.Minute.ToString();
                }

                if (e.WorkingDays.Contains(Day.Monday))
                {
                    days += "Monday ";
                }
                if (e.WorkingDays.Contains(Day.Tuesday))
                {
                    days += "Tuesday ";
                }
                if (e.WorkingDays.Contains(Day.Wednesday))
                {
                    days += "Wednesday ";
                }
                if (e.WorkingDays.Contains(Day.Thursday))
                {
                    days += "Thursday ";
                }
                if (e.WorkingDays.Contains(Day.Friday))
                {
                    days += "Friday ";
                }
                if (e.WorkingDays.Contains(Day.Saturday))
                {
                    days += "Saturday ";
                }
                if (e.WorkingDays.Contains(Day.Sunday))
                {
                    days += "Sunday";
                }

                dataGridViewEmployees.Rows.Add($"{e.ID}", $"{e.TCID.ToString()}", $"{e.Name}", $"{e.Address}", $"{e.GSMNumber}", $"{e.Job}", days, $"{hour[0]}:{minute[0]} - {hour[1]}:{minute[1]}", $"{e.Salary} ₺");
            }
        }

        private void FEmployees_Load(object sender, EventArgs ea)
        {
            UpdateList();
        }

        private void FEmployees_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.FEmployees = null;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (User.LoggedUser.Permissions.EmployeePermissions.HasFlag(EmployeePermission.Add))
            {
                FormHelper.DAddEmployee.SetMode(true);
                FormHelper.DAddEmployee.MdiParent = FormHelper.FMainMenu;
                FormHelper.DAddEmployee.Show();
            }
            else
            {
                MessageBox.Show($"Sorry {User.LoggedUser.Name}, you do not have permission to add employees.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            if (User.LoggedUser.Permissions.EmployeePermissions.HasFlag(EmployeePermission.ViewReports))
            {
                FormHelper.DViewReports.MdiParent = FormHelper.FMainMenu;
                FormHelper.DViewReports.Show(Employee.getEmployeeByID(int.Parse(dataGridViewEmployees.SelectedCells[0].Value.ToString())));
            }
            else
                MessageBox.Show($"Sorry {User.LoggedUser.Name}, you do not have permission to add employees.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (User.LoggedUser.Permissions.EmployeePermissions.HasFlag(EmployeePermission.Remove))
            {
                if (MessageBox.Show("Do you wish to remove this employee?", "Hotelogram", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Employee.AllEmployees.Remove(Employee.getEmployeeByID(int.Parse(dataGridViewEmployees.SelectedCells[0].Value.ToString())));
                    UpdateList();
                }
            }
            else
            {
                MessageBox.Show($"Sorry {User.LoggedUser.Name}, you do not have permission to remove employees.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        private void dataGridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                buttonEdit.Enabled = true;
                buttonRemove.Enabled = true;
                buttonReports.Enabled = true;
            }
            else
            {
                buttonEdit.Enabled = false;
                buttonRemove.Enabled = false;
                buttonReports.Enabled = false;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (User.LoggedUser.Permissions.EmployeePermissions.HasFlag(EmployeePermission.Edit))
            {
                FormHelper.DAddEmployee.SetMode(false);
                FormHelper.DAddEmployee.MdiParent = FormHelper.FMainMenu;
                FormHelper.DAddEmployee.Show(Employee.getEmployeeByID(int.Parse(dataGridViewEmployees.SelectedCells[0].Value.ToString())));
            }
            else
            {
                MessageBox.Show($"Sorry {User.LoggedUser.Name}, you do not have permission to remove employees.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
