/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Int64Value : MessageBase, IMessage<Int64Value> // TypeDefIndex: 26469
{
	// Fields
	private static readonly MessageParser<Int64Value> _parser; // 0x00
	public const int ValueFieldNumber = 1; // Metadata: 0x00B0C328
	private long value_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Int64Value> Parser { /* [XID] */ /* 0x0000000189845090-0x00000001898450B0 */ get => default; } // 0x0000000183090820-0x00000001830908F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x000000018984C4E0-0x000000018984C500 */ get => default; } // 0x00000001830903A0-0x0000000183090490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x00000001898535B0-0x00000001898535D0 */ get => default; } // 0x000000018308FFD0-0x00000001830900A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x000000018985B080-0x000000018985B0A0 */ get => default; } // 0x000000018308F830-0x000000018308F8D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x0000000189862500-0x0000000189862520 */ get => default; } // 0x0000000183090E20-0x0000000183090F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x0000000189869990-0x00000001898699B0 */ get => default; } // 0x0000000183090BC0-0x0000000183090C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x0000000189870C30-0x0000000189870C50 */ get => default; } // 0x00000001830905F0-0x00000001830906F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x00000001898786C0-0x00000001898786E0 */ get => default; } // 0x0000000183090D80-0x0000000183090E20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x000000018987FBF0-0x000000018987FC10 */ get => default; } // 0x0000000183090180-0x0000000183090280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public long Value { /* [XID] */ /* 0x00000001898C56A0-0x00000001898C56C0 */ get => default; /* [XID] */ /* 0x00000001898CCCE0-0x00000001898CCD00 */ set {} } // 0x0000000183090510-0x00000001830905F0 0x0000000183090A30-0x0000000183090B10

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Int64Value() {} // 0x0000000183091190-0x00000001830911F0
	static Int64Value() {} // 0x00000001830910D0-0x0000000183091190

	// Methods
	[DebuggerNonUserCode] // 0x0000000189887240-0x0000000189887280
	// [XID] // 0x0000000189887240-0x0000000189887280
	public Int64Value Clone() => default; // 0x00000001830906F0-0x0000000183090820
	[DebuggerNonUserCode] // 0x00000001898914E0-0x0000000189891520
	// [XID] // 0x00000001898914E0-0x0000000189891520
	public Int64Value ShallowCopy() => default; // 0x00000001830900A0-0x0000000183090180
	[DebuggerNonUserCode] // 0x000000018989BC30-0x000000018989BC70
	// [XID] // 0x000000018989BC30-0x000000018989BC70
	protected override void InternalSetInPool(bool value) {} // 0x000000018308FA90-0x000000018308FB40
	[DebuggerNonUserCode] // 0x00000001898A6240-0x00000001898A6280
	// [XID] // 0x00000001898A6240-0x00000001898A6280
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183090980-0x0000000183090A30
	[DebuggerNonUserCode] // 0x00000001898B0990-0x00000001898B09D0
	// [XID] // 0x00000001898B0990-0x00000001898B09D0
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183090B10-0x0000000183090BC0
	[DebuggerNonUserCode] // 0x00000001898BB360-0x00000001898BB3A0
	// [XID] // 0x00000001898BB360-0x00000001898BB3A0
	public override void Reset() {} // 0x000000018308FB40-0x000000018308FBE0
	[DebuggerNonUserCode] // 0x00000001898D4660-0x00000001898D46B0
	// [IDTag] // 0x00000001898D4660-0x00000001898D46B0
	// [XID] // 0x00000001898D4660-0x00000001898D46B0
	public override bool Equals(object other) => default; // 0x000000018308FC50-0x000000018308FD60
	[DebuggerNonUserCode] // 0x00000001898E24F0-0x00000001898E2540
	// [IDTag] // 0x00000001898E24F0-0x00000001898E2540
	// [XID] // 0x00000001898E24F0-0x00000001898E2540
	public bool Equals(Int64Value other) => default; // 0x000000018308FD60-0x000000018308FEA0
	[DebuggerNonUserCode] // 0x00000001898EFE90-0x00000001898EFED0
	// [XID] // 0x00000001898EFE90-0x00000001898EFED0
	public override int GetHashCode() => default; // 0x0000000183090280-0x00000001830903A0
	[DebuggerNonUserCode] // 0x00000001898FA510-0x00000001898FA550
	// [XID] // 0x00000001898FA510-0x00000001898FA550
	public override string ToString() => default; // 0x0000000183090F20-0x00000001830910D0
	[DebuggerNonUserCode] // 0x0000000189905040-0x0000000189905080
	// [XID] // 0x0000000189905040-0x0000000189905080
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183090C60-0x0000000183090D80
	[DebuggerNonUserCode] // 0x000000018990F860-0x000000018990F8A0
	// [XID] // 0x000000018990F860-0x000000018990F8A0
	public override int CalculateSize() => default; // 0x000000018308FEA0-0x000000018308FFD0
	[DebuggerNonUserCode] // 0x000000018991A310-0x000000018991A350
	// [XID] // 0x000000018991A310-0x000000018991A350
	public void CopyFrom(Int64Value other) {} // 0x000000018308F940-0x000000018308FA90
	[DebuggerNonUserCode] // 0x0000000189924A50-0x0000000189924A90
	// [XID] // 0x0000000189924A50-0x0000000189924A90
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018308F710-0x000000018308F830
}

