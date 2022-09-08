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
	public static class ObjectHashSetPool<TKey> // TypeDefIndex: 7471
	{
		// Properties
		public static HashSetPoolInstance<TKey> cache { get; private set; }
	
		// Constructors
		static ObjectHashSetPool() {}
	
		// Methods
		public static HashSet<TKey> Allocate(IEqualityComparer<TKey> comparer) => default;
		public static void Deallocate(HashSet<TKey> instance) {}
		public static void Deallocate(ref HashSet<TKey> instance) {}
	}
}
