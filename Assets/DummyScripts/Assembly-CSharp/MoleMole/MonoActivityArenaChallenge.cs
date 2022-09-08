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
	public class MonoActivityArenaChallenge : MonoUIProxy // TypeDefIndex: 30269
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _monoSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnDescription; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _scrollView; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnReward; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnGoto; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnGotoQuest; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnItemDetailPS4; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnGotoPS4; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnGotoQuestPS4; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnRewardPS4; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnOKPS4; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnExitPS4; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnBackPS4; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _txtTitle; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _txtDate; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _txtDesc; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _scrollDesc; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _rewardScroll; // 0xC8
	
		// Properties
		public MonoGridScroller rewardScroll { /* [XID] */ /* 0x00000001896EDA60-0x00000001896EDA80 */ get => default; } // 0x0000000184C72D10-0x0000000184C72DC0 
		public MonoElementSwitch monoSwitch { /* [XID] */ /* 0x00000001896F5230-0x00000001896F5250 */ get => default; } // 0x0000000184C72C70-0x0000000184C72D10 
		public Text txtTitle { /* [XID] */ /* 0x00000001896FCA90-0x00000001896FCAB0 */ get => default; } // 0x0000000184C72FD0-0x0000000184C73080 
		public Text txtDate { /* [XID] */ /* 0x0000000189703F50-0x0000000189703F70 */ get => default; } // 0x0000000184C72E70-0x0000000184C72F20 
		public Text txtDesc { /* [XID] */ /* 0x000000018970B840-0x000000018970B860 */ get => default; } // 0x0000000184C72F20-0x0000000184C72FD0 
		public ScrollRect scrollDesc { /* [XID] */ /* 0x00000001897130D0-0x00000001897130F0 */ get => default; } // 0x0000000184C72DC0-0x0000000184C72E70 
		public MonoUIContainer btnGoto { /* [XID] */ /* 0x000000018971A8F0-0x000000018971A910 */ get => default; } // 0x0000000184C72970-0x0000000184C72A30 
		public MonoUIContainer btnExit { /* [XID] */ /* 0x0000000189721C50-0x0000000189721C70 */ get => default; } // 0x0000000184C727F0-0x0000000184C728B0 
		public MonoUIContainer btnBack { /* [XID] */ /* 0x00000001897292C0-0x00000001897292E0 */ get => default; } // 0x0000000184C72730-0x0000000184C727F0 
		public MonoUIContainer btnOK { /* [XID] */ /* 0x0000000189730B20-0x0000000189730B40 */ get => default; } // 0x0000000184C72AF0-0x0000000184C72BB0 
		public MonoUIContainer btnItemDetail { /* [XID] */ /* 0x0000000189738450-0x0000000189738470 */ get => default; } // 0x0000000184C72A30-0x0000000184C72AF0 
		public MonoUIContainer btnReward { /* [XID] */ /* 0x0000000189740190-0x00000001897401B0 */ get => default; } // 0x0000000184C72BB0-0x0000000184C72C70 
		public MonoUIContainer btnGotoQuest { /* [XID] */ /* 0x0000000189747540-0x0000000189747560 */ get => default; } // 0x0000000184C728B0-0x0000000184C72970 
	
		// Constructors
		public MonoActivityArenaChallenge() {} // 0x0000000184C72660-0x0000000184C72730
	
		// Methods
		// [XID] // 0x000000018974EC90-0x000000018974ECB0
		public MonoElementSwitch GetActivityArenaChallenge() => default; // 0x0000000184C71DF0-0x0000000184C71E90
		// [XID] // 0x00000001897563A0-0x00000001897563C0
		public MonoUIContainer GetBtnDescription() => default; // 0x0000000184C71F40-0x0000000184C71FE0
		// [XID] // 0x000000018975D780-0x000000018975D7A0
		public MonoGridScroller GetScrollView() => default; // 0x0000000184C725C0-0x0000000184C72660
		// [XID] // 0x0000000189764DD0-0x0000000189764DF0
		public MonoUIContainer GetBtnReward() => default; // 0x0000000184C72520-0x0000000184C725C0
		// [XID] // 0x000000018976C830-0x000000018976C850
		public MonoUIContainer GetBtnGoto() => default; // 0x0000000184C72280-0x0000000184C72320
		// [XID] // 0x0000000189773CD0-0x0000000189773CF0
		public MonoUIContainer GetBtnGotoQuest() => default; // 0x0000000184C721E0-0x0000000184C72280
		// [XID] // 0x000000018977B380-0x000000018977B3A0
		public MonoUIContainer GetBtnItemDetailPS4() => default; // 0x0000000184C72320-0x0000000184C723C0
		// [XID] // 0x0000000189782EC0-0x0000000189782EE0
		public MonoUIContainer GetBtnGotoPS4() => default; // 0x0000000184C72090-0x0000000184C72130
		// [XID] // 0x000000018978A350-0x000000018978A370
		public MonoUIContainer GetBtnGotoQuestPS4() => default; // 0x0000000184C72130-0x0000000184C721E0
		// [XID] // 0x0000000189791BB0-0x0000000189791BD0
		public MonoUIContainer GetBtnRewardPS4() => default; // 0x0000000184C72470-0x0000000184C72520
		// [XID] // 0x0000000189799190-0x00000001897991B0
		public MonoUIContainer GetBtnOKPS4() => default; // 0x0000000184C723C0-0x0000000184C72470
		// [XID] // 0x00000001897A1090-0x00000001897A10B0
		public MonoUIContainer GetBtnExitPS4() => default; // 0x0000000184C71FE0-0x0000000184C72090
		// [XID] // 0x00000001897A8700-0x00000001897A8720
		public MonoUIContainer GetBtnBackPS4() => default; // 0x0000000184C71E90-0x0000000184C71F40
	}
}
