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

public sealed class CharacterSelectDialogContext : BaseDialogContext, FilterReceiver // TypeDefIndex: 28884
{
	// Fields
	private MonoCharacterSelectDialog _dialogMono; // 0x178
	private List<ulong> _avatarList; // 0x180
	private int _selectIconIndex; // 0x188
	private SortType _sortType; // 0x18C
	private bool _isAsce; // 0x190
	private AvatarPreviewScreenDialogContext _dialog; // 0x198
	private CharacterPageContext _parentPage; // 0x1A0
	private List<ulong> _curTeamList; // 0x1A8
	private List<ulong> _filteredTeamListAll; // 0x1B0
	private List<ulong> _filteredListWithFocus; // 0x1B8
	private List<ulong> _filteredListWithoutFocus; // 0x1C0
	private bool _sortDropdownShow; // 0x1C8
	private bool _isFocus; // 0x1C9
	private List<string> _screenNameList; // 0x1D0

	// Constructors
	public CharacterSelectDialogContext() {} // Dummy constructor
	public CharacterSelectDialogContext(List<ulong> avatarList, List<string> screenNameList) {} // 0x0000000184B0CAC0-0x0000000184B0CC40

	// Methods
	// [XID] // 0x0000000189A0B170-0x0000000189A0B190
	public override void ClearView() {} // 0x0000000184B09080-0x0000000184B09120
	// [XID] // 0x0000000189A12AA0-0x0000000189A12AC0
	public override void SetupView() {} // 0x0000000184B0C490-0x0000000184B0CAC0
	// [XID] // 0x0000000189A19CD0-0x0000000189A19CF0
	protected override void BindViewCallbacks() {} // 0x0000000184B08DF0-0x0000000184B09080
	// [XID] // 0x0000000189A21340-0x0000000189A21360
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000184B09DE0-0x0000000184B0A280
	// [XID] // 0x0000000189A28960-0x0000000189A28980
	public override bool OnNotify(Notify ntf) => default; // 0x0000000184B0C230-0x0000000184B0C340
	// [XID] // 0x0000000189A2FF90-0x0000000189A2FFB0
	private void RefreshSort() {} // 0x0000000184B0A3A0-0x0000000184B0A5B0
	// [XID] // 0x0000000189A379E0-0x0000000189A37A00
	private void RreshFocusAvatar(ulong guid) {} // 0x0000000184B085A0-0x0000000184B089C0
	// [XID] // 0x0000000189A3F0B0-0x0000000189A3F0D0
	private void RefreshAvatarIcon(Transform trans, int index) {} // 0x0000000184B089C0-0x0000000184B08DF0
	// [XID] // 0x0000000189A46790-0x0000000189A467B0
	void MoleMole.FilterReceiver.RefreshScreenAvatarPanel(List<ulong> screenAvatarList) {} // 0x0000000184B0B5E0-0x0000000184B0B820
	// [XID] // 0x0000000189A4DFA0-0x0000000189A4DFC0
	private void OnAvatarIconSelect(int index) {} // 0x0000000184B0B9A0-0x0000000184B0C1A0
	// [XID] // 0x0000000189A55710-0x0000000189A55730
	private int CheckSlotSelect(ulong guid) => default; // 0x0000000184B0B160-0x0000000184B0B280
	// [XID] // 0x0000000189A5D090-0x0000000189A5D0B0
	private void SetLastSelectIcon() {} // 0x0000000184B0C340-0x0000000184B0C490
	// [XID] // 0x0000000189A64930-0x0000000189A64950
	private void OnClose() {} // 0x0000000184B09920-0x0000000184B099D0
	// [XID] // 0x0000000189A6C150-0x0000000189A6C170
	public void OnConfirmBtnClick() {} // 0x0000000184B07BF0-0x0000000184B07CD0
	// [XID] // 0x0000000189A738C0-0x0000000189A738E0
	private void SetupSortTypeDropdown() {} // 0x0000000184B09450-0x0000000184B09820
	// [XID] // 0x0000000189A7B440-0x0000000189A7B460
	private void OnSortTypeChange(int index) {} // 0x0000000184B0AB00-0x0000000184B0AD20
	// [XID] // 0x0000000189A82B00-0x0000000189A82B20
	private SortType SortDropdownIndexToType(int index) => default; // 0x0000000184B0A9E0-0x0000000184B0AB00
	// [XID] // 0x0000000189A8A4B0-0x0000000189A8A4D0
	private void SortAvatarList() {} // 0x0000000184B0A5B0-0x0000000184B0A9E0
	// [XID] // 0x0000000189A91CB0-0x0000000189A91CD0
	private int CompareAvatarItem(ulong x, ulong y) => default; // 0x0000000184B07F90-0x0000000184B085A0
	// [XID] // 0x0000000189A99780-0x0000000189A997A0
	private void ChangeSortOrder() {} // 0x0000000184B0AD20-0x0000000184B0AF30
	// [XID] // 0x0000000189AA07D0-0x0000000189AA07F0
	private void OnScreenBtnClick() {} // 0x0000000184B07D60-0x0000000184B07F90
	// [XID] // 0x0000000189AA7DD0-0x0000000189AA7DF0
	private void OnFocusToggleChanged(bool on) {} // 0x0000000184B0B280-0x0000000184B0B410
	// [XID] // 0x0000000189AAF8C0-0x0000000189AAF8E0
	void MoleMole.FilterReceiver.SaveScreenName(List<string> screenNameList) {} // 0x0000000184B0B820-0x0000000184B0B940
	// [XID] // 0x0000000189AB7170-0x0000000189AB7190
	void MoleMole.FilterReceiver.ChangeStateID(int id) {} // 0x0000000184B0B410-0x0000000184B0B4C0
	// [XID] // 0x0000000189ABEBC0-0x0000000189ABEBE0
	void MoleMole.FilterReceiver.ChangeToAvatarStateID() {} // 0x0000000184B0B4C0-0x0000000184B0B5E0
	// [XID] // 0x0000000189AC6730-0x0000000189AC6750
	private void SelectPrevSlot(int currIndex) {} // 0x0000000184B0B060-0x0000000184B0B160
	// [XID] // 0x0000000189ACDDA0-0x0000000189ACDDC0
	private void SelectNextSlot(int currIndex) {} // 0x0000000184B09820-0x0000000184B09920
	// [XID] // 0x0000000189AD5B60-0x0000000189AD5B80
	private void SelectUpwardSlot(int currIndex) {} // 0x0000000184B09120-0x0000000184B09250
	// [XID] // 0x0000000189ADD530-0x0000000189ADD550
	private void SelectBelowSlot(int currIndex) {} // 0x0000000184B0AF30-0x0000000184B0B060
	// [XID] // 0x0000000189AE4C90-0x0000000189AE4CB0
	private int GetRealMoveSlotIndex(int index) => default; // 0x0000000184B09B40-0x0000000184B09C20
	// [XID] // 0x0000000189AEC370-0x0000000189AEC390
	private void SelectAvatarScrollerSlot(int index) {} // 0x0000000184B0A280-0x0000000184B0A340
	// [XID] // 0x0000000189AF3D90-0x0000000189AF3DB0
	private void ShowSortDropdown() {} // 0x0000000184B09250-0x0000000184B093C0
	// [XID] // 0x0000000189AFB440-0x0000000189AFB460
	private void OnSortTypeSelectConfirm() {} // 0x0000000184B099D0-0x0000000184B09B40
	// [XID] // 0x0000000189B02B60-0x0000000189B02B80
	private void MoveSortDropdownIndex(bool prevOrNext) {} // 0x0000000184B09C80-0x0000000184B09DE0
}

