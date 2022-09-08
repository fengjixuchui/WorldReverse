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
	public abstract class BindingSource : InputControlSource, IEquatable<InControl.BindingSource> // TypeDefIndex: 7595
	{
		// Properties
		public abstract string Name { get; }
		public abstract string DeviceName { get; }
		public abstract InputDeviceClass DeviceClass { get; }
		public abstract InputDeviceStyle DeviceStyle { get; }
		public abstract BindingSourceType BindingSourceType { get; }
		internal PlayerAction BoundTo { /* [XID] */ /* 0x0000000189B8FB10-0x0000000189B8FB50 */ get; /* [XID] */ /* 0x0000000189B99D40-0x0000000189B99D80 */ set; } // 0x0000000187DA9D60-0x0000000187DA9DC0 0x0000000187DAA040-0x0000000187DAA0A0
		internal virtual bool IsValid { /* [XID] */ /* 0x0000000189771130-0x0000000189771150 */ get; } // 0x0000000187DA9DC0-0x0000000187DA9E60 
	
		// Constructors
		protected BindingSource() {} // 0x0000000187DA9D00-0x0000000187DA9D60
	
		// Methods
		public abstract float GetValue(InputDevice inputDevice);
		public abstract bool GetState(InputDevice inputDevice);
		public abstract bool Equals(BindingSource other);
		// [XID] // 0x0000000189B72420-0x0000000189B72440
		public static bool operator ==(BindingSource a, BindingSource b) => default; // 0x0000000187DA9E60-0x0000000187DA9F80
		// [XID] // 0x0000000189B79960-0x0000000189B79980
		public static bool operator !=(BindingSource a, BindingSource b) => default; // 0x0000000187DA9F80-0x0000000187DAA040
		// [XID] // 0x0000000189B80C70-0x0000000189B80C90
		public override bool Equals(object obj) => default; // 0x0000000187DA9A90-0x0000000187DA9B60
		// [XID] // 0x0000000189B88860-0x0000000189B88880
		public override int GetHashCode() => default; // 0x0000000187DA9B60-0x0000000187DA9C10
		internal abstract void Save(BinaryWriter writer);
		internal abstract void Load(BinaryReader reader, ushort dataFormatVersion);
	}
}
