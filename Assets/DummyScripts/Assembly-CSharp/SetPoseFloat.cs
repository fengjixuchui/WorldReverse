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
public class SetPoseFloat : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16543
{
	// Fields
	private string _floatID; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _value; // 0x70

	// Properties
	public string floatID { /* [XID] */ /* 0x0000000189B3B930-0x0000000189B3B950 */ get => default; /* [XID] */ /* 0x0000000189B43370-0x0000000189B43390 */ private set {} } // 0x0000000183D24AE0-0x0000000183D24B80 0x0000000183D23430-0x0000000183D234E0
	public DynamicFloat value { /* [XID] */ /* 0x0000000189B4AB50-0x0000000189B4AB70 */ get => default; /* [XID] */ /* 0x0000000189B521C0-0x0000000189B521E0 */ private set {} } // 0x0000000183D23390-0x0000000183D23430 0x0000000183D23260-0x0000000183D23310
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189BDCC00-0x0000000189BDCC20 */ get => default; } // 0x0000000183D24550-0x0000000183D245F0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001895E93B0-0x00000001895E93D0 */ get => default; } // 0x0000000183D23B60-0x0000000183D23C00 

	// Constructors
	public SetPoseFloat() {} // 0x0000000183D24DF0-0x0000000183D24E50

	// Methods
	// [XID] // 0x0000000189B59B60-0x0000000189B59B80
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183D24B80-0x0000000183D24CB0
	// [XID] // 0x0000000189B612B0-0x0000000189B612D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183D24650-0x0000000183D24750
	// [XID] // 0x0000000189B68BC0-0x0000000189B68BE0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3EB6 */) => default; // 0x0000000183D241C0-0x0000000183D242A0
	// [XID] // 0x0000000189B701C0-0x0000000189B701E0
	public override int GetHashNum() => default; // 0x0000000183D22B30-0x0000000183D22C00
	// [XID] // 0x0000000189B77610-0x0000000189B77630
	public override void InitEmpty() {} // 0x0000000183D23C00-0x0000000183D23CF0
	[BlackList] // 0x0000000189B7EBC0-0x0000000189B7EC00
	// [XID] // 0x0000000189B7EBC0-0x0000000189B7EC00
	public override bool FromJson(JSONNode node) => default; // 0x0000000183D234E0-0x0000000183D23860
	// [XID] // 0x0000000189B89550-0x0000000189B89570
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183D221D0-0x0000000183D22500
	[BlackList] // 0x0000000189B90AF0-0x0000000189B90B30
	// [XID] // 0x0000000189B90AF0-0x0000000189B90B30
	public static new SetPoseFloat ParseFromJson(JSONNode node) => default; // 0x0000000183D24300-0x0000000183D24550
	// [XID] // 0x0000000189B9ADE0-0x0000000189B9AE00
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3EB7 */, bool useObjectPool = false /* Metadata: 0x00AF3EBB */) => default; // 0x0000000183D23EC0-0x0000000183D241C0
	// [XID] // 0x0000000189BA2690-0x0000000189BA26B0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3EBC */, bool useObjectPool = false /* Metadata: 0x00AF3EC0 */) => default; // 0x0000000183D22D50-0x0000000183D23080
	// [XID] // 0x0000000189BA9AE0-0x0000000189BA9B00
	public static new SetPoseFloat ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3EC1 */, bool useObjectPool = false /* Metadata: 0x00AF3EC5 */) => default; // 0x0000000183D23860-0x0000000183D23A80
	[BlackList] // 0x0000000189BB1350-0x0000000189BB1390
	// [XID] // 0x0000000189BB1350-0x0000000189BB1390
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183D22500-0x0000000183D227D0
	// [XID] // 0x0000000189BBB510-0x0000000189BBB530
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183D24830-0x0000000183D24AE0
	[BlackList] // 0x0000000189BC3370-0x0000000189BC33B0
	// [XID] // 0x0000000189BC3370-0x0000000189BC33B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183D23DD0-0x0000000183D23EC0
	// [XID] // 0x0000000189BCDB80-0x0000000189BCDBA0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000183D24CB0-0x0000000183D24D50
	// [XID] // 0x0000000189BD50D0-0x0000000189BD50F0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000183D23080-0x0000000183D231E0
	[BlackList] // 0x00000001895F0BA0-0x00000001895F0BE0
	// [XID] // 0x00000001895F0BA0-0x00000001895F0BE0
	public override void AutoAllocTypeFields() {} // 0x0000000183D227D0-0x0000000183D22870
	[BlackList] // 0x00000001895FB430-0x00000001895FB470
	// [XID] // 0x00000001895FB430-0x00000001895FB470
	public override void AutoRecycleTypeFields() {} // 0x0000000183D22870-0x0000000183D229A0
	[BlackList] // 0x0000000189605B30-0x0000000189605B70
	// [XID] // 0x0000000189605B30-0x0000000189605B70
	public override void ReturnToObjectPool() {} // 0x0000000183D24D50-0x0000000183D24DF0
}

