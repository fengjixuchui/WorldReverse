/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GivingRecord : MessageBase, IMessage<GivingRecord> // TypeDefIndex: 24467
{
	// Fields
	private static readonly MessageParser<GivingRecord> _parser; // 0x00
	public const int GivingIdFieldNumber = 1; // Metadata: 0x00B067F7
	private uint givingId_; // 0x18
	public const int IsFinishedFieldNumber = 2; // Metadata: 0x00B067FB
	private bool isFinished_; // 0x1C
	public const int LastGroupIdFieldNumber = 3; // Metadata: 0x00B067FF
	private uint lastGroupId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GivingRecord> Parser { get => default; } // 0x0000000182542B10-0x0000000182542BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001825426C0-0x0000000182542750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182542380-0x0000000182542400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182541BC0-0x0000000182541C20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182542EE0-0x0000000182542FD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182542CD0-0x0000000182542D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182542890-0x0000000182542980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182542E90-0x0000000182542EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001825424A0-0x0000000182542590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GivingId { get => default; set {} } // 0x0000000182542750-0x00000001825427F0 0x0000000182541F90-0x0000000182542030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsFinished { get => default; set {} } // 0x0000000182542A70-0x0000000182542B10 0x0000000182541EF0-0x0000000182541F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LastGroupId { get => default; set {} } // 0x00000001825427F0-0x0000000182542890 0x0000000182541C20-0x0000000182541CC0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GivingRecord() {} // 0x0000000182543320-0x0000000182543380
	static GivingRecord() {} // 0x0000000182543260-0x0000000182543320

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GivingRecord Clone() => default; // 0x0000000182542980-0x0000000182542A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GivingRecord ShallowCopy() => default; // 0x0000000182542400-0x00000001825424A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182541E20-0x0000000182541E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182542C30-0x0000000182542C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182542C80-0x0000000182542CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182541E70-0x0000000182541EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182542170-0x0000000182542240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GivingRecord other) => default; // 0x0000000182542030-0x0000000182542170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182542590-0x00000001825426C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182542FD0-0x0000000182543260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182542D30-0x0000000182542E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182542240-0x0000000182542380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GivingRecord other) {} // 0x0000000182541CC0-0x0000000182541E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182541AB0-0x0000000182541BC0
}

