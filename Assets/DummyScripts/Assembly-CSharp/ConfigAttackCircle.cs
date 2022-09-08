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
public class ConfigAttackCircle : ConfigSimpleAttackPattern, IAutoAllocRecycle // TypeDefIndex: 17542
{
	// Fields
	private SimpleSafeFloat heightRawNum; // 0x40
	private SimpleSafeFloat fanAngleRawNum; // 0x44
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _radius; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _innerRadius; // 0x50
	private CircleDetectDirection _detectDirection; // 0x58

	// Properties
	public float height { /* [XID] */ /* 0x0000000189AA8420-0x0000000189AA8440 */ get => default; /* [XID] */ /* 0x0000000189AB0160-0x0000000189AB0180 */ private set {} } // 0x00000001846BCC10-0x00000001846BCCF0 0x00000001846BC340-0x00000001846BC420
	public float fanAngle { /* [XID] */ /* 0x00000001895FA3C0-0x00000001895FA3E0 */ get => default; /* [XID] */ /* 0x0000000189ABF2F0-0x0000000189ABF310 */ private set {} } // 0x00000001846BB210-0x00000001846BB2F0 0x00000001846BCB30-0x00000001846BCC10
	public DynamicFloat radius { /* [XID] */ /* 0x0000000189AC6D80-0x0000000189AC6DA0 */ get => default; /* [XID] */ /* 0x0000000189ACE510-0x0000000189ACE530 */ private set {} } // 0x00000001846BC630-0x00000001846BC6D0 0x00000001846BCF30-0x00000001846BCFE0
	public DynamicFloat innerRadius { /* [XID] */ /* 0x0000000189AD63C0-0x0000000189AD63E0 */ get => default; /* [XID] */ /* 0x0000000189ADDC60-0x0000000189ADDC80 */ private set {} } // 0x00000001846BBC10-0x00000001846BBCB0 0x00000001846BCCF0-0x00000001846BCDA0
	public CircleDetectDirection detectDirection { /* [XID] */ /* 0x0000000189AE5600-0x0000000189AE5620 */ get => default; /* [XID] */ /* 0x0000000189AECB20-0x0000000189AECB40 */ private set {} } // 0x00000001846BA340-0x00000001846BA3E0 0x00000001846BC580-0x00000001846BC630

	// Constructors
	public ConfigAttackCircle() {} // 0x00000001846BD080-0x00000001846BD120

	// Methods
	// [XID] // 0x0000000189AF4570-0x0000000189AF4590
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001846BCDA0-0x00000001846BCF30
	// [XID] // 0x0000000189AFBBC0-0x0000000189AFBBE0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001846BC480-0x00000001846BC580
	// [XID] // 0x0000000189B03350-0x0000000189B03370
	public override ConfigBaseAttackPattern Clone(bool useObjectPool = false /* Metadata: 0x00AF7249 */) => default; // 0x00000001846BBFB0-0x00000001846BC090
	// [XID] // 0x0000000189B0AB20-0x0000000189B0AB40
	public override int GetHashNum() => default; // 0x00000001846BAA60-0x00000001846BAB30
	// [XID] // 0x0000000189B12240-0x0000000189B12260
	public override void InitEmpty() {} // 0x00000001846BB900-0x00000001846BBA40
	[BlackList] // 0x0000000189B19530-0x0000000189B19570
	// [XID] // 0x0000000189B19530-0x0000000189B19570
	public override bool FromJson(JSONNode node) => default; // 0x00000001846BB2F0-0x00000001846BB670
	// [XID] // 0x0000000189B23EA0-0x0000000189B23EC0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001846B9D00-0x00000001846BA340
	[BlackList] // 0x0000000189B2B1A0-0x0000000189B2B1E0
	// [XID] // 0x0000000189B2B1A0-0x0000000189B2B1E0
	public static new ConfigAttackCircle ParseFromJson(JSONNode node) => default; // 0x00000001846BC0F0-0x00000001846BC340
	// [XID] // 0x0000000189B354C0-0x0000000189B354E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF724A */, bool useObjectPool = false /* Metadata: 0x00AF724E */) => default; // 0x00000001846BBCB0-0x00000001846BBFB0
	// [XID] // 0x0000000189B3CD80-0x0000000189B3CDA0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF724F */, bool useObjectPool = false /* Metadata: 0x00AF7253 */) => default; // 0x00000001846BAC10-0x00000001846BB110
	// [XID] // 0x0000000189B44A50-0x0000000189B44A70
	public static new ConfigAttackCircle ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7254 */, bool useObjectPool = false /* Metadata: 0x00AF7258 */) => default; // 0x00000001846BB670-0x00000001846BB890
	[BlackList] // 0x0000000189B4C2A0-0x0000000189B4C2E0
	// [XID] // 0x0000000189B4C2A0-0x0000000189B4C2E0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001846BA3E0-0x00000001846BA6B0
	// [XID] // 0x0000000189B56B90-0x0000000189B56BB0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001846BC6D0-0x00000001846BCB30
	[BlackList] // 0x0000000189B5E420-0x0000000189B5E460
	// [XID] // 0x0000000189B5E420-0x0000000189B5E460
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001846BBB20-0x00000001846BBC10
	[BlackList] // 0x0000000189B689E0-0x0000000189B68A20
	// [XID] // 0x0000000189B689E0-0x0000000189B68A20
	public override void AutoAllocTypeFields() {} // 0x00000001846BA6B0-0x00000001846BA750
	[BlackList] // 0x0000000189B72EF0-0x0000000189B72F30
	// [XID] // 0x0000000189B72EF0-0x0000000189B72F30
	public override void AutoRecycleTypeFields() {} // 0x00000001846BA750-0x00000001846BA940
	[BlackList] // 0x0000000189B7D280-0x0000000189B7D2C0
	// [XID] // 0x0000000189B7D280-0x0000000189B7D2C0
	public override void ReturnToObjectPool() {} // 0x00000001846BCFE0-0x00000001846BD080
}

