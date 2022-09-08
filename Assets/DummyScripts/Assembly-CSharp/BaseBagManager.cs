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

public class BaseBagManager : GlobalManager // TypeDefIndex: 20653
{
	// Fields
	protected Dictionary<ulong, BagItemSlot> _guid2ItemSlotDic; // 0x10
	protected Dictionary<uint, Dictionary<ulong, BagItemSlot>> _itemID2ItemSlotDic; // 0x18
	protected Dictionary<int, List<BagItemSlot>> _itemType2slotListDic; // 0x20
	protected Dictionary<int, List<BagItemSlot>> _itemTypeSlotDic; // 0x28
	protected Dictionary<int, Dictionary<int, BagItemSlot>> _itemType2ItemSlotRealIndexDic; // 0x30
	protected Dictionary<int, Dictionary<int, bool>> _itemType2ItemSlotDirtyDic; // 0x38
	protected Dictionary<uint, ulong> _cdGroup2cdDic; // 0x40
	private HashSet<ulong> _newSlots; // 0x48
	private Dictionary<ItemType, Dictionary<uint, int>> _currentCounts; // 0x50
	private Dictionary<ItemType, uint> _cellLimits; // 0x58

	// Properties
	public virtual StoreType storeType { /* [XID] */ /* 0x0000000189ADBE60-0x0000000189ADBE80 */ get => default; } // 0x0000000181BDB470-0x0000000181BDB510 

	// Constructors
	public BaseBagManager() {} // 0x0000000181BDD550-0x0000000181BDD710

	// Methods
	// [IDTag] // 0x0000000189AB2C80-0x0000000189AB2CC0
	// [XID] // 0x0000000189AB2C80-0x0000000189AB2CC0
	public override void Init() {} // 0x0000000181BDAA10-0x0000000181BDAAB0
	// [XID] // 0x0000000189ABD7D0-0x0000000189ABD7F0
	public override void ReloadRes() {} // 0x0000000181BDD4B0-0x0000000181BDD550
	// [XID] // 0x0000000189AC5270-0x0000000189AC5290
	public override void Destroy() {} // 0x0000000181BD8D60-0x0000000181BD8E00
	// [XID] // 0x0000000189ACC740-0x0000000189ACC760
	public override void ClearOnLevelDestroy() {} // 0x0000000181BD8460-0x0000000181BD8500
	// [XID] // 0x0000000189AD4430-0x0000000189AD4450
	public override void ClearOnBackHome(bool forceClear = true /* Metadata: 0x00AFDF76 */) {} // 0x0000000181BD8370-0x0000000181BD8460
	// [XID] // 0x0000000189B8E240-0x0000000189B8E260
	protected virtual void RefreshCurrWeight(ItemConfig config, int deltaNum) {} // 0x0000000181BDAAB0-0x0000000181BDACF0
	// [XID] // 0x0000000189AEB0D0-0x0000000189AEB0F0
	public void RefreshWeightView() {} // 0x0000000181BD9940-0x0000000181BD9A60
	// [XID] // 0x0000000189AF2980-0x0000000189AF29A0
	public bool TryGetItemCellCountAndLimit(ItemType itemType, out int cellCount, out uint countLimit) {
		cellCount = default;
		countLimit = default;
		return default;
	} // 0x0000000181BDACF0-0x0000000181BDAF40
	// [XID] // 0x0000000189AFA2A0-0x0000000189AFA2C0
	public virtual void RefreshAll(PlayerStoreNotify notify) {} // 0x0000000181BDD0F0-0x0000000181BDD350
	// [XID] // 0x0000000189B01840-0x0000000189B01860
	public void OnItemChangeNotify(StoreItemChangeNotify notify) {} // 0x0000000181BD8E00-0x0000000181BD9010
	// [XID] // 0x0000000189B08D70-0x0000000189B08D90
	public void OnItemDelNotify(StoreItemDelNotify notify) {} // 0x0000000181BDBB20-0x0000000181BDBD20
	// [XID] // 0x0000000189B10870-0x0000000189B10890
	public void RefreshWeightLimit(StoreWeightLimitNotify notify) {} // 0x0000000181BD9BD0-0x0000000181BD9D00
	// [XID] // 0x0000000189B17920-0x0000000189B17940
	private void UpdateItemCountLimit(ItemType itemType, uint limit) {} // 0x0000000181BD97A0-0x0000000181BD9880
	// [IDTag] // 0x0000000189B1F2A0-0x0000000189B1F2E0
	// [XID] // 0x0000000189B1F2A0-0x0000000189B1F2E0
	public void Init(PlayerStoreNotify notify) {} // 0x0000000181BD9A60-0x0000000181BD9BD0
	// [IDTag] // 0x0000000189B296C0-0x0000000189B29700
	// [XID] // 0x0000000189B296C0-0x0000000189B29700
	public bool IsNew(BagItemSlot slot) => default; // 0x0000000181BDCE00-0x0000000181BDCF10
	// [IDTag] // 0x0000000189B33BA0-0x0000000189B33BE0
	// [XID] // 0x0000000189B33BA0-0x0000000189B33BE0
	public bool IsNew(ulong guid) => default; // 0x0000000181BDCF10-0x0000000181BDCFE0
	// [XID] // 0x0000000189B3E2D0-0x0000000189B3E2F0
	public void AddNewItem(ulong guid) {} // 0x0000000181BD9880-0x0000000181BD9940
	// [IDTag] // 0x0000000189B45F80-0x0000000189B45FC0
	// [XID] // 0x0000000189B45F80-0x0000000189B45FC0
	public void Touch(BagItemSlot slot) {} // 0x0000000181BDBD20-0x0000000181BDBE20
	// [IDTag] // 0x0000000189B504E0-0x0000000189B50520
	// [XID] // 0x0000000189B504E0-0x0000000189B50520
	public void Touch(ulong guid) {} // 0x0000000181BDBE20-0x0000000181BDBF10
	// [IDTag] // 0x0000000189B5AD50-0x0000000189B5AD90
	// [XID] // 0x0000000189B5AD50-0x0000000189B5AD90
	public List<BagItemSlot> GetSlotListByType(ItemType itemType) => default; // 0x0000000181BD9D00-0x0000000181BD9E30
	// [XID] // 0x0000000189B65380-0x0000000189B653A0
	public List<BagItemSlot> GetItemTypeSlotList(ItemType itemType) => default; // 0x0000000181BD7EA0-0x0000000181BD7FF0
	// [XID] // 0x0000000189B6C9E0-0x0000000189B6CA00
	public List<BagItemSlot> GetFoodRecipeItemList() => default; // 0x0000000181BD7FF0-0x0000000181BD8280
	// [XID] // 0x0000000189B74140-0x0000000189B74160
	public List<BagItemSlot> GetFurnitureShowList() => default; // 0x0000000181BD94D0-0x0000000181BD97A0
	// [IDTag] // 0x0000000189B7B6D0-0x0000000189B7B710
	// [XID] // 0x0000000189B7B6D0-0x0000000189B7B710
	public List<BagItemSlot> GetSlotListByType(ItemType itemType, int startIndex, int num) => default; // 0x0000000181BD9E30-0x0000000181BD9FB0
	// [XID] // 0x0000000189B7F4A0-0x0000000189B7F4C0
	public int GetCurrTypeIndex(ItemType itemType) => default; // 0x0000000181BDC410-0x0000000181BDC4E0
	// [XID] // 0x0000000189AF4F00-0x0000000189AF4F20
	protected Dictionary<int, bool> GetSlotDirtyByType(ItemType itemType) => default; // 0x0000000181BDA710-0x0000000181BDA840
	// [XID] // 0x0000000189AE5F80-0x0000000189AE5FA0
	protected void SetItemSlotDirty(ItemType itemType, int typeIndex) {} // 0x0000000181BDC7E0-0x0000000181BDC8F0
	// [XID] // 0x0000000189B9C040-0x0000000189B9C060
	public BagItemSlot GetItemSlotByGuid(ulong guid) => default; // 0x0000000181BDBA30-0x0000000181BDBB20
	// [XID] // 0x0000000189BA37D0-0x0000000189BA37F0
	public BagItem GetItemByGuid(ulong guid) => default; // 0x0000000181BDCAE0-0x0000000181BDCBE0
	// [XID] // 0x000000018993C1F0-0x000000018993C210
	public uint GetItemNumByItemIDEX(uint itemID) => default; // 0x0000000181BDAF40-0x0000000181BDB220
	// [XID] // 0x0000000189BB2110-0x0000000189BB2130
	public uint GetItemNumByItemID(uint itemID) => default; // 0x0000000181BDBF10-0x0000000181BDC130
	// [XID] // 0x0000000189BB9500-0x0000000189BB9520
	public bool HasItem(uint itemID) => default; // 0x0000000181BDA470-0x0000000181BDA580
	// [XID] // 0x0000000189BC1340-0x0000000189BC1360
	public bool HasWeapon() => default; // 0x0000000181BDA840-0x0000000181BDA900
	// [XID] // 0x0000000189BC8BC0-0x0000000189BC8BE0
	public bool HasReliquary() => default; // 0x0000000181BDC8F0-0x0000000181BDC9B0
	// [XID] // 0x0000000189BD0370-0x0000000189BD0390
	public int GetItemSlotCount() => default; // 0x0000000181BDC350-0x0000000181BDC410
	// [XID] // 0x0000000189BD7930-0x0000000189BD7950
	protected Dictionary<int, BagItemSlot> GetItemSlotRealIndexDic(ItemType itemType) => default; // 0x0000000181BDC9B0-0x0000000181BDCAE0
	// [XID] // 0x0000000189BDF480-0x0000000189BDF4A0
	public bool HasItemSlotByRealIndex(ItemType itemType, int realIndex) => default; // 0x0000000181BDB220-0x0000000181BDB340
	// [XID] // 0x00000001895EC030-0x00000001895EC050
	public BagItemSlot GetItemSlotByRealIndex(ItemType itemType, int realIndex) => default; // 0x0000000181BD7250-0x0000000181BD7360
	// [XID] // 0x00000001895F3450-0x00000001895F3470
	public bool HasItemSlotByTypeIndex(ItemType itemType, int typeIndex) => default; // 0x0000000181BDA900-0x0000000181BDAA10
	// [XID] // 0x00000001895FAD90-0x00000001895FADB0
	public BagItemSlot GetItemSlotByTypeIndex(ItemType itemType, int typeIndex) => default; // 0x0000000181BD7140-0x0000000181BD7250
	// [XID] // 0x0000000189602660-0x0000000189602680
	public void FlushItemDirty() {} // 0x0000000181BD9FB0-0x0000000181BDA120
	// [IDTag] // 0x0000000189609F30-0x0000000189609F70
	// [XID] // 0x0000000189609F30-0x0000000189609F70
	protected void RefreshItem(ItemParam itemParam) {} // 0x0000000181BD8500-0x0000000181BD87B0
	// [IDTag] // 0x00000001896142F0-0x0000000189614330
	// [XID] // 0x00000001896142F0-0x0000000189614330
	public void RefreshItem(Item item, bool init) {} // 0x0000000181BD87B0-0x0000000181BD8B80
	// [XID] // 0x000000018961EF00-0x000000018961EF20
	private void DeleteItem(ulong guid) {} // 0x0000000181BD9010-0x0000000181BD91D0
	// [XID] // 0x0000000189AB0AD0-0x0000000189AB0AF0
	protected virtual void AddItemSlotInternal(BagItemSlot itemSlot) {} // 0x0000000181BD8280-0x0000000181BD8370
	// [XID] // 0x000000018962DC70-0x000000018962DC90
	protected void AddItemSlotByGuid(BagItemSlot itemSlot) {} // 0x0000000181BDA580-0x0000000181BDA710
	// [XID] // 0x0000000189AB81A0-0x0000000189AB81C0
	protected void AddItemSlotByItemID(BagItemSlot itemSlot) {} // 0x0000000181BDA210-0x0000000181BDA470
	// [XID] // 0x000000018963CF10-0x000000018963CF30
	public Dictionary<ulong, BagItemSlot> GetItemSlotByItemID(uint itemID) => default; // 0x0000000181BDC130-0x0000000181BDC220
	// [XID] // 0x0000000189644530-0x0000000189644550
	public BagItemSlot GetFirstItemSlotByItemID(uint itemID) => default; // 0x0000000181BD8B80-0x0000000181BD8D60
	// [XID] // 0x000000018964BD50-0x000000018964BD70
	protected void AddItemSlotByTypeIndex(BagItemSlot itemSlot) {} // 0x0000000181BDD350-0x0000000181BDD4B0
	// [XID] // 0x00000001896533E0-0x0000000189653400
	protected void AddItemTypeSlot(BagItemSlot itemSlot) {} // 0x0000000181BDC220-0x0000000181BDC350
	// [XID] // 0x0000000189A30FC0-0x0000000189A30FE0
	protected virtual void RemoveItemSlotInternal(BagItemSlot itemSlot) {} // 0x0000000181BDA120-0x0000000181BDA210
	// [XID] // 0x0000000189A47930-0x0000000189A47950
	protected void RemoveItemSlotByGuid(BagItemSlot itemSlot) {} // 0x0000000181BDC5E0-0x0000000181BDC730
	// [XID] // 0x0000000189669CA0-0x0000000189669CC0
	protected void RemoveItemSlotByItemID(BagItemSlot itemSlot) {} // 0x0000000181BDCBE0-0x0000000181BDCE00
	// [XID] // 0x00000001896718A0-0x00000001896718C0
	protected void RemoveItemSlotByTypeIndex(BagItemSlot itemSlot) {} // 0x0000000181BD7D40-0x0000000181BD7EA0
	// [XID] // 0x0000000189A65B80-0x0000000189A65BA0
	protected void RemoveItemSlotByItemType(BagItemSlot itemSlot) {} // 0x0000000181BDCFE0-0x0000000181BDD0F0
	// [XID] // 0x00000001896807D0-0x00000001896807F0
	public bool UseItem(ItemType itemType, int index, uint num, ulong targetGuid = 0 /* Metadata: 0x00AFDF77 */, uint optionIndex = 0 /* Metadata: 0x00AFDF7F */, bool IsEnterMpDungeonTeam = false /* Metadata: 0x00AFDF83 */) => default; // 0x0000000181BD91D0-0x0000000181BD94D0
	// [XID] // 0x00000001896883A0-0x00000001896883C0
	public void UpdateCDFinishTime(uint cdGroup, ulong cdTime) {} // 0x0000000181BDB340-0x0000000181BDB470
	// [XID] // 0x000000018968FBE0-0x000000018968FC00
	public ulong GetCDFinishTime(uint cdGroup) => default; // 0x0000000181BDC4E0-0x0000000181BDC5E0
	// [XID] // 0x00000001896975E0-0x0000000189697600
	public void OnUseItem(ulong guid, uint itemId, ulong targetGuid) {} // 0x0000000181BD7360-0x0000000181BD7D40
	// [XID] // 0x000000018969EB10-0x000000018969EB30
	public bool DropItem(ItemType itemType, int index, uint num) => default; // 0x0000000181BDB590-0x0000000181BDBA30
	// [XID] // 0x00000001896A5C80-0x00000001896A5CA0
	public void OnDropItem(ulong guid) {} // 0x0000000181BDC730-0x0000000181BDC7E0
}

