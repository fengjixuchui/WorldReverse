/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class CircleQueue<T> // TypeDefIndex: 10489
	{
		// Fields
		private int _front;
		private int _tail;
		private int _capacity;
		private int _itor;
		private T[] _queue;
	
		// Properties
		public T[] queue { get => default; }
	
		// Constructors
		public CircleQueue() {} // Dummy constructor
		public CircleQueue(int cap) {}
	
		// Methods
		public bool IsEmpty() => default;
		private int innerMoveNext(int value) => default;
		public bool Enqueue(T value, bool throwTheOldestOneWhenFull = true /* Metadata: 0x00AE7651 */) => default;
		public bool TryDequeue(out T value) {
			value = default;
			return default;
		}
	}
}
