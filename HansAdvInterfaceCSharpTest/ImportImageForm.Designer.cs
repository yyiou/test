namespace HansAdvInterfaceCSharpTest
{
    partial class ImportImageForm
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
            this.cbReciProcate = new System.Windows.Forms.CheckBox();
            this.tbRePairDot = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbRotate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbObjName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPosY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPosX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGetFile = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.tbFillName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rdbType1 = new System.Windows.Forms.RadioButton();
            this.rdbType2 = new System.Windows.Forms.RadioButton();
            this.tbAccDot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDotDistY = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbDotDistX = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbReciProcate
            // 
            this.cbReciProcate.AutoSize = true;
            this.cbReciProcate.Location = new System.Drawing.Point(34, 313);
            this.cbReciProcate.Name = "cbReciProcate";
            this.cbReciProcate.Size = new System.Drawing.Size(156, 16);
            this.cbReciProcate.TabIndex = 60;
            this.cbReciProcate.Text = "Reciprocating Scanning";
            this.cbReciProcate.UseVisualStyleBackColor = true;
            this.cbReciProcate.CheckedChanged += new System.EventHandler(this.cbReciProcate_CheckedChanged);
            // 
            // tbRePairDot
            // 
            this.tbRePairDot.Location = new System.Drawing.Point(261, 329);
            this.tbRePairDot.Name = "tbRePairDot";
            this.tbRePairDot.Size = new System.Drawing.Size(53, 21);
            this.tbRePairDot.TabIndex = 59;
            this.tbRePairDot.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 12);
            this.label9.TabIndex = 58;
            this.label9.Text = "Compensation Point Count";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // tbRotate
            // 
            this.tbRotate.Location = new System.Drawing.Point(175, 161);
            this.tbRotate.Name = "tbRotate";
            this.tbRotate.Size = new System.Drawing.Size(53, 21);
            this.tbRotate.TabIndex = 57;
            this.tbRotate.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 12);
            this.label8.TabIndex = 56;
            this.label8.Text = "Rotation Angle(degree)";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(271, 123);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(53, 21);
            this.tbWidth.TabIndex = 55;
            this.tbWidth.Text = "80";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 54;
            this.label2.Text = "Width(mm)";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(111, 123);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(53, 21);
            this.tbHeight.TabIndex = 53;
            this.tbHeight.Text = "80";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 52;
            this.label3.Text = "Height(mm)";
            // 
            // tbObjName
            // 
            this.tbObjName.Location = new System.Drawing.Point(64, 12);
            this.tbObjName.Name = "tbObjName";
            this.tbObjName.Size = new System.Drawing.Size(83, 21);
            this.tbObjName.TabIndex = 51;
            this.tbObjName.Text = "image1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 50;
            this.label6.Text = "Object";
            // 
            // tbPosY
            // 
            this.tbPosY.Location = new System.Drawing.Point(271, 86);
            this.tbPosY.Name = "tbPosY";
            this.tbPosY.Size = new System.Drawing.Size(53, 21);
            this.tbPosY.TabIndex = 49;
            this.tbPosY.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 48;
            this.label4.Text = "Y-coordinate(mm)";
            // 
            // tbPosX
            // 
            this.tbPosX.Location = new System.Drawing.Point(111, 86);
            this.tbPosX.Name = "tbPosX";
            this.tbPosX.Size = new System.Drawing.Size(53, 21);
            this.tbPosX.TabIndex = 47;
            this.tbPosX.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 46;
            this.label5.Text = "X-coordinate(mm)";
            // 
            // btnGetFile
            // 
            this.btnGetFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetFile.Location = new System.Drawing.Point(292, 49);
            this.btnGetFile.Name = "btnGetFile";
            this.btnGetFile.Size = new System.Drawing.Size(32, 21);
            this.btnGetFile.TabIndex = 45;
            this.btnGetFile.Text = "...";
            this.btnGetFile.UseVisualStyleBackColor = true;
            this.btnGetFile.Click += new System.EventHandler(this.btnGetFile_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(218, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(53, 22);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnImport
            // 
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Location = new System.Drawing.Point(76, 366);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(53, 22);
            this.btnImport.TabIndex = 43;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // tbFillName
            // 
            this.tbFillName.Location = new System.Drawing.Point(64, 49);
            this.tbFillName.Name = "tbFillName";
            this.tbFillName.Size = new System.Drawing.Size(217, 21);
            this.tbFillName.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 41;
            this.label1.Text = "Open File";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 61;
            this.label10.Text = "Marking Type";
            // 
            // rdbType1
            // 
            this.rdbType1.AutoSize = true;
            this.rdbType1.Checked = true;
            this.rdbType1.Location = new System.Drawing.Point(111, 197);
            this.rdbType1.Name = "rdbType1";
            this.rdbType1.Size = new System.Drawing.Size(89, 16);
            this.rdbType1.TabIndex = 62;
            this.rdbType1.TabStop = true;
            this.rdbType1.Text = "Gray Bitmap";
            this.rdbType1.UseVisualStyleBackColor = true;
            this.rdbType1.CheckedChanged += new System.EventHandler(this.rdbType1_CheckedChanged);
            // 
            // rdbType2
            // 
            this.rdbType2.AutoSize = true;
            this.rdbType2.Location = new System.Drawing.Point(198, 197);
            this.rdbType2.Name = "rdbType2";
            this.rdbType2.Size = new System.Drawing.Size(125, 16);
            this.rdbType2.TabIndex = 63;
            this.rdbType2.Text = "Two-valued Bitmap";
            this.rdbType2.UseVisualStyleBackColor = true;
            this.rdbType2.CheckedChanged += new System.EventHandler(this.rdbType1_CheckedChanged);
            // 
            // tbAccDot
            // 
            this.tbAccDot.Location = new System.Drawing.Point(175, 267);
            this.tbAccDot.Name = "tbAccDot";
            this.tbAccDot.Size = new System.Drawing.Size(53, 21);
            this.tbAccDot.TabIndex = 69;
            this.tbAccDot.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 12);
            this.label7.TabIndex = 68;
            this.label7.Text = "Acceleration Point Count";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tbDotDistY
            // 
            this.tbDotDistY.Location = new System.Drawing.Point(271, 229);
            this.tbDotDistY.Name = "tbDotDistY";
            this.tbDotDistY.Size = new System.Drawing.Size(53, 21);
            this.tbDotDistY.TabIndex = 67;
            this.tbDotDistY.Text = "0.05";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(188, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 66;
            this.label11.Text = "Dot Pitch(Y)";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // tbDotDistX
            // 
            this.tbDotDistX.Location = new System.Drawing.Point(111, 229);
            this.tbDotDistX.Name = "tbDotDistX";
            this.tbDotDistX.Size = new System.Drawing.Size(53, 21);
            this.tbDotDistX.TabIndex = 65;
            this.tbDotDistX.Text = "0.05";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 64;
            this.label12.Text = "Dot Pitch(X)";
            // 
            // ImportImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 400);
            this.Controls.Add(this.tbAccDot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbDotDistY);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbDotDistX);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rdbType2);
            this.Controls.Add(this.rdbType1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbReciProcate);
            this.Controls.Add(this.tbRePairDot);
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
            this.Name = "ImportImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Bitmap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbReciProcate;
        private System.Windows.Forms.TextBox tbRePairDot;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbRotate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbObjName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPosY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPosX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGetFile;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox tbFillName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdbType1;
        private System.Windows.Forms.RadioButton rdbType2;
        private System.Windows.Forms.TextBox tbAccDot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDotDistY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbDotDistX;
        private System.Windows.Forms.Label label12;
    }
}