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

public sealed class HomeWorldBuildingPageContext : BasePageContext // TypeDefIndex: 30222
{
	// Fields
	private uint QUICK_FETCH_MATERIAL; // 0x190
	private MonoHomeWorldBuildingPage _pageMono; // 0x198
	private DataHelper _pageData; // 0x1A0
	private TabState _tabState; // 0x1A8
	private SubTabState _subTabState; // 0x1AC
	private JoyPadActiveRegion _joyPadActiveRegion; // 0x1B0
	private bool _friendAssistOn; // 0x1B4
	private bool _screenOn; // 0x1B5
	private int _formulaSelectIndex; // 0x1B8
	private int _queueSelectIndex; // 0x1BC
	private const string _needItemTagPath = "ART/UI/Menus/Widget/Btn_Tag_NeedItem"; // Metadata: 0x00B108D1
	private uint _resourceHandler; // 0x1C0
	private GameObject _needItemTagPrefab; // 0x1C8
	private float _playerInfoGetTime; // 0x1D0
	private List<SimpleItemStruct> _itemGotList; // 0x1D8
	private MonoJoypadGridScrollerHandler _formulaScrollerHandler; // 0x1E0
	private MonoJoypadGridScrollerHandler _queueScrollerHandler; // 0x1E8
	private MonoJoypadSimpleResuableListHandler _constructMaterialScrollerHandler; // 0x1F0
	private MonoJoypadSimpleResuableListHandler _dyestuffMaterialScrollerHandler; // 0x1F8
	private MonoJoypadGridScrollerHandler _screenScrollerHandler; // 0x200
	private MonoJoypadGridScrollerHandler _friendAssistScrollerHandler; // 0x208
	private MonoJoypadGridScrollerHandler _gotPanelScrollerHandler; // 0x210
	private uint _maxQueueNum; // 0x218
	private uint _curQueueNum; // 0x21C
	private Dictionary<uint, FurnitureBuildSlotData> _queueData; // 0x220
	private bool _isConstructEmpty; // 0x228
	private List<uint> _constructList; // 0x230
	private List<uint> _dyestuffList; // 0x238
	private List<uint> _consoleIconReusableList; // 0x240
	private string _consoleIconName; // 0x248
	private bool _isFirstTimeBuild; // 0x250
	private FurnitureMakeExcelConfig _currMakeExcelConfig; // 0x258
	private bool _buildingNow; // 0x260
	private List<IdCountConfig> _constructNeedItemList; // 0x268
	private uint _currSelectMaterialMinLevel; // 0x270
	private CombineExcelConfig _currSelectCombineExcelConfig; // 0x278
	private List<IdCountConfig> _dyestuffNeedItemList; // 0x280
	private uint _dyestuffCanCombineNum; // 0x288
	private uint _dyestuffDoCombineNum; // 0x28C
	private FurnitureBuildSlotData? _queueSlotData; // 0x290
	private const float CONSOLE_VIEW_TICK_GAP = 1f; // Metadata: 0x00B108F9
	private float _consoleViewNextTickTime; // 0x2A4
	private bool _hasAnyHelp; // 0x2A8
	private RepeatedMessageField<FurnitureMakeBeHelpedData> _friendAssistedData; // 0x2B0
	private bool _isReverse; // 0x2B8
	private int _selectedFurnitureScreenIndex; // 0x2BC
	private string _screenButtonText; // 0x2C0
	private List<ShopMaterial> _shopMaterialId; // 0x2C8

	// Nested types
	private enum TabState // TypeDefIndex: 30223
	{
		Construct = 0,
		Dyestuff = 1
	}

	private enum SubTabState // TypeDefIndex: 30224
	{
		Formula = 0,
		Queue = 1
	}

	private enum JoyPadActiveRegion // TypeDefIndex: 30225
	{
		Left = 0,
		Right = 1
	}

	private class DataHelper // TypeDefIndex: 30226
	{
		// Fields
		public const uint DyestuffCombineTypeA = 7; // Metadata: 0x00B10917
		public const uint DyestuffCombineTypeB = 8; // Metadata: 0x00B1091B
		private uint _maxConstructSlotNum; // 0x10
		private Dictionary<uint, uint> _slotUnlockLevelDict; // 0x18
		private const string ScreenAllTextMapId = "EQUIP_SCREEN_ALL"; // Metadata: 0x00B1091F
		private Dictionary<string, HashSet<uint>> _constructSortScreenDict; // 0x20
		private List<string> _constructScreenStr; // 0x28
		private Dictionary<uint, List<CombineExcelConfig>> _dyestuffDict; // 0x30
		private Dictionary<uint, CombineExcelConfig> _chosenFormulaDict; // 0x38

		// Properties
		public Dictionary<uint, List<CombineExcelConfig>> DyestuffDict { /* [XID] */ /* 0x00000001899A4240-0x00000001899A4260 */ get => default; } // 0x00000001833FB010-0x00000001833FB0B0 
		public uint MaxConstructSlotNum { /* [XID] */ /* 0x00000001899ABBE0-0x00000001899ABC00 */ get => default; } // 0x00000001833FACB0-0x00000001833FAD50 
		public Dictionary<uint, uint> SlotUnlockLevelDict { /* [XID] */ /* 0x00000001899B3530-0x00000001899B3550 */ get => default; } // 0x00000001833FAD50-0x00000001833FADF0 
		public Dictionary<uint, CombineExcelConfig> ChosenFormulaDict { /* [XID] */ /* 0x00000001899BA910-0x00000001899BA930 */ get => default; } // 0x00000001833FB5A0-0x00000001833FB640 
		public List<string> ConstructScreenNames { /* [XID] */ /* 0x00000001899C2210-0x00000001899C2230 */ get => default; } // 0x00000001833FB160-0x00000001833FB200 

		// Constructors
		public DataHelper() {} // 0x00000001833FD340-0x00000001833FD490

		// Methods
		// [XID] // 0x00000001899C9940-0x00000001899C9960
		public bool CanFurnitureMake(FurnitureMakeExcelConfig makeExcelConfig) => default; // 0x00000001833FAAF0-0x00000001833FACB0
		// [XID] // 0x00000001899D1170-0x00000001899D1190
		public void GetConstructList(ref List<uint> resultList, string screen = null, bool isReverse = false /* Metadata: 0x00B10915 */) {} // 0x00000001833FB200-0x00000001833FB320
		// [XID] // 0x00000001899D8660-0x00000001899D8680
		public bool CanDyestuffCombine(CombineExcelConfig combineExcelConfig) => default; // 0x00000001833FB3E0-0x00000001833FB5A0
		// [XID] // 0x00000001899DFD10-0x00000001899DFD30
		public bool CanDyestuffAllFormulaCombine(uint resultId) => default; // 0x00000001833FC1D0-0x00000001833FC4C0
		// [XID] // 0x00000001899E7720-0x00000001899E7740
		public void GetDyestuffList(ref List<uint> resultList) {} // 0x00000001833FAF20-0x00000001833FB010
		// [XID] // 0x00000001899EECD0-0x00000001899EECF0
		public uint GetConstructTypeNum(string screenName = null) => default; // 0x00000001833FADF0-0x00000001833FAF20
		// [XID] // 0x00000001899F6590-0x00000001899F65B0
		public uint GetDyestuffMinPlayerLevel(uint resultId) => default; // 0x00000001833FBFC0-0x00000001833FC1D0
		// [XID] // 0x00000001899FDAD0-0x00000001899FDAF0
		public bool IsFurnitureFirstTimeBuild(uint furnitureId) => default; // 0x00000001833FB640-0x00000001833FB770
		// [XID] // 0x0000000189A054F0-0x0000000189A05510
		private void Clear() {} // 0x00000001833FB320-0x00000001833FB3E0
		// [XID] // 0x0000000189A0C850-0x0000000189A0C870
		private void ClearConstructSlotNum() {} // 0x00000001833FD2A0-0x00000001833FD340
		// [XID] // 0x0000000189A141C0-0x0000000189A141E0
		private void BuildConstructSlotNum() {} // 0x00000001833FCEC0-0x00000001833FD1D0
		// [XID] // 0x0000000189A1B430-0x0000000189A1B450
		private void ClearConstruct() {} // 0x00000001833FD1D0-0x00000001833FD2A0
		// [XID] // 0x0000000189A22D30-0x0000000189A22D50
		private void BuildConstruct() {} // 0x00000001833FA610-0x00000001833FAAF0
		// [XID] // 0x0000000189A2A000-0x0000000189A2A020
		private void CLearDyestuff() {} // 0x00000001833FB0B0-0x00000001833FB160
		// [XID] // 0x0000000189A314E0-0x0000000189A31500
		private void BuildDyestuff() {} // 0x00000001833FB770-0x00000001833FBFC0
		// [XID] // 0x0000000189A38FB0-0x0000000189A38FD0
		private void FilterDyestuffList(ref List<uint> combineList) {} // 0x00000001833FC4C0-0x00000001833FCA00
		// [XID] // 0x0000000189A40730-0x0000000189A40750
		private void FilterConstructList(ref List<uint> constructList, string screen = null, bool isReverse = false /* Metadata: 0x00B10916 */) {} // 0x00000001833FCA00-0x00000001833FCEC0
	}

	// Constructors
	public HomeWorldBuildingPageContext() {} // 0x00000001833EF0B0-0x00000001833EF3E0

	// Methods
	// [XID] // 0x0000000189797D90-0x0000000189797DB0
	public override void SetupView() {} // 0x00000001833EEDB0-0x00000001833EF010
	// [XID] // 0x000000018979FA70-0x000000018979FA90
	protected override void OnEnable() {} // 0x00000001833EE940-0x00000001833EEA00
	// [XID] // 0x00000001897A7070-0x00000001897A7090
	public override void ClearView() {} // 0x00000001833E4540-0x00000001833E45E0
	// [XID] // 0x00000001897AE9E0-0x00000001897AEA00
	public override void ClosePage() {} // 0x00000001833E1EA0-0x00000001833E1F90
	// [XID] // 0x00000001897B6870-0x00000001897B6890
	protected override void BindViewCallbacks() {} // 0x00000001833E2630-0x00000001833E2DC0
	// [XID] // 0x00000001897BE6D0-0x00000001897BE6F0
	protected override void BindRedPoints() {} // 0x00000001833E24A0-0x00000001833E2630
	// [XID] // 0x00000001897C5D60-0x00000001897C5D80
	public override bool OnNotify(Notify ntf) => default; // 0x00000001833EEA00-0x00000001833EEBD0
	// [XID] // 0x00000001897CD580-0x00000001897CD5A0
	public override void UpdateView() {} // 0x00000001833EF010-0x00000001833EF0B0
	// [XID] // 0x00000001897D4B80-0x00000001897D4BA0
	private void RefreshData(bool keepList = false /* Metadata: 0x00B108CE */) {} // 0x00000001833E72E0-0x00000001833E7570
	// [XID] // 0x00000001897DC200-0x00000001897DC220
	private void RefreshView() {} // 0x00000001833E7DE0-0x00000001833E85B0
	// [XID] // 0x00000001897E3B50-0x00000001897E3B70
	private void RefreshData_Construct(bool keepList = false /* Metadata: 0x00B108CF */) {} // 0x00000001833E12C0-0x00000001833E1490
	// [XID] // 0x00000001897EB7E0-0x00000001897EB800
	private void RefreshView_Construct() {} // 0x00000001833E8960-0x00000001833E91D0
	// [XID] // 0x00000001897F3060-0x00000001897F3080
	private void RefreshData_Dyestuff(bool keepList = false /* Metadata: 0x00B108D0 */) {} // 0x00000001833EBD50-0x00000001833EBE90
	// [XID] // 0x00000001897FA910-0x00000001897FA930
	private void RefreshView_Dyestuff() {} // 0x00000001833EDBC0-0x00000001833EE070
	// [XID] // 0x0000000189801F20-0x0000000189801F40
	private void RefreshData_Console() {} // 0x00000001833E2DC0-0x00000001833E3670
	// [XID] // 0x0000000189809370-0x0000000189809390
	private void RefreshView_Console() {} // 0x00000001833E45E0-0x00000001833E6130
	// [XID] // 0x0000000189810BA0-0x0000000189810BC0
	private void UpdateView_Console() {} // 0x00000001833E19E0-0x00000001833E1C20
	// [XID] // 0x0000000189818650-0x0000000189818670
	private void SetConsoleShowItem(uint id) {} // 0x00000001833E98F0-0x00000001833E99C0
	// [XID] // 0x000000018981FEA0-0x000000018981FEC0
	private void ClearConsoleItem() {} // 0x00000001833E1C20-0x00000001833E1CE0
	// [XID] // 0x0000000189827480-0x00000001898274A0
	private void OnDyestuffCombineNumCountChange() {} // 0x00000001833EE070-0x00000001833EE380
	// [XID] // 0x000000018982E700-0x000000018982E720
	private void RefreshData_FriendAssist() {} // 0x00000001833EEBD0-0x00000001833EECF0
	// [XID] // 0x0000000189836080-0x00000001898360A0
	private void RefreshView_FriendAssist() {} // 0x00000001833EB230-0x00000001833EB6C0
	// [XID] // 0x000000018983D5B0-0x000000018983D5D0
	private void RefreshData_ScreenSort() {} // 0x00000001833ECA30-0x00000001833ECB40
	// [XID] // 0x0000000189844DF0-0x0000000189844E10
	private void RefreshView_ScreenSort() {} // 0x00000001833EAEC0-0x00000001833EB230
	// [XID] // 0x000000018984C200-0x000000018984C220
	private void RefreshData_ShopMaterial() {} // 0x00000001833E20B0-0x00000001833E21C0
	// [XID] // 0x00000001898533D0-0x00000001898533F0
	private void RefreshView_ShopMaterial() {} // 0x00000001833E9A20-0x00000001833E9F10
	// [XID] // 0x000000018985AE60-0x000000018985AE80
	private void OnNotify_HomeWorldFurnitureMakeInfoRefresh(HomeworldModule.BuildDataRefreshReason reason) {} // 0x00000001833E1CE0-0x00000001833E1EA0
	// [XID] // 0x0000000189862300-0x0000000189862320
	private void OnNotify_ConstructDyestuffResultGet(List<SimpleItemStruct> itemList) {} // 0x00000001833E91D0-0x00000001833E9440
	// [XID] // 0x0000000189869790-0x00000001898697B0
	private void OnNotify_GetPlaySocialDetailNotify(SocialDetail serverData) {} // 0x00000001833E68F0-0x00000001833E69D0
	// [XID] // 0x0000000189870990-0x00000001898709B0
	private void OnNotify_HomeWorldLevelUp(object level) {} // 0x00000001833ED990-0x00000001833EDAE0
	// [XID] // 0x0000000189878420-0x0000000189878440
	private void OnNotify_ConstructCancel(List<SimpleItemStruct> itemList) {} // 0x00000001833ED890-0x00000001833ED990
	// [XID] // 0x000000018987F930-0x000000018987F950
	private void ScrollerRefreshItem_ConstructFormula(Transform trans, int index) {} // 0x00000001833E9440-0x00000001833E98F0
	// [XID] // 0x0000000189886F80-0x0000000189886FA0
	private void ScrollerRefreshItem_ConstructFormula_ActionButtonClicked(int index) {} // 0x00000001833EC4E0-0x00000001833EC930
	// [XID] // 0x000000018988E110-0x000000018988E130
	private void ScrollerRefreshItem_Queue(Transform trans, int index) {} // 0x00000001833E4090-0x00000001833E4420
	// [XID] // 0x0000000189895760-0x0000000189895780
	private void ScrollerRefreshItem_Queue_ActionButtonClicked(int index) {} // 0x00000001833EB9A0-0x00000001833EBD50
	// [XID] // 0x000000018989CEC0-0x000000018989CEE0
	private void ScrollerRefreshItem_DyestuffFormula(Transform trans, int index) {} // 0x00000001833ECC10-0x00000001833ECFE0
	// [XID] // 0x00000001898A4680-0x00000001898A46A0
	private void ScrollerRefreshItem_DyestuffFormula_ActionButtonClicked(int index) {} // 0x00000001833E39B0-0x00000001833E3D50
	// [XID] // 0x00000001898ABB40-0x00000001898ABB60
	private void ReusableListRefreshItem_Console(Transform trans, int index) {} // 0x00000001833E65B0-0x00000001833E68F0
	// [XID] // 0x00000001898B32F0-0x00000001898B3310
	private void ReusableListRefreshItem_ConsoleConstruct(Transform trans, int index) {} // 0x00000001833E3D50-0x00000001833E4090
	// [XID] // 0x00000001898BAFF0-0x00000001898BB010
	private void ReusableListRefreshItem_ConsoleDyestuff(Transform trans, int index) {} // 0x00000001833E3670-0x00000001833E39B0
	// [XID] // 0x00000001898C2360-0x00000001898C2380
	private void ScrollerRefreshItem_FriendAssist(Transform trans, int index) {} // 0x00000001833EB6C0-0x00000001833EB9A0
	// [XID] // 0x00000001898C9D80-0x00000001898C9DA0
	private void ScrollerRefreshItem_ScreenPanel(Transform trans, int index) {} // 0x00000001833E6190-0x00000001833E6520
	// [XID] // 0x00000001898D1380-0x00000001898D13A0
	private void ScrollerRefreshItem_ItemGotPanel(Transform trans, int index) {} // 0x00000001833E1490-0x00000001833E1780
	// [XID] // 0x00000001898D8C40-0x00000001898D8C60
	private void OnButtonClicked_ConstructTab() {} // 0x00000001833EC400-0x00000001833EC4E0
	// [XID] // 0x00000001898E0910-0x00000001898E0930
	private void OnButtonClicked_DyestuffTab() {} // 0x00000001833E69D0-0x00000001833E6AB0
	// [XID] // 0x00000001898E8470-0x00000001898E8490
	private void OnButtonClicked_ConstructFormulaTab() {} // 0x00000001833EAD30-0x00000001833EAE10
	// [XID] // 0x00000001898EFBF0-0x00000001898EFC10
	private void OnButtonClicked_ConstructQueueTab() {} // 0x00000001833EDAE0-0x00000001833EDBC0
	// [XID] // 0x00000001898F7430-0x00000001898F7450
	private void OnButtonClicked_RecipeSelect() {} // 0x00000001833ED4D0-0x00000001833ED890
	// [XID] // 0x00000001898FEBA0-0x00000001898FEBC0
	private void OnButtonClicked_RecipeSelect_Callback(uint combineId) {} // 0x00000001833ECFE0-0x00000001833ED210
	// [XID] // 0x00000001899062E0-0x0000000189906300
	private void OnButtonClicked_DyestuffSliderAdd() {} // 0x00000001833E7570-0x00000001833E7630
	// [XID] // 0x000000018990DDA0-0x000000018990DDC0
	private void OnButtonClicked_DyestuffSliderMinus() {} // 0x00000001833E1F90-0x00000001833E2050
	// [XID] // 0x0000000189915530-0x0000000189915550
	private void OnSliderValueChange_DyestuffNumSlider(float value) {} // 0x00000001833E8610-0x00000001833E86E0
	// [XID] // 0x000000018991CF80-0x000000018991CFA0
	private void OnButtonClicked_StartBuild() {} // 0x00000001833E9F10-0x00000001833EAD30
	// [XID] // 0x00000001899247F0-0x0000000189924810
	private void OnButtonClicked_SettlementClose() {} // 0x00000001833EC930-0x00000001833ECA30
	// [XID] // 0x000000018992BDA0-0x000000018992BDC0
	private void OnButtonClicked_StopBuild() {} // 0x00000001833E86E0-0x00000001833E8960
	// [XID] // 0x00000001899332D0-0x00000001899332F0
	private void OnButtonClicked_Fetch() {} // 0x00000001833EBE90-0x00000001833EC400
	// [XID] // 0x000000018993AE40-0x000000018993AE60
	private void OnButtonClicked_FriendAssist() {} // 0x00000001833EAE10-0x00000001833EAEC0
	// [XID] // 0x0000000189941EB0-0x0000000189941ED0
	private void OnButtonClicked_FriendAssistClose() {} // 0x00000001833E76F0-0x00000001833E77A0
	// [XID] // 0x0000000189949990-0x00000001899499B0
	private void OnButtonClicked_SortReverse() {} // 0x00000001833EECF0-0x00000001833EEDB0
	// [XID] // 0x00000001899513C0-0x00000001899513E0
	private void OnButtonClicked_Screen() {} // 0x00000001833EE890-0x00000001833EE940
	// [XID] // 0x00000001899589F0-0x0000000189958A10
	private void OnButtonClicked_ScreenClose() {} // 0x00000001833E1910-0x00000001833E19E0
	// [XID] // 0x0000000189960030-0x0000000189960050
	private void OnButtonClicked_JumpActiveRegion() {} // 0x00000001833ECB40-0x00000001833ECC10
	// [XID] // 0x0000000189967AF0-0x0000000189967B10
	private void OnButtonClicked_Return() {} // 0x00000001833E11F0-0x00000001833E12C0
	// [XID] // 0x000000018996EC90-0x000000018996ECB0
	private void BuildJotStickHandler() {} // 0x00000001833EE380-0x00000001833EE800
	// [XID] // 0x0000000189976890-0x00000001899768B0
	private void CalculateCurrentJoyPadHandlerFocusState() {} // 0x00000001833E6AB0-0x00000001833E72E0
	// [XID] // 0x000000018997DCB0-0x000000018997DCD0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001833E77A0-0x00000001833E7DE0
	// [XID] // 0x0000000189985660-0x0000000189985680
	private static bool JoyStickSimulatePointerClick(object btn) => default; // 0x00000001833E21C0-0x00000001833E24A0
	// [XID] // 0x000000018998D430-0x000000018998D450
	private void ShowFetchButtonNeedItemTag(bool show) {} // 0x00000001833E4420-0x00000001833E4540
	// [XID] // 0x0000000189994EB0-0x0000000189994ED0
	private void SetQuickFetchButtonTag(uint makeId) {} // 0x00000001833E1780-0x00000001833E1910
	// [XID] // 0x000000018999C790-0x000000018999C7B0
	private Transform GetNeedItemTag() => default; // 0x00000001833ED270-0x00000001833ED4D0
}

