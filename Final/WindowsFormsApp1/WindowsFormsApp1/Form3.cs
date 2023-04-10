using _transfer_;
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

namespace WindowsFormsApp1
{
    public partial class MainMenu : Form
    {
        InputOutput ioput;
        MoneyTransfer transfer;
        Messenger messenger;
        Form6 chatRoom;

        void LabelColor()
        {
            label1.Parent = pictureBox_Main;
            label1.BackColor = Color.Transparent;
        }

        public MainMenu()
        {
            InitializeComponent();
            LabelColor();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button_depositwithdraw_Click(object sender, EventArgs e)
        {
            ioput = new InputOutput();
            ioput.ShowDialog();
        }

        private void button_AccountTransfer_Click(object sender, EventArgs e)
        {
            transfer = new MoneyTransfer();
            transfer.ShowDialog();
        }

        private void button_Message_Click(object sender, EventArgs e)
        {
            messenger = new Messenger();
            messenger.ShowDialog();
        }

        private void pictureBox_Main_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chatRoom = new Form6();
            chatRoom.ShowDialog();
        }
    }
}
