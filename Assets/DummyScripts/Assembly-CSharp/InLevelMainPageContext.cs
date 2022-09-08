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
using UniRx;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class InLevelMainPageContext : BasePageContext, IIntentionSubmitter // TypeDefIndex: 29813
{
	// Fields
	private readonly float EnterCountDown; // 0x190
	private readonly string CountDownPrefab; // 0x198
	private GameObject _CountDownGo; // 0x1A0
	private MonoInLevelProgressBar _script; // 0x1A8
	private float _countDownTime; // 0x1B0
	private uint _handle; // 0x1B4
	private Image _fillImage; // 0x1B8
	private Coroutine countCoroutine; // 0x1C0
	private bool _panelActive; // 0x1C8
	private bool _countDownAcitve; // 0x1C9
	private int _versusBattleTotle; // 0x1CC
	public const string FPS_INDICATOR_PREFAB_PATH = "ART/UI/UIToolkits/FPSIndicator"; // Metadata: 0x00B1000B
	private Button _btnOpinion; // 0x1D0
	private InLevelCountDown _countDown; // 0x1D8
	private InLevelInteePanelCom _inteePanelCom; // 0x1E0
	private InLevelObjectDirectionIndicator _directionIndicator; // 0x1E8
	private InLevelTargetIndicator _targetIndicator; // 0x1F0
	private InLevelGadgetIndicator _gadgetIndicator; // 0x1F8
	private InLevelQuestTargetIndicator _navigationIndicator; // 0x200
	private InLevelGalleryPlay _galleryPlay; // 0x208
	private MonoParticleDamageTextContainer _damageParticleTextContainer; // 0x210
	private MonoInLevelMainPage _pageMono; // 0x218
	private MonoInLevelLimitRegion _monoBlackMask; // 0x220
	private NewItemGotDialogContext _newItemDialog; // 0x228
	private SpecialNewItemGotDialogContext _specialItemDialog; // 0x230
	private InLevelGalleryDialogContext _galleryDialog; // 0x238
	private AvatarEntity _localAvatar; // 0x240
	private Button _transBtn; // 0x248
	private LayoutVersion _lastLayoutVersion; // 0x250
	private bool _canChangeMoveType; // 0x254
	private bool _autoOpenedDungeonFactor; // 0x255
	private bool _forbiddenToggleMoveByState; // 0x256
	private bool _friendListReady; // 0x257
	private bool _isPaimonNormal; // 0x258
	private bool _isChatEnabled; // 0x259
	private MainPageChatBubbleDisplayer chatBubbleDisplayer; // 0x260
	private bool _mapActive; // 0x268
	private bool _transAppear; // 0x269
	private DateTime _rttRefreshTime; // 0x270
	private Color _rttGreen; // 0x280
	private Color _rttYellow; // 0x290
	private Color _rttRed; // 0x2A0
	private uint _rttLowLimit; // 0x2B0
	private uint _rttMidLimit; // 0x2B4
	private uint _rttHighLimit; // 0x2B8
	private uint _rttRefreshDeltaTime; // 0x2BC
	private Coroutine _dungeonItemCoroutine; // 0x2C0
	private bool _isOpenInputContainer; // 0x2C8
	private bool _isOpenActionContainer; // 0x2C9
	private bool _isOpenMessageContainer; // 0x2CA
	private uint _lastTimeLeft; // 0x2CC
	private uint _lastCount; // 0x2D0
	private VCCombatBillboardPlugin _activeCombat; // 0x2D8
	private GameObject _fpsIndicator; // 0x2E0
	private uint _fpsHander; // 0x2E8
	private GameObject m_LightingInfoUI; // 0x2F0
	private GameObject m_TreeOverdrawInfoUI; // 0x2F8
	private GameObject m_QuickRenderMenu; // 0x300
	private const string LIGHTING_INFO_PREFAB_PATH = "ART/UI/UIToolkits/LightingInformation"; // Metadata: 0x00B1002D
	private uint m_LightingInfoHandle; // 0x308
	private const string TREE_OVERDRAW_INFO_PREFAB_PATH = "ART/UI/UIToolkits/TreeOverdrawInformation"; // Metadata: 0x00B10056
	private uint m_TreeOverdrawInfoHandle; // 0x30C
	private const string QUICK_RENDERING_MENU = "ART/UI/UIToolkits/QuickRenderMenu"; // Metadata: 0x00B10083
	private uint m_QuickRenderHandle; // 0x310
	private bool _debugUIShow; // 0x314
	private bool _inShakeOff; // 0x315
	private DungeonChallengeConfig _challengeConfig; // 0x318
	private MonoTowerHintText _hintPage; // 0x320
	private Coroutine fleurFairDungeonStartAnimCoroutine; // 0x328
	private float _curFleurFairDungeonBarValue; // 0x330
	private bool _isInFlightChallenge; // 0x334
	private bool _isShowFlightChallengeHint; // 0x335
	private LevelModule.ChallengeData _flightSubChallengeData; // 0x338
	private bool _waitStart; // 0x360
	private Coroutine _startCoroutine; // 0x368
	private Coroutine _uidCoroutine; // 0x370
	private bool _playUidOpEnd; // 0x378
	private uint _curStage; // 0x37C
	private LCAvatarCombat _combat; // 0x380
	private Coroutine _altPressCoroutine; // 0x388
	private Coroutine _cameraLookEndCoroutine; // 0x390
	private bool _disableSkillInput; // 0x398
	private bool _disableMoveInput; // 0x399
	private bool _disableActionInput; // 0x39A
	private bool _mapInfoVisible; // 0x39B
	private bool _chatInfoVisible; // 0x39C
	private Dictionary<int, HashSet<int>> _uiDisableStateDic; // 0x3A0
	private Dictionary<int, HashSet<int>> _inputEnableStateDic; // 0x3A8
	private HashSet<int> _mainPageDisableSet; // 0x3B0
	private CameraInputHelperZoom zoomSmoother; // 0x3B8
	private InLevelVirtualDialDialogContext _virtualDialDialog; // 0x3C0
	private int _prevState; // 0x3C8
	private bool _changeWithSkill; // 0x3CC
	private static readonly uint _openMapAudio; // 0x00
	private static readonly uint _openQuestAudio; // 0x04
	private static readonly uint _openBagAudio; // 0x08
	private static readonly uint _openCharacterAudio; // 0x0C
	private static readonly uint _openPaimonAudio; // 0x10
	private MessageDialogContext _messageDialog; // 0x3D0
	public bool showHazadousWarning; // 0x3D8
	private InLevelQuestHintDialogContext _questHintDialog; // 0x3E0
	private InLevelQuestProgressDialogContext _questProgressDialog; // 0x3E8
	private QuestRewardDialogContext _rewardDialogGeneral; // 0x3F0
	private QuestRewardDialogContext _rewardDialogQuest; // 0x3F8
	private QuestRewardDialogContext _rewardDialogDailyTask; // 0x400
	private QuestRewardDialogContext _rewardDialogRandTask; // 0x408
	private QuestRewardDialogContext _rewardDialogGather; // 0x410
	private DeblockingDialogContext _deblockingDialog; // 0x418
	private InLevelTaskTitleDialogContext _taskTitleDialog; // 0x420
	private Coroutine _templateReminderCoroutine; // 0x428
	private GeneralDialogContext _reminderDialog; // 0x430
	private static readonly ExternalResourceHelper _markPointPrefab; // 0x18
	private static readonly ExternalResourceHelper _markBossPrefabRes; // 0x20
	private static readonly float heightMarkThreshold; // 0x28
	private static readonly float sqrDistanceMarkThreshold; // 0x2C
	private MonoMiniMap _miniMap; // 0x438
	private MonoMapFogAreaGrp _miniMapFog; // 0x440
	private bool _mapImgReady; // 0x448
	private uint _mapImageHandle; // 0x44C
	private uint _mapFogHandle; // 0x450
	private Dictionary<int, Dictionary<uint, MonoMapMark>> _marks; // 0x458
	private HashSet<MonoMapMark> _activeMarks; // 0x460
	private HashSet<MonoMapMark> _candidateMarks; // 0x468
	private const float SQA_REMOVE_DISTANCE = 2.25f; // Metadata: 0x00B100A8
	private Vector2 _searchRegionCenter; // 0x470
	private const float SEARCH_REGION_RADIUS = 1.5f; // Metadata: 0x00B100AC
	private const float CHANGE_DISTANCE = 0.03f; // Metadata: 0x00B100B0
	private MonoMapMark _mapMarkPrefab; // 0x478
	private GameObject _markBossPrefab; // 0x480
	private uint _sceneID; // 0x488
	private float _sqrUpdateSearchDistance; // 0x48C
	private float _sqrSearchRegionRadius; // 0x490
	private GameObject _mapImageInst; // 0x498
	private float _miniMapScale; // 0x4A0
	private float _defaultMiniMapScale; // 0x4A4
	private RectTransform _miniMapBackImg; // 0x4A8
	private MonoLevelMap _levelMap; // 0x4B0
	private RectTransform _levelMapTrans; // 0x4B8
	private Vector2 rectSize; // 0x4C0
	private Coroutine _setScaleCoroutine; // 0x4C8
	private float _currTime; // 0x4D0
	private float _tweenTime; // 0x4D4
	private float _targetScale; // 0x4D8
	private float _preScale; // 0x4DC
	private static MarkType[] markTypes; // 0x30
	private bool _forceUpdateMark; // 0x4E0
	private Vector3 _lastPlayerPos; // 0x4E4
	private float _lastCameraAngle; // 0x4F0
	private float _lastAvatarAngle; // 0x4F4
	private BaseEntity _teamEntity; // 0x4F8
	private Transform _cameraTrans; // 0x500
	private const float LIMIT_UPDATE_ANGLE = 1f; // Metadata: 0x00B100B4
	private const float LIMIT_UPDATE_DISTANCE = 1f; // Metadata: 0x00B100B8
	private float _markContainerLocalEulerAngleZ; // 0x508
	private bool updateCamera; // 0x50C
	private Vector3 newEulerAngle; // 0x510
	private HashSet<uint> _fakemarkTobeRemoved; // 0x520
	private bool _mapBackRotateDirty; // 0x528
	private bool _mapContainerDiry; // 0x529
	private string miniMapQuestMarkPath; // 0x530
	private Dictionary<uint, MonoMapMark> _fakeMarkDic; // 0x538
	private uint _fakeMarkHandle; // 0x540
	private bool _questEnable; // 0x550
	private Coroutine _spPresstartCoroutine; // 0x558
	private ulong _currentAvatarID; // 0x560
	private List<MonoTeamBtn> _buttonList; // 0x568
	private List<ulong> _avatarGuidList; // 0x570
	private bool _showChangeAvatarCDText; // 0x578
	private int _count; // 0x57C
	public List<MonoMPTeamBtn> teamBtnList; // 0x580
	private bool _hideTeamBtnName; // 0x588
	private Dictionary<int, Queue<BaseContext>> _widgetQueueDic; // 0x590
	private float DELAY_TIME; // 0x598

	// Properties
	public InLevelQuestTargetIndicator navigationIndicator { /* [XID] */ /* 0x00000001896068B0-0x00000001896068D0 */ get => default; } // 0x0000000180F51290-0x0000000180F51340 
	public StaminaType staminaType { /* [XID] */ /* 0x00000001899ABD00-0x00000001899ABD20 */ set {} } // 0x0000000180F416C0-0x0000000180F417E0
	public GameObject fpsIndicator { /* [XID] */ /* 0x0000000189A37900-0x0000000189A37920 */ get => default; } // 0x0000000180F3BDF0-0x0000000180F3BEA0 
	public GameObject lightingInformationUI { /* [XID] */ /* 0x0000000189A4DF20-0x0000000189A4DF40 */ get => default; } // 0x0000000180F3E990-0x0000000180F3EA40 
	public GameObject treeOverdrawInformationUI { /* [XID] */ /* 0x0000000189A55690-0x0000000189A556B0 */ get => default; } // 0x0000000180F52970-0x0000000180F52A20 
	public GameObject quickRenderMenu { /* [XID] */ /* 0x0000000189A5CFF0-0x0000000189A5D010 */ get => default; } // 0x0000000180F5F2B0-0x0000000180F5F360 
	public float miniMapScale { /* [XID] */ /* 0x0000000189AEDC90-0x0000000189AEDCB0 */ get => default; } // 0x0000000180F6E5C0-0x0000000180F6E670 
	public RectTransform miniMapBackImg { /* [XID] */ /* 0x0000000189AF5520-0x0000000189AF5540 */ get => default; } // 0x0000000180F3F0D0-0x0000000180F3F180 
	public float sightWorldRadiusAdjusted { /* [XID] */ /* 0x00000001896849C0-0x00000001896849E0 */ get => default; } // 0x0000000180F60FF0-0x0000000180F610F0 
	public float sightWorldRadius { /* [XID] */ /* 0x000000018968C570-0x000000018968C5B0 */ get; /* [XID] */ /* 0x00000001896972B0-0x00000001896972F0 */ set; } // 0x0000000180F38710-0x0000000180F38780 0x0000000180F63FB0-0x0000000180F64020
	public float markReachToUIRatio { /* [XID] */ /* 0x00000001896A14A0-0x00000001896A14E0 */ get; /* [XID] */ /* 0x00000001896AB700-0x00000001896AB740 */ set; } // 0x0000000180F54B50-0x0000000180F54BC0 0x0000000180F6DFE0-0x0000000180F6E050
	private float worldUnitPerPixel { get; /* [XID] */ /* 0x00000001896BCFF0-0x00000001896BD030 */ set; } // 0x0000000180F417E0-0x0000000180F41850 0x0000000180F55D00-0x0000000180F55D70
	public ulong currentAvatarID { /* [XID] */ /* 0x000000018980C250-0x000000018980C270 */ get => default; /* [XID] */ /* 0x0000000189813A00-0x0000000189813A20 */ set {} } // 0x0000000180F42110-0x0000000180F421C0 0x0000000180F45400-0x0000000180F454C0

	// Nested types
	public enum MapNotify // TypeDefIndex: 29814
	{
		OpenLevelMap = 0,
		CloseLevelMap = 1,
		UnLockArea = 2
	}

	// Constructors
	public InLevelMainPageContext() {} // 0x0000000180F70F90-0x0000000180F716B0
	static InLevelMainPageContext() {} // 0x0000000180F70DB0-0x0000000180F70F90

	// Methods
	// [XID] // 0x0000000189BBAA60-0x0000000189BBAA80
	public void StartCountDown() {} // 0x0000000180F40890-0x0000000180F40A10
	[DebuggerHidden] // 0x0000000189BC2AB0-0x0000000189BC2AF0
	// [XID] // 0x0000000189BC2AB0-0x0000000189BC2AF0
	private IEnumerator DoTeamCountDown() => default; // 0x0000000180F60F20-0x0000000180F60FF0
	// [XID] // 0x0000000189BCD060-0x0000000189BCD080
	private bool CheckCanEnter() => default; // 0x0000000180F3C670-0x0000000180F3C9D0
	// [XID] // 0x0000000189BD45E0-0x0000000189BD4600
	private void CheckTerminate() {} // 0x0000000180F3FE40-0x0000000180F3FF50
	// [XID] // 0x0000000189BDC150-0x0000000189BDC170
	private void EndCountDown() {} // 0x0000000180F5D720-0x0000000180F5D880
	// [XID] // 0x00000001895E8990-0x00000001895E89B0
	private void TerminateCountDown() {} // 0x0000000180F5B480-0x0000000180F5B6A0
	// [XID] // 0x00000001895F01E0-0x00000001895F0200
	private void StartVersusBattle(int totle, uint teammateID, int teammateScore, uint opponentID, int opponentScore) {} // 0x0000000180F53C90-0x0000000180F540E0
	// [XID] // 0x00000001895F7CB0-0x00000001895F7CD0
	private void UpdateVersusBattle(int teammateScore, int teammateAdd, int opponentScore, int opponentAdd) {} // 0x0000000180F2ADE0-0x0000000180F2B070
	// [XID] // 0x00000001895FF050-0x00000001895FF070
	private void RemoveVersusBattle() {} // 0x0000000180F3CEB0-0x0000000180F3CF90
	// [XID] // 0x000000018960E230-0x000000018960E250
	public MonoInLevelMainPage GetPageMono() => default; // 0x0000000180F4D120-0x0000000180F4D1D0
	// [XID] // 0x00000001896158C0-0x00000001896158E0
	public override void SetupView() {} // 0x0000000180F6F1A0-0x0000000180F70590
	// [XID] // 0x000000018961D0A0-0x000000018961D0C0
	protected override void BindViewCallbacks() {} // 0x0000000180F2F100-0x0000000180F2FBD0
	// [XID] // 0x00000001896245D0-0x00000001896245F0
	private void SetChatPanelStatus(bool bchatPanel, bool bchatBtn, bool bchatBubble) {} // 0x0000000180F38E80-0x0000000180F39260
	// [XID] // 0x000000018962BD10-0x000000018962BD30
	private void DoCheckMainPageChat() {} // 0x0000000180F4B260-0x0000000180F4B430
	// [XID] // 0x0000000189633830-0x0000000189633850
	private void CheckChatPage(bool isOn) {} // 0x0000000180F31030-0x0000000180F31190
	// [XID] // 0x000000018963B130-0x000000018963B150
	private void CheckMapInfo() {} // 0x0000000180F2C970-0x0000000180F2CB40
	// [XID] // 0x0000000189642860-0x0000000189642880
	private void OnChat() {} // 0x0000000180F285F0-0x0000000180F28880
	// [XID] // 0x0000000189649F30-0x0000000189649F50
	private void OnActivity() {} // 0x0000000180F51000-0x0000000180F51170
	// [XID] // 0x0000000189651610-0x0000000189651630
	private void OnActivityNormal() {} // 0x0000000180F31190-0x0000000180F31320
	// [XID] // 0x0000000189658E90-0x0000000189658EB0
	private void OnExitDungeon() {} // 0x0000000180F43970-0x0000000180F43F60
	// [XID] // 0x0000000189660560-0x0000000189660580
	private void OnToggleFactorInfo() {} // 0x0000000180F42C40-0x0000000180F42D60
	// [XID] // 0x0000000189667EA0-0x0000000189667EC0
	private void OnToggleRestrictionInfo() {} // 0x0000000180F2B600-0x0000000180F2B950
	// [XID] // 0x000000018966F910-0x000000018966F930
	private void OnToggleElementInfo() {} // 0x0000000180F63770-0x0000000180F639C0
	// [XID] // 0x0000000189677260-0x0000000189677280
	protected override void BindRedPoints() {} // 0x0000000180F2EBC0-0x0000000180F2F100
	// [XID] // 0x000000018967E810-0x000000018967E830
	private void RefreshValue(uint refreshMask) {} // 0x0000000180F49340-0x0000000180F49410
	// [XID] // 0x00000001896860C0-0x00000001896860E0
	private void RefreshBuff(uint runtimeID) {} // 0x0000000180F42420-0x0000000180F42630
	// [XID] // 0x000000018968DE90-0x000000018968DEB0
	public void RefreshTeamList() {} // 0x0000000180F571B0-0x0000000180F57320
	// [XID] // 0x00000001896957E0-0x0000000189695800
	public override void UpdateView() {} // 0x0000000180F70590-0x0000000180F70DB0
	// [XID] // 0x000000018969CE70-0x000000018969CE90
	protected override void OnEnable() {} // 0x0000000180F67040-0x0000000180F67840
	// [XID] // 0x00000001896A4180-0x00000001896A41A0
	protected override void OnDisable() {} // 0x0000000180F66CE0-0x0000000180F66F40
	// [XID] // 0x00000001896AB740-0x00000001896AB760
	public override void ClearView() {} // 0x0000000180F34530-0x0000000180F34A90
	// [XID] // 0x00000001896B2970-0x00000001896B2990
	private void InitAvatarControl() {} // 0x0000000180F559D0-0x0000000180F55B20
	// [XID] // 0x00000001896BA0C0-0x00000001896BA0E0
	protected override void PostProcessOfSetActive() {} // 0x0000000180F6E9F0-0x0000000180F6EAA0
	// [XID] // 0x00000001896C1370-0x00000001896C1390
	public override bool OnNotify(Notify ntf) => default; // 0x0000000180F67A10-0x0000000180F6BBA0
	// [XID] // 0x00000001896C8A70-0x00000001896C8A90
	protected override void RegisterHandlePacket() {} // 0x0000000180F6EAA0-0x0000000180F6EB70
	// [XID] // 0x00000001896D0460-0x00000001896D0480
	public override bool OnPacket(Packet packet) => default; // 0x0000000180F6BBA0-0x0000000180F6BD10
	// [XID] // 0x00000001896D7960-0x00000001896D7980
	private void SetMoveStatus(float roleMoveAngle, float roleMoveMold) {} // 0x0000000180F2DA90-0x0000000180F2DBB0
	// [XID] // 0x00000001896DF1C0-0x00000001896DF1E0
	private void UpdateMoveStatus() {} // 0x0000000180F4BFC0-0x0000000180F4C090
	// [XID] // 0x00000001896E65F0-0x00000001896E6610
	private void OnToggleTransBtn(bool value) {} // 0x0000000180F4A210-0x0000000180F4A5F0
	// [XID] // 0x00000001896EDB40-0x00000001896EDB60
	private void SetupPCKeyText(UnityEngine.UI.Text textToSet, InputActionType action) {} // 0x0000000180F64470-0x0000000180F64600
	// [XID] // 0x00000001896F5350-0x00000001896F5370
	private void OnToggleChar() {} // 0x0000000180F53AF0-0x0000000180F53C90
	// [XID] // 0x00000001896FCB90-0x00000001896FCBB0
	private void OnToggleBag() {} // 0x0000000180F2E830-0x0000000180F2EA20
	// [XID] // 0x0000000189704030-0x0000000189704050
	private void OnToggleHomeworld() {} // 0x0000000180F62990-0x0000000180F62BE0
	// [XID] // 0x000000018970B920-0x000000018970B940
	private void OnHomeWorldLevelUp(object newLevel) {} // 0x0000000180F39BA0-0x0000000180F39CB0
	// [XID] // 0x00000001897131F0-0x0000000189713210
	private void OnActivityNormalBtnClick() {} // 0x0000000180F49470-0x0000000180F49600
	// [XID] // 0x000000018971A9D0-0x000000018971A9F0
	private void OnPressActivitySkillButtonClick() {} // 0x0000000180F45A00-0x0000000180F45AD0
	// [XID] // 0x0000000189721D10-0x0000000189721D30
	private void OnToggleGacha() {} // 0x0000000180F4E8A0-0x0000000180F4E990
	// [XID] // 0x00000001897293A0-0x00000001897293C0
	private void OnAvatarDead(uint runtimeID) {} // 0x0000000180F40AE0-0x0000000180F40CC0
	// [XID] // 0x0000000189730BC0-0x0000000189730BE0
	private void OnAvatarChanged(AvatarEntity avatar) {} // 0x0000000180F356F0-0x0000000180F359B0
	// [XID] // 0x0000000189738510-0x0000000189738530
	private void RefreshAvatarPanel() {} // 0x0000000180F3E2B0-0x0000000180F3E500
	// [XID] // 0x0000000189740290-0x00000001897402B0
	private void ResetAvatarStand() {} // 0x0000000180F5F3C0-0x0000000180F5F530
	// [IDTag] // 0x0000000189747620-0x0000000189747660
	// [XID] // 0x0000000189747620-0x0000000189747660
	public bool ShowDamegeText(AttackResult attackResult, BaseEntity target) => default; // 0x0000000180F5F050-0x0000000180F5F140
	// [IDTag] // 0x00000001897519B0-0x00000001897519F0
	// [XID] // 0x00000001897519B0-0x00000001897519F0
	public bool ShowDamegeText(ElementType type, Vector3 position, float damage, string showText, BaseEntity target) => default; // 0x0000000180F5EEF0-0x0000000180F5F050
	// [XID] // 0x000000018975BF40-0x000000018975BF60
	public bool ShowReactionText(ElementReactionType type, ElementType elemType1, ElementType elemType2, BaseEntity target, int hitIndex) => default; // 0x0000000180F3E860-0x0000000180F3E990
	// [XID] // 0x00000001897638B0-0x00000001897638D0
	private void ShowCureText(BaseEntity target, float addHP) {} // 0x0000000180F5D3E0-0x0000000180F5D4C0
	// [XID] // 0x000000018976B090-0x000000018976B0B0
	public bool ShowDamegeComponent(bool show) => default; // 0x0000000180F5B1B0-0x0000000180F5B2A0
	// [XID] // 0x00000001897726E0-0x0000000189772700
	public void ShowScoreText(int score, Vector3 worldPos) {} // 0x0000000180F37F00-0x0000000180F38000
	// [XID] // 0x0000000189779D10-0x0000000189779D30
	private void OnNewItemEncountered(NewItemStruct newItem) {} // 0x0000000180F4D910-0x0000000180F4DA50
	// [XID] // 0x00000001897819B0-0x00000001897819D0
	private void OnSpecialNewItemEncountered(NewItemStruct newItem) {} // 0x0000000180F6BDD0-0x0000000180F6BF40
	// [XID] // 0x0000000189788EB0-0x0000000189788ED0
	private void CheckGalleryPlay() {} // 0x0000000180F2BEB0-0x0000000180F2BFD0
	// [XID] // 0x00000001897904A0-0x00000001897904C0
	private void ShowGalleryDialog() {} // 0x0000000180F5BC70-0x0000000180F5BD90
	// [XID] // 0x0000000189797E70-0x0000000189797E90
	public void ClearOnAvatarDie() {} // 0x0000000180F4CAE0-0x0000000180F4CB90
	// [XID] // 0x000000018979FB10-0x000000018979FB30
	public void ClearOnTransport() {} // 0x0000000180F29030-0x0000000180F290F0
	// [XID] // 0x00000001897A70F0-0x00000001897A7110
	private void ClearDialog(string contextName) {} // 0x0000000180F49EF0-0x0000000180F4A0A0
	// [XID] // 0x00000001897AEA80-0x00000001897AEAA0
	private void ClearAllDialog() {} // 0x0000000180F3FCF0-0x0000000180F3FE40
	// [XID] // 0x00000001897B6910-0x00000001897B6930
	private void ClearOnDisconnect() {} // 0x0000000180F63D70-0x0000000180F63E40
	// [XID] // 0x00000001897BE750-0x00000001897BE770
	internal void OpenQuestBook() {} // 0x0000000180F6C910-0x0000000180F6CA50
	// [XID] // 0x00000001897C5E60-0x00000001897C5E80
	private void ToggleQuestBook() {} // 0x0000000180F52E50-0x0000000180F52F80
	// [XID] // 0x00000001897CD600-0x00000001897CD620
	public void ShowInLevelTalk(string talkerName, string content) {} // 0x0000000180F27E80-0x0000000180F27F70
	// [XID] // 0x00000001897D4BE0-0x00000001897D4C00
	public void CloseInLevelTalk() {} // 0x0000000180F4C090-0x0000000180F4C150
	// [XID] // 0x00000001897DC2E0-0x00000001897DC300
	public void ShowInLevelWarningTalk(string talkerName, string content) {} // 0x0000000180F302A0-0x0000000180F30390
	// [XID] // 0x00000001897E3BF0-0x00000001897E3C10
	public void CloseInLevelWarningTalk() {} // 0x0000000180F3BA00-0x0000000180F3BAC0
	// [XID] // 0x00000001897EB860-0x00000001897EB880
	public void ShowInLevelBubbleTalk(string talkerName, string content) {} // 0x0000000180F66C00-0x0000000180F66CE0
	// [XID] // 0x00000001897F3140-0x00000001897F3160
	public void CloseInLevelBubbleTalk() {} // 0x0000000180F41A60-0x0000000180F41B10
	// [XID] // 0x00000001897FA9D0-0x00000001897FA9F0
	public void OnActivitySkillState(ExtraAbilityState state) {} // 0x0000000180F57400-0x0000000180F574E0
	// [XID] // 0x0000000189801FA0-0x0000000189801FC0
	public void OnShowActivitySkill() {} // 0x0000000180F42FF0-0x0000000180F430F0
	// [XID] // 0x0000000189809410-0x0000000189809430
	public void OnWidgetBtnRefresh() {} // 0x0000000180F317B0-0x0000000180F318B0
	// [XID] // 0x0000000189810C20-0x0000000189810C40
	public void ChangeSkill(AvatarEntity target, int skillIndex) {} // 0x0000000180F6BF40-0x0000000180F6C0C0
	// [XID] // 0x00000001898186D0-0x00000001898186F0
	public void OnAvatarSkillDisable(bool disable) {} // 0x0000000180F42270-0x0000000180F42350
	// [XID] // 0x000000018981FF80-0x000000018981FFA0
	private void OnAvatarEnergyAdded(uint avatarID) {} // 0x0000000180F5FC90-0x0000000180F5FD80
	// [XID] // 0x0000000189827500-0x0000000189827520
	private void OnAvatarSkillCDChanged(uint avatarID, uint skillID, bool isAdd) {} // 0x0000000180F4D000-0x0000000180F4D120
	// [XID] // 0x000000018982E7A0-0x000000018982E7C0
	private void OnAvatarEnergyFullNotify(uint avatarID, bool full) {} // 0x0000000180F54E90-0x0000000180F54FB0
	// [XID] // 0x0000000189836140-0x0000000189836160
	private void OnFireUIEffectNotify(FireUIEffect fireUIEffectConfig) {} // 0x0000000180F5F5F0-0x0000000180F5F6D0
	// [XID] // 0x000000018983D5F0-0x000000018983D610
	private void RefreshSkill() {} // 0x0000000180F44120-0x0000000180F44280
	// [XID] // 0x0000000189844E10-0x0000000189844E30
	private void ShowPlayerProfilePage() {} // 0x0000000180F59320-0x0000000180F594A0
	// [XID] // 0x000000018984C280-0x000000018984C2A0
	private void OnFeedBack() {} // 0x0000000180F3F180-0x0000000180F3F350
	// [XID] // 0x0000000189853410-0x0000000189853430
	private void OpenLevelMap() {} // 0x0000000180F2E010-0x0000000180F2E240
	// [XID] // 0x000000018985AE80-0x000000018985AEA0
	public void BlackScreen(float value) {} // 0x0000000180F31320-0x0000000180F31460
	// [XID] // 0x00000001898765D0-0x00000001898765F0
	public float GetBlackScreenSpeed() => default; // 0x0000000180F3B590-0x0000000180F3B6A0
	// [XID] // 0x00000001898697D0-0x00000001898697F0
	public void SetBlackScreenSpeed(float speed) {} // 0x0000000180F2BFD0-0x0000000180F2C0D0
	// [XID] // 0x00000001898709F0-0x0000000189870A10
	private void OnMarkEntityInMiniMapNotify(MarkEntityInMinMapNotify ntf) {} // 0x0000000180F40A10-0x0000000180F40AE0
	// [XID] // 0x00000001898784A0-0x00000001898784C0
	private void OnDungeonFollowNotify(DungeonFollowNotify ntf) {} // 0x0000000180F363A0-0x0000000180F36530
	// [XID] // 0x000000018987F990-0x000000018987F9B0
	private void OnPaimenNavigationEnabled() {} // 0x0000000180F4EBF0-0x0000000180F4EDD0
	// [XID] // 0x0000000189886FE0-0x0000000189887000
	private void OnPaimenNavigationFailed() {} // 0x0000000180F5F530-0x0000000180F5F5F0
	// [XID] // 0x000000018988E190-0x000000018988E1B0
	private void OnPaimenNavigationAlreadyInArea() {} // 0x0000000180F44A30-0x0000000180F44AF0
	// [XID] // 0x0000000189895800-0x0000000189895820
	private void TryShowCurrentGuideTips(bool isRefresh) {} // 0x0000000180F5FD80-0x0000000180F603C0
	// [XID] // 0x000000018989CF60-0x000000018989CF80
	private void DoPaimenNavigationShow() {} // 0x0000000180F3DAC0-0x0000000180F3DCA0
	// [XID] // 0x00000001898A47A0-0x00000001898A47C0
	private void OnElementViewChange(bool on) {} // 0x0000000180F2C680-0x0000000180F2C800
	// [XID] // 0x00000001898ABC20-0x00000001898ABC40
	private void OnGuideButtonClick() {} // 0x0000000180F53910-0x0000000180F539B0
	// [XID] // 0x00000001898B3390-0x00000001898B33B0
	private void OnTransButtonClick() {} // 0x0000000180F4FE30-0x0000000180F4FF80
	// [XID] // 0x00000001898BB070-0x00000001898BB090
	private void OnLevelUpItemCompleted(UIUtil.LevelUpItemQueue itemQueue) {} // 0x0000000180F455C0-0x0000000180F45680
	// [XID] // 0x00000001898C2400-0x00000001898C2420
	private void CheckActivity() {} // 0x0000000180F5C410-0x0000000180F5C650
	// [XID] // 0x00000001898C9E00-0x00000001898C9E20
	private void CheckUIOpenState() {} // 0x0000000180F6D2C0-0x0000000180F6D750
	// [XID] // 0x00000001898D1460-0x00000001898D1480
	private void CheckNormalActivity() {} // 0x0000000180F381B0-0x0000000180F38360
	// [XID] // 0x00000001898D8D20-0x00000001898D8D40
	private void OnOpenStateChangeNotify(OpenStateType type, bool active) {} // 0x0000000180F38780-0x0000000180F38D30
	// [XID] // 0x00000001898E09D0-0x00000001898E09F0
	private void RttColorSetup() {} // 0x0000000180F6C300-0x0000000180F6C600
	// [XID] // 0x00000001898E8510-0x00000001898E8530
	private void RefreshRTT() {} // 0x0000000180F6E150-0x0000000180F6E350
	// [XID] // 0x00000001898EFCF0-0x00000001898EFD10
	private void SetRtt(MonoInLevelRTT monoRtt, uint rtt) {} // 0x0000000180F29560-0x0000000180F298A0
	// [XID] // 0x00000001898F7530-0x00000001898F7550
	private void OnMoveRunBtnClick() {} // 0x0000000180F34EA0-0x0000000180F34FE0
	// [XID] // 0x00000001898FEC40-0x00000001898FEC60
	private void OnMoveWalkBtnClick() {} // 0x0000000180F3B6A0-0x0000000180F3B7E0
	// [XID] // 0x0000000189906400-0x0000000189906420
	private void ShowMoveToggle(bool runOrWalk) {} // 0x0000000180F460A0-0x0000000180F46210
	// [XID] // 0x000000018990DE80-0x000000018990DEA0
	private void SetMoveToggleEnable(bool enable) {} // 0x0000000180F4E990-0x0000000180F4EB50
	// [XID] // 0x00000001899155D0-0x00000001899155F0
	private void TryShowMoveToggle(bool show) {} // 0x0000000180F5B2A0-0x0000000180F5B480
	// [XID] // 0x000000018991D020-0x000000018991D040
	private bool isCurWalkRun() => default; // 0x0000000180F4F760-0x0000000180F4F8D0
	// [XID] // 0x00000001899248F0-0x0000000189924910
	private void RefreshMoveButtonState() {} // 0x0000000180F28980-0x0000000180F28BC0
	// [XID] // 0x000000018992BE60-0x000000018992BE80
	private void EnterSneakState(float sensingRange) {} // 0x0000000180F5D070-0x0000000180F5D1C0
	// [XID] // 0x0000000189933390-0x00000001899333B0
	private void ExitSneakState() {} // 0x0000000180F61F20-0x0000000180F61FE0
	// [XID] // 0x000000018993AF20-0x000000018993AF40
	private void OnNewMailGotNotify() {} // 0x0000000180F52860-0x0000000180F52970
	// [XID] // 0x0000000189941FF0-0x0000000189942010
	private void SetPlayerListToggleActive(bool available) {} // 0x0000000180F66090-0x0000000180F662A0
	// [XID] // 0x0000000189949A90-0x0000000189949AB0
	private void OnHandbookBtnClick() {} // 0x0000000180F51E80-0x0000000180F51F90
	// [XID] // 0x0000000189951500-0x0000000189951520
	private void OnHomeworldHandbookBtnClick() {} // 0x0000000180F49890-0x0000000180F499A0
	// [XID] // 0x0000000189958AF0-0x0000000189958B10
	private void CheckDungeonItemShow() {} // 0x0000000180F4C560-0x0000000180F4C870
	// [XID] // 0x0000000189960130-0x0000000189960150
	private void RefreshDungeonItem(Transform trans, int index) {} // 0x0000000180F434A0-0x0000000180F435C0
	// [XID] // 0x0000000189967BB0-0x0000000189967BD0
	private void OnBattlePassBtnClick() {} // 0x0000000180F65EB0-0x0000000180F66090
	// [XID] // 0x000000018996ED90-0x000000018996EDB0
	private void OnBattlePassScheduleChangeNotify() {} // 0x0000000180F4FA70-0x0000000180F4FC30
	// [XID] // 0x00000001899769D0-0x00000001899769F0
	private void OnBattlePassMissionChangeNotify() {} // 0x0000000180F66420-0x0000000180F66540
	// [XID] // 0x000000018997DDD0-0x000000018997DDF0
	private void OutSideToggleChat() {} // 0x0000000180F37440-0x0000000180F37630
	// [XID] // 0x0000000189985780-0x00000001899857A0
	public void ClearChatTips() {} // 0x0000000180F28120-0x0000000180F28240
	// [XID] // 0x000000018998D510-0x000000018998D530
	private void CtrlMainPagePartBtnClose() {} // 0x0000000180F378B0-0x0000000180F37CE0
	// [XID] // 0x0000000189994F90-0x0000000189994FB0
	private void CtrlMainPagePartBtnOpen() {} // 0x0000000180F2A910-0x0000000180F2AA90
	// [XID] // 0x000000018999C890-0x000000018999C8B0
	public override void ClearInputState() {} // 0x0000000180F342D0-0x0000000180F34530
	// [XID] // 0x00000001899A4340-0x00000001899A4360
	public override void OnDisconnect() {} // 0x0000000180F66F40-0x0000000180F67040
	// [XID] // 0x00000001899B3630-0x00000001899B3650
	private void OnChargeBarValueChange(ChargeBarInfo info) {} // 0x0000000180F46BA0-0x0000000180F46D90
	// [XID] // 0x00000001899BA9B0-0x00000001899BA9D0
	private void RefreshTalentPRShow() {} // 0x0000000180F2C230-0x0000000180F2C4A0
	[DebuggerHidden] // 0x00000001899C22D0-0x00000001899C2310
	// [XID] // 0x00000001899C22D0-0x00000001899C2310
	private IEnumerator OnCommonChallengeStartTips(string title, string subTitle) => default; // 0x0000000180F3BAC0-0x0000000180F3BBC0
	[DebuggerHidden] // 0x00000001899CCA70-0x00000001899CCAB0
	// [XID] // 0x00000001899CCA70-0x00000001899CCAB0
	private IEnumerator OnCommonChallengeEndTips(bool isWin) => default; // 0x0000000180F36910-0x0000000180F36A00
	// [XID] // 0x00000001899D6E70-0x00000001899D6E90
	private void InitCommonProgressBar() {} // 0x0000000180F63560-0x0000000180F63600
	// [XID] // 0x00000001899DE440-0x00000001899DE460
	private void OnSealProgressChange(ref Notify ntf) {} // 0x0000000180F32700-0x0000000180F33190
	// [XID] // 0x00000001899E60E0-0x00000001899E6100
	private void RegisterCombatBar(VCCombatBillboardPlugin combat) {} // 0x0000000180F361E0-0x0000000180F363A0
	// [XID] // 0x00000001899ED4D0-0x00000001899ED4F0
	private void UnregisterCombatBar(VCCombatBillboardPlugin combat) {} // 0x0000000180F4B080-0x0000000180F4B260
	// [XID] // 0x00000001899F5040-0x00000001899F5060
	private void UpdateCombatBars() {} // 0x0000000180F2EA20-0x0000000180F2EBC0
	// [XID] // 0x00000001899FC5F0-0x00000001899FC610
	public void OnClimateTypeChanged(JsonClimateType climateType) {} // 0x0000000180F55E70-0x0000000180F55F20
	// [XID] // 0x0000000189A03BC0-0x0000000189A03BE0
	public void OnClimateAreaChanged(JsonClimateType climateType) {} // 0x0000000180F5E0B0-0x0000000180F5E2C0
	// [XID] // 0x0000000189A0B0D0-0x0000000189A0B0F0
	private void OnClimateInfoButtonClicked() {} // 0x0000000180F5BD90-0x0000000180F5BF40
	// [XID] // 0x0000000189A12A40-0x0000000189A12A60
	protected void OnClimateValueChange(float value) {} // 0x0000000180F52BB0-0x0000000180F52CE0
	// [XID] // 0x0000000189A19C30-0x0000000189A19C50
	protected void OnClimateWarningChanged(int warningState) {} // 0x0000000180F41110-0x0000000180F41240
	// [XID] // 0x0000000189A212C0-0x0000000189A212E0
	protected void MarkClimateMeterChangeInstant() {} // 0x0000000180F37CE0-0x0000000180F37E00
	// [XID] // 0x0000000189A28890-0x0000000189A288B0
	public void SwitchActionPannelTypeBySetting(ActionPanelType type) {} // 0x0000000180F51C40-0x0000000180F51CF0
	// [XID] // 0x0000000189A2FEB0-0x0000000189A2FED0
	private void RefreshActionPanelType(ActionPanelType type) {} // 0x0000000180F2C0D0-0x0000000180F2C230
	// [XID] // 0x0000000189A3F030-0x0000000189A3F050
	private void InstantiateFpsIndicatorIfNecessary() {} // 0x0000000180F5F140-0x0000000180F5F2B0
	// [XID] // 0x0000000189A46710-0x0000000189A46730
	private void OnLoadedFpsIndicator(ulong requestedPath, bool loadSucceeded, uint handle, GameObject prefab) {} // 0x0000000180F61BF0-0x0000000180F61DD0
	// [XID] // 0x0000000189A64890-0x0000000189A648B0
	private void InstantiateLightingUIIfNecessary() {} // 0x0000000180F57040-0x0000000180F571B0
	// [XID] // 0x0000000189A6C0B0-0x0000000189A6C0D0
	private void InstantiateTreeOverdrawUIIfNecessary() {} // 0x0000000180F63600-0x0000000180F63770
	// [XID] // 0x0000000189A73820-0x0000000189A73840
	private void InstantiateQuickRenderMenuIfNecessary() {} // 0x0000000180F35B70-0x0000000180F35CE0
	// [XID] // 0x0000000189A7B320-0x0000000189A7B340
	private void OnLightingUILoaded(ulong requestedPath, bool loadSucceeded, uint handle, GameObject prefab) {} // 0x0000000180F432C0-0x0000000180F434A0
	// [XID] // 0x0000000189A82A20-0x0000000189A82A40
	private void OnTreeOverdrawUILoaded(ulong requestedPath, bool loadSucceeded, uint handle, GameObject prefab) {} // 0x0000000180F29380-0x0000000180F29560
	// [XID] // 0x0000000189A8A430-0x0000000189A8A450
	private void OnQuickRenderMenuLoaded(ulong requestedPath, bool loadSucceeded, uint handle, GameObject prefab) {} // 0x0000000180F50E20-0x0000000180F51000
	// [XID] // 0x0000000189A91BF0-0x0000000189A91C10
	public MonoInLevelMainPage GetMonoMainPage() => default; // 0x0000000180F5C360-0x0000000180F5C410
	// [XID] // 0x0000000189A99700-0x0000000189A99720
	public void RefreshActionPanelSet() {} // 0x0000000180F4A7D0-0x0000000180F4A8C0
	// [XID] // 0x0000000189AA0750-0x0000000189AA0770
	public void ToggleDebugUI() {} // 0x0000000180F4E510-0x0000000180F4E6F0
	// [XID] // 0x0000000189AA7D50-0x0000000189AA7D70
	private void OnToggleDebugMenuDialog() {} // 0x0000000180F6E350-0x0000000180F6E510
	// [XID] // 0x0000000189AAF800-0x0000000189AAF820
	public void GMOnToggleDebugMenuDialog() {} // 0x0000000180F50A00-0x0000000180F50AA0
	// [XID] // 0x0000000189AB70A0-0x0000000189AB70C0
	private void OnOpinion() {} // 0x0000000180F2AC90-0x0000000180F2ADE0
	// [XID] // 0x0000000189ABEAC0-0x0000000189ABEAE0
	private void OnToggleElemViewButton(bool isOn) {} // 0x0000000180F62460-0x0000000180F625A0
	// [XID] // 0x0000000189AC66B0-0x0000000189AC66D0
	private void OnTestShakeOff() {} // 0x0000000180F6E050-0x0000000180F6E150
	// [XID] // 0x0000000189ACDCC0-0x0000000189ACDCE0
	public void ShowShakeOff(bool visiable) {} // 0x0000000180F53500-0x0000000180F53910
	// [XID] // 0x0000000189AD5AE0-0x0000000189AD5B00
	private void InitNavigationIndicator() {} // 0x0000000180F3DCA0-0x0000000180F3DE50
	[DebuggerHidden] // 0x0000000189ADD450-0x0000000189ADD490
	// [XID] // 0x0000000189ADD450-0x0000000189ADD490
	private IEnumerator CheckShowMonthlyCardPage() => default; // 0x0000000180F5DE30-0x0000000180F5DEF0
	// [XID] // 0x0000000189AE7B10-0x0000000189AE7B30
	private void DoPS5LaunchActivity() {} // 0x0000000180F4F340-0x0000000180F4F3E0
	// [XID] // 0x0000000189AEF850-0x0000000189AEF870
	private void OnForbiddenToggleMoveStateChange(bool forbidden) {} // 0x0000000180F41420-0x0000000180F414E0
	// [XID] // 0x0000000189AF6D90-0x0000000189AF6DB0
	private void OnToggleMoveSettingChange(bool enable) {} // 0x0000000180F34A90-0x0000000180F34B40
	// [XID] // 0x0000000189AFE2C0-0x0000000189AFE2E0
	private void RefreshToggleMoveBtn() {} // 0x0000000180F56840-0x0000000180F56940
	// [XID] // 0x0000000189B05AB0-0x0000000189B05AD0
	private void TryResetJoystickPhysicalRadius() {} // 0x0000000180F56180-0x0000000180F56260
	// [XID] // 0x0000000189B0D200-0x0000000189B0D220
	private void RefreshAllKeycodeIcons() {} // 0x0000000180F6D880-0x0000000180F6D980
	// [XID] // 0x0000000189B147E0-0x0000000189B14800
	private void OnMechanicusInfoBtnClick() {} // 0x0000000180F28880-0x0000000180F28980
	// [XID] // 0x0000000189B1C070-0x0000000189B1C090
	private void CheckDraftTwiceConfirm() {} // 0x0000000180F35220-0x0000000180F35300
	// [XID] // 0x0000000189B23750-0x0000000189B23770
	private void InitDungeonProgressBar(DungeonExcelConfig dungeonConfig) {} // 0x0000000180F29B50-0x0000000180F29DB0
	// [XID] // 0x0000000189B2A9F0-0x0000000189B2AA10
	private void OnDungeonDataNotify(DungeonDataNotify ntf) {} // 0x0000000180F540E0-0x0000000180F54370
	// [XID] // 0x0000000189B31F20-0x0000000189B31F40
	private void InitDungeonCountDown() {} // 0x0000000180F3F3E0-0x0000000180F3F590
	// [XID] // 0x0000000189B396E0-0x0000000189B39700
	private void CheckFirstPassTrialDungeon(DungeonSettleNotify ntf) {} // 0x0000000180F2FED0-0x0000000180F302A0
	// [XID] // 0x0000000189B41050-0x0000000189B41070
	private void OnDungeonCountDownEndNotify() {} // 0x0000000180F4F480-0x0000000180F4F530
	// [XID] // 0x0000000189B48980-0x0000000189B489A0
	private void OnDungeonSettleNotify(DungeonSettleNotify ntf) {} // 0x0000000180F335A0-0x0000000180F33BE0
	// [XID] // 0x0000000189B500F0-0x0000000189B50110
	private void OnEffigyChallengeResultNotify(EffigyChallengeResultNotify ntf) {} // 0x0000000180F4FF80-0x0000000180F50100
	// [XID] // 0x0000000189B57960-0x0000000189B57980
	private void OnDungeonGetReward(GadgetAutoPickDropInfoNotify ntf) {} // 0x0000000180F6D1A0-0x0000000180F6D2C0
	// [XID] // 0x0000000189B5F2B0-0x0000000189B5F2D0
	private void OnDungeonChallengeBegin() {} // 0x0000000180F6CEF0-0x0000000180F6D1A0
	// [XID] // 0x0000000189B668A0-0x0000000189B668C0
	private void OnDungeonChallengeAddSub(LevelModule.ChallengeData subChallengeData) {} // 0x0000000180F3D040-0x0000000180F3D1E0
	// [XID] // 0x0000000189B6DDC0-0x0000000189B6DDE0
	private void OnDungeonChallengeUpdate(uint challengeIndex) {} // 0x0000000180F5E9D0-0x0000000180F5EC90
	// [XID] // 0x0000000189B754B0-0x0000000189B754D0
	private void OnDungeonChallengeFinish(bool success, DungeonChallengeFinishNotify ntf = null) {} // 0x0000000180F318B0-0x0000000180F31E00
	// [XID] // 0x0000000189B7C900-0x0000000189B7C920
	private void OnDungeonSubChallengeFinish(bool success, DungeonChallengeFinishNotify ntf) {} // 0x0000000180F5EC90-0x0000000180F5EEF0
	// [XID] // 0x0000000189B847A0-0x0000000189B847C0
	private void OnBlossomBegin() {} // 0x0000000180F5E5B0-0x0000000180F5E880
	// [XID] // 0x0000000189B8B5F0-0x0000000189B8B610
	private void OnBlossonUpdate() {} // 0x0000000180F5B6A0-0x0000000180F5B8A0
	// [XID] // 0x0000000189B92D20-0x0000000189B92D40
	private void OnBlossomFinish() {} // 0x0000000180F4A5F0-0x0000000180F4A7D0
	// [XID] // 0x0000000189B9A300-0x0000000189B9A320
	private void OnBlossomEnd() {} // 0x0000000180F4D230-0x0000000180F4D2E0
	// [XID] // 0x0000000189BA1A10-0x0000000189BA1A30
	private void OnInBattleMechanicusBegin() {} // 0x0000000180F42E00-0x0000000180F42FF0
	// [XID] // 0x0000000189BA8E10-0x0000000189BA8E30
	private void OnInBattleMechanicusUpdate(MechanicusModule.MechanicusRefreshType type) {} // 0x0000000180F36C40-0x0000000180F36DF0
	// [XID] // 0x0000000189BB0600-0x0000000189BB0620
	private void OnInBattleMechanicusFinish() {} // 0x0000000180F421C0-0x0000000180F42270
	// [XID] // 0x0000000189BB7980-0x0000000189BB79A0
	private void CheckInBattleMechanicus() {} // 0x0000000180F50AA0-0x0000000180F50DA0
	// [XID] // 0x0000000189BBEFE0-0x0000000189BBF000
	private void CheckMechanicusSettle() {} // 0x0000000180F56750-0x0000000180F56840
	// [XID] // 0x0000000189BC6CB0-0x0000000189BC6CD0
	private void ShowMechanicusStageKillBeginBanner(string title, string subTitle) {} // 0x0000000180F6D980-0x0000000180F6DBE0
	// [XID] // 0x0000000189BCE960-0x0000000189BCE980
	private void ShowMechanicusStageKillEndBanner(string title) {} // 0x0000000180F58CE0-0x0000000180F58EC0
	// [XID] // 0x0000000189BD5C20-0x0000000189BD5C40
	private bool OnNotifyActivityRegionSearch(Notify ntf) => default; // 0x0000000180F51A60-0x0000000180F51C40
	// [XID] // 0x0000000189BDD8D0-0x0000000189BDD8F0
	private void OnActivitySearchRegionEnter(ActivityRegion targetActivityRegion) {} // 0x0000000180F399E0-0x0000000180F39BA0
	// [XID] // 0x00000001895EA490-0x00000001895EA4B0
	private void OnActivitySearchRegionUpdate(ActivityRegion targetActivityRegion) {} // 0x0000000180F30710-0x0000000180F30860
	// [XID] // 0x00000001895F18B0-0x00000001895F18D0
	private void OnActivitySearchRegionQuit() {} // 0x0000000180F3EDE0-0x0000000180F3EE90
	// [XID] // 0x00000001895F9310-0x00000001895F9330
	private void CheckInRegionSearch() {} // 0x0000000180F44FF0-0x0000000180F451B0
	// [XID] // 0x0000000189600940-0x0000000189600960
	private void ShowActivityRegionSearchBeginBanner(ActivityRegion targetActivityRegion) {} // 0x0000000180F37630-0x0000000180F378B0
	// [XID] // 0x0000000189608260-0x0000000189608280
	private void ShowActivityRegionSearchFinishBanner(ActivityRegion targetActivityRegion) {} // 0x0000000180F3B7E0-0x0000000180F3BA00
	// [XID] // 0x000000018960FC00-0x000000018960FC20
	private void OnExpeditionChallengeStart(bool isPuzzleFinished) {} // 0x0000000180F57E20-0x0000000180F57F40
	// [XID] // 0x0000000189616EA0-0x0000000189616EC0
	private void OnExpeditionChallengeFinish(bool success) {} // 0x0000000180F51170-0x0000000180F51290
	// [XID] // 0x000000018961EA20-0x000000018961EA40
	private void TickDungeonView() {} // 0x0000000180F3C9D0-0x0000000180F3CEB0
	// [XID] // 0x0000000189625E40-0x0000000189625E60
	private void OnDungeonPlayerDieNotify(DungeonPlayerDieNotify ntf) {} // 0x0000000180F64B30-0x0000000180F65030
	// [XID] // 0x000000018962D780-0x000000018962D7A0
	private void OnWorldPlayerDieNotify(WorldPlayerDieNotify ntf) {} // 0x0000000180F32020-0x0000000180F32380
	// [XID] // 0x0000000189635300-0x0000000189635320
	private void OnTowerEnter() {} // 0x0000000180F62ED0-0x0000000180F63100
	// [XID] // 0x000000018963C9A0-0x000000018963C9C0
	public void TryRefreshTowerTitle() {} // 0x0000000180F3C4D0-0x0000000180F3C610
	// [XID] // 0x0000000189644060-0x0000000189644080
	public void RefreshTowerTitle(bool justEnter = true /* Metadata: 0x00B0FFD2 */) {} // 0x0000000180F41E20-0x0000000180F42110
	// [XID] // 0x000000018964B810-0x000000018964B830
	private void OnTowerInfoCreated(MonoTowerHintText hintPage) {} // 0x0000000180F28BC0-0x0000000180F28E20
	// [XID] // 0x0000000189652FA0-0x0000000189652FC0
	private void SetCondState(int index, bool active) {} // 0x0000000180F4F8D0-0x0000000180F4FA70
	// [XID] // 0x000000018965A680-0x000000018965A6A0
	private void RefreshTowerStar() {} // 0x0000000180F51760-0x0000000180F51A60
	// [XID] // 0x0000000189661CB0-0x0000000189661CD0
	private void OnTowerExit() {} // 0x0000000180F38360-0x0000000180F38560
	// [XID] // 0x0000000189669890-0x00000001896698B0
	private void ShowDungeonEntryExploredCondition(GetDungeonEntryExploreConditionRsp rsp) {} // 0x0000000180F57AF0-0x0000000180F57CA0
	// [XID] // 0x00000001896713C0-0x00000001896713E0
	private void CheckMultistagePlay() {} // 0x0000000180F4E430-0x0000000180F4E510
	// [XID] // 0x0000000189678C60-0x0000000189678C80
	private void ClearFleurFairDungeonForNext() {} // 0x0000000180F65030-0x0000000180F65260
	// [XID] // 0x0000000189680370-0x0000000189680390
	private void OnFleurFairDungeonPreview() {} // 0x0000000180F4EDD0-0x0000000180F4F340
	// [XID] // 0x0000000189687E70-0x0000000189687E90
	private void OnFleurFairDungeonPrepare(bool isBoss) {} // 0x0000000180F48B10-0x0000000180F48EE0
	// [XID] // 0x000000018968F8D0-0x000000018968F8F0
	private void OnFleurFairDungeonGallery(bool recover) {} // 0x0000000180F5E4D0-0x0000000180F5E5B0
	// [XID] // 0x00000001896972F0-0x0000000189697310
	private void OnFleurFairDungeonBoss() {} // 0x0000000180F38000-0x0000000180F381B0
	// [XID] // 0x000000018969E840-0x000000018969E860
	private void OnFleurFairDungeonEnergy() {} // 0x0000000180F42D60-0x0000000180F42E00
	// [XID] // 0x00000001896A5830-0x00000001896A5850
	private void OnFleurFairDungeonGalleryUpdate() {} // 0x0000000180F2A280-0x0000000180F2A320
	// [XID] // 0x00000001896AD050-0x00000001896AD070
	private void OnFleurFairDungeonGallerySettle() {} // 0x0000000180F33480-0x0000000180F335A0
	// [XID] // 0x00000001896B46C0-0x00000001896B46E0
	private void OnFleurFairDungeonBossSettle() {} // 0x0000000180F4A0A0-0x0000000180F4A210
	// [XID] // 0x00000001896BB930-0x00000001896BB950
	private void InitFleurFairDungeonPrepareTime(uint endTime, bool useLevelTime) {} // 0x0000000180F5D880-0x0000000180F5D960
	// [XID] // 0x00000001896C2DF0-0x00000001896C2E10
	private void ShowFleurFairDungeonGalleryBegin() {} // 0x0000000180F29E80-0x0000000180F2A280
	// [XID] // 0x00000001896CA2A0-0x00000001896CA2C0
	private void ShowFleurFairDungeonBossBegin() {} // 0x0000000180F40CC0-0x0000000180F40ED0
	[DebuggerHidden] // 0x00000001896D1930-0x00000001896D1970
	// [XID] // 0x00000001896D1930-0x00000001896D1970
	private IEnumerator PlayFleurFairDungeonStartAnim(bool isBoss) => default; // 0x0000000180F451B0-0x0000000180F452A0
	// [IDTag] // 0x00000001896DBFD0-0x00000001896DC010
	// [XID] // 0x00000001896DBFD0-0x00000001896DC010
	private void UpdateFleurFairDungeonBar(bool init) {} // 0x0000000180F466A0-0x0000000180F46A70
	// [XID] // 0x00000001896E65D0-0x00000001896E65F0
	private void InitFleurFairDungeonMainUI(bool isBoss) {} // 0x0000000180F2BBC0-0x0000000180F2BE30
	// [XID] // 0x00000001896EDB20-0x00000001896EDB40
	private void UpdateFleurFairDungeonProgress() {} // 0x0000000180F5D590-0x0000000180F5D720
	// [XID] // 0x00000001896F5330-0x00000001896F5350
	private void InitFleurFairDungeonBar(SimpleSafeUInt32[] values, uint limit, uint stage) {} // 0x0000000180F61FE0-0x0000000180F623C0
	// [IDTag] // 0x00000001896FCB50-0x00000001896FCB90
	// [XID] // 0x00000001896FCB50-0x00000001896FCB90
	private void UpdateFleurFairDungeonBar(float value, float max, uint stage) {} // 0x0000000180F46210-0x0000000180F466A0
	// [XID] // 0x0000000189707070-0x0000000189707090
	private void InitFleurFairDungeonCountDown(ulong beginTime, ulong endTime) {} // 0x0000000180F3F590-0x0000000180F3F7A0
	// [XID] // 0x000000018970E930-0x000000018970E950
	private void TickFleurFairDungeonView() {} // 0x0000000180F34FE0-0x0000000180F35220
	// [XID] // 0x0000000189715D90-0x0000000189715DB0
	private void OnFlightChallengeBegin() {} // 0x0000000180F5D4C0-0x0000000180F5D590
	// [XID] // 0x000000018971D7D0-0x000000018971D7F0
	private void OnFlightChallengeFinish() {} // 0x0000000180F4CE60-0x0000000180F4D000
	// [XID] // 0x0000000189724B90-0x0000000189724BB0
	public void SetFlightChallengeBarValue(float value) {} // 0x0000000180F27F70-0x0000000180F28050
	// [XID] // 0x000000018972C3C0-0x000000018972C3E0
	private void OnDungeonChallengeAddSubCheck(LevelModule.ChallengeData subChallengeData) {} // 0x0000000180F5E2C0-0x0000000180F5E4D0
	// [XID] // 0x0000000189733AC0-0x0000000189733AE0
	private void OnDungeonChallengeUpdateCheck(uint challengeIndex) {} // 0x0000000180F30A60-0x0000000180F30D70
	// [XID] // 0x000000018973B200-0x000000018973B220
	private void CheckGadgetPlayInfo() {} // 0x0000000180F57A10-0x0000000180F57AF0
	// [XID] // 0x0000000189742BB0-0x0000000189742BD0
	private void OnMpPlayPrepareNotify(bool prepare) {} // 0x0000000180F430F0-0x0000000180F432C0
	// [XID] // 0x000000018974A890-0x000000018974A8B0
	private void CheckGadgetPlayStart(GadgetPlayInfo gadgetPlayInfo) {} // 0x0000000180F452A0-0x0000000180F45400
	// [XID] // 0x0000000189751990-0x00000001897519B0
	private void DoGadgetPlayStart() {} // 0x0000000180F5AF90-0x0000000180F5B1B0
	// [XID] // 0x0000000189758FA0-0x0000000189758FC0
	private void OnGadgetPlayStartNotify(bool waitStart) {} // 0x0000000180F6BD10-0x0000000180F6BDD0
	// [XID] // 0x0000000189760C10-0x0000000189760C30
	private void InitGadgetPlayMainUI() {} // 0x0000000180F34B40-0x0000000180F34EA0
	[DebuggerHidden] // 0x0000000189767EB0-0x0000000189767EF0
	// [XID] // 0x0000000189767EB0-0x0000000189767EF0
	private IEnumerator PlayGadgetPlayStartAnim(float cdTime) => default; // 0x0000000180F2B950-0x0000000180F2BA40
	// [XID] // 0x00000001897726C0-0x00000001897726E0
	private void OnGadgetPlayDataNotify() {} // 0x0000000180F3BBC0-0x0000000180F3BDF0
	// [XID] // 0x0000000189779CF0-0x0000000189779D10
	private void OnGadgetPlayUidOpNotify() {} // 0x0000000180F6CD90-0x0000000180F6CEF0
	[DebuggerHidden] // 0x0000000189781970-0x00000001897819B0
	// [XID] // 0x0000000189781970-0x00000001897819B0
	private IEnumerator PlayGadgetPlayUidOpAnim() => default; // 0x0000000180F39910-0x0000000180F399E0
	// [XID] // 0x000000018978BDA0-0x000000018978BDC0
	private void OnGadgetPlayStopNotify(int stopType) {} // 0x0000000180F3E650-0x0000000180F3E860
	[DebuggerHidden] // 0x0000000189793250-0x0000000189793290
	// [XID] // 0x0000000189793250-0x0000000189793290
	private IEnumerator PlayGadgetPlayStopAnim(bool isWin) => default; // 0x0000000180F65420-0x0000000180F65510
	// [XID] // 0x000000018979E510-0x000000018979E530
	private void InitGadgetPlayPrepareTime(uint endTime) {} // 0x0000000180F4D2E0-0x0000000180F4D4B0
	// [XID] // 0x00000001897A5CB0-0x00000001897A5CD0
	private void InitGadgetPlayPrepareCountdown(float seconds) {} // 0x0000000180F6DD50-0x0000000180F6DF10
	// [XID] // 0x00000001897AD220-0x00000001897AD240
	public void InitGagdetPlayBar(IList<uint> values, uint stage) {} // 0x0000000180F555C0-0x0000000180F559D0
	// [XID] // 0x00000001897B5250-0x00000001897B5270
	public void UpdateGagdetPlayBar(float value, float max, uint stage) {} // 0x0000000180F29900-0x0000000180F29B50
	// [XID] // 0x00000001897BCF00-0x00000001897BCF20
	private void InitGagdetPlayCountDown(ulong beginTime, ulong endTime) {} // 0x0000000180F2A750-0x0000000180F2A910
	// [XID] // 0x00000001897C4240-0x00000001897C4260
	private void ShowEventPromptTop(Sprite elementSprit, ElementType elementType) {} // 0x0000000180F41B10-0x0000000180F41E20
	// [XID] // 0x00000001897CBAC0-0x00000001897CBAE0
	private void ShowTeamBtnStateBonus(uint uid) {} // 0x0000000180F539B0-0x0000000180F53AF0
	// [XID] // 0x00000001897D33D0-0x00000001897D33F0
	private void ClearTeamBtnStateBonus() {} // 0x0000000180F6D750-0x0000000180F6D880
	// [XID] // 0x00000001897DAE50-0x00000001897DAE70
	private void ShowBonusBar(Sprite elementSprit, string elementTypeStr) {} // 0x0000000180F30390-0x0000000180F305E0
	// [XID] // 0x00000001897E2560-0x00000001897E2580
	private void ShowGadgetPlayBegin() {} // 0x0000000180F63100-0x0000000180F63370
	// [XID] // 0x00000001897E9D10-0x00000001897E9D30
	private void ShowGadgetPlayEnd(bool isWin, string completeTitle, string failTitle) {} // 0x0000000180F4C870-0x0000000180F4CAE0
	// [XID] // 0x00000001897F1970-0x00000001897F1990
	private void TickGagdetPlayView() {} // 0x0000000180F4B910-0x0000000180F4BFC0
	// [XID] // 0x00000001897F90E0-0x00000001897F9100
	private void OnBonusBarPlayEnd() {} // 0x0000000180F603C0-0x0000000180F604A0
	// [XID] // 0x00000001898006F0-0x0000000189800710
	private void PushControlDisableState(MainPageDisableType disableType, bool value, string disableInfoName = "DisableAll" /* Metadata: 0x00B0FFD3 */) {} // 0x0000000180F44280-0x0000000180F44A30
	// [XID] // 0x0000000189807D90-0x0000000189807DB0
	private void TrySetUIActiveByType(MainPageUIDisableType uiDisableType, bool value) {} // 0x0000000180F4DA50-0x0000000180F4DD10
	// [XID] // 0x000000018980F670-0x000000018980F690
	private bool CheckCanHandleInputAction(InputActionEvent actionEvent) => default; // 0x0000000180F5DA40-0x0000000180F5DBE0
	// [XID] // 0x0000000189816D20-0x0000000189816D40
	private void InitLocalControl() {} // 0x0000000180F63B70-0x0000000180F63D10
	// [XID] // 0x000000018981E570-0x000000018981E590
	private void TryJump() {} // 0x0000000180F6DC80-0x0000000180F6DD50
	// [XID] // 0x0000000189825A10-0x0000000189825A30
	private void OnAvatarChanged_LocalControl() {} // 0x0000000180F63E40-0x0000000180F63F00
	// [XID] // 0x000000018982D1C0-0x000000018982D1E0
	private bool TryDoQuickUse() => default; // 0x0000000180F52F80-0x0000000180F53140
	// [XID] // 0x0000000189834920-0x0000000189834940
	private bool TryReleaseQuickUse() => default; // 0x0000000180F39260-0x0000000180F39420
	// [XID] // 0x000000018983BFB0-0x000000018983BFD0
	private bool TryDoActivitySkilll() => default; // 0x0000000180F3FB30-0x0000000180F3FCF0
	// [XID] // 0x00000001898435E0-0x0000000189843600
	private bool TryReleaseActivitySkill() => default; // 0x0000000180F359B0-0x0000000180F35B70
	// [XID] // 0x000000018984AAE0-0x000000018984AB00
	private bool TryDoSkill(int index) => default; // 0x0000000180F5C650-0x0000000180F5CB20
	// [XID] // 0x0000000189851E80-0x0000000189851EA0
	private bool TryReleaseSkill(int index) => default; // 0x0000000180F53140-0x0000000180F53500
	// [XID] // 0x0000000189859760-0x0000000189859780
	private bool TryToggleAttackMode() => default; // 0x0000000180F56260-0x0000000180F56330
	// [XID] // 0x00000001898608C0-0x00000001898608E0
	private bool TryEnterAttackMode() => default; // 0x0000000180F28050-0x0000000180F28120
	// [XID] // 0x0000000189867FF0-0x0000000189868010
	private bool TryExitAttackMode() => default; // 0x0000000180F60E50-0x0000000180F60F20
	// [XID] // 0x000000018986F550-0x000000018986F570
	private bool TryOpenWheelMenuDialog() => default; // 0x0000000180F587D0-0x0000000180F58AB0
	// [XID] // 0x0000000189876B60-0x0000000189876B80
	private bool ChangeToTeammate(int teammateIndex) => default; // 0x0000000180F5B980-0x0000000180F5BC70
	// [XID] // 0x000000018987E660-0x000000018987E680
	private bool TryChangeAvaterByIndex(int teammateIndex) => default; // 0x0000000180F42730-0x0000000180F42C40
	// [XID] // 0x0000000189885A50-0x0000000189885A70
	private void OnVirtualDialSelect(VirtualDialAction action) {} // 0x0000000180F3FF50-0x0000000180F40650
	// [XID] // 0x000000018988CD40-0x000000018988CD60
	private bool TrySlip() => default; // 0x0000000180F46AD0-0x0000000180F46BA0
	// [XID] // 0x0000000189894430-0x0000000189894450
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000180F472F0-0x0000000180F48B10
	// [XID] // 0x000000018989B9E0-0x000000018989BA00
	public void TranslateAxisInput(float x, float y) {} // 0x0000000180F58690-0x0000000180F587D0
	// [XID] // 0x00000001898A2E70-0x00000001898A2E90
	private void CheckCountDownTerminate(InputEventType eventType) {} // 0x0000000180F435C0-0x0000000180F43690
	// [XID] // 0x00000001898AA390-0x00000001898AA3B0
	public override void OnInputDeviceChanged() {} // 0x0000000180F67840-0x0000000180F67A10
	// [XID] // 0x00000001898B1D70-0x00000001898B1D90
	private void CameraLoockEnd() {} // 0x0000000180F45940-0x0000000180F45A00
	// [XID] // 0x00000001898B99F0-0x00000001898B9A10
	private void OnTriggerChangeWithSkillEvent() {} // 0x0000000180F5E880-0x0000000180F5E9D0
	// [XID] // 0x00000001898C0DF0-0x00000001898C0E10
	private void OnCancelChangeWithSkillEvent() {} // 0x0000000180F5A780-0x0000000180F5A8D0
	// [XID] // 0x00000001898C8730-0x00000001898C8750
	private bool IslevelInElementView() => default; // 0x0000000180F41590-0x0000000180F416C0
	// [XID] // 0x00000001898D00E0-0x00000001898D0100
	private void ShowMessage(string content, Color color, string subContent = "" /* Metadata: 0x00B0FFE1 */) {} // 0x0000000180F6C0C0-0x0000000180F6C300
	// [XID] // 0x00000001898D76B0-0x00000001898D76D0
	public void ShowTips(string tips, bool showBackground = false /* Metadata: 0x00B0FFE5 */) {} // 0x0000000180F55D70-0x0000000180F55E70
	// [XID] // 0x00000001898DF400-0x00000001898DF420
	public bool IsQuestHintDialogShow() => default; // 0x0000000180F62840-0x0000000180F62990
	// [XID] // 0x00000001898E6D80-0x00000001898E6DA0
	private void AddQuestHint(QuestExcelConfigProxy config, QuestHintType type) {} // 0x0000000180F395C0-0x0000000180F39730
	// [XID] // 0x00000001898EE530-0x00000001898EE550
	public bool IsQuestProgressDialogShow() => default; // 0x0000000180F6DF10-0x0000000180F6DFE0
	// [XID] // 0x00000001898F5D00-0x00000001898F5D20
	private void AddQuestProgressHint(QuestExcelConfigProxy config, uint finishProgress) {} // 0x0000000180F626D0-0x0000000180F62840
	// [XID] // 0x00000001898FD4C0-0x00000001898FD4E0
	private void RemindQuest(uint subQuestID) {} // 0x0000000180F2BA40-0x0000000180F2BBC0
	// [XID] // 0x0000000189904DC0-0x0000000189904DE0
	private void InitGuidePoint() {} // 0x0000000180F6CB40-0x0000000180F6CD90
	// [XID] // 0x000000018990C600-0x000000018990C620
	private void AddGuidePoint(GuidePointData guidePointData) {} // 0x0000000180F2CD80-0x0000000180F2D050
	// [XID] // 0x0000000189913EB0-0x0000000189913ED0
	private void RemoveGuidePoint(uint entityRuntimeID) {} // 0x0000000180F4E6F0-0x0000000180F4E8A0
	// [XID] // 0x000000018991B8A0-0x000000018991B8C0
	private void AddNavigationPoint(TargetIndicatorType type, uint markId, TrackingGroup groupId) {} // 0x0000000180F54BC0-0x0000000180F54DC0
	// [XID] // 0x0000000189922E20-0x0000000189922E40
	private void RefreshNavigationPointAnime() {} // 0x0000000180F3CF90-0x0000000180F3D040
	// [IDTag] // 0x000000018992A6B0-0x000000018992A6F0
	// [XID] // 0x000000018992A6B0-0x000000018992A6F0
	private void RemoveNavigationPoint(TargetIndicatorType type, uint markId) {} // 0x0000000180F30D70-0x0000000180F30E80
	// [IDTag] // 0x0000000189934B50-0x0000000189934B90
	// [XID] // 0x0000000189934B50-0x0000000189934B90
	private void RemoveNavigationPoint(uint targetId, bool isNavigation, bool fadeOut = true /* Metadata: 0x00B0FFE6 */) {} // 0x0000000180F30E80-0x0000000180F31030
	// [XID] // 0x000000018993F530-0x000000018993F550
	private void CheckNavigationPoint() {} // 0x0000000180F66370-0x0000000180F66420
	// [XID] // 0x0000000189946B00-0x0000000189946B20
	private void AddGadgetIndicator(uint targetId, Vector3 pos, IndicatorDistanceInfoType disType, string icon, float yOffSet, bool isFollowMove) {} // 0x0000000180F28240-0x0000000180F28460
	// [XID] // 0x000000018994E180-0x000000018994E1A0
	private void SetGadgetIndicatorCountDown(uint targetId, uint countDownTime) {} // 0x0000000180F57320-0x0000000180F57400
	// [XID] // 0x00000001899557A0-0x00000001899557C0
	private void RemoveGadgetIndicator(uint targetId) {} // 0x0000000180F2C800-0x0000000180F2C970
	// [XID] // 0x000000018995D2C0-0x000000018995D2E0
	private void OnBlossomItemAdded(List<SimpleItemStruct> items, ItemGetReason itemGetReason = ItemGetReason.General /* Metadata: 0x00B0FFE7 */) {} // 0x0000000180F3EA40-0x0000000180F3EB20
	// [XID] // 0x0000000189964970-0x0000000189964990
	private void OnQuestItemAdded(List<SimpleItemStruct> items, ItemGetReason itemGetReason = ItemGetReason.General /* Metadata: 0x00B0FFEB */, bool showAllRewardInMiddle = false /* Metadata: 0x00B0FFEF */) {} // 0x0000000180F2AA90-0x0000000180F2AC90
	// [XID] // 0x000000018996C050-0x000000018996C070
	private void ShowQuestRewardViewportDialog(List<SimpleItemStruct> items, ItemGetReason itemGetReason = ItemGetReason.General /* Metadata: 0x00B0FFF0 */, bool showAllRewardInMiddle = false /* Metadata: 0x00B0FFF4 */) {} // 0x0000000180F550A0-0x0000000180F55260
	// [XID] // 0x0000000189973AE0-0x0000000189973B00
	private void ShowQuestRewardDialog(List<SimpleItemStruct>[] itemLists, ItemGetReason itemGetReason = ItemGetReason.General /* Metadata: 0x00B0FFF5 */) {} // 0x0000000180F50250-0x0000000180F508A0
	// [XID] // 0x000000018997B130-0x000000018997B150
	private List<SimpleItemStruct>[] SeparateItemList(List<SimpleItemStruct> items, bool showAllRewardInMiddle) => default; // 0x0000000180F32380-0x0000000180F32700
	// [XID] // 0x0000000189982C40-0x0000000189982C60
	public void TryShowOpenStateChangeTip(OpenStateType type) {} // 0x0000000180F31F70-0x0000000180F32020
	// [XID] // 0x000000018998A430-0x000000018998A450
	private void ShowDeblockingDialog(OpenStateType type) {} // 0x0000000180F50100-0x0000000180F50250
	// [XID] // 0x0000000189991D20-0x0000000189991D40
	private void ShowGuideRatingDialog() {} // 0x0000000180F305E0-0x0000000180F30710
	// [XID] // 0x0000000189999A50-0x0000000189999A70
	private void OnPlayerLevelUp(uint oldLevel, uint currLevel) {} // 0x0000000180F63440-0x0000000180F63560
	// [XID] // 0x00000001899A10E0-0x00000001899A1100
	private void OnPlayerLevelLockChange(uint worldLevel) {} // 0x0000000180F54FB0-0x0000000180F550A0
	// [XID] // 0x00000001899A8BF0-0x00000001899A8C10
	private void OnPlayerLevelLockAdjust(uint curLevel, uint nextLevel, PlayerLevelSurmountWidgetContext.AdjustType adjustType) {} // 0x0000000180F3EFC0-0x0000000180F3F0D0
	// [XID] // 0x00000001899B0510-0x00000001899B0530
	private void OnPlayerFetterUp(uint oldLevel, uint currLevel, string name = "" /* Metadata: 0x00B0FFF9 */) {} // 0x0000000180F3EE90-0x0000000180F3EFC0
	// [XID] // 0x00000001899B7840-0x00000001899B7860
	private void OnPlayerExpUp(PlayerExpLevelStruct expStruct) {} // 0x0000000180F4AF60-0x0000000180F4B080
	// [XID] // 0x00000001899BF1E0-0x00000001899BF200
	private void ShowPlayerLevel() {} // 0x0000000180F33FD0-0x0000000180F34120
	// [XID] // 0x00000001899C6BE0-0x00000001899C6C00
	private void OnAvatarLevelUp(Tuple<ulong, uint, int, int> avatarLevelUpInfo) {} // 0x0000000180F43F60-0x0000000180F44120
	// [XID] // 0x00000001899CE120-0x00000001899CE140
	private void OnCoopStartFirstPoint(uint chapterId) {} // 0x0000000180F5B8A0-0x0000000180F5B980
	// [XID] // 0x00000001899D5900-0x00000001899D5920
	private void OnCoopShowDefeatDialog(string param) {} // 0x0000000180F639C0-0x0000000180F63B70
	// [XID] // 0x00000001899DCC10-0x00000001899DCC30
	private void OnDailyTaskStart() {} // 0x0000000180F62BE0-0x0000000180F62ED0
	// [XID] // 0x00000001899E4850-0x00000001899E4870
	private void OnDailyTaskProgressUpdate() {} // 0x0000000180F40ED0-0x0000000180F41110
	// [XID] // 0x00000001899EBC40-0x00000001899EBC60
	private void OnDailyTaskComplete() {} // 0x0000000180F57F40-0x0000000180F58230
	// [XID] // 0x00000001899F3710-0x00000001899F3730
	private void OnDailyTaskExitRegion() {} // 0x0000000180F29DB0-0x0000000180F29E80
	// [XID] // 0x00000001899FB030-0x00000001899FB050
	private void OnDailyTaskRefresh() {} // 0x0000000180F63370-0x0000000180F63440
	// [XID] // 0x0000000189A02280-0x0000000189A022A0
	private void OnDailyTaskScoreReward(List<SimpleItemStruct> items) {} // 0x0000000180F2C4A0-0x0000000180F2C680
	// [XID] // 0x0000000189A09A70-0x0000000189A09A90
	public static int CompareItemsByRank(SimpleItemStruct item1, SimpleItemStruct item2) => default; // 0x0000000180F2FD90-0x0000000180F2FED0
	// [XID] // 0x0000000189A11210-0x0000000189A11230
	private void OnRoutineStart() {} // 0x0000000180F64020-0x0000000180F641B0
	// [XID] // 0x0000000189A185E0-0x0000000189A18600
	private void OnRoutineProgressUpdate() {} // 0x0000000180F51CF0-0x0000000180F51E80
	// [XID] // 0x0000000189A1FCC0-0x0000000189A1FCE0
	private void OnRoutineComplete() {} // 0x0000000180F35FB0-0x0000000180F361E0
	// [XID] // 0x0000000189A27030-0x0000000189A27050
	private void OnRoutineExitRegion() {} // 0x0000000180F662A0-0x0000000180F66370
	// [XID] // 0x0000000189A2E850-0x0000000189A2E870
	private void OnRoutineRefresh() {} // 0x0000000180F4AE90-0x0000000180F4AF60
	// [XID] // 0x0000000189A361A0-0x0000000189A361C0
	private void OnRoutineScoreReward(List<SimpleItemStruct> items) {} // 0x0000000180F66A20-0x0000000180F66C00
	// [XID] // 0x0000000189A3D7A0-0x0000000189A3D7C0
	private void OnRandTaskStart() {} // 0x0000000180F4D4B0-0x0000000180F4D7E0
	// [XID] // 0x0000000189A44EE0-0x0000000189A44F00
	private void OnRandTaskComplete() {} // 0x0000000180F3D1E0-0x0000000180F3D4B0
	// [XID] // 0x0000000189A4C680-0x0000000189A4C6A0
	private void OnRandTaskFail() {} // 0x0000000180F40650-0x0000000180F40890
	// [XID] // 0x0000000189A53E20-0x0000000189A53E40
	private void OnRandTaskExitRegion() {} // 0x0000000180F42350-0x0000000180F42420
	// [XID] // 0x0000000189A5B890-0x0000000189A5B8B0
	private void OnGetPushTipsRewardNotify(List<SimpleItemStruct> items) {} // 0x0000000180F4FC30-0x0000000180F4FE30
	// [XID] // 0x0000000189A62F40-0x0000000189A62F60
	private void AddBannerReminder(string content) {} // 0x0000000180F64270-0x0000000180F64390
	// [XID] // 0x0000000189A6AA60-0x0000000189A6AA80
	private void RemoveBannerReminder() {} // 0x0000000180F63F00-0x0000000180F63FB0
	// [XID] // 0x0000000189A72160-0x0000000189A72180
	public bool ReadyToShowBannerReminder() => default; // 0x0000000180F641B0-0x0000000180F64270
	// [XID] // 0x0000000189A79E00-0x0000000189A79E20
	private bool ReadyToEnqueueWidgetContext() => default; // 0x0000000180F5D960-0x0000000180F5DA40
	// [XID] // 0x0000000189A81280-0x0000000189A812A0
	private bool OnNotifyActivityCommonPlayerTips(Notify ntf) => default; // 0x0000000180F508A0-0x0000000180F50A00
	// [XID] // 0x0000000189A88C60-0x0000000189A88C80
	private void ShowActivityCommonPlayerTipsStart(List<string> tips, NotifyTypes type) {} // 0x0000000180F61A20-0x0000000180F61B90
	// [XID] // 0x0000000189A90450-0x0000000189A90470
	private void ShowActivityCommonPlayerTipsFinish(List<string> tips, NotifyTypes type) {} // 0x0000000180F2B070-0x0000000180F2B1E0
	// [XID] // 0x0000000189A97C00-0x0000000189A97C20
	private void ShowActivityCommonPlayerTipsFail(List<string> tips, NotifyTypes type) {} // 0x0000000180F31E00-0x0000000180F31F70
	// [XID] // 0x0000000189A9EFD0-0x0000000189A9EFF0
	private void OnShowTemplateReminderNotify(ShowTemplateReminderNotify ntf) {} // 0x0000000180F604A0-0x0000000180F60D90
	// [XID] // 0x0000000189AA6930-0x0000000189AA6950
	private void OnCloseTemplateReminderDialog() {} // 0x0000000180F60D90-0x0000000180F60E50
	[DebuggerHidden] // 0x0000000189AADF80-0x0000000189AADFC0
	// [XID] // 0x0000000189AADF80-0x0000000189AADFC0
	private IEnumerator PlayTemplateReminderAnim(float waitTime) => default; // 0x0000000180F3E500-0x0000000180F3E5F0
	// [XID] // 0x0000000189AB8620-0x0000000189AB8640
	private void OnNormalUidOpNotify(NormalUidOpNotify ntf) {} // 0x0000000180F5BF40-0x0000000180F5C360
	// [XID] // 0x0000000189AC0300-0x0000000189AC0320
	private void CheckPushTipsShow(bool newTips = false /* Metadata: 0x00B0FFFD */) {} // 0x0000000180F5A8D0-0x0000000180F5AF00
	// [XID] // 0x0000000189AC7D00-0x0000000189AC7D20
	private void FadeoutPushTips() {} // 0x0000000180F2DD90-0x0000000180F2E010
	// [XID] // 0x0000000189ACF240-0x0000000189ACF260
	private void FlashGuideButton() {} // 0x0000000180F2FBD0-0x0000000180F2FD90
	// [XID] // 0x0000000189AD7110-0x0000000189AD7130
	private void ClosePushTips() {} // 0x0000000180F3F7A0-0x0000000180F3F900
	// [XID] // 0x0000000189ADEAD0-0x0000000189ADEAF0
	private bool CheckDungeonPushTipsShow() => default; // 0x0000000180F52CE0-0x0000000180F52E50
	// [XID] // 0x0000000189AE64C0-0x0000000189AE64E0
	private void ShowMessagePushPage() {} // 0x0000000180F49780-0x0000000180F49890
	// [XID] // 0x0000000189AFCA10-0x0000000189AFCA30
	public void InLevelMapInfo() {} // 0x0000000180F4A8C0-0x0000000180F4AE90
	// [XID] // 0x0000000189B04190-0x0000000189B041B0
	private void SetupMiniMapView() {} // 0x0000000180F46EB0-0x0000000180F472F0
	// [XID] // 0x0000000189B0BA30-0x0000000189B0BA50
	private bool UnlockFirstArea() => default; // 0x0000000180F55B20-0x0000000180F55D00
	// [XID] // 0x0000000189B12F00-0x0000000189B12F20
	private void LoadAllMapImages() {} // 0x0000000180F56D70-0x0000000180F56E10
	// [XID] // 0x0000000189B1A610-0x0000000189B1A630
	private void LoadMapImage() {} // 0x0000000180F414E0-0x0000000180F41590
	// [XID] // 0x0000000189B21BA0-0x0000000189B21BC0
	private void LoadMapBackImage() {} // 0x0000000180F4EB50-0x0000000180F4EBF0
	// [XID] // 0x0000000189B29260-0x0000000189B29280
	private void OnLoadMapBackImage() {} // 0x0000000180F3DE50-0x0000000180F3E250
	// [XID] // 0x0000000189B306B0-0x0000000189B306D0
	private void UpdateMiniMapScale() {} // 0x0000000180F2CC20-0x0000000180F2CD20
	// [XID] // 0x0000000189B37F50-0x0000000189B37F70
	public void SetMinimapScale(float scale) {} // 0x0000000180F584F0-0x0000000180F58690
	[DebuggerHidden] // 0x0000000189B3F960-0x0000000189B3F9A0
	// [XID] // 0x0000000189B3F960-0x0000000189B3F9A0
	private IEnumerator SetScaleCoroutine() => default; // 0x0000000180F54DC0-0x0000000180F54E90
	// [IDTag] // 0x0000000189B4A2D0-0x0000000189B4A310
	// [XID] // 0x0000000189B4A2D0-0x0000000189B4A310
	private void DoSetMinimapScale(float scale) {} // 0x0000000180F33D80-0x0000000180F33E90
	// [XID] // 0x0000000189B54850-0x0000000189B54870
	public float InLevelSize2MiniMapUISize(float size) => default; // 0x0000000180F61DD0-0x0000000180F61F20
	// [IDTag] // 0x0000000189B5C410-0x0000000189B5C450
	// [XID] // 0x0000000189B5C410-0x0000000189B5C450
	private void DoSetMinimapScale() {} // 0x0000000180F33BE0-0x0000000180F33D80
	// [XID] // 0x0000000189B66880-0x0000000189B668A0
	private void UpdateMarkAreaCircleEdge() {} // 0x0000000180F28E20-0x0000000180F29030
	// [XID] // 0x0000000189B6DDA0-0x0000000189B6DDC0
	public void RefreshMapback() {} // 0x0000000180F58EC0-0x0000000180F59320
	// [XID] // 0x0000000189B75490-0x0000000189B754B0
	public float MapSizeScale() => default; // 0x0000000180F5DEF0-0x0000000180F5E0B0
	// [XID] // 0x0000000189B7C8E0-0x0000000189B7C900
	public void RefreshMapRotation() {} // 0x0000000180F615C0-0x0000000180F61A20
	// [XID] // 0x0000000189B84780-0x0000000189B847A0
	private void LoadLimitRegion() {} // 0x0000000180F43690-0x0000000180F43970
	// [XID] // 0x0000000189B8B5D0-0x0000000189B8B5F0
	private void DestroyLimitRegion() {} // 0x0000000180F623C0-0x0000000180F62460
	// [XID] // 0x0000000189B92D00-0x0000000189B92D20
	public void ClearMiniMapView() {} // 0x0000000180F51340-0x0000000180F51760
	// [XID] // 0x0000000189B9A2E0-0x0000000189B9A300
	private Dictionary<uint, MonoMapMark> GetMarkDic(MarkType markType) => default; // 0x0000000180F38D30-0x0000000180F38E80
	// [XID] // 0x0000000189BA19F0-0x0000000189BA1A10
	public void AddMiniMapMark(RectTransform mark, bool isOtherLayer, ConfigVMapMark config) {} // 0x0000000180F454C0-0x0000000180F455C0
	// [XID] // 0x0000000189BA8DF0-0x0000000189BA8E10
	public void OnMapNotify(Notify ntf) {} // 0x0000000180F46D90-0x0000000180F46EB0
	// [XID] // 0x0000000189BB05E0-0x0000000189BB0600
	private void OnMapNotifyUnlockArea(Notify ntf) {} // 0x0000000180F56E10-0x0000000180F57040
	// [XID] // 0x0000000189BB7960-0x0000000189BB7980
	private void FetchAllMark() {} // 0x0000000180F54370-0x0000000180F54540
	// [XID] // 0x0000000189BBEFC0-0x0000000189BBEFE0
	public void ReFetchAllMark() {} // 0x0000000180F2D760-0x0000000180F2DA90
	// [XID] // 0x0000000189BC6C90-0x0000000189BC6CB0
	public void RefreshAllMark() {} // 0x0000000180F2E590-0x0000000180F2E830
	// [XID] // 0x0000000189BCE940-0x0000000189BCE960
	private void RefreshMarkViewByType(MarkType markType) {} // 0x0000000180F5DBE0-0x0000000180F5DE30
	// [XID] // 0x0000000189BD5C00-0x0000000189BD5C20
	private void RefreshMarkViewByTypeInRange(MarkType markType) {} // 0x0000000180F4E060-0x0000000180F4E430
	// [XID] // 0x0000000189BDD8B0-0x0000000189BDD8D0
	public void UpdateDirtyMarks(List<MarkManager.GeneralMarkID> dirtyMarks) {} // 0x0000000180F2DBB0-0x0000000180F2DD90
	// [XID] // 0x00000001895EA470-0x00000001895EA490
	public void UpdateMovedMarks(List<MarkManager.GeneralMarkID> movedMarkIDs) {} // 0x0000000180F6C600-0x0000000180F6C910
	private void RemoveInvalidMarks<T>(MarkType markType, Dictionary<uint, T> validMarks) {}
	// [XID] // 0x00000001895F1890-0x00000001895F18B0
	private void RemoveInvalidMark(MarkType markType, uint invalidMarkID) {} // 0x0000000180F49600-0x0000000180F49780
	// [XID] // 0x00000001895F92F0-0x00000001895F9310
	private void UpdateLimitRegionPos(Vector3 avatarLevelMapPos) {} // 0x0000000180F625A0-0x0000000180F626D0
	// [XID] // 0x0000000189600920-0x0000000189600940
	private void UpdateLimitRegionAngle(Transform cameraTrans) {} // 0x0000000180F56C50-0x0000000180F56D70
	// [XID] // 0x0000000189608240-0x0000000189608260
	private MonoMapMark InitMark(MarkType markType, MarkIconType markIconType) => default; // 0x0000000180F55F20-0x0000000180F56180
	// [XID] // 0x000000018960FBE0-0x000000018960FC00
	private void RefreshMarkAngle() {} // 0x0000000180F594A0-0x0000000180F5A780
	// [XID] // 0x0000000189616E80-0x0000000189616EA0
	private void RefreshMarkPos() {} // 0x0000000180F51F90-0x0000000180F52860
	// [XID] // 0x000000018961EA00-0x000000018961EA20
	private void CheckClearFakeMark() {} // 0x0000000180F4B430-0x0000000180F4B870
	// [IDTag] // 0x0000000189625E00-0x0000000189625E40
	// [XID] // 0x0000000189625E00-0x0000000189625E40
	public void RefreshMark() {} // 0x0000000180F65A50-0x0000000180F65D10
	// [IDTag] // 0x0000000189630980-0x00000001896309C0
	// [XID] // 0x0000000189630980-0x00000001896309C0
	private void RefreshMark(MonoMapMark mark, MarkType markType, Vector2 relatedDelta, bool updateSearch = false /* Metadata: 0x00B0FFFE */) {} // 0x0000000180F65510-0x0000000180F65A50
	// [XID] // 0x000000018963B110-0x000000018963B130
	private void UpdateUnderLayerColor(MonoMapMark mark) {} // 0x0000000180F5F980-0x0000000180F5FC90
	// [XID] // 0x0000000189642840-0x0000000189642860
	private void ShowAreaMarkOnMinimap(MonoMapMark realmark, Vector2 delta) {} // 0x0000000180F54540-0x0000000180F54B50
	// [IDTag] // 0x0000000189649EF0-0x0000000189649F30
	// [XID] // 0x0000000189649EF0-0x0000000189649F30
	private void ClearAreaMarkOnMinimap(MonoMapMark fakemark) {} // 0x0000000180F4C330-0x0000000180F4C560
	// [IDTag] // 0x0000000189654860-0x00000001896548A0
	// [XID] // 0x0000000189654860-0x00000001896548A0
	private void ClearAreaMarkOnMinimap(MarkType markType, uint markID) {} // 0x0000000180F4C150-0x0000000180F4C330
	// [XID] // 0x000000018965ED40-0x000000018965ED60
	private void RefreshAreaMark(MonoMapMark mark, Vector2 delta) {} // 0x0000000180F574E0-0x0000000180F57A10
	// [XID] // 0x0000000189666420-0x0000000189666440
	private void ReuseAllMark() {} // 0x0000000180F31460-0x0000000180F317B0
	// [XID] // 0x000000018966DC00-0x000000018966DC20
	private void RefreshMarkView(MarkType markType, uint markID, GeneralMarkData markData, bool force = true /* Metadata: 0x00B0FFFF */) {} // 0x0000000180F39CB0-0x0000000180F3B590
	// [XID] // 0x00000001896759C0-0x00000001896759E0
	private void ReCheckMarkVisibilityType(MonoMapMark mark, uint markId, GeneralMarkData markData) {} // 0x0000000180F45AD0-0x0000000180F460A0
	// [XID] // 0x000000018967D2F0-0x000000018967D310
	private void InitTalkMark(MonoMapMark mark) {} // 0x0000000180F2CB40-0x0000000180F2CC20
	// [XID] // 0x00000001896C7670-0x00000001896C7690
	private void OpenMPLobbyPage() {} // 0x0000000180F4F530-0x0000000180F4F760
	// [XID] // 0x00000001896CEDD0-0x00000001896CEDF0
	private void CheckQuestToggleButtonState() {} // 0x0000000180F38560-0x0000000180F38710
	// [XID] // 0x00000001896D61F0-0x00000001896D6210
	private void OnScenePlayerListNotify() {} // 0x0000000180F4B870-0x0000000180F4B910
	// [XID] // 0x00000001896DD810-0x00000001896DD830
	private void OnReputationLevelUp(CityReputationLevelupNotify ntf) {} // 0x0000000180F39480-0x0000000180F395C0
	// [XID] // 0x00000001896E4EA0-0x00000001896E4EC0
	private void OnHuntingStart() {} // 0x0000000180F28460-0x0000000180F285F0
	// [XID] // 0x00000001896EC3A0-0x00000001896EC3C0
	private void OnHuntingRevealClue() {} // 0x0000000180F35CE0-0x0000000180F35FB0
	// [XID] // 0x00000001896F3B30-0x00000001896F3B50
	private void OnHuntingRevealFinal() {} // 0x0000000180F36A00-0x0000000180F36C40
	// [XID] // 0x00000001896FB2A0-0x00000001896FB2C0
	private void OnHuntingFinish(bool success) {} // 0x0000000180F61450-0x0000000180F615C0
	// [XID] // 0x0000000189702A50-0x0000000189702A70
	private void InitHuntingPlayCountDown(ulong endTime) {} // 0x0000000180F33E90-0x0000000180F33FD0
	// [XID] // 0x000000018970A170-0x000000018970A190
	private void TickHuntingPlayView(bool force = false /* Metadata: 0x00B10000 */) {} // 0x0000000180F56940-0x0000000180F56C50
	// [XID] // 0x0000000189711C30-0x0000000189711C50
	private void CheckScenePlayBattle() {} // 0x0000000180F64390-0x0000000180F64470
	// [XID] // 0x00000001897190B0-0x00000001897190D0
	private void OnScenePlayBattlePrepare() {} // 0x0000000180F58230-0x0000000180F58340
	// [XID] // 0x0000000189720770-0x0000000189720790
	private void OnScenePlayBattlePrestart() {} // 0x0000000180F2D050-0x0000000180F2D230
	// [XID] // 0x0000000189727D20-0x0000000189727D40
	private void OnScenePlayBattleStart() {} // 0x0000000180F58AB0-0x0000000180F58CE0
	// [XID] // 0x000000018972F3C0-0x000000018972F3E0
	private void OnScenePlayBattleInterrupt() {} // 0x0000000180F6E510-0x0000000180F6E5C0
	// [XID] // 0x0000000189736D80-0x0000000189736DA0
	private void OnScenePlayBattleStop(int stopType, uint costTime = 0 /* Metadata: 0x00B10001 */) {} // 0x0000000180F57CA0-0x0000000180F57E20
	// [XID] // 0x000000018973E980-0x000000018973E9A0
	private void PlayScenePlayStopAnim(bool isWin, uint costTime) {} // 0x0000000180F65260-0x0000000180F65420
	// [XID] // 0x0000000189745C60-0x0000000189745C80
	public void InitScenePlayPrepareTime(uint endTime, bool useLevelTime = false /* Metadata: 0x00B10005 */, float defaultCountdown = -1f /* Metadata: 0x00B10006 */, string readyStr = null) {} // 0x0000000180F290F0-0x0000000180F29380
	// [XID] // 0x000000018974D710-0x000000018974D730
	public void InitScenePlayPrepareCountdown(float seconds) {} // 0x0000000180F41240-0x0000000180F41420
	// [XID] // 0x0000000189754D50-0x0000000189754D70
	private void ShowScenePlayBegin() {} // 0x0000000180F56330-0x0000000180F56610
	[DebuggerHidden] // 0x000000018975BF00-0x000000018975BF40
	// [XID] // 0x000000018975BF00-0x000000018975BF40
	private IEnumerator PlayScenePlayPrestartAnim(float cdTime) => default; // 0x0000000180F6CA50-0x0000000180F6CB40
	// [XID] // 0x0000000189766880-0x00000001897668A0
	private void InitScenePlayMainUI() {} // 0x0000000180F4DD10-0x0000000180F4E060
	// [XID] // 0x000000018976DE50-0x000000018976DE70
	private void InitScenePlayBar(IList<uint> values, uint stage) {} // 0x0000000180F2D290-0x0000000180F2D760
	// [XID] // 0x0000000189775590-0x00000001897755B0
	private void UpdateScenePlayBar(float value, float max, uint stage) {} // 0x0000000180F647A0-0x0000000180F64B30
	// [XID] // 0x000000018977CDF0-0x000000018977CE10
	private void InitScenePlayCountDown(ulong beginTime, ulong endTime) {} // 0x0000000180F30860-0x0000000180F30A60
	// [XID] // 0x0000000189784830-0x0000000189784850
	private void TickScenePlayView() {} // 0x0000000180F456E0-0x0000000180F45940
	// [XID] // 0x000000018978BD80-0x000000018978BDA0
	private void OnStartChargeCountDown(uint skillId) {} // 0x0000000180F39730-0x0000000180F39910
	// [XID] // 0x0000000189793230-0x0000000189793250
	private void OnInterruptChargeCountDown(uint skillId) {} // 0x0000000180F34120-0x0000000180F342D0
	// [XID] // 0x000000018979B500-0x000000018979B520
	private void OnScenePlayUidOpNotify() {} // 0x0000000180F3BEA0-0x0000000180F3C4D0
	// [XID] // 0x00000001897A29C0-0x00000001897A29E0
	private void ClearScenePlay() {} // 0x0000000180F610F0-0x0000000180F611F0
	// [XID] // 0x00000001897A9F20-0x00000001897A9F40
	private void InitTeamButton() {} // 0x0000000180F55260-0x0000000180F555C0
	// [XID] // 0x00000001897B1910-0x00000001897B1930
	private void SetupMPTeamPanel() {} // 0x0000000180F44AF0-0x0000000180F44FF0
	// [XID] // 0x00000001897B9370-0x00000001897B9390
	private void RefreshCompanionAvatarIcon(MonoMPTeamBtn teamBtn, List<uint> playerList, int playerIndex) {} // 0x0000000180F666E0-0x0000000180F66A20
	// [XID] // 0x00000001897C1400-0x00000001897C1420
	private void SetFirstAvatar(MonoMPTeamBtn teamBtn, AvatarDataItem avatarData) {} // 0x0000000180F5F6D0-0x0000000180F5F980
	// [XID] // 0x00000001897C8E80-0x00000001897C8EA0
	private void SetSecondAvatar(MonoMPTeamBtn teamBtn, AvatarDataItem avatarData) {} // 0x0000000180F58340-0x0000000180F584F0
	// [XID] // 0x00000001897D04C0-0x00000001897D04E0
	private void OnCompanionCurrAvatarChanged(uint uid) {} // 0x0000000180F41850-0x0000000180F41A60
	// [XID] // 0x00000001897D81E0-0x00000001897D8200
	private void OnCompanionAvatarHPChanged(ulong avatarGuid) {} // 0x0000000180F499A0-0x0000000180F49B40
	// [XID] // 0x00000001897DF2A0-0x00000001897DF2C0
	private void RefreshTeamEnergySkill(ulong avatarGuid) {} // 0x0000000180F367B0-0x0000000180F36910
	// [XID] // 0x00000001897E6B60-0x00000001897E6B80
	private void ChangeAvatar(ulong guid) {} // 0x0000000180F6E670-0x0000000180F6E9F0
	// [XID] // 0x00000001897EE6D0-0x00000001897EE6F0
	public void UpdateTeam(List<ulong> avatarIDList, ulong currentAvatar) {} // 0x0000000180F35300-0x0000000180F356F0
	// [XID] // 0x00000001897F5F40-0x00000001897F5F60
	public void ToggleHideTeamBtnName() {} // 0x0000000180F3D4B0-0x0000000180F3DAC0
	// [XID] // 0x00000001897FD660-0x00000001897FD680
	private void SetupTeamButton(MonoTeamBtn button, int i, ulong avatarGUID, bool isLocal, bool needKey = false /* Metadata: 0x00B1000A */) {} // 0x0000000180F36DF0-0x0000000180F37440
	// [XID] // 0x0000000189804CA0-0x0000000189804CC0
	private void SetupInReactivated(ulong currAvatarGUID) {} // 0x0000000180F611F0-0x0000000180F61450
	// [XID] // 0x000000018981B510-0x000000018981B530
	public void RefreshTeamButtonValue(uint refreshMask) {} // 0x0000000180F37E00-0x0000000180F37F00
	// [XID] // 0x0000000189822B80-0x0000000189822BA0
	public void RefreshTeamButtonBuff(uint runtimeID) {} // 0x0000000180F42630-0x0000000180F42730
	// [XID] // 0x000000018982A4B0-0x000000018982A4D0
	private void RefreshTeamSpeech(uint runtimeId, bool isSpeech) {} // 0x0000000180F5D1C0-0x0000000180F5D320
	// [XID] // 0x0000000189831800-0x0000000189831820
	public void OnEnergyFullNotify_TeamPanel(uint avatarID, bool full) {} // 0x0000000180F3F900-0x0000000180F3FAB0
	// [XID] // 0x0000000189838EE0-0x0000000189838F00
	public void RefreshUISetting(bool showCDText) {} // 0x0000000180F66540-0x0000000180F66650
	// [XID] // 0x0000000189840560-0x0000000189840580
	private void OnTeamButtonClicked(ulong avatarGuid) {} // 0x0000000180F2A320-0x0000000180F2A750
	// [XID] // 0x0000000189847B10-0x0000000189847B30
	private void OnTeamAvatarLevelUp(Tuple<ulong, uint, int, int> avatarLevelUpInfo) {} // 0x0000000180F3EB20-0x0000000180F3EDE0
	// [XID] // 0x000000018984F280-0x000000018984F2A0
	private void OnTeamFetterAdded(Tuple<ulong, uint, uint, uint> fetterInfoChanged) {} // 0x0000000180F48EE0-0x0000000180F49340
	// [XID] // 0x00000001898563E0-0x0000000189856400
	private void PostFetterUpVoice(uint level) {} // 0x0000000180F49B40-0x0000000180F49EF0
	// [XID] // 0x000000018985D7D0-0x000000018985D7F0
	private void ClearOnTransport_TeamPanel() {} // 0x0000000180F52A20-0x0000000180F52BB0
	// [XID] // 0x00000001898650F0-0x0000000189865110
	private void UpdateTeamButtonLifeState(ulong avatarGUID) {} // 0x0000000180F2E240-0x0000000180F2E3F0
	// [XID] // 0x000000018986C650-0x000000018986C670
	private void OnTeamRttRefresh(Dictionary<uint, uint> rttDict) {} // 0x0000000180F33190-0x0000000180F33480
	// [XID] // 0x0000000189873AA0-0x0000000189873AC0
	public void OnRefreshNickname() {} // 0x0000000180F4CB90-0x0000000180F4CE60
	// [XID] // 0x000000018987B530-0x000000018987B550
	public void EnqueueWidgetContext(ContextQueueType queueType, BaseContext context) {} // 0x0000000180F2B1E0-0x0000000180F2B600
	// [XID] // 0x00000001898826B0-0x00000001898826D0
	private void DequeueWidgetContext(ContextQueueType queueType, string contextName) {} // 0x0000000180F5CBA0-0x0000000180F5D070
	// [XID] // 0x0000000189889EA0-0x0000000189889EC0
	private void ClearWidgetQueue() {} // 0x0000000180F2E3F0-0x0000000180F2E590
	// [XID] // 0x0000000189891300-0x0000000189891320
	private int GetQueueCount() => default; // 0x0000000180F64600-0x0000000180F647A0
	// [XID] // 0x0000000189898910-0x0000000189898930
	private bool IsInWidgetQueue(BaseContext context) => default; // 0x0000000180F4D7E0-0x0000000180F4D910
	// [XID] // 0x000000018989FB50-0x000000018989FB70
	public void ShowTaskTraceNavigation() {} // 0x0000000180F65D10-0x0000000180F65EB0
	// [XID] // 0x00000001898A7580-0x00000001898A75A0
	public override void SetActive(bool enabled) {} // 0x0000000180F6EB70-0x0000000180F6F1A0
}

