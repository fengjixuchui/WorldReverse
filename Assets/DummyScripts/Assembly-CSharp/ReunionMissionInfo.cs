/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ReunionMissionInfo : MessageBase, IMessage<ReunionMissionInfo> // TypeDefIndex: 24804
{
	// Fields
	private static readonly MessageParser<ReunionMissionInfo> _parser; // 0x00
	public const int MissionIdFieldNumber = 1; // Metadata: 0x00B0746F
	private uint missionId_; // 0x18
	public const int CurDayWatcherListFieldNumber = 2; // Metadata: 0x00B07473
	private static readonly FieldCodec<ReunionWatcherInfo> _repeated_curDayWatcherList_codec; // 0x08
	private readonly RepeatedMessageField<ReunionWatcherInfo> curDayWatcherList_; // 0x20
	public const int CurScoreFieldNumber = 3; // Metadata: 0x00B07477
	private uint curScore_; // 0x28
	public const int IsFinishedFieldNumber = 4; // Metadata: 0x00B0747B
	private bool isFinished_; // 0x2C
	public const int IsTakenRewardFieldNumber = 5; // Metadata: 0x00B0747F
	private bool isTakenReward_; // 0x2D
	public const int NextRefreshTimeFieldNumber = 6; // Metadata: 0x00B07483
	private uint nextRefreshTime_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ReunionMissionInfo> Parser { get => default; } // 0x00000001822C0E40-0x00000001822C0ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001822C0990-0x00000001822C0A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001822C0520-0x00000001822C05A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001822BFA60-0x00000001822BFAC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001822C1410-0x00000001822C1500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001822C1080-0x00000001822C10E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001822C0B20-0x00000001822C0C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001822C1320-0x00000001822C1370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001822C06E0-0x00000001822C07D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MissionId { get => default; set {} } // 0x00000001822BFAC0-0x00000001822BFB60 0x00000001822C0A80-0x00000001822C0B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ReunionWatcherInfo> CurDayWatcherList { get => default; } // 0x00000001822C0A20-0x00000001822C0A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurScore { get => default; set {} } // 0x00000001822C1370-0x00000001822C1410 0x00000001822C0640-0x00000001822C06E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsFinished { get => default; set {} } // 0x00000001822C0D00-0x00000001822C0DA0 0x00000001822BFF60-0x00000001822C0000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsTakenReward { get => default; set {} } // 0x00000001822C0480-0x00000001822C0520 0x00000001822BFB60-0x00000001822BFC00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NextRefreshTime { get => default; set {} } // 0x00000001822C0DA0-0x00000001822C0E40 0x00000001822C1500-0x00000001822C15A0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionMissionInfo() {} // 0x00000001822C1AD0-0x00000001822C1B60
	static ReunionMissionInfo() {} // 0x00000001822C19C0-0x00000001822C1AD0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionMissionInfo Clone() => default; // 0x00000001822C0C10-0x00000001822C0D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionMissionInfo ShallowCopy() => default; // 0x00000001822C05A0-0x00000001822C0640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001822BFE00-0x00000001822BFE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001822C0F60-0x00000001822C0FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001822C0FF0-0x00000001822C1080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001822BFE50-0x00000001822BFF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001822C0000-0x00000001822C00D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ReunionMissionInfo other) => default; // 0x00000001822C00D0-0x00000001822C0280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001822C07D0-0x00000001822C0990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001822C15A0-0x00000001822C19C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001822C10E0-0x00000001822C1320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001822C0280-0x00000001822C0480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ReunionMissionInfo other) {} // 0x00000001822BFC00-0x00000001822BFE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001822BF880-0x00000001822BFA60
}

