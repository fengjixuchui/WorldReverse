/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread
{
	public class ThreadSafeQueue<T> // TypeDefIndex: 8996
	{
		// Fields
		private readonly Queue<T> _queue;
		private readonly ReaderWriterLockSlim _lockQ;
	
		// Properties
		public int Count { get => default; }
	
		// Constructors
		public ThreadSafeQueue() {}
		public ThreadSafeQueue(int capacity) {}
		public ThreadSafeQueue(IEnumerable<T> collection) {}
	
		// Methods
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator<T> GetEnumerator() => default;
		public void Enqueue(T item) {}
		public T Dequeue() => default;
		public void EnqueueAll(IEnumerable<T> ItemsToQueue) {}
		public List<T> DequeueAll() => default;
		public void DequeueAllInto(List<T> list) {}
		public void DequeueInto(List<T> list, int count) {}
		public T Peek() => default;
		public void Clear() {}
		public bool TryDequeue(out T item) {
			item = default;
			return default;
		}
	}
}
