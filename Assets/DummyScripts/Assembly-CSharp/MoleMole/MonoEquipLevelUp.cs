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
	public class MonoEquipLevelUp : MonoBehaviour // TypeDefIndex: 30755
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _selectedScroller; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _propertyChangeList; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _mainPropChangeScroller; // 0x28
		// [Header] // 0x0000000189658CB0-0x0000000189658CF0
		[SerializeField] // 0x0000000189658CB0-0x0000000189658CF0
		private UnityEngine.UI.Text _curLevelText; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _addLevelText; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _maxLevel; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _expNow; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _expAdd; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoProgressBar _expBar; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _powerUpRoot; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _puNum; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject[] _puLightArray; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _addExpAniTime; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animation _addLevelAni; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _levelUpAnimator; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _maxTip; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _maxTipText; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selectPanel; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0xA8
	
		// Properties
		public MonoGridScroller selectedScroller { /* [XID] */ /* 0x00000001896D4850-0x00000001896D4870 */ get => default; } // 0x0000000183CAB620-0x0000000183CAB6C0 
		public MonoSimpleReusableList propertyChangeList { /* [XID] */ /* 0x00000001896DBEF0-0x00000001896DBF10 */ get => default; } // 0x0000000183CAB390-0x0000000183CAB430 
		public MonoGridScroller mainPropChangeScroller { /* [XID] */ /* 0x00000001896E36A0-0x00000001896E36C0 */ get => default; } // 0x0000000183CAB050-0x0000000183CAB0F0 
		public UnityEngine.UI.Text curLevelText { /* [XID] */ /* 0x00000001896EAAC0-0x00000001896EAAE0 */ get => default; } // 0x0000000183CAAA00-0x0000000183CAAAA0 
		public UnityEngine.UI.Text addLevelText { /* [XID] */ /* 0x00000001896F1E60-0x00000001896F1E80 */ get => default; } // 0x0000000183CAA960-0x0000000183CAAA00 
		public GameObject maxLevel { /* [XID] */ /* 0x00000001896F9830-0x00000001896F9850 */ get => default; } // 0x0000000183CAB0F0-0x0000000183CAB190 
		public UnityEngine.UI.Text expNow { /* [XID] */ /* 0x0000000189701070-0x0000000189701090 */ get => default; } // 0x0000000183CAABE0-0x0000000183CAAC80 
		public UnityEngine.UI.Text expAdd { /* [XID] */ /* 0x0000000189708760-0x0000000189708780 */ get => default; } // 0x0000000183CAAAA0-0x0000000183CAAB40 
		public MonoProgressBar expBar { /* [XID] */ /* 0x00000001897100D0-0x00000001897100F0 */ get => default; } // 0x0000000183CAAB40-0x0000000183CAABE0 
		public GameObject powerUpRoot { /* [XID] */ /* 0x0000000189717470-0x0000000189717490 */ get => default; } // 0x0000000183CAB2F0-0x0000000183CAB390 
		public UnityEngine.UI.Text puNum { /* [XID] */ /* 0x000000018971EEF0-0x000000018971EF10 */ get => default; } // 0x0000000183CAB4D0-0x0000000183CAB570 
		public GameObject[] puLightArray { /* [XID] */ /* 0x00000001897264D0-0x00000001897264F0 */ get => default; } // 0x0000000183CAB430-0x0000000183CAB4D0 
		public float addExpAniTime { /* [XID] */ /* 0x000000018972DA90-0x000000018972DAB0 */ get => default; } // 0x0000000183CAA800-0x0000000183CAA8B0 
		public Animation addLevelAni { /* [XID] */ /* 0x00000001897351F0-0x0000000189735210 */ get => default; } // 0x0000000183CAA8B0-0x0000000183CAA960 
		public Animator levelUpAnimator { /* [XID] */ /* 0x000000018973CC70-0x000000018973CC90 */ get => default; } // 0x0000000183CAAFA0-0x0000000183CAB050 
		public GameObject maxTip { /* [XID] */ /* 0x00000001897441F0-0x0000000189744210 */ get => default; } // 0x0000000183CAB240-0x0000000183CAB2F0 
		public UnityEngine.UI.Text maxTipText { /* [XID] */ /* 0x000000018974BEF0-0x000000018974BF10 */ get => default; } // 0x0000000183CAB190-0x0000000183CAB240 
		public GameObject selectPanel { /* [XID] */ /* 0x00000001897531D0-0x00000001897531F0 */ get => default; } // 0x0000000183CAB570-0x0000000183CAB620 
		public MonoUIContainer fastAddBtn { /* [XID] */ /* 0x000000018975A5A0-0x000000018975A5C0 */ get => default; } // 0x0000000183CAAC80-0x0000000183CAAD90 
		public Dropdown fastAddDropdown { /* [XID] */ /* 0x0000000189762260-0x0000000189762280 */ get => default; } // 0x0000000183CAAE70-0x0000000183CAAFA0 
		public Image fastAddDropdownJoyPadImage { /* [XID] */ /* 0x0000000189769860-0x0000000189769880 */ get => default; } // 0x0000000183CAAD90-0x0000000183CAAE70 
	
		// Constructors
		public MonoEquipLevelUp() {} // 0x0000000183CAA740-0x0000000183CAA800
	}
}
