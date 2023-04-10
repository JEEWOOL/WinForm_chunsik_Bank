namespace WindowsFormsApp1
{
    partial class Messenger
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
            this.button_Clear = new System.Windows.Forms.Button();
            this.listBox_Log = new System.Windows.Forms.ListBox();
            this.textBox_SendData = new System.Windows.Forms.TextBox();
            this.button_EXIT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_RevNum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.White;
            this.button_Clear.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_Clear.FlatAppearance.BorderSize = 4;
            this.button_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button_Clear.Location = new System.Drawing.Point(398, 60);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(147, 42);
            this.button_Clear.TabIndex = 2;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // listBox_Log
            // 
            this.listBox_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox_Log.FormattingEnabled = true;
            this.listBox_Log.ItemHeight = 24;
            this.listBox_Log.Location = new System.Drawing.Point(28, 143);
            this.listBox_Log.Name = "listBox_Log";
            this.listBox_Log.Size = new System.Drawing.Size(398, 412);
            this.listBox_Log.TabIndex = 3;
            // 
            // textBox_SendData
            // 
            this.textBox_SendData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox_SendData.Location = new System.Drawing.Point(28, 108);
            this.textBox_SendData.Name = "textBox_SendData";
            this.textBox_SendData.Size = new System.Drawing.Size(398, 29);
            this.textBox_SendData.TabIndex = 2;
            this.textBox_SendData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_SendData_KeyDown);
            // 
            // button_EXIT
            // 
            this.button_EXIT.BackColor = System.Drawing.Color.White;
            this.button_EXIT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_EXIT.FlatAppearance.BorderSize = 4;
            this.button_EXIT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_EXIT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_EXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_EXIT.Location = new System.Drawing.Point(451, 604);
            this.button_EXIT.Name = "button_EXIT";
            this.button_EXIT.Size = new System.Drawing.Size(75, 32);
            this.button_EXIT.TabIndex = 10;
            this.button_EXIT.Text = "나가기";
            this.button_EXIT.UseVisualStyleBackColor = false;
            this.button_EXIT.Click += new System.EventHandler(this.button_EXIT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.EXIT;
            this.pictureBox1.Location = new System.Drawing.Point(434, 523);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 82);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button_Connect
            // 
            this.button_Connect.BackColor = System.Drawing.Color.White;
            this.button_Connect.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_Connect.FlatAppearance.BorderSize = 4;
            this.button_Connect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_Connect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button_Connect.Location = new System.Drawing.Point(398, 12);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(147, 42);
            this.button_Connect.TabIndex = 2;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = false;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(37, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "받는 사람 계정";
            // 
            // textBox_RevNum
            // 
            this.textBox_RevNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox_RevNum.Location = new System.Drawing.Point(185, 44);
            this.textBox_RevNum.Name = "textBox_RevNum";
            this.textBox_RevNum.Size = new System.Drawing.Size(169, 29);
            this.textBox_RevNum.TabIndex = 1;
            // 
            // Messenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.kakaobackGround;
            this.ClientSize = new System.Drawing.Size(557, 638);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_EXIT);
            this.Controls.Add(this.textBox_SendData);
            this.Controls.Add(this.listBox_Log);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.textBox_RevNum);
            this.Controls.Add(this.label1);
            this.Name = "Messenger";
            this.Text = "채팅";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.ListBox listBox_Log;
        private System.Windows.Forms.TextBox textBox_SendData;
        private System.Windows.Forms.Button button_EXIT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_RevNum;
    }
}