/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FleurFairBalloonSettleInfo : MessageBase, IMessage<FleurFairBalloonSettleInfo> // TypeDefIndex: 22214
{
	// Fields
	private static readonly MessageParser<FleurFairBalloonSettleInfo> _parser; // 0x00
	public const int SettleInfoFieldNumber = 1; // Metadata: 0x00B01107
	private BalloonSettleInfo settleInfo_; // 0x18
	public const int IsNewRecordFieldNumber = 2; // Metadata: 0x00B0110B
	private bool isNewRecord_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FleurFairBalloonSettleInfo> Parser { get => default; } // 0x00000001837CD970-0x00000001837CDA00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001837CD660-0x00000001837CD6F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001837CD230-0x00000001837CD2B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001837CCA90-0x00000001837CCAF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001837CDD60-0x00000001837CDE50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001837CDB90-0x00000001837CDBF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001837CD790-0x00000001837CD880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001837CDD10-0x00000001837CDD60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001837CD350-0x00000001837CD440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BalloonSettleInfo SettleInfo { get => default; set {} } // 0x00000001837CD5C0-0x00000001837CD660 0x00000001837CCE30-0x00000001837CCED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsNewRecord { get => default; set {} } // 0x00000001837CD6F0-0x00000001837CD790 0x00000001837CDE50-0x00000001837CDEF0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairBalloonSettleInfo() {} // 0x00000001837CE190-0x00000001837CE1F0
	static FleurFairBalloonSettleInfo() {} // 0x00000001837CE0D0-0x00000001837CE190

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairBalloonSettleInfo Clone() => default; // 0x00000001837CD880-0x00000001837CD970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairBalloonSettleInfo ShallowCopy() => default; // 0x00000001837CD2B0-0x00000001837CD350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001837CCC80-0x00000001837CCD00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001837CDA90-0x00000001837CDB10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001837CDB10-0x00000001837CDB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001837CCD00-0x00000001837CCE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001837CD000-0x00000001837CD0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FleurFairBalloonSettleInfo other) => default; // 0x00000001837CCED0-0x00000001837CD000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001837CD440-0x00000001837CD5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001837CDEF0-0x00000001837CE0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001837CDBF0-0x00000001837CDD10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001837CD0D0-0x00000001837CD230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FleurFairBalloonSettleInfo other) {} // 0x00000001837CCAF0-0x00000001837CCC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001837CC960-0x00000001837CCA90
}

