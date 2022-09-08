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

public sealed class ReputationPageContext : BasePageContext // TypeDefIndex: 29248
{
	// Fields
	private const string BG_EFFECT_PATH = "ART/Effect/UI/UI/"; // Metadata: 0x00B0EECE
	private PanelState _panelState; // 0x190
	private MonoReputationPage _pageMono; // 0x198
	private CityConfig _cityConfig; // 0x1A0
	private uint _cityId; // 0x1A8
	private MaterialExcelConfig _reputationItemConfig; // 0x1B0
	private CityReputationInfo _cityReputationInfo; // 0x1B8
	private uint _bgEffectHandler; // 0x1C0
	private GameObject _bgEffectPrefab; // 0x1C8
	private RepeatedMessageField<HuntingOfferData> _huntingDataList; // 0x1D0
	private bool _showOneHunting; // 0x1D8
	private bool _needShowHuntingTakenAnim; // 0x1D9
	private RepeatedMessageField<CityReputationRequestInfo.Types.RequestInfo> _requestInfoList; // 0x1E0
	private List<ReputationExploreExcelConfig> _exploreInfoList; // 0x1E8
	private List<RewardItemConfig> _tempRewardList; // 0x1F0
	private List<ReputationQuestExcelConfig> _questConfigList; // 0x1F8

	// Nested types
	private enum PanelState // TypeDefIndex: 29249
	{
		None = -1,
		Main = 0,
		Hunting = 1,
		Resident = 2,
		Explore = 3,
		Quest = 4
	}

	// Constructors
	public ReputationPageContext() {} // Dummy constructor
	public ReputationPageContext(CityConfig cityConfig) {} // 0x0000000185201B40-0x0000000185201C60

	// Methods
	// [XID] // 0x0000000189942030-0x0000000189942050
	public override void SetupView() {} // 0x0000000185201810-0x0000000185201B40
	// [XID] // 0x0000000189949AB0-0x0000000189949AD0
	public override void ClearView() {} // 0x00000001851F9490-0x00000001851F95A0
	// [XID] // 0x0000000189951540-0x0000000189951560
	public override void ClosePage() {} // 0x00000001851F8AC0-0x00000001851F8BA0
	// [XID] // 0x0000000189958B50-0x0000000189958B70
	protected override void OnEnable() {} // 0x00000001851FF650-0x00000001851FF830
	// [XID] // 0x00000001899601B0-0x00000001899601D0
	public override bool OnNotify(Notify ntf) => default; // 0x00000001851FFD00-0x0000000185200110
	// [XID] // 0x0000000189967C50-0x0000000189967C70
	protected override void BindViewCallbacks() {} // 0x00000001851F9190-0x00000001851F92F0
	// [XID] // 0x000000018996EE50-0x000000018996EE70
	protected override void BindRedPoints() {} // 0x00000001851F8F40-0x00000001851F9190
	// [XID] // 0x0000000189976A30-0x0000000189976A50
	private void SetRedPointShow() {} // 0x00000001851FC630-0x00000001851FC900
	// [XID] // 0x000000018997DE70-0x000000018997DE90
	private void SetupCity() {} // 0x00000001851FCE70-0x00000001851FD1B0
	// [XID] // 0x0000000189985850-0x0000000189985870
	public void InitLevel() {} // 0x00000001851FD370-0x00000001851FD6A0
	// [XID] // 0x000000018998D570-0x000000018998D590
	private void InitTime() {} // 0x00000001851FD1B0-0x00000001851FD300
	// [XID] // 0x0000000189994FF0-0x0000000189995010
	private void SwitchPanel(PanelState newState) {} // 0x00000001851FD6A0-0x00000001851FD7C0
	// [XID] // 0x000000018999C990-0x000000018999C9B0
	private void InitAllPanels() {} // 0x00000001851F87D0-0x00000001851F88B0
	// [XID] // 0x00000001899A43A0-0x00000001899A43C0
	private void RefreshPanel(PanelState state) {} // 0x00000001852008B0-0x0000000185200DE0
	// [XID] // 0x00000001899ABD60-0x00000001899ABD80
	private void ShowPanel(PanelState state, bool show) {} // 0x00000001851FB9C0-0x00000001851FBBF0
	// [XID] // 0x00000001899B3690-0x00000001899B36B0
	private void ShowDescription() {} // 0x0000000185200110-0x00000001852002B0
	// [XID] // 0x00000001899BAA10-0x00000001899BAA30
	private void ShowRewardDialog() {} // 0x00000001851FCA50-0x00000001851FCB70
	// [XID] // 0x00000001899C2370-0x00000001899C2390
	private void InitHunting() {} // 0x00000001852002B0-0x00000001852008B0
	// [XID] // 0x00000001899C9A60-0x00000001899C9A80
	private void InitHuntingItem() {} // 0x00000001851FF090-0x00000001851FF5C0
	// [XID] // 0x00000001899D1310-0x00000001899D1330
	private void ShowOneHuntingPanel(bool show) {} // 0x00000001851FD7C0-0x00000001851FD8F0
	// [XID] // 0x00000001899D87A0-0x00000001899D87C0
	private void InitHuntingRewardItem(Transform trans, int index) {} // 0x0000000185201220-0x0000000185201810
	// [XID] // 0x00000001899DFEB0-0x00000001899DFED0
	private void InitResident() {} // 0x00000001851F95A0-0x00000001851F9DB0
	// [XID] // 0x00000001899E78A0-0x00000001899E78C0
	private void InitResidentRewardItem(Transform trans, int index) {} // 0x00000001851FA2F0-0x00000001851FA610
	// [XID] // 0x00000001899EEE10-0x00000001899EEE30
	private void InitExplore() {} // 0x00000001851FADD0-0x00000001851FB650
	// [XID] // 0x00000001899F6730-0x00000001899F6750
	private int ExploreSortOrder(ReputationExploreExcelConfig config1, ReputationExploreExcelConfig config2) => default; // 0x00000001851F88B0-0x00000001851F8AC0
	// [XID] // 0x00000001899FDC70-0x00000001899FDC90
	private void InitExploreRewardItem(Transform trans, int index) {} // 0x00000001851FEC40-0x00000001851FF030
	// [XID] // 0x0000000189A05650-0x0000000189A05670
	private void InitRewardItem(Transform trans, int index) {} // 0x00000001851FA6B0-0x00000001851FA8D0
	// [XID] // 0x0000000189A0C990-0x0000000189A0C9B0
	private void RequestAllExploreRewards() {} // 0x0000000185200DE0-0x00000001852010B0
	// [XID] // 0x0000000189A142E0-0x0000000189A14300
	private void InitQuest() {} // 0x00000001851FE100-0x00000001851FEC40
	// [XID] // 0x0000000189A1B550-0x0000000189A1B570
	private int QuestSortOrder(ReputationQuestExcelConfig config1, ReputationQuestExcelConfig config2) => default; // 0x00000001851FBBF0-0x00000001851FBDD0
	// [XID] // 0x0000000189A22ED0-0x0000000189A22EF0
	private void InitQuestRewardItem(Transform trans, int index) {} // 0x00000001851FA940-0x00000001851FADD0
	// [XID] // 0x0000000189A2A160-0x0000000189A2A180
	private void RequestAllQuestRewards() {} // 0x00000001851F9FC0-0x00000001851FA280
	// [XID] // 0x0000000189A315E0-0x0000000189A31600
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x00000001851FDE80-0x00000001851FE020
	// [XID] // 0x0000000189A39090-0x0000000189A390B0
	private void OnHuntingItemAdded(List<SimpleItemStruct> items) {} // 0x00000001851FC420-0x00000001851FC5C0
	// [XID] // 0x0000000189A40870-0x0000000189A40890
	private void OnCityReputationLevelUp(CityReputationLevelupNotify ntf) {} // 0x0000000185201150-0x0000000185201220
	// [XID] // 0x0000000189A47EF0-0x0000000189A47F10
	private void RequestReputationInfo() {} // 0x00000001851FC970-0x00000001851FCA50
	// [XID] // 0x0000000189A4F6B0-0x0000000189A4F6D0
	private void RequestHuntingReputationInfo() {} // 0x00000001851FB650-0x00000001851FB800
	// [XID] // 0x0000000189A56DD0-0x0000000189A56DF0
	private void RequestHuntingInfo() {} // 0x00000001851FE020-0x00000001851FE100
	// [XID] // 0x0000000189A5E900-0x0000000189A5E920
	private bool IsOpen(PanelState newState) => default; // 0x00000001851F9360-0x00000001851F9490
	// [XID] // 0x0000000189A660E0-0x0000000189A66100
	private ReputationEntranceType panelState2EntranceType(PanelState state) => default; // 0x00000001851F8E60-0x00000001851F8F40
	// [XID] // 0x0000000189A6D750-0x0000000189A6D770
	public override bool BasePageHandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001851FBE30-0x00000001851FC230
	// [XID] // 0x0000000189A74E70-0x0000000189A74E90
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B0EEC6 */) {} // 0x00000001851FFA30-0x00000001851FFD00
	// [XID] // 0x0000000189A7CAC0-0x0000000189A7CAE0
	public override void OnJoypadUIModuleDeSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B0EECA */) {} // 0x00000001851FF830-0x00000001851FFA30
	// [XID] // 0x0000000189A843E0-0x0000000189A84400
	private void RefreshHuntingBtn() {} // 0x00000001851FCB70-0x00000001851FCE00
	// [XID] // 0x0000000189A8BD50-0x0000000189A8BD70
	private void RefreshExploreBtn() {} // 0x00000001851F9DB0-0x00000001851F9F60
	// [XID] // 0x0000000189A932C0-0x0000000189A932E0
	private void RefreshQuestBtn() {} // 0x00000001851FC230-0x00000001851FC3C0
	// [XID] // 0x0000000189A9ACE0-0x0000000189A9AD00
	private void CancelSelectEntrys() {} // 0x00000001851F8BA0-0x00000001851F8D90
	// [XID] // 0x0000000189AA2010-0x0000000189AA2030
	private void OnMenuBack() {} // 0x00000001851FB890-0x00000001851FB960
}

