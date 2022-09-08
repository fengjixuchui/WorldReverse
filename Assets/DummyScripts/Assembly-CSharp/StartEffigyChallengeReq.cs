/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class StartEffigyChallengeReq : MessageBase, IMessage<StartEffigyChallengeReq> // TypeDefIndex: 22064
{
	// Fields
	private static readonly MessageParser<StartEffigyChallengeReq> _parser; // 0x00
	public const int ChallengeIdFieldNumber = 1; // Metadata: 0x00B00B43
	private uint challengeId_; // 0x18
	public const int DifficultyIdFieldNumber = 2; // Metadata: 0x00B00B47
	private uint difficultyId_; // 0x1C
	public const int ConditionIdListFieldNumber = 3; // Metadata: 0x00B00B4B
	private static readonly FieldCodec<uint> _repeated_conditionIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> conditionIdList_; // 0x20
	public const int PointIdFieldNumber = 4; // Metadata: 0x00B00B4F
	private uint pointId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<StartEffigyChallengeReq> Parser { get => default; } // 0x000000018657D670-0x000000018657D700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018657D1C0-0x000000018657D250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018657CDB0-0x000000018657CE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018657C540-0x000000018657C5A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018657DAA0-0x000000018657DB90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018657D830-0x000000018657D890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018657D3F0-0x000000018657D4E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018657DA50-0x000000018657DAA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018657CED0-0x000000018657CFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeId { get => default; set {} } // 0x000000018657D120-0x000000018657D1C0 0x000000018657D5D0-0x000000018657D670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DifficultyId { get => default; set {} } // 0x000000018657C5A0-0x000000018657C640 0x000000018657D250-0x000000018657D2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ConditionIdList { get => default; } // 0x000000018657D390-0x000000018657D3F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PointId { get => default; set {} } // 0x000000018657D2F0-0x000000018657D390 0x000000018657C900-0x000000018657C9A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22065
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22066
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2101
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StartEffigyChallengeReq() {} // 0x000000018657DF70-0x000000018657E000
	static StartEffigyChallengeReq() {} // 0x000000018657DE90-0x000000018657DF70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StartEffigyChallengeReq Clone() => default; // 0x000000018657D4E0-0x000000018657D5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StartEffigyChallengeReq ShallowCopy() => default; // 0x000000018657CE30-0x000000018657CED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018657C7C0-0x000000018657C810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018657D790-0x000000018657D7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018657D7E0-0x000000018657D830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018657C810-0x000000018657C900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018657CB00-0x000000018657CBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(StartEffigyChallengeReq other) => default; // 0x000000018657C9A0-0x000000018657CB00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018657CFC0-0x000000018657D120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018657DB90-0x000000018657DE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018657D890-0x000000018657DA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018657CBD0-0x000000018657CDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(StartEffigyChallengeReq other) {} // 0x000000018657C640-0x000000018657C7C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018657C3A0-0x000000018657C540
}

