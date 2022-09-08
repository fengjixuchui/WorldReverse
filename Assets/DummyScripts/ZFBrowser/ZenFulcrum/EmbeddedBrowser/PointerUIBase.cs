/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.EmbeddedBrowser
{
	// [RequireComponent] // 0x00000001896D00B0-0x00000001896D0100
	public abstract class PointerUIBase : MonoBehaviour, IBrowserUI // TypeDefIndex: 6071
	{
		// Fields
		public readonly KeyEvents keyEvents; // 0x18
		protected Browser browser; // 0x20
		protected bool appFocused; // 0x28
		protected int currentPointerId; // 0x38
		protected readonly List<PointerState> currentPointers; // 0x40
		// [Tooltip] // 0x00000001896E60A0-0x00000001896E60D0
		public float dragMovementThreshold; // 0x48
		protected Vector2 mouseDownPosition; // 0x4C
		protected bool dragging; // 0x54
		protected int p_currentDown; // 0x60
		protected int p_anyDown; // 0x64
		protected int p_currentOver; // 0x68
		protected int p_anyOver; // 0x6C
		protected bool mouseWasOver; // 0x70
		private int focusForceCount; // 0x74
		// [Tooltip] // 0x00000001896F9410-0x00000001896F9440
		public Camera viewCamera; // 0x78
		public bool enableMouseInput; // 0x80
		public bool enableTouchInput; // 0x81
		public bool enableFPSInput; // 0x82
		public bool enableVRInput; // 0x83
		// [Tooltip] // 0x0000000189702620-0x0000000189702650
		public float maxDistance; // 0x84
		[Space] // 0x000000018970B590-0x000000018970B5E0
		// [Tooltip] // 0x000000018970B590-0x000000018970B5E0
		public bool disableMouseEmulation; // 0x88
		protected VRBrowserHand[] vrHands; // 0x90
	
		// Properties
		public virtual bool MouseHasFocus { get; protected set; } // 0x00000001856B7A60-0x00000001856B7AC0 0x00000001856B7F00-0x00000001856B7F70
		public virtual Vector2 MousePosition { get; protected set; } // 0x00000001856B7AC0-0x00000001856B7B30 0x00000001856B7F70-0x00000001856B7FE0
		public virtual MouseButton MouseButtons { get; protected set; } // 0x00000001856B7A00-0x00000001856B7A60 0x00000001856B7E90-0x00000001856B7F00
		public virtual Vector2 MouseScroll { get; protected set; } // 0x00000001856B7B30-0x00000001856B7BA0 0x00000001856B7FE0-0x00000001856B8050
		public virtual bool KeyboardHasFocus { get; protected set; } // 0x00000001856B79A0-0x00000001856B7A00 0x00000001856B7E20-0x00000001856B7E90
		public virtual List<Event> KeyEvents { get; } // 0x00000001856B78F0-0x00000001856B79A0 
		public virtual BrowserCursor BrowserCursor { get; protected set; } // 0x00000001856B7830-0x00000001856B7890 0x00000001856B7D40-0x00000001856B7DB0
		public virtual BrowserInputSettings InputSettings { get; protected set; } // 0x00000001856B7890-0x00000001856B78F0 0x00000001856B7DB0-0x00000001856B7E20
	
		// Events
		public event Action onHandlePointers;
		public event Action onClick;
	
		// Nested types
		public struct PointerState // TypeDefIndex: 6072
		{
			// Fields
			public int id; // 0x00
			public bool is2D; // 0x04
			public Vector2 position2D; // 0x08
			public Ray position3D; // 0x10
			public MouseButton activeButtons; // 0x28
			public Vector2 scrollDelta; // 0x2C
		}
	
		// Constructors
		protected PointerUIBase() {} // 0x00000001856B74D0-0x00000001856B7690
	
		// Methods
		public virtual void Awake() {} // 0x00000001856B5C20-0x00000001856B5DE0
		public virtual void InputUpdate() {} // 0x00000001856B6F60-0x00000001856B7030
		public void OnApplicationFocus(bool focused) {} // 0x00000001856B7200-0x00000001856B7260
		protected abstract Vector2 MapPointerToBrowser(Vector2 screenPosition, int pointerId);
		protected abstract Vector2 MapRayToBrowser(Ray worldRay, int pointerId);
		public abstract void GetCurrentHitLocation(out Vector3 pos, out Quaternion rot);
		public virtual void FeedPointerState(PointerState state) {} // 0x00000001856B65E0-0x00000001856B68D0
		protected virtual void CalculatePointer() {} // 0x00000001856B5DE0-0x00000001856B60B0
		public void OnGUI() {} // 0x00000001856B7260-0x00000001856B72E0
		protected void MouseIsOver() {} // 0x00000001856B7120-0x00000001856B7200
		protected void MouseIsOff() {} // 0x00000001856B7030-0x00000001856B7120
		protected void CursorUpdated() {} // 0x00000001856B60B0-0x00000001856B6100
		public void ForceKeyboardHasFocus(bool force) {} // 0x00000001856B6EC0-0x00000001856B6F60
		protected virtual void OnHandlePointers() {} // 0x00000001856B72E0-0x00000001856B7430
		protected virtual void FeedTouchPointers() {} // 0x00000001856B68D0-0x00000001856B6AD0
		protected virtual void FeedMousePointer() {} // 0x00000001856B63F0-0x00000001856B65E0
		protected virtual void FeedFPS() {} // 0x00000001856B6100-0x00000001856B63F0
		protected virtual void FeedVRPointers() {} // 0x00000001856B6AD0-0x00000001856B6EC0
	}
}
