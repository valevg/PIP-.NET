using System.Collections.Generic;
using System.Linq;
using PROGINETPRIL.Models;
using Microsoft.EntityFrameworkCore;
using PROGINETPRIL.Data;
using DOTENET.Repositories;

namespace PROGINETPRIL.Repositories;
public class SpecialtyRepository : ISpecialityRepository
{
    private readonly ApplicationDbContext _context;

    public SpecialtyRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Specialties> GetAllSpecialities()
    {
        return _context.Specialties.ToList();
    }

    public Specialties GetSpecialityById(int id)
    {
        return _context.Specialties.FirstOrDefault(s => s.SpecialtyId == id);
    }

    public Specialties CreateSpeciality(Specialties newSpeciality)
    {
        _context.Specialties.Add(newSpeciality);
        _context.SaveChanges();
        return newSpeciality;
    }

    public Specialties UpdateSpeciality(Specialties updatedSpeciality)
    {
        _context.Entry(updatedSpeciality).State = EntityState.Modified;
        _context.SaveChanges();
        return updatedSpeciality;
    }

    public void DeleteSpeciality(int id)
    {
        var speciality = _context.Specialties.FirstOrDefault(s => s.SpecialtyId == id);
        if (speciality != null)
        {
            _context.Specialties.Remove(speciality);
            _context.SaveChanges();
        }
    }

}
