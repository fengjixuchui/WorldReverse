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

public class ActivitySubPage_TrialAvatar : BaseSubPageContext // TypeDefIndex: 29433
{
	// Fields
	private MonoActivityCharacterTrial _pageMono; // 0x178
	private List<MonoImgTab> _avatarTabList; // 0x180
	private RepeatedMessageField<TrialAvatarActivityRewardDetailInfo> RewardInfoList; // 0x188
	private Dictionary<uint, uint> _avatarIndexIdToConfigId; // 0x190
	private int _selectTabIndex; // 0x198
	private uint _avatarIndexId; // 0x19C
	private uint _avatarConfigId; // 0x1A0
	private ActivityInfo activityInfo; // 0x1A8
	private uint _activityID; // 0x1B0
	private List<RewardItemConfig> _tempRewardList; // 0x1B8
	private int _slotItemIndex; // 0x1C0

	// Constructors
	public ActivitySubPage_TrialAvatar() {} // Dummy constructor
	public ActivitySubPage_TrialAvatar(uint activityId, BasePageContext _parent, Transform _mountTrans) {} // 0x0000000183828F50-0x00000001838290B0

	// Methods
	// [XID] // 0x0000000189824210-0x0000000189824230
	protected override void BindViewCallbacks() {} // 0x0000000183826100-0x0000000183826370
	// [XID] // 0x000000018982BCA0-0x000000018982BCC0
	public override void SetupView() {} // 0x0000000183828D60-0x0000000183828F50
	// [XID] // 0x0000000189833230-0x0000000189833250
	private void Refresh() {} // 0x0000000183825A50-0x0000000183825DE0
	// [XID] // 0x000000018983A6E0-0x000000018983A700
	private void InitTabItem(Transform trans, int index) {} // 0x0000000183825660-0x0000000183825A50
	// [XID] // 0x0000000189841CE0-0x0000000189841D00
	private void SetTabRedPoint() {} // 0x00000001838282B0-0x0000000183828450
	// [XID] // 0x00000001898491F0-0x0000000189849210
	private void SetImageTabState(int index) {} // 0x0000000183828450-0x00000001838285A0
	// [XID] // 0x00000001898509B0-0x00000001898509D0
	private void OnClickTab(int index) {} // 0x0000000183826370-0x00000001838264D0
	// [XID] // 0x0000000189857D40-0x0000000189857D60
	private void UpdateSelectAvatar() {} // 0x0000000183826720-0x0000000183826C50
	// [XID] // 0x000000018985EE30-0x000000018985EE50
	private void RefreshRewardItems(Transform trans, int index) {} // 0x00000001838264D0-0x0000000183826720
	// [XID] // 0x0000000189866610-0x0000000189866630
	private void OnClickTrial() {} // 0x0000000183827FB0-0x00000001838282B0
	// [XID] // 0x000000018986DF10-0x000000018986DF30
	private void OnClickFetch() {} // 0x00000001838286D0-0x00000001838287C0
	// [XID] // 0x00000001898752E0-0x0000000189875300
	private void OnClickBtnLookOver() {} // 0x0000000183825F70-0x0000000183826100
	// [XID] // 0x000000018987CEB0-0x000000018987CED0
	private void OnClickDes() {} // 0x0000000183825E60-0x0000000183825F70
	// [XID] // 0x0000000189883E50-0x0000000189883E70
	private void RefreshRewardButton() {} // 0x0000000183826FC0-0x0000000183827220
	// [XID] // 0x000000018988B4F0-0x000000018988B510
	public override bool OnNotify(Notify ntf) => default; // 0x00000001838288B0-0x0000000183828A20
	// [XID] // 0x0000000189892CB0-0x0000000189892CD0
	private void RefreshActivity(uint activityId) {} // 0x0000000183828B80-0x0000000183828C90
	// [XID] // 0x000000018989A310-0x000000018989A330
	private void ShowAvatar(uint configId) {} // 0x0000000183828C90-0x0000000183828D60
	// [XID] // 0x00000001898A1570-0x00000001898A1590
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001838276D0-0x0000000183827C80
	// [XID] // 0x00000001898A8DC0-0x00000001898A8DE0
	private void PreTab() {} // 0x00000001838285A0-0x00000001838286D0
	// [XID] // 0x00000001898B0760-0x00000001898B0780
	private void NextTab() {} // 0x0000000183828A20-0x0000000183828B80
	// [XID] // 0x00000001898B7D70-0x00000001898B7D90
	private void SelectSlotItem(bool prev) {} // 0x0000000183827220-0x0000000183827670
	// [XID] // 0x00000001898BF3E0-0x00000001898BF400
	private void RefreshCurrentItem(bool clear) {} // 0x0000000183826C50-0x0000000183826F30
	// [XID] // 0x00000001898C6D00-0x00000001898C6D20
	public override void OnParentFocusChangeed(bool focusOnParent) {} // 0x0000000183827C80-0x0000000183827FB0
}

