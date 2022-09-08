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

public sealed class BagPageContext : BasePageContext // TypeDefIndex: 28825
{
	// Fields
	private MonoBagPage _pageMono; // 0x190
	private ulong[] _selectedItemGuid; // 0x198
	private int _selectedTabIndex; // 0x1A0
	private int _tabCount; // 0x1A4
	private Vector2[] _tabLastScrollPosition; // 0x1A8
	private bool _opened; // 0x1B0
	private BagTabConfig.Config _currTabConfig; // 0x1B8
	private List<BagTabConfig.Config> _tabConfigList; // 0x1E0
	private List<BagItemSlot> _slotList; // 0x1E8
	private SortType _sortType; // 0x1F0
	private uint _relicSetID; // 0x1F4
	private int _selectedRelicSetIndex; // 0x1F8
	private List<uint> _reliquarySetIDList; // 0x200
	private uint _furnitureSetID; // 0x208
	private int _selectedFurnitureSetIndex; // 0x20C
	private List<uint> _furnitureSetIDList; // 0x210
	private uint _dungeonID; // 0x218
	private uint _itemToShow; // 0x21C
	private uint _lunchBoxMaterialId; // 0x220
	private const int INPUT_STATE_DROPDOWN = 1; // Metadata: 0x00B0E77E
	private const int INPUT_STATE_ITEMDETAIL = 2; // Metadata: 0x00B0E782
	private static uint _healAudio; // 0x00
	private static uint _reviveAudio; // 0x04
	private List<string> _dungeonNameList; // 0x228
	private Dictionary<string, List<uint>> _dungeonNameToIDsDict; // 0x230
	private List<string> _textList; // 0x238
	private int _currSourceIndex; // 0x240
	private List<WidgetSystemModule.LunchBoxType> _lunchBoxSelectList; // 0x248
	private int _currQuickUsePropIndex; // 0x250
	private bool _isDestroyMode; // 0x254
	private ItemDestroyDialogContext _destroyDialogContext; // 0x258
	private Dictionary<ItemType, Dictionary<ulong, DestroyItemInfo>> _destroyDic; // 0x260
	private BagItemSlot _currentSlot; // 0x268
	private HashSet<ulong> _destroyModeHighLightItemGuid; // 0x270
	private HashSet<ulong> _destroyModeMarkedItemGuid; // 0x278
	private bool _isClickEnable; // 0x280
	private MonoBagPageCookSelect _selectMono; // 0x288
	private List<uint> _selectFoodList; // 0x290
	private BagItemSlot _currentLunchBoxBagItemSlot; // 0x298
	private WidgetSystemModule.LunchBoxType _currentLunchBoxType; // 0x2A0
	private bool _isMiracleRingMode; // 0x2A4
	private MiracleRingDialogContext _miracleRingDialogContext; // 0x2A8
	private Dictionary<ItemType, Dictionary<ulong, MiracleRingItemInfo>> _miracleRingDic; // 0x2B0
	private BagItemSlot _currentMiracleRingSlot; // 0x2B8
	private HashSet<ulong> _miracleRingModeHighLightItemGuid; // 0x2C0
	private HashSet<ulong> _miracleRingModeMarkedItemGuid; // 0x2C8

	// Properties
	private bool showSort { /* [XID] */ /* 0x0000000189B0EA70-0x0000000189B0EA90 */ get => default; } // 0x00000001813813F0-0x00000001813814B0 

	// Nested types
	public class DestroyItemInfo // TypeDefIndex: 28826
	{
		// Fields
		public uint itemId; // 0x10
		public int itemNum; // 0x14

		// Constructors
		public DestroyItemInfo() {} // Dummy constructor
		public DestroyItemInfo(uint itemId_, int itemNum_) {} // 0x00000001828E6240-0x00000001828E62C0
	}

	public class MiracleRingItemInfo // TypeDefIndex: 28827
	{
		// Fields
		public uint itemId; // 0x10
		public int itemNum; // 0x14
		public ulong itemGuid; // 0x18

		// Constructors
		public MiracleRingItemInfo() {} // Dummy constructor
		public MiracleRingItemInfo(uint itemId_, int itemNum_, ulong itemGuid_) {} // 0x00000001828E5B90-0x00000001828E5C10
	}

	// Constructors
	public BagPageContext() {} // Dummy constructor
	public BagPageContext(uint itemToShow = 0 /* Metadata: 0x00B0E777 */) {} // 0x0000000181385770-0x0000000181385C60
	static BagPageContext() {} // 0x00000001813856C0-0x0000000181385770

	// Methods
	// [XID] // 0x0000000189929140-0x0000000189929160
	public override void SetupView() {} // 0x00000001813851D0-0x00000001813856C0
	// [XID] // 0x0000000189930690-0x00000001899306B0
	private void CalcTabInfo() {} // 0x00000001813749C0-0x0000000181374F30
	// [XID] // 0x0000000189937C20-0x0000000189937C40
	private new void Setup() {} // 0x0000000181373B30-0x00000001813741A0
	// [XID] // 0x000000018993F690-0x000000018993F6B0
	public override void ClearView() {} // 0x0000000181372F80-0x0000000181373070
	// [XID] // 0x0000000189946CA0-0x0000000189946CC0
	protected override void PostProcessOfSetActive() {} // 0x0000000181384E90-0x0000000181384F70
	// [XID] // 0x000000018994E320-0x000000018994E340
	protected override void BindRedPoints() {} // 0x0000000181371EC0-0x00000001813720A0
	// [XID] // 0x0000000189955980-0x00000001899559A0
	protected override void OnEnable() {} // 0x0000000181383290-0x00000001813833B0
	// [XID] // 0x000000018995D420-0x000000018995D440
	public override void SetActive(bool enabled) {} // 0x0000000181385050-0x00000001813851D0
	// [XID] // 0x0000000189964B10-0x0000000189964B30
	protected override void BindViewCallbacks() {} // 0x00000001813720A0-0x0000000181372470
	// [XID] // 0x000000018996C190-0x000000018996C1B0
	private void OnUseButtonClicked() {} // 0x00000001813737C0-0x0000000181373990
	// [XID] // 0x0000000189973C40-0x0000000189973C60
	private void DropBagItem() {} // 0x000000018137FC70-0x000000018137FFD0
	// [XID] // 0x000000018997B2B0-0x000000018997B2D0
	private void CheckBeforeDrop(uint rankLevel, string name, ItemType itemType, int typeIndex) {} // 0x000000018137F560-0x000000018137F7E0
	// [XID] // 0x0000000189982DA0-0x0000000189982DC0
	public override void ClosePage() {} // 0x0000000181370E90-0x0000000181370F70
	// [XID] // 0x000000018998A550-0x000000018998A570
	private void ToPrevTab() {} // 0x0000000181372ED0-0x0000000181372F80
	// [XID] // 0x0000000189991E80-0x0000000189991EA0
	private void ToNextTab() {} // 0x0000000181373710-0x00000001813737C0
	// [XID] // 0x0000000189999B50-0x0000000189999B70
	private void ToNextSlot() {} // 0x000000018136F6C0-0x000000018136F790
	// [XID] // 0x00000001899A1260-0x00000001899A1280
	private void ToPrevSlot() {} // 0x000000018137A3C0-0x000000018137A490
	// [XID] // 0x00000001899A8CF0-0x00000001899A8D10
	private void ToNextRow() {} // 0x000000018137D700-0x000000018137D7D0
	// [XID] // 0x00000001899B0630-0x00000001899B0650
	private void ToPrevRow() {} // 0x0000000181370DC0-0x0000000181370E90
	// [XID] // 0x00000001899B7960-0x00000001899B7980
	private void ToggleSortAscend() {} // 0x0000000181382E30-0x0000000181382FD0
	// [XID] // 0x00000001899BF340-0x00000001899BF360
	private void OnSortTypeChanged(int index) {} // 0x0000000181374F30-0x00000001813750E0
	// [XID] // 0x00000001899C6D30-0x00000001899C6D50
	public override bool OnNotify(Notify ntf) => default; // 0x00000001813833B0-0x00000001813835C0
	// [XID] // 0x00000001899CE260-0x00000001899CE280
	private void OnBagSlotUpdate(Notify ntf) {} // 0x0000000181381840-0x00000001813819B0
	// [XID] // 0x00000001899D5A60-0x00000001899D5A80
	private void UpdateTab(Dictionary<int, Dictionary<int, bool>> dirtyDict) {} // 0x0000000181371750-0x00000001813719B0
	// [XID] // 0x00000001899DCD70-0x00000001899DCD90
	private void OnBagWeightUIRefresh(Notify ntf) {} // 0x000000018137EAD0-0x000000018137EC20
	// [XID] // 0x00000001899E4990-0x00000001899E49B0
	private void UpdateWeightLabel(uint currValue, uint totalValue) {} // 0x0000000181384380-0x0000000181384630
	// [XID] // 0x00000001899EBE00-0x00000001899EBE20
	private void OnItemAdded(List<SimpleItemStruct> items, bool showGotDialog = true /* Metadata: 0x00B0E77B */) {} // 0x0000000181380570-0x0000000181380770
	// [XID] // 0x00000001899F3830-0x00000001899F3850
	private void OnBattlePassBuySuccessNotify() {} // 0x0000000181379FC0-0x000000018137A0A0
	// [XID] // 0x00000001899FB170-0x00000001899FB190
	private void OnWidgetEquipChange() {} // 0x000000018137DA30-0x000000018137DB40
	// [XID] // 0x0000000189A023A0-0x0000000189A023C0
	private void SetCurrencyView() {} // 0x000000018137F9C0-0x000000018137FC70
	// [XID] // 0x0000000189A09BB0-0x0000000189A09BD0
	private void OnSelectedItemChanged(BagItemSlot itemData) {} // 0x0000000181378A40-0x00000001813792D0
	// [XID] // 0x0000000189A11370-0x0000000189A11390
	private void RefreshItemLabel(BagItemSlot itemData) {} // 0x0000000181379A90-0x0000000181379FC0
	// [XID] // 0x0000000189A18780-0x0000000189A187A0
	private void OnTabClicked(int tabIndex) {} // 0x0000000181377F60-0x00000001813787A0
	// [XID] // 0x0000000189A1FDE0-0x0000000189A1FE00
	private void CheckJoyStickIconShowWhenListEmpty() {} // 0x0000000181371CA0-0x0000000181371EC0
	// [XID] // 0x0000000189A27150-0x0000000189A27170
	private void RefreshTabContent() {} // 0x0000000181370F70-0x0000000181371750
	// [XID] // 0x0000000189A2E9B0-0x0000000189A2E9D0
	private void RefreshScreenScroller() {} // 0x000000018137E4C0-0x000000018137E6B0
	// [XID] // 0x0000000189A362C0-0x0000000189A362E0
	private void SetupSortDropdown() {} // 0x00000001813760D0-0x00000001813765C0
	// [XID] // 0x0000000189A3D8C0-0x0000000189A3D8E0
	private void RefreshSlotList() {} // 0x0000000181382600-0x0000000181382B50
	// [XID] // 0x0000000189A45020-0x0000000189A45040
	private List<BagItemSlot> FilterSlotList(List<BagItemSlot> slotList) => default; // 0x0000000181372470-0x0000000181372530
	// [XID] // 0x0000000189A4C780-0x0000000189A4C7A0
	private void RefreshShowStateByFocusDetail(bool isFocus) {} // 0x000000018137AFF0-0x000000018137B320
	// [XID] // 0x0000000189A53F60-0x0000000189A53F80
	private void RefreshItemTipsSourceIcon(bool isFocus) {} // 0x000000018136FB10-0x000000018136FCD0
	// [XID] // 0x0000000189A5B970-0x0000000189A5B990
	protected override void RegisterHandlePacket() {} // 0x0000000181384F70-0x0000000181385050
	// [XID] // 0x0000000189A63020-0x0000000189A63040
	public override bool OnPacket(Packet packet) => default; // 0x00000001813835C0-0x0000000181383780
	// [XID] // 0x0000000189A6AB80-0x0000000189A6ABA0
	private void OnDungeonEntryInfoRsp(DungeonEntryInfoRsp rsp) {} // 0x00000001813840D0-0x0000000181384380
	// [XID] // 0x0000000189A72280-0x0000000189A722A0
	private void OnRecipeUpdate() {} // 0x0000000181377DE0-0x0000000181377EC0
	// [XID] // 0x0000000189A79EE0-0x0000000189A79F00
	private void RefreshDeleteItem() {} // 0x00000001813792D0-0x0000000181379490
	// [XID] // 0x0000000189A81360-0x0000000189A81380
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018137A600-0x000000018137AF90
	// [XID] // 0x0000000189A88D60-0x0000000189A88D80
	private void OnCommonLeftStickButtonEvent() {} // 0x000000018136FED0-0x0000000181370050
	// [XID] // 0x0000000189A90510-0x0000000189A90530
	private bool HandleInputActionEventDropdown(InputActionEvent actionEvent) => default; // 0x000000018136FCD0-0x000000018136FED0
	// [XID] // 0x0000000189A97DA0-0x0000000189A97DC0
	private bool HandleInputActionEventItemDetail(InputActionEvent actionEvent) => default; // 0x0000000181383F80-0x00000001813840D0
	// [XID] // 0x0000000189A9F0F0-0x0000000189A9F110
	private bool HandleInputActionEventItemDetail_LunchBox(InputActionEvent actionEvent) => default; // 0x0000000181380E60-0x00000001813810C0
	// [XID] // 0x0000000189AA69F0-0x0000000189AA6A10
	private bool HandleInputActionEventItemDetail_SourceTips(InputActionEvent actionEvent) => default; // 0x00000001813787A0-0x0000000181378A40
	// [XID] // 0x0000000189AAE080-0x0000000189AAE0A0
	private void ClearFocus() {} // 0x0000000181381340-0x00000001813813F0
	// [XID] // 0x0000000189AB5990-0x0000000189AB59B0
	private void ClearSourceFocus() {} // 0x0000000181383D60-0x0000000181383F80
	// [XID] // 0x0000000189ABD390-0x0000000189ABD3B0
	private void ClearPropFocus() {} // 0x0000000181377BE0-0x0000000181377DE0
	// [XID] // 0x0000000189AC4DC0-0x0000000189AC4DE0
	private void ScrollToTop() {} // 0x000000018137C840-0x000000018137C9D0
	// [XID] // 0x0000000189ACC420-0x0000000189ACC440
	private void ScrollItemTip(InputActionEvent actionEvent) {} // 0x0000000181373510-0x0000000181373710
	// [IDTag] // 0x0000000189AD3FC0-0x0000000189AD4000
	// [XID] // 0x0000000189AD3FC0-0x0000000189AD4000
	private void UseMaterial(BagItemSlot itemSlot) {} // 0x0000000181375250-0x00000001813760D0
	// [XID] // 0x0000000189ADEBF0-0x0000000189ADEC10
	private void OpenAvatarSelectDialog(ItemUseTarget targetType, MaterialItem item, int typeIndex) {} // 0x0000000181382040-0x0000000181382310
	// [XID] // 0x0000000189AE65A0-0x0000000189AE65C0
	private bool CheckBattlePassItemCanUse(MaterialExcelConfig config, int typeIndex) => default; // 0x000000018137BCA0-0x000000018137C0B0
	// [XID] // 0x0000000189AEDDB0-0x0000000189AEDDD0
	private bool CheckMonthlyCardItemCanUse(MaterialExcelConfig config, int typeIndex) => default; // 0x0000000181372530-0x0000000181372780
	// [XID] // 0x0000000189AF55E0-0x0000000189AF5600
	private bool CheckResinCardItemCanUse(MaterialExcelConfig config, int typeIndex, uint configId) => default; // 0x000000018137D7D0-0x000000018137DA30
	// [IDTag] // 0x0000000189AFCAD0-0x0000000189AFCB10
	// [XID] // 0x0000000189AFCAD0-0x0000000189AFCB10
	private void UseMaterial(MaterialExcelConfig config, int typeIndex) {} // 0x00000001813750E0-0x0000000181375250
	// [XID] // 0x0000000189B07270-0x0000000189B07290
	private void UseWidget(BagItemSlot itemSlot) {} // 0x000000018137DD80-0x000000018137DF50
	// [XID] // 0x0000000189B15E00-0x0000000189B15E20
	private void OnScreenButtonClicked() {} // 0x00000001813800B0-0x0000000181380210
	// [XID] // 0x0000000189B1D530-0x0000000189B1D550
	private void RefreshScreenOptionItem(Transform trans, int index) {} // 0x0000000181383780-0x0000000181383D60
	// [XID] // 0x0000000189B24DD0-0x0000000189B24DF0
	private void OnScreenOptionClicked(int index) {} // 0x000000018137B940-0x000000018137BAC0
	// [XID] // 0x0000000189B2C280-0x0000000189B2C2A0
	private void OpenScreenOptionScroller() {} // 0x0000000181376AC0-0x0000000181376BD0
	// [XID] // 0x0000000189B33810-0x0000000189B33830
	private void CancelScreenSelect() {} // 0x000000018137E0F0-0x000000018137E4C0
	// [XID] // 0x0000000189B3B110-0x0000000189B3B130
	private void ToPrevScreenOption() {} // 0x000000018137ED40-0x000000018137F190
	// [XID] // 0x0000000189B42930-0x0000000189B42950
	private void ToNextScreenOption() {} // 0x0000000181381BA0-0x0000000181382040
	// [XID] // 0x0000000189B4A450-0x0000000189B4A470
	private void RefreshItemSource(BagItem item) {} // 0x000000018137CB80-0x000000018137D700
	// [XID] // 0x0000000189B51BF0-0x0000000189B51C10
	private void RefreshSourceDungeonListItem(Transform trans, int index) {} // 0x0000000181377080-0x0000000181377570
	// [XID] // 0x0000000189B593F0-0x0000000189B59410
	private void OnDungeonEntry(uint dungeonID) {} // 0x0000000181370050-0x0000000181370370
	// [XID] // 0x0000000189B60C80-0x0000000189B60CA0
	private void IterateSourceList(bool up, bool isFocus = true /* Metadata: 0x00B0E77C */) {} // 0x000000018136EEF0-0x000000018136F420
	// [XID] // 0x0000000189B68370-0x0000000189B68390
	private void OnCurrSourceListRowClick() {} // 0x000000018137BAC0-0x000000018137BCA0
	// [XID] // 0x0000000189B6F670-0x0000000189B6F690
	private void RefreshShowStateBySelectChange(MonoSourceListRow item) {} // 0x0000000181370760-0x0000000181370960
	// [XID] // 0x0000000189B76CF0-0x0000000189B76D10
	private void RefreshItemQuickUseProp(BagItem item) {} // 0x0000000181376BD0-0x0000000181376F30
	// [XID] // 0x0000000189B7E280-0x0000000189B7E2A0
	private void IterateQuickUsePropList(bool up, bool isFocus = true /* Metadata: 0x00B0E77D */) {} // 0x0000000181380920-0x0000000181380E60
	// [XID] // 0x0000000189B85E80-0x0000000189B85EA0
	private void OnCurrQuickUsePropRowClick() {} // 0x000000018137B320-0x000000018137B520
	// [XID] // 0x0000000189B8CEF0-0x0000000189B8CF10
	private void RefreshLunchBoxScroll(Transform trans, int index) {} // 0x0000000181373180-0x0000000181373440
	// [XID] // 0x0000000189B946A0-0x0000000189B946C0
	private void RefreshLunchBoxCheckButtonText() {} // 0x000000018137E8C0-0x000000018137EAD0
	// [XID] // 0x0000000189B9BD10-0x0000000189B9BD30
	private void RefreshLunchBoxContent() {} // 0x0000000181380210-0x0000000181380570
	// [XID] // 0x0000000189BA3490-0x0000000189BA34B0
	private void OnDestroyItemButtonClicked() {} // 0x000000018137B6A0-0x000000018137B940
	// [XID] // 0x0000000189BAA7F0-0x0000000189BAA810
	private void OnIntoDestroyDialog() {} // 0x0000000181370960-0x0000000181370C40
	// [XID] // 0x0000000189BB1E70-0x0000000189BB1E90
	private void OnQuitDestroyDialog() {} // 0x000000018137DB40-0x000000018137DD80
	// [XID] // 0x0000000189BB9230-0x0000000189BB9250
	private void ClearDestroyStateWhenBagOpen() {} // 0x000000018137EC20-0x000000018137ED40
	// [XID] // 0x0000000189BC1040-0x0000000189BC1060
	private void ClearDestroyDictContent() {} // 0x000000018137B520-0x000000018137B6A0
	// [XID] // 0x0000000189BC87D0-0x0000000189BC87F0
	private void SetChooseNum(MonoQuantityWidget quantityWidget, ItemType type, ulong guid) {} // 0x0000000181380770-0x0000000181380920
	// [XID] // 0x0000000189BD0010-0x0000000189BD0030
	private void RefreshSelectItemNum() {} // 0x000000018137F190-0x000000018137F240
	// [XID] // 0x0000000189BD7650-0x0000000189BD7670
	private void UnSelectFromDestroyDialog(ItemType type, ulong guid) {} // 0x0000000181374200-0x0000000181374400
	// [XID] // 0x0000000189BDF150-0x0000000189BDF170
	private void OnSelectedItemChangedUnderDestroyMode(BagItemSlot itemData) {} // 0x000000018137DFE0-0x000000018137E0F0
	// [XID] // 0x00000001895EBDC0-0x00000001895EBDE0
	private void OnSelected(BagItemSlot itemData) {} // 0x0000000181370370-0x0000000181370600
	// [XID] // 0x00000001895F3160-0x00000001895F3180
	private void OnSelectConfirm(BagItemSlot itemData) {} // 0x000000018137C0B0-0x000000018137C730
	// [XID] // 0x00000001895FAA00-0x00000001895FAA20
	private void OnDestroyFinish(Notify ntf) {} // 0x0000000181379790-0x0000000181379990
	// [XID] // 0x0000000189602350-0x0000000189602370
	private void SetTabContentDestroyInfo() {} // 0x0000000181376F30-0x0000000181377080
	// [XID] // 0x0000000189609B90-0x0000000189609BB0
	private void GetCurrentTabDestroyMarkList() {} // 0x00000001813810C0-0x0000000181381340
	// [XID] // 0x0000000189611320-0x0000000189611340
	private void GetCurrentTabDestroyHighLightList() {} // 0x000000018136F980-0x000000018136FB10
	// [XID] // 0x0000000189618D10-0x0000000189618D30
	private bool CanItemBeDestroyed(ulong guid) => default; // 0x00000001813814B0-0x0000000181381840
	// [XID] // 0x0000000189620200-0x0000000189620220
	private void GenerateCurrentDestroyShowState() {} // 0x00000001813765C0-0x0000000181376830
	// [XID] // 0x00000001896276D0-0x00000001896276F0
	private void OnNumChangeAtBagItem(MonoQuantityWidget quantityWidget) {} // 0x0000000181379990-0x0000000181379A90
	// [XID] // 0x000000018962F190-0x000000018962F1B0
	private void ShowQuantityAtBagItem() {} // 0x00000001813778A0-0x0000000181377BE0
	// [XID] // 0x0000000189636B50-0x0000000189636B70
	private void OpenLunchBoxSelect(WidgetSystemModule.LunchBoxType type) {} // 0x0000000181384630-0x0000000181384E90
	// [XID] // 0x000000018963E080-0x000000018963E0A0
	private void CloseLunchBoxSelect() {} // 0x0000000181370660-0x0000000181370760
	// [XID] // 0x0000000189645A10-0x0000000189645A30
	private void SetUpCookSelectList() {} // 0x0000000181383060-0x0000000181383290
	// [XID] // 0x000000018964D220-0x000000018964D240
	private void RefreshCookSelectItem(Transform trans, int index) {} // 0x000000018137A0A0-0x000000018137A360
	// [XID] // 0x00000001896549C0-0x00000001896549E0
	private void OnCookRowClick(int index) {} // 0x000000018136F790-0x000000018136F980
	// [XID] // 0x000000018965C0B0-0x000000018965C0D0
	private void RefreshCookSelect() {} // 0x000000018137F7E0-0x000000018137F9C0
	// [XID] // 0x0000000189663770-0x0000000189663790
	public bool HandleInputActionEventLunchBoxSelect(InputActionEvent actionEvent) => default; // 0x0000000181373990-0x0000000181373B30
	// [XID] // 0x000000018966B0B0-0x000000018966B0D0
	public static BagPageContext CreateBagPageContextForMiracleRing() => default; // 0x0000000181373440-0x0000000181373510
	// [XID] // 0x0000000189672CB0-0x0000000189672CD0
	public void OpenMiracleRingDialog() {} // 0x0000000181377570-0x0000000181377820
	// [XID] // 0x000000018967A3B0-0x000000018967A3D0
	private void FilterSlotListForMiracleRing(List<BagItemSlot> slotList) {} // 0x000000018137C9D0-0x000000018137CB80
	// [XID] // 0x0000000189681C00-0x0000000189681C20
	private void CalcTabInfoMiracleRing(BagTabConfig tabConfig, List<BagTabConfig.Config> tabConfigList) {} // 0x000000018136F420-0x000000018136F6C0
	// [XID] // 0x0000000189689690-0x00000001896896B0
	private HashSet<ItemType> CalcMiracleRingItemTypes(out HashSet<MaterialType> materialTypes) {
		materialTypes = default;
		return default;
	} // 0x0000000181382310-0x0000000181382600
	// [XID] // 0x00000001896912D0-0x00000001896912F0
	private void OnIntoMiracleRingDialog() {} // 0x0000000181382B50-0x0000000181382E30
	// [XID] // 0x0000000189698A80-0x0000000189698AA0
	private void OnQuitMiracleRingDialog() {} // 0x000000018137E6B0-0x000000018137E810
	// [XID] // 0x000000018969FEF0-0x000000018969FF10
	private void ClearMiracleRingStateWhenBagOpen() {} // 0x0000000181373070-0x0000000181373180
	// [XID] // 0x00000001896A7130-0x00000001896A7150
	private void SetChooseMiracleNum(MonoQuantityWidget quantityWidget, ItemType type, ulong guid) {} // 0x0000000181379490-0x0000000181379640
	// [XID] // 0x00000001896AE750-0x00000001896AE770
	private void RefreshSelectMiracleRingItemNum() {} // 0x000000018137A490-0x000000018137A540
	// [XID] // 0x00000001896B5F70-0x00000001896B5F90
	private void UnSelectFromMiracleRingDialog(ItemType type, ulong guid) {} // 0x0000000181376830-0x0000000181376A30
	// [XID] // 0x00000001896BD130-0x00000001896BD150
	private void OnSelectedItemChangedUnderMiracleRingMode(BagItemSlot itemData) {} // 0x000000018137C730-0x000000018137C840
	// [XID] // 0x00000001896C4630-0x00000001896C4650
	private void OnSelectedMiracleRing(BagItemSlot itemData) {} // 0x0000000181371A10-0x0000000181371CA0
	// [XID] // 0x00000001896CBC90-0x00000001896CBCB0
	private void OnSelectConfirmMiracleRing(BagItemSlot itemData) {} // 0x0000000181372780-0x0000000181372ED0
	// [XID] // 0x00000001896D2F30-0x00000001896D2F50
	private void SetTabContentMiracleRingInfo() {} // 0x0000000181379640-0x0000000181379790
	// [XID] // 0x00000001896DAB00-0x00000001896DAB20
	private void GetCurrentTabMiracleRingMarkList() {} // 0x0000000181374740-0x00000001813749C0
	// [XID] // 0x00000001896E2230-0x00000001896E2250
	private void GetCurrentTabMiracleRingHighLightList() {} // 0x0000000181381A10-0x0000000181381BA0
	// [XID] // 0x00000001896E9770-0x00000001896E9790
	private bool CanItemBeMiracleRinged(ulong guid) => default; // 0x000000018137E810-0x000000018137E8C0
	// [XID] // 0x00000001896F0990-0x00000001896F09B0
	private void GenerateCurrentMiracleRingShowState() {} // 0x000000018137F240-0x000000018137F4B0
	// [XID] // 0x00000001896F81A0-0x00000001896F81C0
	private void OnNumChangeAtBagItemMiracleRing(MonoQuantityWidget quantityWidget) {} // 0x0000000181370C40-0x0000000181370D40
	// [XID] // 0x00000001896FFB00-0x00000001896FFB20
	private void ShowQuantityAtBagItemMiracleRing() {} // 0x0000000181374400-0x0000000181374740
}

