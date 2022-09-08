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
public class BattlePassScheduleExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15249
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _titleNameTextMapHash; // 0x14
	protected string _beginDateStr; // 0x18
	protected string _endDateStr; // 0x20
	protected SimpleSafeUInt32[] _cycleList; // 0x28
	protected SimpleSafeUInt32 extraPaidRewardIdRawNum; // 0x30
	protected SimpleSafeUInt32 extraPaidAddPointRawNum; // 0x34
	protected SimpleSafeUInt32 buyLevelCostCoinNumRawNum; // 0x38
	protected SimpleSafeUInt32 cyclePointUpperLimitRawNum; // 0x3C
	protected SimpleSafeUInt32 levelRewardIndexIdRawNum; // 0x40
	protected SimpleSafeUInt32[] _normalRewardList; // 0x48
	protected BattlePassScheduleRewardType _rewardType; // 0x50
	protected string _showImage; // 0x58
	protected SimpleSafeUInt32[] _showRewardList; // 0x60
	protected SimpleSafeUInt32[] _stroyRewardList; // 0x68
	protected SimpleSafeUInt32 storyIdRawNum; // 0x70
	protected SimpleSafeUInt32 mailDayCountRawNum; // 0x74
	protected SimpleSafeUInt32 mailConfigIdRawNum; // 0x78

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189A1F150-0x0000000189A1F170 */ get => default; /* [XID] */ /* 0x0000000189A26740-0x0000000189A26760 */ protected set {} } // 0x0000000185B49A70-0x0000000185B49B40 0x0000000185B480A0-0x0000000185B48180
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleNameTextMapHash { /* [XID] */ /* 0x0000000189A2DA90-0x0000000189A2DAB0 */ get => default; /* [XID] */ /* 0x0000000189A356B0-0x0000000189A356D0 */ protected set {} } // 0x0000000185B454E0-0x0000000185B45580 0x0000000185B49580-0x0000000185B49630
	public string titleName { /* [XID] */ /* 0x0000000189A3CB00-0x0000000189A3CB20 */ get => default; } // 0x0000000185B49B40-0x0000000185B49CC0 
	public string beginDateStr { /* [XID] */ /* 0x0000000189A44510-0x0000000189A44530 */ get => default; /* [XID] */ /* 0x0000000189A4BAE0-0x0000000189A4BB00 */ protected set {} } // 0x0000000185B47E80-0x0000000185B47F20 0x0000000185B492D0-0x0000000185B49380
	public string endDateStr { /* [XID] */ /* 0x0000000189A531C0-0x0000000189A531E0 */ get => default; /* [XID] */ /* 0x0000000189A5A970-0x0000000189A5A990 */ protected set {} } // 0x0000000185B49630-0x0000000185B496D0 0x0000000185B47DD0-0x0000000185B47E80
	public SimpleSafeUInt32[] cycleList { /* [XID] */ /* 0x0000000189A62170-0x0000000189A62190 */ get => default; /* [XID] */ /* 0x0000000189A6A030-0x0000000189A6A050 */ protected set {} } // 0x0000000185B490F0-0x0000000185B49190 0x0000000185B47940-0x0000000185B479F0
	public uint extraPaidRewardId { /* [XID] */ /* 0x0000000189A71340-0x0000000189A71360 */ get => default; /* [XID] */ /* 0x0000000189A78F00-0x0000000189A78F20 */ protected set {} } // 0x0000000185B45410-0x0000000185B454E0 0x0000000185B47860-0x0000000185B47940
	public uint extraPaidAddPoint { /* [XID] */ /* 0x0000000189A80380-0x0000000189A803A0 */ get => default; /* [XID] */ /* 0x0000000189A88120-0x0000000189A88140 */ protected set {} } // 0x0000000185B47D00-0x0000000185B47DD0 0x0000000185B48180-0x0000000185B48260
	public uint buyLevelCostCoinNum { /* [XID] */ /* 0x0000000189A8F9F0-0x0000000189A8FA10 */ get => default; /* [XID] */ /* 0x0000000189A96FC0-0x0000000189A96FE0 */ protected set {} } // 0x0000000185B45580-0x0000000185B45650 0x0000000185B47B40-0x0000000185B47C20
	public uint cyclePointUpperLimit { /* [XID] */ /* 0x0000000189A9E3D0-0x0000000189A9E3F0 */ get => default; /* [XID] */ /* 0x0000000189AA5D80-0x0000000189AA5DA0 */ protected set {} } // 0x0000000185B45270-0x0000000185B45340 0x0000000185B496D0-0x0000000185B497B0
	public uint levelRewardIndexId { /* [XID] */ /* 0x0000000189AAD400-0x0000000189AAD420 */ get => default; /* [XID] */ /* 0x0000000189AB4D10-0x0000000189AB4D30 */ protected set {} } // 0x0000000185B44DC0-0x0000000185B44E90 0x0000000185B45190-0x0000000185B45270
	public SimpleSafeUInt32[] normalRewardList { /* [XID] */ /* 0x0000000189ABCA20-0x0000000189ABCA40 */ get => default; /* [XID] */ /* 0x0000000189AC4300-0x0000000189AC4320 */ protected set {} } // 0x0000000185B49190-0x0000000185B49230 0x0000000185B49430-0x0000000185B494E0
	public BattlePassScheduleRewardType rewardType { /* [XID] */ /* 0x0000000189ACB890-0x0000000189ACB8B0 */ get => default; /* [XID] */ /* 0x0000000189AD32E0-0x0000000189AD3300 */ protected set {} } // 0x0000000185B494E0-0x0000000185B49580 0x0000000185B479F0-0x0000000185B47AA0
	public string showImage { /* [XID] */ /* 0x0000000189ADAD20-0x0000000189ADAD40 */ get => default; /* [XID] */ /* 0x0000000189AE2540-0x0000000189AE2560 */ protected set {} } // 0x0000000185B47AA0-0x0000000185B47B40 0x0000000185B47F20-0x0000000185B47FD0
	public SimpleSafeUInt32[] showRewardList { /* [XID] */ /* 0x0000000189AE9E30-0x0000000189AE9E50 */ get => default; /* [XID] */ /* 0x0000000189AF1BB0-0x0000000189AF1BD0 */ protected set {} } // 0x0000000185B49230-0x0000000185B492D0 0x0000000185B49380-0x0000000185B49430
	public SimpleSafeUInt32[] stroyRewardList { /* [XID] */ /* 0x0000000189AF93B0-0x0000000189AF93D0 */ get => default; /* [XID] */ /* 0x0000000189B007F0-0x0000000189B00810 */ protected set {} } // 0x0000000185B497B0-0x0000000185B49850 0x0000000185B48260-0x0000000185B48310
	public uint storyId { /* [XID] */ /* 0x0000000189B07ED0-0x0000000189B07EF0 */ get => default; /* [XID] */ /* 0x0000000189B0F710-0x0000000189B0F730 */ protected set {} } // 0x0000000185B47FD0-0x0000000185B480A0 0x0000000185B47C20-0x0000000185B47D00
	public uint mailDayCount { /* [XID] */ /* 0x0000000189B16990-0x0000000189B169B0 */ get => default; /* [XID] */ /* 0x0000000189B1E030-0x0000000189B1E050 */ protected set {} } // 0x0000000185B450C0-0x0000000185B45190 0x0000000185B49850-0x0000000185B49930
	public uint mailConfigId { /* [XID] */ /* 0x0000000189B259A0-0x0000000189B259C0 */ get => default; /* [XID] */ /* 0x0000000189B2CDD0-0x0000000189B2CDF0 */ protected set {} } // 0x0000000185B45340-0x0000000185B45410 0x0000000185B44CE0-0x0000000185B44DC0

	// Constructors
	public BattlePassScheduleExcelConfig() {} // 0x0000000185B49D60-0x0000000185B49DC0

	// Methods
	// [IDTag] // 0x0000000189B34240-0x0000000189B34280
	// [XID] // 0x0000000189B34240-0x0000000189B34280
	public virtual bool ParseFromLine(string line) => default; // 0x0000000185B45650-0x0000000185B46730
	// [IDTag] // 0x0000000189B3ECA0-0x0000000189B3ECE0
	// [XID] // 0x0000000189B3ECA0-0x0000000189B3ECE0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000185B46730-0x0000000185B47860
	// [XID] // 0x0000000189B49880-0x0000000189B498A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF052D */, bool useObjectPool = false /* Metadata: 0x00AF0531 */) => default; // 0x0000000185B48310-0x0000000185B490F0
	[BlackList] // 0x0000000189B50F00-0x0000000189B50F40
	// [XID] // 0x0000000189B50F00-0x0000000189B50F40
	public virtual void AutoAllocTypeFields() {} // 0x0000000185B44E90-0x0000000185B44F30
	[BlackList] // 0x0000000189B5B650-0x0000000189B5B690
	// [XID] // 0x0000000189B5B650-0x0000000189B5B690
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185B44F30-0x0000000185B450C0
	[BlackList] // 0x0000000189B65D40-0x0000000189B65D80
	// [XID] // 0x0000000189B65D40-0x0000000189B65D80
	public virtual void ReturnToObjectPool() {} // 0x0000000185B49CC0-0x0000000185B49D60
	[BlackList] // 0x0000000189B703A0-0x0000000189B703E0
	// [XID] // 0x0000000189B703A0-0x0000000189B703E0
	public virtual void OnPoolAllocated() {} // 0x0000000185B499D0-0x0000000185B49A70
	[BlackList] // 0x0000000189B7A830-0x0000000189B7A870
	// [XID] // 0x0000000189B7A830-0x0000000189B7A870
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185B49930-0x0000000185B499D0
}

