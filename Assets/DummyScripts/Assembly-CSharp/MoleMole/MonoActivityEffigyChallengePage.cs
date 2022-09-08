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
	public class MonoActivityEffigyChallengePage : MonoUIProxy // TypeDefIndex: 30984
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _remainTimeText; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _scoreText; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _showPanel; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _tab0; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _titleText; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _highestRecordText; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _descText; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _upCharScroller; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _menuScroller; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _tab1; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _dayText; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _bossText; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _recordText; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _magnificationText; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _difficultyDropDown; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _restrictionsText; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _restrictionsScroller; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _pointText; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _dropDownButton; // 0xD8
	
		// Properties
		public RectTransform showPanel { /* [XID] */ /* 0x0000000189A12980-0x0000000189A129A0 */ get => default; } // 0x0000000186312790-0x0000000186312830 
		public RectTransform tab0 { /* [XID] */ /* 0x0000000189A19BB0-0x0000000189A19BD0 */ get => default; } // 0x0000000186312830-0x00000001863128D0 
		public RectTransform tab1 { /* [XID] */ /* 0x0000000189A211E0-0x0000000189A21200 */ get => default; } // 0x00000001863128D0-0x0000000186312980 
		public Text scoreText { /* [XID] */ /* 0x0000000189A28810-0x0000000189A28830 */ get => default; } // 0x00000001863126F0-0x0000000186312790 
		public Text remainTimeText { /* [XID] */ /* 0x0000000189A2FDF0-0x0000000189A2FE10 */ get => default; } // 0x00000001863122D0-0x0000000186312370 
		public Text titleText { /* [XID] */ /* 0x0000000189A377C0-0x0000000189A377E0 */ get => default; } // 0x0000000186312980-0x0000000186312A20 
		public Text highestRecordText { /* [XID] */ /* 0x0000000189A3EED0-0x0000000189A3EEF0 */ get => default; } // 0x0000000186311E60-0x0000000186311F00 
		public Text descText { /* [XID] */ /* 0x0000000189A46590-0x0000000189A465B0 */ get => default; } // 0x0000000186311B40-0x0000000186311BE0 
		public MonoGridScroller upCharScroller { /* [XID] */ /* 0x0000000189A4DD80-0x0000000189A4DDA0 */ get => default; } // 0x0000000186312A20-0x0000000186312AD0 
		public MonoGridScroller menuScroller { /* [XID] */ /* 0x0000000189A55590-0x0000000189A555B0 */ get => default; } // 0x0000000186311FB0-0x0000000186312060 
		public Text dayText { /* [XID] */ /* 0x0000000189A5CE70-0x0000000189A5CE90 */ get => default; } // 0x0000000186311980-0x0000000186311A30 
		public Text bossText { /* [XID] */ /* 0x0000000189A646F0-0x0000000189A64710 */ get => default; } // 0x00000001863117C0-0x0000000186311870 
		public Text recordText { /* [XID] */ /* 0x0000000189A6BF90-0x0000000189A6BFB0 */ get => default; } // 0x0000000186312220-0x00000001863122D0 
		public Text magnificationText { /* [XID] */ /* 0x0000000189A73660-0x0000000189A73680 */ get => default; } // 0x0000000186311F00-0x0000000186311FB0 
		public MonoDropdownExtention difficultyDropDown { /* [XID] */ /* 0x0000000189A7B220-0x0000000189A7B240 */ get => default; } // 0x0000000186311CF0-0x0000000186311DB0 
		public Text restrictionsText { /* [XID] */ /* 0x0000000189A82920-0x0000000189A82940 */ get => default; } // 0x0000000186312420-0x00000001863124D0 
		public MonoGridScroller restrictionsScroller { /* [XID] */ /* 0x0000000189A8A330-0x0000000189A8A350 */ get => default; } // 0x0000000186312370-0x0000000186312420 
		public Text pointText { /* [XID] */ /* 0x0000000189A91AB0-0x0000000189A91AD0 */ get => default; } // 0x0000000186312170-0x0000000186312220 
		public Button dropDownButton { /* [XID] */ /* 0x0000000189A995A0-0x0000000189A995C0 */ get => default; } // 0x0000000186311DB0-0x0000000186311E60 
		public MonoUIContainer rewardButton { /* [XID] */ /* 0x0000000189AA0690-0x0000000189AA06B0 */ get => default; } // 0x00000001863125E0-0x00000001863126F0 
		public MonoUIContainer descButton { /* [XID] */ /* 0x0000000189AA7C30-0x0000000189AA7C50 */ get => default; } // 0x0000000186311A30-0x0000000186311B40 
		public MonoUIContainer difficultyButton { /* [XID] */ /* 0x0000000189AAF6E0-0x0000000189AAF700 */ get => default; } // 0x0000000186311BE0-0x0000000186311CF0 
		public MonoUIContainer challengeButton { /* [XID] */ /* 0x0000000189AB6F30-0x0000000189AB6F50 */ get => default; } // 0x0000000186311870-0x0000000186311980 
		public MonoUIContainer returnButton { /* [XID] */ /* 0x0000000189ABE980-0x0000000189ABE9A0 */ get => default; } // 0x00000001863124D0-0x00000001863125E0 
		public MonoUIContainer backButton { /* [XID] */ /* 0x0000000189AC64E0-0x0000000189AC6500 */ get => default; } // 0x00000001863115A0-0x00000001863116B0 
		public MonoUIContainer okButton { /* [XID] */ /* 0x0000000189ACDBE0-0x0000000189ACDC00 */ get => default; } // 0x0000000186312060-0x0000000186312170 
		public MonoUIContainer backTab0Button { /* [XID] */ /* 0x0000000189AD59B0-0x0000000189AD59D0 */ get => default; } // 0x00000001863116B0-0x00000001863117C0 
	
		// Constructors
		public MonoActivityEffigyChallengePage() {} // 0x00000001863114C0-0x00000001863115A0
	}
}
