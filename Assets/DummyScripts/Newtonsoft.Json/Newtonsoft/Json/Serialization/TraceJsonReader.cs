/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal class TraceJsonReader : JsonReader, IJsonLineInfo // TypeDefIndex: 5357
	{
		// Fields
		private readonly JsonReader _innerReader; // 0x78
		private readonly JsonTextWriter _textWriter; // 0x80
		private readonly StringWriter _sw; // 0x88
	
		// Properties
		public override int Depth { get => default; } // 0x0000000185E69A30-0x0000000185E69AB0 
		public override string Path { get => default; } // 0x0000000185E69AB0-0x0000000185E69B30 
		public override Newtonsoft.Json.JsonToken TokenType { get => default; } // 0x0000000185E69B30-0x0000000185E69BB0 
		public override object Value { get => default; } // 0x0000000185E69C30-0x0000000185E69CB0 
		public override System.Type ValueType { get => default; } // 0x0000000185E69BB0-0x0000000185E69C30 
		int IJsonLineInfo.LineNumber { get => default; } // 0x0000000185E69010-0x0000000185E690A0 
		int IJsonLineInfo.LinePosition { get => default; } // 0x0000000185E690A0-0x0000000185E69130 
	
		// Constructors
		public TraceJsonReader() {} // Dummy constructor
		public TraceJsonReader(JsonReader innerReader) {} // 0x0000000185E698C0-0x0000000185E69A30
	
		// Methods
		public string GetDeserializedJsonMessage() => default; // 0x0000000185E68F00-0x0000000185E68F80
		public override bool Read() => default; // 0x0000000185E69800-0x0000000185E698C0
		public override int? ReadAsInt32() => default; // 0x0000000185E69680-0x0000000185E69740
		public override string ReadAsString() => default; // 0x0000000185E69740-0x0000000185E69800
		public override byte[] ReadAsBytes() => default; // 0x0000000185E691F0-0x0000000185E692B0
		public override decimal? ReadAsDecimal() => default; // 0x0000000185E694B0-0x0000000185E695A0
		public override double? ReadAsDouble() => default; // 0x0000000185E695A0-0x0000000185E69680
		public override bool? ReadAsBoolean() => default; // 0x0000000185E69130-0x0000000185E691F0
		public override DateTime? ReadAsDateTime() => default; // 0x0000000185E693B0-0x0000000185E694B0
		public override DateTimeOffset? ReadAsDateTimeOffset() => default; // 0x0000000185E692B0-0x0000000185E693B0
		public override void Close() {} // 0x0000000185E68E80-0x0000000185E68F00
		bool IJsonLineInfo.HasLineInfo() => default; // 0x0000000185E68F80-0x0000000185E69010
	}
}
