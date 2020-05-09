using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HansAdvInterfaceCSharpTest
{
    public partial class AddPointForm : Form
    {
        public double m_dbX = 0.0;
        public double m_dbY = 0.0;
        public bool ClickAdd = false;

        public AddPointForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClickAdd = false;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                m_dbX = Convert.ToDouble(this.tbX.Text);
                m_dbY = Convert.ToDouble(this.tbY.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("输入的数据不合法！\n" + ex.Message, "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ClickAdd = true;
            this.Close();
        }

        private void AddPointForm_Load(object sender, EventArgs e)
        {
            this.tbX.Text = m_dbX.ToString();
            this.tbY.Text = m_dbY.ToString();
        }

        private void tbX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
