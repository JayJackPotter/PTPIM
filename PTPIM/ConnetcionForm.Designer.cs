namespace PTPIM
{
    partial class ConnetcionForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.logBox = new System.Windows.Forms.ListBox();
            this.IP1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.IP2 = new System.Windows.Forms.TextBox();
            this.IP3 = new System.Windows.Forms.TextBox();
            this.IP4 = new System.Windows.Forms.TextBox();
            this.point1 = new System.Windows.Forms.Label();
            this.point2 = new System.Windows.Forms.Label();
            this.point3 = new System.Windows.Forms.Label();
            this.nickname_textbox = new System.Windows.Forms.Label();
            this.nickname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // logBox
            // 
            this.logBox.FormattingEnabled = true;
            this.logBox.Location = new System.Drawing.Point(9, 10);
            this.logBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(301, 108);
            this.logBox.TabIndex = 0;
            // 
            // IP1
            // 
            this.IP1.Location = new System.Drawing.Point(74, 183);
            this.IP1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.IP1.MaxLength = 3;
            this.IP1.Name = "IP1";
            this.IP1.Size = new System.Drawing.Size(26, 20);
            this.IP1.TabIndex = 1;
            this.IP1.Text = "255";
            this.IP1.TextChanged += new System.EventHandler(this.IP1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Target IP";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(74, 284);
            this.connectButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(160, 54);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Connect!";
            this.connectButton.UseVisualStyleBackColor = true;
            // 
            // IP2
            // 
            this.IP2.Location = new System.Drawing.Point(118, 183);
            this.IP2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.IP2.Name = "IP2";
            this.IP2.Size = new System.Drawing.Size(26, 20);
            this.IP2.TabIndex = 1;
            this.IP2.Text = "255";
            this.IP2.TextChanged += new System.EventHandler(this.IP2_TextChanged);
            // 
            // IP3
            // 
            this.IP3.Location = new System.Drawing.Point(162, 183);
            this.IP3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.IP3.Name = "IP3";
            this.IP3.Size = new System.Drawing.Size(26, 20);
            this.IP3.TabIndex = 1;
            this.IP3.Text = "255";
            this.IP3.TextChanged += new System.EventHandler(this.IP3_TextChanged);
            // 
            // IP4
            // 
            this.IP4.Location = new System.Drawing.Point(206, 183);
            this.IP4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.IP4.Name = "IP4";
            this.IP4.Size = new System.Drawing.Size(26, 20);
            this.IP4.TabIndex = 1;
            this.IP4.Text = "255";
            this.IP4.TextChanged += new System.EventHandler(this.IP4_TextChanged);
            // 
            // point1
            // 
            this.point1.AutoSize = true;
            this.point1.Location = new System.Drawing.Point(100, 186);
            this.point1.Name = "point1";
            this.point1.Size = new System.Drawing.Size(10, 13);
            this.point1.TabIndex = 4;
            this.point1.Text = ".";
            this.point1.Click += new System.EventHandler(this.point1_Click);
            // 
            // point2
            // 
            this.point2.AutoSize = true;
            this.point2.Location = new System.Drawing.Point(147, 186);
            this.point2.Name = "point2";
            this.point2.Size = new System.Drawing.Size(10, 13);
            this.point2.TabIndex = 4;
            this.point2.Text = ".";
            this.point2.Click += new System.EventHandler(this.point2_Click);
            // 
            // point3
            // 
            this.point3.AutoSize = true;
            this.point3.Location = new System.Drawing.Point(191, 186);
            this.point3.Name = "point3";
            this.point3.Size = new System.Drawing.Size(10, 13);
            this.point3.TabIndex = 4;
            this.point3.Text = ".";
            // 
            // nickname_textbox
            // 
            this.nickname_textbox.AutoSize = true;
            this.nickname_textbox.Location = new System.Drawing.Point(132, 222);
            this.nickname_textbox.Name = "nickname_textbox";
            this.nickname_textbox.Size = new System.Drawing.Size(55, 13);
            this.nickname_textbox.TabIndex = 5;
            this.nickname_textbox.Text = "Nickname";
            // 
            // nickname
            // 
            this.nickname.Location = new System.Drawing.Point(68, 244);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(183, 20);
            this.nickname.TabIndex = 6;
            this.nickname.TextChanged += new System.EventHandler(this.nickname_TextChanged);
            // 
            // ConnetcionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 373);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.nickname_textbox);
            this.Controls.Add(this.point3);
            this.Controls.Add(this.point2);
            this.Controls.Add(this.point1);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IP4);
            this.Controls.Add(this.IP3);
            this.Controls.Add(this.IP2);
            this.Controls.Add(this.IP1);
            this.Controls.Add(this.logBox);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ConnetcionForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox logBox;
        private System.Windows.Forms.TextBox IP1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox IP2;
        private System.Windows.Forms.TextBox IP3;
        private System.Windows.Forms.TextBox IP4;
        private System.Windows.Forms.Label point1;
        private System.Windows.Forms.Label point2;
        private System.Windows.Forms.Label point3;
        private System.Windows.Forms.Label nickname_textbox;
        private System.Windows.Forms.TextBox nickname;
    }
}

