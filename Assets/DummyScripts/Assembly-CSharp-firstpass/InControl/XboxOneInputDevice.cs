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
	public class XboxOneInputDevice : InputDevice // TypeDefIndex: 8007
	{
		// Fields
		private const uint AnalogLeftStickX = 0; // Metadata: 0x00ADF3B9
		private const uint AnalogLeftStickY = 1; // Metadata: 0x00ADF3BD
		private const uint AnalogRightStickX = 3; // Metadata: 0x00ADF3C1
		private const uint AnalogRightStickY = 4; // Metadata: 0x00ADF3C5
		private const uint AnalogLeftTrigger = 8; // Metadata: 0x00ADF3C9
		private const uint AnalogRightTrigger = 9; // Metadata: 0x00ADF3CD
		private const float LowerDeadZone = 0.2f; // Metadata: 0x00ADF3D1
		private const float UpperDeadZone = 0.9f; // Metadata: 0x00ADF3D5
		private string[] analogAxisNameForId; // 0x188
	
		// Properties
		internal uint JoystickId { /* [XID] */ /* 0x00000001897ACDB0-0x00000001897ACDF0 */ get; private set; } // 0x0000000187B15500-0x0000000187B15560 0x0000000187B155D0-0x0000000187B15640
		public ulong ControllerId { get; private set; } // 0x0000000187B15400-0x0000000187B15460 0x0000000187B15560-0x0000000187B155D0
		public bool IsConnected { /* [XID] */ /* 0x00000001897D5F10-0x00000001897D5F30 */ get => default; } // 0x0000000187B15460-0x0000000187B15500 
	
		// Constructors
		public XboxOneInputDevice() {} // Dummy constructor
		public XboxOneInputDevice(uint joystickId) {} // 0x0000000187B14FE0-0x0000000187B15400
	
		// Methods
		// [XID] // 0x00000001897CE800-0x00000001897CE820
		public override void Update(ulong updateTick, float deltaTime) {} // 0x0000000187B14D70-0x0000000187B14E30
		// [IDTag] // 0x00000001897DD620-0x00000001897DD660
		// [XID] // 0x00000001897DD620-0x00000001897DD660
		public override void Vibrate(float leftMotor, float rightMotor) {} // 0x0000000187B14E30-0x0000000187B14EF0
		// [IDTag] // 0x00000001897E7E90-0x00000001897E7ED0
		// [XID] // 0x00000001897E7E90-0x00000001897E7ED0
		public void Vibrate(float leftMotor, float rightMotor, float leftTrigger, float rightTrigger) {} // 0x0000000187B14EF0-0x0000000187B14FE0
		// [XID] // 0x0000000189AF0070-0x0000000189AF0090
		private string AnalogAxisNameForId(uint analogId) => default; // 0x0000000187B14740-0x0000000187B14820
		// [XID] // 0x00000001897FA5C0-0x00000001897FA5E0
		private void CacheAnalogAxisNameForId(uint analogId) {} // 0x0000000187B14820-0x0000000187B14B30
		// [XID] // 0x0000000189801BA0-0x0000000189801BC0
		private void CacheAnalogAxisNames() {} // 0x0000000187B14B30-0x0000000187B14C50
	}
}
