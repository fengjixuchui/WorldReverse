/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Linq
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public class JValue : JToken, IFormattable, IComparable, IEquatable<JValue>, IComparable<JValue>, IConvertible // TypeDefIndex: 5455
	{
		// Fields
		private JTokenType _valueType; // 0x30
		private object _value; // 0x38
	
		// Properties
		public override bool HasValues { get => default; } // 0x000000018634E8A0-0x000000018634E8F0 
		public override JTokenType Type { get => default; } // 0x000000018634E8F0-0x000000018634E950 
		public object Value { get => default; } // 0x000000018634E950-0x000000018634E9B0 
	
		// Constructors
		public JValue() {} // Dummy constructor
		internal JValue(object value, JTokenType type) {} // 0x000000018634E550-0x000000018634E5F0
		public JValue(JValue other) {} // 0x000000018634E7A0-0x000000018634E8A0
		public JValue(long value) {} // 0x000000018634E5F0-0x000000018634E680
		public JValue(float value) {} // 0x000000018634E440-0x000000018634E4D0
		public JValue(bool value) {} // 0x000000018634E710-0x000000018634E7A0
		public JValue(string value) {} // 0x000000018634E4D0-0x000000018634E550
		public JValue(object value) {} // 0x000000018634E680-0x000000018634E710
	
		// Methods
		internal override bool DeepEquals(JToken node) => default; // 0x000000018634C5B0-0x000000018634C680
		internal static int Compare(JTokenType valueType, object objA, object objB) => default; // 0x000000018634B960-0x000000018634C420
		private static int CompareFloat(object objA, object objB) => default; // 0x000000018634B7A0-0x000000018634B8D0
		internal override JToken CloneToken() => default; // 0x000000018634B720-0x000000018634B7A0
		public static JValue CreateComment(string value) => default; // 0x000000018634C420-0x000000018634C4B0
		public static JValue CreateNull() => default; // 0x000000018634C4B0-0x000000018634C530
		public static JValue CreateUndefined() => default; // 0x000000018634C530-0x000000018634C5B0
		private static JTokenType GetValueType(JTokenType? current, object value) => default; // 0x000000018634C9A0-0x000000018634CD20
		private static JTokenType GetStringValueType(JTokenType? current) => default; // 0x000000018634C8F0-0x000000018634C9A0
		public override void WriteTo(JsonWriter writer, params /* 0x000000018989F6F0-0x000000018989F700 */ JsonConverter[] converters) {} // 0x000000018634DA80-0x000000018634E440
		internal override int GetDeepHashCode() => default; // 0x000000018634C7D0-0x000000018634C870
		private static bool ValuesEquals(JValue v1, JValue v2) => default; // 0x000000018634D9D0-0x000000018634DA80
		public bool Equals(JValue other) => default; // 0x000000018634C750-0x000000018634C7D0
		public override bool Equals(object obj) => default; // 0x000000018634C680-0x000000018634C750
		public override int GetHashCode() => default; // 0x000000018634C870-0x000000018634C8F0
		public override string ToString() => default; // 0x000000018634D7A0-0x000000018634D850
		public string ToString(IFormatProvider formatProvider) => default; // 0x000000018634D850-0x000000018634D8D0
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018634D8D0-0x000000018634D9D0
		int IComparable.CompareTo(object obj) => default; // 0x000000018634CD20-0x000000018634CE90
		public int CompareTo(JValue obj) => default; // 0x000000018634B8D0-0x000000018634B960
		TypeCode IConvertible.GetTypeCode() => default; // 0x000000018634CE90-0x000000018634CF20
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x000000018634CF20-0x000000018634CFB0
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x000000018634D040-0x000000018634D0D0
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x000000018634D450-0x000000018634D4E0
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x000000018634CFB0-0x000000018634D040
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x000000018634D2A0-0x000000018634D330
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x000000018634D5F0-0x000000018634D680
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x000000018634D330-0x000000018634D3C0
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x000000018634D680-0x000000018634D710
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x000000018634D3C0-0x000000018634D450
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x000000018634D710-0x000000018634D7A0
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x000000018634D4E0-0x000000018634D570
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x000000018634D210-0x000000018634D2A0
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x000000018634D170-0x000000018634D210
		DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x000000018634D0D0-0x000000018634D170
		object IConvertible.ToType(System.Type conversionType, IFormatProvider provider) => default; // 0x000000018634D570-0x000000018634D5F0
	}
}
