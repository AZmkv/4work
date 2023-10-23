using System;
using System.Collections.Generic;
using System.Data;

namespace Lab4_2
{
    public class Computer
    {
        public string IPAddress { get; set; }
        public int Power { get; set; }
        public string OSType { get; set; }

        public Computer(string ipAddress, int power, string osType)
        {
            IPAddress = ipAddress;
            Power = power;
            OSType = osType;
        }
    }
}