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

public class InLevelLegendQuestDialogContext : BasePageContext // TypeDefIndex: 29558
{
	// Fields
	private CoopManager _coopManager; // 0x190
	private MonoCoopAvatarCol _lastSelectAvatar; // 0x198
	private MonoCoopChapterRow _lastSelectChapter; // 0x1A0
	private int _selectedAvatarIndex; // 0x1A8
	private bool _isEnterChapter; // 0x1AC
	private Coroutine _highlightTopChpater; // 0x1B0
	private Coroutine _focusAvatarCol; // 0x1B8
	private Coroutine _highlightTopAvatar; // 0x1C0
	private Coroutine _recoverElastic; // 0x1C8
	private uint _targetCoopAvatarId; // 0x1D0
	private int _targetCoopAvatarIndex; // 0x1D4
	private int _minAvatarRPShowIndex; // 0x1D8
	private int _maxAvatarRPShowIndex; // 0x1DC
	private List<uint> _avatarIdList; // 0x1E0
	private List<uint> _tempChapterId; // 0x1E8
	private CoopRewardDialogContext _rewardPage; // 0x1F0
	private CoopPageContext _coopPage; // 0x1F8
	private MonoInlevelLegendQuestDialog _dialogMono; // 0x200
	private LegendQuestDialogType _type; // 0x208
	private int _questLimitNum; // 0x20C
	private List<LegendQuestDialogType> _realShowType; // 0x210
	private InLevelLegendQuestDialogContextData _pageData; // 0x218
	private bool _needCheckShowType; // 0x220
	private uint _targetChapterId; // 0x224
	private int _curSelectIndex; // 0x228
	private bool _isPersonalLineDataLoaded; // 0x22C
	private List<uint> _curShowLineIdList; // 0x230

	// Constructors
	public InLevelLegendQuestDialogContext() {} // Dummy constructor
	public InLevelLegendQuestDialogContext(uint targetChapterId = 0 /* Metadata: 0x00B0F903 */) {} // 0x0000000185701700-0x00000001857018B0
	public InLevelLegendQuestDialogContext(LegendQuestDialogType type, uint targetId = 0 /* Metadata: 0x00B0F907 */) {} // 0x0000000185701540-0x0000000185701700

	// Methods
	// [XID] // 0x0000000189A36200-0x0000000189A36220
	private void ClearCoopView() {} // 0x00000001856F9EE0-0x00000001856FA040
	// [XID] // 0x0000000189A3D800-0x0000000189A3D820
	private void SetCoopView() {} // 0x00000001856F8DD0-0x00000001856F8FA0
	// [XID] // 0x0000000189A44F80-0x0000000189A44FA0
	private void RefreshCoopView() {} // 0x00000001856F9350-0x00000001856F9830
	// [XID] // 0x0000000189A4C6C0-0x0000000189A4C6E0
	private void OnCoopAvatarScrollerInit(Transform trans, int index) {} // 0x00000001856F9830-0x00000001856F9AD0
	// [XID] // 0x0000000189A53EA0-0x0000000189A53EC0
	private void CheckAvatarColRP(MonoCoopAvatarCol avatarCol, int index) {} // 0x00000001856FBB10-0x00000001856FBCE0
	// [XID] // 0x0000000189A5B8D0-0x0000000189A5B8F0
	private void ResetSelectAvatar() {} // 0x00000001856FB9E0-0x00000001856FBB10
	// [XID] // 0x0000000189A62F80-0x0000000189A62FA0
	private void SelectAvatar(int index) {} // 0x00000001856FEB50-0x00000001856FF0B0
	// [XID] // 0x0000000189A6AAE0-0x0000000189A6AB00
	private void SelectTargetAvatar() {} // 0x00000001856F7010-0x00000001856F70D0
	// [XID] // 0x0000000189A721A0-0x0000000189A721C0
	private void SetAvatarChapterViewed(int index) {} // 0x00000001856FA040-0x00000001856FA260
	// [XID] // 0x0000000189A79E40-0x0000000189A79E60
	private void CheckAvatarChapterRPShow(int index) {} // 0x00000001856F7710-0x00000001856F7970
	// [XID] // 0x0000000189A812C0-0x0000000189A812E0
	private void CheckRewardButtonShow(int index) {} // 0x0000000185700D50-0x0000000185700EF0
	// [XID] // 0x0000000189A88CA0-0x0000000189A88CC0
	private void SetBaseInfo(MonoCoopAvatarCol mono, uint avatarId) {} // 0x00000001857004D0-0x00000001857006D0
	// [XID] // 0x0000000189A90490-0x0000000189A904B0
	private void SetChapterInfo(MonoCoopAvatarCol mono, uint avatarId) {} // 0x00000001856F8AF0-0x00000001856F8DD0
	// [XID] // 0x0000000189A97C80-0x0000000189A97CA0
	private int ChapterSortFunc(uint x, uint y) => default; // 0x00000001856F86B0-0x00000001856F87A0
	// [XID] // 0x0000000189A9F010-0x0000000189A9F030
	public int AvatarSortFunc(uint x, uint y) => default; // 0x00000001856FC8B0-0x00000001856FCB90
	// [XID] // 0x0000000189AA6970-0x0000000189AA6990
	private void OnCoopAvatarChapterInit(Transform trans, int index) {} // 0x00000001856FC170-0x00000001856FC450
	// [XID] // 0x0000000189AADFE0-0x0000000189AAE000
	private void RefreshChapterRP(MonoCoopChapterRow chapterRow, uint chapterId) {} // 0x00000001856F6E80-0x00000001856F7010
	// [XID] // 0x0000000189AB5910-0x0000000189AB5930
	private void RefreshChapterStateAccept(MonoCoopChapterRow chapterRow, CoopChapter info) {} // 0x00000001856FE6D0-0x00000001856FEB50
	// [XID] // 0x0000000189ABD2F0-0x0000000189ABD310
	private void RefreshChapterRewardState(MonoCoopChapterRow chapterRow, uint chapterId) {} // 0x00000001857006D0-0x00000001857009D0
	// [XID] // 0x0000000189AC4D20-0x0000000189AC4D40
	private void OpenReward(uint chapterId) {} // 0x00000001856F9B60-0x00000001856F9CD0
	// [XID] // 0x0000000189ACC3A0-0x0000000189ACC3C0
	private void GotoPointPage(uint chapterId) {} // 0x00000001856F91D0-0x00000001856F9350
	// [XID] // 0x0000000189AD3EC0-0x0000000189AD3EE0
	private void RefreshChapterStateCondMeet(MonoCoopChapterRow chapterRow, CoopChapter info, CoopChapterExcelConfig config) {} // 0x00000001856FDE20-0x00000001856FE200
	// [XID] // 0x0000000189ADB9C0-0x0000000189ADB9E0
	private void UnlockTip(uint chapterId, string materialName, uint num, string chapterName) {} // 0x00000001856FBCE0-0x00000001856FC000
	// [XID] // 0x0000000189AE3320-0x0000000189AE3340
	private void RefreshChapterStateCondNotMeet(MonoCoopChapterRow chapterRow, CoopChapter info) {} // 0x00000001856FB1B0-0x00000001856FB630
	// [XID] // 0x0000000189AEAC90-0x0000000189AEACB0
	private void RefreshAvatarRPShowRange() {} // 0x00000001857009D0-0x0000000185700B70
	// [XID] // 0x0000000189AF2560-0x0000000189AF2580
	private void OnScrollerValueChanged(Vector2 scrollerValue) {} // 0x00000001856FA2F0-0x00000001856FA3A0
	// [XID] // 0x0000000189AF9F20-0x0000000189AF9F40
	private void CheckRPArrowIconShow() {} // 0x00000001856FB630-0x00000001856FB9E0
	// [XID] // 0x0000000189B01430-0x0000000189B01450
	private MonoCoopChapterRow GetSelectedChapter(int index) => default; // 0x00000001856FA960-0x00000001856FAAE0
	// [XID] // 0x0000000189B08940-0x0000000189B08960
	private void OnSelectChange(Transform prevItem, int prevIndex, Transform curItem, int curIndex) {} // 0x00000001856F83C0-0x00000001856F85C0
	// [XID] // 0x0000000189B10340-0x0000000189B10360
	private void HightLightChapterRow(Transform trans, bool select) {} // 0x00000001856FF540-0x00000001856FF6F0
	// [XID] // 0x0000000189B17480-0x0000000189B174A0
	private void HightLightTopChapter() {} // 0x00000001856F9D70-0x00000001856F9EE0
	// [XID] // 0x0000000189B1EDC0-0x0000000189B1EDE0
	private void FocusAvatarCol() {} // 0x00000001856FF6F0-0x00000001856FF840
	// [XID] // 0x0000000189B26710-0x0000000189B26730
	protected override void BindViewCallbacks() {} // 0x00000001856F7DD0-0x00000001856F7F80
	// [XID] // 0x0000000189B2D920-0x0000000189B2D940
	protected override void BindRedPoints() {} // 0x00000001856F7CA0-0x00000001856F7DD0
	// [XID] // 0x0000000189B34D40-0x0000000189B34D60
	public override void ClearView() {} // 0x00000001856F8980-0x00000001856F8AF0
	// [XID] // 0x0000000189B3C5F0-0x0000000189B3C610
	public override void SetupView() {} // 0x00000001857013F0-0x0000000185701540
	// [XID] // 0x0000000189B44270-0x0000000189B44290
	protected override void OnEnable() {} // 0x00000001856FFEE0-0x0000000185700000
	// [XID] // 0x0000000189B4B960-0x0000000189B4B980
	private void CheckShowType() {} // 0x00000001856F7F80-0x00000001856F8270
	// [XID] // 0x0000000189B52F50-0x0000000189B52F70
	private void EnterLegendQuestPanel(LegendQuestDialogType type) {} // 0x00000001856F73F0-0x00000001856F7540
	// [XID] // 0x0000000189B5A900-0x0000000189B5A920
	private void SetJoypadView(LegendQuestDialogType type) {} // 0x0000000185700B70-0x0000000185700D50
	// [XID] // 0x0000000189B61DB0-0x0000000189B61DD0
	private void SetContentView(LegendQuestDialogType type) {} // 0x00000001856FF840-0x00000001856FFA80
	// [XID] // 0x0000000189B69A40-0x0000000189B69A60
	private void SetCommonView() {} // 0x00000001856FAC00-0x00000001856FAD70
	// [XID] // 0x0000000189B71000-0x0000000189B71020
	private void SetMenuTab() {} // 0x00000001856FE260-0x00000001856FE6D0
	// [XID] // 0x0000000189B785D0-0x0000000189B785F0
	private int GetTabIndexByDialogType(LegendQuestDialogType type) => default; // 0x00000001856FA830-0x00000001856FA960
	// [XID] // 0x0000000189B7FB30-0x0000000189B7FB50
	private void OnTabClicked(int index) {} // 0x00000001856FA530-0x00000001856FA630
	// [XID] // 0x0000000189B875C0-0x0000000189B875E0
	private void SelectTab(int index) {} // 0x00000001856F87A0-0x00000001856F8980
	// [XID] // 0x0000000189B8E710-0x0000000189B8E730
	private Sprite GetLegendTabIcon(int index) => default; // 0x00000001856F85C0-0x00000001856F86B0
	// [XID] // 0x0000000189B95C30-0x0000000189B95C50
	private void RequestTabInformation(LegendQuestDialogType type) {} // 0x00000001856FA3A0-0x00000001856FA530
	// [XID] // 0x0000000189B9D190-0x0000000189B9D1B0
	private void TryEnterPersonalLine(LegendQuestDialogType type) {} // 0x00000001856F72F0-0x00000001856F73F0
	// [IDTag] // 0x0000000189BA4AF0-0x0000000189BA4B30
	// [XID] // 0x0000000189BA4AF0-0x0000000189BA4B30
	private void ResetSelectTarget() {} // 0x00000001856FC000-0x00000001856FC0B0
	// [IDTag] // 0x0000000189BAEC90-0x0000000189BAECD0
	// [XID] // 0x0000000189BAEC90-0x0000000189BAECD0
	private void ResetSelectTarget(LegendQuestDialogType type) {} // 0x00000001856FC0B0-0x00000001856FC170
	// [XID] // 0x0000000189BB9170-0x0000000189BB9190
	public override bool OnNotify(Notify ntf) => default; // 0x00000001857001A0-0x00000001857004D0
	// [XID] // 0x0000000189BC0F40-0x0000000189BC0F60
	private void OnPrevBtnClick() {} // 0x00000001856F7BE0-0x00000001856F7CA0
	// [XID] // 0x0000000189BC8690-0x0000000189BC86B0
	private void OnNextBtnClick() {} // 0x00000001856F7650-0x00000001856F7710
	// [XID] // 0x0000000189BCFF30-0x0000000189BCFF50
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001856FAD70-0x00000001856FB070
	// [XID] // 0x0000000189BD7530-0x0000000189BD7550
	private bool HandlePersonalLinePanelEvent(InputActionEvent actionEvent) => default; // 0x00000001856F7540-0x00000001856F7650
	// [XID] // 0x0000000189BDF030-0x0000000189BDF050
	private bool HandleCoopPanleEvent(InputActionEvent actionEvent) => default; // 0x00000001856FCF00-0x00000001856FD390
	// [XID] // 0x00000001895EBCA0-0x00000001895EBCC0
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B0F90B */) {} // 0x0000000185700000-0x00000001857001A0
	// [XID] // 0x00000001895F3040-0x00000001895F3060
	private void OnConfirmBtnPress() {} // 0x00000001856FB070-0x00000001856FB150
	// [XID] // 0x00000001895FA880-0x00000001895FA8A0
	private void ChoosePrevChapter() {} // 0x00000001856FC450-0x00000001856FC570
	// [XID] // 0x0000000189602270-0x0000000189602290
	private void ChooseNextChapter() {} // 0x00000001856F8270-0x00000001856F83C0
	// [XID] // 0x0000000189609A50-0x0000000189609A70
	private void OnGetKey() {} // 0x00000001856F79D0-0x00000001856F7AD0
	// [XID] // 0x0000000189611220-0x0000000189611240
	private void RefreshProgressScroller() {} // 0x00000001856F7AD0-0x00000001856F7BE0
	// [XID] // 0x0000000189618BF0-0x0000000189618C10
	private void OnProgressScrollerInit(Transform trans, int index) {} // 0x00000001856F9000-0x00000001856F91D0
	// [XID] // 0x0000000189620120-0x0000000189620140
	private void SetPageText() {} // 0x0000000185700EF0-0x00000001857013F0
	// [XID] // 0x0000000189627590-0x00000001896275B0
	private void OnInfoBtnClick() {} // 0x00000001856FCB90-0x00000001856FCCA0
	// [XID] // 0x000000018962F0B0-0x000000018962F0D0
	private void OnFetchBtnClick() {} // 0x00000001856FFB10-0x00000001856FFEE0
	// [XID] // 0x0000000189636A50-0x0000000189636A70
	private void SetPersonalLineView() {} // 0x00000001856FA630-0x00000001856FA830
	// [XID] // 0x000000018963DF80-0x000000018963DFA0
	private void RefreshChapterScroller() {} // 0x00000001856FF140-0x00000001856FF540
	// [XID] // 0x0000000189645910-0x0000000189645930
	private void RefreshPersonalLineAllData() {} // 0x00000001856FCCA0-0x00000001856FCF00
	// [XID] // 0x000000018964D120-0x000000018964D140
	private void SetSelectChapterRow(int index, bool flg, bool forceMove = false /* Metadata: 0x00B0F90F */) {} // 0x00000001856FC570-0x00000001856FC8B0
	// [XID] // 0x00000001896548C0-0x00000001896548E0
	private void OnChapterScrollerInit(Transform trans, int index) {} // 0x00000001856FD570-0x00000001856FDE20
	// [XID] // 0x000000018965BFB0-0x000000018965BFD0
	private void OnChapterRowClick(int index) {} // 0x00000001856FD390-0x00000001856FD570
	// [XID] // 0x0000000189663630-0x0000000189663650
	private void OnUnlockChapter(uint id) {} // 0x00000001856F70D0-0x00000001856F72F0
}

