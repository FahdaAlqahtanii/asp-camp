using System.ComponentModel.DataAnnotations;

namespace Project.Models;

public class Patient
{
    public int Id { get; set; }

    [MaxLength(150)]
    [RegularExpression("[a-zA-Z]{3,}", ErrorMessage = "Name must be 3 letters or more")]
    public string Name { get; set; }

    [Display(Name = "Visit Date")]
    public DateTime VisitDate { get; set; }

}
