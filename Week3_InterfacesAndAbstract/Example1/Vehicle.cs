using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstract.Example1
{
    public enum EngineType { Diesel, Petrol, Hybrid, EV}
    public enum Category { SUV, Saloon, Hatchback, Convertible, Compact, Large}
    public class Vehicle : IVehicle
    {
        public string NumberPlate { get; set; }
        public string VIN { get; set; }
        public double Engine { get; set; } //4.4
        public string Model { get; set; }
        public string Make { get; set; }
        public EngineType EngineType { get; set; }
        public Category BodyType { get; set; }

        public void ChangeNumberPlate(string newNumberPlate, int pinNumber)
        {
            if (pinNumber == 1111)
            { NumberPlate = newNumberPlate; }
        }

        public double CalculateAvgConsumptionPerKm()
        {
            return 100;
        }
        public int Length { get; set; }
        public int Width { get; set; }

        public double Weight { get; set; }
        public double FindAreaOfVehicle()
        {
            return (Length * Width) * 1.10; 
        }

        public bool SpareOrRepairKit { get; set; }


    }
}
