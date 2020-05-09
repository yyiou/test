namespace HansAdvInterfaceCSharpTest
{
    partial class ImportVectorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbFillName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnGetFile = new System.Windows.Forms.Button();
            this.tbPosY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPosX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbObjName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRotate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbHatchLayer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFill = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open File";
            // 
            // tbFillName
            // 
            this.tbFillName.Location = new System.Drawing.Point(81, 51);
            this.tbFillName.Name = "tbFillName";
            this.tbFillName.Size = new System.Drawing.Size(228, 21);
            this.tbFillName.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(238, 233);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(53, 22);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnImport
            // 
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Location = new System.Drawing.Point(94, 233);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(53, 22);
            this.btnImport.TabIndex = 18;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnGetFile
            // 
            this.btnGetFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetFile.Location = new System.Drawing.Point(315, 51);
            this.btnGetFile.Name = "btnGetFile";
            this.btnGetFile.Size = new System.Drawing.Size(32, 21);
            this.btnGetFile.TabIndex = 24;
            this.btnGetFile.Text = "...";
            this.btnGetFile.UseVisualStyleBackColor = true;
            this.btnGetFile.Click += new System.EventHandler(this.btnGetFile_Click);
            // 
            // tbPosY
            // 
            this.tbPosY.Location = new System.Drawing.Point(294, 88);
            this.tbPosY.Name = "tbPosY";
            this.tbPosY.Size = new System.Drawing.Size(53, 21);
            this.tbPosY.TabIndex = 28;
            this.tbPosY.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "Y-coordinate(mm)";
            // 
            // tbPosX
            // 
            this.tbPosX.Location = new System.Drawing.Point(123, 88);
            this.tbPosX.Name = "tbPosX";
            this.tbPosX.Size = new System.Drawing.Size(53, 21);
            this.tbPosX.TabIndex = 26;
            this.tbPosX.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "X-coordinate(mm)";
            // 
            // tbObjName
            // 
            this.tbObjName.Location = new System.Drawing.Point(81, 14);
            this.tbObjName.Name = "tbObjName";
            this.tbObjName.Size = new System.Drawing.Size(83, 21);
            this.tbObjName.TabIndex = 30;
            this.tbObjName.Text = "vector1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 29;
            this.label6.Text = "Object";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(294, 125);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(53, 21);
            this.tbWidth.TabIndex = 35;
            this.tbWidth.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 34;
            this.label2.Text = "Width(mm)";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(123, 125);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(53, 21);
            this.tbHeight.TabIndex = 33;
            this.tbHeight.Text = "50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 32;
            this.label3.Text = "Height(mm)";
            // 
            // tbRotate
            // 
            this.tbRotate.Location = new System.Drawing.Point(235, 163);
            this.tbRotate.Name = "tbRotate";
            this.tbRotate.Size = new System.Drawing.Size(53, 21);
            this.tbRotate.TabIndex = 37;
            this.tbRotate.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 12);
            this.label8.TabIndex = 36;
            this.label8.Text = "Rotation Angle(degree)";
            // 
            // tbHatchLayer
            // 
            this.tbHatchLayer.Location = new System.Drawing.Point(294, 197);
            this.tbHatchLayer.Name = "tbHatchLayer";
            this.tbHatchLayer.Size = new System.Drawing.Size(53, 21);
            this.tbHatchLayer.TabIndex = 39;
            this.tbHatchLayer.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(211, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 38;
            this.label9.Text = "Filled Layer";
            // 
            // cbFill
            // 
            this.cbFill.AutoSize = true;
            this.cbFill.Location = new System.Drawing.Point(69, 197);
            this.cbFill.Name = "cbFill";
            this.cbFill.Size = new System.Drawing.Size(66, 16);
            this.cbFill.TabIndex = 40;
            this.cbFill.Text = "Filling";
            this.cbFill.UseVisualStyleBackColor = true;
            this.cbFill.CheckedChanged += new System.EventHandler(this.cbFill_CheckedChanged);
            // 
            // ImportVectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 267);
            this.Controls.Add(this.cbFill);
            this.Controls.Add(this.tbHatchLayer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbRotate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbObjName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPosY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPosX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGetFile);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.tbFillName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ImportVectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Vector Graphics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFillName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnGetFile;
        private System.Windows.Forms.TextBox tbPosY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPosX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbObjName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRotate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbHatchLayer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbFill;
    }
}