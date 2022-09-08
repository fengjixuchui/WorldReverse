/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SelectEffigyChallengeConditionRsp : MessageBase, IMessage<SelectEffigyChallengeConditionRsp> // TypeDefIndex: 22092
{
	// Fields
	private static readonly MessageParser<SelectEffigyChallengeConditionRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B00C5F
	private int retcode_; // 0x18
	public const int ChallengeIdFieldNumber = 2; // Metadata: 0x00B00C63
	private uint challengeId_; // 0x1C
	public const int DifficultyIdFieldNumber = 3; // Metadata: 0x00B00C67
	private uint difficultyId_; // 0x20
	public const int ConditionIdListFieldNumber = 4; // Metadata: 0x00B00C6B
	private static readonly FieldCodec<uint> _repeated_conditionIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> conditionIdList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SelectEffigyChallengeConditionRsp> Parser { get => default; } // 0x0000000182AAD0D0-0x0000000182AAD160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182AACCC0-0x0000000182AACD50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182AAC8B0-0x0000000182AAC930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182AABFB0-0x0000000182AAC010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182AAD4F0-0x0000000182AAD5E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182AAD290-0x0000000182AAD2F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182AACE50-0x0000000182AACF40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182AAD4A0-0x0000000182AAD4F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182AAC9D0-0x0000000182AACAC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182AAC810-0x0000000182AAC8B0 0x0000000182AAC360-0x0000000182AAC400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeId { get => default; set {} } // 0x0000000182AACC20-0x0000000182AACCC0 0x0000000182AAD030-0x0000000182AAD0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DifficultyId { get => default; set {} } // 0x0000000182AAC010-0x0000000182AAC0B0 0x0000000182AACD50-0x0000000182AACDF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ConditionIdList { get => default; } // 0x0000000182AACDF0-0x0000000182AACE50 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22093
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22094
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2110
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SelectEffigyChallengeConditionRsp() {} // 0x0000000182AAD9C0-0x0000000182AADA50
	static SelectEffigyChallengeConditionRsp() {} // 0x0000000182AAD8E0-0x0000000182AAD9C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SelectEffigyChallengeConditionRsp Clone() => default; // 0x0000000182AACF40-0x0000000182AAD030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SelectEffigyChallengeConditionRsp ShallowCopy() => default; // 0x0000000182AAC930-0x0000000182AAC9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182AAC230-0x0000000182AAC280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182AAD1F0-0x0000000182AAD240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182AAD240-0x0000000182AAD290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182AAC280-0x0000000182AAC360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182AAC560-0x0000000182AAC630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SelectEffigyChallengeConditionRsp other) => default; // 0x0000000182AAC400-0x0000000182AAC560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182AACAC0-0x0000000182AACC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182AAD5E0-0x0000000182AAD8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182AAD2F0-0x0000000182AAD4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182AAC630-0x0000000182AAC810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SelectEffigyChallengeConditionRsp other) {} // 0x0000000182AAC0B0-0x0000000182AAC230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182AABE10-0x0000000182AABFB0
}

