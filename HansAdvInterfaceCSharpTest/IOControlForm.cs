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
    public partial class IOControlForm : Form
    {
        public bool ClickOkBtn = false;
        public bool m_bTouchReport;
        int m_dwInPort;
        int m_dwOutPort;

        public IOControlForm()
        {
            InitializeComponent();
            m_bTouchReport =false;
            m_dwInPort = 0;
            m_dwOutPort = 0;
        }

        private void IOControlForm_Load(object sender, EventArgs e)
        {

        }

        //关闭
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //确定
        private void btnSet_Click(object sender, EventArgs e)
        {
            ClickOkBtn = true;
            this.Close();
        }

        //输入口读入
        private void btnReadInPort_Click(object sender, EventArgs e)
        {
            int nRet = CSharpInterface.HS_ReadPort(ref m_dwInPort);
            if (0 == nRet)
            {
                tbNote.Text= "Read input port successfully!";
                this.tbInPort.Text = m_dwInPort.ToString();
            }
            else
            {
                tbNote.Text = "Read input port failed!";
                MessageBox.Show("操作失败！\n返回值：" + nRet.ToString() + "\n错误信息："
                                           + CSharpInterface.GetError().ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWriteOutPort_Click(object sender, EventArgs e)
        {
            try
            {
                m_dwOutPort = Convert.ToInt32(this.tbOutPort.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("请输入一个正整数输入！\n" + ex.Message, "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                m_dwOutPort = 0;
                this.tbOutPort.Text = "0";
                return;
            }
            if(m_dwOutPort<0)
            {
                MessageBox.Show("请输入一个正整数输入！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                m_dwOutPort = 0;
                this.tbOutPort.Text = "0";
                return;
            }

            int nRet = CSharpInterface.HS_WritePort(m_dwOutPort, 0xFFFF);
            if (0 == nRet)
            {
                tbNote.Text = "Write output port successfully!";
            }
            else
            {
                tbNote.Text = "Write output port failed!";
                MessageBox.Show("操作失败！\n返回值：" + nRet.ToString() + "\n错误信息："
                                           + CSharpInterface.GetError().ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQueryTouch_Click(object sender, EventArgs e)
        {
            int nTouchFlag = 0;
            int nRet = CSharpInterface.HS_IsTouch(ref nTouchFlag);
            if (nRet!=0)
            {
                tbNote.Text = "脚踏查询失败！";
                MessageBox.Show("操作失败！\n返回值：" + nRet.ToString() + "\n错误信息："
                                           + CSharpInterface.GetError().ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (nTouchFlag != 0)
                {
                    tbNote.Text = "Touch trigger!";
                }
                else
                {
                    tbNote.Text = "Touch is not triggered!";
                }
            }
        }

        private void cbTouchRePort_CheckedChanged(object sender, EventArgs e)
        {
            this.m_bTouchReport=this.cbTouchRePort.Checked;
        }
    }
}
