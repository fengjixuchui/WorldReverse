/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChannelerSlabActivityDetailInfo : MessageBase, IMessage<ChannelerSlabActivityDetailInfo> // TypeDefIndex: 22270
{
	// Fields
	private static readonly MessageParser<ChannelerSlabActivityDetailInfo> _parser; // 0x00
	public const int StageListFieldNumber = 1; // Metadata: 0x00B0134B
	private static readonly FieldCodec<ChannelerSlabChallengeStage> _repeated_stageList_codec; // 0x08
	private readonly RepeatedMessageField<ChannelerSlabChallengeStage> stageList_; // 0x18
	public const int PlayEndTimeFieldNumber = 2; // Metadata: 0x00B0134F
	private uint playEndTime_; // 0x20
	public const int BuffInfoFieldNumber = 3; // Metadata: 0x00B01353
	private ChannellerSlabBuffInfo buffInfo_; // 0x28
	public const int LoopDungeonStageInfoFieldNumber = 4; // Metadata: 0x00B01357
	private ChannellerSlabLoopDungeonStageInfo loopDungeonStageInfo_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChannelerSlabActivityDetailInfo> Parser { get => default; } // 0x00000001824F4A40-0x00000001824F4AD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001824F4630-0x00000001824F46C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001824F41E0-0x00000001824F4260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001824F36A0-0x00000001824F3700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001824F5060-0x00000001824F5150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001824F4CC0-0x00000001824F4D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001824F4720-0x00000001824F4810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001824F5010-0x00000001824F5060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001824F4300-0x00000001824F43F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ChannelerSlabChallengeStage> StageList { get => default; } // 0x00000001824F46C0-0x00000001824F4720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayEndTime { get => default; set {} } // 0x00000001824F5150-0x00000001824F51F0 0x00000001824F3C40-0x00000001824F3CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabBuffInfo BuffInfo { get => default; set {} } // 0x00000001824F49A0-0x00000001824F4A40 0x00000001824F4F70-0x00000001824F5010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabLoopDungeonStageInfo LoopDungeonStageInfo { get => default; set {} } // 0x00000001824F4900-0x00000001824F49A0 0x00000001824F4D20-0x00000001824F4DC0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannelerSlabActivityDetailInfo() {} // 0x00000001824F55D0-0x00000001824F5660
	static ChannelerSlabActivityDetailInfo() {} // 0x00000001824F54C0-0x00000001824F55D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannelerSlabActivityDetailInfo Clone() => default; // 0x00000001824F4810-0x00000001824F4900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannelerSlabActivityDetailInfo ShallowCopy() => default; // 0x00000001824F4260-0x00000001824F4300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001824F3950-0x00000001824F39E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001824F4B60-0x00000001824F4C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001824F4C10-0x00000001824F4CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001824F39E0-0x00000001824F3C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001824F3E70-0x00000001824F3F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChannelerSlabActivityDetailInfo other) => default; // 0x00000001824F3CE0-0x00000001824F3E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001824F43F0-0x00000001824F4630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001824F51F0-0x00000001824F54C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001824F4DC0-0x00000001824F4F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001824F3F40-0x00000001824F41E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChannelerSlabActivityDetailInfo other) {} // 0x00000001824F3700-0x00000001824F3950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001824F3490-0x00000001824F36A0
}

