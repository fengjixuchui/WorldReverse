/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DungeonRestartInviteNotify : MessageBase, IMessage<DungeonRestartInviteNotify> // TypeDefIndex: 22967
{
	// Fields
	private static readonly MessageParser<DungeonRestartInviteNotify> _parser; // 0x00
	public const int PlayerUidFieldNumber = 1; // Metadata: 0x00B02C47
	private uint playerUid_; // 0x18
	public const int PointIdFieldNumber = 2; // Metadata: 0x00B02C4B
	private uint pointId_; // 0x1C
	public const int DungeonIdFieldNumber = 3; // Metadata: 0x00B02C4F
	private uint dungeonId_; // 0x20
	public const int CdFieldNumber = 4; // Metadata: 0x00B02C53
	private uint cd_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DungeonRestartInviteNotify> Parser { get => default; } // 0x0000000181D0CAD0-0x0000000181D0CB60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181D0C7C0-0x0000000181D0C850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181D0C3B0-0x0000000181D0C430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181D0BA80-0x0000000181D0BAE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181D0D020-0x0000000181D0D110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181D0CC90-0x0000000181D0CCF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181D0C8F0-0x0000000181D0C9E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181D0CFD0-0x0000000181D0D020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181D0C570-0x0000000181D0C660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayerUid { get => default; set {} } // 0x0000000181D0CF30-0x0000000181D0CFD0 0x0000000181D0BDE0-0x0000000181D0BE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PointId { get => default; set {} } // 0x0000000181D0C850-0x0000000181D0C8F0 0x0000000181D0BF20-0x0000000181D0BFC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonId { get => default; set {} } // 0x0000000181D0C4D0-0x0000000181D0C570 0x0000000181D0CE90-0x0000000181D0CF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Cd { get => default; set {} } // 0x0000000181D0BE80-0x0000000181D0BF20 0x0000000181D0BC60-0x0000000181D0BD00

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22968
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22969
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 953
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonRestartInviteNotify() {} // 0x0000000181D0D4F0-0x0000000181D0D550
	static DungeonRestartInviteNotify() {} // 0x0000000181D0D430-0x0000000181D0D4F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonRestartInviteNotify Clone() => default; // 0x0000000181D0C9E0-0x0000000181D0CAD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonRestartInviteNotify ShallowCopy() => default; // 0x0000000181D0C430-0x0000000181D0C4D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181D0BD00-0x0000000181D0BD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D0CBF0-0x0000000181D0CC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D0CC40-0x0000000181D0CC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181D0BD50-0x0000000181D0BDE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181D0C110-0x0000000181D0C1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DungeonRestartInviteNotify other) => default; // 0x0000000181D0BFC0-0x0000000181D0C110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181D0C660-0x0000000181D0C7C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181D0D110-0x0000000181D0D430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181D0CCF0-0x0000000181D0CE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181D0C1E0-0x0000000181D0C3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DungeonRestartInviteNotify other) {} // 0x0000000181D0BAE0-0x0000000181D0BC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181D0B950-0x0000000181D0BA80
}

