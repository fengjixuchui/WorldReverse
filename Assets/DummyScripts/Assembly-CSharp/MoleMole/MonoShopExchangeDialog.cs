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
	public class MonoShopExchangeDialog : MonoUIProxy // TypeDefIndex: 30582
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _leftMaterialSelector; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _rightMaterialSelector; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _leftMaterialIcon; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _rightMaterialIcon; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _leftMaterialButton; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _rightMaterialButton; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _leftMaterialNum; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rightMaterialNum; // 0x78
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoUIContainer _quantityContainer; // 0x80
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Image _needIcon; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _needText; // 0x90
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Button _freeClickBtn; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _materialsContainer; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0xA8
	
		// Properties
		public RectTransform materialsContainer { /* [XID] */ /* 0x00000001895FC0A0-0x00000001895FC0C0 */ get => default; } // 0x000000018411ED10-0x000000018411EDC0 
		public Button freeClickBtn { /* [XID] */ /* 0x0000000189603AA0-0x0000000189603AC0 */ get => default; } // 0x000000018411EA60-0x000000018411EB10 
		public Button leftIconBtn { /* [XID] */ /* 0x000000018960B400-0x000000018960B420 */ get => default; } // 0x000000018411EBD0-0x000000018411EC70 
		public Button rightIconBtn { /* [XID] */ /* 0x00000001896127B0-0x00000001896127D0 */ get => default; } // 0x000000018411EF30-0x000000018411EFD0 
		public Image leftIcon { /* [XID] */ /* 0x000000018961A0D0-0x000000018961A0F0 */ get => default; } // 0x000000018411EC70-0x000000018411ED10 
		public Image rightIcon { /* [XID] */ /* 0x0000000189621610-0x0000000189621630 */ get => default; } // 0x000000018411EFD0-0x000000018411F070 
		public string leftTextNum { /* [XID] */ /* 0x0000000189628F20-0x0000000189628F40 */ set {} } // 0x000000018411F070-0x000000018411F140
		public string rightTextNum { /* [XID] */ /* 0x00000001896308A0-0x00000001896308C0 */ set {} } // 0x000000018411F210-0x000000018411F2E0
		public MonoUIContainer BtnCancel { /* [XID] */ /* 0x0000000189638340-0x0000000189638360 */ get => default; } // 0x000000018411E160-0x000000018411E220 
		public MonoUIContainer BtnExchange { /* [XID] */ /* 0x000000018963F720-0x000000018963F740 */ get => default; } // 0x000000018411E2E0-0x000000018411E3A0 
		public MonoUIContainer BtnDetail { /* [XID] */ /* 0x0000000189646F20-0x0000000189646F40 */ get => default; } // 0x000000018411E220-0x000000018411E2E0 
		public MonoUIContainer BtnInputNum { /* [XID] */ /* 0x000000018964E690-0x000000018964E6B0 */ get => default; } // 0x000000018411E3A0-0x000000018411E460 
		public MonoUIContainer BtnMinus100 { /* [XID] */ /* 0x0000000189655E80-0x0000000189655EA0 */ get => default; } // 0x000000018411E520-0x000000018411E5E0 
		public MonoUIContainer BtnPlus100 { /* [XID] */ /* 0x000000018965D660-0x000000018965D680 */ get => default; } // 0x000000018411E760-0x000000018411E820 
		public MonoUIContainer BtnMax { /* [XID] */ /* 0x0000000189664D60-0x0000000189664D80 */ get => default; } // 0x000000018411E460-0x000000018411E520 
		public MonoUIContainer GrpButton { /* [XID] */ /* 0x000000018966C380-0x000000018966C3A0 */ get => default; } // 0x000000018411E9A0-0x000000018411EA60 
		public MonoQuantityWidget quantityWidget { /* [XID] */ /* 0x0000000189674240-0x0000000189674260 */ get => default; } // 0x000000018411EE70-0x000000018411EF30 
		public InputField inputField { /* [XID] */ /* 0x000000018967BA20-0x000000018967BA40 */ get => default; } // 0x000000018411EB10-0x000000018411EBD0 
		public Button BtnPlus { /* [XID] */ /* 0x0000000189683130-0x0000000189683150 */ get => default; } // 0x000000018411E8E0-0x000000018411E9A0 
		public Button BtnMinus { /* [XID] */ /* 0x000000018968ABC0-0x000000018968ABE0 */ get => default; } // 0x000000018411E6A0-0x000000018411E760 
		public MonoLongPressButton BtnPlusLongPress { /* [XID] */ /* 0x00000001896928E0-0x0000000189692900 */ get => default; } // 0x000000018411E820-0x000000018411E8E0 
		public MonoLongPressButton BtnMinusLongPress { /* [XID] */ /* 0x0000000189699C60-0x0000000189699C80 */ get => default; } // 0x000000018411E5E0-0x000000018411E6A0 
		public Image needIcon { /* [XID] */ /* 0x00000001896A1380-0x00000001896A13A0 */ get => default; } // 0x000000018411EDC0-0x000000018411EE70 
		public string needText { /* [XID] */ /* 0x00000001896A87F0-0x00000001896A8810 */ set {} } // 0x000000018411F140-0x000000018411F210
		public bool selectLeftMaterial { /* [XID] */ /* 0x00000001896AF9C0-0x00000001896AF9E0 */ set {} } // 0x000000018411F2E0-0x000000018411F3D0
		public bool selectRightMaterial { /* [XID] */ /* 0x00000001896B7330-0x00000001896B7350 */ set {} } // 0x000000018411F3D0-0x000000018411F4C0
	
		// Constructors
		public MonoShopExchangeDialog() {} // 0x000000018411E0B0-0x000000018411E160
	}
}
