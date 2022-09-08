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
	public class MonoFriendInformationDialog : MonoUIProxy // TypeDefIndex: 30547
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _playerUID; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _nickname; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _remarkname; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _playerLevel; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _worldLevel; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _signature; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _signatureRect; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _returnBtn; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _ps4ID; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _blockChatImg; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _joypadBtnGroup; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _cardImg; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _signatureBtn; // 0xB0
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _editPanel; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _editReturnBtn; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _editScroller; // 0xC8
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text _achievementTxt; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _towerTxt; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _towerNoDataTxt; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _toggleTxt; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _iconHide; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _avatarEmptyGrp; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _toggleGrp; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _avatarScroller; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _toggle; // 0x110
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoUIContainer _mainPageBtn; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _achievementGrp; // 0x120
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _avatarGrp; // 0x128
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoUIContainer _nameCardBtn; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _nameCardGrp; // 0x138
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _nameCardScroller; // 0x140
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _nameCardEmptyGrp; // 0x148
	
		// Properties
		public UnityEngine.UI.Text playerUID { /* [XID] */ /* 0x000000018965A5A0-0x000000018965A5C0 */ get => default; } // 0x0000000184AE9F80-0x0000000184AEA020 
		public UnityEngine.UI.Text nickname { /* [XID] */ /* 0x0000000189661BF0-0x0000000189661C10 */ get => default; } // 0x0000000184AE9E40-0x0000000184AE9EE0 
		public UnityEngine.UI.Text remarkname { /* [XID] */ /* 0x0000000189669790-0x00000001896697B0 */ get => default; } // 0x0000000184AEA190-0x0000000184AEA230 
		public UnityEngine.UI.Text playerLevel { /* [XID] */ /* 0x0000000189671280-0x00000001896712A0 */ get => default; } // 0x0000000184AE9EE0-0x0000000184AE9F80 
		public UnityEngine.UI.Text worldLevel { /* [XID] */ /* 0x0000000189678B40-0x0000000189678B60 */ get => default; } // 0x0000000184AEA800-0x0000000184AEA8A0 
		public UnityEngine.UI.Text signature { /* [XID] */ /* 0x0000000189680180-0x00000001896801A0 */ get => default; } // 0x0000000184AEA450-0x0000000184AEA4F0 
		public UnityEngine.UI.Text achievementTxt { /* [XID] */ /* 0x0000000189687D90-0x0000000189687DB0 */ get => default; } // 0x0000000184AE90C0-0x0000000184AE9170 
		public UnityEngine.UI.Text towerTxt { /* [XID] */ /* 0x000000018968F790-0x000000018968F7B0 */ get => default; } // 0x0000000184AEA750-0x0000000184AEA800 
		public UnityEngine.UI.Text towerNoDataTxt { /* [XID] */ /* 0x00000001896971D0-0x00000001896971F0 */ get => default; } // 0x0000000184AEA6A0-0x0000000184AEA750 
		public UnityEngine.UI.Text toggleTxt { /* [XID] */ /* 0x000000018969E720-0x000000018969E740 */ get => default; } // 0x0000000184AEA4F0-0x0000000184AEA5A0 
		public Image cardImg { /* [XID] */ /* 0x00000001896A5790-0x00000001896A57B0 */ get => default; } // 0x0000000184AE92D0-0x0000000184AE9380 
		public Button editSignatureBtn { /* [XID] */ /* 0x00000001896ACFB0-0x00000001896ACFD0 */ get => default; } // 0x0000000184AE9890-0x0000000184AE9940 
		public bool showIconHide { /* [XID] */ /* 0x00000001896B4620-0x00000001896B4640 */ set {} } // 0x0000000184AEAA50-0x0000000184AEAB40
		public bool showAvatarEmptyGrp { /* [XID] */ /* 0x00000001896BB850-0x00000001896BB870 */ set {} } // 0x0000000184AEA960-0x0000000184AEAA50
		public bool showToggleGrp { /* [XID] */ /* 0x00000001896C2CA0-0x00000001896C2CC0 */ set {} } // 0x0000000184AEAED0-0x0000000184AEAFC0
		public MonoGridScroller avatarScroller { /* [XID] */ /* 0x00000001896CA1C0-0x00000001896CA1E0 */ get => default; } // 0x0000000184AE9170-0x0000000184AE9220 
		public Toggle toggle { /* [XID] */ /* 0x00000001896D1890-0x00000001896D18B0 */ get => default; } // 0x0000000184AEA5A0-0x0000000184AEA6A0 
		public RectTransform signatureRect { /* [XID] */ /* 0x00000001896D9090-0x00000001896D90B0 */ get => default; } // 0x0000000184AEA3A0-0x0000000184AEA450 
		public MonoUIContainer leftBtn { /* [XID] */ /* 0x00000001896E0910-0x00000001896E0930 */ get => default; } // 0x0000000184AE9AB0-0x0000000184AE9B70 
		public MonoUIContainer rightBtn { /* [XID] */ /* 0x00000001896E7B70-0x00000001896E7B90 */ get => default; } // 0x0000000184AEA2E0-0x0000000184AEA3A0 
		public Sprite icon { /* [XID] */ /* 0x00000001896EF210-0x00000001896EF230 */ set {} } // 0x0000000184AEA8A0-0x0000000184AEA960
		public Button returnBtn { /* [XID] */ /* 0x00000001896F6C20-0x00000001896F6C40 */ get => default; } // 0x0000000184AEA230-0x0000000184AEA2E0 
		public MonoUIContainer ps4ID { /* [XID] */ /* 0x00000001896FE500-0x00000001896FE520 */ get => default; } // 0x0000000184AEA0E0-0x0000000184AEA190 
		public RectTransform blockChatImg { /* [XID] */ /* 0x0000000189705660-0x0000000189705680 */ get => default; } // 0x0000000184AE9220-0x0000000184AE92D0 
		public RectTransform joypadBtnGroup { /* [XID] */ /* 0x000000018970D160-0x000000018970D180 */ get => default; } // 0x0000000184AE9A00-0x0000000184AE9AB0 
		public MonoUIContainer editBtn { /* [XID] */ /* 0x00000001897145B0-0x00000001897145D0 */ get => default; } // 0x0000000184AE9500-0x0000000184AE95C0 
		public MonoUIContainer closeBtn { /* [XID] */ /* 0x000000018971C030-0x000000018971C050 */ get => default; } // 0x0000000184AE9440-0x0000000184AE9500 
		public MonoUIContainer checkBtn { /* [XID] */ /* 0x00000001897234E0-0x0000000189723500 */ get => default; } // 0x0000000184AE9380-0x0000000184AE9440 
		public MonoUIContainer editSignatureContainer { /* [XID] */ /* 0x000000018972AC20-0x000000018972AC40 */ get => default; } // 0x0000000184AE9940-0x0000000184AE9A00 
		public MonoUIContainer editShowCaseContainer { /* [XID] */ /* 0x0000000189732330-0x0000000189732350 */ get => default; } // 0x0000000184AE97D0-0x0000000184AE9890 
		public RectTransform editPanel { /* [XID] */ /* 0x0000000189739A20-0x0000000189739A40 */ get => default; } // 0x0000000184AE95C0-0x0000000184AE9670 
		public Button editReturnBtn { /* [XID] */ /* 0x00000001897415E0-0x0000000189741600 */ get => default; } // 0x0000000184AE9670-0x0000000184AE9720 
		public MonoGridScroller editScroller { /* [XID] */ /* 0x0000000189748EC0-0x0000000189748EE0 */ get => default; } // 0x0000000184AE9720-0x0000000184AE97D0 
		public MonoUIContainer mainPageBtn { /* [XID] */ /* 0x0000000189750370-0x0000000189750390 */ get => default; } // 0x0000000184AE9B70-0x0000000184AE9C20 
		public MonoUIContainer nameCardBtn { /* [XID] */ /* 0x0000000189757910-0x0000000189757930 */ get => default; } // 0x0000000184AE9C20-0x0000000184AE9CD0 
		public MonoUIContainer prevTabBtn { /* [XID] */ /* 0x000000018975F310-0x000000018975F330 */ get => default; } // 0x0000000184AEA020-0x0000000184AEA0E0 
		public MonoUIContainer nextTabBtn { /* [XID] */ /* 0x00000001897667A0-0x00000001897667C0 */ get => default; } // 0x0000000184AE9D80-0x0000000184AE9E40 
		public bool showMainPage { /* [XID] */ /* 0x000000018976DDB0-0x000000018976DDD0 */ set {} } // 0x0000000184AEAB40-0x0000000184AEAC80
		public bool showNameCard { /* [XID] */ /* 0x0000000189775510-0x0000000189775530 */ set {} } // 0x0000000184AEAD90-0x0000000184AEAED0
		public MonoGridScroller nameCardScroller { /* [XID] */ /* 0x000000018977CD70-0x000000018977CD90 */ get => default; } // 0x0000000184AE9CD0-0x0000000184AE9D80 
		public bool showNameCardEmptyGrp { /* [XID] */ /* 0x0000000189784790-0x00000001897847B0 */ set {} } // 0x0000000184AEAC80-0x0000000184AEAD90
	
		// Constructors
		public MonoFriendInformationDialog() {} // 0x0000000184AE8F80-0x0000000184AE90C0
	}
}
