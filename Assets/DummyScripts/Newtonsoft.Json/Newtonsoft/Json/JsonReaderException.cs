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
	public class JsonReaderException : JsonException // TypeDefIndex: 5273
	{
		// Properties
		private int LineNumber { get; set; } // 0x0000000185CC41E0-0x0000000185CC4240
		private int LinePosition { get; set; } // 0x0000000185CC4240-0x0000000185CC42A0
		private string Path { get; set; } // 0x0000000185CC42A0-0x0000000185CC4300
	
		// Constructors
		public JsonReaderException() {} // 0x0000000185CC4140-0x0000000185CC41E0
		public JsonReaderException(SerializationInfo info, StreamingContext context) {} // 0x0000000185CC4060-0x0000000185CC4140
		internal JsonReaderException(string message, Exception innerException, string path, int lineNumber, int linePosition) {} // 0x0000000185CC3F20-0x0000000185CC4060
	
		// Methods
		internal static JsonReaderException Create(JsonReader reader, string message) => default; // 0x0000000185CC3D50-0x0000000185CC3DE0
		internal static JsonReaderException Create(JsonReader reader, string message, Exception ex) => default; // 0x0000000185CC3C80-0x0000000185CC3D50
		internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) => default; // 0x0000000185CC3DE0-0x0000000185CC3F20
	}
}
