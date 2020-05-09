namespace HansAdvInterfaceCSharpTest
{
    partial class IOControlForm
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
            this.btnReadInPort = new System.Windows.Forms.Button();
            this.btnWriteOutPort = new System.Windows.Forms.Button();
            this.btnQueryTouch = new System.Windows.Forms.Button();
            this.tbInPort = new System.Windows.Forms.TextBox();
            this.tbOutPort = new System.Windows.Forms.TextBox();
            this.cbTouchRePort = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReadInPort
            // 
            this.btnReadInPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadInPort.Location = new System.Drawing.Point(6, 19);
            this.btnReadInPort.Name = "btnReadInPort";
            this.btnReadInPort.Size = new System.Drawing.Size(92, 22);
            this.btnReadInPort.TabIndex = 10;
            this.btnReadInPort.Text = "Read Input Port";
            this.btnReadInPort.UseVisualStyleBackColor = true;
            this.btnReadInPort.Click += new System.EventHandler(this.btnReadInPort_Click);
            // 
            // btnWriteOutPort
            // 
            this.btnWriteOutPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWriteOutPort.Location = new System.Drawing.Point(6, 56);
            this.btnWriteOutPort.Name = "btnWriteOutPort";
            this.btnWriteOutPort.Size = new System.Drawing.Size(92, 22);
            this.btnWriteOutPort.TabIndex = 11;
            this.btnWriteOutPort.Text = "Write Output";
            this.btnWriteOutPort.UseVisualStyleBackColor = true;
            this.btnWriteOutPort.Click += new System.EventHandler(this.btnWriteOutPort_Click);
            // 
            // btnQueryTouch
            // 
            this.btnQueryTouch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQueryTouch.Location = new System.Drawing.Point(6, 93);
            this.btnQueryTouch.Name = "btnQueryTouch";
            this.btnQueryTouch.Size = new System.Drawing.Size(92, 22);
            this.btnQueryTouch.TabIndex = 12;
            this.btnQueryTouch.Text = "Pedal Query";
            this.btnQueryTouch.UseVisualStyleBackColor = true;
            this.btnQueryTouch.Click += new System.EventHandler(this.btnQueryTouch_Click);
            // 
            // tbInPort
            // 
            this.tbInPort.Location = new System.Drawing.Point(113, 20);
            this.tbInPort.Name = "tbInPort";
            this.tbInPort.ReadOnly = true;
            this.tbInPort.Size = new System.Drawing.Size(112, 21);
            this.tbInPort.TabIndex = 13;
            // 
            // tbOutPort
            // 
            this.tbOutPort.Location = new System.Drawing.Point(113, 57);
            this.tbOutPort.Name = "tbOutPort";
            this.tbOutPort.Size = new System.Drawing.Size(112, 21);
            this.tbOutPort.TabIndex = 14;
            // 
            // cbTouchRePort
            // 
            this.cbTouchRePort.AutoSize = true;
            this.cbTouchRePort.Location = new System.Drawing.Point(113, 96);
            this.cbTouchRePort.Name = "cbTouchRePort";
            this.cbTouchRePort.Size = new System.Drawing.Size(198, 16);
            this.cbTouchRePort.TabIndex = 15;
            this.cbTouchRePort.Text = "Report Real-time Pedal Signal";
            this.cbTouchRePort.UseVisualStyleBackColor = true;
            this.cbTouchRePort.CheckedChanged += new System.EventHandler(this.cbTouchRePort_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReadInPort);
            this.groupBox1.Controls.Add(this.cbTouchRePort);
            this.groupBox1.Controls.Add(this.btnWriteOutPort);
            this.groupBox1.Controls.Add(this.tbOutPort);
            this.groupBox1.Controls.Add(this.btnQueryTouch);
            this.groupBox1.Controls.Add(this.tbInPort);
            this.groupBox1.Location = new System.Drawing.Point(20, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 124);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operation on IO Port";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(234, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 22);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSet
            // 
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Location = new System.Drawing.Point(53, 178);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(65, 22);
            this.btnSet.TabIndex = 17;
            this.btnSet.Text = "Confirm";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(20, 12);
            this.tbNote.Name = "tbNote";
            this.tbNote.ReadOnly = true;
            this.tbNote.Size = new System.Drawing.Size(246, 21);
            this.tbNote.TabIndex = 19;
            // 
            // IOControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 217);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "IOControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IO Operation";
            this.Load += new System.EventHandler(this.IOControlForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadInPort;
        private System.Windows.Forms.Button btnWriteOutPort;
        private System.Windows.Forms.Button btnQueryTouch;
        private System.Windows.Forms.TextBox tbInPort;
        private System.Windows.Forms.TextBox tbOutPort;
        private System.Windows.Forms.CheckBox cbTouchRePort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox tbNote;
    }
}