using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class Membership : Form
    {
        void LabelColor()
        {
            label_MakeAccount.Parent = pictureBox1;
            label_MAKEIDPWD.Parent = pictureBox1;
            label_Makename.Parent = pictureBox1;
            label_MakePWD.Parent = pictureBox1;
            label_MakeAccount.BackColor = Color.Transparent;
            label_MAKEIDPWD.BackColor = Color.Transparent;
            label_Makename.BackColor = Color.Transparent;
            label_MakePWD.BackColor = Color.Transparent;
        }

        public Membership()
        {
            InitializeComponent();
            LabelColor();
        }

        private void button_MakeComplete_Click(object sender, EventArgs e)
        {
            string insertSql = @"INSERT INTO MEMBERSHIP(ano, name, passwd)" + "\r\n" +
                               $"VALUES('{textBox_MakeAccount.Text}', '{textBox_MakeName.Text}', '{textBox_MakePWD.Text}')";
            string checkSQL = $"" + "\r\n" +
                $"'{textBox_MakeAccount.Text}'";

            string query =
                @"SELECT * 
                  FROM membership" + "\r\n" +
                $"WHERE ANO = '{textBox_MakeAccount.Text}'";

            Client.SendCMD(query, 'O');
            string[] receive = Client.GetList()[0].Split(' ');

            if(textBox_MakeAccount.Text == receive[0])
            {
                MessageBox.Show("이미 가입된 회원입니다.");
                this.Close();
            }

            if (textBox_MakeAccount.Text == null || textBox_MakeName.Text == null || textBox_MakePWD.Text == null)
            {
                MessageBox.Show($"정보를 잘못입력했습니다.");
            }
            else
            {
                try
                {
                    Client.SendCMD(insertSql, 'I');
                    MessageBox.Show($"회원가입 완료");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"에러 발생 : {ex.Message}");
                }
            }
            this.Close();
        }
    }
}
