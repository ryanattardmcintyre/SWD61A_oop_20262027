using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstract.Example1
{
    public class Truck
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
            return 100 * 1.20;
        }
        public int Length { get; set; }
        public int Width { get; set; }

        public double Weight { get; set; }
        public double FindAreaOfVehicle()
        {
            return (Length * Width) * 1.25;
        }

        public double CarryingCapacity { get; set; }
        public int NoOfSpareWheels { get; set; }
    }
}
