/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole.AsyncNetwork
{
	public class AtomicObject<T> // TypeDefIndex: 10661
		where T : class
	{
		// Fields
		private T _ptr;
	
		// Properties
		public T value { get => default; }
	
		// Constructors
		public AtomicObject() {}
	
		// Methods
		public void Set(T ptr) {}
		public T Exchange(T value) => default;
		public T CompareExchange(T cmp, T val) => default;
	}
}
