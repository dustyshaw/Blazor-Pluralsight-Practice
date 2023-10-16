using System.ComponentModel.DataAnnotations;

namespace MyFirstBlazorApp.Data.Modals;

public class Employee
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string? FirstName { get; set; }

    [Required]
    [StringLength(50)]
    public string? LastName { get; set; }

    public bool IsDeveloper { get; set; }

    public string ImageUrl { get; set; }    

    [Required]
    public int? DepartmentId { get; set; }

    public Department? Department {get; set;}

}
