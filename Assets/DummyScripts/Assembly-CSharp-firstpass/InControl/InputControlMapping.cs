/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	public class InputControlMapping // TypeDefIndex: 7622
	{
		// Fields
		public InputControlSource Source; // 0x10
		public InputControlType Target; // 0x18
		public bool Invert; // 0x1C
		public float Scale; // 0x20
		public bool Raw; // 0x24
		public bool Passive; // 0x25
		public bool IgnoreInitialZeroValue; // 0x26
		public float Sensitivity; // 0x28
		public float LowerDeadZone; // 0x2C
		public float UpperDeadZone; // 0x30
		public InputRange SourceRange; // 0x34
		public InputRange TargetRange; // 0x40
		private string handle; // 0x50
	
		// Properties
		public string Handle { /* [XID] */ /* 0x000000018997EFD0-0x000000018997EFF0 */ get => default; /* [XID] */ /* 0x00000001898FCFA0-0x00000001898FCFC0 */ set {} } // 0x00000001870C9B10-0x00000001870C9C40 0x00000001870C9C40-0x00000001870C9D90
	
		// Constructors
		public InputControlMapping() {} // 0x00000001870C9A20-0x00000001870C9B10
	
		// Methods
		// [XID] // 0x0000000189977E20-0x0000000189977E40
		public float MapValue(float value) => default; // 0x00000001870C9850-0x00000001870C9A20
	}
}
