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

public sealed class ActivityWaterSpiritDialogContext : BaseDialogContext // TypeDefIndex: 30088
{
	// Fields
	private MonoActivityWaterSpiritDialog _dialogMono; // 0x178
	private uint _activityID; // 0x180
	private ActivityInfo _curActivityInfo; // 0x188
	private uint _finalQuestId; // 0x190
	private uint _toyWidgetId; // 0x194
	private uint _pushId; // 0x198
	private List<uint> _regionOrder; // 0x1A0
	private dialogTaskState _dialogTaskState; // 0x1A8
	private List<string> _recordTextList; // 0x1B0
	private RegionSearchExcelConfig _searchConfig; // 0x1B8
	private List<ActivityTask> _regionList; // 0x1C0
	private uint _finishedRegionCount; // 0x1C8
	private activityState _activityState; // 0x1CC
	private List<RewardItemConfig> _currRewardList; // 0x1D0
	private MainQuestExcelConfigProxy _questConfig; // 0x1D8
	private List<RewardItemConfig> _questReward; // 0x1F0

	// Nested types
	private enum activityState // TypeDefIndex: 30089
	{
		AreaExplore = 0,
		WaitFinalQuest = 1,
		AllFinish = 2
	}

	private enum dialogTaskState // TypeDefIndex: 30090
	{
		LeftRegionSearch = 0,
		RightQuest = 1
	}

	private struct ActivityTask // TypeDefIndex: 30091
	{
		// Fields
		public RegionSearchCondExcelConfig regionConfig; // 0x00
		public RegionSearchState searchState; // 0x08
		public uint progress; // 0x0C
		public uint openTime; // 0x10
	}

	// Constructors
	public ActivityWaterSpiritDialogContext() {} // Dummy constructor
	public ActivityWaterSpiritDialogContext(uint activityId) {} // 0x0000000183D2D350-0x0000000183D2D9E0

	// Methods
	// [XID] // 0x0000000189B34CE0-0x0000000189B34D00
	public override void SetupView() {} // 0x0000000183D2D130-0x0000000183D2D350
	// [XID] // 0x0000000189B3C550-0x0000000189B3C570
	public override void ClearView() {} // 0x0000000183D27F00-0x0000000183D27FB0
	// [XID] // 0x0000000189B441F0-0x0000000189B44210
	protected override void BindViewCallbacks() {} // 0x0000000183D279D0-0x0000000183D27CF0
	// [XID] // 0x0000000189B4B8A0-0x0000000189B4B8C0
	protected override void OnEnable() {} // 0x0000000183D2C510-0x0000000183D2C5D0
	// [XID] // 0x0000000189B52EF0-0x0000000189B52F10
	public override bool OnNotify(Notify ntf) => default; // 0x0000000183D2C5D0-0x0000000183D2C730
	// [XID] // 0x0000000189B5A8A0-0x0000000189B5A8C0
	protected override void BindRedPoints() {} // 0x0000000183D27780-0x0000000183D279D0
	// [XID] // 0x0000000189B61D50-0x0000000189B61D70
	private void ResetData() {} // 0x0000000183D2B450-0x0000000183D2B550
	// [XID] // 0x0000000189B69960-0x0000000189B69980
	private void RefreshData(bool isFirstTimeOpen = false /* Metadata: 0x00B107D0 */) {} // 0x0000000183D28E30-0x0000000183D29680
	// [XID] // 0x0000000189B70F80-0x0000000189B70FA0
	private void RefreshView() {} // 0x0000000183D2A4E0-0x0000000183D2B170
	// [XID] // 0x0000000189B78550-0x0000000189B78570
	private void RefreshRewardItem(Transform trans, int index) {} // 0x0000000183D28170-0x0000000183D28DA0
	// [XID] // 0x0000000189B7FAB0-0x0000000189B7FAD0
	private void RefreshRewardBagItem(Transform trans, int index) {} // 0x0000000183D2B1D0-0x0000000183D2B450
	// [XID] // 0x0000000189B87540-0x0000000189B87560
	private void RefreshQuestRewardSlot(Transform trans, int index) {} // 0x0000000183D2B550-0x0000000183D2B7F0
	// [XID] // 0x0000000189B8E690-0x0000000189B8E6B0
	private void OnGotoQuestButtonClicked() {} // 0x0000000183D2BD70-0x0000000183D2BEF0
	// [XID] // 0x0000000189B95B70-0x0000000189B95B90
	private void OnGotoBagButtonClicked() {} // 0x0000000183D2BBF0-0x0000000183D2BD70
	// [XID] // 0x0000000189B9D110-0x0000000189B9D130
	private void OnRecordButtonClicked() {} // 0x0000000183D2C070-0x0000000183D2C2A0
	// [XID] // 0x0000000189BA4A70-0x0000000189BA4A90
	private void OnTaskRegionSearchButtonClicked() {} // 0x0000000183D2BEF0-0x0000000183D2C010
	// [XID] // 0x0000000189BABD90-0x0000000189BABDB0
	private void OnTaskFinalQuestButtonClicked() {} // 0x0000000183D27CF0-0x0000000183D27F00
	// [XID] // 0x0000000189BB3420-0x0000000189BB3440
	private void OnRegionLocateBtnClicked(ActivityTask task) {} // 0x0000000183D2CE70-0x0000000183D2D130
	// [XID] // 0x0000000189BBAA00-0x0000000189BBAA20
	private void OnRegionRewardFetchBtnClicked(RegionSearchCondExcelConfig regionConfig) {} // 0x0000000183D27FB0-0x0000000183D28110
	// [XID] // 0x0000000189BC2A20-0x0000000189BC2A40
	private void OnCourseBtnClicked() {} // 0x0000000183D2C2A0-0x0000000183D2C480
	// [XID] // 0x0000000189BCA1E0-0x0000000189BCA200
	private void OnLockBtnClicked(ActivityTask task) {} // 0x0000000183D2B890-0x0000000183D2BBF0
	// [XID] // 0x0000000189BD1830-0x0000000189BD1850
	private void IFixDataRefreshPost() {} // 0x0000000183D2B7F0-0x0000000183D2B890
	// [IDTag] // 0x0000000189BD8E00-0x0000000189BD8E40
	// [XID] // 0x0000000189BD8E00-0x0000000189BD8E40
	private void RefreshJoystickButton() {} // 0x0000000183D2CD60-0x0000000183D2CE70
	// [IDTag] // 0x00000001895E8910-0x00000001895E8950
	// [XID] // 0x00000001895E8910-0x00000001895E8950
	private void RefreshJoystickButton(Transform trans, int index) {} // 0x0000000183D2C730-0x0000000183D2CD60
	// [XID] // 0x00000001895F2F40-0x00000001895F2F60
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183D296E0-0x0000000183D2A4E0
}

