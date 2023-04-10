using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Messenger : Form
    {
        BankClient bc;
        string reNum = "";
        Timer tm = new Timer();
        public Messenger()
        {
            InitializeComponent();

            this.Load += Form4_Load;
            this.FormClosed += Form4_FormClosed;
            tm.Interval = 500;
            tm.Tick += Tm_Tick;
        }

        private void Tm_Tick(object sender, EventArgs e)
        {
            RecvMessage();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            tm.Stop();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            bc = BankClient.GetInstance();

            if(bc.userNum != "0")
            {
                textBox_RevNum.Visible = false;
                label1.Visible = false;

                button_Connect.Enabled = true;
                textBox_SendData.Enabled = false;
                return;
            }
            tm.Start();

            textBox_RevNum.Enabled = true;

            button_Connect.Enabled = true;
            textBox_SendData.Enabled = false;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            listBox_Log.Items.Clear();
            tm.Stop();

            textBox_RevNum.Enabled = true;

            button_Connect.Enabled = true;
            textBox_SendData.Enabled = false;
        }
        private void button_Connect_Click(object sender, EventArgs e)
        {
            if(bc.userNum == "0")
            {
                if (textBox_RevNum.Text == "")
                {
                    MessageBox.Show("받는 사람 번호와 이름을 입력하세요");
                    return;
                }
                string checkSql = $"SELECT ano FROM MemberShip WHERE ano = '{textBox_RevNum.Text}'";

                Client.SendCMD(checkSql, 'O');

                string[] reader = Client.GetList()[0].Split(' ');

                if (reader[0] == "null")
                {
                    MessageBox.Show("받는 상대가 가입되어 있지 않습니다.");
                    return;
                }
                reNum = reader[0];

                tm.Start();
            }
            else
            {
                reNum = "0";
                tm.Start();
            }




            textBox_RevNum.Enabled = false;

            button_Connect.Enabled = false;
            textBox_SendData.Enabled = true;
        }

        private void RecvMessage()
        {
            string getDialog = $"SELECT * FROM MessageTable WHERE receiver = '{bc.userNum}' OR ano = '{bc.userNum}'";

            Client.SendCMD(getDialog, 'O');
            List<string> readerList = Client.GetList();
            if (readerList[0] == "null") { return; }
            string[] reader;
            string message = "";
            reader = readerList[readerList.Count -1].Split(' ');
            message = reader[0] + " : " + reader[2] + " /" + reader[3];
            if (listBox_Log.Items.Count > 0)
            {
                if ((string)listBox_Log.Items[0] == message)
                {
                    return;
                }
            }
            listBox_Log.Items.Clear();
            for (int i = 0; i < readerList.Count; i++)
            {
                reader = readerList[i].Split(' ');
                message = reader[0] + " : " + reader[2];
                for(int j = 3;j< reader.Length-3;j++) { message += " " + reader[j]; }
                message+= " /";
                for(int j = reader.Length - 3; j < reader.Length; j++) { message += " " + reader[j]; }
                listBox_Log.Items.Insert(0, message);
                //TODO : 확인
            }
        }

        private void textBox_SendData_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    string ID = bc.userName;
                    string data = textBox_SendData.Text;
                    string insertSql = $"INSERT INTO MessageTable(ano,receiver,message) VALUES ('{ID}','{reNum}','{data}')";
                    try
                    {
                        Client.SendCMD(insertSql, 'I');
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("DB Error : " + ex.Message);
                    }

                    textBox_SendData.Clear();
                    break;
            }
        }

        private void button_EXIT_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
