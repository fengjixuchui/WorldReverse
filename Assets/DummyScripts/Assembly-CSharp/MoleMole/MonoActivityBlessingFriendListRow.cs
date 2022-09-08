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
	public class MonoActivityBlessingFriendListRow : MonoBehaviour // TypeDefIndex: 30679
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x18
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Image _icon; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _iconBtn; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _nameLabel; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoRemarkNameColor _remarkNameColor; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _levelLabel; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _signature; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _signatureText; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _mPTeamLabel; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _ps4ID; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _blockChatImg; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _requestingGrp; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _unreachableLable; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _tipsLable; // 0x80
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private GameObject _imgL; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _imgR; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _nameCardPic; // 0x98
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public MonoUIContainer ChatBtn; // 0xA0
		private MonoFriendJoinButton _chatButton; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _requestBtn; // 0xB0
		private MonoFriendJoinButton _joinButton; // 0xB8
		public GameObject goOnlineInfo; // 0xC0
		public Image markImage; // 0xC8
		public Color colorOnline; // 0xD0
		public Color colorOffline; // 0xE0
		public MonoUIContainer acceptBtn; // 0xF0
		public MonoUIContainer rejectBtn; // 0xF8
		public MonoUIContainer addBtn; // 0x100
		[NonSerialized]
		public int applyCooldown; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _photoScroller; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _photoGrp; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _receiveScroller; // 0x120
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _receiveGrp; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _receiveCompleteShowGrp; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _receiveCompleteGrp; // 0x138
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _receiveBtnGrp; // 0x140
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _receiveBtnContainer; // 0x148
	
		// Properties
		public MonoRemarkNameColor remarkNameColor { /* [XID] */ /* 0x0000000189A4C580-0x0000000189A4C5A0 */ get => default; } // 0x0000000184C7C080-0x0000000184C7C120 
		public Image icon { /* [XID] */ /* 0x0000000189A53D20-0x0000000189A53D40 */ get => default; } // 0x0000000184C7BC90-0x0000000184C7BD30 
		public string playerName { /* [XID] */ /* 0x0000000189A5B730-0x0000000189A5B750 */ set {} } // 0x0000000184C7C850-0x0000000184C7C920
		public string levelString { /* [XID] */ /* 0x0000000189A62DC0-0x0000000189A62DE0 */ set {} } // 0x0000000184C7C640-0x0000000184C7C710
		public UnityEngine.UI.Text signatureText { /* [XID] */ /* 0x0000000189A6A940-0x0000000189A6A960 */ get => default; } // 0x0000000184C7C270-0x0000000184C7C310 
		public RectTransform mPTeamLabel { /* [XID] */ /* 0x0000000189A71F80-0x0000000189A71FA0 */ get => default; } // 0x0000000184C7BD30-0x0000000184C7BDD0 
		public MonoUIContainer ps4ID { /* [XID] */ /* 0x0000000189A79C20-0x0000000189A79C40 */ get => default; } // 0x0000000184C7BE80-0x0000000184C7BF20 
		public RectTransform blockChatImg { /* [XID] */ /* 0x0000000189A81080-0x0000000189A810A0 */ get => default; } // 0x0000000184C7BB50-0x0000000184C7BBF0 
		public Animator animator { /* [XID] */ /* 0x0000000189A88AC0-0x0000000189A88AE0 */ get => default; } // 0x0000000184C7BAB0-0x0000000184C7BB50 
		public Button iconBtn { /* [XID] */ /* 0x0000000189A902B0-0x0000000189A902D0 */ get => default; } // 0x0000000184C7BBF0-0x0000000184C7BC90 
		public MonoFriendJoinButton ChatButton { /* [XID] */ /* 0x0000000189A97AA0-0x0000000189A97AC0 */ get => default; } // 0x0000000184C7B890-0x0000000184C7B9A0 
		public MonoUIContainer requestBtn { /* [XID] */ /* 0x0000000189A9EE70-0x0000000189A9EE90 */ get => default; } // 0x0000000184C7C120-0x0000000184C7C1D0 
		public MonoFriendJoinButton JoinButton { /* [XID] */ /* 0x0000000189AA6770-0x0000000189AA6790 */ get => default; } // 0x0000000184C7B9A0-0x0000000184C7BAB0 
		public RectTransform requestingGrp { /* [XID] */ /* 0x0000000189AADDE0-0x0000000189AADE00 */ get => default; } // 0x0000000184C7C1D0-0x0000000184C7C270 
		public UnityEngine.UI.Text unreachableLable { /* [XID] */ /* 0x0000000189AB5770-0x0000000189AB5790 */ get => default; } // 0x0000000184C7C460-0x0000000184C7C500 
		public UnityEngine.UI.Text tipsLable { /* [XID] */ /* 0x0000000189AC4BE0-0x0000000189AC4C00 */ get => default; } // 0x0000000184C7C3B0-0x0000000184C7C460 
		public RectTransform signature { /* [XID] */ /* 0x0000000189ACC260-0x0000000189ACC280 */ get => default; } // 0x0000000184C7C310-0x0000000184C7C3B0 
		private bool showDefaultNameCard { /* [XID] */ /* 0x0000000189AE3120-0x0000000189AE3140 */ set {} } // 0x0000000184C7A9D0-0x0000000184C7AB00
		public Sprite nameCardPic { /* [XID] */ /* 0x0000000189AEAAB0-0x0000000189AEAAD0 */ set {} } // 0x0000000184C7C710-0x0000000184C7C850
		public MonoSimpleReusableList photoScroller { /* [XID] */ /* 0x0000000189AF9D40-0x0000000189AF9D60 */ get => default; } // 0x0000000184C7BDD0-0x0000000184C7BE80 
		public MonoSimpleReusableList receiveScroller { /* [XID] */ /* 0x0000000189B01270-0x0000000189B01290 */ get => default; } // 0x0000000184C7BFD0-0x0000000184C7C080 
		public bool showFriendPhoto { /* [XID] */ /* 0x0000000189B087C0-0x0000000189B087E0 */ set {} } // 0x0000000184C7C920-0x0000000184C7CA10
		public bool showReceivePhoto { /* [XID] */ /* 0x0000000189B10160-0x0000000189B10180 */ set {} } // 0x0000000184C7CA10-0x0000000184C7CB00
		public MonoUIContainer receiveBtnContainer { /* [XID] */ /* 0x0000000189B17280-0x0000000189B172A0 */ get => default; } // 0x0000000184C7BF20-0x0000000184C7BFD0 
		public bool isReceiveComplete { /* [XID] */ /* 0x0000000189B1EC20-0x0000000189B1EC40 */ set {} } // 0x0000000184C7C500-0x0000000184C7C640
	
		// Nested types
		public enum Option // TypeDefIndex: 30680
		{
			None = 0,
			RequestButton = 1,
			RequestingHint = 2,
			UnreachableHint = 3
		}
	
		// Constructors
		public MonoActivityBlessingFriendListRow() {} // 0x0000000184C7B780-0x0000000184C7B890
	
		// Methods
		// [XID] // 0x0000000189ABD150-0x0000000189ABD170
		public void SetOnlineInfoStyle(bool online, string text) {} // 0x0000000184C7B2A0-0x0000000184C7B500
		// [XID] // 0x0000000189AD3D40-0x0000000189AD3D60
		public void ShowChat(bool show) {} // 0x0000000184C7B500-0x0000000184C7B610
		// [XID] // 0x0000000189ADB820-0x0000000189ADB840
		public void ShowOption(Option option) {} // 0x0000000184C7B610-0x0000000184C7B780
		// [XID] // 0x0000000189AF23A0-0x0000000189AF23C0
		public void RefreshRequestButton(MPRequestState state, uint uid, FriendBriefStruct friendData) {} // 0x0000000184C7AB00-0x0000000184C7B2A0
	}
}
