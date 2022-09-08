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
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public class JsonTextWriter : JsonWriter // TypeDefIndex: 5271
	{
		// Fields
		private readonly TextWriter _writer; // 0x60
		private Base64Encoder _base64Encoder; // 0x68
		private char _indentChar; // 0x70
		private int _indentation; // 0x74
		private char _quoteChar; // 0x78
		private bool _quoteName; // 0x7A
		private bool[] _charEscapeFlags; // 0x80
		private char[] _writeBuffer; // 0x88
		private IArrayPool<char> _arrayPool; // 0x90
		private char[] _indentChars; // 0x98
	
		// Properties
		private Base64Encoder Base64Encoder { get => default; } // 0x0000000186C81420-0x0000000186C814C0 
		public char QuoteChar { get => default; } // 0x0000000186C814C0-0x0000000186C81520 
	
		// Constructors
		public JsonTextWriter() {} // Dummy constructor
		public JsonTextWriter(TextWriter textWriter) {} // 0x0000000186C81330-0x0000000186C81420
	
		// Methods
		public override void Close() {} // 0x0000000186C7E850-0x0000000186C7E980
		public override void WriteStartObject() {} // 0x0000000186C7F7F0-0x0000000186C7F880
		public override void WriteStartArray() {} // 0x0000000186C7F670-0x0000000186C7F700
		public override void WriteStartConstructor(string name) {} // 0x0000000186C7F700-0x0000000186C7F7F0
		protected override void WriteEnd(JsonToken token) {} // 0x0000000186C7EC50-0x0000000186C7EDC0
		public override void WritePropertyName(string name) {} // 0x0000000186C7F500-0x0000000186C7F5B0
		public override void WritePropertyName(string name, bool escape) {} // 0x0000000186C7F3C0-0x0000000186C7F500
		internal override void OnStringEscapeHandlingChanged() {} // 0x0000000186C7EA00-0x0000000186C7EA60
		private void UpdateCharEscapeFlags() {} // 0x0000000186C7EA60-0x0000000186C7EB30
		protected override void WriteIndent() {} // 0x0000000186C7EF90-0x0000000186C7F0D0
		protected override void WriteValueDelimiter() {} // 0x0000000186C7F930-0x0000000186C7F9B0
		protected override void WriteIndentSpace() {} // 0x0000000186C7EF10-0x0000000186C7EF90
		private void WriteValueInternal(string value, JsonToken token) {} // 0x0000000186C7F9B0-0x0000000186C7FA40
		public override void WriteValue(object value) {} // 0x0000000186C80DC0-0x0000000186C80E40
		public override void WriteNull() {} // 0x0000000186C7F310-0x0000000186C7F3C0
		public override void WriteUndefined() {} // 0x0000000186C7F880-0x0000000186C7F930
		public override void WriteRaw(string json) {} // 0x0000000186C7F5B0-0x0000000186C7F670
		public override void WriteValue(string value) {} // 0x0000000186C80FE0-0x0000000186C810B0
		private void WriteEscapedString(string value, bool quote) {} // 0x0000000186C7EDC0-0x0000000186C7EF10
		public override void WriteValue(int value) {} // 0x0000000186C80ED0-0x0000000186C80F50
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public override void WriteValue(uint value) {} // 0x0000000186C7FBB0-0x0000000186C7FC30
		public override void WriteValue(long value) {} // 0x0000000186C80880-0x0000000186C80900
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public override void WriteValue(ulong value) {} // 0x0000000186C7FA40-0x0000000186C7FAC0
		public override void WriteValue(float value) {} // 0x0000000186C810B0-0x0000000186C81200
		public override void WriteValue(float? value) {} // 0x0000000186C80250-0x0000000186C803F0
		public override void WriteValue(double value) {} // 0x0000000186C7FCC0-0x0000000186C7FE00
		public override void WriteValue(double? value) {} // 0x0000000186C800C0-0x0000000186C80250
		public override void WriteValue(bool value) {} // 0x0000000186C80010-0x0000000186C800C0
		public override void WriteValue(short value) {} // 0x0000000186C7FC30-0x0000000186C7FCC0
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public override void WriteValue(ushort value) {} // 0x0000000186C7FF90-0x0000000186C80010
		public override void WriteValue(char value) {} // 0x0000000186C7FEE0-0x0000000186C7FF90
		public override void WriteValue(byte value) {} // 0x0000000186C80E40-0x0000000186C80ED0
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public override void WriteValue(sbyte value) {} // 0x0000000186C80F50-0x0000000186C80FE0
		public override void WriteValue(decimal value) {} // 0x0000000186C803F0-0x0000000186C804C0
		public override void WriteValue(DateTime value) {} // 0x0000000186C80A20-0x0000000186C80DC0
		public override void WriteValue(byte[] value) {} // 0x0000000186C81200-0x0000000186C81330
		public override void WriteValue(DateTimeOffset value) {} // 0x0000000186C804C0-0x0000000186C80880
		public override void WriteValue(Guid value) {} // 0x0000000186C80900-0x0000000186C80A20
		public override void WriteValue(TimeSpan value) {} // 0x0000000186C7FAC0-0x0000000186C7FBB0
		public override void WriteValue(Uri value) {} // 0x0000000186C7FE00-0x0000000186C7FEE0
		public override void WriteComment(string text) {} // 0x0000000186C7EB30-0x0000000186C7EC50
		private void EnsureWriteBuffer() {} // 0x0000000186C7E980-0x0000000186C7EA00
		private void WriteIntegerValue(long value) {} // 0x0000000186C7F230-0x0000000186C7F310
		private void WriteIntegerValue(ulong uvalue) {} // 0x0000000186C7F0D0-0x0000000186C7F230
	}
}
