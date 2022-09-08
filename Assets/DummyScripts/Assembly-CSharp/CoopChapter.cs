/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CoopChapter : MessageBase, IMessage<CoopChapter> // TypeDefIndex: 22702
{
	// Fields
	private static readonly MessageParser<CoopChapter> _parser; // 0x00
	public const int IdFieldNumber = 1; // Metadata: 0x00B022EB
	private uint id_; // 0x18
	public const int StateFieldNumber = 2; // Metadata: 0x00B022EF
	private Types.State state_; // 0x1C
	public const int LockReasonListFieldNumber = 3; // Metadata: 0x00B022F3
	private static readonly FieldCodec<uint> _repeated_lockReasonList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> lockReasonList_; // 0x20
	public const int CoopPointListFieldNumber = 4; // Metadata: 0x00B022F7
	private static readonly FieldCodec<CoopPoint> _repeated_coopPointList_codec; // 0x10
	private readonly RepeatedMessageField<CoopPoint> coopPointList_; // 0x28
	public const int CoopRewardListFieldNumber = 5; // Metadata: 0x00B022FB
	private static readonly FieldCodec<CoopReward> _repeated_coopRewardList_codec; // 0x18
	private readonly RepeatedMessageField<CoopReward> coopRewardList_; // 0x30
	public const int CoopCgListFieldNumber = 6; // Metadata: 0x00B022FF
	private static readonly FieldCodec<CoopCg> _repeated_coopCgList_codec; // 0x20
	private readonly RepeatedMessageField<CoopCg> coopCgList_; // 0x38
	public const int TotalEndCountFieldNumber = 7; // Metadata: 0x00B02303
	private uint totalEndCount_; // 0x40
	public const int FinishedEndCountFieldNumber = 8; // Metadata: 0x00B02307
	private uint finishedEndCount_; // 0x44
	public const int SeenEndingMapFieldNumber = 9; // Metadata: 0x00B0230B
	private static readonly MapField<uint, uint> _map_seenEndingMap_codec; // 0x28
	private readonly MapField<uint, uint> seenEndingMap_; // 0x48
	public const int FinishDialogListFieldNumber = 10; // Metadata: 0x00B0230F
	private static readonly FieldCodec<uint> _repeated_finishDialogList_codec; // 0x30
	private readonly RepeatedPrimitiveField<uint> finishDialogList_; // 0x50

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CoopChapter> Parser { get => default; } // 0x0000000180F1E470-0x0000000180F1E500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000180F1E0A0-0x0000000180F1E130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000180F1DB50-0x0000000180F1DBD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000180F1CC00-0x0000000180F1CC60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000180F1ECC0-0x0000000180F1EDB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000180F1E850-0x0000000180F1E8B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000180F1E230-0x0000000180F1E320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000180F1EC70-0x0000000180F1ECC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000180F1DCD0-0x0000000180F1DDC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Id { get => default; set {} } // 0x0000000180F1DAB0-0x0000000180F1DB50 0x0000000180F1E500-0x0000000180F1E5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.State State { get => default; set {} } // 0x0000000180F1D970-0x0000000180F1DA10 0x0000000180F1DA10-0x0000000180F1DAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> LockReasonList { get => default; } // 0x0000000180F1EDB0-0x0000000180F1EE10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<CoopPoint> CoopPointList { get => default; } // 0x0000000180F1CBA0-0x0000000180F1CC00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<CoopReward> CoopRewardList { get => default; } // 0x0000000180F1E130-0x0000000180F1E190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<CoopCg> CoopCgList { get => default; } // 0x0000000180F1D280-0x0000000180F1D2E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TotalEndCount { get => default; set {} } // 0x0000000180F1E190-0x0000000180F1E230 0x0000000180F1E8B0-0x0000000180F1E950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FinishedEndCount { get => default; set {} } // 0x0000000180F1E7B0-0x0000000180F1E850 0x0000000180F1CC60-0x0000000180F1CD00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> SeenEndingMap { get => default; } // 0x0000000180F1E410-0x0000000180F1E470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> FinishDialogList { get => default; } // 0x0000000180F1DBD0-0x0000000180F1DC30 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22703
	{
		// Nested types
		public enum State // TypeDefIndex: 22704
		{
			Close = 0,
			CondNotMeet = 1,
			CondMeet = 2,
			Accept = 3
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopChapter() {} // 0x0000000180F1F630-0x0000000180F1F770
	static CoopChapter() {} // 0x0000000180F1F3D0-0x0000000180F1F630

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopChapter Clone() => default; // 0x0000000180F1E320-0x0000000180F1E410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopChapter ShallowCopy() => default; // 0x0000000180F1DC30-0x0000000180F1DCD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000180F1CF80-0x0000000180F1CFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180F1E630-0x0000000180F1E6F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180F1E6F0-0x0000000180F1E7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000180F1CFD0-0x0000000180F1D280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000180F1D560-0x0000000180F1D630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CoopChapter other) => default; // 0x0000000180F1D2E0-0x0000000180F1D560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000180F1DDC0-0x0000000180F1E0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000180F1EE10-0x0000000180F1F3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000180F1E950-0x0000000180F1EC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000180F1D630-0x0000000180F1D970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CoopChapter other) {} // 0x0000000180F1CD00-0x0000000180F1CF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000180F1C7D0-0x0000000180F1CBA0
}

