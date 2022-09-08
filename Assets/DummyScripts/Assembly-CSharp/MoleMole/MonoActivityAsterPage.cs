/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoActivityAsterPage : MonoUIProxy // TypeDefIndex: 31145
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _titleSmall; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _timeDesc; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _timeDesc2; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoActivityAsterPage_Little _monoLittle; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoActivityAsterPage_Middle _monoMiddle; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoActivityAsterPage_Large _monoLarge; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<MonoUIContainer> _mainBtnList; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _coinRoot; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _tabSwitch; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _enterTime; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _backMainTime; // 0x9C
	
		// Properties
		public float enterTime { /* [XID] */ /* 0x0000000189A41E60-0x0000000189A41E80 */ get => default; } // 0x0000000184C76B00-0x0000000184C76BB0 
		public float backMainTime { /* [XID] */ /* 0x0000000189A49430-0x0000000189A49450 */ get => default; } // 0x0000000184C769A0-0x0000000184C76A50 
		public Transform coinRoot { /* [XID] */ /* 0x0000000189A50D80-0x0000000189A50DA0 */ get => default; } // 0x0000000184C76A50-0x0000000184C76B00 
		public bool ShowTabSwitch { /* [XID] */ /* 0x0000000189A582A0-0x0000000189A582C0 */ set {} } // 0x0000000184C76E40-0x0000000184C76F30
		public string timeDesc { /* [XID] */ /* 0x0000000189A5FD80-0x0000000189A5FDA0 */ set {} } // 0x0000000184C77000-0x0000000184C770D0
		public string timeDesc2 { /* [XID] */ /* 0x0000000189A67A20-0x0000000189A67A40 */ set {} } // 0x0000000184C76F30-0x0000000184C77000
		public string title { /* [XID] */ /* 0x0000000189A6EE30-0x0000000189A6EE50 */ set {} } // 0x0000000184C771A0-0x0000000184C77270
		public string titleSmall { /* [XID] */ /* 0x0000000189A76630-0x0000000189A76650 */ set {} } // 0x0000000184C770D0-0x0000000184C771A0
		public MonoActivityAsterPage_Little monoLittle { /* [XID] */ /* 0x0000000189A7DFA0-0x0000000189A7DFC0 */ get => default; } // 0x0000000184C76D00-0x0000000184C76DA0 
		public MonoActivityAsterPage_Middle monoMiddle { /* [XID] */ /* 0x0000000189A85920-0x0000000189A85940 */ get => default; } // 0x0000000184C76DA0-0x0000000184C76E40 
		public MonoActivityAsterPage_Large monoLarge { /* [XID] */ /* 0x0000000189A8D200-0x0000000189A8D220 */ get => default; } // 0x0000000184C76C60-0x0000000184C76D00 
		public List<MonoUIContainer> mainBtnList { /* [XID] */ /* 0x0000000189A94740-0x0000000189A94760 */ get => default; } // 0x0000000184C76BB0-0x0000000184C76C60 
		public MonoUIContainer BtnClose { /* [XID] */ /* 0x0000000189A9C020-0x0000000189A9C040 */ get => default; } // 0x0000000184C760A0-0x0000000184C76160 
		public MonoUIContainer BtnBack { /* [XID] */ /* 0x0000000189AA36D0-0x0000000189AA36F0 */ get => default; } // 0x0000000184C75FE0-0x0000000184C760A0 
		public MonoUIContainer BtnShop { /* [XID] */ /* 0x0000000189AAAD70-0x0000000189AAAD90 */ get => default; } // 0x0000000184C76760-0x0000000184C76820 
		public MonoUIContainer BtnExtraTask { /* [XID] */ /* 0x0000000189AB2720-0x0000000189AB2740 */ get => default; } // 0x0000000184C76220-0x0000000184C762E0 
		public MonoUIContainer BtnReward { /* [XID] */ /* 0x0000000189ABA1F0-0x0000000189ABA210 */ get => default; } // 0x0000000184C766A0-0x0000000184C76760 
		public MonoUIContainer BtnExplain { /* [XID] */ /* 0x0000000189AC1B00-0x0000000189AC1B20 */ get => default; } // 0x0000000184C76160-0x0000000184C76220 
		public MonoUIContainer BtnSwitchPrev { /* [XID] */ /* 0x0000000189AC9090-0x0000000189AC90B0 */ get => default; } // 0x0000000184C768E0-0x0000000184C769A0 
		public MonoUIContainer BtnSwitchNext { /* [XID] */ /* 0x0000000189AD0AE0-0x0000000189AD0B00 */ get => default; } // 0x0000000184C76820-0x0000000184C768E0 
		public MonoUIContainer BtnReturn_0_PS4 { /* [XID] */ /* 0x0000000189AD8700-0x0000000189AD8720 */ get => default; } // 0x0000000184C763A0-0x0000000184C76460 
		public MonoUIContainer BtnReturn_1_PS4 { /* [XID] */ /* 0x0000000189AE0360-0x0000000189AE0380 */ get => default; } // 0x0000000184C76460-0x0000000184C76520 
		public MonoUIContainer BtnReturn_2_PS4 { /* [XID] */ /* 0x0000000189AE7910-0x0000000189AE7930 */ get => default; } // 0x0000000184C76520-0x0000000184C765E0 
		public MonoUIContainer BtnReturn_3_PS4 { /* [XID] */ /* 0x0000000189AEF5F0-0x0000000189AEF610 */ get => default; } // 0x0000000184C765E0-0x0000000184C766A0 
		public MonoUIContainer BtnOK_0_PS4 { /* [XID] */ /* 0x0000000189AF6AD0-0x0000000189AF6AF0 */ get => default; } // 0x0000000184C762E0-0x0000000184C763A0 
	
		// Constructors
		public MonoActivityAsterPage() {} // 0x0000000184C75F30-0x0000000184C75FE0
	}
}
