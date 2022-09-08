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
public class ByTargetOverrideMapValue : RelationalOperationPredicate, IAutoAllocRecycle // TypeDefIndex: 17194
{
	// Fields
	private string _targetAbilityName; // 0x20
	private string _targetKey; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _targetValue; // 0x30

	// Properties
	public string targetAbilityName { /* [XID] */ /* 0x000000018974F590-0x000000018974F5B0 */ get => default; /* [XID] */ /* 0x0000000189756C40-0x0000000189756C60 */ private set {} } // 0x0000000182DF4EA0-0x0000000182DF4F40 0x0000000182DF55D0-0x0000000182DF5680
	public string targetKey { /* [XID] */ /* 0x000000018975E110-0x000000018975E130 */ get => default; /* [XID] */ /* 0x0000000189765890-0x00000001897658B0 */ private set {} } // 0x0000000182DF5D30-0x0000000182DF5DD0 0x0000000182DF5DD0-0x0000000182DF5E80
	public DynamicFloat targetValue { /* [XID] */ /* 0x000000018976D120-0x000000018976D140 */ get => default; /* [XID] */ /* 0x0000000189774570-0x0000000189774590 */ private set {} } // 0x0000000182DF4D80-0x0000000182DF4E20 0x0000000182DF47C0-0x0000000182DF4870

	// Constructors
	public ByTargetOverrideMapValue() {} // 0x0000000182DF6860-0x0000000182DF68C0

	// Methods
	// [XID] // 0x000000018977BF80-0x000000018977BFA0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182DF6680-0x0000000182DF67C0
	// [XID] // 0x0000000189783850-0x0000000189783870
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182DF6190-0x0000000182DF62A0
	// [XID] // 0x000000018978B060-0x000000018978B080
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6637 */) => default; // 0x0000000182DF5C50-0x0000000182DF5D30
	// [XID] // 0x0000000189792540-0x0000000189792560
	public override int GetHashNum() => default; // 0x0000000182DF4610-0x0000000182DF46E0
	// [XID] // 0x0000000189799B70-0x0000000189799B90
	public override void InitEmpty() {} // 0x0000000182DF5680-0x0000000182DF5780
	[BlackList] // 0x00000001897A19C0-0x00000001897A1A00
	// [XID] // 0x00000001897A19C0-0x00000001897A1A00
	public override bool FromJson(JSONNode node) => default; // 0x0000000182DF4FC0-0x0000000182DF5340
	// [XID] // 0x00000001897AC1A0-0x00000001897AC1C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182DF3C40-0x0000000182DF4040
	[BlackList] // 0x00000001897B40F0-0x00000001897B4130
	// [XID] // 0x00000001897B40F0-0x00000001897B4130
	public static new ByTargetOverrideMapValue ParseFromJson(JSONNode node) => default; // 0x0000000182DF5EE0-0x0000000182DF6130
	// [XID] // 0x00000001897BF150-0x00000001897BF170
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6638 */, bool useObjectPool = false /* Metadata: 0x00AF663C */) => default; // 0x0000000182DF5950-0x0000000182DF5C50
	// [XID] // 0x00000001897C6700-0x00000001897C6720
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF663D */, bool useObjectPool = false /* Metadata: 0x00AF6641 */) => default; // 0x0000000182DF4870-0x0000000182DF4C50
	// [XID] // 0x00000001897CDF40-0x00000001897CDF60
	public static new ByTargetOverrideMapValue ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6642 */, bool useObjectPool = false /* Metadata: 0x00AF6646 */) => default; // 0x0000000182DF5340-0x0000000182DF5560
	[BlackList] // 0x00000001897D54D0-0x00000001897D5510
	// [XID] // 0x00000001897D54D0-0x00000001897D5510
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182DF4040-0x0000000182DF4310
	// [XID] // 0x00000001897DFDD0-0x00000001897DFDF0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182DF6350-0x0000000182DF6680
	[BlackList] // 0x00000001897E7390-0x00000001897E73D0
	// [XID] // 0x00000001897E7390-0x00000001897E73D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182DF5860-0x0000000182DF5950
	// [XID] // 0x00000001897F2390-0x00000001897F23B0
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000182DF4C50-0x0000000182DF4D80
	[BlackList] // 0x00000001897F9A80-0x00000001897F9AC0
	// [XID] // 0x00000001897F9A80-0x00000001897F9AC0
	public override void AutoAllocTypeFields() {} // 0x0000000182DF4310-0x0000000182DF43B0
	[BlackList] // 0x00000001898040F0-0x0000000189804130
	// [XID] // 0x00000001898040F0-0x0000000189804130
	public override void AutoRecycleTypeFields() {} // 0x0000000182DF43B0-0x0000000182DF44F0
	[BlackList] // 0x000000018980E610-0x000000018980E650
	// [XID] // 0x000000018980E610-0x000000018980E650
	public override void ReturnToObjectPool() {} // 0x0000000182DF67C0-0x0000000182DF6860
}

