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

public sealed class AchievementPageContext : BasePageContext // TypeDefIndex: 28730
{
	// Fields
	private MonoAchievementPage _pageMono; // 0x190
	private int _curSelectedRowIndex; // 0x198
	private uint _curGoalRewardItemId; // 0x19C
	private Dictionary<uint, List<uint>> _goalId2AchievementDic; // 0x1A0
	private Dictionary<uint, uint> _preAchievementDic; // 0x1A8
	private Dictionary<uint, LevelOfAchievemet> _levelOfAchievementDic; // 0x1B0
	private List<Achievement> _unfinishedList; // 0x1B8
	private List<Achievement> _finishedList; // 0x1C0
	private List<Achievement> _rewardTakenList; // 0x1C8
	private bool _isInsidePage; // 0x1D0
	private int _curSelectOverviewSlotIndex; // 0x1D4
	private int _curSelectDetailIndex; // 0x1D8
	private const int OVERVIEW_PAGE = 0; // Metadata: 0x00B0E619
	private const int INSIDE_PAGE_LIST = 1; // Metadata: 0x00B0E61D
	private const int INSIDE_PAGE_REWARD = 2; // Metadata: 0x00B0E621
	private const int REWARD_DETAIL = 3; // Metadata: 0x00B0E625
	private List<AchievementGoalExcelConfig> _goalExcelList; // 0x1E0
	private List<Achievement> _curShowedAchievementsList; // 0x1E8
	private uint _goalRewardItemId; // 0x1F0
	private const string LEVEL_ICON_PATH = "UI_AchievementIcon_{0}_{1}"; // Metadata: 0x00B0E629
	private List<RewardItemConfig> _curRewardList; // 0x1F8

	// Nested types
	public class AchievementOrderComparer : IComparer<Achievement> // TypeDefIndex: 28731
	{
		// Constructors
		public AchievementOrderComparer() {} // 0x0000000182C918F0-0x0000000182C91950

		// Methods
		// [XID] // 0x00000001899F2080-0x00000001899F20A0
		public int Compare(Achievement left, Achievement right) => default; // 0x0000000182C91760-0x0000000182C918F0
	}

	public class AchievementIdOrderComparer : IComparer<uint> // TypeDefIndex: 28732
	{
		// Constructors
		public AchievementIdOrderComparer() {} // 0x0000000182C91700-0x0000000182C91760

		// Methods
		// [XID] // 0x00000001899F97C0-0x00000001899F97E0
		public int Compare(uint left, uint right) => default; // 0x0000000182C915D0-0x0000000182C91700
	}

	// Constructors
	public AchievementPageContext() {} // 0x0000000182C9AAE0-0x0000000182C9AD50

	// Methods
	// [XID] // 0x0000000189872540-0x0000000189872560
	public override void SetupView() {} // 0x0000000182C9AA10-0x0000000182C9AAE0
	// [XID] // 0x000000018987A1B0-0x000000018987A1D0
	protected override void BindViewCallbacks() {} // 0x0000000182C930B0-0x0000000182C93210
	// [XID] // 0x0000000189881350-0x0000000189881370
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182C9A4C0-0x0000000182C9A5C0
	// [XID] // 0x0000000189888920-0x0000000189888940
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182C95E70-0x0000000182C96150
	// [XID] // 0x000000018988FC60-0x000000018988FC80
	private bool HandleInsidePageListActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182C92420-0x0000000182C92600
	// [XID] // 0x0000000189897120-0x0000000189897140
	private bool HandleRewardDetailActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182C98AB0-0x0000000182C98BC0
	// [XID] // 0x000000018989E660-0x000000018989E680
	private bool HandleInsidePageRewardActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182C91F50-0x0000000182C920B0
	// [XID] // 0x00000001898A61C0-0x00000001898A61E0
	private void ShowRewardInfo() {} // 0x0000000182C9A5C0-0x0000000182C9A790
	// [XID] // 0x00000001898AD7B0-0x00000001898AD7D0
	private void JumpToRewardDetail() {} // 0x0000000182C93E90-0x0000000182C93FB0
	// [XID] // 0x00000001898B4CF0-0x00000001898B4D10
	private void BackToDetailList() {} // 0x0000000182C9A790-0x0000000182C9A8B0
	// [XID] // 0x00000001898BC800-0x00000001898BC820
	private void SetRewardItemSelected(int index, bool flg) {} // 0x0000000182C95C90-0x0000000182C95E10
	// [XID] // 0x00000001898C3E80-0x00000001898C3EA0
	private void OnFetchBtnPress() {} // 0x0000000182C93210-0x0000000182C933E0
	// [XID] // 0x00000001898CB660-0x00000001898CB680
	private void JumpToInsideList() {} // 0x0000000182C93FB0-0x0000000182C942C0
	// [XID] // 0x00000001898D2D70-0x00000001898D2D90
	private void JumpToDetailList(int index = -1 /* Metadata: 0x00B0E5FC */) {} // 0x0000000182C96DB0-0x0000000182C97520
	// [XID] // 0x00000001898DA700-0x00000001898DA720
	private void ChoosePrevDetailRow() {} // 0x0000000182C97710-0x0000000182C97E40
	// [XID] // 0x00000001898E2370-0x00000001898E2390
	private void ChooseNextDetailRow() {} // 0x0000000182C933E0-0x0000000182C937D0
	// [XID] // 0x00000001898E9F10-0x00000001898E9F30
	private void ChoosePrevListItem() {} // 0x0000000182C98680-0x0000000182C987C0
	// [XID] // 0x00000001898F16C0-0x00000001898F16E0
	private void ChooseNextListItem() {} // 0x0000000182C9A8B0-0x0000000182C9AA10
	// [XID] // 0x00000001898F8EA0-0x00000001898F8EC0
	private void SetScrollerItemActive(MonoGridScroller scroller, int index, bool active) {} // 0x0000000182C962B0-0x0000000182C964F0
	// [XID] // 0x0000000189900820-0x0000000189900840
	private void ChoosePrevOverviewSlot() {} // 0x0000000182C96150-0x0000000182C962B0
	// [XID] // 0x0000000189907FB0-0x0000000189907FD0
	private void ChooseNextOverviewSlot() {} // 0x0000000182C96850-0x0000000182C969D0
	// [XID] // 0x000000018990F7A0-0x000000018990F7C0
	private void ChoosePrevRowOverviewSlot() {} // 0x0000000182C94380-0x0000000182C94530
	// [XID] // 0x00000001899171D0-0x00000001899171F0
	private void ChooseNextRowOverviewSlot() {} // 0x0000000182C94530-0x0000000182C94750
	// [XID] // 0x000000018991E8B0-0x000000018991E8D0
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x0000000182C98DD0-0x0000000182C98F90
	// [XID] // 0x0000000189926150-0x0000000189926170
	private void OnCloseBtnClick() {} // 0x0000000182C92370-0x0000000182C92420
	// [XID] // 0x000000018992D880-0x000000018992D8A0
	private void InitAchievementPage() {} // 0x0000000182C922D0-0x0000000182C92370
	// [XID] // 0x0000000189934D10-0x0000000189934D30
	private void RefreshAchievementPage() {} // 0x0000000182C942C0-0x0000000182C94380
	// [XID] // 0x000000018993C800-0x000000018993C820
	private void InitOverviewPage(int index = 0 /* Metadata: 0x00B0E600 */) {} // 0x0000000182C98060-0x0000000182C98320
	// [XID] // 0x0000000189943E50-0x0000000189943E70
	private void RefreshOverviewPageText() {} // 0x0000000182C969D0-0x0000000182C96C20
	// [XID] // 0x000000018994B370-0x000000018994B390
	private void RefreshAchievementData() {} // 0x0000000182C95140-0x0000000182C95700
	// [XID] // 0x0000000189952D20-0x0000000189952D40
	private void RefreshOverviewScroller(int index = 0 /* Metadata: 0x00B0E604 */) {} // 0x0000000182C94CB0-0x0000000182C95140
	// [XID] // 0x000000018995A2D0-0x000000018995A2F0
	private void OnOverviewScrollerInit(Transform trans, int index) {} // 0x0000000182C95770-0x0000000182C95C90
	// [XID] // 0x0000000189961CE0-0x0000000189961D00
	private void ChangeToInsidePage() {} // 0x0000000182C98320-0x0000000182C98680
	// [XID] // 0x0000000189969390-0x00000001899693B0
	private void ChangeToOverviewPage(int index = 0 /* Metadata: 0x00B0E608 */) {} // 0x0000000182C96C20-0x0000000182C96DB0
	// [XID] // 0x0000000189970E50-0x0000000189970E70
	private void OnOverviewSlotClick(int index = 0 /* Metadata: 0x00B0E60C */) {} // 0x0000000182C920B0-0x0000000182C922D0
	// [XID] // 0x00000001899787B0-0x00000001899787D0
	private void InitInsidePageList(int index = 0 /* Metadata: 0x00B0E610 */) {} // 0x0000000182C99300-0x0000000182C996C0
	// [XID] // 0x000000018997F870-0x000000018997F890
	private void CalculateProgressValue(uint goalId, out int achievementCnt, out int finishedCnt, List<Achievement> curShowedAchievementsList = null) {
		achievementCnt = default;
		finishedCnt = default;
	} // 0x0000000182C937D0-0x0000000182C93E90
	// [XID] // 0x0000000189987220-0x0000000189987240
	private void OnInsidePageListScrollerInit(Transform trans, int index) {} // 0x0000000182C947E0-0x0000000182C94CB0
	// [XID] // 0x000000018998ECB0-0x000000018998ECD0
	private void OnInsidePageRowClick(int index = 0 /* Metadata: 0x00B0E614 */, bool force = false /* Metadata: 0x00B0E618 */) {} // 0x0000000182C92600-0x0000000182C930B0
	// [XID] // 0x00000001899968B0-0x00000001899968D0
	private void SortAchievementList(List<Achievement> list) {} // 0x0000000182C98F90-0x0000000182C99300
	// [XID] // 0x000000018999E370-0x000000018999E390
	private void OnGoalRewardIconInit(Transform trans, int index) {} // 0x0000000182C964F0-0x0000000182C96850
	// [XID] // 0x00000001899A5D30-0x00000001899A5D50
	private void OnInsidePageDetailScrollerInit(Transform trans, int index) {} // 0x0000000182C99860-0x0000000182C9A300
	// [XID] // 0x00000001899AD3D0-0x00000001899AD3F0
	private string GetProgressText(ProgressShowType type, uint curProgress, uint totalProgress) => default; // 0x0000000182C97520-0x0000000182C97710
	// [XID] // 0x00000001899B4C50-0x00000001899B4C70
	private void OnRewardListInit(Transform trans, int index) {} // 0x0000000182C987C0-0x0000000182C98AB0
	// [XID] // 0x00000001899BC350-0x00000001899BC370
	private void OnFetchRewardBtnClick(uint id) {} // 0x0000000182C97E40-0x0000000182C98060
	// [XID] // 0x00000001899C3D10-0x00000001899C3D30
	private void OnFetchGoalRewardBtnClick(uint id) {} // 0x0000000182C996C0-0x0000000182C99860
	// [XID] // 0x00000001899CB470-0x00000001899CB490
	private string GetTimeStrByTimeStamp(uint timeStamp) => default; // 0x0000000182C98BC0-0x0000000182C98D60
}

