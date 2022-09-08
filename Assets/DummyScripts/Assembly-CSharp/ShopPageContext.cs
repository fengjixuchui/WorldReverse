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

public class ShopPageContext : BasePageContext // TypeDefIndex: 29295
{
	// Fields
	protected ShopData _shopData; // 0x190
	protected MonoShopPage _pageMono; // 0x198
	protected ShopType _shopType; // 0x1A0
	protected uint _selectedShopID; // 0x1A4
	protected uint _selectedShopItemID; // 0x1A8
	protected ShopItem _selectedShopItem; // 0x1B0
	protected Dictionary<uint, int> _itemIDToIndexDic; // 0x1B8
	private uint _shopMaterialHandler; // 0x1C0
	private GameObject _shopMaterialPrefab; // 0x1C8
	private const string SHOP_MAT_PATH = "ART/UI/Menus/Widget/ShopMaterialsItem"; // Metadata: 0x00B0F538
	private const string ITEM_TIPS_PREFAB_PATH = "ART/UI/Menus/Widget/ItemTips"; // Metadata: 0x00B0F561
	private MonoItemTip _itemTipsPrefab; // 0x1D0
	private uint _itemTipsHandler; // 0x1D8
	private List<ShopMaterial> _shopMaterialsList; // 0x1E0
	private uint _dungeonID; // 0x1E8
	private List<uint> _groupItemID; // 0x1F0
	private int _curSelectSource; // 0x1F8
	private MonoAudioEvent2D.Event _shopSuccessAudio; // 0x200
	private int _currSelectedIndex; // 0x210
	private List<string> _dungeonNameList; // 0x218
	private Dictionary<string, List<uint>> _dungeonNameToIDsDict; // 0x220
	private List<string> _textList; // 0x228

	// Properties
	public ShopType shopType { /* [XID] */ /* 0x0000000189A768B0-0x0000000189A768D0 */ set {} } // 0x0000000182EC49F0-0x0000000182EC4AA0
	private bool isFocosDetail { /* [XID] */ /* 0x0000000189A9C220-0x0000000189A9C240 */ get => default; } // 0x0000000182EC6A30-0x0000000182EC6BA0 

	// Constructors
	public ShopPageContext() {} // 0x0000000182ECCE30-0x0000000182ECD050

	// Methods
	// [XID] // 0x0000000189A7E180-0x0000000189A7E1A0
	public override void SetupView() {} // 0x0000000182ECCC80-0x0000000182ECCE30
	// [XID] // 0x0000000189A85B20-0x0000000189A85B40
	private void SetSelectSource(int index, bool force, bool scrollTo) {} // 0x0000000182ECBE50-0x0000000182ECC230
	// [XID] // 0x0000000189A8D3C0-0x0000000189A8D3E0
	private void ScrollToTop() {} // 0x0000000182EC9DE0-0x0000000182EC9F70
	// [XID] // 0x0000000189A94900-0x0000000189A94920
	private MonoSourceListRow GetSelectSourceItem(int index) => default; // 0x0000000182ECBBD0-0x0000000182ECBE50
	// [XID] // 0x0000000189AA38D0-0x0000000189AA38F0
	protected void RefreshShowStateByFocusDetail() {} // 0x0000000182EC9B70-0x0000000182EC9DE0
	// [XID] // 0x0000000189AAAF90-0x0000000189AAAFB0
	private void RefreshShowStateBySelectChange(MonoSourceListRow item) {} // 0x0000000182EC47A0-0x0000000182EC4970
	// [XID] // 0x0000000189AB2920-0x0000000189AB2940
	protected void FocusItemDetailTips(bool focus) {} // 0x0000000182EC8E70-0x0000000182EC8FB0
	// [XID] // 0x0000000189ABA450-0x0000000189ABA470
	private void RefreshItemTipsSourceIcon() {} // 0x0000000182EC4260-0x0000000182EC4420
	// [XID] // 0x0000000189AC1DA0-0x0000000189AC1DC0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182EC8FB0-0x0000000182EC9B10
	// [XID] // 0x0000000189AC9350-0x0000000189AC9370
	protected override void BindViewCallbacks() {} // 0x0000000182EC5A40-0x0000000182EC5BA0
	// [XID] // 0x0000000189AD0E20-0x0000000189AD0E40
	public override void ClearView() {} // 0x0000000182EC61F0-0x0000000182EC6320
	// [XID] // 0x0000000189AD8A50-0x0000000189AD8A70
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182ECC320-0x0000000182ECC6C0
	// [XID] // 0x0000000189AE0620-0x0000000189AE0640
	private void OnShopRefresh(Notify ntf) {} // 0x0000000182ECC7C0-0x0000000182ECC920
	// [XID] // 0x0000000189AE7BB0-0x0000000189AE7BD0
	protected void UpdateShopData(ShopData shopData, int tabIndex = -1 /* Metadata: 0x00B0F52F */) {} // 0x0000000182EC6C40-0x0000000182EC6F20
	// [XID] // 0x0000000189AEF910-0x0000000189AEF930
	private void RefreshVipIcon() {} // 0x0000000182EC7EB0-0x0000000182EC8150
	// [XID] // 0x0000000189AF6E30-0x0000000189AF6E50
	private void OnClickVipBtn() {} // 0x0000000182EC9F70-0x0000000182ECA0A0
	// [XID] // 0x0000000189AFE360-0x0000000189AFE380
	protected void UpdateMaterialsList() {} // 0x0000000182EC8390-0x0000000182EC8B00
	// [XID] // 0x0000000189B05B50-0x0000000189B05B70
	public void UpdateItemSelected(uint selectedShopItemID) {} // 0x0000000182EC5BA0-0x0000000182EC61F0
	// [XID] // 0x0000000189B0D2E0-0x0000000189B0D300
	private List<uint> CheckChooseOneGroup() => default; // 0x0000000182EC5860-0x0000000182EC5A40
	// [XID] // 0x0000000189B14840-0x0000000189B14860
	private void CheckHadItemNum(uint itemID) {} // 0x0000000182EC79B0-0x0000000182EC7BA0
	// [XID] // 0x0000000189B1C160-0x0000000189B1C180
	private void SetUnlockPrompt(ShopItem shopItem) {} // 0x0000000182EC4AA0-0x0000000182EC5860
	// [XID] // 0x0000000189B237F0-0x0000000189B23810
	private void SetQuatityView(ShopItem shopItem) {} // 0x0000000182ECA0A0-0x0000000182ECA4A0
	// [XID] // 0x0000000189B2AA90-0x0000000189B2AAB0
	protected virtual void SetRefreshTime(ShopItem shopItem) {} // 0x0000000182ECB000-0x0000000182ECB600
	// [XID] // 0x0000000189B31FC0-0x0000000189B31FE0
	private void RefreshCostItems() {} // 0x0000000182EC8B00-0x0000000182EC8E10
	// [XID] // 0x0000000189B39780-0x0000000189B397A0
	private void OnConfirm() {} // 0x0000000182EC74A0-0x0000000182EC79B0
	// [XID] // 0x0000000189B41130-0x0000000189B41150
	private uint CalCulateMaxCanBuyNum() => default; // 0x0000000182EC8150-0x0000000182EC8390
	// [XID] // 0x0000000189B48A20-0x0000000189B48A40
	private void OnExchange() {} // 0x0000000182ECB9E0-0x0000000182ECBB30
	// [XID] // 0x0000000189B501B0-0x0000000189B501D0
	private void RefreshSelection() {} // 0x0000000182ECB600-0x0000000182ECB7B0
	// [XID] // 0x0000000189B579E0-0x0000000189B57A00
	private ShopData SortShopItemList(ShopData shopdata, int tabIndex = -1 /* Metadata: 0x00B0F533 */) => default; // 0x0000000182EC6320-0x0000000182EC6740
	// [XID] // 0x0000000189B5F350-0x0000000189B5F370
	private void RefreshItem(Transform trans, int index) {} // 0x0000000182EC6740-0x0000000182EC6A30
	// [XID] // 0x0000000189B66940-0x0000000189B66960
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x0000000182ECB880-0x0000000182ECB9E0
	// [XID] // 0x0000000189B6DEA0-0x0000000189B6DEC0
	protected override void RegisterHandlePacket() {} // 0x0000000182ECCBD0-0x0000000182ECCC80
	// [XID] // 0x0000000189B75590-0x0000000189B755B0
	public override bool OnPacket(Packet packet) => default; // 0x0000000182ECC6C0-0x0000000182ECC7C0
	// [XID] // 0x0000000189B7C9C0-0x0000000189B7C9E0
	private void RefreshItemSource(BagItem item) {} // 0x0000000182ECA4A0-0x0000000182ECB000
	// [XID] // 0x0000000189B84840-0x0000000189B84860
	private void RefreshSourceDungeonListItem(Transform trans, int index) {} // 0x0000000182EC6FB0-0x0000000182EC74A0
	// [XID] // 0x0000000189B8B6D0-0x0000000189B8B6F0
	protected void ShowNoItemPage(bool value = true /* Metadata: 0x00B0F537 */) {} // 0x0000000182EC7BA0-0x0000000182EC7EB0
	// [XID] // 0x0000000189B92E00-0x0000000189B92E20
	private void OnDungeonEntryInfoRsp(DungeonEntryInfoRsp rsp) {} // 0x0000000182ECC920-0x0000000182ECCBD0
	// [XID] // 0x0000000189B9A3C0-0x0000000189B9A3E0
	private void OnDungeonEntry(uint dungeonID) {} // 0x0000000182EC4420-0x0000000182EC4740
	// [XID] // 0x0000000189BA1AF0-0x0000000189BA1B10
	protected virtual bool IsTabLocked() => default; // 0x0000000182ECBB30-0x0000000182ECBBD0
	// [XID] // 0x0000000189BA8F70-0x0000000189BA8F90
	protected virtual bool IsTabPreviewd() => default; // 0x0000000182EC6BA0-0x0000000182EC6C40
	// [XID] // 0x0000000189BB06E0-0x0000000189BB0700
	protected virtual string TabLockReason() => default; // 0x0000000182ECB7B0-0x0000000182ECB880
}

