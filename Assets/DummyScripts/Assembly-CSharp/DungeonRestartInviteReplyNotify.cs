/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DungeonRestartInviteReplyNotify : MessageBase, IMessage<DungeonRestartInviteReplyNotify> // TypeDefIndex: 22976
{
	// Fields
	private static readonly MessageParser<DungeonRestartInviteReplyNotify> _parser; // 0x00
	public const int PlayerUidFieldNumber = 1; // Metadata: 0x00B02C9F
	private uint playerUid_; // 0x18
	public const int IsAcceptFieldNumber = 2; // Metadata: 0x00B02CA3
	private bool isAccept_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DungeonRestartInviteReplyNotify> Parser { get => default; } // 0x00000001843C7550-0x00000001843C75E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001843C7240-0x00000001843C72D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001843C6F20-0x00000001843C6FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001843C6940-0x00000001843C69A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001843C7980-0x00000001843C7A70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001843C7710-0x00000001843C7770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001843C72D0-0x00000001843C73C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001843C7930-0x00000001843C7980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001843C7040-0x00000001843C7130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayerUid { get => default; set {} } // 0x00000001843C7890-0x00000001843C7930 0x00000001843C6B90-0x00000001843C6C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAccept { get => default; set {} } // 0x00000001843C74B0-0x00000001843C7550 0x00000001843C68A0-0x00000001843C6940

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22977
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22978
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 956
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonRestartInviteReplyNotify() {} // 0x00000001843C7D30-0x00000001843C7D90
	static DungeonRestartInviteReplyNotify() {} // 0x00000001843C7C70-0x00000001843C7D30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonRestartInviteReplyNotify Clone() => default; // 0x00000001843C73C0-0x00000001843C74B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonRestartInviteReplyNotify ShallowCopy() => default; // 0x00000001843C6FA0-0x00000001843C7040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001843C6AD0-0x00000001843C6B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843C7670-0x00000001843C76C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843C76C0-0x00000001843C7710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001843C6B20-0x00000001843C6B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001843C6D50-0x00000001843C6E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DungeonRestartInviteReplyNotify other) => default; // 0x00000001843C6C30-0x00000001843C6D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001843C7130-0x00000001843C7240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001843C7A70-0x00000001843C7C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001843C7770-0x00000001843C7890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001843C6E20-0x00000001843C6F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DungeonRestartInviteReplyNotify other) {} // 0x00000001843C69A0-0x00000001843C6AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001843C67A0-0x00000001843C68A0
}

