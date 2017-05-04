using System;
using System.Collections.Generic;

namespace MyMeny
{
	public class Run : RuntimeClass {

		public override void Start ()
		{
			controll.AddGroupe("Main","Title 01");
			controll.GetGrupe("Main").AddButton("title_01",title_01);
			controll.GetGrupe("Main").AddButton("Print",Hello);
			controll.GetGrupe("Main").AddButton("Exit",exit);
			controll.GetGrupe("Title 01").AddButton("Print for Title 01", Hello);
			controll.GetGrupe("Title 01").AddButton("Bask",ChangeGroupe);
		}

		public override void Updates () {
			Console.WriteLine("123");
		}

		public void title_01(Button button) {
			controll.CurrentGrope = controll.GetGrupe("Title 01");
		}

		public void ChangeGroupe(Button button) {
			controll.CurrentGrope = controll.GetGrupe("Main");
		}

		public void Hello(Button button) {
			Console.WriteLine("enter your name: ");
			string name = Console.ReadLine();
			Console.WriteLine("Hello {0}",name);
		}

		public void exit(Button button) {
			ExitProgramm();
		}
	}
}