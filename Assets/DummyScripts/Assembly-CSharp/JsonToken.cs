/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class JsonToken : IEquatable<JsonToken> // TypeDefIndex: 26336
{
	// Fields
	private static readonly JsonToken _true; // 0x00
	private static readonly JsonToken _false; // 0x08
	private static readonly JsonToken _null; // 0x10
	private static readonly JsonToken startObject; // 0x18
	private static readonly JsonToken endObject; // 0x20
	private static readonly JsonToken startArray; // 0x28
	private static readonly JsonToken endArray; // 0x30
	private static readonly JsonToken endDocument; // 0x38
	private readonly TokenType type; // 0x10
	private readonly string stringValue; // 0x18
	private readonly double numberValue; // 0x20

	// Properties
	internal static JsonToken Null { /* [XID] */ /* 0x000000018977B6A0-0x000000018977B6C0 */ get => default; } // 0x0000000184278090-0x0000000184278160 
	internal static JsonToken False { /* [XID] */ /* 0x0000000189783160-0x0000000189783180 */ get => default; } // 0x00000001842785C0-0x0000000184278690 
	internal static JsonToken True { /* [XID] */ /* 0x000000018978A6F0-0x000000018978A710 */ get => default; } // 0x0000000184278810-0x00000001842788E0 
	internal static JsonToken StartObject { /* [XID] */ /* 0x0000000189791DF0-0x0000000189791E10 */ get => default; } // 0x0000000184278280-0x0000000184278350 
	internal static JsonToken EndObject { /* [XID] */ /* 0x0000000189799490-0x00000001897994B0 */ get => default; } // 0x0000000184278350-0x0000000184278420 
	internal static JsonToken StartArray { /* [XID] */ /* 0x00000001897A13B0-0x00000001897A13D0 */ get => default; } // 0x0000000184277D90-0x0000000184277E60 
	internal static JsonToken EndArray { /* [XID] */ /* 0x00000001897A8AA0-0x00000001897A8AC0 */ get => default; } // 0x0000000184277A20-0x0000000184277AF0 
	internal static JsonToken EndDocument { /* [XID] */ /* 0x00000001897B0430-0x00000001897B0450 */ get => default; } // 0x0000000184277E60-0x0000000184277F30 
	internal TokenType Type { /* [XID] */ /* 0x00000001897D4DC0-0x00000001897D4DE0 */ get => default; } // 0x0000000184277910-0x00000001842779B0 
	internal string StringValue { /* [XID] */ /* 0x00000001897DC540-0x00000001897DC560 */ get => default; } // 0x0000000184278160-0x0000000184278200 
	internal double NumberValue { /* [XID] */ /* 0x00000001897E3F70-0x00000001897E3F90 */ get => default; } // 0x0000000184278690-0x0000000184278740 

	// Nested types
	internal enum TokenType // TypeDefIndex: 26337
	{
		Null = 0,
		False = 1,
		True = 2,
		StringValue = 3,
		Number = 4,
		Name = 5,
		StartObject = 6,
		EndObject = 7,
		StartArray = 8,
		EndArray = 9,
		EndDocument = 10
	}

	// Constructors
	public JsonToken() {} // Dummy constructor
	private JsonToken(TokenType type, string stringValue = null, double numberValue = 0 /* Metadata: 0x00B0BE39 */) {} // 0x0000000184278FB0-0x0000000184279050
	static JsonToken() {} // 0x0000000184278BA0-0x0000000184278FB0

	// Methods
	// [XID] // 0x00000001897B81B0-0x00000001897B81D0
	internal static JsonToken Name(string name) => default; // 0x0000000184278740-0x0000000184278810
	// [IDTag] // 0x00000001897C0210-0x00000001897C0250
	// [XID] // 0x00000001897C0210-0x00000001897C0250
	internal static JsonToken Value(string value) => default; // 0x0000000184278420-0x00000001842784F0
	// [IDTag] // 0x00000001897CA6C0-0x00000001897CA700
	// [XID] // 0x00000001897CA6C0-0x00000001897CA700
	internal static JsonToken Value(double value) => default; // 0x00000001842784F0-0x00000001842785C0
	// [IDTag] // 0x00000001897EBAC0-0x00000001897EBB00
	// [XID] // 0x00000001897EBAC0-0x00000001897EBB00
	public override bool Equals(object obj) => default; // 0x0000000184277CC0-0x0000000184277D90
	// [XID] // 0x00000001897F6120-0x00000001897F6140
	public override int GetHashCode() => default; // 0x0000000184277F30-0x0000000184278090
	// [XID] // 0x00000001897FD760-0x00000001897FD780
	public override string ToString() => default; // 0x00000001842788E0-0x0000000184278BA0
	// [IDTag] // 0x0000000189804F50-0x0000000189804F90
	// [XID] // 0x0000000189804F50-0x0000000189804F90
	public bool Equals(JsonToken other) => default; // 0x0000000184277B60-0x0000000184277CC0
}

