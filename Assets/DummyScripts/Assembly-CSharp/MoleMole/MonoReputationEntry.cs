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
	public class MonoReputationEntry : MonoBehaviour // TypeDefIndex: 31020
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockedObj; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _lockedText; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selectedGrp; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<GameObject> _subIcons; // 0x40
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private GameObject _topGrp; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _detailText; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _tevyatText; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _detailNum; // 0x60
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private GameObject _bottomGrp; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _tevyatTextBottom; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _detailNumBottom; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Slider _sliderBottom; // 0x80
	
		// Properties
		public string title { /* [XID] */ /* 0x0000000189BCCFA0-0x0000000189BCCFC0 */ set {} } // 0x0000000184436D20-0x0000000184436DF0
		public Image icon { /* [XID] */ /* 0x0000000189BD4560-0x0000000189BD4580 */ get => default; } // 0x0000000184436380-0x0000000184436420 
		public string detailText { /* [XID] */ /* 0x0000000189BDC090-0x0000000189BDC0B0 */ set {} } // 0x00000001844365E0-0x00000001844366B0
		public string detailNum { /* [XID] */ /* 0x00000001895E8870-0x00000001895E8890 */ set {} } // 0x00000001844364F0-0x00000001844365E0
		public string tevyatText { /* [XID] */ /* 0x00000001895F0100-0x00000001895F0120 */ set {} } // 0x0000000184436C30-0x0000000184436D20
		public float bottomSliderValue { /* [XID] */ /* 0x00000001895F7BB0-0x00000001895F7BD0 */ set {} } // 0x0000000184436420-0x00000001844364F0
		public bool isOpen { /* [XID] */ /* 0x00000001895FEEF0-0x00000001895FEF10 */ set {} } // 0x00000001844366B0-0x0000000184436800
		public bool showTopGrp { /* [XID] */ /* 0x0000000189606750-0x0000000189606770 */ set {} } // 0x00000001844369D0-0x0000000184436AE0
		public string lockedText { /* [XID] */ /* 0x000000018960E0D0-0x000000018960E0F0 */ set {} } // 0x0000000184436800-0x00000001844368E0
		public bool selected { /* [XID] */ /* 0x0000000189615740-0x0000000189615760 */ set {} } // 0x00000001844368E0-0x00000001844369D0
		public int subIconIndex { /* [XID] */ /* 0x000000018961CF20-0x000000018961CF40 */ set {} } // 0x0000000184436AE0-0x0000000184436C30
	
		// Constructors
		public MonoReputationEntry() {} // 0x0000000184436300-0x0000000184436380
	}
}
