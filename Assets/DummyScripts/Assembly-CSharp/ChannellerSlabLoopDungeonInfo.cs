/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChannellerSlabLoopDungeonInfo : MessageBase, IMessage<ChannellerSlabLoopDungeonInfo> // TypeDefIndex: 22268
{
	// Fields
	private static readonly MessageParser<ChannellerSlabLoopDungeonInfo> _parser; // 0x00
	public const int DungeonIndexFieldNumber = 1; // Metadata: 0x00B0131F
	private uint dungeonIndex_; // 0x18
	public const int ScoreFieldNumber = 2; // Metadata: 0x00B01323
	private uint score_; // 0x1C
	public const int IsFirstPassRewardTakenFieldNumber = 3; // Metadata: 0x00B01327
	private bool isFirstPassRewardTaken_; // 0x20
	public const int LastConditionIdListFieldNumber = 4; // Metadata: 0x00B0132B
	private static readonly FieldCodec<uint> _repeated_lastConditionIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> lastConditionIdList_; // 0x28
	public const int OpenTimeFieldNumber = 5; // Metadata: 0x00B0132F
	private uint openTime_; // 0x30
	public const int IsOpenFieldNumber = 6; // Metadata: 0x00B01333
	private bool isOpen_; // 0x34

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChannellerSlabLoopDungeonInfo> Parser { get => default; } // 0x0000000183A8AD30-0x0000000183A8ADC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183A8A920-0x0000000183A8A9B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183A8A4C0-0x0000000183A8A540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183A899B0-0x0000000183A89A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183A8B320-0x0000000183A8B410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183A8AF90-0x0000000183A8AFF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183A8AA50-0x0000000183A8AB40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183A8B2D0-0x0000000183A8B320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183A8A5E0-0x0000000183A8A6D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonIndex { get => default; set {} } // 0x0000000183A8AC90-0x0000000183A8AD30 0x0000000183A8A880-0x0000000183A8A920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Score { get => default; set {} } // 0x0000000183A8A9B0-0x0000000183A8AA50 0x0000000183A89A10-0x0000000183A89AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsFirstPassRewardTaken { get => default; set {} } // 0x0000000183A89DC0-0x0000000183A89E60 0x0000000183A89B50-0x0000000183A89BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> LastConditionIdList { get => default; } // 0x0000000183A8AC30-0x0000000183A8AC90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OpenTime { get => default; set {} } // 0x0000000183A8A420-0x0000000183A8A4C0 0x0000000183A8AEF0-0x0000000183A8AF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsOpen { get => default; set {} } // 0x0000000183A8AFF0-0x0000000183A8B090 0x0000000183A89AB0-0x0000000183A89B50

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabLoopDungeonInfo() {} // 0x0000000183A8B910-0x0000000183A8B9A0
	static ChannellerSlabLoopDungeonInfo() {} // 0x0000000183A8B830-0x0000000183A8B910

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabLoopDungeonInfo Clone() => default; // 0x0000000183A8AB40-0x0000000183A8AC30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabLoopDungeonInfo ShallowCopy() => default; // 0x0000000183A8A540-0x0000000183A8A5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183A89E60-0x0000000183A89EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A8AE50-0x0000000183A8AEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A8AEA0-0x0000000183A8AEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183A89EB0-0x0000000183A89FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183A89FB0-0x0000000183A8A080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChannellerSlabLoopDungeonInfo other) => default; // 0x0000000183A8A080-0x0000000183A8A220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183A8A6D0-0x0000000183A8A880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183A8B410-0x0000000183A8B830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183A8B090-0x0000000183A8B2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183A8A220-0x0000000183A8A420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChannellerSlabLoopDungeonInfo other) {} // 0x0000000183A89BF0-0x0000000183A89DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183A897D0-0x0000000183A899B0
}

