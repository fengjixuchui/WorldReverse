/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SalesmanActivityDetailInfo : MessageBase, IMessage<SalesmanActivityDetailInfo> // TypeDefIndex: 21938
{
	// Fields
	private static readonly MessageParser<SalesmanActivityDetailInfo> _parser; // 0x00
	public const int StatusFieldNumber = 1; // Metadata: 0x00B0064F
	private SalesmanStatusType status_; // 0x18
	public const int DayIndexFieldNumber = 2; // Metadata: 0x00B00653
	private uint dayIndex_; // 0x1C
	public const int LastDeliverTimeFieldNumber = 3; // Metadata: 0x00B00657
	private uint lastDeliverTime_; // 0x20
	public const int DeliverCountFieldNumber = 4; // Metadata: 0x00B0065B
	private uint deliverCount_; // 0x24
	public const int SelectedRewardIdMapFieldNumber = 5; // Metadata: 0x00B0065F
	private static readonly MapField<uint, uint> _map_selectedRewardIdMap_codec; // 0x08
	private readonly MapField<uint, uint> selectedRewardIdMap_; // 0x28
	public const int DayRewardIdFieldNumber = 6; // Metadata: 0x00B00663
	private uint dayRewardId_; // 0x30
	public const int SpecialRewardPreviewIdFieldNumber = 7; // Metadata: 0x00B00667
	private uint specialRewardPreviewId_; // 0x34
	public const int CondDayCountFieldNumber = 8; // Metadata: 0x00B0066B
	private uint condDayCount_; // 0x38
	public const int IsHasTakenSpecialRewardFieldNumber = 9; // Metadata: 0x00B0066F
	private bool isHasTakenSpecialReward_; // 0x3C
	public const int IsTodayHasDeliveredFieldNumber = 10; // Metadata: 0x00B00673
	private bool isTodayHasDelivered_; // 0x3D

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SalesmanActivityDetailInfo> Parser { get => default; } // 0x0000000180FD4CD0-0x0000000180FD4D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000180FD4820-0x0000000180FD48B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000180FD4020-0x0000000180FD40A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000180FD32A0-0x0000000180FD3300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000180FD5460-0x0000000180FD5550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000180FD4FD0-0x0000000180FD5030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000180FD4910-0x0000000180FD4A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000180FD5410-0x0000000180FD5460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000180FD41E0-0x0000000180FD42D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SalesmanStatusType Status { get => default; set {} } // 0x0000000180FD4140-0x0000000180FD41E0 0x0000000180FD4640-0x0000000180FD46E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DayIndex { get => default; set {} } // 0x0000000180FD4B90-0x0000000180FD4C30 0x0000000180FD4C30-0x0000000180FD4CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LastDeliverTime { get => default; set {} } // 0x0000000180FD4F30-0x0000000180FD4FD0 0x0000000180FD4780-0x0000000180FD4820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DeliverCount { get => default; set {} } // 0x0000000180FD3780-0x0000000180FD3820 0x0000000180FD3820-0x0000000180FD38C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> SelectedRewardIdMap { get => default; } // 0x0000000180FD48B0-0x0000000180FD4910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DayRewardId { get => default; set {} } // 0x0000000180FD3300-0x0000000180FD33A0 0x0000000180FD45A0-0x0000000180FD4640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SpecialRewardPreviewId { get => default; set {} } // 0x0000000180FD4E90-0x0000000180FD4F30 0x0000000180FD3EE0-0x0000000180FD3F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CondDayCount { get => default; set {} } // 0x0000000180FD46E0-0x0000000180FD4780 0x0000000180FD3200-0x0000000180FD32A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsHasTakenSpecialReward { get => default; set {} } // 0x0000000180FD5030-0x0000000180FD50D0 0x0000000180FD5550-0x0000000180FD55F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsTodayHasDelivered { get => default; set {} } // 0x0000000180FD3F80-0x0000000180FD4020 0x0000000180FD4AF0-0x0000000180FD4B90

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SalesmanActivityDetailInfo() {} // 0x0000000180FD5D70-0x0000000180FD5E10
	static SalesmanActivityDetailInfo() {} // 0x0000000180FD5C40-0x0000000180FD5D70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SalesmanActivityDetailInfo Clone() => default; // 0x0000000180FD4A00-0x0000000180FD4AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SalesmanActivityDetailInfo ShallowCopy() => default; // 0x0000000180FD40A0-0x0000000180FD4140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000180FD3600-0x0000000180FD3650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180FD4DF0-0x0000000180FD4E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180FD4E40-0x0000000180FD4E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000180FD3650-0x0000000180FD3780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000180FD3AF0-0x0000000180FD3BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SalesmanActivityDetailInfo other) => default; // 0x0000000180FD38C0-0x0000000180FD3AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000180FD42D0-0x0000000180FD45A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000180FD55F0-0x0000000180FD5C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000180FD50D0-0x0000000180FD5410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000180FD3BC0-0x0000000180FD3EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SalesmanActivityDetailInfo other) {} // 0x0000000180FD33A0-0x0000000180FD3600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000180FD2FC0-0x0000000180FD3200
}

