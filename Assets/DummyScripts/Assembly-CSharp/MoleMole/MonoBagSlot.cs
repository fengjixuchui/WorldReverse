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
	public class MonoBagSlot : MonoSpriteProxy, IPointerClickHandler // TypeDefIndex: 30406
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected bool _promptTips; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected Image _iconImg; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text _txtItemNum; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected Image _backImg; // 0x38
		protected ulong _itemGuid; // 0x40
		protected int _index; // 0x48
		private bool _selected; // 0x4C
		protected Action<int> _bagSlotClickHandler; // 0x50
	
		// Properties
		public bool promptTips { /* [XID] */ /* 0x000000018973B160-0x000000018973B180 */ set {} } // 0x00000001848F1170-0x00000001848F1220
		public int index { /* [XID] */ /* 0x0000000189742B10-0x0000000189742B30 */ set {} } // 0x00000001848F10C0-0x00000001848F1170
	
		// Constructors
		public MonoBagSlot() {} // 0x00000001848F1040-0x00000001848F10C0
	
		// Methods
		// [XID] // 0x000000018974A7F0-0x000000018974A810
		public void RegisterBagSlotClickHandler(Action<int> handler) {} // 0x00000001848F09E0-0x00000001848F0A90
		// [XID] // 0x00000001897518D0-0x00000001897518F0
		protected bool IsBagItemSlotInValid(BagItemSlot bagItemSlot) => default; // 0x00000001848F0670-0x00000001848F0760
		// [XID] // 0x0000000189758EA0-0x0000000189758EC0
		public virtual void UpdateBagSlot(BagItemSlot bagItemSlot) {} // 0x00000001848F0C00-0x00000001848F0E40
		// [XID] // 0x0000000189760B30-0x0000000189760B50
		public void UpdateSlot(BagItem bagItem) {} // 0x00000001848F0E40-0x00000001848F1040
		// [XID] // 0x0000000189767DF0-0x0000000189767E10
		public virtual void UpdateBagSlotSelect(bool enable) {} // 0x00000001848F0A90-0x00000001848F0C00
		// [XID] // 0x000000018976F3C0-0x000000018976F3E0
		protected virtual void Clear() {} // 0x00000001848F04F0-0x00000001848F0670
		// [XID] // 0x0000000189776DE0-0x0000000189776E00
		public void OnPointerClick(PointerEventData eventData) {} // 0x00000001848F0760-0x00000001848F09E0
	}
}
