/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BytesValue : MessageBase, IMessage<BytesValue> // TypeDefIndex: 26475
{
	// Fields
	private static readonly MessageParser<BytesValue> _parser; // 0x00
	public const int ValueFieldNumber = 1; // Metadata: 0x00B0C340
	private ByteString value_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BytesValue> Parser { /* [XID] */ /* 0x00000001899E4A50-0x00000001899E4A70 */ get => default; } // 0x000000018401EFD0-0x000000018401F0A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x00000001899EBF20-0x00000001899EBF40 */ get => default; } // 0x000000018401EB70-0x000000018401EC40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x00000001899F3990-0x00000001899F39B0 */ get => default; } // 0x000000018401E780-0x000000018401E850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x00000001899FB2A0-0x00000001899FB2C0 */ get => default; } // 0x000000018401DF50-0x000000018401DFF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x0000000189A024A0-0x0000000189A024C0 */ get => default; } // 0x000000018401F600-0x000000018401F700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x0000000189A09C70-0x0000000189A09C90 */ get => default; } // 0x000000018401F380-0x000000018401F420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x0000000189A11450-0x0000000189A11470 */ get => default; } // 0x000000018401EDA0-0x000000018401EEA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x0000000189A18860-0x0000000189A18880 */ get => default; } // 0x000000018401F560-0x000000018401F600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x0000000189A1FF20-0x0000000189A1FF40 */ get => default; } // 0x000000018401E930-0x000000018401EA30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ByteString Value { /* [XID] */ /* 0x0000000189A661C0-0x0000000189A661E0 */ get => default; /* [XID] */ /* 0x0000000189A6D8D0-0x0000000189A6D8F0 */ set {} } // 0x000000018401ECC0-0x000000018401EDA0 0x000000018401F1E0-0x000000018401F2D0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BytesValue() {} // 0x000000018401F950-0x000000018401F9E0
	static BytesValue() {} // 0x000000018401F890-0x000000018401F950

	// Methods
	[DebuggerNonUserCode] // 0x0000000189A27240-0x0000000189A27280
	// [XID] // 0x0000000189A27240-0x0000000189A27280
	public BytesValue Clone() => default; // 0x000000018401EEA0-0x000000018401EFD0
	[DebuggerNonUserCode] // 0x0000000189A316C0-0x0000000189A31700
	// [XID] // 0x0000000189A316C0-0x0000000189A31700
	public BytesValue ShallowCopy() => default; // 0x000000018401E850-0x000000018401E930
	[DebuggerNonUserCode] // 0x0000000189A3BF70-0x0000000189A3BFB0
	// [XID] // 0x0000000189A3BF70-0x0000000189A3BFB0
	protected override void InternalSetInPool(bool value) {} // 0x000000018401E1D0-0x000000018401E280
	[DebuggerNonUserCode] // 0x0000000189A46890-0x0000000189A468D0
	// [XID] // 0x0000000189A46890-0x0000000189A468D0
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018401F130-0x000000018401F1E0
	[DebuggerNonUserCode] // 0x0000000189A51160-0x0000000189A511A0
	// [XID] // 0x0000000189A51160-0x0000000189A511A0
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018401F2D0-0x000000018401F380
	[DebuggerNonUserCode] // 0x0000000189A5BA30-0x0000000189A5BA70
	// [XID] // 0x0000000189A5BA30-0x0000000189A5BA70
	public override void Reset() {} // 0x000000018401E280-0x000000018401E350
	[DebuggerNonUserCode] // 0x0000000189A74FD0-0x0000000189A75020
	// [IDTag] // 0x0000000189A74FD0-0x0000000189A75020
	// [XID] // 0x0000000189A74FD0-0x0000000189A75020
	public override bool Equals(object other) => default; // 0x000000018401E3C0-0x000000018401E4D0
	[DebuggerNonUserCode] // 0x0000000189A82C20-0x0000000189A82C70
	// [IDTag] // 0x0000000189A82C20-0x0000000189A82C70
	// [XID] // 0x0000000189A82C20-0x0000000189A82C70
	public bool Equals(BytesValue other) => default; // 0x000000018401E4D0-0x000000018401E640
	[DebuggerNonUserCode] // 0x0000000189A90630-0x0000000189A90670
	// [XID] // 0x0000000189A90630-0x0000000189A90670
	public override int GetHashCode() => default; // 0x000000018401EA30-0x000000018401EB70
	[DebuggerNonUserCode] // 0x0000000189A9AE70-0x0000000189A9AEB0
	// [XID] // 0x0000000189A9AE70-0x0000000189A9AEB0
	public override string ToString() => default; // 0x000000018401F700-0x000000018401F890
	[DebuggerNonUserCode] // 0x0000000189AA5310-0x0000000189AA5350
	// [XID] // 0x0000000189AA5310-0x0000000189AA5350
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018401F420-0x000000018401F560
	[DebuggerNonUserCode] // 0x0000000189AAFAD0-0x0000000189AAFB10
	// [XID] // 0x0000000189AAFAD0-0x0000000189AAFB10
	public override int CalculateSize() => default; // 0x000000018401E640-0x000000018401E780
	[DebuggerNonUserCode] // 0x0000000189ABA5B0-0x0000000189ABA5F0
	// [XID] // 0x0000000189ABA5B0-0x0000000189ABA5F0
	public void CopyFrom(BytesValue other) {} // 0x000000018401E060-0x000000018401E1D0
	[DebuggerNonUserCode] // 0x0000000189AC4F20-0x0000000189AC4F60
	// [XID] // 0x0000000189AC4F20-0x0000000189AC4F60
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018401DE30-0x000000018401DF50
}

