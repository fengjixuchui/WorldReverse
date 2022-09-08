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
	internal class MonoBagPage : MonoUIProxy // TypeDefIndex: 30403
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoLocalizedText _tabTitlePrefix; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoLocalizedText _tabTitle; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoBagTabContent _tabContent; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _buttonGroup; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _itemTipPrefab; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoScrollRectExtention _itemTipContainer; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _weightLabel; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x78
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoUIContainer _useButton; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _dropButton; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _prevTabBtn; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _nextTabBtn; // 0x98
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _equippedLabel; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _equippedAvatarIcon; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _equippedAvatarName; // 0xB0
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _quantityLabel; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _quantityText; // 0xC0
		// [Header] // 0x00000001896F1EE0-0x00000001896F1F20
		[SerializeField] // 0x00000001896F1EE0-0x00000001896F1F20
		private RectTransform _screenTitleGrp; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _screenTitleText; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _screenOptionGrp; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _screenOptionScroller; // 0xE0
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		protected MonoElementSwitch _elementSwitch; // 0xE8
		private MonoReusableList _tabContainer; // 0xF0
		private MonoItemTip _itemTip; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selectItemTipsObj; // 0x100
		// [Header] // 0x0000000189726530-0x0000000189726580
		[SerializeField] // 0x0000000189726530-0x0000000189726580
		[Space] // 0x0000000189726530-0x0000000189726580
		private MonoBagPageCookSelect _bagPageCookSelect; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoLocalizedText _noItemTipTitle; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoLocalizedText _noItemTipDesc; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _titleGrp; // 0x120
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _weightGrp; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _itemTipsGrp; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _tabKeysGrp; // 0x138
	
		// Properties
		public Button useButton { /* [XID] */ /* 0x00000001897622E0-0x0000000189762300 */ get => default; } // 0x00000001842355C0-0x0000000184235680 
		public MonoUIContainer useButtonContainer { /* [XID] */ /* 0x00000001897698E0-0x0000000189769900 */ get => default; } // 0x0000000184235500-0x00000001842355C0 
		public Button dropButton { /* [XID] */ /* 0x0000000189770E30-0x0000000189770E50 */ get => default; } // 0x00000001842340D0-0x0000000184234190 
		public MonoBagTabContent tabContent { /* [XID] */ /* 0x00000001897787C0-0x00000001897787E0 */ get => default; } // 0x0000000184235300-0x00000001842353A0 
		public bool showButtonGrp { /* [XID] */ /* 0x000000018977FD00-0x000000018977FD20 */ set {} } // 0x0000000184235EE0-0x0000000184235FC0
		public MonoItemTip itemTip { /* [XID] */ /* 0x00000001897875E0-0x0000000189787600 */ get => default; } // 0x00000001842345F0-0x00000001842346E0 
		public string tabTitleTextID { /* [XID] */ /* 0x000000018978EC10-0x000000018978EC30 */ set {} } // 0x00000001842369C0-0x0000000184236A80
		public string tabTitlePrefixTextID { /* [XID] */ /* 0x00000001897963C0-0x00000001897963E0 */ set {} } // 0x0000000184236900-0x00000001842369C0
		public string noItemTipTitleTextID { /* [XID] */ /* 0x000000018979E490-0x000000018979E4B0 */ set {} } // 0x0000000184235C70-0x0000000184235D40
		public string noItemTipDescTextID { /* [XID] */ /* 0x00000001897A5C10-0x00000001897A5C30 */ set {} } // 0x0000000184235BA0-0x0000000184235C70
		public GameObject titleGrp { /* [XID] */ /* 0x00000001897AD180-0x00000001897AD1A0 */ get => default; } // 0x0000000184235450-0x0000000184235500 
		public GameObject weightGrp { /* [XID] */ /* 0x00000001897B51B0-0x00000001897B51D0 */ get => default; } // 0x0000000184235680-0x0000000184235730 
		public GameObject itemTipsGrp { /* [XID] */ /* 0x00000001897BCE20-0x00000001897BCE40 */ get => default; } // 0x00000001842346E0-0x0000000184234790 
		public GameObject tabKeysGrp { /* [XID] */ /* 0x00000001897C41A0-0x00000001897C41C0 */ get => default; } // 0x00000001842353A0-0x0000000184235450 
		public Button returnBtn { /* [XID] */ /* 0x00000001897CBA00-0x00000001897CBA20 */ get => default; } // 0x00000001842348F0-0x00000001842349B0 
		public Button prevTabBtn { /* [XID] */ /* 0x00000001897D3310-0x00000001897D3330 */ get => default; } // 0x0000000184234840-0x00000001842348F0 
		public Button nextTabBtn { /* [XID] */ /* 0x00000001897DAD90-0x00000001897DADB0 */ get => default; } // 0x0000000184234790-0x0000000184234840 
		public UnityEngine.UI.Text weightLabel { /* [XID] */ /* 0x00000001897E24A0-0x00000001897E24C0 */ get => default; } // 0x0000000184235730-0x00000001842357D0 
		public Image icon { /* [XID] */ /* 0x00000001897E9C10-0x00000001897E9C30 */ get => default; } // 0x0000000184234190-0x0000000184234230 
		public MonoScrollRectExtention itemTipContainer { /* [XID] */ /* 0x00000001897F18D0-0x00000001897F18F0 */ get => default; } // 0x0000000184234550-0x00000001842345F0 
		public string useButtonTextID { /* [XID] */ /* 0x00000001897F9020-0x00000001897F9040 */ set {} } // 0x0000000184236BF0-0x0000000184236CD0
		public bool showUseButton { /* [XID] */ /* 0x0000000189800630-0x0000000189800650 */ set {} } // 0x0000000184236800-0x0000000184236900
		public MonoBagPageCookSelect bagPageCookSelect { /* [XID] */ /* 0x0000000189807CB0-0x0000000189807CD0 */ get => default; } // 0x0000000184233BB0-0x0000000184233C60 
		public bool showSortGrp { /* [XID] */ /* 0x0000000189825950-0x0000000189825970 */ set {} } // 0x00000001842366F0-0x0000000184236800
		public Button sortButton { /* [XID] */ /* 0x000000018982D100-0x000000018982D120 */ get => default; } // 0x0000000184234E90-0x0000000184235070 
		public MonoDropdownExtention sortDropdown { /* [XID] */ /* 0x0000000189834860-0x0000000189834880 */ get => default; } // 0x0000000184235070-0x0000000184235250 
		public bool showScreenButton { /* [XID] */ /* 0x000000018983BED0-0x000000018983BEF0 */ set {} } // 0x00000001842361C0-0x00000001842362D0
		public bool showSortDropDown { /* [XID] */ /* 0x0000000189843500-0x0000000189843520 */ set {} } // 0x00000001842365E0-0x00000001842366F0
		public bool showSortButton { /* [XID] */ /* 0x000000018984AA00-0x000000018984AA20 */ set {} } // 0x00000001842364D0-0x00000001842365E0
		public Button destroyItemButton { /* [XID] */ /* 0x0000000189851DE0-0x0000000189851E00 */ get => default; } // 0x0000000184233E30-0x0000000184234010 
		public Button screenButton { /* [XID] */ /* 0x00000001898596A0-0x00000001898596C0 */ get => default; } // 0x00000001842349B0-0x0000000184234B90 
		public MonoUIContainer itemSelectOkButton { /* [XID] */ /* 0x0000000189860840-0x0000000189860860 */ get => default; } // 0x00000001842343C0-0x0000000184234550 
		public MonoUIContainer itemSelectBackButton { /* [XID] */ /* 0x0000000189867F30-0x0000000189867F50 */ get => default; } // 0x0000000184234230-0x00000001842343C0 
		public MonoReusableList tabContainer { /* [XID] */ /* 0x000000018986F490-0x000000018986F4B0 */ get => default; } // 0x0000000184235250-0x0000000184235300 
		public bool showScreenTitleGrp { /* [XID] */ /* 0x0000000189876AC0-0x0000000189876AE0 */ get => default; /* [XID] */ /* 0x000000018987E5E0-0x000000018987E600 */ set {} } // 0x0000000184234DC0-0x0000000184234E90 0x00000001842363D0-0x00000001842364D0
		public string screenTitleText { /* [XID] */ /* 0x0000000189885990-0x00000001898859B0 */ set {} } // 0x0000000184235E10-0x0000000184235EE0
		public bool showScreenOptionGrp { /* [XID] */ /* 0x000000018988CCA0-0x000000018988CCC0 */ get => default; /* [XID] */ /* 0x0000000189894390-0x00000001898943B0 */ set {} } // 0x0000000184234CF0-0x0000000184234DC0 0x00000001842362D0-0x00000001842363D0
		public bool useScreen { /* [XID] */ /* 0x000000018989B900-0x000000018989B920 */ set {} } // 0x0000000184236CD0-0x0000000184237060
		public MonoGridScroller screenOptionScroller { /* [XID] */ /* 0x00000001898A2DD0-0x00000001898A2DF0 */ get => default; } // 0x0000000184234B90-0x0000000184234C40 
		public Sprite useButtonIcon { /* [XID] */ /* 0x00000001898B9910-0x00000001898B9930 */ set {} } // 0x0000000184236A80-0x0000000184236BF0
		public Sprite dropButtonIcon { /* [XID] */ /* 0x00000001898C0D30-0x00000001898C0D50 */ set {} } // 0x0000000184235890-0x0000000184235A00
		public MonoCurrencyList currency { /* [XID] */ /* 0x00000001898C8630-0x00000001898C8650 */ get => default; } // 0x0000000184233D20-0x0000000184233E30 
		public bool showEquippedLabel { /* [XID] */ /* 0x00000001898D0000-0x00000001898D0020 */ set {} } // 0x0000000184235FC0-0x00000001842360C0
		public Sprite equippedAvatarIconSprite { /* [XID] */ /* 0x00000001898D7610-0x00000001898D7630 */ set {} } // 0x0000000184235A00-0x0000000184235AD0
		public string equippedAvatarName { /* [XID] */ /* 0x00000001898DF340-0x00000001898DF360 */ set {} } // 0x0000000184235AD0-0x0000000184235BA0
		public bool showQuantityLabel { /* [XID] */ /* 0x00000001898E6D00-0x00000001898E6D20 */ set {} } // 0x00000001842360C0-0x00000001842361C0
		public string quantityText { /* [XID] */ /* 0x00000001898EE430-0x00000001898EE450 */ set {} } // 0x0000000184235D40-0x0000000184235E10
		public Button detailButton { /* [XID] */ /* 0x00000001898F5CA0-0x00000001898F5CC0 */ get => default; } // 0x0000000184234010-0x00000001842340D0 
		public Button backButton { /* [XID] */ /* 0x00000001898FD460-0x00000001898FD480 */ get => default; } // 0x0000000184233AF0-0x0000000184233BB0 
		public MonoUIContainer checkButton { /* [XID] */ /* 0x0000000189904D20-0x0000000189904D40 */ get => default; } // 0x0000000184233C60-0x0000000184233D20 
		public GameObject selectItemTipsObj { /* [XID] */ /* 0x000000018990C580-0x000000018990C5A0 */ get => default; } // 0x0000000184234C40-0x0000000184234CF0 
	
		// Constructors
		public MonoBagPage() {} // 0x00000001842339C0-0x0000000184233AF0
	
		// Methods
		// [XID] // 0x000000018980F5B0-0x000000018980F5D0
		protected void InitItemTip() {} // 0x00000001842335B0-0x0000000184233700
		// [XID] // 0x0000000189816C20-0x0000000189816C40
		protected virtual void Awake() {} // 0x0000000184233360-0x0000000184233400
		// [XID] // 0x000000018981E4D0-0x000000018981E4F0
		public bool isBagOpen() => default; // 0x00000001842357D0-0x0000000184235890
		// [XID] // 0x00000001898AA2F0-0x00000001898AA310
		public void CreateTabs(int count) {} // 0x0000000184233400-0x00000001842335B0
		// [XID] // 0x00000001898B1CD0-0x00000001898B1CF0
		public MonoImgTab GetTabAt(int index) => default; // 0x0000000184233700-0x0000000184233860
		// [XID] // 0x0000000189913E30-0x0000000189913E50
		public void UpdateBtnLockState(ItemLockState lockState) {} // 0x0000000184233860-0x00000001842339C0
	}
}
