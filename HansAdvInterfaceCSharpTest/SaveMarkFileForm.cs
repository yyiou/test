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
    public partial class SaveMarkFileForm : Form
    {
        public bool ClickSave = false;
        public string m_strFileName="";
        public SaveMarkFileForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefiledianlog = new SaveFileDialog();
            savefiledianlog.Filter = "HS files(*.hs)|*.hs|All Files(*.*)|*.*||";
            savefiledianlog.Title = "Save mark File";
            if (savefiledianlog.ShowDialog() == DialogResult.OK)
            {
                m_strFileName = savefiledianlog.FileName;
                if (m_strFileName.IndexOf(".hs") == -1)
                {
                    m_strFileName += ".hs";
                }
                tbFillName.Text = m_strFileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            m_strFileName = tbFillName.Text;
            m_strFileName=m_strFileName.Trim();
            if (m_strFileName.Length < 1)
            {
                MessageBox.Show("文件名不能为空！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            ClickSave = true;
            this.Close();
        }
    }
}
