/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public struct ScopeList<T> : IDisposable, IEnumerable // TypeDefIndex: 7462
	{
		// Fields
		private List<T> _list;
	
		// Properties
		public bool IsNull { get => default; }
		public int Count { get => default; }
		public T this[int index] { get => default; }
	
		// Constructors
		public ScopeList(bool doesntMatter = false /* Metadata: 0x00ADE9F9 */) : this() {
			_list = default;
		}
	
		// Methods
		public void Dispose() {}
		public void Add(T obj) {}
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		IEnumerator IEnumerable.GetEnumerator() => default;
	}
}
