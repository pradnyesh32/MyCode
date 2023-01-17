namespace stud;

public class Student{

    public int Id{get;set;}
    public string? Name{get;set;}
    public string? Course{get;set;}

    public Student(int id,string name,string course){
        this.Id=id;
        this.Name=name;
        this.Course=course;
    }

}