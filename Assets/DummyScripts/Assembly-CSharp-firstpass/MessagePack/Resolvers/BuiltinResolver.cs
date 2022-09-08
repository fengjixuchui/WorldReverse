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
	public class BuiltinResolver : IFormatterResolver // TypeDefIndex: 8433
	{
		// Fields
		public static readonly IFormatterResolver Instance; // 0x00
	
		// Nested types
		private static class FormatterCache<T> // TypeDefIndex: 8434
		{
			// Fields
			public static readonly IMessagePackFormatter<T> formatter;
	
			// Constructors
			static FormatterCache() {}
		}
	
		// Constructors
		private BuiltinResolver() {} // 0x00000001859D70E0-0x00000001859D7140
		static BuiltinResolver() {} // 0x00000001859D7020-0x00000001859D70E0
	
		// Methods
		public IMessagePackFormatter<T> GetFormatter<T>() => default;
	}
}
