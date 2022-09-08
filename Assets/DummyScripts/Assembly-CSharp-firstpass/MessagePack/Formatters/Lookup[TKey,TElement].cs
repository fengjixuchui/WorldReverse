/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MessagePack.Formatters
{
	internal class Lookup<TKey, TElement> : ILookup<TKey, TElement> // TypeDefIndex: 8211
	{
		// Fields
		private readonly Dictionary<TKey, IGrouping<TKey, TElement>> groupings;
	
		// Properties
		public IEnumerable<TElement> this[TKey key] { get => default; }
		public int Count { get => default; }
	
		// Constructors
		public Lookup() {} // Dummy constructor
		public Lookup(Dictionary<TKey, IGrouping<TKey, TElement>> groupings) {}
	
		// Methods
		public bool Contains(TKey key) => default;
		public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}
}
