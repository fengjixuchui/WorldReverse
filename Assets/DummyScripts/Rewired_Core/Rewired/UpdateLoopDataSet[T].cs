/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Config;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001897DEF10-0x00000001897DEF80
	[CustomObfuscation] // 0x00000001897DEF10-0x00000001897DEF80
	internal class UpdateLoopDataSet<T> // TypeDefIndex: 3511
		where T : class
	{
		// Fields
		private OhabrbNxoqPeBqThgRDKwFGKMKG AaXfcgJdekgBaHxoPeTTheDgCVGd;
		private int oCjExPQBVRiArAcbiSwTmwqUBqb;
		public readonly int fixedUpdateSetIndex;
		private readonly int[] xcSjpzzrNYXAIxAxYcwPczRgjNT;
		private readonly OhabrbNxoqPeBqThgRDKwFGKMKG[] mtnCXNhGEJZnJZGQpwPudPTRhtR;
		private UpdateLoopType gBuNkASdFGZVNuOTDPDQpcgOAgT;
	
		// Properties
		public T Current { get => default; }
		public int Count { get => default; }
		public T this[int index] { get => default; set {} }
	
		// Nested types
		private class OhabrbNxoqPeBqThgRDKwFGKMKG // TypeDefIndex: 3512
		{
			// Fields
			public readonly UpdateLoopType uZqPISCyPgGPOetNKiFUKtuJqjV;
			public T AdqDRmvMCTHHDQWIUGnRloZhdLl;
	
			// Constructors
			public OhabrbNxoqPeBqThgRDKwFGKMKG() {} // Dummy constructor
			public OhabrbNxoqPeBqThgRDKwFGKMKG(UpdateLoopType updateLoop) {}
		}
	
		// Constructors
		public UpdateLoopDataSet() {} // Dummy constructor
		public UpdateLoopDataSet(UpdateLoopSetting updateLoops) {}
		public UpdateLoopDataSet(UpdateLoopSetting updateLoops, Func<T> instantiatorDelegate) {}
	
		// Methods
		public void SetUpdateLoop(UpdateLoopType updateLoop) {}
		public T Get(int index) => default;
		public T Get(UpdateLoopType updateLoop) => default;
		protected UpdateLoopType GetUpdateLoopType(int index) => default;
	}
}
