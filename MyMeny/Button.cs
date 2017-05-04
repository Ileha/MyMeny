using System;

namespace MyMeny {
	public delegate void Func(Button butt);
	public class Button
	{
		public string title;
		public Func RefFunc;
		public GroupeOfButton MyGroupe;
		public bool interactable;

		public Button (string titl, Func fu, GroupeOfButton groupe) {
			title = titl;
			RefFunc = fu;
			MyGroupe = groupe;
			//MyGroupe.Content.Add(this);
			interactable = true;
		}

		public void DoFunc() {
			RefFunc(this);
			//MyGroupe.MyControll.print();
		}
	}
}

