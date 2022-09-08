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
using UnityEngine;
using UnityEngine.Scripting;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class ComponentManager // TypeDefIndex: 12177
	{
		// Fields
		private BaseComponent[] _componentCache; // 0x10
		public uint entityRuntimeID; // 0x18
		private BaseEntity _owner; // 0x20
		private static List<BaseComponent> DEFAULT_EMPTY_COMPONENT_LIST; // 0x00
		[InspectorCollapsedFoldout] // 0x0000000189BA6080-0x0000000189BA60B0
		[InspectorCollectionShowItemDropdown] // 0x0000000189BA6080-0x0000000189BA60B0
		private List<BaseComponent> _components; // 0x28
		[InspectorCollapsedFoldout] // 0x000000018976B560-0x000000018976B5A0
		[InspectorCollectionShowItemDropdown] // 0x000000018976B560-0x000000018976B5A0
		[ShowInInspector] // 0x000000018976B560-0x000000018976B5A0
		private List<BaseComponent> _componentsToBeAdded; // 0x30
		private List<BaseComponent> _componentsToBeEnabled; // 0x38
		private List<BaseComponent> _tickComponents; // 0x40
		private List<BaseComponent> _lateTickComponents; // 0x48
		private Dictionary<uint, int> _disableNoTickComponents; // 0x50
		private Dictionary<uint, int> _disableNoLateTickComponents; // 0x58
		private List<KeyValuePair<uint, int>> _refreshDicPairTempList; // 0x60
		private Dictionary<int, BaseComponent> _onEventComponentMap; // 0x68
		private Dictionary<int, List<BaseComponent>> _onEventComponentsMap; // 0x70
		private Dictionary<int, BaseComponent> _onEventResolveComponentMap; // 0x78
		private Dictionary<int, List<BaseComponent>> _onEventResolveComponentsMap; // 0x80
		private Dictionary<int, BaseComponent> _listenEventComponentMap; // 0x88
		private Dictionary<int, List<BaseComponent>> _listenEventComponentsMap; // 0x90
		private int _initedComponentIndexBeforeEntityReady; // 0x98
		private bool _isDestroied; // 0x9C
		private bool _hasComponentsRemoved; // 0x9D
	
		// Properties
		public int ComponentsCountIncludeToBeAdded { /* [XID] */ /* 0x000000018974B750-0x000000018974B770 */ get => default; } // 0x0000000181AEA330-0x0000000181AEA4C0 
	
		// Nested types
		public enum HandleEventActionType // TypeDefIndex: 12178
		{
			None = 0,
			OnEventAction = 1,
			OnEventResolvedAction = 2,
			ListenEventAction = 3
		}
	
		// Constructors
		public ComponentManager() {} // Dummy constructor
		public ComponentManager(BaseEntity owner) {} // 0x0000000181AEA250-0x0000000181AEA330
		static ComponentManager() {} // 0x0000000181AEA1C0-0x0000000181AEA250
	
		// Methods
		// [XID] // 0x000000018976C4B0-0x000000018976C4D0
		public virtual void InitCache(int count) {} // 0x0000000181AE43F0-0x0000000181AE44D0
		// [XID] // 0x0000000189727800-0x0000000189727820
		private void ClearCache() {} // 0x0000000181ADF560-0x0000000181ADF650
		// [XID] // 0x0000000189764A50-0x0000000189764A70
		public void AddComponentToCache(BaseComponent component) {} // 0x0000000181ADF190-0x0000000181ADF320
		// [IDTag] // 0x00000001897363E0-0x0000000189736430
		[Preserve] // 0x00000001897363E0-0x0000000189736430
		// [XID] // 0x00000001897363E0-0x0000000189736430
		public BaseComponent GetComponent(int componentCacheType) => default; // 0x0000000181AE2B40-0x0000000181AE2C20
		// [XID] // 0x0000000189743C00-0x0000000189743C20
		public void RemoveComponentCache(int componentCacheType) {} // 0x0000000181AE7960-0x0000000181AE7A40
		// [XID] // 0x0000000189752B90-0x0000000189752BB0
		public void Retarget(uint newEntityRuntimeID) {} // 0x0000000181AE8760-0x0000000181AE8880
		// [XID] // 0x0000000189811E50-0x0000000189811E70
		public void RefreshComponentsEntityRuntimeId(uint entityId) {} // 0x0000000181AE6F90-0x0000000181AE7090
		// [XID] // 0x000000018994AD10-0x000000018994AD30
		public void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000181ADF650-0x0000000181ADF820
		// [XID] // 0x00000001895F9020-0x00000001895F9040
		public void ReInit(BaseEntity.ReInitReason reason, bool runtimeIDChange) {} // 0x0000000181AE5000-0x0000000181AE53D0
		// [XID] // 0x0000000189616A50-0x0000000189616A70
		public virtual void PostReInit() {} // 0x0000000181AE4CA0-0x0000000181AE5000
		// [XID] // 0x0000000189777ED0-0x0000000189777EF0
		public void OnEntityReady() {} // 0x0000000181AE4A50-0x0000000181AE4CA0
		// [XID] // 0x000000018977F460-0x000000018977F480
		public void InitComponents(SliceFrameWatch sliceFrameWatch = null) {} // 0x0000000181AE44D0-0x0000000181AE48B0
		// [XID] // 0x0000000189786E20-0x0000000189786E40
		public bool HasInitedAllComponentsBeforeEntityReady() => default; // 0x0000000181AE4310-0x0000000181AE43F0
		// [XID] // 0x000000018978E460-0x000000018978E480
		public void EnableAllComponentsWaitToBeEnabled() {} // 0x0000000181AE15F0-0x0000000181AE1780
		// [XID] // 0x0000000189795BA0-0x0000000189795BC0
		public void TickComponents(EntityManager.TickType tickType, float inEntityBalanceTickTime, float inGameTickTime) {} // 0x0000000181AE91B0-0x0000000181AE95D0
		public void EnableComponent<T>(bool enabled) {}
		// [IDTag] // 0x000000018979DE90-0x000000018979DED0
		// [XID] // 0x000000018979DE90-0x000000018979DED0
		public void EnableComponent(uint componentRuntimeID, bool enabled) {} // 0x0000000181AE1900-0x0000000181AE1A80
		// [IDTag] // 0x00000001897A8060-0x00000001897A80A0
		// [XID] // 0x00000001897A8060-0x00000001897A80A0
		public void EnableComponent(string typeName, bool enabled) {} // 0x0000000181AE1A80-0x0000000181AE2140
		// [XID] // 0x0000000189A4F210-0x0000000189A4F230
		public void EnableAllComponents(bool enabled) {} // 0x0000000181AE1780-0x0000000181AE1900
		public void EnableComponents<T>(bool enabled) {}
		// [XID] // 0x00000001897BA490-0x00000001897BA4B0
		public void EnableComponents(string typeName, bool enabled) {} // 0x0000000181AE2140-0x0000000181AE23D0
		// [IDTag] // 0x00000001897C23B0-0x00000001897C2400
		[Preserve] // 0x00000001897C23B0-0x00000001897C2400
		// [XID] // 0x00000001897C23B0-0x00000001897C2400
		public BaseComponent GetComponent(uint componentRuntimeID) => default; // 0x0000000181AE2C20-0x0000000181AE2D90
		// [IDTag] // 0x00000001897CFD30-0x00000001897CFD80
		[Preserve] // 0x00000001897CFD30-0x00000001897CFD80
		// [XID] // 0x00000001897CFD30-0x00000001897CFD80
		public BaseComponent GetComponent(System.Type type) => default; // 0x0000000181AE2ED0-0x0000000181AE3160
		[Preserve] // 0x0000000189B94090-0x0000000189B940A0
		public T GetComponent<T>()
			where T : BaseComponent => default;
		// [IDTag] // 0x00000001897E4C80-0x00000001897E4CD0
		[Preserve] // 0x00000001897E4C80-0x00000001897E4CD0
		// [XID] // 0x00000001897E4C80-0x00000001897E4CD0
		public BaseComponent GetComponent(string typeName) => default; // 0x0000000181AE2D90-0x0000000181AE2ED0
		[Preserve] // 0x00000001897F2A90-0x00000001897F2AD0
		// [XID] // 0x00000001897F2A90-0x00000001897F2AD0
		public BaseComponent GetComponentFast(string typeName) => default; // 0x0000000181AE27E0-0x0000000181AE2A30
		// [IDTag] // 0x00000001897FCF80-0x00000001897FCFC0
		// [XID] // 0x00000001897FCF80-0x00000001897FCFC0
		public List<BaseComponent> GetComponents(System.Type type) => default; // 0x0000000181AE34E0-0x0000000181AE3750
		[Preserve] // 0x0000000189807700-0x0000000189807740
		// [XID] // 0x0000000189807700-0x0000000189807740
		public List<BaseComponent> GetComponentsFast(string typeName) => default; // 0x0000000181AE3160-0x0000000181AE3400
		// [IDTag] // 0x0000000189811C80-0x0000000189811CC0
		// [XID] // 0x0000000189811C80-0x0000000189811CC0
		public List<BaseComponent> GetComponents(string typeName) => default; // 0x0000000181AE3750-0x0000000181AE3890
		public List<T> GetComponents<T>()
			where T : BaseComponent => default;
		// [XID] // 0x000000018981C5E0-0x000000018981C600
		public List<BaseComponent> GetAllComponents(bool includeToBeAdded = false /* Metadata: 0x00AEB71D */) => default; // 0x0000000181AE2680-0x0000000181AE27E0
		// [XID] // 0x0000000189B1E6C0-0x0000000189B1E6E0
		public virtual bool Destroy(SliceFrameWatch watch) => default; // 0x0000000181ADF820-0x0000000181ADFF00
		// [XID] // 0x000000018982B490-0x000000018982B4B0
		public void AddComponent(BaseComponent component) {} // 0x0000000181ADF320-0x0000000181ADF480
		// [XID] // 0x000000018974E940-0x000000018974E960
		public bool AddAllAddableComponents() => default; // 0x0000000181ADEDA0-0x0000000181ADEF40
		// [XID] // 0x0000000189839EF0-0x0000000189839F10
		public List<BaseComponent> GetComponentsToBeAdded() => default; // 0x0000000181AE3400-0x0000000181AE34E0
		// [XID] // 0x0000000189841420-0x0000000189841440
		private bool CheckDoComponentRemoved(BaseComponent component) => default; // 0x0000000181ADF480-0x0000000181ADF560
		// [XID] // 0x00000001898488E0-0x0000000189848900
		private bool AddComponentInternal(BaseComponent component) => default; // 0x0000000181ADEF40-0x0000000181ADF000
		// [XID] // 0x0000000189850180-0x00000001898501A0
		private void DoComponentPreInit(BaseComponent component) {} // 0x0000000181ADFF00-0x0000000181AE0070
		// [XID] // 0x0000000189857400-0x0000000189857420
		private void AddComponentKeepOrder(BaseComponent component) {} // 0x0000000181ADF000-0x0000000181ADF190
		// [XID] // 0x000000018985E620-0x000000018985E640
		public void SetHasComponentsRemoved() {} // 0x0000000181AE8F00-0x0000000181AE8FA0
		public void RemoveComponent<T>()
			where T : BaseComponent {}
		// [IDTag] // 0x0000000189865E90-0x0000000189865ED0
		// [XID] // 0x0000000189865E90-0x0000000189865ED0
		public void RemoveComponent(uint componentRuntimeID) {} // 0x0000000181AE8600-0x0000000181AE86B0
		// [IDTag] // 0x0000000189870430-0x0000000189870470
		// [XID] // 0x0000000189870430-0x0000000189870470
		public void RemoveComponent(string typeName) {} // 0x0000000181AE8550-0x0000000181AE8600
		// [XID] // 0x0000000189ABB850-0x0000000189ABB870
		public void RemoveComponentImmediately(BaseComponent component) {} // 0x0000000181AE8310-0x0000000181AE8550
		public void RemoveComponents<T>()
			where T : BaseComponent {}
		// [XID] // 0x0000000189882040-0x0000000189882060
		public void RemoveComponents(string typeName) {} // 0x0000000181AE86B0-0x0000000181AE8760
		// [XID] // 0x0000000189889770-0x0000000189889790
		public void RemoveAllRemoveableComponents() {} // 0x0000000181AE74F0-0x0000000181AE7730
		// [XID] // 0x0000000189890B20-0x0000000189890B40
		public bool RemoveAllComponents(SliceFrameWatch watch) => default; // 0x0000000181AE7090-0x0000000181AE74F0
		// [IDTag] // 0x0000000189898140-0x0000000189898180
		// [XID] // 0x0000000189898140-0x0000000189898180
		private void SetComponentToBeRemoved(uint componentRuntimeID) {} // 0x0000000181AE8880-0x0000000181AE8A20
		private void SetComponentToBeRemoved<T>() {}
		// [IDTag] // 0x00000001898A26F0-0x00000001898A2730
		// [XID] // 0x00000001898A26F0-0x00000001898A2730
		private void SetComponentToBeRemoved(string typeName) {} // 0x0000000181AE8A20-0x0000000181AE8C90
		private void SetComponentsToBeRemoved<T>()
			where T : BaseComponent {}
		// [XID] // 0x00000001898ACDC0-0x00000001898ACDE0
		private void SetComponentsToBeRemoved(string typeName) {} // 0x0000000181AE8C90-0x0000000181AE8F00
		// [XID] // 0x00000001898B4310-0x00000001898B4330
		public void RefreshComponentActions(BaseComponent component) {} // 0x0000000181AE53D0-0x0000000181AE58C0
		// [XID] // 0x00000001898BC150-0x00000001898BC170
		private void RemoveComponentFromListAndIndexDic(BaseComponent component, List<BaseComponent> list, Dictionary<uint, int> indexDic) {} // 0x0000000181AE7A40-0x0000000181AE8310
		// [XID] // 0x00000001898C34F0-0x00000001898C3510
		private void TryToAddEventComponent(BaseComponent component, BaseComponent.HandleEventType handleEventType) {} // 0x0000000181AE95D0-0x0000000181AE9CD0
		// [XID] // 0x00000001898CAE30-0x00000001898CAE50
		private void TryToRemoveEventComponent(BaseComponent component, BaseComponent.HandleEventType handleEventType) {} // 0x0000000181AE9EA0-0x0000000181AEA0F0
		// [XID] // 0x00000001897589F0-0x0000000189758A10
		private void TryToRemoveComponentFromEventComponentsMap(int eventID, BaseComponent component, BaseComponent.HandleEventType handleEventType) {} // 0x0000000181AE9CD0-0x0000000181AE9EA0
		// [XID] // 0x0000000189BCE4C0-0x0000000189BCE4E0
		public void RefreshComponentTicksOnSetEnabled(BaseComponent component) {} // 0x0000000181AE58C0-0x0000000181AE6410
		// [XID] // 0x00000001899EE8C0-0x00000001899EE8E0
		public void RefreshComponentTicksOnSetPluginEnabled(BaseComponent component, bool pluginEnabled, bool pluginHasTick, bool pluginHasLateTick) {} // 0x0000000181AE6410-0x0000000181AE6F90
		// [XID] // 0x00000001898E9750-0x00000001898E9770
		public bool HasAnyTickComponent() => default; // 0x0000000181AE41F0-0x0000000181AE4310
		// [XID] // 0x0000000189B92820-0x0000000189B92840
		public bool HasAnyLateTickComponent() => default; // 0x0000000181AE40D0-0x0000000181AE41F0
		// [XID] // 0x00000001898F8680-0x00000001898F86A0
		private int GetComponentIndex(IList<BaseComponent> components, BaseComponent component) => default; // 0x0000000181AE2A30-0x0000000181AE2B40
		// [XID] // 0x00000001898FFE80-0x00000001898FFEA0
		public void RemoveComponentActions(BaseComponent component, bool refreshComponentTickable = true /* Metadata: 0x00AEB71E */) {} // 0x0000000181AE7730-0x0000000181AE7960
		// [XID] // 0x0000000189BCCCE0-0x0000000189BCCD00
		public bool ShiftWorld(Vector3 newShift, Vector3 oldShift) => default; // 0x0000000181AE8FA0-0x0000000181AE91B0
		// [XID] // 0x000000018990EF30-0x000000018990EF50
		public BaseEntity GetOwner() => default; // 0x0000000181AE3890-0x0000000181AE3930
		// [XID] // 0x0000000189916800-0x0000000189916820
		public bool IsValid() => default; // 0x0000000181AE4990-0x0000000181AE4A50
		// [XID] // 0x000000018991DFB0-0x000000018991DFD0
		public bool HandleEvent(BaseEvent e) => default; // 0x0000000181AE3DA0-0x0000000181AE3F30
		// [XID] // 0x00000001899258A0-0x00000001899258C0
		public bool HandleEventResolved(BaseEvent e) => default; // 0x0000000181AE3C10-0x0000000181AE3DA0
		// [XID] // 0x000000018992CD50-0x000000018992CD70
		public bool HandleListenEvent(BaseEvent e) => default; // 0x0000000181AE3F30-0x0000000181AE40D0
		// [XID] // 0x0000000189934240-0x0000000189934260
		private bool HandleComponentEvent(BaseComponent component, BaseEvent e, HandleEventActionType handleEventActionType) => default; // 0x0000000181AE3930-0x0000000181AE3AC0
		// [XID] // 0x000000018993BF50-0x000000018993BF70
		private bool HandleComponentsEvent(IList<BaseComponent> components, BaseEvent e, HandleEventActionType handleEventActionType) => default; // 0x0000000181AE3AC0-0x0000000181AE3C10
		[Preserve] // 0x00000001899432D0-0x0000000189943310
		// [XID] // 0x00000001899432D0-0x0000000189943310
		public string Dump() => default; // 0x0000000181AE0070-0x0000000181AE15F0
		// [XID] // 0x000000018994DA80-0x000000018994DAA0
		private void InternalUpdateComponentsBalancedTickInfo(List<BaseComponent> components) {} // 0x0000000181AE48B0-0x0000000181AE4990
		// [XID] // 0x00000001899550C0-0x00000001899550E0
		public void UpdateComponentsBalancedTickInfoComputeThread() {} // 0x0000000181AEA0F0-0x0000000181AEA1C0
		// [XID] // 0x0000000189A49170-0x0000000189A49190
		public void GenerateThisFrameTickStatLog(CycleStatLogNode entityCSLNode) {} // 0x0000000181AE23D0-0x0000000181AE2590
		// [XID] // 0x00000001899641F0-0x0000000189964210
		public string GenerateTickStatLog(ref double totalTickMilliseconds, ref double tickMilliseconds, ref double lateTickMilliseconds, ref double fixedTickMilliseconds) => default; // 0x0000000181AE2590-0x0000000181AE2680
	}
}
