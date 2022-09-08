/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text.RegularExpressions;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CharacterPageContext : BasePageContext // TypeDefIndex: 28869
{
	// Fields
	private MonoCharacterPage _pageMono; // 0x190
	private CharacterUISceneComponent _uiSceneComp; // 0x198
	private AvatarDataItem _selectAvatarData; // 0x1A0
	private List<ulong> _teamList; // 0x1A8
	private List<ulong> _previewAvatarList; // 0x1B0
	private CharacterPageType _type; // 0x1B8
	private PageMode _mode; // 0x1BC
	private ulong _showAvatarGuid; // 0x1C0
	private ElementType _elemType; // 0x1C8
	private uint _selectTabIndex; // 0x1CC
	private bool _levelUpBtnShow; // 0x1D0
	private bool _promoteBtnShow; // 0x1D1
	private bool _relicUnselect; // 0x1D2
	private bool _skillIntroduceShow; // 0x1D3
	private bool _showAttributeBtn; // 0x1D4
	public EquipSelectDialogContext equipSelectDialogContext; // 0x1D8
	private CharacterSelectDialogContext _characterSelectDialog; // 0x1E0
	private List<ulong> _curTeamList; // 0x1E8
	private List<ulong> _filteredTeamListAll; // 0x1F0
	private List<ulong> _filteredListWithFocus; // 0x1F8
	private List<ulong> _filteredListWithoutFocus; // 0x200
	private List<string> _screenNameList; // 0x208
	private bool _switchTabTempResult; // 0x210
	private bool _isLocalPlayer; // 0x211
	private SocialDetailStruct _socialDetail; // 0x218
	private bool sideBarHide; // 0x288
	private static readonly uint Step; // 0x00
	private FetterPageState _currentState; // 0x28C
	public EquipType _relicSelectType; // 0x290
	private ItemTipsDialogContext itemTips; // 0x298
	private List<SkillBaseStruct> _skillList; // 0x2A0
	private Dictionary<uint, uint> _unlockSkillDic; // 0x2A8
	private int _selectSkillIndex; // 0x2B0
	private List<SkillPropStruct> _skillPropList; // 0x2B8
	private Regex skillPropRegex; // 0x2C0
	private List<uint> _talentList; // 0x2C8
	private Dictionary<uint, int> _unlockTalentDic; // 0x2D0
	private int _selectTalentIndex; // 0x2D8
	public bool refreshWeapon; // 0x2DC

	// Properties
	public MonoCharacterPage pageMono { /* [XID] */ /* 0x00000001899F5100-0x00000001899F5120 */ get => default; } // 0x00000001817884A0-0x0000000181788550 
	public AvatarDataItem SelectAvatarData { /* [XID] */ /* 0x00000001899FC690-0x00000001899FC6B0 */ get => default; } // 0x0000000181777660-0x0000000181777710 
	public CharacterPageType type { /* [XID] */ /* 0x0000000189A03C80-0x0000000189A03CA0 */ get => default; } // 0x000000018178C450-0x000000018178C4F0 

	// Nested types
	private enum PageMode // TypeDefIndex: 28870
	{
		Normal = 0,
		Preview = 1,
		Friend = 2
	}

	private enum FetterPageState // TypeDefIndex: 28871
	{
		None = 0,
		Normal = 1
	}

	public enum ContrastButtonState // TypeDefIndex: 28872
	{
		Hide = 0,
		Equiped = 1,
		Contrast = 2,
		Fold = 3
	}

	public struct SkillBaseStruct // TypeDefIndex: 28873
	{
		// Fields
		public uint groupId; // 0x00
		public uint skillId; // 0x04
		public uint extraLevel; // 0x08
		public bool isCore; // 0x0C
		public bool isEnergySkill; // 0x0D
	}

	public struct SkillPropStruct // TypeDefIndex: 28874
	{
		// Fields
		public string name; // 0x00
		public string desc; // 0x08
	}

	// Constructors
	public CharacterPageContext() {} // Dummy constructor
	public CharacterPageContext(CharacterPageType type = CharacterPageType.MainToCharacter /* Metadata: 0x00B0E80E */, ulong avatarGuid = 0 /* Metadata: 0x00B0E812 */, List<ulong> previewAvatarList = null) {} // 0x000000018178DDE0-0x000000018178E050
	public CharacterPageContext(CharacterPageType type, ulong avatarGuid, List<ulong> previewAvatarList, bool isLocalPlayer, SocialDetailStruct socialDetail) {} // 0x000000018178E050-0x000000018178E140
	static CharacterPageContext() {} // 0x000000018178DD80-0x000000018178DDE0

	// Methods
	// [XID] // 0x000000018999B200-0x000000018999B220
	private bool DoShowProperty() => default; // 0x00000001817730A0-0x0000000181773320
	// [XID] // 0x00000001899A2A20-0x00000001899A2A40
	private void CheckAvatarPromoteBtnShow() {} // 0x000000018178AF50-0x000000018178B3F0
	// [XID] // 0x00000001899AA320-0x00000001899AA340
	private void TryOpenLevelUpDialog() {} // 0x00000001817765C0-0x0000000181776800
	// [XID] // 0x00000001899B1D50-0x00000001899B1D70
	private void TryOpenStarUpDialog() {} // 0x0000000181782720-0x0000000181782990
	// [XID] // 0x00000001899B90B0-0x00000001899B90D0
	private void ShowBreakThroughResult(ulong avatarGuid, float lastValue, float value) {} // 0x000000018177EE90-0x000000018177F0F0
	// [XID] // 0x00000001899C0970-0x00000001899C0990
	private void ShowUpgradeResult(AvatarUpgradeRsp rsp) {} // 0x0000000181781E30-0x0000000181782030
	// [XID] // 0x00000001899C81A0-0x00000001899C81C0
	public void ShowDetailPropertyDialog() {} // 0x0000000181771B80-0x0000000181771CD0
	// [XID] // 0x00000001899CFB40-0x00000001899CFB60
	private void ShowDetailRelicPropertyDialog() {} // 0x00000001817796B0-0x0000000181779800
	// [XID] // 0x00000001899D6F50-0x00000001899D6F70
	private void OnAvatarFightPropRefresh() {} // 0x0000000181787570-0x0000000181787650
	// [XID] // 0x00000001899DE4C0-0x00000001899DE4E0
	private void OnAppearanceBtnClick() {} // 0x0000000181776800-0x0000000181776AA0
	// [XID] // 0x00000001899E6180-0x00000001899E61A0
	private void OnBreachMaterialBtnClick() {} // 0x0000000181782990-0x0000000181782AE0
	// [XID] // 0x00000001899ED570-0x00000001899ED590
	private PageMode GetPageMode(CharacterPageType type) => default; // 0x0000000181781D40-0x0000000181781E30
	// [XID] // 0x0000000189A0B190-0x0000000189A0B1B0
	public override void SetupView() {} // 0x000000018178D2D0-0x000000018178DD80
	// [XID] // 0x0000000189A12AC0-0x0000000189A12AE0
	private void SetupPageTypeShowState() {} // 0x0000000181779600-0x00000001817796B0
	// [XID] // 0x0000000189A19CF0-0x0000000189A19D10
	private void SetupFriendPageShowState() {} // 0x0000000181777DB0-0x0000000181778080
	// [XID] // 0x0000000189A21360-0x0000000189A21380
	private void SetupDefaultPageShowState() {} // 0x00000001817853F0-0x00000001817855C0
	// [XID] // 0x0000000189A28980-0x0000000189A289A0
	private void CheckIsOnlyTips() {} // 0x0000000181787A00-0x0000000181787B70
	// [XID] // 0x0000000189A2FFB0-0x0000000189A2FFD0
	public override void ClearView() {} // 0x0000000181776AA0-0x0000000181776C90
	// [XID] // 0x0000000189A37A00-0x0000000189A37A20
	protected override void BindViewCallbacks() {} // 0x0000000181774A70-0x0000000181775870
	// [XID] // 0x0000000189A3F0D0-0x0000000189A3F0F0
	protected override void BindRedPoints() {} // 0x0000000181773EB0-0x0000000181774A70
	// [XID] // 0x0000000189A467B0-0x0000000189A467D0
	public override bool OnNotify(Notify ntf) => default; // 0x000000018178BA00-0x000000018178BF00
	// [XID] // 0x0000000189A4DFC0-0x0000000189A4DFE0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181781350-0x00000001817818F0
	// [XID] // 0x0000000189A55730-0x0000000189A55750
	private bool HandleAvatarPanelEvent(InputActionEvent actionEvent) => default; // 0x0000000181784270-0x0000000181784940
	// [XID] // 0x0000000189A5D0B0-0x0000000189A5D0D0
	private bool CanRotateModel(Vector2 delta) => default; // 0x0000000181785090-0x0000000181785250
	// [XID] // 0x0000000189A64950-0x0000000189A64970
	public void RotateModelByDelta(Vector2 delta) {} // 0x000000018178B3F0-0x000000018178B530
	// [XID] // 0x0000000189A6C170-0x0000000189A6C190
	private bool HandleWeaponPanelEvent(InputActionEvent actionEvent) => default; // 0x000000018177F480-0x000000018177F7E0
	// [XID] // 0x0000000189A738E0-0x0000000189A73900
	private bool HandleRelicPanelEvent(InputActionEvent actionEvent) => default; // 0x00000001817719C0-0x0000000181771B80
	// [XID] // 0x0000000189A7B460-0x0000000189A7B480
	private bool HandleTalentPanelEvent(InputActionEvent actionEvent) => default; // 0x000000018177CA70-0x000000018177D090
	// [XID] // 0x0000000189A82B20-0x0000000189A82B40
	private bool HandleSkillPanelEvent(InputActionEvent actionEvent) => default; // 0x000000018178A940-0x000000018178AC40
	// [XID] // 0x0000000189A8A4D0-0x0000000189A8A4F0
	protected override void OnEnable() {} // 0x000000018178B670-0x000000018178BA00
	// [XID] // 0x0000000189A91CD0-0x0000000189A91CF0
	private void OnCloseBtnClick() {} // 0x0000000181773930-0x0000000181773AF0
	// [XID] // 0x0000000189A997A0-0x0000000189A997C0
	private void RefreshAvatarInfo() {} // 0x000000018178A5B0-0x000000018178A790
	// [XID] // 0x0000000189AA07F0-0x0000000189AA0810
	private void OnAvatarEquipUIRefresh(object[] ntf) {} // 0x000000018177EC90-0x000000018177EE90
	// [XID] // 0x0000000189AA7DF0-0x0000000189AA7E10
	public void RefreshAvatar() {} // 0x000000018177BEA0-0x000000018177C070
	// [XID] // 0x0000000189AAF8E0-0x0000000189AAF900
	private void Refresh(bool isBack = false /* Metadata: 0x00B0E81A */) {} // 0x0000000181771740-0x0000000181771910
	// [XID] // 0x0000000189AB7190-0x0000000189AB71B0
	private void RefreshPageTypeShowState(AvatarDataItem avatarData) {} // 0x0000000181779800-0x00000001817798C0
	// [XID] // 0x0000000189ABEBE0-0x0000000189ABEC00
	private void RefreshFriendPageShowState(AvatarDataItem avatarData) {} // 0x000000018177F0F0-0x000000018177F3D0
	// [XID] // 0x0000000189AC6750-0x0000000189AC6770
	private void ToPrevChar() {} // 0x000000018177D720-0x000000018177D830
	// [XID] // 0x0000000189ACDDC0-0x0000000189ACDDE0
	private void ToNextChar() {} // 0x0000000181771EA0-0x0000000181771FB0
	// [XID] // 0x0000000189AD5B80-0x0000000189AD5BA0
	private void SetupTabs(List<ulong> team) {} // 0x000000018177FF70-0x00000001817801D0
	// [XID] // 0x0000000189ADD550-0x0000000189ADD570
	private void OnTabClick(int index) {} // 0x000000018178AC40-0x000000018178AF50
	// [XID] // 0x0000000189AE4CB0-0x0000000189AE4CD0
	private void RefreshTab(AvatarDataItem avatarData, bool isBack = false /* Metadata: 0x00B0E81B */) {} // 0x00000001817890B0-0x00000001817896E0
	// [XID] // 0x0000000189AEC390-0x0000000189AEC3B0
	public void RefreshEquiped() {} // 0x0000000181789890-0x0000000181789980
	// [XID] // 0x0000000189AF3DB0-0x0000000189AF3DD0
	private void RefrshAvatarInfoGrp() {} // 0x0000000181787460-0x0000000181787570
	// [XID] // 0x0000000189AFB460-0x0000000189AFB480
	public void RefreshCost() {} // 0x00000001817804B0-0x00000001817806A0
	// [XID] // 0x0000000189B02B80-0x0000000189B02BA0
	private void RefreshAvatarTab() {} // 0x0000000181787BE0-0x0000000181788110
	// [XID] // 0x0000000189B0A3B0-0x0000000189B0A3D0
	private void ShowAvatar(AvatarDataItem avatarData) {} // 0x000000018178C4F0-0x000000018178CAB0
	// [XID] // 0x0000000189B11B30-0x0000000189B11B50
	private AvatarAssociationInfo.AssocInfo GetAvatarAssocInfoByDataItem(AvatarDataItem avatarData) => default; // 0x0000000181777970-0x0000000181777A80
	// [XID] // 0x0000000189B18E20-0x0000000189B18E40
	private Sprite GetPendantIconSpriteByAvatarDataItem(AvatarDataItem avatarData) => default; // 0x0000000181780C00-0x0000000181780D10
	// [XID] // 0x0000000189B20470-0x0000000189B20490
	private Sprite GetPendantBgIconSpriteByAvatarDataItem(AvatarDataItem avatarData) => default; // 0x0000000181780AA0-0x0000000181780BA0
	// [XID] // 0x0000000189B27AF0-0x0000000189B27B10
	private void ShowPrevNextButton(bool show) {} // 0x0000000181783690-0x0000000181783910
	// [XID] // 0x0000000189B2EE30-0x0000000189B2EE50
	public void SetGrpTabAlpha(float alpha) {} // 0x000000018178A4D0-0x000000018178A5B0
	// [XID] // 0x0000000189B366F0-0x0000000189B36710
	public void HideSideBar(bool hide) {} // 0x0000000181775B30-0x0000000181775C20
	// [XID] // 0x0000000189B3DF60-0x0000000189B3DF80
	public void PreCalcAllCost(ulong weaponGuid, ulong avatarGuid) {} // 0x0000000181771CD0-0x0000000181771EA0
	// [XID] // 0x0000000189B45CB0-0x0000000189B45CD0
	private void RefreshShopMaterial(bool active = true /* Metadata: 0x00B0E81C */) {} // 0x0000000181786260-0x00000001817863C0
	// [XID] // 0x0000000189B4D130-0x0000000189B4D150
	private void RefreshTabPosition(List<ulong> team) {} // 0x000000018178CB60-0x000000018178CF00
	// [XID] // 0x0000000189B54930-0x0000000189B54950
	private void RefreshTabPositionByType(List<ulong> team) {} // 0x0000000181788FA0-0x00000001817890B0
	// [XID] // 0x0000000189B5C4D0-0x0000000189B5C4F0
	private void RefreshCoinNum() {} // 0x0000000181775A30-0x0000000181775B30
	// [XID] // 0x0000000189B63A80-0x0000000189B63AA0
	private void OnHelp() {} // 0x000000018177E040-0x000000018177E270
	// [XID] // 0x0000000189B6B260-0x0000000189B6B280
	private void RefreshHelpBtnShow() {} // 0x0000000181780F50-0x0000000181781030
	// [XID] // 0x0000000189B728C0-0x0000000189B728E0
	private void RefreshMaterialBreachBtnShow() {} // 0x0000000181773C10-0x0000000181773D40
	// [XID] // 0x0000000189B79DD0-0x0000000189B79DF0
	private void ShowNextTab(bool nextOrPrev) {} // 0x0000000181771FB0-0x0000000181772370
	// [XID] // 0x0000000189B814C0-0x0000000189B814E0
	private bool GetTabButtonStateByIndex(uint index) => default; // 0x0000000181777710-0x0000000181777970
	// [XID] // 0x0000000189B88C30-0x0000000189B88C50
	public bool CanShowNewbieMask() => default; // 0x00000001817806A0-0x0000000181780750
	// [XID] // 0x0000000189B90120-0x0000000189B90140
	public void OnCharacterSelectAvatarIconClick(ulong avatarGuid) {} // 0x0000000181780750-0x0000000181780AA0
	// [XID] // 0x0000000189B975C0-0x0000000189B975E0
	public void OnCharacterSelectConfirmBtnClick(List<ulong> showAvatarList) {} // 0x0000000181773320-0x00000001817735B0
	// [XID] // 0x0000000189B9EA20-0x0000000189B9EA40
	private void OnCharacterSelectBtnClick() {} // 0x0000000181787650-0x0000000181787910
	// [XID] // 0x0000000189BA6330-0x0000000189BA6350
	private void SortAvatarList() {} // 0x0000000181783B20-0x0000000181783F50
	// [XID] // 0x0000000189BAD600-0x0000000189BAD620
	private int CompareAvatarItem(ulong x, ulong y) => default; // 0x00000001817735B0-0x0000000181773930
	// [XID] // 0x0000000189BB4D30-0x0000000189BB4D50
	public void SwitchAvatar(int deltaIndex) {} // 0x0000000181777010-0x0000000181777250
	// [XID] // 0x0000000189BBC360-0x0000000189BBC380
	public void SaveScreeName(List<string> screenNameList) {} // 0x000000018177C8F0-0x000000018177CA00
	// [XID] // 0x0000000189BC4040-0x0000000189BC4060
	public MonoSceneUISetup.ShowSubType GetUISceneSubType() => default; // 0x000000018177C070-0x000000018177C120
	// [XID] // 0x0000000189BCBA10-0x0000000189BCBA30
	private bool DoShowFetters() => default; // 0x0000000181777400-0x0000000181777660
	// [XID] // 0x0000000189BD2F80-0x0000000189BD2FA0
	private void OnFetterStoryBtnClicked() {} // 0x0000000181784050-0x0000000181784270
	// [XID] // 0x0000000189BDA7A0-0x0000000189BDA7C0
	private void OnFetterVoiceBtnClicked() {} // 0x000000018177D2A0-0x000000018177D4C0
	// [XID] // 0x00000001895E7190-0x00000001895E71B0
	private void BackToFetterPage() {} // 0x00000001817855C0-0x0000000181785770
	// [XID] // 0x00000001895EEAC0-0x00000001895EEAE0
	private void OnFetterRewardButtonClicked(uint fetterLevel) {} // 0x0000000181781C00-0x0000000181781D40
	// [XID] // 0x00000001895F6480-0x00000001895F64A0
	private void OnAvatarFetterRewardGetNotify(uint rewardId) {} // 0x000000018177F7E0-0x000000018177FC90
	// [XID] // 0x00000001895FD7D0-0x00000001895FD7F0
	private void CheckRewardButton(AvatarDataItem avatarData) {} // 0x0000000181788890-0x0000000181788FA0
	// [XID] // 0x00000001896050A0-0x00000001896050C0
	private bool HandleFetterPanelEvent(InputActionEvent actionEvent) => default; // 0x0000000181781030-0x0000000181781350
	// [XID] // 0x000000018960CAD0-0x000000018960CAF0
	private void OnFetterPageStateChange(FetterPageState nextState) {} // 0x0000000181784FC0-0x0000000181785090
	// [XID] // 0x0000000189614060-0x0000000189614080
	private void FetterStateChange_None_Normal() {} // 0x00000001817798C0-0x0000000181779EC0
	// [XID] // 0x000000018961B9C0-0x000000018961B9E0
	private void FetterStateChange_Normal_Focus() {} // 0x000000018178BF00-0x000000018178C280
	// [XID] // 0x0000000189622FE0-0x0000000189623000
	private void FetterStateChange_Focus_Normal() {} // 0x0000000181776C90-0x0000000181777010
	// [XID] // 0x000000018962A7B0-0x000000018962A7D0
	private void ScrollContent(float delta) {} // 0x0000000181785250-0x00000001817853F0
	// [XID] // 0x0000000189631EF0-0x0000000189631F10
	private bool DoShowRelic() => default; // 0x00000001817762D0-0x0000000181776550
	// [XID] // 0x0000000189639A10-0x0000000189639A30
	private void SetupRelicPageTypeShowState() {} // 0x00000001817896E0-0x0000000181789790
	// [XID] // 0x0000000189640EC0-0x0000000189640EE0
	private void SetupRelicFriendPageShowState() {} // 0x000000018177C3E0-0x000000018177C5D0
	// [XID] // 0x00000001896487D0-0x00000001896487F0
	private void SetupRelicDefaultPageShowState() {} // 0x0000000181787040-0x00000001817871A0
	// [XID] // 0x000000018964FEE0-0x000000018964FF00
	public void BackRelicDetail(bool force = false /* Metadata: 0x00B0E81D */) {} // 0x0000000181779EC0-0x000000018177A040
	// [XID] // 0x00000001896577A0-0x00000001896577C0
	public void SetRelicItemPanelActive(bool active, bool btnsActive) {} // 0x00000001817882F0-0x00000001817884A0
	// [XID] // 0x000000018965EE00-0x000000018965EE20
	public void SetRelicChangePanelActive(bool active) {} // 0x0000000181788110-0x0000000181788220
	// [XID] // 0x0000000189666520-0x0000000189666540
	public void SetRelicSuiteDescActive(bool active) {} // 0x0000000181777250-0x0000000181777400
	// [XID] // 0x000000018966DD20-0x000000018966DD40
	public void SetRelicBackBtnActive(bool active) {} // 0x0000000181789790-0x0000000181789890
	// [XID] // 0x0000000189675B40-0x0000000189675B60
	public void OnFriendRelicBtnClick() {} // 0x0000000181784CD0-0x0000000181784F50
	// [XID] // 0x000000018967D3D0-0x000000018967D3F0
	public void OnRelicReplaceBtnClick() {} // 0x0000000181783020-0x00000001817831E0
	// [XID] // 0x0000000189684AA0-0x0000000189684AC0
	public void OnRelicPromoteBtnClick(BagItem bagItem) {} // 0x00000001817714C0-0x0000000181771740
	// [XID] // 0x000000018968C670-0x000000018968C690
	private void RefreshEquipedRelicInfo() {} // 0x000000018177D1C0-0x000000018177D2A0
	// [XID] // 0x00000001896940C0-0x00000001896940E0
	public void ChangeRelicShow(ReliquaryItem relicItem, EquipType equipType) {} // 0x000000018177BDB0-0x000000018177BEA0
	// [XID] // 0x000000018969B650-0x000000018969B670
	public void ShowRelicItemPage(bool show) {} // 0x000000018177C7F0-0x000000018177C8F0
	// [XID] // 0x00000001896A2DB0-0x00000001896A2DD0
	public void RefreshRelicItemTip(BagItem bagItem) {} // 0x0000000181786EB0-0x0000000181787040
	// [XID] // 0x00000001896AA280-0x00000001896AA2A0
	public void ShowContrastPage(bool show) {} // 0x0000000181772F50-0x00000001817730A0
	// [XID] // 0x00000001896B10C0-0x00000001896B10E0
	public void ShowWeaponContrastPage(bool show) {} // 0x0000000181771380-0x00000001817714C0
	// [XID] // 0x00000001896B8CB0-0x00000001896B8CD0
	public void RefreshContrastItemTip(BagItem bagItem) {} // 0x0000000181782F20-0x0000000181783020
	// [XID] // 0x00000001896BFE90-0x00000001896BFEB0
	public void ShowRelicContrast() {} // 0x0000000181773D40-0x0000000181773E40
	// [XID] // 0x00000001896C7790-0x00000001896C77B0
	public void HideRelicContrast() {} // 0x0000000181777CF0-0x0000000181777DB0
	// [XID] // 0x00000001896CEF30-0x00000001896CEF50
	public void ShowWeaponContrast() {} // 0x0000000181773B50-0x0000000181773C10
	// [XID] // 0x00000001896D6330-0x00000001896D6350
	public void HideWeaponContrast() {} // 0x00000001817873A0-0x0000000181787460
	// [XID] // 0x00000001896DD950-0x00000001896DD970
	public void RefreshRelicRotation() {} // 0x0000000181789CE0-0x0000000181789D90
	// [XID] // 0x00000001896E5000-0x00000001896E5020
	public void ShowRelicChangeInfo(ReliquaryItem oldRelicItem, ReliquaryItem newRelicItem) {} // 0x00000001817818F0-0x0000000181781A00
	// [XID] // 0x00000001896EC4A0-0x00000001896EC4C0
	private void ResetRelicSuite() {} // 0x000000018177D830-0x000000018177E040
	// [XID] // 0x00000001896F3C70-0x00000001896F3C90
	public void ShowRelicEquippedLabel(BagItem item) {} // 0x0000000181788550-0x0000000181788890
	// [XID] // 0x00000001896FB3E0-0x00000001896FB400
	public void CanShowLevelText(bool value) {} // 0x0000000181784C00-0x0000000181784CD0
	// [XID] // 0x0000000189702B70-0x0000000189702B90
	public void TurnToRelic(EquipType type) {} // 0x0000000181784B40-0x0000000181784C00
	// [XID] // 0x000000018970A2B0-0x000000018970A2D0
	private bool DoShowSkill() => default; // 0x0000000181782D40-0x0000000181782F20
	// [XID] // 0x0000000189711D90-0x0000000189711DB0
	private void SetupSkillPageTypeShowState() {} // 0x0000000181771910-0x00000001817719C0
	// [XID] // 0x00000001897191D0-0x00000001897191F0
	private void SetupSkillFriendPageShowState() {} // 0x0000000181783980-0x0000000181783B20
	// [XID] // 0x0000000189720890-0x00000001897208B0
	private void SetupSkillDefaultPageShowState() {} // 0x00000001817831E0-0x0000000181783380
	// [XID] // 0x0000000189727E40-0x0000000189727E60
	private void SetupSkillView(bool resetDetailPanel = false /* Metadata: 0x00B0E81E */) {} // 0x0000000181779430-0x0000000181779600
	// [XID] // 0x000000018972F480-0x000000018972F4A0
	private void RefreshSkillList() {} // 0x0000000181786430-0x00000001817869B0
	// [XID] // 0x0000000189736EC0-0x0000000189736EE0
	private void RefreshUnlockSkillList() {} // 0x0000000181783380-0x0000000181783690
	// [XID] // 0x000000018973EA80-0x000000018973EAA0
	private void RefreshSkillItem(Transform trans, int index) {} // 0x0000000181789D90-0x000000018178A030
	// [XID] // 0x0000000189745D40-0x0000000189745D60
	private void OnSkillItemClick(int index) {} // 0x00000001817801D0-0x00000001817804B0
	// [XID] // 0x000000018974D830-0x000000018974D850
	private void RefreshSelectSkill(SkillBaseStruct skillStruct) {} // 0x000000018177A2E0-0x000000018177B240
	// [XID] // 0x0000000189754E90-0x0000000189754EB0
	private void RefreshSkillIcon(SkillBaseStruct skillStruct, uint level) {} // 0x000000018177E270-0x000000018177E920
	// [XID] // 0x000000018975C000-0x000000018975C020
	private void RefreshSkillPropItem(Transform trans, int index) {} // 0x000000018178D150-0x000000018178D2D0
	// [XID] // 0x00000001897639B0-0x00000001897639D0
	private SkillPropStruct GetSkillPropDescStruct(string desc, ProudSkillExcelConfig proudSkillConfig) => default; // 0x0000000181785A40-0x0000000181786000
	// [XID] // 0x000000018976B170-0x000000018976B190
	private void OnSkillIntroduceBtnClick() {} // 0x000000018177F3D0-0x000000018177F480
	// [XID] // 0x00000001897727C0-0x00000001897727E0
	private void OnSkillAttributeBtnClick() {} // 0x000000018177C330-0x000000018177C3E0
	// [XID] // 0x0000000189779DF0-0x0000000189779E10
	private void OnSkillIntroduceOrAttributeBtnSwitch() {} // 0x0000000181777A80-0x0000000181777B80
	// [XID] // 0x0000000189781A50-0x0000000189781A70
	private void SetSkillDetialShow(bool showIntroduce) {} // 0x000000018178CF00-0x000000018178D150
	// [XID] // 0x0000000189788F50-0x0000000189788F70
	private void SetUpgradeBtnShow(bool canUpgrade, string lockText = null, string maxText = null) {} // 0x000000018177FC90-0x000000018177FF70
	// [XID] // 0x0000000189790540-0x0000000189790560
	private void OnSkillBackBtnDown() {} // 0x000000018178A090-0x000000018178A220
	// [XID] // 0x0000000189797F30-0x0000000189797F50
	private void OnUpgradeSkillBtnClick() {} // 0x00000001817760A0-0x00000001817762D0
	// [XID] // 0x000000018979FC50-0x000000018979FC70
	private void SetSkillDetailPanelActive(bool active) {} // 0x0000000181785770-0x0000000181785A40
	// [XID] // 0x00000001897A71D0-0x00000001897A71F0
	private void SetSkillDetailTab(bool hasAttribute) {} // 0x00000001817871A0-0x00000001817873A0
	// [XID] // 0x00000001897AEB80-0x00000001897AEBA0
	private void OnCombatSkillChangeNotify(uint skillId, uint oldLevel, uint curLevel) {} // 0x0000000181780D10-0x0000000181780F50
	// [XID] // 0x00000001897B6A10-0x00000001897B6A30
	private void OnProudSkillChangeNotify(uint proudSkillId) {} // 0x0000000181775F20-0x00000001817760A0
	// [XID] // 0x00000001897BE850-0x00000001897BE870
	private bool DoShowTalent() => default; // 0x000000018177D4C0-0x000000018177D720
	// [XID] // 0x00000001897C5F40-0x00000001897C5F60
	private void SetupTalentPageTypeShowState() {} // 0x000000018178B530-0x000000018178B5E0
	// [XID] // 0x00000001897CD740-0x00000001897CD760
	private void SetupTalentFriendPageShowState() {} // 0x000000018177BAB0-0x000000018177BC50
	// [XID] // 0x00000001897D4CC0-0x00000001897D4CE0
	private void SetupTalentDefaultPageShowState() {} // 0x0000000181781A60-0x0000000181781C00
	// [XID] // 0x00000001897DC400-0x00000001897DC420
	private void SetupTalentView() {} // 0x000000018178A790-0x000000018178A940
	// [XID] // 0x00000001897E3D70-0x00000001897E3D90
	private void SetTalentViewActive(bool active) {} // 0x0000000181775870-0x0000000181775A30
	// [XID] // 0x00000001897EB940-0x00000001897EB960
	private void RefreshTalentList() {} // 0x0000000181782220-0x0000000181782720
	// [XID] // 0x00000001897F3240-0x00000001897F3260
	private void RefreshTalentItem(Transform trans, int index) {} // 0x0000000181786BC0-0x0000000181786EB0
	// [XID] // 0x00000001897FAAB0-0x00000001897FAAD0
	private void OnTalentItemClick(int index) {} // 0x000000018177E920-0x000000018177EC90
	// [XID] // 0x0000000189802060-0x0000000189802080
	private void RefreshSelectTalent(uint talentId, int index) {} // 0x0000000181778080-0x0000000181779280
	// [XID] // 0x00000001898094F0-0x0000000189809510
	private void OnNeedItemClicked(uint itemId) {} // 0x0000000181784940-0x0000000181784B40
	// [XID] // 0x0000000189810D00-0x0000000189810D20
	private void SetUpgradeStyle(bool canUpgrade, string maxTips = null) {} // 0x000000018177A040-0x000000018177A2E0
	// [XID] // 0x0000000189818790-0x00000001898187B0
	private void SetTalentDetailPanelActive(bool active) {} // 0x000000018178A220-0x000000018178A4D0
	// [XID] // 0x00000001898200A0-0x00000001898200C0
	private void RefreshTalentIcon(uint talentId) {} // 0x00000001817727C0-0x0000000181772F50
	// [XID] // 0x0000000189827660-0x0000000189827680
	private void OnTalentBackBtnDown() {} // 0x000000018178C280-0x000000018178C450
	// [XID] // 0x000000018982E880-0x000000018982E8A0
	private void OnUpgradeTalentBtnClick() {} // 0x0000000181787910-0x0000000181787A00
	// [XID] // 0x0000000189836220-0x0000000189836240
	private void UpgradeTalent(uint talentId) {} // 0x000000018177D090-0x000000018177D1C0
	// [XID] // 0x000000018983D690-0x000000018983D6B0
	private bool CheckTalentUpgradeCondition(uint talentId) => default; // 0x0000000181775C20-0x0000000181775F20
	// [XID] // 0x0000000189844E70-0x0000000189844E90
	private void PlayTalentLevelUpEffect(int index) {} // 0x0000000181788220-0x00000001817882F0
	// [XID] // 0x000000018984C340-0x000000018984C360
	private void OnRefreshAvatarTalent(uint talentId) {} // 0x0000000181782030-0x00000001817821B0
	// [XID] // 0x00000001898534D0-0x00000001898534F0
	private void SetTalentLockTip(bool active) {} // 0x0000000181772520-0x0000000181772720
	// [XID] // 0x000000018985AF00-0x000000018985AF20
	private bool DoShowWeapon(bool isRefresh = false /* Metadata: 0x00B0E81F */) => default; // 0x0000000181786000-0x0000000181786260
	// [XID] // 0x00000001898623A0-0x00000001898623C0
	private void SetupWeaponPageTypeShowState() {} // 0x000000018178CAB0-0x000000018178CB60
	// [XID] // 0x0000000189869890-0x00000001898698B0
	private void SetupWeaponFriendPageShowState() {} // 0x0000000181782AE0-0x0000000181782D40
	// [XID] // 0x0000000189870A30-0x0000000189870A50
	private void SetupWeaponDefaultPageShowState() {} // 0x00000001817869B0-0x0000000181786BC0
	// [XID] // 0x0000000189878520-0x0000000189878540
	private void RefreshEquipedWeaponInfo() {} // 0x000000018177B790-0x000000018177BAB0
	// [XID] // 0x000000018987FA10-0x000000018987FA30
	public void ShowWeaponEquippedLabel(BagItem item) {} // 0x0000000181789980-0x0000000181789CE0
	// [XID] // 0x0000000189887060-0x0000000189887080
	public void RefreshCurrShowWeaponInfo(ulong guid) {} // 0x000000018177BC50-0x000000018177BDB0
	// [XID] // 0x000000018988E210-0x000000018988E230
	public void RefreshCurrEquipedWeaponInfo(ulong guid) {} // 0x0000000181783F50-0x0000000181784050
	// [IDTag] // 0x00000001898958A0-0x00000001898958E0
	// [XID] // 0x00000001898958A0-0x00000001898958E0
	public void OnWeaponPromoteBtnClick() {} // 0x000000018177B4E0-0x000000018177B790
	// [IDTag] // 0x000000018989FC50-0x000000018989FC90
	// [XID] // 0x000000018989FC50-0x000000018989FC90
	public void OnWeaponPromoteBtnClick(BagItem bagItem) {} // 0x000000018177B240-0x000000018177B4E0
	// [XID] // 0x00000001898AA4B0-0x00000001898AA4D0
	private void OnWeaponReplaceBtnClick() {} // 0x0000000181777B80-0x0000000181777CF0
	// [XID] // 0x00000001898B1ED0-0x00000001898B1EF0
	public void MoveWeaponReplaceCam(bool toOrBack) {} // 0x000000018177C120-0x000000018177C1F0
	// [XID] // 0x00000001898B9B50-0x00000001898B9B70
	public void SetWeaponItemPanelActive(bool active, bool btnsActive) {} // 0x000000018177C5D0-0x000000018177C7F0
	// [XID] // 0x00000001898C0F50-0x00000001898C0F70
	public void SetWeaponChangePanelActive(bool active) {} // 0x0000000181779280-0x00000001817793D0
	// [XID] // 0x00000001898C8890-0x00000001898C88B0
	public void ShowSelectWeapon(WeaponItem oldWeaponItem, WeaponItem newWeaponItem) {} // 0x0000000181772400-0x0000000181772520
	// [XID] // 0x00000001898D0220-0x00000001898D0240
	public void RefreshWeaponModel() {} // 0x000000018177C280-0x000000018177C330
}

