/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullSerializer
{
	public class fsJsonParser // TypeDefIndex: 4725
	{
		// Fields
		private int _start; // 0x10
		private string _input; // 0x18
		private readonly StringBuilder _cachedStringBuilder; // 0x20
	
		// Constructors
		public fsJsonParser() {} // Dummy constructor
		private fsJsonParser(string input) {} // 0x0000000185D0E220-0x0000000185D0E2D0
	
		// Methods
		private fsResult MakeFailure(string message) => default; // 0x0000000185D0B4B0-0x0000000185D0B7B0
		private bool TryMoveNext() => default; // 0x0000000185D0C1C0-0x0000000185D0C250
		private bool HasValue() => default; // 0x0000000185D0B280-0x0000000185D0B2F0
		private bool HasValue(int offset) => default; // 0x0000000185D0B2F0-0x0000000185D0B390
		private char Character() => default; // 0x0000000185D0B210-0x0000000185D0B280
		private char Character(int offset) => default; // 0x0000000185D0B180-0x0000000185D0B210
		private void SkipSpace() {} // 0x0000000185D0BF10-0x0000000185D0C1C0
		private bool IsHex(char c) => default; // 0x0000000185D0B390-0x0000000185D0B410
		private uint ParseSingleChar(char c1, uint multipliyer) => default; // 0x0000000185D0B7B0-0x0000000185D0B850
		private uint ParseUnicode(char c1, char c2, char c3, char c4) => default; // 0x0000000185D0B850-0x0000000185D0B930
		private fsResult TryUnescapeChar(out char escaped) {
			escaped = default;
			return default;
		} // 0x0000000185D0D950-0x0000000185D0E220
		private fsResult TryParseExact(string content) => default; // 0x0000000185D0C540-0x0000000185D0C780
		private fsResult TryParseTrue(out fsData data) {
			data = default;
			return default;
		} // 0x0000000185D0D820-0x0000000185D0D950
		private fsResult TryParseFalse(out fsData data) {
			data = default;
			return default;
		} // 0x0000000185D0C780-0x0000000185D0C8B0
		private fsResult TryParseNull(out fsData data) {
			data = default;
			return default;
		} // 0x0000000185D0C8B0-0x0000000185D0CA20
		private bool IsSeparator(char c) => default; // 0x0000000185D0B410-0x0000000185D0B4B0
		private fsResult TryParseNumber(out fsData data) {
			data = default;
			return default;
		} // 0x0000000185D0CA20-0x0000000185D0D000
		private fsResult TryParseString(out string str) {
			str = default;
			return default;
		} // 0x0000000185D0D480-0x0000000185D0D820
		private fsResult TryParseArray(out fsData arr) {
			arr = default;
			return default;
		} // 0x0000000185D0C250-0x0000000185D0C540
		private fsResult TryParseObject(out fsData obj) {
			obj = default;
			return default;
		} // 0x0000000185D0D000-0x0000000185D0D480
		private fsResult RunParse(out fsData data) {
			data = default;
			return default;
		} // 0x0000000185D0BB20-0x0000000185D0BF10
		public static fsResult Parse(string input, out fsData data) {
			data = default;
			return default;
		} // 0x0000000185D0B9E0-0x0000000185D0BB20
		public static fsData Parse(string input) => default; // 0x0000000185D0B930-0x0000000185D0B9E0
	}
}
