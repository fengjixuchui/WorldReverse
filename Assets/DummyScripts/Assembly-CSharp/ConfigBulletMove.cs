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
public class ConfigBulletMove : ConfigMove, IAutoAllocRecycle // TypeDefIndex: 18606
{
	// Fields
	private SimpleSafeFloat speedRawNum; // 0x18
	private SimpleSafeFloat maxSpeedRawNum; // 0x1C
	private SimpleSafeFloat minSpeedRawNum; // 0x20
	private SimpleSafeFloat anglerVelocityRawNum; // 0x24
	private SimpleSafeFloat accelerationRawNum; // 0x28
	private SimpleSafeFloat accelerationTimeRawNum; // 0x2C
	private bool _canBornInWater; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBulletMoveAngle _updateAngle; // 0x38
	private SimpleSafeFloat delayRawNum; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMoveStickToGround _stickToGround; // 0x48
	private bool _syncToRemote; // 0x50

	// Properties
	public float speed { /* [XID] */ /* 0x0000000189A61C30-0x0000000189A61C50 */ get => default; /* [XID] */ /* 0x0000000189A69B50-0x0000000189A69B70 */ private set {} } // 0x000000018438CDA0-0x000000018438CE80 0x000000018438BF10-0x000000018438BFF0
	public float maxSpeed { /* [XID] */ /* 0x0000000189A70EC0-0x0000000189A70EE0 */ get => default; /* [XID] */ /* 0x0000000189A78A00-0x0000000189A78A20 */ private set {} } // 0x000000018438B700-0x000000018438B7E0 0x000000018438CF60-0x000000018438D040
	public float minSpeed { /* [XID] */ /* 0x0000000189A7FDC0-0x0000000189A7FDE0 */ get => default; /* [XID] */ /* 0x0000000189A87B40-0x0000000189A87B60 */ private set {} } // 0x000000018438CBC0-0x000000018438CCA0 0x000000018438CE80-0x000000018438CF60
	public float anglerVelocity { /* [XID] */ /* 0x00000001897FA470-0x00000001897FA490 */ get => default; /* [XID] */ /* 0x0000000189A96860-0x0000000189A96880 */ private set {} } // 0x000000018438B7E0-0x000000018438B8C0 0x000000018438BC40-0x000000018438BD20
	public float acceleration { /* [XID] */ /* 0x0000000189810770-0x0000000189810790 */ get => default; /* [XID] */ /* 0x0000000189AA5820-0x0000000189AA5840 */ private set {} } // 0x000000018438BE30-0x000000018438BF10 0x000000018438A860-0x000000018438A940
	public float accelerationTime { /* [XID] */ /* 0x00000001898019F0-0x0000000189801A10 */ get => default; /* [XID] */ /* 0x0000000189AB4790-0x0000000189AB47B0 */ private set {} } // 0x00000001843890A0-0x0000000184389180 0x000000018438A780-0x000000018438A860
	public bool canBornInWater { /* [XID] */ /* 0x0000000189ABC540-0x0000000189ABC560 */ get => default; /* [XID] */ /* 0x0000000189AC3E80-0x0000000189AC3EA0 */ private set {} } // 0x000000018438BD20-0x000000018438BDC0 0x000000018438BB90-0x000000018438BC40
	public ConfigBulletMoveAngle updateAngle { /* [XID] */ /* 0x0000000189847580-0x00000001898475A0 */ get => default; /* [XID] */ /* 0x0000000189AD2D80-0x0000000189AD2DA0 */ private set {} } // 0x000000018438A500-0x000000018438A5A0 0x000000018438B8C0-0x000000018438B970
	public float delay { /* [XID] */ /* 0x0000000189ADA7E0-0x0000000189ADA800 */ get => default; /* [XID] */ /* 0x0000000189AE2000-0x0000000189AE2020 */ private set {} } // 0x0000000184389180-0x0000000184389260 0x000000018438C7D0-0x000000018438C8B0
	public ConfigMoveStickToGround stickToGround { /* [XID] */ /* 0x0000000189AE9870-0x0000000189AE9890 */ get => default; /* [XID] */ /* 0x0000000189AF1610-0x0000000189AF1630 */ private set {} } // 0x0000000184389000-0x00000001843890A0 0x000000018438A670-0x000000018438A720
	public bool syncToRemote { /* [XID] */ /* 0x0000000189AF8CB0-0x0000000189AF8CD0 */ get => default; /* [XID] */ /* 0x0000000189B00210-0x0000000189B00230 */ private set {} } // 0x000000018438C730-0x000000018438C7D0 0x000000018438B250-0x000000018438B300

	// Constructors
	public ConfigBulletMove() {} // 0x000000018438DAD0-0x000000018438DBB0

	// Methods
	// [XID] // 0x0000000189B07790-0x0000000189B077B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018438D800-0x000000018438DA30
	// [XID] // 0x0000000189B0EFF0-0x0000000189B0F010
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018438CCA0-0x000000018438CDA0
	// [XID] // 0x0000000189B162D0-0x0000000189B162F0
	public override ConfigMove Clone(bool useObjectPool = false /* Metadata: 0x00AFA595 */) => default; // 0x000000018438C650-0x000000018438C730
	// [XID] // 0x0000000189B1D9F0-0x0000000189B1DA10
	public override int GetHashNum() => default; // 0x000000018438A5A0-0x000000018438A670
	// [XID] // 0x0000000189B25300-0x0000000189B25320
	public override void InitEmpty() {} // 0x000000018438BFF0-0x000000018438C180
	[BlackList] // 0x0000000189B2C7B0-0x0000000189B2C7F0
	// [XID] // 0x0000000189B2C7B0-0x0000000189B2C7F0
	public override bool FromJson(JSONNode node) => default; // 0x000000018438B380-0x000000018438B700
	// [XID] // 0x0000000189B36D70-0x0000000189B36D90
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184389260-0x0000000184389E10
	[BlackList] // 0x0000000189B3E5E0-0x0000000189B3E620
	// [XID] // 0x0000000189B3E5E0-0x0000000189B3E620
	public static new ConfigBulletMove ParseFromJson(JSONNode node) => default; // 0x000000018438C910-0x000000018438CB60
	// [XID] // 0x0000000189B491E0-0x0000000189B49200
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA596 */, bool useObjectPool = false /* Metadata: 0x00AFA59A */) => default; // 0x000000018438C350-0x000000018438C650
	// [XID] // 0x0000000189B50860-0x0000000189B50880
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA59B */, bool useObjectPool = false /* Metadata: 0x00AFA59F */) => default; // 0x000000018438A9C0-0x000000018438B1D0
	// [XID] // 0x0000000189B581A0-0x0000000189B581C0
	public static new ConfigBulletMove ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA5A0 */, bool useObjectPool = false /* Metadata: 0x00AFA5A4 */) => default; // 0x000000018438B970-0x000000018438BB90
	[BlackList] // 0x0000000189B5FAC0-0x0000000189B5FB00
	// [XID] // 0x0000000189B5FAC0-0x0000000189B5FB00
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184389E10-0x000000018438A0E0
	// [XID] // 0x0000000189B6A090-0x0000000189B6A0B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018438D040-0x000000018438D800
	[BlackList] // 0x0000000189B71710-0x0000000189B71750
	// [XID] // 0x0000000189B71710-0x0000000189B71750
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018438C260-0x000000018438C350
	[BlackList] // 0x0000000189B7B9B0-0x0000000189B7B9F0
	// [XID] // 0x0000000189B7B9B0-0x0000000189B7B9F0
	public override void AutoAllocTypeFields() {} // 0x000000018438A0E0-0x000000018438A180
	[BlackList] // 0x0000000189B864A0-0x0000000189B864E0
	// [XID] // 0x0000000189B864A0-0x0000000189B864E0
	public override void AutoRecycleTypeFields() {} // 0x000000018438A180-0x000000018438A3E0
	[BlackList] // 0x0000000189B90710-0x0000000189B90750
	// [XID] // 0x0000000189B90710-0x0000000189B90750
	public override void ReturnToObjectPool() {} // 0x000000018438DA30-0x000000018438DAD0
}

