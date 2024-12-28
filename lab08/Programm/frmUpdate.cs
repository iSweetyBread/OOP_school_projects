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
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
        }

        private void btnUpdateUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbId1.Text, out _))
            {
                MessageBox.Show("Fill out the \"ID\" field with a valid number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbId1.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbChange.Text))
            {
                MessageBox.Show("Fill out the \"Change\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbChange.Focus();
                return;
            }

            int attribute;
            if (rbtnName.Checked)
            {
                attribute = 1;
            }
            else if (rbtnSurname.Checked)
            {
                attribute = 2;
            }
            else if (rbtnEmail.Checked)
            {
                attribute = 3;
                if (!ValidationHelper.IsValidEmail(tbChange.Text))
                {
                    MessageBox.Show("Fill out the \"Change\" field with a valid email address", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbChange.Focus();
                    return;
                }
            }
            else if (rbtnPhone.Checked)
            {
                attribute = 4;
                if (!ValidationHelper.IsValidPhone(tbChange.Text))
                {
                    MessageBox.Show("Fill out the \"Change\" field with a valid phone number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbChange.Focus();
                    return;
                }
            }
            else
            {
                attribute = 0;
                MessageBox.Show("Choose an attribute to change", "Choice Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                groupBox1.Focus();
                return;
            }

            try
            {
                DatabaseManager.Update(int.Parse(tbId1.Text), attribute, tbChange.Text);
                DatabaseManagerCSV.Update(int.Parse(tbId1.Text), attribute, tbChange.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Entry updated successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
