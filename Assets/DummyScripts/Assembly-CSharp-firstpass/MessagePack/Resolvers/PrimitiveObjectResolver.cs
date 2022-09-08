/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using MessagePack;
using MessagePack.Formatters;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MessagePack.Resolvers
{
	public class PrimitiveObjectResolver : IFormatterResolver // TypeDefIndex: 8436
	{
		// Fields
		public static IFormatterResolver Instance; // 0x00
	
		// Nested types
		private static class FormatterCache<T> // TypeDefIndex: 8437
		{
			// Fields
			public static readonly IMessagePackFormatter<T> formatter;
	
			// Constructors
			static FormatterCache() {}
		}
	
		// Constructors
		private PrimitiveObjectResolver() {} // 0x00000001859F3610-0x00000001859F3670
		static PrimitiveObjectResolver() {} // 0x00000001859F3550-0x00000001859F3610
	
		// Methods
		public IMessagePackFormatter<T> GetFormatter<T>() => default;
	}
}
