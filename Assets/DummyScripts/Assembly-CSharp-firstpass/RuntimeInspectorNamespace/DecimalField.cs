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
	public class DecimalField : InspectorField // TypeDefIndex: 9982
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private BoundInputField input; // 0x70
		private NumberParser parser; // 0x78
	
		// Nested types
		private struct NumberParser // TypeDefIndex: 9983
		{
			// Fields
			private readonly ParseFunc parseFunction; // 0x00
			private readonly EqualsFunc equalsFunction; // 0x08
	
			// Nested types
			private delegate bool ParseFunc(string input, out object value); // TypeDefIndex: 9984; 0x00000001867FEDD0-0x00000001867FF080
	
			private delegate bool EqualsFunc(object value1, object value2); // TypeDefIndex: 9985; 0x00000001867EB4E0-0x00000001867EB790
	
			// Constructors
			public NumberParser(System.Type fieldType) {
				parseFunction = default;
				equalsFunction = default;
			} // 0x00000001868D7A70-0x00000001868D7AE0
	
			// Methods
			// [XID] // 0x0000000189B21520-0x0000000189B21540
			public bool TryParse(string input, out object value) {
				value = default;
				return default;
			} // 0x00000001868D70F0-0x00000001868D7100
			// [XID] // 0x0000000189B28D10-0x0000000189B28D30
			public bool ValuesAreEqual(object value1, object value2) => default; // 0x00000001868D76E0-0x00000001868D7A70
		}
	
		// Constructors
		public DecimalField() {} // 0x00000001868CB1A0-0x00000001868CB220
	
		// Methods
		// [XID] // 0x0000000189AC7800-0x0000000189AC7820
		public override void Initialize() {} // 0x00000001868CA8F0-0x00000001868CAA60
		// [XID] // 0x0000000189ACED90-0x0000000189ACEDB0
		public override bool SupportsType(System.Type type) => default; // 0x00000001868CAEC0-0x00000001868CB020
		// [XID] // 0x0000000189AD6C70-0x0000000189AD6C90
		protected override void OnBound() {} // 0x00000001868CAA60-0x00000001868CABA0
		// [XID] // 0x0000000189ADE5A0-0x0000000189ADE5C0
		private bool OnValueChanged(BoundInputField source, string input) => default; // 0x00000001868CAC70-0x00000001868CAD70
		// [XID] // 0x0000000189AE5FA0-0x0000000189AE5FC0
		protected override void OnSkinChanged() {} // 0x00000001868CABA0-0x00000001868CAC70
		// [XID] // 0x00000001896359F0-0x0000000189635A10
		public override void Refresh() {} // 0x00000001868CAD70-0x00000001868CAEC0
	}
}
