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
public class AvatarSkillStart : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16351
{
	// Fields
	private SimpleSafeUInt32 skillIDRawNum; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _cdRatio; // 0x70
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _costStaminaRatio; // 0x78

	// Properties
	public uint skillID { /* [XID] */ /* 0x0000000189AE3EB0-0x0000000189AE3ED0 */ get => default; /* [XID] */ /* 0x0000000189AEB710-0x0000000189AEB730 */ private set {} } // 0x0000000181918810-0x00000001819188E0 0x0000000181919A70-0x0000000181919B50
	public DynamicFloat cdRatio { /* [XID] */ /* 0x0000000189AF3050-0x0000000189AF3070 */ get => default; /* [XID] */ /* 0x0000000189AFA960-0x0000000189AFA980 */ private set {} } // 0x00000001819178F0-0x0000000181917990 0x0000000181919010-0x00000001819190C0
	public DynamicFloat costStaminaRatio { /* [XID] */ /* 0x0000000189B01EF0-0x0000000189B01F10 */ get => default; /* [XID] */ /* 0x0000000189B09430-0x0000000189B09450 */ private set {} } // 0x0000000181919570-0x0000000181919610 0x0000000181918A30-0x0000000181918AE0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189B938F0-0x0000000189B93910 */ get => default; } // 0x0000000181919370-0x0000000181919410 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B9AEA0-0x0000000189B9AEC0 */ get => default; } // 0x0000000181918770-0x0000000181918810 

	// Constructors
	public AvatarSkillStart() {} // 0x0000000181919DE0-0x0000000181919E90

	// Methods
	// [XID] // 0x0000000189B10EB0-0x0000000189B10ED0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181919B50-0x0000000181919CA0
	// [XID] // 0x0000000189B18160-0x0000000189B18180
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181919470-0x0000000181919570
	// [XID] // 0x0000000189B1F800-0x0000000189B1F820
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF38B4 */) => default; // 0x0000000181918F30-0x0000000181919010
	// [XID] // 0x0000000189B270A0-0x0000000189B270C0
	public override int GetHashNum() => default; // 0x0000000181917820-0x00000001819178F0
	// [XID] // 0x0000000189B2E210-0x0000000189B2E230
	public override void InitEmpty() {} // 0x00000001819188E0-0x00000001819189B0
	[BlackList] // 0x0000000189B356C0-0x0000000189B35700
	// [XID] // 0x0000000189B356C0-0x0000000189B35700
	public override bool FromJson(JSONNode node) => default; // 0x00000001819180F0-0x0000000181918470
	// [XID] // 0x0000000189B402C0-0x0000000189B402E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181916D30-0x0000000181917140
	[BlackList] // 0x0000000189B47B80-0x0000000189B47BC0
	// [XID] // 0x0000000189B47B80-0x0000000189B47BC0
	public static new AvatarSkillStart ParseFromJson(JSONNode node) => default; // 0x0000000181919120-0x0000000181919370
	// [XID] // 0x0000000189B52240-0x0000000189B52260
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF38B5 */, bool useObjectPool = false /* Metadata: 0x00AF38B9 */) => default; // 0x0000000181918C30-0x0000000181918F30
	// [XID] // 0x0000000189B59BE0-0x0000000189B59C00
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF38BA */, bool useObjectPool = false /* Metadata: 0x00AF38BE */) => default; // 0x0000000181917AE0-0x0000000181917E90
	// [XID] // 0x0000000189B61330-0x0000000189B61350
	public static new AvatarSkillStart ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF38BF */, bool useObjectPool = false /* Metadata: 0x00AF38C3 */) => default; // 0x0000000181918470-0x0000000181918690
	[BlackList] // 0x0000000189B68CA0-0x0000000189B68CE0
	// [XID] // 0x0000000189B68CA0-0x0000000189B68CE0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181917140-0x0000000181917410
	// [XID] // 0x0000000189B73090-0x0000000189B730B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001819196F0-0x0000000181919A70
	[BlackList] // 0x0000000189B7A650-0x0000000189B7A690
	// [XID] // 0x0000000189B7A650-0x0000000189B7A690
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181918B40-0x0000000181918C30
	// [XID] // 0x0000000189B852B0-0x0000000189B852D0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000181919CA0-0x0000000181919D40
	// [XID] // 0x0000000189B8C0C0-0x0000000189B8C0E0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000181917E90-0x0000000181917FF0
	[BlackList] // 0x0000000189BA2710-0x0000000189BA2750
	// [XID] // 0x0000000189BA2710-0x0000000189BA2750
	public override void AutoAllocTypeFields() {} // 0x0000000181917410-0x00000001819174B0
	[BlackList] // 0x0000000189BAC6B0-0x0000000189BAC6F0
	// [XID] // 0x0000000189BAC6B0-0x0000000189BAC6F0
	public override void AutoRecycleTypeFields() {} // 0x00000001819174B0-0x0000000181917690
	[BlackList] // 0x0000000189BB6DF0-0x0000000189BB6E30
	// [XID] // 0x0000000189BB6DF0-0x0000000189BB6E30
	public override void ReturnToObjectPool() {} // 0x0000000181919D40-0x0000000181919DE0
}

