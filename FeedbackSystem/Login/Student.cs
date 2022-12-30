namespace Login;

public abstract class Student{
    public int StudentId{get;set;}
    public string StudentName{get;set;}
    public string Email{get;set;}


    public Student(int id,string name,string email){
        this.StudentId=id;
        this.StudentName=name;
        this.Email=email;
    }

    public Student():this(0,"Unknown","Unknown"){

    }

    public abstract double Average();
    

    public override string ToString(){
        string str = String.Format("{0} {1} {2}",StudentId,StudentName,Email);
        return str;
    }


}