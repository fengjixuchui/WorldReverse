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
	public class MonoEquipAwakenUpDialog : MonoBehaviour // TypeDefIndex: 30540
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoAwakenAffixItem _goldAffixItem; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<MonoAwakenAffixItem> _affixItemList; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _iconRoot; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _itemIconPrefab; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _scroller; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _levelText; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x48
		public float protectTime; // 0x50
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public GameObject itemIcon; // 0x58
	
		// Properties
		public Button okButton { /* [XID] */ /* 0x000000018978D2F0-0x000000018978D310 */ get => default; } // 0x0000000183CA9660-0x0000000183CA9780 
		public GameObject itemIconPrefab { /* [XID] */ /* 0x0000000189794630-0x0000000189794650 */ get => default; } // 0x0000000183CA9520-0x0000000183CA95C0 
		public Transform iconRoot { /* [XID] */ /* 0x000000018979CAC0-0x000000018979CAE0 */ get => default; } // 0x0000000183CA9480-0x0000000183CA9520 
		public List<MonoAwakenAffixItem> affixItemList { /* [XID] */ /* 0x00000001897A3F20-0x00000001897A3F40 */ get => default; } // 0x0000000183CA9340-0x0000000183CA93E0 
		public ScrollRect scroller { /* [XID] */ /* 0x00000001897AB4A0-0x00000001897AB4C0 */ get => default; } // 0x0000000183CA9780-0x0000000183CA9820 
		public UnityEngine.UI.Text levelText { /* [XID] */ /* 0x00000001897B3290-0x00000001897B32B0 */ get => default; } // 0x0000000183CA95C0-0x0000000183CA9660 
		public MonoAwakenAffixItem goldAffixItem { /* [XID] */ /* 0x00000001897BB1B0-0x00000001897BB1D0 */ get => default; } // 0x0000000183CA93E0-0x0000000183CA9480 
	
		// Constructors
		public MonoEquipAwakenUpDialog() {} // 0x0000000183CA92C0-0x0000000183CA9340
	}
}
