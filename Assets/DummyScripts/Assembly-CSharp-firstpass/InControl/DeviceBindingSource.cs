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
	public class DeviceBindingSource : BindingSource // TypeDefIndex: 7599
	{
		// Properties
		public InputControlType Control { /* [XID] */ /* 0x0000000189BB5F90-0x0000000189BB5FD0 */ get; /* [XID] */ /* 0x0000000189BC0640-0x0000000189BC0680 */ protected set; } // 0x0000000187DAE530-0x0000000187DAE590 0x0000000187DAEE60-0x0000000187DAEEC0
		public override string Name { /* [XID] */ /* 0x0000000189BDA070-0x0000000189BDA090 */ get => default; } // 0x0000000187DAEBF0-0x0000000187DAEE60 
		public override string DeviceName { /* [XID] */ /* 0x00000001895E6C70-0x00000001895E6C90 */ get => default; } // 0x0000000187DAE6E0-0x0000000187DAE880 
		public override InputDeviceClass DeviceClass { /* [XID] */ /* 0x00000001895EE6F0-0x00000001895EE710 */ get => default; } // 0x0000000187DAE590-0x0000000187DAE6E0 
		public override InputDeviceStyle DeviceStyle { /* [XID] */ /* 0x00000001899BA190-0x00000001899BA1B0 */ get => default; } // 0x0000000187DAE880-0x0000000187DAE9D0 
		public override BindingSourceType BindingSourceType { /* [XID] */ /* 0x0000000189AC8D00-0x0000000189AC8D20 */ get => default; } // 0x0000000187DAE490-0x0000000187DAE530 
		internal override bool IsValid { /* [XID] */ /* 0x0000000189630410-0x0000000189630430 */ get => default; } // 0x0000000187DAE9D0-0x0000000187DAEBF0 
	
		// Constructors
		internal DeviceBindingSource() {} // 0x0000000187DAE3B0-0x0000000187DAE490
		public DeviceBindingSource(InputControlType control) {} // 0x0000000187DAE2C0-0x0000000187DAE3B0
	
		// Methods
		// [XID] // 0x0000000189BCB560-0x0000000189BCB580
		public override float GetValue(InputDevice inputDevice) => default; // 0x0000000187DADE20-0x0000000187DADF40
		// [XID] // 0x0000000189BD2B60-0x0000000189BD2B80
		public override bool GetState(InputDevice inputDevice) => default; // 0x0000000187DADD10-0x0000000187DADE20
		// [IDTag] // 0x00000001895FD390-0x00000001895FD3D0
		// [XID] // 0x00000001895FD390-0x00000001895FD3D0
		public override bool Equals(BindingSource other) => default; // 0x0000000187DAD950-0x0000000187DADAA0
		// [IDTag] // 0x0000000189607A00-0x0000000189607A40
		// [XID] // 0x0000000189607A00-0x0000000189607A40
		public override bool Equals(object other) => default; // 0x0000000187DADAA0-0x0000000187DADBE0
		// [XID] // 0x00000001896124E0-0x0000000189612500
		public override int GetHashCode() => default; // 0x0000000187DADBE0-0x0000000187DADD10
		// [XID] // 0x0000000189621290-0x00000001896212B0
		internal override void Save(BinaryWriter writer) {} // 0x0000000187DAE060-0x0000000187DAE160
		// [XID] // 0x0000000189628B80-0x0000000189628BA0
		internal override void Load(BinaryReader reader, ushort dataFormatVersion) {} // 0x0000000187DADF40-0x0000000187DAE060
	}
}
