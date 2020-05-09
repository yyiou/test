namespace HansAdvInterfaceCSharpTest
{
    partial class AddCurveForm
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
            this.tbLayer = new System.Windows.Forms.TextBox();
            this.tbPointNum = new System.Windows.Forms.TextBox();
            this.tbObjName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelPoint = new System.Windows.Forms.Button();
            this.btnModifyPoint = new System.Windows.Forms.Button();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.lsbPoint = new System.Windows.Forms.ListBox();
            this.cbHatch = new System.Windows.Forms.CheckBox();
            this.tbHatchLayer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLayer
            // 
            this.tbLayer.Location = new System.Drawing.Point(241, 172);
            this.tbLayer.Name = "tbLayer";
            this.tbLayer.Size = new System.Drawing.Size(55, 21);
            this.tbLayer.TabIndex = 26;
            this.tbLayer.Text = "0";
            // 
            // tbPointNum
            // 
            this.tbPointNum.Location = new System.Drawing.Point(91, 172);
            this.tbPointNum.Name = "tbPointNum";
            this.tbPointNum.ReadOnly = true;
            this.tbPointNum.Size = new System.Drawing.Size(55, 21);
            this.tbPointNum.TabIndex = 25;
            this.tbPointNum.Text = "0";
            // 
            // tbObjName
            // 
            this.tbObjName.Location = new System.Drawing.Point(119, 11);
            this.tbObjName.Name = "tbObjName";
            this.tbObjName.Size = new System.Drawing.Size(83, 21);
            this.tbObjName.TabIndex = 24;
            this.tbObjName.Text = "curve1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "Object";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "Used Layer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "Dot Count";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(202, 245);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 22);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(71, 245);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 22);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelPoint);
            this.groupBox1.Controls.Add(this.btnModifyPoint);
            this.groupBox1.Controls.Add(this.btnAddPoint);
            this.groupBox1.Controls.Add(this.lsbPoint);
            this.groupBox1.Location = new System.Drawing.Point(27, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 123);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dot Matrix";
            // 
            // btnDelPoint
            // 
            this.btnDelPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelPoint.Location = new System.Drawing.Point(191, 86);
            this.btnDelPoint.Name = "btnDelPoint";
            this.btnDelPoint.Size = new System.Drawing.Size(65, 22);
            this.btnDelPoint.TabIndex = 13;
            this.btnDelPoint.Text = "Delete";
            this.btnDelPoint.UseVisualStyleBackColor = true;
            this.btnDelPoint.Click += new System.EventHandler(this.btnDelPoint_Click);
            // 
            // btnModifyPoint
            // 
            this.btnModifyPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyPoint.Location = new System.Drawing.Point(191, 53);
            this.btnModifyPoint.Name = "btnModifyPoint";
            this.btnModifyPoint.Size = new System.Drawing.Size(65, 22);
            this.btnModifyPoint.TabIndex = 12;
            this.btnModifyPoint.Text = "Modify";
            this.btnModifyPoint.UseVisualStyleBackColor = true;
            this.btnModifyPoint.Click += new System.EventHandler(this.btnModifyPoint_Click);
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPoint.Location = new System.Drawing.Point(191, 20);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(65, 22);
            this.btnAddPoint.TabIndex = 11;
            this.btnAddPoint.Text = "Add";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // lsbPoint
            // 
            this.lsbPoint.FormattingEnabled = true;
            this.lsbPoint.ItemHeight = 12;
            this.lsbPoint.Location = new System.Drawing.Point(20, 20);
            this.lsbPoint.Name = "lsbPoint";
            this.lsbPoint.Size = new System.Drawing.Size(161, 88);
            this.lsbPoint.TabIndex = 0;
            // 
            // cbHatch
            // 
            this.cbHatch.AutoSize = true;
            this.cbHatch.Location = new System.Drawing.Point(91, 211);
            this.cbHatch.Name = "cbHatch";
            this.cbHatch.Size = new System.Drawing.Size(48, 16);
            this.cbHatch.TabIndex = 27;
            this.cbHatch.Text = "Fill";
            this.cbHatch.UseVisualStyleBackColor = true;
            this.cbHatch.CheckedChanged += new System.EventHandler(this.cbHatch_CheckedChanged);
            // 
            // tbHatchLayer
            // 
            this.tbHatchLayer.Enabled = false;
            this.tbHatchLayer.Location = new System.Drawing.Point(241, 213);
            this.tbHatchLayer.Name = "tbHatchLayer";
            this.tbHatchLayer.Size = new System.Drawing.Size(55, 21);
            this.tbHatchLayer.TabIndex = 29;
            this.tbHatchLayer.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "Filled Layer";
            // 
            // AddCurveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 283);
            this.Controls.Add(this.tbHatchLayer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbHatch);
            this.Controls.Add(this.tbLayer);
            this.Controls.Add(this.tbPointNum);
            this.Controls.Add(this.tbObjName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddCurveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Curve";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLayer;
        private System.Windows.Forms.TextBox tbPointNum;
        private System.Windows.Forms.TextBox tbObjName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelPoint;
        private System.Windows.Forms.Button btnModifyPoint;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.ListBox lsbPoint;
        private System.Windows.Forms.CheckBox cbHatch;
        private System.Windows.Forms.TextBox tbHatchLayer;
        private System.Windows.Forms.Label label4;
    }
}