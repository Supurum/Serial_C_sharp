namespace Serial_C_sharp
{
    partial class communicate
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.get_textBox = new System.Windows.Forms.TextBox();
            this.send_textBox = new System.Windows.Forms.TextBox();
            this.vertical_ScrollBar = new System.Windows.Forms.VScrollBar();
            this.port_sel_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.baud_rate_sel_comboBox = new System.Windows.Forms.ComboBox();
            this.connect_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.disconnect_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.send_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // get_textBox
            // 
            this.get_textBox.Location = new System.Drawing.Point(14, 24);
            this.get_textBox.Multiline = true;
            this.get_textBox.Name = "get_textBox";
            this.get_textBox.ReadOnly = true;
            this.get_textBox.Size = new System.Drawing.Size(730, 380);
            this.get_textBox.TabIndex = 0;
            // 
            // send_textBox
            // 
            this.send_textBox.Location = new System.Drawing.Point(14, 422);
            this.send_textBox.Name = "send_textBox";
            this.send_textBox.Size = new System.Drawing.Size(670, 21);
            this.send_textBox.TabIndex = 1;
            // 
            // vertical_ScrollBar
            // 
            this.vertical_ScrollBar.Location = new System.Drawing.Point(748, 24);
            this.vertical_ScrollBar.Name = "vertical_ScrollBar";
            this.vertical_ScrollBar.Size = new System.Drawing.Size(17, 380);
            this.vertical_ScrollBar.TabIndex = 2;
            // 
            // port_sel_comboBox
            // 
            this.port_sel_comboBox.FormattingEnabled = true;
            this.port_sel_comboBox.Location = new System.Drawing.Point(851, 12);
            this.port_sel_comboBox.Name = "port_sel_comboBox";
            this.port_sel_comboBox.Size = new System.Drawing.Size(121, 20);
            this.port_sel_comboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(768, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port번호 선택";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(768, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "전송 속도";
            // 
            // baud_rate_sel_comboBox
            // 
            this.baud_rate_sel_comboBox.FormattingEnabled = true;
            this.baud_rate_sel_comboBox.Location = new System.Drawing.Point(851, 38);
            this.baud_rate_sel_comboBox.Name = "baud_rate_sel_comboBox";
            this.baud_rate_sel_comboBox.Size = new System.Drawing.Size(121, 20);
            this.baud_rate_sel_comboBox.TabIndex = 6;
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(3, 3);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(75, 23);
            this.connect_button.TabIndex = 7;
            this.connect_button.Text = "연결";
            this.connect_button.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.disconnect_button);
            this.panel1.Controls.Add(this.connect_button);
            this.panel1.Location = new System.Drawing.Point(812, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 30);
            this.panel1.TabIndex = 8;
            // 
            // disconnect_button
            // 
            this.disconnect_button.Location = new System.Drawing.Point(82, 3);
            this.disconnect_button.Name = "disconnect_button";
            this.disconnect_button.Size = new System.Drawing.Size(75, 23);
            this.disconnect_button.TabIndex = 8;
            this.disconnect_button.Text = "연결 끊기";
            this.disconnect_button.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "내용";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "전송";
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(690, 420);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(75, 23);
            this.send_button.TabIndex = 11;
            this.send_button.Text = "전송";
            this.send_button.UseVisualStyleBackColor = true;
            // 
            // communicate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.baud_rate_sel_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.port_sel_comboBox);
            this.Controls.Add(this.vertical_ScrollBar);
            this.Controls.Add(this.send_textBox);
            this.Controls.Add(this.get_textBox);
            this.Name = "communicate";
            this.Text = "시리얼 통신";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox get_textBox;
        private System.Windows.Forms.TextBox send_textBox;
        private System.Windows.Forms.VScrollBar vertical_ScrollBar;
        private System.Windows.Forms.ComboBox port_sel_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox baud_rate_sel_comboBox;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button disconnect_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button send_button;
    }
}

