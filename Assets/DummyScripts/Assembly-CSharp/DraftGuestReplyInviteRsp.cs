/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DraftGuestReplyInviteRsp : MessageBase, IMessage<DraftGuestReplyInviteRsp> // TypeDefIndex: 22776
{
	// Fields
	private static readonly MessageParser<DraftGuestReplyInviteRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0257F
	private int retcode_; // 0x18
	public const int DraftIdFieldNumber = 2; // Metadata: 0x00B02583
	private uint draftId_; // 0x1C
	public const int IsAgreeFieldNumber = 3; // Metadata: 0x00B02587
	private bool isAgree_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DraftGuestReplyInviteRsp> Parser { get => default; } // 0x00000001837C3DD0-0x00000001837C3E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001837C3AC0-0x00000001837C3B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001837C3780-0x00000001837C3800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001837C2FB0-0x00000001837C3010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001837C42E0-0x00000001837C43D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001837C40D0-0x00000001837C4130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001837C3B50-0x00000001837C3C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001837C4290-0x00000001837C42E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001837C38A0-0x00000001837C3990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001837C36E0-0x00000001837C3780 0x00000001837C3240-0x00000001837C32E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DraftId { get => default; set {} } // 0x00000001837C32E0-0x00000001837C3380 0x00000001837C3FE0-0x00000001837C4080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAgree { get => default; set {} } // 0x00000001837C3D30-0x00000001837C3DD0 0x00000001837C3E60-0x00000001837C3F00

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22777
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22778
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5407
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftGuestReplyInviteRsp() {} // 0x00000001837C4720-0x00000001837C4780
	static DraftGuestReplyInviteRsp() {} // 0x00000001837C4660-0x00000001837C4720

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftGuestReplyInviteRsp Clone() => default; // 0x00000001837C3C40-0x00000001837C3D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftGuestReplyInviteRsp ShallowCopy() => default; // 0x00000001837C3800-0x00000001837C38A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001837C3170-0x00000001837C31C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001837C3F90-0x00000001837C3FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001837C4080-0x00000001837C40D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001837C31C0-0x00000001837C3240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001837C3380-0x00000001837C3450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DraftGuestReplyInviteRsp other) => default; // 0x00000001837C3450-0x00000001837C3590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001837C3990-0x00000001837C3AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001837C43D0-0x00000001837C4660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001837C4130-0x00000001837C4290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001837C3590-0x00000001837C36E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DraftGuestReplyInviteRsp other) {} // 0x00000001837C3010-0x00000001837C3170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001837C2EA0-0x00000001837C2FB0
}

