/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class StatMMA : IStatLogNode // TypeDefIndex: 27846
	{
		// Fields
		public string statName; // 0x10
		public double min; // 0x18
		public double max; // 0x20
		public double total; // 0x28
		public int framesCounted; // 0x30
		public double filterOutMax; // 0x38
		public MMAField calls; // 0x40
	
		// Properties
		public int callsMin { /* [XID] */ /* 0x00000001896E04B0-0x00000001896E04D0 */ get => default; } // 0x0000000182B18600-0x0000000182B186A0 
		public int callsMax { /* [XID] */ /* 0x00000001896D15A0-0x00000001896D15C0 */ get => default; } // 0x0000000182B18560-0x0000000182B18600 
		public int callsAverage { /* [XID] */ /* 0x000000018968E110-0x000000018968E130 */ get => default; } // 0x0000000182B184B0-0x0000000182B18560 
		public double average { /* [XID] */ /* 0x00000001896959E0-0x0000000189695A00 */ get => default; } // 0x0000000182B183F0-0x0000000182B184B0 
		public double averagePerCall { /* [XID] */ /* 0x000000018969D090-0x000000018969D0B0 */ get => default; } // 0x0000000182B18320-0x0000000182B183F0 
	
		// Constructors
		private StatMMA() {} // 0x0000000182B182C0-0x0000000182B18320
	
		// Methods
		// [XID] // 0x00000001898DA190-0x00000001898DA1B0
		public static string ToCSVTitle() => default; // 0x0000000182B17D90-0x0000000182B17E30
		// [XID] // 0x00000001896AB950-0x00000001896AB970
		public string ToCSVString() => default; // 0x0000000182B17E30-0x0000000182B182C0
		// [XID] // 0x00000001896B2AD0-0x00000001896B2AF0
		public static string ToStatIDAveMaxMinCSVTitle() => default; // 0x0000000182B17A00-0x0000000182B17AA0
		// [XID] // 0x00000001896BA2A0-0x00000001896BA2C0
		public string ToStatIDAveMaxMinCSVString() => default; // 0x0000000182B17AA0-0x0000000182B17D90
		// [XID] // 0x00000001896C1510-0x00000001896C1530
		public static string ToEmptyStatIDAveMaxMinCSVString(string inStatName) => default; // 0x0000000182B172B0-0x0000000182B17580
		// [XID] // 0x00000001898B45C0-0x00000001898B45E0
		public static StatMMA NewPooledStatMMA(string inStatName, double inFilterOutMax) => default; // 0x0000000182B17580-0x0000000182B17690
		// [XID] // 0x00000001896D0600-0x00000001896D0620
		public object Clone() => default; // 0x0000000182B178F0-0x0000000182B17A00
		// [XID] // 0x0000000189850480-0x00000001898504A0
		public void Flush() {} // 0x0000000182B17830-0x0000000182B178F0
		// [XID] // 0x00000001897B8F60-0x00000001897B8F80
		public void Accumulate(double value, int callCounts, bool allowZero = false /* Metadata: 0x00B0D070 */) {} // 0x0000000182B17690-0x0000000182B17830
	}
}
