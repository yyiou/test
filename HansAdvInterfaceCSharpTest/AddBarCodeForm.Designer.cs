namespace HansAdvInterfaceCSharpTest
{
    partial class AddBarCodeForm
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
            this.cmbAlign = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbReverse = new System.Windows.Forms.CheckBox();
            this.tbPosY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPosX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbObjName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbBarCodeType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAngle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbBarRatio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbLayNO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbShrink = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbLineDist = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbRevHeight = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbRevWidth = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbModify = new System.Windows.Forms.CheckBox();
            this.tbTextID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbAlign
            // 
            this.cmbAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlign.FormattingEnabled = true;
            this.cmbAlign.Items.AddRange(new object[] {
            "左对齐",
            "右对齐",
            "中间对齐"});
            this.cmbAlign.Location = new System.Drawing.Point(80, 192);
            this.cmbAlign.Name = "cmbAlign";
            this.cmbAlign.Size = new System.Drawing.Size(83, 20);
            this.cmbAlign.TabIndex = 51;
            this.cmbAlign.SelectedIndexChanged += new System.EventHandler(this.cmbAlign_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 50;
            this.label10.Text = "排列方式";
            // 
            // cbReverse
            // 
            this.cbReverse.AutoSize = true;
            this.cbReverse.Location = new System.Drawing.Point(50, 310);
            this.cbReverse.Name = "cbReverse";
            this.cbReverse.Size = new System.Drawing.Size(96, 16);
            this.cbReverse.TabIndex = 49;
            this.cbReverse.Text = "条码是否反填";
            this.cbReverse.UseVisualStyleBackColor = true;
            this.cbReverse.CheckedChanged += new System.EventHandler(this.cbReverse_CheckedChanged);
            // 
            // tbPosY
            // 
            this.tbPosY.Location = new System.Drawing.Point(266, 155);
            this.tbPosY.Name = "tbPosY";
            this.tbPosY.Size = new System.Drawing.Size(83, 21);
            this.tbPosY.TabIndex = 48;
            this.tbPosY.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 47;
            this.label4.Text = "条码Y位置";
            // 
            // tbPosX
            // 
            this.tbPosX.Location = new System.Drawing.Point(80, 154);
            this.tbPosX.Name = "tbPosX";
            this.tbPosX.Size = new System.Drawing.Size(83, 21);
            this.tbPosX.TabIndex = 46;
            this.tbPosX.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 45;
            this.label2.Text = "条码X位置";
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(80, 50);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(243, 49);
            this.tbText.TabIndex = 44;
            this.tbText.Text = "text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 43;
            this.label1.Text = "条码内容";
            // 
            // tbObjName
            // 
            this.tbObjName.Location = new System.Drawing.Point(80, 12);
            this.tbObjName.Name = "tbObjName";
            this.tbObjName.Size = new System.Drawing.Size(83, 21);
            this.tbObjName.TabIndex = 42;
            this.tbObjName.Text = "barcode1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 41;
            this.label3.Text = "对象名";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(208, 403);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 22);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(77, 403);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 22);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbBarCodeType
            // 
            this.cmbBarCodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarCodeType.FormattingEnabled = true;
            this.cmbBarCodeType.Items.AddRange(new object[] {
            "EAN 8",
            "EAN 13",
            "EAN 128",
            "CODE 128A",
            "CODE 128B",
            "CODE 128C",
            "CODE 128AUTO",
            "CODE 39",
            "INT 25",
            "EXT 39",
            "UPCA",
            "UPCE",
            "PDF417",
            "DATA MATRIX",
            "QR"});
            this.cmbBarCodeType.Location = new System.Drawing.Point(80, 116);
            this.cmbBarCodeType.Name = "cmbBarCodeType";
            this.cmbBarCodeType.Size = new System.Drawing.Size(83, 20);
            this.cmbBarCodeType.TabIndex = 53;
            this.cmbBarCodeType.SelectedIndexChanged += new System.EventHandler(this.cmbBarCodeType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 52;
            this.label5.Text = "条码类型";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(266, 115);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(83, 21);
            this.tbHeight.TabIndex = 55;
            this.tbHeight.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 54;
            this.label6.Text = "条码高度";
            // 
            // tbAngle
            // 
            this.tbAngle.Location = new System.Drawing.Point(266, 192);
            this.tbAngle.Name = "tbAngle";
            this.tbAngle.Size = new System.Drawing.Size(83, 21);
            this.tbAngle.TabIndex = 57;
            this.tbAngle.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 56;
            this.label7.Text = "旋转角";
            // 
            // tbBarRatio
            // 
            this.tbBarRatio.Location = new System.Drawing.Point(266, 231);
            this.tbBarRatio.Name = "tbBarRatio";
            this.tbBarRatio.Size = new System.Drawing.Size(83, 21);
            this.tbBarRatio.TabIndex = 61;
            this.tbBarRatio.Text = "0.191";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(207, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 60;
            this.label8.Text = "宽窄比";
            // 
            // tbLayNO
            // 
            this.tbLayNO.Location = new System.Drawing.Point(80, 230);
            this.tbLayNO.Name = "tbLayNO";
            this.tbLayNO.Size = new System.Drawing.Size(83, 21);
            this.tbLayNO.TabIndex = 59;
            this.tbLayNO.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 58;
            this.label9.Text = "层号";
            // 
            // tbShrink
            // 
            this.tbShrink.Location = new System.Drawing.Point(266, 269);
            this.tbShrink.Name = "tbShrink";
            this.tbShrink.Size = new System.Drawing.Size(83, 21);
            this.tbShrink.TabIndex = 65;
            this.tbShrink.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(207, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 64;
            this.label11.Text = "缩进量";
            // 
            // tbLineDist
            // 
            this.tbLineDist.Location = new System.Drawing.Point(80, 268);
            this.tbLineDist.Name = "tbLineDist";
            this.tbLineDist.Size = new System.Drawing.Size(83, 21);
            this.tbLineDist.TabIndex = 63;
            this.tbLineDist.Text = "0.1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 62;
            this.label12.Text = "线间距";
            // 
            // tbRevHeight
            // 
            this.tbRevHeight.Enabled = false;
            this.tbRevHeight.Location = new System.Drawing.Point(266, 332);
            this.tbRevHeight.Name = "tbRevHeight";
            this.tbRevHeight.Size = new System.Drawing.Size(83, 21);
            this.tbRevHeight.TabIndex = 69;
            this.tbRevHeight.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(189, 336);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 68;
            this.label13.Text = "反填高度(mm)";
            // 
            // tbRevWidth
            // 
            this.tbRevWidth.Enabled = false;
            this.tbRevWidth.Location = new System.Drawing.Point(80, 332);
            this.tbRevWidth.Name = "tbRevWidth";
            this.tbRevWidth.Size = new System.Drawing.Size(83, 21);
            this.tbRevWidth.TabIndex = 67;
            this.tbRevWidth.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(0, 336);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 66;
            this.label14.Text = "反填宽度(mm)";
            // 
            // cbModify
            // 
            this.cbModify.AutoSize = true;
            this.cbModify.Location = new System.Drawing.Point(50, 372);
            this.cbModify.Name = "cbModify";
            this.cbModify.Size = new System.Drawing.Size(108, 16);
            this.cbModify.TabIndex = 70;
            this.cbModify.Text = "是否是可变文本";
            this.cbModify.UseVisualStyleBackColor = true;
            this.cbModify.CheckedChanged += new System.EventHandler(this.cbModify_CheckedChanged);
            // 
            // tbTextID
            // 
            this.tbTextID.Enabled = false;
            this.tbTextID.Location = new System.Drawing.Point(266, 370);
            this.tbTextID.Name = "tbTextID";
            this.tbTextID.Size = new System.Drawing.Size(83, 21);
            this.tbTextID.TabIndex = 72;
            this.tbTextID.TextChanged += new System.EventHandler(this.tbTextID_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(195, 376);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 71;
            this.label15.Text = "可变文本ID";
            // 
            // AddBarCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 435);
            this.Controls.Add(this.tbTextID);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbModify);
            this.Controls.Add(this.tbRevHeight);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbRevWidth);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbShrink);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbLineDist);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbBarRatio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbLayNO);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbAngle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbBarCodeType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAlign);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbReverse);
            this.Controls.Add(this.tbPosY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPosX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbObjName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddBarCodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Bar Code";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAlign;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbReverse;
        private System.Windows.Forms.TextBox tbPosY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPosX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbObjName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbBarCodeType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAngle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbBarRatio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbLayNO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbShrink;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbLineDist;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbRevHeight;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbRevWidth;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cbModify;
        private System.Windows.Forms.TextBox tbTextID;
        private System.Windows.Forms.Label label15;
    }
}