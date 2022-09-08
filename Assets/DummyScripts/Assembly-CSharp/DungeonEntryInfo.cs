/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DungeonEntryInfo : MessageBase, IMessage<DungeonEntryInfo> // TypeDefIndex: 22806
{
	// Fields
	private static readonly MessageParser<DungeonEntryInfo> _parser; // 0x00
	public const int DungeonIdFieldNumber = 1; // Metadata: 0x00B0269B
	private uint dungeonId_; // 0x18
	public const int IsPassedFieldNumber = 2; // Metadata: 0x00B0269F
	private bool isPassed_; // 0x1C
	public const int LeftTimesFieldNumber = 3; // Metadata: 0x00B026A3
	private uint leftTimes_; // 0x20
	public const int StartTimeFieldNumber = 4; // Metadata: 0x00B026A7
	private uint startTime_; // 0x24
	public const int EndTimeFieldNumber = 5; // Metadata: 0x00B026AB
	private uint endTime_; // 0x28
	public const int MaxBossChestNumFieldNumber = 6; // Metadata: 0x00B026AF
	private uint maxBossChestNum_; // 0x2C
	public const int BossChestNumFieldNumber = 7; // Metadata: 0x00B026B3
	private uint bossChestNum_; // 0x30
	public const int NextRefreshTimeFieldNumber = 8; // Metadata: 0x00B026B7
	private uint nextRefreshTime_; // 0x34
	public const int WeeklyBossResinDiscountInfoFieldNumber = 9; // Metadata: 0x00B026BB
	private WeeklyBossResinDiscountInfo weeklyBossResinDiscountInfo_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DungeonEntryInfo> Parser { get => default; } // 0x000000018300BAE0-0x000000018300BB70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018300B4B0-0x000000018300B540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018300AEC0-0x000000018300AF40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018300A1B0-0x000000018300A210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018300C3A0-0x000000018300C490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018300BE40-0x000000018300BEA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018300B680-0x000000018300B770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018300C2B0-0x000000018300C300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018300B120-0x000000018300B210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonId { get => default; set {} } // 0x000000018300B080-0x000000018300B120 0x000000018300C210-0x000000018300C2B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsPassed { get => default; set {} } // 0x000000018300A4A0-0x000000018300A540 0x000000018300B770-0x000000018300B810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LeftTimes { get => default; set {} } // 0x000000018300BA40-0x000000018300BAE0 0x000000018300A5C0-0x000000018300A660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StartTime { get => default; set {} } // 0x000000018300C490-0x000000018300C530 0x000000018300B540-0x000000018300B5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EndTime { get => default; set {} } // 0x000000018300B900-0x000000018300B9A0 0x000000018300BDA0-0x000000018300BE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MaxBossChestNum { get => default; set {} } // 0x000000018300AF40-0x000000018300AFE0 0x000000018300C300-0x000000018300C3A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BossChestNum { get => default; set {} } // 0x000000018300B5E0-0x000000018300B680 0x000000018300C170-0x000000018300C210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NextRefreshTime { get => default; set {} } // 0x000000018300B9A0-0x000000018300BA40 0x000000018300C530-0x000000018300C5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WeeklyBossResinDiscountInfo WeeklyBossResinDiscountInfo { get => default; set {} } // 0x000000018300A7F0-0x000000018300A890 0x000000018300BC00-0x000000018300BCA0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonEntryInfo() {} // 0x000000018300CC50-0x000000018300CCB0
	static DungeonEntryInfo() {} // 0x000000018300CB90-0x000000018300CC50

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonEntryInfo Clone() => default; // 0x000000018300B810-0x000000018300B900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonEntryInfo ShallowCopy() => default; // 0x000000018300AFE0-0x000000018300B080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018300A540-0x000000018300A5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018300BCA0-0x000000018300BD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018300BD20-0x000000018300BDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018300A660-0x000000018300A7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018300AA90-0x000000018300AB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DungeonEntryInfo other) => default; // 0x000000018300A890-0x000000018300AA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018300B210-0x000000018300B4B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018300C5D0-0x000000018300CB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018300BEA0-0x000000018300C170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018300AB60-0x000000018300AEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DungeonEntryInfo other) {} // 0x000000018300A210-0x000000018300A4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183009F90-0x000000018300A1B0
}

