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
public class AttachToNormalizedTimeMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16882
{
	// Fields
	private string _stateID; // 0x30
	private string _modifierName; // 0x38
	private AbilityTargetting _target; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _predicates; // 0x48
	private SimpleSafeFloat normalizeStartRawNum; // 0x50
	private SimpleSafeFloat normalizeEndRawNum; // 0x54

	// Properties
	public string stateID { /* [XID] */ /* 0x000000018974F6B0-0x000000018974F6D0 */ get => default; /* [XID] */ /* 0x0000000189756D00-0x0000000189756D20 */ private set {} } // 0x000000018498A630-0x000000018498A6D0 0x00000001849887A0-0x0000000184988850
	public string modifierName { /* [XID] */ /* 0x000000018975E210-0x000000018975E230 */ get => default; /* [XID] */ /* 0x0000000189765930-0x0000000189765950 */ private set {} } // 0x000000018498A6D0-0x000000018498A770 0x0000000184989400-0x00000001849894B0
	public AbilityTargetting target { /* [XID] */ /* 0x000000018976D1E0-0x000000018976D200 */ get => default; /* [XID] */ /* 0x00000001897745F0-0x0000000189774610 */ private set {} } // 0x0000000184987F70-0x0000000184988010 0x0000000184988150-0x0000000184988200
	public ConfigAbilityPredicate[] predicates { /* [XID] */ /* 0x000000018977C020-0x000000018977C040 */ get => default; /* [XID] */ /* 0x00000001897838F0-0x0000000189783910 */ private set {} } // 0x0000000184989F30-0x0000000184989FD0 0x0000000184989A60-0x0000000184989B10
	public float normalizeStart { /* [XID] */ /* 0x000000018978B100-0x000000018978B120 */ get => default; /* [XID] */ /* 0x0000000189792680-0x00000001897926A0 */ private set {} } // 0x0000000184987E90-0x0000000184987F70 0x0000000184988070-0x0000000184988150
	public float normalizeEnd { /* [XID] */ /* 0x0000000189799C10-0x0000000189799C30 */ get => default; /* [XID] */ /* 0x00000001897A1A80-0x00000001897A1AA0 */ private set {} } // 0x00000001849888D0-0x00000001849889B0 0x0000000184987740-0x0000000184987820
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001898264F0-0x0000000189826510 */ get => default; } // 0x0000000184988A30-0x0000000184988AD0 

	// Constructors
	public AttachToNormalizedTimeMixin() {} // 0x000000018498A810-0x000000018498A8C0

	// Methods
	// [XID] // 0x00000001897A9300-0x00000001897A9320
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018498A4B0-0x000000018498A630
	// [XID] // 0x00000001897B0AE0-0x00000001897B0B00
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184989E20-0x0000000184989F30
	// [XID] // 0x00000001897B8840-0x00000001897B8860
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5C59 */) => default; // 0x0000000184989980-0x0000000184989A60
	// [XID] // 0x00000001897C08A0-0x00000001897C08C0
	public override int GetHashNum() => default; // 0x0000000184987DC0-0x0000000184987E90
	// [XID] // 0x00000001897C81F0-0x00000001897C8210
	public override void InitEmpty() {} // 0x00000001849891E0-0x0000000184989320
	[BlackList] // 0x00000001897CF570-0x00000001897CF5B0
	// [XID] // 0x00000001897CF570-0x00000001897CF5B0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184988AD0-0x0000000184988E50
	// [XID] // 0x00000001897DA1F0-0x00000001897DA210
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184987080-0x0000000184987740
	[BlackList] // 0x00000001897E1640-0x00000001897E1680
	// [XID] // 0x00000001897E1640-0x00000001897E1680
	public static new AttachToNormalizedTimeMixin ParseFromJson(JSONNode node) => default; // 0x0000000184989B70-0x0000000184989DC0
	// [XID] // 0x00000001897EC140-0x00000001897EC160
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C5A */, bool useObjectPool = false /* Metadata: 0x00AF5C5E */) => default; // 0x00000001849895A0-0x00000001849898A0
	// [XID] // 0x00000001897F3AF0-0x00000001897F3B10
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C5F */, bool useObjectPool = false /* Metadata: 0x00AF5C63 */) => default; // 0x0000000184988280-0x00000001849887A0
	// [XID] // 0x00000001897FB4F0-0x00000001897FB510
	public static new AttachToNormalizedTimeMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C64 */, bool useObjectPool = false /* Metadata: 0x00AF5C68 */) => default; // 0x0000000184988EC0-0x00000001849890E0
	[BlackList] // 0x0000000189802960-0x00000001898029A0
	// [XID] // 0x0000000189802960-0x00000001898029A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184987820-0x0000000184987AF0
	// [XID] // 0x000000018980CBD0-0x000000018980CBF0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184989FD0-0x000000018498A4B0
	[BlackList] // 0x0000000189814470-0x00000001898144B0
	// [XID] // 0x0000000189814470-0x00000001898144B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001849894B0-0x00000001849895A0
	// [XID] // 0x000000018981EFC0-0x000000018981EFE0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001849898A0-0x0000000184989980
	[BlackList] // 0x000000018982DB60-0x000000018982DBA0
	// [XID] // 0x000000018982DB60-0x000000018982DBA0
	public override void AutoAllocTypeFields() {} // 0x0000000184987AF0-0x0000000184987B90
	[BlackList] // 0x00000001898381A0-0x00000001898381E0
	// [XID] // 0x00000001898381A0-0x00000001898381E0
	public override void AutoRecycleTypeFields() {} // 0x0000000184987B90-0x0000000184987CA0
	[BlackList] // 0x0000000189842920-0x0000000189842960
	// [XID] // 0x0000000189842920-0x0000000189842960
	public override void ReturnToObjectPool() {} // 0x000000018498A770-0x000000018498A810
}

