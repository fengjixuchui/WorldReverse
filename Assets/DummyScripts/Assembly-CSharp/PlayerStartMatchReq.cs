/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerStartMatchReq : MessageBase, IMessage<PlayerStartMatchReq> // TypeDefIndex: 23825
{
	// Fields
	private static readonly MessageParser<PlayerStartMatchReq> _parser; // 0x00
	public const int MatchTypeFieldNumber = 1; // Metadata: 0x00B04E83
	private MatchType matchType_; // 0x18
	public const int DungeonIdFieldNumber = 11; // Metadata: 0x00B04E87
	private uint dungeonId_; // 0x1C
	public const int MpPlayIdFieldNumber = 12; // Metadata: 0x00B04E8B
	private uint mpPlayId_; // 0x20
	public const int MechanicusDifficultLevelFieldNumber = 13; // Metadata: 0x00B04E8F
	private uint mechanicusDifficultLevel_; // 0x24
	public const int MatchIdFieldNumber = 14; // Metadata: 0x00B04E93
	private uint matchId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerStartMatchReq> Parser { get => default; } // 0x000000018379DF30-0x000000018379DFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018379DB80-0x000000018379DC10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018379D660-0x000000018379D6E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018379CC90-0x000000018379CCF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018379E4C0-0x000000018379E5B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018379E190-0x000000018379E1F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018379DC10-0x000000018379DD00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018379E470-0x000000018379E4C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018379D820-0x000000018379D910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MatchType MatchType { get => default; set {} } // 0x000000018379DE90-0x000000018379DF30 0x000000018379E0A0-0x000000018379E140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonId { get => default; set {} } // 0x000000018379D780-0x000000018379D820 0x000000018379E3D0-0x000000018379E470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MpPlayId { get => default; set {} } // 0x000000018379DAE0-0x000000018379DB80 0x000000018379D0D0-0x000000018379D170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MechanicusDifficultLevel { get => default; set {} } // 0x000000018379DDF0-0x000000018379DE90 0x000000018379CD90-0x000000018379CE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MatchId { get => default; set {} } // 0x000000018379D170-0x000000018379D210 0x000000018379CCF0-0x000000018379CD90

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23826
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23827
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4151
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerStartMatchReq() {} // 0x000000018379EA10-0x000000018379EA80
	static PlayerStartMatchReq() {} // 0x000000018379E950-0x000000018379EA10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerStartMatchReq Clone() => default; // 0x000000018379DD00-0x000000018379DDF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerStartMatchReq ShallowCopy() => default; // 0x000000018379D6E0-0x000000018379D780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018379CFE0-0x000000018379D030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018379E050-0x000000018379E0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018379E140-0x000000018379E190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018379D030-0x000000018379D0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018379D210-0x000000018379D2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerStartMatchReq other) => default; // 0x000000018379D2E0-0x000000018379D450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018379D910-0x000000018379DAE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018379E5B0-0x000000018379E950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018379E1F0-0x000000018379E3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018379D450-0x000000018379D660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerStartMatchReq other) {} // 0x000000018379CE30-0x000000018379CFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018379CB40-0x000000018379CC90
}

