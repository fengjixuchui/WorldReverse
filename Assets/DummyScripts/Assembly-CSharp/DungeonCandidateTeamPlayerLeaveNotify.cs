/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DungeonCandidateTeamPlayerLeaveNotify : MessageBase, IMessage<DungeonCandidateTeamPlayerLeaveNotify> // TypeDefIndex: 22891
{
	// Fields
	private static readonly MessageParser<DungeonCandidateTeamPlayerLeaveNotify> _parser; // 0x00
	public const int PlayerUidFieldNumber = 1; // Metadata: 0x00B029EB
	private uint playerUid_; // 0x18
	public const int ReasonFieldNumber = 2; // Metadata: 0x00B029EF
	private DungeonCandidateTeamPlayerLeaveReason reason_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DungeonCandidateTeamPlayerLeaveNotify> Parser { get => default; } // 0x000000018217C490-0x000000018217C520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018217C180-0x000000018217C210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018217BE20-0x000000018217BEA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018217B770-0x000000018217B7D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018217C8C0-0x000000018217C9B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018217C650-0x000000018217C6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018217C210-0x000000018217C300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018217C870-0x000000018217C8C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018217BF40-0x000000018217C030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayerUid { get => default; set {} } // 0x000000018217C7D0-0x000000018217C870 0x000000018217BA60-0x000000018217BB00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonCandidateTeamPlayerLeaveReason Reason { get => default; set {} } // 0x000000018217C3F0-0x000000018217C490 0x000000018217B950-0x000000018217B9F0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22892
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22893
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 928
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonCandidateTeamPlayerLeaveNotify() {} // 0x000000018217CC70-0x000000018217CCE0
	static DungeonCandidateTeamPlayerLeaveNotify() {} // 0x000000018217CBB0-0x000000018217CC70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonCandidateTeamPlayerLeaveNotify Clone() => default; // 0x000000018217C300-0x000000018217C3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonCandidateTeamPlayerLeaveNotify ShallowCopy() => default; // 0x000000018217BEA0-0x000000018217BF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018217B900-0x000000018217B950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018217C5B0-0x000000018217C600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018217C600-0x000000018217C650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018217B9F0-0x000000018217BA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018217BB00-0x000000018217BBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DungeonCandidateTeamPlayerLeaveNotify other) => default; // 0x000000018217BBD0-0x000000018217BCF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018217C030-0x000000018217C180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018217C9B0-0x000000018217CBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018217C6B0-0x000000018217C7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018217BCF0-0x000000018217BE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DungeonCandidateTeamPlayerLeaveNotify other) {} // 0x000000018217B7D0-0x000000018217B900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018217B680-0x000000018217B770
}

