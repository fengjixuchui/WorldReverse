/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	public class MouseBindingSource : BindingSource // TypeDefIndex: 7607
	{
		// Fields
		public static float ScaleX; // 0x00
		public static float ScaleY; // 0x04
		public static float ScaleZ; // 0x08
		public static float JitterThreshold; // 0x0C
		private static readonly int[] buttonTable; // 0x10
	
		// Properties
		public Mouse Control { /* [XID] */ /* 0x000000018980BE30-0x000000018980BE70 */ get; /* [XID] */ /* 0x0000000189816820-0x0000000189816860 */ protected set; } // 0x000000018886C210-0x000000018886C270 0x000000018886C5A0-0x000000018886C600
		public override string Name { /* [XID] */ /* 0x000000018985AB10-0x000000018985AB30 */ get => default; } // 0x000000018886C460-0x000000018886C5A0 
		public override string DeviceName { /* [XID] */ /* 0x0000000189861B90-0x0000000189861BB0 */ get => default; } // 0x000000018886C310-0x000000018886C3C0 
		public override InputDeviceClass DeviceClass { /* [XID] */ /* 0x0000000189869460-0x0000000189869480 */ get => default; } // 0x000000018886C270-0x000000018886C310 
		public override InputDeviceStyle DeviceStyle { /* [XID] */ /* 0x0000000189870610-0x0000000189870630 */ get => default; } // 0x000000018886C3C0-0x000000018886C460 
		public override BindingSourceType BindingSourceType { /* [XID] */ /* 0x0000000189606350-0x0000000189606370 */ get => default; } // 0x000000018886C170-0x000000018886C210 
	
		// Constructors
		internal MouseBindingSource() {} // 0x000000018886C060-0x000000018886C0C0
		public MouseBindingSource(Mouse mouseControl) {} // 0x000000018886C0C0-0x000000018886C170
		static MouseBindingSource() {} // 0x000000018886BFA0-0x000000018886C060
	
		// Methods
		// [XID] // 0x00000001899ECD80-0x00000001899ECDA0
		internal static bool SafeGetMouseButton(int button) => default; // 0x000000018886BCE0-0x000000018886BDB0
		// [XID] // 0x00000001899F4B20-0x00000001899F4B40
		internal static bool ButtonIsPressed(Mouse control) => default; // 0x000000018886AC10-0x000000018886AD30
		// [XID] // 0x000000018982FC50-0x000000018982FC70
		internal static bool NegativeScrollWheelIsActive(float threshold) => default; // 0x000000018886BA00-0x000000018886BB70
		// [XID] // 0x0000000189B8E140-0x0000000189B8E160
		internal static bool PositiveScrollWheelIsActive(float threshold) => default; // 0x000000018886BB70-0x000000018886BCE0
		// [IDTag] // 0x000000018983EA30-0x000000018983EA70
		// [XID] // 0x000000018983EA30-0x000000018983EA70
		internal static float GetValue(Mouse mouseControl) => default; // 0x000000018886B310-0x000000018886B8E0
		// [IDTag] // 0x0000000189848C40-0x0000000189848C80
		// [XID] // 0x0000000189848C40-0x0000000189848C80
		public override float GetValue(InputDevice inputDevice) => default; // 0x000000018886B1F0-0x000000018886B310
		// [XID] // 0x0000000189852E70-0x0000000189852E90
		public override bool GetState(InputDevice inputDevice) => default; // 0x000000018886B0F0-0x000000018886B1F0
		// [IDTag] // 0x0000000189877ED0-0x0000000189877F10
		// [XID] // 0x0000000189877ED0-0x0000000189877F10
		public override bool Equals(BindingSource other) => default; // 0x000000018886AE70-0x000000018886AFC0
		// [IDTag] // 0x0000000189882320-0x0000000189882360
		// [XID] // 0x0000000189882320-0x0000000189882360
		public override bool Equals(object other) => default; // 0x000000018886AD30-0x000000018886AE70
		// [XID] // 0x000000018988CA10-0x000000018988CA30
		public override int GetHashCode() => default; // 0x000000018886AFC0-0x000000018886B0F0
		// [XID] // 0x0000000189838960-0x0000000189838980
		internal override void Save(BinaryWriter writer) {} // 0x000000018886BDB0-0x000000018886BEB0
		// [XID] // 0x00000001898A2B20-0x00000001898A2B40
		internal override void Load(BinaryReader reader, ushort dataFormatVersion) {} // 0x000000018886B8E0-0x000000018886BA00
	}
}
