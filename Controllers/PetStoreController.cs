using Microsoft.AspNetCore.Mvc;
using midterm_project.Models;
using midterm_project.Repositories;

namespace midterm_project.Controllers;

public class PetStoreController : Controller
{
    private readonly ILogger<PetStoreController> _logger;
    private readonly IPetRepository _petRepository;
    public PetStoreController(ILogger<PetStoreController> logger, IPetRepository repository)
    {
        _logger = logger;
        _petRepository = repository;
    }

    public IActionResult List()
    {
        return View(_petRepository.GetAllPets());
    }

    public IActionResult Detail(int id)
    {
        var pet = _petRepository.GetPetById(id);
        if (pet == null)
        {
            return View();
        }
        return View(pet);
    }

    public IActionResult Update(int id) 
    {
        var pet = _petRepository.GetPetById(id);

        if (pet == null) {
            return RedirectToAction("List");
        }

        return View(pet);
    }

    [HttpPost]
    public IActionResult Update(Pet pet)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        _petRepository.UpdatePet(pet);
        return RedirectToAction("List");
    }

    [HttpGet]
    public IActionResult Create()
    {

        return View();
    }

    [HttpPost]
    public IActionResult Create(Pet pet)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        _petRepository.CreatePet(pet);
        return RedirectToAction("Detail", new { id = pet.PetId });;
    }


    public IActionResult Delete(int id)
    {
        _petRepository.DeletePetById(id);

        return RedirectToAction("List");
    }


}


