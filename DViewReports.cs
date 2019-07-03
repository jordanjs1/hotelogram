using System;
using System.Windows.Forms;

namespace Hotelogram
{
    public partial class DViewReports : Form
    {
        private Employee _employee;

        public DViewReports()
        {
            InitializeComponent();
        }

        public void Show(Employee e)
        {
            _employee = e;
            Show();
        }

        public void UpdateList()
        {
            dataGridViewReports.Rows.Clear();
            foreach (var r in _employee.Reports)
                dataGridViewReports.Rows.Add($"{r.ID}", $"{r.report}");
        }

        private void DViewReports_Load(object sender, EventArgs e)
        {
            Text = $"Manage Reports of {_employee.Name} | Hotelogram";
            labelHeader.Text = $"Manage Reports of {_employee.Name}";
            UpdateList();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (User.LoggedUser.Permissions.EmployeePermissions.HasFlag(EmployeePermission.RemoveReport))
            {
                if (MessageBox.Show("Do you wish to remove all reports?", "Hotelogram", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    _employee.Reports.Clear();
                    UpdateList();
                }
            }
            else
                MessageBox.Show($"Sorry {User.LoggedUser.Name}, you do not have permissions to remove reports.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void DViewReports_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.DViewReports = null;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (User.LoggedUser.Permissions.EmployeePermissions.HasFlag(EmployeePermission.Add))
            {
                if (textBoxReport.Text != "")
                {
                    new Employee.Report(_employee, textBoxReport.Text);
                    UpdateList();
                    MessageBox.Show("The report has been added successfully.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    textBoxReport.Clear();
                }
                else
                    MessageBox.Show("Please enter the report description.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
                MessageBox.Show($"Sorry {User.LoggedUser.Name}, you do not have permissions to add reports.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
