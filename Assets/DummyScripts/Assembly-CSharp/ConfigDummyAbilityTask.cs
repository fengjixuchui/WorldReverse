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
public class ConfigDummyAbilityTask : ConfigAbilityTask, IAutoAllocRecycle // TypeDefIndex: 17376
{
	// Fields
	private SimpleSafeInt32 dummyNumberRawNum; // 0x28

	// Properties
	public int dummyNumber { /* [XID] */ /* 0x0000000189AD7A00-0x0000000189AD7A20 */ get => default; /* [XID] */ /* 0x0000000189ADF490-0x0000000189ADF4B0 */ private set {} } // 0x0000000184C4CA20-0x0000000184C4CAF0 0x0000000184C4BD20-0x0000000184C4BE00

	// Constructors
	public ConfigDummyAbilityTask() {} // 0x0000000184C4D9A0-0x0000000184C4DA00

	// Methods
	// [XID] // 0x0000000189AE6C90-0x0000000189AE6CB0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184C4D760-0x0000000184C4D850
	// [XID] // 0x0000000189AEE7E0-0x0000000189AEE800
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184C4D480-0x0000000184C4D530
	// [XID] // 0x0000000189AF5E10-0x0000000189AF5E30
	public override ConfigAbilityTask Clone(bool useObjectPool = false /* Metadata: 0x00AF6C1F */) => default; // 0x0000000184C4D090-0x0000000184C4D170
	// [XID] // 0x0000000189AFD2D0-0x0000000189AFD2F0
	public override int GetHashNum() => default; // 0x0000000184C4BC50-0x0000000184C4BD20
	// [XID] // 0x0000000189B04AE0-0x0000000189B04B00
	public override void InitEmpty() {} // 0x0000000184C4CAF0-0x0000000184C4CBC0
	[BlackList] // 0x0000000189B0C2B0-0x0000000189B0C2F0
	// [XID] // 0x0000000189B0C2B0-0x0000000189B0C2F0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184C4C330-0x0000000184C4C6B0
	// [XID] // 0x0000000189B16570-0x0000000189B16590
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184C4B480-0x0000000184C4B6E0
	[BlackList] // 0x0000000189B1DCB0-0x0000000189B1DCF0
	// [XID] // 0x0000000189B1DCB0-0x0000000189B1DCF0
	public static new ConfigDummyAbilityTask ParseFromJson(JSONNode node) => default; // 0x0000000184C4D1D0-0x0000000184C4D420
	// [XID] // 0x0000000189B28390-0x0000000189B283B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6C20 */, bool useObjectPool = false /* Metadata: 0x00AF6C24 */) => default; // 0x0000000184C4CD90-0x0000000184C4D090
	// [XID] // 0x0000000189B2F6F0-0x0000000189B2F710
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6C25 */, bool useObjectPool = false /* Metadata: 0x00AF6C29 */) => default; // 0x0000000184C4BEE0-0x0000000184C4C150
	// [XID] // 0x0000000189B36F90-0x0000000189B36FB0
	public static new ConfigDummyAbilityTask ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6C2A */, bool useObjectPool = false /* Metadata: 0x00AF6C2E */) => default; // 0x0000000184C4C6B0-0x0000000184C4C8D0
	[BlackList] // 0x0000000189B3E860-0x0000000189B3E8A0
	// [XID] // 0x0000000189B3E860-0x0000000189B3E8A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184C4B6E0-0x0000000184C4B9B0
	// [XID] // 0x0000000189B494E0-0x0000000189B49500
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184C4D530-0x0000000184C4D760
	[BlackList] // 0x0000000189B50B20-0x0000000189B50B60
	// [XID] // 0x0000000189B50B20-0x0000000189B50B60
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184C4CCA0-0x0000000184C4CD90
	[BlackList] // 0x0000000189B5B1F0-0x0000000189B5B230
	// [XID] // 0x0000000189B5B1F0-0x0000000189B5B230
	public override void AutoAllocTypeFields() {} // 0x0000000184C4B9B0-0x0000000184C4BA50
	[BlackList] // 0x0000000189B65960-0x0000000189B659A0
	// [XID] // 0x0000000189B65960-0x0000000189B659A0
	public override void AutoRecycleTypeFields() {} // 0x0000000184C4BA50-0x0000000184C4BB30
	[BlackList] // 0x0000000189B70020-0x0000000189B70060
	// [XID] // 0x0000000189B70020-0x0000000189B70060
	public override void ReturnToObjectPool() {} // 0x0000000184C4D900-0x0000000184C4D9A0
	// [XID] // 0x0000000189B7A550-0x0000000189B7A570
	public override AbilityTask CreateTaskFromConfig() => default; // 0x0000000184C4D850-0x0000000184C4D900
	// [XID] // 0x0000000189B81CD0-0x0000000189B81CF0
	public override AbilityTaskBlackboard CreateTaskBlackboardFromConfig() => default; // 0x0000000184C4C250-0x0000000184C4C330
}

