/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal struct DateTimeParser // TypeDefIndex: 5290
	{
		// Fields
		public int Year; // 0x00
		public int Month; // 0x04
		public int Day; // 0x08
		public int Hour; // 0x0C
		public int Minute; // 0x10
		public int Second; // 0x14
		public int Fraction; // 0x18
		public int ZoneHour; // 0x1C
		public int ZoneMinute; // 0x20
		public ParserTimeZone Zone; // 0x24
		private char[] _text; // 0x28
		private int _end; // 0x30
		private static readonly int[] Power10; // 0x00
		private static readonly int Lzyyyy; // 0x08
		private static readonly int Lzyyyy_; // 0x0C
		private static readonly int Lzyyyy_MM; // 0x10
		private static readonly int Lzyyyy_MM_; // 0x14
		private static readonly int Lzyyyy_MM_dd; // 0x18
		private static readonly int Lzyyyy_MM_ddT; // 0x1C
		private static readonly int LzHH; // 0x20
		private static readonly int LzHH_; // 0x24
		private static readonly int LzHH_mm; // 0x28
		private static readonly int LzHH_mm_; // 0x2C
		private static readonly int LzHH_mm_ss; // 0x30
		private static readonly int Lz_; // 0x34
		private static readonly int Lz_zz; // 0x38
	
		// Constructors
		static DateTimeParser() {
			Power10 = default;
			Lzyyyy = default;
			Lzyyyy_ = default;
			Lzyyyy_MM = default;
			Lzyyyy_MM_ = default;
			Lzyyyy_MM_dd = default;
			Lzyyyy_MM_ddT = default;
			LzHH = default;
			LzHH_ = default;
			LzHH_mm = default;
			LzHH_mm_ = default;
			LzHH_mm_ss = default;
			Lz_ = default;
			Lz_zz = default;
		} // 0x0000000185E4DF20-0x0000000185E4E410
	
		// Methods
		public bool Parse(char[] text, int startIndex, int length) => default; // 0x0000000185E4DF10-0x0000000185E4DF20
		private bool ParseDate(int start) => default; // 0x0000000185E4D820-0x0000000185E4D8C0
		private bool ParseTimeAndZoneAndWhitespace(int start) => default; // 0x0000000185E4D8C0-0x0000000185E4DC20
		private bool ParseTime(ref int start) => default; // 0x0000000185E4DC20-0x0000000185E4DDE0
		private bool ParseZone(int start) => default; // 0x0000000185E4DDE0-0x0000000185E4DF10
		private bool Parse4Digit(int start, out int num) {
			num = default;
			return default;
		} // 0x0000000185E4D540-0x0000000185E4D600
		private bool Parse2Digit(int start, out int num) {
			num = default;
			return default;
		} // 0x0000000185E4D3B0-0x0000000185E4D540
		private bool ParseChar(int start, char ch) => default; // 0x0000000185E4D600-0x0000000185E4D820
	}
}
