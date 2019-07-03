using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Hotelogram
{
    public partial class DAddEmployee : Form
    {
        private Employee _employee;
        private bool _addOrEdit = true;
        private string _textToSplit;
        private readonly string[] _hour = new string[2];
        private readonly string[] _minute = new string[2];

        public DAddEmployee()
        {
            InitializeComponent();
        }

        public void Show(Employee employee)
        {
            _employee = employee;
            Show();
        }

        public void SetMode(bool addOrEdit)
        {
            _addOrEdit = addOrEdit;
        }

        private void DAddEmployee_Load(object sender, EventArgs e)
        {
            if(_addOrEdit)
            {
                Text = "Add an Employee | Hotelogram";
                LabelHeader.Text = "Add Employee";
                ButtonAdd.Text = "Add";
            }
            else
            {
                Text = "Edit Employee | Hotelogram";
                LabelHeader.Text = "Edit Employee";
                ButtonAdd.Text = "Done";

                MaskedTextBoxTCID.Text = _employee.TCID.ToString();
                TextBoxFullName.Text = _employee.Name;
                TextBoxAddress.Text = _employee.Address;
                TextBoxGSMNumber.Text = _employee.GSMNumber;
                TextBoxJob.Text = _employee.Job;
                foreach (var d in _employee.WorkingDays)
                {
                    switch (d)
                    {
                        case Day.Monday:
                            CheckedListBoxWorkingDays.SetItemChecked(0, true);
                            break;

                        case Day.Tuesday:
                            CheckedListBoxWorkingDays.SetItemChecked(1, true);
                            break;

                        case Day.Wednesday:
                            CheckedListBoxWorkingDays.SetItemChecked(2, true);
                            break;

                        case Day.Thursday:
                            CheckedListBoxWorkingDays.SetItemChecked(3, true);
                            break;

                        case Day.Friday:
                            CheckedListBoxWorkingDays.SetItemChecked(4, true);
                            break;

                        case Day.Saturday:
                            CheckedListBoxWorkingDays.SetItemChecked(5, true);
                            break;

                        case Day.Sunday:
                            CheckedListBoxWorkingDays.SetItemChecked(6, true);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }

                _hour[0] = _employee.WorkingHourStart.Hour.ToString();
                _hour[1] = _employee.WorkingHourEnd.Hour.ToString();
                _minute[0] = _employee.WorkingHourStart.Minute.ToString();
                _minute[1] = _employee.WorkingHourEnd.Minute.ToString();

                if (_employee.WorkingHourStart.Hour < 10)
                    _hour[0] = "0" + _employee.WorkingHourStart.Hour;

                if (_employee.WorkingHourStart.Minute < 10)
                    _minute[0] = "0" + _employee.WorkingHourStart.Minute;

                if (_employee.WorkingHourEnd.Hour < 10)
                    _hour[1] = "0" + _employee.WorkingHourEnd.Hour;

                if (_employee.WorkingHourEnd.Minute < 10)
                    _minute[1] = "0" + _employee.WorkingHourEnd.Minute;

                MaskedTextBoxHours.Text = $"{_hour[0]}:{_minute[0]} - {_hour[1]}:{_minute[1]}";
                TextBoxSalary.Text = _employee.Salary.ToString(CultureInfo.CurrentCulture);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DAddEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.DAddEmployee = null;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (MaskedTextBoxTCID.Text != "")
                {
                    if (TextBoxFullName.Text != "")
                    {
                        if (TextBoxAddress.Text != "")
                        {
                            if (TextBoxGSMNumber.Text != "")
                            {
                                if (TextBoxJob.Text != "")
                                {
                                    if (CheckedListBoxWorkingDays.CheckedItems.Count != 0)
                                    {
                                        if (MaskedTextBoxHours.Text != "")
                                        {
                                            if (TextBoxSalary.Text != "")
                                            {
                                                if(float.Parse(TextBoxSalary.Text) >= 0)
                                                {
                                                    _textToSplit = MaskedTextBoxHours.Text;
                                                    _textToSplit = _textToSplit.Replace("-", string.Empty);
                                                    _textToSplit = _textToSplit.Replace(":", string.Empty);
                                                    _textToSplit = _textToSplit.Replace(" ", string.Empty);

                                                    byte hour1 = byte.Parse(Utilities.Split(_textToSplit, 2)[0]);
                                                    byte hour2 = byte.Parse(Utilities.Split(_textToSplit, 2)[2]);
                                                    byte minute1 = byte.Parse(Utilities.Split(_textToSplit, 2)[1]);
                                                    byte minute2 = byte.Parse(Utilities.Split(_textToSplit, 2)[3]);

                                                    if (hour1 <= 23 && hour2 <= 23 && minute1 <= 59 && minute2 <= 59)
                                                    {
                                                        Employee.AllEmployees.Remove(_employee);
                                                        CreateEmployee();
                                                        FormHelper.FEmployees.UpdateList();
                                                        Close();
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("The working hours you entered are not valid. Please change and try again.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("The salary amount you entered is not valid. Please change and try again.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please enter the salary of the employee.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please enter the working hours of the employee.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please select at least one day the employee will work.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please enter the job of the employee.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter the GSM number of the employee.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter the home address of the employee.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter the full name the employee.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the T.C. ID of the employee.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("One of the values you have entered is not valid. Please check and try again.\n\nAn ArgumentNullException caused this message box to show.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            catch(FormatException)
            {
                MessageBox.Show("The salary amount you entered is not valid. Please change and try again.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            catch(OverflowException)
            {
                MessageBox.Show("One of the values you have entered is too big. Please check and try again.\n\nAn OverflowException caused this message box to show.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("One of the values you have entered is too big. Please check and try again.\n\nAn ArgumentOutOfRangeException caused this message box to show.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("There was an unknown error while getting working hours. Please try again with different working hours.\n\nAn IndexOutOfRangeException caused this message box to show.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        public void CreateEmployee()
        {
            var wd = new List<Day>();
            var whs = new Time(byte.Parse(Utilities.Split(_textToSplit, 2)[0]), byte.Parse(Utilities.Split(_textToSplit, 2)[1]), 00);
            var whe = new Time(byte.Parse(Utilities.Split(_textToSplit, 2)[2]), byte.Parse(Utilities.Split(_textToSplit, 2)[3]), 00);

            foreach (int index in CheckedListBoxWorkingDays.CheckedIndices)
            {
                switch(index)
                {
                    case 0:
                        wd.Add(Day.Monday);
                        break;
                    case 1:
                        wd.Add(Day.Tuesday);
                        break;
                    case 2:
                        wd.Add(Day.Wednesday);
                        break;
                    case 3:
                        wd.Add(Day.Thursday);
                        break;
                    case 4:
                        wd.Add(Day.Friday);
                        break;
                    case 5:
                        wd.Add(Day.Saturday);
                        break;
                    case 6:
                        wd.Add(Day.Sunday);
                        break;
                    default:
                        wd.Add(Day.Default);
                        break;
                }
            }

            new Employee(long.Parse(MaskedTextBoxTCID.Text), TextBoxFullName.Text, TextBoxAddress.Text, TextBoxGSMNumber.Text, TextBoxJob.Text, wd.ToArray(), whs, whe, float.Parse(TextBoxSalary.Text.Replace('.', ',')));
        }
    }
}
