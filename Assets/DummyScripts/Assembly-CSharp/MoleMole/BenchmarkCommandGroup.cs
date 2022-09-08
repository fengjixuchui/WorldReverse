/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class BenchmarkCommandGroup // TypeDefIndex: 27585
	{
		// Fields
		public string name; // 0x10
		public BenchmarkCommand[] commands; // 0x18
		public float overrideBenchmarkTime; // 0x20
	
		// Constructors
		public BenchmarkCommandGroup() {} // 0x0000000181ACE330-0x0000000181ACE3A0
	
		// Methods
		// [XID] // 0x0000000189B11C70-0x0000000189B11C90
		public void Run(Action<string> onExecuteCommand, Action<string, object> onExecuteCommandWithObject, IUnityObjectLoader loader, Action<string> onExecuteLuaShell) {} // 0x0000000181ACE1B0-0x0000000181ACE330
	}
}
