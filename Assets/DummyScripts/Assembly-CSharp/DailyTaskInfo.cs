/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DailyTaskInfo : MessageBase, IMessage<DailyTaskInfo> // TypeDefIndex: 24438
{
	// Fields
	private static readonly MessageParser<DailyTaskInfo> _parser; // 0x00
	public const int DailyTaskIdFieldNumber = 1; // Metadata: 0x00B066FB
	private uint dailyTaskId_; // 0x18
	public const int RewardIdFieldNumber = 2; // Metadata: 0x00B066FF
	private uint rewardId_; // 0x1C
	public const int ProgressFieldNumber = 3; // Metadata: 0x00B06703
	private uint progress_; // 0x20
	public const int FinishProgressFieldNumber = 4; // Metadata: 0x00B06707
	private uint finishProgress_; // 0x24
	public const int IsFinishedFieldNumber = 5; // Metadata: 0x00B0670B
	private bool isFinished_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DailyTaskInfo> Parser { get => default; } // 0x000000018594FF30-0x000000018594FFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018594FA40-0x000000018594FAD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018594F600-0x000000018594F680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018594EDA0-0x000000018594EE00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001859504C0-0x00000001859505B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185950230-0x0000000185950290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018594FC10-0x000000018594FD00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185950470-0x00000001859504C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018594F7C0-0x000000018594F8B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DailyTaskId { get => default; set {} } // 0x000000018594FB70-0x000000018594FC10 0x000000018594EFB0-0x000000018594F050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RewardId { get => default; set {} } // 0x0000000185950190-0x0000000185950230 0x000000018594FDF0-0x000000018594FE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Progress { get => default; set {} } // 0x000000018594FAD0-0x000000018594FB70 0x000000018594F720-0x000000018594F7C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FinishProgress { get => default; set {} } // 0x0000000185950050-0x00000001859500F0 0x00000001859505B0-0x0000000185950650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsFinished { get => default; set {} } // 0x000000018594FE90-0x000000018594FF30 0x000000018594F140-0x000000018594F1E0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DailyTaskInfo() {} // 0x0000000185950AB0-0x0000000185950B10
	static DailyTaskInfo() {} // 0x00000001859509F0-0x0000000185950AB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DailyTaskInfo Clone() => default; // 0x000000018594FD00-0x000000018594FDF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DailyTaskInfo ShallowCopy() => default; // 0x000000018594F680-0x000000018594F720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018594F050-0x000000018594F0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001859500F0-0x0000000185950140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185950140-0x0000000185950190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018594F0A0-0x000000018594F140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018594F350-0x000000018594F420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DailyTaskInfo other) => default; // 0x000000018594F1E0-0x000000018594F350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018594F8B0-0x000000018594FA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185950650-0x00000001859509F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185950290-0x0000000185950470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018594F420-0x000000018594F600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DailyTaskInfo other) {} // 0x000000018594EE00-0x000000018594EFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018594EC50-0x000000018594EDA0
}

