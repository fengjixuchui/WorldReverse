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
public class DoActionByAnimatorStateIDMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17049
{
	// Fields
	private string[] _stateIDs; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _enterPredicates; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _exitPredicates; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _enterActions; // 0x48
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _exitActions; // 0x50

	// Properties
	public string[] stateIDs { /* [XID] */ /* 0x00000001899E2280-0x00000001899E22A0 */ get => default; /* [XID] */ /* 0x00000001899E9740-0x00000001899E9760 */ private set {} } // 0x0000000183EBD970-0x0000000183EBDA10 0x0000000183EBDA10-0x0000000183EBDAC0
	public ConfigAbilityPredicate[] enterPredicates { /* [XID] */ /* 0x00000001899F0DF0-0x00000001899F0E10 */ get => default; /* [XID] */ /* 0x00000001899F8730-0x00000001899F8750 */ private set {} } // 0x0000000183EBC290-0x0000000183EBC330 0x0000000183EBB030-0x0000000183EBB0E0
	public ConfigAbilityPredicate[] exitPredicates { /* [XID] */ /* 0x00000001899FFC80-0x00000001899FFCA0 */ get => default; /* [XID] */ /* 0x0000000189A07590-0x0000000189A075B0 */ private set {} } // 0x0000000183EBA710-0x0000000183EBA7B0 0x0000000183EBCFE0-0x0000000183EBD090
	public ConfigAbilityAction[] enterActions { /* [XID] */ /* 0x0000000189A0EA10-0x0000000189A0EA30 */ get => default; /* [XID] */ /* 0x0000000189A16140-0x0000000189A16160 */ private set {} } // 0x0000000183EBC4D0-0x0000000183EBC570 0x0000000183EBD750-0x0000000183EBD800
	public ConfigAbilityAction[] exitActions { /* [XID] */ /* 0x0000000189A1D6C0-0x0000000189A1D6E0 */ get => default; /* [XID] */ /* 0x0000000189A24AD0-0x0000000189A24AF0 */ private set {} } // 0x0000000183EBC3C0-0x0000000183EBC460 0x0000000183EBC1E0-0x0000000183EBC290
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189AA85A0-0x0000000189AA85C0 */ get => default; } // 0x0000000183EBBB30-0x0000000183EBBBD0 

	// Constructors
	public DoActionByAnimatorStateIDMixin() {} // 0x0000000183EBDB60-0x0000000183EBDBC0

	// Methods
	// [XID] // 0x0000000189A2C0F0-0x0000000189A2C110
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183EBD800-0x0000000183EBD970
	// [XID] // 0x0000000189A33840-0x0000000189A33860
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183EBD0F0-0x0000000183EBD240
	// [XID] // 0x0000000189A3B000-0x0000000189A3B020
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6183 */) => default; // 0x0000000183EBCC50-0x0000000183EBCD30
	// [XID] // 0x0000000189A428D0-0x0000000189A428F0
	public override int GetHashNum() => default; // 0x0000000183EBB380-0x0000000183EBB450
	// [XID] // 0x0000000189A49DE0-0x0000000189A49E00
	public override void InitEmpty() {} // 0x0000000183EBC570-0x0000000183EBC6A0
	[BlackList] // 0x0000000189A517B0-0x0000000189A517F0
	// [XID] // 0x0000000189A517B0-0x0000000189A517F0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183EBBBD0-0x0000000183EBBF50
	// [XID] // 0x0000000189A5C1A0-0x0000000189A5C1C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183EBA7B0-0x0000000183EBAD60
	[BlackList] // 0x0000000189A63AF0-0x0000000189A63B30
	// [XID] // 0x0000000189A63AF0-0x0000000189A63B30
	public static new DoActionByAnimatorStateIDMixin ParseFromJson(JSONNode node) => default; // 0x0000000183EBCD90-0x0000000183EBCFE0
	// [XID] // 0x0000000189A6E280-0x0000000189A6E2A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6184 */, bool useObjectPool = false /* Metadata: 0x00AF6188 */) => default; // 0x0000000183EBC870-0x0000000183EBCB70
	// [XID] // 0x0000000189A75830-0x0000000189A75850
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6189 */, bool useObjectPool = false /* Metadata: 0x00AF618D */) => default; // 0x0000000183EBB530-0x0000000183EBBA30
	// [XID] // 0x0000000189A7D470-0x0000000189A7D490
	public static new DoActionByAnimatorStateIDMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF618E */, bool useObjectPool = false /* Metadata: 0x00AF6192 */) => default; // 0x0000000183EBBFC0-0x0000000183EBC1E0
	[BlackList] // 0x0000000189A84C40-0x0000000189A84C80
	// [XID] // 0x0000000189A84C40-0x0000000189A84C80
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183EBAD60-0x0000000183EBB030
	// [XID] // 0x0000000189A8F650-0x0000000189A8F670
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183EBD240-0x0000000183EBD750
	[BlackList] // 0x0000000189A96BA0-0x0000000189A96BE0
	// [XID] // 0x0000000189A96BA0-0x0000000189A96BE0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183EBC780-0x0000000183EBC870
	// [XID] // 0x0000000189AA0F00-0x0000000189AA0F20
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000183EBCB70-0x0000000183EBCC50
	[BlackList] // 0x0000000189AB0280-0x0000000189AB02C0
	// [XID] // 0x0000000189AB0280-0x0000000189AB02C0
	public override void AutoAllocTypeFields() {} // 0x0000000183EBB0E0-0x0000000183EBB180
	[BlackList] // 0x0000000189ABAE90-0x0000000189ABAED0
	// [XID] // 0x0000000189ABAE90-0x0000000189ABAED0
	public override void AutoRecycleTypeFields() {} // 0x0000000183EBB180-0x0000000183EBB260
	[BlackList] // 0x0000000189AC57B0-0x0000000189AC57F0
	// [XID] // 0x0000000189AC57B0-0x0000000189AC57F0
	public override void ReturnToObjectPool() {} // 0x0000000183EBDAC0-0x0000000183EBDB60
}

