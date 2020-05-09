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
    public partial class MotorSetForm : Form
    {
        double m_dbMoveValue;
        int m_nModel;
        int m_nType;
        bool m_bSoft0;
        int m_nAxisNo;

        public MotorSetForm()
        {
            InitializeComponent();
            m_dbMoveValue = 0.0;
            m_nModel = 0;
            m_nType = 0;
            m_bSoft0 =false;
        }

        private void MotorSetForm_Load(object sender, EventArgs e)
        {
            this.cbxAxiNo.SelectedIndex = 0;
            m_nAxisNo = 0;
            UpdateData(false);
        }

        private bool UpdateData(bool typ)
        {
            if (typ == false)//将数据显示到对应的控件
            {
                this.tbValue.Text = m_dbMoveValue.ToString();
                this.cbSoftO.Checked = m_bSoft0;
                if (m_nModel == 0)
                {
                    this.rdbModel.Checked = true;
                }
                else if (m_nModel == 1)
                {
                    this.rdb2.Checked = true;
                }
                else if (m_nModel == 2)
                {
                    this.rdb3.Checked = true;
                }
                else
                {
                    this.rdbModel.Checked = true;
                }

                if(m_nType == 0)
                {
                    rdbType.Checked = true;
                }
                else
                {
                    this.rdb5.Checked = true;
                }
            }
            else//将控件上的数据存储到对应的变量
            {
                try
                {
                    m_dbMoveValue=Convert.ToDouble(this.tbValue.Text);
                    m_bSoft0=this.cbSoftO.Checked;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("输入数据有误！请重新输入！\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                	return false;
                }
                if (this.rdbModel.Checked == true)
                {
                    m_nModel =0;
                }
                else if (this.rdb2.Checked == true)
                {
                    m_nModel = 1;
                }
                else if (this.rdb3.Checked == true)
                {
                    m_nModel = 2;
                }
                else
                {
                    m_nModel = 0;
                }

                if (rdbType.Checked == true)
                {
                    m_nType = 0;
                }
                else
                {
                    m_nType = 1;
                }
            }
            return true;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if(UpdateData(true)==false)return;
            this.tbNote.Text = "";

            //MessageBox.Show(m_nAxisNo.ToString() + "," + m_dbMoveValue.ToString() + "," + m_nModel.ToString() + "," + m_nType.ToString());
            int nRet = CSharpInterface.HS_MoveMotorV(m_nAxisNo, m_dbMoveValue, m_nModel, m_nType);
            if (0 == nRet)
            {
                this.tbNote.Text="Move motor successfully!";
            }
            else
            {
                MessageBox.Show("操作失败！\n返回值：" + nRet.ToString() + "\n错误信息："
                                           + CSharpInterface.GetError().ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxAxiNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_nAxisNo = this.cbxAxiNo.SelectedIndex;
        }

        private void btnSetSoftO_Click(object sender, EventArgs e)
        {
            if (UpdateData(true) == false) return;
            this.tbNote.Text = "";
            int nRet = CSharpInterface.HS_SetAsSoftHome(m_nAxisNo);
            if (0 == nRet)
            {
                this.tbNote.Text= "Soft origin setting successfully!";
            }
            else
            {
                MessageBox.Show("操作失败！\n返回值：" + nRet.ToString() + "\n错误信息："
                                           + CSharpInterface.GetError().ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (UpdateData(true) == false) return;
            this.tbNote.Text = "";
            int nRet = CSharpInterface.HS_HomeMoveV(m_nAxisNo, m_bSoft0);
            if (0 == nRet)
            {
                this.tbNote.Text = "Move motor successfully!";
            }
            else
            {
                MessageBox.Show("操作失败！\n返回值：" + nRet.ToString() + "\n错误信息："
                                           + CSharpInterface.GetError().ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbModel_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
