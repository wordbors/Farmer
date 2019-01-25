using System;
using System.Collections.Generic;
using System.Text;
using Farmer.Data.Models;
using Farmer.Data;
using System.Linq;

namespace Farmer.Services.Implementations
{
    public class NomenclaturesService : INomenclaturesService
    {
        private readonly FarmerDbContext db;

        public NomenclaturesService(FarmerDbContext farmerDb)
        {
            db = farmerDb;
        }
        public void CreateVillage(string name)
        {
            throw new NotImplementedException();
        }

        public void DeleteVillage(int id)
        {
            throw new NotImplementedException();
        }

        public void EditVillage(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Places> GetPlaces()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Villages> GetVillages()
        {
            return db.Villages.ToList();
        }

        public IEnumerable<WorkTypes> GetWorkTypes()
        {
            throw new NotImplementedException();
        }
    }
}
