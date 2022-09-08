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
	public class JsonWriterException : JsonException // TypeDefIndex: 5272
	{
		// Properties
		private string Path { get; set; } // 0x0000000186C81850-0x0000000186C818B0
	
		// Constructors
		public JsonWriterException() {} // 0x0000000186C817F0-0x0000000186C81850
		public JsonWriterException(SerializationInfo info, StreamingContext context) {} // 0x0000000186C816A0-0x0000000186C81730
		internal JsonWriterException(string message, Exception innerException, string path) {} // 0x0000000186C81730-0x0000000186C817F0
	
		// Methods
		internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex) => default; // 0x0000000186C815F0-0x0000000186C816A0
		internal static JsonWriterException Create(string path, string message, Exception ex) => default; // 0x0000000186C81520-0x0000000186C815F0
	}
}
