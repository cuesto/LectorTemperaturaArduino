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
        private SerialPort _serialPort;

        static void Main(string[] args)
        {
            Program prg = new Program();
            prg._serialPort = new SerialPort("COM3");
            prg.LeerPuertoCom();
        }

        private void LeerPuertoCom()
        {
            String temp;
            _serialPort.Open();

            while (true)
            {
                temp = _serialPort.ReadLine().Replace("\r", "");
                Thread.Sleep(1000);
            }
            _serialPort.Close();
        }
    }
}
