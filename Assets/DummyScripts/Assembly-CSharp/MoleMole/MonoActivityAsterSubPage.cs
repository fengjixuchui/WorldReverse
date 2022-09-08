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
	public class MonoActivityAsterSubPage : MonoUIProxy // TypeDefIndex: 31149
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _timeDesc; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _desc; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _scrollDesc; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _rewardList; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockTipsGrp; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _unLockTipsText; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _bgGrpQuestUnFinished; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _bgGrpQuestFinished; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _coinRoot; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _bgGrpUp; // 0x98
	
		// Properties
		public Transform coinRoot { /* [XID] */ /* 0x00000001897DF1C0-0x00000001897DF1E0 */ get => default; } // 0x0000000184C77C60-0x0000000184C77D10 
		public ScrollRect scrollDesc { /* [XID] */ /* 0x00000001897E6A60-0x00000001897E6A80 */ get => default; } // 0x0000000184C77E50-0x0000000184C77EF0 
		public GameObject bgGrpUp { /* [XID] */ /* 0x00000001897EE590-0x00000001897EE5B0 */ get => default; } // 0x0000000184C77BB0-0x0000000184C77C60 
		public string timeDesc { /* [XID] */ /* 0x00000001897F5DE0-0x00000001897F5E00 */ set {} } // 0x0000000184C77FD0-0x0000000184C780A0
		public string Desc { /* [XID] */ /* 0x00000001897FD540-0x00000001897FD560 */ set {} } // 0x0000000184C77EF0-0x0000000184C77FD0
		public string title { /* [XID] */ /* 0x0000000189804AA0-0x0000000189804AC0 */ set {} } // 0x0000000184C780A0-0x0000000184C78170
		public string unLockTipsText { /* [XID] */ /* 0x000000018980C0F0-0x000000018980C110 */ set {} } // 0x0000000184C78170-0x0000000184C78240
		public MonoGridScroller rewardScroller { /* [XID] */ /* 0x00000001898137E0-0x0000000189813800 */ get => default; } // 0x0000000184C77DB0-0x0000000184C77E50 
		public GameObject lockTipsGrp { /* [XID] */ /* 0x000000018981B390-0x000000018981B3B0 */ get => default; } // 0x0000000184C77D10-0x0000000184C77DB0 
		public MonoUIContainer BtnGoto { /* [XID] */ /* 0x00000001898229A0-0x00000001898229C0 */ get => default; } // 0x0000000184C77970-0x0000000184C77A30 
		public MonoUIContainer BtnExit { /* [XID] */ /* 0x000000018982A350-0x000000018982A370 */ get => default; } // 0x0000000184C778B0-0x0000000184C77970 
		public MonoUIContainer BtnBack { /* [XID] */ /* 0x0000000189831610-0x0000000189831630 */ get => default; } // 0x0000000184C77730-0x0000000184C777F0 
		public MonoUIContainer BtnOK { /* [XID] */ /* 0x0000000189838CC0-0x0000000189838CE0 */ get => default; } // 0x0000000184C77A30-0x0000000184C77AF0 
		public MonoUIContainer BtnShop { /* [XID] */ /* 0x0000000189840380-0x00000001898403A0 */ get => default; } // 0x0000000184C77AF0-0x0000000184C77BB0 
		public MonoUIContainer BtnDesc { /* [XID] */ /* 0x0000000189847930-0x0000000189847950 */ get => default; } // 0x0000000184C777F0-0x0000000184C778B0 
		public MonoUIContainer BtnAttribute { /* [XID] */ /* 0x000000018984F0A0-0x000000018984F0C0 */ get => default; } // 0x0000000184C77670-0x0000000184C77730 
	
		// Constructors
		public MonoActivityAsterSubPage() {} // 0x0000000184C775D0-0x0000000184C77670
	
		// Methods
		// [XID] // 0x00000001898561A0-0x00000001898561C0
		public void ShowBgByQuestFinished(bool isFinished) {} // 0x0000000184C774C0-0x0000000184C775D0
	}
}
