using System;
using System.Windows.Forms;
public class Form1:Form{
    public Form1(){
        btn=new Button();
        btn.Text="btn";
        this.Controls.Add(btn);
        this.btn.Location=new System.Drawing.Point(160,50);
    }
    
    Button btn;

    public static void Main(string[] args)
    {
        
        Application.Run(new Form1());
    }
}