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
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigGuideDungeonIdCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18288
{
	// Fields
	private SimpleSafeUInt32 dungeonIdRawNum; // 0x20
	private SimpleSafeUInt32[] _dungeonIdList; // 0x28
	private bool _isDungeon; // 0x30

	// Properties
	public uint dungeonId { /* [XID] */ /* 0x0000000189B56990-0x0000000189B569B0 */ get => default; /* [XID] */ /* 0x0000000189B5E1C0-0x0000000189B5E1E0 */ private set {} } // 0x000000018497A300-0x000000018497A3D0 0x000000018497AD20-0x000000018497AE00
	public SimpleSafeUInt32[] dungeonIdList { /* [XID] */ /* 0x0000000189B65700-0x0000000189B65720 */ get => default; /* [XID] */ /* 0x0000000189B6CC80-0x0000000189B6CCA0 */ private set {} } // 0x000000018497AC80-0x000000018497AD20 0x0000000184978D50-0x0000000184978E00
	public bool isDungeon { /* [XID] */ /* 0x0000000189B74450-0x0000000189B74470 */ get => default; /* [XID] */ /* 0x0000000189B7BAB0-0x0000000189B7BAD0 */ private set {} } // 0x0000000184978CB0-0x0000000184978D50 0x0000000184979970-0x0000000184979A20

	// Constructors
	public ConfigGuideDungeonIdCondition() {} // 0x000000018497AEA0-0x000000018497AF10

	// Methods
	// [XID] // 0x0000000189B83380-0x0000000189B833A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018497AB50-0x000000018497AC80
	// [XID] // 0x0000000189B8A7F0-0x0000000189B8A810
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018497A680-0x000000018497A760
	// [XID] // 0x0000000189B91E00-0x0000000189B91E20
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF92EF */) => default; // 0x000000018497A1C0-0x000000018497A2A0
	// [XID] // 0x0000000189B992E0-0x0000000189B99300
	public override int GetHashNum() => default; // 0x0000000184978BE0-0x0000000184978CB0
	// [XID] // 0x0000000189BA07B0-0x0000000189BA07D0
	public override void InitEmpty() {} // 0x0000000184979BE0-0x0000000184979CF0
	[BlackList] // 0x0000000189BA7ED0-0x0000000189BA7F10
	// [XID] // 0x0000000189BA7ED0-0x0000000189BA7F10
	public override bool FromJson(JSONNode node) => default; // 0x0000000184979360-0x00000001849796E0
	// [XID] // 0x0000000189BB2450-0x0000000189BB2470
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184978270-0x0000000184978670
	[BlackList] // 0x0000000189BB9840-0x0000000189BB9880
	// [XID] // 0x0000000189BB9840-0x0000000189BB9880
	public static new ConfigGuideDungeonIdCondition ParseFromJson(JSONNode node) => default; // 0x000000018497A3D0-0x000000018497A620
	// [XID] // 0x0000000189BC4620-0x0000000189BC4640
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF92F0 */, bool useObjectPool = false /* Metadata: 0x00AF92F4 */) => default; // 0x0000000184979EC0-0x000000018497A1C0
	// [XID] // 0x0000000189BCBFE0-0x0000000189BCC000
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF92F5 */, bool useObjectPool = false /* Metadata: 0x00AF92F9 */) => default; // 0x0000000184978EE0-0x0000000184979260
	// [XID] // 0x0000000189BD3570-0x0000000189BD3590
	public static new ConfigGuideDungeonIdCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF92FA */, bool useObjectPool = false /* Metadata: 0x00AF92FE */) => default; // 0x00000001849796E0-0x0000000184979900
	[BlackList] // 0x0000000189BDAE20-0x0000000189BDAE60
	// [XID] // 0x0000000189BDAE20-0x0000000189BDAE60
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184978670-0x0000000184978940
	// [XID] // 0x00000001895EAB90-0x00000001895EABB0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018497A7E0-0x000000018497AB50
	[BlackList] // 0x00000001895F2030-0x00000001895F2070
	// [XID] // 0x00000001895F2030-0x00000001895F2070
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184979DD0-0x0000000184979EC0
	// [XID] // 0x00000001895FC850-0x00000001895FC870
	public override bool Ready(object body = null) => default; // 0x0000000184979A20-0x0000000184979BE0
	[BlackList] // 0x00000001896041D0-0x0000000189604210
	// [XID] // 0x00000001896041D0-0x0000000189604210
	public override void AutoAllocTypeFields() {} // 0x0000000184978940-0x00000001849789E0
	[BlackList] // 0x000000018960E960-0x000000018960E9A0
	// [XID] // 0x000000018960E960-0x000000018960E9A0
	public override void AutoRecycleTypeFields() {} // 0x00000001849789E0-0x0000000184978AC0
	[BlackList] // 0x00000001896192E0-0x0000000189619320
	// [XID] // 0x00000001896192E0-0x0000000189619320
	public override void ReturnToObjectPool() {} // 0x000000018497AE00-0x000000018497AEA0
}

