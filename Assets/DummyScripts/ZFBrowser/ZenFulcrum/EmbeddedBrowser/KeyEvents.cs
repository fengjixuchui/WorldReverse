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
	public class KeyEvents // TypeDefIndex: 6065
	{
		// Fields
		protected List<Event> keyEvents; // 0x10
		protected List<Event> keyEventsLast; // 0x18
		private static readonly KeyCode[] keysToCheck; // 0x00
	
		// Properties
		public List<Event> Events { get => default; } // 0x00000001856B3E90-0x00000001856B3EF0 
	
		// Constructors
		public KeyEvents() {} // 0x00000001856B3DE0-0x00000001856B3E90
		static KeyEvents() {} // 0x00000001856B3D10-0x00000001856B3DE0
	
		// Methods
		public void InputUpdate() {} // 0x00000001856B36C0-0x00000001856B3A60
		public void Feed(Event ev) {} // 0x00000001856B35E0-0x00000001856B36C0
		public void Press(KeyCode key) {} // 0x00000001856B3A60-0x00000001856B3B30
		public void Release(KeyCode key) {} // 0x00000001856B3B30-0x00000001856B3C00
		public void Type(string text) {} // 0x00000001856B3C00-0x00000001856B3D10
	}
}
