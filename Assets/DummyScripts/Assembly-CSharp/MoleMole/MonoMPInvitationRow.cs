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
	public class MonoMPInvitationRow : MonoReusableListItem // TypeDefIndex: 30977
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Animator _animator; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x28
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Image _icon; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _nameLabel; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _levelLabel; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoRemarkNameColor _remarkNameColor; // 0x48
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private SmoothMask _progress; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _progressCanvasGroup; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animation _progressFadeOut; // 0x60
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _agreedGrp; // 0x68
		// [Header] // 0x0000000189B7C760-0x0000000189B7C7A0
		[SerializeField] // 0x0000000189B7C760-0x0000000189B7C7A0
		private Image _markIcon; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _inTeamGrp; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _invitingGrp; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _onlineID; // 0x88
		[NonSerialized]
		public uint uid; // 0x90
		[NonSerialized]
		public ApplingGuestType type; // 0x94
	
		// Properties
		public bool showOnlineID { /* [XID] */ /* 0x0000000189B9E7E0-0x0000000189B9E800 */ set {} } // 0x0000000182F09080-0x0000000182F09160
		public string onlineID { /* [XID] */ /* 0x0000000189BA6190-0x0000000189BA61B0 */ set {} } // 0x0000000182F08790-0x0000000182F08900
		public MonoRemarkNameColor remarkNameColor { /* [XID] */ /* 0x0000000189BAD400-0x0000000189BAD420 */ get => default; } // 0x0000000182F084A0-0x0000000182F08540 
		public Image icon { /* [XID] */ /* 0x0000000189BB4BF0-0x0000000189BB4C10 */ get => default; } // 0x0000000182F081C0-0x0000000182F08260 
		public string playerName { /* [XID] */ /* 0x0000000189BBC1A0-0x0000000189BBC1C0 */ set {} } // 0x0000000182F08900-0x0000000182F089D0
		public string levelString { /* [XID] */ /* 0x0000000189BC3F00-0x0000000189BC3F20 */ set {} } // 0x0000000182F08600-0x0000000182F086D0
		public bool showButtonGrp { /* [XID] */ /* 0x0000000189BCB7C0-0x0000000189BCB7E0 */ set {} } // 0x0000000182F08B70-0x0000000182F08C40
		public bool showNoButton { /* [XID] */ /* 0x0000000189BD2E00-0x0000000189BD2E20 */ set {} } // 0x0000000182F08FB0-0x0000000182F09080
		public Button noButton { /* [XID] */ /* 0x0000000189BDA4E0-0x0000000189BDA500 */ get => default; } // 0x0000000182F083E0-0x0000000182F084A0 
		public bool showYesButton { /* [XID] */ /* 0x00000001895E6F70-0x00000001895E6F90 */ set {} } // 0x0000000182F09160-0x0000000182F09230
		public Button yesButton { /* [XID] */ /* 0x00000001895EE8E0-0x00000001895EE900 */ get => default; } // 0x0000000182F08540-0x0000000182F08600 
		public float progress { /* [XID] */ /* 0x00000001895F62C0-0x00000001895F62E0 */ set {} } // 0x0000000182F089D0-0x0000000182F08A90
		public bool showAgreedGrp { /* [XID] */ /* 0x000000018960C970-0x000000018960C990 */ set {} } // 0x0000000182F08A90-0x0000000182F08B70
		public bool showMarkIcon { /* [XID] */ /* 0x0000000189613E90-0x0000000189613EB0 */ set {} } // 0x0000000182F08ED0-0x0000000182F08FB0
		public Sprite markIcon { /* [XID] */ /* 0x000000018961B860-0x000000018961B880 */ set {} } // 0x0000000182F086D0-0x0000000182F08790
		public bool showInviteButton { /* [XID] */ /* 0x0000000189622DE0-0x0000000189622E00 */ set {} } // 0x0000000182F08D20-0x0000000182F08DF0
		public Button inviteButton { /* [XID] */ /* 0x000000018962A5D0-0x000000018962A5F0 */ get => default; } // 0x0000000182F08260-0x0000000182F08320 
		public MonoUITemplate inviteTemplate { /* [XID] */ /* 0x0000000189631D50-0x0000000189631D70 */ get => default; } // 0x0000000182F08320-0x0000000182F083E0 
		public bool showInTeamGrp { /* [XID] */ /* 0x00000001896398B0-0x00000001896398D0 */ set {} } // 0x0000000182F08C40-0x0000000182F08D20
		public bool showInvitingGrp { /* [XID] */ /* 0x0000000189640D20-0x0000000189640D40 */ set {} } // 0x0000000182F08DF0-0x0000000182F08ED0
	
		// Constructors
		public MonoMPInvitationRow() {} // 0x0000000182F08120-0x0000000182F081C0
	
		// Methods
		// [XID] // 0x00000001895FD600-0x00000001895FD620
		public override void FadeOut() {} // 0x0000000182F07B60-0x0000000182F07C40
		// [XID] // 0x0000000189604F20-0x0000000189604F40
		public void SkipFadeIn() {} // 0x0000000182F07DB0-0x0000000182F07E90
		// [XID] // 0x0000000189648670-0x0000000189648690
		public void ToDungeonInviteButton() {} // 0x0000000182F07E90-0x0000000182F07F80
		// [XID] // 0x000000018964FD80-0x000000018964FDA0
		public void ToInTeam() {} // 0x0000000182F07F80-0x0000000182F08050
		// [XID] // 0x00000001896575C0-0x00000001896575E0
		public void ToInviting() {} // 0x0000000182F08050-0x0000000182F08120
		// [XID] // 0x000000018965EC80-0x000000018965ECA0
		public void ResetProgressAlpha() {} // 0x0000000182F07CF0-0x0000000182F07DB0
		// [XID] // 0x0000000189666320-0x0000000189666340
		public void ProgressFadeOut() {} // 0x0000000182F07C40-0x0000000182F07CF0
	}
}
