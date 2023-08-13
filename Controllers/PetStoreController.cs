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

    public IActionResult Edit(int id)
    {
        var pet = _petRepository.GetPetById(id);
        if (pet == null)
        {
            return View();
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
    public IActionResult CreatePet()
    {

        return View();
    }

    [HttpPost]
    public IActionResult CreatePet(Pet pet)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        _petRepository.CreatePet(pet);
        return RedirectToAction("List");
    }


    public IActionResult DeletePetById(int id)
    {
        _petRepository.DeletePetById(id);

        return RedirectToAction("List");
    }


}


