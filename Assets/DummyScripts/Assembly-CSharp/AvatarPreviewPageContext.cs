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

public sealed class AvatarPreviewPageContext : BasePageContext, FilterReceiver // TypeDefIndex: 28803
{
	// Fields
	private MonoInLevelAvatarPreviewPage _pageMono; // 0x190
	private PreviewUISceneComponent _uiSceneComp; // 0x198
	private AvatarPreviewScreenDialogContext _dialog; // 0x1A0
	private List<AvatarCodexExcelConfig> _allAvatarList; // 0x1A8
	private Dictionary<uint, AvatarDataItem> _avatarDataItemDic; // 0x1B0
	private HashSet<uint> _ownAvatarSet; // 0x1B8
	private int _selectIconIndex; // 0x1C0
	private AvatarSortType _sortType; // 0x1C4
	private bool _isAsce; // 0x1C8
	private bool _isEmpty; // 0x1C9

	// Nested types
	private enum AvatarSortType // TypeDefIndex: 28804
	{
		Default = 0,
		Own = 1,
		Star = 2,
		Element = 3,
		Weapon = 4
	}

	// Constructors
	public AvatarPreviewPageContext() {} // 0x00000001828F3710-0x00000001828F3C30

	// Methods
	// [XID] // 0x000000018988E230-0x000000018988E250
	public override void ClearView() {} // 0x00000001828EF820-0x00000001828EF970
	// [XID] // 0x00000001898958E0-0x0000000189895900
	public override void SetupView() {} // 0x00000001828F3250-0x00000001828F3710
	// [XID] // 0x000000018989D000-0x000000018989D020
	protected override void BindViewCallbacks() {} // 0x00000001828EF410-0x00000001828EF700
	// [XID] // 0x00000001898A4880-0x00000001898A48A0
	private AvatarDataItem GetAvatarDataItem(uint avatarId) => default; // 0x00000001828F1BD0-0x00000001828F1FE0
	// [XID] // 0x00000001898ABD40-0x00000001898ABD60
	private List<ulong> GenerateGuidList() => default; // 0x00000001828F0050-0x00000001828F0260
	// [XID] // 0x00000001898B3470-0x00000001898B3490
	private void SetTalentRedPoint() {} // 0x00000001828F1280-0x00000001828F1380
	// [XID] // 0x00000001898BB150-0x00000001898BB170
	protected override void OnEnable() {} // 0x00000001828F2E10-0x00000001828F3100
	// [XID] // 0x00000001898C2500-0x00000001898C2520
	private void OnDetail() {} // 0x00000001828F03C0-0x00000001828F05F0
	// [XID] // 0x00000001898C9F20-0x00000001898C9F40
	private void RefreshAvatarIcon(Transform trans, int index) {} // 0x00000001828EF0C0-0x00000001828EF410
	// [XID] // 0x00000001898D15A0-0x00000001898D15C0
	void MoleMole.FilterReceiver.RefreshScreenAvatarPanel(List<ulong> screenAvatarList) {} // 0x00000001828F2130-0x00000001828F2540
	// [XID] // 0x00000001898D8DE0-0x00000001898D8E00
	void MoleMole.FilterReceiver.ChangeStateID(int id) {} // 0x00000001828F1FE0-0x00000001828F2090
	// [XID] // 0x00000001898E0AD0-0x00000001898E0AF0
	void MoleMole.FilterReceiver.ChangeToAvatarStateID() {} // 0x00000001828F2090-0x00000001828F2130
	// [XID] // 0x00000001898E8610-0x00000001898E8630
	void MoleMole.FilterReceiver.SaveScreenName(List<string> screenNameList) {} // 0x00000001828F2540-0x00000001828F25F0
	// [XID] // 0x00000001898EFDF0-0x00000001898EFE10
	private void OnAvatarIconSelect(int index, bool showEffect = false /* Metadata: 0x00B0E72B */) {} // 0x00000001828F2750-0x00000001828F2CF0
	// [XID] // 0x00000001898F7630-0x00000001898F7650
	private int CheckSlotSelect(uint avatarId) => default; // 0x00000001828F1A90-0x00000001828F1BD0
	// [XID] // 0x00000001898FED40-0x00000001898FED60
	private void SetLastSelectIcon() {} // 0x00000001828F3100-0x00000001828F3250
	// [XID] // 0x00000001899064E0-0x0000000189906500
	private void OnClose() {} // 0x00000001828F0260-0x00000001828F03C0
	// [XID] // 0x000000018990DF20-0x000000018990DF40
	private void SetupSortTypeDropdown() {} // 0x00000001828EFD00-0x00000001828F0050
	// [XID] // 0x0000000189915690-0x00000001899156B0
	private void OnSortTypeChange(int index) {} // 0x00000001828F0DB0-0x00000001828F1010
	// [XID] // 0x000000018991D0C0-0x000000018991D0E0
	private AvatarSortType SortDropdownIndexToType(int index) => default; // 0x00000001828F0CD0-0x00000001828F0DB0
	// [XID] // 0x0000000189924970-0x0000000189924990
	private void ChangeSortOrder() {} // 0x00000001828F1010-0x00000001828F1280
	// [XID] // 0x000000018992BF00-0x000000018992BF20
	private void OnArtPreviewBtnClick() {} // 0x00000001828EF9D0-0x00000001828EFB80
	// [XID] // 0x00000001899333F0-0x0000000189933410
	private void OnScreenBtnClick() {} // 0x00000001828EEE50-0x00000001828EF0C0
	// [XID] // 0x000000018993AFA0-0x000000018993AFC0
	private void RefreshChaDetails(AvatarDataItem avatarDataItem) {} // 0x00000001828F25F0-0x00000001828F26F0
	// [XID] // 0x00000001899420B0-0x00000001899420D0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001828F0650-0x00000001828F0C70
	// [XID] // 0x0000000189949AD0-0x0000000189949AF0
	private bool HandleSortInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001828F1800-0x00000001828F1A90
	// [XID] // 0x0000000189951560-0x0000000189951580
	private void SortList() {} // 0x00000001828EF700-0x00000001828EF820
	// [XID] // 0x0000000189958B70-0x0000000189958B90
	private int CompareAvatar(AvatarCodexExcelConfig x, AvatarCodexExcelConfig y) => default; // 0x00000001828F1380-0x00000001828F1800
	// [XID] // 0x00000001899601D0-0x00000001899601F0
	private int GetElementTypeNum(ElementType type) => default; // 0x00000001828F2CF0-0x00000001828F2E10
	// [XID] // 0x0000000189967C70-0x0000000189967C90
	private int GetWeaponTypeNum(WeaponType type) => default; // 0x00000001828EFB80-0x00000001828EFC70
}

