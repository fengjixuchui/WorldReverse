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
	internal class MonoActivityFoodDeliveryButton : MonoSpriteProxy // TypeDefIndex: 30342
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _titleText; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected Button _actionButton; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected Image _iconImg; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _completeTrans; // 0x38
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoElementSwitch _elementSwitch; // 0x40
		public FOOD_DELIVERY_ORDER_STATE CurState; // 0x48
		private bool _hightlighted; // 0x4C
	
		// Properties
		public UnityEngine.UI.Text titleText { /* [XID] */ /* 0x00000001897DF240-0x00000001897DF260 */ get => default; } // 0x0000000186319510-0x00000001863195B0 
		public MonoUIContainer gotoBtn { /* [XID] */ /* 0x00000001897E6B00-0x00000001897E6B20 */ get => default; } // 0x0000000186319360-0x0000000186319470 
		public bool highlight { /* [XID] */ /* 0x0000000189804BA0-0x0000000189804BC0 */ get => default; /* [XID] */ /* 0x000000018980C1D0-0x000000018980C1F0 */ set {} } // 0x0000000186319470-0x0000000186319510 0x00000001863195B0-0x0000000186319810
		public bool selected_Arrow { /* [XID] */ /* 0x0000000189813980-0x00000001898139A0 */ set {} } // 0x0000000186319810-0x0000000186319A00
	
		// Constructors
		public MonoActivityFoodDeliveryButton() {} // 0x00000001863192E0-0x0000000186319360
	
		// Methods
		// [XID] // 0x00000001897EE670-0x00000001897EE690
		public void SetOrderState(FOOD_DELIVERY_ORDER_STATE state) {} // 0x0000000186318FB0-0x0000000186319100
		// [XID] // 0x00000001897F5EC0-0x00000001897F5EE0
		public void SetIcon(string iconName) {} // 0x0000000186318EA0-0x0000000186318FB0
		// [XID] // 0x00000001897FD5E0-0x00000001897FD600
		public void SetSelectedState(bool selected) {} // 0x0000000186319100-0x00000001863192E0
	}
}
