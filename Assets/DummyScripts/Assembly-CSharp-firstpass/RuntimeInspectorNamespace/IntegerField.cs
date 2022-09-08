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
	public class IntegerField : InspectorField // TypeDefIndex: 9997
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private BoundInputField input; // 0x70
		private NumberParser parser; // 0x78
	
		// Nested types
		private struct NumberParser // TypeDefIndex: 9998
		{
			// Fields
			private readonly ParseFunc parseFunction; // 0x00
			private readonly EqualsFunc equalsFunction; // 0x08
	
			// Nested types
			private delegate bool ParseFunc(string input, out object value); // TypeDefIndex: 9999; 0x00000001867FF080-0x00000001867FF330
	
			private delegate bool EqualsFunc(object value1, object value2); // TypeDefIndex: 10000; 0x00000001867EB230-0x00000001867EB4E0
	
			// Constructors
			public NumberParser(System.Type fieldType) {
				parseFunction = default;
				equalsFunction = default;
			} // 0x00000001867FA270-0x00000001867FA2E0
	
			// Methods
			// [XID] // 0x00000001899330C0-0x00000001899330E0
			public bool TryParse(string input, out object value) {
				value = default;
				return default;
			} // 0x00000001867F8AB0-0x00000001867F8AC0
			// [XID] // 0x000000018993A9A0-0x000000018993A9C0
			public bool ValuesAreEqual(object value1, object value2) => default; // 0x00000001867F98D0-0x00000001867FA270
		}
	
		// Constructors
		public IntegerField() {} // 0x00000001867F8920-0x00000001867F8AB0
	
		// Methods
		// [XID] // 0x00000001898E7A70-0x00000001898E7A90
		public override void Initialize() {} // 0x00000001867F7EE0-0x00000001867F8050
		// [XID] // 0x0000000189886B90-0x0000000189886BB0
		public override bool SupportsType(System.Type type) => default; // 0x00000001867F84B0-0x00000001867F87A0
		// [XID] // 0x000000018988DC90-0x000000018988DCB0
		protected override void OnBound() {} // 0x00000001867F8050-0x00000001867F8190
		// [XID] // 0x00000001899863D0-0x00000001899863F0
		private bool OnValueChanged(BoundInputField source, string input) => default; // 0x00000001867F8260-0x00000001867F8360
		// [XID] // 0x0000000189A2EC80-0x0000000189A2ECA0
		protected override void OnSkinChanged() {} // 0x00000001867F8190-0x00000001867F8260
		// [XID] // 0x000000018991C5C0-0x000000018991C5E0
		public override void Refresh() {} // 0x00000001867F8360-0x00000001867F84B0
	}
}
