using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class NIC
    {
        private string ip;
        public string IP
        {
            get { return ip; }
         
        }
        NIC()
        {

        }
        static NIC o = null;
        public static NIC CreateNIC(string ip)
        {
            if (o == null)
            {
                o = new NIC();
                o.ip = ip;
            }
            return o;
        }
    }
}
