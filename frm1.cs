using System;
using System.Windows.Forms;
public class Frm1 : Form
{
    Button btn1;
    public Frm1()
    {
            btn1=new Button();
            btn1.Text="Hello";
            
            this.Controls.Add(btn1);
            btn1.Location=new System.Drawing.Point(150,50);
            

    }
    public static void Main(string[] args){
            Application.Run(new Frm1());
    }
}