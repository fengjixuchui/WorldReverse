/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UInt32Value : MessageBase, IMessage<UInt32Value> // TypeDefIndex: 26472
{
	// Fields
	private static readonly MessageParser<UInt32Value> _parser; // 0x00
	public const int ValueFieldNumber = 1; // Metadata: 0x00B0C334
	private uint value_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UInt32Value> Parser { /* [XID] */ /* 0x00000001896170C0-0x00000001896170E0 */ get => default; } // 0x00000001836FE730-0x00000001836FE800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x000000018961EC60-0x000000018961EC80 */ get => default; } // 0x00000001836FE2B0-0x00000001836FE3A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189626060-0x0000000189626080 */ get => default; } // 0x00000001836FDEE0-0x00000001836FDFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x000000018962DA40-0x000000018962DA60 */ get => default; } // 0x00000001836FD740-0x00000001836FD7E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x0000000189635620-0x0000000189635640 */ get => default; } // 0x00000001836FED30-0x00000001836FEE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x000000018963CC80-0x000000018963CCA0 */ get => default; } // 0x00000001836FEAD0-0x00000001836FEB70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x00000001896442C0-0x00000001896442E0 */ get => default; } // 0x00000001836FE500-0x00000001836FE600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x000000018964BA50-0x000000018964BA70 */ get => default; } // 0x00000001836FEC90-0x00000001836FED30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x00000001896531C0-0x00000001896531E0 */ get => default; } // 0x00000001836FE090-0x00000001836FE190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Value { /* [XID] */ /* 0x0000000189699EE0-0x0000000189699F00 */ get => default; /* [XID] */ /* 0x00000001896A1640-0x00000001896A1660 */ set {} } // 0x00000001836FE420-0x00000001836FE500 0x00000001836FE940-0x00000001836FEA20

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UInt32Value() {} // 0x00000001836FF0A0-0x00000001836FF100
	static UInt32Value() {} // 0x00000001836FEFE0-0x00000001836FF0A0

	// Methods
	[DebuggerNonUserCode] // 0x000000018965A8A0-0x000000018965A8E0
	// [XID] // 0x000000018965A8A0-0x000000018965A8E0
	public UInt32Value Clone() => default; // 0x00000001836FE600-0x00000001836FE730
	[DebuggerNonUserCode] // 0x0000000189664FA0-0x0000000189664FE0
	// [XID] // 0x0000000189664FA0-0x0000000189664FE0
	public UInt32Value ShallowCopy() => default; // 0x00000001836FDFB0-0x00000001836FE090
	[DebuggerNonUserCode] // 0x000000018966FC60-0x000000018966FCA0
	// [XID] // 0x000000018966FC60-0x000000018966FCA0
	protected override void InternalSetInPool(bool value) {} // 0x00000001836FD9A0-0x00000001836FDA50
	[DebuggerNonUserCode] // 0x000000018967A470-0x000000018967A4B0
	// [XID] // 0x000000018967A470-0x000000018967A4B0
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836FE890-0x00000001836FE940
	[DebuggerNonUserCode] // 0x0000000189684C00-0x0000000189684C40
	// [XID] // 0x0000000189684C00-0x0000000189684C40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836FEA20-0x00000001836FEAD0
	[DebuggerNonUserCode] // 0x000000018968FA70-0x000000018968FAB0
	// [XID] // 0x000000018968FA70-0x000000018968FAB0
	public override void Reset() {} // 0x00000001836FDA50-0x00000001836FDAF0
	[DebuggerNonUserCode] // 0x00000001896A8B50-0x00000001896A8BA0
	// [IDTag] // 0x00000001896A8B50-0x00000001896A8BA0
	// [XID] // 0x00000001896A8B50-0x00000001896A8BA0
	public override bool Equals(object other) => default; // 0x00000001836FDB60-0x00000001836FDC70
	[DebuggerNonUserCode] // 0x00000001896B6030-0x00000001896B6080
	// [IDTag] // 0x00000001896B6030-0x00000001896B6080
	// [XID] // 0x00000001896B6030-0x00000001896B6080
	public bool Equals(UInt32Value other) => default; // 0x00000001836FDC70-0x00000001836FDDB0
	[DebuggerNonUserCode] // 0x00000001896C3050-0x00000001896C3090
	// [XID] // 0x00000001896C3050-0x00000001896C3090
	public override int GetHashCode() => default; // 0x00000001836FE190-0x00000001836FE2B0
	[DebuggerNonUserCode] // 0x00000001896CD6C0-0x00000001896CD700
	// [XID] // 0x00000001896CD6C0-0x00000001896CD700
	public override string ToString() => default; // 0x00000001836FEE30-0x00000001836FEFE0
	[DebuggerNonUserCode] // 0x00000001896D7AE0-0x00000001896D7B20
	// [XID] // 0x00000001896D7AE0-0x00000001896D7B20
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001836FEB70-0x00000001836FEC90
	[DebuggerNonUserCode] // 0x00000001896E2310-0x00000001896E2350
	// [XID] // 0x00000001896E2310-0x00000001896E2350
	public override int CalculateSize() => default; // 0x00000001836FDDB0-0x00000001836FDEE0
	[DebuggerNonUserCode] // 0x00000001896EC610-0x00000001896EC650
	// [XID] // 0x00000001896EC610-0x00000001896EC650
	public void CopyFrom(UInt32Value other) {} // 0x00000001836FD850-0x00000001836FD9A0
	[DebuggerNonUserCode] // 0x00000001896F6EC0-0x00000001896F6F00
	// [XID] // 0x00000001896F6EC0-0x00000001896F6F00
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001836FD620-0x00000001836FD740
}

