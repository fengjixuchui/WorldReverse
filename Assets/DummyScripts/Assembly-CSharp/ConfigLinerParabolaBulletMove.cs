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
public class ConfigLinerParabolaBulletMove : ConfigLinerBulletMove, IAutoAllocRecycle // TypeDefIndex: 18622
{
	// Fields
	private SimpleSafeFloat straightRangeRawNum; // 0x58
	private SimpleSafeFloat gravityOfAccelerationRawNum; // 0x5C
	private SimpleSafeFloat airResistanceRawNum; // 0x60

	// Properties
	public float straightRange { /* [XID] */ /* 0x0000000189733470-0x0000000189733490 */ get => default; /* [XID] */ /* 0x0000000189B13610-0x0000000189B13630 */ private set {} } // 0x00000001844E1C00-0x00000001844E1CE0 0x00000001844E0460-0x00000001844E0540
	public float gravityOfAcceleration { /* [XID] */ /* 0x000000018972BE00-0x000000018972BE20 */ get => default; /* [XID] */ /* 0x0000000189B222B0-0x0000000189B222D0 */ private set {} } // 0x00000001844E1130-0x00000001844E1210 0x00000001844E09F0-0x00000001844E0AD0
	public float airResistance { /* [XID] */ /* 0x0000000189724650-0x0000000189724670 */ get => default; /* [XID] */ /* 0x0000000189B30E90-0x0000000189B30EB0 */ private set {} } // 0x00000001844E1F00-0x00000001844E1FE0 0x00000001844E1720-0x00000001844E1800

	// Constructors
	public ConfigLinerParabolaBulletMove() {} // 0x00000001844E2FA0-0x00000001844E3000

	// Methods
	// [XID] // 0x0000000189B38570-0x0000000189B38590
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001844E2DD0-0x00000001844E2F00
	// [XID] // 0x0000000189B3FFC0-0x0000000189B3FFE0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001844E2A00-0x00000001844E2AB0
	// [XID] // 0x0000000189B477C0-0x0000000189B477E0
	public override ConfigMove Clone(bool useObjectPool = false /* Metadata: 0x00AFA615 */) => default; // 0x00000001844E2610-0x00000001844E26F0
	// [XID] // 0x0000000189B4EF10-0x0000000189B4EF30
	public override int GetHashNum() => default; // 0x00000001844E1060-0x00000001844E1130
	// [XID] // 0x0000000189B56910-0x0000000189B56930
	public override void InitEmpty() {} // 0x00000001844E2050-0x00000001844E2140
	[BlackList] // 0x0000000189B5E0E0-0x0000000189B5E120
	// [XID] // 0x0000000189B5E0E0-0x0000000189B5E120
	public override bool FromJson(JSONNode node) => default; // 0x00000001844E1880-0x00000001844E1C00
	// [XID] // 0x0000000189B687C0-0x0000000189B687E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001844E0540-0x00000001844E09F0
	[BlackList] // 0x0000000189B6FCA0-0x0000000189B6FCE0
	// [XID] // 0x0000000189B6FCA0-0x0000000189B6FCE0
	public static new ConfigLinerParabolaBulletMove ParseFromJson(JSONNode node) => default; // 0x00000001844E2750-0x00000001844E29A0
	// [XID] // 0x0000000189B7A270-0x0000000189B7A290
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA616 */, bool useObjectPool = false /* Metadata: 0x00AFA61A */) => default; // 0x00000001844E2310-0x00000001844E2610
	// [XID] // 0x0000000189B819D0-0x0000000189B819F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA61B */, bool useObjectPool = false /* Metadata: 0x00AFA61F */) => default; // 0x00000001844E12F0-0x00000001844E16A0
	// [XID] // 0x0000000189B890F0-0x0000000189B89110
	public static new ConfigLinerParabolaBulletMove ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA620 */, bool useObjectPool = false /* Metadata: 0x00AFA624 */) => default; // 0x00000001844E1CE0-0x00000001844E1F00
	[BlackList] // 0x0000000189B906D0-0x0000000189B90710
	// [XID] // 0x0000000189B906D0-0x0000000189B90710
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001844E0AD0-0x00000001844E0DA0
	// [XID] // 0x0000000189B9AAC0-0x0000000189B9AAE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001844E2AB0-0x00000001844E2DD0
	[BlackList] // 0x0000000189BA2250-0x0000000189BA2290
	// [XID] // 0x0000000189BA2250-0x0000000189BA2290
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001844E2220-0x00000001844E2310
	[BlackList] // 0x0000000189BAC390-0x0000000189BAC3D0
	// [XID] // 0x0000000189BAC390-0x0000000189BAC3D0
	public override void AutoAllocTypeFields() {} // 0x00000001844E0DA0-0x00000001844E0E40
	[BlackList] // 0x0000000189BB69F0-0x0000000189BB6A30
	// [XID] // 0x0000000189BB69F0-0x0000000189BB6A30
	public override void AutoRecycleTypeFields() {} // 0x00000001844E0E40-0x00000001844E0F40
	[BlackList] // 0x0000000189BC1780-0x0000000189BC17C0
	// [XID] // 0x0000000189BC1780-0x0000000189BC17C0
	public override void ReturnToObjectPool() {} // 0x00000001844E2F00-0x00000001844E2FA0
}

