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
	public class BrowserCursor // TypeDefIndex: 5973
	{
		// Fields
		private static Dictionary<BrowserNative.CursorType, CursorInfo> mapping; // 0x00
		private static bool loaded; // 0x08
		private static int size; // 0x0C
		private static Texture2D allCursors; // 0x10
		private bool _hasMouse; // 0x28
		protected Texture2D normalTexture; // 0x30
		protected Texture2D customTexture; // 0x38
	
		// Properties
		public virtual Texture2D Texture { get; protected set; } // 0x0000000186F671D0-0x0000000186F67230 0x0000000186F673E0-0x0000000186F67440
		public virtual Vector2 Hotspot { get; protected set; } // 0x0000000186F67160-0x0000000186F671D0 0x0000000186F67380-0x0000000186F673E0
		public bool HasMouse { get => default; set {} } // 0x0000000186F67100-0x0000000186F67160 0x0000000186F67300-0x0000000186F67380
	
		// Events
		public event Action cursorChange;
	
		// Nested types
		public class CursorInfo // TypeDefIndex: 5974
		{
			// Fields
			public int atlasOffset; // 0x10
			public Vector2 hotspot; // 0x14
	
			// Constructors
			public CursorInfo() {} // 0x0000000186F844B0-0x0000000186F84FE0
		}
	
		// Constructors
		public BrowserCursor() {} // 0x0000000186F66E90-0x0000000186F67030
		static BrowserCursor() {} // 0x0000000186F66DF0-0x0000000186F66E90
	
		// Methods
		private static void Load() {} // 0x0000000186F663B0-0x0000000186F668F0
		public virtual void SetActiveCursor(BrowserNative.CursorType type) {} // 0x0000000186F668F0-0x0000000186F66AF0
		public virtual void SetCustomCursor(Texture2D cursor, Vector2 hotspot) {} // 0x0000000186F66AF0-0x0000000186F66DA0
	}
}
