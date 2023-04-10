using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        BankClient bc;
        Timer tm = new Timer();
        public Form6()
        {
            bc = BankClient.GetInstance();
            InitializeComponent();
            tm.Interval = 30;
            tm.Tick += Tm_Tick;
            tm.Start();
            this.FormClosed += Form6_FormClosed;
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            tm.Stop();
        }

        private void Tm_Tick(object sender, EventArgs e)
        {
            List<string> st = Client.GetChat();
            if(st.Count == 0)
                return;
            if(listBox_ChatRoom.Items.Count > 0)
            {
                if(st[0] == (string)listBox_ChatRoom.Items[0])
                {
                    return;
                }
            }
            listBox_ChatRoom.Items.Insert(0, st[0]);
        }

        private void button_Quit_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void textBox_ChatRoom_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    string ID = bc.userName;
                    try
                    {
                        Client.SendCMD(textBox_ChatRoom.Text, 'C',bc.userName);
                        listBox_ChatRoom.Items.Insert(0, "나 : " + textBox_ChatRoom.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Chat Error : " + ex.Message);
                    }
                    textBox_ChatRoom.Clear();
                    break;
            }
        }
    }
}
