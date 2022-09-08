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
	public class HashSetFormatter<T> : CollectionFormatterBase<T, HashSet<T>, HashSet<T>, HashSet<T>> // TypeDefIndex: 8203
	{
		// Constructors
		public HashSetFormatter() {}
	
		// Methods
		protected override int? GetCount(HashSet<T> sequence) => default;
		protected override void Add(HashSet<T> collection, int index, T value) {}
		protected override HashSet<T> Complete(HashSet<T> intermediateCollection) => default;
		protected override HashSet<T> Create(int count) => default;
		protected override HashSet<T> GetSourceEnumerator(HashSet<T> source) => default;
	}
}
