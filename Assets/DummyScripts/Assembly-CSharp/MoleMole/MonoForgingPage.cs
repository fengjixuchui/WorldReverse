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
	public class MonoForgingPage : MonoUIProxy // TypeDefIndex: 31001
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _itemScroller; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _queueScroller; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _itemListRoot; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _queueListRoot; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _timeText; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _targetItem; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _foodItemList; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _avatarIcon; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _avatarUpImg; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _avatarCanUpImg; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _avatarNormalShow; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _avatarCanUpShow; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _numPlusBtn; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _numMinusBtn; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _minNumText; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _maxNumText; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _curNumText; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _numSlider; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockTipRoot; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _lockTipText; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _lockIcon; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoShopMaterial _curCoinLabel; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoCookAvatarSelect _avatarSelectPanel; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoCookGotPanel _forgeGotPanel; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _formulaBtn; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _queueBtn; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _numSelectRoot; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _progressRoot; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _detailRoot; // 0x120
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _noItemRoot; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _progressText; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _progressFill; // 0x138
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _screeningPanelRoot; // 0x140
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _screeningPanel; // 0x148
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _screeningScroller; // 0x150
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _screenText; // 0x158
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _screenBackBtn; // 0x160
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _screenResetBtn; // 0x168
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _joystickBtnLeftFormula; // 0x170
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _joystickBtnRightMaterial; // 0x178
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _joystickBtnShowDetail; // 0x180
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x188
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _joystickAvatarSelectBtn; // 0x190
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpJoypadButtons; // 0x198
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpNormal; // 0x1A0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpOkNo; // 0x1A8
	
		// Properties
		public MonoGridScroller itemScroller { /* [XID] */ /* 0x000000018965D5C0-0x000000018965D5E0 */ get => default; } // 0x0000000184AE5F90-0x0000000184AE6030 
		public MonoGridScroller queueScroller { /* [XID] */ /* 0x0000000189664CE0-0x0000000189664D00 */ get => default; } // 0x0000000184AE6D30-0x0000000184AE6DD0 
		public GameObject itemListRoot { /* [XID] */ /* 0x000000018966C2E0-0x000000018966C300 */ get => default; } // 0x0000000184AE5EF0-0x0000000184AE5F90 
		public GameObject queueListRoot { /* [XID] */ /* 0x0000000189674160-0x0000000189674180 */ get => default; } // 0x0000000184AE6C90-0x0000000184AE6D30 
		public UnityEngine.UI.Text timeText { /* [XID] */ /* 0x000000018967B9A0-0x000000018967B9C0 */ get => default; } // 0x0000000184AE76F0-0x0000000184AE7790 
		public MonoSimpleReusableList targetItem { /* [XID] */ /* 0x00000001896830B0-0x00000001896830D0 */ get => default; } // 0x0000000184AE7650-0x0000000184AE76F0 
		public MonoSimpleReusableList foodItemList { /* [XID] */ /* 0x000000018968AB20-0x000000018968AB40 */ get => default; } // 0x0000000184AE59C0-0x0000000184AE5A60 
		public MonoSimpleReusableList avatarIcon { /* [XID] */ /* 0x0000000189692880-0x00000001896928A0 */ get => default; } // 0x0000000184AE5050-0x0000000184AE50F0 
		public GameObject avatarUpImg { /* [XID] */ /* 0x0000000189699C00-0x0000000189699C20 */ get => default; } // 0x0000000184AE5420-0x0000000184AE54D0 
		public GameObject avatarCanUpImg { /* [XID] */ /* 0x00000001896A1320-0x00000001896A1340 */ get => default; } // 0x0000000184AE4EF0-0x0000000184AE4FA0 
		public GameObject avatarNormalShow { /* [XID] */ /* 0x00000001896A8790-0x00000001896A87B0 */ get => default; } // 0x0000000184AE50F0-0x0000000184AE51A0 
		public GameObject avatarCanUpShow { /* [XID] */ /* 0x00000001896AF920-0x00000001896AF940 */ get => default; } // 0x0000000184AE4FA0-0x0000000184AE5050 
		public MonoUIContainer numPlusBtn { /* [XID] */ /* 0x00000001896B7290-0x00000001896B72B0 */ get => default; } // 0x0000000184AE67C0-0x0000000184AE6870 
		public MonoUIContainer numMinusBtn { /* [XID] */ /* 0x00000001896BE3E0-0x00000001896BE400 */ get => default; } // 0x0000000184AE6710-0x0000000184AE67C0 
		public UnityEngine.UI.Text minNumText { /* [XID] */ /* 0x00000001896C5C50-0x00000001896C5C70 */ get => default; } // 0x0000000184AE65B0-0x0000000184AE6660 
		public UnityEngine.UI.Text maxNumText { /* [XID] */ /* 0x00000001896CD3C0-0x00000001896CD3E0 */ get => default; } // 0x0000000184AE6500-0x0000000184AE65B0 
		public UnityEngine.UI.Text curNumText { /* [XID] */ /* 0x00000001896D47F0-0x00000001896D4810 */ get => default; } // 0x0000000184AE5750-0x0000000184AE5800 
		public MonoUIContainer numSlider { /* [XID] */ /* 0x00000001896DBE90-0x00000001896DBEB0 */ get => default; } // 0x0000000184AE6920-0x0000000184AE69D0 
		public GameObject lockTipRoot { /* [XID] */ /* 0x00000001896E3660-0x00000001896E3680 */ get => default; } // 0x0000000184AE63A0-0x0000000184AE6450 
		public UnityEngine.UI.Text lockTipText { /* [XID] */ /* 0x00000001896EAA80-0x00000001896EAAA0 */ get => default; } // 0x0000000184AE6450-0x0000000184AE6500 
		public Image lockIcon { /* [XID] */ /* 0x00000001896F1D80-0x00000001896F1DA0 */ get => default; } // 0x0000000184AE62F0-0x0000000184AE63A0 
		public MonoNeedLabel coinLabel { /* [XID] */ /* 0x00000001896F97D0-0x00000001896F97F0 */ get => default; } // 0x0000000184AE5590-0x0000000184AE56A0 
		public MonoShopMaterial curCoinLabel { /* [XID] */ /* 0x0000000189700FE0-0x0000000189701000 */ get => default; } // 0x0000000184AE56A0-0x0000000184AE5750 
		public MonoCookAvatarSelect avatarSelectPanel { /* [XID] */ /* 0x0000000189708720-0x0000000189708740 */ get => default; } // 0x0000000184AE5370-0x0000000184AE5420 
		public MonoCookGotPanel forgeGotPanel { /* [XID] */ /* 0x0000000189710090-0x00000001897100B0 */ get => default; } // 0x0000000184AE5A60-0x0000000184AE5B10 
		public MonoUIContainer formulaBtn { /* [XID] */ /* 0x0000000189717410-0x0000000189717430 */ get => default; } // 0x0000000184AE5C20-0x0000000184AE5CD0 
		public MonoUIContainer queueBtn { /* [XID] */ /* 0x000000018971EE90-0x000000018971EEB0 */ get => default; } // 0x0000000184AE6BE0-0x0000000184AE6C90 
		public GameObject numSelectRoot { /* [XID] */ /* 0x0000000189726430-0x0000000189726450 */ get => default; } // 0x0000000184AE6870-0x0000000184AE6920 
		public GameObject progressRoot { /* [XID] */ /* 0x000000018972DA30-0x000000018972DA50 */ get => default; } // 0x0000000184AE6A80-0x0000000184AE6B30 
		public GameObject detailRoot { /* [XID] */ /* 0x00000001897351B0-0x00000001897351D0 */ get => default; } // 0x0000000184AE5800-0x0000000184AE58B0 
		public GameObject noItemRoot { /* [XID] */ /* 0x000000018973CC30-0x000000018973CC50 */ get => default; } // 0x0000000184AE6660-0x0000000184AE6710 
		public UnityEngine.UI.Text progressText { /* [XID] */ /* 0x00000001897441B0-0x00000001897441D0 */ get => default; } // 0x0000000184AE6B30-0x0000000184AE6BE0 
		public SmoothMask progressFill { /* [XID] */ /* 0x000000018974BE90-0x000000018974BEB0 */ get => default; } // 0x0000000184AE69D0-0x0000000184AE6A80 
		public MonoUIContainer forgingBtn { /* [XID] */ /* 0x0000000189753170-0x0000000189753190 */ get => default; } // 0x0000000184AE5B10-0x0000000184AE5C20 
		public MonoUIContainer returnBtn { /* [XID] */ /* 0x000000018975A4E0-0x000000018975A500 */ get => default; } // 0x0000000184AE6DD0-0x0000000184AE6EE0 
		public Button sortBtn { /* [XID] */ /* 0x00000001897621E0-0x0000000189762200 */ get => default; } // 0x0000000184AE7410-0x0000000184AE7540 
		public MonoUIContainer fetchBtn { /* [XID] */ /* 0x0000000189769750-0x0000000189769770 */ get => default; } // 0x0000000184AE58B0-0x0000000184AE59C0 
		public MonoUIContainer stopBtn { /* [XID] */ /* 0x0000000189770D50-0x0000000189770D70 */ get => default; } // 0x0000000184AE7540-0x0000000184AE7650 
		public MonoUIContainer changeAvatorBtn { /* [XID] */ /* 0x00000001897786E0-0x0000000189778700 */ get => default; } // 0x0000000184AE54D0-0x0000000184AE5590 
		public GameObject screeningPanelRoot { /* [XID] */ /* 0x000000018977FC40-0x000000018977FC60 */ get => default; } // 0x0000000184AE7200-0x0000000184AE72B0 
		public GameObject screeningPanel { /* [XID] */ /* 0x0000000189787520-0x0000000189787540 */ get => default; } // 0x0000000184AE72B0-0x0000000184AE7360 
		public MonoGridScroller screeningScroller { /* [XID] */ /* 0x000000018978EAF0-0x000000018978EB10 */ get => default; } // 0x0000000184AE7360-0x0000000184AE7410 
		public MonoUIContainer screenDrop { /* [XID] */ /* 0x0000000189796270-0x0000000189796290 */ get => default; } // 0x0000000184AE6F90-0x0000000184AE70A0 
		public UnityEngine.UI.Text screenText { /* [XID] */ /* 0x000000018979E3B0-0x000000018979E3D0 */ get => default; } // 0x0000000184AE7150-0x0000000184AE7200 
		public Button screenBackBtn { /* [XID] */ /* 0x00000001897A5B30-0x00000001897A5B50 */ get => default; } // 0x0000000184AE6EE0-0x0000000184AE6F90 
		public MonoUIContainer screenResetBtn { /* [XID] */ /* 0x00000001897AD0A0-0x00000001897AD0C0 */ get => default; } // 0x0000000184AE70A0-0x0000000184AE7150 
		public MonoUIContainer joystickBtnLeftFormula { /* [XID] */ /* 0x00000001897B50D0-0x00000001897B50F0 */ get => default; } // 0x0000000184AE60E0-0x0000000184AE6190 
		public MonoUIContainer joystickBtnRightMaterial { /* [XID] */ /* 0x00000001897BCD00-0x00000001897BCD20 */ get => default; } // 0x0000000184AE6190-0x0000000184AE6240 
		public MonoUIContainer joystickBtnShowDetail { /* [XID] */ /* 0x00000001897C4080-0x00000001897C40A0 */ get => default; } // 0x0000000184AE6240-0x0000000184AE62F0 
		public MonoUIContainer joystickAvatarSelectBtn { /* [XID] */ /* 0x00000001897CB940-0x00000001897CB960 */ get => default; } // 0x0000000184AE6030-0x0000000184AE60E0 
		public MonoUIContainer avatarSelectExitBtn { /* [XID] */ /* 0x00000001897D3230-0x00000001897D3250 */ get => default; } // 0x0000000184AE5260-0x0000000184AE5370 
		public Transform grpSort { /* [XID] */ /* 0x00000001897DACB0-0x00000001897DACD0 */ get => default; } // 0x0000000184AE5E30-0x0000000184AE5EF0 
		public MonoUIContainer avatarReplaceBtn { /* [XID] */ /* 0x00000001897E23A0-0x00000001897E23C0 */ get => default; } // 0x0000000184AE51A0-0x0000000184AE5260 
		public GameObject grpOkNo { /* [XID] */ /* 0x00000001897E9B10-0x00000001897E9B30 */ get => default; } // 0x0000000184AE5D80-0x0000000184AE5E30 
		public GameObject grpNormal { /* [XID] */ /* 0x00000001897F17D0-0x00000001897F17F0 */ get => default; } // 0x0000000184AE5CD0-0x0000000184AE5D80 
		public bool showScreenBtnDetailIcon { /* [XID] */ /* 0x00000001897F8EA0-0x00000001897F8EC0 */ set {} } // 0x0000000184AE79A0-0x0000000184AE7B40
		public GameObject avatarCanUpImgRipple { /* [XID] */ /* 0x00000001898004D0-0x00000001898004F0 */ get => default; } // 0x0000000184AE4D70-0x0000000184AE4EF0 
		public bool showJoypadButtons { /* [XID] */ /* 0x0000000189807B50-0x0000000189807B70 */ set {} } // 0x0000000184AE78A0-0x0000000184AE79A0
		public bool showAvatarJoypadButtons { /* [XID] */ /* 0x000000018980F450-0x000000018980F470 */ set {} } // 0x0000000184AE7790-0x0000000184AE78A0
	
		// Constructors
		public MonoForgingPage() {} // 0x0000000184AE4BE0-0x0000000184AE4D70
	}
}
