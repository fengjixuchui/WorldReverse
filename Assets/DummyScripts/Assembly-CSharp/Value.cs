/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Value : MessageBase, IMessage<Value> // TypeDefIndex: 26450
{
	// Fields
	private static readonly MessageParser<Value> _parser; // 0x00
	public const int NullValueFieldNumber = 1; // Metadata: 0x00B0C1F4
	public const int NumberValueFieldNumber = 2; // Metadata: 0x00B0C1F8
	public const int StringValueFieldNumber = 3; // Metadata: 0x00B0C1FC
	public const int BoolValueFieldNumber = 4; // Metadata: 0x00B0C200
	public const int StructValueFieldNumber = 5; // Metadata: 0x00B0C204
	public const int ListValueFieldNumber = 6; // Metadata: 0x00B0C208
	private object kind_; // 0x18
	private KindOneofCase kindCase_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Value> Parser { /* [XID] */ /* 0x00000001899AA510-0x00000001899AA530 */ get => default; } // 0x0000000182377790-0x0000000182377860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x00000001899B1EF0-0x00000001899B1F10 */ get => default; } // 0x0000000182376F40-0x0000000182377010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x00000001899B9270-0x00000001899B9290 */ get => default; } // 0x0000000182376730-0x0000000182376800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x00000001899C0BC0-0x00000001899C0BE0 */ get => default; } // 0x00000001823753E0-0x0000000182375480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x00000001899C82C0-0x00000001899C82E0 */ get => default; } // 0x0000000182378230-0x0000000182378330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x00000001899CFD20-0x00000001899CFD40 */ get => default; } // 0x0000000182377CD0-0x0000000182377D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x00000001899D7150-0x00000001899D7170 */ get => default; } // 0x0000000182377360-0x0000000182377460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x00000001899DE5C0-0x00000001899DE5E0 */ get => default; } // 0x0000000182378190-0x0000000182378230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x00000001899E62C0-0x00000001899E62E0 */ get => default; } // 0x00000001823769E0-0x0000000182376AE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public NullValue NullValue { /* [XID] */ /* 0x0000000189A32FE0-0x0000000189A33000 */ get => default; /* [XID] */ /* 0x0000000189A3A8F0-0x0000000189A3A910 */ set {} } // 0x0000000182377250-0x0000000182377360 0x00000001823768E0-0x00000001823769E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public double NumberValue { /* [XID] */ /* 0x0000000189A42240-0x0000000189A42260 */ get => default; /* [XID] */ /* 0x0000000189A49850-0x0000000189A49870 */ set {} } // 0x0000000182377A50-0x0000000182377B70 0x0000000182377590-0x0000000182377690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string StringValue { /* [XID] */ /* 0x0000000189A511A0-0x0000000189A511C0 */ get => default; /* [XID] */ /* 0x0000000189A586E0-0x0000000189A58700 */ set {} } // 0x0000000182376E30-0x0000000182376F40 0x0000000182376D30-0x0000000182376E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool BoolValue { /* [XID] */ /* 0x0000000189A602B0-0x0000000189A602D0 */ get => default; /* [XID] */ /* 0x0000000189A67DE0-0x0000000189A67E00 */ set {} } // 0x0000000182377090-0x00000001823771B0 0x0000000182377E60-0x0000000182377F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Struct StructValue { /* [XID] */ /* 0x0000000189A6F1F0-0x0000000189A6F210 */ get => default; /* [XID] */ /* 0x0000000189A76A50-0x0000000189A76A70 */ set {} } // 0x0000000182377690-0x0000000182377790 0x00000001823755F0-0x00000001823756E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ListValue ListValue { /* [XID] */ /* 0x0000000189A7E320-0x0000000189A7E340 */ get => default; /* [XID] */ /* 0x0000000189A85CA0-0x0000000189A85CC0 */ set {} } // 0x00000001823754F0-0x00000001823755F0 0x0000000182377D70-0x0000000182377E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public KindOneofCase KindCase { /* [XID] */ /* 0x0000000189A8D5A0-0x0000000189A8D5C0 */ get => default; } // 0x0000000182375090-0x0000000182375130 

	// Nested types
	public enum KindOneofCase // TypeDefIndex: 26451
	{
		None = 0,
		NullValue = 1,
		NumberValue = 2,
		StringValue = 3,
		BoolValue = 4,
		StructValue = 5,
		ListValue = 6
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Value() {} // 0x0000000182378B60-0x0000000182378BD0
	static Value() {} // 0x0000000182378AA0-0x0000000182378B60

	// Methods
	[DebuggerNonUserCode] // 0x00000001899ED6F0-0x00000001899ED730
	// [XID] // 0x00000001899ED6F0-0x00000001899ED730
	public Value Clone() => default; // 0x0000000182377460-0x0000000182377590
	[DebuggerNonUserCode] // 0x00000001899F7F20-0x00000001899F7F60
	// [XID] // 0x00000001899F7F20-0x00000001899F7F60
	public Value ShallowCopy() => default; // 0x0000000182376800-0x00000001823768E0
	[DebuggerNonUserCode] // 0x0000000189A024C0-0x0000000189A02500
	// [XID] // 0x0000000189A024C0-0x0000000189A02500
	protected override void InternalSetInPool(bool value) {} // 0x0000000182375A40-0x0000000182375BB0
	[DebuggerNonUserCode] // 0x0000000189A0CAC0-0x0000000189A0CB00
	// [XID] // 0x0000000189A0CAC0-0x0000000189A0CB00
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823778F0-0x0000000182377A50
	[DebuggerNonUserCode] // 0x0000000189A16F40-0x0000000189A16F80
	// [XID] // 0x0000000189A16F40-0x0000000189A16F80
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182377B70-0x0000000182377CD0
	[DebuggerNonUserCode] // 0x0000000189A21480-0x0000000189A214C0
	// [XID] // 0x0000000189A21480-0x0000000189A214C0
	public override void Reset() {} // 0x0000000182375BB0-0x0000000182375C50
	// [XID] // 0x0000000189A2B9E0-0x0000000189A2BA00
	public void resetKind() {} // 0x0000000182378330-0x00000001823784A0
	[DebuggerNonUserCode] // 0x0000000189A94B20-0x0000000189A94B60
	// [XID] // 0x0000000189A94B20-0x0000000189A94B60
	public void ClearKind() {} // 0x00000001823771B0-0x0000000182377250
	[DebuggerNonUserCode] // 0x0000000189A9F290-0x0000000189A9F2E0
	// [IDTag] // 0x0000000189A9F290-0x0000000189A9F2E0
	// [XID] // 0x0000000189A9F290-0x0000000189A9F2E0
	public override bool Equals(object other) => default; // 0x0000000182376070-0x0000000182376180
	[DebuggerNonUserCode] // 0x0000000189AACB80-0x0000000189AACBD0
	// [IDTag] // 0x0000000189AACB80-0x0000000189AACBD0
	// [XID] // 0x0000000189AACB80-0x0000000189AACBD0
	public bool Equals(Value other) => default; // 0x0000000182376180-0x00000001823763F0
	[DebuggerNonUserCode] // 0x0000000189ABA610-0x0000000189ABA650
	// [XID] // 0x0000000189ABA610-0x0000000189ABA650
	public override int GetHashCode() => default; // 0x0000000182376AE0-0x0000000182376D30
	[DebuggerNonUserCode] // 0x0000000189AC4F60-0x0000000189AC4FA0
	// [XID] // 0x0000000189AC4F60-0x0000000189AC4FA0
	public override string ToString() => default; // 0x00000001823785D0-0x0000000182378AA0
	[DebuggerNonUserCode] // 0x0000000189ACF4D0-0x0000000189ACF510
	// [XID] // 0x0000000189ACF4D0-0x0000000189ACF510
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182377F60-0x0000000182378190
	[DebuggerNonUserCode] // 0x0000000189ADA370-0x0000000189ADA3B0
	// [XID] // 0x0000000189ADA370-0x0000000189ADA3B0
	public override int CalculateSize() => default; // 0x00000001823763F0-0x0000000182376600
	[DebuggerNonUserCode] // 0x0000000189AE4DF0-0x0000000189AE4E30
	// [XID] // 0x0000000189AE4DF0-0x0000000189AE4E30
	public void CopyFrom(Value other) {} // 0x00000001823756E0-0x0000000182375930
	[DebuggerNonUserCode] // 0x0000000189AEF9D0-0x0000000189AEFA10
	// [XID] // 0x0000000189AEF9D0-0x0000000189AEFA10
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182375130-0x00000001823753E0
	// [XID] // 0x0000000189AFA0C0-0x0000000189AFA0E0
	public static Value ForString(string value) => default; // 0x00000001823784A0-0x00000001823785D0
	// [XID] // 0x0000000189B01660-0x0000000189B01680
	public static Value ForNumber(double value) => default; // 0x0000000182375930-0x0000000182375A40
	// [XID] // 0x0000000189B08BA0-0x0000000189B08BC0
	public static Value ForBool(bool value) => default; // 0x0000000182375F50-0x0000000182376070
	// [XID] // 0x0000000189B10580-0x0000000189B105A0
	public static Value ForNull() => default; // 0x0000000182375CC0-0x0000000182375DC0
	// [XID] // 0x0000000189B17700-0x0000000189B17720
	public static Value ForList(params /* 0x000000018989F6F0-0x000000018989F700 */ Value[] values) => default; // 0x0000000182375DC0-0x0000000182375F50
	// [XID] // 0x0000000189B26990-0x0000000189B269B0
	public static Value ForStruct(Struct value) => default; // 0x0000000182376600-0x0000000182376730
}

