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
	// [RequireComponent] // 0x00000001897FE680-0x00000001897FE6D0
	public class DraggedReferenceSourceCamera : MonoBehaviour // TypeDefIndex: 10017
	{
		// Fields
		private Camera _camera; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UISkin draggedReferenceSkin; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float holdTime; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private LayerMask interactableObjectsMask; // 0x2C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float raycastRange; // 0x30
		private bool pointerDown; // 0x34
		private float pointerDownTime; // 0x38
		private Vector2 pointerDownPos; // 0x3C
		private UnityEngine.Object hitObject; // 0x48
		private DraggedReferenceItem draggedReference; // 0x50
		private PointerEventData draggingPointer; // 0x58
		public RaycastHitProcesserDelegate ProcessRaycastHit; // 0x60
	
		// Nested types
		public delegate UnityEngine.Object RaycastHitProcesserDelegate(RaycastHit hit); // TypeDefIndex: 10018; 0x0000000186801170-0x0000000186801420
	
		// Constructors
		public DraggedReferenceSourceCamera() {} // 0x00000001867E9BF0-0x00000001867E9C80
	
		// Methods
		// [XID] // 0x00000001897DD470-0x00000001897DD490
		private void Awake() {} // 0x00000001867E9060-0x00000001867E9110
		// [XID] // 0x00000001897E4DB0-0x00000001897E4DD0
		private void Update() {} // 0x00000001867E9110-0x00000001867E9BF0
	}
}
