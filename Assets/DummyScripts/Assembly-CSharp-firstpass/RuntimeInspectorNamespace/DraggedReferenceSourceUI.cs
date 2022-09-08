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

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RuntimeInspectorNamespace
{
	public class DraggedReferenceSourceUI : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IBeginDragHandler // TypeDefIndex: 10019
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.Object m_reference; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UISkin draggedReferenceSkin; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float holdTime; // 0x28
		private IEnumerator pointerHeldCoroutine; // 0x30
	
		// Properties
		public UnityEngine.Object Reference { /* [XID] */ /* 0x00000001897EC990-0x00000001897EC9B0 */ get => default; /* [XID] */ /* 0x000000018983E7F0-0x000000018983E810 */ set {} } // 0x00000001867EA0C0-0x00000001867EA160 0x00000001867EA160-0x00000001867EA210
	
		// Constructors
		public DraggedReferenceSourceUI() {} // 0x00000001867EA050-0x00000001867EA0C0
	
		// Methods
		// [XID] // 0x0000000189821130-0x0000000189821150
		public void OnPointerDown(PointerEventData eventData) {} // 0x00000001867E9E70-0x00000001867E9F80
		// [XID] // 0x000000018985BE60-0x000000018985BE80
		public void OnPointerUp(PointerEventData eventData) {} // 0x00000001867E9F80-0x00000001867EA050
		// [XID] // 0x0000000189A40A70-0x0000000189A40A90
		public void OnBeginDrag(PointerEventData eventData) {} // 0x00000001867E9DA0-0x00000001867E9E70
		[DebuggerHidden] // 0x0000000189871EB0-0x0000000189871EF0
		// [XID] // 0x0000000189871EB0-0x0000000189871EF0
		private IEnumerator CreateReferenceItemCoroutine(PointerEventData eventData) => default; // 0x00000001867E9C80-0x00000001867E9DA0
	}
}
