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
public class TowerScheduleExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16193
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 scheduleIdRawNum; // 0x10
	protected SimpleSafeUInt32[] _entranceFloorId; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected TowerSchedule[] _schedules; // 0x20
	protected string _closeTime; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected TowerStarReward[] _scheduleRewards; // 0x30
	protected SimpleSafeUInt32 commemorativeRewardRawNum; // 0x38
	protected SimpleSafeUInt32 monthlyLevelConfigIdRawNum; // 0x3C
	protected uint _descTextMapHash; // 0x40
	protected uint _buffnameTextMapHash; // 0x44
	protected string _icon; // 0x48

	// Properties
	public uint scheduleId { /* [XID] */ /* 0x000000018986BB20-0x000000018986BB40 */ get => default; /* [XID] */ /* 0x0000000189872DB0-0x0000000189872DD0 */ protected set {} } // 0x00000001847EF810-0x00000001847EF8E0 0x00000001847F2430-0x00000001847F2510
	public SimpleSafeUInt32[] entranceFloorId { /* [XID] */ /* 0x000000018987AA90-0x000000018987AAB0 */ get => default; /* [XID] */ /* 0x0000000189881B60-0x0000000189881B80 */ protected set {} } // 0x00000001847F1600-0x00000001847F16A0 0x00000001847F16A0-0x00000001847F1750
	public TowerSchedule[] schedules { /* [XID] */ /* 0x0000000189889240-0x0000000189889260 */ get => default; /* [XID] */ /* 0x00000001898906C0-0x00000001898906E0 */ protected set {} } // 0x00000001847EFD60-0x00000001847EFE00 0x00000001847F1A50-0x00000001847F1B00
	public string closeTime { /* [XID] */ /* 0x0000000189897C60-0x0000000189897C80 */ get => default; /* [XID] */ /* 0x000000018989F040-0x000000018989F060 */ protected set {} } // 0x00000001847F18D0-0x00000001847F1970 0x00000001847F27D0-0x00000001847F2880
	public TowerStarReward[] scheduleRewards { /* [XID] */ /* 0x00000001898A6BA0-0x00000001898A6BC0 */ get => default; /* [XID] */ /* 0x00000001898AE2B0-0x00000001898AE2D0 */ protected set {} } // 0x00000001847F1250-0x00000001847F12F0 0x00000001847F12F0-0x00000001847F13A0
	public uint commemorativeReward { /* [XID] */ /* 0x00000001898B5790-0x00000001898B57B0 */ get => default; /* [XID] */ /* 0x00000001898BD240-0x00000001898BD260 */ protected set {} } // 0x00000001847F1530-0x00000001847F1600 0x00000001847F1970-0x00000001847F1A50
	public uint monthlyLevelConfigId { /* [XID] */ /* 0x00000001898C49E0-0x00000001898C4A00 */ get => default; /* [XID] */ /* 0x00000001898CBEF0-0x00000001898CBF10 */ protected set {} } // 0x00000001847F25C0-0x00000001847F2690 0x00000001847F13A0-0x00000001847F1480
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x00000001898D36F0-0x00000001898D3710 */ get => default; /* [XID] */ /* 0x00000001898DAF00-0x00000001898DAF20 */ protected set {} } // 0x00000001847F2390-0x00000001847F2430 0x00000001847EFE00-0x00000001847EFEB0
	public string desc { /* [XID] */ /* 0x00000001898E2C20-0x00000001898E2C40 */ get => default; } // 0x00000001847F1750-0x00000001847F18D0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint buffnameTextMapHash { /* [XID] */ /* 0x00000001898EA910-0x00000001898EA930 */ get => default; /* [XID] */ /* 0x00000001898F1FF0-0x00000001898F2010 */ protected set {} } // 0x00000001847EFCC0-0x00000001847EFD60 0x00000001847F1480-0x00000001847F1530
	public string buffname { /* [XID] */ /* 0x00000001898F97B0-0x00000001898F97D0 */ get => default; } // 0x00000001847EFB40-0x00000001847EFCC0 
	public string icon { /* [XID] */ /* 0x00000001899010D0-0x00000001899010F0 */ get => default; /* [XID] */ /* 0x0000000189908A10-0x0000000189908A30 */ protected set {} } // 0x00000001847EF8E0-0x00000001847EF980 0x00000001847F2510-0x00000001847F25C0

	// Constructors
	public TowerScheduleExcelConfig() {} // 0x00000001847F2920-0x00000001847F2980

	// Methods
	// [IDTag] // 0x000000018990FF50-0x000000018990FF90
	// [XID] // 0x000000018990FF50-0x000000018990FF90
	public virtual bool ParseFromLine(string line) => default; // 0x00000001847F0820-0x00000001847F1250
	// [IDTag] // 0x000000018991AB90-0x000000018991ABD0
	// [XID] // 0x000000018991AB90-0x000000018991ABD0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001847EFEB0-0x00000001847F0820
	// [XID] // 0x0000000189925280-0x00000001899252A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF33CF */, bool useObjectPool = false /* Metadata: 0x00AF33D3 */) => default; // 0x00000001847F1B00-0x00000001847F2390
	[BlackList] // 0x000000018992C880-0x000000018992C8C0
	// [XID] // 0x000000018992C880-0x000000018992C8C0
	public virtual void AutoAllocTypeFields() {} // 0x00000001847EF980-0x00000001847EFA20
	[BlackList] // 0x0000000189936D10-0x0000000189936D50
	// [XID] // 0x0000000189936D10-0x0000000189936D50
	public virtual void AutoRecycleTypeFields() {} // 0x00000001847EFA20-0x00000001847EFB40
	[BlackList] // 0x00000001899413A0-0x00000001899413E0
	// [XID] // 0x00000001899413A0-0x00000001899413E0
	public virtual void ReturnToObjectPool() {} // 0x00000001847F2880-0x00000001847F2920
	[BlackList] // 0x000000018994BD20-0x000000018994BD60
	// [XID] // 0x000000018994BD20-0x000000018994BD60
	public virtual void OnPoolAllocated() {} // 0x00000001847F2730-0x00000001847F27D0
	[BlackList] // 0x00000001899562A0-0x00000001899562E0
	// [XID] // 0x00000001899562A0-0x00000001899562E0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001847F2690-0x00000001847F2730
}

