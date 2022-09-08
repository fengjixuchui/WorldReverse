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
	public class MonoTowerPage : MonoUIProxy // TypeDefIndex: 31018
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _scrollAnimSpeed; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _waitAnimTime; // 0x44
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoTowerFloorPanel _floorPanel; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoTowerLevelPanel _levelPanel; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoTowerTeamPanel _teamPanel; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _towerTitleRoot; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _teamTitleRoot; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _subTitleText; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _titleText; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _splashText; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _imgBg2; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoPrefabPlugin _prefabPlugin; // 0x98
		private GameObject _floorFactorSelected; // 0xA0
	
		// Properties
		public float scrollAnimSpeed { /* [XID] */ /* 0x0000000189A32CE0-0x0000000189A32D00 */ get => default; } // 0x0000000184886690-0x0000000184886740 
		public float waitAnimTime { /* [XID] */ /* 0x0000000189A3A570-0x0000000189A3A590 */ get => default; } // 0x0000000184886F60-0x0000000184887010 
		public MonoTowerFloorPanel floorPanel { /* [XID] */ /* 0x0000000189A41E80-0x0000000189A41EA0 */ get => default; } // 0x0000000184885DE0-0x0000000184885E80 
		public MonoTowerLevelPanel levelPanel { /* [XID] */ /* 0x0000000189A49450-0x0000000189A49470 */ get => default; } // 0x0000000184885F90-0x0000000184886030 
		public MonoTowerTeamPanel teamPanel { /* [XID] */ /* 0x0000000189A50DA0-0x0000000189A50DC0 */ get => default; } // 0x0000000184886BC0-0x0000000184886C60 
		public GameObject towerTitleRoot { /* [XID] */ /* 0x0000000189A582C0-0x0000000189A582E0 */ get => default; } // 0x0000000184886EC0-0x0000000184886F60 
		public GameObject teamTitleRoot { /* [XID] */ /* 0x0000000189A5FDA0-0x0000000189A5FDC0 */ get => default; } // 0x0000000184886D70-0x0000000184886E10 
		public UnityEngine.UI.Text subTitleText { /* [XID] */ /* 0x0000000189A67A40-0x0000000189A67A60 */ get => default; } // 0x0000000184886A10-0x0000000184886AB0 
		public UnityEngine.UI.Text splashText { /* [XID] */ /* 0x0000000189A6EE50-0x0000000189A6EE70 */ get => default; } // 0x0000000184886850-0x0000000184886900 
		public UnityEngine.UI.Text titleText { /* [XID] */ /* 0x0000000189A76690-0x0000000189A766B0 */ get => default; } // 0x0000000184886E10-0x0000000184886EC0 
		public MonoUIContainer returnButton { /* [XID] */ /* 0x0000000189A7DFC0-0x0000000189A7DFE0 */ get => default; } // 0x0000000184886360-0x0000000184886470 
		public MonoUIContainer backButton { /* [XID] */ /* 0x0000000189A85940-0x0000000189A85960 */ get => default; } // 0x00000001848859A0-0x0000000184885AB0 
		public MonoUIContainer startButton { /* [XID] */ /* 0x0000000189A8D220-0x0000000189A8D240 */ get => default; } // 0x0000000184886900-0x0000000184886A10 
		public MonoUIContainer levelStartButton { /* [XID] */ /* 0x0000000189A94760-0x0000000189A94780 */ get => default; } // 0x0000000184886140-0x0000000184886250 
		public MonoUIContainer teamStartButton { /* [XID] */ /* 0x0000000189A9C040-0x0000000189A9C060 */ get => default; } // 0x0000000184886C60-0x0000000184886D70 
		public Dropdown avatarSortDropDown { /* [XID] */ /* 0x0000000189AA36F0-0x0000000189AA3710 */ get => default; } // 0x0000000184885760-0x0000000184885890 
		public MonoUIContainer avatarSortButton { /* [XID] */ /* 0x0000000189AAAD90-0x0000000189AAADB0 */ get => default; } // 0x0000000184885650-0x0000000184885760 
		public MonoUIContainer avatarScreenButton { /* [XID] */ /* 0x0000000189AB2740-0x0000000189AB2760 */ get => default; } // 0x0000000184885540-0x0000000184885650 
		public MonoUIContainer rewardButton { /* [XID] */ /* 0x0000000189ABA210-0x0000000189ABA230 */ get => default; } // 0x0000000184886470-0x0000000184886580 
		public MonoUIContainer buffButton { /* [XID] */ /* 0x0000000189AC1B20-0x0000000189AC1B40 */ get => default; } // 0x0000000184885BC0-0x0000000184885CD0 
		public MonoUIContainer ruleButton { /* [XID] */ /* 0x0000000189AC90B0-0x0000000189AC90D0 */ get => default; } // 0x0000000184886580-0x0000000184886690 
		public MonoUIContainer levelPrevButton { /* [XID] */ /* 0x0000000189AD0B00-0x0000000189AD0B20 */ get => default; } // 0x0000000184886030-0x0000000184886140 
		public MonoUIContainer levelNextButton { /* [XID] */ /* 0x0000000189AD8720-0x0000000189AD8740 */ get => default; } // 0x0000000184885E80-0x0000000184885F90 
		public MonoUIContainer bookButton { /* [XID] */ /* 0x0000000189AE0380-0x0000000189AE03A0 */ get => default; } // 0x0000000184885AB0-0x0000000184885BC0 
		public MonoUIContainer awardButtonPS4 { /* [XID] */ /* 0x0000000189AE7930-0x0000000189AE7950 */ get => default; } // 0x0000000184885890-0x00000001848859A0 
		public MonoUIContainer switchTeamButtonPS4 { /* [XID] */ /* 0x0000000189AEF630-0x0000000189AEF650 */ get => default; } // 0x0000000184886AB0-0x0000000184886BC0 
		public MonoUIContainer selectButtonPS4 { /* [XID] */ /* 0x0000000189AF6B50-0x0000000189AF6B70 */ get => default; } // 0x0000000184886740-0x0000000184886850 
		public MonoUIContainer floorBackButton { /* [XID] */ /* 0x0000000189AFE080-0x0000000189AFE0A0 */ get => default; } // 0x0000000184885CD0-0x0000000184885DE0 
		public MonoUIContainer resonanceButton { /* [XID] */ /* 0x0000000189B058B0-0x0000000189B058D0 */ get => default; } // 0x0000000184886250-0x0000000184886360 
		public bool showBookButton { /* [XID] */ /* 0x0000000189B0D080-0x0000000189B0D0A0 */ set {} } // 0x0000000184887010-0x00000001848870E0
		public bool showImgBg2 { /* [XID] */ /* 0x0000000189B14650-0x0000000189B14670 */ set {} } // 0x0000000184887320-0x0000000184887400
		public bool showCheckButton { /* [XID] */ /* 0x0000000189B1BE70-0x0000000189B1BE90 */ set {} } // 0x00000001848870E0-0x00000001848871B0
		public bool showFloorFactorSelected { /* [XID] */ /* 0x0000000189B235F0-0x0000000189B23610 */ set {} } // 0x00000001848871B0-0x0000000184887320
	
		// Constructors
		public MonoTowerPage() {} // 0x0000000184885440-0x0000000184885540
	}
}
