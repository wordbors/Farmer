using Farmer.Data.Models;
using System.Collections.Generic;

namespace Farmer.Services
{
    public interface INomenclaturesService
    {
        // Села
        IEnumerable<Villages> GetVillages();

        void CreateVillage(string name);

        void EditVillage(int id);

        void DeleteVillage(int id);





        // Места
        IEnumerable<Places> GetPlaces();

        // Тип работа
        IEnumerable<WorkTypes> GetWorkTypes();
    }
}
