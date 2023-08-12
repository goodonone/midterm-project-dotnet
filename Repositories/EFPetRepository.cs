using midterm_project.Migrations;
using midterm_project.Models;
using midterm_project.Repositories;

namespace midterm_project.Repositories;

public class EFPetRepository : IPetRepository
{
    private readonly PetDbContext _context;

    public EFPetRepository(PetDbContext context)
    {
        _context = context;
    }

    public Pet CreatePet(Pet newPet)
    {
        throw new NotImplementedException();
    }

    public void DeletePetById(int petId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Pet> GetAllPets()
    {
        throw new NotImplementedException();
    }

    public Pet GetPetById(int petId)
    {
        throw new NotImplementedException();
    }

    public Pet UpdatePet(Pet newPet)
    {
        throw new NotImplementedException();
    }
}