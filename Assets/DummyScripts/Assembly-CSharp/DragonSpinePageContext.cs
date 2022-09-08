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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class DragonSpinePageContext : BasePageContext // TypeDefIndex: 29635
{
	// Fields
	private MonoDragonSpineChapterMainPage _mainChapterMono; // 0x190
	private int _curChapterIdx; // 0x198
	public const int CHAPTER_TOTAL_COUNT = 4; // Metadata: 0x00B0FA98
	private MonoDragonSpineChapter _chapterMono; // 0x1A0
	private List<DragonSpineMissionData> _missionList; // 0x1A8
	private List<RewardItemConfig> _currRewardList; // 0x1B0
	private ActivityInfo _activityInfo; // 0x1B8
	private MonoDragonSpinePage _pageMono; // 0x1C0
	private MonoActivityDragonSpineProgressBtn _progressMono; // 0x1C8
	private List<ShopMaterial> _shopMaterialsList; // 0x1D0
	private GameObject _shopMaterialPrefab; // 0x1D8
	private uint _activityID; // 0x1E0
	private const string SHOP_MAT_PATH = "ART/UI/Menus/Widget/ShopMaterialsItem"; // Metadata: 0x00B0FA9C
	private uint _shopMaterialHandler; // 0x1E4
	private int _PlayBannerState; // 0x1E8
	private const uint PlayId = 3; // Metadata: 0x00B0FAC5
	private EPageState _state; // 0x1EC
	private DragonSpineWeaponDialog _weaponDialog; // 0x1F0
	private MessagePushPageContext _pushPage; // 0x1F8

	// Properties
	public EPageState state { /* [XID] */ /* 0x000000018974ED90-0x000000018974EDB0 */ get => default; } // 0x0000000182076820-0x00000001820768C0 

	// Nested types
	public enum EPageState // TypeDefIndex: 29636
	{
		None = -1,
		Albedo = 0,
		AllChapter = 1,
		Chapter_1 = 2,
		Chapter_2 = 3,
		Chapter_3 = 4,
		Chapter_4 = 5
	}

	// Constructors
	public DragonSpinePageContext() {} // Dummy constructor
	public DragonSpinePageContext(int pageIndex) {} // 0x000000018207E950-0x000000018207EB10
	public DragonSpinePageContext(uint activityId) {} // 0x000000018207EB10-0x000000018207EC40

	// Methods
	// [XID] // 0x00000001896428E0-0x0000000189642900
	private void BindViewCallbacks_Albedo() {} // 0x00000001820766B0-0x00000001820767C0
	// [XID] // 0x000000018964A010-0x000000018964A030
	private void OnTrace() {} // 0x000000018207ABF0-0x000000018207AF70
	// [XID] // 0x00000001896516D0-0x00000001896516F0
	private bool HandleInputActionEvent_Albedo(InputActionEvent actionEvent) => default; // 0x0000000182076E00-0x0000000182077090
	// [XID] // 0x0000000189658F10-0x0000000189658F30
	private void BindRedPoints_MainChapter() {} // 0x000000018207A7F0-0x000000018207AA20
	// [XID] // 0x00000001896605E0-0x0000000189660600
	private void ClearSelectState() {} // 0x0000000182079EB0-0x0000000182079FA0
	// [XID] // 0x0000000189667F20-0x0000000189667F40
	private void SetSelectState(int selectedIdx) {} // 0x00000001820795D0-0x0000000182079680
	// [XID] // 0x000000018966F9E0-0x000000018966FA00
	private void RefreshMainChapter() {} // 0x0000000182078550-0x0000000182078750
	// [XID] // 0x0000000189677300-0x0000000189677320
	private DragonSpineChapterInfo GetChapterInfo(uint chapterId) => default; // 0x00000001820751D0-0x0000000182075480
	// [XID] // 0x000000018967E870-0x000000018967E890
	private uint GetMaxOpenChapterId() => default; // 0x0000000182076D20-0x0000000182076E00
	// [XID] // 0x0000000189686120-0x0000000189686140
	private EPageState GetNextPageState(EPageState state) => default; // 0x0000000182075670-0x0000000182075740
	// [XID] // 0x000000018968DF10-0x000000018968DF30
	private uint GetChapterId(EPageState state) => default; // 0x000000018207D010-0x000000018207D0F0
	// [XID] // 0x0000000189695820-0x0000000189695840
	private void RefreshChapterBtn(MonoActivityDragonSpineChapterBtn chapterBtn, int index) {} // 0x000000018207AF70-0x000000018207BC30
	// [XID] // 0x000000018969CEB0-0x000000018969CED0
	private void OnClickChapter(uint chapterId) {} // 0x000000018207BC30-0x000000018207BD40
	// [XID] // 0x00000001896A41C0-0x00000001896A41E0
	private void OnClickChapterLocked(int index, uint openTime, bool isQuestLocked, string questTitle) {} // 0x0000000182076240-0x0000000182076560
	// [XID] // 0x00000001896AB780-0x00000001896AB7A0
	private void OnClickChapterNoQuest(string content) {} // 0x0000000182076C40-0x0000000182076D20
	// [XID] // 0x00000001896B29B0-0x00000001896B29D0
	private void OnClickTrackPreQuest(string title, uint questId, string questTitle) {} // 0x0000000182077DA0-0x0000000182077FF0
	// [XID] // 0x00000001896BA140-0x00000001896BA160
	private void OnConfirmTrack(uint questId) {} // 0x000000018207DA30-0x000000018207DB80
	// [XID] // 0x00000001896C13B0-0x00000001896C13D0
	private bool HandleInputActionEvent_AllChapters(InputActionEvent actionEvent) => default; // 0x000000018207DE60-0x000000018207E240
	// [XID] // 0x00000001896C8AB0-0x00000001896C8AD0
	private void RefreshChapterBtns(bool clear) {} // 0x0000000182079B20-0x0000000182079C50
	// [XID] // 0x00000001896D04A0-0x00000001896D04C0
	private void RefreshRewardHint() {} // 0x0000000182077920-0x0000000182077AC0
	// [XID] // 0x00000001896D79A0-0x00000001896D79C0
	private bool IsShowReward() => default; // 0x000000018207D930-0x000000018207DA30
	// [XID] // 0x00000001896DF200-0x00000001896DF220
	private void BindViewCallbacks_Boss() {} // 0x0000000182078DB0-0x0000000182078EC0
	// [XID] // 0x00000001896E6630-0x00000001896E6650
	private void RefreshChapter(int chapterIndex) {} // 0x0000000182078940-0x0000000182078DB0
	// [XID] // 0x00000001896EDB80-0x00000001896EDBA0
	private void FillMissionData(DragonSpineStageExcelConfig stageExcelConfig, uint chapterId) {} // 0x0000000182079330-0x0000000182079570
	// [XID] // 0x00000001896F53B0-0x00000001896F53D0
	private int SortCompare(DragonSpineMissionData left, DragonSpineMissionData right) => default; // 0x0000000182076560-0x00000001820766B0
	// [XID] // 0x00000001896FCBF0-0x00000001896FCC10
	private void FillWatcherData(DragonSpineMissionExcelConfig missionExcelConfig, NewActivityWatcherConfig watcherExcelConfig) {} // 0x0000000182077460-0x0000000182077830
	// [XID] // 0x0000000189704070-0x0000000189704090
	private void RefreshMissionRow(Transform trans, int index) {} // 0x000000018207D1E0-0x000000018207D6F0
	// [XID] // 0x000000018970B980-0x000000018970B9A0
	private void OnClickFetchReward(uint watcherId) {} // 0x000000018207A2B0-0x000000018207A3D0
	// [XID] // 0x0000000189713250-0x0000000189713270
	private void RefreshRewardItem(Transform trans, int index) {} // 0x0000000182077090-0x00000001820772E0
	// [XID] // 0x000000018971AA10-0x000000018971AA30
	private void OnClickChallenge() {} // 0x0000000182076A40-0x0000000182076C40
	// [XID] // 0x0000000189721D70-0x0000000189721D90
	private bool HandleInputActionEvent_Chapter(InputActionEvent actionEvent) => default; // 0x000000018207C240-0x000000018207CB10
	// [XID] // 0x0000000189729440-0x0000000189729460
	private void RefreshMissionListRow(int index) {} // 0x000000018207C100-0x000000018207C240
	// [XID] // 0x0000000189730C20-0x0000000189730C40
	private void OnSetSelectChange(Transform prevItem, int prevIndex, Transform curItem, int curIndex) {} // 0x0000000182077BF0-0x0000000182077DA0
	// [XID] // 0x0000000189738550-0x0000000189738570
	private void OnMissionItemJoyStickState(RectTransform item, bool select) {} // 0x0000000182077AC0-0x0000000182077BF0
	// [XID] // 0x00000001897402F0-0x0000000189740310
	private void OnMissionSelectorChange(Transform trans, int index) {} // 0x000000018207E240-0x000000018207E410
	// [XID] // 0x0000000189747680-0x00000001897476A0
	private void OnMissionSelectorChangeForLast(Transform trans, int index) {} // 0x000000018207A140-0x000000018207A2B0
	// [XID] // 0x0000000189756480-0x00000001897564A0
	private void InitPageContext() {} // 0x0000000182075CB0-0x0000000182075D80
	// [XID] // 0x000000018975D900-0x000000018975D920
	public override void SetupView() {} // 0x000000018207E410-0x000000018207E950
	// [XID] // 0x0000000189764E50-0x0000000189764E70
	private void OnClickBanner() {} // 0x0000000182075F20-0x00000001820760B0
	// [XID] // 0x000000018976C910-0x000000018976C930
	public override void ClearView() {} // 0x0000000182075D80-0x0000000182075F20
	// [XID] // 0x0000000189773DB0-0x0000000189773DD0
	protected override void BindRedPoints() {} // 0x00000001820757A0-0x0000000182075840
	// [XID] // 0x000000018977B460-0x000000018977B480
	protected override void OnEnable() {} // 0x000000018207DC10-0x000000018207DCB0
	// [XID] // 0x0000000189782FA0-0x0000000189782FC0
	protected override void BindViewCallbacks() {} // 0x0000000182075840-0x0000000182075CB0
	// [XID] // 0x000000018978A430-0x000000018978A450
	public override bool OnNotify(Notify ntf) => default; // 0x000000018207DCB0-0x000000018207DE60
	// [XID] // 0x0000000189791C50-0x0000000189791C70
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x000000018207C000-0x000000018207C100
	// [XID] // 0x0000000189799250-0x0000000189799270
	private void UpdateActivity(uint activityId) {} // 0x000000018207D6F0-0x000000018207D810
	// [XID] // 0x00000001897A11B0-0x00000001897A11D0
	private void Refresh(bool isInit) {} // 0x0000000182074A50-0x0000000182074D20
	// [XID] // 0x00000001897A87A0-0x00000001897A87C0
	private void RefreshWeaponInfo() {} // 0x000000018207A3D0-0x000000018207A7F0
	// [XID] // 0x00000001897B01C0-0x00000001897B01E0
	private void SetPageState(EPageState tState, bool isSwitch) {} // 0x000000018207D0F0-0x000000018207D1E0
	// [XID] // 0x00000001897B7EF0-0x00000001897B7F10
	private void RefreshPage(bool isSwitch) {} // 0x0000000182078750-0x0000000182078940
	// [XID] // 0x00000001897C0010-0x00000001897C0030
	private void UpdateMaterialsList() {} // 0x0000000182077FF0-0x0000000182078550
	// [XID] // 0x00000001897C7840-0x00000001897C7860
	private bool HasCoinId(DragonSpineStageExcelConfig stageConfig, uint itemId) => default; // 0x00000001820768C0-0x0000000182076A40
	// [XID] // 0x00000001897CEAE0-0x00000001897CEB00
	private void OnClickWeapon() {} // 0x000000018207CDD0-0x000000018207CFB0
	// [XID] // 0x00000001897D6220-0x00000001897D6240
	private void OnClickShop() {} // 0x00000001820760B0-0x0000000182076240
	// [XID] // 0x00000001897DDB00-0x00000001897DDB20
	private void OnClickHelp() {} // 0x0000000182075480-0x0000000182075670
	// [XID] // 0x00000001897E53F0-0x00000001897E5410
	private void OnClickGoto() {} // 0x00000001820799A0-0x0000000182079B20
	// [XID] // 0x00000001897ECF90-0x00000001897ECFB0
	private uint GetBlossomMarkId(BlossomRefreshType refreshType) => default; // 0x000000018207CB10-0x000000018207CDD0
	// [XID] // 0x00000001897F47B0-0x00000001897F47D0
	private void OnClickWeaponInfo() {} // 0x000000018207BD40-0x000000018207BF80
	// [XID] // 0x00000001897FC250-0x00000001897FC270
	public static uint GetWeaponId() => default; // 0x000000018207D810-0x000000018207D930
	// [XID] // 0x00000001898036F0-0x0000000189803710
	public static uint GetWeaponBreakLev() => default; // 0x0000000182079FA0-0x000000018207A140
	// [XID] // 0x000000018980ACC0-0x000000018980ACE0
	private void OnPrevTab() {} // 0x0000000182077830-0x0000000182077920
	// [XID] // 0x00000001898122B0-0x00000001898122D0
	private void OnNextTab() {} // 0x00000001820772E0-0x00000001820773D0
	// [XID] // 0x0000000189819E80-0x0000000189819EA0
	private void HandlePageBtns() {} // 0x0000000182074D20-0x00000001820751D0
	// [XID] // 0x00000001898216A0-0x00000001898216C0
	private void SetButtonState(Button btn, bool isEnable) {} // 0x0000000182079CB0-0x0000000182079EB0
	// [XID] // 0x0000000189828CD0-0x0000000189828CF0
	private void OnClickClose() {} // 0x0000000182079850-0x0000000182079940
	// [XID] // 0x00000001898300A0-0x00000001898300C0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182079680-0x0000000182079850
	// [XID] // 0x0000000189837820-0x0000000189837840
	private bool HandleCommonInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182078EC0-0x0000000182079330
}

