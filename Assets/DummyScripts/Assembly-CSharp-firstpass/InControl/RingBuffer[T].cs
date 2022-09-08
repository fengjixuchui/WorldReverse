/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	internal class RingBuffer<T> // TypeDefIndex: 8002
	{
		// Fields
		private int size;
		private T[] data;
		private int head;
		private int tail;
		private object sync;
	
		// Constructors
		public RingBuffer() {} // Dummy constructor
		public RingBuffer(int size) {}
	
		// Methods
		public void Enqueue(T value) {}
		public T Dequeue() => default;
	}
}
