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
    public partial class AddBarCodeForm : Form
    {
        public bool ClickAdd = false;
        int m_nBarType = 0;
        bool m_bModify = false;
        bool m_bReverse = false;
        string m_strText = "text";
        int m_nAlign = 0;
        double m_dbAngle = 0.0;
        double m_dbBarRatio = 0.191;
        int m_nLayerNo = 0;
        double m_dbLineDist = 0.1;
        double m_dbPosX = 0.0;
        double m_dbPosY = 0.0;
        double m_dbRevHeight = 0.0;
        double m_dbRevWidth = 0.0;
        double m_dbShrink = 0.0;
        double m_dbHeight = 10;
        string m_strModelName = "";
        public string m_strObjName = "";

        public AddBarCodeForm()
        {
            InitializeComponent();
        }

        private void cmbBarCodeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_nBarType = cmbBarCodeType.SelectedIndex;
        }

        private void cbReverse_CheckedChanged(object sender, EventArgs e)
        {
            tbRevHeight.Enabled = tbRevWidth.Enabled = m_bReverse = cbReverse.Checked;
        }

        private void cbModify_CheckedChanged(object sender, EventArgs e)
        {
            tbTextID.Enabled = m_bModify = cbModify.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                m_strText = tbText.Text;
                m_dbHeight = Convert.ToDouble(tbHeight.Text);
                m_dbPosX = Convert.ToDouble(tbPosX.Text);
                m_dbPosY = Convert.ToDouble(tbPosY.Text);
                m_dbAngle = Convert.ToDouble(tbAngle.Text);
                m_nLayerNo = Convert.ToInt32(tbLayNO.Text);
                m_dbBarRatio = Convert.ToDouble(tbBarRatio.Text);
                m_dbLineDist = Convert.ToDouble(tbLineDist.Text);
                m_dbShrink = Convert.ToDouble(tbShrink.Text);
                m_dbRevWidth = Convert.ToDouble(tbRevWidth.Text);
                m_dbRevHeight = Convert.ToDouble(tbRevHeight.Text);
                m_strModelName = tbTextID.Text;
                m_strObjName = tbObjName.Text;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("输入的数据不合法！\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int nRet = CSharpInterface.HS_AddBarcode(m_strText, m_nBarType, m_dbHeight, m_dbPosX, m_dbPosY, m_dbAngle, m_nAlign, m_nLayerNo,
                            m_dbBarRatio, m_dbLineDist, m_dbShrink, m_bReverse, m_dbRevWidth, m_dbRevHeight, m_bModify, m_strModelName, m_strObjName);
            if (nRet == 0)
            {
                MessageBox.Show("添加条码对象成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClickAdd = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("添加条码对象失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_nAlign = cmbAlign.SelectedIndex;
        }

        private void tbTextID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
