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
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarSelectDialogContext : BaseDialogContext // TypeDefIndex: 28813
{
	// Fields
	private MonoAvatarSelectDialog _dialogMono; // 0x178
	private BagItem _equipItem; // 0x180
	private ItemType _equipType; // 0x188
	private List<ulong> _avatarList; // 0x190
	private ulong _selectGuid; // 0x198
	private int _selectedIndex; // 0x1A0
	private EquipOverviewPageContext _parentPage; // 0x1A8
	private bool _replaceBtnShow; // 0x1B0
	private bool _sortDropdownShow; // 0x1B1
	public AvatarSelectMode currMode; // 0x1B4
	private UnityAction<ulong> currCallback; // 0x1B8
	private SortType _sortType; // 0x1C0
	private bool _isAsce; // 0x1C4

	// Nested types
	public enum AvatarSelectMode // TypeDefIndex: 28814
	{
		WeaponSelect = 0,
		Exploration = 1
	}

	// Constructors
	public AvatarSelectDialogContext(BagItem item) {} // 0x000000018324D3D0-0x000000018324D4F0
	public AvatarSelectDialogContext() {} // 0x000000018324D2D0-0x000000018324D3D0

	// Methods
	// [XID] // 0x0000000189B38070-0x0000000189B38090
	public void SetMode(AvatarSelectMode mode, UnityAction<ulong> callback = null) {} // 0x00000001832498E0-0x00000001832499B0
	// [XID] // 0x0000000189B3FAA0-0x0000000189B3FAC0
	public override void SetupView() {} // 0x000000018324CFA0-0x000000018324D2D0
	// [XID] // 0x0000000189B472E0-0x0000000189B47300
	protected override void BindViewCallbacks() {} // 0x00000001832499B0-0x0000000183249BE0
	// [XID] // 0x0000000189B4EB00-0x0000000189B4EB20
	public override void ClearView() {} // 0x0000000183249D70-0x0000000183249E50
	// [XID] // 0x0000000189B56360-0x0000000189B56380
	public override bool OnNotify(Notify ntf) => default; // 0x000000018324CE90-0x000000018324CFA0
	// [XID] // 0x0000000189B5DB00-0x0000000189B5DB20
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018324AED0-0x000000018324B0F0
	// [XID] // 0x0000000189B65080-0x0000000189B650A0
	private void SelectPrevSlot(int currIndex) {} // 0x000000018324C7C0-0x000000018324C8C0
	// [XID] // 0x0000000189B6C660-0x0000000189B6C680
	private void SelectNextSlot(int currIndex) {} // 0x000000018324A9C0-0x000000018324AAC0
	// [XID] // 0x0000000189B73DF0-0x0000000189B73E10
	private void SelectUpwardSlot(int currIndex) {} // 0x0000000183249E50-0x0000000183249F80
	// [XID] // 0x0000000189B7B460-0x0000000189B7B480
	private void SelectBelowSlot(int currIndex) {} // 0x000000018324C4E0-0x000000018324C610
	// [XID] // 0x0000000189B82DA0-0x0000000189B82DC0
	private int GetRealMoveSlotIndex(int index) => default; // 0x000000018324AC30-0x000000018324AD10
	// [XID] // 0x0000000189B8A3A0-0x0000000189B8A3C0
	private void SelectAvatarScrollerSlot(int index) {} // 0x000000018324B540-0x000000018324B600
	// [XID] // 0x0000000189B919A0-0x0000000189B919C0
	private void ShowSortDropdown() {} // 0x0000000183249F80-0x000000018324A0F0
	// [XID] // 0x0000000189B98DC0-0x0000000189B98DE0
	private void OnSortTypeSelectConfirm() {} // 0x000000018324AAC0-0x000000018324AC30
	// [XID] // 0x0000000189BA01A0-0x0000000189BA01C0
	private void MoveSortDropdownIndex(bool prevOrNext) {} // 0x000000018324AD70-0x000000018324AED0
	// [XID] // 0x0000000189BA79E0-0x0000000189BA7A00
	private void OnAvatarEquipChangedNotify(Notify ntf) {} // 0x000000018324C3E0-0x000000018324C4E0
	// [XID] // 0x0000000189BAED70-0x0000000189BAED90
	private void ScreenAvatarList(List<ulong> allAvatarList) {} // 0x000000018324B0F0-0x000000018324B540
	// [XID] // 0x0000000189BB6460-0x0000000189BB6480
	private void RefreshAvatarIcon(Transform trans, int index) {} // 0x0000000183249430-0x00000001832498E0
	// [XID] // 0x0000000189BBDAA0-0x0000000189BBDAC0
	private string GetExploringHint(AvatarDataItem avatarData) => default; // 0x000000018324C8C0-0x000000018324CA00
	// [XID] // 0x0000000189BC57A0-0x0000000189BC57C0
	private void OnAvatarIconClick(int index) {} // 0x000000018324C180-0x000000018324C3E0
	// [XID] // 0x0000000189BCD200-0x0000000189BCD220
	private void RefreshAvatarInfo() {} // 0x000000018324CB80-0x000000018324CCD0
	// [XID] // 0x0000000189BD4700-0x0000000189BD4720
	private void RefreshEquipInfo() {} // 0x000000018324CA00-0x000000018324CB20
	// [XID] // 0x0000000189BDC270-0x0000000189BDC290
	private void RefreshWeaponChangeTip(AvatarDataItem avatarData) {} // 0x000000018324BF60-0x000000018324C180
	// [XID] // 0x00000001895E8A90-0x00000001895E8AB0
	private void RefreshRelicChangeTip(AvatarDataItem avatarData) {} // 0x000000018324A0F0-0x000000018324A3A0
	// [XID] // 0x00000001895F0320-0x00000001895F0340
	private void SetEquipPanelShow(bool showPanel) {} // 0x000000018324C610-0x000000018324C7C0
	// [XID] // 0x00000001895F7D90-0x00000001895F7DB0
	private void SetReplaceBtn(bool interactable, string btnText = null, bool active = true /* Metadata: 0x00B0E755 */) {} // 0x0000000183249BE0-0x0000000183249D70
	// [XID] // 0x00000001895FF130-0x00000001895FF150
	private void OnConfirm() {} // 0x000000018324A430-0x000000018324A6F0
	// [XID] // 0x00000001896069D0-0x00000001896069F0
	private void CheckEquipEquiped(ulong equipGuid) {} // 0x000000018324B8D0-0x000000018324BCB0
	// [XID] // 0x000000018960E310-0x000000018960E330
	private bool CheckPlayerLevelEnough(BagItem item) => default; // 0x000000018324CCD0-0x000000018324CE00
	// [XID] // 0x00000001896159A0-0x00000001896159C0
	private void WearEquip(ulong equipGuid) {} // 0x000000018324B660-0x000000018324B7B0
	// [XID] // 0x000000018961D180-0x000000018961D1A0
	private void PreCalcAllCost() {} // 0x0000000183248E80-0x0000000183248F60
	// [XID] // 0x00000001896246B0-0x00000001896246D0
	private void SetupSortTypeDropdown() {} // 0x000000018324A6F0-0x000000018324A9C0
	// [XID] // 0x000000018962BDF0-0x000000018962BE10
	private SortType SortDropdownIndexToType(int index) => default; // 0x000000018324BCB0-0x000000018324BD80
	// [XID] // 0x0000000189633930-0x0000000189633950
	private void ChangeSortOrder() {} // 0x000000018324BE70-0x000000018324BF60
	// [XID] // 0x000000018963B210-0x000000018963B230
	private void OnSortTypeChange(int index) {} // 0x000000018324BD80-0x000000018324BE70
	// [XID] // 0x0000000189642940-0x0000000189642960
	private void SortAvatarList() {} // 0x000000018324B7B0-0x000000018324B8D0
	// [XID] // 0x000000018964A070-0x000000018964A090
	private int CompareAvatarItem(ulong x, ulong y) => default; // 0x0000000183248F60-0x0000000183249430
}

