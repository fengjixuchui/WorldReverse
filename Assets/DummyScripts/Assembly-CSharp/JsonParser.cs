/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text.RegularExpressions;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class JsonParser // TypeDefIndex: 26334
{
	// Fields
	private static readonly Regex TimestampRegex; // 0x00
	private static readonly Regex DurationRegex; // 0x08
	private static readonly int[] SubsecondScalingFactors; // 0x10
	private static readonly char[] FieldMaskPathSeparators; // 0x18
	private static readonly JsonParser defaultInstance; // 0x20
	private static readonly Dictionary<string, Action<JsonParser, IMessage, JsonTokenizer>> WellKnownTypeHandlers; // 0x28
	private readonly Settings settings; // 0x10

	// Properties
	public static JsonParser Default { /* [XID] */ /* 0x000000018965A950-0x000000018965A970 */ get => default; } // 0x00000001827323D0-0x00000001827324A0 

	// Nested types
	public sealed class Settings // TypeDefIndex: 26335
	{
		// Fields
		public static readonly Settings Default; // 0x00
		public readonly int RecursionLimit; // 0x10
		public readonly TypeRegistry TypeRegistry; // 0x18

		// Properties
		public bool IgnoreUnknownFields { /* [XID] */ /* 0x0000000189762540-0x0000000189762580 */ get; private set; } // 0x0000000182720D50-0x0000000182720DB0 0x0000000182720DB0-0x0000000182720E10

		// Constructors
		public Settings() {} // Dummy constructor
		static Settings() {} // 0x0000000182720E10-0x0000000182720EA0
		private Settings(int recursionLimit, TypeRegistry typeRegistry, bool ignoreUnknownFields) {} // 0x0000000182720EA0-0x0000000182720F70
		public Settings(int recursionLimit) {} // 0x0000000182721000-0x00000001827210B0
		public Settings(int recursionLimit, TypeRegistry typeRegistry) {} // 0x0000000182720F70-0x0000000182721000

		// Methods
		// [XID] // 0x0000000189773F70-0x0000000189773F90
		public Settings WithIgnoreUnknownFields(bool ignoreUnknownFields) => default; // 0x0000000182720C60-0x0000000182720D50
	}

	// Constructors
	public JsonParser() {} // Dummy constructor
	public JsonParser(Settings settings) {} // 0x00000001827335A0-0x0000000182733610
	static JsonParser() {} // 0x00000001827328B0-0x00000001827335A0

	// Methods
	// [XID] // 0x0000000189653200-0x0000000189653220
	private static void MergeWrapperField(JsonParser parser, IMessage message, JsonTokenizer tokenizer) {} // 0x000000018272C9B0-0x000000018272CAE0
	// [IDTag] // 0x0000000189661EF0-0x0000000189661F30
	// [XID] // 0x0000000189661EF0-0x0000000189661F30
	internal void Merge(IMessage message, string json) {} // 0x000000018272DC90-0x000000018272DD90
	// [IDTag] // 0x000000018966C640-0x000000018966C680
	// [XID] // 0x000000018966C640-0x000000018966C680
	internal void Merge(IMessage message, TextReader jsonReader) {} // 0x000000018272DD90-0x000000018272DEF0
	// [IDTag] // 0x0000000189677500-0x0000000189677540
	// [XID] // 0x0000000189677500-0x0000000189677540
	private void Merge(IMessage message, JsonTokenizer tokenizer) {} // 0x000000018272D670-0x000000018272DC90
	// [XID] // 0x0000000189681CC0-0x0000000189681CE0
	private void MergeField(IMessage message, FieldDescriptor field, JsonTokenizer tokenizer) {} // 0x000000018272ED60-0x000000018272EFC0
	// [XID] // 0x00000001896897C0-0x00000001896897E0
	private void MergeRepeatedField(IMessage message, FieldDescriptor field, JsonTokenizer tokenizer) {} // 0x000000018272F950-0x000000018272FCA0
	// [XID] // 0x0000000189691490-0x00000001896914B0
	private void MergeMapField(IMessage message, FieldDescriptor field, JsonTokenizer tokenizer) {} // 0x0000000182732080-0x00000001827323D0
	// [XID] // 0x0000000189698BA0-0x0000000189698BC0
	private static bool IsGoogleProtobufValueField(FieldDescriptor field) => default; // 0x000000018272E2B0-0x000000018272E420
	// [XID] // 0x00000001896A0030-0x00000001896A0050
	private object ParseSingleValue(FieldDescriptor field, JsonTokenizer tokenizer) => default; // 0x000000018272F480-0x000000018272F950
	public T Parse<T>(string json)
		where T : IMessage, new() => default;
	public T Parse<T>(TextReader jsonReader)
		where T : IMessage, new() => default;
	// [IDTag] // 0x00000001896A7370-0x00000001896A73B0
	// [XID] // 0x00000001896A7370-0x00000001896A73B0
	public IMessage Parse(string json, MessageDescriptor descriptor) => default; // 0x00000001827324A0-0x00000001827325D0
	// [IDTag] // 0x00000001896B1270-0x00000001896B12B0
	// [XID] // 0x00000001896B1270-0x00000001896B12B0
	public IMessage Parse(TextReader jsonReader, MessageDescriptor descriptor) => default; // 0x00000001827325D0-0x0000000182732700
	// [XID] // 0x00000001896BBBB0-0x00000001896BBBD0
	private void MergeStructValue(IMessage message, JsonTokenizer tokenizer) {} // 0x000000018272EFC0-0x000000018272F480
	// [XID] // 0x00000001896C30B0-0x00000001896C30D0
	private void MergeStruct(IMessage message, JsonTokenizer tokenizer) {} // 0x0000000182732700-0x00000001827328B0
	// [XID] // 0x00000001896CA540-0x00000001896CA560
	private void MergeAny(IMessage message, JsonTokenizer tokenizer) {} // 0x0000000182730640-0x0000000182730B50
	// [XID] // 0x00000001896D1BB0-0x00000001896D1BD0
	private void MergeWellKnownTypeAnyBody(IMessage body, JsonTokenizer tokenizer) {} // 0x000000018272CCE0-0x000000018272CEE0
	// [XID] // 0x00000001896D93C0-0x00000001896D93E0
	private static object ParseMapKey(FieldDescriptor field, string keyText) => default; // 0x000000018272D020-0x000000018272D670
	// [XID] // 0x00000001896E0C00-0x00000001896E0C20
	private static object ParseSingleNumberValue(FieldDescriptor field, JsonToken token) => default; // 0x0000000182731A20-0x0000000182732080
	// [XID] // 0x00000001896E7E70-0x00000001896E7E90
	private static void CheckInteger(double value) {} // 0x000000018272EB70-0x000000018272ED60
	// [XID] // 0x00000001896EF5D0-0x00000001896EF5F0
	private static object ParseSingleStringValue(FieldDescriptor field, string text) => default; // 0x0000000182730C90-0x0000000182731590
	// [XID] // 0x00000001896F6F00-0x00000001896F6F20
	private static IMessage NewMessageForField(FieldDescriptor field) => default; // 0x0000000182731590-0x0000000182731660
	private static T ParseNumericString<T>(string text, Func<string, NumberStyles, IFormatProvider, T> parser) => default;
	// [XID] // 0x00000001896FE790-0x00000001896FE7B0
	private static void ValidateInfinityAndNan(string text, bool isPositiveInfinity, bool isNegativeInfinity, bool isNaN) {} // 0x000000018272CAE0-0x000000018272CCE0
	// [XID] // 0x00000001897059D0-0x00000001897059F0
	private static void MergeTimestamp(IMessage message, JsonToken token) {} // 0x000000018272FCA0-0x0000000182730640
	// [XID] // 0x000000018970D490-0x000000018970D4B0
	private static void MergeDuration(IMessage message, JsonToken token) {} // 0x000000018272E420-0x000000018272EB70
	// [XID] // 0x00000001897148C0-0x00000001897148E0
	private static void MergeFieldMask(IMessage message, JsonToken token) {} // 0x0000000182731660-0x0000000182731940
	// [XID] // 0x000000018971C350-0x000000018971C370
	private static string ToSnakeCase(string text) => default; // 0x000000018272DF80-0x000000018272E200
}

