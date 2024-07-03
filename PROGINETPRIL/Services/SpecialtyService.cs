using System.Collections.Generic;
using PROGINETPRIL.Models;
using DOTENET.Repositories;

namespace DOTENET.Services
{
    public class SpecialtyService : ISpecialtyService
    {
        private readonly ISpecialityRepository _specialityRepository;

        public SpecialtyService(ISpecialityRepository specialityRepository)
        {
            _specialityRepository = specialityRepository;
        }

        public List<Specialties> GetAllSpecialities()
        {
            return _specialityRepository.GetAllSpecialities();
        }

        public Specialties GetSpecialityById(int id)
        {
            return _specialityRepository.GetSpecialityById(id);
        }

        public Specialties CreateSpeciality(Specialties newSpeciality)
        {
            return _specialityRepository.CreateSpeciality(newSpeciality);
        }

        public Specialties UpdateSpeciality(Specialties updatedSpeciality)
        {
            return _specialityRepository.UpdateSpeciality(updatedSpeciality);
        }

        public void DeleteSpeciality(int id)
        {
            _specialityRepository.DeleteSpeciality(id);
        }
    }
}