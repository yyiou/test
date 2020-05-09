namespace HansAdvInterfaceCSharpTest
{
    partial class XYZPositionForm
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
            this.rdbXYZType = new System.Windows.Forms.RadioButton();
            this.rdbZType = new System.Windows.Forms.RadioButton();
            this.rdbXYType = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbZPos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbYPos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbXPos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbXYZType);
            this.groupBox1.Controls.Add(this.rdbZType);
            this.groupBox1.Controls.Add(this.rdbXYType);
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rdbXYZType
            // 
            this.rdbXYZType.AutoSize = true;
            this.rdbXYZType.Location = new System.Drawing.Point(14, 87);
            this.rdbXYZType.Name = "rdbXYZType";
            this.rdbXYZType.Size = new System.Drawing.Size(131, 16);
            this.rdbXYZType.TabIndex = 2;
            this.rdbXYZType.Text = "Move XYZ Meanwhile";
            this.rdbXYZType.UseVisualStyleBackColor = true;
            // 
            // rdbZType
            // 
            this.rdbZType.AutoSize = true;
            this.rdbZType.Location = new System.Drawing.Point(14, 55);
            this.rdbZType.Name = "rdbZType";
            this.rdbZType.Size = new System.Drawing.Size(89, 16);
            this.rdbZType.TabIndex = 1;
            this.rdbZType.Text = "Only Move Z";
            this.rdbZType.UseVisualStyleBackColor = true;
            // 
            // rdbXYType
            // 
            this.rdbXYType.AutoSize = true;
            this.rdbXYType.Checked = true;
            this.rdbXYType.Location = new System.Drawing.Point(14, 23);
            this.rdbXYType.Name = "rdbXYType";
            this.rdbXYType.Size = new System.Drawing.Size(95, 16);
            this.rdbXYType.TabIndex = 0;
            this.rdbXYType.TabStop = true;
            this.rdbXYType.Text = "Only Move XY";
            this.rdbXYType.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbZPos);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbYPos);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbXPos);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(169, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // tbZPos
            // 
            this.tbZPos.Location = new System.Drawing.Point(55, 85);
            this.tbZPos.Name = "tbZPos";
            this.tbZPos.Size = new System.Drawing.Size(49, 21);
            this.tbZPos.TabIndex = 5;
            this.tbZPos.Text = "0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Z-Pos";
            // 
            // tbYPos
            // 
            this.tbYPos.Location = new System.Drawing.Point(55, 53);
            this.tbYPos.Name = "tbYPos";
            this.tbYPos.Size = new System.Drawing.Size(49, 21);
            this.tbYPos.TabIndex = 3;
            this.tbYPos.Text = "0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y-Pos";
            // 
            // tbXPos
            // 
            this.tbXPos.Location = new System.Drawing.Point(55, 21);
            this.tbXPos.Name = "tbXPos";
            this.tbXPos.Size = new System.Drawing.Size(49, 21);
            this.tbXPos.TabIndex = 1;
            this.tbXPos.Text = "0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "X-Pos";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(201, 148);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 22);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSet
            // 
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Location = new System.Drawing.Point(51, 148);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(65, 22);
            this.btnSet.TabIndex = 12;
            this.btnSet.Text = "Confirm";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // XYZPositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 182);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "XYZPositionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "XYZ Position Setting";
            this.Load += new System.EventHandler(this.XYZPositionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbXYZType;
        private System.Windows.Forms.RadioButton rdbZType;
        private System.Windows.Forms.RadioButton rdbXYType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbXPos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbZPos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbYPos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSet;
    }
}