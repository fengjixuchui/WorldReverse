/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DungeonChallengeBeginNotify : MessageBase, IMessage<DungeonChallengeBeginNotify> // TypeDefIndex: 22858
{
	// Fields
	private static readonly MessageParser<DungeonChallengeBeginNotify> _parser; // 0x00
	public const int ChallengeIdFieldNumber = 1; // Metadata: 0x00B028B7
	private uint challengeId_; // 0x18
	public const int ChallengeIndexFieldNumber = 2; // Metadata: 0x00B028BB
	private uint challengeIndex_; // 0x1C
	public const int ParamListFieldNumber = 3; // Metadata: 0x00B028BF
	private static readonly FieldCodec<uint> _repeated_paramList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> paramList_; // 0x20
	public const int GroupIdFieldNumber = 4; // Metadata: 0x00B028C3
	private uint groupId_; // 0x28
	public const int FatherIndexFieldNumber = 5; // Metadata: 0x00B028C7
	private uint fatherIndex_; // 0x2C
	public const int UidListFieldNumber = 6; // Metadata: 0x00B028CB
	private static readonly FieldCodec<uint> _repeated_uidList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> uidList_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DungeonChallengeBeginNotify> Parser { get => default; } // 0x0000000181EE4420-0x0000000181EE44B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181EE3FD0-0x0000000181EE4060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181EE3B70-0x0000000181EE3BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181EE30D0-0x0000000181EE3130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181EE4A40-0x0000000181EE4B30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181EE45E0-0x0000000181EE4640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181EE4100-0x0000000181EE41F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181EE4990-0x0000000181EE49E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181EE3C90-0x0000000181EE3D80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeId { get => default; set {} } // 0x0000000181EE3F30-0x0000000181EE3FD0 0x0000000181EE4380-0x0000000181EE4420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeIndex { get => default; set {} } // 0x0000000181EE3530-0x0000000181EE35D0 0x0000000181EE4060-0x0000000181EE4100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ParamList { get => default; } // 0x0000000181EE46E0-0x0000000181EE4740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GroupId { get => default; set {} } // 0x0000000181EE41F0-0x0000000181EE4290 0x0000000181EE3AD0-0x0000000181EE3B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FatherIndex { get => default; set {} } // 0x0000000181EE4640-0x0000000181EE46E0 0x0000000181EE3340-0x0000000181EE33E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> UidList { get => default; } // 0x0000000181EE49E0-0x0000000181EE4A40 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22859
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22860
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 918
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonChallengeBeginNotify() {} // 0x0000000181EE5030-0x0000000181EE50E0
	static DungeonChallengeBeginNotify() {} // 0x0000000181EE4F30-0x0000000181EE5030

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonChallengeBeginNotify Clone() => default; // 0x0000000181EE4290-0x0000000181EE4380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonChallengeBeginNotify ShallowCopy() => default; // 0x0000000181EE3BF0-0x0000000181EE3C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181EE32F0-0x0000000181EE3340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181EE4540-0x0000000181EE4590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181EE4590-0x0000000181EE45E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181EE33E0-0x0000000181EE3530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181EE35D0-0x0000000181EE36A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DungeonChallengeBeginNotify other) => default; // 0x0000000181EE36A0-0x0000000181EE3850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181EE3D80-0x0000000181EE3F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181EE4B30-0x0000000181EE4F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181EE4740-0x0000000181EE4990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181EE3850-0x0000000181EE3AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DungeonChallengeBeginNotify other) {} // 0x0000000181EE3130-0x0000000181EE32F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181EE2E90-0x0000000181EE30D0
}

