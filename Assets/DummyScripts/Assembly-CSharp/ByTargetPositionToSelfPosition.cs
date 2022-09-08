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
public class ByTargetPositionToSelfPosition : RelationalOperationPredicate, IAutoAllocRecycle // TypeDefIndex: 17260
{
	// Fields
	private TargetPosToSelfPosType _compareType; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _value; // 0x28

	// Properties
	public TargetPosToSelfPosType compareType { /* [XID] */ /* 0x0000000189AA9EC0-0x0000000189AA9EE0 */ get => default; /* [XID] */ /* 0x0000000189AB1D20-0x0000000189AB1D40 */ private set {} } // 0x00000001823E33B0-0x00000001823E3450 0x00000001823E1FE0-0x00000001823E2090
	public DynamicFloat value { /* [XID] */ /* 0x0000000189AB9030-0x0000000189AB9050 */ get => default; /* [XID] */ /* 0x0000000189AC0B70-0x0000000189AC0B90 */ private set {} } // 0x00000001823E2760-0x00000001823E2800 0x00000001823E2630-0x00000001823E26E0

	// Constructors
	public ByTargetPositionToSelfPosition() {} // 0x00000001823E3E40-0x00000001823E3EA0

	// Methods
	// [XID] // 0x0000000189AC85B0-0x0000000189AC85D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001823E3C80-0x00000001823E3DA0
	// [XID] // 0x0000000189ACFCB0-0x0000000189ACFCD0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001823E3840-0x00000001823E3920
	// [XID] // 0x0000000189AD7A80-0x0000000189AD7AA0
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF688B */) => default; // 0x00000001823E3450-0x00000001823E3530
	// [XID] // 0x0000000189ADF550-0x0000000189ADF570
	public override int GetHashNum() => default; // 0x00000001823E1F10-0x00000001823E1FE0
	// [XID] // 0x0000000189AE6CF0-0x0000000189AE6D10
	public override void InitEmpty() {} // 0x00000001823E2E10-0x00000001823E2EE0
	[BlackList] // 0x0000000189AEE820-0x0000000189AEE860
	// [XID] // 0x0000000189AEE820-0x0000000189AEE860
	public override bool FromJson(JSONNode node) => default; // 0x00000001823E2800-0x00000001823E2B80
	// [XID] // 0x0000000189AF8F30-0x0000000189AF8F50
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001823E1630-0x00000001823E1950
	[BlackList] // 0x0000000189B004B0-0x0000000189B004F0
	// [XID] // 0x0000000189B004B0-0x0000000189B004F0
	public static new ByTargetPositionToSelfPosition ParseFromJson(JSONNode node) => default; // 0x00000001823E3590-0x00000001823E37E0
	// [XID] // 0x0000000189B0ABE0-0x0000000189B0AC00
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF688C */, bool useObjectPool = false /* Metadata: 0x00AF6890 */) => default; // 0x00000001823E30B0-0x00000001823E33B0
	// [XID] // 0x0000000189B12300-0x0000000189B12320
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6891 */, bool useObjectPool = false /* Metadata: 0x00AF6895 */) => default; // 0x00000001823E2170-0x00000001823E2480
	// [XID] // 0x0000000189B19630-0x0000000189B19650
	public static new ByTargetPositionToSelfPosition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6896 */, bool useObjectPool = false /* Metadata: 0x00AF689A */) => default; // 0x00000001823E2B80-0x00000001823E2DA0
	[BlackList] // 0x0000000189B20CD0-0x0000000189B20D10
	// [XID] // 0x0000000189B20CD0-0x0000000189B20D10
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001823E1950-0x00000001823E1C20
	// [XID] // 0x0000000189B2B350-0x0000000189B2B370
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001823E39D0-0x00000001823E3C80
	[BlackList] // 0x0000000189B328E0-0x0000000189B32920
	// [XID] // 0x0000000189B328E0-0x0000000189B32920
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001823E2FC0-0x00000001823E30B0
	// [XID] // 0x0000000189B3CDE0-0x0000000189B3CE00
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x00000001823E2480-0x00000001823E25B0
	[BlackList] // 0x0000000189B44B10-0x0000000189B44B50
	// [XID] // 0x0000000189B44B10-0x0000000189B44B50
	public override void AutoAllocTypeFields() {} // 0x00000001823E1C20-0x00000001823E1CC0
	[BlackList] // 0x0000000189B4F290-0x0000000189B4F2D0
	// [XID] // 0x0000000189B4F290-0x0000000189B4F2D0
	public override void AutoRecycleTypeFields() {} // 0x00000001823E1CC0-0x00000001823E1DF0
	[BlackList] // 0x0000000189B59A80-0x0000000189B59AC0
	// [XID] // 0x0000000189B59A80-0x0000000189B59AC0
	public override void ReturnToObjectPool() {} // 0x00000001823E3DA0-0x00000001823E3E40
}

