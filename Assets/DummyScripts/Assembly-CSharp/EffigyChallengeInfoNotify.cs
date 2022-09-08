/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EffigyChallengeInfoNotify : MessageBase, IMessage<EffigyChallengeInfoNotify> // TypeDefIndex: 22070
{
	// Fields
	private static readonly MessageParser<EffigyChallengeInfoNotify> _parser; // 0x00
	public const int ChallengeIdFieldNumber = 1; // Metadata: 0x00B00B8B
	private uint challengeId_; // 0x18
	public const int DifficultyIdFieldNumber = 2; // Metadata: 0x00B00B8F
	private uint difficultyId_; // 0x1C
	public const int ConditionIdListFieldNumber = 3; // Metadata: 0x00B00B93
	private static readonly FieldCodec<uint> _repeated_conditionIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> conditionIdList_; // 0x20
	public const int ChallengeScoreFieldNumber = 4; // Metadata: 0x00B00B97
	private uint challengeScore_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EffigyChallengeInfoNotify> Parser { get => default; } // 0x0000000184EAA0D0-0x0000000184EAA160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184EA9CC0-0x0000000184EA9D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184EA98B0-0x0000000184EA9930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184EA90E0-0x0000000184EA9140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184EAA640-0x0000000184EAA730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184EAA330-0x0000000184EAA390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184EA9E50-0x0000000184EA9F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184EAA5F0-0x0000000184EAA640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184EA99D0-0x0000000184EA9AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeId { get => default; set {} } // 0x0000000184EA9C20-0x0000000184EA9CC0 0x0000000184EAA030-0x0000000184EAA0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DifficultyId { get => default; set {} } // 0x0000000184EA9140-0x0000000184EA91E0 0x0000000184EA9D50-0x0000000184EA9DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ConditionIdList { get => default; } // 0x0000000184EA9DF0-0x0000000184EA9E50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeScore { get => default; set {} } // 0x0000000184EAA290-0x0000000184EAA330 0x0000000184EAA550-0x0000000184EAA5F0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22071
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22072
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2103
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EffigyChallengeInfoNotify() {} // 0x0000000184EAAB10-0x0000000184EAABA0
	static EffigyChallengeInfoNotify() {} // 0x0000000184EAAA30-0x0000000184EAAB10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EffigyChallengeInfoNotify Clone() => default; // 0x0000000184EA9F40-0x0000000184EAA030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EffigyChallengeInfoNotify ShallowCopy() => default; // 0x0000000184EA9930-0x0000000184EA99D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184EA9360-0x0000000184EA93B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184EAA1F0-0x0000000184EAA240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184EAA240-0x0000000184EAA290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184EA93B0-0x0000000184EA94A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184EA9600-0x0000000184EA96D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EffigyChallengeInfoNotify other) => default; // 0x0000000184EA94A0-0x0000000184EA9600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184EA9AC0-0x0000000184EA9C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184EAA730-0x0000000184EAAA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184EAA390-0x0000000184EAA550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184EA96D0-0x0000000184EA98B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EffigyChallengeInfoNotify other) {} // 0x0000000184EA91E0-0x0000000184EA9360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184EA8F40-0x0000000184EA90E0
}

