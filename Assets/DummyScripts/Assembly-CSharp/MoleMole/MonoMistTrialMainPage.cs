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
	public class MonoMistTrialMainPage : MonoUIProxy // TypeDefIndex: 30206
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _monoSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _monsterScroll; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoJoypadSimpleResuableListHandler _joypadMonsterScroll; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoScrollRectExtention _monsterScrollRect; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _watcherScroll; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _txtTitle; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _txtDesc; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoMistTrialSelectAvatarPage _monoAvatar; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _mainGO; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selectAvatarGO; // 0x88
	
		// Properties
		public Text txtTitle { /* [XID] */ /* 0x0000000189724B10-0x0000000189724B30 */ get => default; } // 0x0000000182F14DE0-0x0000000182F14E80 
		public Text txtDesc { /* [XID] */ /* 0x000000018972C340-0x000000018972C360 */ get => default; } // 0x0000000182F14D40-0x0000000182F14DE0 
		public MonoMistTrialSelectAvatarPage monoAvatar { /* [XID] */ /* 0x0000000189733A00-0x0000000189733A20 */ get => default; } // 0x0000000182F14B50-0x0000000182F14BF0 
		public GameObject mainGO { /* [XID] */ /* 0x000000018973B180-0x000000018973B1A0 */ get => default; } // 0x0000000182F14AA0-0x0000000182F14B50 
		public GameObject selectAvatarGO { /* [XID] */ /* 0x0000000189742B30-0x0000000189742B50 */ get => default; } // 0x0000000182F14C90-0x0000000182F14D40 
		public MonoUIContainer btnClose { /* [XID] */ /* 0x000000018974A810-0x000000018974A830 */ get => default; } // 0x0000000182F14260-0x0000000182F14320 
		public MonoUIContainer btnFetch { /* [XID] */ /* 0x00000001897518F0-0x0000000189751910 */ get => default; } // 0x0000000182F143E0-0x0000000182F144A0 
		public MonoUIContainer btnGoto { /* [XID] */ /* 0x0000000189758EE0-0x0000000189758F00 */ get => default; } // 0x0000000182F144A0-0x0000000182F14560 
		public MonoUIContainer btnDetail { /* [XID] */ /* 0x0000000189760B90-0x0000000189760BB0 */ get => default; } // 0x0000000182F14320-0x0000000182F143E0 
		public MonoUIContainer btnInstruction { /* [XID] */ /* 0x0000000189767E50-0x0000000189767E70 */ get => default; } // 0x0000000182F14560-0x0000000182F14620 
		public MonoUIContainer btnCheckAvatar { /* [XID] */ /* 0x000000018976F420-0x000000018976F440 */ get => default; } // 0x0000000182F141A0-0x0000000182F14260 
		public MonoUIContainer btnStartChanllenge { /* [XID] */ /* 0x0000000189776E40-0x0000000189776E60 */ get => default; } // 0x0000000182F147A0-0x0000000182F14860 
		public MonoUIContainer btnResonance { /* [XID] */ /* 0x000000018977E500-0x000000018977E520 */ get => default; } // 0x0000000182F14620-0x0000000182F146E0 
		public MonoUIContainer btnSelect { /* [XID] */ /* 0x0000000189785C30-0x0000000189785C50 */ get => default; } // 0x0000000182F146E0-0x0000000182F147A0 
		public MonoUIContainer btnBack { /* [XID] */ /* 0x000000018978D390-0x000000018978D3B0 */ get => default; } // 0x0000000182F140E0-0x0000000182F141A0 
		public MonoUIContainer btnUnselect { /* [XID] */ /* 0x0000000189794710-0x0000000189794730 */ get => default; } // 0x0000000182F149E0-0x0000000182F14AA0 
		public MonoUIContainer btnSwitchPrev { /* [XID] */ /* 0x000000018979CBA0-0x000000018979CBC0 */ get => default; } // 0x0000000182F14920-0x0000000182F149E0 
		public MonoUIContainer btnSwitchNext { /* [XID] */ /* 0x00000001897A4000-0x00000001897A4020 */ get => default; } // 0x0000000182F14860-0x0000000182F14920 
		public MonoElementSwitch monoSwitch { /* [XID] */ /* 0x00000001897AB560-0x00000001897AB580 */ get => default; } // 0x0000000182F14BF0-0x0000000182F14C90 
	
		// Constructors
		public MonoMistTrialMainPage() {} // 0x0000000182F14050-0x0000000182F140E0
	
		// Methods
		// [XID] // 0x00000001897B3350-0x00000001897B3370
		public MonoSimpleReusableList GetMonsterScroll() => default; // 0x0000000182F13F10-0x0000000182F13FB0
		// [XID] // 0x00000001897BB270-0x00000001897BB290
		public MonoJoypadSimpleResuableListHandler GetJoypadMonsterScroll() => default; // 0x0000000182F13DD0-0x0000000182F13E70
		// [XID] // 0x00000001897C2A50-0x00000001897C2A70
		public MonoScrollRectExtention GetMonsterScrollRect() => default; // 0x0000000182F13E70-0x0000000182F13F10
		// [XID] // 0x00000001897CA270-0x00000001897CA290
		public MonoGridScroller GetWatcherScroll() => default; // 0x0000000182F13FB0-0x0000000182F14050
	}
}
