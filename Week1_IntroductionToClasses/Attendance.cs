using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_IntroductionToClasses
{
    //Create a class called Attendance. Inside the Attendance declare these fields/properties
    //- Id (int)
    //- DateTaken (DateTime)
    //- Present (bool)
    //- Person (Person)
    //- LastModified (DateTime)
    //- Subject (string)

    //- Create a method called MarkPresent() which returns nothing
    //            => you need to set Present + LastModified
    //- LastModified should be read-only
    //- Subject name must start with a capital letter followed by small case letters
    public class Attendance
    {
        //fields
        private string subject;
        private DateTime lastModified;

        //properties
        public int Id { get; set; }
        public DateTime DateTaken { get; set; }
        public bool Present { get; set; }
        public Person Person { get; set; }

        public DateTime LastModified { get { return lastModified; }  }
        public string Subject { get { return subject; } 
                                set { subject = value[0].ToString().ToUpper() +
                                                 value.ToString().Substring(1).ToLower(); } }


        //methods
        public void MarkPresent()
        {
            Present = true;
            lastModified = DateTime.Now;
        }

    }
}
