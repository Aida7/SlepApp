using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SlepClientApp
{
    class Program
    {
  
        static void Main(string[] args)
        {
            
            UdpClient udpClient = new UdpClient(3535);
            IPEndPoint endPoint = null;
            byte[] resiv = udpClient.Receive(ref endPoint);
            byte[] resiv1 = udpClient.Receive(ref endPoint);
            Console.WriteLine("Получение ...");
            Console.WriteLine("Пк скоро отключится");
            string str = System.Text.Encoding.UTF8.GetString(resiv);
            string str1 = System.Text.Encoding.UTF8.GetString(resiv1);
            Console.WriteLine(str);
            Console.WriteLine(str1);
            var p = new ProcessStartInfo(str, str1) { CreateNoWindow = true };
            
            Process.Start(p);
            Console.ReadLine();
            udpClient.Close();

        }
    }
}
