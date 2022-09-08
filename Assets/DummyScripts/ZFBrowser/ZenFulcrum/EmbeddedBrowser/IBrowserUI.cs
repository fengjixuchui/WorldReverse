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
	public interface IBrowserUI // TypeDefIndex: 6064
	{
		// Properties
		bool MouseHasFocus { get; }
		Vector2 MousePosition { get; }
		MouseButton MouseButtons { get; }
		Vector2 MouseScroll { get; }
		bool KeyboardHasFocus { get; }
		List<Event> KeyEvents { get; }
		BrowserCursor BrowserCursor { get; }
		BrowserInputSettings InputSettings { get; }
	
		// Methods
		void InputUpdate();
	}
}
