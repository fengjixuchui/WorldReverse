/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread
{
	public class MainThreadRunner : IRunner // TypeDefIndex: 9028
	{
		// Properties
		public bool paused { get; /* [XID] */ /* 0x00000001897F7160-0x00000001897F71A0 */ set; } // 0x00000001876312E0-0x0000000187631340 0x0000000187631340-0x00000001876313A0
		public bool isStopping { /* [XID] */ /* 0x00000001898A0EB0-0x00000001898A0ED0 */ get => default; } // 0x00000001876311A0-0x0000000187631240 
		public int numberOfRunningTasks { /* [XID] */ /* 0x00000001898A8480-0x00000001898A84A0 */ get => default; } // 0x0000000187631240-0x00000001876312E0 
	
		// Constructors
		public MainThreadRunner() {} // 0x0000000187631140-0x00000001876311A0
	
		// Methods
		// [XID] // 0x00000001896FC3F0-0x00000001896FC410
		public void StartNode(INode node) {} // 0x0000000187630F80-0x00000001876310A0
		// [XID] // 0x0000000189817FC0-0x0000000189817FE0
		public void StopAllNodes() {} // 0x00000001876310A0-0x0000000187631140
		// [XID] // 0x000000018981F8B0-0x000000018981F8D0
		public void Kill(Action onRunnerKilled) {} // 0x0000000187630ED0-0x0000000187630F80
		// [XID] // 0x00000001898DEBB0-0x00000001898DEBD0
		public void Destroy() {} // 0x0000000187630E30-0x0000000187630ED0
	}
}
