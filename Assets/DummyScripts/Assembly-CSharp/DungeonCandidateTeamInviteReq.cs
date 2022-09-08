/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DungeonCandidateTeamInviteReq : MessageBase, IMessage<DungeonCandidateTeamInviteReq> // TypeDefIndex: 22903
{
	// Fields
	private static readonly MessageParser<DungeonCandidateTeamInviteReq> _parser; // 0x00
	public const int PlayerUidsFieldNumber = 1; // Metadata: 0x00B02A4B
	private static readonly FieldCodec<uint> _repeated_playerUids_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> playerUids_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DungeonCandidateTeamInviteReq> Parser { get => default; } // 0x0000000182D0DBE0-0x0000000182D0DC70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182D0D970-0x0000000182D0DA00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182D0D6A0-0x0000000182D0D720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182D0D160-0x0000000182D0D1C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182D0DF50-0x0000000182D0E040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182D0DDA0-0x0000000182D0DE00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182D0DA00-0x0000000182D0DAF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182D0DF00-0x0000000182D0DF50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182D0D7C0-0x0000000182D0D8B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> PlayerUids { get => default; } // 0x0000000182D0E040-0x0000000182D0E0A0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22904
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22905
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 932
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonCandidateTeamInviteReq() {} // 0x0000000182D0E2D0-0x0000000182D0E360
	static DungeonCandidateTeamInviteReq() {} // 0x0000000182D0E1F0-0x0000000182D0E2D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonCandidateTeamInviteReq Clone() => default; // 0x0000000182D0DAF0-0x0000000182D0DBE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonCandidateTeamInviteReq ShallowCopy() => default; // 0x0000000182D0D720-0x0000000182D0D7C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182D0D2D0-0x0000000182D0D320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D0DD00-0x0000000182D0DD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D0DD50-0x0000000182D0DDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182D0D320-0x0000000182D0D3E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182D0D3E0-0x0000000182D0D4B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DungeonCandidateTeamInviteReq other) => default; // 0x0000000182D0D4B0-0x0000000182D0D5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182D0D8B0-0x0000000182D0D970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182D0E0A0-0x0000000182D0E1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182D0DE00-0x0000000182D0DF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182D0D5B0-0x0000000182D0D6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DungeonCandidateTeamInviteReq other) {} // 0x0000000182D0D1C0-0x0000000182D0D2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182D0D020-0x0000000182D0D160
}

