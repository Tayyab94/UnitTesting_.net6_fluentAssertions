using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility.Ping
{
    public class NetworkService
    {
        public string SendPing() =>  "Success: ping sent";

        public int TimeOut(int a, int b) => a + b;
    
    }
}
