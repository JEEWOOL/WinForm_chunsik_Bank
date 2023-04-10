using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class BankClient
    {
        static BankClient sin;
        public string userName;
        public string userNum;
        public string balance;

        BankClient()
        {
            sin = null;
        }
        static public BankClient GetInstance()
        {
            if (sin == null)
                sin = new BankClient();
            return sin;
        }
    }
}
