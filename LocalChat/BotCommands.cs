using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace LocalChat
{
    class BotCommands
    {
        public void IPrequest()
        {
            string IPgive = Console.ReadLine();

            IPHostEntry host1 = Dns.GetHostEntry($"{IPgive}");


            Console.WriteLine(host1.HostName);
            foreach (IPAddress ip in host1.AddressList)
                Console.WriteLine(ip.ToString());
        }
    }
}
