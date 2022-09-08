/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FoundationInfo : MessageBase, IMessage<FoundationInfo> // TypeDefIndex: 26040
{
	// Fields
	private static readonly MessageParser<FoundationInfo> _parser; // 0x00
	public const int StatusFieldNumber = 1; // Metadata: 0x00B0ACFB
	private FoundationStatus status_; // 0x18
	public const int UidListFieldNumber = 2; // Metadata: 0x00B0ACFF
	private static readonly FieldCodec<uint> _repeated_uidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> uidList_; // 0x20
	public const int CurrentBuildingIdFieldNumber = 3; // Metadata: 0x00B0AD03
	private uint currentBuildingId_; // 0x28
	public const int BeginBuildTimeMsFieldNumber = 4; // Metadata: 0x00B0AD07
	private ulong beginBuildTimeMs_; // 0x30
	public const int DemolitionRefundFieldNumber = 5; // Metadata: 0x00B0AD0B
	private uint demolitionRefund_; // 0x38
	public const int BuildingListFieldNumber = 6; // Metadata: 0x00B0AD0F
	private static readonly FieldCodec<BuildingInfo> _repeated_buildingList_codec; // 0x10
	private readonly RepeatedMessageField<BuildingInfo> buildingList_; // 0x40
	public const int CurrentNumFieldNumber = 7; // Metadata: 0x00B0AD13
	private uint currentNum_; // 0x48
	public const int MaxNumFieldNumber = 8; // Metadata: 0x00B0AD17
	private uint maxNum_; // 0x4C
	public const int LockedByUidFieldNumber = 9; // Metadata: 0x00B0AD1B
	private uint lockedByUid_; // 0x50

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FoundationInfo> Parser { get => default; } // 0x00000001831FF250-0x00000001831FF2E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001831FEEA0-0x00000001831FEF30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001831FE7F0-0x00000001831FE870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001831FDA90-0x00000001831FDAF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001831FFAA0-0x00000001831FFB90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001831FF5D0-0x00000001831FF630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001831FF070-0x00000001831FF160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001831FF9F0-0x00000001831FFA40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001831FEA10-0x00000001831FEB00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FoundationStatus Status { get => default; set {} } // 0x00000001831FE910-0x00000001831FE9B0 0x00000001831FED60-0x00000001831FEE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> UidList { get => default; } // 0x00000001831FFA40-0x00000001831FFAA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurrentBuildingId { get => default; set {} } // 0x00000001831FEFD0-0x00000001831FF070 0x00000001831FDFE0-0x00000001831FE080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong BeginBuildTimeMs { get => default; set {} } // 0x00000001831FF630-0x00000001831FF6D0 0x00000001831FEE00-0x00000001831FEEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DemolitionRefund { get => default; set {} } // 0x00000001831FD9F0-0x00000001831FDA90 0x00000001831FF530-0x00000001831FF5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<BuildingInfo> BuildingList { get => default; } // 0x00000001831FE9B0-0x00000001831FEA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurrentNum { get => default; set {} } // 0x00000001831FFB90-0x00000001831FFC30 0x00000001831FE750-0x00000001831FE7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MaxNum { get => default; set {} } // 0x00000001831FF400-0x00000001831FF4A0 0x00000001831FEF30-0x00000001831FEFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LockedByUid { get => default; set {} } // 0x00000001831FE6B0-0x00000001831FE750 0x00000001831FDF40-0x00000001831FDFE0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FoundationInfo() {} // 0x0000000183200300-0x00000001832003C0
	static FoundationInfo() {} // 0x00000001832001D0-0x0000000183200300

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FoundationInfo Clone() => default; // 0x00000001831FF160-0x00000001831FF250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FoundationInfo ShallowCopy() => default; // 0x00000001831FE870-0x00000001831FE910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001831FDD60-0x00000001831FDDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831FF370-0x00000001831FF400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831FF4A0-0x00000001831FF530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001831FDDB0-0x00000001831FDF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001831FE080-0x00000001831FE150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FoundationInfo other) => default; // 0x00000001831FE150-0x00000001831FE360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001831FEB00-0x00000001831FED60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001831FFC30-0x00000001832001D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001831FF6D0-0x00000001831FF9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001831FE360-0x00000001831FE6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FoundationInfo other) {} // 0x00000001831FDAF0-0x00000001831FDD60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001831FD770-0x00000001831FD9F0
}

