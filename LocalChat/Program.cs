using System;
using System.Net;

namespace LocalChat
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            Console.WriteLine("Please, enter your age: ");
            user.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your name: ");
            user.Name = Console.ReadLine();
            user.sayHello();

            while (true)
            {
                Console.Write($">{user.Name}:");
                var input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "/login":
                        //Temporary construct
                        var UserLogin = new UserLogin<string>("12345", "androidcelso@gmail.com");
                        if (UserLogin != null)
                        {
                            Console.WriteLine("Your login is successfull!");
                        }
                        else
                        {
                            Console.WriteLine("Your login attempt has failed");
                        }
                        break;

                    case "/showip":
                        {
                            Console.WriteLine("Enter your address: ");
                            string IPgive = Console.ReadLine();
                            IPHostEntry host1 = Dns.GetHostEntry($"{IPgive}");
                            Console.WriteLine(host1.HostName);
                            foreach (IPAddress ip in host1.AddressList)
                                Console.WriteLine(ip.ToString());
                            Console.WriteLine("Here's the list of IP addresses we located.");
                        }
                        break;

                    case "/exit":
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
