/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BattlePassSchedule : MessageBase, IMessage<BattlePassSchedule> // TypeDefIndex: 22544
{
	// Fields
	private static readonly MessageParser<BattlePassSchedule> _parser; // 0x00
	public const int ScheduleIdFieldNumber = 1; // Metadata: 0x00B01D47
	private uint scheduleId_; // 0x18
	public const int LevelFieldNumber = 2; // Metadata: 0x00B01D4B
	private uint level_; // 0x1C
	public const int PointFieldNumber = 3; // Metadata: 0x00B01D4F
	private uint point_; // 0x20
	public const int UnlockStatusFieldNumber = 4; // Metadata: 0x00B01D53
	private BattlePassUnlockStatus unlockStatus_; // 0x24
	public const int RewardTakenListFieldNumber = 5; // Metadata: 0x00B01D57
	private static readonly FieldCodec<BattlePassRewardTag> _repeated_rewardTakenList_codec; // 0x08
	private readonly RepeatedMessageField<BattlePassRewardTag> rewardTakenList_; // 0x28
	public const int BeginTimeFieldNumber = 6; // Metadata: 0x00B01D5B
	private uint beginTime_; // 0x30
	public const int EndTimeFieldNumber = 7; // Metadata: 0x00B01D5F
	private uint endTime_; // 0x34
	public const int CurCycleFieldNumber = 8; // Metadata: 0x00B01D63
	private BattlePassCycle curCycle_; // 0x38
	public const int IsExtraPaidRewardTakenFieldNumber = 9; // Metadata: 0x00B01D67
	private bool isExtraPaidRewardTaken_; // 0x40
	public const int ProductInfoFieldNumber = 10; // Metadata: 0x00B01D6B
	private BattlePassProduct productInfo_; // 0x48
	public const int IsViewedFieldNumber = 11; // Metadata: 0x00B01D6F
	private bool isViewed_; // 0x50
	public const int CurCyclePointsFieldNumber = 12; // Metadata: 0x00B01D73
	private uint curCyclePoints_; // 0x54

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BattlePassSchedule> Parser { get => default; } // 0x0000000184148440-0x00000001841484D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184148090-0x0000000184148120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001841478C0-0x0000000184147940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001841464E0-0x0000000184146540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184148FE0-0x00000001841490D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184148900-0x0000000184148960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001841481C0-0x00000001841482B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184148F90-0x0000000184148FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184147A80-0x0000000184147B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x0000000184146E80-0x0000000184146F20 0x0000000184148960-0x0000000184148A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x0000000184146950-0x00000001841469F0 0x00000001841479E0-0x0000000184147A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Point { get => default; set {} } // 0x0000000184148120-0x00000001841481C0 0x0000000184146F20-0x0000000184146FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassUnlockStatus UnlockStatus { get => default; set {} } // 0x0000000184146440-0x00000001841464E0 0x0000000184146FC0-0x0000000184147060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<BattlePassRewardTag> RewardTakenList { get => default; } // 0x00000001841484D0-0x0000000184148530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BeginTime { get => default; set {} } // 0x0000000184148E50-0x0000000184148EF0 0x00000001841487C0-0x0000000184148860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EndTime { get => default; set {} } // 0x00000001841483A0-0x0000000184148440 0x0000000184148860-0x0000000184148900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassCycle CurCycle { get => default; set {} } // 0x0000000184148670-0x0000000184148710 0x0000000184147F50-0x0000000184147FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsExtraPaidRewardTaken { get => default; set {} } // 0x0000000184148EF0-0x0000000184148F90 0x0000000184148A00-0x0000000184148AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassProduct ProductInfo { get => default; set {} } // 0x00000001841469F0-0x0000000184146A90 0x00000001841460B0-0x0000000184146150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsViewed { get => default; set {} } // 0x0000000184147820-0x00000001841478C0 0x0000000184146A90-0x0000000184146B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurCyclePoints { get => default; set {} } // 0x0000000184146540-0x00000001841465E0 0x0000000184147FF0-0x0000000184148090

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassSchedule() {} // 0x0000000184149920-0x00000001841499C0
	static BattlePassSchedule() {} // 0x0000000184149810-0x0000000184149920

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassSchedule Clone() => default; // 0x00000001841482B0-0x00000001841483A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassSchedule ShallowCopy() => default; // 0x0000000184147940-0x00000001841479E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184146B30-0x0000000184146BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001841485C0-0x0000000184148670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184148710-0x00000001841487C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184146BC0-0x0000000184146E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001841472E0-0x00000001841473B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BattlePassSchedule other) => default; // 0x0000000184147060-0x00000001841472E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184147B70-0x0000000184147F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001841490D0-0x0000000184149810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184148AA0-0x0000000184148E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001841473B0-0x0000000184147820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BattlePassSchedule other) {} // 0x00000001841465E0-0x0000000184146950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184146150-0x0000000184146440
}

