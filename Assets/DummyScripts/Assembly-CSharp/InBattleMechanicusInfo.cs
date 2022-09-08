/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InBattleMechanicusInfo : MessageBase, IMessage<InBattleMechanicusInfo> // TypeDefIndex: 24110
{
	// Fields
	private static readonly MessageParser<InBattleMechanicusInfo> _parser; // 0x00
	public const int StageFieldNumber = 1; // Metadata: 0x00B05973
	private InBattleMechanicusStageType stage_; // 0x18
	public const int BeginTimeMsFieldNumber = 2; // Metadata: 0x00B05977
	private ulong beginTimeMs_; // 0x20
	public const int DurationMsFieldNumber = 3; // Metadata: 0x00B0597B
	private ulong durationMs_; // 0x28
	public const int RoundFieldNumber = 4; // Metadata: 0x00B0597F
	private uint round_; // 0x30
	public const int TotalRoundFieldNumber = 5; // Metadata: 0x00B05983
	private uint totalRound_; // 0x34
	public const int LeftMonsterFieldNumber = 6; // Metadata: 0x00B05987
	private uint leftMonster_; // 0x38
	public const int MonsterListFieldNumber = 7; // Metadata: 0x00B0598B
	private static readonly FieldCodec<InBattleMechanicusMonsterInfo> _repeated_monsterList_codec; // 0x08
	private readonly RepeatedMessageField<InBattleMechanicusMonsterInfo> monsterList_; // 0x40
	public const int PlayerListFieldNumber = 8; // Metadata: 0x00B0598F
	private static readonly FieldCodec<InBattleMechanicusPlayerInfo> _repeated_playerList_codec; // 0x10
	private readonly RepeatedMessageField<InBattleMechanicusPlayerInfo> playerList_; // 0x48
	public const int ExcapedMonsterNumFieldNumber = 9; // Metadata: 0x00B05993
	private uint excapedMonsterNum_; // 0x50
	public const int MaxExcapeMonsterNumFieldNumber = 10; // Metadata: 0x00B05997
	private uint maxExcapeMonsterNum_; // 0x54
	public const int BuildingStageDurationFieldNumber = 11; // Metadata: 0x00B0599B
	private uint buildingStageDuration_; // 0x58
	public const int PickCardListFieldNumber = 12; // Metadata: 0x00B0599F
	private static readonly FieldCodec<InBattleMechanicusCardInfo> _repeated_pickCardList_codec; // 0x18
	private readonly RepeatedMessageField<InBattleMechanicusCardInfo> pickCardList_; // 0x60
	public const int HistoryCardListFieldNumber = 13; // Metadata: 0x00B059A3
	private static readonly FieldCodec<InBattleMechanicusCardInfo> _repeated_historyCardList_codec; // 0x20
	private readonly RepeatedMessageField<InBattleMechanicusCardInfo> historyCardList_; // 0x68
	public const int WaitBeginTimeUsFieldNumber = 14; // Metadata: 0x00B059A7
	private ulong waitBeginTimeUs_; // 0x70
	public const int WaitSecondsFieldNumber = 15; // Metadata: 0x00B059AB
	private uint waitSeconds_; // 0x78
	public const int EntranceListFieldNumber = 16; // Metadata: 0x00B059AF
	private static readonly FieldCodec<uint> _repeated_entranceList_codec; // 0x28
	private readonly RepeatedPrimitiveField<uint> entranceList_; // 0x80
	public const int ExitListFieldNumber = 17; // Metadata: 0x00B059B3
	private static readonly FieldCodec<uint> _repeated_exitList_codec; // 0x30
	private readonly RepeatedPrimitiveField<uint> exitList_; // 0x88

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<InBattleMechanicusInfo> Parser { get => default; } // 0x000000018317D950-0x000000018317D9E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018317D320-0x000000018317D3B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018317CAD0-0x000000018317CB50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018317B5F0-0x000000018317B650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018317E6B0-0x000000018317E7A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018317DEB0-0x000000018317DF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018317D630-0x000000018317D720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018317E660-0x000000018317E6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018317CD30-0x000000018317CE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusStageType Stage { get => default; set {} } // 0x000000018317DFB0-0x000000018317E050 0x000000018317D3B0-0x000000018317D450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong BeginTimeMs { get => default; set {} } // 0x000000018317D1E0-0x000000018317D280 0x000000018317E560-0x000000018317E600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong DurationMs { get => default; set {} } // 0x000000018317DD70-0x000000018317DE10 0x000000018317CBF0-0x000000018317CC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Round { get => default; set {} } // 0x000000018317DBF0-0x000000018317DC90 0x000000018317B650-0x000000018317B6F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TotalRound { get => default; set {} } // 0x000000018317D280-0x000000018317D320 0x000000018317D8B0-0x000000018317D950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LeftMonster { get => default; set {} } // 0x000000018317CC90-0x000000018317CD30 0x000000018317BBA0-0x000000018317BC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<InBattleMechanicusMonsterInfo> MonsterList { get => default; } // 0x000000018317E7A0-0x000000018317E800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<InBattleMechanicusPlayerInfo> PlayerList { get => default; } // 0x000000018317E600-0x000000018317E660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ExcapedMonsterNum { get => default; set {} } // 0x000000018317DE10-0x000000018317DEB0 0x000000018317D9E0-0x000000018317DA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MaxExcapeMonsterNum { get => default; set {} } // 0x000000018317D4F0-0x000000018317D590 0x000000018317D450-0x000000018317D4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BuildingStageDuration { get => default; set {} } // 0x000000018317D590-0x000000018317D630 0x000000018317BFA0-0x000000018317C040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<InBattleMechanicusCardInfo> PickCardList { get => default; } // 0x000000018317BB40-0x000000018317BBA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<InBattleMechanicusCardInfo> HistoryCardList { get => default; } // 0x000000018317E800-0x000000018317E860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong WaitBeginTimeUs { get => default; set {} } // 0x000000018317B6F0-0x000000018317B790 0x000000018317C040-0x000000018317C0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WaitSeconds { get => default; set {} } // 0x000000018317DF10-0x000000018317DFB0 0x000000018317D810-0x000000018317D8B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> EntranceList { get => default; } // 0x000000018317C0E0-0x000000018317C140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ExitList { get => default; } // 0x000000018317E860-0x000000018317E8C0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusInfo() {} // 0x000000018317F470-0x000000018317F5C0
	static InBattleMechanicusInfo() {} // 0x000000018317F250-0x000000018317F470

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusInfo Clone() => default; // 0x000000018317D720-0x000000018317D810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusInfo ShallowCopy() => default; // 0x000000018317CB50-0x000000018317CBF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018317BC40-0x000000018317BC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018317DB10-0x000000018317DBF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018317DC90-0x000000018317DD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018317BC90-0x000000018317BFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018317C490-0x000000018317C560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(InBattleMechanicusInfo other) => default; // 0x000000018317C140-0x000000018317C490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018317CE20-0x000000018317D1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018317E8C0-0x000000018317F250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018317E050-0x000000018317E560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018317C560-0x000000018317CAD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(InBattleMechanicusInfo other) {} // 0x000000018317B790-0x000000018317BB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018317B130-0x000000018317B5F0
}

