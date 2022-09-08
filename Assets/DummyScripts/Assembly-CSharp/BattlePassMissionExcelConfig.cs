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
public class BattlePassMissionExcelConfig : WatcherConfig, IAutoAllocRecycle // TypeDefIndex: 15253
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected BattlePassMissionRefreshType _refreshType; // 0x28
	protected bool _isForce; // 0x2C
	protected SimpleSafeUInt32 addPointRawNum; // 0x30
	protected SimpleSafeUInt32 scheduleIdRawNum; // 0x34
	protected SimpleSafeUInt32 activityIdRawNum; // 0x38
	protected uint _descTextMapHash; // 0x3C
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected QuestGuide _guide; // 0x40

	// Properties
	public BattlePassMissionRefreshType refreshType { /* [XID] */ /* 0x00000001897347D0-0x00000001897347F0 */ get => default; /* [XID] */ /* 0x000000018973C1A0-0x000000018973C1C0 */ protected set {} } // 0x00000001850D4FE0-0x00000001850D5080 0x00000001850D5080-0x00000001850D5130
	public bool isForce { /* [XID] */ /* 0x0000000189743930-0x0000000189743950 */ get => default; /* [XID] */ /* 0x000000018974B480-0x000000018974B4A0 */ protected set {} } // 0x00000001850D6180-0x00000001850D6220 0x00000001850D42A0-0x00000001850D4350
	public uint addPoint { /* [XID] */ /* 0x0000000189752690-0x00000001897526B0 */ get => default; /* [XID] */ /* 0x0000000189759BE0-0x0000000189759C00 */ protected set {} } // 0x00000001850D5FE0-0x00000001850D60B0 0x00000001850D40B0-0x00000001850D4190
	public uint scheduleId { /* [XID] */ /* 0x0000000189761830-0x0000000189761850 */ get => default; /* [XID] */ /* 0x0000000189768C00-0x0000000189768C20 */ protected set {} } // 0x00000001850D3D90-0x00000001850D3E60 0x00000001850D5F00-0x00000001850D5FE0
	public uint activityId { /* [XID] */ /* 0x00000001897702F0-0x0000000189770310 */ get => default; /* [XID] */ /* 0x00000001897779D0-0x00000001897779F0 */ protected set {} } // 0x00000001850D60B0-0x00000001850D6180 0x00000001850D5340-0x00000001850D5420
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x000000018977F0C0-0x000000018977F0E0 */ get => default; /* [XID] */ /* 0x0000000189786AA0-0x0000000189786AC0 */ protected set {} } // 0x00000001850D5E60-0x00000001850D5F00 0x00000001850D4190-0x00000001850D4240
	public string desc { /* [XID] */ /* 0x000000018978E190-0x000000018978E1B0 */ get => default; } // 0x00000001850D5130-0x00000001850D52B0 
	public QuestGuide guide { /* [XID] */ /* 0x0000000189795840-0x0000000189795860 */ get => default; /* [XID] */ /* 0x000000018979DCD0-0x000000018979DCF0 */ protected set {} } // 0x00000001850D6280-0x00000001850D6320 0x00000001850D5DB0-0x00000001850D5E60

	// Constructors
	public BattlePassMissionExcelConfig() {} // 0x00000001850D63C0-0x00000001850D6420

	// Methods
	// [IDTag] // 0x00000001897A5010-0x00000001897A5050
	// [XID] // 0x00000001897A5010-0x00000001897A5050
	public virtual bool ParseFromLine(string line) => default; // 0x00000001850D4950-0x00000001850D4FE0
	// [IDTag] // 0x00000001897AF670-0x00000001897AF6B0
	// [XID] // 0x00000001897AF670-0x00000001897AF6B0
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001850D4350-0x00000001850D4950
	// [XID] // 0x00000001897B9F90-0x00000001897B9FB0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0546 */, bool useObjectPool = false /* Metadata: 0x00AF054A */) => default; // 0x00000001850D5480-0x00000001850D5DB0
	[BlackList] // 0x00000001897C20F0-0x00000001897C2130
	// [XID] // 0x00000001897C20F0-0x00000001897C2130
	public override void AutoAllocTypeFields() {} // 0x00000001850D3E60-0x00000001850D3F00
	[BlackList] // 0x00000001897CC810-0x00000001897CC850
	// [XID] // 0x00000001897CC810-0x00000001897CC850
	public override void AutoRecycleTypeFields() {} // 0x00000001850D3F00-0x00000001850D4010
	[BlackList] // 0x00000001897D71A0-0x00000001897D71E0
	// [XID] // 0x00000001897D71A0-0x00000001897D71E0
	public override void ReturnToObjectPool() {} // 0x00000001850D6320-0x00000001850D63C0
}

