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

public class StatFramePerformanceAnalyzer // TypeDefIndex: 27881
{
	// Fields
	private FHistogram _gameFrameHistogram; // 0x10
	private static readonly double[] frameTimeHistogramInitArray; // 0x00
	private static StatFramePerformanceAnalyzer _activeFPA; // 0x08

	// Constructors
	private StatFramePerformanceAnalyzer() {} // 0x000000018166C920-0x000000018166C9F0
	static StatFramePerformanceAnalyzer() {} // 0x000000018166C870-0x000000018166C920

	// Methods
	// [XID] // 0x00000001896084A0-0x00000001896084C0
	private void OnAnalyzeFrame(ref StatFrameData inFrameData) {} // 0x000000018166C5F0-0x000000018166C6C0
	// [XID] // 0x00000001898F0FA0-0x00000001898F0FC0
	public static void StartTrackPerformance() {} // 0x000000018166C6C0-0x000000018166C870
	// [XID] // 0x0000000189617060-0x0000000189617080
	public static List<StatTCA> StopTrackPerformanceWithTCA() => default; // 0x000000018166C270-0x000000018166C420
	// [XID] // 0x000000018961EBE0-0x000000018961EC00
	public static void StopTrackPerformance() {} // 0x000000018166C420-0x000000018166C5F0
}

