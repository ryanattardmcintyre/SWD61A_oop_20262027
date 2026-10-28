using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstract.Example1
{
    public enum LicenseType { A1, A2, A}
    public class MotorBike: IVehicle
    {
        public LicenseType LicenseType { get; set; }
        public string NumberPlate { get; set; }
        public string VIN { get; set; }
        public double Engine { get; set; } //4.4
        public string Model { get; set; }
        public string Make { get; set; }
        public EngineType EngineType { get; set; }
        public void ChangeNumberPlate(string newNumberPlate, int pinNumber)
        {
            if (pinNumber == 1111)
            { NumberPlate = newNumberPlate; }
        }

        public double CalculateAvgConsumptionPerKm()
        {
            return 20;
        }
        public int Length { get; set; }
        public int Width { get; set; }

        public double Weight { get; set; }
        public double FindAreaOfVehicle()
        {
            return (Length * Width) ;
        }

        public bool Container { get; set; }
        public int PersonsOnBike { get; set; }

        
    }
}
