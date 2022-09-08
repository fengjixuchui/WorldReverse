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
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class LCBaseEquipController : LCBase // TypeDefIndex: 11711
{
	// Fields
	public List<ulong> equipGuidBar; // 0x130
	protected Dictionary<ulong, EquipInSlotType> equipGuid2Slot; // 0x138
	protected BaseEntity _configRefEntity; // 0x140
	protected string _configRefJsonName; // 0x148
	protected List<PreloadJsonData> _preloadedJsonConfigs; // 0x150
	public Action<BaseEntity> equipLoadedFinishCallback; // 0x158
	private List<ulong> localEqupGuidList; // 0x160

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B94050-0x0000000189B94070 */ get => default; } // 0x0000000183CC0220-0x0000000183CC02C0 

	// Nested types
	protected struct PreloadJsonData // TypeDefIndex: 11712
	{
		// Fields
		public BaseEntity entity; // 0x00
		public string jsonName; // 0x08

		// Constructors
		public PreloadJsonData(BaseEntity entity, string jsonName) {
			this.entity = default;
			this.jsonName = default;
		} // 0x0000000183CD3B70-0x0000000183CD3C10
	}

	// Constructors
	public LCBaseEquipController() {} // 0x0000000183CC00D0-0x0000000183CC0220

	// Methods
	// [XID] // 0x0000000189B9B5F0-0x0000000189B9B610
	public override void OnEnable() {} // 0x0000000183CBFAE0-0x0000000183CBFDF0
	// [XID] // 0x0000000189BA2D50-0x0000000189BA2D70
	public override void OnDisable() {} // 0x0000000183CBF7D0-0x0000000183CBFAE0
	// [XID] // 0x000000018967CDD0-0x000000018967CDF0
	public override void Destroy() {} // 0x0000000183CBC390-0x0000000183CBC450
	// [XID] // 0x0000000189BB1980-0x0000000189BB19A0
	protected virtual void ClearEquips() {} // 0x0000000183CBC7A0-0x0000000183CBCA80
	// [XID] // 0x0000000189BB8960-0x0000000189BB8980
	protected BaseEntity ReUseEquip(WeaponDataItem equipDataItem) => default; // 0x0000000183CBE640-0x0000000183CBE9A0
	// [XID] // 0x00000001899B5B80-0x00000001899B5BA0
	protected static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000183CBCA80-0x0000000183CBCB50
	// [XID] // 0x0000000189BC7D60-0x0000000189BC7D80
	protected override bool OnEvent(BaseEvent e) => default; // 0x0000000183CBFDF0-0x0000000183CC00D0
	// [XID] // 0x0000000189BCF8D0-0x0000000189BCF8F0
	public virtual void AttachCurEquip() {} // 0x0000000183CBBC50-0x0000000183CBBD40
	// [XID] // 0x000000018973FC30-0x000000018973FC50
	public string GetPutPoint() => default; // 0x0000000183CBC260-0x0000000183CBC330
	// [XID] // 0x0000000189BDEA80-0x0000000189BDEAA0
	public string GetEquipAttachPoint(uint gadgetId) => default; // 0x0000000183CBE9A0-0x0000000183CBEB90
	// [XID] // 0x00000001895EB510-0x00000001895EB530
	public string GetSubEquipAttachPoint(uint gadgetId) => default; // 0x0000000183CBD6C0-0x0000000183CBD810
	// [XID] // 0x0000000189852C90-0x0000000189852CB0
	protected void OnAttachEvent(ulong guid) {} // 0x0000000183CBD190-0x0000000183CBD5D0
	// [XID] // 0x00000001895FA2C0-0x00000001895FA2E0
	public virtual bool AttachItem(ulong guid, string equipPart = null, bool showSub = true /* Metadata: 0x00AEA732 */) => default; // 0x0000000183CBC6C0-0x0000000183CBC7A0
	// [XID] // 0x0000000189601C70-0x0000000189601C90
	protected virtual bool AttachEntityItem(ulong guid, GadgetEntity equipEntity, string equipPart = null, GadgetEntity subEquipEntity = null, string subEquipPart = null) => default; // 0x0000000183CBC0A0-0x0000000183CBC260
	// [XID] // 0x00000001898923E0-0x0000000189892400
	public bool DetachItem(ulong guid, bool detachOnly = false /* Metadata: 0x00AEA733 */) => default; // 0x0000000183CBF160-0x0000000183CBF270
	// [XID] // 0x0000000189610C00-0x0000000189610C20
	public static void RemoveAndDisableEntity(BaseEntity entity) {} // 0x0000000183CBBB30-0x0000000183CBBC50
	// [XID] // 0x0000000189617EF0-0x0000000189617F10
	public void DetroyEquip(uint entityId, uint subEntityID) {} // 0x0000000183CBEF20-0x0000000183CBF070
	// [XID] // 0x00000001896C7210-0x00000001896C7230
	protected bool ChangeItem(ulong guid, string orgPart, string destPart, string subOrgPart, string subDestPart) => default; // 0x0000000183CBF680-0x0000000183CBF7D0
	// [XID] // 0x0000000189626E90-0x0000000189626EB0
	public bool AddEquipBar(ulong guid) => default; // 0x0000000183CBF270-0x0000000183CBF420
	// [XID] // 0x000000018988B050-0x000000018988B070
	public bool RemoveEquipBar(ulong guid) => default; // 0x0000000183CBD5D0-0x0000000183CBD6C0
	// [XID] // 0x00000001896364A0-0x00000001896364C0
	public List<ulong> GetAllEquipGuids() => default; // 0x0000000183CBF5D0-0x0000000183CBF680
	// [XID] // 0x0000000189935D00-0x0000000189935D20
	public WeaponDataItem GetPartEquipped(string equipPart) => default; // 0x0000000183CBE290-0x0000000183CBE640
	// [XID] // 0x00000001899E4120-0x00000001899E4140
	public EquipEntityType GetPartEquipEntityType(string equipPart) => default; // 0x0000000183CBCD90-0x0000000183CBCF30
	// [XID] // 0x000000018964CB40-0x000000018964CB60
	protected virtual bool AttachItemFromEquipBar(ulong guid) => default; // 0x0000000183CBF070-0x0000000183CBF160
	// [XID] // 0x0000000189653F70-0x0000000189653F90
	protected virtual bool DetachItemFromEquipBar(ulong guid) => default; // 0x0000000183CBBF20-0x0000000183CBC0A0
	// [XID] // 0x00000001899EB5D0-0x00000001899EB5F0
	protected void DropItem(uint runtimeID) {} // 0x0000000183CBE090-0x0000000183CBE290
	// [XID] // 0x0000000189662CF0-0x0000000189662D10
	protected void ThrowItem(uint runtimeID, uint targetRuntimeID, uint lockPointIndex, Quaternion rotation) {} // 0x0000000183CBD810-0x0000000183CBDBD0
	// [XID] // 0x000000018966A850-0x000000018966A870
	protected ulong CreateLocalEquip(uint itemID, uint gadgetID, string equipPart, uint entityID, AbilitySyncStateInfo abilitySyncInfo, BagItem bagItem = null) => default; // 0x0000000183CBEC80-0x0000000183CBEF20
	// [XID] // 0x0000000189672510-0x0000000189672530
	public virtual void PickUpItem(uint runtimeID) {} // 0x0000000183CBF420-0x0000000183CBF5D0
	// [XID] // 0x0000000189679D80-0x0000000189679DA0
	protected WeaponDataItem GetEquipDataItemByGUID(ulong guid) => default; // 0x0000000183CBC4B0-0x0000000183CBC5C0
	// [XID] // 0x0000000189681480-0x00000001896814A0
	protected void EquipLoadFinishCallback(BaseEntity entity) {} // 0x0000000183CBBD40-0x0000000183CBBF20
	// [XID] // 0x0000000189688F80-0x0000000189688FA0
	protected WeaponDataItem GetSlotOccupy(WeaponDataItem equipDataItem) => default; // 0x0000000183CBDBD0-0x0000000183CBE030
	// [XID] // 0x0000000189690AA0-0x0000000189690AC0
	protected void SwitchSoltItemInBar(WeaponDataItem orgEquipDataItem, WeaponDataItem newEquipDataItem, EquipInSlotType isInSlotType) {} // 0x0000000183CBCC30-0x0000000183CBCD90
	// [XID] // 0x0000000189B2A600-0x0000000189B2A620
	protected virtual GadgetEntity CreateEquip(uint entityId, ulong guid, uint itemId, uint ownerRuntimeID, uint campID, TargetType campType, bool anyncLoad = true /* Metadata: 0x00AEA734 */, Action<BaseEntity> loadFinishCallback = null) => default; // 0x0000000183CBD070-0x0000000183CBD190
	// [XID] // 0x000000018969F600-0x000000018969F620
	protected bool IsJsonConfigLoaded() => default; // 0x0000000183CBC5C0-0x0000000183CBC6C0
	// [XID] // 0x0000000189738060-0x0000000189738080
	protected void RegisterPreloadJsonConfig(BaseEntity entity, string jsonName) {} // 0x0000000183CBCB50-0x0000000183CBCC30
	// [XID] // 0x00000001898B01F0-0x00000001898B0210
	protected void ReleaseJsonConfig() {} // 0x0000000183CBCF30-0x0000000183CBD070
}

