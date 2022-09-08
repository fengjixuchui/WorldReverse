/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MessagePack.Formatters
{
	public class SortedListFormatter<TKey, TValue> : DictionaryFormatterBase<TKey, TValue, SortedList<TKey, TValue>, SortedList<TKey, TValue>> // TypeDefIndex: 8216
	{
		// Constructors
		public SortedListFormatter() {}
	
		// Methods
		protected override void Add(SortedList<TKey, TValue> collection, int index, TKey key, TValue value) {}
		protected override SortedList<TKey, TValue> Complete(SortedList<TKey, TValue> intermediateCollection) => default;
		protected override SortedList<TKey, TValue> Create(int count) => default;
	}
}
