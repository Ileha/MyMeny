using System;
using System.Collections.Generic;

namespace MyMeny
{
	public enum ProgrammStage {
		Awake,
		Start,
		Run,
		Exit
	}

	public class RuntimeClass
	{
		public ProgrammStage Stage = ProgrammStage.Awake;
		public ControllOfGroup controll = new ControllOfGroup();

		public void RunProgram() {
			Stage = ProgrammStage.Start;
			Start();
			Stage = ProgrammStage.Run;
			do {
				controll.print();
				Updates();
			} while(Stage == ProgrammStage.Run);
			if (Stage != ProgrammStage.Exit) {
				Stage = ProgrammStage.Exit;
			}
			Stop();
		}

		public void ExitProgramm() {
			Stage = ProgrammStage.Exit;
		}


		public virtual void Start(){}
		public virtual void Updates(){}
		public virtual void Stop(){}
	}
}
	