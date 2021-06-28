using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _19SpringB5_1
{
    public partial class FrmComporation : Form
    {
        public FrmComporation()
        {
            InitializeComponent();
        }
        private void RefreshCO()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DAO.Corporation.GetAllemployee();
            dataGridView1.Columns[1].HeaderText = "Corporation No";
            dataGridView1.Columns[2].HeaderText = "Corporation Name";
            dataGridView1.Columns[3].HeaderText = "Street";
            dataGridView1.Columns[4].HeaderText = "Region Name";
        }
        private void FrmComporation_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn select = new DataGridViewCheckBoxColumn();
            select.Name = "selectColumn";
            select.HeaderText = "Select";
            select.ValueType = typeof(bool);
            dataGridView1.Columns.Add(select);

            RefreshCO();
        }
    }
}
