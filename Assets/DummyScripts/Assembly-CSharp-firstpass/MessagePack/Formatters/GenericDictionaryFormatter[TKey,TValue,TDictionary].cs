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
	public class GenericDictionaryFormatter<TKey, TValue, TDictionary> : DictionaryFormatterBase<TKey, TValue, TDictionary, TDictionary> // TypeDefIndex: 8214
		where TDictionary : IDictionary<TKey, TValue>, new()
	{
		// Constructors
		public GenericDictionaryFormatter() {}
	
		// Methods
		protected override void Add(TDictionary collection, int index, TKey key, TValue value) {}
		protected override TDictionary Complete(TDictionary intermediateCollection) => default;
		protected override TDictionary Create(int count) => default;
	}
}
