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
    public partial class AddDotMatrixForm : Form
    {
        int m_nPtNum=0;
        int m_nLayer=0;
        public string m_strObjName = "PointMarix";
        List<PointF> m_arrayDot=new List<PointF>();
        public bool ClickOkBtn = false;
        
        public AddDotMatrixForm()
        {
            InitializeComponent();
        }

        private void AddDotMatrixForm_Load(object sender, EventArgs e)
        {
            this.tbLayer.Text = m_nLayer.ToString();
            this.tbObjName.Text = m_strObjName.ToString();
            this.tbPointNum.Text = m_nPtNum.ToString();
        }

        //添加点
        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            AddPointForm addpoinform = new AddPointForm();
            addpoinform.ShowDialog();
            if (addpoinform.ClickAdd)
            {
                PointF dot = new Point();
                dot.X = (float)addpoinform.m_dbX;
                dot.Y = (float)addpoinform.m_dbY;
                m_arrayDot.Add(dot);
            }
            ViewListPoint();//更新显示列表
        }

        //更新点列表
        private void ViewListPoint()
        {
            m_nPtNum = m_arrayDot.Count;
            this.tbPointNum.Text = m_nPtNum.ToString();
            this.lsbPoint.Items.Clear();//清空列表
            for (int i = 0; i < m_nPtNum; i++)
            {
                lsbPoint.Items.Add("X=" + m_arrayDot[i].X + "    Y=" + m_arrayDot[i].Y);
            }
            if (m_nPtNum != 0) lsbPoint.SetSelected(0, true);//选择第一项
        }

        //修改点对象
        private void btnModifyPoint_Click(object sender, EventArgs e)
        {
            int selectindex = lsbPoint.SelectedIndex;
            if (selectindex < 0)
            {
                MessageBox.Show("请先选择要修改的点对象", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            AddPointForm addpointform = new AddPointForm();
            addpointform.m_dbX = m_arrayDot[selectindex].X;
            addpointform.m_dbY = m_arrayDot[selectindex].Y;
            addpointform.ShowDialog();
            if (addpointform.ClickAdd)
            {
                m_arrayDot.RemoveAt(selectindex);
                PointF dot = new PointF();
                dot.X = (float)addpointform.m_dbX;
                dot.Y= (float)addpointform.m_dbY;
                m_arrayDot.Insert(selectindex, dot);
            }
            ViewListPoint();//更新显示列表
        }

        //删除点对象
        private void btnDelPoint_Click(object sender, EventArgs e)
        {
            int selectindex = lsbPoint.SelectedIndex;
            if (selectindex < 0)
            {
                MessageBox.Show("请先选择要删除的点对象", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            m_arrayDot.RemoveAt(selectindex);
            ViewListPoint();//更新显示列表
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //确定添加点阵
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                m_nLayer = Convert.ToInt32(this.tbLayer.Text);
                m_strObjName = tbObjName.Text.ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("输入的数据不合法！\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            m_strObjName = m_strObjName.Trim();//去除空格等
            if (m_strObjName.Length <= 0)
            {
                MessageBox.Show("对象名不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (m_nLayer <0)
            {
                MessageBox.Show("层号不能为负数哦！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (m_arrayDot.Count <= 0)
            {
                MessageBox.Show("点阵中至少要包含一个点对象！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            double[,] ptBuf = new double[m_nPtNum, 2];

            for (int i = 0; i < m_nPtNum; i++)
            {
                ptBuf[i, 0] = m_arrayDot[i].X;
                ptBuf[i, 1] = m_arrayDot[i].Y;
            }

            int nRet = CSharpInterface.HS_AddDotMatrix(ptBuf, m_nPtNum, m_nLayer, m_strObjName);
            if (nRet == 0)
            {
                MessageBox.Show("AddDotMatrix success!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClickOkBtn = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
