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
public class KillSelf : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16509
{
	// Fields
	private SimpleSafeFloat durationRawNum; // 0x68
	private DieStateFlag _dieStateFlage; // 0x6C
	private bool _banDrop; // 0x70
	private bool _banExp; // 0x71
	private bool _banHPPercentageDrop; // 0x72
	private KillSelfType _killSelfType; // 0x74
	private bool _hideEntity; // 0x78

	// Properties
	public float duration { /* [XID] */ /* 0x00000001898DC970-0x00000001898DC990 */ get => default; /* [XID] */ /* 0x00000001898E4420-0x00000001898E4440 */ private set {} } // 0x00000001843CFCA0-0x00000001843CFD80 0x00000001843D0600-0x00000001843D06E0
	public DieStateFlag dieStateFlage { /* [XID] */ /* 0x00000001898EBE50-0x00000001898EBE70 */ get => default; /* [XID] */ /* 0x00000001898F3720-0x00000001898F3740 */ private set {} } // 0x00000001843D1980-0x00000001843D1A20 0x00000001843D22F0-0x00000001843D23A0
	public bool banDrop { /* [XID] */ /* 0x00000001898FAD80-0x00000001898FADA0 */ get => default; /* [XID] */ /* 0x0000000189902920-0x0000000189902940 */ private set {} } // 0x00000001843D2AF0-0x00000001843D2B90 0x00000001843D2160-0x00000001843D2210
	public bool banExp { /* [XID] */ /* 0x0000000189909EA0-0x0000000189909EC0 */ get => default; /* [XID] */ /* 0x0000000189911740-0x0000000189911760 */ private set {} } // 0x00000001843D0E10-0x00000001843D0EB0 0x00000001843D06E0-0x00000001843D0790
	public bool banHPPercentageDrop { /* [XID] */ /* 0x00000001899192C0-0x00000001899192E0 */ get => default; /* [XID] */ /* 0x0000000189920850-0x0000000189920870 */ private set {} } // 0x00000001843D1A80-0x00000001843D1B20 0x00000001843D2520-0x00000001843D25D0
	public KillSelfType killSelfType { /* [XID] */ /* 0x00000001899281D0-0x00000001899281F0 */ get => default; /* [XID] */ /* 0x000000018992F760-0x000000018992F780 */ private set {} } // 0x00000001843D09F0-0x00000001843D0A90 0x00000001843D2DD0-0x00000001843D2E80
	public bool hideEntity { /* [XID] */ /* 0x0000000189936BF0-0x0000000189936C10 */ get => default; /* [XID] */ /* 0x000000018993E7D0-0x000000018993E7F0 */ private set {} } // 0x00000001843CFFA0-0x00000001843D0040 0x00000001843D1400-0x00000001843D14B0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001899CA2A0-0x00000001899CA2C0 */ get => default; } // 0x00000001843D1ED0-0x00000001843D1F70 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001899D1B20-0x00000001899D1B40 */ get => default; } // 0x00000001843D11B0-0x00000001843D1250 

	// Constructors
	public KillSelf() {} // 0x00000001843D2F20-0x00000001843D2FA0

	// Methods
	// [XID] // 0x0000000189945DC0-0x0000000189945DE0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001843D2B90-0x00000001843D2D30
	// [XID] // 0x000000018994D290-0x000000018994D2B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001843D1FD0-0x00000001843D2080
	// [XID] // 0x0000000189954A80-0x0000000189954AA0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3DA6 */) => default; // 0x00000001843D18A0-0x00000001843D1980
	// [XID] // 0x000000018995C240-0x000000018995C260
	public override int GetHashNum() => default; // 0x00000001843CFE00-0x00000001843CFED0
	// [XID] // 0x0000000189963C80-0x0000000189963CA0
	public override void InitEmpty() {} // 0x00000001843D1250-0x00000001843D1320
	[BlackList] // 0x000000018996B210-0x000000018996B250
	// [XID] // 0x000000018996B210-0x000000018996B250
	public override bool FromJson(JSONNode node) => default; // 0x00000001843D0A90-0x00000001843D0E10
	// [XID] // 0x0000000189975C90-0x0000000189975CB0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001843CF020-0x00000001843CF730
	[BlackList] // 0x000000018997CD30-0x000000018997CD70
	// [XID] // 0x000000018997CD30-0x000000018997CD70
	public static new KillSelf ParseFromJson(JSONNode node) => default; // 0x00000001843D1C80-0x00000001843D1ED0
	// [XID] // 0x0000000189987AF0-0x0000000189987B10
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3DA7 */, bool useObjectPool = false /* Metadata: 0x00AF3DAB */) => default; // 0x00000001843D15A0-0x00000001843D18A0
	// [XID] // 0x000000018998F640-0x000000018998F660
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3DAC */, bool useObjectPool = false /* Metadata: 0x00AF3DB0 */) => default; // 0x00000001843D00C0-0x00000001843D0600
	// [XID] // 0x0000000189997060-0x0000000189997080
	public static new KillSelf ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3DB1 */, bool useObjectPool = false /* Metadata: 0x00AF3DB5 */) => default; // 0x00000001843D0EB0-0x00000001843D10D0
	[BlackList] // 0x000000018999EC30-0x000000018999EC70
	// [XID] // 0x000000018999EC30-0x000000018999EC70
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001843CF730-0x00000001843CFA00
	// [XID] // 0x00000001899A9480-0x00000001899A94A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001843D25D0-0x00000001843D2AF0
	[BlackList] // 0x00000001899B0FB0-0x00000001899B0FF0
	// [XID] // 0x00000001899B0FB0-0x00000001899B0FF0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001843D14B0-0x00000001843D15A0
	// [XID] // 0x00000001899BB3D0-0x00000001899BB3F0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001843D2D30-0x00000001843D2DD0
	// [XID] // 0x00000001899C2F00-0x00000001899C2F20
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001843D0790-0x00000001843D08F0
	// [XID] // 0x00000001899D9050-0x00000001899D9070
	public override void CallAuthority(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x00000001843D23A0-0x00000001843D2520
	// [XID] // 0x00000001899E07E0-0x00000001899E0800
	public override void CallRemote(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, UnionAbilityInvokeEntry invokeEntry) {} // 0x00000001843D1B20-0x00000001843D1C80
	[BlackList] // 0x00000001899E8280-0x00000001899E82C0
	// [XID] // 0x00000001899E8280-0x00000001899E82C0
	public override void AutoAllocTypeFields() {} // 0x00000001843CFA00-0x00000001843CFAA0
	[BlackList] // 0x00000001899F2A20-0x00000001899F2A60
	// [XID] // 0x00000001899F2A20-0x00000001899F2A60
	public override void AutoRecycleTypeFields() {} // 0x00000001843CFAA0-0x00000001843CFB90
	[BlackList] // 0x00000001899FD010-0x00000001899FD050
	// [XID] // 0x00000001899FD010-0x00000001899FD050
	public override void ReturnToObjectPool() {} // 0x00000001843D2E80-0x00000001843D2F20
}

