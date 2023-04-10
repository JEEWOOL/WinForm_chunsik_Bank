using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Text.Json;

namespace WindowsFormsApp1
{
    class IOPacket
    {
        public char IO { get; set; }
    }
    class CMDPacket : IOPacket
    {
        public string CMD { get; set; }
    }
    class ChatPacket : CMDPacket
    {
        public string ID { get; set; }
        public string CHATDATA { get; set; }
    }
    class ReaderPacket
    {
        public List<string> READER { get; set; }
    }
    delegate void TextControldel(string data);
    internal static class Client
    {
        static public Socket clientSocket;
        static public IPEndPoint ipep;
        static public NetworkStream ns;
        static public StreamWriter sw;
        static public StreamReader sr;
        static public Thread threadRecv;
        static public bool isOpen = true;
        static private object keyLock = new object();
        static public List<string> readers = new List<string>();
        static Client()
        {
            clientSocket = new Socket(AddressFamily.InterNetwork,
                                            SocketType.Stream,
                                            ProtocolType.Tcp);
            ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"),
                                        777);
            while (true)
            {
                try
                {
                    clientSocket.Connect(ipep);
                    MessageBox.Show("서버 접속 연결!!!");
                    ns = new NetworkStream(clientSocket);
                    sw = new StreamWriter(ns);
                    sr = new StreamReader(ns);
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("서버 접속 실패... " + ex.Message);
                }
            }
        }

        static public List<string> GetList()
        {
            while (readers.Count == 0) ;

            List<string> templist = new List<string>(readers);
            readers.Clear();
            return templist;
        }
        static public List<string> GetChat()
        {
            List<string> templist = new List<string>(readers);
            readers.Clear();
            return templist;
        }
        static public void SendCMD(string cmd, char io)
        {
            try
            {
                CMDPacket cmdP = new CMDPacket();
                cmdP.IO = io;
                cmdP.CMD = cmd;
                sw.WriteLine(JsonSerializer.Serialize<CMDPacket>(cmdP));
                sw.Flush();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Send Error : " + ex.Message);
                throw ex;
            }
        }
        static public void StartTread()
        {
            threadRecv = new Thread(new ThreadStart(ThreadRecv));
            threadRecv.Start();
        }
        static void ThreadRecv()
        {
            while (isOpen)
            {
                string data = "";
                try
                {
                    data = sr.ReadLine();
                    if (data == null)
                        continue;
                    else
                    {
                        lock (keyLock)
                        {
                            readers = JsonSerializer.Deserialize<ReaderPacket>(data).READER;
                        }
                    }
                }
                catch (JsonException ex)
                {
                    Console.WriteLine($"Json Error : {ex.Message}");
                    Console.WriteLine($"Json Data : {data}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Recv Error : {ex.Message}");
                    isOpen= false;
                }
            }
        }

        static public void SendCMD(string text, char io, string userName)
        {
            try
            {
                ChatPacket chatP = new ChatPacket();
                chatP.IO = io;
                chatP.CHATDATA = text;
                chatP.ID = userName;
                sw.WriteLine(JsonSerializer.Serialize<ChatPacket>(chatP));
                sw.Flush();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Send Error : " + ex.Message);
                throw ex;
            }
        }
    }
}
