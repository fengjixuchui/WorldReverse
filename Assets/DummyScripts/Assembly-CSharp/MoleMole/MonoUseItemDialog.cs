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
	public class MonoUseItemDialog : MonoUIProxy // TypeDefIndex: 30597
	{
		// Fields
		private const string ITEM_SLOT_PREFAB_PATH = "ART/UI/Menus/Widget/BagItemSlot"; // Metadata: 0x00B112F4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _titleText; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _itemNameText; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _itemDescText; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoQuantityWidget _quantityWidget; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _itemSlotRoot; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _backButton; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x70
		private MonoBagProxySlot _itemSlot; // 0x78
	
		// Properties
		public UnityEngine.UI.Text titleText { /* [XID] */ /* 0x00000001897818D0-0x00000001897818F0 */ get => default; } // 0x000000018489C940-0x000000018489C9E0 
		public UnityEngine.UI.Text itemNameText { /* [XID] */ /* 0x0000000189788DD0-0x0000000189788DF0 */ get => default; } // 0x000000018489C590-0x000000018489C630 
		public UnityEngine.UI.Text itemDescText { /* [XID] */ /* 0x00000001897903C0-0x00000001897903E0 */ get => default; } // 0x000000018489C4F0-0x000000018489C590 
		public MonoQuantityWidget quantityWidget { /* [XID] */ /* 0x0000000189797D30-0x0000000189797D50 */ get => default; } // 0x000000018489C8A0-0x000000018489C940 
		public Button backButton { /* [XID] */ /* 0x000000018979FA10-0x000000018979FA30 */ get => default; } // 0x000000018489C390-0x000000018489C430 
		public MonoUIContainer okButton { /* [XID] */ /* 0x00000001897A7010-0x00000001897A7030 */ get => default; } // 0x000000018489C7E0-0x000000018489C8A0 
		public MonoUIContainer cancelButton { /* [XID] */ /* 0x00000001897AE980-0x00000001897AE9A0 */ get => default; } // 0x000000018489C430-0x000000018489C4F0 
		public MonoBagProxySlot itemSlot { /* [XID] */ /* 0x00000001897B6830-0x00000001897B6850 */ get => default; } // 0x000000018489C630-0x000000018489C7E0 
	
		// Constructors
		public MonoUseItemDialog() {} // 0x000000018489C2B0-0x000000018489C390
	
		// Methods
		// [XID] // 0x00000001897BE690-0x00000001897BE6B0
		protected override void OnDestroy() {} // 0x000000018489C190-0x000000018489C2B0
	}
}
