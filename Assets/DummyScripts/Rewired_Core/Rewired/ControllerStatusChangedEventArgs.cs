/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	public sealed class ControllerStatusChangedEventArgs : EventArgs // TypeDefIndex: 3475
	{
		// Fields
		private string EqppaAHmTQvmVSSZadzlNpPBbHM; // 0x10
		private int ruGCBfCWNtGZeTUKxKBCHIMxrSyL; // 0x18
		private ControllerType xRMUSowrwSVmfxjnqwQXevUgxsr; // 0x1C
	
		// Properties
		public string name { get => default; } // 0x0000000185D60820-0x0000000185D60880 
		public int controllerId { get => default; } // 0x0000000185D60760-0x0000000185D607C0 
		public ControllerType controllerType { get => default; } // 0x0000000185D607C0-0x0000000185D60820 
	
		// Constructors
		public ControllerStatusChangedEventArgs() {} // Dummy constructor
		public ControllerStatusChangedEventArgs(string name, int uniqueId, ControllerType controllerType) {} // 0x0000000185D606C0-0x0000000185D60760
	}
}
