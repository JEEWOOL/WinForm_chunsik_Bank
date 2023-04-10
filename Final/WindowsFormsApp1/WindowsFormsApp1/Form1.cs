using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        Membership fieldForm2;
        MainMenu fieldForm3;
        
        void LabelColor()
        {
            label_Account.Parent = pictureBox_Title;
            label_Title.Parent = pictureBox_Title;
            label_name.Parent = pictureBox_Title;
            label_PWD.Parent = pictureBox_Title;
            label_Account.BackColor = Color.Transparent;
            label_Title.BackColor = Color.Transparent;
            label_name.BackColor = Color.Transparent;
            label_PWD.BackColor = Color.Transparent;
            label_Title.Location = new Point(110, 10);
        }
        private void btnEnable()
        {
            button_Login.Enabled = true;
            button_MakeID.Enabled = true;
        }

        public Login()
        {
            InitializeComponent();
            this.Load += Form1_Load; // 초기화            

            LabelColor(); // 라벨 배경색 투명            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Client.isOpen = true;
            Client.StartTread();
        }

        private void button_MakeID_Click(object sender, EventArgs e)
        {
            if (fieldForm2 == null || fieldForm2.IsDisposed)
            {
                fieldForm2 = new Membership();
                fieldForm2.Show();
            }
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string query =
                @"SELECT * 
                  FROM membership" + "\r\n" +
                  $"WHERE ANO = '{textBox_Number.Text}'";
            
            string userNumber = textBox_Number.Text;
            string userName = textBox_name.Text;
            string userPwd = textBox_PWD.Text;

            Client.SendCMD(query, 'O');

            string[] receive = Client.GetList()[0].Split(' ');
            if (receive[0] == "null")
            {
                MessageBox.Show("가입된 회원정보와 일치하지 않습니다.");
            }
            else if (userNumber == receive[0] && userName == receive[1] &&
                    userPwd == receive[2])
            {
                MessageBox.Show("로그인에 성공했습니다.", "로그인");
                BankClient bc = BankClient.GetInstance();

                this.Visible = false;
                bc.userNum = userNumber;
                bc.userName = userName;
                bc.balance = receive[3];
                fieldForm3 = new MainMenu();
                fieldForm3.ShowDialog();
            }
            else
            {
                MessageBox.Show("로그인에 실패했습니다.", "로그인");
            }
        }

        private void button_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
