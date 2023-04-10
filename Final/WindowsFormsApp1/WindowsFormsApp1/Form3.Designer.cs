namespace WindowsFormsApp1
{
    partial class MainMenu
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
            this.button_depositwithdraw = new System.Windows.Forms.Button();
            this.button_AccountTransfer = new System.Windows.Forms.Button();
            this.button_Message = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.pictureBox_Main = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // button_depositwithdraw
            // 
            this.button_depositwithdraw.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_depositwithdraw.FlatAppearance.BorderSize = 4;
            this.button_depositwithdraw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_depositwithdraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_depositwithdraw.Font = new System.Drawing.Font("휴먼옛체", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_depositwithdraw.Location = new System.Drawing.Point(413, 32);
            this.button_depositwithdraw.Name = "button_depositwithdraw";
            this.button_depositwithdraw.Size = new System.Drawing.Size(131, 53);
            this.button_depositwithdraw.TabIndex = 1;
            this.button_depositwithdraw.Text = "입 · 출금";
            this.button_depositwithdraw.UseVisualStyleBackColor = true;
            this.button_depositwithdraw.Click += new System.EventHandler(this.button_depositwithdraw_Click);
            // 
            // button_AccountTransfer
            // 
            this.button_AccountTransfer.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_AccountTransfer.FlatAppearance.BorderSize = 4;
            this.button_AccountTransfer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_AccountTransfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_AccountTransfer.Font = new System.Drawing.Font("휴먼옛체", 15.75F);
            this.button_AccountTransfer.Location = new System.Drawing.Point(413, 91);
            this.button_AccountTransfer.Name = "button_AccountTransfer";
            this.button_AccountTransfer.Size = new System.Drawing.Size(131, 53);
            this.button_AccountTransfer.TabIndex = 1;
            this.button_AccountTransfer.Text = "계좌이체";
            this.button_AccountTransfer.UseVisualStyleBackColor = true;
            this.button_AccountTransfer.Click += new System.EventHandler(this.button_AccountTransfer_Click);
            // 
            // button_Message
            // 
            this.button_Message.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_Message.FlatAppearance.BorderSize = 4;
            this.button_Message.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_Message.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_Message.Font = new System.Drawing.Font("휴먼옛체", 15.75F);
            this.button_Message.Location = new System.Drawing.Point(413, 150);
            this.button_Message.Name = "button_Message";
            this.button_Message.Size = new System.Drawing.Size(131, 53);
            this.button_Message.TabIndex = 1;
            this.button_Message.Text = "고객센터";
            this.button_Message.UseVisualStyleBackColor = true;
            this.button_Message.Click += new System.EventHandler(this.button_Message_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_Exit.FlatAppearance.BorderSize = 4;
            this.button_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_Exit.Font = new System.Drawing.Font("휴먼옛체", 15.75F);
            this.button_Exit.Location = new System.Drawing.Point(413, 299);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(131, 53);
            this.button_Exit.TabIndex = 1;
            this.button_Exit.Text = "나가기";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // pictureBox_Main
            // 
            this.pictureBox_Main.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Mainback;
            this.pictureBox_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Main.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Main.Name = "pictureBox_Main";
            this.pictureBox_Main.Size = new System.Drawing.Size(574, 366);
            this.pictureBox_Main.TabIndex = 0;
            this.pictureBox_Main.TabStop = false;
            this.pictureBox_Main.Click += new System.EventHandler(this.pictureBox_Main_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼옛체", 15.75F);
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 66);
            this.label1.TabIndex = 3;
            this.label1.Text = "어서오세요.\r\n춘식이 은행입니다\r\n원하시는 메뉴를 선택해주세요.";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("휴먼옛체", 15.75F);
            this.button1.Location = new System.Drawing.Point(413, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "채팅방";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Message);
            this.Controls.Add(this.button_AccountTransfer);
            this.Controls.Add(this.button_depositwithdraw);
            this.Controls.Add(this.pictureBox_Main);
            this.Name = "MainMenu";
            this.Text = "메인메뉴";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Main;
        private System.Windows.Forms.Button button_depositwithdraw;
        private System.Windows.Forms.Button button_AccountTransfer;
        private System.Windows.Forms.Button button_Message;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}