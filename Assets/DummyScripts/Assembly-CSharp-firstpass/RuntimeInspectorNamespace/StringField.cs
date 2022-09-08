/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RuntimeInspectorNamespace
{
	public class StringField : InspectorField // TypeDefIndex: 10004
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private BoundInputField input; // 0x70
		private Mode m_setterMode; // 0x78
	
		// Properties
		public Mode SetterMode { /* [XID] */ /* 0x0000000189AE5F80-0x0000000189AE5FA0 */ get => default; /* [XID] */ /* 0x0000000189AED4F0-0x0000000189AED510 */ set {} } // 0x00000001867511B0-0x0000000186751250 0x0000000186751250-0x0000000186751300
	
		// Nested types
		public enum Mode // TypeDefIndex: 10005
		{
			OnValueChange = 0,
			OnSubmit = 1
		}
	
		// Constructors
		public StringField() {} // 0x0000000186751140-0x00000001867511B0
	
		// Methods
		// [XID] // 0x0000000189AF4F00-0x0000000189AF4F20
		public override void Initialize() {} // 0x0000000186750930-0x0000000186750B40
		// [XID] // 0x0000000189B9C040-0x0000000189B9C060
		public override bool SupportsType(System.Type type) => default; // 0x0000000186750F30-0x0000000186751020
		// [XID] // 0x0000000189602660-0x0000000189602680
		private bool OnValueChanged(BoundInputField source, string input) => default; // 0x0000000186750C10-0x0000000186750CF0
		// [XID] // 0x00000001896562D0-0x00000001896562F0
		private bool OnValueSubmitted(BoundInputField source, string input) => default; // 0x0000000186750CF0-0x0000000186750DD0
		// [XID] // 0x00000001896DAD20-0x00000001896DAD40
		protected override void OnSkinChanged() {} // 0x0000000186750B40-0x0000000186750C10
		// [XID] // 0x0000000189B19FE0-0x0000000189B1A000
		public override void Refresh() {} // 0x0000000186750DD0-0x0000000186750F30
	}
}
