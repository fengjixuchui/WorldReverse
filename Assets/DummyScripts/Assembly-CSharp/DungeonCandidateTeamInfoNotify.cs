/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DungeonCandidateTeamInfoNotify : MessageBase, IMessage<DungeonCandidateTeamInfoNotify> // TypeDefIndex: 22882
{
	// Fields
	private static readonly MessageParser<DungeonCandidateTeamInfoNotify> _parser; // 0x00
	public const int DungeonIdFieldNumber = 1; // Metadata: 0x00B0299B
	private uint dungeonId_; // 0x18
	public const int AvatarListFieldNumber = 2; // Metadata: 0x00B0299F
	private static readonly FieldCodec<DungeonCandidateTeamAvatar> _repeated_avatarList_codec; // 0x08
	private readonly RepeatedMessageField<DungeonCandidateTeamAvatar> avatarList_; // 0x20
	public const int ReadyPlayerUidFieldNumber = 3; // Metadata: 0x00B029A3
	private static readonly FieldCodec<uint> _repeated_readyPlayerUid_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> readyPlayerUid_; // 0x28
	public const int MatchTypeFieldNumber = 4; // Metadata: 0x00B029A7
	private uint matchType_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DungeonCandidateTeamInfoNotify> Parser { get => default; } // 0x00000001839C7BE0-0x00000001839C7C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001839C7870-0x00000001839C7900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001839C7470-0x00000001839C74F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001839C6CC0-0x00000001839C6D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001839C8220-0x00000001839C8310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001839C7EC0-0x00000001839C7F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001839C7900-0x00000001839C79F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001839C81D0-0x00000001839C8220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001839C7630-0x00000001839C7720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonId { get => default; set {} } // 0x00000001839C7590-0x00000001839C7630 0x00000001839C8130-0x00000001839C81D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<DungeonCandidateTeamAvatar> AvatarList { get => default; } // 0x00000001839C7AE0-0x00000001839C7B40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ReadyPlayerUid { get => default; } // 0x00000001839C80D0-0x00000001839C8130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MatchType { get => default; set {} } // 0x00000001839C7B40-0x00000001839C7BE0 0x00000001839C7D90-0x00000001839C7E30

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22883
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22884
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 925
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonCandidateTeamInfoNotify() {} // 0x00000001839C8720-0x00000001839C87D0
	static DungeonCandidateTeamInfoNotify() {} // 0x00000001839C85F0-0x00000001839C8720

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonCandidateTeamInfoNotify Clone() => default; // 0x00000001839C79F0-0x00000001839C7AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonCandidateTeamInfoNotify ShallowCopy() => default; // 0x00000001839C74F0-0x00000001839C7590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001839C6ED0-0x00000001839C6F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001839C7D00-0x00000001839C7D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001839C7E30-0x00000001839C7EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001839C6F20-0x00000001839C7070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001839C7070-0x00000001839C7140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DungeonCandidateTeamInfoNotify other) => default; // 0x00000001839C7140-0x00000001839C72B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001839C7720-0x00000001839C7870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001839C8310-0x00000001839C85F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001839C7F20-0x00000001839C80D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001839C72B0-0x00000001839C7470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DungeonCandidateTeamInfoNotify other) {} // 0x00000001839C6D20-0x00000001839C6ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001839C6AC0-0x00000001839C6CC0
}

