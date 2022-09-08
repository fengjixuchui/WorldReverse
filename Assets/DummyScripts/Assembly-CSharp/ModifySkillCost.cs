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
public class ModifySkillCost : ConfigTalentMixin, IAutoAllocRecycle // TypeDefIndex: 19050
{
	// Fields
	private SimpleSafeUInt32 skillIDRawNum; // 0x10
	private SimpleSafeFloat costDeltaRawNum; // 0x14
	private SimpleSafeFloat costRatioRawNum; // 0x18

	// Properties
	public uint skillID { /* [XID] */ /* 0x00000001897E2A40-0x00000001897E2A60 */ get => default; /* [XID] */ /* 0x00000001897EA200-0x00000001897EA220 */ private set {} } // 0x00000001840A68E0-0x00000001840A69B0 0x00000001840A7920-0x00000001840A7A00
	public float costDelta { /* [XID] */ /* 0x00000001897F1EB0-0x00000001897F1ED0 */ get => default; /* [XID] */ /* 0x00000001897F9760-0x00000001897F9780 */ private set {} } // 0x00000001840A6790-0x00000001840A6870 0x00000001840A6410-0x00000001840A64F0
	public float costRatio { /* [XID] */ /* 0x0000000189800C80-0x0000000189800CA0 */ get => default; /* [XID] */ /* 0x00000001898081C0-0x00000001898081E0 */ private set {} } // 0x00000001840A74F0-0x00000001840A75D0 0x00000001840A5B00-0x00000001840A5BE0

	// Constructors
	public ModifySkillCost() {} // 0x00000001840A7BD0-0x00000001840A7C30

	// Methods
	// [XID] // 0x000000018980FB70-0x000000018980FB90
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001840A7A00-0x00000001840A7B30
	// [XID] // 0x00000001898171C0-0x00000001898171E0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001840A7440-0x00000001840A74F0
	// [XID] // 0x000000018981EB00-0x000000018981EB20
	public override ConfigTalentMixin Clone(bool useObjectPool = false /* Metadata: 0x00AFB8B9 */) => default; // 0x00000001840A7050-0x00000001840A7130
	// [XID] // 0x0000000189826010-0x0000000189826030
	public override int GetHashNum() => default; // 0x00000001840A5950-0x00000001840A5A20
	// [XID] // 0x000000018982D660-0x000000018982D680
	public override void InitEmpty() {} // 0x00000001840A69B0-0x00000001840A6AC0
	[BlackList] // 0x0000000189834DF0-0x0000000189834E30
	// [XID] // 0x0000000189834DF0-0x0000000189834E30
	public override bool FromJson(JSONNode node) => default; // 0x00000001840A6090-0x00000001840A6410
	// [XID] // 0x000000018983F450-0x000000018983F470
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001840A4EF0-0x00000001840A53A0
	[BlackList] // 0x0000000189846AF0-0x0000000189846B30
	// [XID] // 0x0000000189846AF0-0x0000000189846B30
	public static new ModifySkillCost ParseFromJson(JSONNode node) => default; // 0x00000001840A7190-0x00000001840A73E0
	// [XID] // 0x0000000189851010-0x0000000189851030
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB8BA */, bool useObjectPool = false /* Metadata: 0x00AFB8BE */) => default; // 0x00000001840A6C90-0x00000001840A6F90
	// [XID] // 0x00000001898584E0-0x0000000189858500
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB8BF */, bool useObjectPool = false /* Metadata: 0x00AFB8C3 */) => default; // 0x00000001840A5BE0-0x00000001840A5F90
	// [XID] // 0x000000018985F510-0x000000018985F530
	public static new ModifySkillCost ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB8C4 */, bool useObjectPool = false /* Metadata: 0x00AFB8C8 */) => default; // 0x00000001840A64F0-0x00000001840A6710
	[BlackList] // 0x0000000189866D90-0x0000000189866DD0
	// [XID] // 0x0000000189866D90-0x0000000189866DD0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001840A53A0-0x00000001840A5670
	// [XID] // 0x0000000189871130-0x0000000189871150
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001840A75D0-0x00000001840A7920
	[BlackList] // 0x0000000189878A70-0x0000000189878AB0
	// [XID] // 0x0000000189878A70-0x0000000189878AB0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001840A6BA0-0x00000001840A6C90
	// [XID] // 0x0000000189882BD0-0x0000000189882BF0
	public override BaseTalentMixin CreateInstancedMixin(ActorTalent instancedTalent) => default; // 0x00000001840A6F90-0x00000001840A7050
	[BlackList] // 0x000000018988A310-0x000000018988A350
	// [XID] // 0x000000018988A310-0x000000018988A350
	public override void AutoAllocTypeFields() {} // 0x00000001840A5670-0x00000001840A5710
	[BlackList] // 0x00000001898948B0-0x00000001898948F0
	// [XID] // 0x00000001898948B0-0x00000001898948F0
	public override void AutoRecycleTypeFields() {} // 0x00000001840A5710-0x00000001840A5830
	[BlackList] // 0x000000018989EB40-0x000000018989EB80
	// [XID] // 0x000000018989EB40-0x000000018989EB80
	public override void ReturnToObjectPool() {} // 0x00000001840A7B30-0x00000001840A7BD0
}

