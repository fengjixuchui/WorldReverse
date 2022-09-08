/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigAbilityModifier : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17171
{
	// Fields
	private ModifierTimeScale _timeScale; // 0x10
	private ModifierStacking _stacking; // 0x14
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigModifierStackingOption _stackingOption; // 0x18
	private bool _isBuff; // 0x20
	private bool _isDebuff; // 0x21
	private string _modifierName; // 0x28
	private bool _isUnique; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _duration; // 0x38
	private ElementType _elementType; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _elementDurability; // 0x48
	private SimpleSafeFloat maxElementDurabilityRawNum; // 0x50
	private SimpleSafeFloat purgeIncrementRawNum; // 0x54
	private bool _isElementDurabilityMutable; // 0x58
	private bool _forceTriggerBurning; // 0x59
	private bool _overrideWeaponElement; // 0x5A
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _thinkInterval; // 0x60
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityMixin[] _modifierMixins; // 0x68
	private bool _trimThinkInterval; // 0x70
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, DynamicFloat> _properties; // 0x78
	private AbilityState _state; // 0x80
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAbilityStateOption _stateOption; // 0x88
	private bool _muteStateDisplayEffect; // 0x90
	private bool _applyAttackerWitchTimeRatio; // 0x91
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onAdded; // 0x98
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onRemoved; // 0xA0
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onBeingHit; // 0xA8
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onAttackLanded; // 0xB0
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onHittingOther; // 0xB8
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onThinkInterval; // 0xC0
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onKill; // 0xC8
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onCrash; // 0xD0
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onAvatarIn; // 0xD8
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onAvatarOut; // 0xE0
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onReconnect; // 0xE8
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onChangeAuthority; // 0xF0
	private EntityType[] _forbiddenEntities; // 0xF8
	private bool _fireEventWhenApply; // 0x100
	private bool _isDurabilityGlobal; // 0x101
	private bool _tickThinkIntervalAfterDie; // 0x102
	private bool _thinkIntervalIgnoreTimeScale; // 0x103
	private bool _reduceDurablityIgnoreTimeScale; // 0x104
	private bool _isLimitedProperties; // 0x105
	private bool _forceSyncToRemote; // 0x106
	private SimpleSafeInt32 buffIDRawNum; // 0x108
	public static Dictionary<string, DynamicFloat> EMPTY_PROPERTIES; // 0x00
	[NonSerialized]
	public int fullNameHashCode; // 0x10C
	[NonSerialized]
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	public int configLocalID; // 0x110
	[NonSerialized]
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	public ModifierMPBehavior mpBehavior; // 0x114
	public bool isAuthorityOnly; // 0x118

	// Properties
	public ModifierTimeScale timeScale { /* [XID] */ /* 0x000000018992FF90-0x000000018992FFB0 */ get => default; /* [XID] */ /* 0x0000000189891BA0-0x0000000189891BC0 */ private set {} } // 0x0000000184197930-0x00000001841979D0 0x000000018419BE10-0x000000018419BEC0
	public ModifierStacking stacking { /* [XID] */ /* 0x0000000189733580-0x00000001897335A0 */ get => default; /* [XID] */ /* 0x00000001898A06D0-0x00000001898A06F0 */ set {} } // 0x000000018419B9B0-0x000000018419BA50 0x000000018419B4F0-0x000000018419B5A0
	public ConfigModifierStackingOption stackingOption { /* [XID] */ /* 0x000000018993EFC0-0x000000018993EFE0 */ get => default; /* [XID] */ /* 0x00000001898AF8B0-0x00000001898AF8D0 */ private set {} } // 0x000000018419B650-0x000000018419B6F0 0x000000018419E420-0x000000018419E4D0
	public bool isBuff { /* [XID] */ /* 0x00000001898B6E30-0x00000001898B6E50 */ get => default; /* [XID] */ /* 0x00000001898BE500-0x00000001898BE520 */ set {} } // 0x00000001841969C0-0x0000000184196A60 0x00000001841973D0-0x0000000184197480
	public bool isDebuff { /* [XID] */ /* 0x00000001898C5CF0-0x00000001898C5D10 */ get => default; /* [XID] */ /* 0x00000001898CD4E0-0x00000001898CD500 */ set {} } // 0x000000018419C520-0x000000018419C5C0 0x000000018419E370-0x000000018419E420
	public string modifierName { /* [XID] */ /* 0x00000001898D4EF0-0x00000001898D4F10 */ get => default; /* [XID] */ /* 0x00000001898DC890-0x00000001898DC8B0 */ set {} } // 0x000000018419F230-0x000000018419F2D0 0x000000018419ABA0-0x000000018419AC50
	public bool isUnique { /* [XID] */ /* 0x00000001898E4300-0x00000001898E4320 */ get => default; /* [XID] */ /* 0x00000001898EBD10-0x00000001898EBD30 */ private set {} } // 0x000000018419A830-0x000000018419A8D0 0x0000000184197060-0x0000000184197110
	public DynamicFloat duration { /* [XID] */ /* 0x00000001898F35E0-0x00000001898F3600 */ get => default; /* [XID] */ /* 0x00000001898FAB80-0x00000001898FABA0 */ private set {} } // 0x0000000184196FC0-0x0000000184197060 0x00000001841996E0-0x0000000184199790
	public ElementType elementType { /* [XID] */ /* 0x0000000189902760-0x0000000189902780 */ get => default; /* [XID] */ /* 0x0000000189909D60-0x0000000189909D80 */ private set {} } // 0x00000001841999A0-0x0000000184199A40 0x000000018419B6F0-0x000000018419B7A0
	public DynamicFloat elementDurability { /* [XID] */ /* 0x00000001899115C0-0x00000001899115E0 */ get => default; /* [XID] */ /* 0x0000000189919160-0x0000000189919180 */ private set {} } // 0x000000018419B2F0-0x000000018419B390 0x000000018419A570-0x000000018419A620
	public float maxElementDurability { /* [XID] */ /* 0x00000001899206F0-0x0000000189920710 */ get => default; /* [XID] */ /* 0x0000000189928070-0x0000000189928090 */ private set {} } // 0x000000018419C440-0x000000018419C520 0x0000000184193E10-0x0000000184193EF0
	public float purgeIncrement { /* [XID] */ /* 0x0000000189A4F1D0-0x0000000189A4F1F0 */ get => default; /* [XID] */ /* 0x0000000189936B30-0x0000000189936B50 */ private set {} } // 0x000000018419AE60-0x000000018419AF40 0x000000018419A490-0x000000018419A570
	public bool isElementDurabilityMutable { /* [XID] */ /* 0x0000000189A567E0-0x0000000189A56800 */ get => default; /* [XID] */ /* 0x0000000189945D20-0x0000000189945D40 */ private set {} } // 0x000000018419C3A0-0x000000018419C440 0x0000000184199840-0x00000001841998F0
	public bool forceTriggerBurning { /* [XID] */ /* 0x0000000189A5E460-0x0000000189A5E480 */ get => default; /* [XID] */ /* 0x0000000189954980-0x00000001899549A0 */ private set {} } // 0x000000018419A290-0x000000018419A330 0x000000018419A130-0x000000018419A1E0
	public bool overrideWeaponElement { /* [XID] */ /* 0x0000000189A65C40-0x0000000189A65C60 */ get => default; /* [XID] */ /* 0x0000000189963BA0-0x0000000189963BC0 */ private set {} } // 0x0000000184193D70-0x0000000184193E10 0x000000018419A6D0-0x000000018419A780
	public DynamicFloat thinkInterval { /* [XID] */ /* 0x000000018996B170-0x000000018996B190 */ get => default; /* [XID] */ /* 0x0000000189972BD0-0x0000000189972BF0 */ private set {} } // 0x0000000184197730-0x00000001841977D0 0x000000018419C0C0-0x000000018419C170
	public ConfigAbilityMixin[] modifierMixins { /* [XID] */ /* 0x00000001897F1460-0x00000001897F1480 */ get => default; /* [XID] */ /* 0x0000000189981DA0-0x0000000189981DC0 */ private set {} } // 0x000000018419C5C0-0x000000018419C660 0x0000000184197320-0x00000001841973D0
	public bool trimThinkInterval { /* [XID] */ /* 0x0000000189A74B20-0x0000000189A74B40 */ get => default; /* [XID] */ /* 0x0000000189990ED0-0x0000000189990EF0 */ private set {} } // 0x000000018419BF70-0x000000018419C010 0x000000018419B7A0-0x000000018419B850
	public Dictionary<string, DynamicFloat> properties { /* [XID] */ /* 0x00000001899988D0-0x00000001899988F0 */ get => default; /* [XID] */ /* 0x00000001899A0270-0x00000001899A0290 */ set {} } // 0x0000000184197480-0x0000000184197520 0x000000018419AC50-0x000000018419AD00
	public AbilityState state { /* [XID] */ /* 0x0000000189AFC4D0-0x0000000189AFC4F0 */ get => default; /* [XID] */ /* 0x00000001899AF530-0x00000001899AF550 */ private set {} } // 0x00000001841998F0-0x00000001841999A0 0x00000001841964E0-0x0000000184196590
	public ConfigAbilityStateOption stateOption { /* [XID] */ /* 0x00000001899B6A50-0x00000001899B6A70 */ get => default; /* [XID] */ /* 0x00000001899BE4F0-0x00000001899BE510 */ private set {} } // 0x0000000184199A40-0x0000000184199AF0 0x0000000184199FD0-0x000000018419A080
	public bool muteStateDisplayEffect { /* [XID] */ /* 0x0000000189A7C530-0x0000000189A7C550 */ get => default; /* [XID] */ /* 0x00000001899CD470-0x00000001899CD490 */ private set {} } // 0x000000018419A330-0x000000018419A3E0 0x0000000184197880-0x0000000184197930
	public bool applyAttackerWitchTimeRatio { /* [XID] */ /* 0x00000001899D48D0-0x00000001899D48F0 */ get => default; /* [XID] */ /* 0x00000001899DBF90-0x00000001899DBFB0 */ private set {} } // 0x00000001841977D0-0x0000000184197880 0x000000018419BEC0-0x000000018419BF70
	public ConfigAbilityAction[] onAdded { /* [XID] */ /* 0x0000000189B80B40-0x0000000189B80B60 */ get => default; /* [XID] */ /* 0x00000001899EACC0-0x00000001899EACE0 */ private set {} } // 0x000000018419B850-0x000000018419B900 0x0000000184199AF0-0x0000000184199BA0
	public ConfigAbilityAction[] onRemoved { /* [XID] */ /* 0x00000001896C86F0-0x00000001896C8710 */ get => default; /* [XID] */ /* 0x00000001899F9E30-0x00000001899F9E50 */ private set {} } // 0x000000018419EEC0-0x000000018419EF70 0x000000018419ED60-0x000000018419EE10
	public ConfigAbilityAction[] onBeingHit { /* [XID] */ /* 0x0000000189A01250-0x0000000189A01270 */ get => default; /* [XID] */ /* 0x0000000189A08BF0-0x0000000189A08C10 */ private set {} } // 0x0000000184199790-0x0000000184199840 0x000000018419F180-0x000000018419F230
	public ConfigAbilityAction[] onAttackLanded { /* [XID] */ /* 0x00000001896ED6B0-0x00000001896ED6D0 */ get => default; /* [XID] */ /* 0x0000000189A17630-0x0000000189A17650 */ private set {} } // 0x000000018419B390-0x000000018419B440 0x0000000184197520-0x00000001841975D0
	public ConfigAbilityAction[] onHittingOther { /* [XID] */ /* 0x0000000189A1ED90-0x0000000189A1EDB0 */ get => default; /* [XID] */ /* 0x0000000189A26400-0x0000000189A26420 */ private set {} } // 0x000000018419B5A0-0x000000018419B650 0x0000000184197270-0x0000000184197320
	public ConfigAbilityAction[] onThinkInterval { /* [XID] */ /* 0x0000000189A2D6D0-0x0000000189A2D6F0 */ get => default; /* [XID] */ /* 0x0000000189A35210-0x0000000189A35230 */ private set {} } // 0x0000000184197110-0x00000001841971C0 0x0000000184196590-0x0000000184196640
	public ConfigAbilityAction[] onKill { /* [XID] */ /* 0x0000000189A3C7A0-0x0000000189A3C7C0 */ get => default; /* [XID] */ /* 0x0000000189A44230-0x0000000189A44250 */ private set {} } // 0x000000018419ECB0-0x000000018419ED60 0x0000000184196910-0x00000001841969C0
	public ConfigAbilityAction[] onCrash { /* [XID] */ /* 0x0000000189A4B740-0x0000000189A4B760 */ get => default; /* [XID] */ /* 0x0000000189A52EC0-0x0000000189A52EE0 */ private set {} } // 0x000000018419A080-0x000000018419A130 0x000000018419B240-0x000000018419B2F0
	public ConfigAbilityAction[] onAvatarIn { /* [XID] */ /* 0x0000000189712BD0-0x0000000189712BF0 */ get => default; /* [XID] */ /* 0x0000000189A61E50-0x0000000189A61E70 */ private set {} } // 0x000000018419A780-0x000000018419A830 0x000000018419B440-0x000000018419B4F0
	public ConfigAbilityAction[] onAvatarOut { /* [XID] */ /* 0x000000018971A5B0-0x000000018971A5D0 */ get => default; /* [XID] */ /* 0x0000000189A70FE0-0x0000000189A71000 */ private set {} } // 0x000000018419A3E0-0x000000018419A490 0x000000018419BA50-0x000000018419BB00
	public ConfigAbilityAction[] onReconnect { /* [XID] */ /* 0x0000000189A78C00-0x0000000189A78C20 */ get => default; /* [XID] */ /* 0x0000000189A800E0-0x0000000189A80100 */ private set {} } // 0x0000000184199F20-0x0000000184199FD0 0x000000018419C2F0-0x000000018419C3A0
	public ConfigAbilityAction[] onChangeAuthority { /* [XID] */ /* 0x0000000189A87DA0-0x0000000189A87DC0 */ get => default; /* [XID] */ /* 0x0000000189A8F5F0-0x0000000189A8F610 */ private set {} } // 0x000000018419F020-0x000000018419F0D0 0x000000018419EF70-0x000000018419F020
	public EntityType[] forbiddenEntities { /* [XID] */ /* 0x0000000189AB82A0-0x0000000189AB82C0 */ get => default; /* [XID] */ /* 0x0000000189A9DFD0-0x0000000189A9DFF0 */ private set {} } // 0x000000018419EE10-0x000000018419EEC0 0x0000000184197680-0x0000000184197730
	public bool fireEventWhenApply { /* [XID] */ /* 0x0000000189AA59E0-0x0000000189AA5A00 */ get => default; /* [XID] */ /* 0x0000000189AAD040-0x0000000189AAD060 */ private set {} } // 0x000000018419C170-0x000000018419C220 0x00000001841975D0-0x0000000184197680
	public bool isDurabilityGlobal { /* [XID] */ /* 0x0000000189ACEEB0-0x0000000189ACEED0 */ get => default; /* [XID] */ /* 0x0000000189ABC740-0x0000000189ABC760 */ private set {} } // 0x0000000184199630-0x00000001841996E0 0x0000000184193CC0-0x0000000184193D70
	public bool tickThinkIntervalAfterDie { /* [XID] */ /* 0x0000000189AC4000-0x0000000189AC4020 */ get => default; /* [XID] */ /* 0x0000000189ACB4F0-0x0000000189ACB510 */ private set {} } // 0x0000000184196430-0x00000001841964E0 0x000000018419B900-0x000000018419B9B0
	public bool thinkIntervalIgnoreTimeScale { /* [XID] */ /* 0x0000000189AD2F40-0x0000000189AD2F60 */ get => default; /* [XID] */ /* 0x0000000189ADA9C0-0x0000000189ADA9E0 */ private set {} } // 0x000000018419A1E0-0x000000018419A290 0x000000018419AD00-0x000000018419ADB0
	public bool reduceDurablityIgnoreTimeScale { /* [XID] */ /* 0x0000000189AE6080-0x0000000189AE60A0 */ get => default; /* [XID] */ /* 0x0000000189AE9B10-0x0000000189AE9B30 */ private set {} } // 0x000000018419A620-0x000000018419A6D0 0x00000001841971C0-0x0000000184197270
	public bool isLimitedProperties { /* [XID] */ /* 0x0000000189AED590-0x0000000189AED5B0 */ get => default; /* [XID] */ /* 0x0000000189AF8F90-0x0000000189AF8FB0 */ private set {} } // 0x000000018419C010-0x000000018419C0C0 0x000000018419F0D0-0x000000018419F180
	public bool forceSyncToRemote { /* [XID] */ /* 0x0000000189B00570-0x0000000189B00590 */ get => default; /* [XID] */ /* 0x0000000189B07A30-0x0000000189B07A50 */ private set {} } // 0x000000018419EC00-0x000000018419ECB0 0x000000018419ADB0-0x000000018419AE60
	public int buffID { /* [XID] */ /* 0x0000000189B0F2B0-0x0000000189B0F2D0 */ get => default; /* [XID] */ /* 0x0000000189B16610-0x0000000189B16630 */ private set {} } // 0x000000018419C220-0x000000018419C2F0 0x000000018419E4D0-0x000000018419E5B0

	// Nested types
	public enum ModifierMPBehavior // TypeDefIndex: 17172
	{
		NormallySynced = 0,
		MuteRemoteAuthorityOnly = 1
	}

	// Constructors
	public ConfigAbilityModifier() {} // 0x000000018419F400-0x000000018419F550
	static ConfigAbilityModifier() {} // 0x000000018419F370-0x000000018419F400

	// Methods
	// [XID] // 0x0000000189A61110-0x0000000189A61130
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018419E5B0-0x000000018419EAC0
	// [XID] // 0x0000000189B254C0-0x0000000189B254E0
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018419BB00-0x000000018419BE10
	// [XID] // 0x0000000189B2CA70-0x0000000189B2CA90
	public virtual void InitEmpty() {} // 0x000000018419A8D0-0x000000018419ABA0
	[BlackList] // 0x0000000189B33E80-0x0000000189B33EC0
	// [XID] // 0x0000000189B33E80-0x0000000189B33EC0
	public bool FromJson(JSONNode node) => default; // 0x0000000184199BA0-0x0000000184199F20
	// [XID] // 0x00000001899FAA90-0x00000001899FAAB0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184193EF0-0x0000000184196430
	// [XID] // 0x0000000189634D00-0x0000000189634D20
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF657B */, bool useObjectPool = false /* Metadata: 0x00AF657F */) => default; // 0x000000018419AF40-0x000000018419B240
	// [XID] // 0x0000000189B4D860-0x0000000189B4D880
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6580 */, bool useObjectPool = false /* Metadata: 0x00AF6584 */) => default; // 0x00000001841979D0-0x0000000184199630
	[BlackList] // 0x0000000189B55130-0x0000000189B55170
	// [XID] // 0x0000000189B55130-0x0000000189B55170
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184196640-0x0000000184196910
	// [XID] // 0x0000000189B5FD20-0x0000000189B5FD40
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018419C660-0x000000018419E370
	[BlackList] // 0x0000000189B673A0-0x0000000189B673E0
	// [XID] // 0x0000000189B673A0-0x0000000189B673E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184196A60-0x0000000184196B00
	[BlackList] // 0x0000000189B719D0-0x0000000189B71A10
	// [XID] // 0x0000000189B719D0-0x0000000189B71A10
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184196B00-0x0000000184196FC0
	[BlackList] // 0x0000000189B7BD10-0x0000000189B7BD50
	// [XID] // 0x0000000189B7BD10-0x0000000189B7BD50
	public virtual void ReturnToObjectPool() {} // 0x000000018419F2D0-0x000000018419F370
	[BlackList] // 0x0000000189B86700-0x0000000189B86740
	// [XID] // 0x0000000189B86700-0x0000000189B86740
	public virtual void OnPoolAllocated() {} // 0x000000018419EB60-0x000000018419EC00
	[BlackList] // 0x0000000189B90A10-0x0000000189B90A50
	// [XID] // 0x0000000189B90A10-0x0000000189B90A50
	public virtual void OnBeforePoolRecycled() {} // 0x000000018419EAC0-0x000000018419EB60
}

