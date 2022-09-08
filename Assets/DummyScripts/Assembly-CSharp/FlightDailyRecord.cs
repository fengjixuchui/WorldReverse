/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FlightDailyRecord : MessageBase, IMessage<FlightDailyRecord> // TypeDefIndex: 22031
{
	// Fields
	private static readonly MessageParser<FlightDailyRecord> _parser; // 0x00
	public const int IsTouchedFieldNumber = 1; // Metadata: 0x00B009C3
	private bool isTouched_; // 0x18
	public const int BestScoreFieldNumber = 2; // Metadata: 0x00B009C7
	private uint bestScore_; // 0x1C
	public const int StartTimeFieldNumber = 3; // Metadata: 0x00B009CB
	private uint startTime_; // 0x20
	public const int WatcherIdListFieldNumber = 4; // Metadata: 0x00B009CF
	private static readonly FieldCodec<uint> _repeated_watcherIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> watcherIdList_; // 0x28
	public const int GroupIdFieldNumber = 5; // Metadata: 0x00B009D3
	private uint groupId_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FlightDailyRecord> Parser { get => default; } // 0x0000000180F72E60-0x0000000180F72EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000180F72A10-0x0000000180F72AA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000180F72680-0x0000000180F72700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000180F71E00-0x0000000180F71E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000180F73410-0x0000000180F73500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000180F730C0-0x0000000180F73120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000180F72B40-0x0000000180F72C30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000180F733C0-0x0000000180F73410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000180F727A0-0x0000000180F72890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsTouched { get => default; set {} } // 0x0000000180F73120-0x0000000180F731C0 0x0000000180F73500-0x0000000180F735A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BestScore { get => default; set {} } // 0x0000000180F72DC0-0x0000000180F72E60 0x0000000180F73020-0x0000000180F730C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StartTime { get => default; set {} } // 0x0000000180F735A0-0x0000000180F73640 0x0000000180F72AA0-0x0000000180F72B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> WatcherIdList { get => default; } // 0x0000000180F72050-0x0000000180F720B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GroupId { get => default; set {} } // 0x0000000180F72C30-0x0000000180F72CD0 0x0000000180F725E0-0x0000000180F72680

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FlightDailyRecord() {} // 0x0000000180F73AB0-0x0000000180F73B40
	static FlightDailyRecord() {} // 0x0000000180F739D0-0x0000000180F73AB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FlightDailyRecord Clone() => default; // 0x0000000180F72CD0-0x0000000180F72DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FlightDailyRecord ShallowCopy() => default; // 0x0000000180F72700-0x0000000180F727A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000180F72000-0x0000000180F72050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180F72F80-0x0000000180F72FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180F72FD0-0x0000000180F73020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000180F720B0-0x0000000180F721A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000180F721A0-0x0000000180F72270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FlightDailyRecord other) => default; // 0x0000000180F72270-0x0000000180F723F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000180F72890-0x0000000180F72A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000180F73640-0x0000000180F739D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000180F731C0-0x0000000180F733C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000180F723F0-0x0000000180F725E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FlightDailyRecord other) {} // 0x0000000180F71E60-0x0000000180F72000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000180F71C40-0x0000000180F71E00
}

