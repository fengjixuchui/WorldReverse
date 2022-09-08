/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DraftGuestReplyTwiceConfirmReq : MessageBase, IMessage<DraftGuestReplyTwiceConfirmReq> // TypeDefIndex: 22788
{
	// Fields
	private static readonly MessageParser<DraftGuestReplyTwiceConfirmReq> _parser; // 0x00
	public const int DraftIdFieldNumber = 1; // Metadata: 0x00B025E7
	private uint draftId_; // 0x18
	public const int IsAgreeFieldNumber = 2; // Metadata: 0x00B025EB
	private bool isAgree_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DraftGuestReplyTwiceConfirmReq> Parser { get => default; } // 0x0000000183262A00-0x0000000183262A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001832626F0-0x0000000183262780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001832623D0-0x0000000183262450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183261DF0-0x0000000183261E50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183262ED0-0x0000000183262FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183262D00-0x0000000183262D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183262780-0x0000000183262870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183262E80-0x0000000183262ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001832624F0-0x00000001832625E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DraftId { get => default; set {} } // 0x0000000183262040-0x00000001832620E0 0x0000000183262C10-0x0000000183262CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAgree { get => default; set {} } // 0x0000000183262960-0x0000000183262A00 0x0000000183262A90-0x0000000183262B30

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22789
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22790
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 5411
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftGuestReplyTwiceConfirmReq() {} // 0x0000000183263280-0x00000001832632E0
	static DraftGuestReplyTwiceConfirmReq() {} // 0x00000001832631C0-0x0000000183263280

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftGuestReplyTwiceConfirmReq Clone() => default; // 0x0000000183262870-0x0000000183262960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftGuestReplyTwiceConfirmReq ShallowCopy() => default; // 0x0000000183262450-0x00000001832624F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183261F80-0x0000000183261FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183262BC0-0x0000000183262C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183262CB0-0x0000000183262D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183261FD0-0x0000000183262040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183262200-0x00000001832622D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DraftGuestReplyTwiceConfirmReq other) => default; // 0x00000001832620E0-0x0000000183262200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001832625E0-0x00000001832626F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183262FC0-0x00000001832631C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183262D60-0x0000000183262E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001832622D0-0x00000001832623D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DraftGuestReplyTwiceConfirmReq other) {} // 0x0000000183261E50-0x0000000183261F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183261CF0-0x0000000183261DF0
}

