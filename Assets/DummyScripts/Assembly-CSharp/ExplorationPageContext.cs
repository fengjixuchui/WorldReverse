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
using UniRx;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ExplorationPageContext : BasePageContext // TypeDefIndex: 29056
{
	// Fields
	private RepeatedMessageField<ExpeditionPathInfo> _pathInfoList; // 0x190
	private int upCoeff; // 0x198
	private int dailyTimesLimit; // 0x19C
	private int _markerSelectedIndexForJoypad; // 0x1A0
	private const int questId = 7065301; // Metadata: 0x00B0EADC
	private List<ExpeditionActivityMarkerExcelConfig> _markerCfgList; // 0x1A8
	private List<MonoExplorationMark> _activityMonoMarkerList; // 0x1B0
	private MonoExplorationMark _currActivityMarker; // 0x1B8
	private List<RewardItemConfig> activityRewardList; // 0x1C0
	private int basicRewardCount; // 0x1C8
	private GameObject _rewardTag; // 0x1D0
	private uint _rewardTagHandler; // 0x1D8
	private List<AvatarDataItem> avatarDataList; // 0x1E0
	private List<ElementType> upElements; // 0x1E8
	private const int TOTAL_AVATAR = 5; // Metadata: 0x00B0EAE0
	private AvatarIconClass[] _selectedAvatarList; // 0x1F0
	private uint _friendUid; // 0x1F8
	private uint _friendAvatarId; // 0x1FC
	private List<Tuple<uint, float>> _bonusProbList; // 0x200
	private bool isAvatarRegion; // 0x208
	private MonoExplorePage _pageMono; // 0x210
	private RepeatedField<uint> _openExpeditionList; // 0x218
	private List<uint> _cityList; // 0x220
	private Dictionary<uint, List<ExpeditionDataExcelConfig>> _unlockedLineDic; // 0x228
	private List<Button> _cityBtnList; // 0x230
	private Dictionary<uint, MonoNoticeContainer> _cityRedPointDic; // 0x238
	private uint _currCity; // 0x240
	private uint _total; // 0x244
	private int _listCount; // 0x248
	private List<MonoExplorationMark> _listExplorationMark; // 0x250
	private MonoExplorationMark _currSelectedMark; // 0x258
	private MapField<ulong, AvatarExpeditionInfo> _currExpeditionInfo; // 0x260
	private uint _currRewardPreview; // 0x268
	private List<IdCountStrConfig> rewardPreviewList; // 0x270
	private ItemTipsDialogHelper _itemTips; // 0x278
	private List<BagItem> _itemList; // 0x280
	private AvatarExpeditionAllDataRsp _cachedRsp; // 0x288
	private TabType _tabType; // 0x290
	private bool _isActivityActive; // 0x294
	private string[] _topTabStrArr; // 0x298
	private bool _isAvatarSelectShowing; // 0x2A0
	private AvatarSelectListDialogContext _avatarSelectDialog; // 0x2A8
	private ulong _currSelectedGUID; // 0x2B0
	private int _currTimeIndex; // 0x2B8
	private HashSet<uint> _showedExplorationIDs; // 0x2C0
	private const int INPUT_STATE_CITY_SELECT = 0; // Metadata: 0x00B0EAE4
	private const int INPUT_STATE_EXPLORE_SELECT = 1; // Metadata: 0x00B0EAE8
	private const int INPUT_STATE_EXPLORE_SELECT_FOCUS = 2; // Metadata: 0x00B0EAEC
	private const int INPUT_STATE_CHARACTER_SELECT = 3; // Metadata: 0x00B0EAF0
	private const int INPUT_STATE_EXPLORE_SELECT_ACTIVITY = 4; // Metadata: 0x00B0EAF4
	private const int INPUT_STATE_EXPLORE_SELECT_FOCUS_ACTIVITY = 5; // Metadata: 0x00B0EAF8
	private const int INPUT_STATE_CHARACTER_SELECT_ACTIVITY = 6; // Metadata: 0x00B0EAFC
	private int _citySelectIndex; // 0x2C8
	private int _exploreMarkIndex; // 0x2CC
	private int _timeTableIndex; // 0x2D0
	private static readonly uint _citySwitchAudio; // 0x00
	private static readonly uint _topTabSwitchAudio; // 0x04
	private static readonly uint _selectTargetAudio; // 0x08
	private static readonly uint _bagItemSelectAudio; // 0x0C
	private static readonly uint _itemSelectAudio; // 0x10
	private static readonly uint _expeditionStartAudio; // 0x14

	// Properties
	private static string REWARD_TAG_PATH { /* [XID] */ /* 0x0000000189A94940-0x0000000189A94960 */ get => default; } // 0x0000000181221500-0x00000001812215A0 

	// Nested types
	private class AvatarIconClass // TypeDefIndex: 29057
	{
		// Fields
		public uint configId; // 0x10
		public string iconName; // 0x18
		public uint level; // 0x20
		public ElementType elemType; // 0x24
		public bool isUp; // 0x28
		public MonoAvatarIcon avatarIcon; // 0x30

		// Constructors
		public AvatarIconClass() {} // 0x0000000182CB2F60-0x0000000182CB2FC0
	}

	private enum TabType // TypeDefIndex: 29058
	{
		None = 0,
		Regular = 1,
		Activity = 2
	}

	// Constructors
	public ExplorationPageContext() {} // Dummy constructor
	public ExplorationPageContext(uint tabType = 0 /* Metadata: 0x00B0EAD2 */) {} // 0x0000000181237F60-0x0000000181238420
	static ExplorationPageContext() {} // 0x0000000181237E20-0x0000000181237F60

	// Methods
	// [XID] // 0x0000000189A06D50-0x0000000189A06D70
	private bool isQuestFinish() => default; // 0x0000000181235460-0x0000000181235560
	// [XID] // 0x0000000189A0E460-0x0000000189A0E480
	private void InitActivityExpedition() {} // 0x00000001812242C0-0x00000001812247A0
	// [XID] // 0x0000000189A15A00-0x0000000189A15A20
	protected override void BindRedPoints() {} // 0x0000000181225660-0x0000000181225790
	// [XID] // 0x0000000189A1CEC0-0x0000000189A1CEE0
	private void RefreshTopTabTips() {} // 0x00000001812355C0-0x0000000181235850
	// [XID] // 0x0000000189A24440-0x0000000189A24460
	private void RefreshQuantityDesc() {} // 0x0000000181231DC0-0x0000000181231FE0
	// [XID] // 0x0000000189A2B8A0-0x0000000189A2B8C0
	private void AutoSelectActivityMarker() {} // 0x0000000181234E10-0x0000000181235010
	// [XID] // 0x0000000189A32F40-0x0000000189A32F60
	private void CloseActivityMarker() {} // 0x000000018122F750-0x000000018122F8B0
	// [XID] // 0x0000000189A3A7B0-0x0000000189A3A7D0
	private void RefreshMarkerCfgList() {} // 0x000000018122F110-0x000000018122F3A0
	// [XID] // 0x0000000189A42100-0x0000000189A42120
	private void RefreshExploreActivityMarker() {} // 0x0000000181224990-0x0000000181225030
	// [XID] // 0x0000000189A49690-0x0000000189A496B0
	private void RefreshExploreActivityMarkerState() {} // 0x0000000181226570-0x0000000181226700
	// [XID] // 0x0000000189A51020-0x0000000189A51040
	private void OnActivityMarkerClick(MonoExplorationMark monoMark) {} // 0x0000000181233A90-0x0000000181233C10
	// [XID] // 0x0000000189A585A0-0x0000000189A585C0
	private void RefreshActivityMapBgAndWaterMark() {} // 0x0000000181229640-0x0000000181229840
	// [XID] // 0x0000000189A60060-0x0000000189A60080
	private void RefreshActivityMarkerSelection() {} // 0x0000000181228EB0-0x0000000181229090
	// [XID] // 0x0000000189A67CE0-0x0000000189A67D00
	private void RefreshActivityDetailInfo() {} // 0x0000000181233FB0-0x0000000181234700
	// [XID] // 0x0000000189A6F0B0-0x0000000189A6F0D0
	private void RefreshNoExploringTip() {} // 0x0000000181223820-0x0000000181223E50
	// [XID] // 0x0000000189A768F0-0x0000000189A76910
	private void RefreshActivityExpeditionDetailPanel() {} // 0x0000000181231FE0-0x0000000181232ED0
	// [XID] // 0x0000000189A7E1C0-0x0000000189A7E1E0
	private void RefreshActivityOngoingAvatarIcon() {} // 0x0000000181224080-0x0000000181224230
	// [XID] // 0x0000000189A85B60-0x0000000189A85B80
	private void InitActivityOngoingAvatarIcon(Transform trans, int index) {} // 0x000000018122AE60-0x000000018122B230
	// [XID] // 0x0000000189A8D440-0x0000000189A8D460
	private void RefreshActivityReward() {} // 0x0000000181222DE0-0x00000001812230B0
	// [XID] // 0x0000000189A9C260-0x0000000189A9C280
	private void OnShowActivityReward(Transform trans, int index, int basicRewardCount) {} // 0x0000000181228620-0x0000000181228C30
	// [XID] // 0x0000000189AA3910-0x0000000189AA3930
	private void RefreshActivityExploreInfo() {} // 0x0000000181226800-0x00000001812268A0
	// [XID] // 0x0000000189AAAFD0-0x0000000189AAAFF0
	private void TryStopActivityExpedition() {} // 0x0000000181222570-0x00000001812226D0
	// [XID] // 0x0000000189AB2960-0x0000000189AB2980
	private void TryClaimActivityExpedition() {} // 0x000000018122A820-0x000000018122A9B0
	// [XID] // 0x0000000189ABA490-0x0000000189ABA4B0
	public override void ClosePage() {} // 0x00000001812230B0-0x0000000181223200
	// [XID] // 0x0000000189AC1E20-0x0000000189AC1E40
	private void ShowActivityAvatarSelect() {} // 0x000000018122B230-0x000000018122B7A0
	// [XID] // 0x0000000189AC93D0-0x0000000189AC93F0
	private void RefreshActivityAvatarSelectTitleAndDesc() {} // 0x0000000181225C80-0x0000000181226130
	// [XID] // 0x0000000189AD0E60-0x0000000189AD0E80
	private void RefreshAvatarList(MonoExplorationMark monoMark) {} // 0x000000018122D080-0x000000018122D370
	// [XID] // 0x0000000189AD8AF0-0x0000000189AD8B10
	private void RefreshAvatarGridScroll(MonoExplorationMark monoMark) {} // 0x0000000181225300-0x0000000181225660
	// [XID] // 0x0000000189AE0680-0x0000000189AE06A0
	private void InitAvatarGridScroll(Transform trans, int index) {} // 0x000000018122C2B0-0x000000018122C7C0
	// [XID] // 0x0000000189AE7C10-0x0000000189AE7C30
	private void OnActivityAvatarIconClick(MonoAvatarIcon avatarIcon, AvatarDataItem avatarData) {} // 0x0000000181226D20-0x0000000181227510
	// [XID] // 0x0000000189AEF970-0x0000000189AEF990
	private void SendStart() {} // 0x0000000181227B30-0x0000000181227F00
	// [XID] // 0x0000000189AF6E90-0x0000000189AF6EB0
	private void RefreshAvatarSelectedList() {} // 0x00000001812292D0-0x00000001812295B0
	// [XID] // 0x0000000189AFE400-0x0000000189AFE420
	private void InitAvatarSelectedList(Transform trans, int index) {} // 0x000000018122AB50-0x000000018122AE60
	// [XID] // 0x0000000189B05BB0-0x0000000189B05BD0
	private void OnCloseSelectAvatarPanel() {} // 0x0000000181227F00-0x0000000181228170
	// [XID] // 0x0000000189B0D340-0x0000000189B0D360
	public void CheckRPActivityExpeditionAssistAvatar(bool showRP, MonoAvatarIcon avatarIcon) {} // 0x000000018122A200-0x000000018122A820
	// [XID] // 0x0000000189B148A0-0x0000000189B148C0
	private void OnBorrowedAvatarClick() {} // 0x000000018122CDC0-0x000000018122CFE0
	// [XID] // 0x0000000189B1C1C0-0x0000000189B1C1E0
	private void OnConfirmBorrowAvatar(uint avatarId, uint level, uint uid, ElementType elementType) {} // 0x0000000181236D90-0x00000001812370E0
	// [XID] // 0x0000000189B23850-0x0000000189B23870
	private void ResetBorrowAvatar() {} // 0x0000000181231CE0-0x0000000181231DC0
	// [XID] // 0x0000000189B2AAF0-0x0000000189B2AB10
	private void RefreshChallengeBtnState() {} // 0x0000000181229A80-0x000000018122A0D0
	// [XID] // 0x0000000189B32020-0x0000000189B32040
	private void OnChallengeBtnClick(bool isStart, uint nextOpenTime) {} // 0x0000000181235E50-0x0000000181236000
	// [XID] // 0x0000000189B397E0-0x0000000189B39800
	private void RequestLatestFriendBriefInfo() {} // 0x000000018122EFE0-0x000000018122F110
	// [XID] // 0x0000000189B41190-0x0000000189B411B0
	private void OnExpeditionActivityStartNotify(uint pathId) {} // 0x0000000181232ED0-0x00000001812330C0
	// [XID] // 0x0000000189B48A80-0x0000000189B48AA0
	private void OnExpeditionActivityRecallNotify() {} // 0x000000018122CFE0-0x000000018122D080
	// [XID] // 0x0000000189B50210-0x0000000189B50230
	private void OnExpeditionActivityRewardClaimedNotify(ExpeditionTakeRewardRsp rsp) {} // 0x000000018122C820-0x000000018122CB10
	// [XID] // 0x0000000189B57A40-0x0000000189B57A60
	private List<SimpleItemStruct> CreateSimpleItemStructListByRewardId(uint rewardId, uint bonusRewardId = 0 /* Metadata: 0x00B0EAD6 */) => default; // 0x000000018122F8B0-0x000000018122FAF0
	// [XID] // 0x0000000189B5F3B0-0x0000000189B5F3D0
	private void OnExpeditionActivityInfoUpdateNotify() {} // 0x0000000181236000-0x00000001812361E0
	// [XID] // 0x0000000189B669A0-0x0000000189B669C0
	public float CalculateBonusProb(int level, bool isUp) => default; // 0x000000018122E0F0-0x000000018122E610
	// [XID] // 0x0000000189B6DF00-0x0000000189B6DF20
	private void OnReadmeButtonClick() {} // 0x0000000181225B70-0x0000000181225C80
	// [XID] // 0x0000000189B755F0-0x0000000189B75610
	private bool HandleInputActionExploreSelectActivity(InputActionEvent actionEvent) => default; // 0x000000018122FAF0-0x00000001812300D0
	// [XID] // 0x0000000189B7CA20-0x0000000189B7CA40
	private void IterateExploreListActivity(bool forward) {} // 0x00000001812283A0-0x0000000181228620
	// [XID] // 0x0000000189B848A0-0x0000000189B848C0
	private bool HandleInputActionExploreSelectFocusActivity(InputActionEvent actionEvent) => default; // 0x0000000181230E60-0x00000001812316B0
	// [XID] // 0x0000000189B8B730-0x0000000189B8B750
	private bool HandleInputActionExploreCharacterSelectActivity(InputActionEvent actionEvent) => default; // 0x00000001812361E0-0x0000000181236D00
	// [XID] // 0x0000000189B92E60-0x0000000189B92E80
	public bool isShowTab() => default; // 0x00000001812376F0-0x0000000181237870
	// [XID] // 0x0000000189B9A420-0x0000000189B9A440
	public override void SetupView() {} // 0x0000000181237990-0x0000000181237AC0
	// [XID] // 0x0000000189BA1B50-0x0000000189BA1B70
	private bool isAdventurerLiyue() => default; // 0x00000001812316B0-0x00000001812317B0
	// [XID] // 0x0000000189BA8FD0-0x0000000189BA8FF0
	private void RefreshTopTab(bool isSetupView) {} // 0x0000000181223200-0x00000001812234E0
	// [XID] // 0x0000000189BB0740-0x0000000189BB0760
	private void InitTopTab(Transform trans, int index) {} // 0x000000018122D470-0x000000018122D740
	// [XID] // 0x0000000189BB7AC0-0x0000000189BB7AE0
	private void OnRegularTabClick() {} // 0x0000000181229090-0x0000000181229130
	// [XID] // 0x0000000189BBF0E0-0x0000000189BBF100
	private void OnActivityTabClick() {} // 0x0000000181222440-0x00000001812224E0
	// [XID] // 0x0000000189BC6DB0-0x0000000189BC6DD0
	private void InitExplorationPage() {} // 0x0000000181228C30-0x0000000181228D40
	// [XID] // 0x0000000189BCEA60-0x0000000189BCEA80
	private void InitRegularExplorationPage(bool useCached) {} // 0x000000018122D9D0-0x000000018122DE20
	// [XID] // 0x0000000189BD5D40-0x0000000189BD5D60
	public override void ClearView() {} // 0x00000001812268A0-0x0000000181226B40
	// [XID] // 0x0000000189BDD9D0-0x0000000189BDD9F0
	public override void Destroy() {} // 0x0000000181228170-0x0000000181228250
	// [XID] // 0x00000001895EA5B0-0x00000001895EA5D0
	protected override void ReleaseView() {} // 0x0000000181237870-0x0000000181237990
	// [XID] // 0x00000001895F1A30-0x00000001895F1A50
	public override void UpdateView() {} // 0x0000000181237AC0-0x0000000181237E20
	// [XID] // 0x00000001895F9410-0x00000001895F9430
	public override bool OnNotify(Notify ntf) => default; // 0x00000001812370E0-0x0000000181237410
	// [XID] // 0x0000000189600A60-0x0000000189600A80
	private void OnItemAddedNotify(List<SimpleItemStruct> itemList) {} // 0x0000000181226700-0x0000000181226800
	// [XID] // 0x0000000189608380-0x00000001896083A0
	protected override void BindViewCallbacks() {} // 0x0000000181225790-0x00000001812258A0
	// [XID] // 0x000000018960FD00-0x000000018960FD20
	private void OnCloseBtnClick() {} // 0x0000000181223670-0x0000000181223710
	// [XID] // 0x0000000189616FE0-0x0000000189617000
	private void RefreshAllData(AvatarExpeditionAllDataRsp rsp) {} // 0x0000000181221170-0x0000000181221500
	// [XID] // 0x000000018961EB60-0x000000018961EB80
	private void AutoSelectCity() {} // 0x0000000181227510-0x0000000181227840
	// [XID] // 0x0000000189625F60-0x0000000189625F80
	private void RefreshCityList() {} // 0x0000000181229840-0x0000000181229A80
	// [XID] // 0x000000018962D920-0x000000018962D940
	private void RefreshCityListItem(Transform trans, int index) {} // 0x000000018122CB10-0x000000018122CDC0
	// [XID] // 0x00000001896354A0-0x00000001896354C0
	private void OnCityBtnClicked(int index) {} // 0x0000000181237410-0x00000001812376F0
	// [XID] // 0x000000018963CB80-0x000000018963CBA0
	private void OnAvatarExpeditionStartNtf(uint pathId) {} // 0x0000000181233C10-0x0000000181233DD0
	// [XID] // 0x00000001896441C0-0x00000001896441E0
	private void OnCharacterInfoNotify(MapField<ulong, AvatarExpeditionInfo> avatarExpeditionInfo) {} // 0x00000001812337A0-0x0000000181233A90
	// [XID] // 0x000000018964B970-0x000000018964B990
	private void RefreshExploreMap() {} // 0x0000000181226C30-0x0000000181226D20
	// [XID] // 0x0000000189653100-0x0000000189653120
	public bool isLineUnlocked(uint lineID) => default; // 0x0000000181225AA0-0x0000000181225B70
	// [XID] // 0x000000018965A7C0-0x000000018965A7E0
	private void CloseRegularMarker() {} // 0x00000001812317B0-0x0000000181231900
	// [XID] // 0x0000000189661DF0-0x0000000189661E10
	private void UpdateExploreMapItems(List<ExpeditionDataExcelConfig> lineList) {} // 0x00000001812226D0-0x0000000181222DE0
	// [XID] // 0x00000001896699D0-0x00000001896699F0
	private void AutoSelectMark() {} // 0x000000018122A9B0-0x000000018122AB50
	// [XID] // 0x0000000189671500-0x0000000189671520
	private void OnAvatarIconClicked(MonoExplorationMark mark) {} // 0x000000018122A0D0-0x000000018122A200
	// [XID] // 0x0000000189678DC0-0x0000000189678DE0
	private void ShowAvatarSelect() {} // 0x000000018122B860-0x000000018122BAA0
	// [XID] // 0x0000000189680510-0x0000000189680530
	private void RefreshDetailInfo(bool skipRefreshExploreInfo = false /* Metadata: 0x00B0EADA */) {} // 0x00000001812330C0-0x00000001812337A0
	// [XID] // 0x0000000189687FF0-0x0000000189688010
	private void RefreshExploreInfo() {} // 0x00000001812215A0-0x0000000181222190
	// [XID] // 0x000000018968FA10-0x000000018968FA30
	private void OnTimeTabClicked(int index) {} // 0x00000001812258A0-0x0000000181225AA0
	// [XID] // 0x0000000189697410-0x0000000189697430
	private void RefreshReward(ExpeditionDataExcelConfig currConfig, int index) {} // 0x0000000181235120-0x0000000181235460
	// [XID] // 0x000000018969E960-0x000000018969E980
	private void OnShowReward(Transform trans, int index) {} // 0x000000018122F3A0-0x000000018122F750
	// [XID] // 0x00000001896A5950-0x00000001896A5970
	private void OnRewardClick(int index) {} // 0x0000000181231900-0x00000001812319E0
	// [XID] // 0x00000001896AD1D0-0x00000001896AD1F0
	private void TryExplore() {} // 0x0000000181235AD0-0x0000000181235E50
	// [XID] // 0x00000001896B47E0-0x00000001896B4800
	private void TryStop() {} // 0x0000000181222190-0x0000000181222440
	// [XID] // 0x00000001896BBAB0-0x00000001896BBAD0
	private void TryReceive() {} // 0x000000018122DE20-0x000000018122DF30
	// [XID] // 0x00000001896C2F30-0x00000001896C2F50
	private void OnAvatarSelectCancel() {} // 0x0000000181234700-0x00000001812347B0
	// [XID] // 0x00000001896CA3A0-0x00000001896CA3C0
	private void OnAvatarSelected(ulong guid) {} // 0x000000018122BAA0-0x000000018122BEA0
	// [XID] // 0x00000001896D1A70-0x00000001896D1A90
	private void RrfreshMarkSelection() {} // 0x0000000181233DD0-0x0000000181233FB0
	// [XID] // 0x00000001896D9280-0x00000001896D92A0
	private void OnAvatarSelectedRefreshMark(ulong guid) {} // 0x000000018122D740-0x000000018122D970
	// [XID] // 0x00000001896E0A90-0x00000001896E0AB0
	private bool HasSpareLine() => default; // 0x0000000181225030-0x0000000181225110
	// [XID] // 0x00000001896E7D00-0x00000001896E7D20
	private void RefreshLineCount() {} // 0x0000000181229130-0x00000001812292D0
	// [XID] // 0x00000001896EF430-0x00000001896EF450
	private void InitExplorationNew() {} // 0x0000000181226B40-0x0000000181226C30
	// [XID] // 0x00000001896F6DC0-0x00000001896F6DE0
	private bool IsExplorationNew(uint id) => default; // 0x00000001812248C0-0x0000000181224990
	// [XID] // 0x00000001896FE6D0-0x00000001896FE6F0
	private bool IsCityNew(uint cityID) => default; // 0x0000000181235850-0x0000000181235A80
	// [XID] // 0x0000000189705800-0x0000000189705820
	private void OnExplorationShowed(uint id) {} // 0x0000000181235010-0x0000000181235120
	// [XID] // 0x000000018970D340-0x000000018970D360
	private void SetMarkRedPoint(MonoExplorationMark mark, bool clicked = false /* Metadata: 0x00B0EADB */) {} // 0x0000000181223EE0-0x0000000181224080
	// [XID] // 0x00000001897147E0-0x0000000189714800
	private void SetCityRedPoint(MonoNoticeContainer redPoint, uint cityID) {} // 0x00000001812247A0-0x00000001812248C0
	// [XID] // 0x000000018971C1F0-0x000000018971C210
	private void RefreshMarkRedPoint() {} // 0x0000000181227840-0x0000000181227B30
	// [XID] // 0x0000000189723680-0x00000001897236A0
	protected void SetConsoleUIStateID(int id) {} // 0x00000001812300D0-0x0000000181230E60
	// [XID] // 0x000000018972ADE0-0x000000018972AE00
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018122BEA0-0x000000018122C100
	// [XID] // 0x00000001897324B0-0x00000001897324D0
	protected bool HandleInputActionCitySelect(InputActionEvent actionEvent) => default; // 0x0000000181226130-0x0000000181226570
	// [XID] // 0x0000000189739BA0-0x0000000189739BC0
	protected bool HandleInputActionExploreSelectFocus(InputActionEvent actionEvent) => default; // 0x000000018122E760-0x000000018122EF30
	// [XID] // 0x00000001897417A0-0x00000001897417C0
	private void OnPrevBtnClick() {} // 0x0000000181225110-0x00000001812252A0
	// [XID] // 0x0000000189749080-0x00000001897490A0
	private void OnNextBtnClick() {} // 0x00000001812234E0-0x0000000181223670
	// [XID] // 0x0000000189750530-0x0000000189750550
	private void SetExploreMarkAndDetailActive(bool active) {} // 0x000000018122DF30-0x000000018122E0F0
	// [XID] // 0x0000000189757A90-0x0000000189757AB0
	private void IterateCityList(bool forward) {} // 0x000000018122C100-0x000000018122C2B0
	// [XID] // 0x000000018975F4F0-0x000000018975F510
	protected bool HandleInputActionExploreSelect(InputActionEvent actionEvent) => default; // 0x00000001812347B0-0x0000000181234E10
	// [XID] // 0x00000001897669A0-0x00000001897669C0
	private void IterateExploreList(bool forward) {} // 0x0000000181228250-0x00000001812283A0
	// [XID] // 0x000000018976DF50-0x000000018976DF70
	public void IterateExploreTimeTable(bool forward) {} // 0x0000000181228D40-0x0000000181228EB0
}

