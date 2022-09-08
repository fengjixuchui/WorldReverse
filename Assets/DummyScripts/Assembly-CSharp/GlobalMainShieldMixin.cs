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
public class GlobalMainShieldMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17055
{
	// Fields
	private string _shieldType; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _shieldAngle; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _shieldHPRatio; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _shieldHP; // 0x48
	private string _costShieldRatioName; // 0x50
	private string _showDamageText; // 0x58
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onShieldBroken; // 0x60
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _amountByGetDamage; // 0x68
	private string _effectPattern; // 0x70
	private string _childShieldModifierName; // 0x78
	private bool _targetMuteHitEffect; // 0x80
	private bool _infiniteShield; // 0x81
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _healLimitedByCasterMaxHPRatio; // 0x88
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _healLimitedByLocalCreatureMaxHPRatio; // 0x90

	// Properties
	public string shieldType { /* [XID] */ /* 0x00000001896DC8C0-0x00000001896DC8E0 */ get => default; /* [XID] */ /* 0x00000001896E4290-0x00000001896E42B0 */ private set {} } // 0x0000000184404ED0-0x0000000184404F70 0x00000001844070C0-0x0000000184407170
	public DynamicFloat shieldAngle { /* [XID] */ /* 0x00000001896EB680-0x00000001896EB6A0 */ get => default; /* [XID] */ /* 0x00000001896F2A90-0x00000001896F2AB0 */ private set {} } // 0x0000000184406920-0x00000001844069C0 0x0000000184407B90-0x0000000184407C40
	public DynamicFloat shieldHPRatio { /* [XID] */ /* 0x00000001896FA350-0x00000001896FA370 */ get => default; /* [XID] */ /* 0x0000000189701AC0-0x0000000189701AE0 */ private set {} } // 0x0000000184406B70-0x0000000184406C10 0x0000000184406060-0x0000000184406110
	public DynamicFloat shieldHP { /* [XID] */ /* 0x00000001897093E0-0x0000000189709400 */ get => default; /* [XID] */ /* 0x0000000189710CB0-0x0000000189710CD0 */ private set {} } // 0x00000001844035C0-0x0000000184403660 0x0000000184406C10-0x0000000184406CC0
	public string costShieldRatioName { /* [XID] */ /* 0x0000000189717F70-0x0000000189717F90 */ get => default; /* [XID] */ /* 0x000000018971F930-0x000000018971F950 */ private set {} } // 0x0000000184408C30-0x0000000184408CD0 0x0000000184404B70-0x0000000184404C20
	public string showDamageText { /* [XID] */ /* 0x0000000189726F60-0x0000000189726F80 */ get => default; /* [XID] */ /* 0x000000018972E530-0x000000018972E550 */ private set {} } // 0x0000000184408B90-0x0000000184408C30 0x0000000184404E20-0x0000000184404ED0
	public ConfigAbilityAction[] onShieldBroken { /* [XID] */ /* 0x0000000189735CA0-0x0000000189735CC0 */ get => default; /* [XID] */ /* 0x000000018973D890-0x000000018973D8B0 */ private set {} } // 0x0000000184408CD0-0x0000000184408D70 0x0000000184406870-0x0000000184406920
	public DynamicFloat amountByGetDamage { /* [XID] */ /* 0x0000000189744C90-0x0000000189744CB0 */ get => default; /* [XID] */ /* 0x000000018974C900-0x000000018974C920 */ private set {} } // 0x0000000184407AF0-0x0000000184407B90 0x00000001844077F0-0x00000001844078A0
	public string effectPattern { /* [XID] */ /* 0x0000000189753C20-0x0000000189753C40 */ get => default; /* [XID] */ /* 0x000000018975B160-0x000000018975B180 */ private set {} } // 0x0000000184406ED0-0x0000000184406F70 0x0000000184408D70-0x0000000184408E20
	public string childShieldModifierName { /* [XID] */ /* 0x0000000189762B70-0x0000000189762B90 */ get => default; /* [XID] */ /* 0x000000018976A150-0x000000018976A170 */ private set {} } // 0x0000000184405260-0x0000000184405300 0x0000000184407470-0x0000000184407520
	public bool targetMuteHitEffect { /* [XID] */ /* 0x0000000189771990-0x00000001897719B0 */ get => default; /* [XID] */ /* 0x00000001897790E0-0x0000000189779100 */ private set {} } // 0x00000001844076E0-0x0000000184407790 0x0000000184406A50-0x0000000184406B00
	public bool infiniteShield { /* [XID] */ /* 0x0000000189780880-0x00000001897808A0 */ get => default; /* [XID] */ /* 0x0000000189787F80-0x0000000189787FA0 */ private set {} } // 0x0000000184405020-0x00000001844050D0 0x00000001844061B0-0x0000000184406260
	public DynamicFloat healLimitedByCasterMaxHPRatio { /* [XID] */ /* 0x000000018978F5A0-0x000000018978F5C0 */ get => default; /* [XID] */ /* 0x0000000189796D50-0x0000000189796D70 */ private set {} } // 0x0000000184405130-0x00000001844051E0 0x0000000184404F70-0x0000000184405020
	public DynamicFloat healLimitedByLocalCreatureMaxHPRatio { /* [XID] */ /* 0x000000018979EE70-0x000000018979EE90 */ get => default; /* [XID] */ /* 0x00000001897A6460-0x00000001897A6480 */ private set {} } // 0x0000000184405F30-0x0000000184405FE0 0x0000000184404C20-0x0000000184404CD0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x000000018982AD10-0x000000018982AD30 */ get => default; } // 0x0000000184406110-0x00000001844061B0 

	// Constructors
	public GlobalMainShieldMixin() {} // 0x0000000184408EC0-0x0000000184408F60

	// Methods
	// [XID] // 0x00000001897AD9D0-0x00000001897AD9F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001844088C0-0x0000000184408B90
	// [XID] // 0x00000001897B5AF0-0x00000001897B5B10
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184407CA0-0x0000000184407EC0
	// [XID] // 0x00000001897BD840-0x00000001897BD860
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF61B3 */) => default; // 0x0000000184407600-0x00000001844076E0
	// [XID] // 0x00000001897C4BE0-0x00000001897C4C00
	public override int GetHashNum() => default; // 0x0000000184404D50-0x0000000184404E20
	// [XID] // 0x00000001897CC410-0x00000001897CC430
	public override void InitEmpty() {} // 0x0000000184406CC0-0x0000000184406E50
	[BlackList] // 0x00000001897D3D20-0x00000001897D3D60
	// [XID] // 0x00000001897D3D20-0x00000001897D3D60
	public override bool FromJson(JSONNode node) => default; // 0x0000000184406260-0x00000001844065E0
	// [XID] // 0x00000001897DE410-0x00000001897DE430
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184403660-0x00000001844043C0
	[BlackList] // 0x00000001897E5E90-0x00000001897E5ED0
	// [XID] // 0x00000001897E5E90-0x00000001897E5ED0
	public static new GlobalMainShieldMixin ParseFromJson(JSONNode node) => default; // 0x00000001844078A0-0x0000000184407AF0
	// [XID] // 0x00000001897F0A40-0x00000001897F0A60
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF61B4 */, bool useObjectPool = false /* Metadata: 0x00AF61B8 */) => default; // 0x0000000184407170-0x0000000184407470
	// [XID] // 0x00000001897F8160-0x00000001897F8180
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF61B9 */, bool useObjectPool = false /* Metadata: 0x00AF61BD */) => default; // 0x0000000184405300-0x0000000184405EB0
	// [XID] // 0x00000001897FF8F0-0x00000001897FF910
	public static new GlobalMainShieldMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF61BE */, bool useObjectPool = false /* Metadata: 0x00AF61C2 */) => default; // 0x0000000184406650-0x0000000184406870
	[BlackList] // 0x0000000189806FF0-0x0000000189807030
	// [XID] // 0x0000000189806FF0-0x0000000189807030
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001844043C0-0x0000000184404690
	// [XID] // 0x0000000189811580-0x00000001898115A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184407EC0-0x00000001844088C0
	[BlackList] // 0x00000001898190B0-0x00000001898190F0
	// [XID] // 0x00000001898190B0-0x00000001898190F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184406FD0-0x00000001844070C0
	// [XID] // 0x00000001898233B0-0x00000001898233D0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000184407520-0x0000000184407600
	[BlackList] // 0x0000000189832210-0x0000000189832250
	// [XID] // 0x0000000189832210-0x0000000189832250
	public override void AutoAllocTypeFields() {} // 0x0000000184404690-0x0000000184404730
	[BlackList] // 0x000000018983C8F0-0x000000018983C930
	// [XID] // 0x000000018983C8F0-0x000000018983C930
	public override void AutoRecycleTypeFields() {} // 0x0000000184404730-0x0000000184404AD0
	[BlackList] // 0x0000000189846E70-0x0000000189846EB0
	// [XID] // 0x0000000189846E70-0x0000000189846EB0
	public override void ReturnToObjectPool() {} // 0x0000000184408E20-0x0000000184408EC0
}

