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
	public class MonoActivityMiniTomo : MonoUIProxy // TypeDefIndex: 30278
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _activityMiniTomo; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _previewRewards; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _remainTime; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _tipTitle; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpTipImg; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpTipTxt; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _lockTxt; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _unlockTxt; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpLimit; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _limitTxt; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpEnd; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoJoypadGridScrollerHandler _gridScrollerHandler; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoJoypadScrollRect _scrollRectHandler; // 0xA0
	
		// Properties
		public MonoGridScroller previewRewards { /* [XID] */ /* 0x0000000189B26590-0x0000000189B265B0 */ get => default; } // 0x000000018631FAC0-0x000000018631FB60 
		public Text remainTime { /* [XID] */ /* 0x0000000189B2D860-0x0000000189B2D880 */ get => default; } // 0x000000018631FB60-0x000000018631FC00 
		public Text tipTitle { /* [XID] */ /* 0x0000000189B34CC0-0x0000000189B34CE0 */ get => default; } // 0x000000018631FCB0-0x000000018631FD50 
		public GameObject grpTipImg { /* [XID] */ /* 0x0000000189B3C4D0-0x0000000189B3C4F0 */ get => default; } // 0x000000018631F830-0x000000018631F8D0 
		public GameObject grpTipTxt { /* [XID] */ /* 0x0000000189B441B0-0x0000000189B441D0 */ get => default; } // 0x000000018631F8D0-0x000000018631F970 
		public Text lockTxt { /* [XID] */ /* 0x0000000189B4B860-0x0000000189B4B880 */ get => default; } // 0x000000018631FA20-0x000000018631FAC0 
		public Text unlockTxt { /* [XID] */ /* 0x0000000189B52EB0-0x0000000189B52ED0 */ get => default; } // 0x000000018631FD50-0x000000018631FDF0 
		public GameObject grpLimit { /* [XID] */ /* 0x0000000189B5A880-0x0000000189B5A8A0 */ get => default; } // 0x000000018631F780-0x000000018631F830 
		public Text limitTxt { /* [XID] */ /* 0x0000000189B61D30-0x0000000189B61D50 */ get => default; } // 0x000000018631F970-0x000000018631FA20 
		public GameObject grpEnd { /* [XID] */ /* 0x0000000189B69940-0x0000000189B69960 */ get => default; } // 0x000000018631F6D0-0x000000018631F780 
		public MonoJoypadGridScrollerHandler gridScrollerHandler { /* [XID] */ /* 0x0000000189B70F40-0x0000000189B70F60 */ get => default; } // 0x000000018631F620-0x000000018631F6D0 
		public MonoJoypadScrollRect scrollRectHandler { /* [XID] */ /* 0x0000000189B78510-0x0000000189B78530 */ get => default; } // 0x000000018631FC00-0x000000018631FCB0 
		public MonoUIContainer btnGoto { /* [XID] */ /* 0x0000000189B7FA30-0x0000000189B7FA50 */ get => default; } // 0x000000018631F4A0-0x000000018631F560 
		public MonoUIContainer btnDescription { /* [XID] */ /* 0x0000000189B87500-0x0000000189B87520 */ get => default; } // 0x000000018631F1A0-0x000000018631F260 
		public MonoUIContainer btnGotoQuest { /* [XID] */ /* 0x0000000189B8E650-0x0000000189B8E670 */ get => default; } // 0x000000018631F3E0-0x000000018631F4A0 
		public MonoUIContainer btnEnd { /* [XID] */ /* 0x0000000189B95B30-0x0000000189B95B50 */ get => default; } // 0x000000018631F260-0x000000018631F320 
		public MonoUIContainer btnExit { /* [XID] */ /* 0x0000000189B9D0D0-0x0000000189B9D0F0 */ get => default; } // 0x000000018631F320-0x000000018631F3E0 
		public MonoUIContainer btnOK { /* [XID] */ /* 0x0000000189BA4A30-0x0000000189BA4A50 */ get => default; } // 0x000000018631F560-0x000000018631F620 
		public MonoUIContainer btnBack { /* [XID] */ /* 0x0000000189BABD50-0x0000000189BABD70 */ get => default; } // 0x000000018631F020-0x000000018631F0E0 
		public MonoUIContainer btnCheck { /* [XID] */ /* 0x0000000189BB3400-0x0000000189BB3420 */ get => default; } // 0x000000018631F0E0-0x000000018631F1A0 
	
		// Constructors
		public MonoActivityMiniTomo() {} // 0x000000018631EF70-0x000000018631F020
	}
}
