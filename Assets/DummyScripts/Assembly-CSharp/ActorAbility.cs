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

public class ActorAbility : BaseActorActionContext // TypeDefIndex: 14608
{
	// Fields
	[NonSerialized]
	public LCAbility caster; // 0x38
	public uint entityRuntimeID; // 0x40
	[InspectorCollapsedFoldout] // 0x000000018996D100-0x000000018996D130
	[ShowInInspector] // 0x000000018996D100-0x000000018996D130
	private ConfigAbility _config; // 0x48
	[InspectorCollapsedFoldout] // 0x000000018996D100-0x000000018996D130
	[ShowInInspector] // 0x000000018996D100-0x000000018996D130
	protected OverrideMap _overrideMap; // 0x50
	[InspectorCollapsedFoldout] // 0x000000018981F560-0x000000018981F570
	public List<ActorModifier> ownedModifiers; // 0x58
	public string overrideName; // 0x68
	private uint _instancedAbilityID; // 0x70
	public int referenceCount; // 0x74

	// Properties
	public ConfigAbility config { /* [XID] */ /* 0x0000000189B5D540-0x0000000189B5D560 */ get => default; /* [XID] */ /* 0x0000000189954FC0-0x0000000189954FE0 */ set {} } // 0x0000000182FF2660-0x0000000182FF2700 0x0000000182FEE230-0x0000000182FEE350
	public ConfigAbility configNoCheck { /* [XID] */ /* 0x000000018995C860-0x000000018995C880 */ get => default; } // 0x0000000182FEFC20-0x0000000182FEFCC0 
	[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
	public bool isValid { /* [XID] */ /* 0x0000000189964110-0x0000000189964150 */ get; /* [XID] */ /* 0x000000018996E560-0x000000018996E5A0 */ set; } // 0x0000000182FF0680-0x0000000182FF06E0 0x0000000182FF2BD0-0x0000000182FF2C30
	public bool isLevelElementAbility { /* [XID] */ /* 0x00000001899796C0-0x0000000189979700 */ get; /* [XID] */ /* 0x0000000189983B10-0x0000000189983B50 */ private set; } // 0x0000000182FF2700-0x0000000182FF2760 0x0000000182FF0F20-0x0000000182FF0F80
	public string abilityName { /* [XID] */ /* 0x0000000189835CB0-0x0000000189835CD0 */ get => default; } // 0x0000000182FF0980-0x0000000182FF0A40 
	public uint instancedAbilityID { /* [XID] */ /* 0x0000000189A852B0-0x0000000189A852D0 */ get => default; /* [XID] */ /* 0x0000000189817FC0-0x0000000189817FE0 */ set {} } // 0x0000000182FF00A0-0x0000000182FF0140 0x0000000182FEF060-0x0000000182FEF160

	// Constructors
	public ActorAbility() {} // 0x0000000182FF3130-0x0000000182FF31B0

	// Methods
	// [XID] // 0x000000018998E370-0x000000018998E390
	public void Init(LCAbility caster, ConfigAbility config, string abilityOverride, OverrideMap overrideMap) {} // 0x0000000182FEF4E0-0x0000000182FEF830
	// [XID] // 0x0000000189995E60-0x0000000189995E80
	protected override void TryAddTickContext() {} // 0x0000000182FEE160-0x0000000182FEE230
	// [XID] // 0x000000018999D920-0x000000018999D940
	protected override void RefreshContextTickOnSetMixinEnabled() {} // 0x0000000182FF02D0-0x0000000182FF03A0
	// [XID] // 0x00000001899A51E0-0x00000001899A5200
	public bool CheckNeedInitMixins() => default; // 0x0000000182FF06E0-0x0000000182FF0980
	// [XID] // 0x0000000189B64CE0-0x0000000189B64D00
	private int GetConfigAbilityMixinNum() => default; // 0x0000000182FF0A40-0x0000000182FF0B70
	// [XID] // 0x00000001899B4490-0x00000001899B44B0
	public void InitMixins() {} // 0x0000000182FEDA10-0x0000000182FEE070
	// [XID] // 0x00000001899BB910-0x00000001899BB930
	public override void Clear() {} // 0x0000000182FEF830-0x0000000182FEFC20
	// [XID] // 0x00000001899C3550-0x00000001899C3570
	public bool CheckCanClearAndDeallocteToPool() => default; // 0x0000000182FEE480-0x0000000182FEE630
	// [XID] // 0x00000001899CA9E0-0x00000001899CAA00
	public virtual void ClearAndDeallocateToPool() {} // 0x0000000182FEFD20-0x0000000182FEFEA0
	// [XID] // 0x00000001897B7B10-0x00000001897B7B30
	private void ClearOwnerdModifiers() {} // 0x0000000182FF2C30-0x0000000182FF2EA0
	// [XID] // 0x00000001899D96F0-0x00000001899D9710
	public override string GetDebugContextName() => default; // 0x0000000182FEE3C0-0x0000000182FEE480
	// [XID] // 0x00000001899E0D10-0x00000001899E0D30
	public override LCAbility GetOwner() => default; // 0x0000000182FED730-0x0000000182FED7D0
	// [XID] // 0x00000001899E8920-0x00000001899E8940
	public float EvaluateFloatSpecial(string key, ActorAbilityPlugin sourceGlobalValuePlugin = null) => default; // 0x0000000182FF0F80-0x0000000182FF1810
	// [IDTag] // 0x00000001899EFFE0-0x00000001899F0020
	// [XID] // 0x00000001899EFFE0-0x00000001899F0020
	public bool RelationalOperate(RelationalOperator opt, float floatValue, DynamicFloat value) => default; // 0x0000000182FF1AC0-0x0000000182FF1C80
	// [IDTag] // 0x00000001899FA5D0-0x00000001899FA610
	// [XID] // 0x00000001899FA5D0-0x00000001899FA610
	public bool RelationalOperate(RelationalOperator opt, int intValue, DynamicInt value) => default; // 0x0000000182FF1910-0x0000000182FF1AC0
	// [IDTag] // 0x0000000189A04AA0-0x0000000189A04AE0
	// [XID] // 0x0000000189A04AA0-0x0000000189A04AE0
	public float Evaluate(DynamicFloat dynamicFloat, ActorAbilityPlugin sourceGlobalValuePlugin = null) => default; // 0x0000000182FEEE50-0x0000000182FEEF70
	// [IDTag] // 0x0000000189A0EFA0-0x0000000189A0EFE0
	// [XID] // 0x0000000189A0EFA0-0x0000000189A0EFE0
	public int Evaluate(DynamicInt dynamicInt, ActorAbilityPlugin sourceGlobalValuePlugin = null) => default; // 0x0000000182FEE630-0x0000000182FEEC10
	// [IDTag] // 0x0000000189A19590-0x0000000189A195D0
	// [XID] // 0x0000000189A19590-0x0000000189A195D0
	public string Evaluate(DynamicString dynamicStr) => default; // 0x0000000182FEEC10-0x0000000182FEEE50
	// [XID] // 0x0000000189A23C90-0x0000000189A23CB0
	private void CreateAbilityDefinedProperties(LCAbility caster) {} // 0x0000000182FF1FD0-0x0000000182FF2600
	// [XID] // 0x0000000189844B50-0x0000000189844B70
	public void Attach() {} // 0x0000000182FEEF70-0x0000000182FEF060
	// [XID] // 0x0000000189A326B0-0x0000000189A326D0
	public void Detach(RemoveAbilityReason removeReason) {} // 0x0000000182FF1810-0x0000000182FF1910
	// [XID] // 0x0000000189A39FB0-0x0000000189A39FD0
	public bool HasParam(string key) => default; // 0x0000000182FEF1D0-0x0000000182FEF2F0
	// [XID] // 0x0000000189904840-0x0000000189904860
	public float GetSpecialFloatParam(string key) => default; // 0x0000000182FF0D10-0x0000000182FF0F20
	// [XID] // 0x00000001897D7910-0x00000001897D7930
	public float GetFloatParam(string key) => default; // 0x0000000182FED7D0-0x0000000182FEDA10
	// [XID] // 0x0000000189A507C0-0x0000000189A507E0
	public virtual bool SetFloatParam(string key, float paramValue, bool forceDoAtRemote = false /* Metadata: 0x00AEB965 */) => default; // 0x0000000182FF0140-0x0000000182FF02D0
	// [XID] // 0x0000000189A57C20-0x0000000189A57C40
	public virtual bool ClearOverrideParam(string key, bool forceDoAtRemote = false /* Metadata: 0x00AEB966 */) => default; // 0x0000000182FEFF00-0x0000000182FF00A0
	// [XID] // 0x0000000189A5F8D0-0x0000000189A5F8F0
	public void SetTriggerAbilityParam(string key, float value) {} // 0x0000000182FF0410-0x0000000182FF0680
	// [XID] // 0x0000000189A671B0-0x0000000189A671D0
	public virtual void ReInitOverrideMap() {} // 0x0000000182FEF2F0-0x0000000182FEF4E0
	// [XID] // 0x0000000189A6E840-0x0000000189A6E860
	public virtual void SetOverrideMap(OverrideMap overrideMap, bool syncToServer = false /* Metadata: 0x00AEB967 */) {} // 0x0000000182FEE070-0x0000000182FEE160
	// [XID] // 0x00000001895EB710-0x00000001895EB730
	public OverrideMap GetOverrideMap() => default; // 0x0000000182FF0C70-0x0000000182FF0D10
	// [XID] // 0x0000000189A94050-0x0000000189A94070
	public override void CheckHandleMixinsIfChangeAuthority() {} // 0x0000000182FF1C80-0x0000000182FF1FD0
	// [XID] // 0x0000000189A9BA20-0x0000000189A9BA40
	private void RemoveMixinSuddenly(int mixinIndex) {} // 0x0000000182FF2830-0x0000000182FF2BD0
	// [XID] // 0x0000000189AA2EE0-0x0000000189AA2F00
	public override uint GetAttachContainerKey() => default; // 0x0000000182FF2760-0x0000000182FF2830
	// [XID] // 0x0000000189AAA430-0x0000000189AAA450
	public override ActorActionContextType GetContextType() => default; // 0x0000000182FF0BD0-0x0000000182FF0C70
	// [XID] // 0x0000000189AB2250-0x0000000189AB2270
	public override string ToString() => default; // 0x0000000182FF2EA0-0x0000000182FF3130
}

