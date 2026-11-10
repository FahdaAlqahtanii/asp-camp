namespace Project.Models;

public class Data
{
    public static List<Patient> Patients { get; set; } = new List<Patient>()
    {
        new Patient { Id = 1, Name = "Ahmed Ali", VisitDate = new DateTime(2024, 5, 10) },
        new Patient { Id = 2, Name = "Sara Mohammed", VisitDate = new DateTime(2023, 8, 15) },
        new Patient { Id = 3, Name = "Khalid Hassan", VisitDate = new DateTime(2024, 1, 20) },
        new Patient { Id = 4, Name = "Noura Abdullah", VisitDate = new DateTime(2022, 11, 5) },
        new Patient { Id = 5, Name = "Faisal Omar", VisitDate = new DateTime(2025, 3, 12) }
    };
}