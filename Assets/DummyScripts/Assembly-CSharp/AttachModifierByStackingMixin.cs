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
public class AttachModifierByStackingMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16892
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _actionQueue; // 0x30
	private string _stackingModifier; // 0x38

	// Properties
	public ConfigAbilityAction[] actionQueue { /* [XID] */ /* 0x0000000189B5FDE0-0x0000000189B5FE00 */ get => default; /* [XID] */ /* 0x0000000189B67480-0x0000000189B674A0 */ private set {} } // 0x0000000181F5D620-0x0000000181F5D6C0 0x0000000181F5E290-0x0000000181F5E340
	public string stackingModifier { /* [XID] */ /* 0x0000000189B6E6E0-0x0000000189B6E700 */ get => default; /* [XID] */ /* 0x0000000189B75F10-0x0000000189B75F30 */ private set {} } // 0x0000000181F5DFA0-0x0000000181F5E040 0x0000000181F5E4A0-0x0000000181F5E550
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001895FE220-0x00000001895FE240 */ get => default; } // 0x0000000181F5CF70-0x0000000181F5D010 

	// Constructors
	public AttachModifierByStackingMixin() {} // 0x0000000181F5E9C0-0x0000000181F5EA20

	// Methods
	// [XID] // 0x0000000189B7D420-0x0000000189B7D440
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181F5E810-0x0000000181F5E920
	// [XID] // 0x0000000189B851B0-0x0000000189B851D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181F5E3A0-0x0000000181F5E4A0
	// [XID] // 0x0000000189B8C000-0x0000000189B8C020
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5CA9 */) => default; // 0x0000000181F5DE60-0x0000000181F5DF40
	// [XID] // 0x0000000189B93830-0x0000000189B93850
	public override int GetHashNum() => default; // 0x0000000181F5C9C0-0x0000000181F5CA90
	// [XID] // 0x0000000189B9AD40-0x0000000189B9AD60
	public override void InitEmpty() {} // 0x0000000181F5D7C0-0x0000000181F5D8B0
	[BlackList] // 0x0000000189BA25F0-0x0000000189BA2630
	// [XID] // 0x0000000189BA25F0-0x0000000189BA2630
	public override bool FromJson(JSONNode node) => default; // 0x0000000181F5D010-0x0000000181F5D390
	// [XID] // 0x0000000189BAC5D0-0x0000000189BAC5F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181F5C160-0x0000000181F5C470
	[BlackList] // 0x0000000189BB3E90-0x0000000189BB3ED0
	// [XID] // 0x0000000189BB3E90-0x0000000189BB3ED0
	public static new AttachModifierByStackingMixin ParseFromJson(JSONNode node) => default; // 0x0000000181F5E040-0x0000000181F5E290
	// [XID] // 0x0000000189BBE330-0x0000000189BBE350
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5CAA */, bool useObjectPool = false /* Metadata: 0x00AF5CAE */) => default; // 0x0000000181F5DA80-0x0000000181F5DD80
	// [XID] // 0x0000000189BC5FE0-0x0000000189BC6000
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5CAF */, bool useObjectPool = false /* Metadata: 0x00AF5CB3 */) => default; // 0x0000000181F5CB70-0x0000000181F5CE70
	// [XID] // 0x0000000189BCDAE0-0x0000000189BCDB00
	public static new AttachModifierByStackingMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5CB4 */, bool useObjectPool = false /* Metadata: 0x00AF5CB8 */) => default; // 0x0000000181F5D400-0x0000000181F5D620
	[BlackList] // 0x0000000189BD4FF0-0x0000000189BD5030
	// [XID] // 0x0000000189BD4FF0-0x0000000189BD5030
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181F5C470-0x0000000181F5C740
	// [XID] // 0x0000000189BDFA60-0x0000000189BDFA80
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181F5E550-0x0000000181F5E810
	[BlackList] // 0x00000001895EC5F0-0x00000001895EC630
	// [XID] // 0x00000001895EC5F0-0x00000001895EC630
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181F5D990-0x0000000181F5DA80
	// [XID] // 0x00000001895F6E80-0x00000001895F6EA0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000181F5DD80-0x0000000181F5DE60
	[BlackList] // 0x0000000189605A30-0x0000000189605A70
	// [XID] // 0x0000000189605A30-0x0000000189605A70
	public override void AutoAllocTypeFields() {} // 0x0000000181F5C740-0x0000000181F5C7E0
	[BlackList] // 0x0000000189610510-0x0000000189610550
	// [XID] // 0x0000000189610510-0x0000000189610550
	public override void AutoRecycleTypeFields() {} // 0x0000000181F5C7E0-0x0000000181F5C8A0
	[BlackList] // 0x000000018961AAE0-0x000000018961AB20
	// [XID] // 0x000000018961AAE0-0x000000018961AB20
	public override void ReturnToObjectPool() {} // 0x0000000181F5E920-0x0000000181F5E9C0
}

