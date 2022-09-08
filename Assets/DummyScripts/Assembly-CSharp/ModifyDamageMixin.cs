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
public class ModifyDamageMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16986
{
	// Fields
	private string[] _animEventNames; // 0x30
	private string[] _attackTags; // 0x38
	private AttackType _attackType; // 0x40
	private bool _ignoreEventInfo; // 0x44
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _damagePercentage; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _damagePercentageRatio; // 0x50
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _damageExtra; // 0x58
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _bonusCritical; // 0x60
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _bonusCriticalHurt; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ElementTypeModifier _elementTypeModifier; // 0x70
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _predicates; // 0x78
	private bool _trueDamage; // 0x80

	// Properties
	public string[] animEventNames { /* [XID] */ /* 0x0000000189713B80-0x0000000189713BA0 */ get => default; /* [XID] */ /* 0x000000018971B3E0-0x000000018971B400 */ private set {} } // 0x0000000181081CE0-0x0000000181081D80 0x0000000181085C30-0x0000000181085CE0
	public string[] attackTags { /* [XID] */ /* 0x0000000189722640-0x0000000189722660 */ get => default; /* [XID] */ /* 0x0000000189729DA0-0x0000000189729DC0 */ private set {} } // 0x0000000181083400-0x00000001810834A0 0x0000000181082D40-0x0000000181082DF0
	public AttackType attackType { /* [XID] */ /* 0x00000001897314A0-0x00000001897314C0 */ get => default; /* [XID] */ /* 0x0000000189738CF0-0x0000000189738D10 */ private set {} } // 0x0000000181084BE0-0x0000000181084C80 0x00000001810836D0-0x0000000181083780
	public bool ignoreEventInfo { /* [XID] */ /* 0x0000000189740AE0-0x0000000189740B00 */ get => default; /* [XID] */ /* 0x0000000189747EE0-0x0000000189747F00 */ private set {} } // 0x0000000181085AF0-0x0000000181085B90 0x0000000181084CF0-0x0000000181084DA0
	public DynamicFloat damagePercentage { /* [XID] */ /* 0x000000018974F650-0x000000018974F670 */ get => default; /* [XID] */ /* 0x0000000189756CA0-0x0000000189756CC0 */ private set {} } // 0x0000000181086A40-0x0000000181086AE0 0x0000000181084810-0x00000001810848C0
	public DynamicFloat damagePercentageRatio { /* [XID] */ /* 0x000000018975E170-0x000000018975E190 */ get => default; /* [XID] */ /* 0x0000000189765910-0x0000000189765930 */ private set {} } // 0x00000001810841A0-0x0000000181084240 0x0000000181084FE0-0x0000000181085090
	public DynamicFloat damageExtra { /* [XID] */ /* 0x000000018976D1C0-0x000000018976D1E0 */ get => default; /* [XID] */ /* 0x00000001897745D0-0x00000001897745F0 */ private set {} } // 0x0000000181085B90-0x0000000181085C30 0x00000001810856F0-0x00000001810857A0
	public DynamicFloat bonusCritical { /* [XID] */ /* 0x000000018977BFE0-0x000000018977C000 */ get => default; /* [XID] */ /* 0x00000001897838B0-0x00000001897838D0 */ private set {} } // 0x0000000181082920-0x00000001810829C0 0x00000001810843E0-0x0000000181084490
	public DynamicFloat bonusCriticalHurt { /* [XID] */ /* 0x000000018978B0C0-0x000000018978B0E0 */ get => default; /* [XID] */ /* 0x0000000189792620-0x0000000189792640 */ private set {} } // 0x00000001810835B0-0x0000000181083650 0x00000001810829C0-0x0000000181082A70
	public ElementTypeModifier elementTypeModifier { /* [XID] */ /* 0x0000000189799BD0-0x0000000189799BF0 */ get => default; /* [XID] */ /* 0x00000001897A1A40-0x00000001897A1A60 */ private set {} } // 0x0000000181085800-0x00000001810858A0 0x0000000181085CE0-0x0000000181085D90
	public ConfigAbilityPredicate[] predicates { /* [XID] */ /* 0x00000001897A92C0-0x00000001897A92E0 */ get => default; /* [XID] */ /* 0x00000001897B0AA0-0x00000001897B0AC0 */ private set {} } // 0x0000000181085FB0-0x0000000181086050 0x0000000181085640-0x00000001810856F0
	public bool trueDamage { /* [XID] */ /* 0x00000001897B8800-0x00000001897B8820 */ get => default; /* [XID] */ /* 0x00000001897C0860-0x00000001897C0880 */ private set {} } // 0x0000000181086050-0x0000000181086100 0x00000001810834A0-0x0000000181083550
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189844080-0x00000001898440A0 */ get => default; } // 0x0000000181084340-0x00000001810843E0 

	// Constructors
	public ModifyDamageMixin() {} // 0x0000000181086E20-0x0000000181086EC0

	// Methods
	// [XID] // 0x00000001897C8130-0x00000001897C8150
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181086AE0-0x0000000181086D80
	// [XID] // 0x00000001897CF4F0-0x00000001897CF510
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181085DF0-0x0000000181085FB0
	// [XID] // 0x00000001897D6DA0-0x00000001897D6DC0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5F95 */) => default; // 0x0000000181085560-0x0000000181085640
	// [XID] // 0x00000001897DE450-0x00000001897DE470
	public override int GetHashNum() => default; // 0x0000000181083330-0x0000000181083400
	// [XID] // 0x00000001897E5F10-0x00000001897E5F30
	public override void InitEmpty() {} // 0x0000000181084DA0-0x0000000181084F00
	[BlackList] // 0x00000001897ED8B0-0x00000001897ED8F0
	// [XID] // 0x00000001897ED8B0-0x00000001897ED8F0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181084490-0x0000000181084810
	// [XID] // 0x00000001897F81E0-0x00000001897F8200
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181081D80-0x0000000181082920
	[BlackList] // 0x00000001897FF930-0x00000001897FF970
	// [XID] // 0x00000001897FF930-0x00000001897FF970
	public static new ModifyDamageMixin ParseFromJson(JSONNode node) => default; // 0x00000001810858A0-0x0000000181085AF0
	// [XID] // 0x0000000189809EF0-0x0000000189809F10
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F96 */, bool useObjectPool = false /* Metadata: 0x00AF5F9A */) => default; // 0x0000000181085180-0x0000000181085480
	// [XID] // 0x00000001898115C0-0x00000001898115E0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F9B */, bool useObjectPool = false /* Metadata: 0x00AF5F9F */) => default; // 0x0000000181083780-0x00000001810841A0
	// [XID] // 0x0000000189819130-0x0000000189819150
	public static new ModifyDamageMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5FA0 */, bool useObjectPool = false /* Metadata: 0x00AF5FA4 */) => default; // 0x0000000181084930-0x0000000181084B50
	[BlackList] // 0x00000001898208D0-0x0000000189820910
	// [XID] // 0x00000001898208D0-0x0000000189820910
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181082A70-0x0000000181082D40
	// [XID] // 0x000000018982AD70-0x000000018982AD90
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181086100-0x0000000181086A40
	[BlackList] // 0x0000000189832250-0x0000000189832290
	// [XID] // 0x0000000189832250-0x0000000189832290
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181085090-0x0000000181085180
	// [XID] // 0x000000018983C950-0x000000018983C970
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000181085480-0x0000000181085560
	[BlackList] // 0x000000018984B470-0x000000018984B4B0
	// [XID] // 0x000000018984B470-0x000000018984B4B0
	public override void AutoAllocTypeFields() {} // 0x0000000181082DF0-0x0000000181082E90
	[BlackList] // 0x00000001898555D0-0x0000000189855610
	// [XID] // 0x00000001898555D0-0x0000000189855610
	public override void AutoRecycleTypeFields() {} // 0x0000000181082E90-0x0000000181083210
	[BlackList] // 0x000000018985F910-0x000000018985F950
	// [XID] // 0x000000018985F910-0x000000018985F950
	public override void ReturnToObjectPool() {} // 0x0000000181086D80-0x0000000181086E20
}

