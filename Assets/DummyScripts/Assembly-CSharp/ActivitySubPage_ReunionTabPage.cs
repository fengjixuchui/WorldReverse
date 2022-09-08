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

public sealed class ActivitySubPage_ReunionTabPage : BasePageContext // TypeDefIndex: 29416
{
	// Fields
	private MonoActivityReunionTabPage _pageMono; // 0x190
	private MonoActivityReunionTabPage_SignIn _signInMono; // 0x198
	private MonoActivityReunionTabPage_Task _taskMono; // 0x1A0
	private MonoActivityReunionTabPage_Privilege _prvMono; // 0x1A8
	private List<MonoReunionBtnTab> _tabList; // 0x1B0
	private Dictionary<TabType, string> _tabNameDic; // 0x1B8
	private List<Transform> _topTab; // 0x1C0
	private TabType _tabType; // 0x1C8
	private uint _totalResinTime; // 0x1CC
	private uint _usedResin; // 0x1D0
	private ReunionPrivilegeExcelConfig _prvConfig; // 0x1D8
	private const string _bgImagePath = "ART/UI/Atlas/TutorialPic/"; // Metadata: 0x00B0F796
	private int _curIndex; // 0x1E0
	private List<string> bgNameList; // 0x1E8
	private List<string> titleStrList; // 0x1F0
	private List<string> descStrList; // 0x1F8
	private ReunionSignInInfo _signInInfo; // 0x200
	private HashSet<uint> _claimedDaySet; // 0x208
	private int _daysCount; // 0x210
	private int _psCurDayIndex; // 0x214
	private int _psCurItemIndex; // 0x218
	private Dictionary<int, List<uint>> _dayAndItemIndexToItemIdDic; // 0x220
	private MonoGridScroller _scroller; // 0x228
	private ReunionMissionInfo _missionInfo; // 0x230
	private ReunionMissionExcelConfig _missionConfig; // 0x238
	private List<ReunionWatcherInfo> _ongoingWatcherList; // 0x240
	private List<ReunionWatcherInfo> _canClaimWatcherList; // 0x248
	private List<ReunionWatcherInfo> _claimedWatcherList; // 0x250
	private int _selectTaskRowIndex; // 0x258
	private int _currTaskRewardItemIndex; // 0x25C
	private bool _isOnTaskRewardPointRow; // 0x260
	private MonoItemSlot _finalRewardItem; // 0x268
	private List<RewardItemConfig> _finalRewards; // 0x270
	private HashSet<int> _changeGotoPs4BtnSet; // 0x278

	// Nested types
	public enum TabType // TypeDefIndex: 29417
	{
		SignIn = 0,
		Task = 1,
		Privilege = 2,
		Count = 3,
		None = 4
	}

	// Constructors
	public ActivitySubPage_ReunionTabPage() {} // Dummy constructor
	public ActivitySubPage_ReunionTabPage(TabType tabType) {} // 0x000000018169BD30-0x000000018169BED0

	// Methods
	// [XID] // 0x0000000189969230-0x0000000189969250
	public override void SetupView() {} // 0x000000018169B970-0x000000018169BD30
	// [XID] // 0x0000000189970CD0-0x0000000189970CF0
	private void SetupSubPage() {} // 0x00000001816958B0-0x0000000181695970
	// [XID] // 0x0000000189978610-0x0000000189978630
	private void InitTabNameDic() {} // 0x0000000181695ED0-0x0000000181696040
	// [XID] // 0x000000018997F730-0x000000018997F750
	private void RefreshTabGridScrollerItem(Transform trans, int index) {} // 0x0000000181698700-0x0000000181698950
	// [XID] // 0x0000000189987080-0x00000001899870A0
	private void OpenAdventureHandbook(AdventureHandbookPageContext.AdventurePageType type) {} // 0x0000000181697DC0-0x0000000181697F50
	// [XID] // 0x000000018998EB50-0x000000018998EB70
	private void OnTabClicked(int index) {} // 0x0000000181697B10-0x0000000181697BE0
	// [XID] // 0x0000000189996730-0x0000000189996750
	private void RefreshTopTabState(TabType tabType) {} // 0x0000000181697BE0-0x0000000181697D10
	// [XID] // 0x000000018999E250-0x000000018999E270
	private void RefreshLeftAndRightTabArrow(TabType tabType) {} // 0x0000000181693440-0x0000000181693650
	// [XID] // 0x00000001899A5C10-0x00000001899A5C30
	public override void ClearView() {} // 0x0000000181694A70-0x0000000181694B40
	// [XID] // 0x00000001899AD2D0-0x00000001899AD2F0
	protected override void BindViewCallbacks() {} // 0x0000000181693860-0x0000000181693A30
	// [XID] // 0x00000001899B4B10-0x00000001899B4B30
	protected override void BindRedPoints() {} // 0x0000000181693650-0x0000000181693860
	// [XID] // 0x00000001899BC210-0x00000001899BC230
	private void OnBtnPrev() {} // 0x0000000181697D10-0x0000000181697DC0
	// [XID] // 0x00000001899C3C50-0x00000001899C3C70
	private void OnBtnNext() {} // 0x000000018169B130-0x000000018169B1E0
	// [XID] // 0x00000001899CB350-0x00000001899CB370
	private void OnBtnReturn() {} // 0x000000018169A340-0x000000018169A3F0
	// [XID] // 0x00000001899D2880-0x00000001899D28A0
	private void ShowTabPageBySendReq(TabType tabType) {} // 0x0000000181698DC0-0x0000000181698F40
	// [XID] // 0x00000001899D9F90-0x00000001899D9FB0
	public void ShowReunionSubPage(TabType tabType) {} // 0x0000000181697570-0x0000000181697810
	// [XID] // 0x00000001899E1870-0x00000001899E1890
	public override bool OnNotify(Notify ntf) => default; // 0x000000018169B010-0x000000018169B130
	// [XID] // 0x00000001899E8E20-0x00000001899E8E40
	private void OnItemAddedNotify(List<SimpleItemStruct> itemList) {} // 0x0000000181694970-0x0000000181694A70
	// [XID] // 0x00000001899F07A0-0x00000001899F07C0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181698220-0x00000001816983E0
	// [XID] // 0x00000001899F7DE0-0x00000001899F7E00
	private void RefreshPSBtn() {} // 0x0000000181696EE0-0x0000000181697570
	// [XID] // 0x00000001899FF490-0x00000001899FF4B0
	private void InitPrivilege() {} // 0x0000000181693FF0-0x0000000181694420
	// [XID] // 0x0000000189A06CD0-0x0000000189A06CF0
	private void RefreshGridScrollerItem(Transform trans, int index) {} // 0x0000000181692B20-0x0000000181692F20
	// [XID] // 0x0000000189A0E3C0-0x0000000189A0E3E0
	private void OnClickItemPositionBtn(int index) {} // 0x0000000181692F20-0x00000001816933E0
	// [XID] // 0x0000000189A15940-0x0000000189A15960
	private void ClearPrivilege() {} // 0x0000000181698440-0x00000001816984F0
	// [XID] // 0x0000000189A1CE00-0x0000000189A1CE20
	private void SetupPrivilege() {} // 0x0000000181698660-0x0000000181698700
	// [XID] // 0x0000000189A24340-0x0000000189A24360
	private void BindViewCallBackPrivilege() {} // 0x0000000181692A20-0x0000000181692B20
	// [XID] // 0x0000000189A2B800-0x0000000189A2B820
	private void OnClickResinDetailBtn() {} // 0x000000018169A230-0x000000018169A340
	// [XID] // 0x0000000189A32E80-0x0000000189A32EA0
	private void RefreshResinRemainingTime() {} // 0x00000001816984F0-0x0000000181698660
	// [XID] // 0x0000000189A3A6F0-0x0000000189A3A710
	private void SetSlotSelect(int index, bool isSelect) {} // 0x0000000181698050-0x0000000181698220
	// [XID] // 0x0000000189A42040-0x0000000189A42060
	private bool HandleTaskPrivilegeTabActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181694750-0x0000000181694970
	// [XID] // 0x0000000189A495F0-0x0000000189A49610
	private void InitSignIn() {} // 0x000000018169A9F0-0x000000018169AD30
	// [XID] // 0x0000000189A50F80-0x0000000189A50FA0
	private void SetItemSlotSelectedAndHighlighted(int dayIndex, int itemIndex, bool active) {} // 0x0000000181697810-0x0000000181697B10
	// [XID] // 0x0000000189A584E0-0x0000000189A58500
	private void ClearSignIn() {} // 0x0000000181696D90-0x0000000181696E50
	// [XID] // 0x0000000189A5FFA0-0x0000000189A5FFC0
	private void SetupSignIn() {} // 0x0000000181691AD0-0x0000000181691BA0
	// [XID] // 0x0000000189A67C00-0x0000000189A67C20
	private void BindViewCallBackSignIn() {} // 0x0000000181692460-0x00000001816925E0
	// [XID] // 0x0000000189A6F010-0x0000000189A6F030
	private Dictionary<uint, ReunionSignInExcelConfig> GetCurSignInDaysDic() => default; // 0x0000000181691BA0-0x0000000181691CD0
	// [XID] // 0x0000000189A76850-0x0000000189A76870
	private void FindFirstClaimDay() {} // 0x00000001816919B0-0x0000000181691AD0
	// [XID] // 0x0000000189A7E120-0x0000000189A7E140
	private void SetItemIcon() {} // 0x0000000181698F40-0x00000001816996A0
	// [XID] // 0x0000000189A85AC0-0x0000000189A85AE0
	private void OnReunionSignInGetRewardNotify() {} // 0x000000018169A610-0x000000018169A6B0
	// [XID] // 0x0000000189A8D360-0x0000000189A8D380
	private void RefreshSignInItemAndBtnState() {} // 0x000000018169B1E0-0x000000018169B970
	// [IDTag] // 0x0000000189A94880-0x0000000189A948C0
	// [XID] // 0x0000000189A94880-0x0000000189A948C0
	private void OnClickRewardIcon(uint id) {} // 0x0000000181692210-0x00000001816922E0
	// [IDTag] // 0x0000000189A9F030-0x0000000189A9F070
	// [XID] // 0x0000000189A9F030-0x0000000189A9F070
	private void OnClickRewardIcon(int index, uint id) {} // 0x0000000181692060-0x0000000181692210
	// [XID] // 0x0000000189AA94D0-0x0000000189AA94F0
	private void OnClickFetchBtn(int index) {} // 0x000000018169A0A0-0x000000018169A230
	// [XID] // 0x0000000189AB1410-0x0000000189AB1430
	private uint GetConfigIdByDayAndItemIndex(int dayIndex, int itemIndex) => default; // 0x0000000181695DA0-0x0000000181695ED0
	// [XID] // 0x0000000189AB86A0-0x0000000189AB86C0
	private bool HandleSignInTabActionEvent(InputActionEvent actionEvent) => default; // 0x00000001816989F0-0x0000000181698DC0
	// [XID] // 0x0000000189AC03B0-0x0000000189AC03D0
	private void InitTask() {} // 0x00000001816925E0-0x0000000181692920
	// [XID] // 0x0000000189AC7D80-0x0000000189AC7DA0
	private void RefreshCurrentTaskItem(MonoReunionTaskListRow row, bool prev) {} // 0x0000000181695970-0x0000000181695DA0
	// [XID] // 0x0000000189ACF2C0-0x0000000189ACF2E0
	private void ClearTask() {} // 0x0000000181696040-0x00000001816961C0
	// [XID] // 0x0000000189AD7190-0x0000000189AD71B0
	private void SetupTask() {} // 0x0000000181698950-0x00000001816989F0
	// [XID] // 0x0000000189ADEB30-0x0000000189ADEB50
	private void BindViewCallBackTask() {} // 0x0000000181692920-0x0000000181692A20
	// [XID] // 0x0000000189AE6520-0x0000000189AE6540
	private void RefreshFinalReward() {} // 0x0000000181694D50-0x00000001816958B0
	// [XID] // 0x0000000189AEDCF0-0x0000000189AEDD10
	private void RefreshFinalRewardIcon(Transform trans, int index) {} // 0x000000018169A3F0-0x000000018169A610
	// [XID] // 0x0000000189AF5560-0x0000000189AF5580
	private void OnReunionTaskClaimFinalRewardSuccNotify() {} // 0x0000000181691810-0x00000001816919B0
	// [XID] // 0x0000000189AFCA50-0x0000000189AFCA70
	private void RefreshWatcherList() {} // 0x000000018169AD30-0x000000018169AF20
	// [XID] // 0x0000000189B04210-0x0000000189B04230
	private void RefreshTaskListRow(Transform trans, int index) {} // 0x0000000181699770-0x000000018169A0A0
	// [XID] // 0x0000000189B0BA90-0x0000000189B0BAB0
	private void OnTaskRowClick(int index) {} // 0x0000000181694420-0x0000000181694750
	// [XID] // 0x0000000189B12F60-0x0000000189B12F80
	private void OnTaskPositionClick() {} // 0x00000001816922E0-0x0000000181692460
	// [XID] // 0x0000000189B1A670-0x0000000189B1A690
	private void OnReunionTaskClaimWatcherRewardSuccNotify() {} // 0x0000000181697F50-0x0000000181697FF0
	// [XID] // 0x0000000189B21C60-0x0000000189B21C80
	private void RefreshRewardItems(List<RewardItemConfig> rewardList, Transform trans, int index) {} // 0x0000000181694B40-0x0000000181694D50
	// [XID] // 0x0000000189B29320-0x0000000189B29340
	private void ClearTaskCurrentItem() {} // 0x000000018169A6B0-0x000000018169A9F0
	// [XID] // 0x0000000189B30730-0x0000000189B30750
	private void ClickCurrentTaskRewardItem(MonoReunionTaskListRow row) {} // 0x0000000181691E70-0x0000000181692060
	// [XID] // 0x0000000189B37FD0-0x0000000189B37FF0
	private void OnClickTaskDetailBtn() {} // 0x0000000181693A30-0x0000000181693B40
	// [XID] // 0x0000000189B3FA00-0x0000000189B3FA20
	private void RefreshPS4Btn() {} // 0x0000000181693B40-0x0000000181693FF0
	// [XID] // 0x0000000189B47220-0x0000000189B47240
	private bool HandleTaskTabActionEvent(InputActionEvent actionEvent) => default; // 0x00000001816961C0-0x0000000181696D90
}

