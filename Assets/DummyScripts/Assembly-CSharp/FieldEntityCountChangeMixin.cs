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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class FieldEntityCountChangeMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17139
{
	// Fields
	private TargetType _campTargetType; // 0x30
	private bool _forceTriggerWhenChangeAuthority; // 0x34
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _targetPredicates; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onFieldEnter; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onFieldExit; // 0x48

	// Properties
	public TargetType campTargetType { /* [XID] */ /* 0x000000018993E6F0-0x000000018993E710 */ get => default; /* [XID] */ /* 0x0000000189945D40-0x0000000189945D60 */ private set {} } // 0x0000000184050550-0x00000001840505F0 0x0000000184050F40-0x0000000184050FF0
	public bool forceTriggerWhenChangeAuthority { /* [XID] */ /* 0x000000018994D1D0-0x000000018994D1F0 */ get => default; /* [XID] */ /* 0x00000001899549A0-0x00000001899549C0 */ private set {} } // 0x000000018404F910-0x000000018404F9B0 0x0000000184050140-0x00000001840501F0
	public ConfigAbilityPredicate[] targetPredicates { /* [XID] */ /* 0x000000018995C1A0-0x000000018995C1C0 */ get => default; /* [XID] */ /* 0x0000000189963BC0-0x0000000189963BE0 */ private set {} } // 0x0000000184050D40-0x0000000184050DE0 0x000000018404E980-0x000000018404EA30
	public ConfigAbilityAction[] onFieldEnter { /* [XID] */ /* 0x000000018996B190-0x000000018996B1B0 */ get => default; /* [XID] */ /* 0x0000000189972BF0-0x0000000189972C10 */ private set {} } // 0x0000000184050760-0x0000000184050800 0x00000001840504A0-0x0000000184050550
	public ConfigAbilityAction[] onFieldExit { /* [XID] */ /* 0x000000018997A530-0x000000018997A550 */ get => default; /* [XID] */ /* 0x0000000189981E00-0x0000000189981E20 */ private set {} } // 0x0000000184050800-0x00000001840508A0 0x000000018404EA90-0x000000018404EB40
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189A05F30-0x0000000189A05F50 */ get => default; } // 0x000000018404F160-0x000000018404F200 

	// Constructors
	public FieldEntityCountChangeMixin() {} // 0x0000000184051090-0x0000000184051100

	// Methods
	// [XID] // 0x0000000189989620-0x0000000189989640
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184050DE0-0x0000000184050F40
	// [XID] // 0x0000000189990EF0-0x0000000189990F10
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184050650-0x0000000184050760
	// [XID] // 0x00000001899988F0-0x0000000189998910
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6471 */) => default; // 0x0000000184050060-0x0000000184050140
	// [XID] // 0x00000001899A0290-0x00000001899A02B0
	public override int GetHashNum() => default; // 0x000000018404E8B0-0x000000018404E980
	// [XID] // 0x00000001899A7DA0-0x00000001899A7DC0
	public override void InitEmpty() {} // 0x000000018404F9B0-0x000000018404FAB0
	[BlackList] // 0x00000001899AF550-0x00000001899AF590
	// [XID] // 0x00000001899AF550-0x00000001899AF590
	public override bool FromJson(JSONNode node) => default; // 0x000000018404F200-0x000000018404F580
	// [XID] // 0x00000001899B9950-0x00000001899B9970
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018404DDD0-0x000000018404E340
	[BlackList] // 0x00000001899C14B0-0x00000001899C14F0
	// [XID] // 0x00000001899C14B0-0x00000001899C14F0
	public static new FieldEntityCountChangeMixin ParseFromJson(JSONNode node) => default; // 0x0000000184050250-0x00000001840504A0
	// [XID] // 0x00000001899CBDA0-0x00000001899CBDC0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6472 */, bool useObjectPool = false /* Metadata: 0x00AF6476 */) => default; // 0x000000018404FC80-0x000000018404FF80
	// [XID] // 0x00000001899D32B0-0x00000001899D32D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6477 */, bool useObjectPool = false /* Metadata: 0x00AF647B */) => default; // 0x000000018404EBC0-0x000000018404F060
	// [XID] // 0x00000001899DA820-0x00000001899DA840
	public static new FieldEntityCountChangeMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF647C */, bool useObjectPool = false /* Metadata: 0x00AF6480 */) => default; // 0x000000018404F5F0-0x000000018404F810
	[BlackList] // 0x00000001899E2240-0x00000001899E2280
	// [XID] // 0x00000001899E2240-0x00000001899E2280
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018404E340-0x000000018404E610
	// [XID] // 0x00000001899EC610-0x00000001899EC630
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001840508A0-0x0000000184050D40
	[BlackList] // 0x00000001899F4370-0x00000001899F43B0
	// [XID] // 0x00000001899F4370-0x00000001899F43B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018404FB90-0x000000018404FC80
	// [XID] // 0x00000001899FE710-0x00000001899FE730
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x000000018404FF80-0x0000000184050060
	[BlackList] // 0x0000000189A0D3A0-0x0000000189A0D3E0
	// [XID] // 0x0000000189A0D3A0-0x0000000189A0D3E0
	public override void AutoAllocTypeFields() {} // 0x000000018404E610-0x000000018404E6B0
	[BlackList] // 0x0000000189A17650-0x0000000189A17690
	// [XID] // 0x0000000189A17650-0x0000000189A17690
	public override void AutoRecycleTypeFields() {} // 0x000000018404E6B0-0x000000018404E790
	[BlackList] // 0x0000000189A21CF0-0x0000000189A21D30
	// [XID] // 0x0000000189A21CF0-0x0000000189A21D30
	public override void ReturnToObjectPool() {} // 0x0000000184050FF0-0x0000000184051090
}

