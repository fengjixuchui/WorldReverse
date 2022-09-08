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
	public class MonoShopItem : MonoSpriteProxy // TypeDefIndex: 31061
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Button _actionButton; // 0x20
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text _txtShopItem; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _optionalBg; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _materialsGrp; // 0x38
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoReusableList _iconContent; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _iconBackground; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _iconCornerMark; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _imgSelected; // 0x60
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Image[] _costIcons; // 0x68
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text[] _costNums; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtShopLimit; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoStarRate _rankStar; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _itemCountText; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _itemCountSign; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtLockTips; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtSoldOut; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lock; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtShopTips; // 0xB0
		private bool _isPreview; // 0xB8
		private ShopType _shopType; // 0xBC
		private const uint MAX_REMOVE_TIME = 2592000; // Metadata: 0x00B11E7A
	
		// Properties
		public bool isPreview { /* [XID] */ /* 0x0000000189635140-0x0000000189635160 */ set {} } // 0x0000000184122DC0-0x0000000184122E70
		public bool showShopTips { /* [XID] */ /* 0x000000018963C780-0x000000018963C7A0 */ set {} } // 0x0000000184123260-0x00000001841233B0
		public bool showLock { /* [XID] */ /* 0x0000000189643EB0-0x0000000189643ED0 */ set {} } // 0x0000000184123130-0x0000000184123260
		public bool showLockTips { /* [XID] */ /* 0x000000018964B5F0-0x000000018964B610 */ set {} } // 0x0000000184122FC0-0x0000000184123130
		public bool showSoldOut { /* [XID] */ /* 0x0000000189652DE0-0x0000000189652E00 */ set {} } // 0x00000001841233B0-0x0000000184123500
		public MonoReusableList iconContent { /* [XID] */ /* 0x000000018965A4E0-0x000000018965A500 */ get => default; } // 0x0000000184122BE0-0x0000000184122C80 
		public Image[] costIcons { /* [XID] */ /* 0x0000000189661B30-0x0000000189661B50 */ get => default; } // 0x0000000184122AA0-0x0000000184122B40 
		public UnityEngine.UI.Text[] costNums { /* [XID] */ /* 0x00000001896696D0-0x00000001896696F0 */ get => default; } // 0x0000000184122B40-0x0000000184122BE0 
		public Image optionalBg { /* [XID] */ /* 0x00000001896711C0-0x00000001896711E0 */ get => default; } // 0x0000000184122C80-0x0000000184122D20 
		public Button actionButton { /* [XID] */ /* 0x0000000189678A80-0x0000000189678AA0 */ get => default; } // 0x0000000184122A00-0x0000000184122AA0 
		private bool showShopLimitText { /* [XID] */ /* 0x0000000189680080-0x00000001896800A0 */ set {} } // 0x0000000184121D20-0x0000000184121E70
		public UnityEngine.UI.Text txtShopLimit { /* [XID] */ /* 0x0000000189687CB0-0x0000000189687CD0 */ get => default; } // 0x0000000184122D20-0x0000000184122DC0 
		public bool selected { /* [XID] */ /* 0x000000018969E5F0-0x000000018969E610 */ set {} } // 0x0000000184122E70-0x0000000184122FC0
	
		// Constructors
		public MonoShopItem() {} // 0x0000000184122930-0x0000000184122A00
	
		// Methods
		// [XID] // 0x000000018968F6B0-0x000000018968F6D0
		public void UpdateShopItem(ShopItem shopItem, ShopType shopType) {} // 0x0000000184121E70-0x0000000184122930
		// [XID] // 0x0000000189697110-0x0000000189697130
		private void SetQuatityView(ShopItem shopItem) {} // 0x0000000184121AB0-0x0000000184121D20
		// [XID] // 0x00000001896A56D0-0x00000001896A56F0
		private void SetItemCount(uint num) {} // 0x0000000184121450-0x0000000184121590
		// [XID] // 0x00000001896ACF10-0x00000001896ACF30
		private void SetItemRestrictTips(ShopItem item) {} // 0x0000000184121590-0x0000000184121AB0
		// [XID] // 0x00000001896B44F0-0x00000001896B4510
		private void SetRemoveTime(ShopItem shopItem) {} // 0x0000000184121280-0x0000000184121450
	}
}
