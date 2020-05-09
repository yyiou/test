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
    public partial class MainForm : Form
    {
        //*********************全局数据定义****************************
        bool m_bInitOk = false;              //标记是否初始化成功
        bool m_bLaserOnOff = false;       //标记激光是否打开
        bool m_bWaitTouch = false;
        bool m_bWaitEnd = false;
        int m_nWaitTimeForTouch = 0;
        double m_dbViewRate = 1.0;
        double m_dbViewX = 0;
        double m_dbViewY = 0;
        bool bDrawing = false;
        double m_dbBaseX = 0;
        double m_dbBaseY = 0;
        double m_dbParaX = 0;
        double m_dbParaY = 0;
        string m_strTextTxt = "";
        string m_strModelName = "";
        CInterStroke[] m_listCustom = new CInterStroke[100];
        string m_strHansFileName = "default.hs";//当前模板名字

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetDllVersion();
            UpdateView();
            for (int i = 0; i < 100; i++) m_listCustom[i] = new CInterStroke();
        }

        //调用HS_GetDllVersion获取程序的主版本号和DLL版本号，并显示到状态栏
        private void GetDllVersion()
        {
            ushort nMainVer = 0, nDllVer = 0;
            if (CSharpInterface.HS_GetDllVersion(ref nMainVer, ref nDllVer) == 0)
            {
                //将二进制数值解析成主版本号
                string sMainVer = (((((1 << 4) - 1) << 12) & nMainVer) >> 12).ToString() +
                    "." + (((((1 << 5) - 1) << 7) & nMainVer) >> 7).ToString()
                    + "." + (((1 << 7) - 1) & nMainVer).ToString();
                //将二进制数值解析成子版本号
                string sDllVer = (((((1 << 4) - 1) << 12) & nDllVer) >> 12).ToString() +
                    "." + (((((1 << 5) - 1) << 7) & nDllVer) >> 7).ToString()
                    + "." + (((1 << 7) - 1) & nDllVer).ToString();
                this.tsslabVersion.Text = "版本号:" + sMainVer + " - " + sDllVer;
            }
            else
            {
                MessageBox.Show("获取版本号失败！");
                ShowLastError();
            }
        }

        protected override void DefWndProc(ref System.Windows.Forms.Message m)
        {
            switch (m.Msg)
            {
                case 2119:
                    // 脚踏信号有效消息处理
                    LaserMark(); // 调用打标流程
                    break;
                default:
                    base.DefWndProc(ref m);//一定要调用基类函数，以便系统处理其它消息。
                    break;
            }
        }

        //初始化打标系统
        private void btnInitSystem_Click(object sender, EventArgs e)
        {
            string strCurPath = System.Environment.CurrentDirectory;     //获取当前路径
            int nRet = CSharpInterface.HS_InitialMachine(strCurPath);
            if (nRet == 0)
            {
                tbNote.Text = "打标系统初始化成功！";
                tsslabCardStatus.Text = "状态：初始化成功！";

                CSharpInterface.g_strPathName = strCurPath;
                m_bInitOk = true;

                double px = 0, py = 0;
                CSharpInterface.HS_GetMarkRange(ref px, ref py);
                tsslabMarkRange.Text = "打标范围:" + px.ToString() + "*" + py.ToString() + "mm";
                //设置预览滑标
                tbrX.SetRange(-(int)(px / 2), (int)(px / 2));
                tbrY.SetRange(-(int)(py / 2), (int)(py / 2));
                tbrS.SetRange(0, 100);
                ResetPreview();//设置滑标位置
            }
            else
            {
                ShowLastError();
                tsslabCardStatus.Text = "状态：初始化失败！";
            }
            UpdateView();
        }

        //显示错误信息
        string ShowLastError()
        {
            int nErr = 0;
            StringBuilder szBuff = new StringBuilder(200);
            CSharpInterface.HS_GetLastError(ref nErr, szBuff, 200);
            tbNote.Text = szBuff.ToString();
            return szBuff.ToString();
        }

        //释放打标系统
        private void btnRelease_Click(object sender, EventArgs e)
        {
            CSharpInterface.HS_FreeStrokeList(m_listCustom);
            int nRet = CSharpInterface.HS_CloseMachine();
            if (0 == nRet)
            {
                tbNote.Text = "Release ok!";
                tsslabCardStatus.Text = "Card Status: Not Init!!!";

                m_bInitOk = false;

                tsslabMarkRange.Text = "打标范围:";
                Refresh();
            }
            else
            {
                ShowLastError();
                tsslabCardStatus.Text = "Card Status: Init OK!!!";
            }
            UpdateView();
        }

        //如果初始化未完成，则将其他按钮设置为不可用，反之则设置为可用
        private void UpdateView()
        {
            btnRelease.Enabled = btnSetHardWare.Enabled = btnModule.Enabled = m_bInitOk;
            btnSaveMarkFile.Enabled = btnModulesClose.Enabled = m_bInitOk;

            groupBox2.Enabled = groupBox3.Enabled = groupBox4.Enabled = groupBox5.Enabled = m_bInitOk;
            groupBox6.Enabled = groupBox7.Enabled = groupBox8.Enabled = groupBox9.Enabled = m_bInitOk;

            if (myImageTab1 != null)
                myImageTab1.Enabled = m_bInitOk;
        }

        //硬件设置
        private void btnSetHardWare_Click(object sender, EventArgs e)
        {
            int nRet = CSharpInterface.HS_SetDevCfg();
            if (0 == nRet)
            {
                tbNote.Text = "Set hardware finished!";
            }
            else
            {
                ShowLastError();
            }
        }

        //关闭窗体时，关闭机器
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CSharpInterface.HS_CloseMachine();
            CSharpInterface.HS_FreeStrokeList(m_listCustom);
        }

        //设置填充参数
        private void btnSetHatchPara_Click(object sender, EventArgs e)
        {
            SetHatchParaForm sethatchparaform = new SetHatchParaForm();
            sethatchparaform.ShowDialog();
        }

        //设置字体参数
        private void btnSetFontPara_Click(object sender, EventArgs e)
        {
            SetFontParaForm setfontparaform = new SetFontParaForm();
            setfontparaform.ShowDialog();
        }

        //设置层参数
        private void btnSetLayerPara_Click(object sender, EventArgs e)
        {
            SetLayerParaForm setlayerparaform = new SetLayerParaForm();
            setlayerparaform.ShowDialog();
        }

        //电机单轴运动
        private void btnMotorMove_Click(object sender, EventArgs e)
        {
            MotorSetForm motorsetform = new MotorSetForm();
            motorsetform.ShowDialog();
        }

        //XYZ轴位置跳转
        private void btnJumpPosition_Click(object sender, EventArgs e)
        {
            XYZPositionForm xyzpositionform = new XYZPositionForm();
            xyzpositionform.ShowDialog();
            if (xyzpositionform.ClickSetBtn)
            {
                int nRet = CSharpInterface.HS_IGotoXYZ(xyzpositionform.m_iXYZType, xyzpositionform.m_dbXPos, xyzpositionform.m_dbYPos, xyzpositionform.m_dbZPos);
                if (nRet != 0)
                {
                    ShowLastError();
                }
                else
                {
                    this.tbNote.Text = "Goto XYZ successful!";
                }
            }
        }

        //IO控制
        private void btnIOControl_Click(object sender, EventArgs e)
        {
            IOControlForm iocontrolform = new IOControlForm();
            iocontrolform.ShowDialog();
            if (iocontrolform.ClickOkBtn == false)
            {
                return;
            }

            int nRet = CSharpInterface.HS_CheckTouch(this.Handle, iocontrolform.m_bTouchReport);
            if (nRet!=0)
            {
                ShowLastError();
            }
            else
            {
                this.tbNote.Text= "Check touch succeed!";
            }
        }

        //打开或关闭激光
        private void btnLaserOnOff_Click(object sender, EventArgs e)
        {
            if (this.btnLaserOnOff.Text == "开激光")
            {
                LaserCmdParaForm lasercmdparaform = new LaserCmdParaForm();
                lasercmdparaform.ShowDialog();
                if (lasercmdparaform.ClickSetBtn == false)
                {
                    this.btnLaserOnOff.Text = m_bLaserOnOff ? "关激光" : "开激光";
                    return;
                }
                int nRet = CSharpInterface.HS_ILaserOn(lasercmdparaform.m_dbQFrq, lasercmdparaform.m_dbQRls, 20, 0);
                if (nRet == 0)
                {
                    this.tbNote.Text = "激光打开成功！";
                    this.btnLaserOnOff.Text = "关激光";
                    m_bLaserOnOff = true;
                }
                else
                {
                    ShowLastError();
                    this.btnLaserOnOff.Text = m_bLaserOnOff ? "关激光" : "开激光";
                    m_bLaserOnOff = false;
                }
            }
            else if (this.btnLaserOnOff.Text == "关激光")
            {
                int nRet = CSharpInterface.HS_ILaserOff();
                if (nRet == 0)
                {
                    this.tbNote.Text = "激光关闭成功！";
                    this.btnLaserOnOff.Text = "开激光";
                    m_bLaserOnOff = false;
                }
                else
                {
                    ShowLastError();
                    this.btnLaserOnOff.Text = "开激光";
                    m_bLaserOnOff = true;
                }
            }
        }

        //获取自定义数据
        private void btnGetCustomData_Click(object sender, EventArgs e)
        {
            int selindex = this.cmbObjList.SelectedIndex;
            if (selindex == -1)
            {
                return;
            }
            else if (selindex == 0)
            {
                CSharpInterface.HS_FreeStrokeList(m_listCustom);
            }
            else if (selindex == 1)
            {
                CSharpInterface.HS_FreeStrokeList(m_listCustom);
                int nRet = CSharpInterface.HS_GetStrokeList(null,m_listCustom);
                if (nRet == 0)
                {
                    tbNote.Text = "Get cutstom data success!";
                    Preview();
                }
                else
                {
                    ShowLastError();
                }
                return;
            }
            else
            {
                CSharpInterface.HS_FreeStrokeList(m_listCustom);
                string strObj;
                strObj = cmbObjList.Items[selindex].ToString();
                int nRet = CSharpInterface.HS_GetStrokeList(strObj,m_listCustom);
                if (nRet == 0)
                {
                    tbNote.Text = "获取自定义数据成功!";
                    Preview();
                }
                else
                {
                    ShowLastError();
                }
            }
        }

        //自定义打标
        private void btnMarkCustomData_Click(object sender, EventArgs e)
        {
            int nRet = CSharpInterface.HS_MarkStorkeList(0, m_listCustom);
            if (nRet != 0)
            {
                ShowLastError();
            }
        }

        private void LaserMark()
        {
            try
            {
                this.m_nWaitTimeForTouch = Convert.ToInt32(this.tbWaitTouchTime.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("信号等待最大时长 必须为正整数！\n" + ex.Message, "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (m_nWaitTimeForTouch < 0)
            {
                MessageBox.Show("信号等待最大时长 必须为正整数！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int nRet = CSharpInterface.HS_Mark(0, m_bWaitTouch, m_bWaitEnd, m_nWaitTimeForTouch, true);
            if (0 == nRet)
            {
                this.tbNote.Text = "打标成功！";
            }
            else
            {
                ShowLastError();
            }
        }

        //开始打标
        private void btnEarMark_Click(object sender, EventArgs e)
        {
            LaserMark();
        }

        private void cbWaitTouch_CheckedChanged(object sender, EventArgs e)
        {
            this.m_bWaitTouch = this.cbWaitTouch.Checked;
        }

        private void cbWaitEnd_CheckedChanged(object sender, EventArgs e)
        {
            this.m_bWaitEnd = this.cbWaitEnd.Checked;
        }

        //显示打标状态
        private void btnStatus_Click(object sender, EventArgs e)
        {
            int nFlag = 0;
            int nRet = CSharpInterface.HS_IsMarkEnd(ref nFlag);
            if (nRet == 0)
            {
                if (nFlag == 0) this.tbNote.Text = "Marking ......!";
                else
                {
                    this.tbNote.Text = "打标结束.....!";
                    int nTime = 0;
                    CSharpInterface.HS_GetMarkTime(ref nTime);
                    this.tbNote.Text = "Mark finish...! Last time " + nTime.ToString() + " ms";
                    Preview();//预览
                }
            }
            else
            {
                ShowLastError();
            }
        }

        //暂停打标
        private void btnMarkPause_Click(object sender, EventArgs e)
        {
            int nRet = CSharpInterface.HS_MarkPause();
            if (0 == nRet)
            {
                this.tbNote.Text = "暂停打标!";
            }
            else
            {
                ShowLastError();
            }
        }

        //继续打标
        private void btnMarkResume_Click(object sender, EventArgs e)
        {
            int nRet = CSharpInterface.HS_Remark();
            if (0 == nRet)
            {
                this.tbNote.Text = "继续打标!";
            }
            else
            {
                ShowLastError();
            }
        }

        //停止打标
        private void btnMarkStop_Click(object sender, EventArgs e)
        {
            int nRet = CSharpInterface.HS_MarkStop();
            if (0 == nRet)
            {
                this.tbNote.Text = "停止打标!";
            }
            else
            {
                ShowLastError();
            }
        }

        //显示预览
        void Preview()
        {
            if (bDrawing)
                return;

            bDrawing = true;
            if (myImageTab1.Handle != null)
            {
                int nRet = CSharpInterface.HS_PreviewGraph(myImageTab1.Handle, m_dbViewX, m_dbViewY, m_dbViewRate);
                if (0 != nRet)
                    ShowLastError();
            }
          
            bDrawing = false;
        }

        //重置预览
        void ResetPreview()
        {
            this.tbrX.Value = 0;
            this.m_dbViewX = 0.0;
            this.tbrY.Value = 0;
            this.m_dbViewY = 0.0;
            this.tbrS.Value = 30;
            this.m_dbViewRate = 1.0;
            Preview();
        }

        //调整X轴
        private void tbrX_Scroll(object sender, EventArgs e)
        {
            m_dbViewX = Convert.ToDouble(this.tbrX.Value);
            Preview();
        }

        //调整Y轴
        private void tbrY_Scroll(object sender, EventArgs e)
        {
            m_dbViewY = Convert.ToDouble(this.tbrY.Value);
            Preview();
        }

        //调整Scorll轴
        private void tbrS_Scroll(object sender, EventArgs e)
        {
            int nPos = tbrS.Value;
            m_dbViewRate = 1.0 + (nPos - 30) / 10.0;
            Preview();
        }

        //图形显示区域重绘是调用Preview进行绘图
        private void myimagetab_Paint(object sender, PaintEventArgs e)
        {
            Preview();
        }

        //添加点阵对象
        private void btnAddDotMatrix_Click(object sender, EventArgs e)
        {
            AddDotMatrixForm adddotmatrixform = new AddDotMatrixForm();
            adddotmatrixform.ShowDialog();

            if (adddotmatrixform.ClickOkBtn == true)
            {
                this.cmbObjList.Items.Add(adddotmatrixform.m_strObjName);
                this.cmbObjList.SelectedValue = cmbObjList.Items.Count - 1;//选择最后一项
                SelectSize();
                Preview();
            }
        }

        //获取当前操作对象的属性，并显示在状态栏中
        void SelectSize()
        {
            double l = 0, t = 0, r = 0, b = 0;
            int nRet = CSharpInterface.HS_GetObjProperty(ref l, ref t, ref r, ref b);
            if (0 == nRet)
            {
                tsslabObjSize.Text = "对象属性:[宽" + (r - l).ToString("f2") + "mm,高"
                    + (t - b).ToString("f2") + "mm,中心(" + (0.5 * (r + l)).ToString("f2") + "," + (0.5 * (t + b)).ToString("f2") + ")]";
            }
            else
            {
                ShowLastError();
            }
        }

        //添加文本对象
        private void btnAddText_Click(object sender, EventArgs e)
        {
            AddTextForm addtextform = new AddTextForm();
            addtextform.ShowDialog();
            if (addtextform.ClickAdd == true)
            {
                this.cmbObjList.Items.Add(addtextform.m_strObjName);
                this.cmbObjList.SelectedValue = cmbObjList.Items.Count - 1;//选择最后一项
                SelectSize();
                Preview();
            }
        }

        //选择当前操作对象
        private void cmbObjList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedstr = cmbObjList.GetItemText(cmbObjList.SelectedItem);//获取选择项
            if (selectedstr == "NONE")
            {
                CSharpInterface.HS_SelectObjects(null, false);
            }
            else if (selectedstr == "ALL")
            {
                CSharpInterface.HS_SelectObjects(null, true);
            }
            else
            {
                CSharpInterface.HS_SelectObjects(null, false);
                CSharpInterface.HS_SelectObjects(selectedstr, true);
            }
            SelectSize();
            Preview();
        }

        //删除选择的对象
        private void btnClearDocSelObj_Click(object sender, EventArgs e)
        {
            int nRet = CSharpInterface.HS_ClearObjects();
            if (nRet == 0)
            {
                ReLoadObjList();
                Preview();
            }
            else
            {
                this.tbNote.Text = "HS_ClearObj fail!";
            }
            SelectSize();
        }

        //更新对象列表
        void ReLoadObjList()
        {
            cmbObjList.Items.Clear();
            cmbObjList.Items.Add("NONE");
            cmbObjList.Items.Add("ALL");
            byte[,] szObjList = new byte[100, 50];
            byte[] objname = new byte[50];
            int n = 0;
            int nRet = CSharpInterface.HS_GetObjList(szObjList, ref n);
            if (0 == nRet)
            {
                for (int i = 0; i < n; ++i)
                {
                    for (int t = 0; t < 50; t++) objname[t] = szObjList[i, t];
                    cmbObjList.Items.Add(Encoding.Default.GetString(objname));
                }
            }
            CSharpInterface.HS_SelectObjects(null, false);
            this.cmbObjList.SelectedValue = 0;//选择第一项
        }

        //添加条码对象
        private void btnAddBarCode_Click(object sender, EventArgs e)
        {
            AddBarCodeForm addbarcodeform = new AddBarCodeForm();
            addbarcodeform.ShowDialog();
            if (addbarcodeform.ClickAdd == true)
            {
                this.cmbObjList.Items.Add(addbarcodeform.m_strObjName);
                this.cmbObjList.SelectedValue = cmbObjList.Items.Count - 1;//选择最后一项
                SelectSize();
                Preview();
            }
        }

        //添加曲线对象
        private void btnAddCurve_Click(object sender, EventArgs e)
        {
            //test
            /*
            double[,] ptBuf = new double[2, 2];
            string m_strObjName = "curve1";

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 100000; j++)
                {
                    ptBuf[0, 0] = 1;//第J个线条的开始的点
                    ptBuf[0, 1] = 2;
                    ptBuf[1, 0] = 3;//第J个线条的终点
                    ptBuf[1, 1] = 4;

                    if (0 != CSharpInterface.HS_AddCurve(ptBuf, 2, 0, false, 0, m_strObjName))
                    {
                        MessageBox.Show("添加失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }

                if (0 == CSharpInterface.HS_Mark(0, false, true, 10, true))
                {
                    MessageBox.Show("打标成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("打标失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CSharpInterface.HS_SelectObjects(null, true);
                CSharpInterface.HS_ClearObjects();
            }
            */
            /////////////////////////////
            AddCurveForm addcurveform = new AddCurveForm();
            addcurveform.ShowDialog();
            if (addcurveform.ClickAdd == true)
            {
                this.cmbObjList.Items.Add(addcurveform.m_strObjName);
                this.cmbObjList.SelectedValue = cmbObjList.Items.Count - 1;//选择最后一项
                SelectSize();
                Preview();
            }
        }

        //导入矢量图形
        private void btnImportVectorFile_Click(object sender, EventArgs e)
        {
            ImportVectorForm improtvectorform = new ImportVectorForm();
            improtvectorform.ShowDialog();
            if (improtvectorform.ClickImport == true)
            {
                this.cmbObjList.Items.Add(improtvectorform.m_strObjName);
                this.cmbObjList.SelectedValue = cmbObjList.Items.Count - 1;//选择最后一项
                SelectSize();
                Preview();
            }
        }

        //导入位图文件
        private void btnImportImageFile_Click(object sender, EventArgs e)
        {
            ImportImageForm improtimageform = new ImportImageForm();
            improtimageform.ShowDialog();
            if (improtimageform.ClickImport == true)
            {
                this.cmbObjList.Items.Add(improtimageform.m_strObjName);
                this.cmbObjList.SelectedValue = cmbObjList.Items.Count - 1;//选择最后一项
                SelectSize();
                Preview();
            }
        }

        //移动对象
        private void btnMove_Click(object sender, EventArgs e)
        {
            try
            {
                m_dbParaX = Convert.ToDouble(tbParaX.Text);
                m_dbParaY = Convert.ToDouble(tbParaY.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("输入的数据不合法！\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int nRet = CSharpInterface.HS_Move(m_dbParaX, m_dbParaY);
            if (nRet == 0)
            {
                tbNote.Text = "Move success!";
                Preview();
            }
            else
            {
                ShowLastError();
            }
            SelectSize();
        }

        //旋转对象
        private void btnRotate_Click(object sender, EventArgs e)
        {
            try
            {
                m_dbParaX = Convert.ToDouble(tbParaX.Text);
                m_dbBaseX = Convert.ToDouble(tbBaseX.Text);
                m_dbBaseY = Convert.ToDouble(tbBaseY.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("输入的数据不合法！\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int nRet = CSharpInterface.HS_Rotate(m_dbBaseX, m_dbBaseY, m_dbParaX);
            if (nRet == 0)
            {
                tbNote.Text = "Rotate success!";
                Preview();
            }
            else
            {
                ShowLastError();
            }
            SelectSize();
        }

        //切变对象
        private void btnShear_Click(object sender, EventArgs e)
        {
            try
            {
                m_dbParaX = Convert.ToDouble(tbParaX.Text);
                m_dbParaY = Convert.ToDouble(tbParaY.Text);
                m_dbBaseX = Convert.ToDouble(tbBaseX.Text);
                m_dbBaseY = Convert.ToDouble(tbBaseY.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("输入的数据不合法！\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int nRet = CSharpInterface.HS_Shear(m_dbBaseX, m_dbBaseY, m_dbParaX, m_dbParaY);
            if (nRet == 0)
            {
                tbNote.Text = "Shear success!";
                Preview();
            }
            else
            {
                ShowLastError();
            }
            SelectSize();
        }

        //缩放对象
        private void btnScale_Click(object sender, EventArgs e)
        {
            try
            {
                m_dbParaX = Convert.ToDouble(tbParaX.Text);
                m_dbParaY = Convert.ToDouble(tbParaY.Text);
                m_dbBaseX = Convert.ToDouble(tbBaseX.Text);
                m_dbBaseY = Convert.ToDouble(tbBaseY.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("输入的数据不合法！\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int nRet = CSharpInterface.HS_Scale(m_dbBaseX, m_dbBaseY, m_dbParaX, m_dbParaY);
            if (nRet == 0)
            {
                tbNote.Text = "Scale success!";
                Preview();
            }
            else
            {
                ShowLastError();
            }
            SelectSize();
        }

        //文本替换
        private void btnChangeTextByID_Click(object sender, EventArgs e)
        {
            m_strModelName = this.tbTextID.Text;
            m_strTextTxt = this.tbTextTXT.Text;
            int nRet = CSharpInterface.HS_ChangeTextByName(m_strModelName, m_strTextTxt);
            if (0 == nRet)
            {
                tbNote.Text = "Change text successfully!";
                SelectSize();
                Preview();
            }
            else
            {
                ShowLastError();
            }
        }

        //文本获取
        private void btnGetTextByID_Click(object sender, EventArgs e)
        {
            m_strModelName = this.tbTextID.Text;
            int nSize = 200;
            StringBuilder szText = new StringBuilder(200);
            int nRet = CSharpInterface.HS_GetTextByName(m_strModelName, szText, ref nSize);
            if (0 == nRet)
            {
                tbNote.Text = "Get text value successfully!";
            }
            else
            {
                ShowLastError();
                return;
            }

            this.tbTextTXT.Text = m_strTextTxt = szText.ToString();
        }

        //获取可变对象的别名列表
        private void button_GetList_Click(object sender, EventArgs e)
        {
            m_strModelName = this.tbTextID.Text;
            int nCount = 5000;
            StringBuilder szNameList = new StringBuilder(5000);


            int nRet = CSharpInterface.HS_GetVarTextList(szNameList, ref nCount);
            if (0 == nRet)
            {
                tbNote.Text = "Get name list successfully!";
            }
            else
            {
                ShowLastError();
                return;
            }
            string nameList = szNameList.ToString();

             MessageBox.Show(nCount.ToString() + "可变对象别名列表：\r\n" + nameList, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //文本替换W
        private void btnChangeTextByIDW_Click(object sender, EventArgs e)
        {
            string szText2 = tbTextTXT.Text;
            Byte[] szText = Encoding.Unicode.GetBytes(szText2);
            int nRet = CSharpInterface.HS_ChangeTextByNameW(m_strModelName, szText);
            if (0 == nRet)
            {
                tbNote.Text = "ChangeTextValue successfully!";
                SelectSize();
            }
            else
            {
                ShowLastError();
                return;
            }
            Preview();
        }

        //文本获取W
        private void btnGetTextByIDW_Click(object sender, EventArgs e)
        {
            m_strModelName = this.tbTextID.Text;
            int nSize = 200;
            byte[] szText=new byte[200];
            int nRet = CSharpInterface.HS_GetTextByNameW(m_strModelName, szText, ref nSize);
            if (0 == nRet)
            {
                tbNote.Text = "Get text value successfully!";
            }
            else
            {
                ShowLastError();
                return;
            }
            this.tbTextTXT.Text = m_strTextTxt = Encoding.Unicode.GetString(szText);
        }

        //打开模板文件
        private void btnModule_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "HS File(*.HS)|*.HS";
            openFileDialog1.Title = "Improt Hans file";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            int nRet = CSharpInterface.HS_LoadMarkFile(openFileDialog1.FileName);
            if (0 == nRet)
            {
                tbNote.Text = "open module file " + openFileDialog1.SafeFileName + " succeed!";
                m_strHansFileName = openFileDialog1.SafeFileName;
                Preview();
                SelectSize();
            }
            else
            {
                ShowLastError();
            }
        }

        //保存为模板文件
        private void btnSaveMarkFile_Click(object sender, EventArgs e)
        {
            SaveMarkFileForm savemarkfile = new SaveMarkFileForm();
            savemarkfile.ShowDialog();
            if (savemarkfile.ClickSave == true)
            {
                string szfilename = savemarkfile.m_strFileName;
                int nRet = CSharpInterface.HS_SaveMarkFile(szfilename);
                if (nRet == 0)
                {
                    tbNote.Text = "SaveMarkFile success!";
                }
                else
                {
                    ShowLastError();
                }
            }
        }

        //关闭模板文件
        private void btnModulesClose_Click(object sender, EventArgs e)
        {
            bool bSave = false;
            if (DialogResult.Yes == MessageBox.Show("是否保存修改？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                bSave = true;
            }
            int nRet = CSharpInterface.HS_CloseMarkFile(m_strHansFileName, bSave);
            if (nRet == 0)
            {
                tbNote.Text = "CloseMarkFile success!";
                Preview();
                SelectSize();
            }
            else
            {
                ShowLastError();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
