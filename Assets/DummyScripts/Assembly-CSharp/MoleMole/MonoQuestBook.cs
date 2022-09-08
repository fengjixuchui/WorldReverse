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
	public class MonoQuestBook : MonoBehaviour // TypeDefIndex: 31291
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Button _freeClickButton; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _talkLogBtnContainer; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _deleteBtnContainer; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _trackBtnContainer; // 0x30
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text _questTitle; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtQuestDetail; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtQuestType; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtQuestLocation; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtQuestTabType; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtMapMarkDesc; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtMapMarkNum; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtFinishedPageTitle; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtNoQuestTitle; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtNoQuestDesc; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtRemainingTime; // 0x88
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoGridScroller _mainQuestPanel; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _mainQuestPanelNew; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _mainQuestPanelScrollBar; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _subQuestPanel; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _subQuestPanelNew; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _rewardScroller; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _grpFinishedChapterScroller; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _mainQuestSign; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _rewardGrp; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _questTypeTab; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _subQuestContentDesc; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _questSelectItemPrefab; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpQuestItemList; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpQuestDetail; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpNoQuest; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpFinishedChapter; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpQuestDescInfoIcon; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _imgBarLeft; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _imgLeftUpIcon; // 0x120
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpMarkGO; // 0x128
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private ScrollRect _detailScrollRect; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpStory; // 0x138
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x140
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpTop; // 0x148
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpTabKey; // 0x150
		private MonoScrollRectExtention _mainQuestScrollRect; // 0x158
		private MonoScrollRectExtention _rewardScrollRect; // 0x160
		private ScrollRect _subQuestScrollRect; // 0x168
	
		// Properties
		public bool showRemainingTime { /* [XID] */ /* 0x0000000189AAC690-0x0000000189AAC6B0 */ set {} } // 0x000000018372AC00-0x000000018372AD10
		public UnityEngine.UI.Text txtRemainingTime { /* [XID] */ /* 0x0000000189AB3E70-0x0000000189AB3E90 */ get => default; } // 0x000000018372A570-0x000000018372A620 
		public Button freeClickButton { /* [XID] */ /* 0x0000000189ABBBD0-0x0000000189ABBBF0 */ get => default; } // 0x00000001837290C0-0x0000000183729160 
		public Button talkLogButton { /* [XID] */ /* 0x0000000189AC3340-0x0000000189AC3360 */ get => default; } // 0x000000018372A0F0-0x000000018372A1A0 
		public Button deleteButton { /* [XID] */ /* 0x0000000189ACAA80-0x0000000189ACAAA0 */ get => default; } // 0x0000000183729010-0x00000001837290C0 
		public Button navigateButton { /* [XID] */ /* 0x0000000189AD24C0-0x0000000189AD24E0 */ get => default; } // 0x0000000183729A00-0x0000000183729AB0 
		public MonoGridScroller mainQuestScroller { /* [XID] */ /* 0x0000000189AD9F90-0x0000000189AD9FB0 */ get => default; } // 0x0000000183729950-0x0000000183729A00 
		public MonoSimpleReusableList mainQuestScrollerNew { /* [XID] */ /* 0x0000000189AE18D0-0x0000000189AE18F0 */ get => default; } // 0x00000001837298A0-0x0000000183729950 
		public MonoScrollRectExtention mainQuestScrollRect { /* [XID] */ /* 0x0000000189AE9080-0x0000000189AE90A0 */ get => default; } // 0x0000000183729790-0x00000001837298A0 
		public MonoGridScroller subQuestScroller { /* [XID] */ /* 0x0000000189AF0DE0-0x0000000189AF0E00 */ get => default; } // 0x000000018372A040-0x000000018372A0F0 
		public MonoSimpleReusableList subQuestScrollerNew { /* [XID] */ /* 0x0000000189AF82F0-0x0000000189AF8310 */ get => default; } // 0x0000000183729F90-0x000000018372A040 
		public MonoGridScroller rewardScroller { /* [XID] */ /* 0x0000000189AFF9E0-0x0000000189AFFA00 */ get => default; } // 0x0000000183729D20-0x0000000183729DD0 
		public UnityEngine.UI.Text txtMapMarkDesc { /* [XID] */ /* 0x0000000189B06FB0-0x0000000189B06FD0 */ get => default; } // 0x000000018372A240-0x000000018372A2E0 
		public UnityEngine.UI.Text txtMapMarkNum { /* [XID] */ /* 0x0000000189B0E7B0-0x0000000189B0E7D0 */ get => default; } // 0x000000018372A2E0-0x000000018372A380 
		public MonoGridScroller grpFinishedChapterScroller { /* [XID] */ /* 0x0000000189B15B90-0x0000000189B15BB0 */ get => default; } // 0x0000000183729160-0x0000000183729210 
		public MonoScrollRectExtention rewardScrollRect { /* [XID] */ /* 0x0000000189B1D2D0-0x0000000189B1D2F0 */ get => default; } // 0x0000000183729C10-0x0000000183729D20 
		public string detailText { /* [XID] */ /* 0x0000000189B24B10-0x0000000189B24B30 */ set {} } // 0x000000018372A620-0x000000018372A730
		public string questTypeText { /* [XID] */ /* 0x0000000189B2BFE0-0x0000000189B2C000 */ set {} } // 0x000000018372AA40-0x000000018372AB10
		public string questLocationText { /* [XID] */ /* 0x0000000189B33510-0x0000000189B33530 */ set {} } // 0x000000018372A970-0x000000018372AA40
		public string titleText { /* [XID] */ /* 0x0000000189B3AE50-0x0000000189B3AE70 */ set {} } // 0x000000018372AE00-0x000000018372AED0
		public bool isNavigating { /* [XID] */ /* 0x0000000189B42610-0x0000000189B42630 */ set {} } // 0x000000018372A730-0x000000018372A820
		public bool showMainSign { /* [XID] */ /* 0x0000000189B4A0D0-0x0000000189B4A0F0 */ set {} } // 0x000000018372AB10-0x000000018372AC00
		public bool showReward { /* [XID] */ /* 0x0000000189B51970-0x0000000189B51990 */ set {} } // 0x000000018372AD10-0x000000018372AE00
		public ScrollRect subQuestScrollRect { /* [XID] */ /* 0x0000000189B59130-0x0000000189B59150 */ get => default; } // 0x0000000183729E80-0x0000000183729F90 
		public MonoReusableList questTypeTab { /* [XID] */ /* 0x0000000189B60960-0x0000000189B60980 */ get => default; } // 0x0000000183729B60-0x0000000183729C10 
		public RectTransform subQuestContentDesc { /* [XID] */ /* 0x0000000189B680B0-0x0000000189B680D0 */ get => default; } // 0x0000000183729DD0-0x0000000183729E80 
		public GameObject questSelectItemPrefab { /* [XID] */ /* 0x0000000189B6F430-0x0000000189B6F450 */ get => default; } // 0x0000000183729AB0-0x0000000183729B60 
		public GameObject grpQuestItemList { /* [XID] */ /* 0x0000000189B76A90-0x0000000189B76AB0 */ get => default; } // 0x00000001837294D0-0x0000000183729580 
		public GameObject grpQuestDetail { /* [XID] */ /* 0x0000000189B7E040-0x0000000189B7E060 */ get => default; } // 0x0000000183729420-0x00000001837294D0 
		public GameObject grpNoQuest { /* [XID] */ /* 0x0000000189B85C40-0x0000000189B85C60 */ get => default; } // 0x00000001837292C0-0x0000000183729370 
		public GameObject grpFinishiedChapter { /* [XID] */ /* 0x0000000189B8CC10-0x0000000189B8CC30 */ get => default; } // 0x0000000183729210-0x00000001837292C0 
		public UnityEngine.UI.Text txtQuestTabType { /* [XID] */ /* 0x0000000189B94440-0x0000000189B94460 */ get => default; } // 0x000000018372A4D0-0x000000018372A570 
		public UnityEngine.UI.Text txtFinishPageTitle { /* [XID] */ /* 0x0000000189B9BB30-0x0000000189B9BB50 */ get => default; } // 0x000000018372A1A0-0x000000018372A240 
		public UnityEngine.UI.Text txtNoQuestTitle { /* [XID] */ /* 0x0000000189BA3280-0x0000000189BA32A0 */ get => default; } // 0x000000018372A430-0x000000018372A4D0 
		public UnityEngine.UI.Text txtNoQuestDesc { /* [XID] */ /* 0x0000000189BAA5C0-0x0000000189BAA5E0 */ get => default; } // 0x000000018372A380-0x000000018372A430 
		public GameObject ImgBarLeft { /* [XID] */ /* 0x0000000189BB1C90-0x0000000189BB1CB0 */ get => default; } // 0x0000000183728B10-0x0000000183728BC0 
		public GameObject ImgLeftUpIcon { /* [XID] */ /* 0x0000000189BB8F90-0x0000000189BB8FB0 */ get => default; } // 0x0000000183728BC0-0x0000000183728C70 
		public GameObject grpQuestDescInfoIcon { /* [XID] */ /* 0x0000000189BC0D60-0x0000000189BC0D80 */ get => default; } // 0x0000000183729370-0x0000000183729420 
		public GameObject grpStory { /* [XID] */ /* 0x0000000189BC84A0-0x0000000189BC84C0 */ get => default; } // 0x0000000183729580-0x0000000183729630 
		public GameObject grpTop { /* [XID] */ /* 0x0000000189BCFD10-0x0000000189BCFD30 */ get => default; } // 0x00000001837296E0-0x0000000183729790 
		public GameObject grpTabKey { /* [XID] */ /* 0x0000000189BD7370-0x0000000189BD7390 */ get => default; } // 0x0000000183729630-0x00000001837296E0 
		public Animator animator { /* [XID] */ /* 0x0000000189BDEE50-0x0000000189BDEE70 */ get => default; } // 0x0000000183728C70-0x0000000183728D70 
		public bool isShowQuestItemList { /* [XID] */ /* 0x00000001895EBAE0-0x00000001895EBB00 */ set {} } // 0x000000018372A820-0x000000018372A970
		public MonoUIContainer btnDelete { /* [XID] */ /* 0x00000001895F2E20-0x00000001895F2E40 */ get => default; } // 0x0000000183728D70-0x0000000183728EC0 
		public MonoUIContainer btnStory { /* [XID] */ /* 0x00000001895FA680-0x00000001895FA6A0 */ get => default; } // 0x0000000183728EC0-0x0000000183729010 
	
		// Constructors
		public MonoQuestBook() {} // 0x0000000183728A10-0x0000000183728B10
	
		// Methods
		// [XID] // 0x0000000189AA4E00-0x0000000189AA4E20
		private void Awake() {} // 0x0000000183728950-0x0000000183728A10
	}
}
