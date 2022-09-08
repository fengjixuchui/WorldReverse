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
	public struct UnknownDeviceControl : IEquatable<InControl.UnknownDeviceControl> // TypeDefIndex: 7616
	{
		// Fields
		public static readonly UnknownDeviceControl None; // 0x00
		public InputControlType Control; // 0x00
		public InputRangeType SourceRange; // 0x04
		public bool IsButton; // 0x08
		public bool IsAnalog; // 0x09
	
		// Properties
		public int Index { /* [XID] */ /* 0x00000001897AFE10-0x00000001897AFE30 */ get => default; } // 0x0000000187B05390-0x0000000187B053A0 
	
		// Constructors
		public UnknownDeviceControl(InputControlType control, InputRangeType sourceRange) : this() {
			Control = default;
			SourceRange = default;
			IsButton = default;
			IsAnalog = default;
		} // 0x0000000187B052D0-0x0000000187B05390
		static UnknownDeviceControl() {
			None = default;
		} // 0x0000000187B05130-0x0000000187B052D0
	
		// Methods
		// [XID] // 0x0000000189B80A10-0x0000000189B80A30
		internal float GetValue(InputDevice device) => default; // 0x0000000187B04B50-0x0000000187B04C80
		// [XID] // 0x0000000189B187F0-0x0000000189B18810
		public static bool operator ==(UnknownDeviceControl a, UnknownDeviceControl b) => default; // 0x0000000187B053A0-0x0000000187B054F0
		// [XID] // 0x00000001897BFB10-0x00000001897BFB30
		public static bool operator !=(UnknownDeviceControl a, UnknownDeviceControl b) => default; // 0x0000000187B055B0-0x0000000187B05740
		// [IDTag] // 0x00000001897C72F0-0x00000001897C7330
		// [XID] // 0x00000001897C72F0-0x00000001897C7330
		public bool Equals(UnknownDeviceControl other) => default; // 0x0000000187B048C0-0x0000000187B04A20
		// [IDTag] // 0x00000001897D15C0-0x00000001897D1600
		// [XID] // 0x00000001897D15C0-0x00000001897D1600
		public override bool Equals(object other) => default; // 0x0000000187B047E0-0x0000000187B048C0
		// [XID] // 0x0000000189B3D660-0x0000000189B3D680
		public override int GetHashCode() => default; // 0x0000000187B04A20-0x0000000187B04B50
		// [XID] // 0x00000001897E3810-0x00000001897E3830
		public static implicit operator bool(UnknownDeviceControl control) => default; // 0x0000000187B054F0-0x0000000187B055B0
		// [XID] // 0x00000001897EB050-0x00000001897EB070
		public override string ToString() => default; // 0x0000000187B04F00-0x0000000187B04FC0
		// [XID] // 0x00000001895FD1F0-0x00000001895FD210
		internal void Save(BinaryWriter writer) {} // 0x0000000187B04D70-0x0000000187B04F00
		// [XID] // 0x00000001897FA5E0-0x00000001897FA600
		internal void Load(BinaryReader reader) {} // 0x0000000187B04C80-0x0000000187B04D70
	}
}
