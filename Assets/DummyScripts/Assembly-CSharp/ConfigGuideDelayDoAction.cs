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
public class ConfigGuideDelayDoAction : ConfigGuideAction, IAutoAllocRecycle // TypeDefIndex: 18327
{
	// Fields
	private SimpleSafeFloat delayTimeRawNum; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigGuideAction[] _actions; // 0x20

	// Properties
	public float delayTime { /* [XID] */ /* 0x0000000189732A20-0x0000000189732A40 */ get => default; /* [XID] */ /* 0x000000018973A170-0x000000018973A190 */ private set {} } // 0x00000001849F2690-0x00000001849F2770 0x00000001849F2770-0x00000001849F2850
	public ConfigGuideAction[] actions { /* [XID] */ /* 0x0000000189741D00-0x0000000189741D20 */ get => default; /* [XID] */ /* 0x0000000189749620-0x0000000189749640 */ private set {} } // 0x00000001849F4040-0x00000001849F40E0 0x00000001849F23F0-0x00000001849F24A0

	// Constructors
	public ConfigGuideDelayDoAction() {} // 0x00000001849F45D0-0x00000001849F4630

	// Methods
	// [XID] // 0x0000000189750B20-0x0000000189750B40
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001849F4420-0x00000001849F4530
	// [XID] // 0x0000000189757EF0-0x0000000189757F10
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001849F3F60-0x00000001849F4040
	// [XID] // 0x000000018975FA90-0x000000018975FAB0
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF944B */) => default; // 0x00000001849F3B70-0x00000001849F3C50
	// [XID] // 0x0000000189767000-0x0000000189767020
	public override int GetHashNum() => default; // 0x00000001849F25C0-0x00000001849F2690
	// [XID] // 0x000000018976E560-0x000000018976E580
	public override void InitEmpty() {} // 0x00000001849F3520-0x00000001849F3630
	[BlackList] // 0x0000000189775F00-0x0000000189775F40
	// [XID] // 0x0000000189775F00-0x0000000189775F40
	public override bool FromJson(JSONNode node) => default; // 0x00000001849F2F10-0x00000001849F3290
	// [XID] // 0x0000000189780580-0x00000001897805A0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001849F1C30-0x00000001849F1F90
	[BlackList] // 0x0000000189787D20-0x0000000189787D60
	// [XID] // 0x0000000189787D20-0x0000000189787D60
	public static new ConfigGuideDelayDoAction ParseFromJson(JSONNode node) => default; // 0x00000001849F3CB0-0x00000001849F3F00
	// [XID] // 0x0000000189792360-0x0000000189792380
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF944C */, bool useObjectPool = false /* Metadata: 0x00AF9450 */) => default; // 0x00000001849F3870-0x00000001849F3B70
	// [XID] // 0x00000001897998F0-0x0000000189799910
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9451 */, bool useObjectPool = false /* Metadata: 0x00AF9455 */) => default; // 0x00000001849F2B00-0x00000001849F2E10
	// [XID] // 0x00000001897A1780-0x00000001897A17A0
	public static new ConfigGuideDelayDoAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9456 */, bool useObjectPool = false /* Metadata: 0x00AF945A */) => default; // 0x00000001849F3290-0x00000001849F34B0
	[BlackList] // 0x00000001897A8FC0-0x00000001897A9000
	// [XID] // 0x00000001897A8FC0-0x00000001897A9000
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001849F1F90-0x00000001849F2260
	// [XID] // 0x00000001897B3E30-0x00000001897B3E50
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001849F4160-0x00000001849F4420
	[BlackList] // 0x00000001897BBB90-0x00000001897BBBD0
	// [XID] // 0x00000001897BBB90-0x00000001897BBBD0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001849F3780-0x00000001849F3870
	// [XID] // 0x00000001897C64C0-0x00000001897C64E0
	protected override bool Start(ConfigGuideTask taskBelonged) => default; // 0x00000001849F2930-0x00000001849F2B00
	// [XID] // 0x00000001897CDCC0-0x00000001897CDCE0
	protected override bool Stop() => default; // 0x00000001849F1B90-0x00000001849F1C30
	[BlackList] // 0x00000001897D5150-0x00000001897D5190
	// [XID] // 0x00000001897D5150-0x00000001897D5190
	public override void AutoAllocTypeFields() {} // 0x00000001849F2260-0x00000001849F2300
	[BlackList] // 0x00000001897DFA10-0x00000001897DFA50
	// [XID] // 0x00000001897DFA10-0x00000001897DFA50
	public override void AutoRecycleTypeFields() {} // 0x00000001849F2300-0x00000001849F23F0
	[BlackList] // 0x00000001897EA3C0-0x00000001897EA400
	// [XID] // 0x00000001897EA3C0-0x00000001897EA400
	public override void ReturnToObjectPool() {} // 0x00000001849F4530-0x00000001849F45D0
}

