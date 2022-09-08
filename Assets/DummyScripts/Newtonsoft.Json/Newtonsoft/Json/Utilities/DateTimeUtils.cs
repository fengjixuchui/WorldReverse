/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x0000000189B2BE30-0x0000000189B2BE60
	internal static class DateTimeUtils // TypeDefIndex: 5326
	{
		// Fields
		internal static readonly long InitialJavaScriptDateTicks; // 0x00
		private static readonly int[] DaysToMonth365; // 0x08
		private static readonly int[] DaysToMonth366; // 0x10
	
		// Constructors
		static DateTimeUtils() {} // 0x0000000185E52660-0x0000000185E52760
	
		// Methods
		public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind) => default; // 0x0000000185E4F0E0-0x0000000185E4F1B0
		internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone) => default; // 0x0000000185E4EA20-0x0000000185E4EC40
		private static DateTime SwitchToLocalTime(DateTime value) => default; // 0x0000000185E4EF00-0x0000000185E4EFF0
		private static DateTime SwitchToUtcTime(DateTime value) => default; // 0x0000000185E4EFF0-0x0000000185E4F0E0
		private static long ToUniversalTicks(DateTime dateTime) => default; // 0x0000000185E4F1B0-0x0000000185E4F310
		private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset) => default; // 0x0000000185E4F310-0x0000000185E4F490
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset) => default; // 0x0000000185E4E630-0x0000000185E4E6F0
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime) => default; // 0x0000000185E4E500-0x0000000185E4E630
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc) => default; // 0x0000000185E4E410-0x0000000185E4E500
		private static long UniversialTicksToJavaScriptTicks(long universialTicks) => default; // 0x0000000185E517F0-0x0000000185E518A0
		internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks) => default; // 0x0000000185E4E6F0-0x0000000185E4E7C0
		internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) {
			dt = default;
			return default;
		} // 0x0000000185E4F5F0-0x0000000185E4FBA0
		internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt) {
			dt = default;
			return default;
		} // 0x0000000185E4FEA0-0x0000000185E501E0
		private static DateTime CreateDateTime(DateTimeParser dateTimeParser) => default; // 0x0000000185E4E8B0-0x0000000185E4EA20
		internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) {
			dt = default;
			return default;
		} // 0x0000000185E50EC0-0x0000000185E51260
		internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) {
			dt = default;
			return default;
		} // 0x0000000185E50B30-0x0000000185E50EC0
		internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) {
			dt = default;
			return default;
		} // 0x0000000185E507B0-0x0000000185E50B30
		internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) {
			dt = default;
			return default;
		} // 0x0000000185E503C0-0x0000000185E507B0
		private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind) {
			ticks = default;
			offset = default;
			kind = default;
			return default;
		} // 0x0000000185E51260-0x0000000185E51580
		private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) {
			dt = default;
			return default;
		} // 0x0000000185E4FBA0-0x0000000185E4FD90
		private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) {
			dt = default;
			return default;
		} // 0x0000000185E4F490-0x0000000185E4F5F0
		private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt) {
			dt = default;
			return default;
		} // 0x0000000185E501E0-0x0000000185E503C0
		private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) {
			dt = default;
			return default;
		} // 0x0000000185E4FD90-0x0000000185E4FEA0
		private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset) {
			offset = default;
			return default;
		} // 0x0000000185E51580-0x0000000185E517F0
		internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture) {} // 0x0000000185E52110-0x0000000185E522E0
		internal static int WriteDateTimeString(char[] chars, int start, DateTime value, TimeSpan? offset, DateTimeKind kind, DateFormatHandling format) => default; // 0x0000000185E51C40-0x0000000185E52110
		internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt) => default; // 0x0000000185E522E0-0x0000000185E52660
		private static void CopyIntToCharArray(char[] chars, int start, int value, int digits) {} // 0x0000000185E4E7C0-0x0000000185E4E8B0
		internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format) => default; // 0x0000000185E51AA0-0x0000000185E51C40
		internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture) {} // 0x0000000185E518A0-0x0000000185E51AA0
		private static void GetDateValues(DateTime td, out int year, out int month, out int day) {
			year = default;
			month = default;
			day = default;
		} // 0x0000000185E4EC40-0x0000000185E4EE50
	
		// Extension methods
		public static TimeSpan GetUtcOffset(this DateTime d) => default; // 0x0000000185E4EE50-0x0000000185E4EF00
	}
}
