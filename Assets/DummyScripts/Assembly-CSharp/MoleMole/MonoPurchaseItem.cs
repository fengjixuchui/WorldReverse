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
	public class MonoPurchaseItem : MonoSpriteProxy // TypeDefIndex: 31060
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _iconButton; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _name; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _materialsGrp; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoStarRate _rankStar; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _desc; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _smallTipsGrp; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _smallTipsText; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _limitGrp; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _timeLimitRoot; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _timeLimitText; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _purchaseLimitRoot; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _purchaseLimitText; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _bigTipsGrp; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _bigTipsText; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _scrollRect; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _StarRoot; // 0xA8
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Image[] _costIcons; // 0xB0
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UnityEngine.UI.Text[] _costNums; // 0xB8
		private bool _itemHasBuyLimit; // 0xC0
		private bool _needShowBigTips; // 0xC1
		private const uint MAX_REMOVE_TIME = 2592000; // Metadata: 0x00B11E6E
		private const uint SHOOTING_GAME_GOOD_ID = 1044114; // Metadata: 0x00B11E72
		private const uint MUSICGAME_GOOD_ID = 1044115; // Metadata: 0x00B11E76
	
		// Properties
		public Image[] costIcons { /* [XID] */ /* 0x0000000189B39580-0x0000000189B395A0 */ get => default; } // 0x0000000183726140-0x00000001837261F0 
		public UnityEngine.UI.Text[] costNums { /* [XID] */ /* 0x0000000189B40E90-0x0000000189B40EB0 */ get => default; } // 0x00000001837261F0-0x00000001837262A0 
		public Button iconButton { /* [XID] */ /* 0x0000000189B487E0-0x0000000189B48800 */ get => default; } // 0x00000001837262A0-0x0000000183726340 
		public bool itemHasBuyLimit { /* [XID] */ /* 0x0000000189B4FF50-0x0000000189B4FF70 */ get => default; } // 0x0000000183726340-0x00000001837263F0 
		public bool showSmallTipsGrp { /* [XID] */ /* 0x0000000189B5F0B0-0x0000000189B5F0D0 */ set {} } // 0x0000000183726650-0x0000000183726780
		public bool showShopLimitText { /* [XID] */ /* 0x0000000189B666A0-0x0000000189B666C0 */ set {} } // 0x0000000183726520-0x0000000183726650
		public bool showLimitRoot { /* [XID] */ /* 0x0000000189B6DC60-0x0000000189B6DC80 */ set {} } // 0x00000001837263F0-0x0000000183726520
		private bool showTimeLimitText { /* [XID] */ /* 0x0000000189B75310-0x0000000189B75330 */ set {} } // 0x0000000183724770-0x00000001837248A0
	
		// Constructors
		public MonoPurchaseItem() {} // 0x0000000183726070-0x0000000183726140
	
		// Methods
		// [XID] // 0x0000000189B57720-0x0000000189B57740
		public void UpdatePurchaseItem(ShopItem shopItem, bool lockByShopSetting = false /* Metadata: 0x00B11E69 */, string lockReason = "" /* Metadata: 0x00B11E6A */) {} // 0x00000001837254C0-0x0000000183726070
		// [XID] // 0x0000000189B7C720-0x0000000189B7C740
		private bool ShowBuyCountLeft(ShopItem shopItem) => default; // 0x0000000183724A90-0x0000000183724F50
		// [XID] // 0x0000000189B84520-0x0000000189B84540
		private bool ShowRemoveTime(ShopItem shopItem) => default; // 0x00000001837248A0-0x0000000183724A90
		// [XID] // 0x0000000189B8B3D0-0x0000000189B8B3F0
		private void ShowLimitSpecialInfo(ShopItem shopItem, bool tabLocked, string lockReason) {} // 0x0000000183724F50-0x00000001837254C0
	}
}
