using System;
using System.Net;

namespace LocalChat
{
    public class ShowIpCmd
    {
        public void ShowIp()
        {
            Console.Write("$ Enter your address: ");
            var IPgive = Console.ReadLine();
            var result = Dns.GetHostEntry($"{IPgive}");
            foreach (IPAddress ip in result.AddressList)
                Console.WriteLine(ip.ToString());
            Console.WriteLine("Here's the list of IP addresses we located.");
        }
    }
}
