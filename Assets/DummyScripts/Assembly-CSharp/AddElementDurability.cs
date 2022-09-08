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
public class AddElementDurability : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16595
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _value; // 0x68
	private string _modifierName; // 0x70
	private ElementType _elementType; // 0x78
	private SortModifierType _sortModifier; // 0x7C
	private bool _useLimitRange; // 0x80
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _maxValue; // 0x88
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _minValue; // 0x90

	// Properties
	public DynamicFloat value { /* [XID] */ /* 0x0000000189989780-0x00000001899897A0 */ get => default; /* [XID] */ /* 0x0000000189990FF0-0x0000000189991010 */ private set {} } // 0x0000000185B2D840-0x0000000185B2D8E0 0x0000000185B2D710-0x0000000185B2D7C0
	public string modifierName { /* [XID] */ /* 0x0000000189998A70-0x0000000189998A90 */ get => default; /* [XID] */ /* 0x00000001899A03B0-0x00000001899A03D0 */ private set {} } // 0x0000000185B2F9C0-0x0000000185B2FA60 0x0000000185B2E480-0x0000000185B2E530
	public ElementType elementType { /* [XID] */ /* 0x00000001899A7F80-0x00000001899A7FA0 */ get => default; /* [XID] */ /* 0x00000001899AF5D0-0x00000001899AF5F0 */ private set {} } // 0x0000000185B2D5F0-0x0000000185B2D690 0x0000000185B2EB10-0x0000000185B2EBC0
	public SortModifierType sortModifier { /* [XID] */ /* 0x00000001899B6B10-0x00000001899B6B30 */ get => default; /* [XID] */ /* 0x00000001899BE5F0-0x00000001899BE610 */ private set {} } // 0x0000000185B2E050-0x0000000185B2E0F0 0x0000000185B2DD10-0x0000000185B2DDC0
	public bool useLimitRange { /* [XID] */ /* 0x00000001899C5DD0-0x00000001899C5DF0 */ get => default; /* [XID] */ /* 0x00000001899CD510-0x00000001899CD530 */ private set {} } // 0x0000000185B2CDB0-0x0000000185B2CE60 0x0000000185B2F6A0-0x0000000185B2F750
	public DynamicFloat maxValue { /* [XID] */ /* 0x00000001899D4A10-0x00000001899D4A30 */ get => default; /* [XID] */ /* 0x00000001899DC010-0x00000001899DC030 */ private set {} } // 0x0000000185B2E160-0x0000000185B2E210 0x0000000185B2CBB0-0x0000000185B2CC60
	public DynamicFloat minValue { /* [XID] */ /* 0x00000001899E3990-0x00000001899E39B0 */ get => default; /* [XID] */ /* 0x00000001899EADC0-0x00000001899EADE0 */ private set {} } // 0x0000000185B2EA60-0x0000000185B2EB10 0x0000000185B2D8E0-0x0000000185B2D990
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189A75970-0x0000000189A75990 */ get => default; } // 0x0000000185B2EE10-0x0000000185B2EEB0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189A7D610-0x0000000189A7D630 */ get => default; } // 0x0000000185B2E210-0x0000000185B2E2B0 

	// Constructors
	public AddElementDurability() {} // 0x0000000185B2FB00-0x0000000185B2FBB0

	// Methods
	// [XID] // 0x00000001899F29C0-0x00000001899F29E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185B2F750-0x0000000185B2F920
	// [XID] // 0x00000001899F9F30-0x00000001899F9F50
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000185B2EF10-0x0000000185B2F040
	// [XID] // 0x0000000189A01330-0x0000000189A01350
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF404A */) => default; // 0x0000000185B2E920-0x0000000185B2EA00
	// [XID] // 0x0000000189A08C90-0x0000000189A08CB0
	public override int GetHashNum() => default; // 0x0000000185B2CAE0-0x0000000185B2CBB0
	// [XID] // 0x0000000189A101F0-0x0000000189A10210
	public override void InitEmpty() {} // 0x0000000185B2E2B0-0x0000000185B2E3A0
	[BlackList] // 0x0000000189A177D0-0x0000000189A17810
	// [XID] // 0x0000000189A177D0-0x0000000189A17810
	public override bool FromJson(JSONNode node) => default; // 0x0000000185B2D990-0x0000000185B2DD10
	// [XID] // 0x0000000189A21EF0-0x0000000189A21F10
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000185B2BCB0-0x0000000185B2C3B0
	[BlackList] // 0x0000000189A29300-0x0000000189A29340
	// [XID] // 0x0000000189A29300-0x0000000189A29340
	public static new AddElementDurability ParseFromJson(JSONNode node) => default; // 0x0000000185B2EBC0-0x0000000185B2EE10
	// [XID] // 0x0000000189A338E0-0x0000000189A33900
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF404B */, bool useObjectPool = false /* Metadata: 0x00AF404F */) => default; // 0x0000000185B2E620-0x0000000185B2E920
	// [XID] // 0x0000000189A3B080-0x0000000189A3B0A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4050 */, bool useObjectPool = false /* Metadata: 0x00AF4054 */) => default; // 0x0000000185B2CE60-0x0000000185B2D490
	// [XID] // 0x0000000189A429D0-0x0000000189A429F0
	public static new AddElementDurability ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4055 */, bool useObjectPool = false /* Metadata: 0x00AF4059 */) => default; // 0x0000000185B2DDC0-0x0000000185B2DFE0
	[BlackList] // 0x0000000189A49E80-0x0000000189A49EC0
	// [XID] // 0x0000000189A49E80-0x0000000189A49EC0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000185B2C3B0-0x0000000185B2C680
	// [XID] // 0x0000000189A547F0-0x0000000189A54810
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185B2F120-0x0000000185B2F6A0
	[BlackList] // 0x0000000189A5C220-0x0000000189A5C260
	// [XID] // 0x0000000189A5C220-0x0000000189A5C260
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000185B2E530-0x0000000185B2E620
	// [XID] // 0x0000000189A66A40-0x0000000189A66A60
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000185B2F920-0x0000000185B2F9C0
	// [XID] // 0x0000000189A6E360-0x0000000189A6E380
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000185B2D490-0x0000000185B2D5F0
	[BlackList] // 0x0000000189A84D40-0x0000000189A84D80
	// [XID] // 0x0000000189A84D40-0x0000000189A84D80
	public override void AutoAllocTypeFields() {} // 0x0000000185B2C680-0x0000000185B2C720
	[BlackList] // 0x0000000189A8F750-0x0000000189A8F790
	// [XID] // 0x0000000189A8F750-0x0000000189A8F790
	public override void AutoRecycleTypeFields() {} // 0x0000000185B2C720-0x0000000185B2C950
	[BlackList] // 0x0000000189A9A040-0x0000000189A9A080
	// [XID] // 0x0000000189A9A040-0x0000000189A9A080
	public override void ReturnToObjectPool() {} // 0x0000000185B2FA60-0x0000000185B2FB00
}

