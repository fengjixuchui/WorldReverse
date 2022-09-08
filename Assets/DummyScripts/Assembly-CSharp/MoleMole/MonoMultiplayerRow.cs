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
	public class MonoMultiplayerRow : MonoBehaviour, EditMenuTarget // TypeDefIndex: 30981
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Animator _animator; // 0x18
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Image _icon; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _iconBtn; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _blockChatImg; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _nameLabel; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _levelLabel; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _uidLabel; // 0x48
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoUIContainer _requestBtn; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _requestingGrp; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _unreachableLable; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _selectBtn; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _onlineID; // 0x70
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private GameObject _imgL; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _imgR; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _nameCardPic; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _signatureText; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _signature; // 0x98
		public MonoUIContainer joinButtonContainer; // 0xA0
		private MonoFriendJoinButton _joinButton; // 0xA8
		public GameObject joinNumberGo; // 0xB0
		public UnityEngine.UI.Text numberText; // 0xB8
		[NonSerialized]
		public int applyCooldown; // 0xC0
		private int _index; // 0xC4
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private GameObject _avatarIconSelector; // 0xC8
	
		// Properties
		public UnityEngine.UI.Text signatureText { /* [XID] */ /* 0x00000001898C0C90-0x00000001898C0CB0 */ get => default; } // 0x0000000182F24990-0x0000000182F24A40 
		public RectTransform signature { /* [XID] */ /* 0x00000001898C8530-0x00000001898C8550 */ get => default; } // 0x0000000182F24A40-0x0000000182F24AF0 
		public Animator animator { /* [XID] */ /* 0x00000001898CFF40-0x00000001898CFF60 */ get => default; } // 0x0000000182F245D0-0x0000000182F24670 
		public Image icon { /* [XID] */ /* 0x00000001898D7510-0x00000001898D7530 */ get => default; } // 0x0000000182F247B0-0x0000000182F24850 
		public Button iconBtn { /* [XID] */ /* 0x00000001898DF260-0x00000001898DF280 */ get => default; } // 0x0000000182F24710-0x0000000182F247B0 
		public RectTransform blockChatImg { /* [XID] */ /* 0x00000001898E6C40-0x00000001898E6C60 */ get => default; } // 0x0000000182F24670-0x0000000182F24710 
		public string playerName { /* [XID] */ /* 0x00000001898EE370-0x00000001898EE390 */ set {} } // 0x0000000182F24FE0-0x0000000182F250B0
		public string onlineID { /* [XID] */ /* 0x00000001898F5BC0-0x00000001898F5BE0 */ set {} } // 0x0000000182F24E80-0x0000000182F24FE0
		public bool showOnlineID { /* [XID] */ /* 0x00000001898FD360-0x00000001898FD380 */ set {} } // 0x0000000182F251B0-0x0000000182F25290
		public string levelString { /* [XID] */ /* 0x0000000189904C40-0x0000000189904C60 */ set {} } // 0x0000000182F24BA0-0x0000000182F24C70
		public string uidString { /* [XID] */ /* 0x000000018990C460-0x000000018990C480 */ set {} } // 0x0000000182F25290-0x0000000182F25360
		public string numberString { /* [XID] */ /* 0x0000000189913D50-0x0000000189913D70 */ set {} } // 0x0000000182F24DB0-0x0000000182F24E80
		public MonoFriendJoinButton JoinButton { /* [XID] */ /* 0x000000018991B6C0-0x000000018991B6E0 */ get => default; } // 0x0000000182F244C0-0x0000000182F245D0 
		public MonoUIContainer requestButton { /* [XID] */ /* 0x0000000189922C60-0x0000000189922C80 */ get => default; } // 0x0000000182F248F0-0x0000000182F24990 
		public string requestButtonText { /* [XID] */ /* 0x000000018992A550-0x000000018992A570 */ set {} } // 0x0000000182F250B0-0x0000000182F251B0
		public string unreachableString { /* [XID] */ /* 0x0000000189931B00-0x0000000189931B20 */ set {} } // 0x0000000182F25360-0x0000000182F25430
		public int index { /* [XID] */ /* 0x0000000189939560-0x0000000189939580 */ get => default; /* [XID] */ /* 0x0000000189940870-0x0000000189940890 */ set {} } // 0x0000000182F24850-0x0000000182F248F0 0x0000000182F24AF0-0x0000000182F24BA0
		private bool showDefaultNameCard { /* [XID] */ /* 0x0000000189956E10-0x0000000189956E30 */ set {} } // 0x0000000182F23660-0x0000000182F23790
		public Sprite nameCardPic { /* [XID] */ /* 0x000000018995E960-0x000000018995E980 */ set {} } // 0x0000000182F24C70-0x0000000182F24DB0
	
		// Nested types
		public enum Option // TypeDefIndex: 30982
		{
			None = 0,
			RequestButton = 1,
			RequestingHint = 2,
			UnreachableHint = 3
		}
	
		public enum SelectState // TypeDefIndex: 30983
		{
			None = 0,
			Select = 1,
			UnSelect = 2
		}
	
		// Constructors
		public MonoMultiplayerRow() {} // 0x0000000182F24400-0x0000000182F244C0
	
		// Methods
		// [XID] // 0x00000001899480F0-0x0000000189948110
		public void ShowOption(Option option) {} // 0x0000000182F242D0-0x0000000182F24400
		// [XID] // 0x000000018994F870-0x000000018994F890
		public void SetSelectState(SelectState state) {} // 0x0000000182F24090-0x0000000182F242D0
		// [XID] // 0x0000000189966060-0x0000000189966080
		public void RefreshRequestButton(MPRequestState state, uint uid, HostPlayerData playerData) {} // 0x0000000182F23990-0x0000000182F24090
		// [XID] // 0x000000018996D500-0x000000018996D520
		RectTransform MoleMole.EditMenuTarget.GetTransform() => default; // 0x0000000182F23790-0x0000000182F238A0
		// [XID] // 0x00000001899750C0-0x00000001899750E0
		void MoleMole.EditMenuTarget.Selected(bool selected) {} // 0x0000000182F238A0-0x0000000182F23990
	}
}
