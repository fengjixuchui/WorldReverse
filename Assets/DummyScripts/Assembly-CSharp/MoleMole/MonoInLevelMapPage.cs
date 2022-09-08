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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoInLevelMapPage : MonoUIProxy // TypeDefIndex: 29749
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Transform _GrpMapTrans; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoMapMarkTips _markTips; // 0x50
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Button _markTipsFreeBtn; // 0x58
		// [Header] // 0x00000001899D1270-0x00000001899D12B0
		[SerializeField] // 0x00000001899D1270-0x00000001899D12B0
		private RectTransform _markContainer; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform[] _markContainerLayers; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _unusedMarkContainer; // 0x70
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private GameObject _markPrefab; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoLevelMapMarkContainer _container; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _markBossPrefab; // 0x88
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _goddessLevelGrp; // 0x90
		// [Header] // 0x0000000189A0F7C0-0x0000000189A0F800
		[SerializeField] // 0x0000000189A0F7C0-0x0000000189A0F800
		private RectTransform _rewardTipsGrp; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _rewardTipsList; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _cursor; // 0xA8
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _ps4ButtonsGrp; // 0xB0
		[SerializeField] // 0x0000000189A34950-0x0000000189A349A0
		// [Tooltip] // 0x0000000189A34950-0x0000000189A349A0
		private RectTransform _joypadMapButtonsGrp; // 0xB8
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private bool _joypadMoveMapInverted; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _joypadMoveMapSensitivity; // 0xC4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _joypadMoveCursorInverted; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _joypadMoveCursorSensitivity; // 0xCC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _joypadAttrackSpeed; // 0xD0
		public MonoSliderWithButton slider; // 0xD8
		public GameObject playerIndicator; // 0xE0
		public RectTransform playerIndicatorParent; // 0xE8
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoMapCursor _monoMapCursor; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private InputField _customMarkTipsInputField; // 0xF8
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoMaterialItemRow _resin; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _cycleDungeonLookupGrp; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _cycleDungeonLookupToggle; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _cycleDungeonLookupText; // 0x118
		private Queue<MonoMapMark> _unusedMarkPool; // 0x120
		// [Header] // 0x0000000189A9C180-0x0000000189A9C1C0
		[SerializeField] // 0x0000000189A9C180-0x0000000189A9C1C0
		private GameObject _exploreDegreeGrp; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _exploreArea; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _exploreDegree; // 0x138
		public Button exploreTagButton; // 0x140
		public GameObject redPointAnchorExploreDegree; // 0x148
		public Image exploreDegreeImage; // 0x150
		// [Header] // 0x0000000189AB70C0-0x0000000189AB70F0
		public GameObject mapTagSwitch; // 0x158
		public MonoGridScroller mapTagScroller; // 0x160
		public MonoElementSwitch mapTagElementSwitch; // 0x168
		// [Header] // 0x0000000189AC0340-0x0000000189AC0370
		public GameObject dungeonTowerGO; // 0x170
		public UnityEngine.UI.Text dungeonTowerText; // 0x178
		public MonoUIContainer dungeonBtn; // 0x180
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Sprite _questTrackSprite; // 0x188
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Sprite _commonTrackSprite; // 0x190
		// [Header] // 0x0000000189AD89C0-0x0000000189AD89F0
		public Button homeworldVisitorBtn; // 0x198
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _homeworldVisitorLabel; // 0x1A0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _homeworldVisitorPS4Container; // 0x1A8
		private static int SELECTED; // 0x00
		private Animator _cursorAnimator; // 0x1B0
	
		// Properties
		public MonoUIContainer mapTagGoto { /* [XID] */ /* 0x0000000189AF0FF0-0x0000000189AF1010 */ get => default; } // 0x0000000183D6A830-0x0000000183D6A8F0 
		public Button mapTagCancel { /* [XID] */ /* 0x0000000189AF8490-0x0000000189AF84B0 */ get => default; } // 0x0000000183D6A760-0x0000000183D6A830 
		public Sprite questTrackSprite { /* [XID] */ /* 0x0000000189AFFBA0-0x0000000189AFFBC0 */ get => default; } // 0x0000000183D6AD90-0x0000000183D6AE40 
		public Sprite commonTrackSprite { /* [XID] */ /* 0x0000000189B07150-0x0000000189B07170 */ get => default; } // 0x0000000183D69740-0x0000000183D697F0 
		public UnityEngine.UI.Text homeworldVisitorLabel { /* [XID] */ /* 0x0000000189B0E910-0x0000000189B0E930 */ get => default; } // 0x0000000183D6A0E0-0x0000000183D6A190 
		public MonoUIContainer homeworldVisitorPS4Container { /* [XID] */ /* 0x0000000189B15D00-0x0000000189B15D20 */ get => default; } // 0x0000000183D6A190-0x0000000183D6A240 
		public Transform GrpMapTrans { /* [XID] */ /* 0x0000000189B1D410-0x0000000189B1D430 */ get => default; } // 0x0000000183D69380-0x0000000183D69420 
		public Button closeBtn { /* [XID] */ /* 0x0000000189B24C90-0x0000000189B24CB0 */ get => default; } // 0x0000000183D69680-0x0000000183D69740 
		public bool showCloseBtn { /* [XID] */ /* 0x0000000189B2C100-0x0000000189B2C120 */ set {} } // 0x0000000183D6BAC0-0x0000000183D6BB90
		public RectTransform markContainer { /* [XID] */ /* 0x0000000189B336F0-0x0000000189B33710 */ get => default; } // 0x0000000183D6AA40-0x0000000183D6AAE0 
		public Rect mapRect { /* [XID] */ /* 0x0000000189B3AFF0-0x0000000189B3B010 */ get => default; } // 0x0000000183D6A670-0x0000000183D6A760 
		public RectTransform[] markContainerLayers { /* [XID] */ /* 0x0000000189B427F0-0x0000000189B42810 */ get => default; } // 0x0000000183D6A9A0-0x0000000183D6AA40 
		public float joypadMoveMapSensitivity { /* [XID] */ /* 0x0000000189B681B0-0x0000000189B681D0 */ get => default; } // 0x0000000183D6A500-0x0000000183D6A5B0 
		public float joypadMoveCursorSensitiviy { /* [XID] */ /* 0x0000000189B6F550-0x0000000189B6F570 */ get => default; } // 0x0000000183D6A3A0-0x0000000183D6A450 
		public RectTransform cursor { /* [XID] */ /* 0x0000000189B76BD0-0x0000000189B76BF0 */ get => default; } // 0x0000000183D697F0-0x0000000183D698A0 
		public bool joypadMoveMapInverted { /* [XID] */ /* 0x0000000189B7E160-0x0000000189B7E180 */ get => default; /* [XID] */ /* 0x0000000189B85D80-0x0000000189B85DA0 */ set {} } // 0x0000000183D6A450-0x0000000183D6A500 0x0000000183D6B6D0-0x0000000183D6B780
		public bool joypadMoveCursorInverted { /* [XID] */ /* 0x0000000189B8CD70-0x0000000189B8CD90 */ get => default; /* [XID] */ /* 0x0000000189B94560-0x0000000189B94580 */ set {} } // 0x0000000183D6A2F0-0x0000000183D6A3A0 0x0000000183D6B620-0x0000000183D6B6D0
		public Transform mapBackground { /* [XID] */ /* 0x0000000189B9BC10-0x0000000189B9BC30 */ get => default; } // 0x0000000183D6A5B0-0x0000000183D6A670 
		public bool showJoypadBtnsGrp { /* [XID] */ /* 0x0000000189BA3390-0x0000000189BA33B0 */ set {} } // 0x0000000183D6BFB0-0x0000000183D6C090
		public bool showJoypadMapBtnsGrp { /* [XID] */ /* 0x0000000189BAA6F0-0x0000000189BAA710 */ set {} } // 0x0000000183D6C090-0x0000000183D6C170
		public bool cursorSelected { /* [XID] */ /* 0x0000000189BB1D70-0x0000000189BB1D90 */ set {} } // 0x0000000183D6B230-0x0000000183D6B3A0
		public float joypadAttrackSpeed { /* [XID] */ /* 0x0000000189BB9130-0x0000000189BB9150 */ get => default; } // 0x0000000183D6A240-0x0000000183D6A2F0 
		public MonoMapMarkTips markTips { /* [XID] */ /* 0x0000000189BC0EE0-0x0000000189BC0F00 */ get => default; } // 0x0000000183D6AB80-0x0000000183D6AC20 
		public Button markTipsFreeButton { /* [XID] */ /* 0x0000000189BC8630-0x0000000189BC8650 */ get => default; } // 0x0000000183D6AAE0-0x0000000183D6AB80 
		public bool enableMarkTipsFreeButton { /* [XID] */ /* 0x0000000189BCFE90-0x0000000189BCFEB0 */ set {} } // 0x0000000183D6B3A0-0x0000000183D6B480
		public MonoElementSwitch elementSwitch { /* [XID] */ /* 0x0000000189BD7490-0x0000000189BD74B0 */ get => default; } // 0x0000000183D69CF0-0x0000000183D69D90 
		public bool showBossDungeonTips { /* [XID] */ /* 0x0000000189BDEFB0-0x0000000189BDEFD0 */ set {} } // 0x0000000183D6B8A0-0x0000000183D6B9B0
		public Button bossDungeonTips { /* [XID] */ /* 0x00000001895EBC60-0x00000001895EBC80 */ get => default; } // 0x0000000183D69420-0x0000000183D694E0 
		public bool showOkBtnGrp { /* [XID] */ /* 0x00000001895F3000-0x00000001895F3020 */ set {} } // 0x0000000183D6C170-0x0000000183D6C280
		public Button okButton { /* [XID] */ /* 0x00000001895FA840-0x00000001895FA860 */ get => default; } // 0x0000000183D6ACD0-0x0000000183D6AD90 
		public bool showCancelBtnGrp { /* [XID] */ /* 0x00000001896021F0-0x0000000189602210 */ set {} } // 0x0000000183D6B9B0-0x0000000183D6BAC0
		public MonoUIContainer cancelBtnContainer { /* [XID] */ /* 0x0000000189609A30-0x0000000189609A50 */ get => default; } // 0x0000000183D694E0-0x0000000183D695C0 
		public Button cancelButton { /* [XID] */ /* 0x00000001896111E0-0x0000000189611200 */ get => default; } // 0x0000000183D695C0-0x0000000183D69680 
		public bool showGotoBtnGrp { /* [XID] */ /* 0x0000000189618B70-0x0000000189618B90 */ set {} } // 0x0000000183D6BEA0-0x0000000183D6BFB0
		public Button gotoButton { /* [XID] */ /* 0x0000000189620100-0x0000000189620120 */ get => default; } // 0x0000000183D6A020-0x0000000183D6A0E0 
		public MonoUIContainer gotoBtnContainer { /* [XID] */ /* 0x0000000189627550-0x0000000189627570 */ get => default; } // 0x0000000183D69F60-0x0000000183D6A020 
		public bool showDeleteBtnGrp { /* [XID] */ /* 0x000000018962F070-0x000000018962F090 */ set {} } // 0x0000000183D6BB90-0x0000000183D6BCA0
		public Button deleteButton { /* [XID] */ /* 0x0000000189636A30-0x0000000189636A50 */ get => default; } // 0x0000000183D69B70-0x0000000183D69C30 
		public bool showTrackBtnGrp { /* [XID] */ /* 0x000000018963DF40-0x000000018963DF60 */ set {} } // 0x0000000183D6C510-0x0000000183D6C620
		public bool showExploreBtnGrp { /* [XID] */ /* 0x00000001896458D0-0x00000001896458F0 */ set {} } // 0x0000000183D6BCA0-0x0000000183D6BDB0
		public Button trackButton { /* [XID] */ /* 0x000000018964D100-0x000000018964D120 */ get => default; } // 0x0000000183D6B170-0x0000000183D6B230 
		public Button exploreButton { /* [XID] */ /* 0x00000001896548A0-0x00000001896548C0 */ get => default; } // 0x0000000183D69EA0-0x0000000183D69F60 
		public MonoUIContainer trackBtnContainer { /* [XID] */ /* 0x000000018965BF70-0x000000018965BF90 */ get => default; } // 0x0000000183D6B060-0x0000000183D6B170 
		public MonoUIContainer exploreBtnContainer { /* [XID] */ /* 0x0000000189663580-0x00000001896635A0 */ get => default; } // 0x0000000183D69D90-0x0000000183D69EA0 
		public bool showRewardTips { /* [XID] */ /* 0x000000018966AF50-0x000000018966AF70 */ set {} } // 0x0000000183D6C430-0x0000000183D6C510
		public MonoSimpleReusableList rewardTipsList { /* [XID] */ /* 0x0000000189672B70-0x0000000189672B90 */ get => default; } // 0x0000000183D6AEF0-0x0000000183D6AFA0 
		public bool showRewardTipsBtn { /* [XID] */ /* 0x000000018967A270-0x000000018967A290 */ set {} } // 0x0000000183D6C360-0x0000000183D6C430
		public string rewardTipsBtnText { /* [XID] */ /* 0x0000000189681AC0-0x0000000189681AE0 */ set {} } // 0x0000000183D6B780-0x0000000183D6B8A0
		public MonoMapCursor monoMapCursor { /* [XID] */ /* 0x0000000189689550-0x0000000189689570 */ get => default; } // 0x0000000183D6AC20-0x0000000183D6ACD0 
		public InputField customMarkTipsInputField { /* [XID] */ /* 0x0000000189691170-0x0000000189691190 */ get => default; } // 0x0000000183D698A0-0x0000000183D69950 
		public bool showResinGrp { /* [XID] */ /* 0x0000000189698980-0x00000001896989A0 */ set {} } // 0x0000000183D6C280-0x0000000183D6C360
		public MonoMaterialItemRow resin { /* [XID] */ /* 0x000000018969FDB0-0x000000018969FDD0 */ get => default; } // 0x0000000183D6AE40-0x0000000183D6AEF0 
		public RectTransform cycleDungeonLookupGrp { /* [XID] */ /* 0x00000001896A6FF0-0x00000001896A7010 */ get => default; } // 0x0000000183D69950-0x0000000183D69A00 
		public Toggle cycleDungeonLookupToggle { /* [XID] */ /* 0x00000001896AE630-0x00000001896AE650 */ get => default; } // 0x0000000183D69AB0-0x0000000183D69B70 
		public UnityEngine.UI.Text cycleDungeonLookupText { /* [XID] */ /* 0x00000001896B5E50-0x00000001896B5E70 */ get => default; } // 0x0000000183D69A00-0x0000000183D69AB0 
		public GameObject markBossGroupPrefab { /* [XID] */ /* 0x00000001896BD030-0x00000001896BD050 */ get => default; } // 0x0000000183D6A8F0-0x0000000183D6A9A0 
		public Button dungeonTipsButton { /* [XID] */ /* 0x00000001896C44D0-0x00000001896C44F0 */ get => default; } // 0x0000000183D69C30-0x0000000183D69CF0 
		public bool showExploreDegree { /* [XID] */ /* 0x00000001896CBB70-0x00000001896CBB90 */ set {} } // 0x0000000183D6BDB0-0x0000000183D6BEA0
		public string exploreArea { /* [XID] */ /* 0x00000001896D2E50-0x00000001896D2E70 */ set {} } // 0x0000000183D6B480-0x0000000183D6B550
		public string exploreDegree { /* [XID] */ /* 0x00000001896DAA00-0x00000001896DAA20 */ set {} } // 0x0000000183D6B550-0x0000000183D6B620
		public MonoUIContainer selectBtnContainer { /* [XID] */ /* 0x00000001896E9650-0x00000001896E9670 */ get => default; } // 0x0000000183D6AFA0-0x0000000183D6B060 
	
		// Constructors
		public MonoInLevelMapPage() {} // 0x0000000183D691A0-0x0000000183D69380
		static MonoInLevelMapPage() {} // 0x0000000183D69130-0x0000000183D691A0
	
		// Methods
		// [XID] // 0x0000000189B4A310-0x0000000189B4A330
		public void RefreshGoddessLevel() {} // 0x0000000183D68EB0-0x0000000183D68FA0
		// [XID] // 0x0000000189B51AB0-0x0000000189B51AD0
		public MonoMapMark AddMark(ConfigMarkIcon iconConfig) => default; // 0x0000000183D68810-0x0000000183D68C70
		// [XID] // 0x0000000189B59230-0x0000000189B59250
		public void ReuseMark(MonoMapMark mark) {} // 0x0000000183D68FA0-0x0000000183D69130
		// [XID] // 0x0000000189B60B00-0x0000000189B60B20
		public void MapTagButtonScrollerFadeIn() {} // 0x0000000183D68DC0-0x0000000183D68EB0
		// [XID] // 0x00000001896E2130-0x00000001896E2150
		public void Clear() {} // 0x0000000183D68C70-0x0000000183D68DC0
	}
}
