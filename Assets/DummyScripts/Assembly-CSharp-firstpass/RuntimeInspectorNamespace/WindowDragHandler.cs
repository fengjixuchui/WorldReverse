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
	public class WindowDragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 10035
	{
		// Fields
		private const int NON_EXISTING_TOUCH = -98456; // Metadata: 0x00AE6E32
		private RectTransform rectTransform; // 0x18
		private int pointerId; // 0x20
		private Vector2 initialTouchPos; // 0x24
	
		// Constructors
		public WindowDragHandler() {} // 0x00000001867597B0-0x00000001867598A0
	
		// Methods
		// [XID] // 0x00000001899689B0-0x00000001899689D0
		private void Awake() {} // 0x00000001867592C0-0x0000000186759390
		// [XID] // 0x00000001897857C0-0x00000001897857E0
		public void OnBeginDrag(PointerEventData eventData) {} // 0x0000000186759390-0x00000001867594F0
		// [XID] // 0x000000018997EFB0-0x000000018997EFD0
		public void OnDrag(PointerEventData eventData) {} // 0x00000001867594F0-0x00000001867596E0
		// [XID] // 0x000000018986CA30-0x000000018986CA50
		public void OnEndDrag(PointerEventData eventData) {} // 0x00000001867596E0-0x00000001867597B0
	}
}
