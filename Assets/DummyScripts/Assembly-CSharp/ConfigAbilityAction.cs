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
public class ConfigAbilityAction : BaseActionContainer, IActionTokenConfig, IAutoAllocRecycle // TypeDefIndex: 14947
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAbilityActionToken _token; // 0x20
	private AbilityTargetting _target; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private SelectTargets _otherTargets; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private FixedBool _doOffStage; // 0x38
	private bool _doAfterDie; // 0x40
	private bool _canBeHandledOnRecover; // 0x41
	private bool _muteRemoteAction; // 0x42
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _predicates; // 0x48
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _predicatesForeach; // 0x50
	private Action<object> _getSubActions; // 0x58
	public bool MPTotallyLocal; // 0x60

	// Properties
	public ConfigAbilityActionToken token { /* [XID] */ /* 0x00000001897C5060-0x00000001897C5080 */ get => default; /* [XID] */ /* 0x00000001897CC890-0x00000001897CC8B0 */ private set {} } // 0x0000000184832520-0x00000001848325C0 0x000000018482F9D0-0x000000018482FA80
	public AbilityTargetting target { /* [XID] */ /* 0x00000001896E1D10-0x00000001896E1D30 */ get => default; /* [XID] */ /* 0x00000001897DB9D0-0x00000001897DB9F0 */ private set {} } // 0x0000000184830B90-0x0000000184830C30 0x0000000184830C30-0x0000000184830CE0
	public SelectTargets otherTargets { /* [XID] */ /* 0x00000001897E32A0-0x00000001897E32C0 */ get => default; /* [XID] */ /* 0x00000001897EAA40-0x00000001897EAA60 */ private set {} } // 0x0000000184834660-0x0000000184834700 0x0000000184831B30-0x0000000184831BE0
	public FixedBool doOffStage { /* [XID] */ /* 0x00000001897F2790-0x00000001897F27B0 */ get => default; /* [XID] */ /* 0x00000001897F9F60-0x00000001897F9F80 */ set {} } // 0x00000001848323D0-0x0000000184832470 0x0000000184830CE0-0x0000000184830D90
	public bool doAfterDie { /* [XID] */ /* 0x00000001896CB580-0x00000001896CB5A0 */ get => default; /* [XID] */ /* 0x00000001898089C0-0x00000001898089E0 */ private set {} } // 0x0000000184832330-0x00000001848323D0 0x00000001848345B0-0x0000000184834660
	public bool canBeHandledOnRecover { /* [XID] */ /* 0x00000001898103D0-0x00000001898103F0 */ get => default; /* [XID] */ /* 0x0000000189817AE0-0x0000000189817B00 */ private set {} } // 0x0000000184830FD0-0x0000000184831070 0x0000000184831F60-0x0000000184832010
	public bool muteRemoteAction { /* [XID] */ /* 0x0000000189A04E00-0x0000000189A04E20 */ get => default; /* [XID] */ /* 0x0000000189826870-0x0000000189826890 */ private set {} } // 0x0000000184833480-0x0000000184833520 0x00000001848341F0-0x00000001848342A0
	public ConfigAbilityPredicate[] predicates { /* [XID] */ /* 0x000000018982DFC0-0x000000018982DFE0 */ get => default; /* [XID] */ /* 0x00000001898355B0-0x00000001898355D0 */ private set {} } // 0x00000001848333E0-0x0000000184833480 0x0000000184832C50-0x0000000184832D00
	public ConfigAbilityPredicate[] predicatesForeach { /* [XID] */ /* 0x000000018983CD90-0x000000018983CDB0 */ get => default; /* [XID] */ /* 0x0000000189844440-0x0000000189844460 */ private set {} } // 0x000000018482F930-0x000000018482F9D0 0x0000000184832280-0x0000000184832330
	protected virtual bool MuteAuthority { /* [XID] */ /* 0x00000001898F9A70-0x00000001898F9A90 */ get => default; } // 0x00000001848331F0-0x0000000184833290 
	protected virtual bool MuteRemote { /* [XID] */ /* 0x00000001899013D0-0x00000001899013F0 */ get => default; } // 0x00000001848325C0-0x0000000184832660 
	protected virtual bool ForceForwardToServer { /* [XID] */ /* 0x0000000189A0C490-0x0000000189A0C4B0 */ get => default; } // 0x0000000184830A50-0x0000000184830AF0 
	protected virtual bool RemoteCheckTargetExists { /* [XID] */ /* 0x0000000189910150-0x0000000189910170 */ get => default; } // 0x0000000184830AF0-0x0000000184830B90 
	public bool IsAuthorityOnly { /* [XID] */ /* 0x0000000189926F00-0x0000000189926F20 */ get => default; } // 0x0000000184833980-0x0000000184833A50 
	public bool IsMuteRemote { /* [XID] */ /* 0x000000018992E510-0x000000018992E530 */ get => default; } // 0x0000000184831760-0x0000000184831810 
	public virtual EntityTokenActionType entityTokenType { /* [XID] */ /* 0x000000018993D310-0x000000018993D330 */ get => default; } // 0x0000000184832010-0x00000001848320B0 
	public virtual bool useActionToken { /* [XID] */ /* 0x0000000189944A40-0x0000000189944A60 */ get => default; } // 0x0000000184833840-0x00000001848338E0 

	// Constructors
	public ConfigAbilityAction(AbilityTargetting target) {} // 0x00000001848348B0-0x0000000184834940
	public ConfigAbilityAction() {} // 0x0000000184834840-0x00000001848348B0

	// Methods
	// [XID] // 0x000000018984B8B0-0x000000018984B8D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001848342A0-0x0000000184834470
	// [XID] // 0x0000000189852940-0x0000000189852960
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184833290-0x00000001848333E0
	// [XID] // 0x000000018985A3B0-0x000000018985A3D0
	public virtual ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AEFB68 */) => default; // 0x0000000184832B70-0x0000000184832C50
	// [XID] // 0x00000001898615B0-0x00000001898615D0
	public virtual int GetHashNum() => default; // 0x0000000184830980-0x0000000184830A50
	// [XID] // 0x0000000189868D90-0x0000000189868DB0
	public override void InitEmpty() {} // 0x0000000184832660-0x0000000184832780
	[BlackList] // 0x00000001898701A0-0x00000001898701E0
	// [XID] // 0x00000001898701A0-0x00000001898701E0
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000184831BE0-0x0000000184831F60
	// [XID] // 0x000000018987ADB0-0x000000018987ADD0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018482FA80-0x00000001848302E0
	[BlackList] // 0x0000000189881D00-0x0000000189881D40
	// [XID] // 0x0000000189881D00-0x0000000189881D40
	public static ConfigAbilityAction ParseFromJson(JSONNode node) => default; // 0x0000000184832FF0-0x00000001848331F0
	// [XID] // 0x000000018988C320-0x000000018988C340
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB69 */, bool useObjectPool = false /* Metadata: 0x00AEFB6D */) => default; // 0x0000000184832870-0x0000000184832B70
	// [XID] // 0x00000001898938B0-0x00000001898938D0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB6E */, bool useObjectPool = false /* Metadata: 0x00AEFB72 */) => default; // 0x0000000184831070-0x0000000184831760
	// [XID] // 0x0000000189A38D50-0x0000000189A38D70
	public static ConfigAbilityAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB73 */, bool useObjectPool = false /* Metadata: 0x00AEFB77 */) => default; // 0x00000001848320B0-0x0000000184832280
	[BlackList] // 0x00000001898A2380-0x00000001898A23C0
	// [XID] // 0x00000001898A2380-0x00000001898A23C0
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x00000001848302E0-0x00000001848305B0
	// [XID] // 0x00000001898ACBC0-0x00000001898ACBE0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184833A50-0x0000000184834100
	[BlackList] // 0x00000001898B3FE0-0x00000001898B4020
	// [XID] // 0x00000001898B3FE0-0x00000001898B4020
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184832780-0x0000000184832870
	// [IDTag] // 0x00000001898BE8E0-0x00000001898BE920
	// [XID] // 0x00000001898BE8E0-0x00000001898BE920
	public virtual void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184831810-0x00000001848319B0
	// [IDTag] // 0x00000001898C9280-0x00000001898C92C0
	// [XID] // 0x00000001898C9280-0x00000001898C92C0
	public virtual void Call(AbilityActionExecuter actionExecuter, ConfigAbilityAction actionConfig, IAbilityActionContainer instance, ActorAbilityPlugin.AbilityAttackTarget target) {} // 0x00000001848319B0-0x0000000184831AB0
	// [XID] // 0x00000001898D3910-0x00000001898D3930
	public sealed override void GetAllSubActions() {} // 0x0000000184830880-0x0000000184830980
	// [XID] // 0x00000001898DB120-0x00000001898DB140
	private void GetSubActions(object member) {} // 0x0000000184830E00-0x0000000184830FD0
	// [XID] // 0x00000001898E2EA0-0x00000001898E2EC0
	public override int GetHashCode() => default; // 0x0000000184832470-0x0000000184832520
	// [XID] // 0x00000001898EAB90-0x00000001898EABB0
	public virtual bool GetDebugOutput(ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref string output) => default; // 0x0000000184834100-0x00000001848341F0
	// [XID] // 0x00000001898F22B0-0x00000001898F22D0
	public virtual bool CanUseOtherTargetting() => default; // 0x00000001848338E0-0x0000000184833980
	// [XID] // 0x00000001899E10C0-0x00000001899E10E0
	public virtual void CallAuthority(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x0000000184833520-0x0000000184833840
	// [XID] // 0x000000018991F2E0-0x000000018991F300
	public virtual void CallRemote(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000184832E10-0x0000000184832FF0
	// [XID] // 0x00000001899357B0-0x00000001899357D0
	public virtual bool isAlreadyHandledRecoverCase() => default; // 0x0000000184834700-0x00000001848347A0
	// [XID] // 0x000000018994BFE0-0x000000018994C000
	public ConfigAbilityActionToken GetTokenConfig() => default; // 0x0000000184832D00-0x0000000184832DB0
	[BlackList] // 0x0000000189953670-0x00000001899536B0
	// [XID] // 0x0000000189953670-0x00000001899536B0
	public virtual void AutoAllocTypeFields() {} // 0x00000001848305B0-0x0000000184830650
	[BlackList] // 0x000000018995DF30-0x000000018995DF70
	// [XID] // 0x000000018995DF30-0x000000018995DF70
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184830650-0x0000000184830880
	[BlackList] // 0x0000000189968660-0x00000001899686A0
	// [XID] // 0x0000000189968660-0x00000001899686A0
	public virtual void ReturnToObjectPool() {} // 0x00000001848347A0-0x0000000184834840
	[BlackList] // 0x0000000189972FB0-0x0000000189972FF0
	// [XID] // 0x0000000189972FB0-0x0000000189972FF0
	public virtual void OnPoolAllocated() {} // 0x0000000184834510-0x00000001848345B0
	[BlackList] // 0x000000018997D050-0x000000018997D090
	// [XID] // 0x000000018997D050-0x000000018997D090
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184834470-0x0000000184834510
}

