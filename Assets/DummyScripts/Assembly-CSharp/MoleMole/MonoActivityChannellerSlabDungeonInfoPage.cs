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
	public class MonoActivityChannellerSlabDungeonInfoPage : MonoUIProxy // TypeDefIndex: 30168
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _activityChannellerSlabDungeonInfoPage; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _imgBg; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _menu; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _factorList; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _monsterList; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _scrollView; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _buffListScrollView; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnOKPS4; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnBackPS4; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnReturnPS4; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnReturn; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpSuccessScore; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _panelInfo; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _panelChallenge; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _panelBuff; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textChallengeDifficulty; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textTimeRestriction; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textMonsterHpRestriction; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textSuccessScore; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _restrictionList; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpSelect; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textTitle; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textSplash; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textSubTitle; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpNoBuff; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpNoRestriction; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textMonsterList; // 0x110
	
		// Properties
		public GameObject grpSuccessScore { /* [XID] */ /* 0x00000001897A5C70-0x00000001897A5C90 */ get => default; } // 0x00000001863061D0-0x0000000186306280 
		public GameObject panelInfo { /* [XID] */ /* 0x00000001897AD1E0-0x00000001897AD200 */ get => default; } // 0x00000001863063E0-0x0000000186306490 
		public GameObject panelChallenge { /* [XID] */ /* 0x00000001897B5210-0x00000001897B5230 */ get => default; } // 0x0000000186306330-0x00000001863063E0 
		public GameObject panelBuff { /* [XID] */ /* 0x00000001897BCE80-0x00000001897BCEA0 */ get => default; } // 0x0000000186306280-0x0000000186306330 
		public string textChallengeDifficulty { /* [XID] */ /* 0x00000001897C4200-0x00000001897C4220 */ set {} } // 0x0000000186306800-0x00000001863068D0
		public string textTimeRestriction { /* [XID] */ /* 0x00000001897CBA80-0x00000001897CBAA0 */ set {} } // 0x0000000186306A70-0x0000000186306B40
		public string textMonsterHpRestriction { /* [XID] */ /* 0x00000001897D3390-0x00000001897D33B0 */ set {} } // 0x00000001863068D0-0x00000001863069A0
		public string textSuccessScore { /* [XID] */ /* 0x00000001897DADF0-0x00000001897DAE10 */ set {} } // 0x00000001863069A0-0x0000000186306A70
		public MonoSimpleReusableList restrictionList { /* [XID] */ /* 0x00000001897E2500-0x00000001897E2520 */ get => default; } // 0x0000000186306490-0x0000000186306540 
		public GameObject grpSelect { /* [XID] */ /* 0x00000001897E9C70-0x00000001897E9C90 */ get => default; } // 0x0000000186306120-0x00000001863061D0 
		public UnityEngine.UI.Text textTitle { /* [XID] */ /* 0x00000001897F1930-0x00000001897F1950 */ get => default; } // 0x0000000186306750-0x0000000186306800 
		public UnityEngine.UI.Text textSubTitle { /* [XID] */ /* 0x00000001897F9080-0x00000001897F90A0 */ get => default; } // 0x00000001863066A0-0x0000000186306750 
		public UnityEngine.UI.Text textSplash { /* [XID] */ /* 0x0000000189800690-0x00000001898006B0 */ get => default; } // 0x00000001863065F0-0x00000001863066A0 
		public GameObject grpNoBuff { /* [XID] */ /* 0x0000000189807D10-0x0000000189807D30 */ get => default; } // 0x0000000186305FC0-0x0000000186306070 
		public GameObject grpNoRestriction { /* [XID] */ /* 0x000000018980F610-0x000000018980F630 */ get => default; } // 0x0000000186306070-0x0000000186306120 
		public UnityEngine.UI.Text textMonsterList { /* [XID] */ /* 0x0000000189816C80-0x0000000189816CA0 */ get => default; } // 0x0000000186306540-0x00000001863065F0 
		public MonoUIContainer btnReturn { /* [XID] */ /* 0x000000018981E510-0x000000018981E530 */ get => default; } // 0x0000000186305F00-0x0000000186305FC0 
		public MonoUIContainer btnOK { /* [XID] */ /* 0x00000001898259B0-0x00000001898259D0 */ get => default; } // 0x0000000186305E40-0x0000000186305F00 
		public MonoUIContainer btnBack { /* [XID] */ /* 0x000000018982D160-0x000000018982D180 */ get => default; } // 0x0000000186305D80-0x0000000186305E40 
	
		// Constructors
		public MonoActivityChannellerSlabDungeonInfoPage() {} // 0x0000000186305C70-0x0000000186305D80
	
		// Methods
		// [XID] // 0x00000001898348C0-0x00000001898348E0
		public MonoElementSwitch GetActivityChannellerSlabDungeonInfoPage() => default; // 0x0000000186305560-0x0000000186305600
		// [XID] // 0x000000018983BF30-0x000000018983BF50
		public MonoUIContainer GetImgBg() => default; // 0x00000001863059F0-0x0000000186305A90
		// [XID] // 0x0000000189843560-0x0000000189843580
		public MonoSimpleReusableList GetMenu() => default; // 0x0000000186305A90-0x0000000186305B30
		// [XID] // 0x000000018984AA60-0x000000018984AA80
		public MonoSimpleReusableList GetFactorList() => default; // 0x0000000186305950-0x00000001863059F0
		// [XID] // 0x0000000189851E40-0x0000000189851E60
		public MonoSimpleReusableList GetMonsterList() => default; // 0x0000000186305B30-0x0000000186305BD0
		// [XID] // 0x0000000189859700-0x0000000189859720
		public MonoGridScroller GetScrollView() => default; // 0x0000000186305BD0-0x0000000186305C70
		// [XID] // 0x00000001898608A0-0x00000001898608C0
		public MonoSimpleReusableList GetBuffListScrollView() => default; // 0x00000001863058B0-0x0000000186305950
		// [XID] // 0x0000000189867F90-0x0000000189867FB0
		public MonoUIContainer GetBtnOKPS4() => default; // 0x00000001863056B0-0x0000000186305750
		// [XID] // 0x000000018986F4F0-0x000000018986F510
		public MonoUIContainer GetBtnBackPS4() => default; // 0x0000000186305600-0x00000001863056B0
		// [XID] // 0x0000000189876B40-0x0000000189876B60
		public MonoUIContainer GetBtnReturnPS4() => default; // 0x0000000186305750-0x0000000186305800
		// [XID] // 0x000000018987E640-0x000000018987E660
		public MonoUIContainer GetBtnReturn() => default; // 0x0000000186305800-0x00000001863058B0
	}
}
