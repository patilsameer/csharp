interface Man{
	string getData();
}
public class A{

	public static void Main(string[]  args){
		Student obj=new Student();	
		obj.getData();
	}
}

class Person{
	public Person(){
		System.Console.WriteLine("Person");
	}
}

class Student:Person,Man{
	public string getData(){
		System.Console.WriteLine("I m the man");
		return "done";
	}
	public Student(){
		System.Console.WriteLine("Student");
	}
}
