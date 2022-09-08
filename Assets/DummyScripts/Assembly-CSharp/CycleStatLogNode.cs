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

public class CycleStatLogNode // TypeDefIndex: 27863
{
	// Fields
	public List<CycleStatLogNode> children; // 0x10
	private CycleStat _cycleStat; // 0x18
	public int tickInterval; // 0x20
	public int tickBalanceRemainder; // 0x24
	public int requestTickInterval; // 0x28
	public bool bIgnoreIntervalTick; // 0x2C
	public int distance; // 0x30
	public float balanceTickDeltaTime; // 0x34
	public const string TickLogFormatString = "{0}  ts: {1:F3}, t:{2:F3}, l:{3:F3}, f:{4:F3}"; // Metadata: 0x00B0D081
	public bool bPause; // 0x38
	public CycleStatData _inclusiveStatData; // 0x40
	private static Func<CycleStatLogNode, CycleStatLogNode, bool> isLess; // 0x00

	// Properties
	public CycleStat cycleStat { /* [XID] */ /* 0x000000018991A2A0-0x000000018991A2C0 */ get => default; } // 0x0000000184033720-0x00000001840337C0 
	public string statName { /* [XID] */ /* 0x0000000189921B00-0x0000000189921B20 */ get => default; } // 0x0000000184035830-0x0000000184035930 
	public double totalTime { /* [XID] */ /* 0x0000000189929200-0x0000000189929220 */ get => default; } // 0x0000000184035520-0x00000001840355E0 
	public double tickTime { /* [XID] */ /* 0x00000001899307C0-0x00000001899307E0 */ get => default; } // 0x0000000184034EA0-0x0000000184034F60 
	public double fixedTickTime { /* [XID] */ /* 0x0000000189937CE0-0x0000000189937D00 */ get => default; } // 0x0000000184035460-0x0000000184035520 
	public double lateTickTime { /* [XID] */ /* 0x000000018993F750-0x000000018993F770 */ get => default; } // 0x0000000184035010-0x00000001840350D0 
	public uint handleOnEventCount { /* [XID] */ /* 0x0000000189946D60-0x0000000189946D80 */ get => default; } // 0x00000001840343C0-0x0000000184034470 
	public double handleOnEventTime { /* [XID] */ /* 0x000000018994E3D0-0x000000018994E3F0 */ get => default; } // 0x0000000184033D10-0x0000000184033DD0 
	public uint handleListenEventCount { /* [XID] */ /* 0x0000000189955A60-0x0000000189955A80 */ get => default; } // 0x0000000184033670-0x0000000184033720 
	public double handleListenEventTime { /* [XID] */ /* 0x000000018995D520-0x000000018995D540 */ get => default; } // 0x00000001840337C0-0x0000000184033880 
	public uint handleOnEventResolvedCount { /* [XID] */ /* 0x0000000189964C40-0x0000000189964C60 */ get => default; } // 0x0000000184034DF0-0x0000000184034EA0 
	public double handleOnEventResolvedTime { /* [XID] */ /* 0x000000018996C1F0-0x000000018996C210 */ get => default; } // 0x00000001840353A0-0x0000000184035460 
	public double totalTimeInc { /* [XID] */ /* 0x000000018998A5B0-0x000000018998A5D0 */ get => default; } // 0x0000000184034F60-0x0000000184035010 
	public double totalTickTimeInc { /* [XID] */ /* 0x0000000189A5FC00-0x0000000189A5FC20 */ get => default; } // 0x00000001840350D0-0x0000000184035180 
	public double tickTimeInc { /* [XID] */ /* 0x0000000189999C80-0x0000000189999CA0 */ get => default; } // 0x00000001840355E0-0x0000000184035690 
	public double fixedTickTimeInc { /* [XID] */ /* 0x00000001899A1320-0x00000001899A1340 */ get => default; } // 0x0000000184033940-0x00000001840339F0 
	public double lateTickTimeInc { /* [XID] */ /* 0x00000001899A8D70-0x00000001899A8D90 */ get => default; } // 0x00000001840339F0-0x0000000184033AA0 
	public uint handleOnEventCountInc { /* [XID] */ /* 0x00000001899B06F0-0x00000001899B0710 */ get => default; } // 0x0000000184034320-0x00000001840343C0 
	public double handleOnEventTimeInc { /* [XID] */ /* 0x00000001899B7A60-0x00000001899B7A80 */ get => default; } // 0x00000001840341C0-0x0000000184034270 
	public uint handleListenEventCountInc { /* [XID] */ /* 0x00000001899BF480-0x00000001899BF4A0 */ get => default; } // 0x0000000184033C70-0x0000000184033D10 
	public double handleListenEventTimeInc { /* [XID] */ /* 0x00000001899C6DF0-0x00000001899C6E10 */ get => default; } // 0x0000000184034470-0x0000000184034520 
	public uint handleOnEventResolvedCountInc { /* [XID] */ /* 0x00000001899CE300-0x00000001899CE320 */ get => default; } // 0x0000000184035790-0x0000000184035830 
	public double handleOnEventResolvedTimeInc { /* [XID] */ /* 0x00000001899D5AC0-0x00000001899D5AE0 */ get => default; } // 0x0000000184034270-0x0000000184034320 

	// Constructors
	public CycleStatLogNode() {} // 0x0000000184035990-0x0000000184035B20
	static CycleStatLogNode() {} // 0x0000000184035930-0x0000000184035990

	// Methods
	// [XID] // 0x00000001895EFE10-0x00000001895EFE30
	public void UpdateTickBalanceInfo(ITickBalanceObject inTBO) {} // 0x0000000184034A80-0x0000000184034D30
	// [XID] // 0x00000001899037F0-0x0000000189903810
	public void CloneOtherTBOInfo(CycleStatLogNode inStatNode) {} // 0x0000000184033AA0-0x0000000184033B80
	// [XID] // 0x000000018990AD80-0x000000018990ADA0
	public string ToLog() => default; // 0x0000000184033360-0x0000000184033670
	// [XID] // 0x00000001899129F0-0x0000000189912A10
	public string ToContainChildrenNodeLog(int indent = 0 /* Metadata: 0x00B0D07D */) => default; // 0x0000000184033DD0-0x00000001840340B0
	// [XID] // 0x0000000189612400-0x0000000189612420
	public void AccumulateInclusiveStatValue(ref CycleStatData other) {} // 0x0000000184034D30-0x0000000184034DF0
	// [XID] // 0x000000018997B3F0-0x000000018997B410
	public CycleStatLogNode AccumulateSelfToInclusiveStat() => default; // 0x0000000184033880-0x0000000184033940
	// [XID] // 0x0000000189982E20-0x0000000189982E40
	public CycleStatLogNode AccumulateExclusiveStat() => default; // 0x0000000184035180-0x0000000184035240
	// [XID] // 0x00000001899DCEB0-0x00000001899DCED0
	public static CycleStatLogNode NewPooledCSLNode(CycleStat inStat, ITickBalanceObject inTBO) => default; // 0x00000001840340B0-0x00000001840341C0
	// [XID] // 0x00000001899E4A10-0x00000001899E4A30
	private static bool IsLess(CycleStatLogNode cs1, CycleStatLogNode cs2) => default; // 0x0000000184033B80-0x0000000184033C70
	// [XID] // 0x00000001899EBF00-0x00000001899EBF20
	public void AddChild(CycleStatLogNode inNode, bool bInClone) {} // 0x0000000184035240-0x00000001840353A0
	// [XID] // 0x00000001899F3910-0x00000001899F3930
	public static CycleStatLogNode Clone(CycleStatLogNode other) => default; // 0x00000001840347E0-0x0000000184034A80
	// [XID] // 0x00000001899FB250-0x00000001899FB270
	public void Flush(bool bReturnPooledStat, bool bClearHistroyStat) {} // 0x0000000184034520-0x00000001840347E0
}

