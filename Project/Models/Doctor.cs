using System.ComponentModel.DataAnnotations;

namespace Project.Models;

public class Doctor
{
    public int Id { get; set; }
    [MaxLength(150)]
    public string Name { get; set; }
    public DateTime HireDate { get; set; }
    // [Precision(8,2)]
    public double Salary { get; set; }

}
