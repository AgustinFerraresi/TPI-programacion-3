using Domain.Classes;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class DriverRepository : BaseRepository<Driver>, IDriverRepository
    {
        public DriverRepository(ApplicationContext context) : base(context)
        {

        }


        public Driver GetById(int id)
        {
            return Drivers.FirstOrDefault(driver => driver.Id == id);
        }

    }
}
