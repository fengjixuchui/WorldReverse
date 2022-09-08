/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using MessagePack;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MessagePack.Formatters
{
	public abstract class DictionaryFormatterBase<TKey, TValue, TIntermediate, TDictionary> : IMessagePackFormatter<TDictionary> // TypeDefIndex: 8212
		where TDictionary : IDictionary<TKey, TValue>
	{
		// Constructors
		protected DictionaryFormatterBase() {}
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, TDictionary value, IFormatterResolver formatterResolver) => default;
		public TDictionary Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		}
		protected abstract TIntermediate Create(int count);
		protected abstract void Add(TIntermediate collection, int index, TKey key, TValue value);
		protected abstract TDictionary Complete(TIntermediate intermediateCollection);
	}
}
