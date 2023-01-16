
using Microsoft.AspNetCore.Mvc;
using stud;
using dbconnect;

namespace endmod.Controllers;

public class StudentsController : Controller
{
    private readonly ILogger<StudentsController> _logger;

    public StudentsController(ILogger<StudentsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }


    public IActionResult ShowStudent()
    {
        List<Student> students = UsersDataAccess.GetAllStudent();

       ViewData["catalog"]=students;
        return View();
    }

    





}