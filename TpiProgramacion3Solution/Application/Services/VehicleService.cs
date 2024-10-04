using Application.Interfaces;
using Domain.Classes;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    internal class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        //el encargado de crear los objetos es el service
        public Vehicledto CreateVehicle(CreateVehicleRequest request)
        {
            new newObj = new Vehicle(request.brand, request.year, request.model);
            _vehicleRepository.Add(vehicle);
            return VehicleDto.create(Vehicle vehicle);

        }

        public void DeleteVehicle(Vehicle vehicle)
        {
            _vehicleRepository.Delete(vehicle);
        }

        public Vehicle GetVehicleById(int id)
        {
            return _vehicleRepository.GetVehicleById(id);
        }
        //GetByVehicleById
        public List<Vehicle> GetAllVehicles()
        {
            return _vehicleRepository.GetAll();
        }
    }
}
