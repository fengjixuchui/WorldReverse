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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BattlePassPageContext : BasePageContext // TypeDefIndex: 28841
{
	// Fields
	private BattlePassPageType _type; // 0x190
	private MonoBattlePassPage _pageMono; // 0x198
	private BattlePassUISceneComponent _uiSceneComp; // 0x1A0
	private bool _showScene; // 0x1A8
	private bool _showUnlockAnim; // 0x1A9
	private RegionType _currRegion; // 0x1AC
	private static uint BP_POINT_ITEM_ID; // 0x00
	private int _selectedMissionTabIndex; // 0x1B0
	private int _selectedMissionIndex; // 0x1B4
	private uint _selectedMissionId; // 0x1B8
	private List<BPMissionStruct> _missionList; // 0x1C0
	private uint _tempPointNum; // 0x1C8
	private List<BattlePassRewardExcelConfig> _bpRewardList; // 0x1D0
	private List<int> _bpUpRewardIndexList; // 0x1D8
	private int _minCanTakeIndex; // 0x1E0
	private int _maxCanTakeIndex; // 0x1E4
	private int _firstShowIndex; // 0x1E8
	private int _upShowIndex; // 0x1EC
	private int _selectRewardItemIndex; // 0x1F0
	private int _selectRewardSlotIndex; // 0x1F4
	private Coroutine _unlockAnimCoroutine; // 0x1F8
	private List<uint> _storyRewardItemList; // 0x200
	private int _selectedWeaponIndex; // 0x208
	private int _selectedStoryIndex; // 0x20C
	private BattlePassStoryExcelConfig _bpStoryConfig; // 0x210
	private StoryPanelType _storyPanelType; // 0x218

	// Properties
	public bool showUnlockAnim { /* [XID] */ /* 0x00000001898BF4C0-0x00000001898BF4E0 */ set {} } // 0x00000001816C1730-0x00000001816C17E0

	// Nested types
	public enum BattlePassPageType // TypeDefIndex: 28842
	{
		REWARD = 1,
		MISSION = 2,
		STORY = 3
	}

	private enum RegionType // TypeDefIndex: 28843
	{
		RewardLeft = 0,
		RewardRight = 1,
		MissionLeft = 2,
		MissionRight = 3,
		StoryLeft = 4,
		StoryRight = 5
	}

	private enum StoryPanelType // TypeDefIndex: 28844
	{
		Weapon = 0,
		Wing = 1
	}

	// Constructors
	public BattlePassPageContext() {} // Dummy constructor
	public BattlePassPageContext(bool showScene = true /* Metadata: 0x00B0E792 */) {} // 0x00000001816C82D0-0x00000001816C8440
	static BattlePassPageContext() {} // 0x00000001816C8270-0x00000001816C82D0

	// Methods
	// [XID] // 0x00000001898C6D80-0x00000001898C6DA0
	public override void SetupView() {} // 0x00000001816C8140-0x00000001816C8270
	// [XID] // 0x00000001898CE360-0x00000001898CE380
	public override void ClearView() {} // 0x00000001816BB110-0x00000001816BB2B0
	// [XID] // 0x00000001898D5DB0-0x00000001898D5DD0
	protected override void OnEnable() {} // 0x00000001816C7030-0x00000001816C7170
	// [XID] // 0x00000001898DDAA0-0x00000001898DDAC0
	protected override void BindViewCallbacks() {} // 0x00000001816BA450-0x00000001816BA960
	// [XID] // 0x00000001898E53D0-0x00000001898E53F0
	public override bool OnNotify(Notify ntf) => default; // 0x00000001816C7170-0x00000001816C72E0
	// [XID] // 0x00000001898ECB20-0x00000001898ECB40
	private void EnterBattlePassPanel(BattlePassPageType type) {} // 0x00000001816C4CB0-0x00000001816C4E20
	// [XID] // 0x00000001898F4510-0x00000001898F4530
	private void SetCommonView(BattlePassPageType type) {} // 0x00000001816BD840-0x00000001816BDAF0
	// [XID] // 0x00000001898FBCA0-0x00000001898FBCC0
	private string GetBPTitleText(BattlePassPageType type) => default; // 0x00000001816C60E0-0x00000001816C6210
	// [XID] // 0x0000000189903710-0x0000000189903730
	private void RefreshBattlePassLevel() {} // 0x00000001816BFF80-0x00000001816C0560
	// [XID] // 0x000000018990AC00-0x000000018990AC20
	private void SetMenuTab() {} // 0x00000001816C6210-0x00000001816C6600
	// [XID] // 0x0000000189912930-0x0000000189912950
	private void OnTabClicked(int index) {} // 0x00000001816BCC90-0x00000001816BCE30
	// [XID] // 0x000000018991A200-0x000000018991A220
	private void SetContentView(BattlePassPageType type) {} // 0x00000001816C6B30-0x00000001816C6DE0
	// [XID] // 0x0000000189921A40-0x0000000189921A60
	private void SetTabAnimTrigger(BattlePassPageType type) {} // 0x00000001816C3B40-0x00000001816C3D40
	// [XID] // 0x0000000189929120-0x0000000189929140
	private void OnItemAddedNotify(List<SimpleItemStruct> items) {} // 0x00000001816BAEC0-0x00000001816BB010
	// [XID] // 0x0000000189930670-0x0000000189930690
	private void TryShowBPPreviewPage() {} // 0x00000001816C2D40-0x00000001816C2EB0
	// [XID] // 0x0000000189937C00-0x0000000189937C20
	private string GetLastTimeString(uint lastTime) => default; // 0x00000001816BDAF0-0x00000001816BDCD0
	// [XID] // 0x000000018993F670-0x000000018993F690
	private Sprite GetBattlePassTabIcon(int index) => default; // 0x00000001816BB010-0x00000001816BB110
	// [XID] // 0x0000000189946C80-0x0000000189946CA0
	private void OnRuleBtnClick() {} // 0x00000001816BAA70-0x00000001816BAB80
	// [XID] // 0x000000018994E300-0x000000018994E320
	private void OnCloseBtnClick() {} // 0x00000001816B95A0-0x00000001816B9750
	// [XID] // 0x0000000189955960-0x0000000189955980
	private void OnGetAllBtnClick() {} // 0x00000001816BE390-0x00000001816BE4A0
	// [XID] // 0x000000018995D400-0x000000018995D420
	private void ShowNoScheduleMessage() {} // 0x00000001816B9AC0-0x00000001816B9BA0
	// [XID] // 0x0000000189964AF0-0x0000000189964B10
	private void OnPrevBtnClick() {} // 0x00000001816BA1E0-0x00000001816BA2A0
	// [XID] // 0x000000018996C170-0x000000018996C190
	private void OnNextBtnClick() {} // 0x00000001816B94E0-0x00000001816B95A0
	// [XID] // 0x0000000189973C20-0x0000000189973C40
	private void OnBuyLevelBtnClick() {} // 0x00000001816C3160-0x00000001816C32B0
	// [XID] // 0x000000018997B290-0x000000018997B2B0
	private void SetPS4View() {} // 0x00000001816BEA50-0x00000001816BEC80
	// [XID] // 0x0000000189982D80-0x0000000189982DA0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001816BE4A0-0x00000001816BE640
	// [XID] // 0x000000018998A530-0x000000018998A550
	private bool HandleRewardPanelEvent(InputActionEvent actionEvent) => default; // 0x00000001816C0970-0x00000001816C0ED0
	// [XID] // 0x0000000189991E60-0x0000000189991E80
	private bool HandleMissionPanelEvent(InputActionEvent actionEvent) => default; // 0x00000001816BED90-0x00000001816BF1A0
	// [XID] // 0x0000000189999B30-0x0000000189999B50
	private bool HandleStoryPanelEvent(InputActionEvent actionEvent) => default; // 0x00000001816C2EB0-0x00000001816C30B0
	// [XID] // 0x00000001899A1240-0x00000001899A1260
	private void MoveRewardItemToIndex(int index) {} // 0x00000001816C5130-0x00000001816C56B0
	// [XID] // 0x00000001899A8CD0-0x00000001899A8CF0
	private void MoveRewardSlotToIndex(int index) {} // 0x00000001816C7490-0x00000001816C7840
	// [XID] // 0x00000001899B0610-0x00000001899B0630
	private void MoveUpRewardSlotToIndex(int index) {} // 0x00000001816C4980-0x00000001816C4CB0
	// [XID] // 0x00000001899B7940-0x00000001899B7960
	private bool CheckRewardCanGet(BattlePassRewardExcelConfig bpRewardConfig, int index) => default; // 0x00000001816C3570-0x00000001816C37D0
	// [XID] // 0x00000001899BF320-0x00000001899BF340
	private void MoveToRewardRightRegion() {} // 0x00000001816BF630-0x00000001816BFAA0
	// [XID] // 0x00000001899C6D10-0x00000001899C6D30
	private void MoveToRewardLeftRegion(bool checkLast = false /* Metadata: 0x00B0E793 */) {} // 0x00000001816B9BA0-0x00000001816B9FD0
	// [XID] // 0x00000001899CE240-0x00000001899CE260
	private void SimulateClickSelectRewardItem() {} // 0x00000001816BBEC0-0x00000001816BC020
	// [XID] // 0x00000001899D5A40-0x00000001899D5A60
	private void SimulateClickUpRewardItem() {} // 0x00000001816BD6B0-0x00000001816BD7E0
	// [XID] // 0x00000001899DCD50-0x00000001899DCD70
	private void SimulateClickRewardItem(MonoBPRewardItem rewardItem) {} // 0x00000001816C4F70-0x00000001816C5130
	// [XID] // 0x00000001899E4970-0x00000001899E4990
	private void MoveToMissionRightRegion() {} // 0x00000001816BAB80-0x00000001816BAEC0
	// [XID] // 0x00000001899EBDE0-0x00000001899EBE00
	private void MoveToMissionLeftRegion() {} // 0x00000001816B8950-0x00000001816B8D30
	// [XID] // 0x00000001899F3810-0x00000001899F3830
	private void DoMissionRowAction() {} // 0x00000001816B9750-0x00000001816B9AC0
	// [XID] // 0x00000001899FB150-0x00000001899FB170
	private void ShowMissionPointDetail() {} // 0x00000001816C32B0-0x00000001816C3570
	// [XID] // 0x0000000189A02380-0x0000000189A023A0
	private void MoveStoryItemToIndex(int index) {} // 0x00000001816C0560-0x00000001816C0630
	// [XID] // 0x0000000189A09B90-0x0000000189A09BB0
	private void MoveToStoryRightRegion() {} // 0x00000001816BCAA0-0x00000001816BCC90
	// [XID] // 0x0000000189A11350-0x0000000189A11370
	private void MoveToStoryLeftRegion() {} // 0x00000001816B8D30-0x00000001816B8E70
	// [XID] // 0x0000000189A18760-0x0000000189A18780
	private void MoveStorySlotToIndex(int index) {} // 0x00000001816BBC10-0x00000001816BBEC0
	// [XID] // 0x0000000189A1FDC0-0x0000000189A1FDE0
	private void ShowStory() {} // 0x00000001816C0ED0-0x00000001816C1220
	// [XID] // 0x0000000189A27130-0x0000000189A27150
	private void ScrollWeaponTips(float delta) {} // 0x00000001816BCE30-0x00000001816BCFD0
	// [XID] // 0x0000000189A2E990-0x0000000189A2E9B0
	private void ChangeRegionType(RegionType regionType) {} // 0x00000001816C30B0-0x00000001816C3160
	// [XID] // 0x0000000189A362A0-0x0000000189A362C0
	private void SetMissionView() {} // 0x00000001816C0630-0x00000001816C0970
	// [XID] // 0x0000000189A3D8A0-0x0000000189A3D8C0
	private void RefreshMissionTabItem(Transform trans, int index) {} // 0x00000001816B8290-0x00000001816B8950
	// [XID] // 0x0000000189A45000-0x0000000189A45020
	private void OnMissionTabClick(int index) {} // 0x00000001816C7840-0x00000001816C7C80
	// [XID] // 0x0000000189A4C760-0x0000000189A4C780
	private void RefreshMissionView(bool showAnim) {} // 0x00000001816C1220-0x00000001816C14E0
	// [XID] // 0x0000000189A53F40-0x0000000189A53F60
	private void RefreshMissionRow(Transform trans, int index) {} // 0x00000001816C5810-0x00000001816C6030
	// [XID] // 0x0000000189A5B950-0x0000000189A5B970
	private void OnMissionRowClick(int index) {} // 0x00000001816BB2B0-0x00000001816BB7E0
	// [XID] // 0x0000000189A63000-0x0000000189A63020
	private void ReceiveMissionPoint(uint missionId) {} // 0x00000001816B9FD0-0x00000001816BA1E0
	// [XID] // 0x0000000189A6AB60-0x0000000189A6AB80
	private void RefreshBPPointReward(Transform trans, int index) {} // 0x00000001816BFCE0-0x00000001816BFF80
	// [XID] // 0x0000000189A72260-0x0000000189A72280
	private void RefreshMissionList() {} // 0x00000001816B9230-0x00000001816B94E0
	// [XID] // 0x0000000189A79EC0-0x0000000189A79EE0
	private void TryTrackingMission(uint missionId) {} // 0x00000001816C4270-0x00000001816C44A0
	// [XID] // 0x0000000189A81340-0x0000000189A81360
	private Vector3 GetMissionGuidePos(QuestGuide guide) => default; // 0x00000001816BFAA0-0x00000001816BFCE0
	// [XID] // 0x0000000189A88D40-0x0000000189A88D60
	private int CompareMissionStruct(BPMissionStruct xData, BPMissionStruct yData) => default; // 0x00000001816BC020-0x00000001816BC2F0
	// [XID] // 0x0000000189A904F0-0x0000000189A90510
	private void OnBattlePassMissionChangeNotify() {} // 0x00000001816C6DE0-0x00000001816C6FA0
	// [XID] // 0x0000000189A97D80-0x0000000189A97DA0
	private void OnBattlePassLevelChangeNotify(BPLevelChangeStruct levelChange) {} // 0x00000001816C72E0-0x00000001816C7490
	// [XID] // 0x0000000189A9F0D0-0x0000000189A9F0F0
	private void GetAllBPMissionPoint() {} // 0x00000001816C2020-0x00000001816C26C0
	// [XID] // 0x0000000189AA69D0-0x0000000189AA69F0
	private string GetBPMissionEndTimeText(float deltaTime) => default; // 0x00000001816BA2A0-0x00000001816BA450
	// [XID] // 0x0000000189AAE060-0x0000000189AAE080
	private void SetRewardView() {} // 0x00000001816C26C0-0x00000001816C28F0
	// [XID] // 0x0000000189AB5970-0x0000000189AB5990
	private void RefreshBPRewardList() {} // 0x00000001816C44A0-0x00000001816C4800
	// [XID] // 0x0000000189ABD370-0x0000000189ABD390
	private void RefreshRewardView(bool setToCurLevel) {} // 0x00000001816C3D40-0x00000001816C4270
	// [XID] // 0x0000000189AC4DA0-0x0000000189AC4DC0
	private void RefreshRewardTokenRange() {} // 0x00000001816C17E0-0x00000001816C1C90
	// [XID] // 0x0000000189ACC400-0x0000000189ACC420
	private void RefreshBPRewardItem(Transform trans, int index) {} // 0x00000001816BB7E0-0x00000001816BBBB0
	// [XID] // 0x0000000189AD3FA0-0x0000000189AD3FC0
	private void OnRewardScrollerValueChange(Vector2 normalizedPosition) {} // 0x00000001816B81E0-0x00000001816B8290
	// [XID] // 0x0000000189ADBA60-0x0000000189ADBA80
	private void RefreshUpShowReward() {} // 0x00000001816C14E0-0x00000001816C1730
	// [XID] // 0x0000000189AE33C0-0x0000000189AE33E0
	private void SetBPRewardItem(MonoBPRewardItem item, BattlePassRewardExcelConfig rewardConfig) {} // 0x00000001816B8E70-0x00000001816B9230
	// [XID] // 0x0000000189AEAD50-0x0000000189AEAD70
	private MonoItemSlot GetRewardSlotByIndex(MonoBPRewardItem item, int index, out int realIndex) {
		realIndex = default;
		return default;
	} // 0x00000001816BE640-0x00000001816BEA50
	// [XID] // 0x0000000189AF2620-0x0000000189AF2640
	private void RefreshRewardItem(Transform trans, BattlePassRewardExcelConfig rewardConfig, int index, bool isFree) {} // 0x00000001816BC2F0-0x00000001816BC750
	// [XID] // 0x0000000189AF9FE0-0x0000000189AFA000
	private void OnRewardItemClick(bool isFree, uint level, uint rewardId) {} // 0x00000001816C28F0-0x00000001816C2D40
	// [XID] // 0x0000000189B01510-0x0000000189B01530
	private RewardItemConfig GetFirstRewardItemConfig(uint rewardId) => default; // 0x00000001816C56B0-0x00000001816C57B0
	// [XID] // 0x0000000189B08A20-0x0000000189B08A40
	private void OnBattlePassRewardChangeNotify() {} // 0x00000001816BC7E0-0x00000001816BCAA0
	// [XID] // 0x0000000189B10400-0x0000000189B10420
	private void OnBuyBtnClick() {} // 0x00000001816BA960-0x00000001816BAA70
	// [XID] // 0x0000000189B17540-0x0000000189B17560
	private void OnPaidRewardBtnClick() {} // 0x00000001816C7F80-0x00000001816C8140
	// [XID] // 0x0000000189B1EE60-0x0000000189B1EE80
	private void ShowBPShopPage(uint firstId, uint secondId) {} // 0x00000001816C4800-0x00000001816C4980
	// [XID] // 0x0000000189B267D0-0x0000000189B267F0
	private void GetAllBPReward() {} // 0x00000001816BDCD0-0x00000001816BE390
	// [XID] // 0x0000000189B2D9E0-0x0000000189B2DA00
	private void PlayBPUnlockAnim() {} // 0x00000001816BF2D0-0x00000001816BF630
	// [XID] // 0x0000000189B34E00-0x0000000189B34E20
	private void TryStopBPUnlockAnim() {} // 0x00000001816C4E20-0x00000001816C4F70
	[DebuggerHidden] // 0x0000000189B3C690-0x0000000189B3C6D0
	// [XID] // 0x0000000189B3C690-0x0000000189B3C6D0
	private IEnumerator PlayUnlockAnim(List<int> indexList) => default; // 0x00000001816C37D0-0x00000001816C38B0
	// [XID] // 0x0000000189B472C0-0x0000000189B472E0
	private void SetStoryView() {} // 0x00000001816C1C90-0x00000001816C2020
	// [XID] // 0x0000000189B4EAE0-0x0000000189B4EB00
	private void RefreshWeaponStoryView() {} // 0x00000001816C7C80-0x00000001816C7F80
	// [XID] // 0x0000000189B56340-0x0000000189B56360
	private void RefreshWeaponItem(Transform trans, int index) {} // 0x00000001816BCFD0-0x00000001816BD1F0
	// [XID] // 0x0000000189B5DAE0-0x0000000189B5DB00
	private void OnWeaponItemClick(int index) {} // 0x00000001816BD300-0x00000001816BD6B0
	// [XID] // 0x0000000189B65060-0x0000000189B65080
	private void ShowWeaponStoryDialog() {} // 0x00000001816BF1A0-0x00000001816BF2D0
	// [XID] // 0x0000000189B6C640-0x0000000189B6C660
	private void RefreshBPStoryView(uint storyId) {} // 0x00000001816C38B0-0x00000001816C3B40
	// [XID] // 0x0000000189B73DD0-0x0000000189B73DF0
	private void RefreshStoryListRow(Transform trans, int index) {} // 0x00000001816C6600-0x00000001816C6B30
	// [XID] // 0x0000000189B7B440-0x0000000189B7B460
	private void ShowReadingDialog(uint docId) {} // 0x00000001816BD1F0-0x00000001816BD300
}

