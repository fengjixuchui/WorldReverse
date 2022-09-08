/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace XLua
{
	public class ObjectPool // TypeDefIndex: 32419
	{
		// Fields
		private const int LIST_END = -1; // Metadata: 0x00B143F1
		private const int ALLOCED = -2; // Metadata: 0x00B143F5
		private Slot[] list; // 0x10
		private int freelist; // 0x18
		private int count; // 0x1C
	
		// Properties
		public object this[int i] { get => default; } // 0x0000000186133A10-0x0000000186133AC0 
	
		// Nested types
		private struct Slot // TypeDefIndex: 32420
		{
			// Fields
			public int next; // 0x00
			public object obj; // 0x08
	
			// Constructors
			public Slot(int next, object obj) {
				this.next = default;
				this.obj = default;
			} // 0x0000000186148F10-0x0000000186149060
		}
	
		// Constructors
		public ObjectPool() {} // 0x0000000186133830-0x00000001861338D0
	
		// Methods
		public void Clear() {} // 0x00000001861333C0-0x0000000186133450
		private void extend_capacity() {} // 0x00000001861338D0-0x0000000186133A10
		public int Add(object obj) => default; // 0x0000000186132FC0-0x0000000186133190
		public bool TryGetValue(int index, out object obj) {
			obj = default;
			return default;
		} // 0x0000000186133740-0x0000000186133830
		public object Get(int index) => default; // 0x0000000186133450-0x0000000186133500
		public object Remove(int index) => default; // 0x0000000186133500-0x0000000186133660
		public object Replace(int index, object o) => default; // 0x0000000186133660-0x0000000186133740
		public int Check(int check_pos, int max_check, Func<object, bool> checker, Dictionary<object, int> reverse_map) => default; // 0x0000000186133190-0x00000001861333C0
	}
}
