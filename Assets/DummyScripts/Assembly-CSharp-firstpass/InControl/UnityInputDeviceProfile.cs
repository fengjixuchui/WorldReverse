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
	public class UnityInputDeviceProfile : UnityInputDeviceProfileBase // TypeDefIndex: 7996
	{
		// Fields
		protected string[] JoystickNames; // 0x60
		protected string[] JoystickRegex; // 0x68
		protected string LastResortRegex; // 0x70
		protected static InputControlSource Button0; // 0x00
		protected static InputControlSource Button1; // 0x08
		protected static InputControlSource Button2; // 0x10
		protected static InputControlSource Button3; // 0x18
		protected static InputControlSource Button4; // 0x20
		protected static InputControlSource Button5; // 0x28
		protected static InputControlSource Button6; // 0x30
		protected static InputControlSource Button7; // 0x38
		protected static InputControlSource Button8; // 0x40
		protected static InputControlSource Button9; // 0x48
		protected static InputControlSource Button10; // 0x50
		protected static InputControlSource Button11; // 0x58
		protected static InputControlSource Button12; // 0x60
		protected static InputControlSource Button13; // 0x68
		protected static InputControlSource Button14; // 0x70
		protected static InputControlSource Button15; // 0x78
		protected static InputControlSource Button16; // 0x80
		protected static InputControlSource Button17; // 0x88
		protected static InputControlSource Button18; // 0x90
		protected static InputControlSource Button19; // 0x98
		protected static InputControlSource Analog0; // 0xA0
		protected static InputControlSource Analog1; // 0xA8
		protected static InputControlSource Analog2; // 0xB0
		protected static InputControlSource Analog3; // 0xB8
		protected static InputControlSource Analog4; // 0xC0
		protected static InputControlSource Analog5; // 0xC8
		protected static InputControlSource Analog6; // 0xD0
		protected static InputControlSource Analog7; // 0xD8
		protected static InputControlSource Analog8; // 0xE0
		protected static InputControlSource Analog9; // 0xE8
		protected static InputControlSource Analog10; // 0xF0
		protected static InputControlSource Analog11; // 0xF8
		protected static InputControlSource Analog12; // 0x100
		protected static InputControlSource Analog13; // 0x108
		protected static InputControlSource Analog14; // 0x110
		protected static InputControlSource Analog15; // 0x118
		protected static InputControlSource Analog16; // 0x120
		protected static InputControlSource Analog17; // 0x128
		protected static InputControlSource Analog18; // 0x130
		protected static InputControlSource Analog19; // 0x138
		protected static InputControlSource MenuKey; // 0x140
		protected static InputControlSource EscapeKey; // 0x148
		protected static InputControlSource MouseButton0; // 0x150
		protected static InputControlSource MouseButton1; // 0x158
		protected static InputControlSource MouseButton2; // 0x160
		protected static InputControlSource MouseXAxis; // 0x168
		protected static InputControlSource MouseYAxis; // 0x170
		protected static InputControlSource MouseScrollWheel; // 0x178
	
		// Properties
		public VersionInfo MinUnityVersion { /* [XID] */ /* 0x0000000189A568C0-0x0000000189A56900 */ get; protected set; } // 0x0000000187AFF560-0x0000000187AFF5D0 0x0000000187AFF640-0x0000000187AFF6B0
		public VersionInfo MaxUnityVersion { /* [XID] */ /* 0x0000000189A690E0-0x0000000189A69120 */ get; protected set; } // 0x0000000187AFF4F0-0x0000000187AFF560 0x0000000187AFF5D0-0x0000000187AFF640
		public override bool IsJoystick { /* [XID] */ /* 0x0000000189A7B050-0x0000000189A7B070 */ get => default; } // 0x0000000187AFF080-0x0000000187AFF150 
		public override bool IsSupportedOnThisPlatform { /* [XID] */ /* 0x0000000189AC2DF0-0x0000000189AC2E10 */ get => default; } // 0x0000000187AFF150-0x0000000187AFF210 
		private bool IsSupportedOnThisVersionOfUnity { /* [XID] */ /* 0x0000000189ACA4A0-0x0000000189ACA4C0 */ get => default; } // 0x0000000187AFF210-0x0000000187AFF4F0 
	
		// Constructors
		public UnityInputDeviceProfile() {} // 0x0000000187AFEF40-0x0000000187AFF080
		static UnityInputDeviceProfile() {} // 0x0000000187AFE630-0x0000000187AFEF40
	
		// Methods
		// [XID] // 0x0000000189A82720-0x0000000189A82740
		public override bool HasJoystickName(string joystickName) => default; // 0x0000000187AFD4E0-0x0000000187AFD6B0
		// [XID] // 0x0000000189A89F00-0x0000000189A89F20
		public override bool HasLastResortRegex(string joystickName) => default; // 0x0000000187AFD7A0-0x0000000187AFD8A0
		// [XID] // 0x0000000189A917A0-0x0000000189A917C0
		public override bool HasJoystickOrRegexName(string joystickName) => default; // 0x0000000187AFD6B0-0x0000000187AFD7A0
		// [XID] // 0x0000000189AA7B40-0x0000000189AA7B60
		protected static InputControlSource Button(int index) => default; // 0x0000000187AFCC40-0x0000000187AFCD00
		// [XID] // 0x0000000189AAF4F0-0x0000000189AAF510
		protected static InputControlSource Analog(int index) => default; // 0x0000000187AFCB80-0x0000000187AFCC40
		// [XID] // 0x0000000189AB6D40-0x0000000189AB6D60
		protected static InputControlMapping LeftStickLeftMapping(InputControlSource analog) => default; // 0x0000000187AFD9F0-0x0000000187AFDB40
		// [XID] // 0x0000000189ABE780-0x0000000189ABE7A0
		protected static InputControlMapping LeftStickRightMapping(InputControlSource analog) => default; // 0x0000000187AFDB40-0x0000000187AFDC90
		// [XID] // 0x0000000189AC6290-0x0000000189AC62B0
		protected static InputControlMapping LeftStickUpMapping(InputControlSource analog) => default; // 0x0000000187AFDC90-0x0000000187AFDDE0
		// [XID] // 0x00000001899F1570-0x00000001899F1590
		protected static InputControlMapping LeftStickDownMapping(InputControlSource analog) => default; // 0x0000000187AFD8A0-0x0000000187AFD9F0
		// [XID] // 0x0000000189AD57D0-0x0000000189AD57F0
		protected static InputControlMapping RightStickLeftMapping(InputControlSource analog) => default; // 0x0000000187AFE080-0x0000000187AFE1D0
		// [XID] // 0x0000000189A00410-0x0000000189A00430
		protected static InputControlMapping RightStickRightMapping(InputControlSource analog) => default; // 0x0000000187AFE1D0-0x0000000187AFE320
		// [XID] // 0x0000000189A07B00-0x0000000189A07B20
		protected static InputControlMapping RightStickUpMapping(InputControlSource analog) => default; // 0x0000000187AFE320-0x0000000187AFE470
		// [XID] // 0x0000000189AEBF90-0x0000000189AEBFB0
		protected static InputControlMapping RightStickDownMapping(InputControlSource analog) => default; // 0x0000000187AFDF30-0x0000000187AFE080
		// [XID] // 0x0000000189A16800-0x0000000189A16820
		protected static InputControlMapping LeftTriggerMapping(InputControlSource analog) => default; // 0x0000000187AFDDE0-0x0000000187AFDF30
		// [XID] // 0x0000000189AFB1C0-0x0000000189AFB1E0
		protected static InputControlMapping RightTriggerMapping(InputControlSource analog) => default; // 0x0000000187AFE470-0x0000000187AFE5C0
		// [XID] // 0x0000000189A36A90-0x0000000189A36AB0
		protected static InputControlMapping DPadLeftMapping(InputControlSource analog) => default; // 0x0000000187AFCFA0-0x0000000187AFD0F0
		// [XID] // 0x0000000189A1DC80-0x0000000189A1DCA0
		protected static InputControlMapping DPadRightMapping(InputControlSource analog) => default; // 0x0000000187AFD0F0-0x0000000187AFD240
		// [XID] // 0x0000000189B11820-0x0000000189B11840
		protected static InputControlMapping DPadUpMapping(InputControlSource analog) => default; // 0x0000000187AFD390-0x0000000187AFD4E0
		// [XID] // 0x0000000189B18A50-0x0000000189B18A70
		protected static InputControlMapping DPadDownMapping(InputControlSource analog) => default; // 0x0000000187AFCE50-0x0000000187AFCFA0
		// [XID] // 0x0000000189A4A770-0x0000000189A4A790
		protected static InputControlMapping DPadUpMapping2(InputControlSource analog) => default; // 0x0000000187AFD240-0x0000000187AFD390
		// [XID] // 0x0000000189A51F20-0x0000000189A51F40
		protected static InputControlMapping DPadDownMapping2(InputControlSource analog) => default; // 0x0000000187AFCD00-0x0000000187AFCE50
	}
}
