/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TowerFloorRecord : MessageBase, IMessage<TowerFloorRecord> // TypeDefIndex: 25695
{
	// Fields
	private static readonly MessageParser<TowerFloorRecord> _parser; // 0x00
	public const int FloorIdFieldNumber = 1; // Metadata: 0x00B095BB
	private uint floorId_; // 0x18
	public const int PassedLevelMapFieldNumber = 2; // Metadata: 0x00B095BF
	private static readonly MapField<uint, uint> _map_passedLevelMap_codec; // 0x08
	private readonly MapField<uint, uint> passedLevelMap_; // 0x20
	public const int FloorStarRewardProgressFieldNumber = 3; // Metadata: 0x00B095C3
	private uint floorStarRewardProgress_; // 0x28
	public const int PassedLevelRecordListFieldNumber = 4; // Metadata: 0x00B095C7
	private static readonly FieldCodec<TowerLevelRecord> _repeated_passedLevelRecordList_codec; // 0x10
	private readonly RepeatedMessageField<TowerLevelRecord> passedLevelRecordList_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TowerFloorRecord> Parser { get => default; } // 0x0000000183D0F4A0-0x0000000183D0F530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183D0F130-0x0000000183D0F1C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183D0EDA0-0x0000000183D0EE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183D0E400-0x0000000183D0E460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183D0FA10-0x0000000183D0FB00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183D0F780-0x0000000183D0F7E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183D0F220-0x0000000183D0F310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183D0F9C0-0x0000000183D0FA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183D0EEC0-0x0000000183D0EFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FloorId { get => default; set {} } // 0x0000000183D0F5C0-0x0000000183D0F660 0x0000000183D0E850-0x0000000183D0E8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> PassedLevelMap { get => default; } // 0x0000000183D0F1C0-0x0000000183D0F220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FloorStarRewardProgress { get => default; set {} } // 0x0000000183D0E610-0x0000000183D0E6B0 0x0000000183D0F400-0x0000000183D0F4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<TowerLevelRecord> PassedLevelRecordList { get => default; } // 0x0000000183D0E8F0-0x0000000183D0E950 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerFloorRecord() {} // 0x0000000183D0FF60-0x0000000183D10010
	static TowerFloorRecord() {} // 0x0000000183D0FDE0-0x0000000183D0FF60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerFloorRecord Clone() => default; // 0x0000000183D0F310-0x0000000183D0F400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerFloorRecord ShallowCopy() => default; // 0x0000000183D0EE20-0x0000000183D0EEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183D0E6B0-0x0000000183D0E700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D0F660-0x0000000183D0F6F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D0F6F0-0x0000000183D0F780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183D0E700-0x0000000183D0E850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183D0EAE0-0x0000000183D0EBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TowerFloorRecord other) => default; // 0x0000000183D0E950-0x0000000183D0EAE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183D0EFB0-0x0000000183D0F130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183D0FB00-0x0000000183D0FDE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183D0F7E0-0x0000000183D0F9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183D0EBB0-0x0000000183D0EDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TowerFloorRecord other) {} // 0x0000000183D0E460-0x0000000183D0E610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183D0E210-0x0000000183D0E400
}

