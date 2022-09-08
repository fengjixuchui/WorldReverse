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
	public class KeyBindingSource : BindingSource // TypeDefIndex: 7602
	{
		// Properties
		public KeyCombo Control { /* [XID] */ /* 0x00000001896756D0-0x0000000189675710 */ get; /* [XID] */ /* 0x000000018967FE90-0x000000018967FED0 */ protected set; } // 0x00000001870DF940-0x00000001870DF9B0 0x00000001870DFCD0-0x00000001870DFE10
		public override string Name { /* [XID] */ /* 0x00000001896999D0-0x00000001896999F0 */ get => default; } // 0x00000001870DFBA0-0x00000001870DFCD0 
		public override string DeviceName { /* [XID] */ /* 0x00000001896A0FB0-0x00000001896A0FD0 */ get => default; } // 0x00000001870DFA50-0x00000001870DFB00 
		public override InputDeviceClass DeviceClass { /* [XID] */ /* 0x00000001896A8470-0x00000001896A8490 */ get => default; } // 0x00000001870DF9B0-0x00000001870DFA50 
		public override InputDeviceStyle DeviceStyle { /* [XID] */ /* 0x00000001896AF770-0x00000001896AF790 */ get => default; } // 0x00000001870DFB00-0x00000001870DFBA0 
		public override BindingSourceType BindingSourceType { /* [XID] */ /* 0x00000001896D2BF0-0x00000001896D2C10 */ get => default; } // 0x00000001870DF8A0-0x00000001870DF940 
	
		// Constructors
		internal KeyBindingSource() {} // 0x00000001870DF730-0x00000001870DF790
		public KeyBindingSource(KeyCombo keyCombo) {} // 0x00000001870DF660-0x00000001870DF730
		public KeyBindingSource(params /* 0x000000018989F6F0-0x000000018989F700 */ Key[] keys) {} // 0x00000001870DF790-0x00000001870DF8A0
	
		// Methods
		// [XID] // 0x000000018968A9C0-0x000000018968A9E0
		public override float GetValue(InputDevice inputDevice) => default; // 0x00000001870DF1D0-0x00000001870DF2B0
		// [XID] // 0x0000000189938DC0-0x0000000189938DE0
		public override bool GetState(InputDevice inputDevice) => default; // 0x00000001870DF090-0x00000001870DF1D0
		// [IDTag] // 0x00000001896B6FF0-0x00000001896B7030
		// [XID] // 0x00000001896B6FF0-0x00000001896B7030
		public override bool Equals(BindingSource other) => default; // 0x00000001870DED20-0x00000001870DEF60
		// [IDTag] // 0x00000001896C1100-0x00000001896C1140
		// [XID] // 0x00000001896C1100-0x00000001896C1140
		public override bool Equals(object other) => default; // 0x00000001870DEAF0-0x00000001870DED20
		// [XID] // 0x00000001896CB640-0x00000001896CB660
		public override int GetHashCode() => default; // 0x00000001870DEF60-0x00000001870DF090
		// [XID] // 0x00000001899B15E0-0x00000001899B1600
		internal override void Load(BinaryReader reader, ushort dataFormatVersion) {} // 0x00000001870DF2B0-0x00000001870DF430
		// [XID] // 0x00000001896E1D70-0x00000001896E1D90
		internal override void Save(BinaryWriter writer) {} // 0x00000001870DF430-0x00000001870DF570
	}
}
