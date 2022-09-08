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
	public class MonoCountNumNew : MonoSpriteProxy // TypeDefIndex: 31196
	{
		// Fields
		public static readonly int AnimatorAddHash; // 0x00
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string[] _iconName; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtCount; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtMid; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtAdd; // 0x48
		private bool _isStarted; // 0x50
	
		// Properties
		public bool EnableMidText { /* [XID] */ /* 0x00000001897AD060-0x00000001897AD080 */ set {} } // 0x0000000183F39520-0x0000000183F39600
		public bool EnableAddText { /* [XID] */ /* 0x00000001897B5070-0x00000001897B5090 */ set {} } // 0x0000000183F39440-0x0000000183F39520
	
		// Constructors
		public MonoCountNumNew() {} // 0x0000000183F393C0-0x0000000183F39440
		static MonoCountNumNew() {} // 0x0000000183F39350-0x0000000183F393C0
	
		// Methods
		// [XID] // 0x00000001897BCCA0-0x00000001897BCCC0
		public void Start() {} // 0x0000000183F38F20-0x0000000183F38FC0
		// [XID] // 0x00000001897C4020-0x00000001897C4040
		public void OnEnable() {} // 0x0000000183F38A90-0x0000000183F38B30
		// [XID] // 0x00000001897CB8E0-0x00000001897CB900
		public void ResetCount() {} // 0x0000000183F38C50-0x0000000183F38CF0
		// [IDTag] // 0x00000001897D31B0-0x00000001897D31F0
		// [XID] // 0x00000001897D31B0-0x00000001897D31F0
		public void UpdateCountText(int count) {} // 0x0000000183F39220-0x0000000183F39350
		// [IDTag] // 0x00000001897DD980-0x00000001897DD9C0
		// [XID] // 0x00000001897DD980-0x00000001897DD9C0
		public void UpdateCountText(string text) {} // 0x0000000183F390D0-0x0000000183F39220
		// [XID] // 0x00000001897E8050-0x00000001897E8070
		public void UpdateAddText(string text) {} // 0x0000000183F38FC0-0x0000000183F390D0
		// [XID] // 0x00000001897EFC90-0x00000001897EFCB0
		public void SetItemIcon(string iconName) {} // 0x0000000183F38E00-0x0000000183F38F20
		// [XID] // 0x00000001897F74C0-0x00000001897F74E0
		public void SetIcon(int iconIndex) {} // 0x0000000183F38CF0-0x0000000183F38E00
		// [XID] // 0x00000001897FEBB0-0x00000001897FEBD0
		public void PlayAnim() {} // 0x0000000183F38B30-0x0000000183F38C50
	}
}
