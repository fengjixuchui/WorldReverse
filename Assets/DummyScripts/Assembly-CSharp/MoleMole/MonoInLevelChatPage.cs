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
	public class MonoInLevelChatPage : MonoUIProxy // TypeDefIndex: 28485
	{
		// Fields
		public MonoElementSwitch elementSwitch; // 0x40
		public Button backBtn; // 0x48
		public NativeEditBox talkInputFieldNative; // 0x50
		public InputField talkInputField; // 0x58
		public RectTransform TalkContent; // 0x60
		public GameObject errorBubble; // 0x68
		public RectTransform chatContentAnchor; // 0x70
		public MonoScrollRectExtention scroller; // 0x78
		public GameObject unreadMessageGo; // 0x80
		public UnityEngine.UI.Text unrealMessageText; // 0x88
		public GameObject quickChatWindow; // 0x90
		public MonoGridScroller quickChatScroller; // 0x98
		public Button quickChatBack; // 0xA0
		public GameObject emojiWindow; // 0xA8
		public MonoGridScroller emojiScroller; // 0xB0
		public Button emojiBack; // 0xB8
		public CanvasGroup backCanvasGroup; // 0xC0
		public float backAlphaMain; // 0xC8
		public float backAlphaTeam; // 0xCC
		public MonoGridScroller friendListScroller; // 0xD0
		public MonoUIContainer btnAddFriendToChat; // 0xD8
		public MonoUIContainer btnMore; // 0xE0
		public Button btnCloseMore; // 0xE8
		public GameObject grpEdit; // 0xF0
		public MonoUIContainer deleteButton; // 0xF8
		public UnityEngine.UI.Text talkTarget; // 0x100
		public UnityEngine.UI.Text talkTargetRemarkName; // 0x108
		public GameObject background; // 0x110
		public GameObject NoChatContentTips; // 0x118
		public GameObject inputArea; // 0x120
	
		// Properties
		public MonoUIContainer backBtn2 { /* [XID] */ /* 0x0000000189B9D290-0x0000000189B9D2B0 */ get => default; } // 0x0000000184704120-0x00000001847041E0 
		public MonoUIContainer sendBtn { /* [XID] */ /* 0x0000000189BA4C50-0x0000000189BA4C70 */ get => default; } // 0x0000000184704420-0x00000001847044E0 
		public MonoUIContainer cancelBtn { /* [XID] */ /* 0x0000000189BABF70-0x0000000189BABF90 */ get => default; } // 0x00000001847042A0-0x0000000184704360 
		public MonoUIContainer selectBtn { /* [XID] */ /* 0x0000000189BB3620-0x0000000189BB3640 */ get => default; } // 0x0000000184704360-0x0000000184704420 
		public MonoUIContainer addChatBtn { /* [XID] */ /* 0x0000000189BBAC40-0x0000000189BBAC60 */ get => default; } // 0x0000000184704060-0x0000000184704120 
		public MonoUIContainer BtnReadMsg { /* [XID] */ /* 0x0000000189BC2C10-0x0000000189BC2C30 */ get => default; } // 0x0000000184703FA0-0x0000000184704060 
		public bool showReadGrp { /* [XID] */ /* 0x0000000189BCA320-0x0000000189BCA340 */ set {} } // 0x00000001847045E0-0x0000000184704700
		public bool showFriendDetail { /* [XID] */ /* 0x0000000189BD19B0-0x0000000189BD19D0 */ set {} } // 0x00000001847044E0-0x00000001847045E0
		public MonoUIContainer BtnQuickChat { /* [XID] */ /* 0x0000000189BD8FA0-0x0000000189BD8FC0 */ get => default; } // 0x0000000184703EE0-0x0000000184703FA0 
		public MonoUIContainer BtnEmoji { /* [XID] */ /* 0x00000001895E5B20-0x00000001895E5B40 */ get => default; } // 0x0000000184703E20-0x0000000184703EE0 
		public MonoUIContainer btnMoreVarient { /* [XID] */ /* 0x00000001895ED490-0x00000001895ED4B0 */ get => default; } // 0x00000001847041E0-0x00000001847042A0 
	
		// Constructors
		public MonoInLevelChatPage() {} // 0x0000000184703DC0-0x0000000184703E20
	}
}
