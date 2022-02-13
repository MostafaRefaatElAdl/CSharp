using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06Task01
{
    public class NIC
    {
        private string ip;
        private string manufacture;
        private string macAddress;
        private Type type;
        public string IP
        {
            get { return ip; }
        }
        public string Manufacture
        {
            get { return manufacture; }
        }
        public string MacAddress
        {
            get { return macAddress; }
        }
        public Type Type
        {
            get { return type; }
        }
        NIC()
        {

        }
        static NIC o = null;
        public static NIC CreateNIC(string _ip, string _manufacture, string _macAddress, Type _type)
        {
            if (o == null)
            {
                o = new NIC();
                o.ip = _ip;
                o.manufacture = _manufacture;
                o.macAddress = _macAddress;
                o.type = _type;
            }
            return o;
        }

        public override string ToString()
        {
            return $"IP = {o.IP}\n" +
                $"Manufacture = {o.Manufacture}\n" +
                $"MacAddress = {o.MacAddress}\n" +
                $"Type = {o.Type}\n ";
        }
    }
}
