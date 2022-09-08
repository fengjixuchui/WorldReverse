/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerMatchInfoNotify : MessageBase, IMessage<PlayerMatchInfoNotify> // TypeDefIndex: 23831
{
	// Fields
	private static readonly MessageParser<PlayerMatchInfoNotify> _parser; // 0x00
	public const int HostUidFieldNumber = 1; // Metadata: 0x00B04EDB
	private uint hostUid_; // 0x18
	public const int MatchTypeFieldNumber = 2; // Metadata: 0x00B04EDF
	private MatchType matchType_; // 0x1C
	public const int MatchBeginTimeFieldNumber = 3; // Metadata: 0x00B04EE3
	private uint matchBeginTime_; // 0x20
	public const int EstimateMatchCostTimeFieldNumber = 4; // Metadata: 0x00B04EE7
	private uint estimateMatchCostTime_; // 0x24
	public const int DungeonIdFieldNumber = 11; // Metadata: 0x00B04EEB
	private uint dungeonId_; // 0x28
	public const int MpPlayIdFieldNumber = 12; // Metadata: 0x00B04EEF
	private uint mpPlayId_; // 0x2C
	public const int MechanicusDifficultLevelFieldNumber = 13; // Metadata: 0x00B04EF3
	private uint mechanicusDifficultLevel_; // 0x30
	public const int MatchIdFieldNumber = 14; // Metadata: 0x00B04EF7
	private uint matchId_; // 0x34

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerMatchInfoNotify> Parser { get => default; } // 0x0000000181A78980-0x0000000181A78A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181A78350-0x0000000181A783E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181A77DB0-0x0000000181A77E30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181A770D0-0x0000000181A77130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181A78FD0-0x0000000181A790C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181A78BE0-0x0000000181A78C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181A78480-0x0000000181A78570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181A78F80-0x0000000181A78FD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181A77F70-0x0000000181A78060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint HostUid { get => default; set {} } // 0x0000000181A771D0-0x0000000181A77270 0x0000000181A78840-0x0000000181A788E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MatchType MatchType { get => default; set {} } // 0x0000000181A788E0-0x0000000181A78980 0x0000000181A78AF0-0x0000000181A78B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MatchBeginTime { get => default; set {} } // 0x0000000181A787A0-0x0000000181A78840 0x0000000181A77780-0x0000000181A77820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EstimateMatchCostTime { get => default; set {} } // 0x0000000181A78660-0x0000000181A78700 0x0000000181A783E0-0x0000000181A78480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonId { get => default; set {} } // 0x0000000181A77ED0-0x0000000181A77F70 0x0000000181A78EE0-0x0000000181A78F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MpPlayId { get => default; set {} } // 0x0000000181A782B0-0x0000000181A78350 0x0000000181A77640-0x0000000181A776E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MechanicusDifficultLevel { get => default; set {} } // 0x0000000181A78700-0x0000000181A787A0 0x0000000181A77270-0x0000000181A77310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MatchId { get => default; set {} } // 0x0000000181A776E0-0x0000000181A77780 0x0000000181A77130-0x0000000181A771D0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23832
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23833
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4153
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerMatchInfoNotify() {} // 0x0000000181A796D0-0x0000000181A79740
	static PlayerMatchInfoNotify() {} // 0x0000000181A79610-0x0000000181A796D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerMatchInfoNotify Clone() => default; // 0x0000000181A78570-0x0000000181A78660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerMatchInfoNotify ShallowCopy() => default; // 0x0000000181A77E30-0x0000000181A77ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181A77530-0x0000000181A77580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A78AA0-0x0000000181A78AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A78B90-0x0000000181A78BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181A77580-0x0000000181A77640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181A77820-0x0000000181A778F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerMatchInfoNotify other) => default; // 0x0000000181A778F0-0x0000000181A77AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181A78060-0x0000000181A782B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181A790C0-0x0000000181A79610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181A78C40-0x0000000181A78EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181A77AC0-0x0000000181A77DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerMatchInfoNotify other) {} // 0x0000000181A77310-0x0000000181A77530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181A76F30-0x0000000181A770D0
}

