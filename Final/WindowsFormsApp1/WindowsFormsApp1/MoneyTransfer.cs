using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace _transfer_
{
    public partial class MoneyTransfer : Form
    {
        BankClient bc;
        void LabelColor()
        {
            label_Title.Parent = pictureBox_Transfer;
            label_balance.Parent = pictureBox_Transfer;
            label_MyPassWD.Parent = pictureBox_Transfer;
            label_Tmoney.Parent = pictureBox_Transfer;
            label_ReAccount.Parent = pictureBox_Transfer;
            label_Title.BackColor = Color.Transparent;
            label_balance.BackColor = Color.Transparent;
            label_Tmoney.BackColor = Color.Transparent;
            label_ReAccount.BackColor = Color.Transparent;
            label_MyPassWD.BackColor = Color.Transparent;
        }

        public MoneyTransfer()
        {
            InitializeComponent();

            LabelColor();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bc = BankClient.GetInstance();
            Client.isOpen = true;
            string query =
                @"SELECT balance FROM membership" + "\r\n" +
                $"WHERE ANO = '{bc.userNum}'";
            Client.SendCMD(query, 'O');
            bc.balance = Client.GetList()[0];
            textBox_balance.Text = bc.balance;
            textBox_balance.Enabled= false;
        }

        private void button_TF_Click(object sender, EventArgs e)
        {
            string userPwd = textBox_MyPassWD.Text;
            string reUserNumber = textBox_ReAccount.Text;
            long transfer = DeComma(textBox_Tmoney.Text);
            string query =
                @"SELECT * FROM membership" + "\r\n" +
                $"WHERE ANO = '{bc.userNum}'";
            Client.SendCMD(query, 'O');
            string[] reads = Client.GetList()[0].Split(' ');
            bc.balance = reads[3];
            textBox_balance.Text = bc.balance;
            int userMoney = Int32.Parse(reads[3]);
            if (userMoney < transfer)
            {
                MessageBox.Show("돈이 부족합니다.");
                return;
            }

            if (userPwd != reads[2])
            {
                MessageBox.Show("비밀번호가 틀립니다.");
                return;
            }
            query =
                @"SELECT * 
                  FROM membership" + "\r\n" +
                $"WHERE ANO = '{reUserNumber}'";
            Client.SendCMD(query, 'O');

            reads = Client.GetList()[0].Split(' ');

            if (reUserNumber == reads[0])
            {
                query =
                    $"UPDATE membership SET balance = balance - '{transfer}'" + "\r\n" +
                    $"WHERE ANO = '{bc.userNum}'";
                Client.SendCMD(query, 'I');
                query =
                    $"UPDATE membership SET balance = balance + '{transfer}'" + "\r\n" +
                    $"WHERE ANO = '{reUserNumber}'";
                Client.SendCMD(query, 'I');
                query =
                    $"INSERT INTO TransactionHistory(ano, receiver, tmoney)" + "\r\n" +
                    $"VALUES('{bc.userNum}', '{reUserNumber}', '{transfer}')";
                Client.SendCMD(query, 'I');

                MessageBox.Show("송금되었습니다.", "계좌이체");

                query =
                    @"SELECT balance FROM membership" + "\r\n" +
                    $"WHERE ANO = '{bc.userNum}'";
                Client.SendCMD(query, 'O');
                bc.balance = Client.GetList()[0];
                textBox_balance.Text = bc.balance;
            }
            else
            {
                MessageBox.Show("수신 계정이 없습니다.");
            }
        }

        private long DeComma(string text)
        {
            if (text.Length <= 0)
                return 0;
            string temp = text.Replace(",","");
            return long.Parse(temp);
        }

        private void button_EXIT_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button_TFFavList_Click(object sender, EventArgs e)
        {
            listBox_TF.Items.Clear();
            string selectSql = $"SELECT receiver FROM FavoriteList WHERE ano = '{bc.userNum}'";
            Client.SendCMD(selectSql, 'O');
            List<string> readerList = Client.GetList();
            if (readerList[0].Trim() == "null")
                return;
            for (int i = 0; i < readerList.Count; i++)
            {
                listBox_TF.Items.Add(readerList[i]);
            }
        }

        private void button_TFHistory_Click(object sender, EventArgs e)
        {
            string selectSql = $"SELECT * FROM TransactionHistory WHERE ano = '{bc.userNum}' OR receiver = '{bc.userNum}'";
            Client.SendCMD(selectSql, 'O');
            List<string> readerList = Client.GetList();
            if (readerList[0].Trim() == "null")
                return;
            listBox_TF.Items.Clear();
            for (int i = 0; i < readerList.Count; i++)
            {
                listBox_TF.Items.Insert(0, readerList[i]);
            }
        }

        private void button_TFSetFav_Click(object sender, EventArgs e)
        {
            if (listBox_TF.SelectedItem == null)
            {
                MessageBox.Show("즐겨찾기를 선택할 계좌를 선택해주세요.");
                return;
            }
            string[] sel = listBox_TF.SelectedItem.ToString().Split(' ');

            string selectSql = $"SELECT * FROM FavoriteList WHERE ano = '{bc.userNum}'";
            Client.SendCMD(selectSql, 'O');
            List<string> readerList = Client.GetList();
            if (readerList[0].Trim() == "null")
            {
                string insertSql = @"INSERT INTO FavoriteList(ano, receiver)" + "\r\n" +
                $"VALUES('{bc.userNum}', '{sel[1]}')";
                Client.SendCMD(insertSql, 'I');

                MessageBox.Show("즐겨찾기 설정 완료");
            }
            else
            {
                MessageBox.Show("이미 있는 계좌번호 입니다.");
            }
        }
        private void textBox_Tmoney_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
                return;
            long num = DeComma(((TextBox)sender).Text);
            string k = string.Format("{0:#,##0}", num);
            textBox_Tmoney.Text = k;
            textBox_Tmoney.SelectionStart = textBox_Tmoney.TextLength;
        }

        private void textBox_balance_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
                return;
            long num = DeComma(((TextBox)sender).Text);
            string k = string.Format("{0:#,##0}", num);
            textBox_balance.Text = k;
            textBox_balance.SelectionStart = textBox_balance.TextLength;
        }
    }
}
            