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
    public partial class XYZPositionForm : Form
    {

        public int m_iXYZType;
        public double m_dbXPos;
        public double m_dbYPos;
        public double m_dbZPos;
        public bool ClickSetBtn;

        public XYZPositionForm()
        {
            InitializeComponent();
            m_iXYZType = 0;
            m_dbXPos = 0.0;
            m_dbYPos = 0.0;
            m_dbZPos = 0.0;
            ClickSetBtn = false;
        }

        private void XYZPositionForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (SaveDate())
            {
                ClickSetBtn = true;
                this.Close();
            }
            else
            {
                ClickSetBtn = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool SaveDate()
        {
            try
            {
                if (rdbXYType.Checked)
                    this.m_iXYZType = 0;
                else if (rdbZType.Checked)
                    this.m_iXYZType = 1;
                else if (rdbXYZType.Checked)
                    this.m_iXYZType = 2;
                else this.m_iXYZType = 0;

                m_dbXPos = Convert.ToDouble(this.tbXPos.Text);
                m_dbYPos = Convert.ToDouble(this.tbYPos.Text);
                m_dbZPos = Convert.ToDouble(this.tbZPos.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("输入数据有误！请重新输入！\n"+ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbXPos.Text = this.tbYPos.Text = this.tbZPos.Text = "0.0";
                m_dbXPos = m_dbYPos = m_dbZPos = 0.0;
                this.m_iXYZType = 0;
                return false;
            }
            return true;
        }
    }
}
