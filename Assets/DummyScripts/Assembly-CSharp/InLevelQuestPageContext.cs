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
using MoleMole.Config;
using UnityEngine;
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelQuestPageContext : BasePageContext // TypeDefIndex: 29571
{
	// Fields
	private const uint TOGGLE_TRACKING_AUDIO_ID = 3243807812; // Metadata: 0x00B0F945
	private MonoInLevelQuestDialog _dialogMono; // 0x190
	private MonoQuestBook _questBook; // 0x198
	private const int TAB_INDEX_WORLD_QUEST = 4; // Metadata: 0x00B0F949
	private static int _questTypeTabIndex; // 0x00
	private List<Transform> _allTransList; // 0x1A0
	private Dictionary<MonoQuestChapterRow, List<MonoQuestSelectItem>> _chapterRow2ItemDic; // 0x1A8
	private List<MonoQuestSelectItem> _noChapterItemList; // 0x1B0
	private List<ItemProxy> _mainQuestIDList; // 0x1B8
	private Dictionary<uint, int> _mainQuestID2IndexDic; // 0x1C0
	private HashSet<ItemProxy> _finishedMainQuestIDSet; // 0x1C8
	private Dictionary<ItemProxy, MonoQuestSelectItem> _mainQuestID2ItemDic; // 0x1D0
	private List<MonoQuestSelectItem> _mainQuestItemList; // 0x1D8
	private Dictionary<uint, uint> _finishedQuestId2ChapterId; // 0x1E0
	private List<uint> _finishedChapterList; // 0x1E8
	private Dictionary<uint, List<ItemProxy>> _finishedChapterId2MainProxyListDic; // 0x1F0
	private List<MonoQuestSelectItem> _finishedItemList; // 0x1F8
	private List<MonoQuestSelectItem> _redPointList; // 0x200
	private static ItemProxy? _targetItem; // 0x04
	private ItemProxy? _jumpToItem; // 0x208
	private static ItemProxy _selectItem; // 0x10
	private int _selectMainQuestIndex; // 0x214
	private MonoQuestSelectItem _selectQuestItem; // 0x218
	private MonoQuestSelectItem _finishedSelectItem; // 0x220
	private static int _selectChapterIdIndex; // 0x18
	private int _lastInputState; // 0x228
	private int _selectTransIndex; // 0x22C
	private int _selectFinishItemIndex; // 0x230
	private List<QuestProxy> _subQuestList; // 0x238
	private List<BagItem> _rewardList; // 0x240
	private List<IdCountStrConfig> _rewardPreviewList; // 0x248
	private List<RewardExcelConfig> _rewards; // 0x250
	private InfoTextDialogContext _infoTextDialog; // 0x258
	private string _popUpText; // 0x260
	private bool _needTip; // 0x268
	private bool _needLevelUp; // 0x269
	private uint _referenceAvatarLevel; // 0x26C
	private bool _canNavigation; // 0x270
	private bool _canFold; // 0x271
	private const int TRACK_MAX_COUNT = 1; // Metadata: 0x00B0F94D
	private const int DAILY_TASK_INDEX = 3; // Metadata: 0x00B0F951
	private const string _recommendColor = "<color=#FF5E41FF>{0}</color>"; // Metadata: 0x00B0F955
	private bool _isInFinishedChapterPage; // 0x272
	private bool _isInFinishedDetailPage; // 0x273
	private bool _showImgBarLeft; // 0x274
	private ItemProxy tempItemProxy; // 0x278
	private const int INPUT_STATE_DEFAULT = 0; // Metadata: 0x00B0F975
	private const int INPUT_STATE_CHAPTER = 1; // Metadata: 0x00B0F979
	private const int INPUT_STATE_DETAIL = 2; // Metadata: 0x00B0F97D
	private const int INPUT_STATE_REWARD = 3; // Metadata: 0x00B0F981
	private const string PLUS_ICON = "UI_TouchIcon_Plus"; // Metadata: 0x00B0F985
	private const string MINUS_ICON = "UI_TouchIcon_Minus"; // Metadata: 0x00B0F99A
	private int _selectedRewardIndex; // 0x280
	private ItemTipsDialogHelper _itemTips; // 0x288

	// Constructors
	public InLevelQuestPageContext() {} // Dummy constructor
	public InLevelQuestPageContext(uint targetMainQuestId = 0 /* Metadata: 0x00B0F93E */) {} // 0x0000000181337F60-0x00000001813383A0
	static InLevelQuestPageContext() {} // 0x0000000181337EC0-0x0000000181337F60

	// Methods
	// [XID] // 0x00000001897C2B50-0x00000001897C2B70
	public override void SetupView() {} // 0x0000000181337CF0-0x0000000181337EC0
	// [XID] // 0x00000001897CA3B0-0x00000001897CA3D0
	public override void ClearView() {} // 0x0000000181320510-0x00000001813206A0
	// [XID] // 0x00000001897D1A10-0x00000001897D1A30
	protected override void BindViewCallbacks() {} // 0x000000018131E980-0x000000018131EE50
	// [XID] // 0x00000001897D9830-0x00000001897D9850
	protected override void BindRedPoints() {} // 0x000000018131E850-0x000000018131E980
	// [XID] // 0x00000001897E0BF0-0x00000001897E0C10
	protected override void OnEnable() {} // 0x0000000181336820-0x00000001813368C0
	// [XID] // 0x00000001897E8250-0x00000001897E8270
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181336A70-0x0000000181336CD0
	// [XID] // 0x00000001897EFF70-0x00000001897EFF90
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018132A170-0x000000018132A8A0
	// [XID] // 0x00000001897F7700-0x00000001897F7720
	private bool HandleInputActionChapter(InputActionEvent actionEvent) => default; // 0x0000000181333250-0x0000000181333460
	// [XID] // 0x00000001897FEDF0-0x00000001897FEE10
	private bool HandleInputActionDetail(InputActionEvent actionEvent) => default; // 0x000000018132F7C0-0x000000018132FAC0
	// [XID] // 0x0000000189806570-0x0000000189806590
	private bool HandleInputActionReward(InputActionEvent actionEvent) => default; // 0x00000001813209E0-0x0000000181320B20
	// [XID] // 0x000000018980DC90-0x000000018980DCB0
	public override void OnInputDeviceChanged() {} // 0x00000001813368C0-0x0000000181336A70
	// [XID] // 0x00000001898153D0-0x00000001898153F0
	private void OnQuestTypeTabClicked(int index) {} // 0x00000001813274B0-0x0000000181327680
	// [XID] // 0x000000018981CD90-0x000000018981CDB0
	private void ForceChangeQuestTypeTab(int index) {} // 0x0000000181321080-0x0000000181321180
	// [XID] // 0x00000001898241F0-0x0000000189824210
	private void ShowFinishedChapterPage() {} // 0x0000000181324F60-0x0000000181325090
	// [XID] // 0x000000018982BC80-0x000000018982BCA0
	private void CloseFinishedChapterPage() {} // 0x0000000181326710-0x0000000181326A80
	// [XID] // 0x0000000189833210-0x0000000189833230
	private void CloseFinishedDetailPage() {} // 0x000000018132B710-0x000000018132B7C0
	// [XID] // 0x000000018983A6C0-0x000000018983A6E0
	private void ShowNoQuestPage(int index) {} // 0x0000000181334230-0x00000001813344B0
	// [XID] // 0x0000000189841CC0-0x0000000189841CE0
	private void CloseNoQuestPage() {} // 0x0000000181333460-0x00000001813336A0
	// [XID] // 0x00000001898491D0-0x00000001898491F0
	private void OnCloseBtnClick() {} // 0x000000018131DFE0-0x000000018131E0C0
	// [XID] // 0x0000000189850950-0x0000000189850970
	private void OnTalkLogBtnClick() {} // 0x000000018131D2B0-0x000000018131D420
	// [XID] // 0x0000000189857D20-0x0000000189857D40
	private void OnNavigationBtnClick() {} // 0x000000018132D060-0x000000018132D5C0
	// [XID] // 0x000000018985EE10-0x000000018985EE30
	private void OnTipsClicked() {} // 0x000000018132A040-0x000000018132A170
	// [XID] // 0x00000001898665F0-0x0000000189866610
	private void ShowInfoTextDialog(string text) {} // 0x000000018131CAE0-0x000000018131CC60
	// [XID] // 0x000000018986DEF0-0x000000018986DF10
	private void OnSubQuestItemClick() {} // 0x000000018131FCA0-0x000000018131FDC0
	// [XID] // 0x00000001898752C0-0x00000001898752E0
	private void OnTaskItemClicked(MonoQuestSelectItem questItem) {} // 0x00000001813207F0-0x00000001813209E0
	// [XID] // 0x000000018987CE90-0x000000018987CEB0
	private void OnMainQuestItemClicked(MonoQuestSelectItem item) {} // 0x0000000181335580-0x0000000181335970
	// [XID] // 0x0000000189883E10-0x0000000189883E30
	private void TryRemoveFromNewList(uint mainId) {} // 0x000000018132BFD0-0x000000018132C1F0
	// [XID] // 0x000000018988B4B0-0x000000018988B4D0
	private void OnTrackingBtnClick(ItemProxy itemProxy) {} // 0x000000018131CD90-0x000000018131D210
	// [XID] // 0x0000000189892C70-0x0000000189892C90
	private void OnGrpChapterRowBtnClick(int index) {} // 0x000000018132E460-0x000000018132EF00
	// [XID] // 0x000000018989A2D0-0x000000018989A2F0
	private void OnPreChapterBtnClick() {} // 0x0000000181334C70-0x0000000181334DA0
	// [XID] // 0x00000001898A1530-0x00000001898A1550
	private void OnNextChapterBtnClick() {} // 0x0000000181332720-0x00000001813328B0
	// [XID] // 0x00000001898A8D80-0x00000001898A8DA0
	private void ToggleQuestTrack() {} // 0x000000018132ABA0-0x000000018132AD40
	// [XID] // 0x00000001898B0720-0x00000001898B0740
	private void ToPrevFinishItem() {} // 0x0000000181320390-0x0000000181320510
	// [XID] // 0x00000001898B7D30-0x00000001898B7D50
	private void ToNextFinishItem() {} // 0x00000001813252B0-0x0000000181325460
	// [XID] // 0x00000001898BF3A0-0x00000001898BF3C0
	private void ToPrevTab() {} // 0x0000000181320240-0x0000000181320390
	// [XID] // 0x00000001898C6CC0-0x00000001898C6CE0
	private void ToNextTab() {} // 0x00000001813227D0-0x0000000181322980
	// [XID] // 0x00000001898CE2C0-0x00000001898CE2E0
	private void ToPrevMainQuest() {} // 0x000000018131F9B0-0x000000018131FCA0
	// [XID] // 0x00000001898D5CD0-0x00000001898D5CF0
	private void ToPrevTrans() {} // 0x00000001813344B0-0x0000000181334C70
	// [XID] // 0x00000001898DD980-0x00000001898DD9A0
	private void ToNextTrans() {} // 0x0000000181324750-0x0000000181324F60
	// [XID] // 0x00000001898E52D0-0x00000001898E52F0
	private void RefreshBtns() {} // 0x0000000181337470-0x0000000181337AE0
	// [XID] // 0x00000001898ECA40-0x00000001898ECA60
	private void ToggleChapterFold() {} // 0x000000018132D5C0-0x000000018132DC10
	// [XID] // 0x00000001898F4450-0x00000001898F4470
	private void ToNextMainQuest() {} // 0x000000018131DCC0-0x000000018131DFE0
	// [XID] // 0x00000001898FBBE0-0x00000001898FBC00
	private void ToggleMainQuestTracking() {} // 0x0000000181325460-0x0000000181325540
	// [XID] // 0x0000000189903650-0x0000000189903670
	private bool TryNavigation() => default; // 0x0000000181337330-0x0000000181337470
	// [XID] // 0x000000018990AB60-0x000000018990AB80
	private void ScrollSubQuestList(float delta) {} // 0x000000018131E4F0-0x000000018131E690
	// [XID] // 0x0000000189912870-0x0000000189912890
	private void ChoosePrevChapter() {} // 0x000000018132CD40-0x000000018132D060
	// [XID] // 0x000000018991A140-0x000000018991A160
	private void ChooseNextChapter() {} // 0x000000018131F670-0x000000018131F9B0
	// [XID] // 0x0000000189921940-0x0000000189921960
	public void OnAddQuestHintNtf(QuestExcelConfigProxy config, QuestHintType type) {} // 0x000000018131C780-0x000000018131C8F0
	// [XID] // 0x0000000189929060-0x0000000189929080
	private void InitQuestTypeTab() {} // 0x0000000181330140-0x0000000181330580
	// [XID] // 0x00000001899305B0-0x00000001899305D0
	private void Refresh() {} // 0x000000018131C310-0x000000018131C580
	// [XID] // 0x0000000189937B00-0x0000000189937B20
	private void TrySetDefaultTabIndex() {} // 0x0000000181336DD0-0x0000000181337330
	// [XID] // 0x000000018993F5D0-0x000000018993F5F0
	private void SetTabSelected(int index) {} // 0x000000018131E360-0x000000018131E4F0
	// [XID] // 0x0000000189946BC0-0x0000000189946BE0
	private void InitFinishedItem(MonoQuestSelectItem item, ItemProxy itemProxy) {} // 0x0000000181333700-0x0000000181333CB0
	// [XID] // 0x000000018994E240-0x000000018994E260
	private void OnFinishedItemClicked(MonoQuestSelectItem item) {} // 0x0000000181327E50-0x0000000181328B90
	// [XID] // 0x0000000189955820-0x0000000189955840
	private void OnFinishedDetailChange(Transform trans, int index) {} // 0x000000018132AD40-0x000000018132AFA0
	// [XID] // 0x000000018995D340-0x000000018995D360
	private List<uint> GetFinishedChapter(List<QuestType> filterList = null) => default; // 0x000000018131EE50-0x000000018131F670
	// [XID] // 0x00000001899649F0-0x0000000189964A10
	private void InitFinishedChapterScroller() {} // 0x0000000181321300-0x00000001813216B0
	// [XID] // 0x000000018996C0D0-0x000000018996C0F0
	private void OnFinishedChapterScrollerInit(Transform trans, int index) {} // 0x000000018131FDC0-0x0000000181320240
	// [XID] // 0x0000000189973B60-0x0000000189973B80
	private bool UpdateFilteredQuestBookList(int index) => default; // 0x0000000181324470-0x0000000181324750
	// [XID] // 0x000000018997B1D0-0x000000018997B1F0
	private Dictionary<uint, List<ItemProxy>> FilterQuestIdListByChapterId(List<ItemProxy> inputQuestIdList) => default; // 0x000000018132F2D0-0x000000018132F7C0
	// [XID] // 0x0000000189982CA0-0x0000000189982CC0
	private void FilterQuestBookListData(int index, out List<ItemProxy> filteredMainIdList, out List<ItemProxy> filteredFinishedMainIDList) {
		filteredMainIdList = default;
		filteredFinishedMainIDList = default;
	} // 0x0000000181335B30-0x0000000181336790
	// [XID] // 0x000000018998A470-0x000000018998A490
	private void SetEmptyQuestList(int index) {} // 0x0000000181333130-0x0000000181333250
	// [XID] // 0x0000000189991D60-0x0000000189991D80
	private List<ItemProxy> filterFinishedQuestByChapterId(List<ItemProxy> finishedIDList) => default; // 0x0000000181326B50-0x0000000181326DC0
	// [XID] // 0x0000000189999A90-0x0000000189999AB0
	private void SetQuestBookNew(int changeToIndex, List<ItemProxy> mainIDList, List<ItemProxy> finishedIDList) {} // 0x0000000181322980-0x0000000181323D00
	// [XID] // 0x00000001899A1120-0x00000001899A1140
	private ItemProxy GetDefaultSelectMainQuestID() => default; // 0x0000000181328BF0-0x0000000181329830
	// [XID] // 0x00000001899A8C50-0x00000001899A8C70
	private void OnMainQuestScrollChange(Transform trans, int index) {} // 0x0000000181335970-0x0000000181335B30
	// [XID] // 0x00000001899B0570-0x00000001899B0590
	private void InitTaskItem(MonoQuestSelectItem item, ItemProxy itemProxy) {} // 0x000000018131D420-0x000000018131DCC0
	// [XID] // 0x00000001899B78A0-0x00000001899B78C0
	private string GetMainQuestTitleStrByTag(MainQuestTagType tag, string titleStr) => default; // 0x0000000181327B00-0x0000000181327C60
	// [XID] // 0x00000001899BF240-0x00000001899BF260
	private void InitQuestItem(MonoQuestSelectItem item, ItemProxy itemProxy) {} // 0x0000000181321C20-0x00000001813227D0
	// [XID] // 0x00000001899C6C70-0x00000001899C6C90
	private void UpdateRecommendLevel(MonoQuestSelectItem item, ref ItemProxy itemProxy, bool isDangerous, ref MainQuestExcelConfigProxy cfg, bool isInTimeLimit = false /* Metadata: 0x00B0F942 */) {} // 0x000000018132DC10-0x000000018132E460
	// [XID] // 0x00000001899CE180-0x00000001899CE1A0
	private void UpdateSelect(uint mainQuestID) {} // 0x0000000181332030-0x0000000181332290
	// [XID] // 0x00000001899D5960-0x00000001899D5980
	private void UpdateSelectNew(ItemProxy mainQuest) {} // 0x000000018132C540-0x000000018132C860
	// [XID] // 0x00000001899DCCB0-0x00000001899DCCD0
	private void UpdateChapterSelect(MonoQuestSelectItem newItem, bool isSelected) {} // 0x000000018132FAC0-0x000000018132FE80
	// [XID] // 0x00000001899E48B0-0x00000001899E48D0
	private void RemoveMainQuest(uint mainQuestID) {} // 0x000000018132C1F0-0x000000018132C540
	// [XID] // 0x00000001899EBCA0-0x00000001899EBCC0
	public void AddNewSubQuest(ref QuestExcelConfigProxy config) {} // 0x000000018131C160-0x000000018131C310
	// [XID] // 0x00000001899F3770-0x00000001899F3790
	private void UpdateDailyTaskDetail(uint dailyTaskId) {} // 0x00000001813328B0-0x0000000181333130
	// [XID] // 0x00000001899FB090-0x00000001899FB0B0
	private void OnTaskScrollChange(Transform trans, int index) {} // 0x0000000181333CB0-0x0000000181334230
	// [XID] // 0x0000000189A022E0-0x0000000189A02300
	private void RefreshPreviewRewardItems(Transform trans, int index) {} // 0x000000018132FE80-0x0000000181330140
	// [XID] // 0x0000000189A09AD0-0x0000000189A09AF0
	private uint GetActivityCloseTime(ActivityInfo activityInfo) => default; // 0x00000001813251F0-0x00000001813252B0
	// [XID] // 0x0000000189A11270-0x0000000189A11290
	private void SetRemainingTime(uint mainQuestID) {} // 0x000000018132A900-0x000000018132ABA0
	// [XID] // 0x0000000189A18640-0x0000000189A18660
	private void UpdateMainQuestDetail(uint mainQuestID) {} // 0x0000000181330580-0x0000000181331B20
	// [XID] // 0x0000000189A1FD00-0x0000000189A1FD20
	private bool IsCoopQuest(uint mainQuestID) => default; // 0x00000001813264B0-0x0000000181326630
	// [XID] // 0x0000000189A27090-0x0000000189A270B0
	private void ShowCoopQuest(bool show) {} // 0x0000000181325090-0x00000001813251F0
	// [XID] // 0x0000000189A2E8B0-0x0000000189A2E8D0
	private void DeleteCurrentCoopQuest() {} // 0x000000018131C580-0x000000018131C780
	// [XID] // 0x0000000189A361E0-0x0000000189A36200
	private void CheckMultiPlayerDetail(uint mainQuestId, bool isDailyTask = false /* Metadata: 0x00B0F943 */) {} // 0x000000018132B2D0-0x000000018132B710
	// [XID] // 0x0000000189A3D7E0-0x0000000189A3D800
	private void CheckMultiPlayerItem(MonoQuestSelectItem item, bool isDailyTask = false /* Metadata: 0x00B0F944 */) {} // 0x000000018132AFA0-0x000000018132B2D0
	// [XID] // 0x0000000189A44F60-0x0000000189A44F80
	private void SetPlusBtnIcon(MonoUIContainer btn) {} // 0x0000000181326300-0x00000001813264B0
	// [XID] // 0x0000000189A4C6A0-0x0000000189A4C6C0
	private void OnPlusBtnClicked(int num) {} // 0x0000000181332290-0x0000000181332720
	// [XID] // 0x0000000189A53E80-0x0000000189A53EA0
	private uint RefreshSubQuestList(uint mainQuestID, List<QuestProxy> validSubQuestList) => default; // 0x000000018132BB10-0x000000018132BEC0
	// [XID] // 0x0000000189A5B8B0-0x0000000189A5B8D0
	private void OnSubQuestScrollChange(Transform trans, int index) {} // 0x0000000181335190-0x0000000181335580
	// [XID] // 0x0000000189A62F60-0x0000000189A62F80
	private void RefreshMainQuestRestrictionTips(uint mainQuestID) {} // 0x0000000181325540-0x0000000181325F70
	// [XID] // 0x0000000189A6AAC0-0x0000000189A6AAE0
	private bool isInChapterOpenTime(string str) => default; // 0x0000000181331B20-0x0000000181331E20
	// [XID] // 0x0000000189A72180-0x0000000189A721A0
	private void GetMainQuestLackSceneInfo(uint mainQuestID, uint lackedSceneQuestId, ref string hintText, ref string popupText) {} // 0x0000000181329830-0x0000000181329C70
	// [XID] // 0x0000000189A79E20-0x0000000189A79E40
	private void GetMainQuestLackNPCInfo(uint mainQuestID, uint lackedNPCquestID, ref string hintText, ref string popupText) {} // 0x0000000181320B20-0x0000000181321080
	// [XID] // 0x0000000189A812A0-0x0000000189A812C0
	private void RefreshMainQuestReward(uint mainQuestID, ref MainQuestExcelConfigProxy cfg, uint rewardPreviewId) {} // 0x0000000181323D00-0x0000000181324330
	// [XID] // 0x0000000189A88C80-0x0000000189A88CA0
	private void RefreshMainQuestLocation(uint mainQuestID) {} // 0x000000018131E690-0x000000018131E850
	// [XID] // 0x0000000189A90470-0x0000000189A90490
	private void RefreshMapMark() {} // 0x000000018131CC60-0x000000018131CD90
	// [XID] // 0x0000000189A97C60-0x0000000189A97C80
	private void UpdateTrackingMark() {} // 0x00000001813216B0-0x0000000181321C20
	// [XID] // 0x0000000189A9EFF0-0x0000000189A9F010
	private void TryTracking() {} // 0x0000000181327680-0x0000000181327B00
	// [XID] // 0x0000000189AA6950-0x0000000189AA6970
	private void StartPaimenNavigation(uint dailyTaskId) {} // 0x0000000181337AE0-0x0000000181337CF0
	// [XID] // 0x0000000189AADFC0-0x0000000189AADFE0
	public void CancelCurrentNavigation() {} // 0x000000018131E0C0-0x000000018131E300
	// [XID] // 0x0000000189AB58F0-0x0000000189AB5910
	private void ToRewardPage() {} // 0x0000000181326DC0-0x0000000181327260
	// [XID] // 0x0000000189ABD2D0-0x0000000189ABD2F0
	private void BackToPrevPage() {} // 0x000000018132EF00-0x000000018132F2D0
	// [XID] // 0x0000000189AC4D00-0x0000000189AC4D20
	private void ToNextReward() {} // 0x000000018132B7C0-0x000000018132BB10
	// [XID] // 0x0000000189ACC380-0x0000000189ACC3A0
	private void ToPrevReward() {} // 0x000000018132C9F0-0x000000018132CD40
	// [XID] // 0x0000000189AD3EA0-0x0000000189AD3EC0
	private void ShowReward() {} // 0x0000000181326190-0x0000000181326300
	// [XID] // 0x0000000189ADB9A0-0x0000000189ADB9C0
	private void RefreshRewardSlot(Transform trans, int index) {} // 0x0000000181327C60-0x0000000181327E50
	// [XID] // 0x0000000189AE3300-0x0000000189AE3320
	private void ShowItemTips(int index) {} // 0x0000000181324330-0x0000000181324410
	// [XID] // 0x0000000189AEAC70-0x0000000189AEAC90
	private void RefreshReferenceAvatarLevel() {} // 0x0000000181331F50-0x0000000181332030
	// [XID] // 0x0000000189AF2540-0x0000000189AF2560
	private bool ContainsInFinishedList(IDType type, uint id) => default; // 0x0000000181329C70-0x0000000181329E40
	// [XID] // 0x0000000189AF9F00-0x0000000189AF9F20
	private bool HasOpenedTaskIndex() => default; // 0x0000000181326000-0x0000000181326190
	// [XID] // 0x0000000189B01410-0x0000000189B01430
	private int NowTrackingQuestNum() => default; // 0x0000000181327260-0x00000001813274B0
	// [XID] // 0x0000000189B08920-0x0000000189B08940
	private bool CheckLastPage() => default; // 0x000000018131C8F0-0x000000018131CAE0
	// [XID] // 0x0000000189B10320-0x0000000189B10340
	public static void SetTargetItem(ItemProxy item) {} // 0x0000000181336CD0-0x0000000181336DD0
	// [XID] // 0x0000000189B17460-0x0000000189B17480
	public MonoQuestSelectItem GetQuestSelectItemByMainQuestID(uint mainQuestID) => default; // 0x0000000181321180-0x0000000181321300
	// [XID] // 0x0000000189B1EDA0-0x0000000189B1EDC0
	private void TryShowPersonalLineEntryBtn(bool flg) {} // 0x0000000181329E40-0x000000018132A040
	// [XID] // 0x0000000189B266F0-0x0000000189B26710
	private void OnPersonalLineBtnClick() {} // 0x000000018132BEC0-0x000000018132BFD0
	// [XID] // 0x0000000189B2D900-0x0000000189B2D920
	private bool IsReputationQuest(uint mainId) => default; // 0x0000000181334E00-0x0000000181335190
	// [XID] // 0x0000000189B34D20-0x0000000189B34D40
	private bool IsUsingActivityNeededLevel(ChapterExcelConfig chapterData) => default; // 0x0000000181326630-0x0000000181326710
	// [XID] // 0x0000000189B3C5D0-0x0000000189B3C5F0
	private void SortQuestByQuestTag(List<ItemProxy> questList) {} // 0x000000018132C860-0x000000018132C9F0
}

