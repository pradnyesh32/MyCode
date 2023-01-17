
using Microsoft.AspNetCore.Mvc;
using EndmodApp.Models;
using stud;
using db;
namespace EndmodApp.Controllers;

public class StudsController : Controller
{
    private readonly ILogger<StudsController> _logger;

    public StudsController(ILogger<StudsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

     public IActionResult Studlist()
    {
        List<Student> studs = DB.GetAllStudents();
        foreach(Student s in studs){
            
        }
        ViewData["prop"]=studs;
        return View();
    }

     public IActionResult Addstud()
    {
        return View();
    }

     public IActionResult Insert()
    {   
        var id = Convert.ToInt32(Request.Query["id"]);
        var name=Request.Query["name"];
        var c=Request.Query["course"];
        Student s = new Student(id,name,c);
        DB.SaveNewUser(s);
    
        return Redirect("Studlist");
    }


     public IActionResult Deletestud()
    {   
        var id = Convert.ToInt32(Request.Query["Id"]);
       
        DB.DeleteUserById(id);
    
        return Redirect("Studlist");
    }

     public IActionResult Update()
    {   
        var id = Convert.ToInt32(Request.Query["id"]);
        var name=Request.Query["name"];
        var c=Request.Query["course"];
        Student s = new Student(id,name,c);
        DB.SaveNewUser(s);
    
        return Redirect("Studlist");
    }




}
