﻿using DesignPatterns.CreationalPatterns.AbstractFactoryPatterns.VehicleCompany.Abstractions;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPatterns.Initializers
{
    public sealed class AbstractFactoryTest
    {
        private readonly IVehicleFactory _vehicleFactory = new VehicleFactory();
        public void Test()
        {
            Console.WriteLine("------------------");
            var car = _vehicleFactory.CreateCar();
            var truck = _vehicleFactory.CreateTruck();
            var jet = _vehicleFactory.CreateJet();
            var plane = _vehicleFactory.CreatePlane();
            Console.WriteLine("------------------");
            car.Move();
            truck.Move();
            jet.Fly();
            plane.Fly();
            Console.WriteLine("------------------");
        }
    }
}
