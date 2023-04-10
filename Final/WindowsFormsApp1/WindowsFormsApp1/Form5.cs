using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class InputOutput : Form
    {
        BankClient bc;
        void LabelColor()
        {
            label_IOid.Parent = pictureBox1;
            label_IOmoney.Parent = pictureBox1;
            label_IOid.BackColor = Color.Transparent;
            label_IOmoney.BackColor = Color.Transparent;
        }

        private void AddResultLogListBox(string result)
        {
            listBox1.Items.Add(result);
        }

        public InputOutput()
        {
            InitializeComponent();

            this.Load += InputOutput_Load;

            LabelColor();
        }

        private void InputOutput_Load(object sender, EventArgs e)
        {
            bc = BankClient.GetInstance();
            button_Input.Enabled = false;
            button_Output.Enabled = false;
            textBox_IOBalance.Enabled = false;
        }

        private void button_Input_Click(object sender, EventArgs e)
        {
            if (textBox_IOmoney.Text == "")
            {
                MessageBox.Show("입금액을 입력 하세요!");
                return;
            }
            string selectSql = $"SELECT balance FROM MemberShip WHERE ano=('{bc.userNum}')";
            Client.SendCMD(selectSql, 'O');
            long balance = Int32.Parse(Client.GetList()[0]);
            try
            {
                balance += DeComma(textBox_IOmoney.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("입금액이 숫자가 아닙니다.");
                return;
            }

            string updateSql = $"UPDATE MemberShip SET balance=('{balance}') WHERE ano=('{bc.userNum}')";
            Client.SendCMD(updateSql, 'I');

            string insertSql = @"INSERT INTO TransactionHistory(ano, receiver, tmoney)" + "\r\n" +
                               $"VALUES('{bc.userNum}', '{bc.userNum}', '{DeComma(textBox_IOmoney.Text)}')";
            Client.SendCMD(insertSql, 'I');

            MessageBox.Show(textBox_IOmoney.Text + "원 입금이 완료되었습니다. \n 현재 잔액 : " + balance.ToString());
            textBox_IOBalance.Text = balance.ToString();
            //TODO : 숫자 서식 적용
            textBox_IOmoney.Clear();
            UpdateBalanceAndList();
        }
        private long DeComma(string text)
        {
            if (text.Length <= 0)
                return 0;
            string temp = text.Replace(",", "");
            return long.Parse(temp);
        }
        private void button_Output_Click(object sender, EventArgs e)
        {
            if (textBox_IOmoney.Text == "")
            {
                MessageBox.Show("출금액을 입력 하세요!");
                return;
            }
            string selectSql = $"SELECT balance FROM MemberShip WHERE ano=('{bc.userNum}')";
            Client.SendCMD(selectSql, 'O');
            long balance = Int32.Parse(Client.GetList()[0]);
            try
            {
                balance -= DeComma(textBox_IOmoney.Text);
                if (balance < 0)
                {
                    MessageBox.Show("잔액이 부족합니다.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("출금액이 숫자가 아닙니다.");
                return;
            }

            string updateSql = $"UPDATE MemberShip SET balance=('{balance}') WHERE ano=('{bc.userNum}')";
            Client.SendCMD(updateSql, 'I');

            string insertSql = @"INSERT INTO TransactionHistory(ano, receiver, tmoney)" + "\r\n" +
                               $"VALUES('{bc.userNum}', '{bc.userNum}', '-{DeComma(textBox_IOmoney.Text)}')";
            Client.SendCMD(insertSql, 'I');

            MessageBox.Show(textBox_IOmoney.Text + "원 출금이 완료되었습니다. \n 현재 잔액 : " + balance.ToString());
            textBox_IOBalance.Text = balance.ToString();
            textBox_IOmoney.Clear();
            UpdateBalanceAndList();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (textBox_IOPsswd.Text == "")
            {
                MessageBox.Show("비밀번호를 입력하세요!");
                return;
            }

            string selectSql = $"SELECT passwd FROM MemberShip WHERE ano=('{bc.userNum}')";
            Client.SendCMD(selectSql, 'O');
            string reader = Client.GetList()[0].Trim();
            if (reader != textBox_IOPsswd.Text)
            {
                MessageBox.Show("비밀번호가 틀립니다.");
                return;
            }
            button_Input.Enabled = true;
            button_Output.Enabled = true;

            UpdateBalanceAndList();
        }

        private void UpdateBalanceAndList()
        {
            string selectSql = $"SELECT balance FROM MemberShip WHERE ano=('{bc.userNum}')";
            Client.SendCMD(selectSql, 'O');
            string reader = Client.GetList()[0].Trim();
            textBox_IOBalance.Text = reader;
            bc.balance = reader;

            selectSql = $"SELECT * FROM TransactionHistory WHERE ano = '{bc.userNum}' OR receiver = '{bc.userNum}'";
            Client.SendCMD(selectSql, 'O');
            List<string> readerList = Client.GetList();
            if (readerList[0].Trim() == "null")
                return;
            listBox1.Items.Clear();
            for (int i = 0; i < readerList.Count; i++)
            {
                listBox1.Items.Insert(0, readerList[i]);
            }
        }

        private void button_EXIT_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void textBox_IOmoney_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
                return;
            long num = DeComma(((TextBox)sender).Text);
            string k = string.Format("{0:#,##0}", num);
            textBox_IOmoney.Text = k;
            textBox_IOmoney.SelectionStart = textBox_IOmoney.TextLength;
        }

        private void textBox_IOBalance_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
                return;
            long num = DeComma(((TextBox)sender).Text);
            string k = string.Format("{0:#,##0}", num);
            textBox_IOBalance.Text = k;
            textBox_IOBalance.SelectionStart = textBox_IOBalance.TextLength;
        }
    }
}
