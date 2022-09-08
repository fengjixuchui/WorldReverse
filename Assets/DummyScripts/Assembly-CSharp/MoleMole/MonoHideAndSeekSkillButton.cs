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
	public class MonoHideAndSeekSkillButton : MonoUIProxy // TypeDefIndex: 29727
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _skillName; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _skillType; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _skillIcon; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionButton; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _replaceButton; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoControlElement _element; // 0x68
	
		// Properties
		public Button actionButton { /* [XID] */ /* 0x00000001897AEAA0-0x00000001897AEAC0 */ get => default; } // 0x0000000184B5CC90-0x0000000184B5CD30 
		public MonoUIContainer replaceButton { /* [XID] */ /* 0x00000001897B6930-0x00000001897B6950 */ get => default; } // 0x0000000184B5CD30-0x0000000184B5CDD0 
	
		// Constructors
		public MonoHideAndSeekSkillButton() {} // 0x0000000184B5CC10-0x0000000184B5CC90
	
		// Methods
		// [XID] // 0x00000001897BE770-0x00000001897BE790
		public void SetSkillInfo(HideAndSeekSkillExcelConfig skillConfig, bool isHide = false /* Metadata: 0x00B0FD3C */) {} // 0x0000000184B5C7D0-0x0000000184B5CAF0
		// [XID] // 0x00000001897C5E80-0x00000001897C5EA0
		private void SetPCKey(MonoControlElement keyElement, InputActionType actionType) {} // 0x0000000184B5C480-0x0000000184B5C7D0
		// [XID] // 0x00000001897CD620-0x00000001897CD640
		public void SetSlotJoypadKey(MonoControlElement keyElement, InputActionType actionType) {} // 0x0000000184B5CAF0-0x0000000184B5CC10
	}
}
