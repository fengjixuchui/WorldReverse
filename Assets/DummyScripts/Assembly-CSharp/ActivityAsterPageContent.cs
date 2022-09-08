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

public sealed class ActivityAsterPageContent : BasePageContext // TypeDefIndex: 29362
{
	// Fields
	private MonoActivityAsterPage _pageMono; // 0x190
	private ActivityInfo activityInfo; // 0x198
	private AsterPhase _curShowStage; // 0x1A0
	private GameObject _shopMaterialPrefab; // 0x1A8
	private List<MonoShopMaterial> _shopMaterialsList; // 0x1B0
	private const string SHOP_MAT_PATH = "ART/UI/Menus/Widget/ShopMaterialsItem"; // Metadata: 0x00B0F66D
	private uint _shopMaterialHandler; // 0x1B8
	private bool isPlayAnimation; // 0x1BC
	private int _selectMainButton; // 0x1C0
	private AsterStageExcelConfig largeStageConfig; // 0x1C8
	private List<IdCountStrConfig> _rewardPreviewList; // 0x1D0
	private ScenePlayInfo scenePlayInfo; // 0x1D8
	private MessagePushPageContext _pushPage; // 0x1E0
	private uint _curStateId; // 0x1E8
	private AsterLittleExcelConfig asterLittleConfig; // 0x1F0
	private List<AsterWatcherStruct> asterLittleWatcherList; // 0x1F8
	private List<RewardItemConfig> _tempRewardList; // 0x200
	private AsterStageExcelConfig littleStageConfig; // 0x208
	private MessagePushPageContext _pushPageLittle; // 0x210
	private List<AsterWatcherStruct> asterMiddleWatcherList; // 0x218
	private AsterStageExcelConfig middleStageConfig; // 0x220
	private MessagePushPageContext _pushPageMid; // 0x228

	// Constructors
	public ActivityAsterPageContent() {} // 0x00000001819F7F90-0x00000001819F8130

	// Methods
	// [XID] // 0x0000000189BA8F10-0x0000000189BA8F30
	public override void SetupView() {} // 0x00000001819F7C70-0x00000001819F7F90
	// [XID] // 0x0000000189BB06C0-0x0000000189BB06E0
	protected override void BindViewCallbacks() {} // 0x00000001819EDA10-0x00000001819EE250
	// [XID] // 0x0000000189BB7A20-0x0000000189BB7A40
	protected override void BindRedPoints() {} // 0x00000001819ED6D0-0x00000001819EDA10
	// [XID] // 0x0000000189BBF060-0x0000000189BBF080
	private void Refresh() {} // 0x00000001819EC790-0x00000001819EC9F0
	// [XID] // 0x0000000189BC6D30-0x0000000189BC6D50
	private void SetupMainButton() {} // 0x00000001819EF960-0x00000001819EFF00
	// [XID] // 0x0000000189BCEA00-0x0000000189BCEA20
	private void OnClickAiMi() {} // 0x00000001819F3F50-0x00000001819F4100
	// [XID] // 0x0000000189BD5CC0-0x0000000189BD5CE0
	private void UpdateMaterialsList() {} // 0x00000001819F06D0-0x00000001819F0A50
	// [XID] // 0x0000000189BDD950-0x0000000189BDD970
	private void UpdateMaterialCount() {} // 0x00000001819F7AE0-0x00000001819F7C70
	// [XID] // 0x00000001895EA530-0x00000001895EA550
	private void OnClickReturn() {} // 0x00000001819F7280-0x00000001819F74F0
	// [XID] // 0x00000001895F1990-0x00000001895F19B0
	private void OnClickShop() {} // 0x00000001819EEB60-0x00000001819EECF0
	// [XID] // 0x00000001895F93B0-0x00000001895F93D0
	private void OnClickTask() {} // 0x00000001819F0270-0x00000001819F0420
	// [XID] // 0x0000000189600A00-0x0000000189600A20
	private void OnClickBtnExplain() {} // 0x00000001819F5E80-0x00000001819F6030
	// [XID] // 0x0000000189608320-0x0000000189608340
	private void OnClickBtnPre() {} // 0x00000001819ECD10-0x00000001819ECDC0
	// [XID] // 0x000000018960FC80-0x000000018960FCA0
	private void OnClickBtnNext() {} // 0x00000001819F4E80-0x00000001819F5040
	// [XID] // 0x0000000189616F60-0x0000000189616F80
	protected override void OnEnable() {} // 0x00000001819F5370-0x00000001819F54F0
	// [XID] // 0x000000018961EAE0-0x000000018961EB00
	private void ShortFadeIn(bool bShort) {} // 0x00000001819EECF0-0x00000001819EEFD0
	// [XID] // 0x0000000189625EE0-0x0000000189625F00
	private void OnClickStageBtn(int stage) {} // 0x00000001819F2340-0x00000001819F2730
	// [XID] // 0x000000018962D8A0-0x000000018962D8C0
	private void RefreshTabSwitch() {} // 0x00000001819EF2A0-0x00000001819EF590
	// [XID] // 0x0000000189635420-0x0000000189635440
	private void SetupMainView() {} // 0x00000001819F0620-0x00000001819F06D0
	// [XID] // 0x000000018963CAC0-0x000000018963CAE0
	private void SwitchAniator() {} // 0x00000001819F1F70-0x00000001819F2110
	// [XID] // 0x0000000189644140-0x0000000189644160
	public override bool OnNotify(Notify ntf) => default; // 0x00000001819F5B10-0x00000001819F5CC0
	// [XID] // 0x000000018964B8F0-0x000000018964B910
	private void ChechRedPoint() {} // 0x00000001819F30C0-0x00000001819F31A0
	// [XID] // 0x0000000189653080-0x00000001896530A0
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x00000001819F4730-0x00000001819F4830
	// [XID] // 0x000000018965A740-0x000000018965A760
	private void WatcherUpdateRefresh() {} // 0x00000001819ED340-0x00000001819ED420
	// [XID] // 0x0000000189661D70-0x0000000189661D90
	public override void ClearView() {} // 0x00000001819EE760-0x00000001819EE940
	// [XID] // 0x0000000189669950-0x0000000189669970
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001819F1D00-0x00000001819F1E70
	// [XID] // 0x0000000189671480-0x00000001896714A0
	private void NextMainButton() {} // 0x00000001819EF8A0-0x00000001819EF960
	// [XID] // 0x0000000189678D40-0x0000000189678D60
	private void PreMainButton() {} // 0x00000001819EE3D0-0x00000001819EE490
	// [XID] // 0x0000000189680450-0x0000000189680470
	private void ConfirmMainButton() {} // 0x00000001819F31A0-0x00000001819F3340
	// [XID] // 0x0000000189687F50-0x0000000189687F70
	private void SetMainButtonHighLight() {} // 0x00000001819F0420-0x00000001819F0620
	// [XID] // 0x000000018968F9B0-0x000000018968F9D0
	private void ReSetMainButtonHighLight() {} // 0x00000001819EE490-0x00000001819EE630
	// [XID] // 0x00000001896973B0-0x00000001896973D0
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transforn, JoypadSelectIndexResult selectResult) {} // 0x00000001819F59E0-0x00000001819F5B10
	// [XID] // 0x000000018969E900-0x000000018969E920
	private void SetupLargeView() {} // 0x00000001819F6C50-0x00000001819F7280
	// [XID] // 0x00000001896A58F0-0x00000001896A5910
	private void SetLargeInfo() {} // 0x00000001819EC9F0-0x00000001819ECD10
	// [XID] // 0x00000001896AD170-0x00000001896AD190
	private void SetupRewardPreview() {} // 0x00000001819F44C0-0x00000001819F4730
	// [XID] // 0x00000001896B47A0-0x00000001896B47C0
	private void RefreshItemIcon(Transform trans, int index) {} // 0x00000001819F4960-0x00000001819F4C20
	// [XID] // 0x00000001896BBA10-0x00000001896BBA30
	private void SetupTeamBuff() {} // 0x00000001819F1250-0x00000001819F1510
	// [XID] // 0x00000001896C2ED0-0x00000001896C2EF0
	private void RefreshTeamBuffItem(Transform trans, int index) {} // 0x00000001819F50D0-0x00000001819F5370
	// [XID] // 0x00000001896CA360-0x00000001896CA380
	private void OnClickTeamBuffItem(uint id) {} // 0x00000001819ED1D0-0x00000001819ED2E0
	// [XID] // 0x00000001896D1A10-0x00000001896D1A30
	private void OnClickGotoLarge() {} // 0x00000001819F4100-0x00000001819F42D0
	// [XID] // 0x00000001896D9220-0x00000001896D9240
	private void OnClickDescription() {} // 0x00000001819F2730-0x00000001819F2880
	// [XID] // 0x00000001896E09F0-0x00000001896E0A10
	public override void OnJoypadUIModuleFocus(MonoJoypadUIModule focusModule) {} // 0x00000001819F54F0-0x00000001819F5820
	// [XID] // 0x00000001896E7CA0-0x00000001896E7CC0
	public override void OnJoypadUIModuleLostFocus(MonoJoypadUIModule focusModule) {} // 0x00000001819F5820-0x00000001819F59E0
	// [XID] // 0x00000001896EF390-0x00000001896EF3B0
	private void largeBack() {} // 0x00000001819F3E10-0x00000001819F3F50
	// [XID] // 0x00000001896F6D60-0x00000001896F6D80
	private void SetupLittleView() {} // 0x00000001819F6120-0x00000001819F6C50
	// [XID] // 0x00000001896FE670-0x00000001896FE690
	private void OnClickDescriptionLittle() {} // 0x00000001819F5D30-0x00000001819F5E80
	// [XID] // 0x00000001897057A0-0x00000001897057C0
	private void OnClickGotoTask(uint questID) {} // 0x00000001819F2880-0x00000001819F29A0
	// [XID] // 0x000000018970D2E0-0x000000018970D300
	private void SetLittleInfo() {} // 0x00000001819EFF90-0x00000001819F01F0
	// [XID] // 0x0000000189714780-0x00000001897147A0
	private void SetMissionGroup() {} // 0x00000001819F33E0-0x00000001819F3700
	// [XID] // 0x000000018971C190-0x000000018971C1B0
	private void OnClickItem(int index) {} // 0x00000001819F4C20-0x00000001819F4D80
	// [XID] // 0x00000001897235E0-0x0000000189723600
	private void RefreshTaskItem(Transform trans, int index) {} // 0x00000001819F0A50-0x00000001819F1040
	// [XID] // 0x000000018972AD80-0x000000018972ADA0
	private void RefreshRewardItems(Transform trans, int index) {} // 0x00000001819EE940-0x00000001819EEB60
	// [XID] // 0x0000000189732430-0x0000000189732450
	private void TryTracking(int index) {} // 0x00000001819F1040-0x00000001819F1250
	// [XID] // 0x0000000189739B60-0x0000000189739B80
	private void loadActivityAsterArea(ulong perfabPath) {} // 0x00000001819F2200-0x00000001819F2340
	// [XID] // 0x0000000189741760-0x0000000189741780
	private void ReceiveTargetReward(uint watcherId) {} // 0x00000001819EE250-0x00000001819EE370
	// [XID] // 0x0000000189749040-0x0000000189749060
	private void SetupLittleAsterWatcherList() {} // 0x00000001819F38B0-0x00000001819F3E10
	// [XID] // 0x00000001897504B0-0x00000001897504D0
	private int CompareAsterWatcherStruct(AsterWatcherStruct xData, AsterWatcherStruct yData) => default; // 0x00000001819F1570-0x00000001819F16B0
	// [XID] // 0x0000000189757A50-0x0000000189757A70
	public void OnJoypadUIModuleSelectIndex_Little(MonoJoypadUIModule sourceModule, int index, JoypadSelectIndexResult selectResult) {} // 0x00000001819EE630-0x00000001819EE760
	// [XID] // 0x000000018975F470-0x000000018975F490
	private void UpdateButtonByIndex_Little(int index) {} // 0x00000001819F42D0-0x00000001819F44C0
	// [XID] // 0x0000000189766960-0x0000000189766980
	private void littleBack() {} // 0x00000001819F2110-0x00000001819F2200
	// [XID] // 0x000000018976DF10-0x000000018976DF30
	private void SetupMiddleView() {} // 0x00000001819F74F0-0x00000001819F7AE0
	// [XID] // 0x0000000189775670-0x0000000189775690
	private void SetMiddleInfo() {} // 0x00000001819ED480-0x00000001819ED6D0
	// [XID] // 0x000000018977CEF0-0x000000018977CF10
	private void OnClickDescriptionMid() {} // 0x00000001819F3700-0x00000001819F3850
	// [XID] // 0x00000001897848F0-0x0000000189784910
	private void OnClickGotoCollect() {} // 0x00000001819F29A0-0x00000001819F30C0
	// [XID] // 0x000000018978BEE0-0x000000018978BF00
	private void SetMissionGroupMid() {} // 0x00000001819EF590-0x00000001819EF8A0
	// [XID] // 0x0000000189793330-0x0000000189793350
	private void RefreshMidTaskItem(Transform trans, int index) {} // 0x00000001819F16B0-0x00000001819F1D00
	// [XID] // 0x000000018979B5C0-0x000000018979B5E0
	private void SetupMiddleAsterWatcherList() {} // 0x00000001819ECDC0-0x00000001819ED1D0
	// [XID] // 0x00000001897A2A60-0x00000001897A2A80
	public void OnJoypadUIModuleSelectIndex_Middle(MonoJoypadUIModule sourceModule, int index, JoypadSelectIndexResult selectResult) {} // 0x00000001819F4830-0x00000001819F4960
	// [XID] // 0x00000001897AA000-0x00000001897AA020
	private void UpdateButtonByIndex_Middle(int index) {} // 0x00000001819EEFD0-0x00000001819EF1C0
	// [XID] // 0x00000001897B1A10-0x00000001897B1A30
	private void middleBack() {} // 0x00000001819F6030-0x00000001819F6120
}

