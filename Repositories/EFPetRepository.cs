using midterm_project.Migrations;
using midterm_project.Models;
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
        _context.Pet.Add(newPet);
        _context.SaveChanges();
        return newPet;
    }

    public void DeletePetById(int petId)
{
    var pet = _context.Pet.Find(petId); 
    if (pet != null) {
        _context.Pet.Remove(pet); 
        _context.SaveChanges(); 
    }
}

    public IEnumerable<Pet> GetAllPets()
    {
        return _context.Pet.ToList();
    }

    public Pet GetPetById(int petId)
    {
        return _context.Pet.SingleOrDefault(c => c.PetId == petId);
    }

    public Pet UpdatePet(Pet newPet)
    {
        var originalPet = _context.Pet.Find(newPet.PetId);
        if (originalPet != null)
        {
            originalPet.PetSpecies = newPet.PetSpecies;
            originalPet.PhotoUrl = newPet.PhotoUrl;
            originalPet.PetDescription = newPet.PetDescription;
            originalPet.Spayed = newPet.Spayed;
            originalPet.PetAge = newPet.PetAge;
            originalPet.ShotsAndVaccinations = newPet.ShotsAndVaccinations;
            _context.SaveChanges();
        }
        return originalPet;
    }
}