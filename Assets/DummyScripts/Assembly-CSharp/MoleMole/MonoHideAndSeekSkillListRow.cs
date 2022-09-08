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
	public class MonoHideAndSeekSkillListRow : MonoUIProxy // TypeDefIndex: 29729
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _skillName; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _skillDesc; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _skillIcon; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionButton; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _arrow; // 0x60
		private bool _selected; // 0x68
	
		// Properties
		public Button actionButton { /* [XID] */ /* 0x000000018981FFA0-0x000000018981FFC0 */ get => default; } // 0x0000000184B5D080-0x0000000184B5D120 
		public bool selected { /* [XID] */ /* 0x0000000189836160-0x0000000189836180 */ get => default; /* [XID] */ /* 0x000000018982E7C0-0x000000018982E7E0 */ set {} } // 0x0000000184B5D120-0x0000000184B5D1C0 0x0000000184B5D2B0-0x0000000184B5D410
		public bool arrow { /* [XID] */ /* 0x000000018983D610-0x000000018983D630 */ set {} } // 0x0000000184B5D1C0-0x0000000184B5D2B0
	
		// Constructors
		public MonoHideAndSeekSkillListRow() {} // 0x0000000184B5D000-0x0000000184B5D080
	
		// Methods
		// [XID] // 0x0000000189827520-0x0000000189827540
		public void SetSkillInfo(AvatarSkillExcelConfig skillConfig, HIDE_AND_SEEK_SKILL_SUB_CATEGORY category, bool isHide) {} // 0x0000000184B5CDD0-0x0000000184B5D000
	}
}
