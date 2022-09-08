/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json
{
	[Serializable]
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public class JsonSerializationException : JsonException // TypeDefIndex: 5279
	{
		// Constructors
		public JsonSerializationException() {} // 0x0000000185CC9D40-0x0000000185CC9DE0
		public JsonSerializationException(string message) {} // 0x0000000185CC9C90-0x0000000185CC9D40
		public JsonSerializationException(string message, Exception innerException) {} // 0x0000000185CC9C00-0x0000000185CC9C90
		public JsonSerializationException(SerializationInfo info, StreamingContext context) {} // 0x0000000185CC9B20-0x0000000185CC9C00
	
		// Methods
		internal static JsonSerializationException Create(JsonReader reader, string message) => default; // 0x0000000185CC9A90-0x0000000185CC9B20
		internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex) => default; // 0x0000000185CC99C0-0x0000000185CC9A90
		internal static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) => default; // 0x0000000185CC98F0-0x0000000185CC99C0
	}
}
