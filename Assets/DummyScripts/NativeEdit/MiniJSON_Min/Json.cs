/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Image 56: NativeEdit.dll - Assembly: NativeEdit, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6676-6688

namespace MiniJSON_Min
{
	public static class Json // TypeDefIndex: 6678
	{
		// Nested types
		private sealed class Parser : IDisposable // TypeDefIndex: 6679
		{
			// Fields
			private const string WHITE_SPACE = " \t\n\r"; // Metadata: 0x00ADD9D0
			private const string WORD_BREAK = " \t\n\r{}[],:\""; // Metadata: 0x00ADD9D8
			private StringReader json; // 0x10
	
			// Properties
			private string NextWord { get => default; } // 0x000000018950B3B0-0x000000018950B580 
			private TOKEN NextToken { get => default; } // 0x000000018950B0B0-0x000000018950B3B0 
	
			// Nested types
			private enum TOKEN // TypeDefIndex: 6680
			{
				NONE = 0,
				CURLY_OPEN = 1,
				CURLY_CLOSE = 2,
				SQUARED_OPEN = 3,
				SQUARED_CLOSE = 4,
				COLON = 5,
				COMMA = 6,
				STRING = 7,
				NUMBER = 8,
				TRUE = 9,
				FALSE = 10,
				NULL = 11
			}
	
			// Constructors
			public Parser() {} // Dummy constructor
			private Parser(string jsonString) {} // 0x000000018950B010-0x000000018950B0B0
	
			// Methods
			public void Dispose() {} // 0x000000018950A420-0x000000018950A4A0
			public static object Parse(string jsonString) => default; // 0x000000018950AEB0-0x000000018950B010
			private Dictionary<string, object> ParseObject() => default; // 0x000000018950A8C0-0x000000018950AA00
			private List<object> ParseArray() => default; // 0x000000018950A5D0-0x000000018950A6E0
			private object ParseValue() => default; // 0x000000018950AE30-0x000000018950AEB0
			private object ParseByToken(TOKEN token) => default; // 0x000000018950A6E0-0x000000018950A7D0
			private string ParseString() => default; // 0x000000018950AA00-0x000000018950AE30
			private object ParseNumber() => default; // 0x000000018950A7D0-0x000000018950A8C0
			private void EatWhitespace() {} // 0x000000018950A4A0-0x000000018950A5D0
		}
	
		private sealed class Serializer // TypeDefIndex: 6681
		{
			// Fields
			private readonly StringBuilder builder; // 0x10
	
			// Constructors
			private Serializer() {} // 0x000000018950CCB0-0x000000018950CD40
	
			// Methods
			public static string Serialize(object obj) => default; // 0x000000018950CBF0-0x000000018950CCB0
			private void SerializeValue(object value) {} // 0x000000018950CA50-0x000000018950CBF0
			private void SerializeObject(IDictionary obj) {} // 0x000000018950C250-0x000000018950C550
			private void SerializeArray(IList anArray) {} // 0x000000018950BFC0-0x000000018950C250
			private void SerializeString(string str) {} // 0x000000018950C6E0-0x000000018950CA50
			private void SerializeOther(object value) {} // 0x000000018950C550-0x000000018950C6E0
		}
	
		// Methods
		public static object Deserialize(string json) => default; // 0x0000000189507CA0-0x0000000189507D10
		public static string Serialize(object obj) => default; // 0x0000000189507D10-0x0000000189507D80
	}
}
