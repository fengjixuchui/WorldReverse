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
	public class MonoCodexEquipPage : MonoUIProxy // TypeDefIndex: 30494
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _weaponScroller; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _reliquarySuitScroller; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _weaponGroup; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _weaponInfo; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _reliquaryGroup; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _reliquaryInfo; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _noInfoGroup; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _title; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _collectedNum; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _weaponName; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _weaponDesc; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _reliquaryName; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _reliquaryType; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _reliquarySuitName; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoStarRate _reliquaryStarRate; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text[] _reliquarySetDesc; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _reliquaryDesc; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoTabGroup _relicTabSetType; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _noInfoTitle; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _noInfoDesc; // 0xE0
	
		// Properties
		public MonoGridScroller weaponScroller { /* [XID] */ /* 0x00000001899BC0A0-0x00000001899BC0C0 */ get => default; } // 0x0000000184BA43C0-0x0000000184BA4460 
		public MonoGridScroller reliquarySuitScroller { /* [XID] */ /* 0x00000001899C3B90-0x00000001899C3BB0 */ get => default; } // 0x0000000184BA3D80-0x0000000184BA3E20 
		public RectTransform weaponGroup { /* [XID] */ /* 0x00000001899CB250-0x00000001899CB270 */ get => default; } // 0x0000000184BA41D0-0x0000000184BA4270 
		public RectTransform weaponInfo { /* [XID] */ /* 0x00000001899D2720-0x00000001899D2740 */ get => default; } // 0x0000000184BA4270-0x0000000184BA4310 
		public RectTransform reliquaryGroup { /* [XID] */ /* 0x00000001899D9E70-0x00000001899D9E90 */ get => default; } // 0x0000000184BA3980-0x0000000184BA3A20 
		public RectTransform reliquaryInfo { /* [XID] */ /* 0x00000001899E1750-0x00000001899E1770 */ get => default; } // 0x0000000184BA3A20-0x0000000184BA3AC0 
		public RectTransform noInfoGroup { /* [XID] */ /* 0x00000001899E8D80-0x00000001899E8DA0 */ get => default; } // 0x0000000184BA3610-0x0000000184BA36B0 
		public Text title { /* [XID] */ /* 0x00000001899F0700-0x00000001899F0720 */ get => default; } // 0x0000000184BA4070-0x0000000184BA4120 
		public Text collectedNum { /* [XID] */ /* 0x00000001899F7D40-0x00000001899F7D60 */ get => default; } // 0x0000000184BA34B0-0x0000000184BA3560 
		public Text weaponName { /* [XID] */ /* 0x00000001899FF3D0-0x00000001899FF3F0 */ get => default; } // 0x0000000184BA4310-0x0000000184BA43C0 
		public Text weaponDesc { /* [XID] */ /* 0x0000000189A06B90-0x0000000189A06BB0 */ get => default; } // 0x0000000184BA4120-0x0000000184BA41D0 
		public Text reliquaryName { /* [XID] */ /* 0x0000000189A0E2A0-0x0000000189A0E2C0 */ get => default; } // 0x0000000184BA3AC0-0x0000000184BA3B70 
		public Text reliquaryType { /* [XID] */ /* 0x0000000189A158A0-0x0000000189A158C0 */ get => default; } // 0x0000000184BA3E20-0x0000000184BA3ED0 
		public Text reliquarySuitName { /* [XID] */ /* 0x0000000189A1CD60-0x0000000189A1CD80 */ get => default; } // 0x0000000184BA3CD0-0x0000000184BA3D80 
		public MonoStarRate reliquaryStarRate { /* [XID] */ /* 0x0000000189A242A0-0x0000000189A242C0 */ get => default; } // 0x0000000184BA3C20-0x0000000184BA3CD0 
		public Text reliquaryDesc { /* [XID] */ /* 0x0000000189A2B760-0x0000000189A2B780 */ get => default; } // 0x0000000184BA38D0-0x0000000184BA3980 
		public Text[] reliquarySetDesc { /* [XID] */ /* 0x0000000189A32DA0-0x0000000189A32DC0 */ get => default; } // 0x0000000184BA3B70-0x0000000184BA3C20 
		public MonoTabGroup relicTabSetType { /* [XID] */ /* 0x0000000189A3A5F0-0x0000000189A3A610 */ get => default; } // 0x0000000184BA3820-0x0000000184BA38D0 
		public Text noInfoTitle { /* [XID] */ /* 0x0000000189A41F40-0x0000000189A41F60 */ get => default; } // 0x0000000184BA36B0-0x0000000184BA3760 
		public Text noInfoDesc { /* [XID] */ /* 0x0000000189A494F0-0x0000000189A49510 */ get => default; } // 0x0000000184BA3560-0x0000000184BA3610 
		public MonoUIContainer backBtn { /* [XID] */ /* 0x0000000189A50E00-0x0000000189A50E20 */ get => default; } // 0x0000000184BA31B0-0x0000000184BA3270 
		public MonoUIContainer weaponStoryBtn { /* [XID] */ /* 0x0000000189A58320-0x0000000189A58340 */ get => default; } // 0x0000000184BA4460-0x0000000184BA4520 
		public MonoUIContainer relicStoryBtn { /* [XID] */ /* 0x0000000189A5FE20-0x0000000189A5FE40 */ get => default; } // 0x0000000184BA3760-0x0000000184BA3820 
		public MonoUIContainer awakenToggle { /* [XID] */ /* 0x0000000189A67AE0-0x0000000189A67B00 */ get => default; } // 0x0000000184BA30F0-0x0000000184BA31B0 
		public MonoUIContainer screenBtn { /* [XID] */ /* 0x0000000189A6EEF0-0x0000000189A6EF10 */ get => default; } // 0x0000000184BA3ED0-0x0000000184BA3F90 
		public MonoUIContainer checkBtn { /* [XID] */ /* 0x0000000189A76730-0x0000000189A76750 */ get => default; } // 0x0000000184BA33F0-0x0000000184BA34B0 
		public MonoReusableList tabList { /* [XID] */ /* 0x0000000189A7E040-0x0000000189A7E060 */ get => default; } // 0x0000000184BA3F90-0x0000000184BA4070 
		public Button btnTabPrev { /* [XID] */ /* 0x0000000189A85980-0x0000000189A859A0 */ get => default; } // 0x0000000184BA3330-0x0000000184BA33F0 
		public Button btnTabNext { /* [XID] */ /* 0x0000000189A8D280-0x0000000189A8D2A0 */ get => default; } // 0x0000000184BA3270-0x0000000184BA3330 
	
		// Constructors
		public MonoCodexEquipPage() {} // 0x0000000184BA3010-0x0000000184BA30F0
	}
}
