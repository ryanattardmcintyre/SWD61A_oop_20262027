using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractClasses.Worksheet_AbstractClasses
{
    public class Subscriber
    {
        public Subscriber(int id, string name, string email, string mobileNumber)
        {
            Id = id;
            Name = name;
            Email = email;
            MobileNumber = MobileNumber;
        }
        public int Id { get; set; } 
        public string Name { get; set; } 
        public string Email { get; set; } 
        public string MobileNumber { get; set; } 
    }
}
