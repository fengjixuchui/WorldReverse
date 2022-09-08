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
	public class MonoItemDestroyDialog : MonoUIProxy // TypeDefIndex: 30554
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitchQuantity; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoQuantityWidget _quantityWidget; // 0x50
		// [Header] // 0x0000000189A614C0-0x0000000189A61510
		[SerializeField] // 0x0000000189A614C0-0x0000000189A61510
		private GameObject _tipsGrp; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoLocalizedText _tipsTxt; // 0x60
		// [Header] // 0x0000000189A73760-0x0000000189A737A0
		[SerializeField] // 0x0000000189A73760-0x0000000189A737A0
		private GameObject _quantityGrp; // 0x68
		// [Header] // 0x0000000189A7F600-0x0000000189A7F640
		[SerializeField] // 0x0000000189A7F600-0x0000000189A7F640
		private MonoLocalizedText _currentLocalizedText_mobile_pc; // 0x70
		// [Header] // 0x00000001897754C0-0x0000000189775510
		[SerializeField] // 0x00000001897754C0-0x0000000189775510
		private MonoGridScroller _checkScroller; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _checkBGButton; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _checkButtonNonPS4; // 0x88
		public GameObject _checkOffIcon; // 0x90
		public GameObject _checkOnIcon; // 0x98
	
		// Properties
		public Animator anim { /* [XID] */ /* 0x0000000189AA6790-0x0000000189AA67B0 */ get => default; } // 0x00000001843262D0-0x0000000184326370 
		public Button btnBack { /* [XID] */ /* 0x0000000189AADE00-0x0000000189AADE20 */ get => default; } // 0x0000000184326370-0x0000000184326550 
		public Button btnSelect { /* [XID] */ /* 0x0000000189AB5790-0x0000000189AB57B0 */ get => default; } // 0x0000000184326D80-0x0000000184326F60 
		public Button btnDetail { /* [XID] */ /* 0x0000000189ABD170-0x0000000189ABD190 */ get => default; } // 0x00000001843269C0-0x0000000184326BA0 
		public Button btnDestroy { /* [XID] */ /* 0x0000000189AC4C00-0x0000000189AC4C20 */ get => default; } // 0x00000001843267E0-0x00000001843269C0 
		public Button btnCheck { /* [XID] */ /* 0x0000000189ACC280-0x0000000189ACC2A0 */ get => default; } // 0x0000000184326600-0x00000001843267E0 
		public Button btnCheckBGButton { /* [XID] */ /* 0x0000000189AD3D60-0x0000000189AD3D80 */ get => default; } // 0x0000000184326550-0x0000000184326600 
		public MonoQuantityWidget quantityWidget { /* [XID] */ /* 0x0000000189ADB860-0x0000000189ADB880 */ get => default; } // 0x00000001843271F0-0x0000000184327290 
		public Button btnMax { /* [XID] */ /* 0x0000000189AE3160-0x0000000189AE3180 */ get => default; } // 0x0000000184326BA0-0x0000000184326D80 
		public GameObject tipsGrp { /* [XID] */ /* 0x0000000189AEAAF0-0x0000000189AEAB10 */ get => default; } // 0x0000000184327290-0x0000000184327330 
		public GameObject quantityGrp { /* [XID] */ /* 0x0000000189AF23E0-0x0000000189AF2400 */ get => default; } // 0x0000000184327150-0x00000001843271F0 
		public MonoLocalizedText currentLocalizedText_MobilePC { /* [XID] */ /* 0x0000000189AF9D80-0x0000000189AF9DA0 */ get => default; } // 0x00000001843270B0-0x0000000184327150 
		public MonoGridScroller checkScroller { /* [XID] */ /* 0x0000000189B012B0-0x0000000189B012D0 */ get => default; } // 0x0000000184327010-0x00000001843270B0 
		public Button checkButtonNonPS4 { /* [XID] */ /* 0x0000000189B08800-0x0000000189B08820 */ get => default; } // 0x0000000184326F60-0x0000000184327010 
	
		// Constructors
		public MonoItemDestroyDialog() {} // 0x0000000184326230-0x00000001843262D0
	
		// Methods
		// [XID] // 0x0000000189B101A0-0x0000000189B101C0
		public void SetCheckButtonText(string str) {} // 0x0000000184325D60-0x0000000184325F40
		// [XID] // 0x0000000189B172C0-0x0000000189B172E0
		public void SetSelectButtonText(string str) {} // 0x0000000184325F40-0x0000000184326120
		// [XID] // 0x0000000189B1EC60-0x0000000189B1EC80
		public void SetTipsTxt(bool showCanNotBeDestroyed) {} // 0x0000000184326120-0x0000000184326230
	}
}
