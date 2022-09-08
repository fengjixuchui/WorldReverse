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
	public class MonoActivityDragonSpineListRow : MonoBehaviour // TypeDefIndex: 30331
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _missionDesc; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _missionProgress; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _completeTrans; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _completeMaskTrans; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _inProgressTrans; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _receiveTrans; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _rewardList; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _actionBtn; // 0x58
		private bool _bSetSelected; // 0x60
		private bool _isToSelected; // 0x61
		private bool _hightlighted; // 0x62
	
		// Properties
		public UnityEngine.UI.Text missionDesc { /* [XID] */ /* 0x0000000189970BD0-0x0000000189970BF0 */ get => default; } // 0x000000018630FB10-0x000000018630FBB0 
		public UnityEngine.UI.Text missionProgress { /* [XID] */ /* 0x0000000189978550-0x0000000189978570 */ get => default; } // 0x000000018630FBB0-0x000000018630FC50 
		public MonoSimpleReusableList rewardList { /* [XID] */ /* 0x000000018997F630-0x000000018997F650 */ get => default; } // 0x000000018630FC50-0x000000018630FCF0 
		public MonoUIContainer actionBtn { /* [XID] */ /* 0x0000000189986F80-0x0000000189986FA0 */ get => default; } // 0x000000018630F9D0-0x000000018630FA70 
		public bool highlight { /* [XID] */ /* 0x00000001899AD1F0-0x00000001899AD210 */ get => default; /* [XID] */ /* 0x00000001899B49D0-0x00000001899B49F0 */ set {} } // 0x000000018630FA70-0x000000018630FB10 0x000000018630FCF0-0x000000018630FE90
	
		// Nested types
		public enum EProgressState // TypeDefIndex: 30332
		{
			CanTake = 0,
			CanNotTaken = 1,
			Taken = 2
		}
	
		// Constructors
		public MonoActivityDragonSpineListRow() {} // 0x000000018630F940-0x000000018630F9D0
	
		// Methods
		// [XID] // 0x000000018998EA70-0x000000018998EA90
		public void SetState(EProgressState tState) {} // 0x000000018630F6F0-0x000000018630F820
		// [XID] // 0x0000000189996670-0x0000000189996690
		private void Update() {} // 0x000000018630F820-0x000000018630F940
		// [XID] // 0x000000018999E150-0x000000018999E170
		private void OnDisable() {} // 0x000000018630F560-0x000000018630F600
		// [XID] // 0x00000001899A5B10-0x00000001899A5B30
		public void SetSelectedState(bool selected) {} // 0x000000018630F600-0x000000018630F6F0
	}
}
