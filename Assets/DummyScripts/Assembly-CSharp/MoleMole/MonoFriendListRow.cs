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
	public class MonoFriendListRow : MonoBehaviour, EditMenuTarget // TypeDefIndex: 30776
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x18
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
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
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
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
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private GameObject _avatarIconSelector; // 0x110
		public bool isOnline; // 0x118
	
		// Properties
		public MonoRemarkNameColor remarkNameColor { /* [XID] */ /* 0x0000000189B279B0-0x0000000189B279D0 */ get => default; } // 0x0000000184AEDAC0-0x0000000184AEDB60 
		public Sprite icon { /* [XID] */ /* 0x0000000189B2ECF0-0x0000000189B2ED10 */ set {} } // 0x0000000184AEDF40-0x0000000184AEE000
		public string playerName { /* [XID] */ /* 0x0000000189B36570-0x0000000189B36590 */ set {} } // 0x0000000184AEE210-0x0000000184AEE2E0
		public string levelString { /* [XID] */ /* 0x0000000189B3DD70-0x0000000189B3DD90 */ set {} } // 0x0000000184AEE000-0x0000000184AEE0D0
		public UnityEngine.UI.Text signatureText { /* [XID] */ /* 0x0000000189B45AF0-0x0000000189B45B10 */ get => default; } // 0x0000000184AEDCB0-0x0000000184AEDD50 
		public RectTransform mPTeamLabel { /* [XID] */ /* 0x0000000189B4CF90-0x0000000189B4CFB0 */ get => default; } // 0x0000000184AED980-0x0000000184AEDA20 
		public MonoUIContainer ps4ID { /* [XID] */ /* 0x0000000189B546B0-0x0000000189B546D0 */ get => default; } // 0x0000000184AEDA20-0x0000000184AEDAC0 
		public RectTransform blockChatImg { /* [XID] */ /* 0x0000000189B5C280-0x0000000189B5C2A0 */ get => default; } // 0x0000000184AED840-0x0000000184AED8E0 
		public Animator animator { /* [XID] */ /* 0x0000000189B638A0-0x0000000189B638C0 */ get => default; } // 0x0000000184AED7A0-0x0000000184AED840 
		public Button iconBtn { /* [XID] */ /* 0x0000000189B6B040-0x0000000189B6B060 */ get => default; } // 0x0000000184AED8E0-0x0000000184AED980 
		public MonoFriendJoinButton ChatButton { /* [XID] */ /* 0x0000000189B72680-0x0000000189B726A0 */ get => default; } // 0x0000000184AED580-0x0000000184AED690 
		public MonoUIContainer requestBtn { /* [XID] */ /* 0x0000000189B79BF0-0x0000000189B79C10 */ get => default; } // 0x0000000184AEDB60-0x0000000184AEDC10 
		public MonoFriendJoinButton JoinButton { /* [XID] */ /* 0x0000000189B81340-0x0000000189B81360 */ get => default; } // 0x0000000184AED690-0x0000000184AED7A0 
		public RectTransform requestingGrp { /* [XID] */ /* 0x0000000189B88AD0-0x0000000189B88AF0 */ get => default; } // 0x0000000184AEDC10-0x0000000184AEDCB0 
		public UnityEngine.UI.Text unreachableLable { /* [XID] */ /* 0x0000000189B8FF80-0x0000000189B8FFA0 */ get => default; } // 0x0000000184AEDEA0-0x0000000184AEDF40 
		public UnityEngine.UI.Text tipsLable { /* [XID] */ /* 0x0000000189B9E820-0x0000000189B9E840 */ get => default; } // 0x0000000184AEDDF0-0x0000000184AEDEA0 
		public RectTransform signature { /* [XID] */ /* 0x0000000189BA61D0-0x0000000189BA61F0 */ get => default; } // 0x0000000184AEDD50-0x0000000184AEDDF0 
		private bool showDefaultNameCard { /* [XID] */ /* 0x0000000189BBC200-0x0000000189BBC220 */ set {} } // 0x0000000184AEC300-0x0000000184AEC430
		public Sprite nameCardPic { /* [XID] */ /* 0x0000000189BC3F60-0x0000000189BC3F80 */ set {} } // 0x0000000184AEE0D0-0x0000000184AEE210
	
		// Nested types
		public enum Option // TypeDefIndex: 30777
		{
			None = 0,
			RequestButton = 1,
			RequestingHint = 2,
			UnreachableHint = 3
		}
	
		// Constructors
		public MonoFriendListRow() {} // 0x0000000184AED4A0-0x0000000184AED580
	
		// Methods
		// [XID] // 0x0000000189B97380-0x0000000189B973A0
		public void SetOnlineInfoStyle(bool online, string text) {} // 0x0000000184AECFC0-0x0000000184AED220
		// [XID] // 0x0000000189BAD440-0x0000000189BAD460
		public void ShowChat(bool show) {} // 0x0000000184AED220-0x0000000184AED330
		// [XID] // 0x0000000189BB4C30-0x0000000189BB4C50
		public void ShowOption(Option option) {} // 0x0000000184AED330-0x0000000184AED4A0
		// [XID] // 0x0000000189BCB860-0x0000000189BCB880
		public void RefreshRequestButton(MPRequestState state, uint uid, FriendBriefStruct friendData) {} // 0x0000000184AEC760-0x0000000184AECFC0
		// [XID] // 0x0000000189BD2E60-0x0000000189BD2E80
		RectTransform MoleMole.EditMenuTarget.GetTransform() => default; // 0x0000000184AEC430-0x0000000184AEC540
		// [XID] // 0x0000000189BDA580-0x0000000189BDA5A0
		void MoleMole.EditMenuTarget.Selected(bool selected) {} // 0x0000000184AEC540-0x0000000184AEC630
		// [XID] // 0x00000001895E6FD0-0x00000001895E6FF0
		public void OnEnable() {} // 0x0000000184AEC630-0x0000000184AEC760
	}
}
