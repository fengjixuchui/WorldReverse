/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using MessagePack;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MessagePack.Formatters
{
	public class InterfaceGroupingFormatter<TKey, TElement> : IMessagePackFormatter<IGrouping<TKey, TElement>> // TypeDefIndex: 8208
	{
		// Constructors
		public InterfaceGroupingFormatter() {}
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, IGrouping<TKey, TElement> value, IFormatterResolver formatterResolver) => default;
		public IGrouping<TKey, TElement> Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		}
	}
}
