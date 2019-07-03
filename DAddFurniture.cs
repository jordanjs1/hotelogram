using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelogram
{
    public partial class DAddFurniture : Form
    {
        public DAddFurniture()
        {
            InitializeComponent();
        }

        private void DAddFurniture_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.DAddFurniture = null;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxName.Text != "")
                {
                    FormHelper.DAddRoom.Furniture = new Furniture(TextBoxName.Text, ushort.Parse(NumericUpDownCount.Value.ToString(CultureInfo.CurrentCulture)));
                    Close();
                }
                else
                {
                    MessageBox.Show("Furniture name cannot be empty. Please enter a name.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            catch
            {
                MessageBox.Show("You haven't entered a valid count. Please enter a valid count and try again.", "Hotelogram", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void DAddFurniture_Load(object sender, EventArgs e)
        {
            FormHelper.DAddRoom.Furniture = null;
        }
    }
}
