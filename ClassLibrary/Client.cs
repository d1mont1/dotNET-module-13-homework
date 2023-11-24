using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Client
    {
        public int Id { get; }
        public string Name { get; }
        public string ServiceType { get; }

        public Client(int id, string name, string serviceType)
        {
            Id = id;
            Name = name;
            ServiceType = serviceType;
        }
    }
}
