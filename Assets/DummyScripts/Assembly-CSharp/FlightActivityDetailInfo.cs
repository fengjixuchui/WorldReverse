/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FlightActivityDetailInfo : MessageBase, IMessage<FlightActivityDetailInfo> // TypeDefIndex: 22032
{
	// Fields
	private static readonly MessageParser<FlightActivityDetailInfo> _parser; // 0x00
	public const int DailyRecordListFieldNumber = 1; // Metadata: 0x00B009D7
	private static readonly FieldCodec<FlightDailyRecord> _repeated_dailyRecordList_codec; // 0x08
	private readonly RepeatedMessageField<FlightDailyRecord> dailyRecordList_; // 0x18
	public const int PreviewRewardIdFieldNumber = 2; // Metadata: 0x00B009DB
	private uint previewRewardId_; // 0x20
	public const int MinOpenPlayerLevelFieldNumber = 3; // Metadata: 0x00B009DF
	private uint minOpenPlayerLevel_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FlightActivityDetailInfo> Parser { get => default; } // 0x0000000182F46420-0x0000000182F464B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182F46110-0x0000000182F461A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182F45DE0-0x0000000182F45E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182F45660-0x0000000182F456C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182F46A30-0x0000000182F46B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182F467A0-0x0000000182F46800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182F461A0-0x0000000182F46290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182F46980-0x0000000182F469D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182F45F00-0x0000000182F45FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<FlightDailyRecord> DailyRecordList { get => default; } // 0x0000000182F469D0-0x0000000182F46A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PreviewRewardId { get => default; set {} } // 0x0000000182F46380-0x0000000182F46420 0x0000000182F45990-0x0000000182F45A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MinOpenPlayerLevel { get => default; set {} } // 0x0000000182F464B0-0x0000000182F46550 0x0000000182F465E0-0x0000000182F46680

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FlightActivityDetailInfo() {} // 0x0000000182F46EA0-0x0000000182F46F30
	static FlightActivityDetailInfo() {} // 0x0000000182F46D90-0x0000000182F46EA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FlightActivityDetailInfo Clone() => default; // 0x0000000182F46290-0x0000000182F46380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FlightActivityDetailInfo ShallowCopy() => default; // 0x0000000182F45E60-0x0000000182F45F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182F45850-0x0000000182F458A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182F46680-0x0000000182F46710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182F46710-0x0000000182F467A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182F458A0-0x0000000182F45990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182F45B80-0x0000000182F45C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FlightActivityDetailInfo other) => default; // 0x0000000182F45A30-0x0000000182F45B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182F45FF0-0x0000000182F46110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182F46B20-0x0000000182F46D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182F46800-0x0000000182F46980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182F45C50-0x0000000182F45DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FlightActivityDetailInfo other) {} // 0x0000000182F456C0-0x0000000182F45850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182F454E0-0x0000000182F45660
}

