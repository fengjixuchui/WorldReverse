/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.EmbeddedBrowser
{
	internal static class JSONParser // TypeDefIndex: 6097
	{
		// Fields
		private const int TOKEN_NONE = 0; // Metadata: 0x00ADBC37
		private const int TOKEN_CURLY_OPEN = 1; // Metadata: 0x00ADBC3B
		private const int TOKEN_CURLY_CLOSE = 2; // Metadata: 0x00ADBC3F
		private const int TOKEN_SQUARED_OPEN = 3; // Metadata: 0x00ADBC43
		private const int TOKEN_SQUARED_CLOSE = 4; // Metadata: 0x00ADBC47
		private const int TOKEN_COLON = 5; // Metadata: 0x00ADBC4B
		private const int TOKEN_COMMA = 6; // Metadata: 0x00ADBC4F
		private const int TOKEN_STRING = 7; // Metadata: 0x00ADBC53
		private const int TOKEN_NUMBER = 8; // Metadata: 0x00ADBC57
		private const int TOKEN_TRUE = 9; // Metadata: 0x00ADBC5B
		private const int TOKEN_FALSE = 10; // Metadata: 0x00ADBC5F
		private const int TOKEN_NULL = 11; // Metadata: 0x00ADBC63
		private const int BUILDER_CAPACITY = 2000; // Metadata: 0x00ADBC67
		private static readonly char[] EscapeTable; // 0x00
		private static readonly char[] EscapeCharacters; // 0x08
	
		// Constructors
		static JSONParser() {} // 0x00000001856B3360-0x00000001856B35E0
	
		// Methods
		public static JSONNode Parse(string json) => default; // 0x00000001856B2450-0x00000001856B2520
		public static bool TryDeserializeObject(string json, out JSONNode obj) {
			obj = default;
			return default;
		} // 0x00000001856B3280-0x00000001856B3360
		public static string EscapeToJavascriptString(string jsonString) => default; // 0x00000001856B0D10-0x00000001856B0F20
		private static JSONNode ParseObject(char[] json, ref int index, ref bool success) => default; // 0x00000001856B18F0-0x00000001856B1BA0
		private static JSONNode ParseArray(char[] json, ref int index, ref bool success) => default; // 0x00000001856B1450-0x00000001856B1650
		private static JSONNode ParseValue(char[] json, ref int index, ref bool success) => default; // 0x00000001856B2100-0x00000001856B2450
		private static JSONNode ParseString(char[] json, ref int index, ref bool success) => default; // 0x00000001856B1BA0-0x00000001856B2100
		private static string ConvertFromUtf32(int utf32) => default; // 0x00000001856B0AA0-0x00000001856B0C50
		private static JSONNode ParseNumber(char[] json, ref int index, ref bool success) => default; // 0x00000001856B1650-0x00000001856B18F0
		private static int GetLastIndexOfNumber(char[] json, int index) => default; // 0x00000001856B0F20-0x00000001856B0FE0
		private static void EatWhitespace(char[] json, ref int index) {} // 0x00000001856B0C50-0x00000001856B0D10
		private static int LookAhead(char[] json, int index) => default; // 0x00000001856B0FE0-0x00000001856B1080
		private static int NextToken(char[] json, ref int index) => default; // 0x00000001856B1080-0x00000001856B1450
		public static string Serialize(JSONNode node) => default; // 0x00000001856B3170-0x00000001856B3280
		private static bool SerializeValue(JSONNode value, StringBuilder builder) => default; // 0x00000001856B2DD0-0x00000001856B3170
		private static bool SerializeObject(IEnumerable<string> keys, IEnumerable<JSONNode> values, StringBuilder builder) => default; // 0x00000001856B2870-0x00000001856B2AD0
		private static bool SerializeArray(IEnumerable<JSONNode> anArray, StringBuilder builder) => default; // 0x00000001856B2520-0x00000001856B2730
		private static bool SerializeString(string aString, StringBuilder builder) => default; // 0x00000001856B2AD0-0x00000001856B2DD0
		private static bool SerializeNumber(double number, StringBuilder builder) => default; // 0x00000001856B2730-0x00000001856B2870
	}
}
