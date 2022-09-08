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
	public class InputControl : OneAxisInputControl // TypeDefIndex: 7621
	{
		// Fields
		public static readonly InputControl Null; // 0x00
		public bool Passive; // 0x84
		private ulong zeroTick; // 0x88
	
		// Properties
		public string Handle { /* [XID] */ /* 0x0000000189B6D870-0x0000000189B6D8B0 */ get; protected set; } // 0x00000001870CA9D0-0x00000001870CAA30 0x00000001870CAD00-0x00000001870CAD60
		public InputControlType Target { /* [XID] */ /* 0x00000001898A4410-0x00000001898A4450 */ get; protected set; } // 0x00000001870CACA0-0x00000001870CAD00 0x00000001870CAE40-0x00000001870CAEB0
		public bool IsButton { /* [XID] */ /* 0x00000001898B5FB0-0x00000001898B5FF0 */ get; protected set; } // 0x00000001870CAA90-0x00000001870CAAF0 0x00000001870CADD0-0x00000001870CAE40
		public bool IsAnalog { get; protected set; } // 0x00000001870CAA30-0x00000001870CAA90 0x00000001870CAD60-0x00000001870CADD0
		internal bool IsOnZeroTick { /* [XID] */ /* 0x00000001898DF010-0x00000001898DF030 */ get => default; } // 0x00000001870CAAF0-0x00000001870CABA0 
		public bool IsStandard { /* [XID] */ /* 0x0000000189922830-0x0000000189922850 */ get => default; } // 0x00000001870CABA0-0x00000001870CACA0 
	
		// Constructors
		private InputControl() {} // 0x00000001870CA5E0-0x00000001870CA750
		public InputControl(string handle, InputControlType target) {} // 0x00000001870CA7E0-0x00000001870CA9D0
		public InputControl(string handle, InputControlType target, bool passive) {} // 0x00000001870CA750-0x00000001870CA7E0
		static InputControl() {} // 0x00000001870CA550-0x00000001870CA5E0
	
		// Methods
		// [XID] // 0x0000000189961330-0x0000000189961350
		internal void SetZeroTick() {} // 0x00000001870CA4A0-0x00000001870CA550
	}
}
