namespace HansAdvInterfaceCSharpTest
{
    partial class AddTextForm
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
            this.tbObjName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWidthRatio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbModel = new System.Windows.Forms.CheckBox();
            this.tbPosY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPosX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbModelID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbLayer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbRoTate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbAlign = new System.Windows.Forms.ComboBox();
            this.tbCharSpace = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbHatchLayer = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbLineSpace = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbHatch = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbObjName
            // 
            this.tbObjName.Location = new System.Drawing.Point(79, 12);
            this.tbObjName.Name = "tbObjName";
            this.tbObjName.Size = new System.Drawing.Size(83, 21);
            this.tbObjName.TabIndex = 19;
            this.tbObjName.Text = "Text1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "对象名";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(206, 378);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 22);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(75, 378);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 22);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(79, 50);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(243, 49);
            this.tbText.TabIndex = 21;
            this.tbText.Text = "text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "文本内容";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(79, 113);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(83, 21);
            this.tbHeight.TabIndex = 23;
            this.tbHeight.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "文本高度";
            // 
            // tbWidthRatio
            // 
            this.tbWidthRatio.Location = new System.Drawing.Point(239, 113);
            this.tbWidthRatio.Name = "tbWidthRatio";
            this.tbWidthRatio.Size = new System.Drawing.Size(83, 21);
            this.tbWidthRatio.TabIndex = 25;
            this.tbWidthRatio.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "宽度系数";
            // 
            // cbModel
            // 
            this.cbModel.AutoSize = true;
            this.cbModel.Location = new System.Drawing.Point(22, 153);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(108, 16);
            this.cbModel.TabIndex = 26;
            this.cbModel.Text = "是否是可变文本";
            this.cbModel.UseVisualStyleBackColor = true;
            this.cbModel.CheckedChanged += new System.EventHandler(this.cbModel_CheckedChanged);
            // 
            // tbPosY
            // 
            this.tbPosY.Location = new System.Drawing.Point(239, 189);
            this.tbPosY.Name = "tbPosY";
            this.tbPosY.Size = new System.Drawing.Size(83, 21);
            this.tbPosY.TabIndex = 30;
            this.tbPosY.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "文本Y位置";
            // 
            // tbPosX
            // 
            this.tbPosX.Location = new System.Drawing.Point(79, 189);
            this.tbPosX.Name = "tbPosX";
            this.tbPosX.Size = new System.Drawing.Size(83, 21);
            this.tbPosX.TabIndex = 28;
            this.tbPosX.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "文本X位置";
            // 
            // tbModelID
            // 
            this.tbModelID.Enabled = false;
            this.tbModelID.Location = new System.Drawing.Point(239, 151);
            this.tbModelID.Name = "tbModelID";
            this.tbModelID.Size = new System.Drawing.Size(83, 21);
            this.tbModelID.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 31;
            this.label7.Text = "可变文本ID ";
            // 
            // tbLayer
            // 
            this.tbLayer.Location = new System.Drawing.Point(239, 264);
            this.tbLayer.Name = "tbLayer";
            this.tbLayer.Size = new System.Drawing.Size(83, 21);
            this.tbLayer.TabIndex = 36;
            this.tbLayer.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 35;
            this.label8.Text = "边框层号";
            // 
            // tbRoTate
            // 
            this.tbRoTate.Location = new System.Drawing.Point(79, 264);
            this.tbRoTate.Name = "tbRoTate";
            this.tbRoTate.Size = new System.Drawing.Size(83, 21);
            this.tbRoTate.TabIndex = 34;
            this.tbRoTate.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 33;
            this.label9.Text = "旋转角度";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 37;
            this.label10.Text = "排列方式";
            // 
            // cmbAlign
            // 
            this.cmbAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlign.FormattingEnabled = true;
            this.cmbAlign.Items.AddRange(new object[] {
            "左对齐",
            "右对齐",
            "中间对齐"});
            this.cmbAlign.Location = new System.Drawing.Point(79, 227);
            this.cmbAlign.Name = "cmbAlign";
            this.cmbAlign.Size = new System.Drawing.Size(83, 20);
            this.cmbAlign.TabIndex = 38;
            this.cmbAlign.SelectedIndexChanged += new System.EventHandler(this.cmbAlign_SelectedIndexChanged);
            // 
            // tbCharSpace
            // 
            this.tbCharSpace.Location = new System.Drawing.Point(79, 341);
            this.tbCharSpace.Name = "tbCharSpace";
            this.tbCharSpace.Size = new System.Drawing.Size(83, 21);
            this.tbCharSpace.TabIndex = 42;
            this.tbCharSpace.Text = "0.8";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 41;
            this.label11.Text = "字符间距(mm)";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // tbHatchLayer
            // 
            this.tbHatchLayer.Enabled = false;
            this.tbHatchLayer.Location = new System.Drawing.Point(239, 302);
            this.tbHatchLayer.Name = "tbHatchLayer";
            this.tbHatchLayer.Size = new System.Drawing.Size(83, 21);
            this.tbHatchLayer.TabIndex = 40;
            this.tbHatchLayer.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(180, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 39;
            this.label12.Text = "填充层号";
            // 
            // tbLineSpace
            // 
            this.tbLineSpace.Location = new System.Drawing.Point(239, 341);
            this.tbLineSpace.Name = "tbLineSpace";
            this.tbLineSpace.Size = new System.Drawing.Size(83, 21);
            this.tbLineSpace.TabIndex = 44;
            this.tbLineSpace.Text = "0.5";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(174, 344);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 43;
            this.label13.Text = "行间距(mm)";
            // 
            // cbHatch
            // 
            this.cbHatch.AutoSize = true;
            this.cbHatch.Location = new System.Drawing.Point(83, 304);
            this.cbHatch.Name = "cbHatch";
            this.cbHatch.Size = new System.Drawing.Size(72, 16);
            this.cbHatch.TabIndex = 45;
            this.cbHatch.Text = "是否填充";
            this.cbHatch.UseVisualStyleBackColor = true;
            this.cbHatch.CheckedChanged += new System.EventHandler(this.cbHatch_CheckedChanged);
            // 
            // AddTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 411);
            this.Controls.Add(this.cbHatch);
            this.Controls.Add(this.tbLineSpace);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbCharSpace);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbHatchLayer);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbAlign);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbLayer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbRoTate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbModelID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPosY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPosX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.tbWidthRatio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbObjName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddTextForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Text";
            this.Load += new System.EventHandler(this.AddTextForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbObjName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWidthRatio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbModel;
        private System.Windows.Forms.TextBox tbPosY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPosX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbModelID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbLayer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbRoTate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbAlign;
        private System.Windows.Forms.TextBox tbCharSpace;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbHatchLayer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbLineSpace;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbHatch;
    }
}