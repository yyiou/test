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
    public partial class AddTextForm : Form
    {
        public bool ClickAdd = false;
        bool m_bHatch = false;
        bool m_bModel = false;
        int m_nAlign = 0;
        int m_nHatchLayer = 0;
        double m_dbHeight = 5.0;
        int m_nLayer = 0;
        double m_dbPosX = 0.0;
        double m_dbPosY = 0.0;
        double m_dbRotate = 0.0;
        string m_strText = "text";
        double m_dbWidthRatio = 100;
        string m_strModelName = "";
        public string m_strObjName = "";
        double m_dbCharSpace = 0.8;
        double m_dbLIneSpace = 0.5;

        public AddTextForm()
        {
            InitializeComponent();
        }

        private void cbModel_CheckedChanged(object sender, EventArgs e)
        {

            this.tbModelID.Enabled = m_bModel = cbModel.Checked;
        }

        private void cbHatch_CheckedChanged(object sender, EventArgs e)
        {
            this.tbHatchLayer.Enabled = m_bHatch = cbHatch.Checked;
        }

        private void cmbAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_nAlign = cmbAlign.SelectedIndex;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                m_strText = tbText.Text;
                m_dbHeight = Convert.ToDouble(tbHeight.Text);
                m_dbWidthRatio = Convert.ToDouble(tbWidthRatio.Text);
                m_strModelName = tbModelID.Text;
                m_dbPosX = Convert.ToDouble(tbPosX.Text);
                m_dbPosY = Convert.ToDouble(tbPosY.Text);
                m_dbRotate = Convert.ToDouble(tbRoTate.Text);
                m_nLayer = Convert.ToInt32(tbLayer.Text);
                m_nHatchLayer = Convert.ToInt32(tbHatchLayer.Text);
                m_dbCharSpace = Convert.ToDouble(tbCharSpace.Text);
                m_dbLIneSpace = Convert.ToDouble(tbLineSpace.Text);
                m_strObjName = tbObjName.Text;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("输入的数据不合法！\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int nRet = CSharpInterface.HS_AddText2(m_strText, m_dbHeight, m_dbWidthRatio, m_bModel, m_strModelName, m_dbPosX,
                        m_dbPosY, m_nAlign, m_dbRotate, m_nLayer, m_bHatch, m_nHatchLayer,
                        m_dbCharSpace, m_dbLIneSpace, m_strObjName);

            if (nRet == 0)
            {
                MessageBox.Show("添加文本对象成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClickAdd = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("添加文本对象失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void AddTextForm_Load(object sender, EventArgs e)
        {

        }
    }
}
