namespace Login;

public class DacStudent:Student{

    public int[] Marks{get;set;}

    public DacStudent(int id,string name,string email,int[] mark):base(id,name,email){
        int[] Marks = mark;
    }

    public override double Average(){
        int sum=0;
        foreach(int m in Marks){
            sum+=m;
        }
        return sum/Marks.Length;
    }
}