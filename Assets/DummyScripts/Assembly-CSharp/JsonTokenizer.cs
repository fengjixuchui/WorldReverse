/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal abstract class JsonTokenizer // TypeDefIndex: 26338
{
	// Fields
	private JsonToken bufferedToken; // 0x10
	internal int ObjectDepth; // 0x18

	// Nested types
	private class JsonReplayTokenizer : JsonTokenizer // TypeDefIndex: 26339
	{
		// Fields
		private readonly IList<JsonToken> tokens; // 0x20
		private readonly JsonTokenizer nextTokenizer; // 0x28
		private int nextTokenIndex; // 0x30

		// Constructors
		public JsonReplayTokenizer() {} // Dummy constructor
		internal JsonReplayTokenizer(IList<JsonToken> tokens, JsonTokenizer nextTokenizer) {} // 0x00000001858B5F40-0x00000001858B5FF0

		// Methods
		// [XID] // 0x0000000189834B40-0x0000000189834B60
		protected override JsonToken NextImpl() => default; // 0x00000001858B5E30-0x00000001858B5F40
	}

	private sealed class JsonTextTokenizer : JsonTokenizer // TypeDefIndex: 26340
	{
		// Fields
		private static readonly State ValueStates; // 0x00
		private readonly Stack<ContainerType> containerStack; // 0x20
		private readonly PushBackReader reader; // 0x28
		private State state; // 0x30

		// Nested types
		private enum ContainerType // TypeDefIndex: 26341
		{
			Document = 0,
			Object = 1,
			Array = 2
		}

		[Flags] // 0x000000018990A800-0x000000018990A810
		private enum State // TypeDefIndex: 26342
		{
			StartOfDocument = 1,
			ExpectedEndOfDocument = 2,
			ReaderExhausted = 4,
			ObjectStart = 8,
			ObjectBeforeColon = 16,
			ObjectAfterColon = 32,
			ObjectAfterProperty = 64,
			ObjectAfterComma = 128,
			ArrayStart = 256,
			ArrayAfterValue = 512,
			ArrayAfterComma = 1024
		}

		private class PushBackReader // TypeDefIndex: 26343
		{
			// Fields
			private readonly TextReader reader; // 0x10
			private char? nextChar; // 0x18

			// Constructors
			public PushBackReader() {} // Dummy constructor
			internal PushBackReader(TextReader reader) {} // 0x00000001858B5DC0-0x00000001858B5E30

			// Methods
			// [XID] // 0x00000001898A3170-0x00000001898A3190
			internal char? Read() => default; // 0x00000001858B5B90-0x00000001858B5CA0
			// [XID] // 0x00000001898AA590-0x00000001898AA5B0
			internal char ReadOrFail(string messageOnFailure) => default; // 0x00000001858B5A80-0x00000001858B5B90
			// [XID] // 0x00000001898B1FC0-0x00000001898B1FE0
			internal void PushBack(char c) {} // 0x00000001858B5CA0-0x00000001858B5DC0
			// [XID] // 0x00000001898B9D10-0x00000001898B9D30
			internal InvalidJsonException CreateException(string message) => default; // 0x00000001858B59B0-0x00000001858B5A80
		}

		// Constructors
		public JsonTextTokenizer() {} // Dummy constructor
		internal JsonTextTokenizer(TextReader reader) {} // 0x0000000185898410-0x0000000185898560
		static JsonTextTokenizer() {} // 0x00000001858983B0-0x0000000185898410

		// Methods
		// [XID] // 0x000000018983C230-0x000000018983C250
		protected override JsonToken NextImpl() => default; // 0x0000000185896E70-0x0000000185897580
		// [XID] // 0x0000000189843810-0x0000000189843830
		private void ValidateState(State validStates, string errorPrefix) {} // 0x0000000185896730-0x0000000185896880
		// [XID] // 0x000000018984AD60-0x000000018984AD80
		private string ReadString() => default; // 0x0000000185897E40-0x0000000185898190
		// [XID] // 0x0000000189852020-0x0000000189852040
		private char ReadEscapedCharacter() => default; // 0x00000001858976A0-0x0000000185897910
		// [XID] // 0x00000001898599E0-0x0000000189859A00
		private char ReadUnicodeEscape() => default; // 0x0000000185897C10-0x0000000185897E40
		// [XID] // 0x0000000189860B80-0x0000000189860BA0
		private void ConsumeLiteral(string text) {} // 0x0000000185898190-0x00000001858983B0
		// [XID] // 0x00000001898682B0-0x00000001898682D0
		private double ReadNumber(char initialCharacter) => default; // 0x0000000185896300-0x0000000185896730
		// [XID] // 0x000000018986F790-0x000000018986F7B0
		private char? ReadInt(StringBuilder builder) => default; // 0x0000000185896CE0-0x0000000185896E70
		// [XID] // 0x0000000189876D60-0x0000000189876D80
		private char? ReadFrac(StringBuilder builder) => default; // 0x0000000185897580-0x00000001858976A0
		// [XID] // 0x000000018987E850-0x000000018987E870
		private char? ReadExp(StringBuilder builder) => default; // 0x0000000185896880-0x0000000185896B60
		// [XID] // 0x0000000189885C70-0x0000000189885C90
		private char? ConsumeDigits(StringBuilder builder, out int count) {
			count = default;
			return default;
		} // 0x0000000185896B60-0x0000000185896CE0
		// [XID] // 0x000000018988CFC0-0x000000018988CFE0
		private void ValidateAndModifyStateForValue(string errorPrefix) {} // 0x0000000185897910-0x0000000185897A70
		// [XID] // 0x0000000189894630-0x0000000189894650
		private void PopContainer() {} // 0x0000000185897A70-0x0000000185897C10
	}

	// Constructors
	protected JsonTokenizer() {} // 0x000000018589BAC0-0x000000018589BB20

	// Methods
	// [XID] // 0x000000018980F8F0-0x000000018980F910
	internal static JsonTokenizer FromTextReader(TextReader reader) => default; // 0x000000018589B6F0-0x000000018589B7C0
	// [XID] // 0x0000000189816F50-0x0000000189816F70
	internal static JsonTokenizer FromReplayedTokens(IList<JsonToken> tokens, JsonTokenizer continuation) => default; // 0x000000018589B8E0-0x000000018589B9C0
	// [XID] // 0x000000018981E7B0-0x000000018981E7D0
	internal void PushBack(JsonToken token) {} // 0x000000018589B7C0-0x000000018589B8E0
	// [XID] // 0x0000000189825CF0-0x0000000189825D10
	internal JsonToken Next() => default; // 0x000000018589B9C0-0x000000018589BAC0
	protected abstract JsonToken NextImpl();
	// [XID] // 0x000000018982D3C0-0x000000018982D3E0
	internal void SkipValue() {} // 0x000000018589B610-0x000000018589B6F0
}

