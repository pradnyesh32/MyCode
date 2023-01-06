namespace entities;

public class Admin{
    public string Name{get;set;}
    public string Email{get;set;}
    public string Password{get;set;}

    public Admin(string name,string email,string password){
        this.Name=name;
        this.Email=email;
        this.Password=password;
    }

    public override string ToString()
    {
        return "Name : "+Name+"  Email : "+Email+" Password : "+Password;
    }

}