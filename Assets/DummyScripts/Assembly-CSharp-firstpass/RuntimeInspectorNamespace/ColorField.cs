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
	public class ColorField : InspectorField // TypeDefIndex: 9981
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private PointerEventListener inputColor; // 0x70
		private Image colorImg; // 0x78
		private bool isColor32; // 0x80
	
		// Constructors
		public ColorField() {} // 0x00000001868C7230-0x00000001868C7290
	
		// Methods
		// [XID] // 0x0000000189A92D80-0x0000000189A92DA0
		public override void Initialize() {} // 0x00000001868C6900-0x00000001868C6A10
		// [XID] // 0x0000000189A9A800-0x0000000189A9A820
		public override bool SupportsType(System.Type type) => default; // 0x00000001868C6FE0-0x00000001868C7110
		// [XID] // 0x0000000189AA1890-0x0000000189AA18B0
		protected override void OnBound() {} // 0x00000001868C6A10-0x00000001868C6B10
		// [XID] // 0x0000000189AA8F30-0x0000000189AA8F50
		private void ShowColorPicker(PointerEventData eventData) {} // 0x00000001868C6DF0-0x00000001868C6FE0
		// [XID] // 0x0000000189AB0AF0-0x0000000189AB0B10
		private void OnColorChanged(Color32 color) {} // 0x00000001868C6B10-0x00000001868C6C70
		// [XID] // 0x0000000189AB81C0-0x0000000189AB81E0
		public override void Refresh() {} // 0x00000001868C6C70-0x00000001868C6DF0
	}
}
