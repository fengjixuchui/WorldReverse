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
	public class MonoGachaTransItemSlot : MonoSpriteProxy // TypeDefIndex: 29723
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Animator _animator; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _image; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _text; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _numText; // 0x38
		private ItemConfig _itemConfig; // 0x40
		private uint _lastRank; // 0x48
	
		// Properties
		public Animator animator { /* [XID] */ /* 0x00000001896635A0-0x00000001896635C0 */ get => default; } // 0x000000018406DEB0-0x000000018406DF50 
		public Image image { /* [XID] */ /* 0x0000000189689570-0x0000000189689590 */ get => default; } // 0x000000018406DF50-0x000000018406DFF0 
		public UnityEngine.UI.Text text { /* [XID] */ /* 0x0000000189691190-0x00000001896911B0 */ get => default; } // 0x000000018406DFF0-0x000000018406E090 
	
		// Constructors
		public MonoGachaTransItemSlot() {} // 0x000000018406DE30-0x000000018406DEB0
	
		// Methods
		// [XID] // 0x000000018966AF70-0x000000018966AF90
		private void OnEnable() {} // 0x000000018406D740-0x000000018406D890
		// [XID] // 0x0000000189672B90-0x0000000189672BB0
		public void SetupItem(ItemParam item, bool isNew) {} // 0x000000018406D890-0x000000018406DE30
		// [XID] // 0x000000018967A290-0x000000018967A2B0
		protected override void OnDestroy() {} // 0x000000018406D680-0x000000018406D740
		// [XID] // 0x0000000189681AE0-0x0000000189681B00
		protected virtual void Clear() {} // 0x000000018406D500-0x000000018406D680
	}
}
