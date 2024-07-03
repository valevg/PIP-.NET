using System.Collections.Generic;
using PROGINETPRIL.Models;

namespace DOTENET.Services
{
    public interface ISpecialtyService
    {
        List<Specialties> GetAllSpecialities();
        Specialties GetSpecialityById(int id);
        Specialties CreateSpeciality(Specialties newSpeciality);
        Specialties UpdateSpeciality(Specialties updatedSpeciality);
        void DeleteSpeciality(int id);
    }
}