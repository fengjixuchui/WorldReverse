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

public sealed class AvatarSequenceSelectDialogContext : BaseDialogContext, FilterReceiver // TypeDefIndex: 28820
{
	// Fields
	private MonoAvatarSequenceSelectDialog _dialogMono; // 0x178
	private uint _minSelectNum; // 0x180
	private uint _maxSelectNum; // 0x184
	private List<ulong> _avatarFilteredGuid; // 0x188
	private List<ulong> _avatarShowGuid; // 0x190
	private List<ulong> _avatarSelectedGuid; // 0x198
	private List<ulong> _avatarSortedGuid; // 0x1A0
	private SortType _sortType; // 0x1A8
	private bool _isAsce; // 0x1AC
	private FilterReceiver _receiver; // 0x1B0
	private bool _sortDropdownShow; // 0x1B8
	private int _selectIconIndex; // 0x1BC
	private AvatarPreviewScreenDialogContext _avatarPreviewDialog; // 0x1C0
	private ulong _lastSelectAvatarGuid; // 0x1C8

	// Constructors
	public AvatarSequenceSelectDialogContext() {} // Dummy constructor
	public AvatarSequenceSelectDialogContext(uint minSelectNum, uint maxSelectNum, FilterReceiver receiver, List<ulong> avatarSelectedGuid = null) {} // 0x00000001840CA540-0x00000001840CA740

	// Methods
	// [XID] // 0x0000000189724C70-0x0000000189724C90
	public void UpdateSeletedGuid(List<ulong> avatarSelectedGuid) {} // 0x00000001840C8CE0-0x00000001840C8DD0
	// [XID] // 0x000000018972C4A0-0x000000018972C4C0
	public override void SetupView() {} // 0x00000001840CA3C0-0x00000001840CA540
	// [XID] // 0x0000000189733BC0-0x0000000189733BE0
	protected override void BindViewCallbacks() {} // 0x00000001840C71C0-0x00000001840C7420
	// [XID] // 0x000000018973B2E0-0x000000018973B300
	private void RefreshAvatarList(List<ulong> newAvatarList = null) {} // 0x00000001840C8EC0-0x00000001840C9000
	// [XID] // 0x0000000189742C90-0x0000000189742CB0
	private void SortAvatar() {} // 0x00000001840C64D0-0x00000001840C68B0
	// [XID] // 0x000000018974A9B0-0x000000018974A9D0
	private void RefreshAvatarPanel() {} // 0x00000001840C7CD0-0x00000001840C7EA0
	// [XID] // 0x0000000189751A90-0x0000000189751AB0
	private void RefreshAvatarIcon(Transform trans, int index) {} // 0x00000001840C6E10-0x00000001840C71C0
	// [XID] // 0x0000000189759060-0x0000000189759080
	private void OnAvatarSelect(int index) {} // 0x00000001840C83C0-0x00000001840C8720
	// [XID] // 0x0000000189760CB0-0x0000000189760CD0
	private void OnAvatarNoRefresh() {} // 0x00000001840C9BD0-0x00000001840C9F40
	// [XID] // 0x0000000189768010-0x0000000189768030
	private bool IsPrioritized(ulong x) => default; // 0x00000001840C7690-0x00000001840C77B0
	// [XID] // 0x000000018976F560-0x000000018976F580
	private void ChangeSortOrder() {} // 0x00000001840C9200-0x00000001840C92D0
	// [XID] // 0x0000000189776F80-0x0000000189776FA0
	private void OnSortTypeChange(int index) {} // 0x00000001840C9120-0x00000001840C9200
	// [XID] // 0x000000018977E680-0x000000018977E6A0
	private SortType SortDropdownIndexToType(int index) => default; // 0x00000001840C9000-0x00000001840C9120
	// [XID] // 0x0000000189785E30-0x0000000189785E50
	private void SetupSortTypeDropdown() {} // 0x00000001840C7F30-0x00000001840C82C0
	// [XID] // 0x000000018978D4D0-0x000000018978D4F0
	private void OnFilterBtnClick() {} // 0x00000001840C68B0-0x00000001840C6AD0
	// [XID] // 0x00000001897948D0-0x00000001897948F0
	private void OnCloseBtnClick() {} // 0x00000001840C6D50-0x00000001840C6E10
	// [XID] // 0x000000018979CD20-0x000000018979CD40
	private void OnSaveBtnClick() {} // 0x00000001840C6B90-0x00000001840C6D50
	// [XID] // 0x00000001897A4140-0x00000001897A4160
	private void ClosePreviewDialog() {} // 0x00000001840C6AD0-0x00000001840C6B90
	// [XID] // 0x00000001897AB6E0-0x00000001897AB700
	void MoleMole.FilterReceiver.RefreshScreenAvatarPanel(List<ulong> screenAvatarList) {} // 0x00000001840C9650-0x00000001840C9710
	// [XID] // 0x00000001897B3530-0x00000001897B3550
	void MoleMole.FilterReceiver.SaveScreenName(List<string> screenNameList) {} // 0x00000001840C9710-0x00000001840C97C0
	// [XID] // 0x00000001897BB410-0x00000001897BB430
	void MoleMole.FilterReceiver.ChangeStateID(int id) {} // 0x00000001840C9500-0x00000001840C95B0
	// [XID] // 0x00000001897C2C50-0x00000001897C2C70
	void MoleMole.FilterReceiver.ChangeToAvatarStateID() {} // 0x00000001840C95B0-0x00000001840C9650
	// [XID] // 0x00000001897CA490-0x00000001897CA4B0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001840C8DD0-0x00000001840C8EC0
	// [XID] // 0x00000001897D1AB0-0x00000001897D1AD0
	public bool HandleDropdownInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001840C7BA0-0x00000001840C7CD0
	// [XID] // 0x00000001897D9930-0x00000001897D9950
	public bool HandleDefaultInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001840C9F40-0x00000001840CA3C0
	// [XID] // 0x00000001897E0C90-0x00000001897E0CB0
	private void SelectAvatarSlot() {} // 0x00000001840C97C0-0x00000001840C99E0
	// [XID] // 0x00000001897E82F0-0x00000001897E8310
	private void MoveSortDropdownIndex(bool prevOrNext) {} // 0x00000001840C8B80-0x00000001840C8CE0
	// [XID] // 0x00000001897F0010-0x00000001897F0030
	private void SelectPrevSlot(int currIndex) {} // 0x00000001840C9400-0x00000001840C9500
	// [XID] // 0x00000001897F7780-0x00000001897F77A0
	private void SelectNextSlot(int currIndex) {} // 0x00000001840C82C0-0x00000001840C83C0
	// [XID] // 0x00000001897FEE90-0x00000001897FEEB0
	private void SelectUpwardSlot(int currIndex) {} // 0x00000001840C7900-0x00000001840C7A30
	// [XID] // 0x0000000189806610-0x0000000189806630
	private void SelectBelowSlot(int currIndex) {} // 0x00000001840C92D0-0x00000001840C9400
	// [XID] // 0x000000018980DD10-0x000000018980DD30
	private int GetRealMoveSlotIndex(int index) => default; // 0x00000001840C8890-0x00000001840C8970
	// [XID] // 0x00000001898154B0-0x00000001898154D0
	private void HightlightAvatarSlot(int index) {} // 0x00000001840C8970-0x00000001840C8B20
	// [XID] // 0x000000018981CEF0-0x000000018981CF10
	private void RefreshBtnTextByGuid(ulong guid) {} // 0x00000001840C7420-0x00000001840C7690
	// [XID] // 0x0000000189824290-0x00000001898242B0
	private void SetLastSelectIcon() {} // 0x00000001840C9A40-0x00000001840C9BD0
	// [XID] // 0x000000018982BD60-0x000000018982BD80
	private void ShowSortDropdown() {} // 0x00000001840C7A30-0x00000001840C7BA0
	// [XID] // 0x00000001898332F0-0x0000000189833310
	private void OnSortTypeSelectConfirm() {} // 0x00000001840C8720-0x00000001840C8890
	// [XID] // 0x000000018983A760-0x000000018983A780
	private void TrySelectAvatarIcon() {} // 0x00000001840C77B0-0x00000001840C7900
}

