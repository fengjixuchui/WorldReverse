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
	public class MonoActivityFoodDeliveryDialog : MonoUIProxy // TypeDefIndex: 30343
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _bgTrans; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _taskText; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _foodImage; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _fetchNpcText; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _targetNpcText; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _attentionText; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _lockedText; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _lockedHintTrans; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _completeTrans; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _scroller; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _scrollRect; // 0x90
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoElementSwitch _elementSwitch; // 0x98
	
		// Properties
		public Transform bgTrans { /* [XID] */ /* 0x0000000189876AE0-0x0000000189876B00 */ get => default; } // 0x000000018631A0B0-0x000000018631A150 
		public UnityEngine.UI.Text taskText { /* [XID] */ /* 0x000000018987E600-0x000000018987E620 */ get => default; } // 0x000000018631A850-0x000000018631A8F0 
		public UnityEngine.UI.Text fetchText { /* [XID] */ /* 0x00000001898859B0-0x00000001898859D0 */ get => default; } // 0x000000018631A2D0-0x000000018631A370 
		public UnityEngine.UI.Text targetText { /* [XID] */ /* 0x000000018988CCC0-0x000000018988CCE0 */ get => default; } // 0x000000018631A7B0-0x000000018631A850 
		public UnityEngine.UI.Text attentionText { /* [XID] */ /* 0x00000001898943B0-0x00000001898943D0 */ get => default; } // 0x000000018631A010-0x000000018631A0B0 
		public UnityEngine.UI.Text lockedText { /* [XID] */ /* 0x000000018989B920-0x000000018989B940 */ get => default; } // 0x000000018631A430-0x000000018631A4D0 
		public Button prevBtn { /* [XID] */ /* 0x00000001898A2DF0-0x00000001898A2E10 */ get => default; } // 0x000000018631A590-0x000000018631A650 
		public Button nextBtn { /* [XID] */ /* 0x00000001898AA310-0x00000001898AA330 */ get => default; } // 0x000000018631A4D0-0x000000018631A590 
		public Button checkBtn { /* [XID] */ /* 0x00000001898B1CF0-0x00000001898B1D10 */ get => default; } // 0x000000018631A150-0x000000018631A210 
		public MonoGridScroller scroller { /* [XID] */ /* 0x00000001898B9930-0x00000001898B9950 */ get => default; } // 0x000000018631A700-0x000000018631A7B0 
		public Button gotoBtn { /* [XID] */ /* 0x00000001898C0D50-0x00000001898C0D70 */ get => default; } // 0x000000018631A370-0x000000018631A430 
		public Button closeBtn { /* [XID] */ /* 0x00000001898C8650-0x00000001898C8670 */ get => default; } // 0x000000018631A210-0x000000018631A2D0 
		public ScrollRect scrollRect { /* [XID] */ /* 0x00000001898D0020-0x00000001898D0040 */ get => default; } // 0x000000018631A650-0x000000018631A700 
	
		// Constructors
		public MonoActivityFoodDeliveryDialog() {} // 0x0000000186319F70-0x000000018631A010
	
		// Methods
		// [XID] // 0x00000001898D7630-0x00000001898D7650
		public void SetGotoBtnText(string str) {} // 0x0000000186319C00-0x0000000186319CE0
		// [XID] // 0x00000001898DF360-0x00000001898DF380
		public void SetState(FOOD_DELIVERY_ORDER_STATE state) {} // 0x0000000186319CE0-0x0000000186319E60
		// [XID] // 0x00000001898E6D20-0x00000001898E6D40
		public void UpdateIcon(string iconName) {} // 0x0000000186319E60-0x0000000186319F70
		// [XID] // 0x00000001898EE450-0x00000001898EE470
		public void SetButtonState(Button btn, bool isEnable) {} // 0x0000000186319A00-0x0000000186319C00
	}
}
