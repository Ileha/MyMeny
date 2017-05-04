using System;
using System.Collections.Generic;

namespace MyMeny
{
	public class ControllOfGroup
	{
		public GroupeOfButton CurrentGrope;
		public int LenghtOfgropes {
			get {return gropes.Count;}
		}
		private List<GroupeOfButton> gropes;

		public ControllOfGroup ()
		{
			gropes = new List<GroupeOfButton>();
		}

		public void AddGroupe(params string[] HedLines) {
			for (int i = 0;i<HedLines.Length;i++) {
				DeleteGroupe(HedLines[i]);
				gropes.Add(new GroupeOfButton(HedLines[i],this));
				if (gropes.Count == 1 || CurrentGrope == null) {
					CurrentGrope = gropes[gropes.Count-1];
				}
			}
		}

		public void DeleteGroupe (string name) {
			gropes.RemoveAll(i => i.Header == name);
		}
		public void DeleteGroupe (GroupeOfButton meny) {
			gropes.Remove(meny);
		}

		public GroupeOfButton GetGrupe(string name) {
			//GroupeOfButton res;
			foreach (GroupeOfButton gr in gropes) {
				if (gr.Header == name) {
					return gr;
					//break;
				}
			}
			return null;
		}

		public void print() {
			CurrentGrope.WriteMeny();
		}

		//индексаторы
		public GroupeOfButton this[int index] {
			set
			{
				gropes[index] = value;
			}

			get
			{
				return gropes[index];
			}
		}
	}
}

