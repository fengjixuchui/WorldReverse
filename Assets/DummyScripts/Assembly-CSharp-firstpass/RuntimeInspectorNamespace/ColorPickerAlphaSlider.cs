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
	public class ColorPickerAlphaSlider : MonoBehaviour, IPointerDownHandler, IDragHandler // TypeDefIndex: 10013
	{
		// Fields
		private RectTransform rectTransform; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image alphaImage; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform selector; // 0x28
		private float m_value; // 0x30
		public OnValueChangedDelegate OnValueChanged; // 0x38
	
		// Properties
		public float Value { /* [XID] */ /* 0x0000000189707B90-0x0000000189707BB0 */ get => default; /* [XID] */ /* 0x000000018985B430-0x000000018985B450 */ set {} } // 0x00000001868C7720-0x00000001868C77D0 0x00000001868C78C0-0x00000001868C7A00
		public Color Color { /* [XID] */ /* 0x000000018967C720-0x000000018967C740 */ get => default; /* [XID] */ /* 0x000000018975D1E0-0x000000018975D200 */ set {} } // 0x00000001868C7630-0x00000001868C7720 0x00000001868C77D0-0x00000001868C78C0
	
		// Nested types
		public delegate void OnValueChangedDelegate(float alpha); // TypeDefIndex: 10014; 0x00000001868D8030-0x00000001868D81C0
	
		// Constructors
		public ColorPickerAlphaSlider() {} // 0x00000001868C75D0-0x00000001868C7630
	
		// Methods
		// [XID] // 0x000000018966CFC0-0x000000018966CFE0
		private void Awake() {} // 0x00000001868C7290-0x00000001868C7360
		// [XID] // 0x00000001897C7030-0x00000001897C7050
		public void OnPointerDown(PointerEventData eventData) {} // 0x00000001868C7520-0x00000001868C75D0
		// [XID] // 0x00000001897CE620-0x00000001897CE640
		public void OnDrag(PointerEventData eventData) {} // 0x00000001868C7360-0x00000001868C7520
	}
}
