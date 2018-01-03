using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class GameCaro : Form
    {
        SocketManager socket;
        bool isSever = false;
        BoardChessManager board;
        public delegate Button SentBtn();
        


        public GameCaro()
        {
            InitializeComponent();

        }



        private void GameCaro_Load(object sender, EventArgs e)
        {
            board = new BoardChessManager(PanelBoardChess);
           
            socket = new SocketManager();
        }

        private void btnLan_Click(object sender, EventArgs e)
        {
            socket.IP = txtIp.Text;
            if (!socket.ConnectSever())
            {
                socket.CreateSever();
                

                Thread listenThread = new Thread(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(500);
                        try
                        {
                            listen();
                            break;
                        }
                        catch
                        {

                        }
                    }

                });


                listenThread.IsBackground = true;
                listenThread.Start();
                isSever = true;
            }
            else
            {

                listen();
               

            }

        }

        private void listen()
        {
          
            Thread listenThread = new Thread(() =>
            {
                string data = (string)socket.Receive();
                //SocKetData data1 = (SocKetData)socket.Receive();

                //txtLog.Invoke(new Action(delegate { txtLog.Text = logtext.ToString(); }));
                txtViewChat.Invoke(new Action(delegate { txtViewChat.Items.Add(data == null ? null : data); }));
                //ProcessData(data1); 

            });
            
            listenThread.IsBackground = true;
            listenThread.Start();

        }

        private void ProcessData(SocKetData data)
        {
            if (data == null)
                return;
            PanelBoardChess.Controls.Add(data.Btn);
            MessageBox.Show(data.Mess);
            
        }

        private void SenBtnWhenActiveEventClick()
        {
            //SentBtn btnSent = new SentBtn(board.SentBtn);
            SocKetData data=new SocKetData { Command=Command.Button,Btn=board.SentBtn(),Mess="da gui button"};
            listen();
            socket.Sent(data);
            listen();
        }
        

       
        private void GameCaro_Shown(object sender, EventArgs e)
        {
            txtIp.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            if (string.IsNullOrEmpty(txtIp.Text))
            {
                txtIp.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }

        }

        private void btnChat_Click(object sender, EventArgs e)
        {


            listen();
            socket.Sent(isSever == true ? "Chủ:" + txtChat.Text : "Khách:" + txtChat.Text);
            txtViewChat.Items.Add("Ban:" + txtChat.Text);
            listen();
        }
    }
}
