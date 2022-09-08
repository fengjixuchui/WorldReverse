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
	public static class ObjectArrayPool<T> // TypeDefIndex: 7469
	{
		// Properties
		public static ObjectArrayPoolProxy<T> cache { get; private set; }
	
		// Constructors
		static ObjectArrayPool() {}
	
		// Methods
		public static T[] Allocate(uint count) => default;
		public static T[] Allocate(int count) => default;
		public static void Deallocate(T[] instance) {}
		public static void Deallocate(ref T[] instance) {}
	}
}
