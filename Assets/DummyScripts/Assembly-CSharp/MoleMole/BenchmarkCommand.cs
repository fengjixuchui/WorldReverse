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
	public class BenchmarkCommand // TypeDefIndex: 27584
	{
		// Fields
		public const int CMDValueType_LuaShell = -1; // Metadata: 0x00B0CA47
		public const int CMDValueType_ConsoleCommand = 0; // Metadata: 0x00B0CA4B
		public const int CMDValueType_UnityObject = 1; // Metadata: 0x00B0CA4F
		public int cmdValueType; // 0x10
		public string cmdValue; // 0x18
		public string command; // 0x20
	
		// Constructors
		public BenchmarkCommand() {} // 0x0000000181ACE560-0x0000000181ACE5D0
	
		// Methods
		// [XID] // 0x0000000189B0A450-0x0000000189B0A470
		public void OnExecute(Action<string> onExecuteCommand, Action<string, object> onExecuteCommandWithObject, IUnityObjectLoader loader, Action<string> onExecuteLuaShell) {} // 0x0000000181ACE3A0-0x0000000181ACE560
	}
}
