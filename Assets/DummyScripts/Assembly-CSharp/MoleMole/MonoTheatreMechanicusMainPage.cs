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
	public class MonoTheatreMechanicusMainPage : MonoUIProxy // TypeDefIndex: 31279
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _nextStageTips; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _desc; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _maxDifficultLevelText; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _maxGearLevelText; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _maxMoneyCountText; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _rewardList; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _costItemCountText; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _costItemCountTextPS4; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _costItemIcon; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _costItemIconPS4; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<MonoUIContainer> _sectionList; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _missionScroller; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _missionLockedObj; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _coinRoot; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _unlockTips; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _toPreTab; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _nexyPreTab; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoJoypadSimpleResuableListHandler _rewardHandler; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoJoypadGridScrollerHandler _watcherHandler; // 0xE0
	
		// Properties
		public string title { /* [XID] */ /* 0x00000001897CE8E0-0x00000001897CE900 */ set {} } // 0x0000000183B70F70-0x0000000183B71050
		public string nextStageTips { /* [XID] */ /* 0x00000001897D60C0-0x00000001897D60E0 */ set {} } // 0x0000000183B70E90-0x0000000183B70F70
		public string desc { /* [XID] */ /* 0x00000001897DD960-0x00000001897DD980 */ set {} } // 0x0000000183B70B10-0x0000000183B70BF0
		public string maxDifficultLevelText { /* [XID] */ /* 0x00000001897E5290-0x00000001897E52B0 */ set {} } // 0x0000000183B70BF0-0x0000000183B70CD0
		public string maxGearLevelText { /* [XID] */ /* 0x00000001897ECE50-0x00000001897ECE70 */ set {} } // 0x0000000183B70CD0-0x0000000183B70DB0
		public string maxMoneyCountText { /* [XID] */ /* 0x00000001897F4670-0x00000001897F4690 */ set {} } // 0x0000000183B70DB0-0x0000000183B70E90
		public string costItemCountText { /* [XID] */ /* 0x00000001897FC060-0x00000001897FC080 */ set {} } // 0x0000000183B708C0-0x0000000183B709C0
		public string costItemIcon { /* [XID] */ /* 0x00000001898034F0-0x0000000189803510 */ set {} } // 0x0000000183B709C0-0x0000000183B70B10
		public MonoSimpleReusableList rewardList { /* [XID] */ /* 0x000000018980AAE0-0x000000018980AB00 */ get => default; } // 0x0000000183B70560-0x0000000183B70600 
		public List<MonoUIContainer> sectionList { /* [XID] */ /* 0x00000001898120F0-0x0000000189812110 */ get => default; } // 0x0000000183B70600-0x0000000183B706B0 
		public MonoGridScroller missionScroller { /* [XID] */ /* 0x0000000189819CA0-0x0000000189819CC0 */ get => default; } // 0x0000000183B70400-0x0000000183B704B0 
		public Transform coinRoot { /* [XID] */ /* 0x0000000189821520-0x0000000189821540 */ get => default; } // 0x0000000183B70350-0x0000000183B70400 
		public MonoUIContainer toPreTab { /* [XID] */ /* 0x0000000189828B10-0x0000000189828B30 */ get => default; } // 0x0000000183B70760-0x0000000183B70810 
		public MonoUIContainer toNextTab { /* [XID] */ /* 0x000000018982FF00-0x000000018982FF20 */ get => default; } // 0x0000000183B706B0-0x0000000183B70760 
		public MonoJoypadSimpleResuableListHandler rewardHandler { /* [XID] */ /* 0x0000000189837640-0x0000000189837660 */ get => default; } // 0x0000000183B704B0-0x0000000183B70560 
		public MonoJoypadGridScrollerHandler watcherHandler { /* [XID] */ /* 0x000000018983ED30-0x000000018983ED50 */ get => default; } // 0x0000000183B70810-0x0000000183B708C0 
		public string unlockTips { /* [XID] */ /* 0x000000018984D960-0x000000018984D980 */ set {} } // 0x0000000183B71050-0x0000000183B71130
		public MonoUIContainer BtnReturn { /* [XID] */ /* 0x00000001898549C0-0x00000001898549E0 */ get => default; } // 0x0000000183B70290-0x0000000183B70350 
		public MonoUIContainer BtnFetch { /* [XID] */ /* 0x000000018985C240-0x000000018985C260 */ get => default; } // 0x0000000183B6FE10-0x0000000183B6FED0 
		public MonoUIContainer BtnGoto { /* [XID] */ /* 0x0000000189863BA0-0x0000000189863BC0 */ get => default; } // 0x0000000183B6FF90-0x0000000183B70050 
		public MonoUIContainer BtnCheck { /* [XID] */ /* 0x000000018986AE70-0x000000018986AE90 */ get => default; } // 0x0000000183B6FD50-0x0000000183B6FE10 
		public MonoUIContainer BtnInstruction { /* [XID] */ /* 0x0000000189872260-0x0000000189872280 */ get => default; } // 0x0000000183B701D0-0x0000000183B70290 
		public MonoUIContainer BtnInfo { /* [XID] */ /* 0x0000000189879EF0-0x0000000189879F10 */ get => default; } // 0x0000000183B70110-0x0000000183B701D0 
		public MonoUIContainer BtnGadget { /* [XID] */ /* 0x0000000189881030-0x0000000189881050 */ get => default; } // 0x0000000183B6FED0-0x0000000183B6FF90 
		public MonoUIContainer BtnHandBook { /* [XID] */ /* 0x0000000189888620-0x0000000189888640 */ get => default; } // 0x0000000183B70050-0x0000000183B70110 
	
		// Constructors
		public MonoTheatreMechanicusMainPage() {} // 0x0000000183B6FC70-0x0000000183B6FD50
	
		// Methods
		// [XID] // 0x0000000189846370-0x0000000189846390
		public void SetMissionLockState(bool isLocked) {} // 0x0000000183B6FB80-0x0000000183B6FC70
	}
}
