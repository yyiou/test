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
    public partial class ImportVectorForm : Form
    {
        public bool ClickImport = false;
        string m_strFileName = "";
        double m_dbPosX = 0.0;
        double m_dbPosY = 0.0;
        bool m_bHatch = false;
        int m_nHatchLayer = 0;
        double m_dbHeight = 50;
        double m_dbRotate = 0.0;
        double m_dbWidth = 20;
        public string m_strObjName = "";

        public ImportVectorForm()
        {
            InitializeComponent();
        }

        private void btnGetFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Plt File(*.plt)|*.plt|dxf File(*.dxf)|*.dxf|All Files(*.*)|*.*||";
            openFileDialog1.Title = "Improt vector file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_strFileName = openFileDialog1.FileName;
                tbFillName.Text = m_strFileName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFill_CheckedChanged(object sender, EventArgs e)
        {
            m_bHatch = cbFill.Checked;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                m_dbPosX = Convert.ToDouble(tbPosX.Text);
                m_dbPosY = Convert.ToDouble(tbPosY.Text);
                m_dbWidth = Convert.ToDouble(tbWidth.Text);
                m_dbHeight = Convert.ToDouble(tbHeight.Text);
                m_dbRotate = Convert.ToDouble(tbRotate.Text);
                m_nHatchLayer = Convert.ToInt32(tbHatchLayer.Text);
                m_strObjName = tbObjName.Text;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("输入的数据不合法！\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int nRet = CSharpInterface.HS_ImportVectorFile(m_strFileName, m_dbPosX, m_dbPosY, m_dbWidth, m_dbHeight,
                                m_dbRotate, m_bHatch, m_nHatchLayer, m_strObjName);
            if (nRet == 0)
            {
                MessageBox.Show("ImportVectorFile success!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClickImport = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("导入失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
