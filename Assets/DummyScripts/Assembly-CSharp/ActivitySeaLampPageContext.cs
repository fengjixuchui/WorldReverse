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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class ActivitySeaLampPageContext : BasePageContext // TypeDefIndex: 28750
{
	// Fields
	private int _tabIndex; // 0x190
	private MonoActivitySeaLampPage _pageMono; // 0x198
	private ActivityInfo _seaLampActivityInfo; // 0x1A0
	private uint _lampRewardPreviewId; // 0x1A8
	private uint _lampId; // 0x1AC
	private uint _combineId; // 0x1B0
	private uint _npcMark1; // 0x1B4
	private uint _npcMark2; // 0x1B8
	private int _curDayIndex; // 0x1BC
	private bool _focusItem; // 0x1C0
	private int _focusRow; // 0x1C4
	private int _focusColumn; // 0x1C8

	// Constructors
	public ActivitySeaLampPageContext() {} // 0x0000000183111390-0x00000001831115F0

	// Methods
	// [XID] // 0x00000001896AA2E0-0x00000001896AA300
	public override void SetupView() {} // 0x00000001831111F0-0x0000000183111390
	// [XID] // 0x00000001896B1140-0x00000001896B1160
	protected override void BindViewCallbacks() {} // 0x0000000183108770-0x0000000183108FC0
	// [XID] // 0x00000001896B8D10-0x00000001896B8D30
	protected override void BindRedPoints() {} // 0x0000000183108470-0x0000000183108770
	// [XID] // 0x00000001896BFF10-0x00000001896BFF30
	public override bool OnNotify(Notify ntf) => default; // 0x0000000183110F20-0x00000001831111F0
	// [XID] // 0x00000001896C7810-0x00000001896C7830
	protected override void OnEnable() {} // 0x0000000183110E70-0x0000000183110F20
	// [XID] // 0x00000001896CEFB0-0x00000001896CEFD0
	private void OnOpenStateChangeNotify(OpenStateType type, bool active) {} // 0x0000000183109870-0x0000000183109960
	// [XID] // 0x00000001896D63B0-0x00000001896D63D0
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x000000018310F830-0x000000018310F930
	// [XID] // 0x00000001896DD9D0-0x00000001896DD9F0
	private void OnWeb() {} // 0x000000018310A4A0-0x000000018310A6A0
	// [XID] // 0x00000001896E5080-0x00000001896E50A0
	private void SwitchTab(int i) {} // 0x00000001831107A0-0x0000000183110960
	// [XID] // 0x00000001896EC520-0x00000001896EC540
	private void OnClickBtnClick() {} // 0x0000000183109C10-0x0000000183109CB0
	// [XID] // 0x00000001896F3CF0-0x00000001896F3D10
	private void OnTab1BtnClick() {} // 0x000000018310CBF0-0x000000018310CCA0
	// [XID] // 0x00000001896FB460-0x00000001896FB480
	private void OnTab2BtnClick() {} // 0x0000000183110C20-0x0000000183110CD0
	// [XID] // 0x0000000189702BF0-0x0000000189702C10
	private void OnTab3BtnClick() {} // 0x00000001831097C0-0x0000000183109870
	// [XID] // 0x000000018970A330-0x000000018970A350
	private void UpdateTabContent(bool refresh = false /* Metadata: 0x00B0E65E */) {} // 0x000000018310F560-0x000000018310F830
	// [XID] // 0x0000000189711E50-0x0000000189711E70
	private string GetTimeStr(string fmt) => default; // 0x000000018310BB40-0x000000018310BD10
	// [XID] // 0x0000000189719250-0x0000000189719270
	private void UpdateStory(int lastSeaLampOpenedQuestIndex) {} // 0x000000018310A730-0x000000018310AE50
	// [XID] // 0x0000000189720910-0x0000000189720930
	private void UpdateTab1(bool refresh) {} // 0x0000000183108110-0x0000000183108470
	// [XID] // 0x0000000189727EC0-0x0000000189727EE0
	private void ShowLampRewardPrevie(MonoSimpleReusableList rewardList) {} // 0x000000018310E190-0x000000018310E660
	// [XID] // 0x000000018972F500-0x000000018972F520
	private void UpdateTab2(bool refresh) {} // 0x000000018310FA70-0x00000001831107A0
	// [XID] // 0x0000000189736F40-0x0000000189736F60
	private void UpdateTab3(bool refresh) {} // 0x000000018310D2D0-0x000000018310E190
	// [XID] // 0x000000018973EB00-0x000000018973EB20
	private void ShowPhaseReward(uint phaseId, bool isTaken, uint factor) {} // 0x000000018310D170-0x000000018310D2D0
	// [XID] // 0x0000000189745DC0-0x0000000189745DE0
	private void TakePhaseReward(uint phaseId) {} // 0x0000000183108FC0-0x0000000183109120
	// [XID] // 0x000000018974D8B0-0x000000018974D8D0
	private void OnTipsBtn1Click() {} // 0x0000000183110D60-0x0000000183110E70
	// [XID] // 0x0000000189754EF0-0x0000000189754F10
	private void OnTipsBtn2Click() {} // 0x0000000183109B00-0x0000000183109C10
	// [XID] // 0x000000018975C080-0x000000018975C0A0
	private void OnTipsBtn3Click() {} // 0x00000001831091F0-0x0000000183109300
	// [XID] // 0x0000000189763A30-0x0000000189763A50
	private void OnLampBtnClick() {} // 0x0000000183110B50-0x0000000183110C20
	// [XID] // 0x000000018976B1F0-0x000000018976B210
	private void OnTargetBtnClick() {} // 0x000000018310F930-0x000000018310FA70
	// [XID] // 0x0000000189772840-0x0000000189772860
	private void OnContriRewardBtnClick() {} // 0x000000018310AE50-0x000000018310AF60
	// [XID] // 0x0000000189779E70-0x0000000189779E90
	private void OnGotoQuestBtnClick() {} // 0x000000018310E8E0-0x000000018310EA80
	// [XID] // 0x0000000189781AD0-0x0000000189781AF0
	private void OnWishBtnClick() {} // 0x000000018310EB60-0x000000018310ED70
	// [XID] // 0x0000000189788FD0-0x0000000189788FF0
	private void OnGotoContriBtnClick() {} // 0x00000001831099C0-0x0000000183109B00
	// [XID] // 0x00000001897905C0-0x00000001897905E0
	private void OnSwitchPrevBtnClick() {} // 0x00000001831109C0-0x0000000183110B50
	// [XID] // 0x0000000189797FB0-0x0000000189797FD0
	private void OnSwitchNextClick() {} // 0x000000018310AF60-0x000000018310B140
	// [XID] // 0x000000018979FCD0-0x000000018979FCF0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018310BEA0-0x000000018310C300
	// [XID] // 0x00000001897A7230-0x00000001897A7250
	private int GetTarRowColumnCount(int row, int count, GridLayoutGroup grid) => default; // 0x0000000183107DD0-0x00000001831080B0
	// [XID] // 0x00000001897AEC00-0x00000001897AEC20
	private int ChangeRowColumn2Index(int row, int column, GridLayoutGroup grid) => default; // 0x000000018310E660-0x000000018310E8E0
	// [XID] // 0x00000001897B6A90-0x00000001897B6AB0
	private void ClampRowColumn(int row, ref int column) {} // 0x0000000183109300-0x00000001831097C0
	// [XID] // 0x00000001897BE8B0-0x00000001897BE8D0
	private void GetFocusItem(int row, int column, out MonoBagProxySlot bagSlot, out MonoItemSlot itemSlot) {
		bagSlot = default;
		itemSlot = default;
	} // 0x000000018310B4C0-0x000000018310BB40
	// [XID] // 0x00000001897C5FC0-0x00000001897C5FE0
	private void RefreshTabItemState() {} // 0x000000018310B140-0x000000018310B4C0
	// [XID] // 0x00000001897CD7C0-0x00000001897CD7E0
	private void RefreshFocusItemState() {} // 0x0000000183107750-0x0000000183107DD0
	// [XID] // 0x00000001897D4D20-0x00000001897D4D40
	private void ShowKeyImg(MonoUITemplate template, bool show, bool withParent = false /* Metadata: 0x00B0E65F */) {} // 0x000000018310CCA0-0x000000018310CFB0
	// [XID] // 0x00000001897DC480-0x00000001897DC4A0
	private void ReturnFromFocusItem() {} // 0x000000018310EA80-0x000000018310EB60
	// [XID] // 0x00000001897E3DF0-0x00000001897E3E10
	private void EnterFocusItem() {} // 0x0000000183109120-0x00000001831091F0
	// [XID] // 0x00000001897EB9C0-0x00000001897EB9E0
	private bool FocusItemImpl(int row, int column, bool focus) => default; // 0x000000018310CFB0-0x000000018310D170
	// [XID] // 0x00000001897F32C0-0x00000001897F32E0
	private void SetCurFocusItem(int row, int column) {} // 0x000000018310BD10-0x000000018310BE40
	// [XID] // 0x00000001897FAB30-0x00000001897FAB50
	private bool HandleTab1InputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183109CB0-0x000000018310A4A0
	// [XID] // 0x00000001898020E0-0x0000000189802100
	private bool HandleTab2InputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018310ED70-0x000000018310F560
	// [XID] // 0x0000000189809570-0x0000000189809590
	private bool HandleTab3InputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018310C300-0x000000018310CBF0
}

