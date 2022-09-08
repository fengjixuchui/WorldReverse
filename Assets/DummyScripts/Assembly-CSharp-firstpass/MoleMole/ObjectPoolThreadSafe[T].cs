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
	public static class ObjectPoolThreadSafe<T> // TypeDefIndex: 7472
		where T : class, new()
	{
		// Constructors
		static ObjectPoolThreadSafe() {}
	
		// Methods
		public static void RegisterAllocator(IObjectPoolAllocator<T> inAllocator) {}
		public static T Allocate() => default;
		public static void Deallocate(T instance) {}
		public static void Deallocate(ref T instance) {}
	}
}
