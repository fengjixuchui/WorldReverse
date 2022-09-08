/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoAvatarSelectDialog : MonoUIProxy // TypeDefIndex: 30520
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _returnBtn; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _scroller; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoWeaponChangeTip _weaponChangeTip; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoRelicChangeTip _relicChangeTip; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _weaponChangePanel; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _relicChangePanel; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x70
	
		// Properties
		public MonoUIContainer replaceBtnContainer { /* [XID] */ /* 0x00000001898C85F0-0x00000001898C8610 */ get => default; } // 0x00000001842271B0-0x00000001842272C0 
		public Button returnBtn { /* [XID] */ /* 0x00000001898CFFC0-0x00000001898CFFE0 */ get => default; } // 0x00000001842272C0-0x0000000184227360 
		public Button sortBtn { /* [XID] */ /* 0x00000001898D75D0-0x00000001898D75F0 */ get => default; } // 0x0000000184227400-0x0000000184227520 
		public Dropdown sortTypeDropdown { /* [XID] */ /* 0x00000001898DF300-0x00000001898DF320 */ get => default; } // 0x0000000184227520-0x0000000184227650 
		public MonoGridScroller scroller { /* [XID] */ /* 0x00000001898E6CC0-0x00000001898E6CE0 */ get => default; } // 0x0000000184227360-0x0000000184227400 
		public MonoWeaponChangeTip weaponChangeTip { /* [XID] */ /* 0x00000001898EE3F0-0x00000001898EE410 */ get => default; } // 0x00000001842276F0-0x0000000184227790 
		public MonoRelicChangeTip relicChangeTip { /* [XID] */ /* 0x00000001898F5C60-0x00000001898F5C80 */ get => default; } // 0x0000000184227110-0x00000001842271B0 
		public GameObject weaponChangePanel { /* [XID] */ /* 0x00000001898FD440-0x00000001898FD460 */ get => default; } // 0x0000000184227650-0x00000001842276F0 
		public GameObject relicChangePanel { /* [XID] */ /* 0x0000000189904D00-0x0000000189904D20 */ get => default; } // 0x0000000184227070-0x0000000184227110 
	
		// Constructors
		public MonoAvatarSelectDialog() {} // 0x0000000184226FF0-0x0000000184227070
	}
}
