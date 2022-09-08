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
	public class NativeInputDevice : InputDevice // TypeDefIndex: 7815
	{
		// Fields
		private const int maxUnknownButtons = 20; // Metadata: 0x00ADF25F
		private const int maxUnknownAnalogs = 20; // Metadata: 0x00ADF263
		private short[] buttons; // 0x1B0
		private short[] analogs; // 0x1B8
		private NativeInputDeviceProfile profile; // 0x1C0
		private int skipUpdateFrames; // 0x1C8
		private int numUnknownButtons; // 0x1CC
		private int numUnknownAnalogs; // 0x1D0
	
		// Properties
		internal uint Handle { /* [XID] */ /* 0x0000000189709CF0-0x0000000189709D30 */ get; /* [XID] */ /* 0x0000000189714230-0x0000000189714270 */ private set; } // 0x0000000188872BB0-0x0000000188872C10 0x0000000188872F50-0x0000000188872FC0
		internal NativeDeviceInfo Info { /* [XID] */ /* 0x000000018971EA60-0x000000018971EAA0 */ get; /* [XID] */ /* 0x0000000189728E80-0x0000000189728EC0 */ private set; } // 0x0000000188872C10-0x0000000188872C90 0x0000000188872FC0-0x0000000188873040
		public override bool IsSupportedOnThisPlatform { /* [XID] */ /* 0x00000001897A2520-0x00000001897A2540 */ get => default; } // 0x0000000188872D40-0x0000000188872E10 
		public override bool IsKnown { /* [XID] */ /* 0x00000001897A9BB0-0x00000001897A9BD0 */ get => default; } // 0x0000000188872C90-0x0000000188872D40 
		internal override int NumUnknownButtons { /* [XID] */ /* 0x0000000189AD7840-0x0000000189AD7860 */ get => default; } // 0x0000000188872EB0-0x0000000188872F50 
		internal override int NumUnknownAnalogs { /* [XID] */ /* 0x00000001897B8F80-0x00000001897B8FA0 */ get => default; } // 0x0000000188872E10-0x0000000188872EB0 
	
		// Constructors
		internal NativeInputDevice() {} // 0x0000000188872B20-0x0000000188872BB0
	
		// Methods
		// [IDTag] // 0x0000000189733660-0x00000001897336A0
		// [XID] // 0x0000000189733660-0x00000001897336A0
		internal void Initialize(uint deviceHandle, NativeDeviceInfo deviceInfo, NativeInputDeviceProfile deviceProfile) {} // 0x0000000188871170-0x0000000188871A80
		// [IDTag] // 0x000000018973E560-0x000000018973E5A0
		// [XID] // 0x000000018973E560-0x000000018973E5A0
		internal void Initialize(uint deviceHandle, NativeDeviceInfo deviceInfo) {} // 0x0000000188871050-0x0000000188871170
		// [XID] // 0x000000018963FEF0-0x000000018963FF10
		public override void Update(ulong updateTick, float deltaTime) {} // 0x0000000188872480-0x00000001888729D0
		// [XID] // 0x0000000189750000-0x0000000189750020
		internal override bool ReadRawButtonState(int index) => default; // 0x0000000188871B90-0x0000000188871C90
		// [XID] // 0x00000001897576C0-0x00000001897576E0
		internal override float ReadRawAnalogValue(int index) => default; // 0x0000000188871A80-0x0000000188871B90
		// [XID] // 0x000000018975EF70-0x000000018975EF90
		private byte FloatToByte(float value) => default; // 0x00000001888705B0-0x00000001888706A0
		// [XID] // 0x0000000189766330-0x0000000189766350
		public override void Vibrate(float leftMotor, float rightMotor) {} // 0x00000001888729D0-0x0000000188872B20
		// [XID] // 0x000000018976DB80-0x000000018976DBA0
		public override void SetLightColor(float red, float green, float blue) {} // 0x0000000188871C90-0x0000000188871E10
		// [XID] // 0x00000001897750B0-0x00000001897750D0
		public override void SetLightFlash(float flashOnDuration, float flashOffDuration) {} // 0x0000000188871E10-0x0000000188871F60
		// [XID] // 0x00000001896E4010-0x00000001896E4030
		public bool HasSameVendorID(NativeDeviceInfo deviceInfo) => default; // 0x0000000188870BF0-0x0000000188870E20
		// [XID] // 0x0000000189784330-0x0000000189784350
		public bool HasSameProductID(NativeDeviceInfo deviceInfo) => default; // 0x0000000188870830-0x0000000188870A60
		// [XID] // 0x0000000189A0A000-0x0000000189A0A020
		public bool HasSameVersionNumber(NativeDeviceInfo deviceInfo) => default; // 0x0000000188870E20-0x0000000188871050
		// [XID] // 0x0000000189AA9C60-0x0000000189AA9C80
		public bool HasSameLocation(NativeDeviceInfo deviceInfo) => default; // 0x00000001888706A0-0x0000000188870830
		// [XID] // 0x000000018979A590-0x000000018979A5B0
		public bool HasSameSerialNumber(NativeDeviceInfo deviceInfo) => default; // 0x0000000188870A60-0x0000000188870BF0
	}
}
