/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class StartEffigyChallengeRsp : MessageBase, IMessage<StartEffigyChallengeRsp> // TypeDefIndex: 22067
{
	// Fields
	private static readonly MessageParser<StartEffigyChallengeRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B00B67
	private int retcode_; // 0x18
	public const int ChallengeIdFieldNumber = 2; // Metadata: 0x00B00B6B
	private uint challengeId_; // 0x1C
	public const int DifficultyIdFieldNumber = 3; // Metadata: 0x00B00B6F
	private uint difficultyId_; // 0x20
	public const int ConditionIdListFieldNumber = 4; // Metadata: 0x00B00B73
	private static readonly FieldCodec<uint> _repeated_conditionIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> conditionIdList_; // 0x28
	public const int PointIdFieldNumber = 5; // Metadata: 0x00B00B77
	private uint pointId_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<StartEffigyChallengeRsp> Parser { get => default; } // 0x0000000183A85D30-0x0000000183A85DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183A85880-0x0000000183A85910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183A85450-0x0000000183A854D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183A84A20-0x0000000183A84A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183A861A0-0x0000000183A86290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183A85EF0-0x0000000183A85F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183A85AB0-0x0000000183A85BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183A86150-0x0000000183A861A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183A85570-0x0000000183A85660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183A853B0-0x0000000183A85450 0x0000000183A84E00-0x0000000183A84EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeId { get => default; set {} } // 0x0000000183A857E0-0x0000000183A85880 0x0000000183A85C90-0x0000000183A85D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DifficultyId { get => default; set {} } // 0x0000000183A84A80-0x0000000183A84B20 0x0000000183A85910-0x0000000183A859B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ConditionIdList { get => default; } // 0x0000000183A85A50-0x0000000183A85AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PointId { get => default; set {} } // 0x0000000183A859B0-0x0000000183A85A50 0x0000000183A84EA0-0x0000000183A84F40

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22068
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22069
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2102
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StartEffigyChallengeRsp() {} // 0x0000000183A86700-0x0000000183A86790
	static StartEffigyChallengeRsp() {} // 0x0000000183A86620-0x0000000183A86700

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StartEffigyChallengeRsp Clone() => default; // 0x0000000183A85BA0-0x0000000183A85C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StartEffigyChallengeRsp ShallowCopy() => default; // 0x0000000183A854D0-0x0000000183A85570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183A84CC0-0x0000000183A84D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A85E50-0x0000000183A85EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A85EA0-0x0000000183A85EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183A84D10-0x0000000183A84E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183A850C0-0x0000000183A85190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(StartEffigyChallengeRsp other) => default; // 0x0000000183A84F40-0x0000000183A850C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183A85660-0x0000000183A857E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183A86290-0x0000000183A86620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183A85F50-0x0000000183A86150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183A85190-0x0000000183A853B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(StartEffigyChallengeRsp other) {} // 0x0000000183A84B20-0x0000000183A84CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183A84860-0x0000000183A84A20
}

