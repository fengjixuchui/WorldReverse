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
	public class MonoMPLobbyPage : MonoUIProxy // TypeDefIndex: 31012
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _titleLabel; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _titlePrefixLabel; // 0x50
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _playerListGrp; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _playerGridScroller; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _filterNoResultGrp; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _noWorldGrp; // 0x70
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _teamListGrp; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _teamGridScroller; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _teamNumberLabel; // 0x88
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _settingGrp; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _settingDropdownContainer; // 0x98
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _searchGrp; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _searchInputContainer; // 0xA8
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _joinableFilterGrp; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _joinableFilterToggleContainer; // 0xB8
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _grpOnlineMatching; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _matchingTimeLabel; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _totalMatchingTimeLabel; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _matchingTitleLabel; // 0xD8
		private float _initPlayerListOffsetTop; // 0xE0
		private float _initTeamListOffsetTop; // 0xE4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _matchPlayerListTop; // 0xE8
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoUIContainer _inputToggleContainer; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _inputHighlight; // 0xF8
	
		// Properties
		public RectTransform grpOnlineMatching { /* [XID] */ /* 0x00000001896B9F10-0x00000001896B9F30 */ get => default; } // 0x0000000182F09A00-0x0000000182F09AB0 
		public UnityEngine.UI.Text matchingTimeLabel { /* [XID] */ /* 0x00000001896C1230-0x00000001896C1250 */ get => default; } // 0x0000000182F09D90-0x0000000182F09E40 
		public UnityEngine.UI.Text totalMatchingTimeLabel { /* [XID] */ /* 0x00000001896C88F0-0x00000001896C8910 */ get => default; } // 0x0000000182F0A580-0x0000000182F0A630 
		public UnityEngine.UI.Text matchingTitleLabel { /* [XID] */ /* 0x00000001896D02E0-0x00000001896D0300 */ get => default; } // 0x0000000182F09E40-0x0000000182F09EF0 
		public Button returnButton { /* [XID] */ /* 0x00000001896D7840-0x00000001896D7860 */ get => default; } // 0x0000000182F0A110-0x0000000182F0A1D0 
		public string title { /* [XID] */ /* 0x00000001896DF000-0x00000001896DF020 */ set {} } // 0x0000000182F0B7B0-0x0000000182F0B880
		public bool showTitlePrefix { /* [XID] */ /* 0x00000001896E6470-0x00000001896E6490 */ set {} } // 0x0000000182F0B530-0x0000000182F0B610
		public string titlePrefix { /* [XID] */ /* 0x00000001896ED980-0x00000001896ED9A0 */ set {} } // 0x0000000182F0B6E0-0x0000000182F0B7B0
		public bool showPlayerListGrp { /* [XID] */ /* 0x00000001896F5110-0x00000001896F5130 */ set {} } // 0x0000000182F0B020-0x0000000182F0B100
		public MonoGridScroller playerGridScroller { /* [XID] */ /* 0x000000018970B730-0x000000018970B750 */ get => default; } // 0x0000000182F0A070-0x0000000182F0A110 
		public bool showFilterNoResultHint { /* [XID] */ /* 0x00000001897291E0-0x0000000189729200 */ set {} } // 0x0000000182F0A930-0x0000000182F0AA10
		public bool showNoWorldGrp { /* [XID] */ /* 0x0000000189730A20-0x0000000189730A40 */ set {} } // 0x0000000182F0AD70-0x0000000182F0AE50
		public bool showTeamListGrp { /* [XID] */ /* 0x0000000189738370-0x0000000189738390 */ set {} } // 0x0000000182F0B450-0x0000000182F0B530
		public MonoGridScroller teamGridScroller { /* [XID] */ /* 0x00000001897400B0-0x00000001897400D0 */ get => default; } // 0x0000000182F0A410-0x0000000182F0A4C0 
		public string teamNumberString { /* [XID] */ /* 0x0000000189747480-0x00000001897474A0 */ set {} } // 0x0000000182F0B610-0x0000000182F0B6E0
		public bool showSettingGrp { /* [XID] */ /* 0x000000018974EBD0-0x000000018974EBF0 */ set {} } // 0x0000000182F0B370-0x0000000182F0B450
		public MonoDropdownExtention settingDropdown { /* [XID] */ /* 0x00000001897562E0-0x0000000189756300 */ get => default; } // 0x0000000182F0A350-0x0000000182F0A410 
		public bool showSearchGrp { /* [XID] */ /* 0x000000018975D680-0x000000018975D6A0 */ set {} } // 0x0000000182F0B270-0x0000000182F0B370
		public bool showSearchBtnGrp { /* [XID] */ /* 0x0000000189764CD0-0x0000000189764CF0 */ set {} } // 0x0000000182F0B100-0x0000000182F0B270
		public bool showPlayerBtnGrp { /* [XID] */ /* 0x000000018976C770-0x000000018976C790 */ set {} } // 0x0000000182F0AF20-0x0000000182F0B020
		public bool showKick { /* [XID] */ /* 0x0000000189773BF0-0x0000000189773C10 */ set {} } // 0x0000000182F0AC30-0x0000000182F0AD70
		public bool showAdd { /* [XID] */ /* 0x000000018977B2E0-0x000000018977B300 */ set {} } // 0x0000000182F0A700-0x0000000182F0A840
		public bool showJoin { /* [XID] */ /* 0x0000000189782E00-0x0000000189782E20 */ set {} } // 0x0000000182F0AA10-0x0000000182F0AB50
		public InputField searchInput { /* [XID] */ /* 0x000000018978A290-0x000000018978A2B0 */ get => default; } // 0x0000000182F0A290-0x0000000182F0A350 
		public Button searchButton { /* [XID] */ /* 0x0000000189791B10-0x0000000189791B30 */ get => default; } // 0x0000000182F0A1D0-0x0000000182F0A290 
		public MonoUIContainer pasteButton { /* [XID] */ /* 0x00000001897990B0-0x00000001897990D0 */ get => default; } // 0x0000000182F09FB0-0x0000000182F0A070 
		public bool showExitBtnGrp { /* [XID] */ /* 0x00000001897A0F90-0x00000001897A0FB0 */ set {} } // 0x0000000182F0A840-0x0000000182F0A930
		public MonoUIContainer exitButton { /* [XID] */ /* 0x00000001897A8600-0x00000001897A8620 */ get => default; } // 0x0000000182F098F0-0x0000000182F09A00 
		public bool showJoinableFilterGrp { /* [XID] */ /* 0x00000001897AFFE0-0x00000001897B0000 */ set {} } // 0x0000000182F0AB50-0x0000000182F0AC30
		public Toggle joinableFitlerToggle { /* [XID] */ /* 0x00000001897B7D30-0x00000001897B7D50 */ get => default; } // 0x0000000182F09CD0-0x0000000182F09D90 
		public bool ShowTipsButton { /* [XID] */ /* 0x00000001897BFD80-0x00000001897BFDA0 */ set {} } // 0x0000000182F0A630-0x0000000182F0A700
		public Button tipsButton { /* [XID] */ /* 0x00000001897C7660-0x00000001897C7680 */ get => default; } // 0x0000000182F0A4C0-0x0000000182F0A580 
		public Button outMatchingButton { /* [XID] */ /* 0x00000001897CE900-0x00000001897CE920 */ get => default; } // 0x0000000182F09EF0-0x0000000182F09FB0 
		public bool showOutMatchingButton { /* [XID] */ /* 0x00000001897D60E0-0x00000001897D6100 */ set {} } // 0x0000000182F0AE50-0x0000000182F0AF20
		public Toggle inputToggle { /* [XID] */ /* 0x00000001897DD9C0-0x00000001897DD9E0 */ get => default; } // 0x0000000182F09C10-0x0000000182F09CD0 
		public MonoUIContainer inputToggleContainer { /* [XID] */ /* 0x00000001897E52B0-0x00000001897E52D0 */ get => default; } // 0x0000000182F09B60-0x0000000182F09C10 
		public RectTransform inputHighlight { /* [XID] */ /* 0x00000001897ECE90-0x00000001897ECEB0 */ get => default; } // 0x0000000182F09AB0-0x0000000182F09B60 
	
		// Constructors
		public MonoMPLobbyPage() {} // 0x0000000182F09800-0x0000000182F098F0
	
		// Methods
		// [XID] // 0x00000001896B27F0-0x00000001896B2810
		protected void Awake() {} // 0x0000000182F09230-0x0000000182F09320
		// [XID] // 0x00000001896FC970-0x00000001896FC990
		public void SetMatchPlayerListGrpTop() {} // 0x0000000182F09480-0x0000000182F095F0
		// [XID] // 0x0000000189703E50-0x0000000189703E70
		public void ResetPlayerListGrpTop() {} // 0x0000000182F09320-0x0000000182F09480
		// [XID] // 0x0000000189712FB0-0x0000000189712FD0
		public void ToFilterNoResult() {} // 0x0000000182F095F0-0x0000000182F096A0
		// [XID] // 0x000000018971A830-0x000000018971A850
		public void ToNoWorld() {} // 0x0000000182F096A0-0x0000000182F09750
		// [XID] // 0x0000000189721BB0-0x0000000189721BD0
		public void ToShowPlayerList() {} // 0x0000000182F09750-0x0000000182F09800
	}
}
