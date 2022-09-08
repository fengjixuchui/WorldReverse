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
	public static class ObjectDictionaryPool<TKey, TValue> // TypeDefIndex: 7470
	{
		// Properties
		public static DictionaryPoolInstance<TKey, TValue> cache { get; private set; }
	
		// Constructors
		static ObjectDictionaryPool() {}
	
		// Methods
		public static Dictionary<TKey, TValue> Allocate(IEqualityComparer<TKey> comparer) => default;
		public static void Deallocate(Dictionary<TKey, TValue> instance) {}
		public static void Deallocate(ref Dictionary<TKey, TValue> instance) {}
	}
}
