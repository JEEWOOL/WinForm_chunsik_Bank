namespace WindowsFormsApp1
{
    partial class InputOutput
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
            this.label_IOid = new System.Windows.Forms.Label();
            this.label_IOmoney = new System.Windows.Forms.Label();
            this.textBox_IOPsswd = new System.Windows.Forms.TextBox();
            this.textBox_IOmoney = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_Input = new System.Windows.Forms.Button();
            this.button_Output = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_EXIT = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_IOBalance = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_IOid
            // 
            this.label_IOid.AutoSize = true;
            this.label_IOid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_IOid.Location = new System.Drawing.Point(12, 89);
            this.label_IOid.Name = "label_IOid";
            this.label_IOid.Size = new System.Drawing.Size(89, 29);
            this.label_IOid.TabIndex = 2;
            this.label_IOid.Text = "비밀번호";
            // 
            // label_IOmoney
            // 
            this.label_IOmoney.AutoSize = true;
            this.label_IOmoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_IOmoney.Location = new System.Drawing.Point(12, 143);
            this.label_IOmoney.Name = "label_IOmoney";
            this.label_IOmoney.Size = new System.Drawing.Size(51, 29);
            this.label_IOmoney.TabIndex = 3;
            this.label_IOmoney.Text = "금액";
            // 
            // textBox_IOPsswd
            // 
            this.textBox_IOPsswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_IOPsswd.Location = new System.Drawing.Point(130, 89);
            this.textBox_IOPsswd.Name = "textBox_IOPsswd";
            this.textBox_IOPsswd.Size = new System.Drawing.Size(148, 29);
            this.textBox_IOPsswd.TabIndex = 4;
            // 
            // textBox_IOmoney
            // 
            this.textBox_IOmoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_IOmoney.Location = new System.Drawing.Point(130, 143);
            this.textBox_IOmoney.Name = "textBox_IOmoney";
            this.textBox_IOmoney.Size = new System.Drawing.Size(148, 29);
            this.textBox_IOmoney.TabIndex = 4;
            this.textBox_IOmoney.TextChanged += new System.EventHandler(this.textBox_IOmoney_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(32, 184);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(278, 340);
            this.listBox1.TabIndex = 5;
            // 
            // button_Input
            // 
            this.button_Input.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_Input.FlatAppearance.BorderSize = 3;
            this.button_Input.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_Input.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_Input.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Input.Location = new System.Drawing.Point(325, 24);
            this.button_Input.Name = "button_Input";
            this.button_Input.Size = new System.Drawing.Size(75, 48);
            this.button_Input.TabIndex = 6;
            this.button_Input.Text = "입금";
            this.button_Input.UseVisualStyleBackColor = true;
            this.button_Input.Click += new System.EventHandler(this.button_Input_Click);
            // 
            // button_Output
            // 
            this.button_Output.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_Output.FlatAppearance.BorderSize = 3;
            this.button_Output.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_Output.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_Output.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Output.Location = new System.Drawing.Point(325, 78);
            this.button_Output.Name = "button_Output";
            this.button_Output.Size = new System.Drawing.Size(75, 48);
            this.button_Output.TabIndex = 6;
            this.button_Output.Text = "출금";
            this.button_Output.UseVisualStyleBackColor = true;
            this.button_Output.Click += new System.EventHandler(this.button_Output_Click);
            // 
            // button_Search
            // 
            this.button_Search.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_Search.FlatAppearance.BorderSize = 3;
            this.button_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Search.Location = new System.Drawing.Point(325, 132);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 48);
            this.button_Search.TabIndex = 6;
            this.button_Search.Text = "조회";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_EXIT
            // 
            this.button_EXIT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_EXIT.FlatAppearance.BorderSize = 3;
            this.button_EXIT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_EXIT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_EXIT.Location = new System.Drawing.Point(325, 508);
            this.button_EXIT.Name = "button_EXIT";
            this.button_EXIT.Size = new System.Drawing.Size(85, 31);
            this.button_EXIT.TabIndex = 7;
            this.button_EXIT.Text = "나가기";
            this.button_EXIT.UseVisualStyleBackColor = true;
            this.button_EXIT.Click += new System.EventHandler(this.button_EXIT_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.IOimage;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(314, 405);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 103);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.IOback;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 551);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "잔액";
            // 
            // textBox_IOBalance
            // 
            this.textBox_IOBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_IOBalance.Location = new System.Drawing.Point(130, 35);
            this.textBox_IOBalance.Name = "textBox_IOBalance";
            this.textBox_IOBalance.Size = new System.Drawing.Size(148, 29);
            this.textBox_IOBalance.TabIndex = 4;
            this.textBox_IOBalance.TextChanged += new System.EventHandler(this.textBox_IOBalance_TextChanged);
            // 
            // InputOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 551);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_EXIT);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.button_Output);
            this.Controls.Add(this.button_Input);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox_IOBalance);
            this.Controls.Add(this.textBox_IOmoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_IOPsswd);
            this.Controls.Add(this.label_IOmoney);
            this.Controls.Add(this.label_IOid);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InputOutput";
            this.Text = "입/출금";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_IOid;
        private System.Windows.Forms.Label label_IOmoney;
        private System.Windows.Forms.TextBox textBox_IOPsswd;
        private System.Windows.Forms.TextBox textBox_IOmoney;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_Input;
        private System.Windows.Forms.Button button_Output;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_EXIT;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_IOBalance;
    }
}