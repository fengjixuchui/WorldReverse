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

namespace Dest.Math
{
	public class ShuffleBag<T> : IEnumerable<T> // TypeDefIndex: 8187
	{
		// Fields
		private Rand _rand;
		private List<T> _items;
		private int _index;
	
		// Properties
		public int Count { get => default; }
	
		// Constructors
		public ShuffleBag() {}
		public ShuffleBag(int capacity) {}
		public ShuffleBag(Rand rand) {}
		public ShuffleBag(Rand rand, int capacity) {}
	
		// Methods
		public void Add(T item, uint count = 1 /* Metadata: 0x00ADF6C8 */) {}
		public T NextItem() => default;
		public void Reset() {}
		public void Clear() {}
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator<T> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}
}
