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
	public class MonoActivityFleurFair : MonoUIProxy // TypeDefIndex: 29697
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _activityFleurFair; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _txtDateMono; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnDescription; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _btnShop; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnShopPS4; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnDungeon; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnMiniGames; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnEntrust; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _scrollView; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnGotoQuest; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _textMono; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _grpEndTipsTextMono; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnGotoQuestPS4; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnGotoPS4; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnOKPS4; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnExitPS4; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnBackPS4; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpUnlockTips; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpEndTips; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpRewardRoot; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _scrollTextDesc; // 0xE0
	
		// Properties
		public GameObject grpUnlockTips { /* [XID] */ /* 0x000000018979CC60-0x000000018979CC80 */ get => default; } // 0x0000000186315EF0-0x0000000186315FA0 
		public GameObject grpEndTips { /* [XID] */ /* 0x00000001897A40C0-0x00000001897A40E0 */ get => default; } // 0x0000000186315D90-0x0000000186315E40 
		public GameObject grpRewardRoot { /* [XID] */ /* 0x00000001897AB620-0x00000001897AB640 */ get => default; } // 0x0000000186315E40-0x0000000186315EF0 
		public GameObject btnShopRoot { /* [XID] */ /* 0x00000001897B3470-0x00000001897B3490 */ get => default; } // 0x0000000186315C10-0x0000000186315CD0 
		public MonoUIContainer btnGotoQuest { /* [XID] */ /* 0x00000001897BB350-0x00000001897BB370 */ get => default; } // 0x00000001863159D0-0x0000000186315A90 
		public MonoUIContainer btnExit { /* [XID] */ /* 0x00000001897C2B30-0x00000001897C2B50 */ get => default; } // 0x0000000186315910-0x00000001863159D0 
		public MonoUIContainer btnBack { /* [XID] */ /* 0x00000001897CA390-0x00000001897CA3B0 */ get => default; } // 0x00000001863156D0-0x0000000186315790 
		public MonoUIContainer btnOK { /* [XID] */ /* 0x00000001897D19F0-0x00000001897D1A10 */ get => default; } // 0x0000000186315B50-0x0000000186315C10 
		public MonoUIContainer btnShop { /* [XID] */ /* 0x00000001897D9810-0x00000001897D9830 */ get => default; } // 0x0000000186315CD0-0x0000000186315D90 
		public MonoUIContainer btnDescription { /* [XID] */ /* 0x00000001897E0BD0-0x00000001897E0BF0 */ get => default; } // 0x0000000186315850-0x0000000186315910 
		public MonoUIContainer btnGoto { /* [XID] */ /* 0x00000001897E8230-0x00000001897E8250 */ get => default; } // 0x0000000186315A90-0x0000000186315B50 
		public MonoUIContainer btnCheck { /* [XID] */ /* 0x00000001897EFF50-0x00000001897EFF70 */ get => default; } // 0x0000000186315790-0x0000000186315850 
		public ScrollRect scrollTextDesc { /* [XID] */ /* 0x0000000189875280-0x00000001898752A0 */ get => default; } // 0x0000000186315FA0-0x0000000186316050 
	
		// Constructors
		public MonoActivityFleurFair() {} // 0x00000001863155F0-0x00000001863156D0
	
		// Methods
		// [XID] // 0x00000001897F76E0-0x00000001897F7700
		public MonoElementSwitch GetActivityFleurFair() => default; // 0x0000000186314AC0-0x0000000186314B60
		// [XID] // 0x00000001897FEDD0-0x00000001897FEDF0
		public Text GetTxtDateMono() => default; // 0x0000000186315550-0x00000001863155F0
		// [XID] // 0x0000000189806550-0x0000000189806570
		public MonoUIContainer GetBtnDescription() => default; // 0x0000000186314C10-0x0000000186314CB0
		// [XID] // 0x000000018980DC50-0x000000018980DC70
		public Button GetBtnShop() => default; // 0x00000001863152A0-0x0000000186315340
		// [XID] // 0x0000000189815390-0x00000001898153B0
		public MonoUIContainer GetBtnShopPS4() => default; // 0x0000000186315200-0x00000001863152A0
		// [XID] // 0x000000018981CD70-0x000000018981CD90
		public MonoUIContainer GetBtnDungeon() => default; // 0x0000000186314CB0-0x0000000186314D50
		// [XID] // 0x00000001898241B0-0x00000001898241D0
		public MonoUIContainer GetBtnMiniGames() => default; // 0x00000001863150B0-0x0000000186315150
		// [XID] // 0x000000018982BC40-0x000000018982BC60
		public MonoUIContainer GetBtnEntrust() => default; // 0x0000000186314D50-0x0000000186314DF0
		// [XID] // 0x00000001898331D0-0x00000001898331F0
		public MonoGridScroller GetScrollView() => default; // 0x00000001863153F0-0x00000001863154A0
		// [XID] // 0x000000018983A680-0x000000018983A6A0
		public MonoUIContainer GetBtnGotoQuest() => default; // 0x0000000186315000-0x00000001863150B0
		// [XID] // 0x0000000189841C80-0x0000000189841CA0
		public Text GetTextMono() => default; // 0x00000001863154A0-0x0000000186315550
		// [XID] // 0x0000000189849150-0x0000000189849170
		public Text GetGrpEndTipsTextMono() => default; // 0x0000000186315340-0x00000001863153F0
		// [XID] // 0x0000000189850910-0x0000000189850930
		public MonoUIContainer GetBtnGotoQuestPS4() => default; // 0x0000000186314F50-0x0000000186315000
		// [XID] // 0x0000000189857CE0-0x0000000189857D00
		public MonoUIContainer GetBtnGotoPS4() => default; // 0x0000000186314EA0-0x0000000186314F50
		// [XID] // 0x000000018985EDD0-0x000000018985EDF0
		public MonoUIContainer GetBtnOKPS4() => default; // 0x0000000186315150-0x0000000186315200
		// [XID] // 0x00000001898665B0-0x00000001898665D0
		public MonoUIContainer GetBtnExitPS4() => default; // 0x0000000186314DF0-0x0000000186314EA0
		// [XID] // 0x000000018986DEB0-0x000000018986DED0
		public MonoUIContainer GetBtnBackPS4() => default; // 0x0000000186314B60-0x0000000186314C10
	}
}
