/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PullPrivateChatReq : MessageBase, IMessage<PullPrivateChatReq> // TypeDefIndex: 22631
{
	// Fields
	private static readonly MessageParser<PullPrivateChatReq> _parser; // 0x00
	public const int TargetUidFieldNumber = 1; // Metadata: 0x00B02083
	private uint targetUid_; // 0x18
	public const int FromSequenceFieldNumber = 2; // Metadata: 0x00B02087
	private uint fromSequence_; // 0x1C
	public const int PullNumFieldNumber = 3; // Metadata: 0x00B0208B
	private uint pullNum_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PullPrivateChatReq> Parser { get => default; } // 0x0000000182EDEF80-0x0000000182EDF010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182EDEC70-0x0000000182EDED00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182EDE890-0x0000000182EDE910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182EDE130-0x0000000182EDE190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182EDF490-0x0000000182EDF580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182EDF280-0x0000000182EDF2E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182EDED00-0x0000000182EDEDF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182EDF440-0x0000000182EDF490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182EDE9B0-0x0000000182EDEAA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetUid { get => default; set {} } // 0x0000000182EDEBD0-0x0000000182EDEC70 0x0000000182EDE7F0-0x0000000182EDE890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FromSequence { get => default; set {} } // 0x0000000182EDE2F0-0x0000000182EDE390 0x0000000182EDF190-0x0000000182EDF230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PullNum { get => default; set {} } // 0x0000000182EDEEE0-0x0000000182EDEF80 0x0000000182EDF0A0-0x0000000182EDF140

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22632
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22633
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4956
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PullPrivateChatReq() {} // 0x0000000182EDF8D0-0x0000000182EDF930
	static PullPrivateChatReq() {} // 0x0000000182EDF810-0x0000000182EDF8D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PullPrivateChatReq Clone() => default; // 0x0000000182EDEDF0-0x0000000182EDEEE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PullPrivateChatReq ShallowCopy() => default; // 0x0000000182EDE910-0x0000000182EDE9B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182EDE390-0x0000000182EDE3E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182EDF140-0x0000000182EDF190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182EDF230-0x0000000182EDF280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182EDE3E0-0x0000000182EDE460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182EDE5A0-0x0000000182EDE670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PullPrivateChatReq other) => default; // 0x0000000182EDE460-0x0000000182EDE5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182EDEAA0-0x0000000182EDEBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182EDF580-0x0000000182EDF810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182EDF2E0-0x0000000182EDF440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182EDE670-0x0000000182EDE7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PullPrivateChatReq other) {} // 0x0000000182EDE190-0x0000000182EDE2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182EDE020-0x0000000182EDE130
}

