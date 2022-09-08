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
	public class MonoMechanicusDifficultItem : MonoReusableListItem // TypeDefIndex: 31128
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionButton; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _text; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _checkMark; // 0x38
		private bool isLocked; // 0x40
	
		// Properties
		public Button actionButton { /* [XID] */ /* 0x00000001896FC950-0x00000001896FC970 */ get => default; } // 0x0000000184939CF0-0x0000000184939D90 
		public string diffcultText { /* [XID] */ /* 0x0000000189703E30-0x0000000189703E50 */ set {} } // 0x0000000184939E90-0x0000000184939F70
		public bool selected { /* [XID] */ /* 0x000000018970B710-0x000000018970B730 */ set {} } // 0x000000018493A080-0x000000018493A170
		public bool locked { /* [XID] */ /* 0x0000000189712F90-0x0000000189712FB0 */ set {} } // 0x0000000184939F70-0x000000018493A080
		public bool HighLighted { /* [XID] */ /* 0x00000001897291C0-0x00000001897291E0 */ set {} } // 0x0000000184939D90-0x0000000184939E90
	
		// Constructors
		public MonoMechanicusDifficultItem() {} // 0x0000000184939C70-0x0000000184939CF0
	
		// Methods
		// [XID] // 0x000000018971A810-0x000000018971A830
		public void SetDifficult(MechanicusDifficultyExcelConfig config) {} // 0x0000000184939970-0x0000000184939C70
		// [XID] // 0x0000000189721B90-0x0000000189721BB0
		private void OnEnable() {} // 0x0000000184939880-0x0000000184939970
	}
}
