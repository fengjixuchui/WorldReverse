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
	public class PointerEventListener : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler // TypeDefIndex: 10027
	{
		// Events
		public event PointerEvent PointerDown;
		public event PointerEvent PointerUp;
		public event PointerEvent PointerClick;
	
		// Nested types
		public delegate void PointerEvent(PointerEventData eventData); // TypeDefIndex: 10028; 0x00000001867FFEA0-0x0000000186800100
	
		// Constructors
		public PointerEventListener() {} // 0x00000001867FF670-0x00000001867FF6D0
	
		// Methods
		// [XID] // 0x0000000189AA0230-0x0000000189AA0250
		public void OnPointerDown(PointerEventData eventData) {} // 0x00000001867FF4F0-0x00000001867FF5B0
		// [XID] // 0x0000000189AA7A50-0x0000000189AA7A70
		public void OnPointerUp(PointerEventData eventData) {} // 0x00000001867FF5B0-0x00000001867FF670
		// [XID] // 0x00000001899433D0-0x00000001899433F0
		public void OnPointerClick(PointerEventData eventData) {} // 0x00000001867FF430-0x00000001867FF4F0
	}
}
