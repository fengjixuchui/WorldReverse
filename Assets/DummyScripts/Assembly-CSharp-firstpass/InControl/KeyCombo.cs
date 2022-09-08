/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	public struct KeyCombo // TypeDefIndex: 7604
	{
		// Fields
		private int includeSize; // 0x00
		private ulong includeData; // 0x08
		private int excludeSize; // 0x10
		private ulong excludeData; // 0x18
		private static Dictionary<ulong, string> cachedStrings; // 0x00
	
		// Properties
		[Obsolete] // 0x00000001897D2EF0-0x00000001897D2F20
		public int Count { /* [XID] */ /* 0x0000000189778390-0x00000001897783B0 */ get => default; } // 0x00000001870E1B80-0x00000001870E1C30 
		public int IncludeCount { /* [XID] */ /* 0x000000018966F160-0x000000018966F180 */ get => default; } // 0x00000001870E1CE0-0x00000001870E1EF0 
		public int ExcludeCount { /* [XID] */ /* 0x00000001897872B0-0x00000001897872D0 */ get => default; } // 0x00000001870E1C30-0x00000001870E1CE0 
		public bool IsPressed { /* [XID] */ /* 0x000000018978E820-0x000000018978E840 */ get => default; } // 0x00000001870E1EF0-0x00000001870E1F00 
	
		// Constructors
		public KeyCombo(params /* 0x000000018989F6F0-0x000000018989F700 */ Key[] keys) : this() {
			includeSize = default;
			includeData = default;
			excludeSize = default;
			excludeData = default;
		} // 0x00000001870E1AD0-0x00000001870E1B80
		static KeyCombo() {
			cachedStrings = default;
		} // 0x00000001870E1970-0x00000001870E1AD0
	
		// Methods
		// [XID] // 0x00000001896B9BA0-0x00000001896B9BC0
		private void AddIncludeInt(int key) {} // 0x00000001870DFFB0-0x00000001870E0070
		// [XID] // 0x0000000189B86FB0-0x0000000189B86FD0
		private int GetIncludeInt(int index) => default; // 0x00000001870E0D30-0x00000001870E1000
		[Obsolete] // 0x000000018970E530-0x000000018970E580
		// [XID] // 0x000000018970E530-0x000000018970E580
		public void Add(Key key) {} // 0x00000001870E0130-0x00000001870E02A0
		[Obsolete] // 0x000000018971A5F0-0x000000018971A640
		// [XID] // 0x000000018971A5F0-0x000000018971A640
		public Key Get(int index) => default; // 0x00000001870E10D0-0x00000001870E12D0
		// [XID] // 0x00000001896D7300-0x00000001896D7320
		public void AddInclude(Key key) {} // 0x00000001870E0070-0x00000001870E0130
		// [XID] // 0x000000018972D750-0x000000018972D770
		public Key GetInclude(int index) => default; // 0x00000001870E1000-0x00000001870E10D0
		// [XID] // 0x0000000189734F50-0x0000000189734F70
		private void AddExcludeInt(int key) {} // 0x00000001870DFE10-0x00000001870DFED0
		// [XID] // 0x000000018973CAD0-0x000000018973CAF0
		private int GetExcludeInt(int index) => default; // 0x00000001870E08B0-0x00000001870E0B80
		// [XID] // 0x0000000189743FA0-0x0000000189743FC0
		public void AddExclude(Key key) {} // 0x00000001870DFED0-0x00000001870DFFB0
		// [XID] // 0x000000018974BC10-0x000000018974BC30
		public Key GetExclude(int index) => default; // 0x00000001870E0B80-0x00000001870E0C60
		// [XID] // 0x0000000189752F70-0x0000000189752F90
		public static KeyCombo With(params /* 0x000000018989F6F0-0x000000018989F700 */ Key[] keys) => default; // 0x00000001870E1860-0x00000001870E1970
		// [XID] // 0x0000000189761F60-0x0000000189761F80
		public KeyCombo AndNot(params /* 0x000000018989F6F0-0x000000018989F700 */ Key[] keys) => default; // 0x00000001870E02A0-0x00000001870E0380
		// [XID] // 0x0000000189770AA0-0x0000000189770AC0
		public void Clear() {} // 0x00000001870E0380-0x00000001870E0390
		// [XID] // 0x0000000189795EF0-0x0000000189795F10
		public static KeyCombo Detect(bool modifiersAsKeys) => default; // 0x00000001870E0390-0x00000001870E07E0
		// [XID] // 0x000000018979E230-0x000000018979E250
		public override string ToString() => default; // 0x00000001870E1630-0x00000001870E16F0
		// [XID] // 0x00000001899A9BE0-0x00000001899A9C00
		public static bool operator ==(KeyCombo a, KeyCombo b) => default; // 0x00000001870E1F00-0x00000001870E2000
		// [XID] // 0x00000001897ACE10-0x00000001897ACE30
		public static bool operator !=(KeyCombo a, KeyCombo b) => default; // 0x00000001870E2000-0x00000001870E2840
		// [XID] // 0x00000001899DDF30-0x00000001899DDF50
		public override bool Equals(object other) => default; // 0x00000001870E07E0-0x00000001870E08B0
		// [XID] // 0x00000001897BCA40-0x00000001897BCA60
		public override int GetHashCode() => default; // 0x00000001870E0C60-0x00000001870E0D30
		// [XID] // 0x0000000189B7F3C0-0x0000000189B7F3E0
		internal void Load(BinaryReader reader, ushort dataFormatVersion) {} // 0x00000001870E12D0-0x00000001870E13F0
		// [XID] // 0x00000001899B8AE0-0x00000001899B8B00
		internal void Save(BinaryWriter writer) {} // 0x00000001870E13F0-0x00000001870E1630
	}
}
