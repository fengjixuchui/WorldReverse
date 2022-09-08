/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TokenManager : InLevelManager // TypeDefIndex: 14611
{
	// Fields
	private ActionTokenSourceType[] _evt2ActionSrcTypes; // 0x10
	private const int INIT_DELAY_LIST_CAPACITY = 255; // Metadata: 0x00AEB986
	private List<IActionTokenCache> _actionDelayList; // 0x18
	private List<IActionTokenCache> _actionTempList; // 0x20
	private const int OUTSIDE_TICK_LOD = 1; // Metadata: 0x00AEB98A
	public const int TOKEN_COST_TYPE_GOD = 9; // Metadata: 0x00AEB98E
	public const int TOKEN_COST_TYPE_NORMAL = 0; // Metadata: 0x00AEB992
	private const int INVALID_OVERRIDE_TOKEN_MAX_NUM = -1; // Metadata: 0x00AEB996
	private int _overrideTokenMaxNum; // 0x28
	private EntityTypeTokenProxy[] _entityTypeTokens; // 0x30
	private float _distLowLevel; // 0x38
	private ConfigAbilityActionToken[] _distLowLevelTokens; // 0x40
	private bool[] _distLowLevelAction; // 0x48
	private ConfigActionTokenChannel[] _actionTokenChannels; // 0x50
	private int[] _actionFrameTokenCnts; // 0x58
	private EntityTypeTokenProxy[][] _actionSourceTokens; // 0x60
	private List<IActionTokenConfig> _overBudgetEffects; // 0x68
	private EntityInternalBaseConfig[] _entityInternalConfigs; // 0x70

	// Properties
	public int overrideTokenMaxNum { /* [XID] */ /* 0x0000000189BA2B90-0x0000000189BA2BB0 */ get => default; } // 0x00000001832D1E50-0x00000001832D1EF0 

	// Nested types
	private class EntityTypeTokenProxy // TypeDefIndex: 14612
	{
		// Fields
		private int _type; // 0x10
		private bool[] _entityTypes; // 0x18
		private ConfigAbilityActionToken _lowerToken; // 0x20
		private ConfigAbilityActionToken _otherToken; // 0x28

		// Properties
		public int type { /* [XID] */ /* 0x0000000189656F80-0x0000000189656FA0 */ get => default; } // 0x0000000181DB75E0-0x0000000181DB7680 
		public ConfigAbilityActionToken lowerToken { /* [XID] */ /* 0x000000018965E6B0-0x000000018965E6D0 */ get => default; } // 0x0000000181DB72B0-0x0000000181DB7350 
		public ConfigAbilityActionToken otherToken { /* [XID] */ /* 0x0000000189665CA0-0x0000000189665CC0 */ get => default; } // 0x0000000181DB7350-0x0000000181DB73F0 

		// Constructors
		public EntityTypeTokenProxy() {} // 0x0000000181DB7680-0x0000000181DB7790

		// Methods
		// [XID] // 0x000000018966D410-0x000000018966D430
		public void Init(EntityTokenActionType type, ConfigEntityActionTokenGroup config) {} // 0x0000000181DB6FF0-0x0000000181DB71E0
		// [XID] // 0x0000000189675430-0x0000000189675450
		public ConfigAbilityActionToken GetToken(IActionTokenTarget entity) => default; // 0x0000000181DB71E0-0x0000000181DB72B0
		// [XID] // 0x00000001899CF660-0x00000001899CF680
		public bool IsLowLevelEntity(IActionTokenTarget target) => default; // 0x0000000181DB73F0-0x0000000181DB75E0
	}

	// Constructors
	public TokenManager() {} // 0x00000001832D2B70-0x00000001832D2C80

	// Methods
	// [XID] // 0x0000000189AEF070-0x0000000189AEF090
	private void InitEvt2ActionSrcType() {} // 0x00000001832CF610-0x00000001832CF770
	// [IDTag] // 0x0000000189AF64E0-0x0000000189AF6520
	// [XID] // 0x0000000189AF64E0-0x0000000189AF6520
	public ActionTokenSourceType GetActionTokenSourceType(BaseEvent evt) => default; // 0x00000001832CE0D0-0x00000001832CE1B0
	// [IDTag] // 0x0000000189B00AD0-0x0000000189B00B10
	// [XID] // 0x0000000189B00AD0-0x0000000189B00B10
	public bool HandleActionToken(ActorAbilityPlugin actorAbilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ConfigAbilityPredicate[] predicatesForeach, bool recoverFromServer, bool callAuthority) => default; // 0x00000001832CF070-0x00000001832CF2A0
	// [XID] // 0x0000000189B0B100-0x0000000189B0B120
	public bool HandleUISpawnActionToken(BaseEntity target, VCElementReactionPlugin plugin, ElementReactionType reaction, ElementType sourceElementType, ElementType reactorElementType) => default; // 0x00000001832CE280-0x00000001832CE3E0
	// [IDTag] // 0x0000000189B129D0-0x0000000189B12A10
	// [XID] // 0x0000000189B129D0-0x0000000189B12A10
	public bool HandleActionToken(AbilityActionExecuter abilityExecuter, ConfigAbilityAction actionConfig, IAbilityActionContainer instance, ActorAbilityPlugin.AbilityAttackTarget target) => default; // 0x00000001832CEF00-0x00000001832CF070
	// [XID] // 0x0000000189B1CF10-0x0000000189B1CF30
	public bool HandleEntityCreateToken(bool async, BaseEntity target) => default; // 0x00000001832CFC50-0x00000001832CFD60
	// [XID] // 0x0000000189B24460-0x0000000189B24480
	private bool HandleActionTokenInternal(IActionTokenConfig actionConfig, IActionTokenTarget target, IActionTokenCache tokenCache, ActionTokenSourceType actionSrc = ActionTokenSourceType.SOURCE_INVALID /* Metadata: 0x00AEB978 */) => default; // 0x00000001832CFD60-0x00000001832CFF80
	// [XID] // 0x0000000189B2B980-0x0000000189B2B9A0
	private ActionTokenResult HandleActionTokenInternalImp(IActionTokenConfig actionConfig, IActionTokenTarget target, IActionTokenCache tokenCache, ActionTokenSourceType actionSrc = ActionTokenSourceType.SOURCE_INVALID /* Metadata: 0x00AEB97C */) => default; // 0x00000001832CF900-0x00000001832CFB20
	// [XID] // 0x00000001897BFAD0-0x00000001897BFAF0
	private ActionTokenResult GetTokenResultByTokenType(ActionTokenType tokenType) => default; // 0x00000001832CED60-0x00000001832CEE20
	// [XID] // 0x0000000189B3A800-0x0000000189B3A820
	private void AddToDelayList(IActionTokenCache tokenCache) {} // 0x00000001832CDDF0-0x00000001832CDEC0
	// [XID] // 0x0000000189B42130-0x0000000189B42150
	public void FlushDelayActionToken() {} // 0x00000001832CFB20-0x00000001832CFC50
	// [XID] // 0x0000000189B49B50-0x0000000189B49B70
	private void RemoveCanceledTokenCache() {} // 0x00000001832D0B20-0x00000001832D0E90
	// [XID] // 0x0000000189B51250-0x0000000189B51270
	private void CalculateDelayListPriority() {} // 0x00000001832CDAB0-0x00000001832CDDF0
	// [XID] // 0x0000000189B58B60-0x0000000189B58B80
	private int GetWeightByBool(bool boolValue) => default; // 0x00000001832D2AB0-0x00000001832D2B70
	// [XID] // 0x0000000189BC2540-0x0000000189BC2560
	private bool IsInternalAttachEffect(IActionTokenConfig actionConfig) => default; // 0x00000001832CF2A0-0x00000001832CF380
	// [XID] // 0x0000000189B67AB0-0x0000000189B67AD0
	private bool IsInternalFireEffect(IActionTokenConfig actionConfig) => default; // 0x00000001832CEE20-0x00000001832CEF00
	// [XID] // 0x0000000189B6ECF0-0x0000000189B6ED10
	private bool IsInternalEffect(IActionTokenConfig actionConfig) => default; // 0x00000001832CF380-0x00000001832CF460
	// [XID] // 0x0000000189B764F0-0x0000000189B76510
	private bool IsUISpawn(IActionTokenConfig actionConfig) => default; // 0x00000001832CF830-0x00000001832CF900
	// [XID] // 0x0000000189B7DAA0-0x0000000189B7DAC0
	private bool OutsideTickLod(IActionTokenTarget target) => default; // 0x00000001832D07F0-0x00000001832D08C0
	// [XID] // 0x0000000189B85720-0x0000000189B85740
	private void SortDelayList() {} // 0x00000001832D2190-0x00000001832D22B0
	// [XID] // 0x0000000189B8C4D0-0x0000000189B8C4F0
	private void FlushDelayList() {} // 0x00000001832D01C0-0x00000001832D0620
	// [XID] // 0x0000000189B93ED0-0x0000000189B93EF0
	public bool IsForceEnqueueEffect(string effectName) => default; // 0x00000001832D1EF0-0x00000001832D20B0
	// [XID] // 0x0000000189B9B490-0x0000000189B9B4B0
	public bool IsForceEnqueueElementReactionEffect(string effectName) => default; // 0x00000001832CEBC0-0x00000001832CED60
	// [XID] // 0x0000000189BAA000-0x0000000189BAA020
	public override void Init() {} // 0x00000001832CF770-0x00000001832CF830
	// [XID] // 0x0000000189BB1860-0x0000000189BB1880
	private void InitConfig() {} // 0x00000001832D0FD0-0x00000001832D1E50
	// [XID] // 0x0000000189BB8840-0x0000000189BB8860
	public void FrameReset() {} // 0x00000001832CDEC0-0x00000001832CE0D0
	// [XID] // 0x0000000189BC0220-0x0000000189BC0240
	public override void Destroy() {} // 0x00000001832CE990-0x00000001832CEA60
	// [XID] // 0x00000001896D8CD0-0x00000001896D8CF0
	public ConfigAbilityActionToken GetEntityToken(ConfigAbilityActionToken token, IActionTokenConfig actionConfig, IActionTokenTarget target, ActionTokenSourceType actionSrc) => default; // 0x00000001832CF460-0x00000001832CF610
	// [XID] // 0x0000000189BCF790-0x0000000189BCF7B0
	public void OverrideTokenMaxNum(int tokenMaxNum) {} // 0x00000001832D20B0-0x00000001832D2190
	// [XID] // 0x0000000189BD6C00-0x0000000189BD6C20
	public void RecoverTokenMaxNum() {} // 0x00000001832D0A80-0x00000001832D0B20
	// [XID] // 0x0000000189BDE940-0x0000000189BDE960
	private bool IsLowLevelEntity(IActionTokenConfig actionConfig, BaseEntity target) => default; // 0x00000001832D0E90-0x00000001832D0FD0
	// [XID] // 0x0000000189832C40-0x0000000189832C60
	private ConfigAbilityActionToken GetEntityLowLevelToken(IActionTokenConfig actionConfig) => default; // 0x00000001832D25C0-0x00000001832D26C0
	// [XID] // 0x00000001895F27E0-0x00000001895F2800
	private ConfigAbilityActionToken GetSourceActionToken(ActionTokenSourceType actionSrc, IActionTokenConfig actionConfig, IActionTokenTarget target) => default; // 0x00000001832CEA60-0x00000001832CEBC0
	// [XID] // 0x00000001895FA160-0x00000001895FA180
	private bool IsLowLevelDist(IActionTokenConfig actionConfig, IActionTokenTarget target) => default; // 0x00000001832D0620-0x00000001832D07F0
	// [XID] // 0x0000000189A4F230-0x0000000189A4F250
	private bool HandleActionTokenWithEntityLod(ConfigAbilityActionToken token, IActionTokenTarget target) => default; // 0x00000001832D24B0-0x00000001832D25C0
	// [XID] // 0x00000001896092E0-0x0000000189609300
	private ActionTokenType HandleActionTokenWithChannel(IActionTokenConfig actionConfig, ConfigAbilityActionToken token, IActionTokenCache tokenCache, bool handleFromDelayQueue) => default; // 0x00000001832CD690-0x00000001832CD9D0
	// [XID] // 0x00000001899D82D0-0x00000001899D82F0
	private int GetTokenMaxNum(ConfigActionTokenChannel channel) => default; // 0x00000001832CE890-0x00000001832CE990
	// [XID] // 0x0000000189617D90-0x0000000189617DB0
	private void StatisticOverBudgetEffectCount(IActionTokenConfig actionConfig, ConfigAbilityActionToken token, int frameChannelCnt, ConfigActionTokenChannel channel) {} // 0x00000001832D08C0-0x00000001832D0A80
	// [IDTag] // 0x000000018961FA50-0x000000018961FA90
	// [XID] // 0x000000018961FA50-0x000000018961FA90
	private ActionTokenSourceType GetActionTokenSourceType(uint eventId) => default; // 0x00000001832CE1B0-0x00000001832CE280
	// [XID] // 0x0000000189629F80-0x0000000189629FA0
	public bool HandleRemoteActionToken(MPActorAbilityPlugin actorAbilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, UnionAbilityInvokeEntry invokeEntry) => default; // 0x00000001832D22B0-0x00000001832D24B0
	// [XID] // 0x0000000189631760-0x0000000189631780
	private void InitEntityInternalActionConfig() {} // 0x00000001832CE3E0-0x00000001832CE890
	// [XID] // 0x0000000189BCE4A0-0x0000000189BCE4C0
	private EntityInternalBaseConfig GetEntityInternalConfig(EntityInternalAction actionLevel) => default; // 0x00000001832CD9D0-0x00000001832CDAB0
	// [XID] // 0x0000000189640580-0x00000001896405A0
	public bool HandleFireEffectActionToken(EntityInternalAction actionLevel, MonoEffectProxy proxy, BaseEntity owner, string effectName, Vector3 initPos, Quaternion initRot, bool isHitEffect, float scale = 1f /* Metadata: 0x00AEB980 */, Vector3? targetPos = default, BaseEntity targetEntity = null, Transform targetTransform = null, Vector3? targetDir = default, bool indexed = false /* Metadata: 0x00AEB984 */, bool async = false /* Metadata: 0x00AEB985 */) => default; // 0x00000001832D26C0-0x00000001832D2990
	// [XID] // 0x0000000189647F00-0x0000000189647F20
	public bool HandleAttachEffectActionToken(EntityInternalAction actionLevel, int index, uint effectRuntimeID, BaseEntity target, string effectName, Vector3? pos, Quaternion? rot, float scale, bool isHitEffect) => default; // 0x00000001832CFF80-0x00000001832D01C0
	// [XID] // 0x000000018964F5B0-0x000000018964F5D0
	public bool HandleDetachEffectActionToken(EntityInternalAction actionLevel, int index, BaseEntity target) => default; // 0x00000001832D2990-0x00000001832D2AB0
}

