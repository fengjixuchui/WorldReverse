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
	public class UnityInputDevice : InputDevice // TypeDefIndex: 7992
	{
		// Fields
		private static string[,] analogQueries; // 0x00
		private static string[,] buttonQueries; // 0x08
		public const int MaxDevices = 10; // Metadata: 0x00ADF3A3
		public const int MaxButtons = 20; // Metadata: 0x00ADF3A7
		public const int MaxAnalogs = 20; // Metadata: 0x00ADF3AB
		private UnityInputDeviceProfileBase profile; // 0x180
	
		// Properties
		internal int JoystickId { /* [XID] */ /* 0x000000018994F500-0x000000018994F540 */ get; private set; } // 0x0000000187B01750-0x0000000187B017B0 0x0000000187B018F0-0x0000000187B01960
		public override bool IsSupportedOnThisPlatform { /* [XID] */ /* 0x00000001899961E0-0x0000000189996200 */ get => default; } // 0x0000000187B01680-0x0000000187B01750 
		public override bool IsKnown { /* [XID] */ /* 0x000000018999DC20-0x000000018999DC40 */ get => default; } // 0x0000000187B015D0-0x0000000187B01680 
		internal override int NumUnknownButtons { /* [XID] */ /* 0x0000000189A95A90-0x0000000189A95AB0 */ get => default; } // 0x0000000187B01850-0x0000000187B018F0 
		internal override int NumUnknownAnalogs { /* [XID] */ /* 0x00000001899ACFF0-0x00000001899AD010 */ get => default; } // 0x0000000187B017B0-0x0000000187B01850 
	
		// Constructors
		public UnityInputDevice() {} // Dummy constructor
		public UnityInputDevice(UnityInputDeviceProfileBase deviceProfile) {} // 0x0000000187B014B0-0x0000000187B01540
		public UnityInputDevice(int joystickId, string joystickName) {} // 0x0000000187B01540-0x0000000187B015D0
		public UnityInputDevice(UnityInputDeviceProfileBase deviceProfile, int joystickId, string joystickName) {} // 0x0000000187B008A0-0x0000000187B014B0
	
		// Methods
		// [XID] // 0x00000001897C6620-0x00000001897C6640
		public override void Update(ulong updateTick, float deltaTime) {} // 0x0000000187B00490-0x0000000187B008A0
		// [XID] // 0x00000001898207D0-0x00000001898207F0
		private static void SetupAnalogQueries() {} // 0x0000000187AFFC00-0x0000000187AFFEA0
		// [XID] // 0x000000018983DD80-0x000000018983DDA0
		private static void SetupButtonQueries() {} // 0x0000000187AFFEA0-0x0000000187B00140
		// [XID] // 0x000000018984CAE0-0x000000018984CB00
		private static string GetAnalogKey(int joystickId, int analogId) => default; // 0x0000000187AFF6B0-0x0000000187AFF7C0
		// [XID] // 0x00000001897D5350-0x00000001897D5370
		private static string GetButtonKey(int joystickId, int buttonId) => default; // 0x0000000187AFF7C0-0x0000000187AFF8D0
		// [XID] // 0x00000001897E4490-0x00000001897E44B0
		internal override bool ReadRawButtonState(int index) => default; // 0x0000000187AFFA70-0x0000000187AFFC00
		// [XID] // 0x00000001897F3950-0x00000001897F3970
		internal override float ReadRawAnalogValue(int index) => default; // 0x0000000187AFF8D0-0x0000000187AFFA70
	}
}
