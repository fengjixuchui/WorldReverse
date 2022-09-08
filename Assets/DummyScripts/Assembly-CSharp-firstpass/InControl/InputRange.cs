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
	public struct InputRange // TypeDefIndex: 7626
	{
		// Fields
		public static readonly InputRange None; // 0x00
		public static readonly InputRange MinusOneToOne; // 0x0C
		public static readonly InputRange OneToMinusOne; // 0x18
		public static readonly InputRange ZeroToOne; // 0x24
		public static readonly InputRange ZeroToMinusOne; // 0x30
		public static readonly InputRange OneToZero; // 0x3C
		public static readonly InputRange MinusOneToZero; // 0x48
		public static readonly InputRange ZeroToNegativeInfinity; // 0x54
		public static readonly InputRange ZeroToPositiveInfinity; // 0x60
		public static readonly InputRange Everything; // 0x6C
		private static readonly InputRange[] TypeToRange; // 0x78
		public readonly float Value0; // 0x00
		public readonly float Value1; // 0x04
		public readonly InputRangeType Type; // 0x08
	
		// Constructors
		private InputRange(float value0, float value1, InputRangeType type) {
			Value0 = default;
			Value1 = default;
			Type = default;
		} // 0x00000001870DC940-0x00000001870DCA60
		public InputRange(InputRangeType type) {
			Value0 = default;
			Value1 = default;
			Type = default;
		} // 0x00000001870DCA60-0x00000001870DCA70
		static InputRange() {
			None = default;
			MinusOneToOne = default;
			OneToMinusOne = default;
			ZeroToOne = default;
			ZeroToMinusOne = default;
			OneToZero = default;
			MinusOneToZero = default;
			ZeroToNegativeInfinity = default;
			ZeroToPositiveInfinity = default;
			Everything = default;
			TypeToRange = default;
		} // 0x00000001870DC230-0x00000001870DC940
	
		// Methods
		// [XID] // 0x0000000189958740-0x0000000189958760
		public bool Includes(float value) => default; // 0x00000001870DBF10-0x00000001870DBF20
		// [XID] // 0x000000018995FDB0-0x000000018995FDD0
		public bool Excludes(float value) => default; // 0x00000001870DBE40-0x00000001870DBF10
		// [IDTag] // 0x00000001899676A0-0x00000001899676E0
		// [XID] // 0x00000001899676A0-0x00000001899676E0
		public static float Remap(float value, InputRange sourceRange, InputRange targetRange) => default; // 0x00000001870DBF20-0x00000001870DC090
		// [IDTag] // 0x0000000189971FB0-0x0000000189971FF0
		// [XID] // 0x0000000189971FB0-0x0000000189971FF0
		internal static float Remap(float value, InputRangeType sourceRangeType, InputRangeType targetRangeType) => default; // 0x00000001870DC090-0x00000001870DC230
	}
}
