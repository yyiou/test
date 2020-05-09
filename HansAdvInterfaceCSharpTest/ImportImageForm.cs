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
    public partial class ImportImageForm : Form
    {
        public bool ClickImport = false;
        string m_strFileName = "";
        bool m_bReciprocate = false;
        int m_nAccDot = 0;
        double m_dbDotDisX = 0.05;
        double m_dbDotDisY = 0.05;
        double m_dbHeight = 80;
        int m_nMarkType = 0;
        double m_dbPosX = 0.0;
        double m_dbPosY = 0.0;
        int m_nRePairDot = 0;
        double m_dbRotate = 0.0;
        double m_dbWidth = 80;
        public string m_strObjName = "";

        public ImportImageForm()
        {
            InitializeComponent();
        }

        private void btnGetFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "jpg File(*.jpg/*.jpeg)|*.jpg;*.jpeg|bmp File(*.bmp)|*.bmp|gif File(*.gif)|*.gif|png File(*.png)|*.png|ico File(*.ico)|*.ico|tif File(*.tif)|*.tif|tga File(*.tga)|*.tga|pcx File(*.pcx)|*.pcx|All Files(*.*)|*.*||";
            openFileDialog1.Title = "Improt image file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_strFileName = openFileDialog1.FileName;
                tbFillName.Text = m_strFileName;
            }
        }

        private void rdbType1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbType1.Checked == true)
            {
                m_nMarkType = 0;
                tbDotDistX.Enabled = tbDotDistY.Enabled = tbAccDot.Enabled = cbReciProcate.Enabled = tbRePairDot.Enabled = true;
            }
            else
            {
                m_nMarkType = 1;
                tbDotDistX.Enabled = tbDotDistY.Enabled = tbAccDot.Enabled = cbReciProcate.Enabled = tbRePairDot.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbReciProcate_CheckedChanged(object sender, EventArgs e)
        {
            m_bReciprocate = cbReciProcate.Checked;
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
                m_strObjName = tbObjName.Text;
                m_dbDotDisX = Convert.ToDouble(tbDotDistX.Text);
                m_dbDotDisY = Convert.ToDouble(tbDotDistY.Text);
                m_nAccDot = Convert.ToInt32(tbAccDot.Text);
                m_nRePairDot = Convert.ToInt32(tbRePairDot.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("输入的数据不合法！\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int nRet = CSharpInterface.HS_ImportImageFile(m_strFileName, m_dbPosX, m_dbPosY, m_dbWidth, m_dbHeight,
                                            m_dbRotate, m_nMarkType, m_dbDotDisX, m_dbDotDisY, m_nAccDot, m_bReciprocate, m_nRePairDot,
                                            m_strObjName);
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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
