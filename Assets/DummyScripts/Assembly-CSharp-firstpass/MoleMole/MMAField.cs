/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	[Serializable]
	public struct MMAField // TypeDefIndex: 10081
	{
		// Fields
		public double min; // 0x00
		public double max; // 0x08
		public double total; // 0x10
		private double _average; // 0x18
		public int framesCounted; // 0x20
		public bool bNeedMinValueGreaterThanZero; // 0x24
	
		// Properties
		public double average { /* [XID] */ /* 0x0000000189626F70-0x0000000189626F90 */ get => default; } // 0x0000000186C224D0-0x0000000186C225A0 
		public double displayMin { /* [XID] */ /* 0x00000001898FFFA0-0x00000001898FFFC0 */ get => default; } // 0x0000000186C22670-0x0000000186C22760 
		public double displayMax { /* [XID] */ /* 0x00000001899076E0-0x0000000189907700 */ get => default; } // 0x0000000186C225A0-0x0000000186C22670 
	
		// Constructors
		public MMAField(bool bNeedClear = true /* Metadata: 0x00AE6F15 */, bool bInNeedMinValueGreaterThanZero = false /* Metadata: 0x00AE6F16 */) : this() {
			min = default;
			max = default;
			total = default;
			_average = default;
			framesCounted = default;
			bNeedMinValueGreaterThanZero = default;
		} // 0x0000000186C22410-0x0000000186C224D0
	
		// Methods
		// [XID] // 0x000000018962E900-0x000000018962E920
		public void Accumulate(double value, bool allowZero = false /* Metadata: 0x00AE6F17 */) {} // 0x0000000186C21B80-0x0000000186C21C70
		// [XID] // 0x00000001896451A0-0x00000001896451C0
		public void Clear(bool shouldClearMinMax = true /* Metadata: 0x00AE6F18 */) {} // 0x0000000186C21C70-0x0000000186C21F80
		// [XID] // 0x000000018964CD20-0x000000018964CD40
		public string ToLogStr() => default; // 0x0000000186C22330-0x0000000186C22410
		// [XID] // 0x000000018969F520-0x000000018969F540
		public static string ToCSVTitle() => default; // 0x0000000186C21F90-0x0000000186C22330
		// [XID] // 0x000000018965BAF0-0x000000018965BB10
		public string ToCSVStr() => default; // 0x0000000186C21F80-0x0000000186C21F90
	}
}
