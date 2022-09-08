/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DealAddFriendReq : MessageBase, IMessage<DealAddFriendReq> // TypeDefIndex: 25546
{
	// Fields
	private static readonly MessageParser<DealAddFriendReq> _parser; // 0x00
	public const int TargetUidFieldNumber = 1; // Metadata: 0x00B090BF
	private uint targetUid_; // 0x18
	public const int DealAddFriendResultFieldNumber = 2; // Metadata: 0x00B090C3
	private DealAddFriendResultType dealAddFriendResult_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DealAddFriendReq> Parser { get => default; } // 0x0000000183651F00-0x0000000183651F90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183651B50-0x0000000183651BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183651750-0x00000001836517D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183651140-0x00000001836511A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183652290-0x0000000183652380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001836520C0-0x0000000183652120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183651BE0-0x0000000183651CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183652240-0x0000000183652290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183651870-0x0000000183651960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetUid { get => default; set {} } // 0x0000000183651AB0-0x0000000183651B50 0x00000001836516B0-0x0000000183651750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DealAddFriendResultType DealAddFriendResult { get => default; set {} } // 0x0000000183651DC0-0x0000000183651E60 0x0000000183651E60-0x0000000183651F00

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25547
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25548
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4007
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DealAddFriendReq() {} // 0x0000000183652640-0x00000001836526B0
	static DealAddFriendReq() {} // 0x0000000183652580-0x0000000183652640

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DealAddFriendReq Clone() => default; // 0x0000000183651CD0-0x0000000183651DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DealAddFriendReq ShallowCopy() => default; // 0x00000001836517D0-0x0000000183651870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001836512D0-0x0000000183651320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183652020-0x0000000183652070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183652070-0x00000001836520C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183651320-0x0000000183651390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001836514B0-0x0000000183651580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DealAddFriendReq other) => default; // 0x0000000183651390-0x00000001836514B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183651960-0x0000000183651AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183652380-0x0000000183652580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183652120-0x0000000183652240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183651580-0x00000001836516B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DealAddFriendReq other) {} // 0x00000001836511A0-0x00000001836512D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183651050-0x0000000183651140
}

