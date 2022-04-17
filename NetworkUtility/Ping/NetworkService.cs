using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility.Ping
{
    public class NetworkService
    {
        public string SendPing() =>  "Success: ping sent";

        public int TimeOut(int a, int b) => a + b;
    
        public DateTime ListPingDate()=> DateTime.Now.Date;

        public PingOptions GetPingOptions()
        {
            return new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };
        }

        public IEnumerable<PingOptions> GetPingOptionsList()
        {
            var result = new List<PingOptions>()
            {
                new PingOptions()
                {
                    DontFragment = true,
                    Ttl = 1
                },
                new PingOptions()
                {
                     DontFragment=false,
                     Ttl=2
                }
            };
            return result;
        }
    }
}
