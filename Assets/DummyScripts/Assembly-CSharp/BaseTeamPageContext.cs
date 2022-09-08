/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using HedgehogTeam.EasyTouch;
using IFix.Core;
using MoleMole;
using UnityEngine;
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class BaseTeamPageContext : BasePageContext, FilterReceiver // TypeDefIndex: 29475
{
	// Fields
	protected const int MAX_TEAM_MEMBER = 4; // Metadata: 0x00B0F830
	protected MonoInLevelTeamPage _pageMono; // 0x190
	protected TeamUISceneComponent _uiSceneComp; // 0x198
	protected uint _currTeamId; // 0x1A0
	protected List<ulong> _teamListShow; // 0x1A8
	protected List<ulong> _teamListAll; // 0x1B0
	protected List<ulong> _filteredTeamListAll; // 0x1B8
	protected Operation _op; // 0x1C0
	protected ulong _teamSelectGUID; // 0x1C8
	protected int _teamSelectIndex; // 0x1D0
	protected int _selectIconIndex; // 0x1D4
	protected int _teamAvatarBtnDownIndex; // 0x1D8
	protected int _teamAvatarChangeToIndex; // 0x1DC
	private bool _teamAvatarBtnHold; // 0x1E0
	private bool _hasSetPickUpStyle; // 0x1E1
	private bool _showExitDialog; // 0x1E2
	private uint _showTutorialId; // 0x1E4
	protected bool _exchangeAvatar; // 0x1E8
	protected bool _canUseTeamSelectBtn; // 0x1E9
	protected bool _isShowAvatar; // 0x1EA
	private TeamPageStyle _style; // 0x1EC
	private Action _closeCB; // 0x1F0
	protected List<AvatarDataItem> explorationChaList; // 0x1F8
	private TipsTextDialogContext _tipsTextDialogContext; // 0x200
	protected const int INPUT_STATE_AVATAR_SELECT = 1; // Metadata: 0x00B0F834
	protected const int INPUT_STATE_DROPDOWN = 2; // Metadata: 0x00B0F838
	protected uint _teamShownIndex; // 0x208
	protected bool _teamSceneReady; // 0x20C
	protected ulong _neededGUID; // 0x210
	private List<Transform> _listTeamIndicator; // 0x218
	private bool _changingTeam; // 0x220
	protected UnityAction callbackOfExplorationCallback; // 0x228
	protected bool _cancelingExplore; // 0x230
	protected AvatarPanelMode avatarPanelMode; // 0x234
	protected List<ulong> _selectedListGuid; // 0x238
	private InfoTextDialogContext _infoTextDialog; // 0x240
	protected bool _reviveAvatarEnabled; // 0x248
	protected bool _reviveAvatarTriggerd; // 0x249
	public bool dungeonTarget; // 0x24A
	public uint dungeonEntryPointID; // 0x24C
	public DungeonExcelConfig dungeonConfig; // 0x250
	public EffigyChallengeExcelConfig effigyChallengeConfig; // 0x258
	public uint mechanicusLevel; // 0x260
	private AvatarPreviewScreenDialogContext _dialog; // 0x268
	private List<ulong> _filteredAvatars; // 0x270
	private SortType _sortType; // 0x278
	private bool _isAsce; // 0x27C
	private ulong _lastSelectAvatarGuid; // 0x280
	private static List<ElementType> _lackElementTypes; // 0x00
	private RegionType _currRegion; // 0x288
	private List<TeamResonanceExcelConfig> _resonanceList; // 0x290
	private List<int> _tempElemTypeList; // 0x298
	private bool _hasInitResonance; // 0x2A0
	protected bool _resonancePanelShow; // 0x2A1

	// Nested types
	protected enum Operation // TypeDefIndex: 29476
	{
		None = 0,
		Add = 1,
		Del = 2,
		Change = 3
	}

	protected enum AvatarPanelMode // TypeDefIndex: 29477
	{
		SingleMode = 0,
		FastSelectMode = 1
	}

	private enum RegionType // TypeDefIndex: 29478
	{
		AvatarLeft = 0,
		AvatarRight = 1
	}

	// Constructors
	protected BaseTeamPageContext() {} // Dummy constructor
	public BaseTeamPageContext(TeamPageStyle style = TeamPageStyle.Default /* Metadata: 0x00B0F825 */) {} // 0x0000000181BC2120-0x0000000181BC23D0
	public BaseTeamPageContext(bool showExit, uint showTutorialId = 0 /* Metadata: 0x00B0F829 */, Action callback = null) {} // 0x0000000181BC23D0-0x0000000181BC26C0
	static BaseTeamPageContext() {} // 0x0000000181BC2090-0x0000000181BC2120

	// Methods
	// [XID] // 0x00000001896338F0-0x0000000189633910
	public override void SetupView() {} // 0x0000000181BC1B70-0x0000000181BC2090
	// [XID] // 0x000000018963B1D0-0x000000018963B1F0
	protected void InitTeamTab() {} // 0x0000000181BB2B30-0x0000000181BB2D20
	// [XID] // 0x0000000189642900-0x0000000189642920
	protected virtual void OnSetupView() {} // 0x0000000181BB8890-0x0000000181BB8980
	// [XID] // 0x000000018964A030-0x000000018964A050
	protected virtual void ShowCurrentTeam() {} // 0x0000000181BB83A0-0x0000000181BB8590
	// [XID] // 0x00000001896516F0-0x0000000189651710
	protected void ShowTeamEnabledTip() {} // 0x0000000181BB54C0-0x0000000181BB5650
	// [XID] // 0x0000000189658F30-0x0000000189658F50
	public override void ClearView() {} // 0x0000000181BB58F0-0x0000000181BB5D40
	// [XID] // 0x0000000189660600-0x0000000189660620
	protected override void BindViewCallbacks() {} // 0x0000000181BB3F80-0x0000000181BB4450
	// [XID] // 0x0000000189667F40-0x0000000189667F60
	protected void OnTryChangeName() {} // 0x0000000181BBC990-0x0000000181BBCB00
	// [XID] // 0x000000018966FA00-0x000000018966FA20
	protected void RefreshTeamName() {} // 0x0000000181BBE7A0-0x0000000181BBE9B0
	// [XID] // 0x0000000189677320-0x0000000189677340
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181BB92B0-0x0000000181BB9B70
	// [XID] // 0x000000018967E890-0x000000018967E8B0
	private bool AvatarPageNavigation(ContextEventType input) => default; // 0x0000000181BB6700-0x0000000181BB69A0
	// [XID] // 0x0000000189686140-0x0000000189686160
	protected virtual void ResetIndex() {} // 0x0000000181BB1D60-0x0000000181BB1E80
	// [XID] // 0x000000018968DF30-0x000000018968DF50
	protected virtual void RefreshIndex() {} // 0x0000000181BB2510-0x0000000181BB25D0
	// [XID] // 0x0000000189695840-0x0000000189695860
	protected virtual bool CanSelectSlot(int index) => default; // 0x0000000181BB82F0-0x0000000181BB83A0
	// [XID] // 0x000000018969CED0-0x000000018969CEF0
	private int GetNextSelectableSlot(int index) => default; // 0x0000000181BBD660-0x0000000181BBD7F0
	// [XID] // 0x00000001896A41E0-0x00000001896A4200
	private int GetPrevSelectableSlot(int index) => default; // 0x0000000181BB7950-0x0000000181BB7AD0
	// [XID] // 0x00000001896AB7A0-0x00000001896AB7C0
	private void ToNextTeamSlot() {} // 0x0000000181BB72A0-0x0000000181BB7430
	// [XID] // 0x00000001896B29D0-0x00000001896B29F0
	private void ToPrevTeamSlot() {} // 0x0000000181BBB930-0x0000000181BBBAB0
	// [XID] // 0x00000001896BA160-0x00000001896BA180
	protected override void OnEnable() {} // 0x0000000181BC1090-0x0000000181BC1320
	// [XID] // 0x00000001896C13D0-0x00000001896C13F0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181BC1320-0x0000000181BC1680
	// [XID] // 0x00000001896C8AD0-0x00000001896C8AF0
	protected virtual void OnRefreshTeamShown() {} // 0x0000000181BBF990-0x0000000181BBFB40
	// [XID] // 0x00000001896D04C0-0x00000001896D04E0
	protected virtual void BindTeamAvatarBtnCallbacks() {} // 0x0000000181BC1810-0x0000000181BC1A60
	// [XID] // 0x00000001896D79C0-0x00000001896D79E0
	private void UpdateTeamCost() {} // 0x0000000181BBCD70-0x0000000181BBCF60
	// [XID] // 0x00000001896DF220-0x00000001896DF240
	private void SetTeamAvatarBtnActive(bool active) {} // 0x0000000181BBABF0-0x0000000181BBAD60
	// [XID] // 0x00000001896E6650-0x00000001896E6670
	protected virtual void ShowAvatarInTeamView() {} // 0x0000000181BB4EF0-0x0000000181BB54C0
	// [XID] // 0x00000001896EDBA0-0x00000001896EDBC0
	private void SetAvatarBtnToAdd(MonoTeamAvatarBtn ins) {} // 0x0000000181BB8E50-0x0000000181BB8F50
	// [XID] // 0x00000001896F53D0-0x00000001896F53F0
	private void SetSubTeamAvatarBtnsActive(bool active) {} // 0x0000000181BB3E00-0x0000000181BB3F80
	// [XID] // 0x00000001896FCC10-0x00000001896FCC30
	protected void OnClose() {} // 0x0000000181BB8AE0-0x0000000181BB8C80
	// [XID] // 0x0000000189704090-0x00000001897040B0
	protected virtual void ExitPage() {} // 0x0000000181BB8980-0x0000000181BB8AE0
	// [XID] // 0x000000018970B9A0-0x000000018970B9C0
	protected void OnCancel() {} // 0x0000000181BB7430-0x0000000181BB7550
	// [XID] // 0x0000000189713270-0x0000000189713290
	protected virtual void OnChange() {} // 0x0000000181BB69A0-0x0000000181BB72A0
	// [XID] // 0x000000018971AA30-0x000000018971AA50
	protected virtual List<AvatarDataItem> GetNewExplorationList() => default; // 0x0000000181BB8050-0x0000000181BB82F0
	// [XID] // 0x0000000189721DB0-0x0000000189721DD0
	protected virtual void DoChangeTeamMember() {} // 0x0000000181BC0C10-0x0000000181BC0D90
	// [XID] // 0x0000000189729480-0x00000001897294A0
	protected bool CheckCanChangeLocalAvatar() => default; // 0x0000000181BBB0E0-0x0000000181BBB380
	// [XID] // 0x0000000189730C60-0x0000000189730C80
	private void PreCalcAllCost(ulong currGuid, ulong selectGuid) {} // 0x0000000181BB1E80-0x0000000181BB2050
	// [XID] // 0x0000000189738590-0x00000001897385B0
	private void OnTeamChange(Transform trans, int index) {} // 0x0000000181BB77F0-0x0000000181BB7950
	// [XID] // 0x0000000189740330-0x0000000189740350
	protected void RefreshTeamIndicator() {} // 0x0000000181BB5FD0-0x0000000181BB61B0
	// [XID] // 0x00000001897476C0-0x00000001897476E0
	protected void OnTeamAvatarBtnDown(int index) {} // 0x0000000181BB9F50-0x0000000181BBA000
	// [XID] // 0x000000018974EDD0-0x000000018974EDF0
	protected void OnTeamAvatarBtnUp(int index) {} // 0x0000000181BB8C80-0x0000000181BB8E50
	// [XID] // 0x00000001897564C0-0x00000001897564E0
	protected virtual void RefreshTryChangeTeamBtn() {} // 0x0000000181BB4C20-0x0000000181BB4CC0
	// [XID] // 0x000000018975D940-0x000000018975D960
	protected void TryChangeTeam() {} // 0x0000000181BB6210-0x0000000181BB63B0
	// [XID] // 0x0000000189764E90-0x0000000189764EB0
	protected void PopConfirmExploreCancel(List<AvatarDataItem> explorationList, WaitForGeneralDialog yieldIns = null) {} // 0x0000000181BB3600-0x0000000181BB3930
	// [XID] // 0x000000018976C950-0x000000018976C970
	protected void DoChangeTeam() {} // 0x0000000181BC1A60-0x0000000181BC1B70
	// [XID] // 0x0000000189773DF0-0x0000000189773E10
	protected void OnFastTeam() {} // 0x0000000181BB25D0-0x0000000181BB2810
	// [XID] // 0x000000018977B4E0-0x000000018977B500
	private void RefreshTeamList() {} // 0x0000000181BBCF60-0x0000000181BBD370
	// [XID] // 0x0000000189782FE0-0x0000000189783000
	private void RefreshIcons(bool needClear) {} // 0x0000000181BBB380-0x0000000181BBB6E0
	// [XID] // 0x000000018978A490-0x000000018978A4B0
	protected void RefreshAvatarPanel(bool needClear = false /* Metadata: 0x00B0F82D */) {} // 0x0000000181BB7640-0x0000000181BB7760
	// [XID] // 0x0000000189791CB0-0x0000000189791CD0
	protected bool CheckEffigyChallenge() => default; // 0x0000000181BB8650-0x0000000181BB8890
	// [XID] // 0x00000001897992B0-0x00000001897992D0
	protected bool CheckChannellerSlabLoopDungeon() => default; // 0x0000000181BBA880-0x0000000181BBAAD0
	// [XID] // 0x00000001897A1210-0x00000001897A1230
	private void RefreshAvatarIconFastMode(Transform trans, int index) {} // 0x0000000181BB4720-0x0000000181BB4C20
	// [XID] // 0x00000001897A8800-0x00000001897A8820
	private void OnFastModeAvatarRefresh() {} // 0x0000000181BBC3E0-0x0000000181BBC990
	// [XID] // 0x00000001897B0220-0x00000001897B0240
	private void OnFastModeAvatarSelect(int index) {} // 0x0000000181BB9B70-0x0000000181BB9F50
	// [XID] // 0x00000001897B7F50-0x00000001897B7F70
	protected void OnAvatarIconSelect_FastMode(int index) {} // 0x0000000181BBA000-0x0000000181BBA450
	// [XID] // 0x00000001897C0070-0x00000001897C0090
	protected virtual void OnTeamAvatarBtnSelect(int index) {} // 0x0000000181BB63B0-0x0000000181BB6700
	// [XID] // 0x00000001897C78A0-0x00000001897C78C0
	private void RefreshChaDetails(ulong guid, bool show = true /* Metadata: 0x00B0F82E */) {} // 0x0000000181BBFB40-0x0000000181BBFEA0
	// [XID] // 0x00000001897CEB40-0x00000001897CEB60
	protected void OnAvatarIconSelect(int index, bool showEffect = false /* Metadata: 0x00B0F82F */) {} // 0x0000000181BBFF00-0x0000000181BC04F0
	// [XID] // 0x00000001897D6280-0x00000001897D62A0
	protected void AvatarFromToTeam(bool isAvatar) {} // 0x0000000181BC07F0-0x0000000181BC0C10
	// [XID] // 0x00000001897DDB60-0x00000001897DDB80
	private void RefreshAvatarIcon(Transform trans, int index) {} // 0x0000000181BB3930-0x0000000181BB3D80
	// [XID] // 0x00000001897E5450-0x00000001897E5470
	protected void SetLastSelectIcon() {} // 0x0000000181BC1680-0x0000000181BC1810
	// [XID] // 0x00000001897ECFF0-0x00000001897ED010
	protected void OnDetail() {} // 0x0000000181BB8F50-0x0000000181BB9150
	// [XID] // 0x00000001897F4810-0x00000001897F4830
	protected virtual void ExchangeAvatar(int index) {} // 0x0000000181BC0D90-0x0000000181BC1000
	// [XID] // 0x00000001897FC2D0-0x00000001897FC2F0
	protected virtual void OnAvatarPickUp() {} // 0x0000000181BBF7E0-0x0000000181BBF990
	// [XID] // 0x0000000189803730-0x0000000189803750
	protected void SetTeamTitle(ulong guid) {} // 0x0000000181BBBD60-0x0000000181BBC040
	protected abstract void SetupDefaultTitle();
	// [IDTag] // 0x000000018980AD00-0x000000018980AD40
	// [XID] // 0x000000018980AD00-0x000000018980AD40
	private void On_TouchDown(Gesture gesture) {} // 0x0000000181BB32E0-0x0000000181BB3400
	// [XID] // 0x00000001898153F0-0x0000000189815410
	private void On_PS4Down(int index) {} // 0x0000000181BBB6E0-0x0000000181BBB930
	// [IDTag] // 0x000000018981CDF0-0x000000018981CE30
	// [XID] // 0x000000018981CDF0-0x000000018981CE30
	private void On_TouchDown(Vector3 pos) {} // 0x0000000181BB2D20-0x0000000181BB32E0
	// [XID] // 0x00000001898275C0-0x00000001898275E0
	protected virtual bool ValidIndexToDrag(int index, out ulong avatarGuid) {
		avatarGuid = default;
		return default;
	} // 0x0000000181BBAAD0-0x0000000181BBABF0
	// [IDTag] // 0x000000018982E7E0-0x000000018982E820
	// [XID] // 0x000000018982E7E0-0x000000018982E820
	private void On_TouchUp(Gesture gesture) {} // 0x0000000181BBAD60-0x0000000181BBAE80
	// [XID] // 0x0000000189838FE0-0x0000000189839000
	private void On_PS4Up(int index) {} // 0x0000000181BBD370-0x0000000181BBD660
	// [IDTag] // 0x0000000189840600-0x0000000189840640
	// [XID] // 0x0000000189840600-0x0000000189840640
	private void On_TouchUp(Vector3 pos) {} // 0x0000000181BBAE80-0x0000000181BBB0E0
	// [XID] // 0x000000018984AB60-0x000000018984AB80
	protected virtual bool ValidIndexForAvatarSwitch(int index) => default; // 0x0000000181BB7550-0x0000000181BB7640
	// [XID] // 0x0000000189851F00-0x0000000189851F20
	private int FindAvatarBtnIndexByPos(Vector3 pos) => default; // 0x0000000181BC04F0-0x0000000181BC07F0
	// [XID] // 0x00000001898597C0-0x00000001898597E0
	protected void OnScreenBtnClick() {} // 0x0000000181BB2810-0x0000000181BB29F0
	// [XID] // 0x0000000189860940-0x0000000189860960
	void MoleMole.FilterReceiver.RefreshScreenAvatarPanel(List<ulong> screenAvatarList) {} // 0x0000000181BBF020-0x0000000181BBF110
	// [XID] // 0x0000000189868070-0x0000000189868090
	void MoleMole.FilterReceiver.SaveScreenName(List<string> screenNameList) {} // 0x0000000181BBF110-0x0000000181BBF1C0
	// [XID] // 0x000000018986F650-0x000000018986F670
	void MoleMole.FilterReceiver.ChangeStateID(int id) {} // 0x0000000181BBEEC0-0x0000000181BBEF70
	// [XID] // 0x0000000189876BE0-0x0000000189876C00
	void MoleMole.FilterReceiver.ChangeToAvatarStateID() {} // 0x0000000181BBEF70-0x0000000181BBF020
	// [XID] // 0x000000018987E6E0-0x000000018987E700
	private void SetupSortTypeDropdown() {} // 0x0000000181BB7CC0-0x0000000181BB8050
	// [XID] // 0x0000000189885AD0-0x0000000189885AF0
	private SortType SortDropdownIndexToType(int index) => default; // 0x0000000181BBBC40-0x0000000181BBBD60
	// [XID] // 0x000000018988CDC0-0x000000018988CDE0
	protected void ChangeSortOrder() {} // 0x0000000181BBC120-0x0000000181BBC1E0
	// [XID] // 0x00000001898944B0-0x00000001898944D0
	protected void TrySelectAvatarIcon() {} // 0x0000000181BB5EA0-0x0000000181BB5FD0
	// [XID] // 0x000000018989BA60-0x000000018989BA80
	protected void OnSortTypeChange(int index) {} // 0x0000000181BBC040-0x0000000181BBC120
	// [XID] // 0x00000001898A2F10-0x00000001898A2F30
	private bool IsPrioritized(ulong x) => default; // 0x0000000181BB5D40-0x0000000181BB5EA0
	// [XID] // 0x00000001898AA3F0-0x00000001898AA410
	protected bool NeedShowRecommendElementList() => default; // 0x0000000181BB29F0-0x0000000181BB2B30
	// [XID] // 0x00000001898B1DF0-0x00000001898B1E10
	protected void RefreshRecommendElementList() {} // 0x0000000181BBDA90-0x0000000181BBE6D0
	// [XID] // 0x00000001898B9A90-0x00000001898B9AB0
	protected virtual bool TeamContainElementType(ElementType elementType) => default; // 0x0000000181BB3510-0x0000000181BB3600
	// [XID] // 0x00000001898C0E70-0x00000001898C0E90
	protected void RequestEnterDungeon() {} // 0x0000000181BB4CC0-0x0000000181BB4EF0
	// [XID] // 0x00000001898C87B0-0x00000001898C87D0
	protected void OnStartDungeonButtonClicked() {} // 0x0000000181BB8590-0x0000000181BB8650
	// [XID] // 0x00000001898D0160-0x00000001898D0180
	protected void ShowDungeonDetailInfoDialog() {} // 0x0000000181BBE9B0-0x0000000181BBEEC0
	// [XID] // 0x00000001898D76F0-0x00000001898D7710
	protected void RefreshUpAvatarList() {} // 0x0000000181BBA450-0x0000000181BBA820
	// [XID] // 0x00000001898DF440-0x00000001898DF460
	protected virtual bool TeamContainUpAvatar(uint avatarId) => default; // 0x0000000181BB5650-0x0000000181BB58F0
	// [XID] // 0x00000001898E6E00-0x00000001898E6E20
	private void SetResonanceView() {} // 0x0000000181BBF6A0-0x0000000181BBF7E0
	// [XID] // 0x00000001898EE5D0-0x00000001898EE5F0
	private void RefreshResonanceList() {} // 0x0000000181BBF1C0-0x0000000181BBF400
	// [XID] // 0x00000001898F5D60-0x00000001898F5D80
	private void RefreshResonanceItem(Transform trans, int index) {} // 0x0000000181BB2050-0x0000000181BB2510
	// [XID] // 0x00000001898FD560-0x00000001898FD580
	private void RefreshResonanceItemIconList(Transform trans, int index) {} // 0x0000000181BBD7F0-0x0000000181BBDA90
	// [XID] // 0x0000000189904E20-0x0000000189904E40
	private void SetResonanceBtnActive(bool active) {} // 0x0000000181BB9150-0x0000000181BB9250
	// [XID] // 0x000000018990C660-0x000000018990C680
	protected void SetResonancePanelActive(bool active) {} // 0x0000000181BBCB00-0x0000000181BBCD70
	// [XID] // 0x0000000189913F10-0x0000000189913F30
	protected virtual void OnResonanceBtnClick() {} // 0x0000000181BBBAB0-0x0000000181BBBC40
	// [XID] // 0x000000018991B940-0x000000018991B960
	private int CompareResonance(TeamResonanceExcelConfig xData, TeamResonanceExcelConfig yData) => default; // 0x0000000181BB3400-0x0000000181BB3510
	// [XID] // 0x0000000189922EA0-0x0000000189922EC0
	private void MoveToAvatarRightRegion() {} // 0x0000000181BBC1E0-0x0000000181BBC3E0
	// [XID] // 0x000000018992A710-0x000000018992A730
	private void MoveToAvatarLeftRegion() {} // 0x0000000181BB7AD0-0x0000000181BB7CC0
	// [XID] // 0x0000000189931D10-0x0000000189931D30
	private void ScrollResonanceList(float delta) {} // 0x0000000181BBF500-0x0000000181BBF6A0
	// [XID] // 0x0000000189939720-0x0000000189939740
	private void MoveToAvatarLeftNearest() {} // 0x0000000181BB4450-0x0000000181BB4720
}

