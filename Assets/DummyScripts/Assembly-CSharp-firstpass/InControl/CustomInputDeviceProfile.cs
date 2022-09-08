/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	[Obsolete] // 0x0000000189AFC560-0x0000000189AFC590
	public class CustomInputDeviceProfile : UnityInputDeviceProfileBase // TypeDefIndex: 7854
	{
		// Fields
		protected static InputControlSource MouseButton0; // 0x00
		protected static InputControlSource MouseButton1; // 0x08
		protected static InputControlSource MouseButton2; // 0x10
		protected static InputControlSource MouseXAxis; // 0x18
		protected static InputControlSource MouseYAxis; // 0x20
		protected static InputControlSource MouseScrollWheel; // 0x28
	
		// Properties
		public sealed override bool IsJoystick { /* [XID] */ /* 0x0000000189B055D0-0x0000000189B055F0 */ get => default; } // 0x0000000187DAC7F0-0x0000000187DAC890 
	
		// Constructors
		public CustomInputDeviceProfile() {} // 0x0000000187DAC5F0-0x0000000187DAC7F0
		static CustomInputDeviceProfile() {} // 0x0000000187DAC470-0x0000000187DAC5F0
	
		// Methods
		// [XID] // 0x0000000189B0CC80-0x0000000189B0CCA0
		public sealed override bool HasJoystickName(string joystickName) => default; // 0x0000000187DAC0C0-0x0000000187DAC170
		// [XID] // 0x00000001897FE580-0x00000001897FE5A0
		public sealed override bool HasLastResortRegex(string joystickName) => default; // 0x0000000187DAC220-0x0000000187DAC2D0
		// [XID] // 0x0000000189A33FE0-0x0000000189A34000
		public sealed override bool HasJoystickOrRegexName(string joystickName) => default; // 0x0000000187DAC170-0x0000000187DAC220
		// [XID] // 0x0000000189B22FF0-0x0000000189B23010
		protected static InputControlSource KeyCodeButton(params /* 0x000000018989F6F0-0x000000018989F700 */ KeyCode[] keyCodeList) => default; // 0x0000000187DAC2D0-0x0000000187DAC3A0
		// [XID] // 0x0000000189B31BF0-0x0000000189B31C10
		protected static InputControlSource KeyCodeComboButton(params /* 0x000000018989F6F0-0x000000018989F700 */ KeyCode[] keyCodeList) => default; // 0x0000000187DAC3A0-0x0000000187DAC470
	}
}
