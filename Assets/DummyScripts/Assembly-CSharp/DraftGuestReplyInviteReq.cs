/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DraftGuestReplyInviteReq : MessageBase, IMessage<DraftGuestReplyInviteReq> // TypeDefIndex: 22773
{
	// Fields
	private static readonly MessageParser<DraftGuestReplyInviteReq> _parser; // 0x00
	public const int DraftIdFieldNumber = 1; // Metadata: 0x00B02563
	private uint draftId_; // 0x18
	public const int IsAgreeFieldNumber = 2; // Metadata: 0x00B02567
	private bool isAgree_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DraftGuestReplyInviteReq> Parser { get => default; } // 0x000000018176EF20-0x000000018176EFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018176EC10-0x000000018176ECA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018176E8F0-0x000000018176E970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018176E310-0x000000018176E370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018176F3F0-0x000000018176F4E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018176F220-0x000000018176F280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018176ECA0-0x000000018176ED90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018176F3A0-0x000000018176F3F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018176EA10-0x000000018176EB00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DraftId { get => default; set {} } // 0x000000018176E560-0x000000018176E600 0x000000018176F130-0x000000018176F1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAgree { get => default; set {} } // 0x000000018176EE80-0x000000018176EF20 0x000000018176EFB0-0x000000018176F050

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22774
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22775
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 5406
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftGuestReplyInviteReq() {} // 0x000000018176F7A0-0x000000018176F800
	static DraftGuestReplyInviteReq() {} // 0x000000018176F6E0-0x000000018176F7A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftGuestReplyInviteReq Clone() => default; // 0x000000018176ED90-0x000000018176EE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftGuestReplyInviteReq ShallowCopy() => default; // 0x000000018176E970-0x000000018176EA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018176E4A0-0x000000018176E4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018176F0E0-0x000000018176F130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018176F1D0-0x000000018176F220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018176E4F0-0x000000018176E560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018176E720-0x000000018176E7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DraftGuestReplyInviteReq other) => default; // 0x000000018176E600-0x000000018176E720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018176EB00-0x000000018176EC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018176F4E0-0x000000018176F6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018176F280-0x000000018176F3A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018176E7F0-0x000000018176E8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DraftGuestReplyInviteReq other) {} // 0x000000018176E370-0x000000018176E4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018176E210-0x000000018176E310
}

