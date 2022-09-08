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
	public abstract class CollectionFormatterBase<TElement, TIntermediate, TEnumerator, TCollection> : IMessagePackFormatter<TCollection> // TypeDefIndex: 8196
		where TEnumerator : IEnumerator<TElement>
		where TCollection : IEnumerable<TElement>
	{
		// Constructors
		protected CollectionFormatterBase() {}
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, TCollection value, IFormatterResolver formatterResolver) => default;
		public TCollection Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		}
		protected virtual int? GetCount(TCollection sequence) => default;
		protected abstract TEnumerator GetSourceEnumerator(TCollection source);
		protected abstract TIntermediate Create(int count);
		protected abstract void Add(TIntermediate collection, int index, TElement value);
		protected abstract TCollection Complete(TIntermediate intermediateCollection);
	}
}
