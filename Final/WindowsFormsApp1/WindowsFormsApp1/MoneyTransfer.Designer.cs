namespace _transfer_
{
    partial class MoneyTransfer
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
            this.label_ReAccount = new System.Windows.Forms.Label();
            this.label_MyPassWD = new System.Windows.Forms.Label();
            this.label_Tmoney = new System.Windows.Forms.Label();
            this.textBox_MyPassWD = new System.Windows.Forms.TextBox();
            this.textBox_Tmoney = new System.Windows.Forms.TextBox();
            this.textBox_ReAccount = new System.Windows.Forms.TextBox();
            this.button_TF = new System.Windows.Forms.Button();
            this.textBox_balance = new System.Windows.Forms.TextBox();
            this.label_balance = new System.Windows.Forms.Label();
            this.button_EXIT = new System.Windows.Forms.Button();
            this.listBox_TF = new System.Windows.Forms.ListBox();
            this.button_TFFavList = new System.Windows.Forms.Button();
            this.button_TFHistory = new System.Windows.Forms.Button();
            this.button_TFSetFav = new System.Windows.Forms.Button();
            this.pictureBox_Transfer = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Transfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Title.Location = new System.Drawing.Point(160, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(240, 73);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "계좌이체";
            // 
            // label_ReAccount
            // 
            this.label_ReAccount.AutoSize = true;
            this.label_ReAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_ReAccount.Location = new System.Drawing.Point(210, 241);
            this.label_ReAccount.Name = "label_ReAccount";
            this.label_ReAccount.Size = new System.Drawing.Size(92, 25);
            this.label_ReAccount.TabIndex = 2;
            this.label_ReAccount.Text = "수취인계좌";
            // 
            // label_MyPassWD
            // 
            this.label_MyPassWD.AutoSize = true;
            this.label_MyPassWD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_MyPassWD.Location = new System.Drawing.Point(225, 164);
            this.label_MyPassWD.Name = "label_MyPassWD";
            this.label_MyPassWD.Size = new System.Drawing.Size(76, 25);
            this.label_MyPassWD.TabIndex = 2;
            this.label_MyPassWD.Text = "비밀번호";
            // 
            // label_Tmoney
            // 
            this.label_Tmoney.AutoSize = true;
            this.label_Tmoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Tmoney.Location = new System.Drawing.Point(204, 200);
            this.label_Tmoney.Name = "label_Tmoney";
            this.label_Tmoney.Size = new System.Drawing.Size(98, 25);
            this.label_Tmoney.TabIndex = 2;
            this.label_Tmoney.Text = "입금할 금액";
            // 
            // textBox_MyPassWD
            // 
            this.textBox_MyPassWD.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_MyPassWD.Location = new System.Drawing.Point(335, 160);
            this.textBox_MyPassWD.Name = "textBox_MyPassWD";
            this.textBox_MyPassWD.PasswordChar = '●';
            this.textBox_MyPassWD.Size = new System.Drawing.Size(100, 26);
            this.textBox_MyPassWD.TabIndex = 0;
            // 
            // textBox_Tmoney
            // 
            this.textBox_Tmoney.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Tmoney.Location = new System.Drawing.Point(335, 199);
            this.textBox_Tmoney.Name = "textBox_Tmoney";
            this.textBox_Tmoney.Size = new System.Drawing.Size(100, 26);
            this.textBox_Tmoney.TabIndex = 2;
            this.textBox_Tmoney.TextChanged += new System.EventHandler(this.textBox_Tmoney_TextChanged);
            // 
            // textBox_ReAccount
            // 
            this.textBox_ReAccount.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_ReAccount.Location = new System.Drawing.Point(335, 240);
            this.textBox_ReAccount.Name = "textBox_ReAccount";
            this.textBox_ReAccount.Size = new System.Drawing.Size(100, 26);
            this.textBox_ReAccount.TabIndex = 1;
            // 
            // button_TF
            // 
            this.button_TF.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_TF.FlatAppearance.BorderSize = 4;
            this.button_TF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_TF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_TF.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_TF.Location = new System.Drawing.Point(235, 433);
            this.button_TF.Name = "button_TF";
            this.button_TF.Size = new System.Drawing.Size(198, 69);
            this.button_TF.TabIndex = 4;
            this.button_TF.Text = "이체하기";
            this.button_TF.UseVisualStyleBackColor = true;
            this.button_TF.Click += new System.EventHandler(this.button_TF_Click);
            // 
            // textBox_balance
            // 
            this.textBox_balance.Location = new System.Drawing.Point(335, 124);
            this.textBox_balance.Name = "textBox_balance";
            this.textBox_balance.Size = new System.Drawing.Size(100, 21);
            this.textBox_balance.TabIndex = 5;
            this.textBox_balance.TextChanged += new System.EventHandler(this.textBox_balance_TextChanged);
            // 
            // label_balance
            // 
            this.label_balance.AutoSize = true;
            this.label_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_balance.Location = new System.Drawing.Point(257, 124);
            this.label_balance.Name = "label_balance";
            this.label_balance.Size = new System.Drawing.Size(44, 25);
            this.label_balance.TabIndex = 6;
            this.label_balance.Text = "잔액";
            // 
            // button_EXIT
            // 
            this.button_EXIT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_EXIT.FlatAppearance.BorderSize = 4;
            this.button_EXIT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_EXIT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_EXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_EXIT.Location = new System.Drawing.Point(475, 504);
            this.button_EXIT.Name = "button_EXIT";
            this.button_EXIT.Size = new System.Drawing.Size(75, 32);
            this.button_EXIT.TabIndex = 7;
            this.button_EXIT.Text = "나가기";
            this.button_EXIT.UseVisualStyleBackColor = true;
            this.button_EXIT.Click += new System.EventHandler(this.button_EXIT_Click);
            // 
            // listBox_TF
            // 
            this.listBox_TF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox_TF.FormattingEnabled = true;
            this.listBox_TF.ItemHeight = 16;
            this.listBox_TF.Location = new System.Drawing.Point(204, 299);
            this.listBox_TF.Name = "listBox_TF";
            this.listBox_TF.Size = new System.Drawing.Size(231, 84);
            this.listBox_TF.TabIndex = 8;
            // 
            // button_TFFavList
            // 
            this.button_TFFavList.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_TFFavList.FlatAppearance.BorderSize = 4;
            this.button_TFFavList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_TFFavList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_TFFavList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_TFFavList.Location = new System.Drawing.Point(450, 299);
            this.button_TFFavList.Name = "button_TFFavList";
            this.button_TFFavList.Size = new System.Drawing.Size(75, 23);
            this.button_TFFavList.TabIndex = 9;
            this.button_TFFavList.Text = "즐겨찾기";
            this.button_TFFavList.UseVisualStyleBackColor = true;
            this.button_TFFavList.Click += new System.EventHandler(this.button_TFFavList_Click);
            // 
            // button_TFHistory
            // 
            this.button_TFHistory.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_TFHistory.FlatAppearance.BorderSize = 4;
            this.button_TFHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_TFHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_TFHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_TFHistory.Location = new System.Drawing.Point(450, 360);
            this.button_TFHistory.Name = "button_TFHistory";
            this.button_TFHistory.Size = new System.Drawing.Size(75, 23);
            this.button_TFHistory.TabIndex = 9;
            this.button_TFHistory.Text = "거래내역";
            this.button_TFHistory.UseVisualStyleBackColor = true;
            this.button_TFHistory.Click += new System.EventHandler(this.button_TFHistory_Click);
            // 
            // button_TFSetFav
            // 
            this.button_TFSetFav.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_TFSetFav.FlatAppearance.BorderSize = 4;
            this.button_TFSetFav.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_TFSetFav.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_TFSetFav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_TFSetFav.Location = new System.Drawing.Point(450, 328);
            this.button_TFSetFav.Name = "button_TFSetFav";
            this.button_TFSetFav.Size = new System.Drawing.Size(100, 23);
            this.button_TFSetFav.TabIndex = 10;
            this.button_TFSetFav.Text = "즐겨찾기 설정";
            this.button_TFSetFav.UseVisualStyleBackColor = true;
            this.button_TFSetFav.Click += new System.EventHandler(this.button_TFSetFav_Click);
            // 
            // pictureBox_Transfer
            // 
            this.pictureBox_Transfer.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.transferback;
            this.pictureBox_Transfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Transfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Transfer.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Transfer.Name = "pictureBox_Transfer";
            this.pictureBox_Transfer.Size = new System.Drawing.Size(603, 548);
            this.pictureBox_Transfer.TabIndex = 0;
            this.pictureBox_Transfer.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.transferImage;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 302);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // MoneyTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 548);
            this.Controls.Add(this.listBox_TF);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_TFSetFav);
            this.Controls.Add(this.button_TFHistory);
            this.Controls.Add(this.button_TFFavList);
            this.Controls.Add(this.button_EXIT);
            this.Controls.Add(this.label_balance);
            this.Controls.Add(this.textBox_balance);
            this.Controls.Add(this.button_TF);
            this.Controls.Add(this.textBox_ReAccount);
            this.Controls.Add(this.textBox_Tmoney);
            this.Controls.Add(this.textBox_MyPassWD);
            this.Controls.Add(this.label_ReAccount);
            this.Controls.Add(this.label_Tmoney);
            this.Controls.Add(this.label_MyPassWD);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.pictureBox_Transfer);
            this.Name = "MoneyTransfer";
            this.Text = "계좌이체";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Transfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Transfer;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_ReAccount;
        private System.Windows.Forms.Label label_MyPassWD;
        private System.Windows.Forms.Label label_Tmoney;
        private System.Windows.Forms.TextBox textBox_MyPassWD;
        private System.Windows.Forms.TextBox textBox_Tmoney;
        private System.Windows.Forms.TextBox textBox_ReAccount;
        private System.Windows.Forms.Button button_TF;
        private System.Windows.Forms.TextBox textBox_balance;
        private System.Windows.Forms.Label label_balance;
        private System.Windows.Forms.Button button_EXIT;
        private System.Windows.Forms.ListBox listBox_TF;
        private System.Windows.Forms.Button button_TFFavList;
        private System.Windows.Forms.Button button_TFHistory;
        private System.Windows.Forms.Button button_TFSetFav;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

