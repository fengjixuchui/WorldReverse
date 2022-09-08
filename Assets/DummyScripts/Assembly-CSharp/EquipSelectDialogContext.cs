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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EquipSelectDialogContext : BaseDialogContext // TypeDefIndex: 29040
{
	// Fields
	private MonoEquipSelectDialog _dialogMono; // 0x178
	private List<BagItemSlot> _totalRelicList; // 0x180
	private List<BagItemSlot> _itemList; // 0x188
	private UserLocalDataItem _userLocalData; // 0x190
	private EquipType _equipType; // 0x198
	private int _equipSelectSortTypeRelicIndex; // 0x19C
	private bool _isAsceRelic; // 0x1A0
	private SortType _sortTypeWeapon; // 0x1A4
	private bool _isAsceWeapon; // 0x1A8
	private int _selectedWeaponIndex; // 0x1AC
	private ulong _selectedGuid; // 0x1B0
	private BagItemSlot _currEquip; // 0x1B8
	private uint _selectedSetId; // 0x1C0
	private int _selectedRelicIndex; // 0x1C4
	private Dictionary<uint, List<BagItemSlot>> _relicSetDic; // 0x1C8
	private List<BagItemSlot> _currentFilteredSlot; // 0x1D0
	private List<uint> _relicSetDataList; // 0x1D8
	private bool _relicSetFilterOpen; // 0x1E0
	private CharacterPageContext _parentPage; // 0x1E8
	private bool _replaceBtnShow; // 0x1F0
	private bool _dischargeBtnShow; // 0x1F1
	private bool _sortDropdownShow; // 0x1F2
	private int _selectScreenIndex; // 0x1F4
	private List<string> _sortTypeFilterDefine; // 0x1F8
	private List<string> _sortPropFilterDefine; // 0x200
	private bool _isWeaponContrastShow; // 0x208
	private CharacterPageContext.ContrastButtonState _preState; // 0x20C

	// Properties
	public BagItemSlot currEquip { /* [XID] */ /* 0x0000000189B07210-0x0000000189B07230 */ get => default; } // 0x0000000181E71BC0-0x0000000181E71C70 
	public EquipType equipType { /* [XID] */ /* 0x0000000189B0EA10-0x0000000189B0EA30 */ get => default; } // 0x0000000181E72520-0x0000000181E725C0 

	// Constructors
	public EquipSelectDialogContext() {} // Dummy constructor
	public EquipSelectDialogContext(AvatarDataItem avatarData, EquipType equipType) {} // 0x0000000181E78870-0x0000000181E78EE0

	// Methods
	// [XID] // 0x0000000189B15DA0-0x0000000189B15DC0
	private void ReloadItemList() {} // 0x0000000181E77030-0x0000000181E77180
	// [XID] // 0x0000000189B1D4D0-0x0000000189B1D4F0
	protected override void OnEnable() {} // 0x0000000181E78360-0x0000000181E78420
	// [XID] // 0x0000000189B24D50-0x0000000189B24D70
	private void RefreshEquipSelectDialog() {} // 0x0000000181E71530-0x0000000181E71B30
	// [XID] // 0x0000000189B2C200-0x0000000189B2C220
	public override void SetupView() {} // 0x0000000181E787D0-0x0000000181E78870
	// [XID] // 0x0000000189B33790-0x0000000189B337B0
	public override void ClearView() {} // 0x0000000181E6EA70-0x0000000181E6EC70
	// [XID] // 0x0000000189B3B0B0-0x0000000189B3B0D0
	protected override void BindViewCallbacks() {} // 0x0000000181E6E150-0x0000000181E6E4A0
	// [XID] // 0x0000000189B428B0-0x0000000189B428D0
	private void SortRelicList(List<BagItemSlot> list, bool isAscend) {} // 0x0000000181E74030-0x0000000181E74170
	// [XID] // 0x0000000189B4A3D0-0x0000000189B4A3F0
	private string SortDropdownIndexToPropTypeStr(int index) => default; // 0x0000000181E6E060-0x0000000181E6E150
	// [XID] // 0x0000000189B51B70-0x0000000189B51B90
	private void OnSortDropdownClick(int index) {} // 0x0000000181E6E880-0x0000000181E6E980
	// [XID] // 0x0000000189B59370-0x0000000189B59390
	private bool IsPropDropdown(int index) => default; // 0x0000000181E72ED0-0x0000000181E73000
	// [XID] // 0x0000000189B60C00-0x0000000189B60C20
	private void OnClickRelicSetFilterBtn() {} // 0x0000000181E76470-0x0000000181E767E0
	// [XID] // 0x0000000189B68270-0x0000000189B68290
	private void ClearRelicFilter() {} // 0x0000000181E78580-0x0000000181E78670
	// [XID] // 0x0000000189B6F5F0-0x0000000189B6F610
	private void ShowRelicLeft(bool show) {} // 0x0000000181E74170-0x0000000181E742D0
	// [XID] // 0x0000000189B76C90-0x0000000189B76CB0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181E78420-0x0000000181E78580
	// [XID] // 0x0000000189B7E200-0x0000000189B7E220
	private void Refresh(bool updateSelectedGuid = true /* Metadata: 0x00B0EA59 */) {} // 0x0000000181E6D410-0x0000000181E6D4E0
	// [XID] // 0x0000000189B85E00-0x0000000189B85E20
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181E73000-0x0000000181E739F0
	// [XID] // 0x0000000189B8CE50-0x0000000189B8CE70
	private Dropdown GetCurrentDropdown() => default; // 0x0000000181E6E980-0x0000000181E6EA70
	// [XID] // 0x0000000189B94640-0x0000000189B94660
	private void SelectPrevSlot(int currIndex) {} // 0x0000000181E76EB0-0x0000000181E77030
	// [XID] // 0x0000000189B9BC90-0x0000000189B9BCB0
	private void SelectNextSlot(int currIndex) {} // 0x0000000181E71EE0-0x0000000181E72060
	// [XID] // 0x0000000189BA3430-0x0000000189BA3450
	private void SelectUpwardSlot(int currIndex) {} // 0x0000000181E6FEE0-0x0000000181E70080
	// [XID] // 0x0000000189BAA770-0x0000000189BAA790
	private void SelectBelowSlot(int currIndex) {} // 0x0000000181E762D0-0x0000000181E76470
	// [XID] // 0x0000000189BB1DD0-0x0000000189BB1DF0
	private int GetRealMoveSlotIndex(int index) => default; // 0x0000000181E72AE0-0x0000000181E72BD0
	// [XID] // 0x0000000189BB91B0-0x0000000189BB91D0
	private void SelectEquipScrollerSlot(int index) {} // 0x0000000181E76040-0x0000000181E76120
	// [XID] // 0x0000000189BC0FA0-0x0000000189BC0FC0
	private void ShowSortDropdown() {} // 0x0000000181E70B30-0x0000000181E70CD0
	// [XID] // 0x0000000189BC8730-0x0000000189BC8750
	private void OnSortTypeSelectConfirm() {} // 0x0000000181E72730-0x0000000181E72880
	// [XID] // 0x0000000189BCFF70-0x0000000189BCFF90
	private void MoveSortDropdownIndex(bool prevOrNext) {} // 0x0000000181E72D80-0x0000000181E72ED0
	// [XID] // 0x0000000189BD75B0-0x0000000189BD75D0
	private void MoveScreenPanelIndex(bool prevOrNext) {} // 0x0000000181E6EC70-0x0000000181E6EF50
	// [XID] // 0x0000000189BDF0B0-0x0000000189BDF0D0
	private void OnScreenRowSelect() {} // 0x0000000181E70670-0x0000000181E70900
	// [XID] // 0x00000001895EBD20-0x00000001895EBD40
	private void PlayEquipChangeAudio(object[] ntf) {} // 0x0000000181E77950-0x0000000181E77B90
	// [XID] // 0x00000001895F30C0-0x00000001895F30E0
	private void RefreshWeapon(bool updateSelectedGuid = true /* Metadata: 0x00B0EA5A */) {} // 0x0000000181E78670-0x0000000181E787D0
	// [XID] // 0x00000001895FA920-0x00000001895FA940
	private void RefreshWeaponScroller() {} // 0x0000000181E76D20-0x0000000181E76EB0
	// [XID] // 0x00000001896022D0-0x00000001896022F0
	private void SelectInitWeaponItem() {} // 0x0000000181E77710-0x0000000181E77950
	// [XID] // 0x0000000189609AF0-0x0000000189609B10
	private void OnClose() {} // 0x0000000181E725C0-0x0000000181E72730
	// [XID] // 0x0000000189611280-0x00000001896112A0
	private void RefreshItemSlot(Transform trans, int index) {} // 0x0000000181E72880-0x0000000181E72AE0
	// [XID] // 0x0000000189618C90-0x0000000189618CB0
	private void SetAvatarIconOfItem(Image avatarIcon, BagItem item) {} // 0x0000000181E74CD0-0x0000000181E74F00
	// [XID] // 0x0000000189620180-0x00000001896201A0
	private void OnSlotClicked(int index) {} // 0x0000000181E6FBD0-0x0000000181E6FEE0
	// [XID] // 0x00000001896275F0-0x0000000189627610
	private void SetWeaponReplaceStyle() {} // 0x0000000181E70280-0x0000000181E70670
	// [XID] // 0x000000018962F110-0x000000018962F130
	private void ReplaceEquip() {} // 0x0000000181E73A50-0x0000000181E73D90
	// [XID] // 0x0000000189636AB0-0x0000000189636AD0
	private void LockEquip() {} // 0x0000000181E75280-0x0000000181E753C0
	// [XID] // 0x000000018963DFE0-0x000000018963E000
	private void CheckEquipEquiped(ulong equipGuid) {} // 0x0000000181E74F00-0x0000000181E75280
	// [XID] // 0x0000000189645970-0x0000000189645990
	private string GetEquipedAvatarName(ulong equipGuid) => default; // 0x0000000181E75A50-0x0000000181E75C10
	// [XID] // 0x000000018964D180-0x000000018964D1A0
	private bool CheckPlayerLevelEnough(BagItem item) => default; // 0x0000000181E781A0-0x0000000181E782D0
	// [XID] // 0x0000000189654920-0x0000000189654940
	private void WearEquip(ulong equipGuid) {} // 0x0000000181E73E40-0x0000000181E74030
	// [XID] // 0x000000018965C010-0x000000018965C030
	private void TakeOffEquip() {} // 0x0000000181E75C10-0x0000000181E75E80
	// [XID] // 0x00000001896636D0-0x00000001896636F0
	private void ChangeSortOrder() {} // 0x0000000181E75E80-0x0000000181E76040
	// [XID] // 0x000000018966B010-0x000000018966B030
	private void SelectInitRelicItem() {} // 0x0000000181E71230-0x0000000181E71470
	// [XID] // 0x0000000189672C10-0x0000000189672C30
	private void FillRelicSlot(bool updateSelectedGuid = true /* Metadata: 0x00B0EA5B */) {} // 0x0000000181E747A0-0x0000000181E74A80
	// [XID] // 0x000000018967A310-0x000000018967A330
	private void UpdateCurrentFilteredSlots() {} // 0x0000000181E75830-0x0000000181E75A50
	// [XID] // 0x0000000189681B60-0x0000000189681B80
	private void RefreshFilteredSlotsRelatedUIs() {} // 0x0000000181E77BF0-0x0000000181E77E90
	// [XID] // 0x00000001896895F0-0x0000000189689610
	private List<BagItemSlot> GetCurrentFilteredSlots() => default; // 0x0000000181E73D90-0x0000000181E73E40
	// [XID] // 0x0000000189691210-0x0000000189691230
	private void SetupSortDropdown(EquipType equipType) {} // 0x0000000181E70FD0-0x0000000181E71230
	// [XID] // 0x0000000189698A00-0x0000000189698A20
	private List<string> ConvertTextKeyToText(List<string> keys) => default; // 0x0000000181E6EF50-0x0000000181E6F110
	// [XID] // 0x000000018969FE50-0x000000018969FE70
	private void SetupSortTypeDropdown(EquipType equipType) {} // 0x0000000181E71C70-0x0000000181E71EE0
	// [XID] // 0x00000001896A70D0-0x00000001896A70F0
	private void OnWeaponSortDropdownClick(int index) {} // 0x0000000181E6F110-0x0000000181E6F220
	// [XID] // 0x00000001896AE6F0-0x00000001896AE710
	private SortType SortDropdownIndexToType(int index) => default; // 0x0000000181E753C0-0x0000000181E75490
	// [XID] // 0x00000001896B5F10-0x00000001896B5F30
	private void SetScreenBtnIcon(bool isDetailStyle) {} // 0x0000000181E77180-0x0000000181E77250
	// [XID] // 0x00000001896BD0D0-0x00000001896BD0F0
	private void ResetSelectPanel() {} // 0x0000000181E70080-0x0000000181E70220
	// [XID] // 0x00000001896C45D0-0x00000001896C45F0
	private void SetReplaceBtn(bool interactable, string btnText = null, bool active = true /* Metadata: 0x00B0EA5C */) {} // 0x0000000181E6E4A0-0x0000000181E6E7A0
	// [XID] // 0x00000001896CBC30-0x00000001896CBC50
	private void SetPromoteBtnForRelic(bool active, bool interactable = true /* Metadata: 0x00B0EA5D */, BagItem bagItem = null) {} // 0x0000000181E6F220-0x0000000181E6F520
	// [XID] // 0x00000001896D2ED0-0x00000001896D2EF0
	private void SetPromoteBtnForWeapon(bool active, bool interactable = true /* Metadata: 0x00B0EA5E */, BagItem bagItem = null) {} // 0x0000000181E70CD0-0x0000000181E70FD0
	// [XID] // 0x00000001896DAAA0-0x00000001896DAAC0
	private void SetScreeningRowActive(uint selectedSetId) {} // 0x0000000181E77E90-0x0000000181E781A0
	// [XID] // 0x00000001896E21D0-0x00000001896E21F0
	private void InitRelicTab() {} // 0x0000000181E72BD0-0x0000000181E72D20
	// [XID] // 0x00000001896E96F0-0x00000001896E9710
	private void OnRelicTabChange(int tab) {} // 0x0000000181E6F520-0x0000000181E6F5E0
	// [XID] // 0x00000001896F0930-0x00000001896F0950
	private void OnSelectRelicPositionTab() {} // 0x0000000181E70900-0x0000000181E70B30
	// [XID] // 0x00000001896F8140-0x00000001896F8160
	private void OnSelectRelicSetTab() {} // 0x0000000181E6F970-0x0000000181E6FA80
	// [XID] // 0x00000001896FFAA0-0x00000001896FFAC0
	private void OnRelicSubTypeChange(int tab) {} // 0x0000000181E71470-0x0000000181E71530
	// [XID] // 0x0000000189707150-0x0000000189707170
	private void SetupRelicSet() {} // 0x0000000181E6F5E0-0x0000000181E6F970
	// [XID] // 0x000000018970EA10-0x000000018970EA30
	private int CompareSetIndex(uint x, uint y) => default; // 0x0000000181E74A80-0x0000000181E74CD0
	// [XID] // 0x0000000189715E10-0x0000000189715E30
	private void RefreshRelicScreeningButtons(Transform trans, int index) {} // 0x0000000181E75490-0x0000000181E75830
	// [XID] // 0x000000018971D870-0x000000018971D890
	private BagItemSlot GetCurrEquip() => default; // 0x0000000181E6FA80-0x0000000181E6FBD0
	// [XID] // 0x0000000189724C10-0x0000000189724C30
	private void RefreshRelic(bool updateSelectedGuid = true /* Metadata: 0x00B0EA5F */) {} // 0x0000000181E775C0-0x0000000181E77710
	// [XID] // 0x000000018972C440-0x000000018972C460
	private void UpdateSelectedGuid() {} // 0x0000000181E6E7A0-0x0000000181E6E880
	// [XID] // 0x0000000189733B60-0x0000000189733B80
	private void RefreshRelicReplaceStyle() {} // 0x0000000181E6D4E0-0x0000000181E6D5A0
	// [XID] // 0x000000018973B280-0x000000018973B2A0
	private void RefreshRelicSlot(Transform trans, int index) {} // 0x0000000181E767E0-0x0000000181E76A70
	// [XID] // 0x0000000189742C30-0x0000000189742C50
	private void OnRelicSetSlotClicked(int index) {} // 0x0000000181E72060-0x0000000181E72520
	// [XID] // 0x000000018974A930-0x000000018974A950
	private void SetRelicReplaceStyle(List<BagItemSlot> itemList, int selectedIndex) {} // 0x0000000181E742D0-0x0000000181E747A0
	// [XID] // 0x0000000189751A50-0x0000000189751A70
	private void OnRelicFilterRowClick(uint setId) {} // 0x0000000181E76A70-0x0000000181E76C60
	// [XID] // 0x0000000189759020-0x0000000189759040
	private void RefreshRelicSet() {} // 0x0000000181E77250-0x0000000181E775C0
	// [XID] // 0x0000000189760C90-0x0000000189760CB0
	private void ChangeRelicType(EquipType equipType) {} // 0x0000000181E6DAA0-0x0000000181E6DBE0
	// [XID] // 0x0000000189767FD0-0x0000000189767FF0
	private void BindRelicTabRP() {} // 0x0000000181E76120-0x0000000181E762D0
	// [XID] // 0x000000018976F520-0x000000018976F540
	public void SetWeaponContrastBtnState(CharacterPageContext.ContrastButtonState state) {} // 0x0000000181E6D5A0-0x0000000181E6DAA0
	// [XID] // 0x0000000189776F60-0x0000000189776F80
	private void ShowWeaponContrast() {} // 0x0000000181E6DFA0-0x0000000181E6E060
	// [XID] // 0x000000018977E640-0x000000018977E660
	private void HideWeaponContrast() {} // 0x0000000181E76C60-0x0000000181E76D20
	// [XID] // 0x0000000189785DF0-0x0000000189785E10
	public void SetRelicContrastBtnState(CharacterPageContext.ContrastButtonState state) {} // 0x0000000181E6DBE0-0x0000000181E6DFA0
}

