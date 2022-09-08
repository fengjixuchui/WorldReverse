/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SeaLampActivityDetailInfo : MessageBase, IMessage<SeaLampActivityDetailInfo> // TypeDefIndex: 21892
{
	// Fields
	private static readonly MessageParser<SeaLampActivityDetailInfo> _parser; // 0x00
	public const int PhaseIdFieldNumber = 1; // Metadata: 0x00B0047B
	private uint phaseId_; // 0x18
	public const int ProgressFieldNumber = 2; // Metadata: 0x00B0047F
	private uint progress_; // 0x1C
	public const int DaysFieldNumber = 3; // Metadata: 0x00B00483
	private uint days_; // 0x20
	public const int ContributionFieldNumber = 4; // Metadata: 0x00B00487
	private uint contribution_; // 0x24
	public const int TakenContributionRewardListFieldNumber = 5; // Metadata: 0x00B0048B
	private static readonly FieldCodec<uint> _repeated_takenContributionRewardList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> takenContributionRewardList_; // 0x28
	public const int TakenPhaseRewardListFieldNumber = 6; // Metadata: 0x00B0048F
	private static readonly FieldCodec<uint> _repeated_takenPhaseRewardList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> takenPhaseRewardList_; // 0x30
	public const int FactorFieldNumber = 7; // Metadata: 0x00B00493
	private uint factor_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SeaLampActivityDetailInfo> Parser { get => default; } // 0x0000000184500A30-0x0000000184500AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184500580-0x0000000184500610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001844FFFC0-0x0000000184500040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001844FF440-0x00000001844FF4A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184500F10-0x0000000184501000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184500BF0-0x0000000184500C50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001845007B0-0x00000001845008A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184500EC0-0x0000000184500F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001845002C0-0x00000001845003B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PhaseId { get => default; set {} } // 0x00000001844FF3A0-0x00000001844FF440 0x00000001844FFF20-0x00000001844FFFC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Progress { get => default; set {} } // 0x0000000184500670-0x0000000184500710 0x0000000184500220-0x00000001845002C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Days { get => default; set {} } // 0x00000001844FF5A0-0x00000001844FF640 0x0000000184500990-0x0000000184500A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Contribution { get => default; set {} } // 0x0000000184500710-0x00000001845007B0 0x00000001844FF4A0-0x00000001844FF540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> TakenContributionRewardList { get => default; } // 0x00000001844FF540-0x00000001844FF5A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> TakenPhaseRewardList { get => default; } // 0x0000000184500610-0x0000000184500670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Factor { get => default; set {} } // 0x0000000184500040-0x00000001845000E0 0x0000000184500180-0x0000000184500220

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampActivityDetailInfo() {} // 0x0000000184501590-0x0000000184501640
	static SeaLampActivityDetailInfo() {} // 0x0000000184501490-0x0000000184501590

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampActivityDetailInfo Clone() => default; // 0x00000001845008A0-0x0000000184500990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampActivityDetailInfo ShallowCopy() => default; // 0x00000001845000E0-0x0000000184500180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001844FF830-0x00000001844FF880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184500B50-0x0000000184500BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184500BA0-0x0000000184500BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001844FF880-0x00000001844FF9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001844FFBB0-0x00000001844FFC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SeaLampActivityDetailInfo other) => default; // 0x00000001844FF9E0-0x00000001844FFBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001845003B0-0x0000000184500580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184501000-0x0000000184501490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184500C50-0x0000000184500EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001844FFC80-0x00000001844FFF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SeaLampActivityDetailInfo other) {} // 0x00000001844FF640-0x00000001844FF830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001844FF140-0x00000001844FF3A0
}

