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
	public class MonoInLevelPlayerProfilePage : MonoUIProxy // TypeDefIndex: 29760
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text _playerName; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _playerLv; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _playerExp; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Slider _playerExpSlider; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _playerID; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _playerCost; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _playerInfo; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _playerNum; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public Image playerIconImage; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _playerWorldLv; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _playerBirthday; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _playerSignature; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _playerNoSignature; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _playerSignatureRect; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _nameCardPic; // 0xB0
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Button _closeButton; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MihoyoGridLayoutGroup _menuEntryLayout; // 0xC8
		// [Header] // 0x0000000189B1C090-0x0000000189B1C0E0
		[SerializeField] // 0x0000000189B1C090-0x0000000189B1C0E0
		private MonoReusableList _entryList; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<PaimonEntryConfig> _entryConfigs; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _playerLevelBtn; // 0xE0
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Vector3 _offsetPos; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public float transDuration; // 0xF4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public float transLerpRatio; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public StoryCameraLerpPattern lerpPattern; // 0xFC
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoUIContainer _photographBtn; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _bulletinBtn; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _mailBtn; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _timeBtn; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _settingBtn; // 0x120
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Button _iconBtn; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _editBtn; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _editPanel; // 0x138
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _editReturnBtn; // 0x140
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _editHeadPortraitBtn; // 0x148
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _editNameCardBtn; // 0x150
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _editSignatureBtn; // 0x158
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _editNameBtn; // 0x160
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _editCopyUidBtn; // 0x168
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _editBirthdayBtn; // 0x170
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _editProfileBtn; // 0x178
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _worldLvInfoBtn; // 0x180
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _copyBtn; // 0x188
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _copyText; // 0x190
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _ps4OnlineID; // 0x198
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _ps4OnlineIDText; // 0x1A0
	
		// Properties
		public Vector3 offsetPos { /* [XID] */ /* 0x00000001895FF090-0x00000001895FF0B0 */ get => default; } // 0x0000000183D724C0-0x0000000183D725A0 
		public UnityEngine.UI.Text playerName { /* [XID] */ /* 0x0000000189606910-0x0000000189606930 */ get => default; } // 0x0000000183D72B80-0x0000000183D72C20 
		public UnityEngine.UI.Text playerLv { /* [XID] */ /* 0x000000018960E290-0x000000018960E2B0 */ get => default; } // 0x0000000183D72AE0-0x0000000183D72B80 
		public UnityEngine.UI.Text playerExp { /* [XID] */ /* 0x0000000189615920-0x0000000189615940 */ get => default; } // 0x0000000183D72840-0x0000000183D728E0 
		public Slider playerExpSlider { /* [XID] */ /* 0x000000018961D100-0x000000018961D120 */ get => default; } // 0x0000000183D727A0-0x0000000183D72840 
		public UnityEngine.UI.Text playerID { /* [XID] */ /* 0x0000000189624630-0x0000000189624650 */ get => default; } // 0x0000000183D728E0-0x0000000183D72980 
		public UnityEngine.UI.Text playerCost { /* [XID] */ /* 0x000000018962BD70-0x000000018962BD90 */ get => default; } // 0x0000000183D72700-0x0000000183D727A0 
		public UnityEngine.UI.Text playerInfo { /* [XID] */ /* 0x0000000189633890-0x00000001896338B0 */ get => default; } // 0x0000000183D72980-0x0000000183D72A20 
		public UnityEngine.UI.Text playerNum { /* [XID] */ /* 0x000000018963B190-0x000000018963B1B0 */ get => default; } // 0x0000000183D72CD0-0x0000000183D72D70 
		public UnityEngine.UI.Text playerWorldLv { /* [XID] */ /* 0x00000001896428C0-0x00000001896428E0 */ get => default; } // 0x0000000183D72ED0-0x0000000183D72F80 
		public UnityEngine.UI.Text playerBirthday { /* [XID] */ /* 0x0000000189649FB0-0x0000000189649FD0 */ get => default; } // 0x0000000183D72650-0x0000000183D72700 
		public UnityEngine.UI.Text playerSignature { /* [XID] */ /* 0x00000001896516B0-0x00000001896516D0 */ get => default; } // 0x0000000183D72E20-0x0000000183D72ED0 
		public UnityEngine.UI.Text playerNoSignature { /* [XID] */ /* 0x0000000189658EF0-0x0000000189658F10 */ get => default; } // 0x0000000183D72C20-0x0000000183D72CD0 
		public RectTransform playerSignatureRect { /* [XID] */ /* 0x00000001896605C0-0x00000001896605E0 */ get => default; } // 0x0000000183D72D70-0x0000000183D72E20 
		public Image nameCardPic { /* [XID] */ /* 0x0000000189667F00-0x0000000189667F20 */ get => default; } // 0x0000000183D72410-0x0000000183D724C0 
		public Button logoutButton { /* [XID] */ /* 0x000000018966F970-0x000000018966F990 */ get => default; } // 0x0000000183D720D0-0x0000000183D722B0 
		public MonoMaskController logoutButtonMask { /* [XID] */ /* 0x00000001896772E0-0x0000000189677300 */ get => default; } // 0x0000000183D71EF0-0x0000000183D720D0 
		public Button playerLevelBtn { /* [XID] */ /* 0x000000018967E850-0x000000018967E870 */ get => default; } // 0x0000000183D72A20-0x0000000183D72AE0 
		public Button closeButton { /* [XID] */ /* 0x0000000189686100-0x0000000189686120 */ get => default; } // 0x0000000183D713F0-0x0000000183D714A0 
		public MihoyoGridLayoutGroup menuEntryLayout { /* [XID] */ /* 0x000000018968DEF0-0x000000018968DF10 */ get => default; } // 0x0000000183D72360-0x0000000183D72410 
		public MonoReusableList entryList { /* [XID] */ /* 0x0000000189695800-0x0000000189695820 */ get => default; } // 0x0000000183D71D90-0x0000000183D71E40 
		public List<PaimonEntryConfig> entryConfigs { /* [XID] */ /* 0x000000018969CE90-0x000000018969CEB0 */ get => default; } // 0x0000000183D71CE0-0x0000000183D71D90 
		public MonoUIContainer photographBtn { /* [XID] */ /* 0x00000001896A41A0-0x00000001896A41C0 */ get => default; } // 0x0000000183D725A0-0x0000000183D72650 
		public MonoUIContainer bulletinBtn { /* [XID] */ /* 0x00000001896AB760-0x00000001896AB780 */ get => default; } // 0x0000000183D71340-0x0000000183D713F0 
		public MonoUIContainer mailBtn { /* [XID] */ /* 0x00000001896B2990-0x00000001896B29B0 */ get => default; } // 0x0000000183D722B0-0x0000000183D72360 
		public MonoUIContainer timeBtn { /* [XID] */ /* 0x00000001896BA120-0x00000001896BA140 */ get => default; } // 0x0000000183D73320-0x0000000183D733D0 
		public MonoUIContainer settingBtn { /* [XID] */ /* 0x00000001896C1390-0x00000001896C13B0 */ get => default; } // 0x0000000183D73270-0x0000000183D73320 
		public MonoUIContainer returnBtn { /* [XID] */ /* 0x00000001896C8A90-0x00000001896C8AB0 */ get => default; } // 0x0000000183D730E0-0x0000000183D73270 
		public Button iconBtn { /* [XID] */ /* 0x00000001896D0480-0x00000001896D04A0 */ get => default; } // 0x0000000183D71E40-0x0000000183D71EF0 
		public MonoUIContainer editBtn { /* [XID] */ /* 0x00000001896D7980-0x00000001896D79A0 */ get => default; } // 0x0000000183D716B0-0x0000000183D71760 
		public RectTransform editPanel { /* [XID] */ /* 0x00000001896DF1E0-0x00000001896DF200 */ get => default; } // 0x0000000183D71A20-0x0000000183D71AD0 
		public Button editReturnBtn { /* [XID] */ /* 0x00000001896E6610-0x00000001896E6630 */ get => default; } // 0x0000000183D71B80-0x0000000183D71C30 
		public MonoUIContainer editNameBtn { /* [XID] */ /* 0x00000001896EDB60-0x00000001896EDB80 */ get => default; } // 0x0000000183D718C0-0x0000000183D71970 
		public MonoUIContainer editSignatureBtn { /* [XID] */ /* 0x00000001896F5390-0x00000001896F53B0 */ get => default; } // 0x0000000183D71C30-0x0000000183D71CE0 
		public MonoUIContainer editHeadPortraitBtn { /* [XID] */ /* 0x00000001896FCBD0-0x00000001896FCBF0 */ get => default; } // 0x0000000183D71810-0x0000000183D718C0 
		public MonoUIContainer editNameCardBtn { /* [XID] */ /* 0x0000000189704050-0x0000000189704070 */ get => default; } // 0x0000000183D71970-0x0000000183D71A20 
		public MonoUIContainer editCopyUidBtn { /* [XID] */ /* 0x000000018970B960-0x000000018970B980 */ get => default; } // 0x0000000183D71760-0x0000000183D71810 
		public MonoUIContainer editBirthdayBtn { /* [XID] */ /* 0x0000000189713230-0x0000000189713250 */ get => default; } // 0x0000000183D71600-0x0000000183D716B0 
		public MonoUIContainer editProfileBtn { /* [XID] */ /* 0x000000018971A9F0-0x000000018971AA10 */ get => default; } // 0x0000000183D71AD0-0x0000000183D71B80 
		public MonoUIContainer worldLvInfoBtn { /* [XID] */ /* 0x0000000189721D50-0x0000000189721D70 */ get => default; } // 0x0000000183D733D0-0x0000000183D73480 
		public Button copyBtn { /* [XID] */ /* 0x00000001897293E0-0x0000000189729400 */ get => default; } // 0x0000000183D714A0-0x0000000183D71550 
		public RectTransform copyText { /* [XID] */ /* 0x0000000189730C00-0x0000000189730C20 */ get => default; } // 0x0000000183D71550-0x0000000183D71600 
		public RectTransform ps4OnlineID { /* [XID] */ /* 0x0000000189738530-0x0000000189738550 */ get => default; } // 0x0000000183D73030-0x0000000183D730E0 
		public UnityEngine.UI.Text ps4OnlineIDText { /* [XID] */ /* 0x00000001897402D0-0x00000001897402F0 */ get => default; } // 0x0000000183D72F80-0x0000000183D73030 
	
		// Constructors
		public MonoInLevelPlayerProfilePage() {} // 0x0000000183D711B0-0x0000000183D71340
	}
}
