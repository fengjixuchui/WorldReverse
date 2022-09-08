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
	public class MonoActivityAsterPage_Middle : MonoBehaviour // TypeDefIndex: 31148
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpNotOpen; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpMission; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _tabTitleDesc; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _tabDesc; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _taskScroller; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _lockTitle; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _lockDesc; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _intro; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _curCountText; // 0x60
	
		// Properties
		public bool ShowNotOpenGrp { /* [XID] */ /* 0x00000001897144D0-0x00000001897144F0 */ set {} } // 0x0000000184C75910-0x0000000184C75A00
		public bool ShowMissionGrp { /* [XID] */ /* 0x000000018971BF10-0x000000018971BF30 */ set {} } // 0x0000000184C75820-0x0000000184C75910
		public string tabTitleDesc { /* [XID] */ /* 0x0000000189723420-0x0000000189723440 */ set {} } // 0x0000000184C75E50-0x0000000184C75F30
		public string tabDesc { /* [XID] */ /* 0x000000018972AB40-0x000000018972AB60 */ set {} } // 0x0000000184C75D70-0x0000000184C75E50
		public string curCountText { /* [XID] */ /* 0x0000000189732270-0x0000000189732290 */ set {} } // 0x0000000184C75A00-0x0000000184C75AD0
		public MonoGridScroller taskScroller { /* [XID] */ /* 0x0000000189739940-0x0000000189739960 */ get => default; } // 0x0000000184C75780-0x0000000184C75820 
		public string intro { /* [XID] */ /* 0x00000001897414B0-0x00000001897414D0 */ set {} } // 0x0000000184C75AD0-0x0000000184C75BB0
		public string lockTitle { /* [XID] */ /* 0x0000000189748DE0-0x0000000189748E00 */ set {} } // 0x0000000184C75C90-0x0000000184C75D70
		public string lockDesc { /* [XID] */ /* 0x0000000189750270-0x0000000189750290 */ set {} } // 0x0000000184C75BB0-0x0000000184C75C90
		public MonoUIContainer BtnGotoTask_2 { /* [XID] */ /* 0x0000000189757850-0x0000000189757870 */ get => default; } // 0x0000000184C75600-0x0000000184C756C0 
		public MonoUIContainer BtnGotoCollect_2 { /* [XID] */ /* 0x000000018975F230-0x000000018975F250 */ get => default; } // 0x0000000184C75540-0x0000000184C75600 
		public MonoUIContainer BtnCourse_2 { /* [XID] */ /* 0x0000000189766650-0x0000000189766670 */ get => default; } // 0x0000000184C75480-0x0000000184C75540 
		public MonoUIContainer BtnReceive_2 { /* [XID] */ /* 0x000000018976DCF0-0x000000018976DD10 */ get => default; } // 0x0000000184C756C0-0x0000000184C75780 
		public MonoUIContainer BtnAttribute_2 { /* [XID] */ /* 0x0000000189775400-0x0000000189775420 */ get => default; } // 0x0000000184C753C0-0x0000000184C75480 
	
		// Constructors
		public MonoActivityAsterPage_Middle() {} // 0x0000000184C75330-0x0000000184C753C0
	
		// Methods
		// [XID] // 0x000000018977CC70-0x000000018977CC90
		public void SetGrpState(bool isOpen) {} // 0x0000000184C75260-0x0000000184C75330
	}
}
