using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers;

public class PatientController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public PatientController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(Data.Patients);
    }

    public IActionResult Details(int id)
    {
        var Patient = Data.Patients.Single(d => d.Id == id);
        return View(Patient);
    }

    [HttpPost]
    public IActionResult Create(Patient patient)
    {

        if (!ModelState.IsValid)
        {
            return View();
        }

        patient.Id = Data.Patients.Max(d => d.Id) + 1;
        Data.Patients.Add(patient);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        var patient = Data.Patients.Single(d => d.Id == id);
        Data.Patients.Remove(patient);

        return RedirectToAction(nameof(Index));
    }
}