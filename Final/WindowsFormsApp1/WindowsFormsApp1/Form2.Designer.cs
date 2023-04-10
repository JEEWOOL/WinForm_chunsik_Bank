namespace WindowsFormsApp1
{
    partial class Membership
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
            this.label_Makename = new System.Windows.Forms.Label();
            this.label_MakePWD = new System.Windows.Forms.Label();
            this.label_MAKEIDPWD = new System.Windows.Forms.Label();
            this.textBox_MakeName = new System.Windows.Forms.TextBox();
            this.textBox_MakePWD = new System.Windows.Forms.TextBox();
            this.button_MakeComplete = new System.Windows.Forms.Button();
            this.label_MakeAccount = new System.Windows.Forms.Label();
            this.textBox_MakeAccount = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Makename
            // 
            this.label_Makename.AutoSize = true;
            this.label_Makename.Font = new System.Drawing.Font("휴먼옛체", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Makename.Location = new System.Drawing.Point(20, 210);
            this.label_Makename.Name = "label_Makename";
            this.label_Makename.Size = new System.Drawing.Size(52, 22);
            this.label_Makename.TabIndex = 1;
            this.label_Makename.Text = "이름";
            // 
            // label_MakePWD
            // 
            this.label_MakePWD.AutoSize = true;
            this.label_MakePWD.Font = new System.Drawing.Font("휴먼옛체", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_MakePWD.Location = new System.Drawing.Point(20, 263);
            this.label_MakePWD.Name = "label_MakePWD";
            this.label_MakePWD.Size = new System.Drawing.Size(94, 22);
            this.label_MakePWD.TabIndex = 1;
            this.label_MakePWD.Text = "비밀번호";
            // 
            // label_MAKEIDPWD
            // 
            this.label_MAKEIDPWD.AutoSize = true;
            this.label_MAKEIDPWD.Font = new System.Drawing.Font("휴먼옛체", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_MAKEIDPWD.Location = new System.Drawing.Point(27, 80);
            this.label_MAKEIDPWD.Name = "label_MAKEIDPWD";
            this.label_MAKEIDPWD.Size = new System.Drawing.Size(218, 51);
            this.label_MAKEIDPWD.TabIndex = 1;
            this.label_MAKEIDPWD.Text = "회원가입";
            // 
            // textBox_MakeName
            // 
            this.textBox_MakeName.Font = new System.Drawing.Font("굴림", 18F);
            this.textBox_MakeName.Location = new System.Drawing.Point(141, 210);
            this.textBox_MakeName.Name = "textBox_MakeName";
            this.textBox_MakeName.Size = new System.Drawing.Size(120, 35);
            this.textBox_MakeName.TabIndex = 1;
            // 
            // textBox_MakePWD
            // 
            this.textBox_MakePWD.Font = new System.Drawing.Font("굴림", 18F);
            this.textBox_MakePWD.Location = new System.Drawing.Point(141, 254);
            this.textBox_MakePWD.Name = "textBox_MakePWD";
            this.textBox_MakePWD.PasswordChar = '●';
            this.textBox_MakePWD.Size = new System.Drawing.Size(120, 35);
            this.textBox_MakePWD.TabIndex = 2;
            // 
            // button_MakeComplete
            // 
            this.button_MakeComplete.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_MakeComplete.FlatAppearance.BorderSize = 4;
            this.button_MakeComplete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_MakeComplete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_MakeComplete.Font = new System.Drawing.Font("휴먼옛체", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_MakeComplete.Location = new System.Drawing.Point(55, 314);
            this.button_MakeComplete.Name = "button_MakeComplete";
            this.button_MakeComplete.Size = new System.Drawing.Size(162, 43);
            this.button_MakeComplete.TabIndex = 3;
            this.button_MakeComplete.Text = "회원가입완료";
            this.button_MakeComplete.UseVisualStyleBackColor = true;
            this.button_MakeComplete.Click += new System.EventHandler(this.button_MakeComplete_Click);
            // 
            // label_MakeAccount
            // 
            this.label_MakeAccount.AutoSize = true;
            this.label_MakeAccount.Font = new System.Drawing.Font("휴먼옛체", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_MakeAccount.Location = new System.Drawing.Point(20, 153);
            this.label_MakeAccount.Name = "label_MakeAccount";
            this.label_MakeAccount.Size = new System.Drawing.Size(94, 22);
            this.label_MakeAccount.TabIndex = 1;
            this.label_MakeAccount.Text = "전화번호";
            // 
            // textBox_MakeAccount
            // 
            this.textBox_MakeAccount.Font = new System.Drawing.Font("굴림", 18F);
            this.textBox_MakeAccount.Location = new System.Drawing.Point(141, 153);
            this.textBox_MakeAccount.Name = "textBox_MakeAccount";
            this.textBox_MakeAccount.Size = new System.Drawing.Size(120, 35);
            this.textBox_MakeAccount.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.MakeImage;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 376);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Membership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 376);
            this.Controls.Add(this.button_MakeComplete);
            this.Controls.Add(this.textBox_MakePWD);
            this.Controls.Add(this.textBox_MakeAccount);
            this.Controls.Add(this.textBox_MakeName);
            this.Controls.Add(this.label_MakePWD);
            this.Controls.Add(this.label_MAKEIDPWD);
            this.Controls.Add(this.label_MakeAccount);
            this.Controls.Add(this.label_Makename);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Membership";
            this.Text = "회원가입";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Makename;
        private System.Windows.Forms.Label label_MakePWD;
        private System.Windows.Forms.Label label_MAKEIDPWD;
        private System.Windows.Forms.TextBox textBox_MakeName;
        private System.Windows.Forms.TextBox textBox_MakePWD;
        private System.Windows.Forms.Button button_MakeComplete;
        private System.Windows.Forms.Label label_MakeAccount;
        private System.Windows.Forms.TextBox textBox_MakeAccount;
    }
}