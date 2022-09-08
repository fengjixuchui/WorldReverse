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
	public class MonoShopPurchaseDialog : MonoUIProxy // TypeDefIndex: 30585
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _freeClickBtn; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoPurchaseItem _monoPurchaseItem; // 0x48
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoUIContainer _slider; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _exchangeItemContainer; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _materialsContainer; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x68
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UnityEngine.UI.Text _txtTitle; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtMinNum; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtMaxNum; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtContentTitle; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SimpleText _txtContentNum; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTime; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _sliderNum; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _sliderRoot; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _highlightTipText; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _highlightTipRoot; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoQuantityWidget _quantityWidget; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected bool _enableRatioNumChange; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _ratioMinTime; // 0xCC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _ratioMaxTime; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _ratioMax; // 0xD4
	
		// Properties
		public bool showSliderRoot { /* [XID] */ /* 0x0000000189882630-0x0000000189882650 */ set {} } // 0x00000001841277E0-0x00000001841278D0
		public MonoQuantityWidget quantityWidget { /* [XID] */ /* 0x0000000189889DC0-0x0000000189889DE0 */ get => default; } // 0x0000000184126E80-0x0000000184126F30 
		public Slider slider { /* [XID] */ /* 0x0000000189891260-0x0000000189891280 */ get => default; } // 0x00000001841271F0-0x00000001841272F0 
		public RectTransform exchangeItemContainer { /* [XID] */ /* 0x0000000189898870-0x0000000189898890 */ get => default; } // 0x0000000184126790-0x0000000184126830 
		public RectTransform materialsContainer { /* [XID] */ /* 0x000000018989FAB0-0x000000018989FAD0 */ get => default; } // 0x0000000184126980-0x0000000184126A20 
		public UnityEngine.UI.Text txtTitle { /* [XID] */ /* 0x00000001898A74E0-0x00000001898A7500 */ get => default; } // 0x0000000184127650-0x00000001841276F0 
		public UnityEngine.UI.Text txtMinNum { /* [XID] */ /* 0x00000001898AEEC0-0x00000001898AEEE0 */ get => default; } // 0x0000000184127500-0x00000001841275A0 
		public UnityEngine.UI.Text txtMaxNum { /* [XID] */ /* 0x00000001898B62D0-0x00000001898B62F0 */ get => default; } // 0x0000000184127450-0x0000000184127500 
		public UnityEngine.UI.Text txtContentTitle { /* [XID] */ /* 0x00000001898BDBA0-0x00000001898BDBC0 */ get => default; } // 0x00000001841273A0-0x0000000184127450 
		public SimpleText txtContentNum { /* [XID] */ /* 0x00000001898C5440-0x00000001898C5460 */ get => default; } // 0x00000001841272F0-0x00000001841273A0 
		public UnityEngine.UI.Text txtTime { /* [XID] */ /* 0x00000001898CC960-0x00000001898CC980 */ get => default; } // 0x00000001841275A0-0x0000000184127650 
		public Button freeClickBtn { /* [XID] */ /* 0x00000001898D4380-0x00000001898D43A0 */ get => default; } // 0x0000000184126830-0x00000001841268D0 
		public MonoPurchaseItem monoPurchaseItem { /* [XID] */ /* 0x00000001898DBB60-0x00000001898DBB80 */ get => default; } // 0x0000000184126C00-0x0000000184126CA0 
		public GameObject sliderNum { /* [XID] */ /* 0x00000001898E3740-0x00000001898E3760 */ get => default; } // 0x0000000184127140-0x00000001841271F0 
		public UnityEngine.UI.Text highlightTipText { /* [XID] */ /* 0x00000001898EB3E0-0x00000001898EB400 */ get => default; } // 0x00000001841268D0-0x0000000184126980 
		public bool showHightlightTip { /* [XID] */ /* 0x00000001898F2B20-0x00000001898F2B40 */ set {} } // 0x00000001841276F0-0x00000001841277E0
		public Button closeBtn { /* [XID] */ /* 0x00000001898FA290-0x00000001898FA2B0 */ get => default; } // 0x0000000184126340-0x0000000184126520 
		public Button cancelBtn { /* [XID] */ /* 0x0000000189901C60-0x0000000189901C80 */ get => default; } // 0x0000000184126160-0x0000000184126340 
		public MonoUIContainer confirmBtn { /* [XID] */ /* 0x00000001899094D0-0x00000001899094F0 */ get => default; } // 0x0000000184126520-0x00000001841266E0 
		public Button plusBtn { /* [XID] */ /* 0x00000001899108E0-0x0000000189910900 */ get => default; } // 0x0000000184126CA0-0x0000000184126E80 
		public Button minusBtn { /* [XID] */ /* 0x0000000189918500-0x0000000189918520 */ get => default; } // 0x0000000184126A20-0x0000000184126C00 
		public bool showTimeText { /* [XID] */ /* 0x000000018991FD00-0x000000018991FD20 */ set {} } // 0x00000001841278D0-0x0000000184127A30
		public bool enableRationNum { /* [XID] */ /* 0x00000001899275A0-0x00000001899275C0 */ get => default; } // 0x00000001841266E0-0x0000000184126790 
		public float ratioMinTime { /* [XID] */ /* 0x000000018992ED00-0x000000018992ED20 */ get => default; } // 0x0000000184127090-0x0000000184127140 
		public float ratioMaxTime { /* [XID] */ /* 0x0000000189936130-0x0000000189936150 */ get => default; } // 0x0000000184126F30-0x0000000184126FE0 
		public float ratioMax { /* [XID] */ /* 0x000000018993DB70-0x000000018993DB90 */ get => default; } // 0x0000000184126FE0-0x0000000184127090 
	
		// Constructors
		public MonoShopPurchaseDialog() {} // 0x0000000184126070-0x0000000184126160
	}
}
