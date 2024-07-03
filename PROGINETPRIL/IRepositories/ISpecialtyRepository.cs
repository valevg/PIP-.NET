using System.Collections.Generic;
using PROGINETPRIL.Models;

namespace DOTENET.Repositories
{
    public interface ISpecialityRepository
    {
        List<Specialties> GetAllSpecialities();
        Specialties GetSpecialityById(int id);
        Specialties CreateSpeciality(Specialties newSpeciality);
        Specialties UpdateSpeciality(Specialties updatedSpeciality);
        void DeleteSpeciality(int id);
    }

    
}