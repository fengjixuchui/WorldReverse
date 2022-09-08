/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Int32Value : MessageBase, IMessage<Int32Value> // TypeDefIndex: 26471
{
	// Fields
	private static readonly MessageParser<Int32Value> _parser; // 0x00
	public const int ValueFieldNumber = 1; // Metadata: 0x00B0C330
	private int value_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Int32Value> Parser { /* [XID] */ /* 0x0000000189ACDF20-0x0000000189ACDF40 */ get => default; } // 0x0000000182AC30F0-0x0000000182AC31C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189AD5C80-0x0000000189AD5CA0 */ get => default; } // 0x0000000182AC2C70-0x0000000182AC2D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189ADD6E0-0x0000000189ADD700 */ get => default; } // 0x0000000182AC28A0-0x0000000182AC2970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189AE4DD0-0x0000000189AE4DF0 */ get => default; } // 0x0000000182AC2100-0x0000000182AC21A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x0000000189AEC4F0-0x0000000189AEC510 */ get => default; } // 0x0000000182AC36F0-0x0000000182AC37F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x0000000189AF3F50-0x0000000189AF3F70 */ get => default; } // 0x0000000182AC3490-0x0000000182AC3530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x0000000189AFB580-0x0000000189AFB5A0 */ get => default; } // 0x0000000182AC2EC0-0x0000000182AC2FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x0000000189B02D00-0x0000000189B02D20 */ get => default; } // 0x0000000182AC3650-0x0000000182AC36F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x0000000189B0A4C0-0x0000000189B0A4E0 */ get => default; } // 0x0000000182AC2A50-0x0000000182AC2B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Value { /* [XID] */ /* 0x0000000189B50350-0x0000000189B50370 */ get => default; /* [XID] */ /* 0x0000000189B57B00-0x0000000189B57B20 */ set {} } // 0x0000000182AC2DE0-0x0000000182AC2EC0 0x0000000182AC3300-0x0000000182AC33E0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Int32Value() {} // 0x0000000182AC3A60-0x0000000182AC3AC0
	static Int32Value() {} // 0x0000000182AC39A0-0x0000000182AC3A60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B11CB0-0x0000000189B11CF0
	// [XID] // 0x0000000189B11CB0-0x0000000189B11CF0
	public Int32Value Clone() => default; // 0x0000000182AC2FC0-0x0000000182AC30F0
	[DebuggerNonUserCode] // 0x0000000189B1C2F0-0x0000000189B1C330
	// [XID] // 0x0000000189B1C2F0-0x0000000189B1C330
	public Int32Value ShallowCopy() => default; // 0x0000000182AC2970-0x0000000182AC2A50
	[DebuggerNonUserCode] // 0x0000000189B26930-0x0000000189B26970
	// [XID] // 0x0000000189B26930-0x0000000189B26970
	protected override void InternalSetInPool(bool value) {} // 0x0000000182AC2360-0x0000000182AC2410
	[DebuggerNonUserCode] // 0x0000000189B30940-0x0000000189B30980
	// [XID] // 0x0000000189B30940-0x0000000189B30980
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182AC3250-0x0000000182AC3300
	[DebuggerNonUserCode] // 0x0000000189B3B210-0x0000000189B3B250
	// [XID] // 0x0000000189B3B210-0x0000000189B3B250
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182AC33E0-0x0000000182AC3490
	[DebuggerNonUserCode] // 0x0000000189B45E30-0x0000000189B45E70
	// [XID] // 0x0000000189B45E30-0x0000000189B45E70
	public override void Reset() {} // 0x0000000182AC2410-0x0000000182AC24B0
	[DebuggerNonUserCode] // 0x0000000189B5F4D0-0x0000000189B5F520
	// [IDTag] // 0x0000000189B5F4D0-0x0000000189B5F520
	// [XID] // 0x0000000189B5F4D0-0x0000000189B5F520
	public override bool Equals(object other) => default; // 0x0000000182AC2520-0x0000000182AC2630
	[DebuggerNonUserCode] // 0x0000000189B6C7A0-0x0000000189B6C7F0
	// [IDTag] // 0x0000000189B6C7A0-0x0000000189B6C7F0
	// [XID] // 0x0000000189B6C7A0-0x0000000189B6C7F0
	public bool Equals(Int32Value other) => default; // 0x0000000182AC2630-0x0000000182AC2770
	[DebuggerNonUserCode] // 0x0000000189B79EB0-0x0000000189B79EF0
	// [XID] // 0x0000000189B79EB0-0x0000000189B79EF0
	public override int GetHashCode() => default; // 0x0000000182AC2B50-0x0000000182AC2C70
	[DebuggerNonUserCode] // 0x0000000189B84AA0-0x0000000189B84AE0
	// [XID] // 0x0000000189B84AA0-0x0000000189B84AE0
	public override string ToString() => default; // 0x0000000182AC37F0-0x0000000182AC39A0
	[DebuggerNonUserCode] // 0x0000000189B8E910-0x0000000189B8E950
	// [XID] // 0x0000000189B8E910-0x0000000189B8E950
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182AC3530-0x0000000182AC3650
	[DebuggerNonUserCode] // 0x0000000189B98F00-0x0000000189B98F40
	// [XID] // 0x0000000189B98F00-0x0000000189B98F40
	public override int CalculateSize() => default; // 0x0000000182AC2770-0x0000000182AC28A0
	[DebuggerNonUserCode] // 0x0000000189BA35D0-0x0000000189BA3610
	// [XID] // 0x0000000189BA35D0-0x0000000189BA3610
	public void CopyFrom(Int32Value other) {} // 0x0000000182AC2210-0x0000000182AC2360
	[DebuggerNonUserCode] // 0x0000000189BAD6E0-0x0000000189BAD720
	// [XID] // 0x0000000189BAD6E0-0x0000000189BAD720
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182AC1FE0-0x0000000182AC2100
}

