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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActorModifier : BaseActorActionContext // TypeDefIndex: 14613
{
	// Fields
	[NonSerialized]
	public ActorAbility parentAbility; // 0x38
	private ConfigAbility _parentAbilityConfig; // 0x40
	[NonSerialized]
	public uint parentAbilityEntityID; // 0x48
	[NonSerialized]
	public LCAbility owner; // 0x50
	[InspectorCollapsedFoldout] // 0x0000000189879680-0x00000001898796B0
	[ShowInInspector] // 0x0000000189879680-0x00000001898796B0
	private ConfigAbilityModifier _config; // 0x58
	[NonSerialized]
	public Dictionary<EncryptedString, int> stackIndices; // 0x60
	private int _parentOwnedIx; // 0x68
	public uint instancedModifierID; // 0x6C
	public ActorModifier attachedInstancedModifier; // 0x70
	public uint attachedModifierOwnerEntityId; // 0x78
	public uint attachedModifierInstancedModifierId; // 0x7C
	public bool attachedModifierIsServerBuff; // 0x80
	public int attachedModifierNameHash; // 0x84
	public bool isAttachedParentAbility; // 0x88
	public Action<ActorModifier> onDetached; // 0x90
	public uint serverBuffUid; // 0x98
	public Action<float?> onDurabilityEmpty; // 0xA0
	[NonSerialized]
	public bool isModifierInvalidByServer; // 0xB8
	public bool hasAddedAbilityState; // 0xB9
	public float thinkInterval; // 0xBC
	private static Dictionary<EncryptedString, float> _propertyDict; // 0x00
	public float reduceElementRatio; // 0xC0

	// Properties
	public ConfigAbility parentAbilityConfig { /* [XID] */ /* 0x0000000189965D50-0x0000000189965D70 */ get => default; /* [XID] */ /* 0x00000001896B5500-0x00000001896B5520 */ set {} } // 0x0000000181861120-0x00000001818611C0 0x0000000181862480-0x00000001818625A0
	public uint applyEntityId { /* [XID] */ /* 0x00000001896BC760-0x00000001896BC7A0 */ get; /* [XID] */ /* 0x00000001896C6DF0-0x00000001896C6E30 */ private set; } // 0x000000018185E7E0-0x000000018185E840 0x0000000181862040-0x00000001818620A0
	public ConfigAbilityModifier config { /* [XID] */ /* 0x00000001899C3840-0x00000001899C3860 */ get => default; /* [XID] */ /* 0x00000001896D8900-0x00000001896D8920 */ set {} } // 0x0000000181863AD0-0x0000000181863B70 0x000000018185EE30-0x000000018185EEE0
	public ConfigAbilityModifier configNoCheck { /* [XID] */ /* 0x00000001896E0130-0x00000001896E0150 */ get => default; } // 0x0000000181860FC0-0x0000000181861060 
	[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
	public bool isValid { /* [XID] */ /* 0x00000001896E7460-0x00000001896E74A0 */ get; /* [XID] */ /* 0x00000001896F14F0-0x00000001896F1530 */ set; } // 0x0000000181861D70-0x0000000181861DD0 0x0000000181863FB0-0x0000000181864020
	public ulong modifierStartTime { /* [XID] */ /* 0x00000001896FC2D0-0x00000001896FC310 */ get; /* [XID] */ /* 0x0000000189706780-0x00000001897067C0 */ set; } // 0x00000001818634D0-0x0000000181863530 0x000000018185DDE0-0x000000018185DE50
	public float elementDurability { /* [XID] */ /* 0x0000000189825540-0x0000000189825560 */ get => default; } // 0x0000000181861DD0-0x0000000181861F40 
	public float elementRemainingTime { /* [XID] */ /* 0x00000001897CCB40-0x00000001897CCB60 */ get => default; } // 0x0000000181861A90-0x0000000181861C00 

	// Constructors
	public ActorModifier() {} // 0x0000000181865010-0x0000000181865100
	static ActorModifier() {} // 0x0000000181864F80-0x0000000181865010

	// Methods
	// [XID] // 0x0000000189711250-0x0000000189711270
	public override string GetDebugContextName() => default; // 0x000000018185EF50-0x000000018185F0D0
	// [XID] // 0x00000001897187C0-0x00000001897187E0
	public override LCAbility GetOwner() => default; // 0x000000018185D950-0x000000018185D9F0
	// [XID] // 0x000000018971FF20-0x000000018971FF40
	public void Init(ActorAbility parentAbility, LCAbility owner, ConfigAbilityModifier config, uint applyEntityId, ConfigAbility parentAbilityConfig = null, uint parentAbilityEntityID = 0 /* Metadata: 0x00AEB99A */) {} // 0x000000018185FDA0-0x00000001818609F0
	// [XID] // 0x0000000189727680-0x00000001897276A0
	protected override void TryAddTickContext() {} // 0x000000018185ED60-0x000000018185EE30
	// [XID] // 0x000000018972EB30-0x000000018972EB50
	protected override void RefreshContextTickOnSetMixinEnabled() {} // 0x0000000181861950-0x0000000181861A20
	// [XID] // 0x00000001897362A0-0x00000001897362C0
	public override void Clear() {} // 0x0000000181860DD0-0x0000000181860FC0
	// [XID] // 0x000000018973E120-0x000000018973E140
	public void LazySetParentAbility(ActorAbility parentAbility) {} // 0x00000001818611C0-0x0000000181861950
	// [XID] // 0x0000000189745450-0x0000000189745470
	public void OnPostRecoverFromServer() {} // 0x000000018185F0D0-0x000000018185F170
	// [XID] // 0x000000018974CEF0-0x000000018974CF10
	public void OnSyncSetAttachedModifier() {} // 0x000000018185DE50-0x000000018185E7E0
	// [XID] // 0x00000001897544B0-0x00000001897544D0
	public void Attach() {} // 0x000000018185F880-0x000000018185FBA0
	// [XID] // 0x000000018980BDD0-0x000000018980BDF0
	public void Detach(RemoveAbilityReason removeReason) {} // 0x0000000181862720-0x00000001818634D0
	// [XID] // 0x00000001897A8370-0x00000001897A8390
	public void SetParentAbilitySuddenlyClear() {} // 0x000000018185FC10-0x000000018185FDA0
	// [XID] // 0x0000000189B67D70-0x0000000189B67D90
	public void PushProperties() {} // 0x000000018185F170-0x000000018185F880
	// [XID] // 0x0000000189771EB0-0x0000000189771ED0
	public void ApplyProperties(RepeatedMessageField<ModifierProperty> properties) {} // 0x0000000181864020-0x0000000181864A80
	// [XID] // 0x00000001898135C0-0x00000001898135E0
	public void PopProperties() {} // 0x000000018185E840-0x000000018185ED60
	// [XID] // 0x0000000189781060-0x0000000189781080
	public void FillSyncActorModifierProperties(RepeatedMessageField<ModifierProperty> properties) {} // 0x00000001818620A0-0x0000000181862480
	// [XID] // 0x0000000189788520-0x0000000189788540
	public override void CheckHandleMixinsIfChangeAuthority() {} // 0x0000000181863530-0x0000000181863A70
	// [XID] // 0x000000018978FBE0-0x000000018978FC00
	private void RemoveMixinSuddenly(int mixinIndex) {} // 0x0000000181863C10-0x0000000181863FB0
	// [XID] // 0x00000001897973B0-0x00000001897973D0
	public bool SendRemoveMessageImmediately() => default; // 0x00000001818625A0-0x0000000181862720
	// [XID] // 0x0000000189807920-0x0000000189807940
	public void SetApplyEntityId(uint applyEntityId, bool syncToServer = true /* Metadata: 0x00AEB99E */) {} // 0x000000018185D9F0-0x000000018185DDE0
	// [XID] // 0x00000001898344B0-0x00000001898344D0
	public BaseEntity GetApplierEntity() => default; // 0x0000000181861C00-0x0000000181861D70
	// [XID] // 0x00000001897AE0A0-0x00000001897AE0C0
	public void SyncDurabilityToServer(float reduceDurability, float remainDurability) {} // 0x00000001818609F0-0x0000000181860DD0
	// [XID] // 0x00000001897B6110-0x00000001897B6130
	public override uint GetAttachContainerKey() => default; // 0x0000000181863B70-0x0000000181863C10
	// [XID] // 0x00000001897BDF40-0x00000001897BDF60
	public override ActorActionContextType GetContextType() => default; // 0x0000000181861FA0-0x0000000181862040
	// [XID] // 0x00000001897D42E0-0x00000001897D4300
	public override string ToString() => default; // 0x0000000181864A80-0x0000000181864F80
}

