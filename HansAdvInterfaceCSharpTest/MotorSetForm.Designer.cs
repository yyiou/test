namespace HansAdvInterfaceCSharpTest
{
    partial class MotorSetForm
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
            this.cbxAxiNo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdbModel = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb5 = new System.Windows.Forms.RadioButton();
            this.rdbType = new System.Windows.Forms.RadioButton();
            this.cbSoftO = new System.Windows.Forms.CheckBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnSetSoftO = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Axis No.";
            // 
            // cbxAxiNo
            // 
            this.cbxAxiNo.Enabled = false;
            this.cbxAxiNo.FormattingEnabled = true;
            this.cbxAxiNo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbxAxiNo.Location = new System.Drawing.Point(74, 17);
            this.cbxAxiNo.Name = "cbxAxiNo";
            this.cbxAxiNo.Size = new System.Drawing.Size(63, 20);
            this.cbxAxiNo.TabIndex = 1;
            this.cbxAxiNo.SelectedIndexChanged += new System.EventHandler(this.cbxAxiNo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Motion Distance";
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(241, 16);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(63, 21);
            this.tbValue.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb3);
            this.groupBox1.Controls.Add(this.rdb2);
            this.groupBox1.Controls.Add(this.rdbModel);
            this.groupBox1.Location = new System.Drawing.Point(15, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 162);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move Model";
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Location = new System.Drawing.Point(16, 73);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(167, 16);
            this.rdb3.TabIndex = 2;
            this.rdb3.Text = "Return to Machine Origin";
            this.rdb3.UseVisualStyleBackColor = true;
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(16, 48);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(113, 16);
            this.rdb2.TabIndex = 1;
            this.rdb2.Text = "Relative Motion";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // rdbModel
            // 
            this.rdbModel.AutoSize = true;
            this.rdbModel.Checked = true;
            this.rdbModel.Location = new System.Drawing.Point(16, 23);
            this.rdbModel.Name = "rdbModel";
            this.rdbModel.Size = new System.Drawing.Size(113, 16);
            this.rdbModel.TabIndex = 0;
            this.rdbModel.TabStop = true;
            this.rdbModel.Text = "Absolute Motion";
            this.rdbModel.UseVisualStyleBackColor = true;
            this.rdbModel.CheckedChanged += new System.EventHandler(this.rdbModel_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb5);
            this.groupBox2.Controls.Add(this.rdbType);
            this.groupBox2.Location = new System.Drawing.Point(231, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 99);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Motion Speed Type";
            // 
            // rdb5
            // 
            this.rdb5.AutoSize = true;
            this.rdb5.Location = new System.Drawing.Point(21, 48);
            this.rdb5.Name = "rdb5";
            this.rdb5.Size = new System.Drawing.Size(113, 16);
            this.rdb5.TabIndex = 2;
            this.rdb5.Text = "Absolute Motion";
            this.rdb5.UseVisualStyleBackColor = true;
            // 
            // rdbType
            // 
            this.rdbType.AutoSize = true;
            this.rdbType.Checked = true;
            this.rdbType.Location = new System.Drawing.Point(21, 23);
            this.rdbType.Name = "rdbType";
            this.rdbType.Size = new System.Drawing.Size(89, 16);
            this.rdbType.TabIndex = 1;
            this.rdbType.TabStop = true;
            this.rdbType.Text = "Idle Motion";
            this.rdbType.UseVisualStyleBackColor = true;
            // 
            // cbSoftO
            // 
            this.cbSoftO.Location = new System.Drawing.Point(231, 179);
            this.cbSoftO.Name = "cbSoftO";
            this.cbSoftO.Size = new System.Drawing.Size(144, 40);
            this.cbSoftO.TabIndex = 6;
            this.cbSoftO.Text = "Return to Software Origin When Motor Return to Zero";
            this.cbSoftO.UseVisualStyleBackColor = true;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(15, 240);
            this.tbNote.Name = "tbNote";
            this.tbNote.ReadOnly = true;
            this.tbNote.Size = new System.Drawing.Size(289, 21);
            this.tbNote.TabIndex = 7;
            // 
            // btnTest
            // 
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Location = new System.Drawing.Point(12, 282);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(129, 22);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "Motion Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnSetSoftO
            // 
            this.btnSetSoftO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetSoftO.Location = new System.Drawing.Point(209, 282);
            this.btnSetSoftO.Name = "btnSetSoftO";
            this.btnSetSoftO.Size = new System.Drawing.Size(166, 22);
            this.btnSetSoftO.TabIndex = 10;
            this.btnSetSoftO.Text = "Software Origin Settings";
            this.btnSetSoftO.UseVisualStyleBackColor = true;
            this.btnSetSoftO.Click += new System.EventHandler(this.btnSetSoftO_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(12, 319);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(167, 22);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Motor Return to Zero";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(262, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 22);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MotorSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 368);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSetSoftO);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.cbSoftO);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxAxiNo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MotorSetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Motor Motion Setting";
            this.Load += new System.EventHandler(this.MotorSetForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxAxiNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdbModel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb5;
        private System.Windows.Forms.RadioButton rdbType;
        private System.Windows.Forms.CheckBox cbSoftO;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnSetSoftO;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCancel;
    }
}