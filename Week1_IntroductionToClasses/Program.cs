// See https://aka.ms/new-console-template for more information
using Week1_IntroductionToClasses;

Console.WriteLine("Hello, World!");

//a class is a blueprint/template

//an object is an instance of a class
//    in other words an object is an address location in memory which respects the
//    template (i.e. class) which stores the data 

Person myPerson; //declaration of an object of type Person named myPerson
//myPerson.Name = "Test"; //you cannot store in an unitialized object

myPerson = new Person("Robert", "Zammit"); //you instantiate an instance of Person by calling the constructor
myPerson.Active = true;
myPerson.DateOfBirth = new DateTime(2000, 1, 1);


Person myPerson2;
myPerson2 = new Person("Joe", "Abela");
myPerson2.Name = "Maria";
Console.WriteLine(myPerson2.Name);

//Exercise:
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


