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
	public class ExposedMethodField : InspectorField // TypeDefIndex: 9987
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button invokeButton; // 0x70
		protected ExposedMethod boundMethod; // 0x78
	
		// Constructors
		public ExposedMethodField() {} // 0x00000001867EE1B0-0x00000001867EE410
	
		// Methods
		// [XID] // 0x00000001898A5E90-0x00000001898A5EB0
		public override bool SupportsType(System.Type type) => default; // 0x00000001867EDFA0-0x00000001867EE090
		// [XID] // 0x0000000189BCCBC0-0x0000000189BCCBE0
		public override void Initialize() {} // 0x00000001867EDA60-0x00000001867EDB70
		// [XID] // 0x00000001899C5690-0x00000001899C56B0
		protected override void OnSkinChanged() {} // 0x00000001867EDDE0-0x00000001867EDEB0
		// [XID] // 0x00000001899C87A0-0x00000001899C87C0
		protected override void OnDepthChanged() {} // 0x00000001867EDC70-0x00000001867EDDE0
		// [XID] // 0x0000000189944360-0x0000000189944380
		public void SetBoundMethod(ExposedMethod boundMethod) {} // 0x00000001867EDEB0-0x00000001867EDFA0
		// [XID] // 0x00000001895EFCC0-0x00000001895EFCE0
		public void InvokeMethod() {} // 0x00000001867EDB70-0x00000001867EDC70
	}
}
