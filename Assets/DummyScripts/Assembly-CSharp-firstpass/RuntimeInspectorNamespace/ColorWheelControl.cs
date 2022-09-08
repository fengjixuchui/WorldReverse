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

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RuntimeInspectorNamespace
{
	public class ColorWheelControl : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler // TypeDefIndex: 9957
	{
		// Fields
		private const float RGB_CONST = 0.63661975f; // Metadata: 0x00AE6DBB
		private const float G_CONST = 2.0943952f; // Metadata: 0x00AE6DBF
		private const float B_CONST = 4.1887903f; // Metadata: 0x00AE6DC3
		private Color m_color; // 0x18
		private RectTransform rectTransform; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform SelectorOut; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform SelectorIn; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private WindowDragHandler colorPickerWindow; // 0x48
		private float outer; // 0x50
		private Vector2 inner; // 0x54
		private UnityEngine.Material mat; // 0x60
		private bool draggingOuter; // 0x68
		private bool draggingInner; // 0x69
		private float halfSize; // 0x6C
		private float halfSizeSqr; // 0x70
		private float outerCirclePaddingSqr; // 0x74
		private float innerSquareHalfSize; // 0x78
		private int pointerId; // 0x7C
	
		// Properties
		public Color Color { /* [XID] */ /* 0x00000001898D8140-0x00000001898D8160 */ get => default; /* [XID] */ /* 0x0000000189813480-0x00000001898134A0 */ private set {} } // 0x00000001868CA560-0x00000001868CA630 0x00000001868CA7C0-0x00000001868CA8F0
		public float Alpha { /* [XID] */ /* 0x000000018981B010-0x000000018981B050 */ get; /* [XID] */ /* 0x00000001898254D0-0x0000000189825510 */ set; } // 0x00000001868CA4F0-0x00000001868CA560 0x00000001868CA750-0x00000001868CA7C0
	
		// Events
		public event OnColorChangedDelegate OnColorChanged;
	
		// Nested types
		public delegate void OnColorChangedDelegate(Color32 color); // TypeDefIndex: 9958; 0x00000001868D7BF0-0x00000001868D7D80
	
		// Constructors
		public ColorWheelControl() {} // 0x00000001868CA360-0x00000001868CA3D0
	
		// Methods
		// [XID] // 0x000000018983E890-0x000000018983E8B0
		private void Awake() {} // 0x00000001868C9110-0x00000001868C9260
		// [XID] // 0x00000001897E6DB0-0x00000001897E6DD0
		private void OnRectTransformDimensionsChange() {} // 0x00000001868C9C30-0x00000001868C9D20
		// [XID] // 0x0000000189749FB0-0x0000000189749FD0
		private void UpdateProperties() {} // 0x00000001868CA090-0x00000001868CA1B0
		// [XID] // 0x0000000189854610-0x0000000189854630
		public void PickColor(Color c) {} // 0x00000001868C9D20-0x00000001868C9F00
		// [XID] // 0x000000018985BF80-0x000000018985BFA0
		public void OnPointerDown(PointerEventData eventData) {} // 0x00000001868C9880-0x00000001868C9AB0
		// [XID] // 0x00000001897BA560-0x00000001897BA580
		public void OnDrag(PointerEventData eventData) {} // 0x00000001868C96E0-0x00000001868C9880
		// [XID] // 0x000000018986AB10-0x000000018986AB30
		public void OnPointerUp(PointerEventData eventData) {} // 0x00000001868C9AB0-0x00000001868C9C30
		// [XID] // 0x0000000189776A00-0x0000000189776A20
		private void GetSelectedColor(Vector2 pointerPos) {} // 0x00000001868C9480-0x00000001868C96E0
		// [XID] // 0x000000018977DE70-0x000000018977DE90
		private void UpdateColor() {} // 0x00000001868C9F00-0x00000001868CA090
		// [XID] // 0x0000000189880D70-0x0000000189880D90
		private Color GetCurrentBaseColor() => default; // 0x00000001868C9260-0x00000001868C9480
		// [XID] // 0x0000000189888150-0x0000000189888170
		private void UpdateSelectors() {} // 0x00000001868CA1B0-0x00000001868CA360
	}
}
