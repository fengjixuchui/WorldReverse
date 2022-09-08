/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MechanicusInfo : MessageBase, IMessage<MechanicusInfo> // TypeDefIndex: 23876
{
	// Fields
	private static readonly MessageParser<MechanicusInfo> _parser; // 0x00
	public const int MechanicusIdFieldNumber = 1; // Metadata: 0x00B05097
	private uint mechanicusId_; // 0x18
	public const int CoinFieldNumber = 2; // Metadata: 0x00B0509B
	private uint coin_; // 0x1C
	public const int GearLevelPairListFieldNumber = 3; // Metadata: 0x00B0509F
	private static readonly FieldCodec<Uint32Pair> _repeated_gearLevelPairList_codec; // 0x08
	private readonly RepeatedMessageField<Uint32Pair> gearLevelPairList_; // 0x20
	public const int OpenSequenceIdListFieldNumber = 4; // Metadata: 0x00B050A3
	private static readonly FieldCodec<uint> _repeated_openSequenceIdList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> openSequenceIdList_; // 0x28
	public const int IsFinishTeachDungeonFieldNumber = 5; // Metadata: 0x00B050A7
	private bool isFinishTeachDungeon_; // 0x30
	public const int FinishDifficultLevelListFieldNumber = 6; // Metadata: 0x00B050AB
	private static readonly FieldCodec<uint> _repeated_finishDifficultLevelList_codec; // 0x18
	private readonly RepeatedPrimitiveField<uint> finishDifficultLevelList_; // 0x38
	public const int PunishOverTimeFieldNumber = 7; // Metadata: 0x00B050AF
	private uint punishOverTime_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MechanicusInfo> Parser { get => default; } // 0x00000001820218B0-0x0000000182021940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182021460-0x00000001820214F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182020F80-0x0000000182021000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182020430-0x0000000182020490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182021F30-0x0000000182022020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182021B50-0x0000000182021BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182021590-0x0000000182021680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182021E40-0x0000000182021E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001820210A0-0x0000000182021190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MechanicusId { get => default; set {} } // 0x00000001820214F0-0x0000000182021590 0x00000001820209C0-0x0000000182020A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Coin { get => default; set {} } // 0x0000000182022020-0x00000001820220C0 0x0000000182021E90-0x0000000182021F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Uint32Pair> GearLevelPairList { get => default; } // 0x0000000182021360-0x00000001820213C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> OpenSequenceIdList { get => default; } // 0x00000001820219D0-0x0000000182021A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsFinishTeachDungeon { get => default; set {} } // 0x00000001820213C0-0x0000000182021460 0x0000000182021810-0x00000001820218B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> FinishDifficultLevelList { get => default; } // 0x0000000182020960-0x00000001820209C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PunishOverTime { get => default; set {} } // 0x0000000182021770-0x0000000182021810 0x0000000182020490-0x0000000182020530

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MechanicusInfo() {} // 0x0000000182022680-0x0000000182022750
	static MechanicusInfo() {} // 0x0000000182022530-0x0000000182022680

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MechanicusInfo Clone() => default; // 0x0000000182021680-0x0000000182021770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MechanicusInfo ShallowCopy() => default; // 0x0000000182021000-0x00000001820210A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182020750-0x00000001820207A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182021A30-0x0000000182021AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182021AC0-0x0000000182021B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001820207A0-0x0000000182020960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182020A60-0x0000000182020B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MechanicusInfo other) => default; // 0x0000000182020B30-0x0000000182020D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182021190-0x0000000182021360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001820220C0-0x0000000182022530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182021BB0-0x0000000182021E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182020D10-0x0000000182020F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MechanicusInfo other) {} // 0x0000000182020530-0x0000000182020750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182020180-0x0000000182020430
}

