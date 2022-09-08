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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityTriggerMassiveElementTaskBlackboard : AbilityTaskBlackboard // TypeDefIndex: 20588
{
	// Fields
	public const int DEFAULT_PROXY_SIZE = 151; // Metadata: 0x00AFDE36
	private ConfigTriggerMassiveElementTask _config; // 0x10
	private List<ConfigMassiveEntityElement>[] _massiveEntityElementConfigs; // 0x18
	private Dictionary<long, MassiveEntityProxy> _massiveEntityProxyDic; // 0x20
	private IndexHandleObjectList<MassiveEntityProxy>[] _elementType2ProxyArray; // 0x28
	private IndexHandleObjectList<MassiveEntityProxy>[] _triggerType2ProxyPendingArray; // 0x30
	private IndexHandleObjectList<MassiveEntityProxy>[] _triggerType2ProxyTickArray; // 0x38
	private float[] _globalElementDurability; // 0x40
	private bool[] _forceEnableElementReactionEvents; // 0x48
	private List<MassiveEntityProxy> _toBeOnFlush; // 0x50
	private List<MassiveEntityProxy> _toBeOnPreUpdate; // 0x58
	private Queue<MassiveElementReactionEvent> _toBeHandleElementReactionEvent; // 0x60
	private List<MassiveEntityAbilityProxy> _toBeFlushDetachAbilityProxys; // 0x68

	// Properties
	public List<MassiveEntityProxy> toBeOnFlush { /* [XID] */ /* 0x0000000189976D70-0x0000000189976D90 */ get => default; } // 0x0000000184682030-0x00000001846820D0 
	public List<MassiveEntityProxy> toBeOnPreUpdate { /* [XID] */ /* 0x000000018997E140-0x000000018997E160 */ get => default; } // 0x0000000184681F90-0x0000000184682030 
	public Queue<MassiveElementReactionEvent> toBeHandleElementReactionEvent { /* [XID] */ /* 0x0000000189985C50-0x0000000189985C70 */ get => default; } // 0x0000000184682820-0x00000001846828C0 
	public List<MassiveEntityAbilityProxy> toBeFlushDetachAbilityProxys { /* [XID] */ /* 0x000000018998D8A0-0x000000018998D8C0 */ get => default; } // 0x0000000184682CE0-0x0000000184682D80 

	// Constructors
	public AbilityTriggerMassiveElementTaskBlackboard() {} // 0x0000000184683AD0-0x0000000184683C60

	// Methods
	// [XID] // 0x0000000189995350-0x0000000189995370
	public void RegisterProxy(MassiveEntityProxy proxy) {} // 0x0000000184683330-0x00000001846835A0
	// [XID] // 0x000000018999CE10-0x000000018999CE30
	private void ClearProxy(MassiveEntityProxy proxy) {} // 0x0000000184681D20-0x0000000184681EA0
	// [XID] // 0x00000001899A46F0-0x00000001899A4710
	private void InitProxy(MassiveEntityProxy proxy) {} // 0x0000000184683900-0x0000000184683AD0
	// [XID] // 0x00000001899AC090-0x00000001899AC0B0
	public void SetProxyElement(ElementType elementType, MassiveEntityProxy proxy) {} // 0x0000000184682A80-0x0000000184682BE0
	// [XID] // 0x00000001899B3900-0x00000001899B3920
	public void RemoveProxyElement(ElementType elementType, MassiveEntityProxy proxy) {} // 0x00000001846835A0-0x0000000184683710
	// [XID] // 0x00000001899BAD60-0x00000001899BAD80
	public void SetGlobalElementDurability(ElementType elementType, float durability) {} // 0x0000000184683160-0x0000000184683250
	// [XID] // 0x00000001899C2770-0x00000001899C2790
	public float GetGlobalElementDurability(ElementType elementType) => default; // 0x00000001846816A0-0x0000000184681780
	// [XID] // 0x00000001899C9D80-0x00000001899C9DA0
	public void SetForceEnableElementReactionEvent(MassiveElementTriggerType triggerType, bool value) {} // 0x0000000184681EA0-0x0000000184681F90
	// [XID] // 0x00000001899D1640-0x00000001899D1660
	public bool IsForceEnableElementReactionEvent(MassiveElementTriggerType triggerType) => default; // 0x0000000184682E50-0x0000000184682F30
	// [XID] // 0x00000001899D8B90-0x00000001899D8BB0
	public IndexHandleObjectList<MassiveEntityProxy> GetProxyTriggerPending(MassiveElementTriggerType triggerType) => default; // 0x0000000184683250-0x0000000184683330
	// [XID] // 0x00000001899E0220-0x00000001899E0240
	public IndexHandleObjectList<MassiveEntityProxy> GetProxyTriggerTick(MassiveElementTriggerType triggerType) => default; // 0x0000000184683080-0x0000000184683160
	// [XID] // 0x00000001899E7D80-0x00000001899E7DA0
	public void SetProxyTriggerPending(MassiveElementTriggerType triggerType, MassiveEntityProxy proxy) {} // 0x00000001846823B0-0x00000001846824B0
	// [XID] // 0x00000001899EF140-0x00000001899EF160
	public void SetProxyTriggerTick(MassiveElementTriggerType triggerType, MassiveEntityProxy proxy) {} // 0x0000000184682BE0-0x0000000184682CE0
	// [XID] // 0x00000001899F6B30-0x00000001899F6B50
	private void SetProxyTriggerInternal(MassiveElementTriggerType triggerType, MassiveEntityProxy proxy, MassiveTriggerStateIndex index, IndexHandleObjectList<MassiveEntityProxy>[] proxyArray) {} // 0x00000001846824B0-0x0000000184682610
	// [XID] // 0x00000001899FE110-0x00000001899FE130
	public void RemoveProxyTriggerPending(MassiveElementTriggerType triggerType, MassiveEntityProxy proxy) {} // 0x00000001846828C0-0x00000001846829B0
	// [XID] // 0x0000000189A05A10-0x0000000189A05A30
	public void RemoveProxyTriggerTick(MassiveElementTriggerType triggerType, MassiveEntityProxy proxy) {} // 0x0000000184682F90-0x0000000184683080
	// [XID] // 0x0000000189A0CD00-0x0000000189A0CD20
	private void RemoveProxyTriggerInternal(MassiveElementTriggerType triggerType, MassiveTriggerStateIndex index, IndexHandleObjectList<MassiveEntityProxy>[] proxyArray) {} // 0x0000000184683710-0x0000000184683850
	// [XID] // 0x0000000189A14620-0x0000000189A14640
	public void PushProxyOnFlush(MassiveEntityProxy proxy) {} // 0x00000001846829B0-0x0000000184682A80
	// [XID] // 0x0000000189A1B8B0-0x0000000189A1B8D0
	public void ClearProxyOnFlush() {} // 0x0000000184683850-0x0000000184683900
	// [XID] // 0x0000000189A232A0-0x0000000189A232C0
	public void PushProxyOnPreUpdate(MassiveEntityProxy proxy) {} // 0x0000000184682D80-0x0000000184682E50
	// [XID] // 0x0000000189A2A4E0-0x0000000189A2A500
	public void ClearProxyOnPreUpdate() {} // 0x0000000184681900-0x00000001846819B0
	// [XID] // 0x0000000189A31970-0x0000000189A31990
	public void PushAbilityProxyOnFlushDetach(MassiveEntityAbilityProxy abilityProxy) {} // 0x0000000184681780-0x0000000184681850
	// [XID] // 0x0000000189A39470-0x0000000189A39490
	public void ClearAbilityProxyOnFlushDetach() {} // 0x0000000184681850-0x0000000184681900
	// [XID] // 0x0000000189A40C30-0x0000000189A40C50
	public void EqueueElementReactionEvent(MassiveElementReactionEvent evt) {} // 0x00000001846815D0-0x00000001846816A0
	// [XID] // 0x0000000189A482B0-0x0000000189A482D0
	public override void Init(ConfigAbilityTask taskConfig) {} // 0x00000001846820D0-0x00000001846823B0
	// [XID] // 0x0000000189A4FB80-0x0000000189A4FBA0
	private void InitEntityElementConfig() {} // 0x0000000184682610-0x0000000184682820
	// [XID] // 0x0000000189A570F0-0x0000000189A57110
	public override void Destroy() {} // 0x00000001846819B0-0x0000000184681D20
}

