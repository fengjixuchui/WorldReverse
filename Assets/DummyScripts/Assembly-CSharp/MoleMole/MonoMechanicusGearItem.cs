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
	public class MonoMechanicusGearItem : MonoSpriteProxy // TypeDefIndex: 30390
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _itemIcon; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _nameText; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _levelText; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _lockTipsText; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionBtn; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _levelGrp; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockGrp; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _unLockGrp; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _new; // 0x68
	
		// Properties
		public Button actionBtn { /* [XID] */ /* 0x0000000189664E20-0x0000000189664E40 */ get => default; } // 0x000000018493AB30-0x000000018493ABD0 
		public uint gearId { get; /* [XID] */ /* 0x0000000189674300-0x0000000189674340 */ private set; } // 0x000000018493ABD0-0x000000018493AC30 0x000000018493A590-0x000000018493A5F0
		public uint level { get; /* [XID] */ /* 0x0000000189685F80-0x0000000189685FC0 */ private set; } // 0x000000018493AD40-0x000000018493ADA0 0x000000018493A5F0-0x000000018493A650
		public bool isSelected { /* [XID] */ /* 0x00000001896910B0-0x00000001896910D0 */ get => default; } // 0x000000018493AC30-0x000000018493AD40 
		public bool ShowNew { /* [XID] */ /* 0x000000018969FCB0-0x000000018969FCD0 */ set {} } // 0x000000018493ADA0-0x000000018493AE90
	
		// Constructors
		public MonoMechanicusGearItem() {} // 0x000000018493AAA0-0x000000018493AB30
	
		// Methods
		// [XID] // 0x0000000189698820-0x0000000189698840
		public void SetGearListRow(uint gearId, uint level = 0 /* Metadata: 0x00B10A1B */, bool isLocked = false /* Metadata: 0x00B10A1F */) {} // 0x000000018493A650-0x000000018493AAA0
	}
}
