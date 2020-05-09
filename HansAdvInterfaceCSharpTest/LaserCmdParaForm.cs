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
    public partial class LaserCmdParaForm : Form
    {
        public double m_dbQFrq;
        public double m_dbQRls;
        public bool ClickSetBtn = false;

        public LaserCmdParaForm()
        {
            InitializeComponent();
            m_dbQFrq = 10.0;
            m_dbQRls = 5.0;
        }

        private void LaserCmdParaForm_Load(object sender, EventArgs e)
        {
            this.tbLaserQfre.Text = "10.0";
            this.tbLaserQrls.Text = "5.0";
        }

        public bool SaveDate()
        {
            try
            {
                m_dbQFrq = Convert.ToDouble(this.tbLaserQfre.Text);
                m_dbQRls = Convert.ToDouble(this.tbLaserQrls.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("输入数据有误！请重新输入！\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbLaserQfre.Text = "10.0";
                this.tbLaserQrls.Text = "5.0";
                m_dbQFrq = 10.0;
                m_dbQRls = 5.0;
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
