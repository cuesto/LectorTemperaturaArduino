using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;

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
                string temp = serial.ReadLine().Replace("\r", "");
                Thread.Sleep(1000);
            }
            serial.Close();
        }
    }
}
