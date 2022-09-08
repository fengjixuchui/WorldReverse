/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AdventureHandbookPageContext : BasePageContext // TypeDefIndex: 28769
{
	// Fields
	private AdventurePageType _type; // 0x190
	private MonoAdventureHandbookPage _pageMono; // 0x198
	private uint _selectCityId; // 0x1A0
	private List<uint> _unlockCityList; // 0x1A8
	private ItemGotBigDialogContext _itemGotDialog; // 0x1B0
	private bool _isOnTab; // 0x1B8
	private bool _isOnDailyDungeonTab; // 0x1B9
	private bool _isOnTrialDungeonTab; // 0x1BA
	private MonsterCategory _monsterDropdownSelectCategory; // 0x1BC
	private int _currInvestigationRewardItemIndex; // 0x1C0
	private int _currTaskRewardItemIndex; // 0x1C4
	private bool _isOnTaskRewardPointRow; // 0x1C8
	private int _currDailyDungeonRewardItemIndex; // 0x1CC
	private int _currTrialRewardItemIndex; // 0x1D0
	private int _currMonsterRewardItemIndex; // 0x1D4
	private Dictionary<uint, List<uint>> _cityDungeonDic; // 0x1D8
	private int _selectedEntryIndex; // 0x1E0
	private int _selectDungeonIndex; // 0x1E4
	private int _selectedTypeIndex; // 0x1E8
	private int _selectDungeonEntryIndex; // 0x1EC
	private int _selectTrialEntryIndex; // 0x1F0
	private SimpleSafeUInt32[] _selectedDungeonList; // 0x1F8
	private List<RewardItemConfig> _tempRewardList; // 0x200
	private List<IdCountStrConfig> _tempRewardPreviewList; // 0x208
	private List<RewardItemConfig> _tempRecommendRewardList; // 0x210
	private List<IdCountStrConfig> _tempRecommendRewardPreviewList; // 0x218
	private List<DailyDungeonEntryStruct> _dungeonEntryList; // 0x220
	private List<DailyDungeonEntryStruct> _dungeonEntryCurrList; // 0x228
	private List<DailyDungeonEntryStruct> _trialDungeonEntryList; // 0x230
	private List<DailyDungeonEntryStruct> _trialDungeonEntryCurrList; // 0x238
	private List<DungunEntryType> _dungeonEntryDropdownList; // 0x240
	private List<DungunEntryType> _trialEntryDropdownList; // 0x248
	private DungunEntryType _screenType; // 0x250
	private DungunEntryType _screenTrialType; // 0x254
	private SubDungeonType _curSubDungeonType; // 0x258
	private readonly uint _towerDungeonID; // 0x25C
	private uint _towerDungeonEntryConfigId; // 0x260
	private bool _towerDungeonToBeExplore; // 0x264
	private List<int> _dungeonCooldownUpdateTimeList; // 0x268
	private ulong _nextSendReqTime; // 0x270
	private readonly uint _intervalTime; // 0x278
	private Coroutine _updateRecoveryTextCoroutineOfResin; // 0x280
	private int _curInvestigationProgress; // 0x288
	private List<InvestigationTargetStruct> _investigationTargetList; // 0x290
	private int _selectInvestigationTargetIndex; // 0x298
	private uint _selectInvestigationTargetId; // 0x29C
	private int _curSelectChapterIndex; // 0x2A0
	private int _lastMaxChapterNum; // 0x2A4
	private Dictionary<MonsterCategory, List<InvestigationMonsterStruct>> _monsterDataDic; // 0x2A8
	private uint _showMonsterId; // 0x2B0
	private int _selectMonsterIndex; // 0x2B4
	private Coroutine _refreshCoroutine; // 0x2B8
	private List<IdCountStrConfig> _tempMonsterRewardList; // 0x2C0
	private bool _isMonsterLock; // 0x2C8
	private Coroutine _updateCooldownTipsCoroutine; // 0x2D0
	private List<DailyTaskData> _unfinishTaskList; // 0x2D8
	private List<DailyTaskData> _finishedTaskList; // 0x2E0
	private List<IdCountStrConfig> _taskRewardList; // 0x2E8
	private List<IdCountStrConfig> _rewardPreviewList; // 0x2F0
	private int _selectTaskIndex; // 0x2F8

	// Nested types
	public enum AdventurePageType // TypeDefIndex: 28770
	{
		INVESTIGATION = 0,
		TASK = 1,
		DUNGEON = 2,
		MONSTER = 3
	}

	// Constructors
	public AdventureHandbookPageContext() {} // 0x00000001821E67A0-0x00000001821E6A90

	// Methods
	// [XID] // 0x0000000189B204B0-0x0000000189B204D0
	public override void SetupView() {} // 0x00000001821E6420-0x00000001821E6700
	// [XID] // 0x0000000189B27B10-0x0000000189B27B30
	private void SetupJoypadSelectorSound() {} // 0x00000001821D5520-0x00000001821D5930
	// [XID] // 0x0000000189B2EE70-0x0000000189B2EE90
	public void SetupInitOpenPageType(AdventurePageType type) {} // 0x00000001821CB1C0-0x00000001821CB270
	// [XID] // 0x0000000189B36730-0x0000000189B36750
	public override void UpdateView() {} // 0x00000001821E6700-0x00000001821E67A0
	// [XID] // 0x0000000189B3DFA0-0x0000000189B3DFC0
	public override void ClearView() {} // 0x00000001821CC660-0x00000001821CC770
	// [XID] // 0x0000000189B45CD0-0x0000000189B45CF0
	protected override void BindViewCallbacks() {} // 0x00000001821CA4B0-0x00000001821CAE60
	// [XID] // 0x0000000189B4D170-0x0000000189B4D190
	protected override void BindRedPoints() {} // 0x00000001821CA300-0x00000001821CA4B0
	// [XID] // 0x0000000189B54970-0x0000000189B54990
	public override bool OnNotify(Notify ntf) => default; // 0x00000001821E3370-0x00000001821E3620
	// [XID] // 0x0000000189B5C4F0-0x0000000189B5C510
	private void OnTabClicked(AdventurePageType type) {} // 0x00000001821D2010-0x00000001821D23F0
	// [XID] // 0x0000000189B63AC0-0x0000000189B63AE0
	private void RefreshClickTips() {} // 0x00000001821C6510-0x00000001821C6720
	// [XID] // 0x0000000189B6B2A0-0x0000000189B6B2C0
	private void ResolveBtnShowForJoypad() {} // 0x00000001821C9540-0x00000001821C9620
	// [XID] // 0x0000000189B728E0-0x0000000189B72900
	private void SetContentView(AdventurePageType type) {} // 0x00000001821E29C0-0x00000001821E2AB0
	// [XID] // 0x0000000189B79E10-0x0000000189B79E30
	private void SetTabAnimTrigger(AdventurePageType type) {} // 0x00000001821DD6F0-0x00000001821DDAA0
	// [XID] // 0x0000000189B81500-0x0000000189B81520
	private void OnTravelBtnClick() {} // 0x00000001821D2A50-0x00000001821D2AF0
	// [XID] // 0x0000000189B88C50-0x0000000189B88C70
	private void OnTaskBtnClick() {} // 0x00000001821D75F0-0x00000001821D76A0
	// [XID] // 0x0000000189B90160-0x0000000189B90180
	private void OnDungeonBtnClick() {} // 0x00000001821DE780-0x00000001821DE830
	// [XID] // 0x0000000189B97600-0x0000000189B97620
	private void OnMonsterBtnClick() {} // 0x00000001821D5470-0x00000001821D5520
	// [XID] // 0x0000000189B9EA80-0x0000000189B9EAA0
	private void OnItemAddedNotify(List<SimpleItemStruct> items) {} // 0x00000001821CC220-0x00000001821CC360
	// [XID] // 0x0000000189BA6390-0x0000000189BA63B0
	private void ShowClickTips(Button btn, bool active) {} // 0x00000001821E1FC0-0x00000001821E2180
	// [XID] // 0x0000000189BAD620-0x0000000189BAD640
	private void RefreshUnlockCityList() {} // 0x00000001821CB630-0x00000001821CB8A0
	// [XID] // 0x0000000189BB4D90-0x0000000189BB4DB0
	private void SetupCityDropdown() {} // 0x00000001821DCA20-0x00000001821DCD00
	// [XID] // 0x0000000189BBC3C0-0x0000000189BBC3E0
	private void OnMonsterDropdownSelect(int index) {} // 0x00000001821D7B10-0x00000001821D7BD0
	// [XID] // 0x0000000189BC4080-0x0000000189BC40A0
	public override bool BasePageHandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001821D46E0-0x00000001821D47A0
	// [XID] // 0x0000000189BCBA70-0x0000000189BCBA90
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001821D4CD0-0x00000001821D4EA0
	// [XID] // 0x0000000189BD2FC0-0x0000000189BD2FE0
	private Button GetPageTabButton(AdventurePageType type) => default; // 0x00000001821CFF80-0x00000001821D0130
	// [XID] // 0x0000000189BDA7E0-0x0000000189BDA800
	private void SimulateClickTab(AdventurePageType type) {} // 0x00000001821E4480-0x00000001821E45E0
	// [XID] // 0x00000001895E7210-0x00000001895E7230
	private bool HandleTabInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001821C7AD0-0x00000001821C8140
	// [XID] // 0x00000001895EEAE0-0x00000001895EEB00
	private MonoUIContainer GetButtonByType(AdventurePageType type) => default; // 0x00000001821E0010-0x00000001821E0150
	// [XID] // 0x00000001895F64E0-0x00000001895F6500
	private void InitTabView() {} // 0x00000001821D7BD0-0x00000001821D7CC0
	// [XID] // 0x00000001895FD7F0-0x00000001895FD810
	private void InitInvestigationView() {} // 0x00000001821CBA70-0x00000001821CBD30
	// [XID] // 0x00000001896050C0-0x00000001896050E0
	private void InitTaskView() {} // 0x00000001821CBF60-0x00000001821CC220
	// [XID] // 0x000000018960CAF0-0x000000018960CB10
	private void InitDungeonView() {} // 0x00000001821DA0F0-0x00000001821DA1A0
	// [XID] // 0x0000000189614080-0x00000001896140A0
	private void InitMonsterView() {} // 0x00000001821E2AB0-0x00000001821E2D20
	// [XID] // 0x000000018961B9E0-0x000000018961BA00
	private bool HandleInvestigationInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001821E5850-0x00000001821E6420
	// [XID] // 0x0000000189623000-0x0000000189623020
	private bool HandleCityDropdownInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001821E2180-0x00000001821E2430
	// [XID] // 0x000000018962A7F0-0x000000018962A810
	private void BackToTab() {} // 0x00000001821D0130-0x00000001821D01E0
	// [XID] // 0x0000000189631F30-0x0000000189631F50
	private void BackToDailyDungeonTab() {} // 0x00000001821E1870-0x00000001821E1920
	// [XID] // 0x0000000189639A50-0x0000000189639A70
	private void BackToTrialDungeonTab() {} // 0x00000001821DF900-0x00000001821DF9B0
	// [XID] // 0x0000000189640F20-0x0000000189640F40
	private void RefreshCurrentInvestigationItem(MonoInvestigationListRow row, bool prev) {} // 0x00000001821D4F00-0x00000001821D5370
	// [XID] // 0x0000000189648810-0x0000000189648830
	private void ClearInvestigationCurrentItem() {} // 0x00000001821C6720-0x00000001821C6A40
	// [XID] // 0x000000018964FF40-0x000000018964FF60
	private void ClickCurrentInvestigationRewardItem(MonoInvestigationListRow row) {} // 0x00000001821DF9B0-0x00000001821DFBA0
	// [XID] // 0x00000001896577E0-0x0000000189657800
	private void ResolveInvestigationBtnShow(MonoInvestigationListRow row) {} // 0x00000001821C6A40-0x00000001821C6CB0
	// [XID] // 0x000000018965EE40-0x000000018965EE60
	private void HideInvestigationBtnShow() {} // 0x00000001821DFDC0-0x00000001821E0010
	// [XID] // 0x0000000189666580-0x00000001896665A0
	private bool HandleTaskInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001821D05B0-0x00000001821D1150
	// [XID] // 0x000000018966DD80-0x000000018966DDA0
	private void RefreshCurrentTaskItem(MonoTaskListRow row, bool prev) {} // 0x00000001821CE730-0x00000001821CEBA0
	// [XID] // 0x0000000189675B80-0x0000000189675BA0
	private void ClearTaskCurrentItem() {} // 0x00000001821DDFD0-0x00000001821DE2F0
	// [XID] // 0x000000018967D430-0x000000018967D450
	private void ClickCurrentTaskRewardItem(MonoTaskListRow row) {} // 0x00000001821C78E0-0x00000001821C7AD0
	// [XID] // 0x0000000189684B00-0x0000000189684B20
	private void ResolveTaskBtnShow(MonoTaskListRow row) {} // 0x00000001821DBE90-0x00000001821DC040
	// [XID] // 0x000000018968C6B0-0x000000018968C6D0
	private void HideTaskBtnShow() {} // 0x00000001821C7720-0x00000001821C78E0
	// [XID] // 0x0000000189694120-0x0000000189694140
	private bool HandleDungeonInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001821D3390-0x00000001821D34E0
	// [XID] // 0x000000018969B6B0-0x000000018969B6D0
	private void RefreshCurrentDailyDungeonItem(MonoDungeonListRow row, bool prev) {} // 0x00000001821CE2C0-0x00000001821CE730
	// [XID] // 0x00000001896A2E10-0x00000001896A2E30
	private void ClearDailyDungeonCurrentItem() {} // 0x00000001821C91C0-0x00000001821C94E0
	// [XID] // 0x00000001896AA2C0-0x00000001896AA2E0
	private void ClickCurrentDailyDungeonRewardItem(MonoDungeonListRow row) {} // 0x00000001821D3E20-0x00000001821D4010
	// [XID] // 0x00000001896B1120-0x00000001896B1140
	private void RefreshCurrentTrialDungeonItem(MonoDungeonListRow row, bool prev) {} // 0x00000001821DEB50-0x00000001821DEFC0
	// [XID] // 0x00000001896B8CF0-0x00000001896B8D10
	private void ClearTrialDungeonCurrentItem() {} // 0x00000001821D01E0-0x00000001821D0500
	// [XID] // 0x00000001896BFEF0-0x00000001896BFF10
	private void ResolveDailyDungeonBtnShow(MonoDungeonListRow row) {} // 0x00000001821D3120-0x00000001821D3390
	// [XID] // 0x00000001896C77F0-0x00000001896C7810
	private void RefreshCurrentTrialItem(MonoDungeonListRow row, bool prev) {} // 0x00000001821D1640-0x00000001821D1AB0
	// [XID] // 0x00000001896CEF90-0x00000001896CEFB0
	private void ClickCurrentTrialDungeonRewardItem(MonoDungeonListRow row) {} // 0x00000001821DE960-0x00000001821DEB50
	// [XID] // 0x00000001896D6390-0x00000001896D63B0
	private void ResolveTrialBtnShow(MonoDungeonListRow row) {} // 0x00000001821D1150-0x00000001821D1300
	// [XID] // 0x00000001896DD9B0-0x00000001896DD9D0
	private void HideDailyDungeonBtnShow() {} // 0x00000001821D2EA0-0x00000001821D3120
	// [XID] // 0x00000001896E5060-0x00000001896E5080
	private void HideTrialDungeonBtnShow() {} // 0x00000001821E1540-0x00000001821E1700
	// [XID] // 0x00000001896EC500-0x00000001896EC520
	private bool HandleDailyInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001821CC570-0x00000001821CC660
	// [XID] // 0x00000001896F3CD0-0x00000001896F3CF0
	private bool HandleDailyTabInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001821E0C70-0x00000001821E0E50
	// [XID] // 0x00000001896FB440-0x00000001896FB460
	private bool HandleDailyDungeonInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001821E38B0-0x00000001821E4480
	// [XID] // 0x0000000189702BD0-0x0000000189702BF0
	private bool HandleTrialInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001821CB980-0x00000001821CBA70
	// [XID] // 0x000000018970A310-0x000000018970A330
	private bool HandleTrialTabInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001821D24D0-0x00000001821D26B0
	// [XID] // 0x0000000189711E30-0x0000000189711E50
	private bool HandleTrialDungeonInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001821D7EF0-0x00000001821D8AC0
	// [XID] // 0x0000000189719230-0x0000000189719250
	private void InitTrialTabView() {} // 0x00000001821D6940-0x00000001821D6B80
	// [XID] // 0x00000001897208F0-0x0000000189720910
	private void InitDailyTabView() {} // 0x00000001821CDA10-0x00000001821CDC50
	// [XID] // 0x0000000189727EA0-0x0000000189727EC0
	private bool HandleTowerInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001821CD190-0x00000001821CD4A0
	// [XID] // 0x000000018972F4E0-0x000000018972F500
	private void ResolveDungeonBtnShow() {} // 0x00000001821DAE90-0x00000001821DB560
	// [XID] // 0x0000000189736F20-0x0000000189736F40
	private void HideDungeonBtnShow() {} // 0x00000001821E0230-0x00000001821E0840
	// [XID] // 0x000000018973EAE0-0x000000018973EB00
	private bool HandleDungeonEntryDropdownInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001821D3730-0x00000001821D39C0
	// [XID] // 0x0000000189745DA0-0x0000000189745DC0
	private bool HandleTrialEntryDropdownInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001821DD090-0x00000001821DD320
	// [XID] // 0x000000018974D890-0x000000018974D8B0
	private bool HandleMonsterInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001821C84A0-0x00000001821C8BE0
	// [XID] // 0x0000000189754ED0-0x0000000189754EF0
	private void RefreshCurrentMonsterItem(bool prev) {} // 0x00000001821D4260-0x00000001821D4680
	// [XID] // 0x000000018975C060-0x000000018975C080
	private void ClickCurrentMonsterRewardItem() {} // 0x00000001821DDAA0-0x00000001821DDE40
	// [XID] // 0x0000000189763A10-0x0000000189763A30
	private void ClearMonsterCurrentItem() {} // 0x00000001821CAF50-0x00000001821CB1C0
	// [XID] // 0x000000018976B1D0-0x000000018976B1F0
	private void ResolveMonsterBtnShow() {} // 0x00000001821C8D70-0x00000001821C9050
	// [XID] // 0x0000000189772820-0x0000000189772840
	private void HideMonsterBtnShow() {} // 0x00000001821D1390-0x00000001821D1640
	// [XID] // 0x0000000189779E50-0x0000000189779E70
	private void PlayJoypadSelectSound(Transform trans, int index) {} // 0x00000001821DD5C0-0x00000001821DD6F0
	// [XID] // 0x0000000189781AB0-0x0000000189781AD0
	private void SetDungeonView() {} // 0x00000001821D1BD0-0x00000001821D1E20
	// [XID] // 0x0000000189788FB0-0x0000000189788FD0
	private void RefreshDungeonEntryView() {} // 0x00000001821DEFC0-0x00000001821DF200
	// [XID] // 0x00000001897905A0-0x00000001897905C0
	private void RefreshDungeonDic() {} // 0x00000001821DBA20-0x00000001821DBBD0
	// [XID] // 0x0000000189797F90-0x0000000189797FB0
	private void RefreshDungeonEntryRow(Transform trans, int index) {} // 0x00000001821CEC70-0x00000001821CF0A0
	// [XID] // 0x000000018979FCB0-0x000000018979FCD0
	private void OnDungeonEntryRowClick(int index) {} // 0x00000001821D8AC0-0x00000001821D8F10
	// [XID] // 0x00000001897A7210-0x00000001897A7230
	private void RefreshDungeonRow(Transform trans, int index) {} // 0x00000001821E1B40-0x00000001821E1FC0
	// [XID] // 0x00000001897AEBE0-0x00000001897AEC00
	private void OnDungeonRowClick(int index) {} // 0x00000001821D9EC0-0x00000001821DA0F0
	// [XID] // 0x00000001897B6A70-0x00000001897B6A90
	private void OnDungeonPositionClick() {} // 0x00000001821DE2F0-0x00000001821DE470
	// [XID] // 0x00000001897BE890-0x00000001897BE8B0
	private void RefreshRewardItems(Transform trans, int index) {} // 0x00000001821CCBC0-0x00000001821CCDE0
	// [XID] // 0x00000001897C5FA0-0x00000001897C5FC0
	private void RefreshRewardPreviewItems(Transform trans, int index) {} // 0x00000001821CFA80-0x00000001821CFC70
	// [XID] // 0x00000001897CD7A0-0x00000001897CD7C0
	private void OnTipsBtnClick() {} // 0x00000001821E3620-0x00000001821E38B0
	// [XID] // 0x00000001897D4D00-0x00000001897D4D20
	public void SetUpTowerPanel() {} // 0x00000001821D5B00-0x00000001821D5FC0
	// [XID] // 0x00000001897DC460-0x00000001897DC480
	private void OnClickRewardPreview() {} // 0x00000001821DF7A0-0x00000001821DF900
	// [XID] // 0x00000001897E3DD0-0x00000001897E3DF0
	private void OnClickGotoChallenge() {} // 0x00000001821DE650-0x00000001821DE780
	// [XID] // 0x00000001897EB9A0-0x00000001897EB9C0
	private void RefreshDungeonView() {} // 0x00000001821C9700-0x00000001821C9940
	// [XID] // 0x00000001897F32A0-0x00000001897F32C0
	private void RefreshDungeonTypeRow(Transform trans, int index) {} // 0x00000001821DF200-0x00000001821DF7A0
	// [XID] // 0x00000001897FAB10-0x00000001897FAB30
	private void SetupDailyDungeonView() {} // 0x00000001821DB840-0x00000001821DBA20
	// [XID] // 0x00000001898020C0-0x00000001898020E0
	private void SetupTrialDungeonView() {} // 0x00000001821CDFD0-0x00000001821CE240
	// [XID] // 0x0000000189809550-0x0000000189809570
	private void ShowDugeonScrollerHalfCost(bool isTrial) {} // 0x00000001821E49E0-0x00000001821E4F30
	// [XID] // 0x0000000189810D60-0x0000000189810D80
	private void OnDungeonTypeRowClick(int index) {} // 0x00000001821E5150-0x00000001821E5850
	// [XID] // 0x00000001898187F0-0x0000000189818810
	private void RefreshNewDungeonEntryRow(Transform trans, int index) {} // 0x00000001821C9940-0x00000001821CA1B0
	// [XID] // 0x0000000189820100-0x0000000189820120
	private void RefreshTrialDungeonEntryRow(Transform trans, int index) {} // 0x00000001821D5FC0-0x00000001821D6940
	// [XID] // 0x00000001898276C0-0x00000001898276E0
	private void UpdateDungeonCooldownInfo() {} // 0x00000001821D76A0-0x00000001821D7B10
	// [XID] // 0x000000018982E8E0-0x000000018982E900
	private void OnGetDailyDungeonEntryInfoNoitfy(RepeatedMessageField<DailyDungeonEntryInfo> dailyDungeonList) {} // 0x00000001821D8F10-0x00000001821D9B90
	// [XID] // 0x0000000189836280-0x00000001898362A0
	private void GetDailyDungeonEntryInfo() {} // 0x00000001821CB8A0-0x00000001821CB980
	// [XID] // 0x000000018983D6F0-0x000000018983D710
	private void RefreshDungeonEntryDic() {} // 0x00000001821DFC70-0x00000001821DFDC0
	// [XID] // 0x0000000189844ED0-0x0000000189844EF0
	private void OnDungeonEntryPositionClick(int index) {} // 0x00000001821CF8F0-0x00000001821CFA80
	// [XID] // 0x000000018984C3A0-0x000000018984C3C0
	private void OnTrialEntryPositionClick(int index) {} // 0x00000001821DDE40-0x00000001821DDFD0
	// [XID] // 0x0000000189853510-0x0000000189853530
	private void RefreshRecommendRewardItems(Transform trans, int index) {} // 0x00000001821D4A60-0x00000001821D4CD0
	// [XID] // 0x000000018985AF60-0x000000018985AF80
	private void RefreshRecommendRewardPreviewItems(Transform trans, int index) {} // 0x00000001821E1920-0x00000001821E1B40
	// [XID] // 0x0000000189862400-0x0000000189862420
	private void OnNewDungeonEntryRowClick(int index) {} // 0x00000001821D7CC0-0x00000001821D7EF0
	// [XID] // 0x00000001898698F0-0x0000000189869910
	private void OnNewTrialEntryRowClick(int index) {} // 0x00000001821C6CB0-0x00000001821C6EE0
	// [XID] // 0x0000000189870A90-0x0000000189870AB0
	private string GetDungeonEntryDescription(DungunEntryType type) => default; // 0x00000001821CA1B0-0x00000001821CA300
	// [XID] // 0x0000000189878580-0x00000001898785A0
	private void SetupTypeDropdown() {} // 0x00000001821CC770-0x00000001821CCBC0
	// [XID] // 0x000000018987FAB0-0x000000018987FAD0
	private void SetupTrialTypeDropDown() {} // 0x00000001821D2AF0-0x00000001821D2E30
	// [XID] // 0x00000001898870E0-0x0000000189887100
	private void OnDungeonEntryTypeChange(int index) {} // 0x00000001821D39C0-0x00000001821D3DA0
	// [XID] // 0x000000018988E250-0x000000018988E270
	private void ScreenDungeonEntryList() {} // 0x00000001821D6D20-0x00000001821D6F70
	// [XID] // 0x0000000189895900-0x0000000189895920
	private void OnTrialEntryTypeChange(int index) {} // 0x00000001821DD320-0x00000001821DD5C0
	// [XID] // 0x000000018989D020-0x000000018989D040
	private void ScreenTrialEntryList() {} // 0x00000001821D4010-0x00000001821D4260
	// [XID] // 0x00000001898A48A0-0x00000001898A48C0
	private void InitResinView() {} // 0x00000001821E45E0-0x00000001821E49E0
	// [XID] // 0x00000001898ABD60-0x00000001898ABD80
	private void ShowResinView(bool show) {} // 0x00000001821DCDE0-0x00000001821DCFC0
	// [XID] // 0x00000001898B3490-0x00000001898B34B0
	private void RefreshResinView() {} // 0x00000001821CDD60-0x00000001821CDFD0
	// [XID] // 0x00000001898BB170-0x00000001898BB190
	private void SetInvestigationView() {} // 0x00000001821D0500-0x00000001821D05B0
	// [XID] // 0x00000001898C2520-0x00000001898C2540
	private void RefreshInvestigationDic() {} // 0x00000001821E09F0-0x00000001821E0B00
	// [XID] // 0x00000001898C9F40-0x00000001898C9F60
	private void RefreshInvestigationView() {} // 0x00000001821E27E0-0x00000001821E29C0
	// [XID] // 0x00000001898D15C0-0x00000001898D15E0
	private void RefreshInvestigationTargetView(InvestigationStruct investigationData) {} // 0x00000001821C6EE0-0x00000001821C7720
	// [XID] // 0x00000001898D8E00-0x00000001898D8E20
	private void RefreshProgressItem(Transform trans, int index) {} // 0x00000001821DC910-0x00000001821DCA20
	// [XID] // 0x00000001898E0AF0-0x00000001898E0B10
	private void RefreshInvestigationRow(Transform trans, int index) {} // 0x00000001821DC310-0x00000001821DC910
	// [XID] // 0x00000001898E8630-0x00000001898E8650
	private void OnInvestigationRowClick(int index) {} // 0x00000001821DB560-0x00000001821DB840
	// [XID] // 0x00000001898EFE10-0x00000001898EFE30
	private void OnReceiveBtnClick() {} // 0x00000001821E1700-0x00000001821E1810
	// [XID] // 0x00000001898F7650-0x00000001898F7670
	private void ReceiveTargetReward(uint questId) {} // 0x00000001821CAE60-0x00000001821CAF50
	// [XID] // 0x00000001898FED60-0x00000001898FED80
	private void OnLocationBtnClick() {} // 0x00000001821CDC50-0x00000001821CDD60
	// [XID] // 0x0000000189906500-0x0000000189906520
	private void OnInvestigationReceiveBtnClick() {} // 0x00000001821E0840-0x00000001821E09F0
	// [XID] // 0x000000018990DF40-0x000000018990DF60
	private void TryTracking(uint questId) {} // 0x00000001821D34E0-0x00000001821D3730
	// [XID] // 0x00000001899156B0-0x00000001899156D0
	private void OnInvestigationChangeTargetNotify() {} // 0x00000001821C8BE0-0x00000001821C8D70
	// [XID] // 0x000000018991D0E0-0x000000018991D100
	private void OnInvestigationChangeNotify() {} // 0x00000001821E2430-0x00000001821E25E0
	// [XID] // 0x0000000189924990-0x00000001899249B0
	private void PlayNewTabAnim() {} // 0x00000001821DE830-0x00000001821DE960
	// [XID] // 0x000000018992BF20-0x000000018992BF40
	private int CompareInvestigationTarget(InvestigationTargetStruct xData, InvestigationTargetStruct yData) => default; // 0x00000001821D6B80-0x00000001821D6CC0
	// [XID] // 0x0000000189933410-0x0000000189933430
	private void OnNextChapterBtnClick() {} // 0x00000001821DE470-0x00000001821DE590
	// [XID] // 0x000000018993AFC0-0x000000018993AFE0
	private void OnPrevChapterBtnClick() {} // 0x00000001821CEBA0-0x00000001821CEC70
	// [XID] // 0x00000001899420D0-0x00000001899420F0
	private void ResetScrollerFocus() {} // 0x00000001821D1AB0-0x00000001821D1BD0
	// [XID] // 0x0000000189949AF0-0x0000000189949B10
	private void RefreshChapterBtnShowState() {} // 0x00000001821CC360-0x00000001821CC570
	// [XID] // 0x0000000189951580-0x00000001899515A0
	private void SetupMonsterView() {} // 0x00000001821DCFC0-0x00000001821DD090
	// [XID] // 0x0000000189958B90-0x0000000189958BB0
	private void ClearMonsterView() {} // 0x00000001821DE590-0x00000001821DE650
	// [XID] // 0x00000001899601F0-0x0000000189960210
	private void SetMonsterView() {} // 0x00000001821DFBA0-0x00000001821DFC70
	// [XID] // 0x0000000189967C90-0x0000000189967CB0
	private void OnGetInvestigationMonsterNotify(RepeatedMessageField<InvestigationMonster> monsterList) {} // 0x00000001821CB540-0x00000001821CB630
	// [XID] // 0x000000018996EE90-0x000000018996EEB0
	private void RefreshMonsterDataDic(RepeatedMessageField<InvestigationMonster> monsterList) {} // 0x00000001821E0E50-0x00000001821E1540
	// [XID] // 0x0000000189976A90-0x0000000189976AB0
	private void RefreshMonsterView() {} // 0x00000001821DC040-0x00000001821DC310
	// [XID] // 0x000000018997DED0-0x000000018997DEF0
	private List<InvestigationMonsterStruct> GetMonsterScrollViewNeedData() => default; // 0x00000001821E0150-0x00000001821E0230
	// [XID] // 0x00000001899858B0-0x00000001899858D0
	private void RefreshMonsterIcon(Transform trans, int index) {} // 0x00000001821E2DB0-0x00000001821E3370
	// [XID] // 0x000000018998D5F0-0x000000018998D610
	private void OnMonsterIconClick(int index) {} // 0x00000001821CF0A0-0x00000001821CF560
	// [XID] // 0x0000000189995030-0x0000000189995050
	public void RefreshMonsterDetailView(InvestigationMonsterStruct monsterData) {} // 0x00000001821DA1A0-0x00000001821DAE90
	[DebuggerHidden] // 0x000000018999CA10-0x000000018999CA50
	// [XID] // 0x000000018999CA10-0x000000018999CA50
	private IEnumerator UpdateCooldownTips(uint nextRefreshTime) => default; // 0x00000001821C9620-0x00000001821C9700
	// [XID] // 0x00000001899A7430-0x00000001899A7450
	public void RefreshMonsterNoInfoView(InvestigationMonsterStruct monsterData) {} // 0x00000001821CD4A0-0x00000001821CDA10
	// [XID] // 0x00000001899AED00-0x00000001899AED20
	private void RefreshMonsterRewardItem(Transform trans, int index) {} // 0x00000001821CB270-0x00000001821CB540
	// [XID] // 0x00000001899B6080-0x00000001899B60A0
	private void OnMonsterTrackBtnClick() {} // 0x00000001821D26B0-0x00000001821D2A50
	// [XID] // 0x00000001899BDDE0-0x00000001899BDE00
	private void MapCloseCallBack(uint id) {} // 0x00000001821E0B00-0x00000001821E0C70
	// [XID] // 0x00000001899C5520-0x00000001899C5540
	private void CancelPreTrackMonster() {} // 0x00000001821C9050-0x00000001821C91C0
	// [XID] // 0x00000001899CCBF0-0x00000001899CCC10
	private void SetupOccupiedByQuest(uint mainQuestId) {} // 0x00000001821CFC70-0x00000001821CFEA0
	// [XID] // 0x00000001899D41F0-0x00000001899D4210
	private uint CheckNearestRefreshTime() => default; // 0x00000001821D9B90-0x00000001821D9EC0
	// [XID] // 0x00000001899DB7E0-0x00000001899DB800
	private void StartRefreshMonsterCoroutine(float duration) {} // 0x00000001821D1EB0-0x00000001821D2010
	// [XID] // 0x00000001899E2EE0-0x00000001899E2F00
	private void StopRefreshMonsterCoroutine() {} // 0x00000001821D5370-0x00000001821D5470
	// [XID] // 0x00000001899EA5F0-0x00000001899EA610
	private void GetInvestigationMonsterData() {} // 0x00000001821D23F0-0x00000001821D24D0
	// [XID] // 0x00000001899F2060-0x00000001899F2080
	private void SetTaskView() {} // 0x00000001821CCDE0-0x00000001821CD190
	// [XID] // 0x00000001899F97A0-0x00000001899F97C0
	private void RefreshTaskList() {} // 0x00000001821E4F30-0x00000001821E5150
	// [XID] // 0x0000000189A00B00-0x0000000189A00B20
	private void SetupTaskProgressView() {} // 0x00000001821CF560-0x00000001821CF8F0
	// [XID] // 0x0000000189A083E0-0x0000000189A08400
	private void RefreshProgressIcon(Transform trans, int index) {} // 0x00000001821D59B0-0x00000001821D5B00
	// [XID] // 0x0000000189A0F980-0x0000000189A0F9A0
	private void SetupTaskRewardView() {} // 0x00000001821E25E0-0x00000001821E27E0
	// [XID] // 0x0000000189A16EE0-0x0000000189A16F00
	private void RefreshTaskRewardItem(Transform trans, int index) {} // 0x00000001821D47A0-0x00000001821D4A60
	// [XID] // 0x0000000189A1E580-0x0000000189A1E5A0
	private void RefreshTaskListRow(Transform trans, int index) {} // 0x00000001821D6F70-0x00000001821D75F0
	// [XID] // 0x0000000189A25C80-0x0000000189A25CA0
	private void RefreshPreviewRewardItems(Transform trans, int index) {} // 0x00000001821DBBD0-0x00000001821DBE90
	// [XID] // 0x0000000189A2D120-0x0000000189A2D140
	private void OnTaskRowClick(int index) {} // 0x00000001821CBD30-0x00000001821CBF60
	// [XID] // 0x0000000189A34AC0-0x0000000189A34AE0
	private void OnTaskPositionClick(uint taskId) {} // 0x00000001821C8140-0x00000001821C8270
	// [XID] // 0x0000000189A3BE90-0x0000000189A3BEB0
	private void OnTaskMarkBtnClick() {} // 0x00000001821C8270-0x00000001821C84A0
}

