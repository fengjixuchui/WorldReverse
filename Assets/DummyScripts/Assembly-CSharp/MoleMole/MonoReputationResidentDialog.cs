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
	public class MonoReputationResidentDialog : MonoUIProxy // TypeDefIndex: 30576
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _rewardScroller; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _desc; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _author; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpCompleted; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _freeClickBtn; // 0x70
	
		// Properties
		public MonoGridScroller rewardScroller { /* [XID] */ /* 0x0000000189853330-0x0000000189853350 */ get => default; } // 0x000000018443D450-0x000000018443D4F0 
		public string title { /* [XID] */ /* 0x000000018985ADC0-0x000000018985ADE0 */ set {} } // 0x000000018443DB20-0x000000018443DBF0
		public string desc { /* [XID] */ /* 0x0000000189862280-0x00000001898622A0 */ set {} } // 0x000000018443D7A0-0x000000018443D880
		public string author { /* [XID] */ /* 0x0000000189869730-0x0000000189869750 */ set {} } // 0x000000018443D6D0-0x000000018443D7A0
		public Button freeClickBtn { /* [XID] */ /* 0x0000000189870930-0x0000000189870950 */ get => default; } // 0x000000018443D3B0-0x000000018443D450 
		public MonoUIContainer BtnGoto { /* [XID] */ /* 0x00000001898783C0-0x00000001898783E0 */ get => default; } // 0x000000018443D170-0x000000018443D230 
		public MonoUIContainer BtnClose { /* [XID] */ /* 0x000000018987F8D0-0x000000018987F8F0 */ get => default; } // 0x000000018443CF30-0x000000018443CFF0 
		public MonoUIContainer BtnSwitchPrev { /* [XID] */ /* 0x0000000189886F20-0x0000000189886F40 */ get => default; } // 0x000000018443D2F0-0x000000018443D3B0 
		public MonoUIContainer BtnSwitchNext { /* [XID] */ /* 0x000000018988E0B0-0x000000018988E0D0 */ get => default; } // 0x000000018443D230-0x000000018443D2F0 
		public MonoUIContainer BtnDetail { /* [XID] */ /* 0x0000000189895700-0x0000000189895720 */ get => default; } // 0x000000018443CFF0-0x000000018443D0B0 
		public MonoUIContainer BtnAccept { /* [XID] */ /* 0x000000018989CE40-0x000000018989CE60 */ get => default; } // 0x000000018443CE70-0x000000018443CF30 
		public MonoUIContainer BtnGiveup { /* [XID] */ /* 0x00000001898A4600-0x00000001898A4620 */ get => default; } // 0x000000018443D0B0-0x000000018443D170 
		public bool ShowBtnSwitchPrev { /* [XID] */ /* 0x00000001898ABAC0-0x00000001898ABAE0 */ set {} } // 0x000000018443D5E0-0x000000018443D6D0
		public bool ShowBtnSwitchNext { /* [XID] */ /* 0x00000001898B3270-0x00000001898B3290 */ set {} } // 0x000000018443D4F0-0x000000018443D5E0
		public RewardState rewardState { /* [XID] */ /* 0x00000001898BAF70-0x00000001898BAF90 */ set {} } // 0x000000018443D880-0x000000018443DB20
	
		// Constructors
		public MonoReputationResidentDialog() {} // 0x000000018443CDF0-0x000000018443CE70
	}
}
