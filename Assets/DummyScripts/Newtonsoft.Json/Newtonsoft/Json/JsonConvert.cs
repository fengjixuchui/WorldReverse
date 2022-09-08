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

namespace Newtonsoft.Json
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public static class JsonConvert // TypeDefIndex: 5278
	{
		// Fields
		public static readonly string True; // 0x08
		public static readonly string False; // 0x10
		public static readonly string Null; // 0x18
		public static readonly string Undefined; // 0x20
		public static readonly string PositiveInfinity; // 0x28
		public static readonly string NegativeInfinity; // 0x30
		public static readonly string NaN; // 0x38
		private static readonly JsonSerializerSettings InitialSerializerSettings; // 0x40
	
		// Properties
		public static Func<JsonSerializerSettings> DefaultSettings { get; set; } // 0x0000000185CC25B0-0x0000000185CC2640 0x0000000185CC2640-0x0000000185CC26D0
	
		// Constructors
		static JsonConvert() {} // 0x0000000185CC2440-0x0000000185CC25B0
	
		// Methods
		internal static JsonSerializerSettings GetDefaultSettings() => default; // 0x0000000185CC17A0-0x0000000185CC1830
		public static string ToString(bool value) => default; // 0x0000000185CC2190-0x0000000185CC2250
		public static string ToString(char value) => default; // 0x0000000185CC2380-0x0000000185CC2440
		internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) => default; // 0x0000000185CC2250-0x0000000185CC2380
		private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) => default; // 0x0000000185CC1640-0x0000000185CC17A0
		internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) => default; // 0x0000000185CC1FA0-0x0000000185CC20D0
		private static string EnsureDecimalPlace(double value, string text) => default; // 0x0000000185CC1530-0x0000000185CC1640
		private static string EnsureDecimalPlace(string text) => default; // 0x0000000185CC1480-0x0000000185CC1530
		public static string ToString(decimal value) => default; // 0x0000000185CC20D0-0x0000000185CC2190
		public static string ToString(string value) => default; // 0x0000000185CC1D60-0x0000000185CC1DF0
		public static string ToString(string value, char delimiter) => default; // 0x0000000185CC1EF0-0x0000000185CC1FA0
		public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling) => default; // 0x0000000185CC1DF0-0x0000000185CC1EF0
		public static string SerializeObject(object value) => default; // 0x0000000185CC1CC0-0x0000000185CC1D60
		public static string SerializeObject(object value, Formatting formatting, params /* 0x000000018989F6F0-0x000000018989F700 */ JsonConverter[] converters) => default; // 0x0000000185CC1A10-0x0000000185CC1B10
		public static string SerializeObject(object value, System.Type type, JsonSerializerSettings settings) => default; // 0x0000000185CC1B10-0x0000000185CC1BD0
		public static string SerializeObject(object value, System.Type type, Formatting formatting, JsonSerializerSettings settings) => default; // 0x0000000185CC1BD0-0x0000000185CC1CC0
		private static string SerializeObjectInternal(object value, System.Type type, JsonSerializer jsonSerializer) => default; // 0x0000000185CC1830-0x0000000185CC1A10
		public static object DeserializeObject(string value) => default; // 0x0000000185CC1200-0x0000000185CC12A0
		public static T DeserializeObject<T>(string value) => default;
		public static T DeserializeObject<T>(string value, JsonSerializerSettings settings) => default;
		public static object DeserializeObject(string value, System.Type type, JsonSerializerSettings settings) => default; // 0x0000000185CC12A0-0x0000000185CC1480
	}
}
