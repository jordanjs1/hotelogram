using System;
using System.Windows.Forms;

namespace Hotelogram
{
    public partial class DBillInfo : Form
    {
        private Bill _bill;

        public DBillInfo()
        {
            InitializeComponent();
        }

        public void Show(Bill b)
        {
            _bill = b;
            Show();
        }

        public void UpdateList()
        {
            DataGridViewBillInfo.Rows.Clear();

            foreach(var a in _bill.AllActions)
                DataGridViewBillInfo.Rows.Add($"{a.ActionID}", $"{a.ActionDescription}", $"{a.Amount} ₺");
        }

        private void DBillInfo_Load(object sender, EventArgs e)
        {
            Text = $"Bill Information of {_bill.Owner.Name} | Hotelogram";
            LabelHeader.Text = $"Bill Information of {_bill.Owner.Name}";
            UpdateList();
        }

        private void DBillInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.DBillInfo = null;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            FormHelper.FGuests.UpdateList();
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormHelper.DAddAction.Bill = _bill;
            FormHelper.DAddAction.ShowDialog();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to remove this action?", "Hotelogram", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                _bill.AllActions.Remove(Bill.Action.GetActionByID(_bill, int.Parse(DataGridViewBillInfo.SelectedCells[0].Value.ToString())));
                UpdateList();
            }
        }

        private void dataGridViewBillInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ButtonRemove.Enabled = e.ColumnIndex == 0;
        }
    }
}
