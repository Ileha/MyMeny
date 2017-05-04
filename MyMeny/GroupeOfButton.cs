using System;
using System.Collections.Generic;

namespace MyMeny
{
	public class GroupeOfButton
	{
		public string Header;
		private List<Button> Content = new List<Button>();
		public int LenghtOfButton {
			get {return Content.Count;}
		}
		public ControllOfGroup MyControll{get;}

		public GroupeOfButton (string hed, ControllOfGroup controller) {
			Header = hed;
			MyControll = controller;
		}

		public void AddButton(string titl, Func funce) {
			Content.Add(new Button(titl, funce, this));
		}

		public void DeleteButton (string name) {
			Content.RemoveAll(i => i.title == name);
		}
		public void DeleteButton (Button meny) {
			Content.Remove(meny);
		}

		public void WriteMeny() {
			Console.WriteLine();
			Console.Write("***{0}***\n",Header);
			for (int i = 0;i<Content.Count;i++) {
				Console.Write(i+1+") "+Content[i].title+"\n");
			}
			Console.Write("Enter number: ");
			int num = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			while (num <= 0 || num > Content.Count) {
				Console.Write("Error...\n");
				Console.Write("Enter number again: ");
				num = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine();
			}
			Content[num-1].DoFunc();
			//return Content[num-1];
		}

		//индексаторы
		public Button this[int index] {
			set
			{
				Content[index] = value;
			}

			get
			{
				return Content[index];
			}
		}
	}
}

