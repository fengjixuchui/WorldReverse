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
	public class ColorPicker : SkinnedWindow // TypeDefIndex: 10012
	{
		// Fields
		private static ColorPicker m_instance; // 0x00
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image panel; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ColorWheelControl colorWheel; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ColorPickerAlphaSlider alphaSlider; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text rgbaText; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private BoundInputField rInput; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private BoundInputField gInput; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private BoundInputField bInput; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private BoundInputField aInput; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private LayoutElement rgbaLayoutElement; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private LayoutElement buttonsLayoutElement; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button cancelButton; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button okButton; // 0x80
		private Color initialValue; // 0x88
		private ColorWheelControl.OnColorChangedDelegate onColorChanged; // 0x98
	
		// Properties
		public static ColorPicker Instance { /* [XID] */ /* 0x00000001898B9120-0x00000001898B9140 */ get => default; } // 0x00000001868C8F80-0x00000001868C9110 
	
		// Constructors
		public ColorPicker() {} // 0x00000001868C8F20-0x00000001868C8F80
	
		// Methods
		// [XID] // 0x0000000189899970-0x0000000189899990
		protected override void Awake() {} // 0x00000001868C7A00-0x00000001868C7BE0
		// [XID] // 0x00000001897FE1E0-0x00000001897FE200
		private void Start() {} // 0x00000001868C89F0-0x00000001868C8EC0
		// [XID] // 0x0000000189703B60-0x0000000189703B80
		public void Show(ColorWheelControl.OnColorChangedDelegate onColorChanged, Color initialColor) {} // 0x00000001868C87D0-0x00000001868C89F0
		// [XID] // 0x000000018997C240-0x000000018997C260
		public void Cancel() {} // 0x00000001868C7BE0-0x00000001868C7D20
		// [XID] // 0x00000001898D6EF0-0x00000001898D6F10
		public void Close() {} // 0x00000001868C7D20-0x00000001868C7DF0
		// [XID] // 0x000000018971A4A0-0x000000018971A4C0
		protected override void RefreshSkin() {} // 0x00000001868C8510-0x00000001868C87D0
		// [XID] // 0x00000001897EF4B0-0x00000001897EF4D0
		private void OnSelectedColorChanged(Color32 color) {} // 0x00000001868C82A0-0x00000001868C8510
		// [XID] // 0x00000001898806A0-0x00000001898806C0
		private void OnAlphaChanged(float alpha) {} // 0x00000001868C7DF0-0x00000001868C8010
		// [XID] // 0x0000000189B5B7B0-0x0000000189B5B7D0
		private bool OnRGBAChanged(BoundInputField source, string input) => default; // 0x00000001868C8010-0x00000001868C82A0
	}
}
