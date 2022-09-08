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
	public class MonoVersusBattle : MonoBehaviour // TypeDefIndex: 31285
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Animator _animator; // 0x18
		// [Header] // 0x0000000189AC1A50-0x0000000189AC1AA0
		[SerializeField] // 0x0000000189AC1A50-0x0000000189AC1AA0
		private UnityEngine.UI.Text _leftProgressLabel; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _leftDeltaLabel; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _leftTitleLabel; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Slider _leftSlider; // 0x38
		// [Header] // 0x0000000189AE2FF0-0x0000000189AE3040
		[SerializeField] // 0x0000000189AE2FF0-0x0000000189AE3040
		private UnityEngine.UI.Text _rightProgressLabel; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rightDeltaLabel; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rightTitleLabel; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Slider _rightSlider; // 0x58
	
		// Properties
		public string leftProgressText { /* [XID] */ /* 0x0000000189B03FD0-0x0000000189B03FF0 */ set {} } // 0x000000018249E3D0-0x000000018249E4A0
		public string leftDelta { /* [XID] */ /* 0x0000000189B0B890-0x0000000189B0B8B0 */ set {} } // 0x000000018249E300-0x000000018249E3D0
		public string leftTitle { /* [XID] */ /* 0x0000000189B12DC0-0x0000000189B12DE0 */ set {} } // 0x000000018249E570-0x000000018249E640
		public float leftProgress { /* [XID] */ /* 0x0000000189B1A450-0x0000000189B1A470 */ set {} } // 0x000000018249E4A0-0x000000018249E570
		public string rightProgressText { /* [XID] */ /* 0x0000000189B21950-0x0000000189B21970 */ set {} } // 0x000000018249E710-0x000000018249E7E0
		public string rightDelta { /* [XID] */ /* 0x0000000189B29080-0x0000000189B290A0 */ set {} } // 0x000000018249E640-0x000000018249E710
		public string rightTitle { /* [XID] */ /* 0x0000000189B304B0-0x0000000189B304D0 */ set {} } // 0x000000018249E8B0-0x000000018249E980
		public float rightProgress { /* [XID] */ /* 0x0000000189B37DD0-0x0000000189B37DF0 */ set {} } // 0x000000018249E7E0-0x000000018249E8B0
	
		// Constructors
		public MonoVersusBattle() {} // 0x000000018249E270-0x000000018249E300
	
		// Methods
		// [XID] // 0x0000000189B3F700-0x0000000189B3F720
		public void SetStart() {} // 0x000000018249DF40-0x000000018249E030
		// [XID] // 0x0000000189B470A0-0x0000000189B470C0
		public void TriggerAddLeft() {} // 0x000000018249E030-0x000000018249E0E0
		// [XID] // 0x0000000189B4E7A0-0x0000000189B4E7C0
		public void TriggerAddRight() {} // 0x000000018249E0E0-0x000000018249E190
		// [XID] // 0x0000000189B56000-0x0000000189B56020
		public void TriggerFadeout() {} // 0x000000018249E190-0x000000018249E270
		// [XID] // 0x0000000189B5D8E0-0x0000000189B5D900
		private void OnDisable() {} // 0x000000018249DDB0-0x000000018249DF40
	}
}
