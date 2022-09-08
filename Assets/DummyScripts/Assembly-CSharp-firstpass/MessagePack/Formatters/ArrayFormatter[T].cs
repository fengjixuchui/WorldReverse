/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using MessagePack;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MessagePack.Formatters
{
	public class ArrayFormatter<T> : IMessagePackFormatter<T[]> // TypeDefIndex: 8192
	{
		// Constructors
		public ArrayFormatter() {}
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, T[] value, IFormatterResolver formatterResolver) => default;
		public T[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		}
	}
}
