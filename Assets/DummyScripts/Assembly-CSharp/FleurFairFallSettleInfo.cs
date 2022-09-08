/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FleurFairFallSettleInfo : MessageBase, IMessage<FleurFairFallSettleInfo> // TypeDefIndex: 22215
{
	// Fields
	private static readonly MessageParser<FleurFairFallSettleInfo> _parser; // 0x00
	public const int SettleInfoFieldNumber = 1; // Metadata: 0x00B0110F
	private FallSettleInfo settleInfo_; // 0x18
	public const int IsNewRecordFieldNumber = 2; // Metadata: 0x00B01113
	private bool isNewRecord_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FleurFairFallSettleInfo> Parser { get => default; } // 0x0000000182018670-0x0000000182018700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182018360-0x00000001820183F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182017F30-0x0000000182017FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182017790-0x00000001820177F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182018A60-0x0000000182018B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182018890-0x00000001820188F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182018490-0x0000000182018580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182018A10-0x0000000182018A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182018050-0x0000000182018140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FallSettleInfo SettleInfo { get => default; set {} } // 0x00000001820182C0-0x0000000182018360 0x0000000182017B30-0x0000000182017BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsNewRecord { get => default; set {} } // 0x00000001820183F0-0x0000000182018490 0x0000000182018B50-0x0000000182018BF0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairFallSettleInfo() {} // 0x0000000182018E90-0x0000000182018EF0
	static FleurFairFallSettleInfo() {} // 0x0000000182018DD0-0x0000000182018E90

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairFallSettleInfo Clone() => default; // 0x0000000182018580-0x0000000182018670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairFallSettleInfo ShallowCopy() => default; // 0x0000000182017FB0-0x0000000182018050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182017980-0x0000000182017A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182018790-0x0000000182018810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182018810-0x0000000182018890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182017A00-0x0000000182017B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182017D00-0x0000000182017DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FleurFairFallSettleInfo other) => default; // 0x0000000182017BD0-0x0000000182017D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182018140-0x00000001820182C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182018BF0-0x0000000182018DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001820188F0-0x0000000182018A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182017DD0-0x0000000182017F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FleurFairFallSettleInfo other) {} // 0x00000001820177F0-0x0000000182017980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182017660-0x0000000182017790
}

