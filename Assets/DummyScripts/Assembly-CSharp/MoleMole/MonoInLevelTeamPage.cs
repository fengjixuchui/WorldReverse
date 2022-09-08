/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using HedgehogTeam.EasyTouch;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoInLevelTeamPage : MonoUIProxy // TypeDefIndex: 29764
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoUIContainer _closeBtnContainer; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _avatarPanel; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _btnSwitch; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _cancleBtnContainer; // 0x58
		// [Header] // 0x0000000189887000-0x0000000189887040
		[SerializeField] // 0x0000000189887000-0x0000000189887040
		private RectTransform _teamSwitchGrp; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _nextTeamBtnContainer; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _prevTeamBtnContainer; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _tabPanel; // 0x78
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private GameObject _grpTeam; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpAvatar; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoCostLabel _costLabel; // 0x90
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform[] _teamAvatarBtns; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _blankBtn; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _holdTimeBarFill; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _holdTimeBar; // 0xB0
		// [Range] // 0x00000001898EE590-0x00000001898EE5D0
		[SerializeField] // 0x00000001898EE590-0x00000001898EE5D0
		private float _teamBtnHoldTime; // 0xB8
		// [Range] // 0x00000001898EE590-0x00000001898EE5D0
		[SerializeField] // 0x00000001898EE590-0x00000001898EE5D0
		private float _teamBtnHoldShowTime; // 0xBC
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private GameObject _teamIcon; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _dungeonIcon; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _avatarIcon; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _titleGrp; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _titleText; // 0xE0
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private GameObject _noAvatarTip; // 0xE8
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _recommendElementGrp; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _recommendElementLabel; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _recommendElementList; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.Material _recommendGreyMaterial; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _upGrp; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _upList; // 0x118
		// [Header] // 0x000000018995B800-0x000000018995B850
		[SerializeField] // 0x000000018995B800-0x000000018995B850
		private RectTransform _mpTitleGrp; // 0x120
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _mpTitleLabel; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _titleRecommendElementGrp; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _titleRecommendElementList; // 0x138
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public Button titleBtn; // 0x140
		public EasyTouch.TouchDownHandler EasyTouch_TouchDown; // 0x148
		public EasyTouch.TouchUpHandler EasyTouch_TouchUp; // 0x150
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _grpAvatarList; // 0x158
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _mpUpGrp; // 0x160
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _mpUpList; // 0x168
		public UnityEngine.UI.Text chaName; // 0x170
		public MonoStarRate starRate; // 0x178
		public MonoUIContainer chatPanel; // 0x180
		// [Header] // 0x000000018999F730-0x000000018999F770
		[SerializeField] // 0x000000018999F730-0x000000018999F770
		private GameObject _resonancePanel; // 0x188
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _resonanceList; // 0x190
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _resonanceScroller; // 0x198
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _resonanceSelectRoot; // 0x1A0
	
		// Properties
		public MonoUIContainer closeBtnContainer { /* [XID] */ /* 0x00000001899C2310-0x00000001899C2330 */ get => default; } // 0x000000018431B8B0-0x000000018431B950 
		public MonoGridScroller avatarPanel { /* [XID] */ /* 0x00000001899C9A00-0x00000001899C9A20 */ get => default; } // 0x000000018431B160-0x000000018431B200 
		public RectTransform upGrp { /* [XID] */ /* 0x00000001899D1250-0x00000001899D1270 */ get => default; } // 0x000000018431CF10-0x000000018431CFC0 
		public MonoSimpleReusableList upList { /* [XID] */ /* 0x00000001899D8700-0x00000001899D8720 */ get => default; } // 0x000000018431CFC0-0x000000018431D070 
		public RectTransform mpUpGrp { /* [XID] */ /* 0x00000001899DFDF0-0x00000001899DFE10 */ get => default; } // 0x000000018431C200-0x000000018431C2B0 
		public MonoSimpleReusableList mpUpList { /* [XID] */ /* 0x00000001899E7820-0x00000001899E7840 */ get => default; } // 0x000000018431C2B0-0x000000018431C360 
		public MonoUIContainer changeBtnSwitch { /* [XID] */ /* 0x00000001899EED90-0x00000001899EEDB0 */ get => default; } // 0x000000018431B7F0-0x000000018431B8B0 
		public bool showFastModeSubmitButton { /* [XID] */ /* 0x00000001899F6650-0x00000001899F6670 */ set {} } // 0x000000018431DF30-0x000000018431E000
		public MonoUIContainer cancleBtnContainer { /* [XID] */ /* 0x00000001899FDBD0-0x00000001899FDBF0 */ get => default; } // 0x000000018431B750-0x000000018431B7F0 
		public bool showPrevTeamBtn { /* [XID] */ /* 0x0000000189A055B0-0x0000000189A055D0 */ set {} } // 0x000000018431E870-0x000000018431E950
		public Button prevTeamBtn { /* [XID] */ /* 0x0000000189A0C8D0-0x0000000189A0C8F0 */ get => default; } // 0x000000018431C410-0x000000018431C4C0 
		public bool showTeamSwitchGrp { /* [XID] */ /* 0x0000000189A14240-0x0000000189A14260 */ set {} } // 0x000000018431EC30-0x000000018431ED10
		public bool showNextTeamBtn { /* [XID] */ /* 0x0000000189A1B4F0-0x0000000189A1B510 */ set {} } // 0x000000018431E3E0-0x000000018431E4C0
		public Button nextTeamBtn { /* [XID] */ /* 0x0000000189A22E30-0x0000000189A22E50 */ get => default; } // 0x000000018431C360-0x000000018431C410 
		public MonoUIContainer backBtnContainer { /* [XID] */ /* 0x0000000189A2A100-0x0000000189A2A120 */ get => default; } // 0x000000018431B200-0x000000018431B2C0 
		public MonoReusableList tabPanel { /* [XID] */ /* 0x0000000189A31580-0x0000000189A315A0 */ get => default; } // 0x000000018431CB00-0x000000018431CBA0 
		public RectTransform[] teamAvatarBtns { /* [XID] */ /* 0x0000000189A39030-0x0000000189A39050 */ get => default; } // 0x000000018431CBA0-0x000000018431CC50 
		public GameObject grpTeam { /* [XID] */ /* 0x0000000189A40810-0x0000000189A40830 */ get => default; } // 0x000000018431BE70-0x000000018431BF20 
		public GameObject grpAvatar { /* [XID] */ /* 0x0000000189A47EB0-0x0000000189A47ED0 */ get => default; } // 0x000000018431BDC0-0x000000018431BE70 
		public MonoCostLabel costLabel { /* [XID] */ /* 0x0000000189A4F670-0x0000000189A4F690 */ get => default; } // 0x000000018431B950-0x000000018431BA00 
		public MonoUIContainer detailBtnContainer { /* [XID] */ /* 0x0000000189A56D90-0x0000000189A56DB0 */ get => default; } // 0x000000018431BA00-0x000000018431BAC0 
		public Button blankBtn { /* [XID] */ /* 0x0000000189A5E8C0-0x0000000189A5E8E0 */ get => default; } // 0x000000018431B380-0x000000018431B430 
		public float teamBtnHoldTime { /* [XID] */ /* 0x0000000189A66080-0x0000000189A660A0 */ get => default; } // 0x000000018431CD00-0x000000018431CDB0 
		public SmoothMask holdTimeBarFill { /* [XID] */ /* 0x0000000189A6D6F0-0x0000000189A6D710 */ get => default; } // 0x000000018431BF20-0x000000018431BFD0 
		public GameObject holdTimeBar { /* [XID] */ /* 0x0000000189A74E10-0x0000000189A74E30 */ get => default; } // 0x000000018431BFD0-0x000000018431C080 
		public float teamBtnHoldShowTime { /* [XID] */ /* 0x0000000189A7CA60-0x0000000189A7CA80 */ get => default; } // 0x000000018431CC50-0x000000018431CD00 
		public bool showTeamIcon { /* [XID] */ /* 0x0000000189A84380-0x0000000189A843A0 */ set {} } // 0x000000018431EB40-0x000000018431EC30
		public bool showDungeonIcon { /* [XID] */ /* 0x0000000189A8BCF0-0x0000000189A8BD10 */ set {} } // 0x000000018431DC30-0x000000018431DD10
		public Sprite dungeonIcon { /* [XID] */ /* 0x0000000189A93240-0x0000000189A93260 */ set {} } // 0x000000018431D070-0x000000018431D140
		public bool showAvatarIcon { /* [XID] */ /* 0x0000000189A9ACA0-0x0000000189A9ACC0 */ set {} } // 0x000000018431D6E0-0x000000018431D7C0
		public bool showTitleGrp { /* [XID] */ /* 0x0000000189AA1FD0-0x0000000189AA1FF0 */ set {} } // 0x000000018431ED10-0x000000018431EDF0
		public MonoUIContainer avatarIcon { /* [XID] */ /* 0x0000000189AA9490-0x0000000189AA94B0 */ get => default; } // 0x000000018431B0B0-0x000000018431B160 
		public UnityEngine.UI.Text titleText { /* [XID] */ /* 0x0000000189AB13B0-0x0000000189AB13D0 */ get => default; } // 0x000000018431CE60-0x000000018431CF10 
		public bool showNoAvatarTip { /* [XID] */ /* 0x0000000189AB8640-0x0000000189AB8660 */ set {} } // 0x000000018431E4C0-0x000000018431E5B0
		public bool showAvatarInfo { /* [XID] */ /* 0x0000000189AC0320-0x0000000189AC0340 */ set {} } // 0x000000018431D7C0-0x000000018431D900
		public bool showStartBtnGrp { /* [XID] */ /* 0x0000000189ACF260-0x0000000189ACF280 */ set {} } // 0x000000018431EA30-0x000000018431EB40
		public Button startButton { /* [XID] */ /* 0x0000000189AD7130-0x0000000189AD7150 */ get => default; } // 0x000000018431CA40-0x000000018431CB00 
		public bool showBackBtnGrp { /* [XID] */ /* 0x0000000189ADEAF0-0x0000000189ADEB10 */ set {} } // 0x000000018431D900-0x000000018431DA10
		public Button backButton { /* [XID] */ /* 0x0000000189AE64E0-0x0000000189AE6500 */ get => default; } // 0x000000018431B2C0-0x000000018431B380 
		public bool showInfoBtnGrp { /* [XID] */ /* 0x0000000189AEDCB0-0x0000000189AEDCD0 */ set {} } // 0x000000018431E000-0x000000018431E110
		public Button infoButton { /* [XID] */ /* 0x0000000189AF5540-0x0000000189AF5560 */ get => default; } // 0x000000018431C080-0x000000018431C140 
		public bool showInviteBtnGrp { /* [XID] */ /* 0x0000000189AFCA30-0x0000000189AFCA50 */ set {} } // 0x000000018431E110-0x000000018431E220
		public bool showActionSelectBtn { /* [XID] */ /* 0x0000000189B041B0-0x0000000189B041D0 */ set {} } // 0x000000018431D5D0-0x000000018431D6E0
		public bool showActionCancelBtn { /* [XID] */ /* 0x0000000189B0BA70-0x0000000189B0BA90 */ set {} } // 0x000000018431D4C0-0x000000018431D5D0
		public bool showCloseBtn { /* [XID] */ /* 0x0000000189B12F40-0x0000000189B12F60 */ set {} } // 0x000000018431DB20-0x000000018431DC30
		public bool showChangeBtn { /* [XID] */ /* 0x0000000189B1A650-0x0000000189B1A670 */ set {} } // 0x000000018431DA10-0x000000018431DB20
		public Button inviteButton { /* [XID] */ /* 0x0000000189B21BE0-0x0000000189B21C00 */ get => default; } // 0x000000018431C140-0x000000018431C200 
		public string inviteButtonText { /* [XID] */ /* 0x0000000189B292E0-0x0000000189B29300 */ set {} } // 0x000000018431D230-0x000000018431D320
		public RectTransform grpAvatarList { /* [XID] */ /* 0x0000000189B306F0-0x0000000189B30710 */ get => default; } // 0x000000018431BD10-0x000000018431BDC0 
		public Button fastButton { /* [XID] */ /* 0x0000000189B37F90-0x0000000189B37FB0 */ get => default; } // 0x000000018431BC50-0x000000018431BD10 
		public bool showFastBtnGrp { /* [XID] */ /* 0x0000000189B3F9C0-0x0000000189B3F9E0 */ set {} } // 0x000000018431DE20-0x000000018431DF30
		public bool showEnableBtnGrp { /* [XID] */ /* 0x0000000189B471E0-0x0000000189B47200 */ set {} } // 0x000000018431DD10-0x000000018431DE20
		public Button enableButton { /* [XID] */ /* 0x0000000189B4E9A0-0x0000000189B4E9C0 */ get => default; } // 0x000000018431BB90-0x000000018431BC50 
		public string enableButtonText { /* [XID] */ /* 0x0000000189B561E0-0x0000000189B56200 */ set {} } // 0x000000018431D140-0x000000018431D230
		public bool showNotEnableBtnGrp { /* [XID] */ /* 0x0000000189B5DA60-0x0000000189B5DA80 */ set {} } // 0x000000018431E5B0-0x000000018431E760
		public bool showNotEnableButton { /* [XID] */ /* 0x0000000189B64FC0-0x0000000189B64FE0 */ set {} } // 0x000000018431E760-0x000000018431E870
		public bool showRecommendElementsGrp { /* [XID] */ /* 0x0000000189B6C5A0-0x0000000189B6C5C0 */ set {} } // 0x000000018431E950-0x000000018431EA30
		public string recommendElementsTitle { /* [XID] */ /* 0x0000000189B73D10-0x0000000189B73D30 */ set {} } // 0x000000018431D3F0-0x000000018431D4C0
		public MonoReusableList recommendElementsList { /* [XID] */ /* 0x0000000189B7B380-0x0000000189B7B3A0 */ get => default; } // 0x000000018431C4C0-0x000000018431C570 
		public UnityEngine.Material recommendGreyMatarial { /* [XID] */ /* 0x0000000189B82CA0-0x0000000189B82CC0 */ get => default; } // 0x000000018431C570-0x000000018431C620 
		public Dropdown dropDown { /* [XID] */ /* 0x0000000189B8A2A0-0x0000000189B8A2C0 */ get => default; } // 0x000000018431BAC0-0x000000018431BB90 
		public Button btnSort { /* [XID] */ /* 0x0000000189B91900-0x0000000189B91920 */ get => default; } // 0x000000018431B680-0x000000018431B750 
		public Button btnScreen { /* [XID] */ /* 0x0000000189B98CC0-0x0000000189B98CE0 */ get => default; } // 0x000000018431B5B0-0x000000018431B680 
		public Button btnJoypadPreTeam { /* [XID] */ /* 0x0000000189BA00E0-0x0000000189BA0100 */ get => default; } // 0x000000018431B4F0-0x000000018431B5B0 
		public Button btnJoypadNextTeam { /* [XID] */ /* 0x0000000189BA7920-0x0000000189BA7940 */ get => default; } // 0x000000018431B430-0x000000018431B4F0 
		public bool showMPTitleGrp { /* [XID] */ /* 0x0000000189BAEC50-0x0000000189BAEC70 */ set {} } // 0x000000018431E220-0x000000018431E300
		public string mpTitle { /* [XID] */ /* 0x0000000189BB6340-0x0000000189BB6360 */ set {} } // 0x000000018431D320-0x000000018431D3F0
		public bool showMPTitleRecommendElementGrp { /* [XID] */ /* 0x0000000189BBD940-0x0000000189BBD960 */ set {} } // 0x000000018431E300-0x000000018431E3E0
		public MonoSimpleReusableList titleRecommendElement { /* [XID] */ /* 0x0000000189BC56A0-0x0000000189BC56C0 */ get => default; } // 0x000000018431CDB0-0x000000018431CE60 
		public GameObject resonancePanel { /* [XID] */ /* 0x0000000189BCD0A0-0x0000000189BCD0C0 */ get => default; } // 0x000000018431C780-0x000000018431C830 
		public MonoSimpleReusableList resonanceList { /* [XID] */ /* 0x0000000189BD4620-0x0000000189BD4640 */ get => default; } // 0x000000018431C6D0-0x000000018431C780 
		public ScrollRect resonanceScroller { /* [XID] */ /* 0x0000000189BDC190-0x0000000189BDC1B0 */ get => default; } // 0x000000018431C8E0-0x000000018431C990 
		public GameObject resonanceSelectRoot { /* [XID] */ /* 0x00000001895E89D0-0x00000001895E89F0 */ get => default; } // 0x000000018431C990-0x000000018431CA40 
		public MonoUIContainer resonanceBtn { /* [XID] */ /* 0x00000001895F0220-0x00000001895F0240 */ get => default; } // 0x000000018431C620-0x000000018431C6D0 
		public MonoUIContainer resonanceRegionBtn { /* [XID] */ /* 0x00000001895F7CF0-0x00000001895F7D10 */ get => default; } // 0x000000018431C830-0x000000018431C8E0 
	
		// Constructors
		public MonoInLevelTeamPage() {} // 0x000000018431AF30-0x000000018431B0B0
	
		// Methods
		// [XID] // 0x0000000189AC7D20-0x0000000189AC7D40
		protected override void OnDestroy() {} // 0x000000018431AE10-0x000000018431AF30
	}
}
