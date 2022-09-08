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
	public class MonoEquipSelectDialog : MonoUIProxy // TypeDefIndex: 30542
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _returnBtn; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _scroller; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _screeningPanel; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _screeningBg; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _screeningScroller; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _screenText; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x70
		public GameObject weaponGo; // 0x78
		public GameObject relicPanel; // 0x80
		public MonoTabGroup relicTab; // 0x88
		public MonoTabGroup relicTabSetType; // 0x90
		public RectTransform relicTabType1; // 0x98
		public RectTransform relicTabType2; // 0xA0
		public RectTransform relicTabType3; // 0xA8
		public RectTransform relicTabType4; // 0xB0
		public RectTransform relicTabType5; // 0xB8
		public MonoGridScroller relicItemScroller; // 0xC0
		public MonoGridScroller relicSetFilterScroller; // 0xC8
		public GameObject relicSetFilterGo; // 0xD0
		public GameObject relicScreeningTitleGo; // 0xD8
		public UnityEngine.UI.Text relicScreeningTitleText; // 0xE0
		public GameObject relicNoItemTipGo; // 0xE8
		public UnityEngine.UI.Text relicNoItemText; // 0xF0
		public GameObject buttomButtons; // 0xF8
	
		// Properties
		public MonoUIContainer replaceBtnContainer { /* [XID] */ /* 0x000000018989CE60-0x000000018989CE80 */ get => default; } // 0x0000000183CB0990-0x0000000183CB0A50 
		public MonoUIContainer replaceBtnRelicContainer { /* [XID] */ /* 0x00000001898A4620-0x00000001898A4640 */ get => default; } // 0x0000000183CB0A50-0x0000000183CB0B10 
		public MonoUIContainer dischargeBtnContainer { /* [XID] */ /* 0x00000001898ABAE0-0x00000001898ABB00 */ get => default; } // 0x0000000183CB0810-0x0000000183CB08D0 
		public MonoUIContainer promoteBtnContainer { /* [XID] */ /* 0x00000001898B3290-0x00000001898B32B0 */ get => default; } // 0x0000000183CB08D0-0x0000000183CB0990 
		public Button returnBtn { /* [XID] */ /* 0x00000001898BAF90-0x00000001898BAFB0 */ get => default; } // 0x0000000183CB0B10-0x0000000183CB0BB0 
		public Button sortBtn { /* [XID] */ /* 0x00000001898C2300-0x00000001898C2320 */ get => default; } // 0x0000000183CB0FF0-0x0000000183CB1110 
		public Dropdown sortDropdown { /* [XID] */ /* 0x00000001898C9D20-0x00000001898C9D40 */ get => default; } // 0x0000000183CB1110-0x0000000183CB1240 
		public Dropdown sortTypeDropdown { /* [XID] */ /* 0x00000001898D1320-0x00000001898D1340 */ get => default; } // 0x0000000183CB1240-0x0000000183CB1370 
		public MonoGridScroller scroller { /* [XID] */ /* 0x00000001898D8BE0-0x00000001898D8C00 */ get => default; } // 0x0000000183CB0F50-0x0000000183CB0FF0 
		public GameObject screeningPanel { /* [XID] */ /* 0x00000001898E08B0-0x00000001898E08D0 */ get => default; } // 0x0000000183CB0E10-0x0000000183CB0EB0 
		public GameObject screeningBg { /* [XID] */ /* 0x00000001898E8410-0x00000001898E8430 */ get => default; } // 0x0000000183CB0D70-0x0000000183CB0E10 
		public MonoGridScroller screeningScroller { /* [XID] */ /* 0x00000001898EFB90-0x00000001898EFBB0 */ get => default; } // 0x0000000183CB0EB0-0x0000000183CB0F50 
		public Button screenBtn { /* [XID] */ /* 0x00000001898F73D0-0x00000001898F73F0 */ get => default; } // 0x0000000183CB0BB0-0x0000000183CB0CD0 
		public UnityEngine.UI.Text screenText { /* [XID] */ /* 0x00000001898FEB40-0x00000001898FEB60 */ get => default; } // 0x0000000183CB0CD0-0x0000000183CB0D70 
		public MonoUIContainer contrastContainer { /* [XID] */ /* 0x0000000189906280-0x00000001899062A0 */ get => default; } // 0x0000000183CB0700-0x0000000183CB0810 
		public bool showScreenBtnDetailIcon { /* [XID] */ /* 0x00000001899154F0-0x0000000189915510 */ set {} } // 0x0000000183CB1370-0x0000000183CB1510
	
		// Constructors
		public MonoEquipSelectDialog() {} // 0x0000000183CB0680-0x0000000183CB0700
	
		// Methods
		// [XID] // 0x000000018990DD40-0x000000018990DD60
		public void ShowForRelic(bool relic) {} // 0x0000000183CB0390-0x0000000183CB0480
		// [XID] // 0x000000018991CF40-0x000000018991CF60
		public void UpdateBtnLockState(ItemLockState lockState) {} // 0x0000000183CB0480-0x0000000183CB0680
	}
}
