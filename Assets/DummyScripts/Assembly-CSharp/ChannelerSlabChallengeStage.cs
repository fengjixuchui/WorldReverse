/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChannelerSlabChallengeStage : MessageBase, IMessage<ChannelerSlabChallengeStage> // TypeDefIndex: 22264
{
	// Fields
	private static readonly MessageParser<ChannelerSlabChallengeStage> _parser; // 0x00
	public const int StageIdFieldNumber = 1; // Metadata: 0x00B012E7
	private uint stageId_; // 0x18
	public const int OpenTimeFieldNumber = 2; // Metadata: 0x00B012EB
	private uint openTime_; // 0x1C
	public const int ChallengeListFieldNumber = 3; // Metadata: 0x00B012EF
	private static readonly FieldCodec<ChannelerSlabChallenge> _repeated_challengeList_codec; // 0x08
	private readonly RepeatedMessageField<ChannelerSlabChallenge> challengeList_; // 0x20
	public const int DungeonInfoFieldNumber = 4; // Metadata: 0x00B012F3
	private ChannelerSlabOneoffDungeon dungeonInfo_; // 0x28
	public const int IsOpenFieldNumber = 5; // Metadata: 0x00B012F7
	private bool isOpen_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChannelerSlabChallengeStage> Parser { get => default; } // 0x0000000182055A40-0x0000000182055AD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001820557D0-0x0000000182055860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182055310-0x0000000182055390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182054740-0x00000001820547A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001820561D0-0x00000001820562C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182055E80-0x0000000182055EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182055860-0x0000000182055950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182056180-0x00000001820561D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182055430-0x0000000182055520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StageId { get => default; set {} } // 0x0000000182055B60-0x0000000182055C00 0x0000000182055730-0x00000001820557D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OpenTime { get => default; set {} } // 0x00000001820551D0-0x0000000182055270 0x0000000182055D40-0x0000000182055DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ChannelerSlabChallenge> ChallengeList { get => default; } // 0x0000000182054CB0-0x0000000182054D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannelerSlabOneoffDungeon DungeonInfo { get => default; set {} } // 0x0000000182055270-0x0000000182055310 0x0000000182055DE0-0x0000000182055E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsOpen { get => default; set {} } // 0x0000000182055EE0-0x0000000182055F80 0x00000001820547A0-0x0000000182054840

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannelerSlabChallengeStage() {} // 0x0000000182056740-0x00000001820567D0
	static ChannelerSlabChallengeStage() {} // 0x0000000182056630-0x0000000182056740

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannelerSlabChallengeStage Clone() => default; // 0x0000000182055950-0x0000000182055A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannelerSlabChallengeStage ShallowCopy() => default; // 0x0000000182055390-0x0000000182055430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182054A70-0x0000000182054AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182055C00-0x0000000182055CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182055CA0-0x0000000182055D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182054AF0-0x0000000182054CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182054EB0-0x0000000182054F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChannelerSlabChallengeStage other) => default; // 0x0000000182054D10-0x0000000182054EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182055520-0x0000000182055730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001820562C0-0x0000000182056630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182055F80-0x0000000182056180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182054F80-0x00000001820551D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChannelerSlabChallengeStage other) {} // 0x0000000182054840-0x0000000182054A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182054550-0x0000000182054740
}

