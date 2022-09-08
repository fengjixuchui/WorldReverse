/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using FullInspector;
using IFix.Core;
using MoleMole;
using UniRx;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ActorAbilityPlugin : BaseComponentPlugin // TypeDefIndex: 11979
{
	// Fields
	private List<MonoEffectProxy> _effectProxyListCache; // 0x58
	private List<MonoEffectProxy> _effectProxyListCacheForChangFollowDampTime; // 0x60
	private List<Vector3> _pushedPosList; // 0x68
	protected LCAbility _owner; // 0x70
	[InspectorCollapsedFoldout] // 0x000000018996D100-0x000000018996D130
	[ShowInInspector] // 0x000000018996D100-0x000000018996D130
	protected List<ActorAbility> _appliedAbilities; // 0x78
	protected Dictionary<uint, int> _appliedAbilitiesIndex; // 0x80
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public uint nextValidAbilityID; // 0x88
	protected List<ActorModifier> _appliedModifiers; // 0x90
	protected List<ActorModifier> _deadModifiers; // 0x98
	protected List<ActorModifier> _appliedServerBuffModifiers; // 0xA0
	protected List<ActorModifier> _allAppliedModifiers; // 0xA8
	private bool _isTicking; // 0xB0
	private List<ActorAbility> _tickAbilities; // 0xB8
	private List<ActorAbility> _addTickAbilities; // 0xC0
	private List<ActorAbility> _removeTickAbilities; // 0xC8
	private List<ActorModifier> _tickModifiers; // 0xD0
	private List<ActorModifier> _addTickModifiers; // 0xD8
	private List<ActorModifier> _removeTickModifiers; // 0xE0
	protected Dictionary<EncryptedString, DynamicActorValue<SafeFloat>> _dynamicFloatMap; // 0xE8
	protected bool _isKilled; // 0xF0
	[NonSerialized]
	public LCAbilityElement lcAbilityElement; // 0xF8
	[NonSerialized]
	public LCAbilityState lcAbilityState; // 0x100
	protected TokenManager _tokenMgr; // 0x108
	protected Func<float, object, bool> _hanlderModifierThinkTimerUp; // 0x110
	private static List<ActorAbility> _emptyAppliedAbilities; // 0x00
	private List<Tuple<ActorModifier, TimerReceiver>?> _modifierThinkTimers; // 0x118
	private HashSet<TimerReceiver> _modifierThinkTimersAffectedByTimeScale; // 0x120
	private HashSet<TimerReceiver> _modifierThinkTimersAffectedByAlive; // 0x128
	private Action<EvtEntityTimeScaleChange> _onOwnerTimeScaleChangedCache; // 0x130
	private Action<EvtEntityAliveChange> _onOwnerAliveChangedCache; // 0x138
	private bool _isOnEventing; // 0x140
	private Dictionary<int, List<BaseAbilityMixin>> _onEventMixins; // 0x148
	private List<BaseAbilityMixin> _addOnEventMixins; // 0x150
	private List<BaseAbilityMixin> _removeOnEventMixins; // 0x158
	private bool _isOnEventRemoting; // 0x160
	private Dictionary<int, List<BaseAbilityMixin>> _onEventRemoteMixins; // 0x168
	private List<BaseAbilityMixin> _addOnEventRemoteMixins; // 0x170
	private List<BaseAbilityMixin> _removeOnEventRemoteMixins; // 0x178
	private bool _isOnEventResolveing; // 0x180
	private Dictionary<int, List<BaseAbilityMixin>> _onEventResolvedMixins; // 0x188
	private List<BaseAbilityMixin> _addOnEventResolvedMixins; // 0x190
	private List<BaseAbilityMixin> _removeOnEventResolvedMixins; // 0x198
	private bool _isListenEventing; // 0x1A0
	private Dictionary<int, List<BaseAbilityMixin>> _listenEventMixins; // 0x1A8
	private List<BaseAbilityMixin> _addListenEventMixins; // 0x1B0
	private List<BaseAbilityMixin> _removeListenEventMixins; // 0x1B8
	public bool IsImmuneDebuff; // 0x1C0
	private static List<ActorModifier> _emptyAppliedModifiers; // 0x08
	private Action<EvtEntityReadyPost> _handleServerBuffChangedOnEntityReady; // 0x1C8
	private Dictionary<uint, AvatarDataItem.ServerBuffInfo> _addSBuffsBeforeEntityReady; // 0x1D0
	private Dictionary<uint, AvatarDataItem.ServerBuffInfo> _rmvSBuffsBeforeEntityReady; // 0x1D8
	private SpriteLoadProxy _spriteLoadProxy; // 0x1E0
	protected Dictionary<uint, BaseAttachContainer> _abilityAttachContainers; // 0x1E8
	protected Dictionary<uint, BaseAttachContainer> _modifierAttachContainers; // 0x1F0

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018967B160-0x000000018967B180 */ get => default; } // 0x0000000180E46C30-0x0000000180E4BA10 
	public LCAbility ownerAbility { /* [XID] */ /* 0x00000001896FABF0-0x00000001896FAC10 */ get => default; } // 0x0000000180DFB3E0-0x0000000180DFB480 
	public Dictionary<EncryptedString, DynamicActorValue<SafeFloat>> dynamicFloatMap { /* [XID] */ /* 0x0000000189BCFAF0-0x0000000189BCFB10 */ get => default; } // 0x0000000180E32440-0x0000000180E324F0 
	public bool isDuringInitAbility { get; /* [XID] */ /* 0x00000001896C2580-0x00000001896C25C0 */ private set; } // 0x0000000180DF4850-0x0000000180DF48B0 0x0000000180E13EA0-0x0000000180E13F10
	public bool isDuringChangeAbility { get; /* [XID] */ /* 0x00000001896E30A0-0x00000001896E30E0 */ private set; } // 0x0000000180E165E0-0x0000000180E16640 0x0000000180E16790-0x0000000180E16800
	private SpriteLoadProxy spriteLoadProxy { /* [XID] */ /* 0x00000001897DD580-0x00000001897DD5A0 */ get => default; } // 0x0000000180E0D0E0-0x0000000180E0D1C0 

	// Nested types
	public struct AbilityAttackTarget // TypeDefIndex: 11980
	{
		// Fields
		public BaseEntity entity; // 0x00
		public string lockedPoint; // 0x08
		public float distance; // 0x10
		public float? score; // 0x14

		// Constructors
		public AbilityAttackTarget(BaseEntity entity, string lockedPoint) {
			this.entity = default;
			this.lockedPoint = default;
			distance = default;
			score = default;
		} // 0x00000001816589F0-0x0000000181658A20
	}

	public delegate bool AbilityPredicateHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt); // TypeDefIndex: 11981; 0x00000001816779B0-0x0000000181677DC0

	// Constructors
	public ActorAbilityPlugin() {} // Dummy constructor
	public ActorAbilityPlugin(LCAbility lcAbility) {} // 0x0000000180E46A30-0x0000000180E46C30
	static ActorAbilityPlugin() {} // 0x0000000180E46970-0x0000000180E46A30

	// Methods
	// [XID] // 0x0000000189682AA0-0x0000000189682AC0
	public void FireEffectHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E07CD0-0x0000000180E08110
	// [XID] // 0x000000018968A620-0x000000018968A640
	protected void FireEffectByBornPosRot(FireEffect config, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, Vector3 bornPos, Quaternion bornRot, Vector3 targetDir, BaseEvent evt) {} // 0x0000000180E2FF60-0x0000000180E30850
	// [XID] // 0x0000000189692370-0x0000000189692390
	public void FireEffectToTargetHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DF9830-0x0000000180DF9950
	// [XID] // 0x0000000189699790-0x00000001896997B0
	public void FireHitEffectHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DFEFD0-0x0000000180DFF3C0
	// [XID] // 0x00000001896A0C00-0x00000001896A0C20
	public void FireEffectForStormHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E28650-0x0000000180E28930
	// [XID] // 0x00000001896A81B0-0x00000001896A81D0
	public void AvatarSkillStartHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E09460-0x0000000180E09750
	// [XID] // 0x00000001896AF540-0x00000001896AF560
	public void EntityDoSkillHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DF48B0-0x0000000180DF4A40
	// [XID] // 0x00000001896B6BE0-0x00000001896B6C00
	public void AvatarEnterFocusHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DF76D0-0x0000000180DF7940
	// [XID] // 0x00000001896BDE00-0x00000001896BDE20
	public void AvatarExitFocusHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E24550-0x0000000180E247C0
	// [XID] // 0x00000001896C5710-0x00000001896C5730
	public void AvatarExitClimbHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DF60D0-0x0000000180DF6270
	// [XID] // 0x00000001896CCD60-0x00000001896CCD80
	public void AvatarCameraParamHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E447C0-0x0000000180E449F0
	// [XID] // 0x00000001896D3FA0-0x00000001896D3FC0
	public void AvatarEnterCameraShotHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E10140-0x0000000180E10480
	// [XID] // 0x00000001896DB900-0x00000001896DB920
	public void AvatarExitCameraShotHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E03330-0x0000000180E03610
	// [XID] // 0x00000001896E30E0-0x00000001896E3100
	public void PlayEmoSyncHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E377C0-0x0000000180E37AD0
	// [XID] // 0x00000001896EA660-0x00000001896EA680
	public void ControlEmotionHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E31650-0x0000000180E31A40
	// [XID] // 0x00000001896F1650-0x00000001896F1670
	public void SpawnAttachHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E236F0-0x0000000180E23900
	// [XID] // 0x00000001896F9020-0x00000001896F9040
	public void TurnDirectionHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DEE320-0x0000000180DEE570
	// [XID] // 0x0000000189700A30-0x0000000189700A50
	public void TurnDirectionToPosHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E449F0-0x0000000180E44FB0
	// [XID] // 0x00000001897080A0-0x00000001897080C0
	public void SetCameraLockTimeHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E18B70-0x0000000180E18E40
	// [XID] // 0x000000018970FB50-0x000000018970FB70
	public void ApplyModifierHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E2F7B0-0x0000000180E2FA20
	// [XID] // 0x0000000189716D10-0x0000000189716D30
	public void ApplyLevelModifierHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E398B0-0x0000000180E39B90
	// [XID] // 0x000000018971E760-0x000000018971E780
	public void RemoveModifierHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E30AB0-0x0000000180E30D50
	// [XID] // 0x0000000189725F00-0x0000000189725F20
	public void RemoveUniqueModifierHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DEAD10-0x0000000180DEAF70
	// [XID] // 0x000000018972D410-0x000000018972D430
	public void AttachModifierHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DFC8C0-0x0000000180DFCB70
	// [XID] // 0x0000000189734B30-0x0000000189734B50
	public void FireMonsterBeingHitAfterImageHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E02420-0x0000000180E02760
	// [XID] // 0x000000018973C720-0x000000018973C740
	public void FireSubEmitterEffectHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E32760-0x0000000180E32B70
	// [XID] // 0x0000000189743C40-0x0000000189743C60
	public void AttachEffectHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E10480-0x0000000180E106F0
	// [XID] // 0x000000018974B790-0x000000018974B7B0
	protected void AttachEffectByBornPosRot(AttachEffect config, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, Vector3 bornPos, Quaternion bornRot, BaseEvent evt) {} // 0x0000000180E37310-0x0000000180E375D0
	// [XID] // 0x0000000189752BD0-0x0000000189752BF0
	private void PostAttachHandler(int effectIndex, AttachEffect config) {} // 0x0000000180E2B080-0x0000000180E2B1B0
	// [XID] // 0x0000000189759F40-0x0000000189759F60
	public void AddGlobalValueHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DF1EC0-0x0000000180DF24E0
	// [XID] // 0x0000000189761CC0-0x0000000189761CE0
	public void SetGlobalValueHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DEB220-0x0000000180DEB850
	// [XID] // 0x0000000189768FD0-0x0000000189768FF0
	public void MultiplyGlobalValueHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E1B980-0x0000000180E1BFB0
	// [XID] // 0x0000000189770770-0x0000000189770790
	public void SetGobalValueListHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E16E40-0x0000000180E17350
	// [XID] // 0x0000000189777F10-0x0000000189777F30
	public void CopyGlobalValueHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E3B380-0x0000000180E3B900
	// [XID] // 0x000000018977F480-0x000000018977F4A0
	public void AddGlobalValueToTargetHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E38DD0-0x0000000180E39350
	// [XID] // 0x0000000189786E80-0x0000000189786EA0
	public void SetGlobalValueToOverrideMapHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E30850-0x0000000180E30AB0
	// [XID] // 0x000000018978E4C0-0x000000018978E4E0
	public void SetRandomOverrideMapValueHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E1ADD0-0x0000000180E1AF90
	// [XID] // 0x0000000189795C00-0x0000000189795C20
	public void SetRandomOverrideMapValue_AuthorityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x0000000180E36860-0x0000000180E36AB0
	// [XID] // 0x000000018979DEF0-0x000000018979DF10
	public void SetCrystalShieldHpToOverrideMapHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E17EA0-0x0000000180E182D0
	// [XID] // 0x00000001897A5410-0x00000001897A5430
	public void SetOverrideMapValueHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E0DE20-0x0000000180E0DFC0
	// [XID] // 0x00000001897ACA60-0x00000001897ACA80
	public void SetSystemValueToOverrideMapHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E3A850-0x0000000180E3AC10
	// [XID] // 0x00000001897B47C0-0x00000001897B47E0
	public void SetGlobalValueByTargetDistanceHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DF6FD0-0x0000000180DF7360
	// [XID] // 0x00000001897BC750-0x00000001897BC770
	public void ClearGlobalValueHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E08FC0-0x0000000180E092A0
	// [XID] // 0x00000001897C3BD0-0x00000001897C3BF0
	public void SumTargetWeightToSelfGlobalValueHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DFE4B0-0x0000000180DFE7C0
	// [XID] // 0x00000001897CB500-0x00000001897CB520
	public void SetGlobalPosHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E384C0-0x0000000180E38880
	// [XID] // 0x00000001897D2BE0-0x00000001897D2C00
	public void AddGlobalPosHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E10A50-0x0000000180E10E30
	// [XID] // 0x00000001897DA980-0x00000001897DA9A0
	public void ClearGlobalPosHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DFC170-0x0000000180DFC430
	// [XID] // 0x00000001897E1D60-0x00000001897E1D80
	public void SetGlobalDirHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DF5650-0x0000000180DF5AE0
	// [XID] // 0x00000001897E9530-0x00000001897E9550
	protected float HealHP_CalculateHPAmount(ActorAbility instancedAbility, HealHP config, BaseEntity target) => default; // 0x0000000180E182D0-0x0000000180E188B0
	// [XID] // 0x00000001897F1100-0x00000001897F1120
	public void HealHPHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E25180-0x0000000180E255C0
	// [XID] // 0x00000001897F89E0-0x00000001897F8A00
	protected float LoseHP_CalculateHPAmount(ActorAbility instancedAbility, LoseHP config, BaseEntity target) => default; // 0x0000000180E19760-0x0000000180E19C40
	// [XID] // 0x00000001898000A0-0x00000001898000C0
	public void LoseHPHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E23B00-0x0000000180E23C90
	// [XID] // 0x0000000189807760-0x0000000189807780
	protected float HealSP_CalculateHPAmount(ActorAbility instancedAbility, HealSP config, BaseEntity target) => default; // 0x0000000180E3E210-0x0000000180E3E2F0
	// [XID] // 0x000000018980EDC0-0x000000018980EDE0
	public void HealSPHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E31540-0x0000000180E31650
	// [XID] // 0x0000000189816470-0x0000000189816490
	public void CameraShakeHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E14B40-0x0000000180E14F80
	// [XID] // 0x000000018981DE30-0x000000018981DE50
	public void CameraRadialBlurHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E16BC0-0x0000000180E16E40
	// [XID] // 0x00000001898251E0-0x0000000189825200
	public void SetAIParamHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E42830-0x0000000180E42940
	// [XID] // 0x000000018982CBD0-0x000000018982CBF0
	public void TimeSlowHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E3AFF0-0x0000000180E3B200
	// [XID] // 0x0000000189834320-0x0000000189834340
	public void PredicatedHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E37E50-0x0000000180E38010
	// [XID] // 0x000000018983B6B0-0x000000018983B6D0
	public void SetAnimatorBoolHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E3B200-0x0000000180E3B380
	// [XID] // 0x0000000189843070-0x0000000189843090
	public void SetAnimatorIntHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E071A0-0x0000000180E07340
	// [XID] // 0x000000018984A2D0-0x000000018984A2F0
	public void ForceTriggerJumpHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DEB9B0-0x0000000180DEBAF0
	// [XID] // 0x0000000189851910-0x0000000189851930
	public void EnableRocketJumpHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E1A760-0x0000000180E1A970
	// [XID] // 0x0000000189858FB0-0x0000000189858FD0
	public void EnableAfterImageHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DF7940-0x0000000180DF7AC0
	// [XID] // 0x00000001898601B0-0x00000001898601D0
	public void SetAnimatorFloatHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DF2880-0x0000000180DF2AE0
	// [XID] // 0x0000000189867870-0x0000000189867890
	public void DamageByAttackValueHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E45B60-0x0000000180E46260
	// [XID] // 0x000000018986EFA0-0x000000018986EFC0
	protected void _TriggerAbilityCommon(TriggerAbility config, ActorAbility instancedAbility, BaseEntity target, uint otherID, AttackResult.HitCollsion? hitCollision) {} // 0x0000000180E08B90-0x0000000180E08FC0
	// [XID] // 0x0000000189876490-0x00000001898764B0
	protected uint _TriggerAbilityResolveOtherID(TriggerAbility config, BaseEvent evt) => default; // 0x0000000180DFE350-0x0000000180DFE4B0
	// [XID] // 0x000000018987E070-0x000000018987E090
	public void TriggerAbilityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E23D90-0x0000000180E23F60
	// [XID] // 0x00000001898850C0-0x00000001898850E0
	public void DebugLogHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E2C940-0x0000000180E2CCE0
	// [XID] // 0x000000018988C6A0-0x000000018988C6C0
	public void FireAudioHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E08110-0x0000000180E08220
	// [XID] // 0x0000000189893BF0-0x0000000189893C10
	public void SetAnimatorTriggerHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E1AF90-0x0000000180E1B1F0
	// [XID] // 0x000000018989B310-0x000000018989B330
	public void ResetAnimatorTriggerHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DF0150-0x0000000180DF02A0
	// [XID] // 0x00000001898A2750-0x00000001898A2770
	public void TriggerBulletHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E28BD0-0x0000000180E29640
	// [XID] // 0x00000001898A9CC0-0x00000001898A9CE0
	public void TriggerAttackEventHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E02CB0-0x0000000180E03080
	// [XID] // 0x00000001898B1770-0x00000001898B1790
	public void TriggerAttackTargetMapEventHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E06020-0x0000000180E06390
	// [XID] // 0x00000001898B90C0-0x00000001898B90E0
	public void CreateItemHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DF45B0-0x0000000180DF47A0
	// [XID] // 0x00000001898C0660-0x00000001898C0680
	public void CreateGadgetHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E2E250-0x0000000180E2EB90
	// [XID] // 0x00000001898C7E40-0x00000001898C7E60
	protected bool CreateEntityCommon(CreateEntity config, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEvent evt, BaseEntity target, out Vector3 bornPos, out Quaternion bornRot, out Collider hitCollider) {
		bornPos = default;
		bornRot = default;
		hitCollider = default;
		return default;
	} // 0x0000000180DF0C00-0x0000000180DF0F00
	// [XID] // 0x00000001898CF660-0x00000001898CF680
	public void CreateMovingPlatformHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E0B870-0x0000000180E0B960
	// [XID] // 0x00000001898D6E90-0x00000001898D6EB0
	public void TryTriggerPlatformStartMove(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E25EB0-0x0000000180E26870
	// [XID] // 0x00000001898DECD0-0x00000001898DECF0
	public void KillGadgetHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E06390-0x0000000180E06970
	// [XID] // 0x00000001898E6350-0x00000001898E6370
	public void KillSelfHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DF6C50-0x0000000180DF6FD0
	// [XID] // 0x00000001898EDC20-0x00000001898EDC40
	public void TriggerAudioHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DFF3C0-0x0000000180DFFA30
	// [XID] // 0x00000001898F55D0-0x00000001898F55F0
	public void TriggerDropEquipPartsHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E24A30-0x0000000180E24C10
	// [XID] // 0x00000001898FCCE0-0x00000001898FCD00
	public void TriggerThrowEquipPartHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DF2F60-0x0000000180DF3350
	// [XID] // 0x0000000189904680-0x00000001899046A0
	public void TriggerCreateGadgetToEquipPartHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DFE000-0x0000000180DFE200
	// [XID] // 0x000000018990BE40-0x000000018990BE60
	public void TriggerAuxWeaponTransHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DFAE00-0x0000000180DFAFC0
	// [XID] // 0x0000000189913800-0x0000000189913820
	public void TriggerGadgetInteractiveHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E36F50-0x0000000180E37140
	// [XID] // 0x000000018991B160-0x000000018991B180
	public void DropSubfieldHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E2AE50-0x0000000180E2B080
	// [XID] // 0x00000001899227B0-0x00000001899227D0
	public void EnableGadgetInteeHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E000D0-0x0000000180E00300
	// [XID] // 0x0000000189929EC0-0x0000000189929EE0
	public void RemoveVelocityForceHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E43330-0x0000000180E43520
	// [XID] // 0x00000001899315F0-0x0000000189931610
	public void ExecuteGroupTriggerHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E0C560-0x0000000180E0C7F0
	// [XID] // 0x0000000189938D40-0x0000000189938D60
	public void TriggerSetVisibleHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E092A0-0x0000000180E09460
	// [XID] // 0x00000001899404F0-0x0000000189940510
	public void TriggerSetCastShadowHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E0A2F0-0x0000000180E0A490
	// [XID] // 0x0000000189947B70-0x0000000189947B90
	public void TriggerSetPassThroughHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E24C10-0x0000000180E24DC0
	// [XID] // 0x000000018994F230-0x000000018994F250
	public void TriggerSetSetRenderersEnableHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DF24E0-0x0000000180DF26C0
	// [XID] // 0x00000001899567E0-0x0000000189956800
	public void TriggerHideWeaponHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DFD960-0x0000000180DFDBE0
	// [XID] // 0x000000018995E230-0x000000018995E250
	public void TriggerTauntHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E3D720-0x0000000180E3DA50
	// [XID] // 0x0000000189965BA0-0x0000000189965BC0
	public void TriggerSetChestLockHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E0B960-0x0000000180E0BB40
	// [XID] // 0x000000018996D210-0x000000018996D230
	public void ClearLockTargetHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E43520-0x0000000180E43650
	// [XID] // 0x0000000189974AD0-0x0000000189974AF0
	public void SetPoseBoolHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E09DA0-0x0000000180E09F50
	// [XID] // 0x000000018997BFE0-0x000000018997C000
	public void SetPoseIntHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E08900-0x0000000180E08AB0
	// [XID] // 0x0000000189983C30-0x0000000189983C50
	public void SetPoseFloatHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E23FE0-0x0000000180E241A0
	// [XID] // 0x000000018998B500-0x000000018998B520
	public void TriggerFaceAnimationHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E030E0-0x0000000180E03250
	// [XID] // 0x0000000189993080-0x00000001899930A0
	public void EnableCrashDamageHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DFBB10-0x0000000180DFBC90
	// [XID] // 0x000000018999ABD0-0x000000018999ABF0
	public void TriggerSetCrashDamageHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E23900-0x0000000180E23B00
	// [XID] // 0x00000001899A2330-0x00000001899A2350
	protected float ResolveCrashDamage(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E29C20-0x0000000180E29EE0
	// [XID] // 0x00000001899A9B80-0x00000001899A9BA0
	protected void SetCrashDamageHandlerCommon(SetCrashDamage config, ActorAbility instancedAbility, BaseEntity target, float damage, Vector3 hitPos) {} // 0x0000000180E01790-0x0000000180E01AD0
	// [XID] // 0x00000001899B1540-0x00000001899B1560
	public void TryFindBlinkPointHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E32B70-0x0000000180E32CB0
	// [XID] // 0x00000001899B89C0-0x00000001899B89E0
	protected bool TryFindBlinkPointCommon(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref VCAnimatorMove vcMove) => default; // 0x0000000180E3BB50-0x0000000180E3BF70
	// [XID] // 0x00000001899C0290-0x00000001899C02B0
	public void TryFindBlinkPointByBornHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E25B80-0x0000000180E25CC0
	// [XID] // 0x00000001899C7B10-0x00000001899C7B30
	protected bool TryFindBlinkPointByBornCommon(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref VCAnimatorMove vcMove) => default; // 0x0000000180E43A50-0x0000000180E43FB0
	// [XID] // 0x00000001899CF330-0x00000001899CF350
	public void DoBlinkHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E13C10-0x0000000180E13EA0
	// [XID] // 0x00000001899D67D0-0x00000001899D67F0
	public void AvatarDoBlinkHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E424D0-0x0000000180E42660
	// [XID] // 0x00000001899DDE90-0x00000001899DDEB0
	public void EnableHitBoxByNameHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E20BB0-0x0000000180E20E20
	// [XID] // 0x00000001899E5C30-0x00000001899E5C50
	public void EnablePushColliderNameHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E3AC10-0x0000000180E3AE60
	// [XID] // 0x00000001899ECCC0-0x00000001899ECCE0
	public void EnableSceneTransformByNameHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E22FD0-0x0000000180E232D0
	// [XID] // 0x00000001899F4A20-0x00000001899F4A40
	public void GenerateElemBallHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DFCD80-0x0000000180DFD340
	// [XID] // 0x00000001899FC060-0x00000001899FC080
	public void RandomedHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E2EE30-0x0000000180E2F000
	// [XID] // 0x0000000189A03470-0x0000000189A03490
	public void HideUIBillBoardHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E38880-0x0000000180E389F0
	// [XID] // 0x0000000189A0AB10-0x0000000189A0AB30
	public void SendEffectTriggerHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E40A90-0x0000000180E40E60
	// [XID] // 0x0000000189A12280-0x0000000189A122A0
	public void ChangeFollowDampTimeHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E26870-0x0000000180E26C30
	// [XID] // 0x0000000189A19730-0x0000000189A19750
	public void SetSelfAttackTargetHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000180E26C30-0x0000000180E27040
	// [XID] // 0x0000000189A20DB0-0x0000000189A20DD0
	public void EnableHeadControlHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DF92A0-0x0000000180DF9430
	// [XID] // 0x0000000189A280E0-0x0000000189A28100
	public void EnablePartControlHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DFBC90-0x0000000180DFBEC0
	// [XID] // 0x0000000189A2F7F0-0x0000000189A2F810
	public void ForceInitMassiveEntityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E12610-0x0000000180E12A00
	// [XID] // 0x0000000189A37260-0x0000000189A37280
	public void StartDitherHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E15820-0x0000000180E159B0
	// [XID] // 0x0000000189A3E930-0x0000000189A3E950
	public void SummonHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E0C7F0-0x0000000180E0D0E0
	// [XID] // 0x0000000189A46020-0x0000000189A46040
	public void AttachAbilityStateResistanceHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E2FBD0-0x0000000180E2FF60
	// [XID] // 0x0000000189A4D730-0x0000000189A4D750
	public void GuidePaimonDisappearEndHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E1A970-0x0000000180E1AB00
	// [XID] // 0x0000000189A54FD0-0x0000000189A54FF0
	public void FireAISoundEventHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E44240-0x0000000180E44400
	// [XID] // 0x0000000189A5C8E0-0x0000000189A5C900
	public void AddElementDurabilityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DFBEC0-0x0000000180DFC170
	// [XID] // 0x0000000189A641B0-0x0000000189A641D0
	public void SetPartControlTargetHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DF5460-0x0000000180DF5650
	// [XID] // 0x0000000189A6BB60-0x0000000189A6BB80
	public void SetAISkillCDAvailableNowHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E42660-0x0000000180E42830
	// [XID] // 0x0000000189A73320-0x0000000189A73340
	public void SetAISkillGCDHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E27AD0-0x0000000180E27C30
	// [XID] // 0x0000000189A7AE10-0x0000000189A7AE30
	public void ReTriggerAISkillInitialCDHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DF5070-0x0000000180DF5240
	// [XID] // 0x0000000189A823A0-0x0000000189A823C0
	public void EnableAIStealthyHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E05CE0-0x0000000180E05E40
	// [XID] // 0x0000000189A89CC0-0x0000000189A89CE0
	public void SetPaimonLookAtCameraHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E0A490-0x0000000180E0A6B0
	// [XID] // 0x0000000189A913C0-0x0000000189A913E0
	public void PaimonActionHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E445E0-0x0000000180E447C0
	// [XID] // 0x0000000189A98F90-0x0000000189A98FB0
	public void SetPaimonLookAtAvatarHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E255C0-0x0000000180E257E0
	// [XID] // 0x0000000189AA0120-0x0000000189AA0140
	public void SetPaimonTempOffsetHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E02A80-0x0000000180E02CB0
	// [XID] // 0x0000000189AA7910-0x0000000189AA7930
	public void UnlockSkillHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DEF450-0x0000000180DEF5B0
	// [XID] // 0x0000000189AAF150-0x0000000189AAF170
	public void SetKeepInAirVelocityForceHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E2ACC0-0x0000000180E2AE50
	// [XID] // 0x0000000189AB69F0-0x0000000189AB6A10
	public void ForceAirStateFlyHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DFB7D0-0x0000000180DFB930
	// [XID] // 0x0000000189ABE4E0-0x0000000189ABE500
	public void ToNearstAnchorPointHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DEE710-0x0000000180DEEA10
	// [XID] // 0x0000000189AC6050-0x0000000189AC6070
	public void PushDvalinS01ProcessHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E31D50-0x0000000180E320D0
	// [XID] // 0x0000000189ACD5E0-0x0000000189ACD600
	public void SetDvalinS01FlyStateHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E14120-0x0000000180E14310
	// [XID] // 0x0000000189AD5380-0x0000000189AD53A0
	public void RegistToStageScriptHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E259A0-0x0000000180E25B80
	// [XID] // 0x0000000189ADCCF0-0x0000000189ADCD10
	public void SyncToStageScriptHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E0B110-0x0000000180E0B2F0
	// [XID] // 0x0000000189AE4560-0x0000000189AE4580
	public void SetEmissionScalerHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E1C3A0-0x0000000180E1C9D0
	// [XID] // 0x0000000189AEBCD0-0x0000000189AEBCF0
	public void AddAvatarSkillInfoHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E40740-0x0000000180E408D0
	// [XID] // 0x0000000189AF3700-0x0000000189AF3720
	public void RemoveAvatarSkillInfoHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DEC870-0x0000000180DEC9F0
	// [XID] // 0x0000000189AFAF60-0x0000000189AFAF80
	public void ShowScreenEffectHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DFDBE0-0x0000000180DFDDD0
	// [XID] // 0x0000000189B02580-0x0000000189B025A0
	public void SetCanDieImmediatelyHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E1C240-0x0000000180E1C3A0
	// [XID] // 0x0000000189B09B20-0x0000000189B09B40
	public void PlayEmojiBubbleHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E15290-0x0000000180E15400
	// [XID] // 0x0000000189B115A0-0x0000000189B115C0
	public void AttachBulletAimPointHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DEB850-0x0000000180DEB9B0
	// [XID] // 0x0000000189B187B0-0x0000000189B187D0
	public void EnableBulletCollisionPluginTriggerHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E007F0-0x0000000180E00970
	// [XID] // 0x0000000189B1FE70-0x0000000189B1FE90
	public void ModifyAvatarSkillCDHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E04100-0x0000000180E04570
	// [XID] // 0x0000000189B275C0-0x0000000189B275E0
	public void ResetAbilitySpecialHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E29EE0-0x0000000180E2A070
	// [XID] // 0x0000000189B2E7A0-0x0000000189B2E7C0
	public void SetNeuronEnableHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E32EC0-0x0000000180E33030
	// [XID] // 0x0000000189B35E50-0x0000000189B35E70
	public void SetNeuronMuteHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E0D830-0x0000000180E0D9A0
	// [XID] // 0x0000000189B3D5A0-0x0000000189B3D5C0
	public void EnterCameraLockHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E32330-0x0000000180E32440
	// [XID] // 0x0000000189B45440-0x0000000189B45460
	public void ShowUICombatBarHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DEE070-0x0000000180DEE320
	// [XID] // 0x0000000189B4CA30-0x0000000189B4CA50
	public void EnableAvatarFlyStateTrailHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DF3350-0x0000000180DF34E0
	// [XID] // 0x0000000189B541A0-0x0000000189B541C0
	public void ShowReminderHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E21D10-0x0000000180E21EC0
	// [XID] // 0x0000000189B5BC00-0x0000000189B5BC20
	public void UpdateReactionDamageHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DF07F0-0x0000000180DF0C00
	// [XID] // 0x0000000189B63000-0x0000000189B63020
	public void ExecuteGadgetLuaHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E11730-0x0000000180E11910
	// [XID] // 0x0000000189B6A970-0x0000000189B6A990
	public void ResetAIAttackTargetHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DFC5A0-0x0000000180DFC6E0
	// [XID] // 0x0000000189B721E0-0x0000000189B72200
	public void ResetAIResistTauntLevelHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E36AB0-0x0000000180E36C10
	// [XID] // 0x0000000189B795D0-0x0000000189B795F0
	public void SetWeaponBindStateHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E22210-0x0000000180E22560
	// [XID] // 0x0000000189B80970-0x0000000189B80990
	public void SetWeaponAttachPointRealNameHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E3AE60-0x0000000180E3AFF0
	// [XID] // 0x0000000189B885C0-0x0000000189B885E0
	public void EnableMainInterfaceHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E35790-0x0000000180E35980
	// [XID] // 0x0000000189B8F7E0-0x0000000189B8F800
	public void SetAvatarCanShakeOffHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E36100-0x0000000180E36360
	// [XID] // 0x0000000189B96D40-0x0000000189B96D60
	public void ChangePlayModeHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E0D6A0-0x0000000180E0D830
	// [XID] // 0x0000000189B9E1B0-0x0000000189B9E1D0
	public void EnableCameraDofHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E10E30-0x0000000180E10F90
	// [XID] // 0x0000000189BA5AB0-0x0000000189BA5AD0
	public void EnableHitAutoRedirectHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E1D780-0x0000000180E1D8E0
	// [XID] // 0x0000000189BACDC0-0x0000000189BACDE0
	public void CalcDvalinS04RebornPointHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E0AAA0-0x0000000180E0AF30
	// [XID] // 0x0000000189BB46D0-0x0000000189BB46F0
	public void TriggerPlayerDieHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E3A550-0x0000000180E3A700
	// [XID] // 0x0000000189BBBCB0-0x0000000189BBBCD0
	public void ResetEnviroEularHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DEAF70-0x0000000180DEB220
	// [XID] // 0x0000000189BC3B50-0x0000000189BC3B70
	public void ClearEnduraHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E178C0-0x0000000180E17A30
	// [XID] // 0x0000000189BCB300-0x0000000189BCB320
	public void SetSurroundAnchorHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E188B0-0x0000000180E18B70
	// [XID] // 0x0000000189BD28F0-0x0000000189BD2910
	public void SetCombatFixedMovePointHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E1D340-0x0000000180E1D5F0
	// [XID] // 0x0000000189BD9E50-0x0000000189BD9E70
	public void RushMoveHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E3DD40-0x0000000180E3E210
	// [XID] // 0x00000001895E6970-0x00000001895E6990
	public void SetAvatarHitBucketsHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DF8460-0x0000000180DF86A0
	// [XID] // 0x00000001895EE490-0x00000001895EE4B0
	public void ResetAvatarHitBucketsHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E192C0-0x0000000180E194C0
	// [XID] // 0x00000001895F5C10-0x00000001895F5C30
	public void SetAISkillCDMultiplierHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E09750-0x0000000180E098B0
	// [XID] // 0x00000001895FD130-0x00000001895FD150
	public void RegisterAIActionPointHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DF18D0-0x0000000180DF1B10
	// [XID] // 0x0000000189604B10-0x0000000189604B30
	public void ReleaseAIActionPointHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E42BF0-0x0000000180E42E40
	// [XID] // 0x000000018960C380-0x000000018960C3A0
	public void BroadcastNeuronStimulateHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DFE7C0-0x0000000180DFEB90
	// [XID] // 0x00000001896139E0-0x0000000189613A00
	public void IssueCommandHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DEEC20-0x0000000180DEEDF0
	// [XID] // 0x000000018961B2B0-0x000000018961B2D0
	public void ResetAIThreatBroadcastRangeHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E07820-0x0000000180E079A0
	// [XID] // 0x0000000189622780-0x00000001896227A0
	public void SetAIHitFeelingHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E13510-0x0000000180E13670
	// [XID] // 0x000000018962A120-0x000000018962A140
	public void SetVelocityIgnoreAirGYHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DEE570-0x0000000180DEE710
	// [XID] // 0x00000001896318C0-0x00000001896318E0
	public void RepeatedHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E07340-0x0000000180E07570
	// [XID] // 0x0000000189639300-0x0000000189639320
	public void SetEntityScaleHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DF63B0-0x0000000180DF65B0
	// [XID] // 0x0000000189640740-0x0000000189640760
	public void CallLuaTaskHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E2A070-0x0000000180E2A310
	// [XID] // 0x0000000189648060-0x0000000189648080
	public void DungeonFogEffectsHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E0FE60-0x0000000180E10140
	// [XID] // 0x000000018964F710-0x000000018964F730
	public void DoTileActionHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E3B900-0x0000000180E3BB50
	// [XID] // 0x00000001896570E0-0x0000000189657100
	public void DoWatcherSystemActionHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E1BFB0-0x0000000180E1C240
	// [XID] // 0x000000018965E7D0-0x000000018965E7F0
	public void ShowProgressBarActionHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E16210-0x0000000180E16360
	// [XID] // 0x0000000189665DE0-0x0000000189665E00
	public void PushPosHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E27270-0x0000000180E27790
	// [XID] // 0x000000018966D590-0x000000018966D5B0
	public void ClearPosHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E25010-0x0000000180E25180
	// [XID] // 0x0000000189675550-0x0000000189675570
	public void GetPosHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E0BFD0-0x0000000180E0C560
	// [XID] // 0x000000018967CC00-0x000000018967CC20
	public void UseSkillEliteSetHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E417E0-0x0000000180E41950
	// [XID] // 0x00000001896841E0-0x0000000189684200
	public void FixedMonsterRushMoveHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E0EAE0-0x0000000180E0F1A0
	// [XID] // 0x000000018968BE90-0x000000018968BEB0
	public void FixedAvatarRushMoveHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E04570-0x0000000180E04C20
	// [XID] // 0x0000000189693A30-0x0000000189693A50
	public void AttachElementTypeResistanceHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DEFDD0-0x0000000180DEFF50
	// [XID] // 0x000000018969AE30-0x000000018969AE50
	public void FireGainCrystalSeedEventHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E2DA60-0x0000000180E2DBF0
	// [XID] // 0x00000001896A28C0-0x00000001896A28E0
	public void EnableMonsterMoveOnWaterHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E2FA20-0x0000000180E2FBD0
	// [XID] // 0x00000001896A9A80-0x00000001896A9AA0
	public void SyncEntityPositionByNormalizedTimeHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E28350-0x0000000180E28650
	// [XID] // 0x00000001896B0A40-0x00000001896B0A60
	public void ShowExtraAbilityHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E375D0-0x0000000180E377C0
	// [XID] // 0x00000001896B8510-0x00000001896B8530
	public void SetExtraAbilityEnableHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180DFEB90-0x0000000180DFECE0
	// [XID] // 0x00000001896BF5C0-0x00000001896BF5E0
	public void SetExtraAbilityStateHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E098B0-0x0000000180E09A80
	// [XID] // 0x00000001896C6F90-0x00000001896C6FB0
	public void ForceUseSkillSuccessHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E42F60-0x0000000180E431A0
	// [XID] // 0x00000001896CE5E0-0x00000001896CE600
	public void DoWidgetSystemActionHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E24220-0x0000000180E24450
	// [XID] // 0x00000001896D5AD0-0x00000001896D5AF0
	public void ChangeGadgetUIInteractHintHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E431A0-0x0000000180E43330
	// [XID] // 0x00000001896DCFD0-0x00000001896DCFF0
	public void BanEntityMarkHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E37140-0x0000000180E37310
	// [XID] // 0x00000001896E4990-0x00000001896E49B0
	public void FireUIEffectHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E2C5F0-0x0000000180E2C7D0
	// [XID] // 0x00000001896EBDF0-0x00000001896EBE10
	public void SetSkillAnchorHandler(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E31090-0x0000000180E312D0
	// [XID] // 0x00000001896F3470-0x00000001896F3490
	public void EnablePositionSynchronization(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) {} // 0x0000000180E17A30-0x0000000180E17B90
	// [XID] // 0x000000018981F8B0-0x000000018981F8D0
	public void TryAddTickAbility(ActorAbility ability) {} // 0x0000000180E13670-0x0000000180E13750
	// [XID] // 0x0000000189709960-0x0000000189709980
	private void CacheAddTickAbility(ActorAbility ability) {} // 0x0000000180DF7360-0x0000000180DF7490
	// [XID] // 0x00000001897113D0-0x00000001897113F0
	private void DoAddTickAbility(ActorAbility ability) {} // 0x0000000180E16800-0x0000000180E16950
	// [XID] // 0x0000000189718900-0x0000000189718920
	public void TryRemoveTickAbility(ActorAbility ability) {} // 0x0000000180E44FB0-0x0000000180E45070
	// [XID] // 0x0000000189720060-0x0000000189720080
	private void CacheRemoveTickAbility(ActorAbility ability) {} // 0x0000000180E3D5F0-0x0000000180E3D720
	// [XID] // 0x0000000189901970-0x0000000189901990
	private void DoRemoveTickAbility(ActorAbility ability) {} // 0x0000000180E149F0-0x0000000180E14B40
	// [XID] // 0x000000018972ECF0-0x000000018972ED10
	public void TryAddTickModifier(ActorModifier modifier) {} // 0x0000000180E1AB00-0x0000000180E1ABE0
	// [XID] // 0x0000000189A8E7F0-0x0000000189A8E810
	private void CacheAddTickModifier(ActorModifier modifier) {} // 0x0000000180E15D90-0x0000000180E15EC0
	// [XID] // 0x0000000189A95C70-0x0000000189A95C90
	private void DoAddTickModifier(ActorModifier modifier) {} // 0x0000000180E12B90-0x0000000180E12CE0
	// [XID] // 0x0000000189745590-0x00000001897455B0
	public void TryRemoveTickModifier(ActorModifier modifier) {} // 0x0000000180E337F0-0x0000000180E338B0
	// [XID] // 0x000000018974D090-0x000000018974D0B0
	private void CacheRemoveTickModifier(ActorModifier modifier) {} // 0x0000000180DEBCB0-0x0000000180DEBDE0
	// [XID] // 0x0000000189918170-0x0000000189918190
	private void DoRemoveTickModifier(ActorModifier modifier) {} // 0x0000000180DFE200-0x0000000180DFE350
	// [XID] // 0x000000018975B830-0x000000018975B850
	private void HandleTickList(float inDeltaTime) {} // 0x0000000180DF5BA0-0x0000000180DF6050
	// [XID] // 0x0000000189763260-0x0000000189763280
	private void RemoveTickList() {} // 0x0000000180E3CEA0-0x0000000180E3D000
	// [IDTag] // 0x000000018976AA30-0x000000018976AA70
	// [XID] // 0x000000018976AA30-0x000000018976AA70
	public void RefreshContextTickOnSetMixinEnabled(ActorAbility ability) {} // 0x0000000180E16360-0x0000000180E164A0
	// [IDTag] // 0x0000000189774CE0-0x0000000189774D20
	// [XID] // 0x0000000189774CE0-0x0000000189774D20
	public void RefreshContextTickOnSetMixinEnabled(ActorModifier modifier) {} // 0x0000000180E164A0-0x0000000180E165E0
	// [XID] // 0x0000000189786E60-0x0000000189786E80
	public override void Init() {} // 0x0000000180E19EC0-0x0000000180E1A0C0
	// [XID] // 0x000000018978E4A0-0x000000018978E4C0
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000180E46260-0x0000000180E46490
	// [XID] // 0x0000000189795BE0-0x0000000189795C00
	public void ReAddAbilityActionsAndMixins() {} // 0x0000000180E2F000-0x0000000180E2F1F0
	// [XID] // 0x0000000189B4E4B0-0x0000000189B4E4D0
	public void ReAddAbilityActionsAndMixin(ActorAbility ability, bool reInitOverrideMap = true /* Metadata: 0x00AEB2D4 */) {} // 0x0000000180E2F4F0-0x0000000180E2F7B0
	// [XID] // 0x00000001897A53F0-0x00000001897A5410
	private RemoveAbilityReason GetRemoveReasonOnEntityClear(BaseEntity.ClearReason clearReason) => default; // 0x0000000180E1CD60-0x0000000180E1CE30
	// [XID] // 0x00000001897ACA40-0x00000001897ACA60
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000180DF8CD0-0x0000000180DF9080
	// [XID] // 0x00000001897B47A0-0x00000001897B47C0
	public override void OnEnable() {} // 0x0000000180E3E5D0-0x0000000180E3E680
	// [XID] // 0x00000001897BC730-0x00000001897BC750
	public override void OnDisable() {} // 0x0000000180E3E520-0x0000000180E3E5D0
	// [XID] // 0x00000001897C3BB0-0x00000001897C3BD0
	public override void OnEntityReady() {} // 0x0000000180E3E680-0x0000000180E3E720
	// [XID] // 0x00000001897CB4E0-0x00000001897CB500
	public override void Retarget(uint oldEntityRuntimeID, uint newEntityRuntimeID) {} // 0x0000000180E46490-0x0000000180E468B0
	// [XID] // 0x00000001897D2BC0-0x00000001897D2BE0
	private void RetargetModifier(ActorModifier actorModifier, uint oldEntityRuntimeID, uint newEntityRuntimeID) {} // 0x0000000180E332E0-0x0000000180E33430
	// [XID] // 0x00000001897DA960-0x00000001897DA980
	private void OnSetActive(bool active) {} // 0x0000000180E3D000-0x0000000180E3D410
	// [XID] // 0x00000001897E1D40-0x00000001897E1D60
	private void OnEnableModifier(ActorModifier actorModifier, bool active) {} // 0x0000000180E2C450-0x0000000180E2C5F0
	// [XID] // 0x00000001897E9510-0x00000001897E9530
	public override void Tick(float inDeltaTime) {} // 0x0000000180E468B0-0x0000000180E46970
	// [XID] // 0x00000001897F10E0-0x00000001897F1100
	public virtual float CreateOrGetDynamicFloat(string key, float value, bool forceDoAtRemote = false /* Metadata: 0x00AEB2D5 */) => default; // 0x0000000180E0D1C0-0x0000000180E0D4D0
	// [IDTag] // 0x00000001897F89A0-0x00000001897F89E0
	// [XID] // 0x00000001897F89A0-0x00000001897F89E0
	public float GetDynamicFloat(string key) => default; // 0x0000000180E2BB20-0x0000000180E2BEB0
	// [IDTag] // 0x00000001898030F0-0x0000000189803130
	// [XID] // 0x00000001898030F0-0x0000000189803130
	public float GetDynamicFloat(int keyHash) => default; // 0x0000000180E2B760-0x0000000180E2BB20
	// [XID] // 0x000000018980D4A0-0x000000018980D4C0
	public DynamicActorValue<SafeFloat> GetDynamicActorFloat(string key) => default; // 0x0000000180E1B1F0-0x0000000180E1B400
	// [IDTag] // 0x0000000189814B10-0x0000000189814B50
	// [XID] // 0x0000000189814B10-0x0000000189814B50
	public bool HasDynamicFloat(string key) => default; // 0x0000000180DF12F0-0x0000000180DF1410
	// [IDTag] // 0x000000018981F670-0x000000018981F6B0
	// [XID] // 0x000000018981F670-0x000000018981F6B0
	public bool HasDynamicFloat(int keyHash) => default; // 0x0000000180DF1410-0x0000000180DF1530
	// [XID] // 0x0000000189829C50-0x0000000189829C70
	public void AddDynamicFloat(string key, float value, bool forceDoAtRemote = false /* Metadata: 0x00AEB2D6 */) {} // 0x0000000180E3DA50-0x0000000180E3DBB0
	// [XID] // 0x0000000189831120-0x0000000189831140
	public void AddDynamicFloatWithRange(string key, float value, float min, float max, bool forceDoAtRemote = false /* Metadata: 0x00AEB2D7 */) {} // 0x0000000180E3D410-0x0000000180E3D5F0
	// [XID] // 0x0000000189838920-0x0000000189838940
	public void CreateOrSetDynamicFloat(string key, float value, bool forceDoAtRemote = false /* Metadata: 0x00AEB2D8 */) {} // 0x0000000180DEF5B0-0x0000000180DEF710
	// [IDTag] // 0x000000018983FE40-0x000000018983FE80
	// [XID] // 0x000000018983FE40-0x000000018983FE80
	public void UpdateServerDynamicFloat(string key, float value) {} // 0x0000000180E39600-0x0000000180E398B0
	// [IDTag] // 0x000000018984A290-0x000000018984A2D0
	// [XID] // 0x000000018984A290-0x000000018984A2D0
	public void UpdateServerDynamicFloat(int keyHash, float value) {} // 0x0000000180E39350-0x0000000180E39600
	// [XID] // 0x0000000189854490-0x00000001898544B0
	public virtual bool SetDynamicFloat(string key, float value, bool forceDoAtRemote = false /* Metadata: 0x00AEB2D9 */) => default; // 0x0000000180DF65B0-0x0000000180DF69A0
	// [XID] // 0x000000018985BE00-0x000000018985BE20
	public void SetDynamicFloatWithRange(string key, float value, float min, float max, bool forceDoAtRemote = false /* Metadata: 0x00AEB2DA */) {} // 0x0000000180DF26C0-0x0000000180DF2880
	// [XID] // 0x00000001898634E0-0x0000000189863500
	public void MultiplyDynamicFloat(string key, float value, bool forceDoAtRemote = false /* Metadata: 0x00AEB2DB */) {} // 0x0000000180E17B90-0x0000000180E17CF0
	// [XID] // 0x000000018986A9B0-0x000000018986A9D0
	public void MultiplyDynamicFloatWithRange(string key, float value, float min, float max, bool forceDoAtRemote = false /* Metadata: 0x00AEB2DC */) {} // 0x0000000180E36360-0x0000000180E36540
	// [XID] // 0x0000000189871DB0-0x0000000189871DD0
	public virtual void ClearDynamicFloat(string key, bool forceDoAtRemote = false /* Metadata: 0x00AEB2DD */) {} // 0x0000000180E0D4D0-0x0000000180E0D6A0
	// [XID] // 0x00000001898795C0-0x00000001898795E0
	protected bool IsMuted() => default; // 0x0000000180E08820-0x0000000180E08900
	// [IDTag] // 0x0000000189880C50-0x0000000189880C90
	// [XID] // 0x0000000189880C50-0x0000000189880C90
	public List<ActorAbility> GetAppliedAbilities() => default; // 0x0000000180E29980-0x0000000180E29A60
	// [XID] // 0x00000001899CF640-0x00000001899CF660
	protected virtual ActorAbility CreateAbilityInstance(string abilityName, string abilityOverride, OverrideMap overrideMap) => default; // 0x0000000180E0BD30-0x0000000180E0BFD0
	// [XID] // 0x0000000189892260-0x0000000189892280
	public virtual ActorAbility AddAbility(string abilityName, string abilityOverride = "" /* Metadata: 0x00AEB2DE */, OverrideMap overrideMap = null, bool syncToServer = false /* Metadata: 0x00AEB2E2 */, uint specifiedAbilityID = 0 /* Metadata: 0x00AEB2E3 */) => default; // 0x0000000180DEC400-0x0000000180DEC550
	// [XID] // 0x0000000189899CF0-0x0000000189899D10
	protected ActorAbility AddAbilityInternal(string abilityName, string abilityOverride, OverrideMap overrideMap, uint specifiedAbilityID) => default; // 0x0000000180E2ED10-0x0000000180E2EE30
	// [XID] // 0x00000001898A0EB0-0x00000001898A0ED0
	private void AttachInstancedAbility(ActorAbility instancedAbility, uint specifiedAbilityID) {} // 0x0000000180E2F400-0x0000000180E2F4F0
	// [XID] // 0x00000001898A8480-0x00000001898A84A0
	private void HandleAddActorAbilityID(ActorAbility instancedAbility, uint specifiedAbilityID) {} // 0x0000000180DEF710-0x0000000180DEFDD0
	// [XID] // 0x00000001898B0030-0x00000001898B0050
	private void HandleRemoveActorAbilityID(uint abilityID) {} // 0x0000000180E00600-0x0000000180E007F0
	// [XID] // 0x00000001899406B0-0x00000001899406D0
	public void ReorderAppliedAbilitiesIndex() {} // 0x0000000180E106F0-0x0000000180E10A50
	// [XID] // 0x00000001898BEC20-0x00000001898BEC40
	public int GetAppliedAbilityIndex(uint instancedAbilityID) => default; // 0x0000000180E43FB0-0x0000000180E44090
	// [XID] // 0x00000001898C64E0-0x00000001898C6500
	public Dictionary<uint, int> GetAppliedAbilitiesIndex() => default; // 0x0000000180DF47A0-0x0000000180DF4850
	// [XID] // 0x00000001898CDBD0-0x00000001898CDBF0
	protected virtual bool RemoveAbility(ActorAbility instancedAbility, bool forceDoAtRemote = false /* Metadata: 0x00AEB2E7 */, RemoveAbilityReason removeReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB2E8 */, bool doRemoveFromAbilities = true /* Metadata: 0x00AEB2EC */) => default; // 0x0000000180E037E0-0x0000000180E04100
	// [XID] // 0x000000018984BE70-0x000000018984BE90
	public void RemoveInstancedAbilityByName(string abilityName, bool withOwnedModifiers = false /* Metadata: 0x00AEB2ED */, RemoveAbilityReason removeReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB2EE */) {} // 0x0000000180E22560-0x0000000180E22690
	// [IDTag] // 0x00000001898DCF10-0x00000001898DCF50
	// [XID] // 0x00000001898DCF10-0x00000001898DCF50
	public ActorModifier ApplyModifier(ActorAbility instancedAbility, string modifierName, uint modifierApplyEntityId, ActorModifier attachedInstancedModifier = null, bool isAttachParentAbility = false /* Metadata: 0x00AEB2F2 */, uint serverBuffUid = 0 /* Metadata: 0x00AEB2F3 */, uint instancedModifierID = 0 /* Metadata: 0x00AEB2F7 */) => default; // 0x0000000180E1FCD0-0x0000000180E20370
	// [XID] // 0x00000001898E7F60-0x00000001898E7F80
	private bool CheckStacking(ActorModifier modifier, ActorAbility instancedAbility, ConfigAbilityModifier modifierConfig, bool refreshModifierApplyId, uint modifierApplyEntityId, bool isServerBuff, ref bool isStackHandling) => default; // 0x0000000180DEC9F0-0x0000000180DEDEC0
	// [IDTag] // 0x00000001898EF600-0x00000001898EF640
	// [XID] // 0x00000001898EF600-0x00000001898EF640
	protected ActorModifier ApplyModifier(ActorAbility instancedAbility, ConfigAbilityModifier modifierConfig, uint modifierApplyEntityId = 0 /* Metadata: 0x00AEB2FB */, ActorModifier attachedInstancedModifier = null, bool isAttachedParentAbility = false /* Metadata: 0x00AEB2FF */, uint serverBuffUid = 0 /* Metadata: 0x00AEB300 */, uint instancedModifierID = 0 /* Metadata: 0x00AEB304 */) => default; // 0x0000000180E1DA90-0x0000000180E1FCD0
	// [XID] // 0x00000001898F9D00-0x00000001898F9D20
	public void StartModifierDurability(ActorAbility instancedAbility, ActorModifier modifier, bool recoverFromServer = false /* Metadata: 0x00AEB308 */, float remainDurablity = 0f /* Metadata: 0x00AEB309 */) {} // 0x0000000180E00970-0x0000000180E00FA0
	// [XID] // 0x000000018976F080-0x000000018976F0A0
	private float GetAbilityStateDurationRatio(ConfigAbilityModifier modifierConfig) => default; // 0x0000000180DEEDF0-0x0000000180DEF340
	// [XID] // 0x00000001898853D0-0x00000001898853F0
	private ActorModifier GetAppliedModifier(ConfigAbilityModifier modifierConfig, ActorAbility ownerAbility, bool isServerBuff) => default; // 0x0000000180DF5240-0x0000000180DF5460
	// [XID] // 0x0000000189910390-0x00000001899103B0
	private bool IsModifierSameConfigAndAbility(ActorModifier modifier, ConfigAbilityModifier modifierConfig, ActorAbility ownerAbility) => default; // 0x0000000180E24450-0x0000000180E24550
	// [XID] // 0x0000000189917F40-0x0000000189917F60
	private int GetAppliedModifierNum(ConfigAbilityModifier modifierConfig, ActorAbility ownerAbility, bool isServerBuff) => default; // 0x0000000180E19570-0x0000000180E19760
	// [XID] // 0x000000018991F590-0x000000018991F5B0
	private ActorModifier GetAppliedModifierWithSameConfig(ConfigAbilityModifier modifierConfig, ActorAbility ownerAbility, bool isServerBuff) => default; // 0x0000000180E18E40-0x0000000180E19060
	// [XID] // 0x000000018987E330-0x000000018987E350
	private bool IsModifierSameConfig(ActorModifier modifier, ConfigAbilityModifier modifierConfig, ActorAbility ownerAbility) => default; // 0x0000000180E42E40-0x0000000180E42F60
	// [XID] // 0x00000001897C1070-0x00000001897C1090
	protected void RemoveModifier(ActorModifier modifier, bool forceDoAtRemote = false /* Metadata: 0x00AEB30D */, RemoveAbilityReason removeReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB30E */, bool useActionBlackListForInvalidModifier = false /* Metadata: 0x00AEB312 */) {} // 0x0000000180E06970-0x0000000180E070C0
	// [XID] // 0x0000000189935B00-0x0000000189935B20
	public void ClearDeadModifiers() {} // 0x0000000180E00FA0-0x0000000180E01110
	// [IDTag] // 0x000000018993D7A0-0x000000018993D7E0
	// [XID] // 0x000000018993D7A0-0x000000018993D7E0
	public bool HasModifier(ActorModifier modifier) => default; // 0x0000000180E08220-0x0000000180E08360
	// [IDTag] // 0x0000000189947B30-0x0000000189947B70
	// [XID] // 0x0000000189947B30-0x0000000189947B70
	public bool HasModifier(string modifierName, bool isServerBuff = false /* Metadata: 0x00AEB313 */) => default; // 0x0000000180E08360-0x0000000180E086C0
	// [XID] // 0x00000001899524D0-0x00000001899524F0
	public ActorModifier GetModifierByInstancedModifierID(uint instancedModiiferID, bool isServerBuff) => default; // 0x0000000180E22690-0x0000000180E22D40
	// [XID] // 0x0000000189959970-0x0000000189959990
	public int GetModifierIndex(ActorModifier modifier) => default; // 0x0000000180DF6270-0x0000000180DF63B0
	// [IDTag] // 0x0000000189961290-0x00000001899612D0
	// [XID] // 0x0000000189961290-0x00000001899612D0
	public bool TryRemoveModifier(uint instancedModifierID, RemoveAbilityReason removeReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB314 */, bool isServerBuff = false /* Metadata: 0x00AEB318 */) => default; // 0x0000000180E3C360-0x0000000180E3C580
	// [IDTag] // 0x000000018996B7F0-0x000000018996B830
	// [XID] // 0x000000018996B7F0-0x000000018996B830
	public bool TryRemoveModifier(ActorModifier modifier, bool useActionBlackListForInvalidModifier = false /* Metadata: 0x00AEB319 */, RemoveAbilityReason removeReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB31A */) => default; // 0x0000000180E3CA60-0x0000000180E3CC80
	// [IDTag] // 0x0000000189976190-0x00000001899761D0
	// [XID] // 0x0000000189976190-0x00000001899761D0
	public bool TryRemoveModifier(ActorAbility instancedAbility, string modifierName, RemoveAbilityReason removeReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB31E */) => default; // 0x0000000180E3C580-0x0000000180E3C860
	// [XID] // 0x0000000189980820-0x0000000189980840
	public void TryAddElementDurability(ActorAbility instancedAbility, string modifierName, float addValue, bool useLimitedValue = false /* Metadata: 0x00AEB322 */, float minValue = -3.4028235E+38f /* Metadata: 0x00AEB323 */, float maxValue = 3.4028235E+38f /* Metadata: 0x00AEB327 */) {} // 0x0000000180E207E0-0x0000000180E20BB0
	// [IDTag] // 0x0000000189988190-0x00000001899881D0
	// [XID] // 0x0000000189988190-0x00000001899881D0
	private bool TryRemoveModifier(ConfigAbilityModifier modifierConfig, RemoveAbilityReason removeReason) => default; // 0x0000000180E3C860-0x0000000180E3CA60
	// [XID] // 0x00000001899C7D70-0x00000001899C7D90
	public bool HasAbility(string abilityName) => default; // 0x0000000180E19C40-0x0000000180E19EC0
	// [XID] // 0x000000018999ABB0-0x000000018999ABD0
	protected bool HasInstancedAbility(ActorAbility instancedAbility) => default; // 0x0000000180DF02A0-0x0000000180DF07F0
	// [XID] // 0x0000000189AC4810-0x0000000189AC4830
	public ActorAbility GetAppliedAbility(string abilityName) => default; // 0x0000000180E3CC80-0x0000000180E3CEA0
	// [IDTag] // 0x00000001899A9B40-0x00000001899A9B80
	// [XID] // 0x00000001899A9B40-0x00000001899A9B80
	private void GetAppliedAbilities(string abilityName, uint runtimeID, ref List<ActorAbility> abilities) {} // 0x0000000180E29A60-0x0000000180E29C20
	// [XID] // 0x00000001899B4570-0x00000001899B4590
	private EntityTimer GetModifierDurationTimer(ActorModifier instancedModifier) => default; // 0x0000000180E0D9A0-0x0000000180E0DA90
	// [XID] // 0x00000001899BB9F0-0x00000001899BBA10
	private void InitModifierThinker() {} // 0x0000000180E01EA0-0x0000000180E02010
	// [XID] // 0x00000001899C3630-0x00000001899C3650
	protected void ClearModifierThinker() {} // 0x0000000180E13060-0x0000000180E132E0
	// [XID] // 0x00000001899CAAC0-0x00000001899CAAE0
	private void DestroyModiferThinker() {} // 0x0000000180E37AD0-0x0000000180E37C40
	// [XID] // 0x00000001899D20F0-0x00000001899D2110
	private void OnOwnerTimeScaleChanged(EvtEntityTimeScaleChange evt) {} // 0x0000000180E02010-0x0000000180E021E0
	// [XID] // 0x00000001899D97D0-0x00000001899D97F0
	private void OnOwnerAliveChanged(EvtEntityAliveChange evt) {} // 0x0000000180E45720-0x0000000180E458E0
	// [XID] // 0x0000000189698590-0x00000001896985B0
	public void StartModifierThinkTimer(ActorAbility instancedAbility, ActorModifier modifier) {} // 0x0000000180E0E6E0-0x0000000180E0EAE0
	// [XID] // 0x00000001899E8A20-0x00000001899E8A40
	public void StopModifierThinkTimer(ActorModifier modifier) {} // 0x0000000180E1B400-0x0000000180E1B750
	// [XID] // 0x00000001899F0140-0x00000001899F0160
	private bool HanlderModifierThinkTimerUp(float delay, object arg) => default; // 0x0000000180E2C0E0-0x0000000180E2C450
	// [XID] // 0x00000001899F7720-0x00000001899F7740
	private void RemoveEventMixinList() {} // 0x0000000180E20E20-0x0000000180E21660
	// [IDTag] // 0x00000001899FEE00-0x00000001899FEE40
	// [XID] // 0x00000001899FEE00-0x00000001899FEE40
	public void TryAddEventMixin(BaseActorActionContext context) {} // 0x0000000180E0F840-0x0000000180E0F950
	// [IDTag] // 0x0000000189A09430-0x0000000189A09470
	// [XID] // 0x0000000189A09430-0x0000000189A09470
	public void TryAddEventMixin(BaseAbilityMixin mixin) {} // 0x0000000180E0F680-0x0000000180E0F840
	// [XID] // 0x0000000189A13BF0-0x0000000189A13C10
	private void CacheAddEventMixin(ref List<BaseAbilityMixin> mixins, BaseAbilityMixin mixin) {} // 0x0000000180E1ACC0-0x0000000180E1ADD0
	// [XID] // 0x0000000189A1ADD0-0x0000000189A1ADF0
	private void DoAddEventMixin(BaseAbilityMixin.HandleEventType eventType, ref Dictionary<int, List<BaseAbilityMixin>> mixins, BaseAbilityMixin mixin) {} // 0x0000000180DFA770-0x0000000180DFAC50
	// [IDTag] // 0x0000000189A226F0-0x0000000189A22730
	// [XID] // 0x0000000189A226F0-0x0000000189A22730
	public void TryRemoveEventMixin(BaseActorActionContext context) {} // 0x0000000180E20530-0x0000000180E20640
	// [IDTag] // 0x0000000189A2C880-0x0000000189A2C8C0
	// [XID] // 0x0000000189A2C880-0x0000000189A2C8C0
	public void TryRemoveEventMixin(BaseAbilityMixin mixin) {} // 0x0000000180E20370-0x0000000180E20530
	// [XID] // 0x0000000189A37240-0x0000000189A37260
	private void CacheRemoveEventMixin(ref List<BaseAbilityMixin> mixins, BaseAbilityMixin mixin) {} // 0x0000000180E21EC0-0x0000000180E21FD0
	// [XID] // 0x0000000189A3E910-0x0000000189A3E930
	private void DoRemoveEventMixin(BaseAbilityMixin.HandleEventType eventType, ref Dictionary<int, List<BaseAbilityMixin>> mixins, BaseAbilityMixin mixin) {} // 0x0000000180DFC6E0-0x0000000180DFC8C0
	// [XID] // 0x0000000189A46000-0x0000000189A46020
	private void HandleCachedEventMixins(BaseAbilityMixin.HandleEventType eventType, ref Dictionary<int, List<BaseAbilityMixin>> mixins, List<BaseAbilityMixin> addMixins, List<BaseAbilityMixin> removeMixins) {} // 0x0000000180DFB930-0x0000000180DFBB10
	// [XID] // 0x0000000189A4D710-0x0000000189A4D730
	private int[] GetEventIDsByEventType(BaseAbilityMixin.HandleEventType eventType, BaseAbilityMixin mixin) => default; // 0x0000000180E45070-0x0000000180E45190
	// [XID] // 0x0000000189A54FB0-0x0000000189A54FD0
	protected void RegisterEventListener() {} // 0x0000000180E159B0-0x0000000180E15AF0
	// [XID] // 0x0000000189A5C8C0-0x0000000189A5C8E0
	protected void RemoveEventListener() {} // 0x0000000180E1A410-0x0000000180E1A550
	// [XID] // 0x0000000189A64190-0x0000000189A641B0
	protected static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000180E0F270-0x0000000180E0F340
	// [XID] // 0x0000000189A6BB40-0x0000000189A6BB60
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000180E3E9D0-0x0000000180E40300
	// [XID] // 0x0000000189A73300-0x0000000189A73320
	public override bool OnRemoteEvtBeingHit(BaseEvent evt) => default; // 0x0000000180E40300-0x0000000180E405B0
	// [XID] // 0x0000000189A7ADF0-0x0000000189A7AE10
	private bool OnEventBeingHit(BaseEvent evt) => default; // 0x0000000180E33430-0x0000000180E33790
	// [XID] // 0x0000000189A82380-0x0000000189A823A0
	protected static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000180E0F1A0-0x0000000180E0F270
	// [XID] // 0x0000000189A89CA0-0x0000000189A89CC0
	public override bool ListenEvent(BaseEvent evt) => default; // 0x0000000180E2CEC0-0x0000000180E2D640
	// [XID] // 0x0000000189A913A0-0x0000000189A913C0
	protected static new EventID[] GetSelfOnEventResolvedIDsExcludingBase() => default; // 0x0000000180E0F340-0x0000000180E0F420
	// [XID] // 0x0000000189A98F70-0x0000000189A98F90
	public override bool OnEventResolved(BaseEvent evt) => default; // 0x0000000180E3E720-0x0000000180E3E9D0
	// [XID] // 0x0000000189AA0100-0x0000000189AA0120
	protected virtual bool OnKill(EvtKill evt) => default; // 0x0000000180E25CC0-0x0000000180E25E30
	// [XID] // 0x0000000189AA78F0-0x0000000189AA7910
	public virtual void DetachAllAbilitiesFromActor(bool forceDoAtRemote = false /* Metadata: 0x00AEB32B */, RemoveAbilityReason removeReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB32C */) {} // 0x0000000180E2CCE0-0x0000000180E2CEC0
	// [XID] // 0x0000000189AAF130-0x0000000189AAF150
	public virtual void RemoveAllAbilities(bool forceDoAtRemote, RemoveAbilityReason removeReason) {} // 0x0000000180DFDDD0-0x0000000180DFE000
	// [XID] // 0x00000001898B5E10-0x00000001898B5E30
	public virtual void RemoveAllModifies(bool forceDoAtRemote = false /* Metadata: 0x00AEB330 */, RemoveAbilityReason removeReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB331 */) {} // 0x0000000180E0F950-0x0000000180E0FE60
	// [XID] // 0x0000000189ABE4C0-0x0000000189ABE4E0
	protected virtual void SetKilled(bool killed) {} // 0x0000000180E15060-0x0000000180E15110
	// [XID] // 0x0000000189AC6030-0x0000000189AC6050
	public override void Destroy() {} // 0x0000000180DFD340-0x0000000180DFD960
	// [IDTag] // 0x0000000189ACD5A0-0x0000000189ACD5E0
	// [XID] // 0x0000000189ACD5A0-0x0000000189ACD5E0
	public bool HandleAbilityActions(ActorAbility instancedAbility, BaseEntity other, BaseEvent evt, Func<ConfigAbility, ConfigAbilityAction[]> actionsGetter, bool recoverFromServer = false /* Metadata: 0x00AEB335 */) => default; // 0x0000000180DF88E0-0x0000000180DF8AF0
	// [IDTag] // 0x0000000189AD80D0-0x0000000189AD8110
	// [XID] // 0x0000000189AD80D0-0x0000000189AD8110
	protected virtual bool HandleAbilityActions(BaseEntity other, BaseEvent evt, Func<ConfigAbility, ConfigAbilityAction[]> actionsGetter) => default; // 0x0000000180DF8AF0-0x0000000180DF8CD0
	// [IDTag] // 0x0000000189AE27E0-0x0000000189AE2820
	// [XID] // 0x0000000189AE27E0-0x0000000189AE2820
	public bool HandleModifierActions(ActorModifier instancedModifier, BaseEntity other, BaseEvent evt, Func<ConfigAbilityModifier, ConfigAbilityAction[]> actionsGetter, bool recoverFromServer = false /* Metadata: 0x00AEB336 */, bool useActionBlackListForInvalidModifier = false /* Metadata: 0x00AEB337 */) => default; // 0x0000000180E34260-0x0000000180E34780
	// [IDTag] // 0x0000000189AED250-0x0000000189AED290
	// [XID] // 0x0000000189AED250-0x0000000189AED290
	public bool HandleModifierActions(BaseEntity other, BaseEvent evt, Func<ConfigAbilityModifier, ConfigAbilityAction[]> actionsGetter) => default; // 0x0000000180E338B0-0x0000000180E33D30
	// [IDTag] // 0x0000000189AF7D90-0x0000000189AF7DD0
	// [XID] // 0x0000000189AF7D90-0x0000000189AF7DD0
	protected bool HandleModifierActions(uint[] attackeeList, BaseEvent evt, Func<ConfigAbilityModifier, ConfigAbilityAction[]> actionsGetter) => default; // 0x0000000180E33D30-0x0000000180E34260
	// [IDTag] // 0x0000000189B02540-0x0000000189B02580
	// [XID] // 0x0000000189B02540-0x0000000189B02580
	public void HandleActionTargetDispatch(ConfigAbilityAction[] actionConfigs, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity other, BaseEvent evt, bool recoverFromServer = false /* Metadata: 0x00AEB338 */, bool useActionBlackListForInvalidModifier = false /* Metadata: 0x00AEB339 */) {} // 0x0000000180E41050-0x0000000180E41230
	// [IDTag] // 0x0000000189B0C9A0-0x0000000189B0C9E0
	// [XID] // 0x0000000189B0C9A0-0x0000000189B0C9E0
	public virtual void HandleActionTargetDispatch(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity other, BaseEvent evt, bool recoverFromServer = false /* Metadata: 0x00AEB33A */, bool useActionBlackListForInvalidModifier = false /* Metadata: 0x00AEB33B */) {} // 0x0000000180E41230-0x0000000180E417E0
	// [XID] // 0x00000001896D2B10-0x00000001896D2B30
	public void ResolveTarget(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity other, BaseEvent evt, out AbilityAttackTarget outTarget, out List<AbilityAttackTarget> outTargetLs) {
		outTarget = default;
		outTargetLs = default;
	} // 0x0000000180E27C30-0x0000000180E28350
	// [XID] // 0x00000001898B4580-0x00000001898B45A0
	public void FilterTargets(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity other, BaseEvent evt, ref AbilityAttackTarget outTarget, ref List<AbilityAttackTarget> outTargetLs, Vector3 logicCenter, BaseShape2d shape) {} // 0x0000000180E11910-0x0000000180E12610
	// [IDTag] // 0x0000000189B25E00-0x0000000189B25E40
	// [XID] // 0x0000000189B25E00-0x0000000189B25E40
	public bool EvaluateAbilityPredicate(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E0B460-0x0000000180E0B6A0
	// [IDTag] // 0x0000000189B30010-0x0000000189B30050
	// [XID] // 0x0000000189B30010-0x0000000189B30050
	public bool EvaluateAbilityPredicate(ConfigAbilityPredicate[] predConfigs, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E0B2F0-0x0000000180E0B460
	// [XID] // 0x00000001899961C0-0x00000001899961E0
	protected virtual void HandleAction(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, AbilityAttackTarget target, BaseEvent evt, ConfigAbilityPredicate[] predicatesForeach, bool recoverFromServer = false /* Metadata: 0x00AEB33C */) {} // 0x0000000180E07570-0x0000000180E077A0
	// [XID] // 0x0000000189B421F0-0x0000000189B42210
	public void HandleActionExternal(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, AbilityAttackTarget target, BaseEvent evt, ConfigAbilityPredicate[] predicatesForeach, bool recoverFromServer, bool callAuthority) {} // 0x0000000180E43890-0x0000000180E43A50
	// [XID] // 0x00000001899BBC00-0x00000001899BBC20
	protected void HandleActionInternal(ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, AbilityAttackTarget target, BaseEvent evt, ConfigAbilityPredicate[] predicatesForeach, bool recoverFromServer, bool callAuthority = false /* Metadata: 0x00AEB33D */) {} // 0x0000000180E01110-0x0000000180E01790
	// [XID] // 0x0000000189B51330-0x0000000189B51350
	protected uint GetOtherID(BaseEvent evt) => default; // 0x0000000180E14F80-0x0000000180E15060
	// [XID] // 0x0000000189B58CA0-0x0000000189B58CC0
	private AttackResult GetAttackResult(BaseEvent evt) => default; // 0x0000000180E194C0-0x0000000180E19570
	// [XID] // 0x0000000189B60350-0x0000000189B60370
	private string GetAttackTag(BaseEvent evt) => default; // 0x0000000180E40EE0-0x0000000180E41050
	// [XID] // 0x0000000189B67B70-0x0000000189B67B90
	private AttackType GetAttackType(BaseEvent evt) => default; // 0x0000000180E36780-0x0000000180E36860
	// [XID] // 0x0000000189B6EE50-0x0000000189B6EE70
	protected AttackResult.HitCollsion? GetHitCollision(BaseEvent evt) => default; // 0x0000000180E05E40-0x0000000180E06020
	// [XID] // 0x00000001897DEDD0-0x00000001897DEDF0
	public virtual void RemoveAllDebuffModifiers() {} // 0x0000000180E257E0-0x0000000180E259A0
	// [XID] // 0x0000000189B7DBC0-0x0000000189B7DBE0
	private bool IsModifierDurationed(ActorModifier modifier) => default; // 0x0000000180DEDF40-0x0000000180DEDFF0
	// [XID] // 0x0000000189B85840-0x0000000189B85860
	protected virtual void RemoveAllDurationedOrDebuffs() {} // 0x0000000180DFA2F0-0x0000000180DFA4E0
	// [XID] // 0x0000000189B8C630-0x0000000189B8C650
	private ActorModifier GetModifierByState(AbilityState state, bool isServerBuff) => default; // 0x0000000180DFA4E0-0x0000000180DFA770
	// [XID] // 0x0000000189B93FF0-0x0000000189B94010
	public void RemoveModifierByState(AbilityState state) {} // 0x0000000180E436D0-0x0000000180E43890
	// [XID] // 0x000000018999AC90-0x000000018999ACB0
	public ActorModifier GetFirstUniqueModifier(string uniqueModifierName, bool isServerBuff = false /* Metadata: 0x00AEB33E */) => default; // 0x0000000180E1CE30-0x0000000180E1D050
	// [XID] // 0x0000000189BA2CD0-0x0000000189BA2CF0
	private bool IsUniqueModifier(ActorModifier modifier, string uniqueModifierName) => default; // 0x0000000180E3A700-0x0000000180E3A850
	// [XID] // 0x0000000189BAA120-0x0000000189BAA140
	public ActorModifier GetFirstModifierByName(string modifierName) => default; // 0x0000000180E2B590-0x0000000180E2B760
	// [XID] // 0x0000000189BB1940-0x0000000189BB1960
	public ActorModifier GetFirstAppliedModifier(ActorAbility instancedAbility, string modifierName, bool isServerBuff = false /* Metadata: 0x00AEB33F */) => default; // 0x0000000180DF9E70-0x0000000180DFA160
	// [XID] // 0x0000000189852D50-0x0000000189852D70
	protected virtual void DetachAbilityOwnedModifiers(ActorAbility actorAbility) {} // 0x0000000180DFFA30-0x0000000180DFFD40
	// [XID] // 0x0000000189BC0300-0x0000000189BC0320
	public EntityTimer DebugGetModifierTimer(ActorModifier instancedModifier) => default; // 0x0000000180E298D0-0x0000000180E29980
	// [XID] // 0x0000000189BC7D00-0x0000000189BC7D20
	public virtual BaseAbilityMixin CreateInstancedAbilityMixin(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) => default; // 0x0000000180E24DC0-0x0000000180E24EC0
	// [XID] // 0x0000000189BCF870-0x0000000189BCF890
	public void AddInstancedMixins(BaseAbilityMixin[] mixins, bool syncToServer = true /* Metadata: 0x00AEB340 */) {} // 0x0000000180E28930-0x0000000180E28BD0
	// [XID] // 0x0000000189BD6CE0-0x0000000189BD6D00
	public void ResetAbilityInstancedMixins(ActorAbility ability, RemoveAbilityReason removeReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB341 */) {} // 0x0000000180E03610-0x0000000180E037E0
	// [XID] // 0x0000000189BDEA20-0x0000000189BDEA40
	protected void RemoveInstancedMixins(BaseAbilityMixin[] mixins, RemoveAbilityReason removeReason) {} // 0x0000000180E16640-0x0000000180E16790
	// [XID] // 0x00000001895EB490-0x00000001895EB4B0
	protected void AbilityStartInstancedMixin(BaseAbilityMixin mixin, EvtAbilityStart evt) {} // 0x0000000180E2B3E0-0x0000000180E2B590
	// [XID] // 0x00000001895F2900-0x00000001895F2920
	protected bool EventInstancedMixin(BaseAbilityMixin mixin, BaseEvent evt) => default; // 0x0000000180E12A00-0x0000000180E12B90
	// [XID] // 0x00000001895FA260-0x00000001895FA280
	protected bool EventRemoteInstancedMixin(BaseAbilityMixin mixin, BaseEvent evt) => default; // 0x0000000180DFA160-0x0000000180DFA2F0
	// [XID] // 0x0000000189601BF0-0x0000000189601C10
	protected bool EventResolvedInstancedMixin(BaseAbilityMixin mixin, BaseEvent evt) => default; // 0x0000000180E405B0-0x0000000180E40740
	// [XID] // 0x0000000189609440-0x0000000189609460
	public virtual ActorModifier AddModifierOnIndex(ActorAbility instancedAbility, ConfigAbilityModifier modifierConfig, int index, ConfigAbility parentAbilityConfig, uint parentAbilityEntityID, ActorModifier attachedInstancedModifier, uint modifierApplyEntityId, bool isAttachedParentAbility, uint serverBuffUid, bool syncToServer = true /* Metadata: 0x00AEB345 */, bool inSBuffBucket = false /* Metadata: 0x00AEB346 */) => default; // 0x0000000180E39F70-0x0000000180E3A550
	// [XID] // 0x0000000189610BC0-0x0000000189610BE0
	protected ActorModifier AddModifierOnIndexPre(ActorAbility instancedAbility, ConfigAbilityModifier modifierConfig, int index, ConfigAbility parentAbilityConfig, uint parentAbilityEntityID, ActorModifier attachedInstancedModifier, uint modifierApplyEntityId, uint serverBuffUid, bool inSBuffBucket) => default; // 0x0000000180E2A310-0x0000000180E2ACC0
	// [XID] // 0x00000001898048B0-0x00000001898048D0
	protected virtual void RemoveModifierOnIndex(ActorModifier modifier, bool forceDoAtRemote = false /* Metadata: 0x00AEB347 */, RemoveAbilityReason removeReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB348 */) {} // 0x0000000180E34F40-0x0000000180E35790
	// [XID] // 0x0000000189A856C0-0x0000000189A856E0
	public void TriggerAbility(string abilityName, uint? otherID = default, uint? triggerID = default, Dictionary<string, float> abilitySpecials = null, bool canBeHandledImmediately = false /* Metadata: 0x00AEB34C */) {} // 0x0000000180E45470-0x0000000180E45720
	// [XID] // 0x00000001896D1540-0x00000001896D1560
	public float GetCurPurgeIncrement() => default; // 0x0000000180DF7490-0x0000000180DF76D0
	// [XID] // 0x000000018962E7C0-0x000000018962E7E0
	public ActorAbility GetInstancedAbilityByID(uint appliedAbilityID) => default; // 0x0000000180E10F90-0x0000000180E11580
	// [XID] // 0x00000001898705F0-0x0000000189870610
	public ActorAbility TryGetInstancedAbilityByID(uint appliedAbilityID) => default; // 0x0000000180E2DBF0-0x0000000180E2E250
	// [XID] // 0x000000018963DA70-0x000000018963DA90
	public ActorModifier GetInstancedModifierByID(int appliedModifierID, bool isServerBuff) => default; // 0x0000000180E31A40-0x0000000180E31D50
	// [XID] // 0x0000000189645020-0x0000000189645040
	public ActorModifier TryGetInstancedModifierByID(int appliedModifierID, bool isServerBuff) => default; // 0x0000000180E320D0-0x0000000180E32330
	// [XID] // 0x00000001899D9AC0-0x00000001899D9AE0
	public virtual void StartRecordInvokeEntry(uint instancedAbilityID, uint instancedModifierID, int modifierConfigLocalID, uint targetRuntimeID, int localID, out RecordInvokeEntryContext entry, uint evtID = 0 /* Metadata: 0x00AEB34D */, uint serverBuffUid = 0 /* Metadata: 0x00AEB351 */, bool inSBuffBucket = false /* Metadata: 0x00AEB355 */) {
		entry = default;
	} // 0x0000000180E11600-0x0000000180E11730
	// [XID] // 0x0000000189A1B060-0x0000000189A1B080
	public virtual bool CanSyncAbilityMessageToRemote(bool remoteToAuthority = false /* Metadata: 0x00AEB356 */) => default; // 0x0000000180E21C60-0x0000000180E21D10
	// [XID] // 0x000000018965B8F0-0x000000018965B910
	private ActorModifier TryRecycleDeadModifier(ActorAbility ownerAbility, ConfigAbilityModifier config) => default; // 0x0000000180E458E0-0x0000000180E45B60
	// [IDTag] // 0x0000000189662C90-0x0000000189662CD0
	// [XID] // 0x0000000189662C90-0x0000000189662CD0
	public List<ActorModifier> GetAppliedModifiers() => default; // 0x0000000180E0DA90-0x0000000180E0DB70
	// [XID] // 0x000000018966D570-0x000000018966D590
	public List<ActorModifier> GetCommonModifiers() => default; // 0x0000000180E1ABE0-0x0000000180E1ACC0
	// [XID] // 0x00000001896095A0-0x00000001896095C0
	public List<ActorModifier> GetServerBuffModifiers() => default; // 0x0000000180E08AB0-0x0000000180E08B90
	// [IDTag] // 0x000000018967CBC0-0x000000018967CC00
	// [XID] // 0x000000018967CBC0-0x000000018967CC00
	private void GetAppliedModifiers(string abilityName, uint runtimeID, ref List<ActorModifier> modifiers) {} // 0x0000000180E0DB70-0x0000000180E0DE20
	// [XID] // 0x000000018961FD30-0x000000018961FD50
	public int GetAppliedModifierCount() => default; // 0x0000000180DFCB70-0x0000000180DFCD20
	// [XID] // 0x000000018968F090-0x000000018968F0B0
	public virtual bool Command_MPTryApplyModifier(ActorAbility instancedAbility, string modifierName, uint modifierApplyEntityId) => default; // 0x0000000180DF6B50-0x0000000180DF6C50
	// [XID] // 0x0000000189696B50-0x0000000189696B70
	public virtual bool Command_MPTryRemoveModifier(ActorAbility instancedAbility, string modifierName) => default; // 0x0000000180E03250-0x0000000180E03330
	// [XID] // 0x000000018969E0E0-0x000000018969E100
	public bool HasShield(HasShieldType type, bool usePotentShield, ElementType potentElementShield) => default; // 0x0000000180E3BF70-0x0000000180E3C360
	// [XID] // 0x00000001896A5150-0x00000001896A5170
	public bool GetShieldString(StringBuilder shieldSb, out float shieldResult) {
		shieldResult = default;
		return default;
	} // 0x0000000180DF7AC0-0x0000000180DF7F70
	// [XID] // 0x00000001896ACA80-0x00000001896ACAA0
	public bool IsPotentElementEliteShield(string shieldType, ElementType potentElementShield) => default; // 0x0000000180DFED60-0x0000000180DFEFD0
	// [XID] // 0x00000001896B3D50-0x00000001896B3D70
	public ElementType GetElementTypeFromModifier() => default; // 0x0000000180E2D7F0-0x0000000180E2DA60
	// [XID] // 0x00000001896CCD40-0x00000001896CCD60
	public virtual void PushDuringInitAbility() {} // 0x0000000180DFAC50-0x0000000180DFAE00
	// [XID] // 0x00000001895FEAF0-0x00000001895FEB10
	public virtual void PopDuringInitAbility() {} // 0x0000000180E132E0-0x0000000180E13490
	// [XID] // 0x00000001896ED390-0x00000001896ED3B0
	public virtual void PushDuringChangeAbility() {} // 0x0000000180E1D8E0-0x0000000180E1DA90
	// [XID] // 0x00000001896F4CC0-0x00000001896F4CE0
	public virtual void PopDuringChangeAbility() {} // 0x0000000180DF69A0-0x0000000180DF6B50
	// [XID] // 0x00000001896FC3F0-0x00000001896FC410
	private void PrintAbilities(string title) {} // 0x0000000180DF7F70-0x0000000180DF8460
	// [XID] // 0x00000001897039A0-0x00000001897039C0
	private void InitServerBuffModifier() {} // 0x0000000180E070C0-0x0000000180E071A0
	// [XID] // 0x000000018970B170-0x000000018970B190
	private void ClearServerBuffModifier() {} // 0x0000000180DF9190-0x0000000180DF92A0
	// [XID] // 0x00000001897129B0-0x00000001897129D0
	private void RemoveServerBuffModifier() {} // 0x0000000180E15400-0x0000000180E15550
	// [XID] // 0x000000018971A2B0-0x000000018971A2D0
	public void AddServerBuff(uint sBuffUid, AvatarDataItem.ServerBuffInfo sBuffInfo) {} // 0x0000000180E33030-0x0000000180E332E0
	// [XID] // 0x00000001897215A0-0x00000001897215C0
	public void RemoveServerBuff(uint sBuffUid, AvatarDataItem.ServerBuffInfo sBuffInfo) {} // 0x0000000180E0E270-0x0000000180E0E520
	// [XID] // 0x0000000189728BE0-0x0000000189728C00
	private void HandleServerBuffChangedOnEntityReady(EvtEntityReadyPost ev) {} // 0x0000000180E389F0-0x0000000180E38DD0
	// [XID] // 0x0000000189730610-0x0000000189730630
	private void DoAddServerBuff(uint sBuffUid, AvatarDataItem.ServerBuffInfo sBuffInfo, LCAbility levelAbilityCom) {} // 0x0000000180E04CA0-0x0000000180E05BE0
	// [XID] // 0x0000000189737DF0-0x0000000189737E10
	private void CheckInvalidModifier(uint sBuffUid) {} // 0x0000000180E0DFC0-0x0000000180E0E270
	// [XID] // 0x000000018973F960-0x000000018973F980
	private void DoRemoveServerBuff(uint sBuffUid, AvatarDataItem.ServerBuffInfo sBuffInfo, LCAbility levelAbilityCom) {} // 0x0000000180DF34E0-0x0000000180DF4210
	// [XID] // 0x0000000189746E80-0x0000000189746EA0
	private int modifierCompare(ActorModifier a, ActorModifier b) => default; // 0x0000000180E2C7D0-0x0000000180E2C940
	// [XID] // 0x000000018974E6D0-0x000000018974E6F0
	public void GetBuffids(ref List<int> result, int count) {} // 0x0000000180E38010-0x0000000180E382E0
	// [XID] // 0x000000018975D040-0x000000018975D060
	protected void LoadDynamicAbilityPreloadAsset(ConfigDynamicAbilityPreload preloadData) {} // 0x0000000180E12D60-0x0000000180E13060
	// [XID] // 0x0000000189764840-0x0000000189764860
	protected void ReleaseAbilityDependAsset(ConfigDynamicAbilityPreload preloadData) {} // 0x0000000180E34910-0x0000000180E34BA0
	// [XID] // 0x000000018976C2E0-0x000000018976C300
	private void ClearAttachContainers(ref Dictionary<uint, BaseAttachContainer> attachContainers) {} // 0x0000000180E0A890-0x0000000180E0AAA0
	// [XID] // 0x0000000189773680-0x00000001897736A0
	public void ClearAllAttachContainers() {} // 0x0000000180DF5AE0-0x0000000180DF5BA0
	// [XID] // 0x000000018977AEB0-0x000000018977AED0
	private BaseAttachContainer AllocBaseAttachContainer() => default; // 0x0000000180E1D290-0x0000000180E1D340
	// [XID] // 0x0000000189890EA0-0x0000000189890EC0
	private void ReleaseBaseAttachContainer(BaseAttachContainer attachContainer) {} // 0x0000000180DF4A40-0x0000000180DF4B10
	// [XID] // 0x000000018986C1E0-0x000000018986C200
	public Dictionary<uint, BaseAttachContainer> GetAttachContainersList(ActorActionContextType contextType) => default; // 0x0000000180E16100-0x0000000180E16210
	// [XID] // 0x0000000189791490-0x00000001897914B0
	public BaseAttachContainer GetBaseAttachContainer(BaseActorActionContext baseActionContext, bool createIfNull = false /* Metadata: 0x00AEB357 */) => default; // 0x0000000180DFC430-0x0000000180DFC5A0
	// [XID] // 0x00000001896B58E0-0x00000001896B5900
	public void AttachModifier(BaseActorActionContext baseContext, ActorModifier modifier) {} // 0x0000000180DF1B10-0x0000000180DF1BF0
	// [XID] // 0x00000001898BD7C0-0x00000001898BD7E0
	public void RemoveAttachedModifier(BaseActorActionContext baseContext, ActorModifier modifier) {} // 0x0000000180DF2AE0-0x0000000180DF2BC0
	// [XID] // 0x00000001897A80A0-0x00000001897A80C0
	public void DetachAttachModifierFromActor(BaseActorActionContext baseContext, LCAbility actor, RemoveAbilityReason removeReason) {} // 0x0000000180E1C9D0-0x0000000180E1CB50
	// [XID] // 0x0000000189965CB0-0x0000000189965CD0
	public bool InServerBuffModifierBucket(uint serverBuffUID, uint instancedModifierID) => default; // 0x0000000180DF2BC0-0x0000000180DF2F60
	// [XID] // 0x00000001899D2360-0x00000001899D2380
	public bool IsInServerBuffBucket(ActorModifier modifier) => default; // 0x0000000180DFB480-0x0000000180DFB590
	// [XID] // 0x00000001897BF840-0x00000001897BF860
	public bool IsServerBuffModifierCanOnAdded(uint serverBuffUid, int actionLocalID) => default; // 0x0000000180DEC550-0x0000000180DEC870
	// [XID] // 0x000000018995B2D0-0x000000018995B2F0
	public void CheckBucketNum() {} // 0x0000000180E41950-0x0000000180E424D0
	// [XID] // 0x00000001897CE5A0-0x00000001897CE5C0
	public bool ByTargetHPRatioHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180DEFF50-0x0000000180DF0150
	// [XID] // 0x00000001897D5C90-0x00000001897D5CB0
	public bool ByTargetRaycastVisiableHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E15550-0x0000000180E15820
	// [XID] // 0x00000001897DD410-0x00000001897DD430
	public bool ByLocalAvatarStaminaHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E36DA0-0x0000000180E36F50
	// [XID] // 0x00000001897E4D10-0x00000001897E4D30
	public bool ByLocalAvatarStaminaRatioHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E2D640-0x0000000180E2D7F0
	// [XID] // 0x00000001897EC950-0x00000001897EC970
	public bool ByTargetHPValueHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E382E0-0x0000000180E384C0
	// [XID] // 0x00000001897F41A0-0x00000001897F41C0
	public bool ByHitDamageHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E324F0-0x0000000180E326E0
	// [XID] // 0x00000001897FBC00-0x00000001897FBC20
	public bool ByHitEnBreakHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E0BB40-0x0000000180E0BD30
	// [XID] // 0x00000001898030D0-0x00000001898030F0
	public bool ByTargetOverrideMapValueHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E3E2F0-0x0000000180E3E520
	// [XID] // 0x000000018980A580-0x000000018980A5A0
	public bool ByHitCriticalHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E15110-0x0000000180E15290
	// [XID] // 0x0000000189811CE0-0x0000000189811D00
	public bool ByHasElementHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E17350-0x0000000180E175A0
	// [XID] // 0x0000000189819970-0x0000000189819990
	private bool HasMassiveEntityElement(BaseEntity entity, ElementType elementType) => default; // 0x0000000180E23C90-0x0000000180E23D90
	// [XID] // 0x00000001898210B0-0x00000001898210D0
	public bool ByHasAbilityStateHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E20640-0x0000000180E207E0
	// [XID] // 0x0000000189828660-0x0000000189828680
	public bool ByNotHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180DF1130-0x0000000180DF12F0
	// [XID] // 0x000000018982F8F0-0x000000018982F910
	public bool ByAnyHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E408D0-0x0000000180E40A90
	// [XID] // 0x00000001898371D0-0x00000001898371F0
	public bool ByHasAttackTargetHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180DF9080-0x0000000180DF9190
	// [XID] // 0x000000018983E770-0x000000018983E790
	public bool ByTargetIsGhostToEnemyHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E086C0-0x0000000180E08820
	// [XID] // 0x0000000189845DD0-0x0000000189845DF0
	public bool ByTargetIsSelfHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E36C10-0x0000000180E36DA0
	// [XID] // 0x000000018984D380-0x000000018984D3A0
	public bool ByTargetElementHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E44090-0x0000000180E44240
	// [XID] // 0x0000000189854470-0x0000000189854490
	public bool ByTargetWeightHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180DF86A0-0x0000000180DF88E0
	// [XID] // 0x000000018985BDE0-0x000000018985BE00
	public bool ByAnimatorFloatHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E1D050-0x0000000180E1D210
	// [XID] // 0x00000001898634C0-0x00000001898634E0
	public bool ByAnimatorIntHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E34D90-0x0000000180E34F40
	// [XID] // 0x000000018986A990-0x000000018986A9B0
	public bool ByAnimatorBoolHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E09A80-0x0000000180E09C00
	// [XID] // 0x0000000189871D90-0x0000000189871DB0
	public bool ByTargetGlobalValueHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180DFFD40-0x0000000180E000D0
	// [XID] // 0x00000001898795A0-0x00000001898795C0
	public bool ByScenePropStateHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E1A0C0-0x0000000180E1A410
	// [XID] // 0x0000000189880C30-0x0000000189880C50
	public bool ByAvatarInWaterDepthHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180DFB590-0x0000000180DFB7D0
	// [XID] // 0x0000000189888000-0x0000000189888020
	public bool ByEntityTypeHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E45190-0x0000000180E45470
	// [XID] // 0x000000018988F560-0x000000018988F580
	public bool ByHitImpulseHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E312D0-0x0000000180E31450
	// [XID] // 0x0000000189896B00-0x0000000189896B20
	public bool ByHitElementHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E30D50-0x0000000180E30F40
	// [XID] // 0x000000018989DF10-0x000000018989DF30
	public bool ByHitStrikeTypeHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180DF1530-0x0000000180DF1720
	// [XID] // 0x00000001898A58F0-0x00000001898A5910
	public bool ByIsMoveOnWaterHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E30F40-0x0000000180E31090
	// [XID] // 0x00000001898ACE20-0x00000001898ACE40
	public bool BySceneSurfaceTypeHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E09F50-0x0000000180E0A2F0
	// [XID] // 0x00000001898B4370-0x00000001898B4390
	public bool ByAttackTagsHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E0B6A0-0x0000000180E0B870
	// [XID] // 0x00000001898BC1B0-0x00000001898BC1D0
	public bool ByUnlockTalentParamHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E01D00-0x0000000180E01EA0
	// [XID] // 0x00000001898C3550-0x00000001898C3570
	public bool ByHitBoxNameHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180DF9430-0x0000000180DF9830
	// [XID] // 0x00000001898CAED0-0x00000001898CAEF0
	public bool ByHitBoxTypeHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E27790-0x0000000180E27AD0
	// [XID] // 0x00000001898D2590-0x00000001898D25B0
	public bool ByConductiveHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E44400-0x0000000180E445E0
	// [XID] // 0x00000001898D9ED0-0x00000001898D9EF0
	public bool ByTargetPositionToSelfPositionHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E39B90-0x0000000180E39EF0
	// [XID] // 0x00000001898E1A60-0x00000001898E1A80
	public bool ByTargetForwardAndSelfPositionHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E0A6B0-0x0000000180E0A890
	// [XID] // 0x00000001898E97F0-0x00000001898E9810
	public bool BySelfForwardAndTargetPositionHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E35D20-0x0000000180E35F00
	// [XID] // 0x00000001898F0D60-0x00000001898F0D80
	public bool ByEnergyRatioHandler(ByEnergyRatio predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180DEC280-0x0000000180DEC400
	// [XID] // 0x00000001898F86E0-0x00000001898F8700
	public bool BySummonTagValueHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E34BA0-0x0000000180E34D90
	// [XID] // 0x00000001898FFF20-0x00000001898FFF40
	public bool ByAttackNotHitSceneHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E35F00-0x0000000180E36100
	// [XID] // 0x0000000189907680-0x00000001899076A0
	public bool BySkillReadyHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E21FD0-0x0000000180E22210
	// [XID] // 0x000000018990EF90-0x000000018990EFB0
	public bool ByIsCombatHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E2EB90-0x0000000180E2ED10
	// [XID] // 0x0000000189916860-0x0000000189916880
	public bool ByAvatarWeaponTypeHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E2BEB0-0x0000000180E2C0E0
	// [XID] // 0x000000018991E010-0x000000018991E030
	public bool ByTagetAltitudeHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180DEBE60-0x0000000180DEC220
	// [XID] // 0x0000000189925900-0x0000000189925920
	public bool ByStageIsReadyTempHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E09C00-0x0000000180E09DA0
	// [XID] // 0x000000018992CDB0-0x000000018992CDD0
	public bool ByItemNumberHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E19060-0x0000000180E192C0
	// [XID] // 0x00000001899342A0-0x00000001899342C0
	public bool ByHasComponentTagHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E01AD0-0x0000000180E01C80
	// [XID] // 0x000000018993BFB0-0x000000018993BFD0
	public bool ByHasFeatureTagHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E00300-0x0000000180E00580
	// [XID] // 0x00000001899433B0-0x00000001899433D0
	public bool ByAvatarElementTypeHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E0E520-0x0000000180E0E6E0
	// [XID] // 0x000000018994AA80-0x000000018994AAA0
	public bool ByAvatarBodyTypeHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E0AF30-0x0000000180E0B110
	// [XID] // 0x00000001899524B0-0x00000001899524D0
	public bool ByCurTeamHasFeatureTagHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E2B1B0-0x0000000180E2B3E0
	// [XID] // 0x0000000189959950-0x0000000189959970
	public bool ByBigTeamHasFeatureTagHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180DF0F00-0x0000000180DF1130
	// [XID] // 0x0000000189961270-0x0000000189961290
	private int GetTeamFeatureTagCount(List<uint> ids, uint featureTagID) => default; // 0x0000000180E027E0-0x0000000180E02A80
	// [XID] // 0x0000000189968950-0x0000000189968970
	public bool ByCurTeamHasElementTypeHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180DF9950-0x0000000180DF9B80
	// [XID] // 0x000000018996FF40-0x000000018996FF60
	public bool ByBigTeamHasElementTypeHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E234C0-0x0000000180E236F0
	// [XID] // 0x0000000189977D30-0x0000000189977D50
	private int GetTeamElementTypeCount(List<uint> ids, ElementType elementType) => default; // 0x0000000180E0F420-0x0000000180E0F680
	// [XID] // 0x000000018997EF50-0x000000018997EF70
	public bool ByCurTeamElementTypeSortHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E2F1F0-0x0000000180E2F400
	// [XID] // 0x0000000189986850-0x0000000189986870
	public bool ByBigTeamElementTypeSortHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E37C40-0x0000000180E37E50
	// [XID] // 0x000000018998E450-0x000000018998E470
	private int GetTeamElementTypeSort(List<uint> ids) => default; // 0x0000000180DF1BF0-0x0000000180DF1EC0
	// [XID] // 0x0000000189995FA0-0x0000000189995FC0
	public bool ByCurTeamHasWeaponTypeHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E22D40-0x0000000180E22F70
	// [XID] // 0x000000018999D9E0-0x000000018999DA00
	public bool ByBigTeamHasWeaponTypeHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E27040-0x0000000180E27270
	// [XID] // 0x00000001899A5300-0x00000001899A5320
	private int GetTeamHasWeaponType(List<uint> ids, string weaponType) => default; // 0x0000000180E16950-0x0000000180E16BC0
	// [XID] // 0x00000001899ACD30-0x00000001899ACD50
	public bool ByCurTeamWeaponTypeSortHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E1A550-0x0000000180E1A760
	// [XID] // 0x00000001899B4550-0x00000001899B4570
	public bool ByBigTeamWeaponTypeSortHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E32CB0-0x0000000180E32EC0
	// [XID] // 0x00000001899BB9D0-0x00000001899BB9F0
	private int GetTeamHasWeaponTypeSort(List<uint> ids) => default; // 0x0000000180E15AF0-0x0000000180E15D90
	// [XID] // 0x00000001899C3610-0x00000001899C3630
	public bool ByCurTeamHasBodyTypeHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E1B750-0x0000000180E1B980
	// [XID] // 0x00000001899CAAA0-0x00000001899CAAC0
	public bool ByBigTeamHasBodyTypeHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E217C0-0x0000000180E219F0
	// [XID] // 0x00000001899D20D0-0x00000001899D20F0
	private int GetTeamHasBodyType(List<uint> ids, string bodyType) => default; // 0x0000000180E247C0-0x0000000180E24A30
	// [XID] // 0x00000001899D97B0-0x00000001899D97D0
	public bool ByCurTeamBodyTypeSortHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E13F10-0x0000000180E14120
	// [XID] // 0x00000001899E0E30-0x00000001899E0E50
	public bool ByBigTeamBodyTypeSortHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E1CB50-0x0000000180E1CD60
	// [XID] // 0x00000001899E8A00-0x00000001899E8A20
	private int GetTeamHasBodyTypeSort(List<uint> ids) => default; // 0x0000000180E35A00-0x0000000180E35CA0
	// [XID] // 0x00000001899F0120-0x00000001899F0140
	public bool ByAttackTypeHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E21660-0x0000000180E217C0
	// [XID] // 0x00000001899F7700-0x00000001899F7720
	public bool ByCompareWithTargetHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E175A0-0x0000000180E178C0
	// [XID] // 0x00000001899FEDE0-0x00000001899FEE00
	public bool ByEntityAppearVisionTypeHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E21A50-0x0000000180E21C60
	// [XID] // 0x0000000189A06660-0x0000000189A06680
	public bool ByElementTriggerEntityTypeHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E29640-0x0000000180E298D0
	// [XID] // 0x0000000189A0DBA0-0x0000000189A0DBC0
	public bool ByElementReactionSourceTypeHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E1D5F0-0x0000000180E1D780
	// [XID] // 0x0000000189A152C0-0x0000000189A152E0
	public bool ByElementReactionTypeHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180DFB250-0x0000000180DFB3E0
	// [XID] // 0x0000000189A1C3F0-0x0000000189A1C410
	public bool ByTargetConfigIDHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180DF4210-0x0000000180DF45B0
	// [XID] // 0x0000000189A23DB0-0x0000000189A23DD0
	public bool ByIsLocalAvatarHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E24EC0-0x0000000180E25010
	// [XID] // 0x0000000189A2B080-0x0000000189A2B0A0
	public bool ByTargetGadgetStateHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E17CF0-0x0000000180E17EA0
	// [XID] // 0x0000000189A32750-0x0000000189A32770
	public bool ByDieStateFlagHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E3DBB0-0x0000000180E3DD40
	// [XID] // 0x0000000189A3A050-0x0000000189A3A070
	public bool ByHasShieldHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E15F40-0x0000000180E16100
	// [XID] // 0x0000000189A41920-0x0000000189A41940
	public bool ByGlobalPosToGroundHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E14310-0x0000000180E149F0
	// [XID] // 0x0000000189A48F30-0x0000000189A48F50
	public bool ByEquipAffixReadyHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E34780-0x0000000180E34910
	// [XID] // 0x0000000189A50880-0x0000000189A508A0
	public bool ByIsTargetCampHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E079A0-0x0000000180E07C50
	// [XID] // 0x0000000189A57D40-0x0000000189A57D60
	public bool ByHasChildGadgetHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180DF4B10-0x0000000180DF5070
	// [XID] // 0x0000000189A5F9B0-0x0000000189A5F9D0
	public bool ByIsGadgetExistAroundHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E13750-0x0000000180E13C10
	// [XID] // 0x0000000189A672D0-0x0000000189A672F0
	public bool ByEntityIsAliveHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180DEF340-0x0000000180DEF450
	// [XID] // 0x0000000189A6E920-0x0000000189A6E940
	public bool ByMonsterAirStateHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180DF1720-0x0000000180DF18D0
	// [XID] // 0x0000000189A761B0-0x0000000189A761D0
	public bool ByTargetLayoutAreaHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E232D0-0x0000000180E234C0
	// [XID] // 0x0000000189A7DB80-0x0000000189A7DBA0
	public bool ByGameTimeIsLockedHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180DEEA10-0x0000000180DEEBB0
	// [XID] // 0x0000000189A85430-0x0000000189A85450
	public bool ByTargetIsCasterHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180DEBAF0-0x0000000180DEBC50
	// [XID] // 0x0000000189A8CE40-0x0000000189A8CE60
	public bool ByHasTagHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E365B0-0x0000000180E36780
	// [XID] // 0x0000000189A94110-0x0000000189A94130
	public bool ByHitElementDurabilityHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E42940-0x0000000180E42BF0
	// [XID] // 0x0000000189A9BB00-0x0000000189A9BB20
	public bool ByCurrentSceneTypesHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180E021E0-0x0000000180E02420
	// [XID] // 0x0000000189AA2FC0-0x0000000189AA2FE0
	public bool ByTargetTypeHandler(ByTargetType predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180DF9B80-0x0000000180DF9E70
	// [XID] // 0x0000000189AAA4D0-0x0000000189AAA4F0
	public bool ByCurrentSceneIdHandler(ConfigAbilityPredicate predConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000180DFAFC0-0x0000000180DFB250
}

