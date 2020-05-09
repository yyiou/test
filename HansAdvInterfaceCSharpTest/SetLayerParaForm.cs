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
    public partial class SetLayerParaForm : Form
    {
        //*********************全局数据定义****************************
        LAYERPARA m_layerPara = new LAYERPARA();
        int m_nLayerCount;
        int m_nLayerNo;

        public SetLayerParaForm()
        {
            InitializeComponent();
            m_nLayerCount = 10;
        }

        //窗口加载函数
        private void SetLayerParaForm_Load(object sender, EventArgs e)
        {
            numudLayerNo.Maximum = m_nLayerCount - 1;
            numudLayerNo.Minimum = 0;

            m_nLayerNo = 0;
            int nRet = CSharpInterface.HS_GetLayerPara(m_nLayerNo, ref m_layerPara);

            if (nRet != 0)
            {
                MessageBox.Show("读取层参数数据失败！\n返回值：" + nRet.ToString() + "\n错误信息："
                    + CSharpInterface.GetError().ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            SetData(false);
        }

        //保存或显示层参数
        bool SetData(bool bSet)
        {
            try
            {
                if (bSet == true)
                {
                    //保存数据
                    m_layerPara.nCount = Convert.ToInt32(tbCount.Text);
                    m_layerPara.dbCurrent = Convert.ToDouble(tbCurrent.Text);
                    m_layerPara.dbCurrentR = Convert.ToDouble(tbCurrentR.Text);
                    m_layerPara.dbFPKInitRate = Convert.ToDouble(tbFPKInitRate.Text);
                    m_layerPara.dbFPKCurRate = Convert.ToDouble(tbFPKCurRate.Text);
                    m_layerPara.dbFPKLenRate = Convert.ToDouble(tbFPKLenRate.Text);
                    m_layerPara.dbFPKMaxPRate = Convert.ToDouble(tbFPKMaxpRate.Text);
                    m_layerPara.nFpkTime = Convert.ToInt32(tbFPKTime.Text);
                    m_layerPara.nJumpDelay = Convert.ToInt32(tbJumpDelay.Text);
                    m_layerPara.dbJumpV = Convert.ToDouble(tbJumpV.Text);
                    m_layerPara.nLaserOffDelay = Convert.ToInt32(tbLaserOffDelay.Text);
                    m_layerPara.nLaserOnDelay = Convert.ToInt32(tbLaserOnDelay.Text);
                    m_layerPara.nLayerDelay = Convert.ToInt32(tbLayerDelay.Text);
                    m_layerPara.dbMarkV = Convert.ToDouble(tbMarkV.Text);
                    m_layerPara.nMoveLineDelay = Convert.ToInt32(tbMoveLineDelay.Text);
                    m_layerPara.dbPowerR = Convert.ToDouble(tbPowerR.Text);
                    m_layerPara.dbQFre = Convert.ToDouble(tbQFreq.Text);
                    m_layerPara.dbQRls = Convert.ToDouble(tbQRls.Text);
                    m_layerPara.nQuality = Convert.ToInt32(tbQuality.Text);
                    m_layerPara.nRoundDelay = Convert.ToInt32(tbRoundDelay.Text);
                    m_layerPara.dbSimmerCur = Convert.ToDouble(tbSimmerCur.Text);
                    m_layerPara.nWaveForm = Convert.ToInt32(tbWaveForm.Text);
                }
                else
                {
                    //显示数据
                    tbCount.Text = m_layerPara.nCount.ToString();
                    tbCurrent.Text = m_layerPara.dbCurrent.ToString();
                    tbCurrentR.Text = m_layerPara.dbCurrentR.ToString();
                    tbFPKInitRate.Text = m_layerPara.dbFPKInitRate.ToString();
                    tbFPKCurRate.Text = m_layerPara.dbFPKCurRate.ToString();
                    tbFPKLenRate.Text = m_layerPara.dbFPKLenRate.ToString();
                    tbFPKMaxpRate.Text = m_layerPara.dbFPKMaxPRate.ToString();
                    tbFPKTime.Text = m_layerPara.nFpkTime.ToString();
                    tbJumpDelay.Text = m_layerPara.nJumpDelay.ToString();
                    tbJumpV.Text = m_layerPara.dbJumpV.ToString();
                    tbLaserOffDelay.Text = m_layerPara.nLaserOffDelay.ToString();
                    tbLaserOnDelay.Text = m_layerPara.nLaserOnDelay.ToString();
                    tbLayerDelay.Text = m_layerPara.nLayerDelay.ToString();
                    tbMarkV.Text = m_layerPara.dbMarkV.ToString();
                    tbMoveLineDelay.Text = m_layerPara.nMoveLineDelay.ToString();
                    tbPowerR.Text = m_layerPara.dbPowerR.ToString();
                    tbQFreq.Text = m_layerPara.dbQFre.ToString();
                    tbQRls.Text = m_layerPara.dbQRls.ToString();
                    tbQuality.Text = m_layerPara.nQuality.ToString();
                    tbRoundDelay.Text = m_layerPara.nRoundDelay.ToString();
                    tbSimmerCur.Text = m_layerPara.dbSimmerCur.ToString();
                    tbWaveForm.Text = m_layerPara.nWaveForm.ToString();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("输入的数据不合法！\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        //设置层参数
        private void btnSet_Click(object sender, EventArgs e)
        {
            // TODO: Add your control notification handler code here
            if(SetData(true)==false)return;
            int nRet = CSharpInterface.HS_SetLayerPara(m_nLayerNo, ref m_layerPara);
            if (nRet == 0)
            {
                MessageBox.Show("层参数设置成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("层参数设置失败！\n返回值：" + nRet.ToString() + "\n错误信息："
                                           + CSharpInterface.GetError().ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //关闭窗口
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //改变层时，显示相应层的参数
        private void numudLayerNo_ValueChanged(object sender, EventArgs e)
        {
            m_nLayerNo = Convert.ToInt32(numudLayerNo.Value);
            int nRet = CSharpInterface.HS_GetLayerPara(m_nLayerNo, ref m_layerPara);

            if (nRet != 0)
            {
                MessageBox.Show("读取层参数数据失败！\n返回值：" + nRet.ToString() + "\n错误信息："
                    + CSharpInterface.GetError().ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            SetData(false);
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
