public class demo_base{
    private int j;
    public void setJ(int val){
        this.j=val;
    }

    public int getJ()
    {
        return j;
    }
}

public class A{
    public int k;
}

class D{
    public void data()
    {
        A obj=new A();
        obj.k=22;

        demo_base dbo=new demo_base();
        dbo.setJ(11);
        System.Console.WriteLine("the value of private member j of demo_base is="+dbo.getJ());

    }
}

public class B:A{
    public void data(int val)
    {
        k=val;
    }
}



public class Demo{
    public static void Main(string[] args)
    {
        B obj=new B();
        obj.data(22);
        D dobj=new D();
        dobj.data();
    }
}