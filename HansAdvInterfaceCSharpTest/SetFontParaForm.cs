using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HansAdvInterfaceCSharpTest
{
    public partial class SetFontParaForm : Form
    {
        //*********************全局数据定义****************************
        FONTPARA m_fontPara = new FONTPARA();
        LOGFONT m_lf=new LOGFONT();

        public int m_nType=0;
        public int m_nFontType=0;
        public byte nCharSet = 0;
        public string m_strFontName="";
        public string m_strShxCN="";
        public string m_strShxEN="";
        public string m_strShxNum="";
        public string m_strFontCHS="";
        public string m_strFontEN="";
        public string m_strFontNUM="";
        public string m_strFontUser="";
        public string m_strHzkType="12*12";
        public string m_strAscType="8*16";

        public SetFontParaForm()
        {
            InitializeComponent();
            UpdateDataView();
        }

        //窗口加载
        private void SetFontParaForm_Load(object sender, EventArgs e)
        {
            int nRet = CSharpInterface.HS_GetFontPara(ref m_fontPara);
            if (nRet != 0)
            {
                MessageBox.Show("读取字体数数据失败！\n返回值：" + nRet.ToString() + "\n错误信息："
                    + CSharpInterface.GetError().ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            m_nType = m_nFontType = m_fontPara.naFontType;
            m_strFontName =new String(m_fontPara.szFontName);
            m_strShxCN = new String(m_fontPara.szShxCN);
            m_strShxEN = new String(m_fontPara.szShxEN);
            m_strShxNum = new String(m_fontPara.szShxNum);

            if (m_nFontType == 0)
            {
                m_lf.lfFaceName = System.Text.Encoding.Default.GetBytes(m_fontPara.szFontName.ToString());
            }
            else if (m_nFontType == 1)
            {
                m_strFontCHS =new String(m_fontPara.szShxCN);
                m_strFontEN = new String(m_fontPara.szShxEN);
                m_strFontNUM = new String(m_fontPara.szShxNum);
            }
            else if (m_nFontType == 2)
            {
                m_strFontUser = new String(m_fontPara.szFontName);
            }
            else if (m_nFontType == 3)
            {
                m_strHzkType = new String(m_fontPara.szShxCN);
                m_strAscType = new String(m_fontPara.szShxEN);
            }

            UpdateData(false);

            //初始化字体信息
            DirectoryInfo dircinfo1 = new DirectoryInfo(CSharpInterface.g_strPathName+"\\PFonts\\");
            foreach (FileInfo fileinfo1 in dircinfo1.GetFiles())
            {
                this.cmbCHS.Items.Add(fileinfo1.Name.Remove(fileinfo1.Name.LastIndexOf(".")));                
            }
            cmbCHS.SelectedText =m_strFontCHS;

            DirectoryInfo dircinfo2 = new DirectoryInfo(CSharpInterface.g_strPathName + "\\EFonts\\");
            foreach (FileInfo fileinfo2 in dircinfo2.GetFiles())
            {
                this.cmbEN.Items.Add(fileinfo2.Name.Remove(fileinfo2.Name.LastIndexOf(".")));
                this.cmbNUM.Items.Add(fileinfo2.Name.Remove(fileinfo2.Name.LastIndexOf(".")));
            }
            cmbEN.SelectedText = m_strFontEN;
            cmbNUM.SelectedText = m_strFontNUM;

            DirectoryInfo dircinfo3 = new DirectoryInfo(CSharpInterface.g_strPathName + "\\Font\\");
            foreach (FileInfo fileinfo3 in dircinfo3.GetFiles())
            {
                this.cmbUser.Items.Add(fileinfo3.Name.Remove(fileinfo3.Name.LastIndexOf(".")));
            }
            cmbUser.SelectedText = m_strFontUser;

            cmbMatrixEnNum.Items.Add("5*7");
            cmbMatrixEnNum.Items.Add("8*16");
            cmbMatrixCHS.Items.Add("12*12");
            cmbMatrixCHS.Items.Add("14*14");
            cmbMatrixCHS.Items.Add("16*16");

            UpdateDataView();
        }

        private void UpdateData(bool typ)
        {
            if (typ == false)//将数据显示到对应的空间
            {
                tbFontType.Text = m_nFontType.ToString();
                tbFontName.Text = m_strFontName;
                tbShxCN.Text = m_strShxCN;
                tbShxEN.Text = m_strShxEN;
                tbShxNum.Text = m_strShxNum;
            }
        }

        //设置
        private void btnSet_Click(object sender, EventArgs e)
        {
            int nRet = CSharpInterface.HS_SetFontPara2(m_nFontType, nCharSet, m_strFontName, m_strShxCN, m_strShxEN, m_strShxNum);
            if (nRet == 0)
            {
                MessageBox.Show("设置字体参数成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("设置字体参数失败！\n" + CSharpInterface.GetError(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //更新窗口的控件的Enable属性
        void UpdateDataView()
        {
            if (m_nType == 0) //TTF
            {
                btnTTF.Enabled = true;
                cmbCHS.Enabled =cmbNUM.Enabled = cmbEN.Enabled = false;
                cmbUser.Enabled = false;
                cmbMatrixCHS.Enabled = cmbMatrixEnNum.Enabled = false;
            }
            else if (m_nType == 1) //SHX
            {
                btnTTF.Enabled = true;
                cmbCHS.Enabled = cmbNUM.Enabled = cmbEN.Enabled = true;
                cmbUser.Enabled = false;
                cmbMatrixCHS.Enabled = cmbMatrixEnNum.Enabled = false;
            }
            else if (m_nType == 2)  //HANS
            {
                btnTTF.Enabled = true;
                cmbCHS.Enabled = cmbNUM.Enabled = cmbEN.Enabled = false;
                cmbUser.Enabled = true;
                cmbMatrixCHS.Enabled = cmbMatrixEnNum.Enabled = false;
            }
            else if (m_nType == 3)  //点阵 DOT
            {
                btnTTF.Enabled = true;
                cmbCHS.Enabled = cmbNUM.Enabled = cmbEN.Enabled = false;
                cmbUser.Enabled = false;
                cmbMatrixCHS.Enabled = cmbMatrixEnNum.Enabled = true;
            }
            else  //TTF
            {
                btnTTF.Enabled = true;
                cmbCHS.Enabled = cmbNUM.Enabled = cmbEN.Enabled = false;
                cmbUser.Enabled = false;
                cmbMatrixCHS.Enabled = cmbMatrixEnNum.Enabled = false;
            }
        }

        //改变字体选择项
        private void rbFont_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFontTTF.Checked)m_nType = 0;
            if (rbFontSHX.Checked) m_nType = 1;
            if (rbFontUser.Checked) m_nType = 2;
            if (rbFontMatrix.Checked) m_nType = 3;
            tbFontType.Text = m_nType.ToString();
            m_nFontType = m_nType;
            UpdateDataView();
        }

        //FFT设置
        private void btnTTF_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            fontDialog1.Font = new Font(CSharpInterface.FromASCIIByteArray(m_lf.lfFaceName), 8);
            if (DialogResult.OK == fontDialog1.ShowDialog())
            {
                m_strFontName = fontDialog1.Font.Name;
                m_lf.lfFaceName=System.Text.Encoding.Default.GetBytes(fontDialog1.Font.Name);
                m_fontPara.nCharSet =fontDialog1.Font.GdiCharSet;
                m_lf.lfCharSet = fontDialog1.Font.GdiCharSet;
            }
            UpdateData(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_strFontCHS=m_strShxCN = cmbCHS.Items[cmbCHS.SelectedIndex].ToString();
            UpdateData(false);
        }

        private void cmbEN_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_strFontEN=m_strShxEN=cmbEN.Items[cmbEN.SelectedIndex].ToString();
            UpdateData(false);
        }

        private void cmbNUM_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_strFontNUM=m_strShxNum=cmbNUM.Items[cmbNUM.SelectedIndex].ToString();
            UpdateData(false);
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_strFontName=m_strFontUser=cmbUser.Items[cmbUser.SelectedIndex].ToString();
            UpdateData(false);
        }

        private void cmbMatrixEnNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_strAscType=m_strShxEN=cmbMatrixEnNum.Items[cmbMatrixEnNum.SelectedIndex].ToString();
            UpdateData(false);
        }

        private void cmbMatrixCHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_strHzkType=m_strShxCN=cmbMatrixCHS.Items[cmbMatrixCHS.SelectedIndex].ToString();
            UpdateData(false);
        }
    }
}
