namespace HansAdvInterfaceCSharpTest
{
    partial class AddDotMatrixForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelPoint = new System.Windows.Forms.Button();
            this.btnModifyPoint = new System.Windows.Forms.Button();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.lsbPoint = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbObjName = new System.Windows.Forms.TextBox();
            this.tbPointNum = new System.Windows.Forms.TextBox();
            this.tbLayer = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelPoint);
            this.groupBox1.Controls.Add(this.btnModifyPoint);
            this.groupBox1.Controls.Add(this.btnAddPoint);
            this.groupBox1.Controls.Add(this.lsbPoint);
            this.groupBox1.Location = new System.Drawing.Point(25, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 123);
            this.groupBox1.TabIndex = 0;
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
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(200, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 22);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(69, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 22);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dot Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "Layer No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "Object";
            // 
            // tbObjName
            // 
            this.tbObjName.Location = new System.Drawing.Point(117, 8);
            this.tbObjName.Name = "tbObjName";
            this.tbObjName.Size = new System.Drawing.Size(83, 21);
            this.tbObjName.TabIndex = 15;
            // 
            // tbPointNum
            // 
            this.tbPointNum.Location = new System.Drawing.Point(89, 169);
            this.tbPointNum.Name = "tbPointNum";
            this.tbPointNum.ReadOnly = true;
            this.tbPointNum.Size = new System.Drawing.Size(55, 21);
            this.tbPointNum.TabIndex = 16;
            // 
            // tbLayer
            // 
            this.tbLayer.Location = new System.Drawing.Point(226, 169);
            this.tbLayer.Name = "tbLayer";
            this.tbLayer.Size = new System.Drawing.Size(55, 21);
            this.tbLayer.TabIndex = 17;
            // 
            // AddDotMatrixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 238);
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
            this.Name = "AddDotMatrixForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Dot Matrix";
            this.Load += new System.EventHandler(this.AddDotMatrixForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lsbPoint;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelPoint;
        private System.Windows.Forms.Button btnModifyPoint;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbObjName;
        private System.Windows.Forms.TextBox tbPointNum;
        private System.Windows.Forms.TextBox tbLayer;
    }
}