using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace TempSensor
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialPort serial = new SerialPort("COM3");
            serial.Open();
            string temp = serial.ReadExisting();
            serial.Close();
        }
    }
}
