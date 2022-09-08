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
	public class ArrayObjectPoolInstance<T> : ObjectPoolProxy, ObjectArrayPoolProxy<T> // TypeDefIndex: 7440
	{
		// Fields
		private Dictionary<int, Stack<T[]>> _dict;
	
		// Constructors
		public ArrayObjectPoolInstance() {}
	
		// Methods
		public override string ToString() => default;
		private Stack<T[]> GetStackByArrayCount(int count) => default;
		public T[] Allocate(uint count) => default;
		public T[] Allocate(int count) => default;
		public void Deallocate(T[] instance) {}
		public void Deallocate(ref T[] instance) {}
		public void ReleaseAllCache() {}
	}
}
