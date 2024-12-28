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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd frmAdd = new frmAdd();
            frmAdd.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            frmRemove frmRemove = new frmRemove();
            frmRemove.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdate frmUdpate = new frmUpdate();
            frmUdpate.ShowDialog();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            StringBuilder text = new StringBuilder();
            List<string> data;
            try
            {
                data = DatabaseManager.Read();
            }
            catch (Exception ex)
            {
                try
                {
                    data = DatabaseManagerCSV.Read();
                }
                catch (Exception ex1)
                {
                    tbMain.Text = "Cannot get data from either of sources";
                    return;
                }
            }
            if (data.Count == 0)
            {
                tbMain.Text = "No entries found";
                return;
            }
            else
            {
                foreach (string s in data)
                {
                    text.AppendLine(s);
                }
            }
            tbMain.Text = text.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch();
            frmSearch.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
