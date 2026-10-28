using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstract.Example1
{

    //An interface is usally named starting with an I...
    //An interface does not allow us to implement methods/properties
    //An interface allows us to declare properties/methods
    //An interface CANNOT be instantiated
    //Classes can inherit many interfaces


    //When are they used? They are used when you want to have a common item for many classes
    //                    so it comes easier to manage when stored in a list
    //                    & when certain specifics are still unknown e.g. I want to declare
    //                    a method e.g. Draw() but i don't where vehicles will be drawn yet

    //Therefore an interface is like a definition of a contract without specific details. Hence
    //if i inherit a class from an interface, I am forced to implement any declared methods/properties

    //In other words an interface is usually created to be inherited

    //An interface is like a contract which must be respected in the implemented classes
    public interface IVehicle
    {
      
        string NumberPlate { get; set; }
        string VIN { get; set; }
        double Engine { get; set; } //4.4
        string Model { get; set; }
        string Make { get; set; }
        EngineType EngineType { get; set; }
        int Length { get; set; }
        int Width { get; set; }
        double Weight { get; set; }

        void ChangeNumberPlate(string newNumberPlate, int pinNumber);
        double CalculateAvgConsumptionPerKm();
        double FindAreaOfVehicle();

    }
        //....
        //to decide which are the common properties/methods in Vehicle,Truck,Motorbike and place them here
    
}
