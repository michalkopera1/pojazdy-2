using System;
using System.Collections.Generic;
using ClassLibrary1;
using System.Linq;
using VehiclesLibrary;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicleList = new List<Vehicle>();
            Car volvo = new Car(100, Engine.FuelType.Petrol);
            Amphibian amph = new Amphibian(200, 500);
            Plane cessna = new Plane(300, Engine.FuelType.Petrol);
            Hydroplane hydro = new Hydroplane(300, Engine.FuelType.Petrol, 100);
            Boat titanic = new Boat(10000, 20000);
            UFO ufo = new UFO();
            Bicycle bic = new Bicycle();
            vehicleList.Add(volvo);
            vehicleList.Add(amph);
            vehicleList.Add(cessna);
            vehicleList.Add(hydro);
            vehicleList.Add(titanic);
            vehicleList.Add(ufo);
            vehicleList.Add(bic);
            
            foreach(var v in vehicleList)
                Console.WriteLine(v);
            Console.WriteLine("---Onground vehicles---\n");
            var groundVehicles = vehicleList.Where(vehicle => vehicle.actualEnv == Environments.OnGround);
            foreach(var v in groundVehicles)
                Console.WriteLine(v);
            Console.WriteLine("---By Speed ascending---\n");
            volvo.Accelerate(150);
            amph.Accelerate(100);
            amph.Sail();
            cessna.Accelerate(100);
            cessna.Fly();
            cessna.Accelerate(150);
            hydro.Accelerate(40);
            hydro.Fly();
            hydro.Accelerate(180);
            titanic.Accelerate(40);
            ufo.Accelerate(100);
            ufo.Fly();
            ufo.Accelerate(200);
            bic.Accelerate(350);
            Console.WriteLine();
            var bySpeedAsc = vehicleList.OrderBy(vehicle => Vehicle.UnitConverter(vehicle.ActualSpeed, vehicle.actualUnit, SpeedUnits.KMpH));
            foreach(var v in bySpeedAsc)
                Console.WriteLine(v);
            Console.WriteLine("---Onground vehicles orderder by speed descending---\n");
            var groundByDesc = vehicleList.Where(vehicle => vehicle.actualEnv == Environments.OnGround).OrderByDescending(vehicle => Vehicle.UnitConverter(vehicle.ActualSpeed, vehicle.actualUnit, SpeedUnits.KMpH));
            foreach (var v in groundByDesc)
                Console.WriteLine(v);

           
        }
    }
}
