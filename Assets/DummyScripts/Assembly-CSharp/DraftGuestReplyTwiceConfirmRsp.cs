/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DraftGuestReplyTwiceConfirmRsp : MessageBase, IMessage<DraftGuestReplyTwiceConfirmRsp> // TypeDefIndex: 22791
{
	// Fields
	private static readonly MessageParser<DraftGuestReplyTwiceConfirmRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B02603
	private int retcode_; // 0x18
	public const int DraftIdFieldNumber = 2; // Metadata: 0x00B02607
	private uint draftId_; // 0x1C
	public const int IsAgreeFieldNumber = 3; // Metadata: 0x00B0260B
	private bool isAgree_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DraftGuestReplyTwiceConfirmRsp> Parser { get => default; } // 0x0000000183ECD450-0x0000000183ECD4E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183ECD140-0x0000000183ECD1D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183ECCE00-0x0000000183ECCE80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183ECC630-0x0000000183ECC690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183ECD960-0x0000000183ECDA50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183ECD750-0x0000000183ECD7B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183ECD1D0-0x0000000183ECD2C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183ECD910-0x0000000183ECD960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183ECCF20-0x0000000183ECD010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183ECCD60-0x0000000183ECCE00 0x0000000183ECC8C0-0x0000000183ECC960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DraftId { get => default; set {} } // 0x0000000183ECC960-0x0000000183ECCA00 0x0000000183ECD660-0x0000000183ECD700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAgree { get => default; set {} } // 0x0000000183ECD3B0-0x0000000183ECD450 0x0000000183ECD4E0-0x0000000183ECD580

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22792
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22793
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5412
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftGuestReplyTwiceConfirmRsp() {} // 0x0000000183ECDDA0-0x0000000183ECDE00
	static DraftGuestReplyTwiceConfirmRsp() {} // 0x0000000183ECDCE0-0x0000000183ECDDA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftGuestReplyTwiceConfirmRsp Clone() => default; // 0x0000000183ECD2C0-0x0000000183ECD3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftGuestReplyTwiceConfirmRsp ShallowCopy() => default; // 0x0000000183ECCE80-0x0000000183ECCF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183ECC7F0-0x0000000183ECC840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183ECD610-0x0000000183ECD660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183ECD700-0x0000000183ECD750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183ECC840-0x0000000183ECC8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183ECCB40-0x0000000183ECCC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DraftGuestReplyTwiceConfirmRsp other) => default; // 0x0000000183ECCA00-0x0000000183ECCB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183ECD010-0x0000000183ECD140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183ECDA50-0x0000000183ECDCE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183ECD7B0-0x0000000183ECD910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183ECCC10-0x0000000183ECCD60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DraftGuestReplyTwiceConfirmRsp other) {} // 0x0000000183ECC690-0x0000000183ECC7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183ECC520-0x0000000183ECC630
}

