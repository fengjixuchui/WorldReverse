/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RuntimeInspectorNamespace
{
	public class BoolField : InspectorField // TypeDefIndex: 9979
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image toggleBackground; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Toggle input; // 0x78
	
		// Constructors
		public BoolField() {} // 0x00000001868C4F80-0x00000001868C4FE0
	
		// Methods
		// [XID] // 0x0000000189AD19F0-0x0000000189AD1A10
		public override void Initialize() {} // 0x00000001868C4910-0x00000001868C4A20
		// [XID] // 0x0000000189A22910-0x0000000189A22930
		public override bool SupportsType(System.Type type) => default; // 0x00000001868C4D70-0x00000001868C4E60
		// [XID] // 0x0000000189AD96D0-0x0000000189AD96F0
		private void OnValueChanged(bool input) {} // 0x00000001868C4BA0-0x00000001868C4C70
		// [XID] // 0x0000000189A30FE0-0x0000000189A31000
		protected override void OnSkinChanged() {} // 0x00000001868C4A20-0x00000001868C4BA0
		// [XID] // 0x0000000189A38C70-0x0000000189A38C90
		public override void Refresh() {} // 0x00000001868C4C70-0x00000001868C4D70
	}
}
