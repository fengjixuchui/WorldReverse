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
	public class MonoSynthesisPage : MonoUIProxy // TypeDefIndex: 31017
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _itemScroller; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtPageTitle; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _targetItemName; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _targetItem; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _foodItem1; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _foodItem2; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _foodItem3; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _avatarIcon; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _avatarUpImg; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _avatarCanUpImg; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _iconUp; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _numPlusBtn; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _numMinusBtn; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _minNumText; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _maxNumText; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _curNumText; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _numSlider; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockTipRoot; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _lockTipText; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _lockIcon; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoShopMaterial _curCoinLabel; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoCookAvatarSelect _avatarSelectPanel; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoCookGotPanel _combineGotPanel; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _screeningPanel; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _screeningTitle; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _screeningScroller; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _screenText; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _screenBackBtn; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _changeAvatorBtn; // 0x120
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _animTime; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _btnDisableTime; // 0x134
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject[] _joypadSelectLeftShowObjs; // 0x138
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject[] _joypadSelectRightShowObjs; // 0x140
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpNormal; // 0x148
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpOkNo; // 0x150
		// [Header] // 0x00000001897AB3F0-0x00000001897AB430
		[SerializeField] // 0x00000001897AB3F0-0x00000001897AB430
		private GameObject _grpNeedSynthesis; // 0x158
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpNeedMelting; // 0x160
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtConvert; // 0x168
		// [Header] // 0x00000001897C7620-0x00000001897C7660
		[SerializeField] // 0x00000001897C7620-0x00000001897C7660
		private MonoSimpleReusableList _convertItem1; // 0x170
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _convertItem2; // 0x178
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _convertItem3; // 0x180
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _replaceBtnContainer; // 0x188
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _selectedMeltingBtn; // 0x190
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpTabKey; // 0x198
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpJoypadButtons; // 0x1A0
		private uint _showingTabIndex; // 0x1A8
	
		// Properties
		public Button selectedMeltingBtn { /* [XID] */ /* 0x0000000189800490-0x00000001898004B0 */ get => default; } // 0x000000018500E7A0-0x000000018500E850 
		public UnityEngine.UI.Text txtPageTitle { /* [XID] */ /* 0x0000000189807B10-0x0000000189807B30 */ get => default; } // 0x000000018500F450-0x000000018500F4F0 
		public bool showGrpTabKey { /* [XID] */ /* 0x000000018980F410-0x000000018980F430 */ set {} } // 0x000000018500F600-0x000000018500F6F0
		public MonoUIContainer replaceBtnContainer { /* [XID] */ /* 0x0000000189816AA0-0x0000000189816AC0 */ get => default; } // 0x000000018500E160-0x000000018500E210 
		public MonoSimpleReusableList convertItem1 { /* [XID] */ /* 0x000000018981E320-0x000000018981E340 */ get => default; } // 0x000000018500D170-0x000000018500D220 
		public MonoSimpleReusableList convertItem2 { /* [XID] */ /* 0x0000000189825800-0x0000000189825820 */ get => default; } // 0x000000018500D220-0x000000018500D2D0 
		public MonoSimpleReusableList convertItem3 { /* [XID] */ /* 0x000000018982CFC0-0x000000018982CFE0 */ get => default; } // 0x000000018500D2D0-0x000000018500D380 
		public UnityEngine.UI.Text txtConvert { /* [XID] */ /* 0x00000001898347A0-0x00000001898347C0 */ get => default; } // 0x000000018500F3A0-0x000000018500F450 
		public uint showingTabIndex { /* [XID] */ /* 0x000000018983BDF0-0x000000018983BE10 */ get => default; /* [XID] */ /* 0x0000000189843440-0x0000000189843460 */ set {} } // 0x000000018500E980-0x000000018500EA20 0x000000018500FA90-0x000000018500FC10
		public MonoGridScroller itemScroller { /* [XID] */ /* 0x000000018984A960-0x000000018984A980 */ get => default; } // 0x000000018500D8D0-0x000000018500D970 
		public UnityEngine.UI.Text targetItemName { /* [XID] */ /* 0x0000000189851D60-0x0000000189851D80 */ get => default; } // 0x000000018500F260-0x000000018500F300 
		public MonoSimpleReusableList targetItem { /* [XID] */ /* 0x00000001898595E0-0x0000000189859600 */ get => default; } // 0x000000018500F300-0x000000018500F3A0 
		public MonoSimpleReusableList foodItem1 { /* [XID] */ /* 0x0000000189860720-0x0000000189860740 */ get => default; } // 0x000000018500D4E0-0x000000018500D580 
		public MonoSimpleReusableList foodItem2 { /* [XID] */ /* 0x0000000189867E30-0x0000000189867E50 */ get => default; } // 0x000000018500D580-0x000000018500D620 
		public MonoSimpleReusableList foodItem3 { /* [XID] */ /* 0x000000018986F390-0x000000018986F3B0 */ get => default; } // 0x000000018500D620-0x000000018500D6C0 
		public MonoSimpleReusableList avatarIcon { /* [XID] */ /* 0x00000001898769C0-0x00000001898769E0 */ get => default; } // 0x000000018500C990-0x000000018500CA30 
		public GameObject avatarUpImg { /* [XID] */ /* 0x000000018987E4E0-0x000000018987E500 */ get => default; } // 0x000000018500CDA0-0x000000018500CE50 
		public GameObject avatarCanUpImg { /* [XID] */ /* 0x0000000189885890-0x00000001898858B0 */ get => default; } // 0x000000018500C8E0-0x000000018500C990 
		public GameObject iconCanUp { /* [XID] */ /* 0x000000018988CB80-0x000000018988CBA0 */ get => default; } // 0x000000018500D820-0x000000018500D8D0 
		public MonoUIContainer numPlusBtn { /* [XID] */ /* 0x0000000189894250-0x0000000189894270 */ get => default; } // 0x000000018500E000-0x000000018500E0B0 
		public MonoUIContainer numMinusBtn { /* [XID] */ /* 0x000000018989B7C0-0x000000018989B7E0 */ get => default; } // 0x000000018500DF50-0x000000018500E000 
		public UnityEngine.UI.Text minNumText { /* [XID] */ /* 0x00000001898A2CF0-0x00000001898A2D10 */ get => default; } // 0x000000018500DEA0-0x000000018500DF50 
		public UnityEngine.UI.Text maxNumText { /* [XID] */ /* 0x00000001898AA210-0x00000001898AA230 */ get => default; } // 0x000000018500DCE0-0x000000018500DD90 
		public UnityEngine.UI.Text curNumText { /* [XID] */ /* 0x00000001898B1C10-0x00000001898B1C30 */ get => default; } // 0x000000018500D430-0x000000018500D4E0 
		public MonoUIContainer numSlider { /* [XID] */ /* 0x00000001898B9830-0x00000001898B9850 */ get => default; } // 0x000000018500E0B0-0x000000018500E160 
		public GameObject lockTipRoot { /* [XID] */ /* 0x00000001898C0C50-0x00000001898C0C70 */ get => default; } // 0x000000018500DB80-0x000000018500DC30 
		public UnityEngine.UI.Text lockTipText { /* [XID] */ /* 0x00000001898C84B0-0x00000001898C84D0 */ get => default; } // 0x000000018500DC30-0x000000018500DCE0 
		public Image lockIcon { /* [XID] */ /* 0x00000001898CFF00-0x00000001898CFF20 */ get => default; } // 0x000000018500DAD0-0x000000018500DB80 
		public MonoNeedLabel coinLabel { /* [XID] */ /* 0x00000001898D74D0-0x00000001898D74F0 */ get => default; } // 0x000000018500CFB0-0x000000018500D0C0 
		public MonoShopMaterial curCoinLabel { /* [XID] */ /* 0x00000001898DF220-0x00000001898DF240 */ get => default; } // 0x000000018500D380-0x000000018500D430 
		public MonoCookAvatarSelect avatarSelectPanel { /* [XID] */ /* 0x00000001898E6C00-0x00000001898E6C20 */ get => default; } // 0x000000018500CCF0-0x000000018500CDA0 
		public MonoCookGotPanel combineGotPanel { /* [XID] */ /* 0x00000001898EE330-0x00000001898EE350 */ get => default; } // 0x000000018500D0C0-0x000000018500D170 
		public MonoUIContainer synthesisBtn { /* [XID] */ /* 0x00000001898F5B80-0x00000001898F5BA0 */ get => default; } // 0x000000018500EB50-0x000000018500EC60 
		public MonoUIContainer returnBtn { /* [XID] */ /* 0x00000001898FD320-0x00000001898FD340 */ get => default; } // 0x000000018500E210-0x000000018500E320 
		public Button sortBtn { /* [XID] */ /* 0x0000000189904C00-0x0000000189904C20 */ get => default; } // 0x000000018500EA20-0x000000018500EB50 
		public MonoUIContainer changeAvatorBtn { /* [XID] */ /* 0x000000018990C420-0x000000018990C440 */ get => default; } // 0x000000018500CF00-0x000000018500CFB0 
		public GameObject screeningPanel { /* [XID] */ /* 0x0000000189913D10-0x0000000189913D30 */ get => default; } // 0x000000018500E590-0x000000018500E640 
		public GameObject screeningTitle { /* [XID] */ /* 0x000000018991B680-0x000000018991B6A0 */ get => default; } // 0x000000018500E6F0-0x000000018500E7A0 
		public MonoGridScroller screeningScroller { /* [XID] */ /* 0x0000000189922C20-0x0000000189922C40 */ get => default; } // 0x000000018500E640-0x000000018500E6F0 
		public MonoUIContainer screenDrop { /* [XID] */ /* 0x000000018992A510-0x000000018992A530 */ get => default; } // 0x000000018500E3D0-0x000000018500E4E0 
		public UnityEngine.UI.Text screenText { /* [XID] */ /* 0x0000000189931AC0-0x0000000189931AE0 */ get => default; } // 0x000000018500E4E0-0x000000018500E590 
		public Button screenBackBtn { /* [XID] */ /* 0x0000000189939520-0x0000000189939540 */ get => default; } // 0x000000018500E320-0x000000018500E3D0 
		public Button settlementCloseBtn { /* [XID] */ /* 0x0000000189940850-0x0000000189940870 */ get => default; } // 0x000000018500E850-0x000000018500E980 
		public Button avatarSelectBackBtn { /* [XID] */ /* 0x00000001899480D0-0x00000001899480F0 */ get => default; } // 0x000000018500CA30-0x000000018500CBE0 
		public GameObject avatarSelectBtnGO { /* [XID] */ /* 0x000000018994F850-0x000000018994F870 */ get => default; } // 0x000000018500CBE0-0x000000018500CCF0 
		public GameObject meltingSelectBtnGO { /* [XID] */ /* 0x0000000189956DF0-0x0000000189956E10 */ get => default; } // 0x000000018500DD90-0x000000018500DEA0 
		public GameObject avatarCanUpImgRipple { /* [XID] */ /* 0x000000018995E940-0x000000018995E960 */ get => default; } // 0x000000018500C760-0x000000018500C8E0 
		public GameObject[] joypadSelectLeftShowObjs { /* [XID] */ /* 0x0000000189966040-0x0000000189966060 */ get => default; } // 0x000000018500D970-0x000000018500DA20 
		public GameObject[] joypadSelectRightShowObjs { /* [XID] */ /* 0x000000018996D4E0-0x000000018996D500 */ get => default; } // 0x000000018500DA20-0x000000018500DAD0 
		public GameObject grpNormal { /* [XID] */ /* 0x00000001899750A0-0x00000001899750C0 */ get => default; } // 0x000000018500D6C0-0x000000018500D770 
		public GameObject grpOkNo { /* [XID] */ /* 0x000000018997C280-0x000000018997C2A0 */ get => default; } // 0x000000018500D770-0x000000018500D820 
		public bool showScreenBtnDetailIcon { /* [XID] */ /* 0x0000000189983F70-0x0000000189983F90 */ set {} } // 0x000000018500F8F0-0x000000018500FA90
		public float animTime { /* [XID] */ /* 0x000000018998BB50-0x000000018998BB70 */ get => default; } // 0x000000018500C6B0-0x000000018500C760 
		public float btnDisableTime { /* [XID] */ /* 0x00000001899936B0-0x00000001899936D0 */ get => default; } // 0x000000018500CE50-0x000000018500CF00 
		public Button tabSynthesisBtn { /* [XID] */ /* 0x000000018999B000-0x000000018999B020 */ get => default; } // 0x000000018500EF60-0x000000018500F110 
		public Button tabMeltingBtn { /* [XID] */ /* 0x00000001899A27E0-0x00000001899A2800 */ get => default; } // 0x000000018500EC60-0x000000018500EE10 
		public MonoImgTab tabSynthesisTab { /* [XID] */ /* 0x00000001899AA180-0x00000001899AA1A0 */ get => default; } // 0x000000018500F110-0x000000018500F260 
		public MonoImgTab tabMeltingTab { /* [XID] */ /* 0x00000001899B1B70-0x00000001899B1B90 */ get => default; } // 0x000000018500EE10-0x000000018500EF60 
		public bool showJoypadButtons { /* [XID] */ /* 0x00000001899B8EE0-0x00000001899B8F00 */ set {} } // 0x000000018500F6F0-0x000000018500F7E0
		public bool showAvatarJoypadButtons { /* [XID] */ /* 0x00000001899C0740-0x00000001899C0760 */ set {} } // 0x000000018500F4F0-0x000000018500F600
		public bool showMeltingJoypadButtons { /* [XID] */ /* 0x00000001899C8000-0x00000001899C8020 */ set {} } // 0x000000018500F7E0-0x000000018500F8F0
	
		// Constructors
		public MonoSynthesisPage() {} // 0x000000018500C530-0x000000018500C6B0
	}
}
