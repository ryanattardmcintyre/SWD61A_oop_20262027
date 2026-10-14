using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1_IntroductionToClasses;

namespace Week2_InheritanceAndPolymorphism.Example1
{
    //Inheritance
    //1) denoted as derived class : base class
    //2) all the public & protected properties/methods will be made
    //   available in the derived class

    public class User: Person
    {
        //we're forced to declare a constructor with name & surname
        //because the base class is forcing us since it has one
        //constructor with those parameters

        public User(string _name, string _surname) 
            : base(_name, _surname)
        { }
        public string Username { get; set; }
        public string Password { get; set; }

        public void ChangePassword(string currentPassword, string newPassword 
            , string confirmationPassword)
        {
            if(currentPassword == Password
                && newPassword == confirmationPassword)
            {
                Password = currentPassword;
            }
        }

    }
}
