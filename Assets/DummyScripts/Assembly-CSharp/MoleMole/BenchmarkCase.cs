/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public sealed class BenchmarkCase : BMCaseBase, IBMCaseRunner // TypeDefIndex: 27588
	{
		// Fields
		public float defaultEachCaseBenchmarkTime; // 0x18
		public string objRefClusterPath; // 0x20
		public BenchmarkCommandGroup[] cases; // 0x28
		private SOBORCInstance _orcInstance; // 0x30
	
		// Properties
		public int caseCount { /* [XID] */ /* 0x0000000189B27C40-0x0000000189B27C60 */ get => default; } // 0x0000000181ACE100-0x0000000181ACE1B0 
	
		// Constructors
		public BenchmarkCase() {} // 0x0000000181ACE080-0x0000000181ACE100
	
		// Methods
		// [XID] // 0x0000000189B20570-0x0000000189B20590
		public static bool IsAlmostEqual(float a, float b) => default; // 0x0000000181ACDCA0-0x0000000181ACDDB0
		[DebuggerHidden] // 0x0000000189B2EF50-0x0000000189B2EF90
		// [XID] // 0x0000000189B2EF50-0x0000000189B2EF90
		public IEnumerator Run(int startCaseID, Action<string, int> onStartBMCase, Action<string, int> onEndBMCase, Action<string> onExecuteCommand, Action<string, object> onExecuteCommandWithObject, Action<string> onExecuteLuaShell, float timeScale = 1f /* Metadata: 0x00B0CA57 */) => default; // 0x0000000181ACDDB0-0x0000000181ACDF70
		// [XID] // 0x0000000189B39910-0x0000000189B39930
		public override void Dispose() {} // 0x0000000181ACDF70-0x0000000181ACE020
	}
}
