using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programm
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void btnAddAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAddName.Text))
            {
                MessageBox.Show("Fill out the \"First name\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbAddName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbAddSurname.Text))
            {
                MessageBox.Show("Fill out the \"Last name\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbAddSurname.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbAddEmail.Text))
            {
                MessageBox.Show("Fill out the \"Email address\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbAddEmail.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbAddPhone.Text))
            {
                MessageBox.Show("Fill out the \"Phone number\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbAddPhone.Focus();
                return;
            }

            try
            {
                Client client = new Client(tbAddName.Text, tbAddSurname.Text, tbAddEmail.Text, tbAddPhone.Text);
                ClientCSV clientCSV = new ClientCSV(tbAddName.Text, tbAddSurname.Text, tbAddEmail.Text, tbAddPhone.Text);
                ClientManager.AddClient(client);
                ClientManager.AddClient(clientCSV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MessageBox.Show("Entry created successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
