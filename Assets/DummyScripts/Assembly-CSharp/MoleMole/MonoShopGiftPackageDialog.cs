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
	public class MonoShopGiftPackageDialog : MonoUIProxy // TypeDefIndex: 30583
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _giftContainerPrefab; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _packageShowPrefab; // 0x48
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _exchangeItemContainer; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _materialsContainer; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _giftPackageContainer; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _bgBtn; // 0x70
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text _txtTitle; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtInfo; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _txtInfoDefalutColor; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _txtInfoWarningColor; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoScrollRectExtention _itemContainer; // 0xA8
		private List<MonoGiftPackageContainer> _containerList; // 0xB0
		private List<IdCountStrConfig> _tempRecommendRewardPreviewList; // 0xB8
		private List<MonoGiftPackageListRow> _itemList; // 0xC0
		private int _curSelectItem; // 0xC8
	
		// Properties
		public Button bgBtn { /* [XID] */ /* 0x000000018971D6A0-0x000000018971D6C0 */ get => default; } // 0x0000000184120A70-0x0000000184120B10 
		public GameObject packageShowPrefab { /* [XID] */ /* 0x0000000189724A90-0x0000000189724AB0 */ get => default; } // 0x0000000184120F30-0x0000000184120FD0 
		public RectTransform exchangeItemContainer { /* [XID] */ /* 0x000000018972C2E0-0x000000018972C300 */ get => default; } // 0x0000000184120D50-0x0000000184120DF0 
		public RectTransform materialsContainer { /* [XID] */ /* 0x00000001897339A0-0x00000001897339C0 */ get => default; } // 0x0000000184120E90-0x0000000184120F30 
		public RectTransform giftPackageContainer { /* [XID] */ /* 0x000000018973B100-0x000000018973B120 */ get => default; } // 0x0000000184120DF0-0x0000000184120E90 
		public UnityEngine.UI.Text txtTitle { /* [XID] */ /* 0x0000000189742A70-0x0000000189742A90 */ get => default; } // 0x0000000184121080-0x0000000184121120 
		public UnityEngine.UI.Text txtInfo { /* [XID] */ /* 0x000000018974A760-0x000000018974A780 */ get => default; } // 0x0000000184120FD0-0x0000000184121080 
		public MonoUIContainer cancelBtn { /* [XID] */ /* 0x0000000189776DA0-0x0000000189776DC0 */ get => default; } // 0x0000000184120B10-0x0000000184120BD0 
		public MonoUIContainer confirmBtn { /* [XID] */ /* 0x000000018977E460-0x000000018977E480 */ get => default; } // 0x0000000184120C90-0x0000000184120D50 
		public MonoUIContainer checkBtn { /* [XID] */ /* 0x0000000189785B90-0x0000000189785BB0 */ get => default; } // 0x0000000184120BD0-0x0000000184120C90 
		public bool showTimeText { /* [XID] */ /* 0x000000018978D2D0-0x000000018978D2F0 */ set {} } // 0x0000000184121120-0x0000000184121280
	
		// Constructors
		public MonoShopGiftPackageDialog() {} // 0x0000000184120970-0x0000000184120A70
	
		// Methods
		// [XID] // 0x0000000189751890-0x00000001897518B0
		private void InitContainers(int num) {} // 0x0000000184120060-0x0000000184120210
		// [XID] // 0x0000000189758E10-0x0000000189758E30
		public void InitGiftPackage(ShopItem shopItem) {} // 0x000000018411FF10-0x0000000184120060
		// [XID] // 0x0000000189760AF0-0x0000000189760B10
		private void InitCard(ShopItem shopItem) {} // 0x000000018411F4C0-0x000000018411FA10
		// [XID] // 0x0000000189767DB0-0x0000000189767DD0
		private void InitPackage(ShopItem shopItem) {} // 0x0000000184120210-0x0000000184120400
		// [XID] // 0x000000018976F380-0x000000018976F3A0
		private void RefreshRecommendRewardPreviewItems(Transform trans, int index) {} // 0x0000000184120400-0x00000001841205C0
		// [XID] // 0x0000000189794610-0x0000000189794630
		private void InitShowText(ShopItem shopItem) {} // 0x000000018411FCD0-0x000000018411FF10
		// [XID] // 0x000000018979CAA0-0x000000018979CAC0
		private void UpdateConfirmBtn(ShopItem shopItem) {} // 0x000000018411FA10-0x000000018411FBC0
		// [XID] // 0x00000001897A3F00-0x00000001897A3F20
		public void SelectPrevItem() {} // 0x0000000184120800-0x0000000184120970
		// [XID] // 0x00000001897AB480-0x00000001897AB4A0
		public void SelectNextItem() {} // 0x0000000184120690-0x0000000184120800
		// [XID] // 0x00000001897B3270-0x00000001897B3290
		public void OnCheckItem() {} // 0x00000001841205C0-0x0000000184120690
		// [XID] // 0x00000001897BB190-0x00000001897BB1B0
		private void ScrollToItem() {} // 0x000000018411FBC0-0x000000018411FCD0
	}
}
