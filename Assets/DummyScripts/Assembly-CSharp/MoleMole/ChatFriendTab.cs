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
	public class ChatFriendTab : MonoSpriteProxy // TypeDefIndex: 28463
	{
		// Fields
		private bool _isBtnClickBinded; // 0x20
		public GameObject AvatarIconGo; // 0x28
		public Image AvatarImage; // 0x30
		public GameObject TeamGo; // 0x38
		public Image teamImage; // 0x40
		public UnityEngine.UI.Text playerName; // 0x48
		public GameObject onlineIdGo; // 0x50
		public UnityEngine.UI.Text onlineId; // 0x58
		public Button btn; // 0x60
		public GameObject noticeGO; // 0x68
		public GameObject selectArrow; // 0x70
		public MonoRemarkNameColor remarkNameColor; // 0x78
		public ChatChannel channel; // 0x80
		private DataPack<uint, bool, ChatChannel> _notifyChangeChatTalkBgUid; // 0x88
		private FriendBriefStruct friendData; // 0x90
	
		// Properties
		public bool showOnlineID { /* [XID] */ /* 0x00000001896F0A70-0x00000001896F0A90 */ set {} } // 0x0000000181ADD3E0-0x0000000181ADD4D0
		public bool ShowNoticeGO { /* [XID] */ /* 0x00000001896F8260-0x00000001896F8280 */ set {} } // 0x0000000181ADD2F0-0x0000000181ADD3E0
	
		// Constructors
		public ChatFriendTab() {} // 0x0000000181ADD250-0x0000000181ADD2F0
	
		// Methods
		// [XID] // 0x00000001896FFBC0-0x00000001896FFBE0
		public uint GetUid() => default; // 0x0000000181ADCB90-0x0000000181ADCC30
		// [XID] // 0x0000000189707290-0x00000001897072B0
		public void SetUp(uint uid, bool isTargetTalkingWith, ChatExcelConfig config) {} // 0x0000000181ADCC30-0x0000000181ADD0F0
		// [XID] // 0x000000018970EB30-0x000000018970EB50
		public void ShowTabSelect(bool show) {} // 0x0000000181ADD0F0-0x0000000181ADD250
		// [XID] // 0x0000000189715F10-0x0000000189715F30
		private void OnClickFriendTabButton() {} // 0x0000000181ADCA20-0x0000000181ADCB90
	}
}
