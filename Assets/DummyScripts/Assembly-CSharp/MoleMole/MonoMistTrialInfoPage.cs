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
	public class MonoMistTrialInfoPage : MonoUIProxy // TypeDefIndex: 30198
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _mistTrialInfoPage; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _imgBg; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _menu; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _randomFactor; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _monsterList; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _scrollView; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnItemDetailPS4; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnOKPS4; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnBackPS4; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnExitPS4; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnClose; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _monsterGO; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _watcherGO; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _scrollRect; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _txtNone; // 0xB0
	
		// Properties
		public GameObject monsterGO { /* [XID] */ /* 0x0000000189A40750-0x0000000189A40770 */ get => default; } // 0x0000000182F13B10-0x0000000182F13BC0 
		public GameObject watcherGO { /* [XID] */ /* 0x0000000189A47E30-0x0000000189A47E50 */ get => default; } // 0x0000000182F13D20-0x0000000182F13DD0 
		public ScrollRect scrollRect { /* [XID] */ /* 0x0000000189A4F5D0-0x0000000189A4F5F0 */ get => default; } // 0x0000000182F13BC0-0x0000000182F13C70 
		public GameObject txtNone { /* [XID] */ /* 0x0000000189A56CF0-0x0000000189A56D10 */ get => default; } // 0x0000000182F13C70-0x0000000182F13D20 
		public MonoUIContainer btnClose { /* [XID] */ /* 0x0000000189A5E820-0x0000000189A5E840 */ get => default; } // 0x0000000182F138D0-0x0000000182F13990 
		public MonoUIContainer btnItemDetail { /* [XID] */ /* 0x0000000189A65FC0-0x0000000189A65FE0 */ get => default; } // 0x0000000182F13990-0x0000000182F13A50 
		public MonoUIContainer btnOK { /* [XID] */ /* 0x0000000189A6D690-0x0000000189A6D6B0 */ get => default; } // 0x0000000182F13A50-0x0000000182F13B10 
		public MonoUIContainer btnBack { /* [XID] */ /* 0x0000000189A74DB0-0x0000000189A74DD0 */ get => default; } // 0x0000000182F13810-0x0000000182F138D0 
	
		// Nested types
		public enum State // TypeDefIndex: 30199
		{
			Monster = 0,
			Watcher = 1
		}
	
		// Constructors
		public MonoMistTrialInfoPage() {} // 0x0000000182F13750-0x0000000182F13810
	
		// Methods
		// [XID] // 0x0000000189A7CA00-0x0000000189A7CA20
		public MonoElementSwitch GetMistTrialInfoPage() => default; // 0x0000000182F133B0-0x0000000182F13450
		// [XID] // 0x0000000189A84320-0x0000000189A84340
		public MonoUIContainer GetImgBg() => default; // 0x0000000182F13270-0x0000000182F13310
		// [XID] // 0x0000000189A8BC50-0x0000000189A8BC70
		public MonoSimpleReusableList GetMenu() => default; // 0x0000000182F13310-0x0000000182F133B0
		// [XID] // 0x0000000189A931E0-0x0000000189A93200
		public MonoSimpleReusableList GetRandomFactor() => default; // 0x0000000182F134F0-0x0000000182F13590
		// [XID] // 0x0000000189A9AC40-0x0000000189A9AC60
		public MonoSimpleReusableList GetMonsterList() => default; // 0x0000000182F13450-0x0000000182F134F0
		// [XID] // 0x0000000189AA1F10-0x0000000189AA1F30
		public MonoGridScroller GetScrollView() => default; // 0x0000000182F13590-0x0000000182F13630
		// [XID] // 0x0000000189AA93F0-0x0000000189AA9410
		public MonoUIContainer GetBtnItemDetailPS4() => default; // 0x0000000182F13130-0x0000000182F131D0
		// [XID] // 0x0000000189AB1350-0x0000000189AB1370
		public MonoUIContainer GetBtnOKPS4() => default; // 0x0000000182F131D0-0x0000000182F13270
		// [XID] // 0x0000000189AB85C0-0x0000000189AB85E0
		public MonoUIContainer GetBtnBackPS4() => default; // 0x0000000182F12F20-0x0000000182F12FD0
		// [XID] // 0x0000000189AC02A0-0x0000000189AC02C0
		public MonoUIContainer GetBtnExitPS4() => default; // 0x0000000182F13080-0x0000000182F13130
		// [XID] // 0x0000000189AC7C60-0x0000000189AC7C80
		public MonoUIContainer GetBtnClose() => default; // 0x0000000182F12FD0-0x0000000182F13080
		// [XID] // 0x0000000189ACF1E0-0x0000000189ACF200
		public void SetPageState(State state) {} // 0x0000000182F13630-0x0000000182F13750
	}
}
