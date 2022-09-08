/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DungeonCandidateTeamInviteNotify : MessageBase, IMessage<DungeonCandidateTeamInviteNotify> // TypeDefIndex: 22885
{
	// Fields
	private static readonly MessageParser<DungeonCandidateTeamInviteNotify> _parser; // 0x00
	public const int PlayerUidFieldNumber = 1; // Metadata: 0x00B029BB
	private uint playerUid_; // 0x18
	public const int DungeonIdFieldNumber = 2; // Metadata: 0x00B029BF
	private uint dungeonId_; // 0x1C
	public const int VaildDeadlineTimeSecFieldNumber = 3; // Metadata: 0x00B029C3
	private uint vaildDeadlineTimeSec_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DungeonCandidateTeamInviteNotify> Parser { get => default; } // 0x000000018467D3D0-0x000000018467D460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018467D160-0x000000018467D1F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018467CD80-0x000000018467CE00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018467C6C0-0x000000018467C720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018467D980-0x000000018467DA70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018467D630-0x000000018467D690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018467D1F0-0x000000018467D2E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018467D930-0x000000018467D980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018467CF40-0x000000018467D030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayerUid { get => default; set {} } // 0x000000018467D890-0x000000018467D930 0x000000018467C950-0x000000018467C9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonId { get => default; set {} } // 0x000000018467CEA0-0x000000018467CF40 0x000000018467D7F0-0x000000018467D890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint VaildDeadlineTimeSec { get => default; set {} } // 0x000000018467C620-0x000000018467C6C0 0x000000018467D590-0x000000018467D630

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22886
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22887
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 926
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonCandidateTeamInviteNotify() {} // 0x000000018467DDC0-0x000000018467DE20
	static DungeonCandidateTeamInviteNotify() {} // 0x000000018467DD00-0x000000018467DDC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonCandidateTeamInviteNotify Clone() => default; // 0x000000018467D2E0-0x000000018467D3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonCandidateTeamInviteNotify ShallowCopy() => default; // 0x000000018467CE00-0x000000018467CEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018467C880-0x000000018467C8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018467D4F0-0x000000018467D540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018467D540-0x000000018467D590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018467C8D0-0x000000018467C950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018467CB30-0x000000018467CC00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DungeonCandidateTeamInviteNotify other) => default; // 0x000000018467C9F0-0x000000018467CB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018467D030-0x000000018467D160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018467DA70-0x000000018467DD00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018467D690-0x000000018467D7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018467CC00-0x000000018467CD80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DungeonCandidateTeamInviteNotify other) {} // 0x000000018467C720-0x000000018467C880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018467C510-0x000000018467C620
}

