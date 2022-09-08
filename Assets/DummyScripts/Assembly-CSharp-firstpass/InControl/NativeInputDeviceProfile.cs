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
	public abstract class NativeInputDeviceProfile : InputDeviceProfile // TypeDefIndex: 7819
	{
		// Fields
		public NativeInputDeviceMatcher[] Matchers; // 0x60
		public NativeInputDeviceMatcher[] LastResortMatchers; // 0x68
	
		// Constructors
		public NativeInputDeviceProfile() {} // 0x00000001893C49D0-0x00000001893C4A90
	
		// Methods
		// [IDTag] // 0x0000000189855F70-0x0000000189855FB0
		// [XID] // 0x0000000189855F70-0x0000000189855FB0
		internal bool Matches(NativeDeviceInfo deviceInfo) => default; // 0x00000001893C3F30-0x00000001893C4030
		// [XID] // 0x00000001898604D0-0x00000001898604F0
		internal bool LastResortMatches(NativeDeviceInfo deviceInfo) => default; // 0x00000001893C3310-0x00000001893C3410
		// [IDTag] // 0x0000000189867BB0-0x0000000189867BF0
		// [XID] // 0x0000000189867BB0-0x0000000189867BF0
		private bool Matches(NativeDeviceInfo deviceInfo, NativeInputDeviceMatcher[] matchers) => default; // 0x00000001893C3DB0-0x00000001893C3F30
		// [XID] // 0x00000001896B00D0-0x00000001896B00F0
		protected static InputControlSource Button(int index) => default; // 0x00000001893C2A10-0x00000001893C2AD0
		// [XID] // 0x000000018998FD40-0x000000018998FD60
		protected static InputControlSource Analog(int index) => default; // 0x00000001893C2950-0x00000001893C2A10
		// [XID] // 0x0000000189997650-0x0000000189997670
		protected static InputControlMapping LeftStickLeftMapping(int analog) => default; // 0x00000001893C36D0-0x00000001893C3830
		// [XID] // 0x0000000189888210-0x0000000189888230
		protected static InputControlMapping LeftStickRightMapping(int analog) => default; // 0x00000001893C3830-0x00000001893C3990
		// [XID] // 0x000000018988F7E0-0x000000018988F800
		protected static InputControlMapping LeftStickUpMapping(int analog) => default; // 0x00000001893C3AF0-0x00000001893C3C50
		// [XID] // 0x00000001899551C0-0x00000001899551E0
		protected static InputControlMapping LeftStickDownMapping(int analog) => default; // 0x00000001893C3570-0x00000001893C36D0
		// [XID] // 0x000000018989E250-0x000000018989E270
		protected static InputControlMapping LeftStickUpMapping2(int analog) => default; // 0x00000001893C3990-0x00000001893C3AF0
		// [XID] // 0x00000001898A5C70-0x00000001898A5C90
		protected static InputControlMapping LeftStickDownMapping2(int analog) => default; // 0x00000001893C3410-0x00000001893C3570
		// [XID] // 0x00000001899642B0-0x00000001899642D0
		protected static InputControlMapping RightStickLeftMapping(int analog) => default; // 0x00000001893C42F0-0x00000001893C4450
		// [XID] // 0x000000018996B910-0x000000018996B930
		protected static InputControlMapping RightStickRightMapping(int analog) => default; // 0x00000001893C4450-0x00000001893C45B0
		// [XID] // 0x00000001898BC410-0x00000001898BC430
		protected static InputControlMapping RightStickUpMapping(int analog) => default; // 0x00000001893C4710-0x00000001893C4870
		// [XID] // 0x00000001898C37B0-0x00000001898C37D0
		protected static InputControlMapping RightStickDownMapping(int analog) => default; // 0x00000001893C4190-0x00000001893C42F0
		// [XID] // 0x00000001899A6C10-0x00000001899A6C30
		protected static InputControlMapping RightStickUpMapping2(int analog) => default; // 0x00000001893C45B0-0x00000001893C4710
		// [XID] // 0x00000001898D28E0-0x00000001898D2900
		protected static InputControlMapping RightStickDownMapping2(int analog) => default; // 0x00000001893C4030-0x00000001893C4190
		// [XID] // 0x00000001898DA210-0x00000001898DA230
		protected static InputControlMapping LeftTriggerMapping(int analog) => default; // 0x00000001893C3C50-0x00000001893C3DB0
		// [XID] // 0x00000001899C4CF0-0x00000001899C4D10
		protected static InputControlMapping RightTriggerMapping(int analog) => default; // 0x00000001893C4870-0x00000001893C49D0
		// [XID] // 0x00000001898E9B50-0x00000001898E9B70
		protected static InputControlMapping DPadLeftMapping(int analog) => default; // 0x00000001893C2D90-0x00000001893C2EF0
		// [XID] // 0x00000001898F1060-0x00000001898F1080
		protected static InputControlMapping DPadRightMapping(int analog) => default; // 0x00000001893C2EF0-0x00000001893C3050
		// [XID] // 0x00000001899F31A0-0x00000001899F31C0
		protected static InputControlMapping DPadUpMapping(int analog) => default; // 0x00000001893C31B0-0x00000001893C3310
		// [XID] // 0x00000001899002F0-0x0000000189900310
		protected static InputControlMapping DPadDownMapping(int analog) => default; // 0x00000001893C2C30-0x00000001893C2D90
		// [XID] // 0x00000001899079B0-0x00000001899079D0
		protected static InputControlMapping DPadUpMapping2(int analog) => default; // 0x00000001893C3050-0x00000001893C31B0
		// [XID] // 0x0000000189A094F0-0x0000000189A09510
		protected static InputControlMapping DPadDownMapping2(int analog) => default; // 0x00000001893C2AD0-0x00000001893C2C30
	}
}
