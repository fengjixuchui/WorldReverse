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

public class BenchmarkNPCWithTickStrategy : IBatchedBenchmarkJob, IComparableBenchmarkJob // TypeDefIndex: 27668
{
	// Fields
	public uint[] npcIDs; // 0x10
	public int tickStrategy; // 0x18
	public int rectWidth; // 0x1C
	public int rectHeight; // 0x20
	public int startIndex; // 0x24
	public int count; // 0x28
	public int frameCount; // 0x2C
	public bool hasLuaBehaviour; // 0x30
	private BenchmarkSessionCancellation _cancelRequest; // 0x31
	private BenchmarkNPC.BenchmarkSession _currentBenchmarkSession; // 0x38
	private uint _currentNPCConfigID; // 0x40
	private int _count; // 0x44

	// Properties
	public string statFolderName { /* [XID] */ /* 0x0000000189892E60-0x0000000189892E80 */ get => default; } // 0x0000000183A5D2F0-0x0000000183A5D3A0 
	public string statFileType { /* [XID] */ /* 0x000000018989A4D0-0x000000018989A4F0 */ get => default; } // 0x0000000183A5D240-0x0000000183A5D2F0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public string statFileName { /* [XID] */ /* 0x00000001898A17D0-0x00000001898A17F0 */ get => default; } // 0x0000000183A5D150-0x0000000183A5D240 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public int statLOD { /* [XID] */ /* 0x00000001898A8FC0-0x00000001898A8FE0 */ get => default; } // 0x0000000183A5D3A0-0x0000000183A5D440 
	public static string csvTitleStr { /* [XID] */ /* 0x00000001898C6F40-0x00000001898C6F60 */ get => default; } // 0x0000000183A5BA60-0x0000000183A5BB00 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public StatUnitMMA benchmarkFrameData { /* [XID] */ /* 0x00000001898D5ED0-0x00000001898D5F10 */ get; /* [XID] */ /* 0x00000001898E0C00-0x00000001898E0C40 */ private set; } // 0x0000000183A5D0F0-0x0000000183A5D150 0x0000000183A5BDE0-0x0000000183A5BE40
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public StatUnitMMA baseFrameData { get; /* [XID] */ /* 0x00000001898F2DD0-0x00000001898F2E10 */ private set; } // 0x0000000183A5D090-0x0000000183A5D0F0 0x0000000183A5C440-0x0000000183A5C4A0

	// Constructors
	public BenchmarkNPCWithTickStrategy() {} // 0x0000000183A5D030-0x0000000183A5D090

	// Methods
	// [XID] // 0x00000001898B0930-0x00000001898B0950
	public int GetJobCount() => default; // 0x0000000183A5BB00-0x0000000183A5BBA0
	// [XID] // 0x00000001898B7FB0-0x00000001898B7FD0
	private bool HandleCancelStatCmd(string[] statArgs) => default; // 0x0000000183A5BBA0-0x0000000183A5BCC0
	// [XID] // 0x00000001898BF700-0x00000001898BF720
	public void PreStat() {} // 0x0000000183A5B8E0-0x0000000183A5BA60
	// [XID] // 0x00000001898CE460-0x00000001898CE480
	public string ToCSVTitleString() => default; // 0x0000000183A5B590-0x0000000183A5B820
	// [XID] // 0x00000001898FD760-0x00000001898FD780
	public string ToInvalidStatCSVString() => default; // 0x0000000183A5BE40-0x0000000183A5C440
	// [XID] // 0x0000000189905000-0x0000000189905020
	public string ToValidStatCSVString(StatUnitMMA BaseFrameData) => default; // 0x0000000183A5C4A0-0x0000000183A5D030
	[DebuggerHidden] // 0x000000018990C860-0x000000018990C8A0
	// [XID] // 0x000000018990C860-0x000000018990C8A0
	public IEnumerator ExecuteAt(int index) => default; // 0x0000000183A5BCC0-0x0000000183A5BDE0
	// [XID] // 0x00000001899172D0-0x00000001899172F0
	public void PostStat() {} // 0x0000000183A5B820-0x0000000183A5B8E0
}

