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
	internal class TraceJsonWriter : JsonWriter // TypeDefIndex: 5358
	{
		// Fields
		private readonly JsonWriter _innerWriter; // 0x60
		private readonly JsonTextWriter _textWriter; // 0x68
		private readonly StringWriter _sw; // 0x70
	
		// Constructors
		public TraceJsonWriter() {} // Dummy constructor
		public TraceJsonWriter(JsonWriter innerWriter) {} // 0x0000000185E6B7E0-0x0000000185E6BB50
	
		// Methods
		public string GetSerializedJsonMessage() => default; // 0x0000000185E69D50-0x0000000185E69DD0
		public override void WriteValue(decimal value) {} // 0x0000000185E6B4A0-0x0000000185E6B580
		public override void WriteValue(bool value) {} // 0x0000000185E6A780-0x0000000185E6A840
		public override void WriteValue(byte value) {} // 0x0000000185E6B580-0x0000000185E6B640
		public override void WriteValue(byte? value) {} // 0x0000000185E6A900-0x0000000185E6A9C0
		public override void WriteValue(char value) {} // 0x0000000185E6AC20-0x0000000185E6ACE0
		public override void WriteValue(byte[] value) {} // 0x0000000185E6A6C0-0x0000000185E6A780
		public override void WriteValue(DateTime value) {} // 0x0000000185E6B640-0x0000000185E6B720
		public override void WriteValue(DateTimeOffset value) {} // 0x0000000185E6ACE0-0x0000000185E6ADE0
		public override void WriteValue(double value) {} // 0x0000000185E6ADE0-0x0000000185E6AEA0
		public override void WriteUndefined() {} // 0x0000000185E6A620-0x0000000185E6A6C0
		public override void WriteNull() {} // 0x0000000185E6A070-0x0000000185E6A110
		public override void WriteValue(float value) {} // 0x0000000185E6AAA0-0x0000000185E6AB60
		public override void WriteValue(Guid value) {} // 0x0000000185E6A9C0-0x0000000185E6AAA0
		public override void WriteValue(int value) {} // 0x0000000185E6B1A0-0x0000000185E6B260
		public override void WriteValue(long value) {} // 0x0000000185E6B020-0x0000000185E6B0E0
		public override void WriteValue(object value) {} // 0x0000000185E6B320-0x0000000185E6B3E0
		public override void WriteValue(sbyte value) {} // 0x0000000185E6AEA0-0x0000000185E6AF60
		public override void WriteValue(short value) {} // 0x0000000185E6B0E0-0x0000000185E6B1A0
		public override void WriteValue(string value) {} // 0x0000000185E6AB60-0x0000000185E6AC20
		public override void WriteValue(TimeSpan value) {} // 0x0000000185E6B260-0x0000000185E6B320
		public override void WriteValue(uint value) {} // 0x0000000185E6B3E0-0x0000000185E6B4A0
		public override void WriteValue(ulong value) {} // 0x0000000185E6B720-0x0000000185E6B7E0
		public override void WriteValue(Uri value) {} // 0x0000000185E6AF60-0x0000000185E6B020
		public override void WriteValue(ushort value) {} // 0x0000000185E6A840-0x0000000185E6A900
		public override void WriteComment(string text) {} // 0x0000000185E69DD0-0x0000000185E69E90
		public override void WriteStartArray() {} // 0x0000000185E6A420-0x0000000185E6A4C0
		public override void WriteEndArray() {} // 0x0000000185E69E90-0x0000000185E69F30
		public override void WriteStartConstructor(string name) {} // 0x0000000185E6A4C0-0x0000000185E6A580
		public override void WriteEndConstructor() {} // 0x0000000185E69F30-0x0000000185E69FD0
		public override void WritePropertyName(string name) {} // 0x0000000185E6A110-0x0000000185E6A1D0
		public override void WritePropertyName(string name, bool escape) {} // 0x0000000185E6A1D0-0x0000000185E6A2A0
		public override void WriteStartObject() {} // 0x0000000185E6A580-0x0000000185E6A620
		public override void WriteEndObject() {} // 0x0000000185E69FD0-0x0000000185E6A070
		public override void WriteRawValue(string json) {} // 0x0000000185E6A2A0-0x0000000185E6A360
		public override void WriteRaw(string json) {} // 0x0000000185E6A360-0x0000000185E6A420
		public override void Close() {} // 0x0000000185E69CB0-0x0000000185E69D50
	}
}
