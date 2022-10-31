using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace XMLDeserialization
{
    public class Company
    {
        public Company()
        {
            Addresses = new List<Address>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
