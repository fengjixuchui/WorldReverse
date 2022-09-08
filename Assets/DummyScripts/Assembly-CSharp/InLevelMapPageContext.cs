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
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelMapPageContext : BasePageContext // TypeDefIndex: 29842
{
	// Fields
	private GameObject _mapGameObject; // 0x190
	private MonoLevelMapUI _mapScript; // 0x198
	private MonoInLevelMapPage _pageMono; // 0x1A0
	private RewardPreviewComponent _rewardPreviewComponent; // 0x1A8
	private uint _mapFogHandle; // 0x1B0
	private Action _loadingCallback; // 0x1B8
	private Dictionary<uint, MonoMapMark> _transPointMarks; // 0x1C0
	private Dictionary<uint, MonoMapMark> _companionMarks; // 0x1C8
	private Dictionary<int, Dictionary<uint, MonoMapMark>> _markType2markDic; // 0x1D0
	private Rect _mapViewRect; // 0x1D8
	private MonoMapMark _localAvatarMark; // 0x1E8
	private Rect _markContainerViewport; // 0x1F0
	private InfoTextDialogContext _infoTextDialog; // 0x200
	private int _markLayer; // 0x208
	public static float currZoomValue; // 0x00
	private uint _markId; // 0x20C
	private MarkType _markType; // 0x210
	private bool _needTrack; // 0x214
	private List<MonoMapMark> _nearMarks; // 0x218
	private List<uint> _nearMarkIdentifiers; // 0x220
	private MonoMapMark _hintMark; // 0x228
	private List<RewardTip> _rewardTipsDataList; // 0x230
	private Vector3 _customMarkWorldPos; // 0x238
	private string _customMarkTitle; // 0x248
	private MarkIconType _customMarktype; // 0x250
	private bool _isCreatCustomMark; // 0x254
	private bool _isCenterCameraNoReason; // 0x255
	private const float CHANGE_DISTANCE = 0.03f; // Metadata: 0x00B10123
	private uint _customMarkTrackMonsterID; // 0x258
	private uint _customMarkTrackQuestID; // 0x25C
	private CustomMarkTrackReasonType _customMarkTrackReasonType; // 0x260
	private bool _isAdventureHandbookOpened; // 0x264
	private float _slideValue; // 0x268
	private Dictionary<MonoMapMark, GameObject> trackingIndictor; // 0x270
	private float currAnimTime; // 0x278
	private Vector2 startPos; // 0x27C
	private readonly float resetPeriod; // 0x284
	private Vector2 _currRectPos; // 0x288
	private Vector2 _currRectSize; // 0x290
	private GameObject _playerIndicator; // 0x298
	private Vector2 _newPos; // 0x2A0
	private Dictionary<uint, GameObject> _questAreaMarkDic; // 0x2A8
	private const string unlockBlueWidgetPath = "ART/UI/Menus/Widget/Unlock_Blue"; // Metadata: 0x00B10127
	private GameObject _lockBlueObj; // 0x2B0
	private bool _canTrans; // 0x2B8
	private uint _unlockAreaID; // 0x2BC
	private const string unlockRedWidgetPath = "ART/UI/Menus/Widget/Unlock_Red"; // Metadata: 0x00B1014A
	private GameObject _lockRedObj; // 0x2C0
	private bool _showDisableLimitRegion; // 0x2C8
	private const int INPUT_STATE_DEFAULT = 0; // Metadata: 0x00B1016C
	private const int INPUT_STATE_UNLOCK_SHOW = 1; // Metadata: 0x00B10170
	private const int INPUT_STATE_MARK_TIPS = 2; // Metadata: 0x00B10174
	private const int INPUT_STATE_REWARD_TIPS = 3; // Metadata: 0x00B10178
	private PointerEventData _cursorPointer; // 0x2D0
	private List<RaycastResult> _raycastResults; // 0x2D8
	private GameObject _currOverGameObject; // 0x2E0
	private bool _anyMarkUnderCursor; // 0x2E8
	private int _selectedRewardTipsIndex; // 0x2EC
	private Coroutine _updateRecoveryTextCoroutineOfResin; // 0x2F0
	private bool _resinOpened; // 0x2F8
	private MapTagType _currTag; // 0x2FC
	private uint _currShownID; // 0x300
	private uint _currSelectedID; // 0x304
	private MapTagDataConfig _currSelectedConfig; // 0x308
	private List<MapTagDataConfig> _mapTagConfig; // 0x310
	private uint _sceneToLoad; // 0x318
	private MonoMapMark _selectedMark; // 0x320
	private uint BOSS_DUNGEON_ENTRY_ID; // 0x328
	private MarkTipsContentType _markTipsContentType; // 0x32C
	private static uint[] _questMarkBlackListID; // 0x08
	private List<BagItem> _reward; // 0x330
	private List<IdCountStrConfig> _rewardPreviewList; // 0x338
	private DungeonEntry _selectedDungeonEntry; // 0x340
	private DungeonEntryState _selectDungeonEntryState; // 0x348
	private Coroutine _updateDungeonCooldownTipsCoroutine; // 0x350
	private DungeonEntryInfoList _dungeonEntryInfoList; // 0x358
	private uint _dungeonEntryPointID; // 0x3EC
	private DungeonTabSelectState _dungeonTabSelectState; // 0x3F0
	private MonoDungeonTabTip _selectedTitle; // 0x3F8
	private int _selectedTitleIndex; // 0x400
	private MonoItemSlot _selectedReward; // 0x408
	private int _selectedRewardIndex; // 0x410
	private int _rewardPerRow; // 0x414
	private ItemTipsDialogHelper _itemTipsHelper; // 0x418
	private Coroutine _updateReviveCooldownCoroutine; // 0x420
	private int _selectedMapTagIndex; // 0x428
	private int _selectedPanelTagIndex; // 0x42C
	private MonoMapMark _selectedCustomMark; // 0x430
	private int _customMarkCount; // 0x438
	private MarkIconType[] _customMarkIcons; // 0x440
	private Vector2 _currMapPos; // 0x448

	// Nested types
	public enum E_RewardTipType // TypeDefIndex: 29843
	{
		AdTask = 0,
		AdPlayer = 1,
		AdExped = 2,
		ForgeFinish = 3,
		Food = 4,
		SaleMan = 5,
		ReputationReward = 6,
		ReputationQuest = 7,
		HuntingInfo = 8,
		ElderTree = 9,
		ActivityBlessing = 10,
		ExpeditionChallenge = 11,
		ActivityWaterSprite = 12,
		ActivityMiniTomoHiliWei = 13,
		ArenaChallenge = 14,
		HomeworldLevel = 15,
		HomeworldCoin = 16,
		HomeworldCompanionshipExp = 17,
		HomeworldBuild = 18,
		HomeworldDjinnWeekendRefresh = 19
	}

	public class RewardTip // TypeDefIndex: 29844
	{
		// Fields
		public E_RewardTipType rewardType; // 0x10
		public MonoMapMark mark; // 0x18

		// Constructors
		public RewardTip() {} // Dummy constructor
		public RewardTip(E_RewardTipType type, MonoMapMark mapMark) {} // 0x000000018433C100-0x000000018433C180
	}

	private enum DungeonEntryState // TypeDefIndex: 29845
	{
		LOCKED = 0,
		TOBEEXPLORE = 1,
		UNLOCKED = 2
	}

	private enum MarkTipsContentType // TypeDefIndex: 29846
	{
		Normal = 0,
		AddCustomMark = 1,
		EditCustomMark = 2,
		Dungeon = 3,
		Boss = 4,
		Routine = 5,
		MapTagSwitch = 6
	}

	private struct DungeonEntryInfo // TypeDefIndex: 29847
	{
		// Fields
		public uint id; // 0x00
		public bool isPassed; // 0x04
		public uint maxBossChestNum; // 0x08
		public uint openedBossCheestNum; // 0x0C
		public uint nextRefreshTime; // 0x10
		public WeeklyBossResinDiscountInfoStruct weeklyBossResinDiscount; // 0x14
	}

	private struct DungeonEntryInfoList // TypeDefIndex: 29848
	{
		// Fields
		public int count; // 0x00
		public DungeonEntryInfo first; // 0x04
		public DungeonEntryInfo second; // 0x28
		public DungeonEntryInfo third; // 0x4C
		public DungeonEntryInfo fourth; // 0x70
	}

	private enum DungeonTabSelectState // TypeDefIndex: 29849
	{
		NotReady = 0,
		SelectTitle = 1,
		SelectReward = 2,
		DailyReward = 3
	}

	// Constructors
	public InLevelMapPageContext() {} // Dummy constructor
	public InLevelMapPageContext(uint markId = 0 /* Metadata: 0x00B10100 */, MarkType markType = MarkType.TransPoint /* Metadata: 0x00B10104 */, bool needTrack = true /* Metadata: 0x00B10108 */, float slideValue = 0f /* Metadata: 0x00B10109 */) {} // 0x000000018104FA60-0x000000018104FF70
	public InLevelMapPageContext(Vector3 worldPos, string title, MarkIconType type) {} // 0x000000018104FF70-0x0000000181050690
	public InLevelMapPageContext(Vector3 worldPos, Action loadingCallback = null) {} // 0x000000018104F560-0x000000018104FA60
	static InLevelMapPageContext() {} // 0x000000018104F4B0-0x000000018104F560

	// Methods
	// [XID] // 0x000000018973B1E0-0x000000018973B200
	protected override void PostReleaseView() {} // 0x000000018104E870-0x000000018104E910
	// [XID] // 0x0000000189742B90-0x0000000189742BB0
	private void OnMapLoaded() {} // 0x0000000181017D80-0x00000001810186B0
	// [XID] // 0x000000018974A870-0x000000018974A890
	private void LoadMap() {} // 0x0000000181025460-0x00000001810255B0
	// [XID] // 0x0000000189751970-0x0000000189751990
	private void CenterCameraAt(Vector2 levelMapPos, bool keepZ = false /* Metadata: 0x00B1010D */) {} // 0x00000001810347A0-0x00000001810348A0
	// [XID] // 0x0000000189758F80-0x0000000189758FA0
	public override void SetupView() {} // 0x000000018104EAF0-0x000000018104F4B0
	// [XID] // 0x0000000189760BF0-0x0000000189760C10
	private void CheckShowMiniMapMarkArea(bool show) {} // 0x000000018101CDA0-0x000000018101CF10
	// [XID] // 0x0000000189767E90-0x0000000189767EB0
	protected override void BindViewCallbacks() {} // 0x0000000181019220-0x00000001810194E0
	// [XID] // 0x000000018976F480-0x000000018976F4A0
	private void CheckClearMap() {} // 0x000000018102E4B0-0x000000018102E650
	// [XID] // 0x0000000189776EC0-0x0000000189776EE0
	public override void ClosePage() {} // 0x0000000181016930-0x0000000181016A20
	// [XID] // 0x000000018977E580-0x000000018977E5A0
	public override void ClearView() {} // 0x000000018101D9E0-0x000000018101DDF0
	// [XID] // 0x0000000189785CF0-0x0000000189785D10
	private void OnReleaseMap() {} // 0x000000018102ABC0-0x000000018102AC80
	// [XID] // 0x000000018978D410-0x000000018978D430
	protected override void ReleaseView() {} // 0x000000018104E9C0-0x000000018104EAF0
	// [XID] // 0x0000000189794790-0x00000001897947B0
	protected override void OnPostSetActive() {} // 0x000000018104B010-0x000000018104B1A0
	// [XID] // 0x000000018979CC20-0x000000018979CC40
	public override bool OnNotify(Notify ntf) => default; // 0x000000018104A9E0-0x000000018104AE30
	// [XID] // 0x00000001897A4080-0x00000001897A40A0
	private void PlayMarkUnlockEffect() {} // 0x000000018103B910-0x000000018103BA20
	// [XID] // 0x00000001897AB5E0-0x00000001897AB600
	private MonoMapMark GetUnlockEffectMark() => default; // 0x000000018103A0D0-0x000000018103A3A0
	// [XID] // 0x00000001897B3430-0x00000001897B3450
	protected override void RegisterHandlePacket() {} // 0x000000018104E910-0x000000018104E9C0
	// [XID] // 0x00000001897BB310-0x00000001897BB330
	public override bool OnPacket(Packet packet) => default; // 0x000000018104AE30-0x000000018104B010
	// [XID] // 0x00000001897C2AF0-0x00000001897C2B10
	private void OnSliderChanged(float value) {} // 0x0000000181034A90-0x0000000181034B70
	// [XID] // 0x00000001897CA330-0x00000001897CA350
	private void OnZoomChanged(float value) {} // 0x00000001810357A0-0x00000001810358B0
	// [XID] // 0x00000001897D1990-0x00000001897D19B0
	protected override void OnEnable() {} // 0x000000018104A8F0-0x000000018104A9E0
	// [XID] // 0x00000001897D97B0-0x00000001897D97D0
	protected override void OnDisable() {} // 0x000000018104A810-0x000000018104A8F0
	// [XID] // 0x00000001897E0B70-0x00000001897E0B90
	private void OnLevelMapUIManagerLoaded() {} // 0x00000001810195F0-0x000000018101A230
	// [XID] // 0x00000001897E81D0-0x00000001897E81F0
	private void ResetSliderValue() {} // 0x000000018104B890-0x000000018104BAA0
	// [IDTag] // 0x00000001897EFED0-0x00000001897EFF10
	// [XID] // 0x00000001897EFED0-0x00000001897EFF10
	private void ResetCameraView(Vector2 mapPos, bool withAnim = false /* Metadata: 0x00B1010E */) {} // 0x000000018102CF40-0x000000018102D420
	[DebuggerHidden] // 0x00000001897FA990-0x00000001897FA9D0
	// [XID] // 0x00000001897FA990-0x00000001897FA9D0
	private IEnumerator SetCameraViewCoroutine(Vector2 targetPos) => default; // 0x00000001810468B0-0x00000001810469A0
	// [IDTag] // 0x0000000189804C60-0x0000000189804CA0
	// [XID] // 0x0000000189804C60-0x0000000189804CA0
	private void ResetCameraView(Vector2 mapPos, float slideValue) {} // 0x000000018102CE20-0x000000018102CF40
	// [XID] // 0x000000018980F650-0x000000018980F670
	private void InitAllMark() {} // 0x00000001810103A0-0x0000000181011990
	// [XID] // 0x0000000189816D00-0x0000000189816D20
	private void RefreshQuestLayerColor() {} // 0x0000000181018A20-0x0000000181018C10
	// [XID] // 0x000000018981E550-0x000000018981E570
	private void UpdateUnderLayerColor(MonoMapMark mark) {} // 0x0000000181046540-0x00000001810468B0
	// [XID] // 0x00000001898259F0-0x0000000189825A10
	private void RefreshAllMark() {} // 0x0000000181018C10-0x0000000181018E80
	// [XID] // 0x000000018982D1A0-0x000000018982D1C0
	private void FetchAllMark() {} // 0x000000018103B820-0x000000018103B910
	// [XID] // 0x0000000189834900-0x0000000189834920
	private void InitLocalAvatarMark() {} // 0x0000000181035D30-0x0000000181036240
	// [XID] // 0x000000018983BF90-0x000000018983BFB0
	private MonoMapMark InitMark(MarkType markType, MarkIconType iconType) => default; // 0x000000018103D360-0x000000018103D560
	// [XID] // 0x00000001898435C0-0x00000001898435E0
	private Dictionary<uint, MonoMapMark> GetMarkDic(MarkType markType) => default; // 0x0000000181021170-0x00000001810212C0
	// [XID] // 0x000000018984AAC0-0x000000018984AAE0
	private void UpdateCustomMark(uint markID, GeneralMarkData markData) {} // 0x0000000181048F70-0x0000000181049140
	// [XID] // 0x0000000189851E60-0x0000000189851E80
	private void UpdatePinMark(uint markID, GeneralMarkData markData) {} // 0x0000000181013CB0-0x0000000181013F50
	// [IDTag] // 0x0000000189859720-0x0000000189859760
	// [XID] // 0x0000000189859720-0x0000000189859760
	private void AddCustomMark(uint identifier, GeneralMarkData markData) {} // 0x0000000181041A80-0x0000000181041DB0
	// [XID] // 0x0000000189863D40-0x0000000189863D60
	private void AddFakeMarkAsHint(Vector2 levelMapPos, MarkIconType type = MarkIconType.MarkCustomBoss /* Metadata: 0x00B1010F */) {} // 0x000000018102E1D0-0x000000018102E4B0
	// [XID] // 0x000000018986B070-0x000000018986B090
	private void UpdateCompanionMark(uint markID, GeneralMarkData markData) {} // 0x0000000181037890-0x0000000181037C40
	// [XID] // 0x0000000189872440-0x0000000189872460
	private void ShowPS4OnlineID(MonoMapMark mark) {} // 0x0000000181035B00-0x0000000181035D30
	// [XID] // 0x000000018987A050-0x000000018987A070
	private void UpdateTransPointMark(uint markID, GeneralMarkData markData) {} // 0x00000001810285B0-0x0000000181028A40
	// [XID] // 0x0000000189881210-0x0000000189881230
	private void UpdatePacketAnchor(uint markID, GeneralMarkData markData) {} // 0x00000001810250B0-0x00000001810253A0
	// [XID] // 0x00000001898887C0-0x00000001898887E0
	private void UpdateTowerTopTip(bool open, MonoMapMark mark) {} // 0x00000001810259D0-0x0000000181025C20
	// [XID] // 0x000000018988FB80-0x000000018988FBA0
	private void UpdateBossMark(uint markID, GeneralMarkData markData) {} // 0x000000018103D560-0x000000018103DF00
	// [XID] // 0x0000000189897040-0x0000000189897060
	private void UpdateHuntingMark(uint markID, GeneralMarkData markData) {} // 0x00000001810409B0-0x0000000181040C00
	// [XID] // 0x000000018989E580-0x000000018989E5A0
	private void UpdateWidgetMark(uint markID, GeneralMarkData markData) {} // 0x0000000181040830-0x00000001810409B0
	// [XID] // 0x00000001898A6080-0x00000001898A60A0
	private void UpdateActivityRegionMark(uint markID, GeneralMarkData markData) {} // 0x00000001810212C0-0x00000001810214B0
	// [XID] // 0x00000001898AD670-0x00000001898AD690
	private void UpdateGalleryRegionMark(uint markID, GeneralMarkData markData) {} // 0x0000000181036820-0x0000000181036A20
	// [XID] // 0x00000001898B4BD0-0x00000001898B4BF0
	private void UpdateFlightActivityMark(uint markID, GeneralMarkData markData) {} // 0x0000000181036470-0x00000001810366D0
	// [XID] // 0x00000001898BC700-0x00000001898BC720
	private void UpdateRoutineMark(uint markID, GeneralMarkData markData) {} // 0x0000000181043C10-0x0000000181043EE0
	// [XID] // 0x00000001898C3CE0-0x00000001898C3D00
	private void UpdateHomeworldDynamicMark(uint markID, GeneralMarkData markData) {} // 0x0000000181026B70-0x0000000181026E20
	// [IDTag] // 0x00000001898CB560-0x00000001898CB5A0
	// [XID] // 0x00000001898CB560-0x00000001898CB5A0
	private void RemoveInvalidMark(Dictionary<uint, MonoMapMark> markDic, uint invalidMarkID) {} // 0x0000000181030DB0-0x0000000181030ED0
	// [IDTag] // 0x00000001898D5C70-0x00000001898D5CB0
	// [XID] // 0x00000001898D5C70-0x00000001898D5CB0
	private void RemoveInvalidMark(MarkType markType, uint markID) {} // 0x0000000181030C70-0x0000000181030DB0
	// [XID] // 0x00000001898E09B0-0x00000001898E09D0
	private float GetNearValue(MonoMapMark mark1, MonoMapMark mark2) => default; // 0x0000000181023A10-0x0000000181023B70
	// [XID] // 0x00000001898E84F0-0x00000001898E8510
	private bool IsNear(MonoMapMark mark1, MonoMapMark mark2) => default; // 0x00000001810206E0-0x0000000181020860
	// [XID] // 0x00000001898EFCD0-0x00000001898EFCF0
	private bool IsMuteMark(MonoMapMark mark) => default; // 0x0000000181036B30-0x0000000181036C90
	// [XID] // 0x00000001898F7510-0x00000001898F7530
	private bool IsLayerShow(MonoMapMark mark) => default; // 0x0000000181011990-0x0000000181011B40
	// [XID] // 0x00000001898FEC20-0x00000001898FEC40
	private void GetNearMarks(MonoMapMark mark) {} // 0x000000018102D7F0-0x000000018102E1D0
	// [XID] // 0x00000001899063E0-0x0000000189906400
	private void OnMarkSelectDialogClose() {} // 0x00000001810481A0-0x0000000181048390
	// [XID] // 0x000000018990DE20-0x000000018990DE40
	private void OnMarkClicked(MonoMapMark mark) {} // 0x000000018104E3A0-0x000000018104E810
	// [XID] // 0x00000001899155B0-0x00000001899155D0
	private void OnSingleMarkClicked(MonoMapMark mark) {} // 0x0000000181023B70-0x0000000181024410
	// [XID] // 0x000000018991D000-0x000000018991D020
	private void OnViewChange(float viewX, float viewY, float viewWidth, float viewHeight) {} // 0x0000000181029D20-0x000000018102A8D0
	// [XID] // 0x00000001899248D0-0x00000001899248F0
	private void InitPlayerIndicator() {} // 0x0000000181036240-0x00000001810363F0
	// [XID] // 0x000000018992BE40-0x000000018992BE60
	private void ClearPlayerIndicator() {} // 0x00000001810370F0-0x0000000181037210
	// [XID] // 0x0000000189933370-0x0000000189933390
	public void LocatePlayerIndicator() {} // 0x0000000181028120-0x00000001810285B0
	// [XID] // 0x000000018993AF00-0x000000018993AF20
	private void RemoveTrackingIndictor(MonoMapMark mark) {} // 0x000000018101B790-0x000000018101B8D0
	// [XID] // 0x0000000189941FD0-0x0000000189941FF0
	private void ClearTrackingIndicator() {} // 0x000000018103EC30-0x000000018103EE60
	// [XID] // 0x0000000189949A70-0x0000000189949A90
	private void LocateTrackingIndictor(MonoMapMark mark, Rect mapViewRect) {} // 0x000000018101F4A0-0x000000018101FE50
	// [XID] // 0x00000001899514A0-0x00000001899514C0
	private void LocateMark(MonoMapMark mark, Rect mapViewRect) {} // 0x00000001810448D0-0x0000000181044C50
	// [XID] // 0x0000000189958AD0-0x0000000189958AF0
	private void ReuseAllMark() {} // 0x000000018101AF40-0x000000018101B5F0
	// [XID] // 0x0000000189960110-0x0000000189960130
	private void OnMapClicked(Vector2 screenPos) {} // 0x0000000181027D20-0x0000000181028120
	// [XID] // 0x0000000189967B90-0x0000000189967BB0
	private void UpdateDirtyMarks(List<MarkManager.GeneralMarkID> dirtyList) {} // 0x00000001810186B0-0x0000000181018A20
	// [XID] // 0x000000018996ED70-0x000000018996ED90
	private void UpdateMovedMarks(List<MarkManager.GeneralMarkID> movedMarks) {} // 0x000000018104BAA0-0x000000018104BCF0
	// [XID] // 0x00000001899769B0-0x00000001899769D0
	private void RefreshScenePointMarkView(uint markID, GeneralMarkData markData) {} // 0x0000000181026F40-0x0000000181027510
	// [XID] // 0x000000018997DDB0-0x000000018997DDD0
	private void RefreshQuestMarkView() {} // 0x0000000181037C40-0x0000000181038400
	// [IDTag] // 0x0000000189985740-0x0000000189985780
	// [XID] // 0x0000000189985740-0x0000000189985780
	private void RefreshTaskMarkView() {} // 0x0000000181032130-0x0000000181032390
	// [IDTag] // 0x00000001899904A0-0x00000001899904E0
	// [XID] // 0x00000001899904A0-0x00000001899904E0
	private void RefreshTaskMarkView(uint markID, GeneralMarkData markData) {} // 0x0000000181031E30-0x0000000181032130
	// [IDTag] // 0x000000018999B140-0x000000018999B180
	// [XID] // 0x000000018999B140-0x000000018999B180
	private void RefreshTalkMarkView() {} // 0x0000000181027720-0x0000000181027980
	// [IDTag] // 0x00000001899A5B90-0x00000001899A5BD0
	// [XID] // 0x00000001899A5B90-0x00000001899A5BD0
	private void RefreshTalkMarkView(uint markID, GeneralMarkData markData) {} // 0x0000000181027980-0x0000000181027C40
	// [XID] // 0x00000001899B04F0-0x00000001899B0510
	public void UnlockArea(uint sceneID, uint areaID) {} // 0x000000018102C7E0-0x000000018102C960
	// [XID] // 0x00000001899B7820-0x00000001899B7840
	private void RealUnlockArea(uint sceneID, uint areaID) {} // 0x000000018103F280-0x000000018103F930
	// [XID] // 0x00000001899BF1C0-0x00000001899BF1E0
	public void ShowDisableLimitRegion() {} // 0x0000000181012340-0x00000001810124E0
	// [XID] // 0x00000001899C6BC0-0x00000001899C6BE0
	private void ClearAnimationLogicObjs() {} // 0x000000018102FF70-0x0000000181030170
	// [XID] // 0x00000001899CE100-0x00000001899CE120
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181030930-0x0000000181030A80
	// [XID] // 0x00000001899D58A0-0x00000001899D58C0
	private bool HandleInputActionEvent_Default(InputActionEvent actionEvent) => default; // 0x0000000181020A20-0x0000000181021170
	// [XID] // 0x00000001899DCBF0-0x00000001899DCC10
	private bool HandleInputActionEvent_MarkTips(InputActionEvent actionEvent) => default; // 0x0000000181028B40-0x0000000181029B20
	// [XID] // 0x00000001899E4830-0x00000001899E4850
	private bool HandleInputActionEvent_RewardTips(InputActionEvent actionEvent) => default; // 0x00000001810348A0-0x0000000181034A90
	// [XID] // 0x00000001899EBC20-0x00000001899EBC40
	private void MoveMap(Vector2 input) {} // 0x0000000181021510-0x00000001810216E0
	// [XID] // 0x00000001899F36F0-0x00000001899F3710
	private void MoveCursor(Vector2 input) {} // 0x0000000181024410-0x0000000181024CA0
	// [XID] // 0x00000001899FB010-0x00000001899FB030
	private void ZoomMap(float value) {} // 0x000000018103FFC0-0x0000000181040230
	// [XID] // 0x0000000189A02260-0x0000000189A02280
	private void UpdateCurrOverAndSetGotoBtn() {} // 0x00000001810469A0-0x0000000181046CA0
	// [XID] // 0x0000000189A09A50-0x0000000189A09A70
	private void UpdateCurrOverGameObject() {} // 0x0000000181043500-0x0000000181043C10
	// [XID] // 0x0000000189A111F0-0x0000000189A11210
	private bool OnSelect() => default; // 0x000000018104B1A0-0x000000018104B510
	// [XID] // 0x0000000189A18580-0x0000000189A185A0
	private RaycastResult FindFirstRaycast(List<RaycastResult> candidates) => default; // 0x00000001810230E0-0x0000000181023470
	// [XID] // 0x0000000189A1FCA0-0x0000000189A1FCC0
	public void OnItemTipsDungeonEntryClick(uint dungeonEntryID) {} // 0x0000000181040230-0x0000000181040470
	// [XID] // 0x0000000189A27010-0x0000000189A27030
	private void CreatCustomMark(Vector3 worldPos, string title, MarkIconType type) {} // 0x0000000181024F10-0x00000001810250B0
	// [XID] // 0x0000000189A2E830-0x0000000189A2E850
	private bool CompareTrackReasonID(MapMarkPoint mark) => default; // 0x0000000181011C40-0x0000000181011D40
	// [XID] // 0x0000000189A36180-0x0000000189A361A0
	public void SetCreatCustomMarkMonsterID(CustomMarkTrackReasonType type, uint configID) {} // 0x0000000181014310-0x00000001810143F0
	// [XID] // 0x0000000189A3D780-0x0000000189A3D7A0
	private void HideRewardTips() {} // 0x000000018104B510-0x000000018104B5D0
	// [XID] // 0x0000000189A44EC0-0x0000000189A44EE0
	private bool CheckReward(MapTagType tagType) => default; // 0x000000018103A730-0x000000018103A7F0
	// [XID] // 0x0000000189A4C660-0x0000000189A4C680
	private MarkIconType GetFirstRewardIconType(MapTagType tagType) => default; // 0x000000018103E110-0x000000018103EC30
	// [XID] // 0x0000000189A53E00-0x0000000189A53E20
	private void SetRewardTips() {} // 0x00000001810124E0-0x0000000181013CB0
	// [XID] // 0x0000000189A5B830-0x0000000189A5B850
	private void RefreshRewardTipItem(Transform trans, int index) {} // 0x0000000181022A40-0x0000000181022E10
	// [XID] // 0x0000000189A62F20-0x0000000189A62F40
	private MonoMapMark GetAdvenMark() => default; // 0x0000000181047430-0x0000000181047640
	// [XID] // 0x0000000189A6AA40-0x0000000189A6AA60
	private MonoMapMark GetForgeMark() => default; // 0x000000018103DF00-0x000000018103E110
	// [XID] // 0x0000000189A72140-0x0000000189A72160
	private MonoMapMark GetFoodMark() => default; // 0x000000018103D160-0x000000018103D360
	// [XID] // 0x0000000189A79DE0-0x0000000189A79E00
	private MonoMapMark GetSalesmanMark() => default; // 0x0000000181040C00-0x0000000181040E00
	// [IDTag] // 0x0000000189A81240-0x0000000189A81280
	// [XID] // 0x0000000189A81240-0x0000000189A81280
	private MonoMapMark GetReputationMark(MarkIconType cityReputationMarkType) => default; // 0x000000018103B2D0-0x000000018103B4D0
	// [IDTag] // 0x0000000189A8BCB0-0x0000000189A8BCF0
	// [XID] // 0x0000000189A8BCB0-0x0000000189A8BCF0
	private MonoMapMark GetReputationMark() => default; // 0x000000018103B4D0-0x000000018103B820
	// [XID] // 0x0000000189A96250-0x0000000189A96270
	private MonoMapMark GetHuntingMark() => default; // 0x00000001810342A0-0x00000001810344A0
	// [XID] // 0x0000000189A9D7A0-0x0000000189A9D7C0
	private MonoMapMark GetActivityExpeditionChallengeMark() => default; // 0x0000000181049640-0x0000000181049840
	// [XID] // 0x0000000189AA5050-0x0000000189AA5070
	private MonoMapMark GetActivityArenaChallengeMark() => default; // 0x0000000181038D30-0x0000000181038F30
	// [XID] // 0x0000000189AAC830-0x0000000189AAC850
	private MonoMapMark GetActivityMiniTomoHiliWeiMark() => default; // 0x000000018102ADD0-0x000000018102AFD0
	// [XID] // 0x0000000189AB40B0-0x0000000189AB40D0
	private MonoMapMark GetActivityWaterSpriteExploreMark() => default; // 0x000000018103B0D0-0x000000018103B2D0
	// [XID] // 0x0000000189ABBDF0-0x0000000189ABBE10
	private MonoMapMark GetElderTreeMark() => default; // 0x0000000181029B20-0x0000000181029D20
	// [XID] // 0x0000000189AC35C0-0x0000000189AC35E0
	private MonoMapMark GetHomeworldDjinnMark() => default; // 0x00000001810446D0-0x00000001810448D0
	// [XID] // 0x0000000189ACAC50-0x0000000189ACAC70
	private MonoMapMark GetHomeworldDjinnWeekendMark() => default; // 0x000000018102E6B0-0x000000018102E8B0
	// [XID] // 0x0000000189AD26C0-0x0000000189AD26E0
	private MonoMapMark GetActivityBlessingMark() => default; // 0x000000018101CF10-0x000000018101D110
	// [XID] // 0x0000000189ADA150-0x0000000189ADA170
	private string GetRewardTipTitle(E_RewardTipType rewardType, MonoMapMark mark) => default; // 0x00000001810426E0-0x0000000181042B40
	// [XID] // 0x0000000189AE1A10-0x0000000189AE1A30
	private bool ShowHighLight(E_RewardTipType rewardType) => default; // 0x000000018102D420-0x000000018102D510
	// [XID] // 0x0000000189AE91C0-0x0000000189AE91E0
	private void SelectRewardTips(int? currIndex, int? prevIndex) {} // 0x000000018104B5D0-0x000000018104B890
	// [XID] // 0x0000000189AF0FB0-0x0000000189AF0FD0
	private void ChangeFocusToRewardTips() {} // 0x0000000181014A80-0x0000000181014CD0
	// [XID] // 0x0000000189AF8430-0x0000000189AF8450
	private void CancelFocusToRewardTips() {} // 0x000000018103BB80-0x000000018103BEB0
	// [XID] // 0x0000000189AFFB40-0x0000000189AFFB60
	private void ToNextRewardTips() {} // 0x0000000181015370-0x00000001810154A0
	// [XID] // 0x0000000189B07130-0x0000000189B07150
	private void ToPrevRewardTips() {} // 0x00000001810178B0-0x00000001810179B0
	// [XID] // 0x0000000189B0E8F0-0x0000000189B0E910
	private void OpenSelectedRewardTips() {} // 0x000000018102FD30-0x000000018102FEC0
	// [XID] // 0x0000000189B15CE0-0x0000000189B15D00
	private void InitResinView() {} // 0x000000018104CE90-0x000000018104D210
	// [XID] // 0x0000000189B1D3F0-0x0000000189B1D410
	private void RefreshResinView() {} // 0x000000018101FE50-0x0000000181020040
	// [XID] // 0x0000000189B24C70-0x0000000189B24C90
	private void SetupCycleDungeonLookupToggle() {} // 0x0000000181038660-0x00000001810388D0
	// [XID] // 0x0000000189B2C0E0-0x0000000189B2C100
	private void OnLookupToggleChanged(bool on) {} // 0x00000001810253A0-0x0000000181025460
	// [XID] // 0x0000000189B336D0-0x0000000189B336F0
	private void ChangeAllNonCycleDungeonMarkHideState(bool isHide) {} // 0x000000018103A7F0-0x000000018103ADD0
	// [XID] // 0x0000000189B3AFB0-0x0000000189B3AFD0
	private void ChangeNonCycleDungeonMarkHideState(MonoMapMark mark, bool isHide) {} // 0x0000000181035990-0x0000000181035B00
	// [XID] // 0x0000000189B42770-0x0000000189B42790
	private void ShowDungeonEntryExploredCondition(GetDungeonEntryExploreConditionRsp rsp) {} // 0x000000018103F0C0-0x000000018103F280
	// [XID] // 0x0000000189B4A2B0-0x0000000189B4A2D0
	private void OnHomeworldVisitorBtnClick() {} // 0x0000000181023470-0x0000000181023570
	// [XID] // 0x0000000189B51A90-0x0000000189B51AB0
	private void RefreshHomeworldVisitorBtnText() {} // 0x000000018104D210-0x000000018104D540
	// [XID] // 0x0000000189B59210-0x0000000189B59230
	private void SetupHomeworldVisitor() {} // 0x000000018103ADD0-0x000000018103AF60
	// [XID] // 0x0000000189B60AE0-0x0000000189B60B00
	private void SetHomeworldVisitorBtnState(bool active) {} // 0x0000000181040670-0x0000000181040830
	// [XID] // 0x0000000189B68190-0x0000000189B681B0
	public void RefreshBigworldExploreDegree() {} // 0x000000018103FBD0-0x000000018103FFC0
	// [XID] // 0x0000000189B6F530-0x0000000189B6F550
	private void RefreshMapMarkTips(GetMapMarkTipsRsp rsp) {} // 0x0000000181025820-0x00000001810259D0
	// [XID] // 0x0000000189B76BB0-0x0000000189B76BD0
	private void RefreshMapMarkTipsElementTrial(RepeatedField<uint> pointIdList) {} // 0x0000000181038400-0x0000000181038660
	// [XID] // 0x0000000189B7E140-0x0000000189B7E160
	private void ResetCurrTag() {} // 0x000000018103AF60-0x000000018103B0D0
	// [XID] // 0x0000000189B85D20-0x0000000189B85D40
	private uint GetSceneFromTag(MapTagType tag) => default; // 0x000000018104C580-0x000000018104C7C0
	// [XID] // 0x0000000189B8CD50-0x0000000189B8CD70
	private uint GetSceneToLoad() => default; // 0x000000018102FEC0-0x000000018102FF70
	// [XID] // 0x0000000189B94540-0x0000000189B94560
	private void OpenMapSwitchPanel() {} // 0x0000000181025610-0x0000000181025750
	// [XID] // 0x0000000189B9BBF0-0x0000000189B9BC10
	private void InitMapTagConfig() {} // 0x0000000181034040-0x00000001810342A0
	// [XID] // 0x0000000189BA3370-0x0000000189BA3390
	private bool IsTagUnlocked(MapTagDataConfig config) => default; // 0x0000000181031210-0x0000000181031300
	// [XID] // 0x0000000189BAA6D0-0x0000000189BAA6F0
	private bool IsHomeworldUnlocked() => default; // 0x000000018101C140-0x000000018101C230
	// [XID] // 0x0000000189BB1D50-0x0000000189BB1D70
	private void InitMapTagScroller() {} // 0x0000000181038F30-0x00000001810390F0
	// [XID] // 0x0000000189BB9110-0x0000000189BB9130
	private void RefreshMapTagScroller() {} // 0x0000000181016460-0x00000001810165D0
	// [XID] // 0x0000000189BC0EC0-0x0000000189BC0EE0
	private void InitMapTagSwitch(Transform trans, int index) {} // 0x00000001810154A0-0x0000000181015880
	// [XID] // 0x0000000189BC85D0-0x0000000189BC85F0
	private void DoOnClickMapTag(MapTagDataConfig config) {} // 0x0000000181011B40-0x0000000181011C40
	// [XID] // 0x0000000189BCFE70-0x0000000189BCFE90
	private void CloseMapSwitchPanel() {} // 0x00000001810194E0-0x00000001810195F0
	// [XID] // 0x0000000189BD7470-0x0000000189BD7490
	private void MapDoSwitchPanel() {} // 0x000000018103BEB0-0x000000018103C1C0
	// [XID] // 0x0000000189BDEF90-0x0000000189BDEFB0
	private void RefreshExploreDegreeGrp() {} // 0x0000000181042F90-0x00000001810432B0
	// [XID] // 0x00000001895EBC40-0x00000001895EBC60
	private void RefreshExploreDegreeRedPoint() {} // 0x000000018101AD60-0x000000018101AE80
	// [XID] // 0x00000001895F2FE0-0x00000001895F3000
	private bool TagNeedRedPoint(MapTagType tag) => default; // 0x0000000181026E20-0x0000000181026F40
	// [XID] // 0x00000001895FA820-0x00000001895FA840
	private void OnGotoBtnClicked(MonoMapMark mark) {} // 0x00000001810143F0-0x0000000181014740
	// [XID] // 0x00000001896021D0-0x00000001896021F0
	private void OnGotoPacketAnchorClicked(MonoMapMark mark) {} // 0x000000018102CBD0-0x000000018102CE20
	// [XID] // 0x0000000189609A10-0x0000000189609A30
	private void OnGotoCityPoint(MonoMapMark mark) {} // 0x00000001810331F0-0x0000000181033860
	// [XID] // 0x0000000189611180-0x00000001896111A0
	private void ResetAllGrp() {} // 0x0000000181033860-0x0000000181034040
	// [XID] // 0x0000000189618B50-0x0000000189618B70
	private void OnTransMarkClicked(MonoMapMark mark) {} // 0x0000000181049C90-0x000000018104A810
	// [XID] // 0x00000001896200E0-0x0000000189620100
	private void OnPacketAnchorClicked(MonoMapMark mark) {} // 0x000000018101D110-0x000000018101D9E0
	// [XID] // 0x0000000189627530-0x0000000189627550
	private void DeletePacketAnchorConfirmed(MonoMapMark mark) {} // 0x000000018101B5F0-0x000000018101B790
	// [XID] // 0x000000018962F050-0x000000018962F070
	private void SetQuestStepDesc(MainQuestExcelConfigProxy mainCfg) {} // 0x000000018102FA10-0x000000018102FD30
	// [XID] // 0x0000000189636A10-0x0000000189636A30
	private void OnQuestMarkClicked(MonoMapMark mark) {} // 0x000000018101E810-0x000000018101F4A0
	// [XID] // 0x000000018963DF20-0x000000018963DF40
	private void OnQuestTrackButtonClicked(uint mainQuestID) {} // 0x0000000181049140-0x0000000181049640
	// [XID] // 0x00000001896458B0-0x00000001896458D0
	private void OnDailyTaskMarkClicked(MonoMapMark mark) {} // 0x0000000181021BE0-0x0000000181022930
	// [XID] // 0x000000018964D0E0-0x000000018964D100
	private void OnRoutineEventMarkClicked(MonoMapMark mark) {} // 0x0000000181031300-0x0000000181031E30
	// [XID] // 0x0000000189654800-0x0000000189654820
	private void OnRoutineTrackBtnClick(MonoMapMark mark) {} // 0x000000018101C230-0x000000018101C490
	// [XID] // 0x000000018965BF10-0x000000018965BF30
	private void OnRewardClicked(int index) {} // 0x0000000181022930-0x0000000181022A40
	// [XID] // 0x0000000189663560-0x0000000189663580
	private void OnDungeonEntryMarkClicked(MonoMapMark mark) {} // 0x00000001810432B0-0x0000000181043500
	// [XID] // 0x000000018966AF30-0x000000018966AF50
	private void SetDungeonEntryView(List<DungeonEntryInfo> dungeonEntryInfoList) {} // 0x000000018102E8B0-0x000000018102FA10
	[DebuggerHidden] // 0x0000000189672B30-0x0000000189672B70
	// [XID] // 0x0000000189672B30-0x0000000189672B70
	private IEnumerator UpdateDungeonCooldownTips(uint nextRefreshTime) => default; // 0x00000001810358B0-0x0000000181035990
	// [XID] // 0x000000018967D2D0-0x000000018967D2F0
	private void OnDungeonEntryTipsClick(uint pointID) {} // 0x0000000181036A20-0x0000000181036B30
	// [XID] // 0x00000001896849A0-0x00000001896849C0
	private void OnDungeonEntryLockedMarkClicked(MonoMapMark mark) {} // 0x00000001810388D0-0x0000000181038B00
	// [XID] // 0x000000018968C550-0x000000018968C570
	private void SetDungeonEntryLockedView() {} // 0x0000000181040E00-0x0000000181041840
	// [XID] // 0x0000000189693FC0-0x0000000189693FE0
	private void OnDungeonEntryToBeExploredMarkClicked(MonoMapMark mark) {} // 0x0000000181038B00-0x0000000181038D30
	// [XID] // 0x000000018969B530-0x000000018969B550
	private void SetDungeonEntryToBeExploredView() {} // 0x000000018101C490-0x000000018101CC90
	// [XID] // 0x00000001896A2C70-0x00000001896A2C90
	private void OnBossTipsClick() {} // 0x00000001810177A0-0x00000001810178B0
	// [XID] // 0x00000001896AA160-0x00000001896AA180
	private void OnTowerEntryMarkClicked(MonoMapMark mark) {} // 0x000000018102BBF0-0x000000018102C7E0
	// [XID] // 0x00000001896B0F40-0x00000001896B0F60
	public static string UpdateTowerRefreshStr() => default; // 0x0000000181040470-0x0000000181040670
	// [XID] // 0x00000001896B8B70-0x00000001896B8B90
	private void OnDungeonEntryInfoRsp(DungeonEntryInfoRsp rsp) {} // 0x000000018104D540-0x000000018104E3A0
	// [XID] // 0x00000001896BFD70-0x00000001896BFD90
	private void SetFleurFairDungeonEntryView() {} // 0x0000000181011D40-0x0000000181012340
	// [XID] // 0x00000001896C7650-0x00000001896C7670
	private void SetChannellerSlabOneOffDungeonEntryView(uint pointID) {} // 0x000000018102AA20-0x000000018102ABC0
	// [XID] // 0x00000001896CEDB0-0x00000001896CEDD0
	private void SetChannellerSlabLoopDungeonEntryView(uint pointID) {} // 0x0000000181021940-0x0000000181021BE0
	// [XID] // 0x00000001896D61D0-0x00000001896D61F0
	private void SetupViewDungeonTabToBeExplored(MonoDungeonTabTip ui, uint pointID) {} // 0x0000000181042B40-0x0000000181042F90
	// [XID] // 0x00000001896DD7F0-0x00000001896DD810
	private void SetupViewDungeonTab(MonoDungeonTabTip ui, DungeonEntryInfo info, bool select, Sprite titleIcon) {} // 0x0000000181016A20-0x0000000181017090
	// [XID] // 0x00000001896E4E80-0x00000001896E4EA0
	private bool TryToggleDungeonTab_Joypad() => default; // 0x0000000181014740-0x0000000181014A80
	// [XID] // 0x00000001896EC380-0x00000001896EC3A0
	private bool TryShowSelectedRewardTips_Joypad() => default; // 0x0000000181022E10-0x0000000181023060
	// [XID] // 0x00000001896F3B10-0x00000001896F3B30
	private void DungeonTabNavigationUp() {} // 0x000000018104BF20-0x000000018104C310
	// [XID] // 0x00000001896FB280-0x00000001896FB2A0
	private void DungeonTabNavigationDown() {} // 0x00000001810390F0-0x0000000181039660
	// [XID] // 0x0000000189702A30-0x0000000189702A50
	private void DungeonTabNavigationLeft() {} // 0x000000018101CC90-0x000000018101CDA0
	// [XID] // 0x000000018970A150-0x000000018970A170
	private void DungeonTabNavigationRight() {} // 0x00000001810366D0-0x0000000181036820
	// [XID] // 0x0000000189711C10-0x0000000189711C30
	private void SelectDungeonTabReward(int titleIndex, int rewardIndex) {} // 0x0000000181013F50-0x0000000181014310
	// [XID] // 0x0000000189719090-0x00000001897190B0
	private void SelectDungeonTabDailyReward(int rewardIndex, bool updateFocus = true /* Metadata: 0x00B10113 */) {} // 0x00000001810263C0-0x0000000181026690
	// [XID] // 0x0000000189720750-0x0000000189720770
	private void SelectDungeonTabTitle(int titleIndex, bool updateFocus = true /* Metadata: 0x00B10114 */) {} // 0x0000000181017A60-0x0000000181017D80
	// [XID] // 0x0000000189727D00-0x0000000189727D20
	private void NormalRewaedNavigation(ContextEventType contextEventType) {} // 0x00000001810159D0-0x0000000181015BF0
	// [XID] // 0x000000018972F3A0-0x000000018972F3C0
	private void SelectNormalReward(int index, bool focus = true /* Metadata: 0x00B10115 */) {} // 0x0000000181014FD0-0x0000000181015310
	// [XID] // 0x0000000189736D60-0x0000000189736D80
	private bool TryChangeSelectedRewardIndex(ContextEventType contextEventType, int maxCount) => default; // 0x000000018102AC80-0x000000018102ADD0
	// [XID] // 0x000000018973E960-0x000000018973E980
	private void CheckSelectNormalReward() {} // 0x0000000181020860-0x0000000181020A20
	// [XID] // 0x0000000189745C40-0x0000000189745C60
	private bool CanScrollTip(Vector2 delta) => default; // 0x000000018103A520-0x000000018103A730
	// [XID] // 0x000000018974D6F0-0x000000018974D710
	private void ScrollMarkTip(InputActionEvent actionEvent) {} // 0x0000000181047C80-0x00000001810481A0
	// [XID] // 0x0000000189754D30-0x0000000189754D50
	private void RoutineNavigation(ContextEventType contextEventType) {} // 0x0000000181024CA0-0x0000000181024F10
	// [XID] // 0x000000018975BEE0-0x000000018975BF00
	private void OnRewardClick(uint id, uint count = 0 /* Metadata: 0x00B10116 */) {} // 0x000000018103BA20-0x000000018103BB80
	// [XID] // 0x0000000189763890-0x00000001897638B0
	private void DoGoto(uint pointID) {} // 0x0000000181047840-0x0000000181047C80
	// [XID] // 0x000000018976B070-0x000000018976B090
	private void GotoDungeonEntry() {} // 0x00000001810179B0-0x0000000181017A60
	// [XID] // 0x00000001897726A0-0x00000001897726C0
	private void OnHomeworldMainhouseClick(MonoMapMark mark, MonoMapMark transPointMark = null) {} // 0x0000000181044000-0x00000001810446D0
	// [XID] // 0x0000000189779CD0-0x0000000189779CF0
	private void OnHomeworldDjinnClick(MonoMapMark mark) {} // 0x0000000181020040-0x00000001810206E0
	// [XID] // 0x0000000189781950-0x0000000189781970
	private void OnHomeworldDjinnWeekendClick(MonoMapMark mark) {} // 0x000000018104C7C0-0x000000018104CE90
	// [XID] // 0x0000000189788E90-0x0000000189788EB0
	private void OnNormalGotoMarkClick(MonoMapMark mark, MonoMapMark transPointMark = null) {} // 0x0000000181025C20-0x0000000181026330
	// [XID] // 0x0000000189790480-0x00000001897904A0
	private void OnGotoClosestTransPointMarkClick(MonoMapMark mark) {} // 0x0000000181049840-0x0000000181049C00
	// [XID] // 0x0000000189797E50-0x0000000189797E70
	private void OnBlacksmithMarkClick(MonoMapMark mark) {} // 0x0000000181045BD0-0x0000000181045D20
	// [XID] // 0x000000018979FAF0-0x000000018979FB10
	private void OnActivityArenaChallengeMarkClick(MonoMapMark mark) {} // 0x000000018102AFD0-0x000000018102BBF0
	// [XID] // 0x00000001897A70D0-0x00000001897A70F0
	private void OnElderTreeMarkClick(MonoMapMark mark) {} // 0x0000000181015880-0x00000001810159D0
	// [XID] // 0x00000001897AEA60-0x00000001897AEA80
	private void OnAdventurersMarkClick(MonoMapMark mark) {} // 0x00000001810344A0-0x00000001810347A0
	// [XID] // 0x00000001897B68F0-0x00000001897B6910
	private void OnReputationMarkClick(MonoMapMark mark) {} // 0x000000018102D510-0x000000018102D790
	// [XID] // 0x00000001897BE730-0x00000001897BE750
	private void OnHuntingAreaMarkClick(MonoMapMark mark) {} // 0x0000000181018EE0-0x0000000181019220
	// [XID] // 0x00000001897C5E40-0x00000001897C5E60
	private void OnActivityMiniTomoHiliWeiMarkClick(MonoMapMark mark) {} // 0x000000018104BCF0-0x000000018104BF20
	// [XID] // 0x00000001897CD5E0-0x00000001897CD600
	private void OnActivityExpeditionChallengeMarkClick(MonoMapMark mark) {} // 0x000000018101A2D0-0x000000018101AD60
	// [XID] // 0x00000001897D4BC0-0x00000001897D4BE0
	private void OnCommonTrackMarkClicked(MonoMapMark mark) {} // 0x0000000181017090-0x00000001810177A0
	// [XID] // 0x00000001897DC2C0-0x00000001897DC2E0
	private void OnNormalMarkClicked(MonoMapMark mark) {} // 0x000000018101B8D0-0x000000018101C140
	// [XID] // 0x00000001897E3BD0-0x00000001897E3BF0
	private void OnFleurFairTrackMarkClicked(MonoMapMark mark) {} // 0x0000000181041DB0-0x00000001810426E0
	// [XID] // 0x00000001897EB840-0x00000001897EB860
	private void OnFleurFairMarkTrack(MonoMapMark mark) {} // 0x000000018101DDF0-0x000000018101DEA0
	// [XID] // 0x00000001897F3120-0x00000001897F3140
	private void OnCommonSceneActivityMarkTrack(MonoMapMark mark) {} // 0x0000000181036C90-0x00000001810370F0
	// [XID] // 0x00000001897FA970-0x00000001897FA990
	private void OnChannellerSlabTrackMarkClicked(MonoMapMark mark) {} // 0x0000000181039660-0x000000018103A0D0
	// [XID] // 0x0000000189801F80-0x0000000189801FA0
	private void OnActivitySalesmanMarkClicked(MonoMapMark mark) {} // 0x0000000181045DA0-0x0000000181046470
	// [XID] // 0x00000001898093F0-0x0000000189809410
	private void OnActivityHideAndSeekClicked(MonoMapMark mark) {} // 0x0000000181034B70-0x00000001810357A0
	// [XID] // 0x0000000189810C00-0x0000000189810C20
	private void OnActivityWaterSpriteExploreMarkClicked(MonoMapMark mark) {} // 0x0000000181037210-0x0000000181037890
	// [XID] // 0x00000001898186B0-0x00000001898186D0
	private void OnClickActivity(MonoMapMark mark) {} // 0x0000000181044D80-0x0000000181045BD0
	// [XID] // 0x000000018981FF60-0x000000018981FF80
	private void OnInvestigationBossMarkClicked(MonoMapMark mark) {} // 0x0000000181026690-0x0000000181026B70
	// [XID] // 0x00000001898274E0-0x0000000189827500
	private void SetBlossomInfo(MonoMapMark mark, BlossomData blossomData) {} // 0x0000000181048390-0x0000000181048EF0
	// [XID] // 0x000000018982E780-0x000000018982E7A0
	private void SetMonsterInfo(MonoMapMark mark) {} // 0x000000018103C1C0-0x000000018103D0D0
	[DebuggerHidden] // 0x0000000189836100-0x0000000189836140
	// [XID] // 0x0000000189836100-0x0000000189836140
	private IEnumerator UpdateReviveCooldown(MonoMapMark mark, uint targetTimeStamp) => default; // 0x0000000181030A80-0x0000000181030B80
	// [XID] // 0x0000000189840540-0x0000000189840560
	private void TraceActivityMark(MonoMapMark mark) {} // 0x0000000181016650-0x0000000181016930
	// [XID] // 0x0000000189847AF0-0x0000000189847B10
	private void TrackInvestigationBossMark(MonoMapMark mark, bool forceSelect = false /* Metadata: 0x00B1011A */) {} // 0x0000000181014CD0-0x0000000181014FD0
	// [XID] // 0x000000018984F260-0x000000018984F280
	private void OnAsterMiddleMarkClicked(MonoMapMark mark) {} // 0x0000000181032390-0x00000001810331F0
	// [XID] // 0x00000001898563C0-0x00000001898563E0
	private void TrackAsterMiddleMark(MonoMapMark mark) {} // 0x0000000181046CA0-0x0000000181047050
	// [XID] // 0x000000018985D7B0-0x000000018985D7D0
	private void TryAddCustomMark(Vector2 levelMapPos, int initialIndex = 0 /* Metadata: 0x00B1011B */, MarkIconType type = MarkIconType.MarkCustomBoss /* Metadata: 0x00B1011F */) {} // 0x000000018103F930-0x000000018103FBD0
	// [XID] // 0x00000001898650D0-0x00000001898650F0
	private void ShowTagMaxMessage() {} // 0x0000000181047050-0x00000001810471D0
	// [XID] // 0x000000018986C630-0x000000018986C650
	private void FadeInMarkPanel(bool isClickOrAdd) {} // 0x00000001810235D0-0x0000000181023A10
	// [XID] // 0x0000000189873A80-0x0000000189873AA0
	private void ShowCustomMarkPanel() {} // 0x0000000181015BF0-0x0000000181016090
	// [IDTag] // 0x000000018987B4F0-0x000000018987B530
	// [XID] // 0x000000018987B4F0-0x000000018987B530
	private void AddCustomMark() {} // 0x0000000181041840-0x0000000181041A80
	// [XID] // 0x0000000189885A30-0x0000000189885A50
	private void RemoveCustomMark() {} // 0x000000018102A8D0-0x000000018102AA20
	// [XID] // 0x000000018988CD20-0x000000018988CD40
	private void ModifyCustomMark() {} // 0x0000000181030ED0-0x0000000181031190
	// [XID] // 0x0000000189894410-0x0000000189894430
	private void OnDeletePacketAnchorClicked(MonoMapMark mark) {} // 0x0000000181043EE0-0x0000000181044000
	// [XID] // 0x000000018989B9C0-0x000000018989B9E0
	private Vector GetPos(Vector3 worldPos) => default; // 0x0000000181044C50-0x0000000181044D80
	// [XID] // 0x00000001898A2E50-0x00000001898A2E70
	private void RefreshMapTagButton(Transform trans, int index) {} // 0x000000018102C960-0x000000018102CBD0
	// [XID] // 0x00000001898AA370-0x00000001898AA390
	private MarkIconType GetIconType(int index) => default; // 0x0000000181027C40-0x0000000181027D20
	// [XID] // 0x00000001898B1D50-0x00000001898B1D70
	private int GetIconIndex(MarkIconType type) => default; // 0x000000018101AE80-0x000000018101AF40
	// [XID] // 0x00000001898B9990-0x00000001898B99B0
	private void OnMapTagButtonClicked(int index) {} // 0x0000000181016090-0x00000001810163E0
	// [XID] // 0x00000001898C0DD0-0x00000001898C0DF0
	private void SelectMark(MonoMapMark mark) {} // 0x0000000181047640-0x0000000181047840
	// [XID] // 0x00000001898C8710-0x00000001898C8730
	private void OnCustomMarkClicked(MonoMapMark mark) {} // 0x0000000181030170-0x0000000181030930
	// [XID] // 0x00000001898D00C0-0x00000001898D00E0
	private void OnCommonMarkTrack(MonoMapMark mark) {} // 0x000000018104C310-0x000000018104C580
	// [XID] // 0x00000001898D7690-0x00000001898D76B0
	private void OnLockedTransPointTrack(MonoMapMark mark) {} // 0x00000001810216E0-0x0000000181021940
	// [XID] // 0x00000001898DF3E0-0x00000001898DF400
	private void CloseMarkTips() {} // 0x000000018101DEA0-0x000000018101E770
	// [XID] // 0x00000001898E6D60-0x00000001898E6D80
	private void OnCancelButtonClicked() {} // 0x000000018101A230-0x000000018101A2D0
	// [XID] // 0x00000001898EE4D0-0x00000001898EE4F0
	private void OnTrackButtonClicked(uint taskID) {} // 0x000000018103EE60-0x000000018103F0C0
	// [XID] // 0x00000001898F5CE0-0x00000001898F5D00
	private void OnExploreButtonClicked(uint pointID) {} // 0x000000018103A3A0-0x000000018103A520
	// [XID] // 0x00000001898FD4A0-0x00000001898FD4C0
	private MapMarkFromType GetMarkFromType(CustomMarkTrackReasonType type) => default; // 0x0000000181046470-0x0000000181046540
	// [XID] // 0x0000000189904DA0-0x0000000189904DC0
	private void ShowTipsCommon() {} // 0x0000000181028A40-0x0000000181028B40
	// [XID] // 0x000000018990C5E0-0x000000018990C600
	private uint GetConfigID(CustomMarkTrackReasonType type) => default; // 0x0000000181025750-0x0000000181025820
	// [XID] // 0x0000000189913E90-0x0000000189913EB0
	private string GetCityAreaCombineName(string cityName, string areaName) => default; // 0x00000001810471D0-0x00000001810473D0
	// [XID] // 0x000000018991B880-0x000000018991B8A0
	private void TipsScrollToTop() {} // 0x0000000181027590-0x0000000181027720
}

