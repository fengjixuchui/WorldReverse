/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class RecyclePool<T> : IDisposable // TypeDefIndex: 10608
		where T : new()
	{
		// Fields
		private Queue<T> _queue;
		private int _capacity;
		private int _originalCapacity;
		private int _incrementalSizeUpCount;
		private const float incrementalCountScale = 0.1f; // Metadata: 0x00AE7BB2
	
		// Constructors
		public RecyclePool() {} // Dummy constructor
		public RecyclePool(int capacity) {}
	
		// Methods
		private void SizeUp() {}
		public bool IncrementalSizeUp() => default;
		public T Allocate() => default;
		public void Recycle(T t) {}
		public void Dispose() {}
	}
}
