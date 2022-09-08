/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MpPlayGuestReplyInviteReq : MessageBase, IMessage<MpPlayGuestReplyInviteReq> // TypeDefIndex: 24081
{
	// Fields
	private static readonly MessageParser<MpPlayGuestReplyInviteReq> _parser; // 0x00
	public const int MpPlayIdFieldNumber = 1; // Metadata: 0x00B0583B
	private uint mpPlayId_; // 0x18
	public const int IsAgreeFieldNumber = 2; // Metadata: 0x00B0583F
	private bool isAgree_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MpPlayGuestReplyInviteReq> Parser { get => default; } // 0x0000000182DE5750-0x0000000182DE57E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182DE5440-0x0000000182DE54D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182DE5080-0x0000000182DE5100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182DE4AA0-0x0000000182DE4B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182DE5B80-0x0000000182DE5C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182DE59B0-0x0000000182DE5A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182DE54D0-0x0000000182DE55C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182DE5B30-0x0000000182DE5B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182DE51A0-0x0000000182DE5290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MpPlayId { get => default; set {} } // 0x0000000182DE53A0-0x0000000182DE5440 0x0000000182DE4CF0-0x0000000182DE4D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAgree { get => default; set {} } // 0x0000000182DE56B0-0x0000000182DE5750 0x0000000182DE57E0-0x0000000182DE5880

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24082
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24083
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1820
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayGuestReplyInviteReq() {} // 0x0000000182DE5F30-0x0000000182DE5F90
	static MpPlayGuestReplyInviteReq() {} // 0x0000000182DE5E70-0x0000000182DE5F30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayGuestReplyInviteReq Clone() => default; // 0x0000000182DE55C0-0x0000000182DE56B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayGuestReplyInviteReq ShallowCopy() => default; // 0x0000000182DE5100-0x0000000182DE51A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182DE4C30-0x0000000182DE4C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182DE5910-0x0000000182DE5960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182DE5960-0x0000000182DE59B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182DE4C80-0x0000000182DE4CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182DE4D90-0x0000000182DE4E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MpPlayGuestReplyInviteReq other) => default; // 0x0000000182DE4E60-0x0000000182DE4F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182DE5290-0x0000000182DE53A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182DE5C70-0x0000000182DE5E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182DE5A10-0x0000000182DE5B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182DE4F80-0x0000000182DE5080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MpPlayGuestReplyInviteReq other) {} // 0x0000000182DE4B00-0x0000000182DE4C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182DE49A0-0x0000000182DE4AA0
}

