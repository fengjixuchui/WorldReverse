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
	public class MonoActivityCrucible : MonoBehaviour // TypeDefIndex: 31155
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _activityTime; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _desc; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpDesc; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpSettlement; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpTips; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _tipsText; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _bestTime; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnReward; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnDescription; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<FriendAssistInfo> _assistList; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _assistDesc; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _scrollRect; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _worldLevel; // 0x88
	
		// Properties
		public bool showGrpDesc { /* [XID] */ /* 0x0000000189B6DC20-0x0000000189B6DC40 */ set {} } // 0x000000018630DB10-0x000000018630DC00
		public bool showGrpSettlement { /* [XID] */ /* 0x0000000189B752D0-0x0000000189B752F0 */ set {} } // 0x000000018630DC00-0x000000018630DCF0
		public bool showGrpTips { /* [XID] */ /* 0x0000000189B7C6E0-0x0000000189B7C700 */ set {} } // 0x000000018630DCF0-0x000000018630DDE0
		public UnityEngine.UI.Text tipsText { /* [XID] */ /* 0x0000000189B844E0-0x0000000189B84500 */ get => default; } // 0x000000018630D720-0x000000018630D7C0 
		public string tittle { /* [XID] */ /* 0x0000000189B8B390-0x0000000189B8B3B0 */ set {} } // 0x000000018630DDE0-0x000000018630DEB0
		public string worldLevel { /* [XID] */ /* 0x0000000189B92B40-0x0000000189B92B60 */ set {} } // 0x000000018630DEB0-0x000000018630DF80
		public string activityTime { /* [XID] */ /* 0x0000000189B9A080-0x0000000189B9A0A0 */ set {} } // 0x000000018630D7C0-0x000000018630D890
		public string desc { /* [XID] */ /* 0x0000000189BA17C0-0x0000000189BA17E0 */ set {} } // 0x000000018630DA30-0x000000018630DB10
		public string bestTime { /* [XID] */ /* 0x0000000189BA8C10-0x0000000189BA8C30 */ set {} } // 0x000000018630D960-0x000000018630DA30
		public string assistDesc { /* [XID] */ /* 0x0000000189BB0340-0x0000000189BB0360 */ set {} } // 0x000000018630D890-0x000000018630D960
		public ScrollRect scrollDesc { /* [XID] */ /* 0x0000000189BB7780-0x0000000189BB77A0 */ get => default; } // 0x000000018630D670-0x000000018630D720 
		public List<FriendAssistInfo> assistList { /* [XID] */ /* 0x0000000189BBEE00-0x0000000189BBEE20 */ get => default; } // 0x000000018630D5D0-0x000000018630D670 
		public MonoUIContainer BtnGoto { /* [XID] */ /* 0x0000000189BC6AD0-0x0000000189BC6AF0 */ get => default; } // 0x000000018630CD60-0x000000018630CEF0 
		public MonoUIContainer BtnST { /* [XID] */ /* 0x0000000189BCE7E0-0x0000000189BCE800 */ get => default; } // 0x000000018630D2B0-0x000000018630D440 
		public MonoUIContainer BtnTask { /* [XID] */ /* 0x0000000189BD5A60-0x0000000189BD5A80 */ get => default; } // 0x000000018630D440-0x000000018630D5D0 
		public MonoUIContainer BtnExit { /* [XID] */ /* 0x0000000189BDD6A0-0x0000000189BDD6C0 */ get => default; } // 0x000000018630CBD0-0x000000018630CD60 
		public MonoUIContainer BtnBack { /* [XID] */ /* 0x00000001895EA270-0x00000001895EA290 */ get => default; } // 0x000000018630C9A0-0x000000018630CB30 
		public MonoUIContainer BtnOK { /* [XID] */ /* 0x00000001895F16F0-0x00000001895F1710 */ get => default; } // 0x000000018630CEF0-0x000000018630D080 
		public MonoUIContainer BtnPlayerDetail { /* [XID] */ /* 0x00000001895F9150-0x00000001895F9170 */ get => default; } // 0x000000018630D080-0x000000018630D210 
		public MonoUIContainer BtnReward { /* [XID] */ /* 0x0000000189600760-0x0000000189600780 */ get => default; } // 0x000000018630D210-0x000000018630D2B0 
		public MonoUIContainer BtnDescription { /* [XID] */ /* 0x00000001896080A0-0x00000001896080C0 */ get => default; } // 0x000000018630CB30-0x000000018630CBD0 
	
		// Constructors
		public MonoActivityCrucible() {} // 0x000000018630C930-0x000000018630C9A0
	}
}
