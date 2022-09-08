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
	public class MonoLunchBoxListRow : MonoSpriteProxy // TypeDefIndex: 30821
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionButton; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _iconBuff; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _iconAdd; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _iconItem; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _text; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _textCanvasGroup; // 0x48
		private List<BagItemSlot> _itemList; // 0x50
	
		// Properties
		public Button actionButton { /* [XID] */ /* 0x0000000189B40F30-0x0000000189B40F50 */ get => default; } // 0x0000000184289DA0-0x0000000184289E40 
	
		// Constructors
		public MonoLunchBoxListRow() {} // 0x0000000184289CF0-0x0000000184289DA0
	
		// Methods
		// [IDTag] // 0x0000000189B48880-0x0000000189B488C0
		// [XID] // 0x0000000189B48880-0x0000000189B488C0
		public void Setup(WidgetSystemModule.LunchBoxType type) {} // 0x0000000184289640-0x0000000184289990
		// [IDTag] // 0x0000000189B52DD0-0x0000000189B52E10
		// [XID] // 0x0000000189B52DD0-0x0000000189B52E10
		public void Setup(BagItemSlot bagItem) {} // 0x0000000184289990-0x0000000184289CF0
		// [XID] // 0x0000000189B5D940-0x0000000189B5D960
		private void RefreshItem(Transform trans, int index) {} // 0x00000001842894B0-0x0000000184289640
	}
}
