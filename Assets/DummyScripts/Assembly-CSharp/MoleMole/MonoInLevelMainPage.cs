/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoInLevelMainPage : MonoUIProxy // TypeDefIndex: 29747
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoInLevelGameInfo _gameInfo; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _talkPanelContainer; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _messagePushAnimator; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _talkPanelPrefab; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoTeamButtonContainer _teamBtnContainer; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoMiniMap _miniMap; // 0x68
		public GameObject mapInfo; // 0x70
		public GameObject grpMainBtn; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _bubblePanelContainer; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _bubblePanelPrefab; // 0x88
		// [Header] // 0x000000018990F650-0x000000018990F6A0
		[SerializeField] // 0x000000018990F650-0x000000018990F6A0
		private Button _playerListToggle; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _playerListDisableGrp; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _onlineTeam; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _onlineMatching; // 0xA8
		// [Header] // 0x0000000189931CC0-0x0000000189931D10
		[SerializeField] // 0x0000000189931CC0-0x0000000189931D10
		private Button _questDialogToggle; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _characterPageToggle; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _characterPageSprite; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _bagPageToggle; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _gachaPageToggle; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _homeowrldPageToggle; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _activityPageToggle; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _profileButton; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _guideButton; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _guideButtonEff; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _exitDungeonButton; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _toggleFactorInfoButton; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _toggleRestrictionInfoButton; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _toggleElementInfoButton; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _toggleClimateInfoButton; // 0x120
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _toggleFactorEffect; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _toggleElementTrialEffect; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _handbookButton; // 0x138
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _homeworldHandbookButton; // 0x140
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _activityNormalButton; // 0x148
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _battlePassButton; // 0x150
		private GameObject _transBtn; // 0x158
		private MonoReturnToQuestBtn _returnToQuestBtn; // 0x160
		private Button _transButton; // 0x168
		private Animator _transBtnAnim; // 0x170
		private Transform _transBtnKeyPC; // 0x178
		private MonoMessagePushTips _tutorialPushTips; // 0x180
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoInteePanel _inteePanel; // 0x188
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoInputEasyTouch_H4 _inputEasyTouch; // 0x190
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoJoyStick_H4 _joyStick; // 0x198
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoInLevelRTT _monoSelfRtt; // 0x1A0
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoPlayerListPanel _playerListPanel; // 0x1A8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoPrefabPlugin _prefabPlugin; // 0x1B0
		private MonoGrpConversation _talkPanel; // 0x1B8
		private MonoGrpConversation _bubblePanel; // 0x1C0
		private MonoDungeonProgressBar _dungeonProgressBar; // 0x1C8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _discoverContainer; // 0x1D0
		public List<GameObject> panelMaskList; // 0x1D8
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoArrowPointContainer _arrowPointContainer; // 0x1E0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _inputPanelContainer; // 0x1E8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _aimContainer; // 0x1F0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _wheelMenuChargeTime; // 0x1F8
		public GameObject topSpaceHolder; // 0x200
		private ActionPanelState _currentActionPanelState; // 0x210
		public bool isTalkShow; // 0x214
		public bool isWarningTalkShow; // 0x215
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoActionPanelContainer _actionPanelContainer; // 0x218
		private const string DUNGEON_COUNT_DOWN = "DungeonCountDown"; // Metadata: 0x00B0FD8C
		private MonoQuestHintText _questHint; // 0x220
		private MonoCombatBars _combatBars; // 0x228
		public MonoElementChargeBar _elementChargeBar; // 0x230
		private float _currHPRatio; // 0x238
		private float _currShieldRatio; // 0x23C
		private float _currElementShieldRatio; // 0x240
		private string _combatBarPluginName; // 0x248
		private int _currLevel; // 0x250
		private int _currIndex; // 0x254
		private ElementType _currElementType; // 0x258
		private MonoInLevelProgressBar _inLevelProgressBar; // 0x260
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private float _dungeonItemDestroyTime; // 0x268
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Button _moveRunBtn; // 0x270
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _moveWalkBtn; // 0x278
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _moveToggle; // 0x280
		// [Header] // 0x0000000189A6AA80-0x0000000189A6AAC0
		[SerializeField] // 0x0000000189A6AA80-0x0000000189A6AAC0
		private Toggle _elemViewButton; // 0x288
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _gmButton; // 0x290
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _testShakeOffButton; // 0x298
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoControlElement _controlElement; // 0x2A0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _feedbackButton; // 0x2A8
		public Button chatBtn; // 0x2B0
		public GameObject chatBtnDot; // 0x2B8
		public GameObject chatPanel; // 0x2C0
		private static int _virtualDialShow; // 0x00
		private MonoVersusBattle _versusBattle; // 0x2C8
		private Transform _activityAnim; // 0x2D0
		private MonoTowerHintText _towerHintText; // 0x2D8
		private UnityAction<MonoTowerHintText> _towerLoadCallBack; // 0x2E0
		private const string GADGET_PLAY_BAR = "ElementCharge"; // Metadata: 0x00B0FDA0
		private const string GADGET_PLAY_COUNT_DOWN = "DungeonCountDown"; // Metadata: 0x00B0FDB1
		private const string EVENT_PROMPT_TOP = "EventPromptTop"; // Metadata: 0x00B0FDC5
		private const string BONUS_BAR = "BonusBar"; // Metadata: 0x00B0FDD7
		private const string GADGET_PLAY_BANNER = "GadgetPlayBanner"; // Metadata: 0x00B0FDE3
		private const string ACTIVITY_BAR = "ActivityBar"; // Metadata: 0x00B0FDF7
		private const string TEMPLATE_REMINDER = "EventPromptDown"; // Metadata: 0x00B0FE06
		private const string CHARGE_COUNT_DOWN = "ChargeCountDown"; // Metadata: 0x00B0FE19
		private const string HUNTING_PLAY_COUNT_DOWN = "HuntingCountDown"; // Metadata: 0x00B0FE2C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _toggleMechanicusInfoBtn; // 0x330
	
		// Properties
		public MonoInLevelGameInfo gameInfo { /* [XID] */ /* 0x0000000189AFB400-0x0000000189AFB420 */ get => default; } // 0x0000000183D66330-0x0000000183D663D0 
		public float wheelMenuChargeTime { /* [XID] */ /* 0x0000000189B02AC0-0x0000000189B02AE0 */ get => default; } // 0x0000000183D680D0-0x0000000183D68180 
		public RectTransform aimContainer { /* [XID] */ /* 0x0000000189B0A310-0x0000000189B0A330 */ get => default; } // 0x0000000183D65320-0x0000000183D653D0 
		public GameObject messagePushContainer { /* [XID] */ /* 0x0000000189B11AD0-0x0000000189B11AF0 */ get => default; } // 0x0000000183D66BC0-0x0000000183D66CC0 
		public Button questDialogToggle { /* [XID] */ /* 0x0000000189B18DA0-0x0000000189B18DC0 */ get => default; } // 0x0000000183D672E0-0x0000000183D67390 
		public Button characterPageToggle { /* [XID] */ /* 0x0000000189B203F0-0x0000000189B20410 */ get => default; } // 0x0000000183D656F0-0x0000000183D657A0 
		public Image characterPageSprite { /* [XID] */ /* 0x0000000189B27A70-0x0000000189B27A90 */ get => default; } // 0x0000000183D65640-0x0000000183D656F0 
		public Button bagPageToggle { /* [XID] */ /* 0x0000000189B2EDB0-0x0000000189B2EDD0 */ get => default; } // 0x0000000183D65480-0x0000000183D65530 
		public Button gachaPageToggle { /* [XID] */ /* 0x0000000189B36630-0x0000000189B36650 */ get => default; } // 0x0000000183D66160-0x0000000183D66210 
		public Button homeworldPageToggle { /* [XID] */ /* 0x0000000189B3DE90-0x0000000189B3DEB0 */ get => default; } // 0x0000000183D66740-0x0000000183D667F0 
		public Button profileButton { /* [XID] */ /* 0x0000000189B45C30-0x0000000189B45C50 */ get => default; } // 0x0000000183D67230-0x0000000183D672E0 
		public Button guideButton { /* [XID] */ /* 0x0000000189B4D0B0-0x0000000189B4D0D0 */ get => default; } // 0x0000000183D66530-0x0000000183D665E0 
		public GameObject guideButtonEff { /* [XID] */ /* 0x0000000189B54890-0x0000000189B548B0 */ get => default; } // 0x0000000183D66480-0x0000000183D66530 
		public Button exitDungeonButton { /* [XID] */ /* 0x0000000189B5C470-0x0000000189B5C490 */ get => default; } // 0x0000000183D66000-0x0000000183D660B0 
		public Button toggleFactorInfoButton { /* [XID] */ /* 0x0000000189B639A0-0x0000000189B639C0 */ get => default; } // 0x0000000183D67920-0x0000000183D679D0 
		public Button toggleRestrictionInfoButton { /* [XID] */ /* 0x0000000189B6B1A0-0x0000000189B6B1C0 */ get => default; } // 0x0000000183D67A80-0x0000000183D67B30 
		public Button toggleElementInfoButton { /* [XID] */ /* 0x0000000189B727E0-0x0000000189B72800 */ get => default; } // 0x0000000183D67870-0x0000000183D67920 
		public Button toggleClimateInfoButton { /* [XID] */ /* 0x0000000189B79D10-0x0000000189B79D30 */ get => default; } // 0x0000000183D677C0-0x0000000183D67870 
		public Button handbookButton { /* [XID] */ /* 0x0000000189B81460-0x0000000189B81480 */ get => default; } // 0x0000000183D665E0-0x0000000183D66690 
		public Button homeworldHandbookButton { /* [XID] */ /* 0x0000000189B88BB0-0x0000000189B88BD0 */ get => default; } // 0x0000000183D66690-0x0000000183D66740 
		public Button activityNormalButton { /* [XID] */ /* 0x0000000189B900A0-0x0000000189B900C0 */ get => default; } // 0x0000000183D651C0-0x0000000183D65270 
		public Button battlePassButton { /* [XID] */ /* 0x0000000189B974E0-0x0000000189B97500 */ get => default; } // 0x0000000183D65530-0x0000000183D655E0 
		public Button activityPageToggle { /* [XID] */ /* 0x0000000189B9E920-0x0000000189B9E940 */ get => default; } // 0x0000000183D65270-0x0000000183D65320 
		public RectTransform inputPanelContainer { /* [XID] */ /* 0x0000000189BA62B0-0x0000000189BA62D0 */ get => default; } // 0x0000000183D669B0-0x0000000183D66A60 
		public MonoInLevelRTT selfRtt { /* [XID] */ /* 0x0000000189BAD560-0x0000000189BAD580 */ get => default; } // 0x0000000183D67560-0x0000000183D67610 
		private GameObject transBtn { /* [XID] */ /* 0x0000000189BB4CB0-0x0000000189BB4CD0 */ get => default; } // 0x0000000183D5E940-0x0000000183D5EA70 
		public MonoReturnToQuestBtn returnToQuestBtn { /* [XID] */ /* 0x0000000189BBC2E0-0x0000000189BBC300 */ get => default; } // 0x0000000183D67440-0x0000000183D67560 
		public Button transButton { /* [XID] */ /* 0x0000000189BC3FE0-0x0000000189BC4000 */ get => default; } // 0x0000000183D67D80-0x0000000183D67F30 
		public Animator transBtnAnim { /* [XID] */ /* 0x0000000189BCB990-0x0000000189BCB9B0 */ get => default; } // 0x0000000183D67B30-0x0000000183D67C50 
		public Transform transBtnKeyPC { /* [XID] */ /* 0x0000000189BD2F00-0x0000000189BD2F20 */ get => default; } // 0x0000000183D67C50-0x0000000183D67D80 
		public MonoMessagePushTips tutorialPushTips { /* [XID] */ /* 0x0000000189BDA6E0-0x0000000189BDA700 */ get => default; } // 0x0000000183D67F30-0x0000000183D680D0 
		public Button playerListToggle { /* [XID] */ /* 0x00000001895E7090-0x00000001895E70B0 */ get => default; } // 0x0000000183D67180-0x0000000183D67230 
		public bool showPlayerListToggleButton { /* [XID] */ /* 0x00000001895EE9E0-0x00000001895EEA00 */ set {} } // 0x0000000183D683D0-0x0000000183D684D0
		public RectTransform onlineMatching { /* [XID] */ /* 0x0000000189604FA0-0x0000000189604FC0 */ get => default; } // 0x0000000183D66F70-0x0000000183D67020 
		public RectTransform onlineTeam { /* [XID] */ /* 0x000000018960CA10-0x000000018960CA30 */ get => default; } // 0x0000000183D67020-0x0000000183D670D0 
		public MonoTeamButtonContainer teamButtonContainer { /* [XID] */ /* 0x0000000189613F80-0x0000000189613FA0 */ get => default; } // 0x0000000183D67610-0x0000000183D676B0 
		public MonoJoyStick_H4 joystick { /* [XID] */ /* 0x000000018961B8E0-0x000000018961B900 */ get => default; } // 0x0000000183D66B10-0x0000000183D66BC0 
		public MonoDungeonProgressBar dungeonProgressBar { /* [XID] */ /* 0x0000000189622EA0-0x0000000189622EC0 */ get => default; } // 0x0000000183D65DD0-0x0000000183D65EF0 
		public Transform discoverContainer { /* [XID] */ /* 0x000000018962A670-0x000000018962A690 */ get => default; } // 0x0000000183D65B50-0x0000000183D65C00 
		public MonoDungeonCountDown dungeonCountDown { /* [XID] */ /* 0x0000000189631DD0-0x0000000189631E10 */ get; /* [XID] */ /* 0x000000018963C9C0-0x000000018963CA00 */ private set; } // 0x0000000183D65C00-0x0000000183D65C60 0x0000000183D5E8D0-0x0000000183D5E940
		public MonoArrowPointContainer arrowPointContainer { /* [XID] */ /* 0x00000001896470A0-0x00000001896470C0 */ get => default; } // 0x0000000183D653D0-0x0000000183D65480 
		public ActionPanelState currentActionPanelState { /* [XID] */ /* 0x000000018965D780-0x000000018965D7A0 */ get => default; } // 0x0000000183D65AB0-0x0000000183D65B50 
		public MonoInteePanel inteePanel { /* [XID] */ /* 0x00000001896CD540-0x00000001896CD560 */ get => default; } // 0x0000000183D66A60-0x0000000183D66B10 
		public MonoInputEasyTouch_H4 inputEasyTouch { /* [XID] */ /* 0x00000001896D4990-0x00000001896D49B0 */ get => default; } // 0x0000000183D66900-0x0000000183D669B0 
		public MonoActionPanelContainer actionPanelContainer { /* [XID] */ /* 0x00000001896DC010-0x00000001896DC030 */ get => default; } // 0x0000000183D650B0-0x0000000183D65160 
		public MonoMiniMap miniMap { /* [XID] */ /* 0x00000001896EABB0-0x00000001896EABD0 */ get => default; } // 0x0000000183D66CC0-0x0000000183D66D60 
		public MonoPlayerListPanel playerListPanel { /* [XID] */ /* 0x00000001896F1F60-0x00000001896F1F80 */ get => default; } // 0x0000000183D670D0-0x0000000183D67180 
		public MonoQuestHintText questHint { /* [XID] */ /* 0x0000000189717530-0x0000000189717550 */ get => default; } // 0x0000000183D67390-0x0000000183D67440 
		public MonoCombatBars combatBars { /* [XID] */ /* 0x000000018971F030-0x000000018971F050 */ get => default; } // 0x0000000183D65950-0x0000000183D65A00 
		public bool showCombatBars { /* [XID] */ /* 0x000000018975A690-0x000000018975A6B0 */ set {} } // 0x0000000183D682F0-0x0000000183D683D0
		public MonoInLevelProgressBar inLevelProgressBar { /* [XID] */ /* 0x0000000189762340-0x0000000189762360 */ get => default; } // 0x0000000183D66850-0x0000000183D66900 
		public float dungeonItemDestroyTime { /* [XID] */ /* 0x0000000189770F10-0x0000000189770F30 */ get => default; } // 0x0000000183D65C60-0x0000000183D65D10 
		public Transform dungeonItemWidget { /* [XID] */ /* 0x0000000189778820-0x0000000189778840 */ get => default; } // 0x0000000183D65D10-0x0000000183D65DD0 
		public Button moveRunBtn { /* [XID] */ /* 0x0000000189787640-0x0000000189787660 */ get => default; } // 0x0000000183D66D60-0x0000000183D66E10 
		public Button moveWalkBtn { /* [XID] */ /* 0x000000018978ECB0-0x000000018978ECD0 */ get => default; } // 0x0000000183D66EC0-0x0000000183D66F70 
		public GameObject moveToggle { /* [XID] */ /* 0x0000000189796420-0x0000000189796440 */ get => default; } // 0x0000000183D66E10-0x0000000183D66EC0 
		public Toggle elemViewButton { /* [XID] */ /* 0x000000018979E550-0x000000018979E570 */ get => default; } // 0x0000000183D65EF0-0x0000000183D65FA0 
		public MonoControlElement controlElement { /* [XID] */ /* 0x00000001897A5CF0-0x00000001897A5D10 */ get => default; } // 0x0000000183D65A00-0x0000000183D65AB0 
		public MonoMainPageChatDisplayer chatDisplayer { /* [XID] */ /* 0x00000001897AD260-0x00000001897AD280 */ get => default; } // 0x0000000183D65800-0x0000000183D65950 
		public Button gmButton { /* [XID] */ /* 0x00000001897B52D0-0x00000001897B52F0 */ get => default; } // 0x0000000183D663D0-0x0000000183D66480 
		public Button testShakeOffBtn { /* [XID] */ /* 0x00000001897BCF40-0x00000001897BCF60 */ get => default; } // 0x0000000183D67710-0x0000000183D677C0 
		public Button feedbackButton { /* [XID] */ /* 0x00000001897C4280-0x00000001897C42A0 */ get => default; } // 0x0000000183D660B0-0x0000000183D66160 
		public bool showActivityAnim { /* [XID] */ /* 0x00000001897F9120-0x00000001897F9140 */ set {} } // 0x0000000183D68180-0x0000000183D682F0
		public MonoElementChargeBar gadgetPlayBar { /* [XID] */ /* 0x000000018981E5B0-0x000000018981E5F0 */ get; /* [XID] */ /* 0x0000000189828C90-0x0000000189828CD0 */ private set; } // 0x0000000183D66270-0x0000000183D662D0 0x0000000183D619E0-0x0000000183D61A50
		public MonoDungeonCountDown gadgetPlayCountDown { /* [XID] */ /* 0x0000000189841C40-0x0000000189841C80 */ get; /* [XID] */ /* 0x000000018984C2A0-0x000000018984C2E0 */ private set; } // 0x0000000183D662D0-0x0000000183D66330 0x0000000183D61B80-0x0000000183D61BF0
		public MonoCommonDescRow eventPromptTop { /* [XID] */ /* 0x0000000189865150-0x0000000189865190 */ get; /* [XID] */ /* 0x000000018986F590-0x000000018986F5D0 */ private set; } // 0x0000000183D65FA0-0x0000000183D66000 0x0000000183D61D10-0x0000000183D61D80
		public MonoBonusBar bonusBar { /* [XID] */ /* 0x00000001898887E0-0x0000000189888820 */ get; /* [XID] */ /* 0x0000000189892C10-0x0000000189892C50 */ private set; } // 0x0000000183D655E0-0x0000000183D65640 0x0000000183D5EC50-0x0000000183D5ECC0
		public MonoDungeonChallenge gadgetPlayBanner { /* [XID] */ /* 0x00000001898ABC40-0x00000001898ABC80 */ get; /* [XID] */ /* 0x00000001898B6430-0x00000001898B6470 */ private set; } // 0x0000000183D66210-0x0000000183D66270 0x0000000183D5ECC0-0x0000000183D5ED30
		public MonoActivityBar activityBar { /* [XID] */ /* 0x00000001898D0120-0x00000001898D0160 */ get; /* [XID] */ /* 0x00000001898DA5E0-0x00000001898DA620 */ private set; } // 0x0000000183D65160-0x0000000183D651C0 0x0000000183D61D80-0x0000000183D61DF0
		public MonoCommonDescRow templateReminder { /* [XID] */ /* 0x00000001898F43F0-0x00000001898F4430 */ get; /* [XID] */ /* 0x00000001898FEC60-0x00000001898FECA0 */ private set; } // 0x0000000183D676B0-0x0000000183D67710 0x0000000183D62350-0x0000000183D623C0
		public MonoChargeCountDown chargeCountDown { /* [XID] */ /* 0x0000000189910A60-0x0000000189910AA0 */ get; /* [XID] */ /* 0x000000018991B900-0x000000018991B940 */ private set; } // 0x0000000183D657A0-0x0000000183D65800 0x0000000183D60DE0-0x0000000183D60E50
		public MonoDungeonCountDown huntingPlayCountDown { /* [XID] */ /* 0x0000000189943C90-0x0000000189943CD0 */ get; /* [XID] */ /* 0x000000018994E1C0-0x000000018994E200 */ private set; } // 0x0000000183D667F0-0x0000000183D66850 0x0000000183D61250-0x0000000183D612C0
		public Button toggleMechanicusInfoBtn { /* [XID] */ /* 0x0000000189967BD0-0x0000000189967BF0 */ get => default; } // 0x0000000183D679D0-0x0000000183D67A80 
	
		// Constructors
		public MonoInLevelMainPage() {} // 0x0000000183D64DD0-0x0000000183D650B0
		static MonoInLevelMainPage() {} // 0x0000000183D64D60-0x0000000183D64DD0
	
		// Methods
		// [XID] // 0x00000001895F63E0-0x00000001895F6400
		public void SetPlayerListNormal() {} // 0x0000000183D62A20-0x0000000183D62AF0
		// [XID] // 0x00000001895FD710-0x00000001895FD730
		public void SetPlayerListDisable() {} // 0x0000000183D62950-0x0000000183D62A20
		// [XID] // 0x000000018964E7B0-0x000000018964E7D0
		protected void Awake() {} // 0x0000000183D5E780-0x0000000183D5E8D0
		// [XID] // 0x0000000189655FC0-0x0000000189655FE0
		public void OnAvatarChange(LCAvatarCombat combat) {} // 0x0000000183D61EC0-0x0000000183D62040
		// [XID] // 0x0000000189664EA0-0x0000000189664EC0
		public void OnActionPanelStateChanged(ActionPanelState state) {} // 0x0000000183D61DF0-0x0000000183D61EC0
		// [XID] // 0x000000018966C4E0-0x000000018966C500
		public void ClearInDeactivated() {} // 0x0000000183D5FA30-0x0000000183D5FAE0
		// [XID] // 0x00000001896743A0-0x00000001896743C0
		public void RefreshGameInfo(uint refreshMask) {} // 0x0000000183D62600-0x0000000183D626C0
		// [XID] // 0x000000018967BB60-0x000000018967BB80
		public void RefreshBuffInfo(uint runtimeID) {} // 0x0000000183D623C0-0x0000000183D62480
		// [XID] // 0x0000000189683230-0x0000000189683250
		public void InterruptSprintButton() {} // 0x0000000183D617F0-0x0000000183D618A0
		// [XID] // 0x000000018968AD60-0x000000018968AD80
		public void ShowTalkPanel(string talkerName, string content) {} // 0x0000000183D62F90-0x0000000183D630D0
		// [XID] // 0x00000001896929E0-0x0000000189692A00
		public void HideTalkPanel() {} // 0x0000000183D615F0-0x0000000183D616F0
		// [XID] // 0x0000000189699D80-0x0000000189699DA0
		private void SetTalkPanelTitleShow(bool active) {} // 0x0000000183D613F0-0x0000000183D61500
		// [XID] // 0x00000001896A14E0-0x00000001896A1500
		public void SetTalkPanelStyle(bool moveUp) {} // 0x0000000183D62AF0-0x0000000183D62C00
		// [XID] // 0x00000001896A8980-0x00000001896A89A0
		public void ShowWarningTalkPanel(string talkerName, string content) {} // 0x0000000183D630D0-0x0000000183D63210
		// [XID] // 0x00000001896AFB00-0x00000001896AFB20
		public void HideWarningTalkPanel() {} // 0x0000000183D616F0-0x0000000183D617F0
		// [XID] // 0x00000001896B7470-0x00000001896B7490
		public void ShowBubbleTalk(string talkerName, string content) {} // 0x0000000183D62CC0-0x0000000183D62E00
		// [XID] // 0x00000001896BE5A0-0x00000001896BE5C0
		public void HideBubbleTalkPanel() {} // 0x0000000183D61500-0x0000000183D615F0
		// [XID] // 0x00000001896C5E10-0x00000001896C5E30
		public void RefreshUISetting(UserLocalDataItem userLocalData) {} // 0x0000000183D626C0-0x0000000183D62790
		// [XID] // 0x00000001896E3780-0x00000001896E37A0
		public void SetupActionPanel(ActionPanelType type) {} // 0x0000000183D62C00-0x0000000183D62CC0
		// [XID] // 0x00000001896F9920-0x00000001896F9940
		public void CreateDungeonCountDown() {} // 0x0000000183D60090-0x0000000183D60230
		// [XID] // 0x0000000189701150-0x0000000189701170
		public void ClearDungeonCountDown() {} // 0x0000000183D5F1B0-0x0000000183D5F2B0
		// [XID] // 0x0000000189708840-0x0000000189708860
		public void OnDisconnect() {} // 0x0000000183D62040-0x0000000183D62170
		// [XID] // 0x0000000189710150-0x0000000189710170
		public MonoQuestHintText GetOrCreateQuestHint() => default; // 0x0000000183D612C0-0x0000000183D613F0
		// [XID] // 0x0000000189726630-0x0000000189726650
		public void DestroyCurrCombatBar() {} // 0x0000000183D60EF0-0x0000000183D610F0
		// [XID] // 0x000000018972DB50-0x000000018972DB70
		public void RefreshCombatBarBuff(uint entityID) {} // 0x0000000183D62480-0x0000000183D62600
		// [XID] // 0x0000000189735310-0x0000000189735330
		public void TryCreateTopBars(VCCombatBillboardPlugin combat) {} // 0x0000000183D64300-0x0000000183D643D0
		// [XID] // 0x000000018973CD70-0x000000018973CD90
		public void TryCreateElementBars(VCCombatBillboardPlugin combat) {} // 0x0000000183D63FD0-0x0000000183D641E0
		// [XID] // 0x00000001897442B0-0x00000001897442D0
		public void UpdateElementCharge(VCCombatBillboardPlugin _activeCombat) {} // 0x0000000183D64B50-0x0000000183D64D60
		// [XID] // 0x000000018974BF90-0x000000018974BFB0
		public void TryCreateCombatBars(VCCombatBillboardPlugin combat) {} // 0x0000000183D63210-0x0000000183D63FD0
		// [XID] // 0x00000001897532D0-0x00000001897532F0
		public void UpdateCombatBars(VCCombatBillboardPlugin _activeCombat) {} // 0x0000000183D64610-0x0000000183D64B50
		// [XID] // 0x0000000189769940-0x0000000189769960
		public void TryCreateInLevelProgressBar() {} // 0x0000000183D641E0-0x0000000183D64300
		// [XID] // 0x000000018977FD60-0x000000018977FD80
		public void DestroyDungeonItemWidget() {} // 0x0000000183D610F0-0x0000000183D611B0
		// [XID] // 0x00000001897CBB00-0x00000001897CBB20
		public void OnVirtualDailShow() {} // 0x0000000183D62170-0x0000000183D62260
		// [XID] // 0x00000001897D3410-0x00000001897D3430
		public void OnVirtualDialHide() {} // 0x0000000183D62260-0x0000000183D62350
		// [XID] // 0x00000001897DAE90-0x00000001897DAEB0
		public void SetPanelMask(bool active) {} // 0x0000000183D62790-0x0000000183D62950
		// [XID] // 0x00000001897E25A0-0x00000001897E25C0
		public MonoVersusBattle TryCreateVersusBattle() => default; // 0x0000000183D643D0-0x0000000183D64500
		// [XID] // 0x00000001897E9D50-0x00000001897E9D70
		public bool IsVersusBattleActive(out MonoVersusBattle ins) {
			ins = default;
			return default;
		} // 0x0000000183D618A0-0x0000000183D619E0
		// [XID] // 0x00000001897F19B0-0x00000001897F19D0
		public void TryDestroyVersusBattle() {} // 0x0000000183D64500-0x0000000183D64610
		// [XID] // 0x0000000189800730-0x0000000189800750
		public void CreateTowerHint(UnityAction<MonoTowerHintText> loadCallback) {} // 0x0000000183D60C70-0x0000000183D60DE0
		// [XID] // 0x0000000189807DD0-0x0000000189807DF0
		private void TowerLoadCallBack(Transform trans) {} // 0x0000000183D61BF0-0x0000000183D61D10
		// [XID] // 0x000000018980F6B0-0x000000018980F6D0
		private void OnActionPanelViewChange() {} // 0x0000000183D5EA70-0x0000000183D5EC50
		// [XID] // 0x0000000189816D60-0x0000000189816D80
		public void ClearTowerHint() {} // 0x0000000183D5FAE0-0x0000000183D5FBB0
		// [XID] // 0x00000001898331B0-0x00000001898331D0
		public void CreateGagdetPlayBar() {} // 0x0000000183D60570-0x0000000183D60710
		// [XID] // 0x000000018983A660-0x000000018983A680
		public void ClearGagdetPlayBar() {} // 0x0000000183D5F5B0-0x0000000183D5F730
		// [XID] // 0x0000000189856440-0x0000000189856460
		public MonoDungeonCountDown CreateGagdetPlayCountDown() => default; // 0x0000000183D60710-0x0000000183D608F0
		// [XID] // 0x000000018985D830-0x000000018985D850
		public void ClearGagdetPlayCountDown() {} // 0x0000000183D5F730-0x0000000183D5F8B0
		// [XID] // 0x000000018987A070-0x000000018987A090
		public void CreateEventPromptTop() {} // 0x0000000183D60230-0x0000000183D603D0
		// [XID] // 0x0000000189881230-0x0000000189881250
		public void ClearEventPromptTop() {} // 0x0000000183D5F2B0-0x0000000183D5F430
		// [XID] // 0x000000018989CF80-0x000000018989CFA0
		public void CreateBonusBar() {} // 0x0000000183D5FD50-0x0000000183D5FEF0
		// [XID] // 0x00000001898A47C0-0x00000001898A47E0
		public void ClearBonusBar() {} // 0x0000000183D5EEB0-0x0000000183D5F030
		// [XID] // 0x00000001898C0E30-0x00000001898C0E50
		public void CreateGadgetPlayBanner() {} // 0x0000000183D603D0-0x0000000183D60570
		// [XID] // 0x00000001898C8770-0x00000001898C8790
		public void ClearGadgetPlayBanner() {} // 0x0000000183D5F430-0x0000000183D5F5B0
		// [XID] // 0x00000001898E5290-0x00000001898E52B0
		public void CreateActivityBar() {} // 0x0000000183D5FBB0-0x0000000183D5FD50
		// [XID] // 0x00000001898ECA00-0x00000001898ECA20
		public void ClearActivityBar() {} // 0x0000000183D5ED30-0x0000000183D5EEB0
		// [XID] // 0x00000001899095F0-0x0000000189909610
		public void CreateTemplateReminder() {} // 0x0000000183D60AD0-0x0000000183D60C70
		// [XID] // 0x0000000189926010-0x0000000189926030
		public void CreateChargeCountDown() {} // 0x0000000183D5FEF0-0x0000000183D60090
		// [XID] // 0x000000018992D700-0x000000018992D720
		public void ClearChargeCountDown() {} // 0x0000000183D5F030-0x0000000183D5F1B0
		// [XID] // 0x0000000189934B90-0x0000000189934BB0
		public void showFactorEffect() {} // 0x0000000183D684D0-0x0000000183D68660
		// [XID] // 0x000000018993C660-0x000000018993C680
		public void ShowElementTrialEffect() {} // 0x0000000183D62E00-0x0000000183D62F90
		// [XID] // 0x0000000189958B10-0x0000000189958B30
		public MonoDungeonCountDown CreateHuntingPlayCountDown() => default; // 0x0000000183D608F0-0x0000000183D60AD0
		// [XID] // 0x0000000189960150-0x0000000189960170
		public void ClearHuntingPlayCountDown() {} // 0x0000000183D5F8B0-0x0000000183D5FA30
	}
}
