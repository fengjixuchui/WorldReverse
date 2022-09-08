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
	public class JsonTextReader : JsonReader, IJsonLineInfo // TypeDefIndex: 5268
	{
		// Fields
		private readonly TextReader _reader; // 0x78
		private char[] _chars; // 0x80
		private int _charsUsed; // 0x88
		private int _charPos; // 0x8C
		private int _lineStartPos; // 0x90
		private int _lineNumber; // 0x94
		private bool _isEndOfFile; // 0x98
		private StringBuffer _stringBuffer; // 0xA0
		private StringReference _stringReference; // 0xB0
		private IArrayPool<char> _arrayPool; // 0xC0
		internal PropertyNameTable NameTable; // 0xC8
	
		// Properties
		public int LineNumber { get => default; } // 0x0000000185CD6DD0-0x0000000185CD6EE0 
		public int LinePosition { get => default; } // 0x0000000185CD6EE0-0x0000000185CD6F50 
	
		// Constructors
		public JsonTextReader() {} // Dummy constructor
		public JsonTextReader(TextReader reader) {} // 0x0000000185CD6D10-0x0000000185CD6DD0
	
		// Methods
		private void EnsureBufferNotEmpty() {} // 0x0000000185CCEA30-0x0000000185CCEAE0
		private void OnNewLine(int pos) {} // 0x0000000185CCF1B0-0x0000000185CCF220
		private void ParseString(char quote, ReadType readType) {} // 0x0000000185CD1BC0-0x0000000185CD2120
		private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count) {} // 0x0000000185CCE470-0x0000000185CCE520
		private void ShiftBufferIfNeeded() {} // 0x0000000185CD6A70-0x0000000185CD6BA0
		private int ReadData(bool append) => default; // 0x0000000185CD4A30-0x0000000185CD4AB0
		private int ReadData(bool append, int charsRequired) => default; // 0x0000000185CD4780-0x0000000185CD4A30
		private bool EnsureChars(int relativePosition, bool append) => default; // 0x0000000185CCEB90-0x0000000185CCEC30
		private bool ReadChars(int relativePosition, bool append) => default; // 0x0000000185CD46B0-0x0000000185CD4780
		public override bool Read() => default; // 0x0000000185CD6750-0x0000000185CD6A70
		public override int? ReadAsInt32() => default; // 0x0000000185CD4570-0x0000000185CD4620
		public override DateTime? ReadAsDateTime() => default; // 0x0000000185CD4310-0x0000000185CD43E0
		public override string ReadAsString() => default; // 0x0000000185CD4620-0x0000000185CD46B0
		public override byte[] ReadAsBytes() => default; // 0x0000000185CD3C60-0x0000000185CD4240
		private object ReadStringValue(ReadType readType) => default; // 0x0000000185CD5DB0-0x0000000185CD6750
		private JsonReaderException CreateUnexpectedCharacterException(char c) => default; // 0x0000000185CCE6E0-0x0000000185CCE800
		public override bool? ReadAsBoolean() => default; // 0x0000000185CD3290-0x0000000185CD3C60
		private void ProcessValueComma() {} // 0x0000000185CD31F0-0x0000000185CD3290
		private object ReadNumberValue(ReadType readType) => default; // 0x0000000185CD4FE0-0x0000000185CD5690
		public override DateTimeOffset? ReadAsDateTimeOffset() => default; // 0x0000000185CD4240-0x0000000185CD4310
		public override decimal? ReadAsDecimal() => default; // 0x0000000185CD43E0-0x0000000185CD44B0
		public override double? ReadAsDouble() => default; // 0x0000000185CD44B0-0x0000000185CD4570
		private void HandleNull() {} // 0x0000000185CCEC30-0x0000000185CCED60
		private void ReadFinished() {} // 0x0000000185CD4AB0-0x0000000185CD4C60
		private bool ReadNullChar() => default; // 0x0000000185CD4C60-0x0000000185CD4CF0
		private void EnsureBuffer() {} // 0x0000000185CCEAE0-0x0000000185CCEB90
		private void ReadStringIntoBuffer(char quote) {} // 0x0000000185CD5690-0x0000000185CD5DB0
		private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition) {} // 0x0000000185CD6C40-0x0000000185CD6D10
		private char ParseUnicode() => default; // 0x0000000185CD22E0-0x0000000185CD2410
		private void ReadNumberIntoBuffer() {} // 0x0000000185CD4CF0-0x0000000185CD4FE0
		private void ClearRecentString() {} // 0x0000000185CCE520-0x0000000185CCE5A0
		private bool ParsePostValue() => default; // 0x0000000185CD1510-0x0000000185CD1850
		private bool ParseObject() => default; // 0x0000000185CD1310-0x0000000185CD1510
		private bool ParseProperty() => default; // 0x0000000185CD1850-0x0000000185CD1BC0
		private bool ValidIdentifierChar(char value) => default; // 0x0000000185CD6BA0-0x0000000185CD6C40
		private void ParseUnquotedProperty() {} // 0x0000000185CD2410-0x0000000185CD2750
		private bool ParseValue() => default; // 0x0000000185CD2750-0x0000000185CD3030
		private void ProcessLineFeed() {} // 0x0000000185CD3140-0x0000000185CD31F0
		private void ProcessCarriageReturn(bool append) {} // 0x0000000185CD3030-0x0000000185CD3140
		private bool EatWhitespace(bool oneOrMore) => default; // 0x0000000185CCE800-0x0000000185CCE970
		private void ParseConstructor() {} // 0x0000000185CCF610-0x0000000185CCFA60
		private void ParseNumber(ReadType readType) {} // 0x0000000185CD0160-0x0000000185CD1310
		private void ParseComment(bool setToken) {} // 0x0000000185CCF220-0x0000000185CCF610
		private void EndComment(bool setToken, int initialPosition, int endPosition) {} // 0x0000000185CCE970-0x0000000185CCEA30
		private bool MatchValue(string value) => default; // 0x0000000185CCF050-0x0000000185CCF1B0
		private bool MatchValueWithTrailingSeparator(string value) => default; // 0x0000000185CCEF40-0x0000000185CCF050
		private bool IsSeparator(char c) => default; // 0x0000000185CCEDB0-0x0000000185CCEF40
		private void ParseTrue() {} // 0x0000000185CD2120-0x0000000185CD2210
		private void ParseNull() {} // 0x0000000185CCFB50-0x0000000185CCFC20
		private void ParseUndefined() {} // 0x0000000185CD2210-0x0000000185CD22E0
		private void ParseFalse() {} // 0x0000000185CCFA60-0x0000000185CCFB50
		private object ParseNumberNegativeInfinity(ReadType readType) => default; // 0x0000000185CCFDE0-0x0000000185CCFFA0
		private object ParseNumberPositiveInfinity(ReadType readType) => default; // 0x0000000185CCFFA0-0x0000000185CD0160
		private object ParseNumberNaN(ReadType readType) => default; // 0x0000000185CCFC20-0x0000000185CCFDE0
		public override void Close() {} // 0x0000000185CCE5A0-0x0000000185CCE6E0
		public bool HasLineInfo() => default; // 0x0000000185CCED60-0x0000000185CCEDB0
	}
}
