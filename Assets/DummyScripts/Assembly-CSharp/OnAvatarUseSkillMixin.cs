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
public class OnAvatarUseSkillMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16963
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onTriggerNormalAttack; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onTriggerSkill; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onTriggerUltimateSkill; // 0x40

	// Properties
	public ConfigAbilityAction[] onTriggerNormalAttack { /* [XID] */ /* 0x00000001898C2DA0-0x00000001898C2DC0 */ get => default; /* [XID] */ /* 0x00000001898CA700-0x00000001898CA720 */ private set {} } // 0x0000000183C12C10-0x0000000183C12CB0 0x0000000183C13980-0x0000000183C13A30
	public ConfigAbilityAction[] onTriggerSkill { /* [XID] */ /* 0x00000001898D1E90-0x00000001898D1EB0 */ get => default; /* [XID] */ /* 0x00000001898D96D0-0x00000001898D96F0 */ private set {} } // 0x0000000183C122A0-0x0000000183C12340 0x0000000183C12F40-0x0000000183C12FF0
	public ConfigAbilityAction[] onTriggerUltimateSkill { /* [XID] */ /* 0x00000001898E1430-0x00000001898E1450 */ get => default; /* [XID] */ /* 0x00000001898E8E80-0x00000001898E8EA0 */ private set {} } // 0x0000000183C130F0-0x0000000183C13190 0x0000000183C13DF0-0x0000000183C13EA0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x000000018996CA50-0x000000018996CA70 */ get => default; } // 0x0000000183C127F0-0x0000000183C12890 

	// Constructors
	public OnAvatarUseSkillMixin() {} // 0x0000000183C14410-0x0000000183C14470

	// Methods
	// [XID] // 0x00000001898F05E0-0x00000001898F0600
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183C14240-0x0000000183C14370
	// [XID] // 0x00000001898F7FD0-0x00000001898F7FF0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183C13CE0-0x0000000183C13DF0
	// [XID] // 0x00000001898FF690-0x00000001898FF6B0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5EDF */) => default; // 0x0000000183C13840-0x0000000183C13920
	// [XID] // 0x0000000189906E70-0x0000000189906E90
	public override int GetHashNum() => default; // 0x0000000183C120F0-0x0000000183C121C0
	// [XID] // 0x000000018990E870-0x000000018990E890
	public override void InitEmpty() {} // 0x0000000183C13190-0x0000000183C13290
	[BlackList] // 0x0000000189915EC0-0x0000000189915F00
	// [XID] // 0x0000000189915EC0-0x0000000189915F00
	public override bool FromJson(JSONNode node) => default; // 0x0000000183C12890-0x0000000183C12C10
	// [XID] // 0x0000000189920770-0x0000000189920790
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183C117A0-0x0000000183C11B90
	[BlackList] // 0x0000000189928110-0x0000000189928150
	// [XID] // 0x0000000189928110-0x0000000189928150
	public static new OnAvatarUseSkillMixin ParseFromJson(JSONNode node) => default; // 0x0000000183C13A30-0x0000000183C13C80
	// [XID] // 0x00000001899326C0-0x00000001899326E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5EE0 */, bool useObjectPool = false /* Metadata: 0x00AF5EE4 */) => default; // 0x0000000183C13460-0x0000000183C13760
	// [XID] // 0x000000018993A0D0-0x000000018993A0F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5EE5 */, bool useObjectPool = false /* Metadata: 0x00AF5EE9 */) => default; // 0x0000000183C12340-0x0000000183C126F0
	// [XID] // 0x00000001899412A0-0x00000001899412C0
	public static new OnAvatarUseSkillMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5EEA */, bool useObjectPool = false /* Metadata: 0x00AF5EEE */) => default; // 0x0000000183C12D20-0x0000000183C12F40
	[BlackList] // 0x0000000189948DE0-0x0000000189948E20
	// [XID] // 0x0000000189948DE0-0x0000000189948E20
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183C11B90-0x0000000183C11E60
	// [XID] // 0x0000000189953390-0x00000001899533B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183C13EA0-0x0000000183C14240
	[BlackList] // 0x000000018995AB90-0x000000018995ABD0
	// [XID] // 0x000000018995AB90-0x000000018995ABD0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183C13370-0x0000000183C13460
	// [XID] // 0x0000000189965430-0x0000000189965450
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000183C13760-0x0000000183C13840
	[BlackList] // 0x00000001899744B0-0x00000001899744F0
	// [XID] // 0x00000001899744B0-0x00000001899744F0
	public override void AutoAllocTypeFields() {} // 0x0000000183C11E60-0x0000000183C11F00
	[BlackList] // 0x000000018997E760-0x000000018997E7A0
	// [XID] // 0x000000018997E760-0x000000018997E7A0
	public override void AutoRecycleTypeFields() {} // 0x0000000183C11F00-0x0000000183C11FD0
	[BlackList] // 0x0000000189989640-0x0000000189989680
	// [XID] // 0x0000000189989640-0x0000000189989680
	public override void ReturnToObjectPool() {} // 0x0000000183C14370-0x0000000183C14410
}

