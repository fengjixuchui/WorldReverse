/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UniRx;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class EquipOverviewPageContext : BasePageContext // TypeDefIndex: 29022
{
	// Fields
	private const string AWAKEN_AFFIX_ITEM_PREFAB_PATH = "ART/UI/Menus/Widget/EquipOverview/AwakenAffixChangeRow"; // Metadata: 0x00B0E9A3
	private const int AWAKEN_NEED_FOOD_NUM = 1; // Metadata: 0x00B0E9DD
	private GameObject _awakenAffixPrefab; // 0x190
	private List<BagItemSlot> _awakenCandidates; // 0x198
	private BagItemSlot _selectedAwakenCandidate; // 0x1A0
	private ShopMaterial _needMaterial; // 0x1A8
	private Coroutine _awakenUpCoroutine; // 0x1B0
	private BagItem _item; // 0x1B8
	private MonoEquipOverviewPage _pageMono; // 0x1C0
	private EquipUISceneComponent _uiSceneComp; // 0x1C8
	private const int MAIN_PROP_NUM = 1; // Metadata: 0x00B0E9E1
	private List<ulong> _selectedGuid; // 0x1D0
	private Dictionary<uint, int> _selectedStoneDic; // 0x1D8
	private EquipPageType _type; // 0x1E0
	private EquipType _equipType; // 0x1E4
	private bool _showLevelUp; // 0x1E8
	private bool _isTrial; // 0x1E9
	private bool _hideStory; // 0x1EA
	private EquipPageShowType _showType; // 0x1EC
	private bool _selectPanelShow; // 0x1F0
	private bool _awakenBtnShow; // 0x1F1
	private bool _awakenMax; // 0x1F2
	private uint _selectTabIndex; // 0x1F4
	private int _selectSlotIndex; // 0x1F8
	private bool _sortDropdownShow; // 0x1FC
	private bool _fastAddDropdownShow; // 0x1FD
	private bool _handleInputEvents; // 0x1FE
	private List<BagItemSlot> _tempItemListForSortByLockState; // 0x200
	private const int INPUT_STATE_DEFAULT = 0; // Metadata: 0x00B0E9E5
	private const int INPUT_STATE_ITEMDETAIL = 1; // Metadata: 0x00B0E9E9
	private bool _isPressingConfirmButton; // 0x208
	private bool _isPressingMenuLeftButton; // 0x209
	private uint _storyId; // 0x20C
	private SortType _sortType; // 0x210
	private bool _isAsce; // 0x214
	private const int MAX_APPEND_PROP_NUM = 4; // Metadata: 0x00B0E9ED
	private const int MAX_LEVEL_UP_CANDIDATE_NUM = 6; // Metadata: 0x00B0E9F1
	private const int WEAPON_RARE_LEVEL = 4; // Metadata: 0x00B0E9F5
	private const int RELIQUARY_RARE_LEVEL = 5; // Metadata: 0x00B0E9F9
	private List<PropertyChange> _levelUpPropChange; // 0x218
	private List<BagItemSlot> _foodCandidates; // 0x220
	private List<BagItemSlot> _selectedCandidates; // 0x228
	private Dictionary<uint, int> _expItemDic; // 0x230
	private bool _canAddLevelUpWeapon; // 0x238
	private bool _canAddLevelUpRelic; // 0x239
	private uint _levelExpAdd; // 0x23C
	private uint _levelAdd; // 0x240
	private uint _expExceed; // 0x244
	private float _expWeaponSaleParam; // 0x248
	private bool _hasWeaponSale; // 0x24C
	private bool _inLevelUpAnim; // 0x24D
	private bool _needShowStarUp; // 0x24E
	private Coroutine _expAddAnimCoroutine; // 0x250
	private Coroutine _levelUpCoroutine; // 0x258
	private bool _deactiveItemTipAfterFadeOut; // 0x260
	private bool _candidateItemTipIsShow; // 0x261
	private List<int> _fastSortIndexList; // 0x268
	private int _fastAddScreenRank; // 0x270
	private const int TIP_RELIC_APPEND_NUM = 4; // Metadata: 0x00B0E9FD
	private List<PropertyChange> _propertyChange; // 0x278
	private List<Tuple<BagItemSlot, uint>> _weaponBreakNeedList; // 0x280
	private List<Tuple<BagItemSlot, uint>> _relicBreakNeedList; // 0x288
	private Coroutine _breakThroughCoroutine; // 0x290

	// Properties
	public EquipPageType equipType { /* [XID] */ /* 0x0000000189A0F920-0x0000000189A0F940 */ get => default; } // 0x00000001810DDFA0-0x00000001810DE040 

	// Nested types
	public enum EquipPageType // TypeDefIndex: 29023
	{
		Default = 0,
		CharacterToWeapon = 1,
		CharacterToRelic = 2,
		FromGacha = 3,
		FromActivity = 4
	}

	private enum EquipPageShowType // TypeDefIndex: 29024
	{
		Detail = 0,
		LevelUp = 1,
		StarUp = 2,
		Awaken = 3
	}

	// Constructors
	public EquipOverviewPageContext() {} // Dummy constructor
	public EquipOverviewPageContext(BagItem itemSlot, EquipPageType type = EquipPageType.Default /* Metadata: 0x00B0E99C */, bool isTrial = false /* Metadata: 0x00B0E9A0 */, bool hideStory = false /* Metadata: 0x00B0E9A1 */) {} // 0x00000001810F13C0-0x00000001810F1810

	// Methods
	// [XID] // 0x00000001899905A0-0x00000001899905C0
	private void OnWeaponAwakenNotify(Notify ntf) {} // 0x00000001810E7BB0-0x00000001810E7F50
	// [XID] // 0x0000000189998110-0x0000000189998130
	private void ShowEquipAwakenUpDialog(WeaponAwakenRsp rsp) {} // 0x00000001810D92B0-0x00000001810D95E0
	// [XID] // 0x000000018999F850-0x000000018999F870
	private void ShowAwaken() {} // 0x00000001810D3B80-0x00000001810D3E20
	// [XID] // 0x00000001899A7410-0x00000001899A7430
	private void RefreshWeaponAwaken() {} // 0x00000001810E6B00-0x00000001810E7410
	// [XID] // 0x00000001899AECE0-0x00000001899AED00
	private void RefreshWeaponAwakenView(WeaponItem weaponItem) {} // 0x00000001810E0CB0-0x00000001810E1380
	// [XID] // 0x00000001899B6060-0x00000001899B6080
	private MonoAwakenAffixItem GetAwakenAffixItemInstance() => default; // 0x00000001810D2F20-0x00000001810D3100
	// [XID] // 0x00000001899BDDC0-0x00000001899BDDE0
	private void RefreshAwakenCandidateItem(Transform trans, int index) {} // 0x00000001810D8610-0x00000001810D8980
	// [XID] // 0x00000001899C5500-0x00000001899C5520
	private void OnAwakeCandidateItemClicked(int index) {} // 0x00000001810DA3A0-0x00000001810DA6F0
	// [XID] // 0x00000001899CCBD0-0x00000001899CCBF0
	private void RefreshAwakenSelectItem(Transform trans, int index) {} // 0x00000001810EB750-0x00000001810EB960
	// [XID] // 0x00000001899D41D0-0x00000001899D41F0
	private void RefreshAwakenNeedCost() {} // 0x00000001810DBD90-0x00000001810DBFB0
	// [XID] // 0x00000001899DB7C0-0x00000001899DB7E0
	private void AwakenEquip() {} // 0x00000001810F08C0-0x00000001810F0DB0
	// [XID] // 0x00000001899E2EC0-0x00000001899E2EE0
	private bool CheckAndShowConfirmTip(WeaponItem target, WeaponItem food) => default; // 0x00000001810DF1A0-0x00000001810DF3A0
	// [XID] // 0x00000001899EA5D0-0x00000001899EA5F0
	private void ShowAwakenWeaponConfirmTip(string tipContent, WeaponItem target, WeaponItem food) {} // 0x00000001810E8060-0x00000001810E8280
	// [XID] // 0x00000001899F2040-0x00000001899F2060
	private void ConfirmAwakenWeapon(bool confirm, WeaponItem target, WeaponItem food) {} // 0x00000001810E3A40-0x00000001810E3BA0
	// [XID] // 0x00000001899F9780-0x00000001899F97A0
	private void GoldAffixSelectCallBack(WeaponItem weaponItem) {} // 0x00000001810E38F0-0x00000001810E3A40
	// [XID] // 0x0000000189A00AE0-0x0000000189A00B00
	private void SetAwakenMaxTip(bool active, string tipText = null) {} // 0x00000001810DA6F0-0x00000001810DA990
	// [XID] // 0x0000000189A083C0-0x0000000189A083E0
	private void StopAwakenUpCoroutine() {} // 0x00000001810D9E20-0x00000001810D9FE0
	// [XID] // 0x0000000189A16EC0-0x0000000189A16EE0
	public override void SetupView() {} // 0x00000001810F1100-0x00000001810F13C0
	// [XID] // 0x0000000189A1E560-0x0000000189A1E580
	private void RefrshActivityTips() {} // 0x00000001810E6390-0x00000001810E6690
	// [XID] // 0x0000000189A25C60-0x0000000189A25C80
	protected override void BindViewCallbacks() {} // 0x00000001810D3E20-0x00000001810D4550
	// [XID] // 0x0000000189A2D0C0-0x0000000189A2D0E0
	private void BindItemBackCallback() {} // 0x00000001810DE1E0-0x00000001810DE370
	// [XID] // 0x0000000189A34AA0-0x0000000189A34AC0
	private new void Close() {} // 0x00000001810D70B0-0x00000001810D7280
	// [XID] // 0x0000000189A3BE70-0x0000000189A3BE90
	public override void ClearView() {} // 0x00000001810D6EC0-0x00000001810D70B0
	// [XID] // 0x0000000189A43AC0-0x0000000189A43AE0
	public override bool OnNotify(Notify ntf) => default; // 0x00000001810EFA30-0x00000001810EFD30
	// [XID] // 0x0000000189A4AF10-0x0000000189A4AF30
	private void OnBagSlotUpdate() {} // 0x00000001810EC460-0x00000001810EC550
	// [XID] // 0x0000000189A52610-0x0000000189A52630
	private void OnChangeEquipLockState(Notify ntf) {} // 0x00000001810E9170-0x00000001810E9280
	// [XID] // 0x0000000189A59F80-0x0000000189A59FA0
	private void RemoveItemFromCandidate(ulong targetEquipGuid) {} // 0x00000001810E4C70-0x00000001810E5030
	// [XID] // 0x0000000189A61750-0x0000000189A61770
	protected override void OnEnable() {} // 0x00000001810EF930-0x00000001810EFA30
	// [XID] // 0x0000000189A69670-0x0000000189A69690
	private void ChangeDetailBtnStatus(bool focusItemDetail) {} // 0x00000001810F0120-0x00000001810F02C0
	// [XID] // 0x0000000189A70A00-0x0000000189A70A20
	private void ChangeSelectPanelBtnStatus(bool focusItemDetail) {} // 0x00000001810DE040-0x00000001810DE1E0
	// [XID] // 0x0000000189A78290-0x0000000189A782B0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001810E01B0-0x00000001810E0740
	// [XID] // 0x0000000189A7F8A0-0x0000000189A7F8C0
	private bool HandleDetailEvent(InputActionEvent actionEvent) => default; // 0x00000001810DF3A0-0x00000001810DF610
	// [XID] // 0x0000000189A875A0-0x0000000189A875C0
	private bool CanMoveSlot() => default; // 0x00000001810DEE90-0x00000001810DEF40
	// [XID] // 0x0000000189A8ED40-0x0000000189A8ED60
	private bool HandleLevelUpEvent(InputActionEvent actionEvent) => default; // 0x00000001810ECF60-0x00000001810EDAB0
	// [XID] // 0x0000000189A963B0-0x0000000189A963D0
	private void SetLevelUpItemLockState() {} // 0x00000001810D5F30-0x00000001810D60E0
	// [XID] // 0x0000000189A9D900-0x0000000189A9D920
	private void SetAwakenItemLockState() {} // 0x00000001810DEF40-0x00000001810DF0F0
	// [XID] // 0x0000000189AA51F0-0x0000000189AA5210
	private bool HandleStarlUpEvent(InputActionEvent actionEvent) => default; // 0x00000001810F0EC0-0x00000001810F1100
	// [XID] // 0x0000000189AAC9B0-0x0000000189AAC9D0
	private bool HandleAwakenEvent(InputActionEvent actionEvent) => default; // 0x00000001810D7FE0-0x00000001810D84D0
	// [XID] // 0x0000000189AB4290-0x0000000189AB42B0
	private void ShowSortDropdown() {} // 0x00000001810D9CB0-0x00000001810D9E20
	// [XID] // 0x0000000189ABBF90-0x0000000189ABBFB0
	private void OnSortTypeSelectConfirm() {} // 0x00000001810DEB00-0x00000001810DEC70
	// [XID] // 0x0000000189AC3760-0x0000000189AC3780
	private void MoveSortDropdownIndex(bool prevOrNext) {} // 0x00000001810DFF70-0x00000001810E00D0
	// [XID] // 0x0000000189ACAD90-0x0000000189ACADB0
	private void ShowFastAddDropdown() {} // 0x00000001810E5E50-0x00000001810E5FE0
	// [XID] // 0x0000000189AD2820-0x0000000189AD2840
	private void HideFastAddDropdown() {} // 0x00000001810DBB80-0x00000001810DBD00
	// [XID] // 0x0000000189ADA250-0x0000000189ADA270
	private void OnFastAddTypeSelectConfirm() {} // 0x00000001810EC820-0x00000001810EC9A0
	// [XID] // 0x0000000189AE1B30-0x0000000189AE1B50
	private void MoveFastAddDropdownIndex(bool prevOrNext) {} // 0x00000001810D1FE0-0x00000001810D2160
	// [XID] // 0x0000000189AE9320-0x0000000189AE9340
	private void SetupWeaponView() {} // 0x00000001810E09F0-0x00000001810E0CB0
	// [XID] // 0x0000000189AF10D0-0x0000000189AF10F0
	private void CheckIsOnlyShowTips() {} // 0x00000001810EB500-0x00000001810EB620
	// [XID] // 0x0000000189AF85F0-0x0000000189AF8610
	private void SetupReliquaryView() {} // 0x00000001810E1820-0x00000001810E1BC0
	// [XID] // 0x0000000189AFFC80-0x0000000189AFFCA0
	private void ShowItemTips() {} // 0x00000001810D8980-0x00000001810D8B30
	// [XID] // 0x0000000189B07230-0x0000000189B07250
	private void SetEquipSelectPanelActive(bool active, BagItemSlot selectItem = null) {} // 0x00000001810D60E0-0x00000001810D6960
	// [XID] // 0x0000000189B0EA30-0x0000000189B0EA50
	private void SetNoItemTip(bool active, string text = null) {} // 0x00000001810E2720-0x00000001810E28D0
	// [XID] // 0x0000000189B15DC0-0x0000000189B15DE0
	private void CheckShowBtnActive() {} // 0x00000001810DB5D0-0x00000001810DBAC0
	// [XID] // 0x0000000189B1D4F0-0x0000000189B1D510
	private void OnHelp() {} // 0x00000001810DDE00-0x00000001810DDFA0
	// [XID] // 0x0000000189B24D70-0x0000000189B24D90
	private void RefreshHelpBtnShow() {} // 0x00000001810E00D0-0x00000001810E01B0
	// [XID] // 0x0000000189B2C220-0x0000000189B2C240
	private void ShowNextTab(bool nextOrPrev) {} // 0x00000001810D2D90-0x00000001810D2F20
	// [XID] // 0x0000000189B337B0-0x0000000189B337D0
	private void SelectPrevSlot() {} // 0x00000001810E7F50-0x00000001810E8060
	// [XID] // 0x0000000189B3B0D0-0x0000000189B3B0F0
	private void SelectNextSlot() {} // 0x00000001810DD460-0x00000001810DD570
	// [XID] // 0x0000000189B428D0-0x0000000189B428F0
	private void SelectUpwardSlot() {} // 0x00000001810D84D0-0x00000001810D8610
	// [XID] // 0x0000000189B4A3F0-0x0000000189B4A410
	private void SelectBelowSlot() {} // 0x00000001810E5520-0x00000001810E5660
	// [XID] // 0x0000000189B51B90-0x0000000189B51BB0
	private int GetRealMoveSlotIndex(int index) => default; // 0x00000001810DED90-0x00000001810DEE90
	// [XID] // 0x0000000189B59390-0x0000000189B593B0
	private void SelectEquipScrollerSlot(int index) {} // 0x00000001810E5030-0x00000001810E53B0
	// [XID] // 0x0000000189B60C20-0x0000000189B60C40
	private void ShowAvatarSelectDialog() {} // 0x00000001810EE7B0-0x00000001810EE9D0
	// [XID] // 0x0000000189B68290-0x0000000189B682B0
	public void OnAvatarSelectDialogClose() {} // 0x00000001810E59B0-0x00000001810E5B00
	// [XID] // 0x0000000189B6F610-0x0000000189B6F630
	public void SetItemTipAndEquipBtnActive(bool activeItemTip, bool activeEquipBtn) {} // 0x00000001810ECDE0-0x00000001810ECF60
	// [XID] // 0x0000000189B76CB0-0x0000000189B76CD0
	private void RefreshEquipedAvatarIcon() {} // 0x00000001810F0550-0x00000001810F08C0
	// [XID] // 0x0000000189B7E220-0x0000000189B7E240
	private void RefreshCostText() {} // 0x00000001810EAF80-0x00000001810EB170
	// [XID] // 0x0000000189B85E20-0x0000000189B85E40
	public void PreCalcAllCost(ulong weaponGuid, ulong avatarGuid) {} // 0x00000001810D2160-0x00000001810D2330
	// [XID] // 0x0000000189B8CE70-0x0000000189B8CE90
	private void OnAvatarEquipChangedNotify(Notify ntf) {} // 0x00000001810E53B0-0x00000001810E5520
	// [XID] // 0x0000000189B94660-0x0000000189B94680
	private void RefreshShopMaterial(bool active = true /* Metadata: 0x00B0E9A2 */) {} // 0x00000001810E57E0-0x00000001810E5900
	// [XID] // 0x0000000189B9BCB0-0x0000000189B9BCD0
	private void RefreshCoinNum() {} // 0x00000001810D4550-0x00000001810D4650
	// [XID] // 0x0000000189BA3450-0x0000000189BA3470
	private void RefreshStoryBtnActive() {} // 0x00000001810E5C80-0x00000001810E5E50
	// [XID] // 0x0000000189BAA790-0x0000000189BAA7B0
	private void ShowStory() {} // 0x00000001810E40E0-0x00000001810E4210
	// [XID] // 0x0000000189BB1DF0-0x0000000189BB1E10
	private void SetupSortTypeDropdown() {} // 0x00000001810DCDA0-0x00000001810DCF90
	// [XID] // 0x0000000189BB91D0-0x0000000189BB91F0
	private void HideSortDropdown() {} // 0x00000001810EB300-0x00000001810EB500
	// [XID] // 0x0000000189BC0FC0-0x0000000189BC0FE0
	private SortType SortDropdownIndexToType(int index) => default; // 0x00000001810E4010-0x00000001810E40E0
	// [XID] // 0x0000000189BC8750-0x0000000189BC8770
	private void ChangeSortOrder() {} // 0x00000001810E4900-0x00000001810E4A30
	// [XID] // 0x0000000189BCFF90-0x0000000189BCFFB0
	private void OnSortTypeChange(int index) {} // 0x00000001810E4210-0x00000001810E4320
	// [XID] // 0x0000000189BD75D0-0x0000000189BD75F0
	private void SortLevelUpFoodList() {} // 0x00000001810DA200-0x00000001810DA3A0
	// [XID] // 0x0000000189BDF0D0-0x0000000189BDF0F0
	private void SortAwakenFoodList() {} // 0x00000001810EC300-0x00000001810EC460
	// [XID] // 0x00000001895EBD40-0x00000001895EBD60
	private void PostSortFoodCandidatesByLockState() {} // 0x00000001810DD5E0-0x00000001810DD690
	// [XID] // 0x00000001895F30E0-0x00000001895F3100
	private void PostSortAwakenCandidatesByLockState() {} // 0x00000001810DF0F0-0x00000001810DF1A0
	// [XID] // 0x00000001895FA940-0x00000001895FA960
	private void SortByLockState(List<BagItemSlot> list) {} // 0x00000001810EF060-0x00000001810EF310
	// [XID] // 0x00000001896022F0-0x0000000189602310
	private int CompareReliquaryItem(BagItemSlot x, BagItemSlot y) => default; // 0x00000001810EE240-0x00000001810EE6E0
	// [XID] // 0x0000000189609B10-0x0000000189609B30
	private int CompareWeaponItem(BagItemSlot x, BagItemSlot y) => default; // 0x00000001810DCF90-0x00000001810DD460
	// [XID] // 0x00000001896112A0-0x00000001896112C0
	private void OnWeaponUpgradeNotify(Notify ntf) {} // 0x00000001810E5FE0-0x00000001810E6390
	// [XID] // 0x0000000189618CB0-0x0000000189618CD0
	private void OnReliquaryUpgradeNotify(Notify ntf) {} // 0x00000001810D3100-0x00000001810D3490
	// [XID] // 0x00000001896201A0-0x00000001896201C0
	private void ShowLevelUp() {} // 0x00000001810E1C30-0x00000001810E2100
	// [XID] // 0x0000000189627610-0x0000000189627630
	private void RefreshWeaponLevelUp() {} // 0x00000001810D4EE0-0x00000001810D55D0
	// [XID] // 0x000000018962F130-0x000000018962F150
	private uint GetExpNeededForRank(WeaponLevelExcelConfig config, uint rank) => default; // 0x00000001810DBFB0-0x00000001810DC0E0
	// [XID] // 0x0000000189636AD0-0x0000000189636AF0
	private void CheckActivitySale(BagItem item) {} // 0x00000001810EB170-0x00000001810EB300
	// [XID] // 0x000000018963E000-0x000000018963E020
	private void ResetWeaponLevelUpPanel(WeaponItem item) {} // 0x00000001810D76A0-0x00000001810D7FE0
	// [XID] // 0x0000000189645990-0x00000001896459B0
	private void RefreshWeaponPropertyChange(WeaponItem item, uint addLevel) {} // 0x00000001810D27C0-0x00000001810D2CA0
	// [XID] // 0x000000018964D1A0-0x000000018964D1C0
	private void RefreshWeaponLevelUpNeedCost(WeaponItem item, uint addExp) {} // 0x00000001810E4A30-0x00000001810E4C70
	// [XID] // 0x0000000189654940-0x0000000189654960
	private void OnWeaponCandidateItemClicked(int index) {} // 0x00000001810D9950-0x00000001810D9CB0
	// [XID] // 0x000000018965C030-0x000000018965C050
	private void ShowCandidateItemTip(BagItemSlot itemSlot) {} // 0x00000001810E46F0-0x00000001810E4900
	// [XID] // 0x00000001896636F0-0x0000000189663710
	private void HideCandidateItemTip() {} // 0x00000001810EC130-0x00000001810EC300
	// [XID] // 0x000000018966B030-0x000000018966B050
	private void TryUpdateCandidateItemTip() {} // 0x00000001810E33B0-0x00000001810E3590
	// [XID] // 0x0000000189672C30-0x0000000189672C50
	private void DeactiveAfterFadeOut() {} // 0x00000001810D2330-0x00000001810D24D0
	// [XID] // 0x000000018967A330-0x000000018967A350
	private void CheckSelectWeaponQuality(WeaponItem selectItem, int index) {} // 0x00000001810EE6E0-0x00000001810EE7B0
	// [XID] // 0x0000000189681B80-0x0000000189681BA0
	private void AddSelectWeapon(int index) {} // 0x00000001810E95D0-0x00000001810E98B0
	// [XID] // 0x0000000189689610-0x0000000189689630
	private void OnWeaponMinusBtnClicked(int index) {} // 0x00000001810E2A50-0x00000001810E2D30
	// [XID] // 0x0000000189691230-0x0000000189691250
	private void RefreshRelicLevelUp() {} // 0x00000001810EBB70-0x00000001810EC130
	// [XID] // 0x0000000189698A20-0x0000000189698A40
	private void ResetRelicLevelUpPanel(ReliquaryItem item) {} // 0x00000001810DF7C0-0x00000001810DFF70
	// [XID] // 0x000000018969FE70-0x000000018969FE90
	private uint GetRelicItemAddExp(ReliquaryItem relicItem) => default; // 0x00000001810E8350-0x00000001810E8630
	// [XID] // 0x00000001896A70F0-0x00000001896A7110
	private uint GetRelicExpNeededForRank(uint level, uint rank) => default; // 0x00000001810E5B00-0x00000001810E5C80
	// [XID] // 0x00000001896AE710-0x00000001896AE730
	private void RefreshRelicPropertyChange(ReliquaryItem item, uint addLevel) {} // 0x00000001810EA3E0-0x00000001810EADC0
	// [XID] // 0x00000001896B5F30-0x00000001896B5F50
	private void RefreshRelicLevelUpNeedCost(ReliquaryItem item, uint addExp) {} // 0x00000001810DB390-0x00000001810DB5D0
	// [XID] // 0x00000001896BD0F0-0x00000001896BD110
	private void OnRelicCandidateItemClicked(int index) {} // 0x00000001810D1B20-0x00000001810D1E60
	// [XID] // 0x00000001896C45F0-0x00000001896C4610
	private void AddSelectRelic(int index) {} // 0x00000001810EC9A0-0x00000001810ECC80
	// [XID] // 0x00000001896CBC50-0x00000001896CBC70
	private void OnRelicMinusBtnClicked(int index) {} // 0x00000001810E98B0-0x00000001810E9B90
	// [XID] // 0x00000001896D2EF0-0x00000001896D2F10
	private void SelectExpItem(int index) {} // 0x00000001810D7350-0x00000001810D76A0
	// [XID] // 0x00000001896DAAC0-0x00000001896DAAE0
	private void IncSelectedExpItemCount(int index) {} // 0x00000001810E30B0-0x00000001810E33B0
	// [XID] // 0x00000001896E21F0-0x00000001896E2210
	private void DecSelectedExpItemCount(int index) {} // 0x00000001810D5BB0-0x00000001810D5F30
	// [XID] // 0x00000001896E9710-0x00000001896E9730
	private void SetBreakMaterialPreviewButtonShow() {} // 0x00000001810DB1C0-0x00000001810DB390
	// [XID] // 0x00000001896F0950-0x00000001896F0970
	private void ShowBreakMaterialPreview() {} // 0x00000001810E1590-0x00000001810E1820
	// [XID] // 0x00000001896F8160-0x00000001896F8180
	private void RefreshCandidateItem(Transform trans, int index) {} // 0x00000001810D6960-0x00000001810D6EC0
	// [XID] // 0x00000001896FFAC0-0x00000001896FFAE0
	private void RefreshSelectedItem(Transform trans, int index) {} // 0x00000001810EA0B0-0x00000001810EA3E0
	// [XID] // 0x0000000189707170-0x0000000189707190
	private void RefreshLevelUpPropChange(Transform trans, int index) {} // 0x00000001810D4AB0-0x00000001810D4DA0
	// [XID] // 0x000000018970EA30-0x000000018970EA50
	private void RefreshLevelUpOtherPropChange(Transform trans, int index) {} // 0x00000001810E2FE0-0x00000001810E30B0
	// [XID] // 0x0000000189715E30-0x0000000189715E50
	private void CheckEquipUpgrade() {} // 0x00000001810E6690-0x00000001810E6940
	// [XID] // 0x000000018971D890-0x000000018971D8B0
	private void RequestCalcWeaponUpgradeReturnItems() {} // 0x00000001810DE370-0x00000001810DE6A0
	// [XID] // 0x0000000189724C30-0x0000000189724C50
	private void OnGetCalcWeaponUpgradeReturnItemsResult(Notify ntf) {} // 0x00000001810EDD30-0x00000001810EDE10
	// [XID] // 0x000000018972C460-0x000000018972C480
	private void KeepOnWeaponUpgradeProcess(CalcWeaponUpgradeReturnItemsRsp rsp) {} // 0x00000001810D5A30-0x00000001810D5BB0
	// [XID] // 0x0000000189733B80-0x0000000189733BA0
	private bool WeaponUpgradeNeedTip(WeaponUpgradeTipInfo tipInfo) => default; // 0x00000001810EF310-0x00000001810EF410
	// [XID] // 0x000000018973B2A0-0x000000018973B2C0
	private WeaponUpgradeTipInfo CalculateTipInfo(CalcWeaponUpgradeReturnItemsRsp rsp) => default; // 0x00000001810DC650-0x00000001810DCA30
	// [XID] // 0x0000000189742C50-0x0000000189742C70
	private bool HasBeenAwakened(WeaponItem item) => default; // 0x00000001810DBAC0-0x00000001810DBB80
	// [IDTag] // 0x000000018974A950-0x000000018974A990
	// [XID] // 0x000000018974A950-0x000000018974A990
	private bool HasBeenLevelUped(WeaponItem item) => default; // 0x00000001810E5660-0x00000001810E5720
	// [IDTag] // 0x0000000189754E10-0x0000000189754E50
	// [XID] // 0x0000000189754E10-0x0000000189754E50
	private bool HasBeenLevelUped(ReliquaryItem item) => default; // 0x00000001810E5720-0x00000001810E57E0
	// [XID] // 0x000000018975F510-0x000000018975F530
	private void UpgradeEquip() {} // 0x00000001810DC0E0-0x00000001810DC490
	// [XID] // 0x00000001897669C0-0x00000001897669E0
	private float GetItemAddExp(BagItem item) => default; // 0x00000001810E4320-0x00000001810E44D0
	// [XID] // 0x000000018976DF70-0x000000018976DF90
	private float GetRealItemAddExp(BagItem item) => default; // 0x00000001810ECC80-0x00000001810ECD80
	// [XID] // 0x00000001897756F0-0x0000000189775710
	private float GetWeaponItemAddExp(WeaponItem weaponItem) => default; // 0x00000001810E8F40-0x00000001810E9170
	// [XID] // 0x000000018977CF30-0x000000018977CF50
	private uint GetMaterialItemAddExp(MaterialItem item) => default; // 0x00000001810DE6A0-0x00000001810DE800
	// [XID] // 0x0000000189784950-0x0000000189784970
	private uint GetItemBaseExp(BagItem item) => default; // 0x00000001810E3BA0-0x00000001810E3D70
	// [IDTag] // 0x000000018978BF20-0x000000018978BF60
	// [XID] // 0x000000018978BF20-0x000000018978BF60
	private void SetExpFillBar(uint curValue, uint postValue, uint maxValue) {} // 0x00000001810E93D0-0x00000001810E95D0
	// [XID] // 0x00000001897964A0-0x00000001897964C0
	private void SetLevelMaxTip(bool active, string tipText = null) {} // 0x00000001810E8900-0x00000001810E8BA0
	// [XID] // 0x000000018979E5F0-0x000000018979E610
	private void SetupFastAddDropdown() {} // 0x00000001810E2100-0x00000001810E2470
	// [XID] // 0x00000001897A5DB0-0x00000001897A5DD0
	private bool EquipTypeIsReliquary() => default; // 0x00000001810D24D0-0x00000001810D2580
	// [XID] // 0x00000001897AD320-0x00000001897AD340
	private bool EquipTypeIsWeapon() => default; // 0x00000001810D3490-0x00000001810D3540
	// [XID] // 0x00000001897B53B0-0x00000001897B53D0
	private void OnFastAddRankChange(int index) {} // 0x00000001810E5900-0x00000001810E59B0
	// [XID] // 0x00000001897BD000-0x00000001897BD020
	private void FastAddLevelUpCandidateByOtherSort() {} // 0x00000001810EECE0-0x00000001810EF060
	// [XID] // 0x00000001897C4380-0x00000001897C43A0
	private uint CalcMaxCandidatePutInNum(BagItem candidate) => default; // 0x00000001810E44D0-0x00000001810E46F0
	// [XID] // 0x00000001897CBBA0-0x00000001897CBBC0
	private bool CanAddMoreFood(int selectedIdx, int fastSortIdx, bool foodItemChange) => default; // 0x00000001810E6940-0x00000001810E6B00
	// [XID] // 0x00000001897D34D0-0x00000001897D34F0
	private void AddNewSelected(BagItemSlot candidateSlot, Transform candidate) {} // 0x00000001810E2470-0x00000001810E2720
	// [XID] // 0x00000001897DAF50-0x00000001897DAF70
	private bool IncExistingSelected(BagItemSlot selectedSlot, Transform selected) => default; // 0x00000001810D3540-0x00000001810D3750
	// [XID] // 0x00000001897E26C0-0x00000001897E26E0
	private void DoFastAddLevelUpCandidate() {} // 0x00000001810EE9D0-0x00000001810EECE0
	// [XID] // 0x00000001897E9E30-0x00000001897E9E50
	private uint CalcCurFeedExp() => default; // 0x00000001810DC490-0x00000001810DC650
	// [XID] // 0x00000001897F1A90-0x00000001897F1AB0
	private uint CalcMaxFeedExp() => default; // 0x00000001810E8630-0x00000001810E8900
	// [XID] // 0x00000001897F9220-0x00000001897F9240
	private void RefreshFastAddIndexList(int rankLevel) {} // 0x00000001810F02C0-0x00000001810F0550
	// [XID] // 0x00000001898007F0-0x0000000189800810
	private bool ItemCanFastAdd(BagItemSlot itemSlot) => default; // 0x00000001810DA090-0x00000001810DA200
	// [XID] // 0x0000000189807E70-0x0000000189807E90
	private bool ItemIsLocked(BagItemSlot itemSlot) => default; // 0x00000001810D2CA0-0x00000001810D2D90
	// [XID] // 0x000000018980F770-0x000000018980F790
	private int CompareFastAddWeaponItem(int indexL, int indexR) => default; // 0x00000001810E8BA0-0x00000001810E8F40
	// [XID] // 0x0000000189816E20-0x0000000189816E40
	private int CompareFastAddReliquaryItem(int indexL, int indexR) => default; // 0x00000001810D3750-0x00000001810D3B80
	// [XID] // 0x000000018981E690-0x000000018981E6B0
	private void ResolveFastAddIcon() {} // 0x00000001810E9E00-0x00000001810E9EF0
	// [XID] // 0x0000000189825B70-0x0000000189825B90
	private void SetPowerUp(uint powerUpRate) {} // 0x00000001810EDE10-0x00000001810EE240
	// [XID] // 0x000000018982D2A0-0x000000018982D2C0
	private void SetPowerUpLight(int index) {} // 0x00000001810D9790-0x00000001810D9950
	// [XID] // 0x0000000189834A00-0x0000000189834A20
	private void PlayExpAddAnimation(float startPer, float endPer, Action callback) {} // 0x00000001810D9640-0x00000001810D9790
	[DebuggerHidden] // 0x000000018983C0F0-0x000000018983C130
	// [XID] // 0x000000018983C0F0-0x000000018983C130
	private IEnumerator PlayExpAddAni(float startPer, float endPer, Action callback) => default; // 0x00000001810DEC70-0x00000001810DED90
	// [XID] // 0x0000000189846670-0x0000000189846690
	private void StopExpAddAnimCoroutine() {} // 0x00000001810E9EF0-0x00000001810E9FF0
	// [IDTag] // 0x000000018984DBE0-0x000000018984DC20
	// [XID] // 0x000000018984DBE0-0x000000018984DC20
	private void SetExpFillBar(float curPer, float postPer) {} // 0x00000001810E9280-0x00000001810E93D0
	// [XID] // 0x0000000189857DC0-0x0000000189857DE0
	private float GetCurrentExpFill() => default; // 0x00000001810E2D30-0x00000001810E2E30
	// [IDTag] // 0x000000018985EEB0-0x000000018985EEF0
	// [XID] // 0x000000018985EEB0-0x000000018985EEF0
	private float GetNewExpFill(WeaponItem item) => default; // 0x00000001810E37A0-0x00000001810E38F0
	// [IDTag] // 0x0000000189869830-0x0000000189869870
	// [XID] // 0x0000000189869830-0x0000000189869870
	private float GetNewExpFill(ReliquaryItem item) => default; // 0x00000001810E3590-0x00000001810E37A0
	// [XID] // 0x0000000189873B40-0x0000000189873B60
	private void PlayAddLevelTextAni(uint addLevel) {} // 0x00000001810DF610-0x00000001810DF760
	// [XID] // 0x000000018987B5F0-0x000000018987B610
	private void PlayLevelUpSuccessShow(Action refreshViewAction) {} // 0x00000001810DE800-0x00000001810DEB00
	// [XID] // 0x0000000189882790-0x00000001898827B0
	private void StopLevelUpCoroutine() {} // 0x00000001810D4DA0-0x00000001810D4EE0
	// [XID] // 0x0000000189889F60-0x0000000189889F80
	private void SelectEquipSelectionSlot(int index) {} // 0x00000001810E9FF0-0x00000001810EA0B0
	// [XID] // 0x00000001898913A0-0x00000001898913C0
	private void RefreshSlotSelectionState(MonoBagProxySlot slot, int index) {} // 0x00000001810DACD0-0x00000001810DAE00
	// [XID] // 0x0000000189898A10-0x0000000189898A30
	private void OnWeaponPromoteNotify(Notify ntf) {} // 0x00000001810EF4A0-0x00000001810EF930
	// [XID] // 0x000000018989FC30-0x000000018989FC50
	private void OnReliquaryPromoteNotify(Notify ntf) {} // 0x00000001810EC550-0x00000001810EC820
	// [XID] // 0x00000001898A7600-0x00000001898A7620
	private void ShowStarUp() {} // 0x00000001810E7410-0x00000001810E7BB0
	// [XID] // 0x00000001898AF020-0x00000001898AF040
	private void RefreshWeaponStarUp() {} // 0x00000001810DAE00-0x00000001810DB1C0
	// [XID] // 0x00000001898B64D0-0x00000001898B64F0
	private void ResetWeaponStarUpView(WeaponItem weaponItem) {} // 0x00000001810DD690-0x00000001810DDE00
	// [XID] // 0x00000001898BDCC0-0x00000001898BDCE0
	private int ResetWeaponBreakNeedList(WeaponItem weaponItem) => default; // 0x00000001810DCA30-0x00000001810DCDA0
	// [XID] // 0x00000001898C55C0-0x00000001898C55E0
	private void ResetMaxBreakLevelView(WeaponItem weaponItem) {} // 0x00000001810D4650-0x00000001810D4AB0
	// [XID] // 0x00000001898CCB40-0x00000001898CCB60
	private void RefreshStarUpCandidate(Transform trans, int index) {} // 0x00000001810EDAB0-0x00000001810EDD30
	// [XID] // 0x00000001898D4500-0x00000001898D4520
	private void OnWeaponNeedItemClicked(int index) {} // 0x00000001810D1E60-0x00000001810D1FE0
	// [XID] // 0x00000001898DBDA0-0x00000001898DBDC0
	private void RefreshWeaponStarUpPropItem(Transform trans, int index) {} // 0x00000001810D2580-0x00000001810D27C0
	// [XID] // 0x00000001898E3900-0x00000001898E3920
	private void RefreshWeaponStarUpOtherPropItem(Transform trans, int index) {} // 0x00000001810D7280-0x00000001810D7350
	// [XID] // 0x00000001898EB540-0x00000001898EB560
	private void OnSelectedWeaponBreakMaterialChange(Transform trans, bool isSelect) {} // 0x00000001810EB620-0x00000001810EB750
	// [XID] // 0x00000001898F2CA0-0x00000001898F2CC0
	private void ShowSelectedWeaponBreakMaterialDetail() {} // 0x00000001810E07A0-0x00000001810E09F0
	// [XID] // 0x00000001898FA490-0x00000001898FA4B0
	private void RefreshRelicStarUp() {} // 0x00000001810E1380-0x00000001810E1590
	// [XID] // 0x0000000189901DE0-0x0000000189901E00
	private void ResetRelicStarUpView(ReliquaryItem relicItem) {} // 0x00000001810D9FE0-0x00000001810DA090
	// [XID] // 0x0000000189909670-0x0000000189909690
	private void RefreshRelicBreakNeed(Transform trans, int index) {} // 0x00000001810E9B90-0x00000001810E9E00
	// [XID] // 0x0000000189910B00-0x0000000189910B20
	private void OnRelicNeedItemClicked(int index) {} // 0x00000001810E28D0-0x00000001810E2A50
	// [IDTag] // 0x00000001899186E0-0x0000000189918720
	// [XID] // 0x00000001899186E0-0x0000000189918720
	private void RefreshRelicStarUpPropChange(ReliquaryItem item) {} // 0x00000001810D8CF0-0x00000001810D92B0
	// [IDTag] // 0x0000000189922F80-0x0000000189922FC0
	// [XID] // 0x0000000189922F80-0x0000000189922FC0
	private void RefreshRelicStarUpPropChange(Transform trans, int index) {} // 0x00000001810D8B30-0x00000001810D8CF0
	// [XID] // 0x000000018992D840-0x000000018992D860
	private void RefreshRelicStarUpOtherPropChange(Transform trans, int index) {} // 0x00000001810E8280-0x00000001810E8350
	// [XID] // 0x0000000189934CD0-0x0000000189934CF0
	private void RefreshEquipStarUpNeedCost(uint needCoinCount) {} // 0x00000001810F0DB0-0x00000001810F0EC0
	// [XID] // 0x000000018993C7C0-0x000000018993C7E0
	private void SetPostBreakPropActive(bool active) {} // 0x00000001810EADC0-0x00000001810EAF80
	// [XID] // 0x0000000189943DF0-0x0000000189943E10
	private void SetStarUpTip(bool active, string tipText = null) {} // 0x00000001810EB960-0x00000001810EBB70
	// [XID] // 0x000000018994B310-0x000000018994B330
	private void SetWeaponStarMaxTip(bool active, string tipText = null) {} // 0x00000001810D5790-0x00000001810D5A30
	// [XID] // 0x0000000189952CC0-0x0000000189952CE0
	private void SetRelicStarMaxTip(bool active, string tipText = null) {} // 0x00000001810E3D70-0x00000001810E4010
	// [XID] // 0x000000018995A270-0x000000018995A290
	private void PromoteEquip() {} // 0x00000001810E2E30-0x00000001810E2FE0
	// [XID] // 0x0000000189961CA0-0x0000000189961CC0
	private void PromoteWeapon() {} // 0x00000001810EFD30-0x00000001810F00C0
	// [XID] // 0x0000000189969350-0x0000000189969370
	private void PromoteRelic() {} // 0x00000001810DA990-0x00000001810DACD0
	// [XID] // 0x0000000189970E10-0x0000000189970E30
	private void StopBreakThroughCoroutine() {} // 0x00000001810D55D0-0x00000001810D5790
}

