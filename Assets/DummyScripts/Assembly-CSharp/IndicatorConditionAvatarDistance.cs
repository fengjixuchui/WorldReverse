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
public class IndicatorConditionAvatarDistance : IndicatorCondition, IAutoAllocRecycle // TypeDefIndex: 18485
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private TemplateParamFloat _distance; // 0x10

	// Properties
	public TemplateParamFloat distance { /* [XID] */ /* 0x0000000189AE98B0-0x0000000189AE98D0 */ get => default; /* [XID] */ /* 0x0000000189AF1670-0x0000000189AF1690 */ private set {} } // 0x00000001816B41A0-0x00000001816B4240 0x00000001816B5EF0-0x00000001816B5FA0
	public override bool TimeCheck { /* [XID] */ /* 0x0000000189B6CC20-0x0000000189B6CC40 */ get => default; } // 0x00000001816B4B80-0x00000001816B4C20 

	// Constructors
	public IndicatorConditionAvatarDistance() {} // 0x00000001816B6B20-0x00000001816B6B80

	// Methods
	// [XID] // 0x0000000189AF8CD0-0x0000000189AF8CF0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001816B6670-0x00000001816B6750
	// [XID] // 0x0000000189B00230-0x0000000189B00250
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001816B6250-0x00000001816B6330
	// [XID] // 0x0000000189B077B0-0x0000000189B077D0
	public override IndicatorCondition Clone(bool useObjectPool = false /* Metadata: 0x00AF9EFD */) => default; // 0x00000001816B5D20-0x00000001816B5E00
	// [XID] // 0x0000000189B0F070-0x0000000189B0F090
	public override int GetHashNum() => default; // 0x00000001816B4A50-0x00000001816B4B20
	// [XID] // 0x0000000189B16350-0x0000000189B16370
	public override void InitEmpty() {} // 0x00000001816B5650-0x00000001816B5720
	[BlackList] // 0x0000000189B1DA90-0x0000000189B1DAD0
	// [XID] // 0x0000000189B1DA90-0x0000000189B1DAD0
	public override bool FromJson(JSONNode node) => default; // 0x00000001816B5040-0x00000001816B53C0
	// [XID] // 0x0000000189B28130-0x0000000189B28150
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001816B4240-0x00000001816B4490
	[BlackList] // 0x0000000189B2F4B0-0x0000000189B2F4F0
	// [XID] // 0x0000000189B2F4B0-0x0000000189B2F4F0
	public static new IndicatorConditionAvatarDistance ParseFromJson(JSONNode node) => default; // 0x00000001816B5FA0-0x00000001816B61F0
	// [XID] // 0x0000000189B39ED0-0x0000000189B39EF0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9EFE */, bool useObjectPool = false /* Metadata: 0x00AF9F02 */) => default; // 0x00000001816B5A20-0x00000001816B5D20
	// [XID] // 0x0000000189B41850-0x0000000189B41870
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F03 */, bool useObjectPool = false /* Metadata: 0x00AF9F07 */) => default; // 0x00000001816B4CA0-0x00000001816B4F40
	// [XID] // 0x0000000189B49240-0x0000000189B49260
	public static new IndicatorConditionAvatarDistance ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F08 */, bool useObjectPool = false /* Metadata: 0x00AF9F0C */) => default; // 0x00000001816B53C0-0x00000001816B55E0
	[BlackList] // 0x0000000189B50880-0x0000000189B508C0
	// [XID] // 0x0000000189B50880-0x0000000189B508C0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001816B4490-0x00000001816B4760
	// [XID] // 0x0000000189B5AF50-0x0000000189B5AF70
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001816B6330-0x00000001816B6560
	[BlackList] // 0x0000000189B623D0-0x0000000189B62410
	// [XID] // 0x0000000189B623D0-0x0000000189B62410
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001816B58C0-0x00000001816B59B0
	// [XID] // 0x0000000189B743D0-0x0000000189B743F0
	public override bool Register(LCIndicatorPlugin plugin, int state, int index, LCIndicatorPlugin.DominatorCondition condition) => default; // 0x00000001816B6560-0x00000001816B6670
	// [XID] // 0x0000000189B7BA30-0x0000000189B7BA50
	public override bool OnTriggered(LCIndicatorPlugin plugin, int state, BaseEvent fromEvent) => default; // 0x00000001816B6750-0x00000001816B6A80
	[BlackList] // 0x0000000189B83320-0x0000000189B83360
	// [XID] // 0x0000000189B83320-0x0000000189B83360
	public override void AutoAllocTypeFields() {} // 0x00000001816B4760-0x00000001816B4800
	[BlackList] // 0x0000000189B8D570-0x0000000189B8D5B0
	// [XID] // 0x0000000189B8D570-0x0000000189B8D5B0
	public override void AutoRecycleTypeFields() {} // 0x00000001816B4800-0x00000001816B4930
	[BlackList] // 0x0000000189B97B60-0x0000000189B97BA0
	// [XID] // 0x0000000189B97B60-0x0000000189B97BA0
	public override void ReturnToObjectPool() {} // 0x00000001816B6A80-0x00000001816B6B20
}

