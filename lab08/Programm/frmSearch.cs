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
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void btnSeacrhSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSearch.Text))
            {
                MessageBox.Show("Fill out the \"Change\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSearch.Focus();
                return;
            }

            int attribute;
            if (rbtnName1.Checked)
            {
                attribute = 1;
            }
            else if (rbtnSurname1.Checked)
            {
                attribute = 2;
            }
            else if (rbtnEmail1.Checked)
            {
                attribute = 3;
                if (!ValidationHelper.IsValidEmail(tbSearch.Text))
                {
                    MessageBox.Show("Fill out the \"Change\" field with a valid email address", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbSearch.Focus();
                    return;
                }
            }
            else if (rbtnPhone1.Checked)
            {
                attribute = 4;
                if (!ValidationHelper.IsValidPhone(tbSearch.Text))
                {
                    MessageBox.Show("Fill out the \"Change\" field with a valid phone number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbSearch.Focus();
                    return;
                }
            }
            else
            {
                attribute = 0;
                MessageBox.Show("Choose an attribute to find by", "Choice Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                groupBox2.Focus();
                return;
            }

            StringBuilder text = new StringBuilder();
            List<string> data;
            try
            {
                data = DatabaseManager.Search(attribute, tbSearch.Text);
            }
            catch (Exception ex)
            {
                try
                {
                    data = DatabaseManagerCSV.Search(attribute, tbSearch.Text);
                }
                catch (Exception ex1)
                {
                    tbResult.Text = "Cannot get data from either of sources";
                    return;
                }
            }

            if (data.Count == 0)
            {
                tbResult.Text = "No entries found";
                return;
            }
            else
            {
                foreach (string s in data)
                {
                    text.AppendLine(s);
                }
            }
            tbResult.Text = text.ToString();
        }
    }
}
