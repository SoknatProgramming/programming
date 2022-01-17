using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace programming
{
    class MainClass
    {

        public static void Main(string[] args)
        {

            List<string> ipaddress = new List<string>() {"172.20.10.2", "172.20.10.3", "172.20.10.4", "172.20.10.5" };
            try
            {
                for(int i=0; i<ipaddress.Count; i++) { 
                Ping myPing = new Ping();
                PingReply reply = myPing.Send(ipaddress[i], 1000);
                if (reply != null)
                {
                    Console.WriteLine("Status :  " + reply.Status + " \n Time : " + reply.RoundtripTime.ToString() + " \n Address : " + reply.Address);
                    //Console.WriteLine(reply.ToString());

                }
                }
            }
            catch
            {
                Console.WriteLine("ERROR: You have Some TIMEOUT issue");
            }
            Console.ReadKey();
        }
    }
 }
