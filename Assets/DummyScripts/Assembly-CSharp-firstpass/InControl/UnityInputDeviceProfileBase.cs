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
	public abstract class UnityInputDeviceProfileBase : InputDeviceProfile // TypeDefIndex: 7997
	{
		// Properties
		public abstract bool IsJoystick { get; }
		public bool IsNotJoystick { /* [XID] */ /* 0x0000000189B2EA70-0x0000000189B2EA90 */ get; } // 0x0000000187AF9CE0-0x0000000187AF9DA0 
	
		// Constructors
		protected UnityInputDeviceProfileBase() {} // 0x0000000187AF9C60-0x0000000187AF9CE0
	
		// Methods
		public abstract bool HasJoystickName(string joystickName);
		public abstract bool HasLastResortRegex(string joystickName);
		public abstract bool HasJoystickOrRegexName(string joystickName);
	}
}
