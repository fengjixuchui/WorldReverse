/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using Rewired;
using UnityEngine;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Rewired.Demos.GamepadTemplateUI
{
	// [RequireComponent] // 0x0000000189B841D0-0x0000000189B84220
	public class ControllerUIElement : MonoBehaviour // TypeDefIndex: 9782
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _highlightColor; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIEffect _positiveUIEffect; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIEffect _negativeUIEffect; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _label; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _positiveLabel; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _negativeLabel; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ControllerUIElement[] _childElements; // 0x50
		private Image _image; // 0x58
		private Color _color; // 0x60
		private Color _origColor; // 0x70
		private bool _isActive; // 0x80
		private float _highlightAmount; // 0x84
	
		// Properties
		private bool hasEffects { /* [XID] */ /* 0x0000000189BC3C50-0x0000000189BC3C70 */ get => default; } // 0x0000000186547A90-0x0000000186547BB0 
	
		// Constructors
		public ControllerUIElement() {} // 0x00000001865479F0-0x0000000186547A90
	
		// Methods
		// [XID] // 0x0000000189BCB480-0x0000000189BCB4A0
		private void Awake() {} // 0x0000000186547080-0x0000000186547170
		// [XID] // 0x0000000189BD2A10-0x0000000189BD2A30
		public void Activate(float amount) {} // 0x0000000186546CE0-0x0000000186547080
		// [XID] // 0x0000000189A9FCF0-0x0000000189A9FD10
		public void Deactivate() {} // 0x00000001865474A0-0x00000001865476F0
		// [XID] // 0x000000018995ED10-0x000000018995ED30
		public void SetLabel(string text, AxisRange labelType) {} // 0x00000001865477C0-0x00000001865479F0
		// [XID] // 0x0000000189A64D80-0x0000000189A64DA0
		public void ClearLabels() {} // 0x0000000186547170-0x00000001865474A0
		// [XID] // 0x0000000189B68EC0-0x0000000189B68EE0
		private void RedrawImage() {} // 0x00000001865476F0-0x00000001865477C0
	}
}
