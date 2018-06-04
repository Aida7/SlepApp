using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace SlepApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Process
            //UdpClient udpClient = new UdpClient();
            //udpClient.Client.AddressFamily;
            //udpClient.Connect(new IPEndPoint(, 3535));
            //byte[] data = Encoding.Default.GetBytes("hi");
            //udpClient.Send(data, data.Length);
            //udpClient.Close();
            //Console.WriteLine();
            // доступно ли сетевое подключение

            UdpClient udpClient = new UdpClient();
            udpClient.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3535));
            Console.WriteLine("...");
            //  "shutdown", "/s /t /f 00"
            //"cmd", "/c shutdown -s -f -t 00"
            string b = "cmd";
            string b1 = "/c shutdown -s -f -t 30";
            byte[] data = Encoding.Default.GetBytes(b);
            byte[] data1 = Encoding.Default.GetBytes(b1);
            udpClient.Send(data,data.Length);
            udpClient.Send(data1, data1.Length);
            Console.WriteLine("Отправка...");
            udpClient.Close();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
