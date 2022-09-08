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
	public class MonoItemTipsDialog : MonoUIProxy // TypeDefIndex: 31231
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Button _freeClickButton; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _background; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoScrollRectExtention _itemTipsContainer; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _itemTipsPrefab; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _quantity; // 0x60
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		protected MonoElementSwitch _elementSwitch; // 0x68
		private MonoMaxContentSizeFitter _maxSizeFitter; // 0x70
		private MonoItemTip _itemTip; // 0x78
	
		// Properties
		public MonoItemTip itemTip { /* [XID] */ /* 0x0000000189B8CC30-0x0000000189B8CC50 */ get => default; } // 0x0000000184336800-0x00000001843368A0 
		public MonoScrollRectExtention itemTipsContainer { /* [XID] */ /* 0x0000000189B94460-0x0000000189B94480 */ get => default; } // 0x00000001843368A0-0x0000000184336940 
		public GameObject quantity { /* [XID] */ /* 0x0000000189B9BB50-0x0000000189B9BB70 */ get => default; } // 0x0000000184336940-0x00000001843369E0 
		public Button freeClickButton { /* [XID] */ /* 0x0000000189BC84C0-0x0000000189BC84E0 */ get => default; } // 0x0000000184336760-0x0000000184336800 
		public MonoUIContainer checkButton { /* [XID] */ /* 0x0000000189BCFD30-0x0000000189BCFD50 */ get => default; } // 0x00000001843366A0-0x0000000184336760 
	
		// Constructors
		public MonoItemTipsDialog() {} // 0x0000000184336630-0x00000001843366A0
	
		// Methods
		// [XID] // 0x0000000189BA32A0-0x0000000189BA32C0
		protected void Awake() {} // 0x0000000184336000-0x00000001843361C0
		// [XID] // 0x0000000189BAA5E0-0x0000000189BAA600
		public void Setup() {} // 0x0000000184336290-0x0000000184336340
		// [XID] // 0x0000000189BB1CB0-0x0000000189BB1CD0
		public void UpdateByItemInfo(BagItem item) {} // 0x0000000184336340-0x0000000184336580
		// [XID] // 0x0000000189BB8FB0-0x0000000189BB8FD0
		public void UpdateSizeFitter() {} // 0x0000000184336580-0x0000000184336630
		// [XID] // 0x0000000189BC0D80-0x0000000189BC0DA0
		public void HideBackground() {} // 0x00000001843361C0-0x0000000184336290
	}
}
