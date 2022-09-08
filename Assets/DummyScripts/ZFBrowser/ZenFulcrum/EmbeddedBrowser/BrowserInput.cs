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
	internal class BrowserInput // TypeDefIndex: 5975
	{
		// Fields
		private readonly Browser browser; // 0x10
		private bool kbWasFocused; // 0x18
		private bool mouseWasFocused; // 0x19
		private static HashSet<KeyCode> keysToReleaseOnFocusLoss; // 0x00
		public List<Event> extraEventsToInject; // 0x20
		private MouseButton prevButtons; // 0x28
		private Vector2 prevPos; // 0x2C
		private readonly ButtonHistory leftClickHistory; // 0x38
		private Vector2 accumulatedScroll; // 0x40
		private float lastScrollEvent; // 0x48
		private const float maxScrollEventRate = 0.06666667f; // Metadata: 0x00ADBA89
	
		// Nested types
		private class ButtonHistory // TypeDefIndex: 5976
		{
			// Fields
			public float lastPressTime; // 0x10
			public int repeatCount; // 0x14
			public Vector3 lastPosition; // 0x18
	
			// Constructors
			public ButtonHistory() {} // 0x0000000186F76B20-0x0000000186F76B80
	
			// Methods
			public void ButtonPress(Vector3 mousePos, IBrowserUI uiHandler, Vector2 browserSize) {} // 0x0000000186F76950-0x0000000186F76B20
		}
	
		// Constructors
		public BrowserInput() {} // Dummy constructor
		public BrowserInput(Browser browser) {} // 0x0000000186F68C10-0x0000000186F68D10
		static BrowserInput() {} // 0x0000000186F68B80-0x0000000186F68C10
	
		// Methods
		public void HandleInput() {} // 0x0000000186F67B30-0x0000000186F68150
		private void HandleMouseInput() {} // 0x0000000186F68680-0x0000000186F68B80
		private void FeedScrolling(Vector2 mouseScroll, float scrollSpeed) {} // 0x0000000186F67520-0x0000000186F677F0
		private void HandleKeyInput() {} // 0x0000000186F68150-0x0000000186F682A0
		private void HandleKeyInput(List<Event> keyEvents) {} // 0x0000000186F682A0-0x0000000186F68680
		public void HandleFocusLoss() {} // 0x0000000186F678B0-0x0000000186F67B30
		protected void FireCommands(Event ev) {} // 0x0000000186F677F0-0x0000000186F678B0
	}
}
