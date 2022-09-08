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
using MiHoYo.SDK.Protobuf.Reflection;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf
{
	public sealed class JsonFormatter // TypeDefIndex: 5085
	{
		// Fields
		private static readonly JsonFormatter diagnosticFormatter; // 0x08
		private static readonly string[] CommonRepresentations; // 0x10
		private readonly Settings settings; // 0x10
	
		// Properties
		public static JsonFormatter Default { get; } // 0x0000000186512130-0x00000001865121C0 
		private bool DiagnosticOnly { get => default; } // 0x00000001865121C0-0x0000000186512250 
	
		// Nested types
		public sealed class Settings // TypeDefIndex: 5086
		{
			// Properties
			public static Settings Default { get; } // 0x0000000186513C20-0x0000000186513CB0 
			public bool FormatDefaultValues { get; } // 0x0000000186513CB0-0x0000000186513D10 
			public MiHoYo.SDK.Protobuf.Reflection.TypeRegistry TypeRegistry { get; } // 0x0000000186513D10-0x0000000186513D70 
	
			// Constructors
			public Settings() {} // Dummy constructor
			static Settings() {} // 0x0000000186513A60-0x0000000186513AE0
			public Settings(bool formatDefaultValues) {} // 0x0000000186513AE0-0x0000000186513B80
			public Settings(bool formatDefaultValues, MiHoYo.SDK.Protobuf.Reflection.TypeRegistry typeRegistry) {} // 0x0000000186513B80-0x0000000186513C20
		}
	
		private static class OriginalEnumValueHelper // TypeDefIndex: 5087
		{
			// Fields
			private static readonly Dictionary<System.Type, Dictionary<object, string>> dictionaries; // 0x00
	
			// Constructors
			static OriginalEnumValueHelper() {} // 0x0000000186512A90-0x0000000186512B20
	
			// Methods
			internal static string GetOriginalName(object value) => default; // 0x0000000186512870-0x0000000186512A90
			private static Dictionary<object, string> GetNameMapping(System.Type enumType) => default; // 0x0000000186512670-0x0000000186512870
		}
	
		// Constructors
		public JsonFormatter() {} // Dummy constructor
		static JsonFormatter() {} // 0x000000018650E960-0x00000001865120C0
		public JsonFormatter(Settings settings) {} // 0x00000001865120C0-0x0000000186512130
	
		// Methods
		public string Format(IMessage message) => default; // 0x000000018650A4D0-0x000000018650A590
		public void Format(IMessage message, TextWriter writer) {} // 0x000000018650A3B0-0x000000018650A4D0
		public static string ToDiagnosticString(IMessage message) => default; // 0x000000018650AEF0-0x000000018650AFB0
		private void WriteMessage(TextWriter writer, IMessage message) {} // 0x000000018650C990-0x000000018650CB10
		private bool WriteMessageFields(TextWriter writer, IMessage message, bool assumeFirstFieldWritten) => default; // 0x000000018650C590-0x000000018650C990
		internal static string ToCamelCase(string input) => default; // 0x000000018650ABA0-0x000000018650AEF0
		private static void WriteNull(TextWriter writer) {} // 0x000000018650CB10-0x000000018650CB90
		private static bool IsDefaultValue(MiHoYo.SDK.Protobuf.Reflection.IFieldAccessor accessor, object value) => default; // 0x000000018650A710-0x000000018650ABA0
		public void WriteValue(TextWriter writer, object value) {} // 0x000000018650DAD0-0x000000018650E210
		private void WriteWellKnownTypeValue(TextWriter writer, MiHoYo.SDK.Protobuf.Reflection.MessageDescriptor descriptor, object value) {} // 0x000000018650E210-0x000000018650E960
		private void WriteTimestamp(TextWriter writer, IMessage value) {} // 0x000000018650D7E0-0x000000018650DAD0
		private void WriteDuration(TextWriter writer, IMessage value) {} // 0x000000018650BDF0-0x000000018650C0E0
		private void WriteFieldMask(TextWriter writer, IMessage value) {} // 0x000000018650C0E0-0x000000018650C2C0
		private void WriteAny(TextWriter writer, IMessage value) {} // 0x000000018650AFB0-0x000000018650B4D0
		private void WriteDiagnosticOnlyAny(TextWriter writer, IMessage value) {} // 0x000000018650B4D0-0x000000018650B870
		private void WriteStruct(TextWriter writer, IMessage message) {} // 0x000000018650D360-0x000000018650D7E0
		private void WriteStructFieldValue(TextWriter writer, IMessage message) {} // 0x000000018650CFA0-0x000000018650D360
		internal void WriteList(TextWriter writer, IList list) {} // 0x000000018650C2C0-0x000000018650C590
		internal void WriteDictionary(TextWriter writer, IDictionary dictionary) {} // 0x000000018650B870-0x000000018650BDF0
		internal static void WriteString(TextWriter writer, string text) {} // 0x000000018650CB90-0x000000018650CFA0
		private static void HexEncodeUtf16CodeUnit(TextWriter writer, char c) {} // 0x000000018650A590-0x000000018650A710
	}
}
