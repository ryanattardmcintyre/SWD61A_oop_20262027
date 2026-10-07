using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_IntroductionToClasses
{
    //What is a class?
    //A class is a collection of related characteristics that define a (real-world) entity

    //Good practices:
    //class names:
    //    -  Singular
    //    -  using Pascal case naming convention e.g. AttendanceSheet
    //    -  names should not contain symbols, spaces, numbers (Wrong: Attendance_Sheet_1)
    //    -  to understand the reason: class will represent a single entity, while a table will 
    //                                 store a list of persons


    //What is a field?
    //A fields are data containers; they store values and therefore they require you to 
    //define a data type

    //field names:
    //    - singular
    //    - names should not contain symbols, spaces, numbers (Wrong: Attendance_Sheet_1)
    //    - camel case e.g. dateOfBirth (start with a lower case)


    //properties:
    //What is a property?
    //A property is normally used to control access to the values stored in the fields

    //property names:
    //   - names should not contain symbols, spaces, numbers (Wrong: Attendance_Sheet_1)
    //   - Pascal case again


    //access modifiers
    //private (Default) - is the most restrictive one. anything declared private
    //          is only accessible within the parent its contained in
    //protected - anything declared as protected can be accessed within the parent or the derived class
    //internal - is accessible within the same namespace / project
    //public - is accessible from everywhere
    public class Person //table: Persons will be generated automatically
    {
        //fields:
        string name;
        string surname;
        DateTime dateOfBirth;
        //bool active;
        string email;
        long mobile;

        //properties:
        public string Name //robert zammit      
        {
            get
            {
                //...
                return name; //returning the value from the field name
            }
            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public DateTime DateOfBirth { get; set; } //shorthand notation

        public bool Active { get; set; }

        //a property without a dedicated field
        //a property which is formed out of two fields
        //a property which is readonly
        public string FullName { get { return name + ' ' + surname; } }

        //a property with a set only i.e. write-only
        public int AgeInYears { set {
                dateOfBirth = new DateTime(
                    DateTime.Now.Year - Convert.ToInt32(value),
                    DateTime.Now.Month, DateTime.Now.Day
                    );
            } }
    }

}
