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
public class ConfigCoopSelectNode : ConfigCoopBaseNode, IAutoAllocRecycle // TypeDefIndex: 17754
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private CoopSelectNodeContent[] _selectList; // 0x20

	// Properties
	public CoopSelectNodeContent[] selectList { /* [XID] */ /* 0x00000001896B3390-0x00000001896B33B0 */ get => default; /* [XID] */ /* 0x00000001896BAB90-0x00000001896BABB0 */ private set {} } // 0x00000001817AE2C0-0x00000001817AE360 0x00000001817AEDC0-0x00000001817AEE70

	// Constructors
	public ConfigCoopSelectNode() {} // 0x00000001817AFCB0-0x00000001817AFD10

	// Methods
	// [XID] // 0x00000001896C1B60-0x00000001896C1B80
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001817AFB20-0x00000001817AFC10
	// [XID] // 0x00000001896C91F0-0x00000001896C9210
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001817AF800-0x00000001817AF8E0
	// [XID] // 0x00000001896D0B40-0x00000001896D0B60
	public override ConfigCoopBaseNode Clone(bool useObjectPool = false /* Metadata: 0x00AF7AFF */) => default; // 0x00000001817AF410-0x00000001817AF4F0
	// [XID] // 0x00000001896D8090-0x00000001896D80B0
	public override int GetHashNum() => default; // 0x00000001817AE1F0-0x00000001817AE2C0
	// [XID] // 0x00000001896DFA00-0x00000001896DFA20
	public override void InitEmpty() {} // 0x00000001817AEE70-0x00000001817AEF40
	[BlackList] // 0x00000001896E6DA0-0x00000001896E6DE0
	// [XID] // 0x00000001896E6DA0-0x00000001896E6DE0
	public override bool FromJson(JSONNode node) => default; // 0x00000001817AE7B0-0x00000001817AEB30
	// [XID] // 0x00000001896F0F00-0x00000001896F0F20
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001817ADA80-0x00000001817ADCB0
	[BlackList] // 0x00000001896F8780-0x00000001896F87C0
	// [XID] // 0x00000001896F8780-0x00000001896F87C0
	public static new ConfigCoopSelectNode ParseFromJson(JSONNode node) => default; // 0x00000001817AF550-0x00000001817AF7A0
	// [XID] // 0x0000000189703130-0x0000000189703150
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B00 */, bool useObjectPool = false /* Metadata: 0x00AF7B04 */) => default; // 0x00000001817AF110-0x00000001817AF410
	// [XID] // 0x000000018970A800-0x000000018970A820
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B05 */, bool useObjectPool = false /* Metadata: 0x00AF7B09 */) => default; // 0x00000001817AE440-0x00000001817AE6B0
	// [XID] // 0x0000000189712350-0x0000000189712370
	public static new ConfigCoopSelectNode ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B0A */, bool useObjectPool = false /* Metadata: 0x00AF7B0E */) => default; // 0x00000001817AEB30-0x00000001817AED50
	[BlackList] // 0x0000000189719970-0x00000001897199B0
	// [XID] // 0x0000000189719970-0x00000001897199B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001817ADCB0-0x00000001817ADF80
	// [XID] // 0x0000000189723BB0-0x0000000189723BD0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001817AF8E0-0x00000001817AFB20
	[BlackList] // 0x000000018972B270-0x000000018972B2B0
	// [XID] // 0x000000018972B270-0x000000018972B2B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001817AF020-0x00000001817AF110
	[BlackList] // 0x0000000189735AA0-0x0000000189735AE0
	// [XID] // 0x0000000189735AA0-0x0000000189735AE0
	public override void AutoAllocTypeFields() {} // 0x00000001817ADF80-0x00000001817AE020
	[BlackList] // 0x0000000189740980-0x00000001897409C0
	// [XID] // 0x0000000189740980-0x00000001897409C0
	public override void AutoRecycleTypeFields() {} // 0x00000001817AE020-0x00000001817AE0D0
	[BlackList] // 0x000000018974B0E0-0x000000018974B120
	// [XID] // 0x000000018974B0E0-0x000000018974B120
	public override void ReturnToObjectPool() {} // 0x00000001817AFC10-0x00000001817AFCB0
}

