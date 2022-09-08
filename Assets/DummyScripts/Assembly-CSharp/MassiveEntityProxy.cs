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

public class MassiveEntityProxy // TypeDefIndex: 20587
{
	// Fields
	private BaseEntity _entity; // 0x10
	private LevelTileAttackPlugin _tilePlugin; // 0x18
	public ActorAbilityPlugin.AbilityAttackTarget abilityTarget; // 0x20
	private bool _isDestroyed; // 0x40
	private bool _isInitedExternal; // 0x41
	private long _preScenePropId; // 0x48
	private long _scenePropId; // 0x50
	private MassiveElementStateIndex _index; // 0x58
	private MassiveTriggerStateIndex _triggerPendingIndex; // 0x60
	private MassiveTriggerStateIndex _triggerTickIndex; // 0x68
	private List<MassiveEntityAbilityProxy> _onFlushAbilityProxys; // 0x70
	private List<MassiveEntityAbilityProxy> _onPreUpdateAbilityProxys; // 0x78
	private List<MassiveElementReactionEvent>[] _reactionEvents; // 0x80
	private uint[] _triggerSourceIds; // 0x88
	private AbilityState _abilityState; // 0x90
	private MassiveEntityAbilityProxy[] _abilityProxys; // 0x98
	private float[] _elementDurabilities; // 0xA0
	private bool[] _elementDurabilityMutables; // 0xA8

	// Properties
	public BaseEntity entity { /* [XID] */ /* 0x0000000189803C10-0x0000000189803C30 */ get => default; } // 0x0000000181B148B0-0x0000000181B14950 
	private LevelTileAttackPlugin tilePlugin { /* [XID] */ /* 0x000000018980B090-0x000000018980B0B0 */ get => default; } // 0x0000000181B14420-0x0000000181B14530 
	public bool needToBeDestroy { /* [XID] */ /* 0x00000001898126E0-0x0000000189812700 */ get => default; } // 0x0000000181B13240-0x0000000181B13330 
	public EntityType entityType { /* [XID] */ /* 0x000000018981A380-0x000000018981A3A0 */ get => default; } // 0x0000000181B13990-0x0000000181B13A40 
	public uint runtimeId { /* [XID] */ /* 0x0000000189821A30-0x0000000189821A50 */ get => default; } // 0x0000000181B14AB0-0x0000000181B14B60 
	public bool isDestroyed { /* [XID] */ /* 0x0000000189829000-0x0000000189829020 */ get => default; } // 0x0000000181B12790-0x0000000181B12830 
	public bool isInitedExternal { /* [XID] */ /* 0x0000000189830530-0x0000000189830550 */ get => default; } // 0x0000000181B138F0-0x0000000181B13990 
	public long preScenePropId { /* [XID] */ /* 0x00000001898469B0-0x00000001898469D0 */ get => default; } // 0x0000000181B13510-0x0000000181B135B0 
	public long scenePropId { /* [XID] */ /* 0x000000018984DFA0-0x000000018984DFC0 */ get => default; } // 0x0000000181B14950-0x0000000181B149F0 
	public MassiveElementStateIndex index { /* [XID] */ /* 0x0000000189854FF0-0x0000000189855010 */ get => default; } // 0x0000000181B14380-0x0000000181B14420 
	public MassiveTriggerStateIndex triggerPendingIndex { /* [XID] */ /* 0x000000018985C750-0x000000018985C770 */ get => default; } // 0x0000000181B129E0-0x0000000181B12A80 
	public MassiveTriggerStateIndex triggerTickIndex { /* [XID] */ /* 0x00000001898640B0-0x00000001898640D0 */ get => default; } // 0x0000000181B14EB0-0x0000000181B14F50 

	// Constructors
	public MassiveEntityProxy() {} // 0x0000000181B155D0-0x0000000181B15720

	// Methods
	// [XID] // 0x00000001897F4BF0-0x00000001897F4C10
	public static MassiveEntityProxy Create(BaseEntity entity) => default; // 0x0000000181B13EB0-0x0000000181B13F80
	// [XID] // 0x00000001897FC660-0x00000001897FC680
	public static void Release(ref MassiveEntityProxy proxy) {} // 0x0000000181B14640-0x0000000181B14700
	// [XID] // 0x0000000189837BB0-0x0000000189837BD0
	public void InitExternal() {} // 0x0000000181B15420-0x0000000181B154C0
	// [XID] // 0x000000018983F330-0x000000018983F350
	public void ClearExternal() {} // 0x0000000181B12830-0x0000000181B128D0
	// [XID] // 0x000000018986B4A0-0x000000018986B4C0
	private void InitReationEvents() {} // 0x0000000181B12CA0-0x0000000181B12E00
	// [XID] // 0x0000000189872810-0x0000000189872830
	private void DestroyReactionEvents() {} // 0x0000000181B13F80-0x0000000181B14090
	// [XID] // 0x000000018987A4A0-0x000000018987A4C0
	public void AddReactionEvent(MassiveElementTriggerType triggerType, MassiveElementReactionEvent evt) {} // 0x0000000181B14270-0x0000000181B14380
	// [XID] // 0x00000001898815A0-0x00000001898815C0
	public List<MassiveElementReactionEvent> GetReactionEvents(int triggerType) => default; // 0x0000000181B14090-0x0000000181B14170
	// [XID] // 0x0000000189888AE0-0x0000000189888B00
	public void SetTriggerSourceId(AbilityTriggerMassiveElementTask.AbilityTriggerContainerType triggerContainerType, uint runtimeId) {} // 0x0000000181B13A40-0x0000000181B13B30
	// [XID] // 0x000000018988FF00-0x000000018988FF20
	public uint GetTriggerSourceId(AbilityTriggerMassiveElementTask.AbilityTriggerContainerType triggerContainerType) => default; // 0x0000000181B126B0-0x0000000181B12790
	// [XID] // 0x0000000189897480-0x00000001898974A0
	public void AddAbilityState(AbilityState state) {} // 0x0000000181B14800-0x0000000181B148B0
	// [XID] // 0x000000018989E960-0x000000018989E980
	public void RemoveAbilityState(AbilityState state) {} // 0x0000000181B13840-0x0000000181B138F0
	// [XID] // 0x00000001898A6440-0x00000001898A6460
	public bool ContainAbilityState(AbilityState state) => default; // 0x0000000181B15360-0x0000000181B15420
	// [XID] // 0x00000001898ADAF0-0x00000001898ADB10
	private void InitAbilityProxys() {} // 0x0000000181B14D60-0x0000000181B14EB0
	// [XID] // 0x00000001898B5000-0x00000001898B5020
	private void DestroyAbilityProxys() {} // 0x0000000181B13DC0-0x0000000181B13EB0
	// [XID] // 0x00000001898BCAB0-0x00000001898BCAD0
	public void AttachAbility(int index, ConfigMassiveElementTriggerAction config, out bool hasActionOnFlush, out bool hasActionOnPreUpdate) {
		hasActionOnFlush = default;
		hasActionOnPreUpdate = default;
	} // 0x0000000181B135B0-0x0000000181B13740
	// [XID] // 0x00000001898C4210-0x00000001898C4230
	public bool DetachAbility(int index) => default; // 0x0000000181B14700-0x0000000181B14800
	// [XID] // 0x00000001898CB870-0x00000001898CB890
	public MassiveEntityAbilityProxy GetAbility(int index) => default; // 0x0000000181B15280-0x0000000181B15360
	// [XID] // 0x00000001898D2F90-0x00000001898D2FB0
	public bool TickAbility(int index, float deltaTime) => default; // 0x0000000181B128D0-0x0000000181B129E0
	// [XID] // 0x00000001898DA940-0x00000001898DA960
	public float GetAbilityDurability(int index) => default; // 0x0000000181B14170-0x0000000181B14270
	// [XID] // 0x00000001898E2760-0x00000001898E2780
	public void SetAbilityDurability(int index, float value) {} // 0x0000000181B13740-0x0000000181B13840
	// [XID] // 0x00000001898EA230-0x00000001898EA250
	public void SetAbilityDurabilityInternal(int index, float value) {} // 0x0000000181B15180-0x0000000181B15280
	// [XID] // 0x00000001898F1A50-0x00000001898F1A70
	public bool TickAbilityDurability(int index, float deltaTimeDurability) => default; // 0x0000000181B14530-0x0000000181B14640
	// [XID] // 0x00000001898F91B0-0x00000001898F91D0
	public void HandleOnFlush() {} // 0x0000000181B14F50-0x0000000181B15080
	// [XID] // 0x0000000189900B30-0x0000000189900B50
	public void HandleOnPreUpdate() {} // 0x0000000181B13C90-0x0000000181B13DC0
	// [XID] // 0x00000001899082F0-0x0000000189908310
	public void RegisterAttackTile(string attackID) {} // 0x0000000181B12A80-0x0000000181B12B90
	// [XID] // 0x000000018990FAB0-0x000000018990FAD0
	public void UnregisterAttackTile(string attackID) {} // 0x0000000181B14C50-0x0000000181B14D60
	// [XID] // 0x00000001899174E0-0x0000000189917500
	public void RegisterActionTile(string actionID, int triggerContainerType) {} // 0x0000000181B12FC0-0x0000000181B13120
	// [IDTag] // 0x000000018991EB40-0x000000018991EB80
	// [XID] // 0x000000018991EB40-0x000000018991EB80
	public float GetElementDurability(ElementType elementType) => default; // 0x0000000181B13420-0x0000000181B13510
	// [IDTag] // 0x0000000189929400-0x0000000189929440
	// [XID] // 0x0000000189929400-0x0000000189929440
	public float GetElementDurability(int elementType) => default; // 0x0000000181B13330-0x0000000181B13420
	// [XID] // 0x0000000189933700-0x0000000189933720
	internal void SetElementDurabilityOnInit(ElementType elementType, float value) {} // 0x0000000181B14B60-0x0000000181B14C50
	// [XID] // 0x000000018993B390-0x000000018993B3B0
	public void SetElementDurability(ElementType elementType, float value) {} // 0x0000000181B13120-0x0000000181B13240
	// [XID] // 0x00000001899424A0-0x00000001899424C0
	public void InitElementDurabilityMutables() {} // 0x0000000181B154C0-0x0000000181B155D0
	// [XID] // 0x0000000189949E00-0x0000000189949E20
	public void SetElementDurabilityMutable(ElementType elementType, bool value) {} // 0x0000000181B12ED0-0x0000000181B12FC0
	// [XID] // 0x00000001899519A0-0x00000001899519C0
	public bool HasElement(ElementType elementType) => default; // 0x0000000181B12E00-0x0000000181B12ED0
	// [XID] // 0x0000000189958EB0-0x0000000189958ED0
	public void Init(BaseEntity entity) {} // 0x0000000181B13B30-0x0000000181B13C90
	// [XID] // 0x0000000189960580-0x00000001899605A0
	public void ClearDurability() {} // 0x0000000181B15080-0x0000000181B15180
	// [XID] // 0x0000000189967F40-0x0000000189967F60
	public void SwitchScenePropId(long scenePropId) {} // 0x0000000181B149F0-0x0000000181B14AB0
	// [XID] // 0x000000018996F1C0-0x000000018996F1E0
	public void Destroy() {} // 0x0000000181B12B90-0x0000000181B12CA0
}

