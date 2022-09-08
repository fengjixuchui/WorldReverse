/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SelectEffigyChallengeConditionReq : MessageBase, IMessage<SelectEffigyChallengeConditionReq> // TypeDefIndex: 22089
{
	// Fields
	private static readonly MessageParser<SelectEffigyChallengeConditionReq> _parser; // 0x00
	public const int ChallengeIdFieldNumber = 1; // Metadata: 0x00B00C3F
	private uint challengeId_; // 0x18
	public const int DifficultyIdFieldNumber = 2; // Metadata: 0x00B00C43
	private uint difficultyId_; // 0x1C
	public const int ConditionIdListFieldNumber = 3; // Metadata: 0x00B00C47
	private static readonly FieldCodec<uint> _repeated_conditionIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> conditionIdList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SelectEffigyChallengeConditionReq> Parser { get => default; } // 0x00000001811C1C20-0x00000001811C1CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001811C1810-0x00000001811C18A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001811C1430-0x00000001811C14B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001811C0D10-0x00000001811C0D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001811C2000-0x00000001811C20F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001811C1DE0-0x00000001811C1E40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001811C19A0-0x00000001811C1A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001811C1FB0-0x00000001811C2000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001811C1550-0x00000001811C1640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeId { get => default; set {} } // 0x00000001811C1770-0x00000001811C1810 0x00000001811C1B80-0x00000001811C1C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DifficultyId { get => default; set {} } // 0x00000001811C0D70-0x00000001811C0E10 0x00000001811C18A0-0x00000001811C1940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ConditionIdList { get => default; } // 0x00000001811C1940-0x00000001811C19A0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22090
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22091
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2109
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SelectEffigyChallengeConditionReq() {} // 0x00000001811C2440-0x00000001811C24D0
	static SelectEffigyChallengeConditionReq() {} // 0x00000001811C2360-0x00000001811C2440

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SelectEffigyChallengeConditionReq Clone() => default; // 0x00000001811C1A90-0x00000001811C1B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SelectEffigyChallengeConditionReq ShallowCopy() => default; // 0x00000001811C14B0-0x00000001811C1550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001811C0F70-0x00000001811C0FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001811C1D40-0x00000001811C1D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001811C1D90-0x00000001811C1DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001811C0FC0-0x00000001811C1090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001811C1090-0x00000001811C1160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SelectEffigyChallengeConditionReq other) => default; // 0x00000001811C1160-0x00000001811C12A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001811C1640-0x00000001811C1770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001811C20F0-0x00000001811C2360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001811C1E40-0x00000001811C1FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001811C12A0-0x00000001811C1430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SelectEffigyChallengeConditionReq other) {} // 0x00000001811C0E10-0x00000001811C0F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001811C0B90-0x00000001811C0D10
}

