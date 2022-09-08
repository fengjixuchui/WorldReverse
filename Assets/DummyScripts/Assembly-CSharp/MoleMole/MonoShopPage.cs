/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoShopPage : MonoUIProxy, IPointerClickHandler // TypeDefIndex: 31066
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoUIContainer _exchangeBtn; // 0x40
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private ScrollRect _itemTipsContainer; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _materialsContainer; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _goodsScroller; // 0x58
		private MonoItemTip _itemTips; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _quantityText; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _refreshTimeText; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _shopTitle; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _unlockPromptText; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selectItemTipsObj; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtHadItemNum; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtNoItemTipTitle; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtNoItemTipDesc; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _BtnVip; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _vipDesc; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _vipTipsGrp; // 0xC0
	
		// Properties
		public Button BtnVip { /* [XID] */ /* 0x00000001897ECE70-0x00000001897ECE90 */ get => default; } // 0x0000000184124BA0-0x0000000184124C50 
		public string VIPDesc { /* [XID] */ /* 0x00000001897F4690-0x00000001897F46B0 */ set {} } // 0x0000000184125A80-0x0000000184125B60
		public GameObject vipTipsGrp { /* [XID] */ /* 0x00000001897FC0C0-0x00000001897FC0E0 */ get => default; } // 0x00000001841259D0-0x0000000184125A80 
		public MonoUIContainer closeButton { /* [XID] */ /* 0x0000000189803510-0x0000000189803530 */ get => default; } // 0x0000000184124DD0-0x0000000184124E90 
		public MonoUIContainer exchangeButton { /* [XID] */ /* 0x000000018980AB80-0x000000018980ABA0 */ get => default; } // 0x0000000184124F50-0x0000000184125010 
		public bool showExchangeButton { /* [XID] */ /* 0x0000000189812150-0x0000000189812170 */ set {} } // 0x0000000184125CB0-0x0000000184125DB0
		public MonoGridScroller goodsScroller { /* [XID] */ /* 0x0000000189819D00-0x0000000189819D20 */ get => default; } // 0x0000000184125010-0x00000001841250B0 
		public MonoItemTip itemTips { /* [XID] */ /* 0x0000000189821580-0x00000001898215A0 */ get => default; /* [XID] */ /* 0x0000000189828B70-0x0000000189828B90 */ set {} } // 0x00000001841252F0-0x0000000184125390 0x0000000184125B60-0x0000000184125CB0
		public RectTransform materialsContainer { /* [XID] */ /* 0x000000018982FFA0-0x000000018982FFC0 */ get => default; } // 0x0000000184125390-0x0000000184125430 
		public RectTransform itemTipsContainer { /* [XID] */ /* 0x00000001898376E0-0x0000000189837700 */ get => default; } // 0x0000000184125160-0x0000000184125210 
		public UnityEngine.UI.Text unlockPromptText { /* [XID] */ /* 0x000000018983EDB0-0x000000018983EDD0 */ get => default; } // 0x0000000184125920-0x00000001841259D0 
		public MonoQuantityWidget quantityWidget { /* [XID] */ /* 0x000000018985C2A0-0x000000018985C2C0 */ get => default; } // 0x0000000184125630-0x0000000184125730 
		public UnityEngine.UI.Text quantityText { /* [XID] */ /* 0x0000000189863C00-0x0000000189863C20 */ get => default; } // 0x0000000184125590-0x0000000184125630 
		public UnityEngine.UI.Text refreshTimeText { /* [XID] */ /* 0x000000018986AED0-0x000000018986AEF0 */ get => default; } // 0x0000000184125730-0x00000001841257D0 
		public UnityEngine.UI.Text shopTitle { /* [XID] */ /* 0x00000001898722E0-0x0000000189872300 */ get => default; } // 0x0000000184125880-0x0000000184125920 
		public UnityEngine.UI.Text noItemTipTitle { /* [XID] */ /* 0x0000000189879F50-0x0000000189879F70 */ get => default; } // 0x00000001841254E0-0x0000000184125590 
		public UnityEngine.UI.Text noItemTipDesc { /* [XID] */ /* 0x0000000189881090-0x00000001898810B0 */ get => default; } // 0x0000000184125430-0x00000001841254E0 
		public GameObject selectItemTipsObj { /* [XID] */ /* 0x0000000189888660-0x0000000189888680 */ get => default; } // 0x00000001841257D0-0x0000000184125880 
		public MonoUIContainer checkButton { /* [XID] */ /* 0x000000018988FA20-0x000000018988FA40 */ get => default; } // 0x0000000184124D10-0x0000000184124DD0 
		public MonoUIContainer backButton { /* [XID] */ /* 0x0000000189896F20-0x0000000189896F40 */ get => default; } // 0x0000000184124C50-0x0000000184124D10 
		public MonoUIContainer detailButton { /* [XID] */ /* 0x000000018989E420-0x000000018989E440 */ get => default; } // 0x0000000184124E90-0x0000000184124F50 
		public MonoScrollRectExtention itemTipsScroller { /* [XID] */ /* 0x00000001898A5EF0-0x00000001898A5F10 */ get => default; } // 0x0000000184125210-0x00000001841252F0 
		public UnityEngine.UI.Text hadItemNum { /* [XID] */ /* 0x00000001898AD530-0x00000001898AD550 */ get => default; } // 0x00000001841250B0-0x0000000184125160 
		public bool showHadItemNum { /* [XID] */ /* 0x00000001898B4A70-0x00000001898B4A90 */ set {} } // 0x0000000184125DB0-0x0000000184125F10
		public bool showNoItemTip { /* [XID] */ /* 0x00000001898BC600-0x00000001898BC620 */ set {} } // 0x0000000184125F10-0x0000000184126070
	
		// Constructors
		public MonoShopPage() {} // 0x0000000184124AD0-0x0000000184124BA0
	
		// Methods
		// [XID] // 0x00000001898463F0-0x0000000189846410
		public void SetupSizeFitter() {} // 0x0000000184124A00-0x0000000184124AD0
		// [XID] // 0x000000018984D9E0-0x000000018984DA00
		public void AdjustItemTipsContainerSize() {} // 0x00000001841247F0-0x00000001841248C0
		// [XID] // 0x0000000189854A40-0x0000000189854A60
		public void OnPointerClick(PointerEventData eventData) {} // 0x00000001841248C0-0x0000000184124A00
	}
}
