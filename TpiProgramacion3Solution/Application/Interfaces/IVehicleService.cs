using Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IVehicleService
    {
        void CreateVehicle(Vehicle vehicle);
        void DeleteVehicle(Vehicle vehicle);
        List<Vehicle> GetAllVehicles();
        Vehicle GetVehicleById(int id);
    }
}
