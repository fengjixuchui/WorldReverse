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
	public class MonoInLevelPlayerLevelPage : MonoUIProxy // TypeDefIndex: 29759
	{
		// Fields
		private const string BAG_ITEM_SLOT_PATH = "ART/UI/Menus/Widget/BagItemSlot"; // Metadata: 0x00B0FE55
		private const string PLAYER_LEVEL_UNLOCK_ROW_PATH = "ART/UI/Menus/Widget/PlayerLevel_UnlockRow"; // Metadata: 0x00B0FE78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoCentreScroller _levelScroller; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _rewardItemRoot; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _unlockRoot; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _rewardRoot; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _questRoot; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _questText; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _tipText; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _noContentPanel; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _bottomRoot; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _disableTip; // 0x88
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private GameObject _grpLevelRow; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _worldLevelRow; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _titleUnlockTemplate; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _titleLockTemplate; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _contentUnlockTemplate; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _contentLockTemplate; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0xC0
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private ScrollRect _contextScroll; // 0xC8
		[SerializeField] // 0x00000001899B1C50-0x00000001899B1C90
		// [Tooltip] // 0x00000001899B1C50-0x00000001899B1C90
		private float _scrollShieldAngle; // 0xD0
		private GameObject _bagItemPrefab; // 0xD8
		private GameObject _unlockRowPrefab; // 0xE0
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public List<MonoBagProxySlot> rewardItemList; // 0xE8
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public List<MonoPlayerLevelUnlockRow> unlockRowList; // 0xF0
	
		// Properties
		public MonoCentreScroller levelScroller { /* [XID] */ /* 0x00000001899CCAB0-0x00000001899CCAD0 */ get => default; } // 0x0000000183D70760-0x0000000183D70800 
		public UnityEngine.UI.Text questText { /* [XID] */ /* 0x00000001899D40F0-0x00000001899D4110 */ get => default; } // 0x0000000183D70940-0x0000000183D709E0 
		public UnityEngine.UI.Text tipText { /* [XID] */ /* 0x00000001899DB6C0-0x00000001899DB6E0 */ get => default; } // 0x0000000183D70D40-0x0000000183D70DE0 
		public Transform unlockRoot { /* [XID] */ /* 0x00000001899E2DE0-0x00000001899E2E00 */ get => default; } // 0x0000000183D70F40-0x0000000183D70FE0 
		public GameObject questRoot { /* [XID] */ /* 0x00000001899EA4F0-0x00000001899EA510 */ get => default; } // 0x0000000183D708A0-0x0000000183D70940 
		public GameObject rewardRoot { /* [XID] */ /* 0x00000001899F1F00-0x00000001899F1F20 */ get => default; } // 0x0000000183D70BF0-0x0000000183D70C90 
		public GameObject noContentPanel { /* [XID] */ /* 0x00000001899F9680-0x00000001899F96A0 */ get => default; } // 0x0000000183D70800-0x0000000183D708A0 
		public GameObject bottomRoot { /* [XID] */ /* 0x0000000189A009A0-0x0000000189A009C0 */ get => default; } // 0x0000000183D70120-0x0000000183D701D0 
		public GameObject disableTip { /* [XID] */ /* 0x0000000189A082E0-0x0000000189A08300 */ get => default; } // 0x0000000183D703E0-0x0000000183D70490 
		public GameObject grpLevelRow { /* [XID] */ /* 0x0000000189A0F7A0-0x0000000189A0F7C0 */ get => default; } // 0x0000000183D706B0-0x0000000183D70760 
		public GameObject worldLevelRow { /* [XID] */ /* 0x0000000189A16DA0-0x0000000189A16DC0 */ get => default; } // 0x0000000183D71100-0x0000000183D711B0 
		public GameObject titleUnlockTemplate { /* [XID] */ /* 0x0000000189A1E400-0x0000000189A1E420 */ get => default; } // 0x0000000183D70E90-0x0000000183D70F40 
		public GameObject titleLockTemplate { /* [XID] */ /* 0x0000000189A25B00-0x0000000189A25B20 */ get => default; } // 0x0000000183D70DE0-0x0000000183D70E90 
		public GameObject contentUnlockTemplate { /* [XID] */ /* 0x0000000189A2CF80-0x0000000189A2CFA0 */ get => default; } // 0x0000000183D70280-0x0000000183D70330 
		public GameObject contentLockTemplate { /* [XID] */ /* 0x0000000189A34930-0x0000000189A34950 */ get => default; } // 0x0000000183D701D0-0x0000000183D70280 
		public MonoUIContainer fetchBtnContainer { /* [XID] */ /* 0x0000000189A3BD30-0x0000000189A3BD50 */ get => default; } // 0x0000000183D70490-0x0000000183D705A0 
		public MonoUIContainer gotoBtnContainer { /* [XID] */ /* 0x0000000189A43980-0x0000000189A439A0 */ get => default; } // 0x0000000183D705A0-0x0000000183D706B0 
		public MonoUIContainer returnBtnContainer { /* [XID] */ /* 0x0000000189A4ADD0-0x0000000189A4ADF0 */ get => default; } // 0x0000000183D70AE0-0x0000000183D70BF0 
		public Transform receivedTip { /* [XID] */ /* 0x0000000189A524F0-0x0000000189A52510 */ get => default; } // 0x0000000183D709E0-0x0000000183D70AE0 
		public GameObject bagItemPrefab { /* [XID] */ /* 0x0000000189A59E40-0x0000000189A59E60 */ get => default; } // 0x0000000183D70000-0x0000000183D70120 
		public GameObject unlockRowPrefab { /* [XID] */ /* 0x0000000189A69550-0x0000000189A69570 */ get => default; } // 0x0000000183D70FE0-0x0000000183D71100 
		public float scrollShieldAngle { /* [XID] */ /* 0x0000000189A78170-0x0000000189A78190 */ get => default; } // 0x0000000183D70C90-0x0000000183D70D40 
		public ScrollRect contextScroll { /* [XID] */ /* 0x0000000189A7F760-0x0000000189A7F780 */ get => default; } // 0x0000000183D70330-0x0000000183D703E0 
	
		// Constructors
		public MonoInLevelPlayerLevelPage() {} // 0x0000000183D6FEC0-0x0000000183D70000
	
		// Methods
		// [XID] // 0x0000000189A61610-0x0000000189A61630
		public MonoBagProxySlot GetNewBagSlotItem() => default; // 0x0000000183D6FA80-0x0000000183D6FBD0
		// [XID] // 0x0000000189A708C0-0x0000000189A708E0
		public MonoPlayerLevelUnlockRow GetNewUnlockRow() => default; // 0x0000000183D6FBD0-0x0000000183D6FD20
		// [XID] // 0x0000000189A874C0-0x0000000189A874E0
		protected override void OnDestroy() {} // 0x0000000183D6FD20-0x0000000183D6FEC0
	}
}
