using Nancy.Hosting.Self;
using System;

namespace NancyMono
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new NancyHost(new Uri("http://localhost:8011")))
            {
                host.Start();
                Console.ReadLine();
            }
        }
    }
}
