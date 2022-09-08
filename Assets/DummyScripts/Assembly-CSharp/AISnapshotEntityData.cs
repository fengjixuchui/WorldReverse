/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AISnapshotEntityData : MessageBase, IMessage<AISnapshotEntityData> // TypeDefIndex: 25691
{
	// Fields
	private static readonly MessageParser<AISnapshotEntityData> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B09577
	private uint entityId_; // 0x18
	public const int RealTimeFieldNumber = 2; // Metadata: 0x00B0957B
	private float realTime_; // 0x1C
	public const int TickTimeFieldNumber = 3; // Metadata: 0x00B0957F
	private float tickTime_; // 0x20
	public const int TacticFieldNumber = 4; // Metadata: 0x00B09583
	private uint tactic_; // 0x24
	public const int DistanceToPlayerFieldNumber = 5; // Metadata: 0x00B09587
	private float distanceToPlayer_; // 0x28
	public const int ThreatListSizeFieldNumber = 6; // Metadata: 0x00B0958B
	private uint threatListSize_; // 0x2C
	public const int ThreatTargetIdFieldNumber = 7; // Metadata: 0x00B0958F
	private uint threatTargetId_; // 0x30
	public const int AiTargetIdFieldNumber = 8; // Metadata: 0x00B09593
	private uint aiTargetId_; // 0x34
	public const int AttackTargetIdFieldNumber = 9; // Metadata: 0x00B09597
	private uint attackTargetId_; // 0x38
	public const int MovedDistanceFieldNumber = 10; // Metadata: 0x00B0959B
	private float movedDistance_; // 0x3C
	public const int FinishedSkillCyclesFieldNumber = 11; // Metadata: 0x00B0959F
	private static readonly FieldCodec<AISnapshotEntitySkillCycle> _repeated_finishedSkillCycles_codec; // 0x08
	private readonly RepeatedMessageField<AISnapshotEntitySkillCycle> finishedSkillCycles_; // 0x40
	public const int HittingAvatarsFieldNumber = 12; // Metadata: 0x00B095A3
	private static readonly MapField<uint, uint> _map_hittingAvatars_codec; // 0x10
	private readonly MapField<uint, uint> hittingAvatars_; // 0x48

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AISnapshotEntityData> Parser { get => default; } // 0x0000000182DB7F60-0x0000000182DB7FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182DB7BF0-0x0000000182DB7C80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182DB7320-0x0000000182DB73A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182DB60E0-0x0000000182DB6140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182DB8760-0x0000000182DB8850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182DB82E0-0x0000000182DB8340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182DB7D20-0x0000000182DB7E10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182DB8710-0x0000000182DB8760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182DB74E0-0x0000000182DB75D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000182DB8240-0x0000000182DB82E0 0x0000000182DB88B0-0x0000000182DB8950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float RealTime { get => default; set {} } // 0x0000000182DB8080-0x0000000182DB8120 0x0000000182DB6A90-0x0000000182DB6B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float TickTime { get => default; set {} } // 0x0000000182DB64D0-0x0000000182DB6570 0x0000000182DB73A0-0x0000000182DB7440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Tactic { get => default; set {} } // 0x0000000182DB6BD0-0x0000000182DB6C70 0x0000000182DB7AB0-0x0000000182DB7B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float DistanceToPlayer { get => default; set {} } // 0x0000000182DB78D0-0x0000000182DB7970 0x0000000182DB7B50-0x0000000182DB7BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ThreatListSize { get => default; set {} } // 0x0000000182DB69F0-0x0000000182DB6A90 0x0000000182DB7A10-0x0000000182DB7AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ThreatTargetId { get => default; set {} } // 0x0000000182DB7970-0x0000000182DB7A10 0x0000000182DB6570-0x0000000182DB6610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AiTargetId { get => default; set {} } // 0x0000000182DB67A0-0x0000000182DB6840 0x0000000182DB6700-0x0000000182DB67A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AttackTargetId { get => default; set {} } // 0x0000000182DB6140-0x0000000182DB61E0 0x0000000182DB7C80-0x0000000182DB7D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float MovedDistance { get => default; set {} } // 0x0000000182DB6B30-0x0000000182DB6BD0 0x0000000182DB6610-0x0000000182DB66B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AISnapshotEntitySkillCycle> FinishedSkillCycles { get => default; } // 0x0000000182DB8850-0x0000000182DB88B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> HittingAvatars { get => default; } // 0x0000000182DB7F00-0x0000000182DB7F60 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AISnapshotEntityData() {} // 0x0000000182DB9230-0x0000000182DB92E0
	static AISnapshotEntityData() {} // 0x0000000182DB90B0-0x0000000182DB9230

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AISnapshotEntityData Clone() => default; // 0x0000000182DB7E10-0x0000000182DB7F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AISnapshotEntityData ShallowCopy() => default; // 0x0000000182DB7440-0x0000000182DB74E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182DB66B0-0x0000000182DB6700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182DB8120-0x0000000182DB81B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182DB81B0-0x0000000182DB8240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182DB6840-0x0000000182DB69F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182DB6F10-0x0000000182DB6FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AISnapshotEntityData other) => default; // 0x0000000182DB6C70-0x0000000182DB6F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182DB75D0-0x0000000182DB78D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182DB8950-0x0000000182DB90B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182DB8340-0x0000000182DB8710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182DB6FE0-0x0000000182DB7320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AISnapshotEntityData other) {} // 0x0000000182DB61E0-0x0000000182DB64D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182DB5DD0-0x0000000182DB60E0
}

