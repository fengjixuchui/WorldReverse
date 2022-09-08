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
	public class MonoGiftPackageListRow : MonoSpriteProxy // TypeDefIndex: 30412
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		protected GameObject _itemSlotPrefab; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text _txtItemName; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text _txtItemNum; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected RectTransform _slotContainer; // 0x38
		protected MonoItemSlot _itemSlot; // 0x40
		protected MihoyoButton _backgroundButton; // 0x48
	
		// Properties
		public bool selected { /* [XID] */ /* 0x00000001899DE400-0x00000001899DE420 */ set {} } // 0x0000000184070D70-0x0000000184070E80
	
		// Constructors
		public MonoGiftPackageListRow() {} // 0x0000000184070D00-0x0000000184070D70
	
		// Methods
		// [XID] // 0x00000001899CFA20-0x00000001899CFA40
		protected void Awake() {} // 0x00000001840705A0-0x0000000184070700
		// [XID] // 0x00000001899D6DB0-0x00000001899D6DD0
		public void ResetItem(IdCountStrConfig rewardConfig, bool showCount = true /* Metadata: 0x00B10CF7 */) {} // 0x0000000184070700-0x0000000184070BB0
		// [XID] // 0x00000001899E60A0-0x00000001899E60C0
		public void ShowTip() {} // 0x0000000184070BB0-0x0000000184070D00
	}
}
