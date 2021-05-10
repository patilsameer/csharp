using System.Windows.Forms;
using System;

public class Form1 : Form
{
	public Form1(){
		btn1=new Button();		
		btn1.Text="Btn1";
		this.Controls.Add(btn1);
		btn1.Click+=new System.EventHandler(this.evn);
		txt=new TextBox();
		txt.Location=new System.Drawing.Point(159,55);
		this.Controls.Add(txt);
	}
	public void evn(object sender,EventArgs ev)
	{
		System.Console.WriteLine("evn method");
		string msg=txt.Text;
		System.Console.WriteLine(msg);
	}

	Button btn1;
	TextBox txt;
	public static void Main(string[] args){
		Application.Run(new Form1());
	}
}