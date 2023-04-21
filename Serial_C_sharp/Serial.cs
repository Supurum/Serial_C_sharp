using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace Serial_C_sharp
{
    class Serial
    {
        private static Serial instance = new Serial();
        private Serial()
        {

        }

        public static Serial getInstance()
        {
            return instance;
        }
        
        public string[] Port_Load()
        {
            return SerialPort.GetPortNames();
        }
    }
}
