using System.ComponentModel.DataAnnotations;

namespace midterm_project.Models;

public class Pet
{
    public int PetId { get; set; }
    [Required]
    [Display(Name = "Pet Species")]
    public string? PetSpecies { get; set; }
    [Required]
    [Display(Name = "Pet Description")]
    public string? PetDescription { get; set; }
    [Required]
    [Display(Name = "Spayed?")]

    public Boolean? spayed { get; set; }
    [Required, Range(0, 100)]
    [Display(Name = "Pet Age")]
    
    public int petAge { get; set; }
    [Display(Name = "Shots?")]

    public string? NecessaryShots { get; set; }

}