/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoHideandSeekWaitingPage : MonoUIProxy // TypeDefIndex: 30192
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _grpWaiting; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _grpContent; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _bgContainer; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _txtIdentity; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _avatarList; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _avatarReplaceBtn; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoCookAvatarSelect _avatarSelectPanel; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _skillScroller; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoCookAvatarSelect _skillSelectPanel; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _playerList; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _mapIcon; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _mapDesc; // 0xA0
		public Button chatBtn; // 0xA8
		public GameObject chatBtnDot; // 0xB0
		public GameObject chatPanel; // 0xB8
	
		// Properties
		public MonoMainPageChatDisplayer chatDisplayer { /* [XID] */ /* 0x0000000189886FA0-0x0000000189886FC0 */ get => default; } // 0x0000000184B60750-0x0000000184B608A0 
		public RectTransform grpWaiting { /* [XID] */ /* 0x000000018988E130-0x000000018988E150 */ get => default; } // 0x0000000184B60940-0x0000000184B609E0 
		public RectTransform grpContent { /* [XID] */ /* 0x0000000189895780-0x00000001898957A0 */ get => default; } // 0x0000000184B608A0-0x0000000184B60940 
		public MonoUIContainer bgContainer { /* [XID] */ /* 0x000000018989CEE0-0x000000018989CF00 */ get => default; } // 0x0000000184B606B0-0x0000000184B60750 
		public MonoCookAvatarSelect skillSelectPanel { /* [XID] */ /* 0x00000001898A46A0-0x00000001898A46C0 */ get => default; } // 0x0000000184B60CA0-0x0000000184B60D50 
		public Text txtIdentity { /* [XID] */ /* 0x00000001898ABB60-0x00000001898ABB80 */ get => default; } // 0x0000000184B60D50-0x0000000184B60DF0 
		public MonoSimpleReusableList avatarList { /* [XID] */ /* 0x00000001898B3310-0x00000001898B3330 */ get => default; } // 0x0000000184B604D0-0x0000000184B60570 
		public MonoCookAvatarSelect avatarSelectPanel { /* [XID] */ /* 0x00000001898BB010-0x00000001898BB030 */ get => default; } // 0x0000000184B60610-0x0000000184B606B0 
		public MonoGridScroller skillScroller { /* [XID] */ /* 0x00000001898C2380-0x00000001898C23A0 */ get => default; } // 0x0000000184B60BF0-0x0000000184B60CA0 
		public MonoSimpleReusableList playerList { /* [XID] */ /* 0x00000001898C9DA0-0x00000001898C9DC0 */ get => default; } // 0x0000000184B60B40-0x0000000184B60BF0 
		public Image mapIcon { /* [XID] */ /* 0x00000001898D13A0-0x00000001898D13C0 */ get => default; } // 0x0000000184B60A90-0x0000000184B60B40 
		public Text mapDesc { /* [XID] */ /* 0x00000001898D8C60-0x00000001898D8C80 */ get => default; } // 0x0000000184B609E0-0x0000000184B60A90 
		public MonoUIContainer avatarReplaceBtn { /* [XID] */ /* 0x00000001898E0930-0x00000001898E0950 */ get => default; } // 0x0000000184B60570-0x0000000184B60610 
		public MonoUIContainer BtnReady { /* [XID] */ /* 0x00000001898E8490-0x00000001898E84B0 */ get => default; } // 0x0000000184B603C0-0x0000000184B604D0 
		public MonoUIContainer BtnChoose { /* [XID] */ /* 0x00000001898EFC10-0x00000001898EFC30 */ get => default; } // 0x0000000184B60090-0x0000000184B601A0 
		public MonoUIContainer BtnOK_GrpAvatarSelect { /* [XID] */ /* 0x00000001898F7450-0x00000001898F7470 */ get => default; } // 0x0000000184B601A0-0x0000000184B602B0 
		public Button BtnBack_GrpAvatarSelect { /* [XID] */ /* 0x00000001898FEBC0-0x00000001898FEBE0 */ get => default; } // 0x0000000184B5FD70-0x0000000184B5FF00 
		public MonoUIContainer BtnOK_GrpSkillSelect { /* [XID] */ /* 0x0000000189906300-0x0000000189906320 */ get => default; } // 0x0000000184B602B0-0x0000000184B603C0 
		public Button BtnBack_GrpSkillSelect { /* [XID] */ /* 0x000000018990DDC0-0x000000018990DDE0 */ get => default; } // 0x0000000184B5FF00-0x0000000184B60090 
	
		// Constructors
		public MonoHideandSeekWaitingPage() {} // 0x0000000184B5FCB0-0x0000000184B5FD70
	}
}
