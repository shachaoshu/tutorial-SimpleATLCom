namespace SimpleATLcomTest1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chkFireEvent = new System.Windows.Forms.CheckBox();
            this.txtComMarks = new System.Windows.Forms.TextBox();
            this.txtATLMarks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.txtResultName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInvokeDLG = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.chkFireEvent);
            this.groupBox1.Controls.Add(this.txtComMarks);
            this.groupBox1.Controls.Add(this.txtATLMarks);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Values";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkFireEvent
            // 
            this.chkFireEvent.AutoSize = true;
            this.chkFireEvent.Location = new System.Drawing.Point(9, 99);
            this.chkFireEvent.Name = "chkFireEvent";
            this.chkFireEvent.Size = new System.Drawing.Size(84, 16);
            this.chkFireEvent.TabIndex = 6;
            this.chkFireEvent.Text = "Fire Event";
            this.chkFireEvent.UseVisualStyleBackColor = true;
            // 
            // txtComMarks
            // 
            this.txtComMarks.Location = new System.Drawing.Point(155, 64);
            this.txtComMarks.Name = "txtComMarks";
            this.txtComMarks.Size = new System.Drawing.Size(100, 21);
            this.txtComMarks.TabIndex = 5;
            this.txtComMarks.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtATLMarks
            // 
            this.txtATLMarks.Location = new System.Drawing.Point(9, 65);
            this.txtATLMarks.Name = "txtATLMarks";
            this.txtATLMarks.Size = new System.Drawing.Size(100, 21);
            this.txtATLMarks.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "COM Marks";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "ATL Marks";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(54, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 21);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMarks);
            this.groupBox2.Controls.Add(this.txtResultName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(93, 61);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.ReadOnly = true;
            this.txtMarks.Size = new System.Drawing.Size(160, 21);
            this.txtMarks.TabIndex = 3;
            // 
            // txtResultName
            // 
            this.txtResultName.Location = new System.Drawing.Point(93, 25);
            this.txtResultName.Name = "txtResultName";
            this.txtResultName.ReadOnly = true;
            this.txtResultName.Size = new System.Drawing.Size(160, 21);
            this.txtResultName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "Marks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // btnInvokeDLG
            // 
            this.btnInvokeDLG.Location = new System.Drawing.Point(13, 256);
            this.btnInvokeDLG.Name = "btnInvokeDLG";
            this.btnInvokeDLG.Size = new System.Drawing.Size(259, 23);
            this.btnInvokeDLG.TabIndex = 2;
            this.btnInvokeDLG.Text = "Invoke ATL Dialog";
            this.btnInvokeDLG.UseVisualStyleBackColor = true;
            this.btnInvokeDLG.Click += new System.EventHandler(this.btnInvokeDLG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 293);
            this.Controls.Add(this.btnInvokeDLG);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkFireEvent;
        private System.Windows.Forms.TextBox txtComMarks;
        private System.Windows.Forms.TextBox txtATLMarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.TextBox txtResultName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInvokeDLG;
    }
}

