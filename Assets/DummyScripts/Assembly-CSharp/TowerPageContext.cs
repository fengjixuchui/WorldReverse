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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TowerPageContext : BasePageContext, FilterReceiver // TypeDefIndex: 29331
{
	// Fields
	private static TowerPageType _closeType; // 0x00
	private TowerPageType _type; // 0x190
	private TowerPageType _lastType; // 0x194
	private MonoTowerPage _pageMono; // 0x198
	private uint _pointId; // 0x1A0
	private uint _nextFloorId; // 0x1A4
	private bool _enterTeamPanel; // 0x1A8
	private List<SimpleItemStruct> _items; // 0x1B0
	private int _levelRightStickType; // 0x1B8
	private bool _forceLockFloor; // 0x1BC
	private List<uint> _floorList; // 0x1C0
	private int _selectFloorIndex; // 0x1C8
	private int _openFloorMaxIndex; // 0x1CC
	private int _entranceFloorIndex; // 0x1D0
	public static readonly int[] STAR_COUNT_ARRAY; // 0x08
	private List<TowerLevelExcelConfig> _levelList; // 0x1D8
	private List<DungeonLevelEntityConfig> _factorList; // 0x1E0
	private AvatarPreviewScreenDialogContext _screenDialog; // 0x1E8
	private List<ulong> _avatarList; // 0x1F0
	private TowerTeamData _teamFirst; // 0x1F8
	private TowerTeamData _teamSecond; // 0x200
	private bool _isDoubleTeam; // 0x208
	private int _selectTeamIndex; // 0x20C
	private const int MAX_TEAM_MEMBER = 4; // Metadata: 0x00B0F607
	private SortType _sortType; // 0x210
	private bool _isAsce; // 0x214

	// Nested types
	public enum TowerPageType // TypeDefIndex: 29332
	{
		ENTER = 0,
		FLOOR = 1,
		LEVEL = 2,
		TEAM = 3,
		FLOOR_EX = 4
	}

	// Constructors
	public TowerPageContext() {} // Dummy constructor
	public TowerPageContext(uint pointId) {} // 0x0000000184A1BE50-0x0000000184A1BFF0
	public TowerPageContext(uint pointId, uint nextFloorId) {} // 0x0000000184A1BCA0-0x0000000184A1BE50
	static TowerPageContext() {} // 0x0000000184A1BBF0-0x0000000184A1BCA0

	// Methods
	// [XID] // 0x00000001899ABD40-0x00000001899ABD60
	public static void ClearCloseType() {} // 0x0000000184A175C0-0x0000000184A17680
	// [XID] // 0x00000001899B3670-0x00000001899B3690
	public override void SetupView() {} // 0x0000000184A1BAE0-0x0000000184A1BBF0
	// [XID] // 0x00000001899BA9F0-0x00000001899BAA10
	public override void ClearView() {} // 0x0000000184A0FD80-0x0000000184A0FE70
	// [XID] // 0x00000001899C2350-0x00000001899C2370
	protected override void BindViewCallbacks() {} // 0x0000000184A0E1B0-0x0000000184A0EA70
	// [XID] // 0x00000001899C9A40-0x00000001899C9A60
	public override bool OnNotify(Notify ntf) => default; // 0x0000000184A1AA80-0x0000000184A1AB90
	// [XID] // 0x00000001899D12F0-0x00000001899D1310
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000184A13E60-0x0000000184A14010
	// [XID] // 0x00000001899D8780-0x00000001899D87A0
	protected override void OnEnable() {} // 0x0000000184A1A950-0x0000000184A1AA80
	// [XID] // 0x00000001899DFE90-0x00000001899DFEB0
	private void OnGetTowerAllDataNotify() {} // 0x0000000184A0CD80-0x0000000184A0D1F0
	// [XID] // 0x00000001899E7880-0x00000001899E78A0
	private void CheckResumeDialogShow() {} // 0x0000000184A15F00-0x0000000184A164A0
	// [XID] // 0x00000001899EEDF0-0x00000001899EEE10
	private void EnterTowerPanel(TowerPageType type) {} // 0x0000000184A0F530-0x0000000184A0F970
	// [XID] // 0x00000001899F66D0-0x00000001899F66F0
	private void CheckTowerReview() {} // 0x0000000184A14D60-0x0000000184A14F60
	// [XID] // 0x00000001899FDC50-0x00000001899FDC70
	private void CheckCommemorativeReward() {} // 0x0000000184A0FF40-0x0000000184A10250
	// [XID] // 0x0000000189A05630-0x0000000189A05650
	private void CheckSkipToFloor() {} // 0x0000000184A19240-0x0000000184A192E0
	[DebuggerHidden] // 0x0000000189A0C950-0x0000000189A0C990
	// [XID] // 0x0000000189A0C950-0x0000000189A0C990
	private IEnumerator PlaySkipToFloorAnim() => default; // 0x0000000184A11790-0x0000000184A118A0
	// [XID] // 0x0000000189A16E40-0x0000000189A16E60
	private void CheckSkipFloorGrantedReward() {} // 0x0000000184A12D30-0x0000000184A13210
	// [XID] // 0x0000000189A1E500-0x0000000189A1E520
	private void SetContentView(TowerPageType type) {} // 0x0000000184A198F0-0x0000000184A19AF0
	// [XID] // 0x0000000189A25BE0-0x0000000189A25C00
	private void SetPanelAnimTrigger(TowerPageType type) {} // 0x0000000184A169C0-0x0000000184A16C90
	// [XID] // 0x0000000189A2D040-0x0000000189A2D060
	private void OnReturnButtonClick() {} // 0x0000000184A1B8F0-0x0000000184A1BAE0
	// [XID] // 0x0000000189A34A40-0x0000000189A34A60
	private void OnStartButtonClick() {} // 0x0000000184A19780-0x0000000184A198F0
	// [XID] // 0x0000000189A3BDF0-0x0000000189A3BE10
	private void OnRuleButtonClick() {} // 0x0000000184A0F420-0x0000000184A0F530
	// [XID] // 0x0000000189A43A40-0x0000000189A43A60
	private void OnBuffButtonClick() {} // 0x0000000184A13910-0x0000000184A13A80
	// [XID] // 0x0000000189A4AE90-0x0000000189A4AEB0
	private void OnRewardButtonClick() {} // 0x0000000184A180D0-0x0000000184A18260
	// [XID] // 0x0000000189A525B0-0x0000000189A525D0
	private void OnBookButtonClick() {} // 0x0000000184A17680-0x0000000184A17760
	// [XID] // 0x0000000189A59F00-0x0000000189A59F20
	private void OnTowerRecordHandbookRefresh() {} // 0x0000000184A118A0-0x0000000184A119A0
	// [XID] // 0x0000000189A616D0-0x0000000189A616F0
	private void OnGetTowerStarRewardNotify(List<SimpleItemStruct> items) {} // 0x0000000184A15A10-0x0000000184A15B40
	// [XID] // 0x0000000189A69610-0x0000000189A69630
	private void OnExit() {} // 0x0000000184A0E030-0x0000000184A0E1B0
	// [XID] // 0x0000000189A70960-0x0000000189A70980
	private void OnResonanceBtnClick() {} // 0x0000000184A166F0-0x0000000184A168A0
	// [XID] // 0x0000000189A78230-0x0000000189A78250
	private bool HandleEnterInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000184A11620-0x0000000184A11790
	// [XID] // 0x0000000189A7F840-0x0000000189A7F860
	private MonoGridScroller GeFloorScroller() => default; // 0x0000000184A15B40-0x0000000184A15C40
	// [XID] // 0x0000000189A87540-0x0000000189A87560
	private bool HandleFloorInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000184A14590-0x0000000184A14CA0
	// [XID] // 0x0000000189A8ECE0-0x0000000189A8ED00
	private void ResolveFloorRewardButton() {} // 0x0000000184A0DC60-0x0000000184A0E030
	// [XID] // 0x0000000189A96350-0x0000000189A96370
	private void CheckLevelRightStick() {} // 0x0000000184A192E0-0x0000000184A194D0
	// [XID] // 0x0000000189A9D8A0-0x0000000189A9D8C0
	private bool HandleLevelInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000184A18260-0x0000000184A18CE0
	// [XID] // 0x0000000189AA5190-0x0000000189AA51B0
	private void ResolveLevelRewardButton() {} // 0x0000000184A171F0-0x0000000184A175C0
	// [XID] // 0x0000000189AAC910-0x0000000189AAC930
	private bool HandleTeamInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000184A19AF0-0x0000000184A1A380
	// [XID] // 0x0000000189AB41D0-0x0000000189AB41F0
	private bool HandleSortInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000184A17760-0x0000000184A179F0
	// [XID] // 0x0000000189ABBF10-0x0000000189ABBF30
	private void RefreshTeamConfirmBtn() {} // 0x0000000184A10F10-0x0000000184A115C0
	// [XID] // 0x0000000189AC36A0-0x0000000189AC36C0
	private void SetFloorView() {} // 0x0000000184A15C40-0x0000000184A15D70
	// [XID] // 0x0000000189ACAD30-0x0000000189ACAD50
	private void RefreshTowerFloorList() {} // 0x0000000184A14010-0x0000000184A14440
	// [XID] // 0x0000000189AD27C0-0x0000000189AD27E0
	private void RefreshFloorView(bool resetIndex = true /* Metadata: 0x00B0F603 */) {} // 0x0000000184A10370-0x0000000184A10A90
	// [XID] // 0x0000000189ADA210-0x0000000189ADA230
	private void ClearFloorCurTarget() {} // 0x0000000184A10250-0x0000000184A10370
	// [XID] // 0x0000000189AE1AD0-0x0000000189AE1AF0
	private void SetCurIndexWithRefresh() {} // 0x0000000184A13D70-0x0000000184A13E60
	// [XID] // 0x0000000189AE9280-0x0000000189AE92A0
	private void RefreshTowerFloorItem(Transform trans, int index) {} // 0x0000000184A164A0-0x0000000184A166F0
	// [XID] // 0x0000000189AF1090-0x0000000189AF10B0
	private void RefreshTowerFloorExItem(Transform trans, int index) {} // 0x0000000184A0DB80-0x0000000184A0DC60
	[DebuggerHidden] // 0x0000000189AF8530-0x0000000189AF8570
	// [XID] // 0x0000000189AF8530-0x0000000189AF8570
	private IEnumerator PlayFinishedEntranceFloorAnim(MonoTowerFloorItem item) => default; // 0x0000000184A15170-0x0000000184A15280
	// [XID] // 0x0000000189B02B20-0x0000000189B02B40
	private void SetFloorItemView(MonoTowerFloorItem item, uint floorId, bool forceEnable = false /* Metadata: 0x00B0F604 */, bool forceLock = false /* Metadata: 0x00B0F605 */) {} // 0x0000000184A0EA70-0x0000000184A0F420
	// [XID] // 0x0000000189B0A330-0x0000000189B0A350
	private uint GetFloorUnlockStarCount(TowerFloorExcelConfig floorConfig) => default; // 0x0000000184A19660-0x0000000184A19780
	// [XID] // 0x0000000189B11AF0-0x0000000189B11B10
	private int GetFloorOpenRemainingTime(uint floorId) => default; // 0x0000000184A0F970-0x0000000184A0FA90
	// [XID] // 0x0000000189B18DE0-0x0000000189B18E00
	private int GetStarProgress(uint starNum) => default; // 0x0000000184A190D0-0x0000000184A19240
	// [XID] // 0x0000000189B20430-0x0000000189B20450
	private void OnTowerFloorItemClick(int index) {} // 0x0000000184A10C50-0x0000000184A10F10
	// [XID] // 0x0000000189B27AB0-0x0000000189B27AD0
	private void OnTowerFloorRewardClick(int index) {} // 0x0000000184A17DF0-0x0000000184A180D0
	// [XID] // 0x0000000189B2EDF0-0x0000000189B2EE10
	private void SetLevelView() {} // 0x0000000184A12650-0x0000000184A127D0
	// [XID] // 0x0000000189B366B0-0x0000000189B366D0
	private void RefreshTowerLevelList() {} // 0x0000000184A0D1F0-0x0000000184A0D430
	// [XID] // 0x0000000189B3DF20-0x0000000189B3DF40
	private void RefreshLevelView(bool haveFactorAnim = false /* Metadata: 0x00B0F606 */) {} // 0x0000000184A11BA0-0x0000000184A12650
	// [XID] // 0x0000000189B45C70-0x0000000189B45C90
	private void RefreshTowerLevelItem(Transform trans, int index) {} // 0x0000000184A0D630-0x0000000184A0DB80
	// [XID] // 0x0000000189B4D0F0-0x0000000189B4D110
	private void OnTowerLevelItemClick(int index) {} // 0x0000000184A15D70-0x0000000184A15F00
	// [XID] // 0x0000000189B548F0-0x0000000189B54910
	private void RefreshFloorFactorItem(Transform trans, int index) {} // 0x0000000184A179F0-0x0000000184A17B80
	// [XID] // 0x0000000189B5C490-0x0000000189B5C4B0
	private void RefreshFloorFactorItemWithAnim(Transform trans, int index) {} // 0x0000000184A12940-0x0000000184A12B40
	// [XID] // 0x0000000189B63A40-0x0000000189B63A60
	private void OnLevelStartBtnClick() {} // 0x0000000184A134D0-0x0000000184A13580
	// [XID] // 0x0000000189B6B220-0x0000000189B6B240
	private void OnLevelPrevBtnClick() {} // 0x0000000184A0FE70-0x0000000184A0FF40
	// [XID] // 0x0000000189B72820-0x0000000189B72840
	private void OnLevelNextBtnClick() {} // 0x0000000184A16F50-0x0000000184A17030
	// [XID] // 0x0000000189B79D50-0x0000000189B79D70
	private void PlayPrevNextBtnAnim(bool isPrev) {} // 0x0000000184A13210-0x0000000184A13440
	// [XID] // 0x0000000189B81480-0x0000000189B814A0
	private void OnFloorBackBtnClick() {} // 0x0000000184A1A410-0x0000000184A1A4C0
	// [XID] // 0x0000000189B88BF0-0x0000000189B88C10
	private void SetTeamView() {} // 0x0000000184A127D0-0x0000000184A12940
	// [XID] // 0x0000000189B900E0-0x0000000189B90100
	private void RefreshDefaultAvatarList() {} // 0x0000000184A13A80-0x0000000184A13D10
	// [XID] // 0x0000000189B97580-0x0000000189B975A0
	private void RefreshTeamView() {} // 0x0000000184A1AB90-0x0000000184A1B550
	// [XID] // 0x0000000189B9E9A0-0x0000000189B9E9C0
	private void RefreshAvatarItem(Transform trans, int index) {} // 0x0000000184A1A4C0-0x0000000184A1A950
	// [XID] // 0x0000000189BA62F0-0x0000000189BA6310
	private void OnAvatarItemClick(int index) {} // 0x0000000184A15280-0x0000000184A15A10
	// [XID] // 0x0000000189BAD580-0x0000000189BAD5A0
	private void RefreshFirstTeamAvatarItem(Transform trans, int index) {} // 0x0000000184A1B600-0x0000000184A1B8F0
	// [XID] // 0x0000000189BB4CF0-0x0000000189BB4D10
	private void RefreshSecondTeamAvatarItem(Transform trans, int index) {} // 0x0000000184A0FA90-0x0000000184A0FD80
	// [XID] // 0x0000000189BBC320-0x0000000189BBC340
	private void OnFirstTeamAvatarItemClick(int index) {} // 0x0000000184A14F60-0x0000000184A15170
	// [XID] // 0x0000000189BC4000-0x0000000189BC4020
	private void OnSecondTeamAvatarItemClick(int index) {} // 0x0000000184A10A90-0x0000000184A10C50
	// [XID] // 0x0000000189BCB9D0-0x0000000189BCB9F0
	private void SetAvatarIconAddStyle(MonoAvatarIcon avatarIcon) {} // 0x0000000184A119A0-0x0000000184A11BA0
	// [XID] // 0x0000000189BD2F40-0x0000000189BD2F60
	private void OnFirstTeamBtnClick() {} // 0x0000000184A194D0-0x0000000184A19600
	// [XID] // 0x0000000189BDA740-0x0000000189BDA760
	private void OnSecondTeamBtnClick() {} // 0x0000000184A12B40-0x0000000184A12C70
	// [XID] // 0x00000001895E7130-0x00000001895E7150
	private void OnTeamStartBtnClick() {} // 0x0000000184A17B80-0x0000000184A17DF0
	// [XID] // 0x00000001895EEA80-0x00000001895EEAA0
	private void SetupSortTypeDropdown() {} // 0x0000000184A13580-0x0000000184A13910
	// [XID] // 0x00000001895F6420-0x00000001895F6440
	private SortType SortDropdownIndexToType(int index) => default; // 0x0000000184A168A0-0x0000000184A169C0
	// [XID] // 0x00000001895FD770-0x00000001895FD790
	private void OnSortTypeChange(int index) {} // 0x0000000184A16C90-0x0000000184A16F50
	// [XID] // 0x0000000189605000-0x0000000189605020
	private void ChangeSortOrder() {} // 0x0000000184A17030-0x0000000184A171F0
	// [XID] // 0x000000018960CA70-0x000000018960CA90
	private void OnScreenBtnClick() {} // 0x0000000184A0D430-0x0000000184A0D630
	// [XID] // 0x0000000189613FE0-0x0000000189614000
	void MoleMole.FilterReceiver.RefreshScreenAvatarPanel(List<ulong> screenAvatarList) {} // 0x0000000184A18E40-0x0000000184A19020
	// [XID] // 0x000000018961B940-0x000000018961B960
	void MoleMole.FilterReceiver.SaveScreenName(List<string> screenNameList) {} // 0x0000000184A19020-0x0000000184A190D0
	// [XID] // 0x0000000189622F60-0x0000000189622F80
	void MoleMole.FilterReceiver.ChangeStateID(int id) {} // 0x0000000184A18CE0-0x0000000184A18D90
	// [XID] // 0x000000018962A710-0x000000018962A730
	void MoleMole.FilterReceiver.ChangeToAvatarStateID() {} // 0x0000000184A18D90-0x0000000184A18E40
}

