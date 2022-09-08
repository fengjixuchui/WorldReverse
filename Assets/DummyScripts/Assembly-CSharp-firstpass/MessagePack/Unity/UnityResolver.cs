/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using MessagePack;
using MessagePack.Formatters;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MessagePack.Unity
{
	public class UnityResolver : IFormatterResolver // TypeDefIndex: 8450
	{
		// Fields
		public static IFormatterResolver Instance; // 0x00
	
		// Nested types
		private static class FormatterCache<T> // TypeDefIndex: 8451
		{
			// Fields
			public static readonly IMessagePackFormatter<T> formatter;
	
			// Constructors
			static FormatterCache() {}
		}
	
		// Constructors
		private UnityResolver() {} // 0x00000001859F4940-0x00000001859F49A0
		static UnityResolver() {} // 0x00000001859F4880-0x00000001859F4940
	
		// Methods
		public IMessagePackFormatter<T> GetFormatter<T>() => default;
	}
}
