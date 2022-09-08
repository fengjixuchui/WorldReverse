/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
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
	public class DraggedReferenceItem : MonoBehaviour, IDragHandler, IEndDragHandler // TypeDefIndex: 10015
	{
		// Fields
		private const float VALIDATE_INTERVAL = 5f; // Metadata: 0x00AE6E11
		private RectTransform rectTransform; // 0x18
		private Camera worldCamera; // 0x20
		private RectTransform canvasTransform; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private LayoutElement borderLayoutElement; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image background; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text referenceName; // 0x40
		private UnityEngine.Object m_reference; // 0x48
		private PointerEventData draggingPointer; // 0x50
	
		// Properties
		public UnityEngine.Object Reference { /* [XID] */ /* 0x0000000189750960-0x0000000189750980 */ get => default; } // 0x00000001867E8FC0-0x00000001867E9060 
	
		// Constructors
		public DraggedReferenceItem() {} // 0x00000001867E8F60-0x00000001867E8FC0
	
		// Methods
		// [XID] // 0x000000018965D100-0x000000018965D120
		public void Initialize(Canvas canvas, UnityEngine.Object reference, PointerEventData draggingPointer, UISkin skin) {} // 0x00000001867E8780-0x00000001867E8BF0
		[DebuggerHidden] // 0x00000001897A0B90-0x00000001897A0BD0
		// [XID] // 0x00000001897A0B90-0x00000001897A0BD0
		private IEnumerator ValidatePointer() => default; // 0x00000001867E8E50-0x00000001867E8F60
		// [XID] // 0x0000000189AC88D0-0x0000000189AC88F0
		public void OnDrag(PointerEventData eventData) {} // 0x00000001867E8BF0-0x00000001867E8D70
		// [XID] // 0x00000001897D5CF0-0x00000001897D5D10
		public void OnEndDrag(PointerEventData eventData) {} // 0x00000001867E8D70-0x00000001867E8E50
	}
}
