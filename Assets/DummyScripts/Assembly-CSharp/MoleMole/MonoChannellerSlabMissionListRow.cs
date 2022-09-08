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
	public class MonoChannellerSlabMissionListRow : MonoBehaviour, IJoypadSelect // TypeDefIndex: 30045
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _missionDesc; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _missionProgress; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _completeMaskTrans; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _completeTrans; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _inProgressTrans; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _receiveTrans; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _rewardList; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _actionBtn; // 0x58
		private bool _bSetSelected; // 0x64
		private bool _isToSelected; // 0x65
		private bool _hightlighted; // 0x66
	
		// Properties
		public UnityEngine.UI.Text missionDesc { /* [XID] */ /* 0x00000001898DD940-0x00000001898DD960 */ get => default; } // 0x000000018480A620-0x000000018480A6C0 
		public UnityEngine.UI.Text missionProgress { /* [XID] */ /* 0x00000001898E51D0-0x00000001898E51F0 */ get => default; } // 0x000000018480A6C0-0x000000018480A760 
		public MonoSimpleReusableList rewardList { /* [XID] */ /* 0x00000001898EC9C0-0x00000001898EC9E0 */ get => default; } // 0x000000018480A760-0x000000018480A800 
		public MonoUIContainer actionBtn { /* [XID] */ /* 0x00000001898F43B0-0x00000001898F43D0 */ get => default; } // 0x000000018480A4E0-0x000000018480A580 
		public EProgressState ProgressState { /* [XID] */ /* 0x00000001898FBB80-0x00000001898FBBC0 */ get; /* [XID] */ /* 0x0000000189906320-0x0000000189906360 */ private set; } // 0x000000018480A480-0x000000018480A4E0 0x0000000184809F70-0x0000000184809FD0
		public bool highlight { /* [XID] */ /* 0x000000018992EDE0-0x000000018992EE00 */ get => default; /* [XID] */ /* 0x0000000189936210-0x0000000189936230 */ set {} } // 0x000000018480A580-0x000000018480A620 0x000000018480A800-0x000000018480A9A0
	
		// Nested types
		public enum EProgressState // TypeDefIndex: 30046
		{
			CanTake = 0,
			CanNotTaken = 1,
			Taken = 2
		}
	
		// Constructors
		public MonoChannellerSlabMissionListRow() {} // 0x000000018480A3F0-0x000000018480A480
	
		// Methods
		// [XID] // 0x00000001899109A0-0x00000001899109C0
		public void SetState(EProgressState tState) {} // 0x000000018480A160-0x000000018480A2D0
		// [XID] // 0x00000001899185E0-0x0000000189918600
		private void Update() {} // 0x000000018480A2D0-0x000000018480A3F0
		// [XID] // 0x000000018991FDE0-0x000000018991FE00
		private void OnDisable() {} // 0x0000000184809FD0-0x000000018480A070
		// [XID] // 0x0000000189927680-0x00000001899276A0
		public void SetSelected(bool bSelected) {} // 0x000000018480A070-0x000000018480A160
	}
}
