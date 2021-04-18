using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace PersonalTracking
{
    public partial class FrmDeparmentList : Form
    {
        public FrmDeparmentList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmDepartment frm = new FrmDepartment();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            list = DepartmentBLL.GetDepartments();
            dataGridView1.DataSource = list;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmDepartment frm = new FrmDepartment();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        List<DEPARTMENT> list = new List<DEPARTMENT>();
        private void FrmDeparmentList_Load(object sender, EventArgs e)
        {
            
            list = BLL.DepartmentBLL.GetDepartments();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].HeaderText = "Department ID";
            dataGridView1.Columns[0].Visible = false;//Para Ocultar la primera columna
            dataGridView1.Columns[1].HeaderText = "Department Name";
        }
    }
}
