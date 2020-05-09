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
    public partial class SetHatchParaForm : Form
    {
        int m_nFillNo;                 //填充序号
        bool m_bEquaDist;               //是否等间距充
        bool m_bKeepAngle;              //填充线随轮廓旋转
        double m_dbSpace;                 //填充间距
        bool m_bEnable;                 //填充使能
        bool m_bLoop;                   //缩扩使能
        double m_dbAngle;                 //填充角度
        double m_dbBeamComp;              //光栅大小
        double m_dbLineReduce;            //线缩进量
        int m_nLoopNum;                //缩扩圈数
        double m_dbStartOffset;           //起始偏移
        double m_dbEndOffset;             //末尾偏移
        double m_dbMinJump;               //最小跳转间距
        bool m_bRemoveOrg;              //缩扩时删除原始轮廓
        double m_dbLoopDist;              //缩扩间距
        bool m_bRemoveFill;
        int m_nFillNum;
        double m_dbAddDis;
        double m_dbAddAngle;
        bool m_bFillFirst;

        int m_nFillStyle;
        int m_nPrevFillNo;	     //填充线类型

        HATCHPARA m_hatchPara = new HATCHPARA();
        BaseHatch m_fillData1;
        BaseHatch m_fillData2;

        public SetHatchParaForm()
        {
            InitializeComponent();
            m_nFillNo = 0;
            m_bEquaDist = false;
            m_bKeepAngle = false;
            m_dbSpace = 0.01;
            m_bEnable = false;
            m_bLoop = false;
            m_dbAngle = 0.0;
            m_dbBeamComp = 0.0;
            m_dbLineReduce = 0.0;
            m_nLoopNum = 1;
            m_dbStartOffset = 0.0;
            m_dbEndOffset = 0.0;
            m_dbMinJump = 0.0;
            m_bRemoveOrg = false;
            m_dbLoopDist = 0.01;
            m_bRemoveFill = false;

            m_bFillFirst = true;
            m_nFillNum = 1;
            m_dbAddDis = 0;
            m_dbAddAngle = 0;
        }

        private void SetHatchParaForm_Load(object sender, EventArgs e)
        {
            int nRet = CSharpInterface.HS_GetHatchPara(ref m_hatchPara);
            if (nRet != 0)
            {
                MessageBox.Show("读取填充参数失败！\n返回值：" + nRet.ToString() + "\n错误信息："
                                           + CSharpInterface.GetError().ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();//关闭此窗口
            }

            m_bFillFirst = m_hatchPara.bFillFirst;
            m_fillData1 = m_hatchPara.newFileData1;
            m_fillData2 = m_hatchPara.newFileData2;

            SetFillData(0, false);
            m_nPrevFillNo = m_nFillNo = 0;
            UpdateDataView();
            UpdateData(false);
        }

        private bool UpdateData(bool typ)
        {
            try
            {
                if (typ == false)//将数据显示到对应的控件
                {
                    this.cbEqualDist.Checked = m_bEquaDist;
                    this.cbKeepAngel.Checked = m_bKeepAngle;
                    this.tbSpace.Text = m_dbSpace.ToString();
                    this.cbEnable.Checked = m_bEnable;
                    this.cbLoop.Checked = m_bLoop;
                    this.tbAngle.Text = m_dbAngle.ToString();
                    this.tbBeamcomp.Text = m_dbBeamComp.ToString();
                    this.tbLineRedu.Text = m_dbLineReduce.ToString();
                    this.tbLoopNum.Text = m_nLoopNum.ToString();
                    this.tbStartOffSet.Text = m_dbStartOffset.ToString();
                    this.tbEndOffSet.Text = m_dbEndOffset.ToString();
                    this.tbMinJump.Text = m_dbMinJump.ToString();
                    this.cbReMoveOrg.Checked = m_bRemoveOrg;
                    this.tbLoopDist.Text = m_dbLoopDist.ToString();
                    this.cbReMoveFill.Checked = m_bRemoveFill;
                    this.cbFillFirst.Checked = m_bFillFirst;
                    this.tbNum.Text = m_nFillNum.ToString();
                    this.tbAddDis.Text = m_dbAddDis.ToString();
                    this.tbAddAngle.Text = m_dbAddAngle.ToString();
                    this.tbFillType.Text = m_nFillStyle.ToString();

                }
                else  //将控件上的数据存储到对应的变量
                {
                    m_bEquaDist = this.cbEqualDist.Checked;
                    m_bKeepAngle = this.cbKeepAngel.Checked;
                    m_dbSpace = Convert.ToDouble(this.tbSpace.Text);
                    m_bEnable = this.cbEnable.Checked;
                    m_bLoop = this.cbLoop.Checked;
                    m_dbAngle = Convert.ToDouble(this.tbAngle.Text);
                    m_dbBeamComp = Convert.ToDouble(this.tbBeamcomp.Text);
                    m_dbLineReduce = Convert.ToDouble(this.tbLineRedu.Text);
                    m_nLoopNum = Convert.ToInt32(this.tbLoopNum.Text);
                    m_dbStartOffset = Convert.ToDouble(this.tbStartOffSet.Text);
                    m_dbEndOffset = Convert.ToDouble(this.tbEndOffSet.Text);
                    m_dbMinJump = Convert.ToDouble(this.tbMinJump.Text);
                    m_bRemoveOrg = this.cbReMoveOrg.Checked;
                    m_dbLoopDist = Convert.ToDouble(this.tbLoopDist.Text);
                    m_bRemoveFill = this.cbReMoveFill.Checked;
                    m_bFillFirst = this.cbFillFirst.Checked;
                    m_nFillNum = Convert.ToInt32(this.tbNum.Text);
                    m_dbAddDis = Convert.ToDouble(this.tbAddDis.Text);
                    m_dbAddAngle = Convert.ToDouble(this.tbAddAngle.Text);
                    m_nFillStyle = Convert.ToInt32(this.tbFillType.Text);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("输入的数据不合法！\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;

        }

        public void UpdateDataView()
        {
            this.tbLoopNum.Enabled = m_bLoop && m_bEnable;
            this.tbLoopDist.Enabled = m_bLoop && m_bEnable;
            this.cbReMoveOrg.Enabled = m_bLoop && m_bEnable;
            this.cbReMoveFill.Enabled = m_bLoop && m_bEnable;

            this.cbEqualDist.Enabled = m_bEnable;
            this.tbSpace.Enabled = m_bEnable;
            this.tbAngle.Enabled = m_bEnable;
            this.tbMinJump.Enabled = m_bEnable && (m_nFillStyle == 1 || m_nFillStyle == 3);
            this.tbStartOffSet.Enabled = m_bEnable;
            this.tbEndOffSet.Enabled = m_bEnable;
            this.tbLineRedu.Enabled = m_bEnable;
            this.tbBeamcomp.Enabled = m_bEnable;
            this.cbLoop.Enabled = m_bEnable;
            this.btnSType.Enabled = m_bEnable;

            this.cbKeepAngel.Enabled = m_bEnable;
            this.tbNum.Enabled = m_bEnable;
            this.tbAddDis.Enabled = m_bEnable;
            this.tbAddAngle.Enabled = m_bEnable;

            switch (m_nFillStyle)
            {
                case 1:
                    this.btnSType.BackgroundImage = global::HansAdvInterfaceCSharpTest.Properties.Resources.icon24;
                    break;

                case 2:
                    this.btnSType.BackgroundImage = global::HansAdvInterfaceCSharpTest.Properties.Resources.ico00002;
                    break;

                case 3:
                    this.btnSType.BackgroundImage = global::HansAdvInterfaceCSharpTest.Properties.Resources.icon25;
                    break;

                case 4:
                    this.btnSType.BackgroundImage = global::HansAdvInterfaceCSharpTest.Properties.Resources.icon26;
                    break;
                default:
                    this.btnSType.BackgroundImage = global::HansAdvInterfaceCSharpTest.Properties.Resources.icon_fil;
                    break;
            }
        }

        void SetFillData(int nNo, bool bSave)
        {
            BaseHatch data = new BaseHatch();
            //
            if (bSave)
            {
                data.bEnable = m_bEnable;
                data.nFillStyle = m_nFillStyle;
                data.bEquaDist = m_bEquaDist;
                data.bKeepAngle = m_bKeepAngle;
                data.dbSpace = m_dbSpace;
                data.dbAngle = m_dbAngle;
                data.dbBeamComp = m_dbBeamComp;
                data.dbLineReduce = m_dbLineReduce;
                data.dbStartOffset = m_dbStartOffset;
                data.dbEndOffset = m_dbEndOffset;
                data.dbMinJump = m_dbMinJump;

                data.bLoop = m_bLoop;
                data.nLoopNum = m_nLoopNum;
                data.dbLoopDist = m_dbLoopDist;
                data.bRemoveOrg = m_bRemoveOrg;
                data.bRemoveLine = m_bRemoveFill;

                data.nFillNum = m_nFillNum;
                data.AddDis = m_dbAddDis;
                data.ProAngle = m_dbAddAngle;

                if (nNo == 0)
                    m_fillData1 = data;
                else
                    m_fillData2 = data;
            }
            else
            {
                if (nNo == 0)
                    data = m_fillData1;
                else
                    data = m_fillData2;

                m_bEnable = data.bEnable;
                m_nFillStyle = data.nFillStyle;
                m_bEquaDist = data.bEquaDist;
                m_bKeepAngle = data.bKeepAngle;
                m_dbSpace = data.dbSpace;
                m_dbAngle = data.dbAngle;
                m_dbBeamComp = data.dbBeamComp;
                m_dbLineReduce = data.dbLineReduce;
                m_dbStartOffset = data.dbStartOffset;
                m_dbEndOffset = data.dbEndOffset;
                m_dbMinJump = data.dbMinJump;

                m_bLoop = data.bLoop;
                m_nLoopNum = data.nLoopNum;
                m_dbLoopDist = data.dbLoopDist;
                m_bRemoveOrg = data.bRemoveOrg;
                m_bRemoveFill = data.bRemoveLine;

                m_nFillNum = data.nFillNum;
                m_dbAddDis = data.AddDis;
                m_dbAddAngle = data.ProAngle;
                UpdateData(false);
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (UpdateData(true) == false) return;
            SetFillData(m_nFillNo, true);
            m_hatchPara.bFillFirst = m_bFillFirst;
            m_hatchPara.newFileData1 = m_fillData1;
            m_hatchPara.newFileData2 = m_fillData2;

            int nRet = CSharpInterface.HS_SetHatchPara(ref m_hatchPara);
            if (nRet == 0)
            {
                MessageBox.Show("设置成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("设置失败！\n返回值：" + nRet.ToString() + "\n错误信息："
                                           + CSharpInterface.GetError().ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //关闭窗口
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSType_Click(object sender, EventArgs e)
        {
            if (UpdateData(true) == false) return;

            m_nFillStyle++;

            if (m_nFillStyle >= 4)
                m_nFillStyle = 0;

            UpdateData(false);
            UpdateDataView();
        }

        private void rbtnFill1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFill1.Checked) m_nFillNo = 0;
            else m_nFillNo = 1;

            if (UpdateData(true) == false) return;

            if (m_nPrevFillNo == m_nFillNo)
            {
                SetFillData(m_nFillNo, true);
                return;
            }

            SetFillData(m_nPrevFillNo, true);
            SetFillData(m_nFillNo, false);
            m_nPrevFillNo = m_nFillNo;

            UpdateDataView();
        }

        private void rbtnFill2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFill1.Checked) m_nFillNo = 0;
            else m_nFillNo = 1;

            if (UpdateData(true) == false) return;

            if (m_nPrevFillNo == m_nFillNo)
            {
                SetFillData(m_nFillNo, true);
                return;
            }

            SetFillData(m_nPrevFillNo, true);
            SetFillData(m_nFillNo, false);
            m_nPrevFillNo = m_nFillNo;

            UpdateDataView();
        }

        private void cbEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdateData(true) == false) return;
            ////////
            UpdateDataView();
        }

        private void cbLoop_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdateData(true) == false) return;
            ////////
            UpdateDataView();
        }

        private void tbEndOffSet_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbAddAngle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
