/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityComponentProxy : AbilityActionExecuter, IComponentProxy // TypeDefIndex: 20570
{
	// Fields
	private List<AbilityInstance> _activeAbilityInstances; // 0x10
	private List<AbilityInstance> _pendingInstances; // 0x18
	private Dictionary<int, AbilityInstance> _abilityInstanceCache; // 0x20
	private BaseEntity _entity; // 0x28
	private IComponentProxyMgr _proxyMgr; // 0x30
	private TokenManager _tokenMgr; // 0x38
	private AbilitySystemData _taskData; // 0x40
	private List<Ability> _onBeingHitAbility; // 0x48
	private Dictionary<int, AbilityContext> _registerEvents; // 0x50
	private int _index; // 0x58

	// Properties
	public int index { /* [XID] */ /* 0x0000000189973EF0-0x0000000189973F10 */ get => default; /* [XID] */ /* 0x000000018997B690-0x000000018997B6B0 */ set {} } // 0x00000001841568B0-0x0000000184156950 0x0000000184156950-0x0000000184156A00

	// Constructors
	public AbilityComponentProxy() {} // 0x0000000184157370-0x0000000184157490

	// Methods
	// [XID] // 0x000000018968D720-0x000000018968D740
	public static AbilityComponentProxy Create(BaseEntity entity) => default; // 0x00000001841561D0-0x00000001841562A0
	// [XID] // 0x0000000189964E90-0x0000000189964EB0
	public static void Release(ref AbilityComponentProxy proxy) {} // 0x0000000184156A00-0x0000000184156AC0
	// [XID] // 0x000000018996C3F0-0x000000018996C410
	public override BaseEntity GetEntity() => default; // 0x0000000184155190-0x0000000184155230
	// [XID] // 0x0000000189983130-0x0000000189983150
	public void Init(BaseEntity entity) {} // 0x0000000184155AF0-0x0000000184155BA0
	// [XID] // 0x000000018998A880-0x000000018998A8A0
	public void InitMgr(IComponentProxyMgr proxyMgr) {} // 0x00000001841564B0-0x0000000184156590
	// [XID] // 0x0000000189676D90-0x0000000189676DB0
	public void InitWithConfig(ConfigEntityAbilitySystem config) {} // 0x0000000184156AC0-0x0000000184156B90
	// [XID] // 0x0000000189999EF0-0x0000000189999F10
	private void InitAbilitySystem(ref List<Ability> abilities, ConfigAbilitySystem[] abilitySystems) {} // 0x00000001841552A0-0x0000000184155430
	// [XID] // 0x00000001899A1570-0x00000001899A1590
	public override void HandleAction(ConfigAbilityAction actionConfig, IAbilityActionContainer instance, ActorAbilityPlugin.AbilityAttackTarget target) {} // 0x0000000184155F20-0x0000000184156130
	// [XID] // 0x00000001899A8F60-0x00000001899A8F80
	private void CheckTaskData() {} // 0x0000000184157200-0x00000001841572D0
	// [XID] // 0x00000001899B0A10-0x00000001899B0A30
	private void CheckTaskDataFinished() {} // 0x0000000184155520-0x0000000184155610
	// [XID] // 0x00000001899B7D50-0x00000001899B7D70
	public void CheckShouldTick() {} // 0x00000001841570B0-0x0000000184157200
	// [XID] // 0x00000001899BF770-0x00000001899BF790
	public void Tick() {} // 0x0000000184155BA0-0x0000000184155F20
	// [XID] // 0x00000001899A86C0-0x00000001899A86E0
	public void Clear() {} // 0x0000000184156130-0x00000001841561D0
	// [XID] // 0x00000001899CE5F0-0x00000001899CE610
	public void Destory() {} // 0x00000001841557C0-0x0000000184155A40
	// [XID] // 0x00000001896FC690-0x00000001896FC6B0
	private void ReleaseAbilities(List<Ability> abilities) {} // 0x00000001841562A0-0x00000001841563C0
	// [XID] // 0x00000001896F4EE0-0x00000001896F4F00
	private bool HasAbility(List<Ability> abilities) => default; // 0x00000001841567E0-0x00000001841568B0
	// [IDTag] // 0x00000001899E4CE0-0x00000001899E4D20
	// [XID] // 0x00000001899E4CE0-0x00000001899E4D20
	private AbilityContext ActiveAbility(Ability ability) => default; // 0x0000000184156F70-0x00000001841570B0
	// [IDTag] // 0x00000001899EF160-0x00000001899EF1A0
	// [XID] // 0x00000001899EF160-0x00000001899EF1A0
	private void ActiveAbility(List<Ability> abilities, AbilityContextCommand cmd) {} // 0x0000000184156E30-0x0000000184156F70
	// [XID] // 0x00000001899F9990-0x00000001899F99B0
	private AbilityInstance GetSingleInstance(Ability ability) => default; // 0x00000001841556C0-0x00000001841557C0
	// [XID] // 0x0000000189A00D30-0x0000000189A00D50
	private void AddSingleInstance(Ability ability, AbilityInstance instance) {} // 0x00000001841563C0-0x00000001841564B0
	// [XID] // 0x00000001897739E0-0x0000000189773A00
	private void AddPendingInstance(AbilityInstance instance) {} // 0x0000000184156B90-0x0000000184156C90
	// [XID] // 0x0000000189A0FC30-0x0000000189A0FC50
	public void RegisterEvent(AbilityEventID evtID, AbilityContext context) {} // 0x0000000184156590-0x00000001841566B0
	// [XID] // 0x0000000189A170D0-0x0000000189A170F0
	public void UnregisterEvent(AbilityEventID evtID) {} // 0x0000000184155430-0x0000000184155520
	// [XID] // 0x000000018977F6D0-0x000000018977F6F0
	public void HandleBeingHit(uint attackerId, uint targetId, AttackResult attackResult, BaseEntity targetEntity) {} // 0x0000000184156C90-0x0000000184156E30
	// [XID] // 0x0000000189A25EF0-0x0000000189A25F10
	public void TriggerAbility() {} // 0x00000001841572D0-0x0000000184157370
	// [XID] // 0x0000000189A2D2D0-0x0000000189A2D2F0
	public void HandleAbilityEvent(AbilityTaskEvent evt) {} // 0x00000001841566B0-0x00000001841567E0
	// [XID] // 0x0000000189A34D90-0x0000000189A34DB0
	public void HasElement(ElementType elementType) {} // 0x0000000184155610-0x00000001841556C0
}

