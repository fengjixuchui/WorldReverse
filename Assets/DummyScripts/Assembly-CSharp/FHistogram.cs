/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class FHistogram // TypeDefIndex: 27872
{
	// Fields
	private List<FBin> Bins; // 0x10
	private double SumOfAllMeasures; // 0x18
	private int CountOfAllMeasures; // 0x20
	private double MinimalMeasurement; // 0x28
	private double MaximalMeasurement; // 0x30
	private double totalSeconds; // 0x38

	// Properties
	public double average { /* [XID] */ /* 0x0000000189B502F0-0x0000000189B50310 */ get => default; } // 0x000000018334FFF0-0x00000001833500B0 

	// Nested types
	private class FBin // TypeDefIndex: 27873
	{
		// Fields
		public double MinValue; // 0x10
		public double UpperBound; // 0x18
		public double Sum; // 0x20
		public int Count; // 0x28

		// Constructors
		public FBin() {} // Dummy constructor
		public FBin(double MinInclusive, double MaxExclusive) {} // 0x00000001833382E0-0x0000000183338370
		public FBin(double MinInclusive) {} // 0x0000000183338250-0x00000001833382E0
	}

	// Constructors
	public FHistogram() {} // Dummy constructor
	public FHistogram(double[] Thresholds) {} // 0x00000001833500B0-0x0000000183350280

	// Methods
	// [IDTag] // 0x0000000189B3B190-0x0000000189B3B1D0
	// [XID] // 0x0000000189B3B190-0x0000000189B3B1D0
	public void AddMeasurement(double inValue) {} // 0x000000018334FB10-0x000000018334FBD0
	// [IDTag] // 0x0000000189B45D70-0x0000000189B45DB0
	// [XID] // 0x0000000189B45D70-0x0000000189B45DB0
	private void AddMeasurement(double ValueForBinning, double MeasurementValue) {} // 0x000000018334F860-0x000000018334FB10
	// [XID] // 0x0000000189B57AA0-0x0000000189B57AC0
	public List<StatTCA> GetTCAInfo() => default; // 0x000000018334F400-0x000000018334F860
	// [XID] // 0x0000000189B5F450-0x0000000189B5F470
	public string DumpToAnalytics() => default; // 0x000000018334FBD0-0x000000018334FFF0
}

