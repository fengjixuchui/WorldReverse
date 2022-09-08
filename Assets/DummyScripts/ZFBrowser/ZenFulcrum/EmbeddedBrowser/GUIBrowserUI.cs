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
	[Obsolete] // 0x0000000189601EB0-0x0000000189601F50
	// [RequireComponent] // 0x0000000189601EB0-0x0000000189601F50
	// [RequireComponent] // 0x0000000189601EB0-0x0000000189601F50
	public class GUIBrowserUI : MonoBehaviour, IBrowserUI, ISelectHandler, IDeselectHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler // TypeDefIndex: 6069
	{
		// Fields
		protected RawImage myImage; // 0x18
		protected Browser browser; // 0x20
		public bool enableInput; // 0x28
		public bool autoResize; // 0x29
		protected List<Event> keyEvents; // 0x30
		protected List<Event> keyEventsLast; // 0x38
		protected BaseRaycaster raycaster; // 0x40
		protected RectTransform rTransform; // 0x48
		protected bool _mouseHasFocus; // 0x50
		protected bool _keyboardHasFocus; // 0x68
	
		// Properties
		public bool MouseHasFocus { get => default; } // 0x00000001856AF150-0x00000001856AF1C0 
		public Vector2 MousePosition { get; private set; } // 0x00000001856AF1C0-0x00000001856AF230 0x00000001856AF3C0-0x00000001856AF420
		public MouseButton MouseButtons { get; private set; } // 0x00000001856AF0F0-0x00000001856AF150 0x00000001856AF360-0x00000001856AF3C0
		public Vector2 MouseScroll { get; private set; } // 0x00000001856AF230-0x00000001856AF2A0 0x00000001856AF420-0x00000001856AF480
		public bool KeyboardHasFocus { get => default; } // 0x00000001856AF080-0x00000001856AF0F0 
		public List<Event> KeyEvents { get => default; } // 0x00000001856AF020-0x00000001856AF080 
		public BrowserCursor BrowserCursor { get; private set; } // 0x00000001856AEF60-0x00000001856AEFC0 0x00000001856AF2A0-0x00000001856AF300
		public BrowserInputSettings InputSettings { get; private set; } // 0x00000001856AEFC0-0x00000001856AF020 0x00000001856AF300-0x00000001856AF360
	
		// Constructors
		public GUIBrowserUI() {} // 0x00000001856AEEA0-0x00000001856AEF60
	
		// Methods
		protected void Awake() {} // 0x00000001856ADE50-0x00000001856AE080
		protected void OnEnable() {} // 0x00000001856AE730-0x00000001856AE7B0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator WatchResize() => default; // 0x00000001856AEDD0-0x00000001856AEEA0
		protected void UpdateTexture(Texture2D texture) {} // 0x00000001856AECF0-0x00000001856AEDD0
		public virtual void InputUpdate() {} // 0x00000001856AE080-0x00000001856AE6D0
		public void OnGUI() {} // 0x00000001856AE7B0-0x00000001856AE890
		protected virtual void SetCursor(BrowserCursor newCursor) {} // 0x00000001856AEAD0-0x00000001856AEC30
		public void OnSelect(BaseEventData eventData) {} // 0x00000001856AEA70-0x00000001856AEAD0
		public void OnDeselect(BaseEventData eventData) {} // 0x00000001856AE6D0-0x00000001856AE730
		public void OnPointerEnter(PointerEventData eventData) {} // 0x00000001856AE940-0x00000001856AEA00
		public void OnPointerExit(PointerEventData eventData) {} // 0x00000001856AEA00-0x00000001856AEA70
		public void OnPointerDown(PointerEventData eventData) {} // 0x00000001856AE890-0x00000001856AE940
	}
}
