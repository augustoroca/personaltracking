using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace PersonalTracking
{
    public partial class FrmPosition : Form
    {
        public FrmPosition()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<DEPARTMENT> departmentList = new List<DEPARTMENT>();
        private void FrmPosition_Load(object sender, EventArgs e)
        {
            departmentList = DepartmentBLL.GetDepartments();
            cmbDeparment.DataSource = departmentList;
            cmbDeparment.DisplayMember = "DepartmentName";
            cmbDeparment.ValueMember = "ID";
            cmbDeparment.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPosition.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the position name");
            }
            else if (cmbDeparment.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a department");
            }
            else
            {
                POSITION position = new POSITION();
                position.PositionName = txtPosition.Text;
                position.DepartmentID = Convert.ToInt32(cmbDeparment.SelectedValue);
                PositionBLL.AddPosition(position);
                MessageBox.Show("Position was added");
                txtPosition.Clear();
                cmbDeparment.SelectedIndex = -1;

            }
        }
    }
}
