/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UInt64Value : MessageBase, IMessage<UInt64Value> // TypeDefIndex: 26470
{
	// Fields
	private static readonly MessageParser<UInt64Value> _parser; // 0x00
	public const int ValueFieldNumber = 1; // Metadata: 0x00B0C32C
	private ulong value_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UInt64Value> Parser { /* [XID] */ /* 0x0000000189988E40-0x0000000189988E60 */ get => default; } // 0x0000000183E5DB00-0x0000000183E5DBD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x00000001899906F0-0x0000000189990710 */ get => default; } // 0x0000000183E5D680-0x0000000183E5D770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x00000001899981B0-0x00000001899981D0 */ get => default; } // 0x0000000183E5D2B0-0x0000000183E5D380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x000000018999F950-0x000000018999F970 */ get => default; } // 0x0000000183E5CB10-0x0000000183E5CBB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x00000001899A7610-0x00000001899A7630 */ get => default; } // 0x0000000183E5E100-0x0000000183E5E200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x00000001899AEE20-0x00000001899AEE40 */ get => default; } // 0x0000000183E5DEA0-0x0000000183E5DF40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x00000001899B6160-0x00000001899B6180 */ get => default; } // 0x0000000183E5D8D0-0x0000000183E5D9D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x00000001899BDE80-0x00000001899BDEA0 */ get => default; } // 0x0000000183E5E060-0x0000000183E5E100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x00000001899C5600-0x00000001899C5620 */ get => default; } // 0x0000000183E5D460-0x0000000183E5D560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong Value { /* [XID] */ /* 0x0000000189A0B2D0-0x0000000189A0B2F0 */ get => default; /* [XID] */ /* 0x0000000189A12BE0-0x0000000189A12C00 */ set {} } // 0x0000000183E5D7F0-0x0000000183E5D8D0 0x0000000183E5DD10-0x0000000183E5DDF0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UInt64Value() {} // 0x0000000183E5E470-0x0000000183E5E4D0
	static UInt64Value() {} // 0x0000000183E5E3B0-0x0000000183E5E470

	// Methods
	[DebuggerNonUserCode] // 0x00000001899CCCB0-0x00000001899CCCF0
	// [XID] // 0x00000001899CCCB0-0x00000001899CCCF0
	public UInt64Value Clone() => default; // 0x0000000183E5D9D0-0x0000000183E5DB00
	[DebuggerNonUserCode] // 0x00000001899D7090-0x00000001899D70D0
	// [XID] // 0x00000001899D7090-0x00000001899D70D0
	public UInt64Value ShallowCopy() => default; // 0x0000000183E5D380-0x0000000183E5D460
	[DebuggerNonUserCode] // 0x00000001899E1AB0-0x00000001899E1AF0
	// [XID] // 0x00000001899E1AB0-0x00000001899E1AF0
	protected override void InternalSetInPool(bool value) {} // 0x0000000183E5CD70-0x0000000183E5CE20
	[DebuggerNonUserCode] // 0x00000001899EBF40-0x00000001899EBF80
	// [XID] // 0x00000001899EBF40-0x00000001899EBF80
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E5DC60-0x0000000183E5DD10
	[DebuggerNonUserCode] // 0x00000001899F6810-0x00000001899F6850
	// [XID] // 0x00000001899F6810-0x00000001899F6850
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E5DDF0-0x0000000183E5DEA0
	[DebuggerNonUserCode] // 0x0000000189A00B60-0x0000000189A00BA0
	// [XID] // 0x0000000189A00B60-0x0000000189A00BA0
	public override void Reset() {} // 0x0000000183E5CE20-0x0000000183E5CEC0
	[DebuggerNonUserCode] // 0x0000000189A19F10-0x0000000189A19F60
	// [IDTag] // 0x0000000189A19F10-0x0000000189A19F60
	// [XID] // 0x0000000189A19F10-0x0000000189A19F60
	public override bool Equals(object other) => default; // 0x0000000183E5CF30-0x0000000183E5D040
	[DebuggerNonUserCode] // 0x0000000189A27280-0x0000000189A272D0
	// [IDTag] // 0x0000000189A27280-0x0000000189A272D0
	// [XID] // 0x0000000189A27280-0x0000000189A272D0
	public bool Equals(UInt64Value other) => default; // 0x0000000183E5D040-0x0000000183E5D180
	[DebuggerNonUserCode] // 0x0000000189A34BA0-0x0000000189A34BE0
	// [XID] // 0x0000000189A34BA0-0x0000000189A34BE0
	public override int GetHashCode() => default; // 0x0000000183E5D560-0x0000000183E5D680
	[DebuggerNonUserCode] // 0x0000000189A3F310-0x0000000189A3F350
	// [XID] // 0x0000000189A3F310-0x0000000189A3F350
	public override string ToString() => default; // 0x0000000183E5E200-0x0000000183E5E3B0
	[DebuggerNonUserCode] // 0x0000000189A49810-0x0000000189A49850
	// [XID] // 0x0000000189A49810-0x0000000189A49850
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183E5DF40-0x0000000183E5E060
	[DebuggerNonUserCode] // 0x0000000189A54020-0x0000000189A54060
	// [XID] // 0x0000000189A54020-0x0000000189A54060
	public override int CalculateSize() => default; // 0x0000000183E5D180-0x0000000183E5D2B0
	[DebuggerNonUserCode] // 0x0000000189A5EA80-0x0000000189A5EAC0
	// [XID] // 0x0000000189A5EA80-0x0000000189A5EAC0
	public void CopyFrom(UInt64Value other) {} // 0x0000000183E5CC20-0x0000000183E5CD70
	[DebuggerNonUserCode] // 0x0000000189A697F0-0x0000000189A69830
	// [XID] // 0x0000000189A697F0-0x0000000189A69830
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183E5C9F0-0x0000000183E5CB10
}

