/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EffigyActivityDetailInfo : MessageBase, IMessage<EffigyActivityDetailInfo> // TypeDefIndex: 22063
{
	// Fields
	private static readonly MessageParser<EffigyActivityDetailInfo> _parser; // 0x00
	public const int DailyInfoListFieldNumber = 1; // Metadata: 0x00B00B33
	private static readonly FieldCodec<EffigyDailyInfo> _repeated_dailyInfoList_codec; // 0x08
	private readonly RepeatedMessageField<EffigyDailyInfo> dailyInfoList_; // 0x18
	public const int LastDifficultyIdFieldNumber = 2; // Metadata: 0x00B00B37
	private uint lastDifficultyId_; // 0x20
	public const int CurScoreFieldNumber = 3; // Metadata: 0x00B00B3B
	private uint curScore_; // 0x24
	public const int TakenRewardIndexListFieldNumber = 4; // Metadata: 0x00B00B3F
	private static readonly FieldCodec<uint> _repeated_takenRewardIndexList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> takenRewardIndexList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EffigyActivityDetailInfo> Parser { get => default; } // 0x000000018381DDA0-0x000000018381DE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018381DAD0-0x000000018381DB60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018381D670-0x000000018381D6F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018381CE90-0x000000018381CEF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018381E450-0x000000018381E540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018381E120-0x000000018381E180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018381DBC0-0x000000018381DCB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018381E360-0x000000018381E3B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018381D830-0x000000018381D920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<EffigyDailyInfo> DailyInfoList { get => default; } // 0x000000018381DA70-0x000000018381DAD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LastDifficultyId { get => default; set {} } // 0x000000018381DFE0-0x000000018381E080 0x000000018381E080-0x000000018381E120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurScore { get => default; set {} } // 0x000000018381E3B0-0x000000018381E450 0x000000018381D790-0x000000018381D830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> TakenRewardIndexList { get => default; } // 0x000000018381DB60-0x000000018381DBC0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EffigyActivityDetailInfo() {} // 0x000000018381E950-0x000000018381EA00
	static EffigyActivityDetailInfo() {} // 0x000000018381E820-0x000000018381E950

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EffigyActivityDetailInfo Clone() => default; // 0x000000018381DCB0-0x000000018381DDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EffigyActivityDetailInfo ShallowCopy() => default; // 0x000000018381D6F0-0x000000018381D790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018381D0A0-0x000000018381D0F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018381DEC0-0x000000018381DF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018381DF50-0x000000018381DFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018381D0F0-0x000000018381D240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018381D3B0-0x000000018381D480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EffigyActivityDetailInfo other) => default; // 0x000000018381D240-0x000000018381D3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018381D920-0x000000018381DA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018381E540-0x000000018381E820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018381E180-0x000000018381E360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018381D480-0x000000018381D670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EffigyActivityDetailInfo other) {} // 0x000000018381CEF0-0x000000018381D0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018381CCA0-0x000000018381CE90
}

