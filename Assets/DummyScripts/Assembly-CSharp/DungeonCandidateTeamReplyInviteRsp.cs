/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DungeonCandidateTeamReplyInviteRsp : MessageBase, IMessage<DungeonCandidateTeamReplyInviteRsp> // TypeDefIndex: 22924
{
	// Fields
	private static readonly MessageParser<DungeonCandidateTeamReplyInviteRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B02AE3
	private int retcode_; // 0x18
	public const int IsTransPointFieldNumber = 2; // Metadata: 0x00B02AE7
	private bool isTransPoint_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DungeonCandidateTeamReplyInviteRsp> Parser { get => default; } // 0x000000018352BFB0-0x000000018352C040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018352BD40-0x000000018352BDD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018352BA20-0x000000018352BAA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018352B3A0-0x000000018352B400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018352C3E0-0x000000018352C4D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018352C210-0x000000018352C270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018352BDD0-0x000000018352BEC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018352C390-0x000000018352C3E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018352BB40-0x000000018352BC30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018352B980-0x000000018352BA20 0x000000018352B5F0-0x000000018352B690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsTransPoint { get => default; set {} } // 0x000000018352B300-0x000000018352B3A0 0x000000018352C0D0-0x000000018352C170

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22925
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22926
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 939
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonCandidateTeamReplyInviteRsp() {} // 0x000000018352C790-0x000000018352C7F0
	static DungeonCandidateTeamReplyInviteRsp() {} // 0x000000018352C6D0-0x000000018352C790

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonCandidateTeamReplyInviteRsp Clone() => default; // 0x000000018352BEC0-0x000000018352BFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonCandidateTeamReplyInviteRsp ShallowCopy() => default; // 0x000000018352BAA0-0x000000018352BB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018352B530-0x000000018352B580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018352C170-0x000000018352C1C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018352C1C0-0x000000018352C210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018352B580-0x000000018352B5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018352B7B0-0x000000018352B880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DungeonCandidateTeamReplyInviteRsp other) => default; // 0x000000018352B690-0x000000018352B7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018352BC30-0x000000018352BD40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018352C4D0-0x000000018352C6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018352C270-0x000000018352C390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018352B880-0x000000018352B980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DungeonCandidateTeamReplyInviteRsp other) {} // 0x000000018352B400-0x000000018352B530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018352B200-0x000000018352B300
}

