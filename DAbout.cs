using System;
using System.Windows.Forms;

namespace Hotelogram
{
    public partial class DAbout : Form
    {
        public DAbout()
        {
            InitializeComponent();
        }

        private void DAbout_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.DAbout = null;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
