using System;
public class Person{

    public int Number{set;get;}
    private int age;
    public int Age{
        get {
            return age;
        }
    }
    /*
    public int getAge(){
        return age;
    }
    public void setAge(int val)
    {
        age=val;
    }*/
}

class ValidVoter{

    public bool chk(Person obj){
          //  if((obj.getAge()>17)){
    /*          if(obj.Age>17){
                return true;
            }
            else
            {
                return false;
            }*/
            return true;
    }
}

public class Demo{
    public static void Main(string[] args){
            ValidVoter v=new ValidVoter();
            Person p=new Person();
       //     p.Age=19;
            p.Number=1234;
            Console.WriteLine("number of voter is="+p.Number);
            Console.WriteLine("Is a voter="+v.chk(p));
            /*p.setAge(19);
            Console.WriteLine(p.getAge());
            Console.WriteLine("Is a voter="+v.chk(p));
            */
    }
}

