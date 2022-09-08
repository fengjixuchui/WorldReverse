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

namespace miHoYoThread
{
	public struct ThreadListEnumerator<T> : IEnumerator<T> // TypeDefIndex: 8991
	{
		// Fields
		private T[] _buffer;
		private int _counter;
		private int _size;
		private T _current;
	
		// Properties
		object IEnumerator.Current { get => default; }
		T IEnumerator<T>.Current { get => default; }
		public T Current { get => default; }
	
		// Constructors
		public ThreadListEnumerator(T[] buffer, int size) : this() {
			_buffer = default;
			_counter = default;
			_size = default;
			_current = default;
		}
	
		// Methods
		public void Dispose() {}
		public bool MoveNext() => default;
		public void Reset() {}
		bool IEnumerator.MoveNext() => default;
		void IEnumerator.Reset() {}
	}
}
