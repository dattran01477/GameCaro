using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameCaro
{
    public class SocketManager
    {

        #region Client
        Socket client;
        public bool ConnectSever()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), PORT);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(iep);
                return true;
            }
           catch
            {
                return false;
            }
           
        }
        #endregion

        #region Sever
        Socket sever;
        public void CreateSever()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), PORT);
            sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            sever.Bind(iep);
            sever.Listen(10);
            Thread accepClient = new Thread(() =>
            {
                client = sever.Accept();
            });
            accepClient.IsBackground = true;
            accepClient.Start();

            

        }
        #endregion

        #region Both
        public string IP = "127.0.0.0.1";
        public int PORT = 9999;
        public const int BUFFER = 1024;
        public bool Sent(object o)
        {
            byte[] data = SerializeData(o);
            return SentData(client, data);
        }
        public object Receive()
        {
            byte[] data = new byte[BUFFER];
            bool isOK = ReceiveData(client, data);
            return DeserializeData(data);
        }
        private bool SentData(Socket target, byte[] data)
        {
            return target.Send(data) == 1 ? true : false;
        }
        private bool ReceiveData(Socket target, byte[] data)
        {
            try
            {

                return target.Receive(data) == 1 ? true:false;
            }
            catch
            {

            }
            return false;
            
        }
        /// <summary>
        /// Nén đối tượng thành mảng byte[]
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public byte[] SerializeData(Object o)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(ms, o);
            return ms.ToArray();
        }

        /// <summary>
        /// Giải nén mảng byte[] thành đối tượng object
        /// </summary>
        /// <param name="theByteArray"></param>
        /// <returns></returns>
        public object DeserializeData(byte[] theByteArray)
        {
            try
            {
                MemoryStream ms = new MemoryStream(theByteArray);
                BinaryFormatter bf1 = new BinaryFormatter();
                ms.Position = 0;
                return bf1.Deserialize(ms);
            }
            catch
            {

            }
            return null;
        }

        /// <summary>
        /// Lấy ra IP V4 của card mạng đang dùng
        /// </summary>
        /// <param name="_type"></param>
        /// <returns></returns>
        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }
            return output;
        }
        #endregion

    }
}
