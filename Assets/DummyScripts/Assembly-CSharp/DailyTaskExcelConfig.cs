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
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class DailyTaskExcelConfig : IAutoAllocRecycle // TypeDefIndex: 14860
{
	// Fields
	private Vector3? _centerPositionCustom; // 0x10
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 IDRawNum; // 0x20
	protected SimpleSafeUInt32 cityIdRawNum; // 0x24
	protected SimpleSafeUInt32 poolIdRawNum; // 0x28
	protected DailyTaskType _type; // 0x2C
	protected SimpleSafeUInt32 rarityRawNum; // 0x30
	protected SimpleSafeUInt32 questIdRawNum; // 0x34
	protected SimpleSafeUInt32[] _oldGroupVec; // 0x38
	protected SimpleSafeUInt32[] _newGroupVec; // 0x40
	protected DailyTaskFinishType _finishType; // 0x48
	protected SimpleSafeUInt32 finishParam1RawNum; // 0x4C
	protected SimpleSafeUInt32 finishParam2RawNum; // 0x50
	protected SimpleSafeUInt32 finishProgressRawNum; // 0x54
	protected SimpleSafeUInt32 taskRewardIdRawNum; // 0x58
	protected string _centerPosition; // 0x60
	protected SimpleSafeUInt32 enterDistanceRawNum; // 0x68
	protected SimpleSafeUInt32 exitDistanceRawNum; // 0x6C
	protected uint _titleTextMapHash; // 0x70
	protected uint _descriptionTextMapHash; // 0x74
	protected uint _targetTextMapHash; // 0x78
	protected SimpleSafeFloat radarRadiusRawNum; // 0x7C

	// Properties
	public uint ID { /* [XID] */ /* 0x00000001898F0AC0-0x00000001898F0AE0 */ get => default; /* [XID] */ /* 0x00000001898F83F0-0x00000001898F8410 */ protected set {} } // 0x0000000181E3ADF0-0x0000000181E3AEC0 0x0000000181E37DD0-0x0000000181E37EB0
	public uint cityId { /* [XID] */ /* 0x00000001898FFB90-0x00000001898FFBB0 */ get => default; /* [XID] */ /* 0x0000000189907370-0x0000000189907390 */ protected set {} } // 0x0000000181E3CC40-0x0000000181E3CD10 0x0000000181E3A870-0x0000000181E3A950
	public uint poolId { /* [XID] */ /* 0x000000018990ED30-0x000000018990ED50 */ get => default; /* [XID] */ /* 0x0000000189916400-0x0000000189916420 */ protected set {} } // 0x0000000181E38290-0x0000000181E38360 0x0000000181E3A570-0x0000000181E3A650
	public DailyTaskType type { /* [XID] */ /* 0x000000018991DD90-0x000000018991DDB0 */ get => default; /* [XID] */ /* 0x0000000189925500-0x0000000189925520 */ protected set {} } // 0x0000000181E3D270-0x0000000181E3D310 0x0000000181E3C9E0-0x0000000181E3CA90
	public uint rarity { /* [XID] */ /* 0x000000018992CA40-0x000000018992CA60 */ get => default; /* [XID] */ /* 0x00000001899340A0-0x00000001899340C0 */ protected set {} } // 0x0000000181E3CA90-0x0000000181E3CB60 0x0000000181E3C2B0-0x0000000181E3C390
	public uint questId { /* [XID] */ /* 0x000000018993BD50-0x000000018993BD70 */ get => default; /* [XID] */ /* 0x0000000189942F50-0x0000000189942F70 */ protected set {} } // 0x0000000181E3A3F0-0x0000000181E3A4C0 0x0000000181E3AC60-0x0000000181E3AD40
	public SimpleSafeUInt32[] oldGroupVec { /* [XID] */ /* 0x000000018994A6C0-0x000000018994A6E0 */ get => default; /* [XID] */ /* 0x0000000189952110-0x0000000189952130 */ protected set {} } // 0x0000000181E3D3F0-0x0000000181E3D490 0x0000000181E3A4C0-0x0000000181E3A570
	public SimpleSafeUInt32[] newGroupVec { /* [XID] */ /* 0x0000000189959690-0x00000001899596B0 */ get => default; /* [XID] */ /* 0x0000000189960FA0-0x0000000189960FC0 */ protected set {} } // 0x0000000181E3ABC0-0x0000000181E3AC60 0x0000000181E3A950-0x0000000181E3AA00
	public DailyTaskFinishType finishType { /* [XID] */ /* 0x0000000189968720-0x0000000189968740 */ get => default; /* [XID] */ /* 0x000000018996FC00-0x000000018996FC20 */ protected set {} } // 0x0000000181E38630-0x0000000181E386D0 0x0000000181E3AD40-0x0000000181E3ADF0
	public uint finishParam1 { /* [XID] */ /* 0x0000000189977A80-0x0000000189977AA0 */ get => default; /* [XID] */ /* 0x000000018997EC40-0x000000018997EC60 */ protected set {} } // 0x0000000181E3C790-0x0000000181E3C860 0x0000000181E3B1E0-0x0000000181E3B2C0
	public uint finishParam2 { /* [XID] */ /* 0x0000000189986530-0x0000000189986550 */ get => default; /* [XID] */ /* 0x000000018998E1C0-0x000000018998E1E0 */ protected set {} } // 0x0000000181E3C5E0-0x0000000181E3C6B0 0x0000000181E3C900-0x0000000181E3C9E0
	public uint finishProgress { /* [XID] */ /* 0x0000000189995BF0-0x0000000189995C10 */ get => default; /* [XID] */ /* 0x000000018999D6B0-0x000000018999D6D0 */ protected set {} } // 0x0000000181E3AEC0-0x0000000181E3AF90 0x0000000181E3AA00-0x0000000181E3AAE0
	public uint taskRewardId { /* [XID] */ /* 0x00000001899A5030-0x00000001899A5050 */ get => default; /* [XID] */ /* 0x00000001899ACA90-0x00000001899ACAB0 */ protected set {} } // 0x0000000181E3C390-0x0000000181E3C460 0x0000000181E3C1D0-0x0000000181E3C2B0
	public string centerPosition { /* [XID] */ /* 0x00000001899B4260-0x00000001899B4280 */ get => default; /* [XID] */ /* 0x00000001899BB710-0x00000001899BB730 */ protected set {} } // 0x0000000181E3C860-0x0000000181E3C900 0x0000000181E3B130-0x0000000181E3B1E0
	public uint enterDistance { /* [XID] */ /* 0x00000001899C3300-0x00000001899C3320 */ get => default; /* [XID] */ /* 0x00000001899CA7E0-0x00000001899CA800 */ protected set {} } // 0x0000000181E3B060-0x0000000181E3B130 0x0000000181E3C6B0-0x0000000181E3C790
	public uint exitDistance { /* [XID] */ /* 0x00000001899D1EE0-0x00000001899D1F00 */ get => default; /* [XID] */ /* 0x00000001899D9430-0x00000001899D9450 */ protected set {} } // 0x0000000181E3AF90-0x0000000181E3B060 0x0000000181E3D310-0x0000000181E3D3F0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x00000001899E0B20-0x00000001899E0B40 */ get => default; /* [XID] */ /* 0x00000001899E8700-0x00000001899E8720 */ protected set {} } // 0x0000000181E384E0-0x0000000181E38580 0x0000000181E38580-0x0000000181E38630
	public string title { /* [XID] */ /* 0x00000001899EFD90-0x00000001899EFDB0 */ get => default; } // 0x0000000181E3C460-0x0000000181E3C5E0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descriptionTextMapHash { /* [XID] */ /* 0x00000001899F7430-0x00000001899F7450 */ get => default; /* [XID] */ /* 0x00000001899FEB70-0x00000001899FEB90 */ protected set {} } // 0x0000000181E3A650-0x0000000181E3A6F0 0x0000000181E3CD10-0x0000000181E3CDC0
	public string description { /* [XID] */ /* 0x0000000189A06370-0x0000000189A06390 */ get => default; } // 0x0000000181E3A6F0-0x0000000181E3A870 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint targetTextMapHash { /* [XID] */ /* 0x0000000189A0D880-0x0000000189A0D8A0 */ get => default; /* [XID] */ /* 0x0000000189A14F80-0x0000000189A14FA0 */ protected set {} } // 0x0000000181E37EB0-0x0000000181E37F50 0x0000000181E381E0-0x0000000181E38290
	public string target { /* [XID] */ /* 0x0000000189A1C0D0-0x0000000189A1C0F0 */ get => default; } // 0x0000000181E38360-0x0000000181E384E0 
	public float radarRadius { /* [XID] */ /* 0x0000000189A239E0-0x0000000189A23A00 */ get => default; /* [XID] */ /* 0x0000000189A2AE00-0x0000000189A2AE20 */ protected set {} } // 0x0000000181E3AAE0-0x0000000181E3ABC0 0x0000000181E3CB60-0x0000000181E3CC40

	// Constructors
	public DailyTaskExcelConfig() {} // 0x0000000181E3D530-0x0000000181E3D5B0

	// Methods
	// [XID] // 0x00000001898E9300-0x00000001898E9320
	public Vector3 GetCenterPosition() => default; // 0x0000000181E3CDC0-0x0000000181E3D130
	// [IDTag] // 0x0000000189A32340-0x0000000189A32380
	// [XID] // 0x0000000189A32340-0x0000000189A32380
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181E386D0-0x0000000181E39550
	// [IDTag] // 0x0000000189A3CBE0-0x0000000189A3CC20
	// [XID] // 0x0000000189A3CBE0-0x0000000189A3CC20
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181E39550-0x0000000181E3A3F0
	// [XID] // 0x0000000189A47490-0x0000000189A474B0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF80D */, bool useObjectPool = false /* Metadata: 0x00AEF811 */) => default; // 0x0000000181E3B2C0-0x0000000181E3C1D0
	[BlackList] // 0x0000000189A4ECD0-0x0000000189A4ED10
	// [XID] // 0x0000000189A4ECD0-0x0000000189A4ED10
	public virtual void AutoAllocTypeFields() {} // 0x0000000181E37F50-0x0000000181E37FF0
	[BlackList] // 0x0000000189A59460-0x0000000189A594A0
	// [XID] // 0x0000000189A59460-0x0000000189A594A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181E37FF0-0x0000000181E381E0
	[BlackList] // 0x0000000189A63F50-0x0000000189A63F90
	// [XID] // 0x0000000189A63F50-0x0000000189A63F90
	public virtual void ReturnToObjectPool() {} // 0x0000000181E3D490-0x0000000181E3D530
	[BlackList] // 0x0000000189A6E720-0x0000000189A6E760
	// [XID] // 0x0000000189A6E720-0x0000000189A6E760
	public virtual void OnPoolAllocated() {} // 0x0000000181E3D1D0-0x0000000181E3D270
	[BlackList] // 0x0000000189A79040-0x0000000189A79080
	// [XID] // 0x0000000189A79040-0x0000000189A79080
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181E3D130-0x0000000181E3D1D0
}

