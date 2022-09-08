/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class FleurFairDungeonExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15105
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 sectionIdRawNum; // 0x14
	protected SimpleSafeUInt32 openDayRawNum; // 0x18
	protected SimpleSafeUInt32 obtainCoinLimitRawNum; // 0x1C
	protected SimpleSafeUInt32 activityIdRawNum; // 0x20
	protected SimpleSafeUInt32[] _watcherIdList; // 0x28
	protected SimpleSafeUInt32 dungeonIdRawNum; // 0x30
	protected SimpleSafeUInt32[] _miniGameList; // 0x38
	protected SimpleSafeUInt32[] _monsterList; // 0x40
	protected SimpleSafeUInt32[] _energyGradeList; // 0x48
	protected SimpleSafeUInt32 initialEnergyRawNum; // 0x50
	protected SimpleSafeUInt32 energyLimitRawNum; // 0x54
	protected SimpleSafeUInt32 successRewardIdRawNum; // 0x58
	protected SimpleSafeUInt32 failureRewardIdRawNum; // 0x5C
	protected SimpleSafeUInt32 punishTimeRawNum; // 0x60
	protected uint _titleTextMapHash; // 0x64
	protected uint _descTextMapHash; // 0x68

	// Properties
	public uint id { /* [XID] */ /* 0x00000001898FB000-0x00000001898FB020 */ get => default; /* [XID] */ /* 0x0000000189902AE0-0x0000000189902B00 */ protected set {} } // 0x000000018078D020-0x000000018078D0F0 0x000000018078B6C0-0x000000018078B7A0
	public uint sectionId { /* [XID] */ /* 0x000000018990A0C0-0x000000018990A0E0 */ get => default; /* [XID] */ /* 0x00000001899119C0-0x00000001899119E0 */ protected set {} } // 0x000000018078B840-0x000000018078B910 0x000000018078AF50-0x000000018078B030
	public uint openDay { /* [XID] */ /* 0x00000001899195A0-0x00000001899195C0 */ get => default; /* [XID] */ /* 0x0000000189920AF0-0x0000000189920B10 */ protected set {} } // 0x000000018078CD70-0x000000018078CE40 0x0000000180788400-0x00000001807884E0
	public uint obtainCoinLimit { /* [XID] */ /* 0x0000000189928530-0x0000000189928550 */ get => default; /* [XID] */ /* 0x000000018992F9C0-0x000000018992F9E0 */ protected set {} } // 0x000000018078B030-0x000000018078B100 0x00000001807884E0-0x00000001807885C0
	public uint activityId { /* [XID] */ /* 0x0000000189936F30-0x0000000189936F50 */ get => default; /* [XID] */ /* 0x000000018993EAB0-0x000000018993EAD0 */ protected set {} } // 0x000000018078C9D0-0x000000018078CAA0 0x000000018078B5E0-0x000000018078B6C0
	public SimpleSafeUInt32[] watcherIdList { /* [XID] */ /* 0x0000000189946160-0x0000000189946180 */ get => default; /* [XID] */ /* 0x000000018994D630-0x000000018994D650 */ protected set {} } // 0x000000018078CCD0-0x000000018078CD70 0x000000018078CAA0-0x000000018078CB50
	public uint dungeonId { /* [XID] */ /* 0x0000000189954D40-0x0000000189954D60 */ get => default; /* [XID] */ /* 0x000000018995C540-0x000000018995C560 */ protected set {} } // 0x000000018078C900-0x000000018078C9D0 0x000000018078D2A0-0x000000018078D380
	public SimpleSafeUInt32[] miniGameList { /* [XID] */ /* 0x0000000189963F00-0x0000000189963F20 */ get => default; /* [XID] */ /* 0x000000018996B470-0x000000018996B490 */ protected set {} } // 0x000000018078B7A0-0x000000018078B840 0x000000018078ADC0-0x000000018078AE70
	public SimpleSafeUInt32[] monsterList { /* [XID] */ /* 0x0000000189972F70-0x0000000189972F90 */ get => default; /* [XID] */ /* 0x000000018997A830-0x000000018997A850 */ protected set {} } // 0x0000000180788B10-0x0000000180788BB0 0x000000018078C630-0x000000018078C6E0
	public SimpleSafeUInt32[] energyGradeList { /* [XID] */ /* 0x0000000189982280-0x00000001899822A0 */ get => default; /* [XID] */ /* 0x0000000189989A20-0x0000000189989A40 */ protected set {} } // 0x000000018078CE40-0x000000018078CEE0 0x000000018078CC20-0x000000018078CCD0
	public uint initialEnergy { /* [XID] */ /* 0x0000000189991290-0x00000001899912B0 */ get => default; /* [XID] */ /* 0x0000000189998D70-0x0000000189998D90 */ protected set {} } // 0x0000000180788810-0x00000001807888E0 0x000000018078AE70-0x000000018078AF50
	public uint energyLimit { /* [XID] */ /* 0x00000001899A0610-0x00000001899A0630 */ get => default; /* [XID] */ /* 0x00000001899A8120-0x00000001899A8140 */ protected set {} } // 0x000000018078B440-0x000000018078B510 0x000000018078B1E0-0x000000018078B2C0
	public uint successRewardId { /* [XID] */ /* 0x00000001899AF830-0x00000001899AF850 */ get => default; /* [XID] */ /* 0x00000001899B6D10-0x00000001899B6D30 */ protected set {} } // 0x000000018078D0F0-0x000000018078D1C0 0x0000000180788980-0x0000000180788A60
	public uint failureRewardId { /* [XID] */ /* 0x00000001899BE7F0-0x00000001899BE810 */ get => default; /* [XID] */ /* 0x00000001899C6010-0x00000001899C6030 */ protected set {} } // 0x000000018078CB50-0x000000018078CC20 0x000000018078D1C0-0x000000018078D2A0
	public uint punishTime { /* [XID] */ /* 0x00000001899CD810-0x00000001899CD830 */ get => default; /* [XID] */ /* 0x00000001899D4CB0-0x00000001899D4CD0 */ protected set {} } // 0x000000018078B510-0x000000018078B5E0 0x000000018078B100-0x000000018078B1E0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x00000001899DC350-0x00000001899DC370 */ get => default; /* [XID] */ /* 0x00000001899E3B70-0x00000001899E3B90 */ protected set {} } // 0x00000001807888E0-0x0000000180788980 0x0000000180788BB0-0x0000000180788C60
	public string title { /* [XID] */ /* 0x00000001899EB000-0x00000001899EB020 */ get => default; } // 0x000000018078C780-0x000000018078C900 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x00000001899F2C00-0x00000001899F2C20 */ get => default; /* [XID] */ /* 0x00000001899FA2B0-0x00000001899FA2D0 */ protected set {} } // 0x000000018078C6E0-0x000000018078C780 0x0000000180788A60-0x0000000180788B10
	public string desc { /* [XID] */ /* 0x0000000189A015F0-0x0000000189A01610 */ get => default; } // 0x000000018078B2C0-0x000000018078B440 

	// Constructors
	public FleurFairDungeonExcelConfig() {} // 0x000000018078D420-0x000000018078D480

	// Methods
	// [IDTag] // 0x0000000189A09010-0x0000000189A09050
	// [XID] // 0x0000000189A09010-0x0000000189A09050
	public virtual bool ParseFromLine(string line) => default; // 0x0000000180788C60-0x0000000180789CF0
	// [IDTag] // 0x0000000189A13800-0x0000000189A13840
	// [XID] // 0x0000000189A13800-0x0000000189A13840
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000180789CF0-0x000000018078ADC0
	// [XID] // 0x0000000189A1DA80-0x0000000189A1DAA0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF00F3 */, bool useObjectPool = false /* Metadata: 0x00AF00F7 */) => default; // 0x000000018078B910-0x000000018078C630
	[BlackList] // 0x0000000189A24F50-0x0000000189A24F90
	// [XID] // 0x0000000189A24F50-0x0000000189A24F90
	public virtual void AutoAllocTypeFields() {} // 0x00000001807885C0-0x0000000180788660
	[BlackList] // 0x0000000189A2F550-0x0000000189A2F590
	// [XID] // 0x0000000189A2F550-0x0000000189A2F590
	public virtual void AutoRecycleTypeFields() {} // 0x0000000180788660-0x0000000180788810
	[BlackList] // 0x0000000189A39CF0-0x0000000189A39D30
	// [XID] // 0x0000000189A39CF0-0x0000000189A39D30
	public virtual void ReturnToObjectPool() {} // 0x000000018078D380-0x000000018078D420
	[BlackList] // 0x0000000189A44570-0x0000000189A445B0
	// [XID] // 0x0000000189A44570-0x0000000189A445B0
	public virtual void OnPoolAllocated() {} // 0x000000018078CF80-0x000000018078D020
	[BlackList] // 0x0000000189A4EC30-0x0000000189A4EC70
	// [XID] // 0x0000000189A4EC30-0x0000000189A4EC70
	public virtual void OnBeforePoolRecycled() {} // 0x000000018078CEE0-0x000000018078CF80
}

