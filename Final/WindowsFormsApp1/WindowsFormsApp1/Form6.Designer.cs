namespace WindowsFormsApp1
{
    partial class Form6
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_ChatRoom = new System.Windows.Forms.ListBox();
            this.textBox_ChatRoom = new System.Windows.Forms.TextBox();
            this.button_Quit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_ChatRoom
            // 
            this.listBox_ChatRoom.FormattingEnabled = true;
            this.listBox_ChatRoom.ItemHeight = 12;
            this.listBox_ChatRoom.Location = new System.Drawing.Point(27, 26);
            this.listBox_ChatRoom.Name = "listBox_ChatRoom";
            this.listBox_ChatRoom.Size = new System.Drawing.Size(594, 436);
            this.listBox_ChatRoom.TabIndex = 0;
            // 
            // textBox_ChatRoom
            // 
            this.textBox_ChatRoom.Location = new System.Drawing.Point(27, 481);
            this.textBox_ChatRoom.Name = "textBox_ChatRoom";
            this.textBox_ChatRoom.Size = new System.Drawing.Size(594, 21);
            this.textBox_ChatRoom.TabIndex = 1;
            this.textBox_ChatRoom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_ChatRoom_KeyDown);
            // 
            // button_Quit
            // 
            this.button_Quit.Location = new System.Drawing.Point(639, 481);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(141, 56);
            this.button_Quit.TabIndex = 2;
            this.button_Quit.Text = "나가기";
            this.button_Quit.UseVisualStyleBackColor = true;
            this.button_Quit.Click += new System.EventHandler(this.button_Quit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.KakaoTalk_20230214_172014510;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(627, 343);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 132);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(792, 549);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Quit);
            this.Controls.Add(this.textBox_ChatRoom);
            this.Controls.Add(this.listBox_ChatRoom);
            this.Name = "Form6";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_ChatRoom;
        private System.Windows.Forms.TextBox textBox_ChatRoom;
        private System.Windows.Forms.Button button_Quit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

