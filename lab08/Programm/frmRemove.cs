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
    public partial class frmRemove : Form
    {
        public frmRemove()
        {
            InitializeComponent();
        }

        private void btnRemoveRemove_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbId.Text, out _))
            {
                MessageBox.Show("Fill out the \"ID\" field with a valid number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbId.Focus();
                return;
            }

            try
            {
                DatabaseManager.Delete(int.Parse(tbId.Text));
                DatabaseManagerCSV.Delete(int.Parse(tbId.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MessageBox.Show("Entry removed successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
