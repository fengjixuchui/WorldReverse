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
	public class MonoSquatButton : MonoActionBtn // TypeDefIndex: 31114
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Sprite _squatIcon; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Sprite _standIcon; // 0x68
	
		// Constructors
		public MonoSquatButton() {} // 0x0000000185006FA0-0x0000000185007020
	
		// Methods
		// [XID] // 0x00000001897F5E20-0x00000001897F5E40
		private void OnSquat() {} // 0x0000000185006C10-0x0000000185006D70
		// [XID] // 0x00000001897FD580-0x00000001897FD5A0
		protected override void HandlePointDown() {} // 0x0000000185006D70-0x0000000185006E20
		// [XID] // 0x0000000189804B00-0x0000000189804B20
		private void ToStandIcon() {} // 0x0000000185006AB0-0x0000000185006B60
		// [XID] // 0x000000018980C110-0x000000018980C130
		private void ToSquatIcon() {} // 0x0000000185006B60-0x0000000185006C10
		// [XID] // 0x0000000189813800-0x0000000189813820
		private void TrySetSquatButtonIcon(bool toSquat) {} // 0x00000001850069F0-0x0000000185006AB0
		// [XID] // 0x000000018981B3B0-0x000000018981B3D0
		public bool SetActive(bool active, ActionPanelState state) => default; // 0x0000000185006E80-0x0000000185006FA0
	}
}
