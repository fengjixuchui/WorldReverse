/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal static class ConvertUtils // TypeDefIndex: 5320
	{
		// Fields
		private static readonly Dictionary<System.Type, PrimitiveTypeCode> TypeCodeMap; // 0x00
		private static readonly TypeInformation[] PrimitiveTypeCodes; // 0x08
		private static readonly ThreadSafeStore<TypeConvertKey, Func<object, object>> CastConverters; // 0x10
	
		// Nested types
		internal struct TypeConvertKey : IEquatable<TypeConvertKey> // TypeDefIndex: 5321
		{
			// Fields
			private readonly System.Type _initialType; // 0x00
			private readonly System.Type _targetType; // 0x08
	
			// Properties
			public System.Type InitialType { get => default; } // 0x0000000185E6BDB0-0x0000000185E6BE10 
			public System.Type TargetType { get => default; } // 0x0000000185E6BE10-0x0000000185E6BE90 
	
			// Constructors
			public TypeConvertKey(System.Type initialType, System.Type targetType) : this() {
				_initialType = default;
				_targetType = default;
			} // 0x0000000185E6BD30-0x0000000185E6BDB0
	
			// Methods
			public override int GetHashCode() => default; // 0x0000000185E6BD20-0x0000000185E6BD30
			public override bool Equals(object obj) => default; // 0x0000000185E6BB50-0x0000000185E6BBF0
			public bool Equals(TypeConvertKey other) => default; // 0x0000000185E6BBF0-0x0000000185E6BD20
		}
	
		internal enum ConvertResult // TypeDefIndex: 5322
		{
			Success = 0,
			CannotConvertNull = 1,
			NotInstantiableType = 2,
			NoValidConversion = 3
		}
	
		// Constructors
		static ConvertUtils() {} // 0x0000000185E4BFD0-0x0000000185E4D250
	
		// Methods
		public static PrimitiveTypeCode GetTypeCode(System.Type t) => default; // 0x0000000185E4A8C0-0x0000000185E4A950
		public static PrimitiveTypeCode GetTypeCode(System.Type t, out bool isEnum) {
			isEnum = default;
			return default;
		} // 0x0000000185E4A620-0x0000000185E4A8C0
		public static TypeInformation GetTypeInformation(IConvertible convertable) => default; // 0x0000000185E4A950-0x0000000185E4AA30
		public static bool IsConvertible(System.Type t) => default; // 0x0000000185E4B020-0x0000000185E4B0E0
		public static TimeSpan ParseTimeSpan(string input) => default; // 0x0000000185E4B1E0-0x0000000185E4B270
		private static Func<object, object> CreateCastConverter(TypeConvertKey t) => default; // 0x0000000185E49F80-0x0000000185E4A310
		private static bool TryConvert(object initialValue, CultureInfo culture, System.Type targetType, out object value) {
			value = default;
			return default;
		} // 0x0000000185E4BE40-0x0000000185E4BF20
		private static ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, System.Type targetType, out object value) {
			value = default;
			return default;
		} // 0x0000000185E4B3E0-0x0000000185E4BE40
		public static object ConvertOrCast(object initialValue, CultureInfo culture, System.Type targetType) => default; // 0x0000000185E49DD0-0x0000000185E49F80
		private static object EnsureTypeAssignable(object value, System.Type initialType, System.Type targetType) => default; // 0x0000000185E4A310-0x0000000185E4A590
		internal static TypeConverter GetConverter(System.Type t) => default; // 0x0000000185E4A590-0x0000000185E4A620
		public static bool VersionTryParse(string input, out Version result) {
			result = default;
			return default;
		} // 0x0000000185E4BF20-0x0000000185E4BFD0
		public static bool IsInteger(object value) => default; // 0x0000000185E4B0E0-0x0000000185E4B1E0
		public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value) {
			value = default;
			return default;
		} // 0x0000000185E4AC60-0x0000000185E4AE40
		public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value) {
			value = default;
			return default;
		} // 0x0000000185E4AE40-0x0000000185E4B020
		public static bool TryConvertGuid(string s, out Guid g) {
			g = default;
			return default;
		} // 0x0000000185E4B270-0x0000000185E4B3E0
		public static int HexTextToInt(char[] text, int start, int end) => default; // 0x0000000185E4AB50-0x0000000185E4AC60
		private static int HexCharToInt(char ch) => default; // 0x0000000185E4AA30-0x0000000185E4AB50
	}
}
