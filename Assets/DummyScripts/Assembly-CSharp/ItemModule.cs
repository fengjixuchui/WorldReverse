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

public sealed class ItemModule : BaseModule // TypeDefIndex: 21538
{
	// Fields
	public const uint WIND_CRYSTAL_ID = 107001; // Metadata: 0x00AFF907
	private List<SimpleItemStruct> _itemAdded; // 0x10
	private Dictionary<uint, ForgeQueueData> _queueDataDic; // 0x18
	private Dictionary<uint, GivingRecord> _givingRecordList; // 0x20

	// Constructors
	public ItemModule() {} // 0x0000000183B36160-0x0000000183B36250

	// Methods
	// [XID] // 0x00000001899F5F40-0x00000001899F5F60
	public BaseBagManager GetBagManagerByStoreType(StoreType storeType) => default; // 0x0000000183B336E0-0x0000000183B33830
	// [XID] // 0x0000000189733E50-0x0000000189733E70
	public override bool OnPacket(Packet packet) => default; // 0x0000000183B2F2E0-0x0000000183B2F940
	// [XID] // 0x000000018973B5D0-0x000000018973B5F0
	private void OnCalcWeaponUpgradeReturnItemsRsp(CalcWeaponUpgradeReturnItemsRsp calcWeaponUpgradeReturnItemsRsp) {} // 0x0000000183B34E10-0x0000000183B35010
	// [XID] // 0x0000000189743080-0x00000001897430A0
	private void OnChangeEquipLockStateRsp(SetEquipLockStateRsp changeEquipLockStateRsp) {} // 0x0000000183B30190-0x0000000183B30390
	// [XID] // 0x000000018974ABE0-0x000000018974AC00
	private void OnPlayerStoreNotify(PlayerStoreNotify notify) {} // 0x0000000183B30640-0x0000000183B30730
	// [XID] // 0x0000000189751C70-0x0000000189751C90
	private void OnStoreWeightLimitNotify(StoreWeightLimitNotify notify) {} // 0x0000000183B35420-0x0000000183B35500
	// [XID] // 0x0000000189A04D40-0x0000000189A04D60
	private void OnStoreItemChangeNotify(StoreItemChangeNotify notify) {} // 0x0000000183B30730-0x0000000183B30A30
	// [XID] // 0x0000000189760F10-0x0000000189760F30
	private void OnStoreItemDelNotify(StoreItemDelNotify notify) {} // 0x0000000183B31060-0x0000000183B31360
	// [XID] // 0x00000001897682A0-0x00000001897682C0
	private void OnItemChangePreprocess(StoreItemChangeNotify ntf) {} // 0x0000000183B34220-0x0000000183B34A40
	// [XID] // 0x000000018976F870-0x000000018976F890
	private void OnItemDelPreprocess(StoreItemDelNotify ntf) {} // 0x0000000183B33E20-0x0000000183B340A0
	// [XID] // 0x00000001897771D0-0x00000001897771F0
	private void OnItemAddHintNotify(ItemAddHintNotify notify) {} // 0x0000000183B2D510-0x0000000183B2EC80
	// [XID] // 0x000000018977E900-0x000000018977E920
	private ItemConfig FilterItemConfig(ItemConfig itemConfig) => default; // 0x0000000183B2EFA0-0x0000000183B2F0D0
	// [XID] // 0x00000001897860C0-0x00000001897860E0
	private void OnDropHintNotify(DropHintNotify notify) {} // 0x0000000183B33830-0x0000000183B33A70
	// [XID] // 0x000000018978D750-0x000000018978D770
	private void OnUseItemRsp(UseItemRsp rsp) {} // 0x0000000183B31470-0x0000000183B316D0
	// [XID] // 0x0000000189794BE0-0x0000000189794C00
	private void OnDropItemRsp(DropItemRsp rsp) {} // 0x0000000183B2F150-0x0000000183B2F2E0
	// [XID] // 0x000000018979D110-0x000000018979D130
	private void OnAvatarCardChangeRsp(AvatarCardChangeRsp rsp) {} // 0x0000000183B33AF0-0x0000000183B33D00
	// [XID] // 0x00000001897A4410-0x00000001897A4430
	private void OnItemCdGroupTimeNotify(ItemCdGroupTimeNotify ntf) {} // 0x0000000183B2EC80-0x0000000183B2EE70
	// [XID] // 0x00000001897AB980-0x00000001897AB9A0
	private void OnGrantRewardNotify(GrantRewardNotify ntf) {} // 0x0000000183B32C60-0x0000000183B32D10
	// [XID] // 0x00000001897B38E0-0x00000001897B3900
	public override bool OnNotify(Notify ntf) => default; // 0x0000000183B35E50-0x0000000183B35F40
	// [XID] // 0x00000001897BB6D0-0x00000001897BB6F0
	public void UseItem(StoreType storeType, ItemType itemType, int typeIndex, uint num, ulong targetGuid = 0 /* Metadata: 0x00AFF8FA */, uint optionIndex = 0 /* Metadata: 0x00AFF902 */, bool IsEnterMpDungeonTeam = false /* Metadata: 0x00AFF906 */) {} // 0x0000000183B30A30-0x0000000183B30B80
	// [XID] // 0x00000001897C2F30-0x00000001897C2F50
	public void DropItem(StoreType storeType, ItemType itemType, int typeIndex, uint num) {} // 0x0000000183B34A40-0x0000000183B34B50
	// [XID] // 0x00000001897CA7F0-0x00000001897CA810
	public void RequestCombine(uint combineId, uint count, ulong avatarGuid) {} // 0x0000000183B32D10-0x0000000183B32E50
	// [XID] // 0x00000001897D1D30-0x00000001897D1D50
	private void OnCombineRsp(CombineRsp rsp) {} // 0x0000000183B31A20-0x0000000183B320A0
	// [XID] // 0x00000001897D9BD0-0x00000001897D9BF0
	private void OnForgeQueueDataNotify(ForgeQueueDataNotify ntf) {} // 0x0000000183B334E0-0x0000000183B336E0
	// [XID] // 0x00000001897E0F00-0x00000001897E0F20
	private void OnForgeQueueMapUpdate(MapField<uint, ForgeQueueData> forgeQueueMap, bool fullAmount) {} // 0x0000000183B30DD0-0x0000000183B31060
	// [XID] // 0x00000001897E85D0-0x00000001897E85F0
	public void RequestForgeGetQueueData() {} // 0x0000000183B35150-0x0000000183B35230
	// [XID] // 0x00000001897F02E0-0x00000001897F0300
	private void OnForgeGetQueueDataRsp(ForgeGetQueueDataRsp rsp) {} // 0x0000000183B356F0-0x0000000183B35A70
	// [XID] // 0x0000000189A80C60-0x0000000189A80C80
	public bool HaveFinishForgeItem() => default; // 0x0000000183B340A0-0x0000000183B34220
	// [XID] // 0x00000001897FF0B0-0x00000001897FF0D0
	public void RequestForgeStart(uint forgeId, uint count, uint avatarId) {} // 0x0000000183B35010-0x0000000183B35150
	// [XID] // 0x0000000189806830-0x0000000189806850
	private void OnForgeStartRsp(ForgeStartRsp rsp) {} // 0x0000000183B35500-0x0000000183B356F0
	// [XID] // 0x000000018980DFF0-0x000000018980E010
	public void RequestForgeQueueManipulate(uint queueId, ForgeQueueManipulateType type) {} // 0x0000000183B34CF0-0x0000000183B34E10
	// [XID] // 0x0000000189815690-0x00000001898156B0
	private void OnForgeQueueManipulateRsp(ForgeQueueManipulateRsp rsp) {} // 0x0000000183B32210-0x0000000183B327B0
	// [XID] // 0x000000018981D0E0-0x000000018981D100
	private void OnBagItemUse(StoreType storeType, ItemType itemType, int bagItemSlotIndex, uint num) {} // 0x0000000183B33D00-0x0000000183B33E20
	// [XID] // 0x0000000189824500-0x0000000189824520
	private void OnBagItemDrop(Notify ntf) {} // 0x0000000183B34B50-0x0000000183B34CF0
	// [XID] // 0x000000018982BFD0-0x000000018982BFF0
	public override void ClearOnLevelDestroy() {} // 0x0000000183B2FC40-0x0000000183B2FCE0
	// [XID] // 0x00000001898334E0-0x0000000189833500
	public override void ClearOnDisconnect() {} // 0x0000000183B35D20-0x0000000183B35DC0
	// [XID] // 0x00000001898D5730-0x00000001898D5750
	public void PickItem(uint entityID) {} // 0x0000000183B32F00-0x0000000183B334E0
	// [XID] // 0x0000000189A5AFE0-0x0000000189A5B000
	public GivingRecord GetGivingRecord(uint id) => default; // 0x0000000183B320A0-0x0000000183B32190
	// [XID] // 0x00000001898494A0-0x00000001898494C0
	private void OnGivingRecordNotify(GivingRecordNotify ntf) {} // 0x0000000183B327B0-0x0000000183B32A80
	// [XID] // 0x0000000189850C80-0x0000000189850CA0
	private void OnGivingRecordChangeNotify(GivingRecordChangeNotify ntf) {} // 0x0000000183B35F40-0x0000000183B36160
	// [XID] // 0x0000000189858080-0x00000001898580A0
	public void RequestItemGiving(uint givingId, Dictionary<uint, uint> _itemParams) {} // 0x0000000183B30390-0x0000000183B30640
	// [XID] // 0x000000018985F150-0x000000018985F170
	private void OnItemGivingRsp(ItemGivingRsp rsp) {} // 0x0000000183B35A70-0x0000000183B35C50
	// [XID] // 0x0000000189866950-0x0000000189866970
	public void TakeMaterilDeleteReturnReq() {} // 0x0000000183B316D0-0x0000000183B317B0
	// [XID] // 0x000000018986E230-0x000000018986E250
	private void OnTakeMaterilDeleteReturnRsp(TakeMaterialDeleteReturnRsp rsp) {} // 0x0000000183B32E50-0x0000000183B32F00
	// [XID] // 0x0000000189875700-0x0000000189875720
	private void OnMaterialDeleteReturnNotify(MaterialDeleteReturnNotify notify) {} // 0x0000000183B35230-0x0000000183B35420
	// [XID] // 0x000000018987D250-0x000000018987D270
	private void OnDestroyMaterialRsp(DestroyMaterialRsp rsp) {} // 0x0000000183B317B0-0x0000000183B31A20
	// [XID] // 0x0000000189884190-0x00000001898841B0
	public void RequestChangeLockState(ulong itemGuid, bool isLock) {} // 0x0000000183B2EE70-0x0000000183B2EFA0
	// [XID] // 0x000000018988B8C0-0x000000018988B8E0
	public void RequestCalcWeaponUpgradeReturnItems(ulong targetWeaponGuid, List<ulong> foodWeaponGuids, List<ItemParam> itemParamList) {} // 0x0000000183B32A80-0x0000000183B32C60
	// [XID] // 0x0000000189892FB0-0x0000000189892FD0
	private void OnForgeDataNotify(ForgeDataNotify ntf) {} // 0x0000000183B30CA0-0x0000000183B30DD0
	// [XID] // 0x000000018989A6B0-0x000000018989A6D0
	private void OnForgeFormulaDataNotify(ForgeFormulaDataNotify ntf) {} // 0x0000000183B2FFC0-0x0000000183B300E0
	// [XID] // 0x00000001898A1900-0x00000001898A1920
	private void OnCombineDataNotify(CombineDataNotify ntf) {} // 0x0000000183B31360-0x0000000183B31470
	// [XID] // 0x00000001898A9130-0x00000001898A9150
	private void OnCombineFormulaDataNotify(CombineFormulaDataNotify ntf) {} // 0x0000000183B30B80-0x0000000183B30CA0
	// [XID] // 0x00000001898B0A60-0x00000001898B0A80
	private void OnItemExceedLimitNotify(ItemExceedLimitNotify itemExceedLimitNotify) {} // 0x0000000183B300E0-0x0000000183B30190
	// [XID] // 0x00000001898B8160-0x00000001898B8180
	private void ShowItemExceedLimitTip(ItemExceedLimitNotify itemExceedLimitNotify) {} // 0x0000000183B2F940-0x0000000183B2FC40
	// [XID] // 0x00000001898BF820-0x00000001898BF840
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x0000000183B2FCE0-0x0000000183B2FFC0
	// [XID] // 0x00000001898C7100-0x00000001898C7120
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x0000000183B35C50-0x0000000183B35D20
}

