/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BonusActivityInfo : MessageBase, IMessage<BonusActivityInfo> // TypeDefIndex: 25461
{
	// Fields
	private static readonly MessageParser<BonusActivityInfo> _parser; // 0x00
	public const int BonusActivityIdFieldNumber = 1; // Metadata: 0x00B08D0B
	private uint bonusActivityId_; // 0x18
	public const int StateFieldNumber = 2; // Metadata: 0x00B08D0F
	private uint state_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BonusActivityInfo> Parser { get => default; } // 0x00000001848D7FD0-0x00000001848D8060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001848D7D60-0x00000001848D7DF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001848D79B0-0x00000001848D7A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001848D7260-0x00000001848D72C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001848D8360-0x00000001848D8450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001848D8190-0x00000001848D81F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001848D7DF0-0x00000001848D7EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001848D8310-0x00000001848D8360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001848D7AD0-0x00000001848D7BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BonusActivityId { get => default; set {} } // 0x00000001848D7440-0x00000001848D74E0 0x00000001848D7CC0-0x00000001848D7D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint State { get => default; set {} } // 0x00000001848D7870-0x00000001848D7910 0x00000001848D7910-0x00000001848D79B0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BonusActivityInfo() {} // 0x00000001848D8710-0x00000001848D8770
	static BonusActivityInfo() {} // 0x00000001848D8650-0x00000001848D8710

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BonusActivityInfo Clone() => default; // 0x00000001848D7EE0-0x00000001848D7FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BonusActivityInfo ShallowCopy() => default; // 0x00000001848D7A30-0x00000001848D7AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001848D73F0-0x00000001848D7440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001848D80F0-0x00000001848D8140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001848D8140-0x00000001848D8190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001848D74E0-0x00000001848D7550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001848D7670-0x00000001848D7740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BonusActivityInfo other) => default; // 0x00000001848D7550-0x00000001848D7670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001848D7BC0-0x00000001848D7CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001848D8450-0x00000001848D8650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001848D81F0-0x00000001848D8310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001848D7740-0x00000001848D7870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BonusActivityInfo other) {} // 0x00000001848D72C0-0x00000001848D73F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001848D7160-0x00000001848D7260
}

