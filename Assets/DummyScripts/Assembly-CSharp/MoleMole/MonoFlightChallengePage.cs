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
	public class MonoFlightChallengePage : MonoUIProxy // TypeDefIndex: 29716
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoActivityFlightChallengeListRow _rewardListRow; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Slider _medalSlider; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _sliderValue1; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _sliderValue2; // 0x5C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _sliderValue3; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoActivityFlightMedalButton _medal1; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoActivityFlightMedalButton _medal2; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoActivityFlightMedalButton _medal3; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _titleText; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _bestScore; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _tipsText; // 0x90
		// [Header] // 0x0000000189898990-0x00000001898989D0
		[SerializeField] // 0x0000000189898990-0x00000001898989D0
		private List<MonoUIContainer> _challengeBtns; // 0x98
	
		// Properties
		public Button backBtn { /* [XID] */ /* 0x00000001898A47E0-0x00000001898A4800 */ get => default; } // 0x0000000184AE0EB0-0x0000000184AE0F70 
		public Button gotoBtn { /* [XID] */ /* 0x00000001898ABC80-0x00000001898ABCA0 */ get => default; } // 0x0000000184AE1490-0x0000000184AE1550 
		public Button btnReturn { /* [XID] */ /* 0x00000001898B33B0-0x00000001898B33D0 */ get => default; } // 0x0000000184AE1320-0x0000000184AE13E0 
		public Button btnDesc { /* [XID] */ /* 0x00000001898BB090-0x00000001898BB0B0 */ get => default; } // 0x0000000184AE10E0-0x0000000184AE11A0 
		public Button btnCheck { /* [XID] */ /* 0x00000001898C2420-0x00000001898C2440 */ get => default; } // 0x0000000184AE1020-0x0000000184AE10E0 
		public Button btnFetch { /* [XID] */ /* 0x00000001898C9E20-0x00000001898C9E40 */ get => default; } // 0x0000000184AE11A0-0x0000000184AE1260 
		public Button btnOK { /* [XID] */ /* 0x00000001898D14C0-0x00000001898D14E0 */ get => default; } // 0x0000000184AE1260-0x0000000184AE1320 
		public UnityEngine.UI.Text titleText { /* [XID] */ /* 0x00000001898D8D40-0x00000001898D8D60 */ get => default; } // 0x0000000184AE1920-0x0000000184AE19D0 
		public UnityEngine.UI.Text bestScore { /* [XID] */ /* 0x00000001898E0A30-0x00000001898E0A50 */ get => default; } // 0x0000000184AE0F70-0x0000000184AE1020 
		public UnityEngine.UI.Text tipsText { /* [XID] */ /* 0x00000001898E8530-0x00000001898E8550 */ get => default; } // 0x0000000184AE1870-0x0000000184AE1920 
		public List<MonoUIContainer> challengeBtns { /* [XID] */ /* 0x00000001898EFD10-0x00000001898EFD30 */ get => default; } // 0x0000000184AE13E0-0x0000000184AE1490 
		public Slider medalSlider { /* [XID] */ /* 0x00000001898F7550-0x00000001898F7570 */ get => default; } // 0x0000000184AE1730-0x0000000184AE17D0 
		public MonoActivityFlightMedalButton medal1 { /* [XID] */ /* 0x00000001898FECA0-0x00000001898FECC0 */ get => default; } // 0x0000000184AE1550-0x0000000184AE15F0 
		public MonoActivityFlightMedalButton medal2 { /* [XID] */ /* 0x0000000189906420-0x0000000189906440 */ get => default; } // 0x0000000184AE15F0-0x0000000184AE1690 
		public MonoActivityFlightMedalButton medal3 { /* [XID] */ /* 0x000000018990DEA0-0x000000018990DEC0 */ get => default; } // 0x0000000184AE1690-0x0000000184AE1730 
		public MonoActivityFlightChallengeListRow rewardListRow { /* [XID] */ /* 0x00000001899155F0-0x0000000189915610 */ get => default; } // 0x0000000184AE17D0-0x0000000184AE1870 
	
		// Constructors
		public MonoFlightChallengePage() {} // 0x0000000184AE0E00-0x0000000184AE0EB0
	
		// Methods
		// [XID] // 0x000000018991D060-0x000000018991D080
		public MonoUIContainer GetChallengeEntry(int index) => default; // 0x0000000184AE0C10-0x0000000184AE0D10
		// [XID] // 0x0000000189924910-0x0000000189924930
		public float GetValue(int index) => default; // 0x0000000184AE0D10-0x0000000184AE0E00
	}
}
