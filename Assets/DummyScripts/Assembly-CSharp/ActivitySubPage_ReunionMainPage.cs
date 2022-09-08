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

public sealed class ActivitySubPage_ReunionMainPage : BaseSubPageContext // TypeDefIndex: 29414
{
	// Fields
	private MonoActivityReunionMain _pageMono; // 0x178
	private int _currentSelectIdx; // 0x180
	private ReunionBriefInfo _briefInfo; // 0x188

	// Nested types
	public enum TabType // TypeDefIndex: 29415
	{
		SignIn = 0,
		Task = 1,
		Privilege = 2,
		Count = 3
	}

	// Constructors
	public ActivitySubPage_ReunionMainPage() {} // Dummy constructor
	public ActivitySubPage_ReunionMainPage(uint activityID, BasePageContext _parent, Transform _mountTrans) {} // 0x0000000181E844B0-0x0000000181E84590

	// Methods
	// [XID] // 0x00000001898BC740-0x00000001898BC760
	public override void SetupView() {} // 0x0000000181E84250-0x0000000181E844B0
	// [XID] // 0x00000001898C3DA0-0x00000001898C3DC0
	protected override void OnEnable() {} // 0x0000000181E83FF0-0x0000000181E84120
	// [XID] // 0x00000001898CB5C0-0x00000001898CB5E0
	public override void ClearView() {} // 0x0000000181E82C00-0x0000000181E82CA0
	// [XID] // 0x00000001898D2C90-0x00000001898D2CB0
	protected override void BindViewCallbacks() {} // 0x0000000181E826B0-0x0000000181E82A20
	// [XID] // 0x00000001898DA640-0x00000001898DA660
	protected override void BindRedPoints() {} // 0x0000000181E82500-0x0000000181E826B0
	// [XID] // 0x00000001898E2290-0x00000001898E22B0
	public override void OnParentFocusChangeed(bool focusOnParent) {} // 0x0000000181E83240-0x0000000181E83440
	// [XID] // 0x00000001898E9E70-0x00000001898E9E90
	private void OnRewardButtonClick() {} // 0x0000000181E83900-0x0000000181E83A50
	// [XID] // 0x00000001898F1600-0x00000001898F1620
	private void OnDescButtonClick() {} // 0x0000000181E83130-0x0000000181E83240
	// [XID] // 0x00000001898F8DE0-0x00000001898F8E00
	private void OnSignInButtonClick() {} // 0x0000000181E82A20-0x0000000181E82B00
	// [XID] // 0x0000000189900780-0x00000001899007A0
	private void OnTasksButtonClick() {} // 0x0000000181E83A50-0x0000000181E83B30
	// [XID] // 0x0000000189907ED0-0x0000000189907EF0
	private void OnPrivilegeButtonClick() {} // 0x0000000181E823C0-0x0000000181E824A0
	// [XID] // 0x000000018990F6C0-0x000000018990F6E0
	private void Refresh() {} // 0x0000000181E82170-0x0000000181E82270
	// [XID] // 0x0000000189917090-0x00000001899170B0
	private void RefreshFirstRewardBtnIcon() {} // 0x0000000181E81FE0-0x0000000181E82170
	// [XID] // 0x000000018991E7B0-0x000000018991E7D0
	private void SetRewardBtnIconOpen() {} // 0x0000000181E83440-0x0000000181E836A0
	// [XID] // 0x0000000189926050-0x0000000189926070
	private void RefreshTitleAndTime() {} // 0x0000000181E83B30-0x0000000181E83D40
	// [XID] // 0x000000018992D740-0x000000018992D760
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181E84120-0x0000000181E84250
	// [XID] // 0x0000000189934BD0-0x0000000189934BF0
	private void ShowFirstGiftClaimedDialog() {} // 0x0000000181E836A0-0x0000000181E837E0
	// [XID] // 0x000000018993C6C0-0x000000018993C6E0
	private void OnItemAddedNotify(List<SimpleItemStruct> itemList) {} // 0x0000000181E82B00-0x0000000181E82C00
	// [XID] // 0x0000000189943CD0-0x0000000189943CF0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181E82F10-0x0000000181E830D0
	// [XID] // 0x000000018994B1F0-0x000000018994B210
	private void RefreshPS4BtnText() {} // 0x0000000181E83D40-0x0000000181E83F00
	// [XID] // 0x0000000189952BE0-0x0000000189952C00
	private void RefreshIndexAndHighLight(bool gotoLeft) {} // 0x0000000181E837E0-0x0000000181E83900
	// [XID] // 0x000000018995A170-0x000000018995A190
	private void SetSlotActive(bool active) {} // 0x0000000181E82D90-0x0000000181E82EB0
	// [XID] // 0x0000000189961BA0-0x0000000189961BC0
	private void OnPSConfirmBtn() {} // 0x0000000181E822F0-0x0000000181E823C0
}

