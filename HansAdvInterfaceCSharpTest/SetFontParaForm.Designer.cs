namespace HansAdvInterfaceCSharpTest
{
    partial class SetFontParaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbFontTTF = new System.Windows.Forms.RadioButton();
            this.rbFontSHX = new System.Windows.Forms.RadioButton();
            this.rbFontUser = new System.Windows.Forms.RadioButton();
            this.rbFontMatrix = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTTF = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbNUM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEN = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCHS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbMatrixCHS = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMatrixEnNum = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbShxNum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbShxEN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbShxCN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbFontName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFontType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbFontTTF
            // 
            this.rbFontTTF.AutoSize = true;
            this.rbFontTTF.Checked = true;
            this.rbFontTTF.Location = new System.Drawing.Point(23, 19);
            this.rbFontTTF.Name = "rbFontTTF";
            this.rbFontTTF.Size = new System.Drawing.Size(41, 16);
            this.rbFontTTF.TabIndex = 0;
            this.rbFontTTF.TabStop = true;
            this.rbFontTTF.Text = "TTF";
            this.rbFontTTF.UseVisualStyleBackColor = true;
            this.rbFontTTF.CheckedChanged += new System.EventHandler(this.rbFont_CheckedChanged);
            // 
            // rbFontSHX
            // 
            this.rbFontSHX.AutoSize = true;
            this.rbFontSHX.Location = new System.Drawing.Point(113, 19);
            this.rbFontSHX.Name = "rbFontSHX";
            this.rbFontSHX.Size = new System.Drawing.Size(41, 16);
            this.rbFontSHX.TabIndex = 1;
            this.rbFontSHX.Text = "SHX";
            this.rbFontSHX.UseVisualStyleBackColor = true;
            this.rbFontSHX.CheckedChanged += new System.EventHandler(this.rbFont_CheckedChanged);
            // 
            // rbFontUser
            // 
            this.rbFontUser.AutoSize = true;
            this.rbFontUser.Location = new System.Drawing.Point(203, 19);
            this.rbFontUser.Name = "rbFontUser";
            this.rbFontUser.Size = new System.Drawing.Size(47, 16);
            this.rbFontUser.TabIndex = 2;
            this.rbFontUser.Text = "HANS";
            this.rbFontUser.UseVisualStyleBackColor = true;
            this.rbFontUser.CheckedChanged += new System.EventHandler(this.rbFont_CheckedChanged);
            // 
            // rbFontMatrix
            // 
            this.rbFontMatrix.AutoSize = true;
            this.rbFontMatrix.Location = new System.Drawing.Point(299, 19);
            this.rbFontMatrix.Name = "rbFontMatrix";
            this.rbFontMatrix.Size = new System.Drawing.Size(65, 16);
            this.rbFontMatrix.TabIndex = 3;
            this.rbFontMatrix.Text = "Lattice";
            this.rbFontMatrix.UseVisualStyleBackColor = true;
            this.rbFontMatrix.CheckedChanged += new System.EventHandler(this.rbFont_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTTF);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 40);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TTF";
            // 
            // btnTTF
            // 
            this.btnTTF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTF.Location = new System.Drawing.Point(36, 12);
            this.btnTTF.Name = "btnTTF";
            this.btnTTF.Size = new System.Drawing.Size(103, 22);
            this.btnTTF.TabIndex = 0;
            this.btnTTF.Text = "TTF Settings";
            this.btnTTF.UseVisualStyleBackColor = true;
            this.btnTTF.Click += new System.EventHandler(this.btnTTF_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbNUM);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbEN);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbCHS);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 70);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SHX";
            // 
            // cmbNUM
            // 
            this.cmbNUM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNUM.FormattingEnabled = true;
            this.cmbNUM.Location = new System.Drawing.Point(78, 42);
            this.cmbNUM.Name = "cmbNUM";
            this.cmbNUM.Size = new System.Drawing.Size(95, 20);
            this.cmbNUM.TabIndex = 5;
            this.cmbNUM.SelectedIndexChanged += new System.EventHandler(this.cmbNUM_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Digit";
            // 
            // cmbEN
            // 
            this.cmbEN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEN.FormattingEnabled = true;
            this.cmbEN.Location = new System.Drawing.Point(229, 16);
            this.cmbEN.Name = "cmbEN";
            this.cmbEN.Size = new System.Drawing.Size(95, 20);
            this.cmbEN.TabIndex = 3;
            this.cmbEN.SelectedIndexChanged += new System.EventHandler(this.cmbEN_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "English";
            // 
            // cmbCHS
            // 
            this.cmbCHS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCHS.FormattingEnabled = true;
            this.cmbCHS.Location = new System.Drawing.Point(78, 16);
            this.cmbCHS.Name = "cmbCHS";
            this.cmbCHS.Size = new System.Drawing.Size(95, 20);
            this.cmbCHS.TabIndex = 1;
            this.cmbCHS.SelectedIndexChanged += new System.EventHandler(this.cmbCHS_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chinese";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbUser);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 40);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HANS";
            // 
            // cmbUser
            // 
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(78, 14);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(95, 20);
            this.cmbUser.TabIndex = 7;
            this.cmbUser.SelectedIndexChanged += new System.EventHandler(this.cmbUser_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Font File";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbMatrixCHS);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cmbMatrixEnNum);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(12, 214);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 40);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lattice";
            // 
            // cmbMatrixCHS
            // 
            this.cmbMatrixCHS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMatrixCHS.FormattingEnabled = true;
            this.cmbMatrixCHS.Location = new System.Drawing.Point(244, 14);
            this.cmbMatrixCHS.Name = "cmbMatrixCHS";
            this.cmbMatrixCHS.Size = new System.Drawing.Size(95, 20);
            this.cmbMatrixCHS.TabIndex = 7;
            this.cmbMatrixCHS.SelectedIndexChanged += new System.EventHandler(this.cmbMatrixCHS_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Chinese";
            // 
            // cmbMatrixEnNum
            // 
            this.cmbMatrixEnNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMatrixEnNum.FormattingEnabled = true;
            this.cmbMatrixEnNum.Location = new System.Drawing.Point(90, 14);
            this.cmbMatrixEnNum.Name = "cmbMatrixEnNum";
            this.cmbMatrixEnNum.Size = new System.Drawing.Size(95, 20);
            this.cmbMatrixEnNum.TabIndex = 5;
            this.cmbMatrixEnNum.SelectedIndexChanged += new System.EventHandler(this.cmbMatrixEnNum_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "English\\Digit";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbShxNum);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.tbShxEN);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.tbShxCN);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.tbFontName);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.tbFontType);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(12, 262);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(345, 171);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Font Parameters";
            // 
            // tbShxNum
            // 
            this.tbShxNum.Location = new System.Drawing.Point(107, 144);
            this.tbShxNum.Name = "tbShxNum";
            this.tbShxNum.ReadOnly = true;
            this.tbShxNum.Size = new System.Drawing.Size(183, 21);
            this.tbShxNum.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "szShxNum";
            // 
            // tbShxEN
            // 
            this.tbShxEN.Location = new System.Drawing.Point(107, 113);
            this.tbShxEN.Name = "tbShxEN";
            this.tbShxEN.ReadOnly = true;
            this.tbShxEN.Size = new System.Drawing.Size(183, 21);
            this.tbShxEN.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "szShxEN";
            // 
            // tbShxCN
            // 
            this.tbShxCN.Location = new System.Drawing.Point(107, 82);
            this.tbShxCN.Name = "tbShxCN";
            this.tbShxCN.ReadOnly = true;
            this.tbShxCN.Size = new System.Drawing.Size(183, 21);
            this.tbShxCN.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "szShxCN";
            // 
            // tbFontName
            // 
            this.tbFontName.Location = new System.Drawing.Point(107, 51);
            this.tbFontName.Name = "tbFontName";
            this.tbFontName.ReadOnly = true;
            this.tbFontName.Size = new System.Drawing.Size(183, 21);
            this.tbFontName.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "nFontName";
            // 
            // tbFontType
            // 
            this.tbFontType.Location = new System.Drawing.Point(107, 20);
            this.tbFontType.Name = "tbFontType";
            this.tbFontType.ReadOnly = true;
            this.tbFontType.Size = new System.Drawing.Size(183, 21);
            this.tbFontType.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "nFontType";
            // 
            // btnSet
            // 
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Location = new System.Drawing.Point(86, 439);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(65, 22);
            this.btnSet.TabIndex = 8;
            this.btnSet.Text = "Apply";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(217, 439);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 22);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SetFontParaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 467);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbFontMatrix);
            this.Controls.Add(this.rbFontUser);
            this.Controls.Add(this.rbFontSHX);
            this.Controls.Add(this.rbFontTTF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SetFontParaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Font Parameter Setting";
            this.Load += new System.EventHandler(this.SetFontParaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbFontTTF;
        private System.Windows.Forms.RadioButton rbFontSHX;
        private System.Windows.Forms.RadioButton rbFontUser;
        private System.Windows.Forms.RadioButton rbFontMatrix;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTTF;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbNUM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCHS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbMatrixCHS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMatrixEnNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbShxNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbShxEN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbShxCN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbFontName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbFontType;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnCancel;
    }
}