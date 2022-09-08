/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class JsonFormatter // TypeDefIndex: 26331
{
	// Fields
	internal const string AnyTypeUrlField = "@type"; // Metadata: 0x00B0BDE6
	internal const string AnyWellKnownTypeValueField = "value"; // Metadata: 0x00B0BDEF
	internal const string AnyDiagnosticValueField = "@value"; // Metadata: 0x00B0BDF8
	private const string TypeUrlPrefix = "type.googleapis.com"; // Metadata: 0x00B0BE02
	private const string NameValueSeparator = ": "; // Metadata: 0x00B0BE19
	private const string PropertySeparator = ", "; // Metadata: 0x00B0BE1F
	public static readonly JsonFormatter Default; // 0x00
	private static readonly JsonFormatter diagnosticFormatter; // 0x08
	private static readonly string[] CommonRepresentations; // 0x10
	private readonly Settings settings; // 0x10
	private const string Hex = "0123456789abcdef"; // Metadata: 0x00B0BE25

	// Properties
	private bool DiagnosticOnly { /* [XID] */ /* 0x0000000189AC4FE0-0x0000000189AC5000 */ get => default; } // 0x00000001846DCB60-0x00000001846DCC40 
	public static JsonFormatter DiagnosticFormatter { /* [XID] */ /* 0x0000000189ACC540-0x0000000189ACC560 */ get => default; } // 0x00000001846DD490-0x00000001846DD560 

	// Nested types
	public sealed class Settings // TypeDefIndex: 26332
	{
		// Fields
		public static readonly Settings Default; // 0x00
		public readonly bool FormatDefaultValues; // 0x10
		public readonly TypeRegistry TypeRegistry; // 0x18
		public readonly bool FormatEnumsAsIntegers; // 0x20

		// Constructors
		public Settings() {} // Dummy constructor
		static Settings() {} // 0x00000001846F2490-0x00000001846F2510
		public Settings(bool formatDefaultValues) {} // 0x00000001846F25A0-0x00000001846F2650
		public Settings(bool formatDefaultValues, TypeRegistry typeRegistry) {} // 0x00000001846F2510-0x00000001846F25A0
		private Settings(bool formatDefaultValues, TypeRegistry typeRegistry, bool formatEnumsAsIntegers) {} // 0x00000001846F2650-0x00000001846F2710

		// Methods
		// [XID] // 0x0000000189B76E50-0x0000000189B76E70
		public Settings WithFormatDefaultValues(bool formatDefaultValues) => default; // 0x00000001846F2390-0x00000001846F2490
		// [XID] // 0x0000000189B7E360-0x0000000189B7E380
		public Settings WithTypeRegistry(TypeRegistry typeRegistry) => default; // 0x00000001846F2290-0x00000001846F2390
		// [XID] // 0x0000000189B85FA0-0x0000000189B85FC0
		public Settings WithFormatEnumsAsIntegers(bool formatEnumsAsIntegers) => default; // 0x00000001846F2190-0x00000001846F2290
	}

	private static class OriginalEnumValueHelper // TypeDefIndex: 26333
	{
		// Fields
		private static readonly Dictionary<System.Type, Dictionary<object, string>> dictionaries; // 0x00

		// Constructors
		static OriginalEnumValueHelper() {} // 0x00000001846F2100-0x00000001846F2190

		// Methods
		// [XID] // 0x0000000189B9BE90-0x0000000189B9BEB0
		internal static string GetOriginalName(object value) => default; // 0x00000001846F1EA0-0x00000001846F2100
		// [XID] // 0x0000000189BA3610-0x0000000189BA3630
		private static Dictionary<object, string> GetNameMapping(System.Type enumType) => default; // 0x00000001846F1A70-0x00000001846F1CD0
	}

	// Constructors
	public JsonFormatter() {} // Dummy constructor
	static JsonFormatter() {} // 0x00000001846DEFD0-0x00000001846E2750
	public JsonFormatter(Settings settings) {} // 0x00000001846E2750-0x00000001846E27C0

	// Methods
	// [IDTag] // 0x0000000189AD4280-0x0000000189AD42C0
	// [XID] // 0x0000000189AD4280-0x0000000189AD42C0
	public string Format(IMessage message) => default; // 0x00000001846DD8D0-0x00000001846DD9D0
	// [IDTag] // 0x0000000189ADEDD0-0x0000000189ADEE10
	// [XID] // 0x0000000189ADEDD0-0x0000000189ADEE10
	public void Format(IMessage message, TextWriter writer) {} // 0x00000001846DD9D0-0x00000001846DDB60
	// [XID] // 0x0000000189AE9500-0x0000000189AE9520
	public static string ToDiagnosticString(IMessage message) => default; // 0x00000001846DD390-0x00000001846DD490
	// [XID] // 0x0000000189AF1270-0x0000000189AF1290
	private void WriteMessage(TextWriter writer, IMessage message) {} // 0x00000001846DBDD0-0x00000001846DBF90
	// [XID] // 0x0000000189AF8840-0x0000000189AF8860
	private bool WriteMessageFields(TextWriter writer, IMessage message, bool assumeFirstFieldWritten) => default; // 0x00000001846DDEE0-0x00000001846DE270
	// [XID] // 0x0000000189AFFE00-0x0000000189AFFE20
	private static void WriteNull(TextWriter writer) {} // 0x00000001846DDB60-0x00000001846DDC20
	// [XID] // 0x0000000189B073E0-0x0000000189B07400
	private static bool IsDefaultValue(IFieldAccessor accessor, object value) => default; // 0x00000001846DE970-0x00000001846DEE20
	// [XID] // 0x0000000189B0EB70-0x0000000189B0EB90
	public void WriteValue(TextWriter writer, object value) {} // 0x00000001846DB040-0x00000001846DB810
	// [XID] // 0x0000000189B15F00-0x0000000189B15F20
	private void WriteWellKnownTypeValue(TextWriter writer, MessageDescriptor descriptor, object value) {} // 0x00000001846DA920-0x00000001846DB040
	// [XID] // 0x0000000189B1D610-0x0000000189B1D630
	private void WriteTimestamp(TextWriter writer, IMessage value) {} // 0x00000001846DDC20-0x00000001846DDEE0
	// [XID] // 0x0000000189B24F60-0x0000000189B24F80
	private void WriteDuration(TextWriter writer, IMessage value) {} // 0x00000001846DE270-0x00000001846DE530
	// [XID] // 0x0000000189B2C460-0x0000000189B2C480
	private void WriteFieldMask(TextWriter writer, IMessage value) {} // 0x00000001846DC960-0x00000001846DCB60
	// [XID] // 0x0000000189B33990-0x0000000189B339B0
	private void WriteAny(TextWriter writer, IMessage value) {} // 0x00000001846DC150-0x00000001846DC600
	// [XID] // 0x0000000189B3B270-0x0000000189B3B290
	private void WriteDiagnosticOnlyAny(TextWriter writer, IMessage value) {} // 0x00000001846DD560-0x00000001846DD8D0
	// [XID] // 0x0000000189B42A00-0x0000000189B42A20
	private void WriteStruct(TextWriter writer, IMessage message) {} // 0x00000001846DCC40-0x00000001846DD0D0
	// [XID] // 0x0000000189B4A550-0x0000000189B4A570
	private void WriteStructFieldValue(TextWriter writer, IMessage message) {} // 0x00000001846DC600-0x00000001846DC960
	// [XID] // 0x0000000189B51CB0-0x0000000189B51CD0
	internal void WriteList(TextWriter writer, IList list) {} // 0x00000001846DD0D0-0x00000001846DD390
	// [XID] // 0x0000000189B59510-0x0000000189B59530
	internal void WriteDictionary(TextWriter writer, IDictionary dictionary) {} // 0x00000001846DB810-0x00000001846DBDD0
	// [XID] // 0x0000000189B60D60-0x0000000189B60D80
	public static void WriteString(TextWriter writer, string text) {} // 0x00000001846DE530-0x00000001846DE970
	// [XID] // 0x0000000189B684B0-0x0000000189B684D0
	private static void HexEncodeUtf16CodeUnit(TextWriter writer, char c) {} // 0x00000001846DBF90-0x00000001846DC150
	// [XID] // 0x0000000189B6F7B0-0x0000000189B6F7D0
	internal static string ToJsonName(string name) => default; // 0x00000001846DEE20-0x00000001846DEFD0
}

