namespace WindowsFormsApp1
{
    partial class Login
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
            this.label_Title = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_PWD = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_PWD = new System.Windows.Forms.TextBox();
            this.button_MakeID = new System.Windows.Forms.Button();
            this.button_Login = new System.Windows.Forms.Button();
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.label_Account = new System.Windows.Forms.Label();
            this.button_EXIT = new System.Windows.Forms.Button();
            this.pictureBox_Title = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Title)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("휴먼옛체", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Title.Location = new System.Drawing.Point(113, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(267, 51);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "춘식이은행";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("휴먼옛체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_name.Location = new System.Drawing.Point(76, 161);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(100, 26);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "이    름";
            // 
            // label_PWD
            // 
            this.label_PWD.AutoSize = true;
            this.label_PWD.Font = new System.Drawing.Font("휴먼옛체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_PWD.Location = new System.Drawing.Point(71, 216);
            this.label_PWD.Name = "label_PWD";
            this.label_PWD.Size = new System.Drawing.Size(108, 26);
            this.label_PWD.TabIndex = 1;
            this.label_PWD.Text = "비밀번호";
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_name.Location = new System.Drawing.Point(282, 161);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(128, 35);
            this.textBox_name.TabIndex = 1;
            // 
            // textBox_PWD
            // 
            this.textBox_PWD.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_PWD.Location = new System.Drawing.Point(282, 216);
            this.textBox_PWD.Name = "textBox_PWD";
            this.textBox_PWD.PasswordChar = '●';
            this.textBox_PWD.Size = new System.Drawing.Size(128, 35);
            this.textBox_PWD.TabIndex = 2;
            // 
            // button_MakeID
            // 
            this.button_MakeID.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_MakeID.FlatAppearance.BorderSize = 4;
            this.button_MakeID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_MakeID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_MakeID.Font = new System.Drawing.Font("휴먼옛체", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_MakeID.Location = new System.Drawing.Point(109, 276);
            this.button_MakeID.Name = "button_MakeID";
            this.button_MakeID.Size = new System.Drawing.Size(114, 43);
            this.button_MakeID.TabIndex = 3;
            this.button_MakeID.Text = "회원가입";
            this.button_MakeID.UseVisualStyleBackColor = true;
            this.button_MakeID.Click += new System.EventHandler(this.button_MakeID_Click);
            // 
            // button_Login
            // 
            this.button_Login.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_Login.FlatAppearance.BorderSize = 4;
            this.button_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_Login.Font = new System.Drawing.Font("휴먼옛체", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Login.Location = new System.Drawing.Point(256, 276);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(114, 43);
            this.button_Login.TabIndex = 3;
            this.button_Login.Text = "로그인";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // textBox_Number
            // 
            this.textBox_Number.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Number.Location = new System.Drawing.Point(282, 105);
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(128, 29);
            this.textBox_Number.TabIndex = 0;
            // 
            // label_Account
            // 
            this.label_Account.AutoSize = true;
            this.label_Account.Font = new System.Drawing.Font("휴먼옛체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Account.Location = new System.Drawing.Point(71, 105);
            this.label_Account.Name = "label_Account";
            this.label_Account.Size = new System.Drawing.Size(108, 26);
            this.label_Account.TabIndex = 1;
            this.label_Account.Text = "전화번호";
            // 
            // button_EXIT
            // 
            this.button_EXIT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_EXIT.FlatAppearance.BorderSize = 3;
            this.button_EXIT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_EXIT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_EXIT.Font = new System.Drawing.Font("휴먼옛체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_EXIT.Location = new System.Drawing.Point(397, 383);
            this.button_EXIT.Name = "button_EXIT";
            this.button_EXIT.Size = new System.Drawing.Size(61, 29);
            this.button_EXIT.TabIndex = 4;
            this.button_EXIT.Text = "종료";
            this.button_EXIT.UseVisualStyleBackColor = true;
            this.button_EXIT.Click += new System.EventHandler(this.button_EXIT_Click);
            // 
            // pictureBox_Title
            // 
            this.pictureBox_Title.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Login;
            this.pictureBox_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Title.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Title.Name = "pictureBox_Title";
            this.pictureBox_Title.Size = new System.Drawing.Size(484, 424);
            this.pictureBox_Title.TabIndex = 0;
            this.pictureBox_Title.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 424);
            this.Controls.Add(this.button_EXIT);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.button_MakeID);
            this.Controls.Add(this.textBox_PWD);
            this.Controls.Add(this.textBox_Number);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_PWD);
            this.Controls.Add(this.label_Account);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.pictureBox_Title);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.Text = "로그인";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Title)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Title;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_PWD;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_PWD;
        private System.Windows.Forms.Button button_MakeID;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.TextBox textBox_Number;
        private System.Windows.Forms.Label label_Account;
        private System.Windows.Forms.Button button_EXIT;
    }
}

