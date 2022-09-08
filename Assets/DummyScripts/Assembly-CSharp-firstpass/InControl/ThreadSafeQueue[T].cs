/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	internal class ThreadSafeQueue<T> // TypeDefIndex: 8004
	{
		// Fields
		private object sync;
		private Queue<T> data;
	
		// Constructors
		public ThreadSafeQueue() {}
		public ThreadSafeQueue(int capacity) {}
	
		// Methods
		public void Enqueue(T item) {}
		public bool Dequeue(out T item) {
			item = default;
			return default;
		}
		public T Dequeue() => default;
		public int Dequeue(ref IList<T> list) => default;
	}
}
