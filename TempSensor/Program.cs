﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;

namespace TempSensor
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialPort serial = new SerialPort("COM3");
            serial.Open();
            while (true)
            {
                string temp = serial.ReadLine();
                
            }
            serial.Close();
        }
    }
}
