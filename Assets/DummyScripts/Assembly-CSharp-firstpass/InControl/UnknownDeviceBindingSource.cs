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
	public class UnknownDeviceBindingSource : BindingSource // TypeDefIndex: 7613
	{
		// Properties
		public UnknownDeviceControl Control { /* [XID] */ /* 0x0000000189706BA0-0x0000000189706BE0 */ get; /* [XID] */ /* 0x00000001897116F0-0x0000000189711730 */ protected set; } // 0x0000000187B03DC0-0x0000000187B03E30 0x0000000187B04670-0x0000000187B047E0
		public override string Name { /* [XID] */ /* 0x000000018972A880-0x000000018972A8A0 */ get => default; } // 0x0000000187B04250-0x0000000187B04670 
		public override string DeviceName { /* [XID] */ /* 0x0000000189AFB080-0x0000000189AFB0A0 */ get => default; } // 0x0000000187B03ED0-0x0000000187B04000 
		public override InputDeviceClass DeviceClass { /* [XID] */ /* 0x0000000189B02620-0x0000000189B02640 */ get => default; } // 0x0000000187B03E30-0x0000000187B03ED0 
		public override InputDeviceStyle DeviceStyle { /* [XID] */ /* 0x0000000189B09C60-0x0000000189B09C80 */ get => default; } // 0x0000000187B04000-0x0000000187B040A0 
		public override BindingSourceType BindingSourceType { /* [XID] */ /* 0x0000000189B455C0-0x0000000189B455E0 */ get => default; } // 0x0000000187B03D20-0x0000000187B03DC0 
		internal override bool IsValid { /* [XID] */ /* 0x000000018976C4D0-0x000000018976C4F0 */ get => default; } // 0x0000000187B040A0-0x0000000187B04250 
	
		// Constructors
		internal UnknownDeviceBindingSource() {} // 0x0000000187B03B70-0x0000000187B03C60
		public UnknownDeviceBindingSource(UnknownDeviceControl control) {} // 0x0000000187B03C60-0x0000000187B03D20
	
		// Methods
		// [XID] // 0x00000001896AD610-0x00000001896AD630
		public override float GetValue(InputDevice device) => default; // 0x0000000187B03690-0x0000000187B037B0
		// [XID] // 0x00000001897230D0-0x00000001897230F0
		public override bool GetState(InputDevice device) => default; // 0x0000000187B03590-0x0000000187B03690
		// [IDTag] // 0x0000000189748AC0-0x0000000189748B00
		// [XID] // 0x0000000189748AC0-0x0000000189748B00
		public override bool Equals(BindingSource other) => default; // 0x0000000187B03260-0x0000000187B03480
		// [IDTag] // 0x0000000189752F30-0x0000000189752F70
		// [XID] // 0x0000000189752F30-0x0000000189752F70
		public override bool Equals(object other) => default; // 0x0000000187B03050-0x0000000187B03260
		// [XID] // 0x000000018975D3A0-0x000000018975D3C0
		public override int GetHashCode() => default; // 0x0000000187B03480-0x0000000187B03590
		// [XID] // 0x0000000189773AA0-0x0000000189773AC0
		internal override void Load(BinaryReader reader, ushort dataFormatVersion) {} // 0x0000000187B037B0-0x0000000187B038F0
		// [XID] // 0x00000001895F5C90-0x00000001895F5CB0
		internal override void Save(BinaryWriter writer) {} // 0x0000000187B038F0-0x0000000187B03A10
	}
}
