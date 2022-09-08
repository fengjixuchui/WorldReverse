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
	public class MonoActivitySubPageChannellerSlab : MonoUIProxy // TypeDefIndex: 31175
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _timeDesc; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _unlockHint; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _charactorBtn; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _unlockTrans; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _lockedTrans; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _coinTrans; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _lockedHintTrans; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer[] _slabStages; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoJoypadItemNavigator _joypadItemNavigator; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoJoypadScrollRect _scrollRect; // 0x90
	
		// Properties
		public MonoElementSwitch ElementSwitch { /* [XID] */ /* 0x000000018995FF30-0x000000018995FF50 */ get => default; } // 0x00000001852E2140-0x00000001852E21E0 
		public UnityEngine.UI.Text TimeDesc { /* [XID] */ /* 0x00000001899679D0-0x00000001899679F0 */ get => default; } // 0x00000001852E2290-0x00000001852E2330 
		public MonoJoypadScrollRect ScrollDesc { /* [XID] */ /* 0x000000018996EB50-0x000000018996EB70 */ get => default; } // 0x00000001852E21E0-0x00000001852E2290 
		public UnityEngine.UI.Text UnlockHint { /* [XID] */ /* 0x0000000189976730-0x0000000189976750 */ get => default; } // 0x00000001852E2330-0x00000001852E23D0 
		public Transform coinRoot { /* [XID] */ /* 0x000000018997DB50-0x000000018997DB70 */ get => default; } // 0x00000001852E23D0-0x00000001852E2470 
		public MonoJoypadItemNavigator itemNavigator { /* [XID] */ /* 0x00000001899854F0-0x0000000189985510 */ get => default; } // 0x00000001852E2470-0x00000001852E2520 
		public MonoUIContainer BtnExit { /* [XID] */ /* 0x000000018998D2B0-0x000000018998D2D0 */ get => default; } // 0x00000001852E1CC0-0x00000001852E1D80 
		public MonoUIContainer BtnBack { /* [XID] */ /* 0x0000000189994D50-0x0000000189994D70 */ get => default; } // 0x00000001852E1900-0x00000001852E19C0 
		public MonoUIContainer BtnOK { /* [XID] */ /* 0x000000018999C630-0x000000018999C650 */ get => default; } // 0x00000001852E1F00-0x00000001852E1FC0 
		public MonoUIContainer BtnShop { /* [XID] */ /* 0x00000001899A40C0-0x00000001899A40E0 */ get => default; } // 0x00000001852E2080-0x00000001852E2140 
		public MonoUIContainer BtnDesc { /* [XID] */ /* 0x00000001899ABA90-0x00000001899ABAB0 */ get => default; } // 0x00000001852E1C00-0x00000001852E1CC0 
		public MonoUIContainer BtnCharacter { /* [XID] */ /* 0x00000001899B3470-0x00000001899B3490 */ get => default; } // 0x00000001852E1B40-0x00000001852E1C00 
		public Transform BtnCharacterPS4BG { /* [XID] */ /* 0x00000001899BA790-0x00000001899BA7B0 */ get => default; } // 0x00000001852E19C0-0x00000001852E1A80 
		public MonoUIContainer BtnCharacterPS4 { /* [XID] */ /* 0x00000001899C20D0-0x00000001899C20F0 */ get => default; } // 0x00000001852E1A80-0x00000001852E1B40 
		public MonoUIContainer BtnGoto { /* [XID] */ /* 0x00000001899C97D0-0x00000001899C97F0 */ get => default; } // 0x00000001852E1E40-0x00000001852E1F00 
		public MonoUIContainer BtnGotoQuest { /* [XID] */ /* 0x00000001899D1070-0x00000001899D1090 */ get => default; } // 0x00000001852E1D80-0x00000001852E1E40 
		public MonoUIContainer BtnPlate { /* [XID] */ /* 0x00000001899D8560-0x00000001899D8580 */ get => default; } // 0x00000001852E1FC0-0x00000001852E2080 
	
		// Constructors
		public MonoActivitySubPageChannellerSlab() {} // 0x00000001852E1870-0x00000001852E1900
	
		// Methods
		// [XID] // 0x00000001899DFBF0-0x00000001899DFC10
		public void SetCharactorHint(int charState) {} // 0x00000001852E1490-0x00000001852E1690
		// [XID] // 0x00000001899E7640-0x00000001899E7660
		public void SetIsLocked(bool bLocked) {} // 0x00000001852E1690-0x00000001852E1790
		// [XID] // 0x00000001899EEBF0-0x00000001899EEC10
		public void SetLevelLocked(bool bLocked) {} // 0x00000001852E1790-0x00000001852E1870
		// [XID] // 0x00000001899F6470-0x00000001899F6490
		public MonoChannellerSlabStage GetStage(int index) => default; // 0x00000001852E13A0-0x00000001852E1490
	}
}
