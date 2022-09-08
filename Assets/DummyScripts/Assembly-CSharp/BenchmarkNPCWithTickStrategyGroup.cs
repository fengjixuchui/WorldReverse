/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using Newtonsoft.Json;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class BenchmarkNPCWithTickStrategyGroup : IBatchedBenchmarkJob // TypeDefIndex: 27670
{
	// Fields
	public IBatchedBenchmarkJob[] jobIDs; // 0x10
	public int startIndex; // 0x18
	public int count; // 0x1C
	private int _count; // 0x20
	private int _currentIdx; // 0x24
	private StatUnitMMA benchmarkFrameData; // 0x28

	// Properties
	public string statFolderName { /* [XID] */ /* 0x000000018997F8D0-0x000000018997F8F0 */ get => default; } // 0x0000000182CDDDF0-0x0000000182CDDEA0 
	public string statFileType { /* [XID] */ /* 0x00000001899872C0-0x00000001899872E0 */ get => default; } // 0x0000000182CDDD40-0x0000000182CDDDF0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public string statFileName { /* [XID] */ /* 0x000000018998ED90-0x000000018998EDB0 */ get => default; } // 0x0000000182CDDC90-0x0000000182CDDD40 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public int statLOD { /* [XID] */ /* 0x0000000189996950-0x0000000189996970 */ get => default; } // 0x0000000182CDDEA0-0x0000000182CDDF40 
	public static string csvTitleStr { /* [XID] */ /* 0x00000001899AD410-0x00000001899AD430 */ get => default; } // 0x0000000182CDD1A0-0x0000000182CDD240 

	// Constructors
	public BenchmarkNPCWithTickStrategyGroup() {} // 0x0000000182CDDC30-0x0000000182CDDC90

	// Methods
	// [XID] // 0x000000018999E3D0-0x000000018999E3F0
	public int GetJobCount() => default; // 0x0000000182CDD240-0x0000000182CDD2E0
	// [XID] // 0x00000001899A5DB0-0x00000001899A5DD0
	public void PreStat() {} // 0x0000000182CDD080-0x0000000182CDD1A0
	// [XID] // 0x00000001899B4CD0-0x00000001899B4CF0
	public string ToCSVTitleString() => default; // 0x0000000182CDCD30-0x0000000182CDCFC0
	// [XID] // 0x00000001899BC410-0x00000001899BC430
	public string ToInvalidStatCSVString() => default; // 0x0000000182CDD400-0x0000000182CDDA00
	// [XID] // 0x00000001899C3D90-0x00000001899C3DB0
	public string ToValidStatCSVString(StatUnitMMA BaseFrameData) => default; // 0x0000000182CDDA00-0x0000000182CDDC30
	[DebuggerHidden] // 0x00000001899CB4F0-0x00000001899CB530
	// [XID] // 0x00000001899CB4F0-0x00000001899CB530
	public IEnumerator ExecuteAt(int index) => default; // 0x0000000182CDD2E0-0x0000000182CDD400
	// [XID] // 0x00000001899D5AE0-0x00000001899D5B00
	public void PostStat() {} // 0x0000000182CDCFC0-0x0000000182CDD080
}

