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
	public class MonoActivityTreasureHuntButton : MonoSpriteProxy // TypeDefIndex: 30360
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _titleText; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selectedArrow; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _completeTrans; // 0x30
		// [Header] // 0x00000001899A41E0-0x00000001899A4220
		[SerializeField] // 0x00000001899A41E0-0x00000001899A4220
		private GameObject _statusOpen; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _statusNormal; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _statusLock; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _statusBattle; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _statusBattleClose; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _statusBattleOpen; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _statusBattleCloseSelected; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _statusBattleOpenSelected; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected Button _actionButton; // 0x78
		private bool _hightlighted; // 0x80
	
		// Properties
		public Button actionButton { /* [XID] */ /* 0x00000001899EBAE0-0x00000001899EBB00 */ get => default; } // 0x00000001852E6910-0x00000001852E69B0 
		public UnityEngine.UI.Text titleText { /* [XID] */ /* 0x00000001899F35F0-0x00000001899F3610 */ get => default; } // 0x00000001852E6A60-0x00000001852E6B00 
		public bool highlight { /* [XID] */ /* 0x0000000189A1FC00-0x0000000189A1FC20 */ get => default; /* [XID] */ /* 0x0000000189A26F50-0x0000000189A26F70 */ set {} } // 0x00000001852E69B0-0x00000001852E6A60 0x00000001852E6B00-0x00000001852E6D50
		public bool selected_Arrow { /* [XID] */ /* 0x0000000189A360C0-0x0000000189A360E0 */ set {} } // 0x00000001852E6D50-0x00000001852E6ED0
	
		// Constructors
		public MonoActivityTreasureHuntButton() {} // 0x00000001852E6870-0x00000001852E6910
	
		// Methods
		// [XID] // 0x00000001899FAF50-0x00000001899FAF70
		public void SetButoonInteractable(bool interactable) {} // 0x00000001852E60E0-0x00000001852E6200
		// [XID] // 0x0000000189A021A0-0x0000000189A021C0
		public void SetBattleStatus(bool isOpen) {} // 0x00000001852E5FA0-0x00000001852E60E0
		// [XID] // 0x0000000189A09990-0x0000000189A099B0
		public void SetStatus(TreasureHuntButtonStatus status) {} // 0x00000001852E6530-0x00000001852E6870
		// [XID] // 0x0000000189A110F0-0x0000000189A11110
		public void SetComplete(bool isComplete) {} // 0x00000001852E6200-0x00000001852E62F0
		// [XID] // 0x0000000189A184A0-0x0000000189A184C0
		public void SetSelectedState(bool selected) {} // 0x00000001852E63B0-0x00000001852E6530
		// [XID] // 0x0000000189A2E770-0x0000000189A2E790
		public void SetFocus(bool focus) {} // 0x00000001852E62F0-0x00000001852E63B0
	}
}
