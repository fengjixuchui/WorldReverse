/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChannellerSlabLoopDungeonStageInfo : MessageBase, IMessage<ChannellerSlabLoopDungeonStageInfo> // TypeDefIndex: 22269
{
	// Fields
	private static readonly MessageParser<ChannellerSlabLoopDungeonStageInfo> _parser; // 0x00
	public const int DungeonInfoListFieldNumber = 1; // Metadata: 0x00B01337
	private static readonly FieldCodec<ChannellerSlabLoopDungeonInfo> _repeated_dungeonInfoList_codec; // 0x08
	private readonly RepeatedMessageField<ChannellerSlabLoopDungeonInfo> dungeonInfoList_; // 0x18
	public const int LastDifficultyIdFieldNumber = 2; // Metadata: 0x00B0133B
	private uint lastDifficultyId_; // 0x20
	public const int TakenRewardIndexListFieldNumber = 3; // Metadata: 0x00B0133F
	private static readonly FieldCodec<uint> _repeated_takenRewardIndexList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> takenRewardIndexList_; // 0x28
	public const int OpenTimeFieldNumber = 4; // Metadata: 0x00B01343
	private uint openTime_; // 0x30
	public const int IsOpenFieldNumber = 5; // Metadata: 0x00B01347
	private bool isOpen_; // 0x34

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChannellerSlabLoopDungeonStageInfo> Parser { get => default; } // 0x0000000184B32880-0x0000000184B32910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184B325B0-0x0000000184B32640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184B32220-0x0000000184B322A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184B31830-0x0000000184B31890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184B33010-0x0000000184B33100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184B32CA0-0x0000000184B32D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184B326A0-0x0000000184B32790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184B32FC0-0x0000000184B33010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184B32340-0x0000000184B32430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ChannellerSlabLoopDungeonInfo> DungeonInfoList { get => default; } // 0x0000000184B31B10-0x0000000184B31B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LastDifficultyId { get => default; set {} } // 0x0000000184B32B60-0x0000000184B32C00 0x0000000184B32C00-0x0000000184B32CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> TakenRewardIndexList { get => default; } // 0x0000000184B32640-0x0000000184B326A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OpenTime { get => default; set {} } // 0x0000000184B32180-0x0000000184B32220 0x0000000184B32AC0-0x0000000184B32B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsOpen { get => default; set {} } // 0x0000000184B32D00-0x0000000184B32DA0 0x0000000184B31890-0x0000000184B31930

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabLoopDungeonStageInfo() {} // 0x0000000184B335A0-0x0000000184B33650
	static ChannellerSlabLoopDungeonStageInfo() {} // 0x0000000184B33470-0x0000000184B335A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabLoopDungeonStageInfo Clone() => default; // 0x0000000184B32790-0x0000000184B32880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabLoopDungeonStageInfo ShallowCopy() => default; // 0x0000000184B322A0-0x0000000184B32340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184B31B70-0x0000000184B31BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B329A0-0x0000000184B32A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B32A30-0x0000000184B32AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184B31BC0-0x0000000184B31D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184B31EB0-0x0000000184B31F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChannellerSlabLoopDungeonStageInfo other) => default; // 0x0000000184B31D10-0x0000000184B31EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184B32430-0x0000000184B325B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184B33100-0x0000000184B33470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184B32DA0-0x0000000184B32FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184B31F80-0x0000000184B32180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChannellerSlabLoopDungeonStageInfo other) {} // 0x0000000184B31930-0x0000000184B31B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184B31620-0x0000000184B31830
}

