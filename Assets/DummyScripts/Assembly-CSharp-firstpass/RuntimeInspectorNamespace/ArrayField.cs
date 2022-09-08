/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RuntimeInspectorNamespace
{
	public class ArrayField : ExpandableInspectorField, IDropHandler // TypeDefIndex: 9976
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private LayoutElement sizeLayoutElement; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text sizeText; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private BoundInputField sizeInput; // 0xC0
		private bool isArray; // 0xC8
		private System.Type elementType; // 0xD0
	
		// Properties
		protected override int Length { /* [XID] */ /* 0x00000001899763B0-0x00000001899763D0 */ get => default; } // 0x00000001868C3770-0x00000001868C3890 
	
		// Constructors
		public ArrayField() {} // 0x00000001868C3710-0x00000001868C3770
	
		// Methods
		// [XID] // 0x000000018997D6A0-0x000000018997D6C0
		public override void Initialize() {} // 0x00000001868C2570-0x00000001868C2760
		// [XID] // 0x000000018968E2B0-0x000000018968E2D0
		public override bool SupportsType(System.Type type) => default; // 0x00000001868C3360-0x00000001868C34C0
		// [XID] // 0x000000018998CCE0-0x000000018998CD00
		protected override void OnBound() {} // 0x00000001868C2760-0x00000001868C28B0
		// [XID] // 0x000000018965FA00-0x000000018965FA20
		protected override void OnUnbound() {} // 0x00000001868C32A0-0x00000001868C3360
		// [XID] // 0x000000018999C2B0-0x000000018999C2D0
		protected override void OnSkinChanged() {} // 0x00000001868C3160-0x00000001868C32A0
		// [XID] // 0x00000001899A3C40-0x00000001899A3C60
		protected override void OnDepthChanged() {} // 0x00000001868C28B0-0x00000001868C29F0
		// [XID] // 0x00000001899AB6F0-0x00000001899AB710
		protected override void GenerateElements() {} // 0x00000001868C1AA0-0x00000001868C20F0
		// [XID] // 0x00000001899B3090-0x00000001899B30B0
		public void OnDrop(PointerEventData eventData) {} // 0x00000001868C29F0-0x00000001868C2C60
		// [XID] // 0x00000001899BA340-0x00000001899BA360
		private bool OnSizeInputBeingChanged(BoundInputField source, string input) => default; // 0x00000001868C3070-0x00000001868C3160
		// [XID] // 0x00000001899C1D80-0x00000001899C1DA0
		private bool OnSizeChanged(BoundInputField source, string input) => default; // 0x00000001868C2C60-0x00000001868C3070
		// [XID] // 0x0000000189A9E470-0x0000000189A9E490
		private object GetTemplateElement(object value) => default; // 0x00000001868C20F0-0x00000001868C2570
	}
}
