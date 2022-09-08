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
public class AttachModifierToPredicateMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16898
{
	// Fields
	private AvatarStageType _type; // 0x30
	private OnEventType _onEvent; // 0x34
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _predicates; // 0x38
	private string _modifierName; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityStateToActions[] _onAbilityStateAdded; // 0x48
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityStateToActions[] _onAbilityStateRemoved; // 0x50

	// Properties
	public AvatarStageType type { /* [XID] */ /* 0x0000000189719B30-0x0000000189719B50 */ get => default; /* [XID] */ /* 0x00000001897210D0-0x00000001897210F0 */ private set {} } // 0x0000000181FB9CF0-0x0000000181FB9D90 0x0000000181FB9450-0x0000000181FB9500
	public OnEventType onEvent { /* [XID] */ /* 0x0000000189728750-0x0000000189728770 */ get => default; /* [XID] */ /* 0x000000018972FEC0-0x000000018972FEE0 */ private set {} } // 0x0000000181FB9A20-0x0000000181FB9AC0 0x0000000181FB9C40-0x0000000181FB9CF0
	public ConfigAbilityPredicate[] predicates { /* [XID] */ /* 0x0000000189737780-0x00000001897377A0 */ get => default; /* [XID] */ /* 0x000000018973F2A0-0x000000018973F2C0 */ private set {} } // 0x0000000181FB93B0-0x0000000181FB9450 0x0000000181FB8EC0-0x0000000181FB8F70
	public string modifierName { /* [XID] */ /* 0x00000001897465A0-0x00000001897465C0 */ get => default; /* [XID] */ /* 0x000000018974E070-0x000000018974E090 */ private set {} } // 0x0000000181FB9D90-0x0000000181FB9E30 0x0000000181FB8860-0x0000000181FB8910
	public ConfigAbilityStateToActions[] onAbilityStateAdded { /* [XID] */ /* 0x00000001897557B0-0x00000001897557D0 */ get => default; /* [XID] */ /* 0x000000018975CAB0-0x000000018975CAD0 */ private set {} } // 0x0000000181FB80B0-0x0000000181FB8150 0x0000000181FB85C0-0x0000000181FB8670
	public ConfigAbilityStateToActions[] onAbilityStateRemoved { /* [XID] */ /* 0x0000000189764260-0x0000000189764280 */ get => default; /* [XID] */ /* 0x000000018976BB20-0x000000018976BB40 */ private set {} } // 0x0000000181FB8370-0x0000000181FB8410 0x0000000181FB84A0-0x0000000181FB8550
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001897F0AC0-0x00000001897F0AE0 */ get => default; } // 0x0000000181FB7C20-0x0000000181FB7CC0 

	// Constructors
	public AttachModifierToPredicateMixin() {} // 0x0000000181FB9ED0-0x0000000181FB9F30

	// Methods
	// [XID] // 0x0000000189773040-0x0000000189773060
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181FB9AC0-0x0000000181FB9C40
	// [XID] // 0x000000018977A640-0x000000018977A660
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181FB9280-0x0000000181FB93B0
	// [XID] // 0x0000000189782220-0x0000000189782240
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5CE9 */) => default; // 0x0000000181FB8DE0-0x0000000181FB8EC0
	// [XID] // 0x00000001897895C0-0x00000001897895E0
	public override int GetHashNum() => default; // 0x0000000181FB7420-0x0000000181FB74F0
	// [XID] // 0x0000000189790CB0-0x0000000189790CD0
	public override void InitEmpty() {} // 0x0000000181FB8670-0x0000000181FB8780
	[BlackList] // 0x00000001897985A0-0x00000001897985E0
	// [XID] // 0x00000001897985A0-0x00000001897985E0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181FB7CC0-0x0000000181FB8040
	// [XID] // 0x00000001897A32C0-0x00000001897A32E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181FB6850-0x0000000181FB6EB0
	[BlackList] // 0x00000001897AA840-0x00000001897AA880
	// [XID] // 0x00000001897AA840-0x00000001897AA880
	public static new AttachModifierToPredicateMixin ParseFromJson(JSONNode node) => default; // 0x0000000181FB8FD0-0x0000000181FB9220
	// [XID] // 0x00000001897B5B50-0x00000001897B5B70
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5CEA */, bool useObjectPool = false /* Metadata: 0x00AF5CEE */) => default; // 0x0000000181FB8A00-0x0000000181FB8D00
	// [XID] // 0x00000001897BD900-0x00000001897BD920
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5CEF */, bool useObjectPool = false /* Metadata: 0x00AF5CF3 */) => default; // 0x0000000181FB75D0-0x0000000181FB7B20
	// [XID] // 0x00000001897C4C80-0x00000001897C4CA0
	public static new AttachModifierToPredicateMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5CF4 */, bool useObjectPool = false /* Metadata: 0x00AF5CF8 */) => default; // 0x0000000181FB8150-0x0000000181FB8370
	[BlackList] // 0x00000001897CC430-0x00000001897CC470
	// [XID] // 0x00000001897CC430-0x00000001897CC470
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181FB6EB0-0x0000000181FB7180
	// [XID] // 0x00000001897D6DE0-0x00000001897D6E00
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181FB9500-0x0000000181FB9A20
	[BlackList] // 0x00000001897DE490-0x00000001897DE4D0
	// [XID] // 0x00000001897DE490-0x00000001897DE4D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181FB8910-0x0000000181FB8A00
	// [XID] // 0x00000001897E8ED0-0x00000001897E8EF0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000181FB8D00-0x0000000181FB8DE0
	[BlackList] // 0x00000001897F8240-0x00000001897F8280
	// [XID] // 0x00000001897F8240-0x00000001897F8280
	public override void AutoAllocTypeFields() {} // 0x0000000181FB7180-0x0000000181FB7220
	[BlackList] // 0x0000000189802920-0x0000000189802960
	// [XID] // 0x0000000189802920-0x0000000189802960
	public override void AutoRecycleTypeFields() {} // 0x0000000181FB7220-0x0000000181FB7300
	[BlackList] // 0x000000018980CB90-0x000000018980CBD0
	// [XID] // 0x000000018980CB90-0x000000018980CBD0
	public override void ReturnToObjectPool() {} // 0x0000000181FB9E30-0x0000000181FB9ED0
}

