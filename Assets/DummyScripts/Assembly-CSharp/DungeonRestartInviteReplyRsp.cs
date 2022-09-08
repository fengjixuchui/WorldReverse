/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DungeonRestartInviteReplyRsp : MessageBase, IMessage<DungeonRestartInviteReplyRsp> // TypeDefIndex: 22973
{
	// Fields
	private static readonly MessageParser<DungeonRestartInviteReplyRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B02C83
	private int retcode_; // 0x18
	public const int IsTransPointFieldNumber = 2; // Metadata: 0x00B02C87
	private bool isTransPoint_; // 0x1C
	public const int IsAcceptFieldNumber = 3; // Metadata: 0x00B02C8B
	private bool isAccept_; // 0x1D

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DungeonRestartInviteReplyRsp> Parser { get => default; } // 0x00000001811C5120-0x00000001811C51B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001811C4E10-0x00000001811C4EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001811C4AC0-0x00000001811C4B40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001811C43D0-0x00000001811C4430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001811C5590-0x00000001811C5680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001811C5380-0x00000001811C53E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001811C4EA0-0x00000001811C4F90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001811C5540-0x00000001811C5590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001811C4BE0-0x00000001811C4CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001811C4A20-0x00000001811C4AC0 0x00000001811C4660-0x00000001811C4700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsTransPoint { get => default; set {} } // 0x00000001811C4290-0x00000001811C4330 0x00000001811C5240-0x00000001811C52E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAccept { get => default; set {} } // 0x00000001811C5080-0x00000001811C5120 0x00000001811C4330-0x00000001811C43D0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22974
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22975
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 955
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonRestartInviteReplyRsp() {} // 0x00000001811C59D0-0x00000001811C5A30
	static DungeonRestartInviteReplyRsp() {} // 0x00000001811C5910-0x00000001811C59D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonRestartInviteReplyRsp Clone() => default; // 0x00000001811C4F90-0x00000001811C5080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonRestartInviteReplyRsp ShallowCopy() => default; // 0x00000001811C4B40-0x00000001811C4BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001811C4590-0x00000001811C45E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001811C52E0-0x00000001811C5330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001811C5330-0x00000001811C5380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001811C45E0-0x00000001811C4660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001811C4840-0x00000001811C4910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DungeonRestartInviteReplyRsp other) => default; // 0x00000001811C4700-0x00000001811C4840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001811C4CD0-0x00000001811C4E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001811C5680-0x00000001811C5910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001811C53E0-0x00000001811C5540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001811C4910-0x00000001811C4A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DungeonRestartInviteReplyRsp other) {} // 0x00000001811C4430-0x00000001811C4590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001811C4180-0x00000001811C4290
}

