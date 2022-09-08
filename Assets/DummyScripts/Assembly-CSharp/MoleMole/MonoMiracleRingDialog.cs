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
	public class MonoMiracleRingDialog : MonoUIProxy // TypeDefIndex: 30559
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
		private UnityEngine.UI.Text _tipsText; // 0x60
		// [Header] // 0x0000000189758E30-0x0000000189758E80
		[SerializeField] // 0x0000000189758E30-0x0000000189758E80
		private GameObject _quantityGrp; // 0x68
		// [Header] // 0x00000001897637C0-0x0000000189763810
		[SerializeField] // 0x00000001897637C0-0x0000000189763810
		private MonoLocalizedText _currentLocalizedText_mobile_pc; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoLocalizedText _progressText2; // 0x78
		// [Header] // 0x00000001897754C0-0x0000000189775510
		[SerializeField] // 0x00000001897754C0-0x0000000189775510
		private MonoGridScroller _checkScroller; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _checkBGButton; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _checkButtonNonPS4; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _progressMask; // 0x98
		public GameObject _checkOffIcon; // 0xA0
		public GameObject _checkOnIcon; // 0xA8
	
		// Properties
		public Animator anim { /* [XID] */ /* 0x0000000189796380-0x00000001897963A0 */ get => default; } // 0x0000000182F11CC0-0x0000000182F11D60 
		public UnityEngine.UI.Text tipsText { /* [XID] */ /* 0x000000018979E450-0x000000018979E470 */ get => default; } // 0x0000000182F12E80-0x0000000182F12F20 
		public SmoothMask progressMask { /* [XID] */ /* 0x00000001897A5BD0-0x00000001897A5BF0 */ get => default; } // 0x0000000182F12B50-0x0000000182F12C00 
		public Button btnBack { /* [XID] */ /* 0x00000001897AD140-0x00000001897AD160 */ get => default; } // 0x0000000182F11D60-0x0000000182F11F40 
		public Button btnSelect { /* [XID] */ /* 0x00000001897B5170-0x00000001897B5190 */ get => default; } // 0x0000000182F12590-0x0000000182F12770 
		public Button btnDetail { /* [XID] */ /* 0x00000001897BCDE0-0x00000001897BCE00 */ get => default; } // 0x0000000182F121D0-0x0000000182F123B0 
		public Button btnStart { /* [XID] */ /* 0x00000001897C4160-0x00000001897C4180 */ get => default; } // 0x0000000182F12770-0x0000000182F12950 
		public Button btnCheck { /* [XID] */ /* 0x00000001897CB9E0-0x00000001897CBA00 */ get => default; } // 0x0000000182F11FF0-0x0000000182F121D0 
		public Button btnCheckBGButton { /* [XID] */ /* 0x00000001897D32F0-0x00000001897D3310 */ get => default; } // 0x0000000182F11F40-0x0000000182F11FF0 
		public MonoQuantityWidget quantityWidget { /* [XID] */ /* 0x00000001897DAD70-0x00000001897DAD90 */ get => default; } // 0x0000000182F12D40-0x0000000182F12DE0 
		public Button btnMax { /* [XID] */ /* 0x00000001897E2480-0x00000001897E24A0 */ get => default; } // 0x0000000182F123B0-0x0000000182F12590 
		public GameObject tipsGrp { /* [XID] */ /* 0x00000001897E9BF0-0x00000001897E9C10 */ get => default; } // 0x0000000182F12DE0-0x0000000182F12E80 
		public GameObject quantityGrp { /* [XID] */ /* 0x00000001897F18B0-0x00000001897F18D0 */ get => default; } // 0x0000000182F12CA0-0x0000000182F12D40 
		public MonoLocalizedText currentLocalizedText_MobilePC { /* [XID] */ /* 0x00000001897F8FE0-0x00000001897F9000 */ get => default; } // 0x0000000182F12AB0-0x0000000182F12B50 
		public MonoLocalizedText progressText2 { /* [XID] */ /* 0x00000001898005F0-0x0000000189800610 */ get => default; } // 0x0000000182F12C00-0x0000000182F12CA0 
		public MonoGridScroller checkScroller { /* [XID] */ /* 0x0000000189807C70-0x0000000189807C90 */ get => default; } // 0x0000000182F12A00-0x0000000182F12AB0 
		public Button checkButtonNonPS4 { /* [XID] */ /* 0x000000018980F570-0x000000018980F590 */ get => default; } // 0x0000000182F12950-0x0000000182F12A00 
	
		// Constructors
		public MonoMiracleRingDialog() {} // 0x0000000182F11C10-0x0000000182F11CC0
	
		// Methods
		// [XID] // 0x0000000189816BE0-0x0000000189816C00
		public void SetCheckButtonText(string str) {} // 0x0000000182F11850-0x0000000182F11A30
		// [XID] // 0x000000018981E490-0x000000018981E4B0
		public void SetSelectButtonText(string str) {} // 0x0000000182F11A30-0x0000000182F11C10
	}
}
