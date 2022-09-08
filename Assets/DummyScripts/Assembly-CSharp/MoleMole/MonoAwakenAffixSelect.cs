/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

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
	public class MonoAwakenAffixSelect : MonoBehaviour // TypeDefIndex: 30696
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _bgSelect; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Scrollbar _scrollBar; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selectedImg; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<MonoAwakenAffixItem> _affixItemList; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x38
	
		// Properties
		public MonoUIContainer plusBtn { /* [XID] */ /* 0x0000000189B2A890-0x0000000189B2A8B0 */ get => default; } // 0x0000000184233000-0x0000000184233110 
		public MonoUIContainer minusBtn { /* [XID] */ /* 0x0000000189B31E00-0x0000000189B31E20 */ get => default; } // 0x0000000184232EF0-0x0000000184233000 
		public List<MonoAwakenAffixItem> affixItemList { /* [XID] */ /* 0x0000000189B39600-0x0000000189B39620 */ get => default; } // 0x0000000184232DB0-0x0000000184232E50 
		public GameObject bgSelect { /* [XID] */ /* 0x0000000189B40F50-0x0000000189B40F70 */ get => default; } // 0x0000000184232E50-0x0000000184232EF0 
		public Scrollbar scrollBar { /* [XID] */ /* 0x0000000189B488C0-0x0000000189B488E0 */ get => default; } // 0x0000000184233110-0x00000001842331B0 
		public GameObject selectedImg { /* [XID] */ /* 0x0000000189B4FFF0-0x0000000189B50010 */ get => default; } // 0x00000001842331B0-0x0000000184233250 
	
		// Constructors
		public MonoAwakenAffixSelect() {} // 0x0000000184232D30-0x0000000184232DB0
	}
}
