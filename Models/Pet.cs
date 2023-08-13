using System.ComponentModel.DataAnnotations;

namespace midterm_project.Models;

public class Pet
{
    public int PetId { get; set; }
    [Required]
    [Display(Name = "Pet Species")]

    public string? PetSpecies { get; set; }
    [Required]
    [Display(Name = "Photo")]

    public string? PhotoUrl { get; set; }
    [Required]
    [Display(Name = "Pet Description")]

    public string? PetDescription { get; set; }
    [Required]
    [Display(Name = "Spaying")]

    public Boolean? Spayed { get; set; }
    [Required, Range(0, 100)]
    [Display(Name = "Pet Age")]

    public int PetAge { get; set; }
    [Display(Name = "All Administered Shots")]

    public string? ShotsAndVaccinations { get; set; }

}