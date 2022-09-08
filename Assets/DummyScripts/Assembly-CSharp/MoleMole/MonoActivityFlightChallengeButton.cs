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
	internal class MonoActivityFlightChallengeButton : MonoSpriteProxy // TypeDefIndex: 30337
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _titleText; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _selectedArrow; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _completeTrans; // 0x30
		// [Header] // 0x00000001896DA910-0x00000001896DA960
		[SerializeField] // 0x00000001896DA910-0x00000001896DA960
		private Transform _medalLock; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _medalNoMedal; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _medal1; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _medal2; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _medal3; // 0x58
		// [Header] // 0x0000000189BB04A0-0x0000000189BB04E0
		[SerializeField] // 0x0000000189BB04A0-0x0000000189BB04E0
		private Transform _openTipsTrans; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _tipsText; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected Button _actionButton; // 0x70
		private bool _hightlighted; // 0x78
	
		// Properties
		public UnityEngine.UI.Text titleText { /* [XID] */ /* 0x0000000189BCB900-0x0000000189BCB920 */ get => default; } // 0x0000000186316820-0x00000001863168C0 
		public UnityEngine.UI.Text tipsText { /* [XID] */ /* 0x0000000189BD2EA0-0x0000000189BD2EC0 */ get => default; } // 0x0000000186316780-0x0000000186316820 
		public Button actionButton { /* [XID] */ /* 0x0000000189BDA640-0x0000000189BDA660 */ get => default; } // 0x0000000186316640-0x00000001863166E0 
		public bool highlight { /* [XID] */ /* 0x0000000189604F60-0x0000000189604F80 */ get => default; /* [XID] */ /* 0x000000018960C9B0-0x000000018960C9D0 */ set {} } // 0x00000001863166E0-0x0000000186316780 0x00000001863168C0-0x0000000186316B10
		public bool selected_Arrow { /* [XID] */ /* 0x000000018961B8A0-0x000000018961B8C0 */ set {} } // 0x0000000186316B10-0x0000000186316C80
	
		// Constructors
		public MonoActivityFlightChallengeButton() {} // 0x00000001863165B0-0x0000000186316640
	
		// Methods
		// [XID] // 0x00000001895E7050-0x00000001895E7070
		public void SetMedal(int lv) {} // 0x00000001863161F0-0x0000000186316330
		// [XID] // 0x00000001895EE9A0-0x00000001895EE9C0
		public void SetOpenState(bool isOpen) {} // 0x0000000186316330-0x0000000186316430
		// [XID] // 0x00000001895F6380-0x00000001895F63A0
		public void SetComplete(bool isComplete) {} // 0x0000000186316050-0x0000000186316130
		// [XID] // 0x00000001895FD6B0-0x00000001895FD6D0
		public void SetSelectedState(bool selected) {} // 0x0000000186316430-0x00000001863165B0
		// [XID] // 0x0000000189613EB0-0x0000000189613ED0
		public void SetFocus(bool focus) {} // 0x0000000186316130-0x00000001863161F0
	}
}
