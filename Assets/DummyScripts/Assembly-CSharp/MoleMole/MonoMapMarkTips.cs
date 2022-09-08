/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoMapMarkTips : MonoBehaviour // TypeDefIndex: 31136
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Animator _animator; // 0x18
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _eventTitleGrp; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _eventTitleLabel; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _eventTitleIcon; // 0x30
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _normalTitleGrp; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _normalTitleLabel; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _normalTitleIcon; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _modBtnGrp; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _modBtn; // 0x58
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _dungeonTabGrp; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _dungeonTabScroll; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _dungeonTabList; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _dungeonEntryImage; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoDungeonTabTip _dungeonDailyTab; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _dungeonPossibleRewardGrp; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _dungeonCoolDownTipsGrp; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _dungeonCoolDownTipsLeftChestGrp; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _dungeonCoolDownTipsLeftChest; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _dungeonCoolDownTipsLeftTimeGrp; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _dungeonCoolDownTipsLeftTime; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _dungeonTips; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _transPointTips; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoWeeklyBossResinDiscountInfo _dungeonWeeklyBossResinDiscountMono; // 0xC8
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _normalDescriptionGrp; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _normalDescriptionLabel; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _normalConditionLabel; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _normalRewardGrp; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _normalRewardTitle; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _normalRewardList; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoScrollRectExtention _normalScroll; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _normalMultiplyRewardGrp; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _normalMultiplyRewarText; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoWeeklyBossResinDiscountInfo _normalWeeklyBossResinDiscountMono; // 0x118
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _normalTimeTipsGrp; // 0x120
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _normalTimeTipsText; // 0x128
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _positionGrp; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _positionText; // 0x138
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _goddessLevelGrp; // 0x140
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _goddessLevelNum; // 0x148
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public UnityEngine.UI.Text GrpMarkerDescriptionLabel; // 0x150
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _eventDescriptionGrp; // 0x158
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _eventDescriptionLabel; // 0x160
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _eventProgressLabel; // 0x168
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		public RectTransform markGrp; // 0x170
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _timeGrp; // 0x178
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _timeLabel; // 0x180
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private GameObject _adventureGrp; // 0x188
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _taskRewardRoot; // 0x190
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _playerRewardRoot; // 0x198
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _advenRewardDescRoot; // 0x1A0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _advenPositionRoot; // 0x1A8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _advenPositionText; // 0x1B0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _forgeRewardRoot; // 0x1B8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _advenExpedRoot; // 0x1C0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _adventureDesc; // 0x1C8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _salesmanRewardRoot; // 0x1D0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _salesmanRewardText; // 0x1D8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _elderTreeRewardRoot; // 0x1E0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _homeworldDjinnRewardRoot; // 0x1E8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _scoreRewardText; // 0x1F0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _scoreRewardRoot; // 0x1F8
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private GameObject _routineGrp; // 0x200
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _routinePositionText; // 0x208
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _routineTypeDescText; // 0x210
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _routineEventTitleText; // 0x218
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _routineEventDescText; // 0x220
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _routineEventGoalText; // 0x228
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _routineRewardText; // 0x230
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _routineRewardList; // 0x238
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private GameObject _reputationRewardDescRoot; // 0x240
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _reputationRewardRoot; // 0x248
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _reputationRewardText; // 0x250
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _activityDescText; // 0x258
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _reputationActivityRequestRoot; // 0x260
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _reputationActivityHuntingRoot; // 0x268
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _reputationHuntingRoot; // 0x270
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _reputationHuntingInfo1; // 0x278
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _reputationHuntingInfo2; // 0x280
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public GameObject customMarkPrefab; // 0x288
		public UnityEngine.UI.Text markName; // 0x290
		public GameObject titleMarkerGO; // 0x298
		public InputField titleMarkerTextInputField; // 0x2A0
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private GameObject _unlockTip; // 0x2A8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _unlockTipText; // 0x2B0
		public GameObject GrpTower; // 0x2B8
		public UnityEngine.UI.Text TowerDesc; // 0x2C0
		public UnityEngine.UI.Text TowerBuffTitle; // 0x2C8
		public UnityEngine.UI.Text TowerCumulative; // 0x2D0
		public UnityEngine.UI.Text TowerStarCount; // 0x2D8
		public UnityEngine.UI.Text TowerRefresh; // 0x2E0
		public UnityEngine.UI.Text TowerProgress; // 0x2E8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _towerEntryImage; // 0x2F0
		// [Header] // 0x0000000189889CB0-0x0000000189889D00
		[SerializeField] // 0x0000000189889CB0-0x0000000189889D00
		private GameObject _rewardCountReviveGrp; // 0x2F8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _rewardCountTextGroup; // 0x300
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rewardCountText; // 0x308
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RewardConsume _rewardConsume; // 0x310
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _reviveCooldownGroup; // 0x318
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _reviveCooldownText; // 0x320
		// [Header] // 0x00000001898C0BD0-0x00000001898C0C10
		[SerializeField] // 0x00000001898C0BD0-0x00000001898C0C10
		private GameObject _recommendElement; // 0x328
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _elementList; // 0x330
		// [Header] // 0x00000001898D42D0-0x00000001898D4320
		[SerializeField] // 0x00000001898D42D0-0x00000001898D4320
		private RectTransform _occupiedTipGrp; // 0x338
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _occupiedTipText; // 0x340
		// [Header] // 0x00000001898E8360-0x00000001898E8390
		public GameObject GrpFleurFair; // 0x348
		public UnityEngine.UI.Text FleurFairTitle; // 0x350
		public UnityEngine.UI.Text FleurFairDesc; // 0x358
		public UnityEngine.UI.Text FleurFairFeatureHint; // 0x360
		public Transform FleurFairFeatureListTrans; // 0x368
		public UnityEngine.UI.Text FleurFairFeatureTitle; // 0x370
		public UnityEngine.UI.Text FleurFairFeatureDesc; // 0x378
		public UnityEngine.UI.Text FleurFairBestScore; // 0x380
		// [Header] // 0x00000001898F1470-0x00000001898F14A0
		public RectTransform TipsHomeworldConform; // 0x388
		public UnityEngine.UI.Text TextTipsHomeworldConform; // 0x390
		public bool clickOrAddCustomMark; // 0x398
		private static int ACTIVE; // 0x00
		private static int REFRESH; // 0x04
		private static int SHOW; // 0x08
		public MonoMapMark currentMapMark; // 0x3A0
		private DateTime currentTime; // 0x3A8
		private DateTime targetTime; // 0x3B8
		public GameObject lookupGrp; // 0x3C8
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private ScrollRect _adventureTabScroll; // 0x3D0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _abyssTabScroll; // 0x3D8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _routineTabScroll; // 0x3E0
		[SerializeField] // 0x0000000189913C30-0x0000000189913C80
		[Space] // 0x0000000189913C30-0x0000000189913C80
		// [Tooltip] // 0x0000000189913C30-0x0000000189913C80
		private float _scrollShieldAngle; // 0x3E8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _multiTimesRewardTag; // 0x3F0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _multiTimesRewardText; // 0x3F8
	
		// Properties
		public bool showEventTitleGrp { /* [XID] */ /* 0x00000001899377F0-0x0000000189937810 */ set {} } // 0x000000018492BF90-0x000000018492C070
		public bool showMarkerTitleGrp { /* [XID] */ /* 0x000000018993F310-0x000000018993F330 */ set {} } // 0x000000018492C8B0-0x000000018492C9A0
		public string eventTitle { /* [XID] */ /* 0x00000001899468E0-0x0000000189946900 */ set {} } // 0x0000000184929F50-0x000000018492A020
		public Sprite eventTitleIcon { /* [XID] */ /* 0x000000018994DF80-0x000000018994DFA0 */ set {} } // 0x0000000184929E90-0x0000000184929F50
		public bool showNormalTitleGrp { /* [XID] */ /* 0x0000000189955600-0x0000000189955620 */ set {} } // 0x000000018492D000-0x000000018492D0E0
		public string normalTitle { /* [XID] */ /* 0x000000018995D0C0-0x000000018995D0E0 */ set {} } // 0x000000018492AB80-0x000000018492AC50
		public Image normalTitleImg { /* [XID] */ /* 0x0000000189964760-0x0000000189964780 */ get => default; } // 0x00000001849290D0-0x0000000184929170 
		public Sprite normalTitleIcon { /* [XID] */ /* 0x000000018996BE50-0x000000018996BE70 */ set {} } // 0x000000018492AAC0-0x000000018492AB80
		public bool showModButtonGrp { /* [XID] */ /* 0x0000000189973940-0x0000000189973960 */ set {} } // 0x000000018492C9A0-0x000000018492CA80
		public Button modButton { /* [XID] */ /* 0x000000018997AF90-0x000000018997AFB0 */ get => default; } // 0x0000000184928D70-0x0000000184928E10 
		public MonoWeeklyBossResinDiscountInfo dungeonWeeklyBossResinDiscountMono { /* [XID] */ /* 0x0000000189982AC0-0x0000000189982AE0 */ get => default; } // 0x0000000184928A70-0x0000000184928B20 
		public MonoWeeklyBossResinDiscountInfo normalWeeklyBossResinDiscountMono { /* [XID] */ /* 0x000000018998A2B0-0x000000018998A2D0 */ get => default; } // 0x0000000184929170-0x0000000184929220 
		public bool showDungeonTabGrp { /* [XID] */ /* 0x0000000189991B80-0x0000000189991BA0 */ set {} } // 0x000000018492BC00-0x000000018492BCE0
		public bool showDungeonTips { /* [XID] */ /* 0x0000000189999890-0x00000001899998B0 */ set {} } // 0x000000018492BCE0-0x000000018492BDC0
		public string dungeonTips { /* [XID] */ /* 0x00000001899A0F60-0x00000001899A0F80 */ set {} } // 0x0000000184929C20-0x0000000184929CF0
		public bool showTransPointTips { /* [XID] */ /* 0x00000001899A89B0-0x00000001899A89D0 */ set {} } // 0x000000018492DFB0-0x000000018492E090
		public string transPointTips { /* [XID] */ /* 0x00000001899B0290-0x00000001899B02B0 */ set {} } // 0x000000018492E3F0-0x000000018492E4C0
		public ScrollRect dungeonTabScroll { /* [XID] */ /* 0x00000001899B75A0-0x00000001899B75C0 */ get => default; } // 0x00000001849289D0-0x0000000184928A70 
		public bool showDungeonPossibleRewardText { /* [XID] */ /* 0x00000001899BF000-0x00000001899BF020 */ set {} } // 0x000000018492BB10-0x000000018492BC00
		public MonoReusableList dungeonTabList { /* [XID] */ /* 0x00000001899C69C0-0x00000001899C69E0 */ get => default; } // 0x0000000184928930-0x00000001849289D0 
		public MonoDungeonTabTip dungeonDailyTab { /* [XID] */ /* 0x00000001899CDF60-0x00000001899CDF80 */ get => default; } // 0x0000000184928880-0x0000000184928930 
		public GameObject dungeonCoolDownTipsGrp { /* [XID] */ /* 0x00000001899D5690-0x00000001899D56B0 */ get => default; } // 0x0000000184928510-0x00000001849285C0 
		public GameObject dungeonCoolDownTipsLeftChestGrp { /* [XID] */ /* 0x00000001899DCA70-0x00000001899DCA90 */ get => default; } // 0x00000001849285C0-0x0000000184928670 
		public UnityEngine.UI.Text dungeonCoolDownTipsLeftChest { /* [XID] */ /* 0x00000001899E46B0-0x00000001899E46D0 */ get => default; } // 0x0000000184928670-0x0000000184928720 
		public GameObject dungeonCoolDownTipsLeftTimeGrp { /* [XID] */ /* 0x00000001899EB9A0-0x00000001899EB9C0 */ get => default; } // 0x0000000184928720-0x00000001849287D0 
		public UnityEngine.UI.Text dungeonCoolDownTipsLeftTime { /* [XID] */ /* 0x00000001899F3490-0x00000001899F34B0 */ get => default; } // 0x00000001849287D0-0x0000000184928880 
		public bool showNormalDescriptionGrp { /* [XID] */ /* 0x00000001899FAE50-0x00000001899FAE70 */ set {} } // 0x000000018492CC70-0x000000018492CD50
		public bool showNormalTimeTipsGrp { /* [XID] */ /* 0x0000000189A020A0-0x0000000189A020C0 */ set {} } // 0x000000018492CF20-0x000000018492D000
		public string timeTipsLabel { /* [XID] */ /* 0x0000000189A09890-0x0000000189A098B0 */ set {} } // 0x000000018492E250-0x000000018492E320
		public UnityEngine.UI.Text normalDescriptionLabel { /* [XID] */ /* 0x0000000189A10FF0-0x0000000189A11010 */ get => default; } // 0x0000000184928E10-0x0000000184928EC0 
		public bool showNormalConditionGrp { /* [XID] */ /* 0x0000000189A183A0-0x0000000189A183C0 */ set {} } // 0x000000018492CB70-0x000000018492CC70
		public string normalConditionLabel { /* [XID] */ /* 0x0000000189A1FA50-0x0000000189A1FA70 */ set {} } // 0x000000018492A920-0x000000018492A9F0
		public bool showNormalRewardGrp { /* [XID] */ /* 0x0000000189A26E10-0x0000000189A26E30 */ set {} } // 0x000000018492CE40-0x000000018492CF20
		public string normalRewardTitle { /* [XID] */ /* 0x0000000189A2E650-0x0000000189A2E670 */ set {} } // 0x000000018492A9F0-0x000000018492AAC0
		public MonoReusableList normalRewardList { /* [XID] */ /* 0x0000000189A35FA0-0x0000000189A35FC0 */ get => default; } // 0x0000000184928F70-0x0000000184929020 
		public MonoScrollRectExtention normalScroll { /* [XID] */ /* 0x0000000189A3D5A0-0x0000000189A3D5C0 */ get => default; } // 0x0000000184929020-0x00000001849290D0 
		public bool showNormalMultiplyRewardTagGrp { /* [XID] */ /* 0x0000000189A44C70-0x0000000189A44C90 */ set {} } // 0x000000018492CD50-0x000000018492CE40
		public UnityEngine.UI.Text normalMultiplyRewarTagText { /* [XID] */ /* 0x0000000189A4C4C0-0x0000000189A4C4E0 */ get => default; } // 0x0000000184928EC0-0x0000000184928F70 
		public bool showPositionGrp { /* [XID] */ /* 0x0000000189A53C20-0x0000000189A53C40 */ set {} } // 0x000000018492D1D0-0x000000018492D2B0
		public string positionText { /* [XID] */ /* 0x0000000189A5B670-0x0000000189A5B690 */ set {} } // 0x000000018492AD20-0x000000018492ADF0
		public bool showGoddesLevelGrp { /* [XID] */ /* 0x0000000189A62CC0-0x0000000189A62CE0 */ set {} } // 0x000000018492C430-0x000000018492C510
		public uint goddesLevelNum { /* [XID] */ /* 0x0000000189A6A870-0x0000000189A6A890 */ set {} } // 0x000000018492A5B0-0x000000018492A690
		public bool showEventDescriptionGrp { /* [XID] */ /* 0x0000000189A71F00-0x0000000189A71F20 */ set {} } // 0x000000018492BEB0-0x000000018492BF90
		public string eventDesciption { /* [XID] */ /* 0x0000000189A79B60-0x0000000189A79B80 */ set {} } // 0x0000000184929CF0-0x0000000184929DC0
		public string eventProgress { /* [XID] */ /* 0x0000000189A81000-0x0000000189A81020 */ set {} } // 0x0000000184929DC0-0x0000000184929E90
		public bool showMarkGrp { /* [XID] */ /* 0x0000000189A88A40-0x0000000189A88A60 */ set {} } // 0x000000018492C7D0-0x000000018492C8B0
		public bool showTimeGrp { /* [XID] */ /* 0x0000000189A90210-0x0000000189A90230 */ set {} } // 0x000000018492DED0-0x000000018492DFB0
		public string timeLabel { /* [XID] */ /* 0x0000000189A97A00-0x0000000189A97A20 */ set {} } // 0x000000018492E180-0x000000018492E250
		public bool showAdventureGrp { /* [XID] */ /* 0x0000000189A9EDA0-0x0000000189A9EDC0 */ set {} } // 0x000000018492BA20-0x000000018492BB10
		public bool showTaskReward { /* [XID] */ /* 0x0000000189AA66D0-0x0000000189AA66F0 */ set {} } // 0x000000018492DDE0-0x000000018492DED0
		public bool showPlayerReward { /* [XID] */ /* 0x0000000189AADD20-0x0000000189AADD40 */ set {} } // 0x000000018492D0E0-0x000000018492D1D0
		public bool ShowAdvenRewardDesc { /* [XID] */ /* 0x0000000189AB56B0-0x0000000189AB56D0 */ set {} } // 0x00000001849298C0-0x00000001849299B0
		public bool showAdvenPositionGrp { /* [XID] */ /* 0x0000000189ABD0B0-0x0000000189ABD0D0 */ set {} } // 0x000000018492B850-0x000000018492B940
		public string advenPositionLabel { /* [XID] */ /* 0x0000000189AC4B40-0x0000000189AC4B60 */ set {} } // 0x00000001849299B0-0x0000000184929A80
		public bool showForgeReward { /* [XID] */ /* 0x0000000189ACC1C0-0x0000000189ACC1E0 */ set {} } // 0x000000018492C340-0x000000018492C430
		public bool showSalesmanReward { /* [XID] */ /* 0x0000000189AD3CA0-0x0000000189AD3CC0 */ set {} } // 0x000000018492DC00-0x000000018492DCF0
		public bool showElderTreeReward { /* [XID] */ /* 0x0000000189ADB780-0x0000000189ADB7A0 */ set {} } // 0x000000018492BDC0-0x000000018492BEB0
		public bool showHomeworldDjinnReward { /* [XID] */ /* 0x0000000189AE3040-0x0000000189AE3060 */ set {} } // 0x000000018492C510-0x000000018492C600
		public bool showAdvenExpedReward { /* [XID] */ /* 0x0000000189AEA9F0-0x0000000189AEAA10 */ set {} } // 0x000000018492B760-0x000000018492B850
		public bool showAdventureDesc { /* [XID] */ /* 0x0000000189AF22E0-0x0000000189AF2300 */ set {} } // 0x000000018492B940-0x000000018492BA20
		public string adventureDesc { /* [XID] */ /* 0x0000000189AF9C40-0x0000000189AF9C60 */ set {} } // 0x0000000184929A80-0x0000000184929B60
		public string salesmanRewardText { /* [XID] */ /* 0x0000000189B01150-0x0000000189B01170 */ set {} } // 0x000000018492B5A0-0x000000018492B680
		public bool showSalesmanDesc { /* [XID] */ /* 0x0000000189B086E0-0x0000000189B08700 */ set {} } // 0x000000018492DB20-0x000000018492DC00
		public bool showScoreDesc { /* [XID] */ /* 0x0000000189B10020-0x0000000189B10040 */ set {} } // 0x000000018492DCF0-0x000000018492DDE0
		public string scoreRewardText { /* [XID] */ /* 0x0000000189B17180-0x0000000189B171A0 */ set {} } // 0x000000018492B680-0x000000018492B760
		public bool showRoutineGrp { /* [XID] */ /* 0x0000000189B1EAE0-0x0000000189B1EB00 */ set {} } // 0x000000018492DA30-0x000000018492DB20
		public string routinePositionText { /* [XID] */ /* 0x0000000189B263D0-0x0000000189B263F0 */ set {} } // 0x000000018492B300-0x000000018492B3E0
		public string routineTypeDescText { /* [XID] */ /* 0x0000000189B2D650-0x0000000189B2D670 */ set {} } // 0x000000018492B4C0-0x000000018492B5A0
		public string routineEventTitleText { /* [XID] */ /* 0x0000000189B34B20-0x0000000189B34B40 */ set {} } // 0x000000018492B220-0x000000018492B300
		public string routineEventDescText { /* [XID] */ /* 0x0000000189B3C330-0x0000000189B3C350 */ set {} } // 0x000000018492B060-0x000000018492B140
		public string routineEventGoalText { /* [XID] */ /* 0x0000000189B43FA0-0x0000000189B43FC0 */ set {} } // 0x000000018492B140-0x000000018492B220
		public string routineRewardText { /* [XID] */ /* 0x0000000189B4B6A0-0x0000000189B4B6C0 */ set {} } // 0x000000018492B3E0-0x000000018492B4C0
		public bool showFleurFairGrp { /* [XID] */ /* 0x0000000189B52D10-0x0000000189B52D30 */ set {} } // 0x000000018492C170-0x000000018492C260
		public bool showFleurFairFeatureHint { /* [XID] */ /* 0x0000000189B5A6A0-0x0000000189B5A6C0 */ set {} } // 0x000000018492C070-0x000000018492C170
		public string fleurFairTitle { /* [XID] */ /* 0x0000000189B61B90-0x0000000189B61BB0 */ set {} } // 0x000000018492A3A0-0x000000018492A480
		public string fleurFairDesc { /* [XID] */ /* 0x0000000189B69820-0x0000000189B69840 */ set {} } // 0x000000018492A100-0x000000018492A1E0
		public string fleurFairFeatureTitle { /* [XID] */ /* 0x0000000189B70E00-0x0000000189B70E20 */ set {} } // 0x000000018492A2C0-0x000000018492A3A0
		public string fleurFairFeatureDesc { /* [XID] */ /* 0x0000000189B783B0-0x0000000189B783D0 */ set {} } // 0x000000018492A1E0-0x000000018492A2C0
		public string fleurFairBestScoreText { /* [XID] */ /* 0x0000000189B7F870-0x0000000189B7F890 */ set {} } // 0x000000018492A020-0x000000018492A100
		public MonoReusableList routineRewardList { /* [XID] */ /* 0x0000000189B873C0-0x0000000189B873E0 */ get => default; } // 0x0000000184929380-0x0000000184929430 
		public bool showReputationReward { /* [XID] */ /* 0x0000000189B8E490-0x0000000189B8E4B0 */ set {} } // 0x000000018492D670-0x000000018492D780
		public string reputationRewardText { /* [XID] */ /* 0x0000000189B95950-0x0000000189B95970 */ set {} } // 0x000000018492ADF0-0x000000018492AEC0
		public bool showReputationActivity { /* [XID] */ /* 0x0000000189B9CEF0-0x0000000189B9CF10 */ set {} } // 0x000000018492D580-0x000000018492D670
		public bool showReputationActivityHunting { /* [XID] */ /* 0x0000000189BA47F0-0x0000000189BA4810 */ set {} } // 0x000000018492D3A0-0x000000018492D490
		public bool showReputationActivityRequest { /* [XID] */ /* 0x0000000189BABB50-0x0000000189BABB70 */ set {} } // 0x000000018492D490-0x000000018492D580
		public bool showHuntingInfo { /* [XID] */ /* 0x0000000189BB3240-0x0000000189BB3260 */ set {} } // 0x000000018492C600-0x000000018492C6F0
		public string huntingInfo1 { /* [XID] */ /* 0x0000000189BBA820-0x0000000189BBA840 */ set {} } // 0x000000018492A690-0x000000018492A770
		public string huntingInfo2 { /* [XID] */ /* 0x0000000189BC2840-0x0000000189BC2860 */ set {} } // 0x000000018492A770-0x000000018492A850
		public bool showUnlockTip { /* [XID] */ /* 0x0000000189BC9FA0-0x0000000189BC9FC0 */ set {} } // 0x000000018492E090-0x000000018492E180
		public string unlockTipText { /* [XID] */ /* 0x0000000189BD1670-0x0000000189BD1690 */ set {} } // 0x000000018492E4C0-0x000000018492E590
		public RewardConsume rewardConsume { /* [XID] */ /* 0x00000001895F47D0-0x00000001895F47F0 */ get => default; } // 0x00000001849292D0-0x0000000184929380 
		public bool showRewardCountReviveInfo { /* [XID] */ /* 0x00000001895FBF80-0x00000001895FBFA0 */ get => default; /* [XID] */ /* 0x00000001896039C0-0x00000001896039E0 */ set {} } // 0x00000001849297F0-0x00000001849298C0 0x000000018492D940-0x000000018492DA30
		public bool showRecommendElement { /* [XID] */ /* 0x000000018960B320-0x000000018960B340 */ get => default; /* [XID] */ /* 0x00000001896126D0-0x00000001896126F0 */ set {} } // 0x0000000184929590-0x0000000184929650 0x000000018492D2B0-0x000000018492D3A0
		public MonoReusableList elementList { /* [XID] */ /* 0x000000018961A010-0x000000018961A030 */ get => default; } // 0x0000000184928B20-0x0000000184928BD0 
		public bool showRewardCountGrp { /* [XID] */ /* 0x0000000189621550-0x0000000189621570 */ get => default; /* [XID] */ /* 0x0000000189628E60-0x0000000189628E80 */ set {} } // 0x0000000184929720-0x00000001849297F0 0x000000018492D860-0x000000018492D940
		public string rewardCountString { /* [XID] */ /* 0x00000001896307E0-0x0000000189630800 */ set {} } // 0x000000018492AF90-0x000000018492B060
		public bool showReviveCooldownGrp { /* [XID] */ /* 0x0000000189638280-0x00000001896382A0 */ get => default; /* [XID] */ /* 0x000000018963F660-0x000000018963F680 */ set {} } // 0x0000000184929650-0x0000000184929720 0x000000018492D780-0x000000018492D860
		public string reviveCooldownString { /* [XID] */ /* 0x0000000189646E20-0x0000000189646E40 */ set {} } // 0x000000018492AEC0-0x000000018492AF90
		public Sprite dungeonEntryImage { /* [XID] */ /* 0x000000018964E590-0x000000018964E5B0 */ set {} } // 0x0000000184929B60-0x0000000184929C20
		public Sprite towerEntryImage { /* [XID] */ /* 0x0000000189655DC0-0x0000000189655DE0 */ set {} } // 0x000000018492E320-0x000000018492E3F0
		public bool showItemTipsBtn { /* [XID] */ /* 0x000000018965D580-0x000000018965D5A0 */ set {} } // 0x000000018492C6F0-0x000000018492C7D0
		public bool showFoldBtn { /* [XID] */ /* 0x0000000189664CA0-0x0000000189664CC0 */ set {} } // 0x000000018492C260-0x000000018492C340
		public string foldBtnText { /* [XID] */ /* 0x000000018966C2A0-0x000000018966C2C0 */ set {} } // 0x000000018492A480-0x000000018492A5B0
		public float scrollShieldAngle { /* [XID] */ /* 0x0000000189683070-0x0000000189683090 */ get => default; } // 0x00000001849294E0-0x0000000184929590 
		public ScrollRect adventureTabScroll { /* [XID] */ /* 0x000000018968AAC0-0x000000018968AAE0 */ get => default; } // 0x0000000184928460-0x0000000184928510 
		public ScrollRect abyssTabScroll { /* [XID] */ /* 0x0000000189692820-0x0000000189692840 */ get => default; } // 0x00000001849283B0-0x0000000184928460 
		public ScrollRect routineTabScroll { /* [XID] */ /* 0x0000000189699BA0-0x0000000189699BC0 */ get => default; } // 0x0000000184929430-0x00000001849294E0 
		public RectTransform occupiedTipGrp { /* [XID] */ /* 0x00000001896A12C0-0x00000001896A12E0 */ get => default; } // 0x0000000184929220-0x00000001849292D0 
		public string occupiedTipString { /* [XID] */ /* 0x00000001896A8730-0x00000001896A8750 */ set {} } // 0x000000018492AC50-0x000000018492AD20
		public bool showMultiTimesRewardTag { /* [XID] */ /* 0x00000001896AF8E0-0x00000001896AF900 */ set {} } // 0x000000018492CA80-0x000000018492CB70
		public string multiTimesRewardText { /* [XID] */ /* 0x00000001896B7250-0x00000001896B7270 */ set {} } // 0x000000018492A850-0x000000018492A920
		public MonoUIContainer halfTipsDungeonBtn { /* [XID] */ /* 0x00000001896BE3A0-0x00000001896BE3C0 */ get => default; } // 0x0000000184928BD0-0x0000000184928CA0 
		public MonoUIContainer halfTipsMonsterBtn { /* [XID] */ /* 0x00000001896C5C10-0x00000001896C5C30 */ get => default; } // 0x0000000184928CA0-0x0000000184928D70 
	
		// Constructors
		public MonoMapMarkTips() {} // 0x0000000184927FC0-0x00000001849283B0
		static MonoMapMarkTips() {} // 0x0000000184927F00-0x0000000184927FC0
	
		// Methods
		// [XID] // 0x0000000189930330-0x0000000189930350
		public void ResetDefault() {} // 0x0000000184927730-0x0000000184927810
		// [XID] // 0x0000000189BD8C60-0x0000000189BD8C80
		public void AnimateRefresh() {} // 0x0000000184927440-0x0000000184927520
		// [XID] // 0x00000001895E5800-0x00000001895E5820
		public void Show() {} // 0x0000000184927810-0x0000000184927A50
		// [XID] // 0x00000001895ED150-0x00000001895ED170
		public void Hide() {} // 0x0000000184927520-0x0000000184927610
		// [XID] // 0x0000000189674120-0x0000000189674140
		private void OnEnable() {} // 0x0000000184927610-0x0000000184927730
		// [XID] // 0x000000018967B960-0x000000018967B980
		private void Update() {} // 0x0000000184927A50-0x0000000184927F00
	}
}
