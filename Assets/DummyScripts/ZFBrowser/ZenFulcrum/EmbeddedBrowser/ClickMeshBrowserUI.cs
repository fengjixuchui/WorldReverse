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
	[Obsolete] // 0x0000000189AED670-0x0000000189AED6A0
	public class ClickMeshBrowserUI : MonoBehaviour, IBrowserUI // TypeDefIndex: 6066
	{
		// Fields
		protected MeshCollider meshCollider; // 0x18
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public float maxDistance; // 0x20
		protected List<Event> keyEvents; // 0x28
		protected List<Event> keyEventsLast; // 0x30
		private static readonly KeyCode[] keysToCheck; // 0x00
		protected bool mouseWasOver; // 0x38
	
		// Properties
		protected virtual Ray LookRay { get => default; } // 0x0000000186F83B70-0x0000000186F83C60 
		public bool MouseHasFocus { get; protected set; } // 0x0000000186F83CC0-0x0000000186F83D20 0x0000000186F83F80-0x0000000186F83FE0
		public Vector2 MousePosition { get; protected set; } // 0x0000000186F83D20-0x0000000186F83D90 0x0000000186F83FE0-0x0000000186F84040
		public MouseButton MouseButtons { get; protected set; } // 0x0000000186F83C60-0x0000000186F83CC0 0x0000000186F83F20-0x0000000186F83F80
		public Vector2 MouseScroll { get; protected set; } // 0x0000000186F83D90-0x0000000186F83E00 0x0000000186F84040-0x0000000186F840A0
		public bool KeyboardHasFocus { get; protected set; } // 0x0000000186F83B10-0x0000000186F83B70 0x0000000186F83EC0-0x0000000186F83F20
		public List<Event> KeyEvents { get => default; } // 0x0000000186F83AB0-0x0000000186F83B10 
		public BrowserCursor BrowserCursor { get; protected set; } // 0x0000000186F839F0-0x0000000186F83A50 0x0000000186F83E00-0x0000000186F83E60
		public BrowserInputSettings InputSettings { get; protected set; } // 0x0000000186F83A50-0x0000000186F83AB0 0x0000000186F83E60-0x0000000186F83EC0
	
		// Constructors
		public ClickMeshBrowserUI() {} // 0x0000000186F83930-0x0000000186F839F0
		static ClickMeshBrowserUI() {} // 0x0000000186F83860-0x0000000186F83930
	
		// Methods
		public static ClickMeshBrowserUI Create(MeshCollider meshCollider) => default; // 0x0000000186F82AF0-0x0000000186F82BA0
		public void Awake() {} // 0x0000000186F82960-0x0000000186F82AF0
		public virtual void InputUpdate() {} // 0x0000000186F82C60-0x0000000186F83480
		public void OnGUI() {} // 0x0000000186F835F0-0x0000000186F836D0
		protected void LookOn() {} // 0x0000000186F83540-0x0000000186F835F0
		protected void LookOff() {} // 0x0000000186F83480-0x0000000186F83540
		protected void CursorUpdated() {} // 0x0000000186F82BA0-0x0000000186F82C60
		protected virtual void SetCursor(BrowserCursor newCursor) {} // 0x0000000186F836D0-0x0000000186F83860
	}
}
