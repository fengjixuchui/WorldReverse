/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MessagePack.Formatters
{
	internal class Grouping<TKey, TElement> : IGrouping<TKey, TElement> // TypeDefIndex: 8210
	{
		// Fields
		private readonly TKey key;
		private readonly IEnumerable<TElement> elements;
	
		// Properties
		public TKey Key { get => default; }
	
		// Constructors
		public Grouping() {} // Dummy constructor
		public Grouping(TKey key, IEnumerable<TElement> elements) {}
	
		// Methods
		public IEnumerator<TElement> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}
}
