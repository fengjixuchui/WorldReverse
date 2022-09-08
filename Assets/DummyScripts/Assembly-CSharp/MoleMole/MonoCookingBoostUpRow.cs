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
	public class MonoCookingBoostUpRow : MonoSpriteProxy // TypeDefIndex: 30738
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _name; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _desc; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selectGo; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _stateImg; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionButton; // 0x48
	
		// Properties
		public Button actionButton { /* [XID] */ /* 0x00000001896A6EB0-0x00000001896A6ED0 */ get => default; } // 0x0000000184BB7030-0x0000000184BB70D0 
		public bool selected { /* [XID] */ /* 0x00000001896AE480-0x00000001896AE4A0 */ set {} } // 0x0000000184BB72B0-0x0000000184BB73A0
		public Image icon { /* [XID] */ /* 0x00000001896B5D50-0x00000001896B5D70 */ get => default; } // 0x0000000184BB7170-0x0000000184BB7210 
		public UnityEngine.UI.Text title { /* [XID] */ /* 0x00000001896BCF10-0x00000001896BCF30 */ get => default; } // 0x0000000184BB7210-0x0000000184BB72B0 
		public UnityEngine.UI.Text desc { /* [XID] */ /* 0x00000001896C43F0-0x00000001896C4410 */ get => default; } // 0x0000000184BB70D0-0x0000000184BB7170 
	
		// Constructors
		public MonoCookingBoostUpRow() {} // 0x0000000184BB6FB0-0x0000000184BB7030
	
		// Methods
		// [XID] // 0x00000001896CBA30-0x00000001896CBA50
		public void SetBoostUpRow(AvatarExcelConfig avatarConfig, string bonusDesc, bool isCurrent) {} // 0x0000000184BB6C50-0x0000000184BB6EE0
		// [XID] // 0x00000001896D2D70-0x00000001896D2D90
		public void SetBoostUpRowFormat(AvatarExcelConfig avatarConfig, string nameFormatText, string bonusDesc, bool interactable) {} // 0x0000000184BB6990-0x0000000184BB6C50
		// [XID] // 0x00000001896DA8D0-0x00000001896DA8F0
		public void TriggerAnimation(string anim) {} // 0x0000000184BB6EE0-0x0000000184BB6FB0
		// [XID] // 0x00000001896E2030-0x00000001896E2050
		public void ResetTrigger(string anim) {} // 0x0000000184BB68C0-0x0000000184BB6990
	}
}
