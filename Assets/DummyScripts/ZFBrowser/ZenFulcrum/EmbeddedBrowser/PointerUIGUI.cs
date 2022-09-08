/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.EmbeddedBrowser
{
	// [RequireComponent] // 0x00000001897E7F10-0x00000001897E7F60
	public class PointerUIGUI : PointerUIBase, IBrowserUI, ISelectHandler, IDeselectHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler // TypeDefIndex: 6073
	{
		// Fields
		protected RawImage myImage; // 0xC8
		public bool enableInput; // 0xD0
		public bool automaticResize; // 0xD1
		protected BaseRaycaster raycaster; // 0xD8
		protected RectTransform rTransform; // 0xE0
		protected bool _mouseHasFocus; // 0xE8
		protected bool _keyboardHasFocus; // 0xE9
	
		// Properties
		public override bool MouseHasFocus { get => default; protected set {} } // 0x00000001856B8B00-0x00000001856B8B70 0x00000001856B8B70-0x00000001856B8BE0
		public override bool KeyboardHasFocus { get => default; } // 0x00000001856B8A90-0x00000001856B8B00 
	
		// Constructors
		public PointerUIGUI() {} // 0x00000001856B8A20-0x00000001856B8A90
	
		// Methods
		public override void Awake() {} // 0x00000001856B8050-0x00000001856B8140
		protected void OnEnable() {} // 0x00000001856B85E0-0x00000001856B8660
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator WatchResize() => default; // 0x00000001856B8950-0x00000001856B8A20
		protected void UpdateTexture(Texture2D texture) {} // 0x00000001856B8860-0x00000001856B8950
		protected override Vector2 MapPointerToBrowser(Vector2 screenPosition, int pointerId) => default; // 0x00000001856B8200-0x00000001856B8470
		protected override Vector2 MapRayToBrowser(Ray worldRay, int pointerId) => default; // 0x00000001856B8470-0x00000001856B8550
		public override void GetCurrentHitLocation(out Vector3 pos, out Quaternion rot) {
			pos = default;
			rot = default;
		} // 0x00000001856B8140-0x00000001856B8200
		public void OnSelect(BaseEventData eventData) {} // 0x00000001856B87D0-0x00000001856B8860
		public void OnDeselect(BaseEventData eventData) {} // 0x00000001856B8550-0x00000001856B85E0
		public void OnPointerEnter(PointerEventData eventData) {} // 0x00000001856B8710-0x00000001856B8770
		public void OnPointerExit(PointerEventData eventData) {} // 0x00000001856B8770-0x00000001856B87D0
		public void OnPointerDown(PointerEventData eventData) {} // 0x00000001856B8660-0x00000001856B8710
	}
}
