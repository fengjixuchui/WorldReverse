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
	public class StandardResolver : IFormatterResolver // TypeDefIndex: 8438
	{
		// Fields
		public static readonly IFormatterResolver Instance; // 0x00
		private static readonly IFormatterResolver[] resolvers; // 0x08
	
		// Nested types
		private static class FormatterCache<T> // TypeDefIndex: 8439
		{
			// Fields
			public static readonly IMessagePackFormatter<T> formatter;
	
			// Constructors
			static FormatterCache() {}
		}
	
		// Constructors
		private StandardResolver() {} // 0x00000001859F45E0-0x00000001859F4640
		static StandardResolver() {} // 0x00000001859F4370-0x00000001859F45E0
	
		// Methods
		public IMessagePackFormatter<T> GetFormatter<T>() => default;
	}
}
