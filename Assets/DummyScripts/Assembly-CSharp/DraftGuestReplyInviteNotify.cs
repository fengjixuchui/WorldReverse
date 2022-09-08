/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DraftGuestReplyInviteNotify : MessageBase, IMessage<DraftGuestReplyInviteNotify> // TypeDefIndex: 22779
{
	// Fields
	private static readonly MessageParser<DraftGuestReplyInviteNotify> _parser; // 0x00
	public const int DraftIdFieldNumber = 1; // Metadata: 0x00B0259B
	private uint draftId_; // 0x18
	public const int GuestUidFieldNumber = 2; // Metadata: 0x00B0259F
	private uint guestUid_; // 0x1C
	public const int IsAgreeFieldNumber = 3; // Metadata: 0x00B025A3
	private bool isAgree_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DraftGuestReplyInviteNotify> Parser { get => default; } // 0x00000001826C4C70-0x00000001826C4D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001826C4960-0x00000001826C49F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001826C4580-0x00000001826C4600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001826C3EF0-0x00000001826C3F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001826C5220-0x00000001826C5310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001826C4F70-0x00000001826C4FD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001826C49F0-0x00000001826C4AE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001826C51D0-0x00000001826C5220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001826C46A0-0x00000001826C4790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DraftId { get => default; set {} } // 0x00000001826C4180-0x00000001826C4220 0x00000001826C4E80-0x00000001826C4F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GuestUid { get => default; set {} } // 0x00000001826C48C0-0x00000001826C4960 0x00000001826C5130-0x00000001826C51D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAgree { get => default; set {} } // 0x00000001826C4BD0-0x00000001826C4C70 0x00000001826C4D00-0x00000001826C4DA0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22780
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22781
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5408
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftGuestReplyInviteNotify() {} // 0x00000001826C5660-0x00000001826C56C0
	static DraftGuestReplyInviteNotify() {} // 0x00000001826C55A0-0x00000001826C5660

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftGuestReplyInviteNotify Clone() => default; // 0x00000001826C4AE0-0x00000001826C4BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftGuestReplyInviteNotify ShallowCopy() => default; // 0x00000001826C4600-0x00000001826C46A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001826C40B0-0x00000001826C4100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001826C4E30-0x00000001826C4E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001826C4F20-0x00000001826C4F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001826C4100-0x00000001826C4180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001826C4220-0x00000001826C42F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DraftGuestReplyInviteNotify other) => default; // 0x00000001826C42F0-0x00000001826C4430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001826C4790-0x00000001826C48C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001826C5310-0x00000001826C55A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001826C4FD0-0x00000001826C5130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001826C4430-0x00000001826C4580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DraftGuestReplyInviteNotify other) {} // 0x00000001826C3F50-0x00000001826C40B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001826C3DE0-0x00000001826C3EF0
}

