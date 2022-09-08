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
	public class MonoActivityCharacterTrial : MonoUIProxy // TypeDefIndex: 31152
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _timeDesc; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _subTitle; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _charName; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rewardTips; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _character; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _element; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _bg; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _complete; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _progress; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoStarRate _starRate; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _tabList; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _rewardList; // 0xA8
	
		// Properties
		public string title { /* [XID] */ /* 0x0000000189A06B10-0x0000000189A06B30 */ set {} } // 0x000000018630ADF0-0x000000018630AEC0
		public string timeDesc { /* [XID] */ /* 0x0000000189A0E240-0x0000000189A0E260 */ set {} } // 0x000000018630AD20-0x000000018630ADF0
		public string subTitle { /* [XID] */ /* 0x0000000189A157C0-0x0000000189A157E0 */ set {} } // 0x000000018630AC50-0x000000018630AD20
		public string charName { /* [XID] */ /* 0x0000000189A1CCA0-0x0000000189A1CCC0 */ set {} } // 0x000000018630AAB0-0x000000018630AB80
		public string rewardTips { /* [XID] */ /* 0x0000000189A24200-0x0000000189A24220 */ set {} } // 0x000000018630AB80-0x000000018630AC50
		public Image character { /* [XID] */ /* 0x0000000189A2B670-0x0000000189A2B690 */ get => default; } // 0x000000018630A600-0x000000018630A6A0 
		public Image element { /* [XID] */ /* 0x0000000189A32CC0-0x0000000189A32CE0 */ get => default; } // 0x000000018630A750-0x000000018630A7F0 
		public Image bg { /* [XID] */ /* 0x0000000189A3A550-0x0000000189A3A570 */ get => default; } // 0x000000018630A550-0x000000018630A600 
		public MonoStarRate starRate { /* [XID] */ /* 0x0000000189A41E40-0x0000000189A41E60 */ get => default; } // 0x000000018630A950-0x000000018630AA00 
		public MonoSimpleReusableList tabList { /* [XID] */ /* 0x0000000189A49410-0x0000000189A49430 */ get => default; } // 0x000000018630AA00-0x000000018630AAB0 
		public MonoSimpleReusableList rewardList { /* [XID] */ /* 0x0000000189A50D60-0x0000000189A50D80 */ get => default; } // 0x000000018630A8A0-0x000000018630A950 
		public MonoUIContainer BtnTrial { /* [XID] */ /* 0x0000000189A58280-0x0000000189A582A0 */ get => default; } // 0x000000018630A250-0x000000018630A310 
		public MonoUIContainer BtnLookOver { /* [XID] */ /* 0x0000000189A5FD60-0x0000000189A5FD80 */ get => default; } // 0x000000018630A0D0-0x000000018630A190 
		public MonoUIContainer BtnExit { /* [XID] */ /* 0x0000000189A67A00-0x0000000189A67A20 */ get => default; } // 0x000000018630A010-0x000000018630A0D0 
		public MonoUIContainer BtnBack { /* [XID] */ /* 0x0000000189A6EE10-0x0000000189A6EE30 */ get => default; } // 0x0000000186309DD0-0x0000000186309E90 
		public MonoUIContainer BtnDetails { /* [XID] */ /* 0x0000000189A76610-0x0000000189A76630 */ get => default; } // 0x0000000186309F50-0x000000018630A010 
		public MonoUIContainer FetchHint { /* [XID] */ /* 0x0000000189A7DF80-0x0000000189A7DFA0 */ get => default; } // 0x000000018630A310-0x000000018630A3D0 
		public MonoUIContainer BtnOK { /* [XID] */ /* 0x0000000189A85900-0x0000000189A85920 */ get => default; } // 0x000000018630A190-0x000000018630A250 
		public MonoUIContainer PreTab { /* [XID] */ /* 0x0000000189A8D1E0-0x0000000189A8D200 */ get => default; } // 0x000000018630A490-0x000000018630A550 
		public MonoUIContainer NextTab { /* [XID] */ /* 0x0000000189A94720-0x0000000189A94740 */ get => default; } // 0x000000018630A3D0-0x000000018630A490 
		public MonoUIContainer BtnDes { /* [XID] */ /* 0x0000000189A9C000-0x0000000189A9C020 */ get => default; } // 0x0000000186309E90-0x0000000186309F50 
		public GameObject complete { /* [XID] */ /* 0x0000000189AA36B0-0x0000000189AA36D0 */ get => default; } // 0x000000018630A6A0-0x000000018630A750 
		public GameObject progress { /* [XID] */ /* 0x0000000189AAAD50-0x0000000189AAAD70 */ get => default; } // 0x000000018630A7F0-0x000000018630A8A0 
	
		// Constructors
		public MonoActivityCharacterTrial() {} // 0x0000000186309D20-0x0000000186309DD0
	
		// Methods
		// [XID] // 0x0000000189AB2700-0x0000000189AB2720
		public void RefreshAnimator() {} // 0x00000001863098E0-0x0000000186309A00
		// [XID] // 0x0000000189ABA1D0-0x0000000189ABA1F0
		public void SetCharacterImage(uint id) {} // 0x0000000186309A00-0x0000000186309D20
	}
}
