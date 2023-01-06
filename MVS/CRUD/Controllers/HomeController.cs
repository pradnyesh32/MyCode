using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUD.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using entities;

namespace CRUD.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

     public IActionResult Validate(string email,string password)
    {
            bool flag =false;
            Console.WriteLine(email);
            Console.WriteLine(password);

        try{
            string fileName=@"C:\CSharp Projects\MVS\CRUD\wwwroot\admins.json";
            string jsonString = System.IO.File.ReadAllText(fileName);
            List<Admin>? jsonAdmins = JsonSerializer.Deserialize<List<Admin>>(jsonString);


            // dynamic data type variable
            var options=new JsonSerializerOptions {IncludeFields=true};
            var produtsJson=JsonSerializer.Serialize<List<Admin>?>(jsonAdmins,options);
            
            //Serialize all Flowers into json file

            System.IO.File.WriteAllText(fileName,produtsJson);
            //Deserialize from JSON file
            string jstring = System.IO.File.ReadAllText(fileName);
            List<Admin>? jsonAd = JsonSerializer.Deserialize<List<Admin>>(jstring);
            Console.WriteLine("\n JSON :Deserializing data from json file\n \n");
            Console.WriteLine("bfe");
            foreach( Admin ad in jsonAd)
            {   Console.WriteLine(ad.Email);
            Console.WriteLine(ad.Password);
                 
                if(ad.Email==email && ad.Password==password){
                    Console.WriteLine(ad);
                    flag=true;
                    
                }
            }   
    }
   catch(Exception e){
    string s=e.Message;
        Console.WriteLine("err  "+s);
           
    }
    if(!flag){
    return Redirect("/home/privacy");
    }
    else{
        return Redirect("/home/Welcome");
    }
    }

     public IActionResult Welcome()
    {
        return View();
    }




    public IActionResult Register()
    {
        return View();
    }


    public IActionResult Add(string name,string email,string password)
    {
        try{
            string fileName=@"C:\CSharp Projects\MVS\CRUD\wwwroot\admins.json";
            string jsonString = System.IO.File.ReadAllText(fileName);
            List<Admin>? jsonAdmins = JsonSerializer.Deserialize<List<Admin>>(jsonString);
            Admin ad = new Admin(name,email,password);
            jsonAdmins.Add(ad);
            var options=new JsonSerializerOptions {IncludeFields=true};
            var produtsJson=JsonSerializer.Serialize<List<Admin>?>(jsonAdmins,options);
            System.IO.File.WriteAllText(fileName,produtsJson);



            }
   catch(Exception e){
    string s=e.Message;
        Console.WriteLine("err  "+s);
           
    }


        return Redirect("/home");
    }


    public IActionResult Login(){
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
