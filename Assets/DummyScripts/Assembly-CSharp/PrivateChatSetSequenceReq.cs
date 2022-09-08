/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PrivateChatSetSequenceReq : MessageBase, IMessage<PrivateChatSetSequenceReq> // TypeDefIndex: 22625
{
	// Fields
	private static readonly MessageParser<PrivateChatSetSequenceReq> _parser; // 0x00
	public const int TargetUidFieldNumber = 1; // Metadata: 0x00B02053
	private uint targetUid_; // 0x18
	public const int SequenceFieldNumber = 2; // Metadata: 0x00B02057
	private uint sequence_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PrivateChatSetSequenceReq> Parser { get => default; } // 0x0000000182A73170-0x0000000182A73200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182A72F00-0x0000000182A72F90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182A72AB0-0x0000000182A72B30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182A72400-0x0000000182A72460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182A73500-0x0000000182A735F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182A73330-0x0000000182A73390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182A72F90-0x0000000182A73080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182A734B0-0x0000000182A73500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182A72BD0-0x0000000182A72CC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetUid { get => default; set {} } // 0x0000000182A72DC0-0x0000000182A72E60 0x0000000182A72A10-0x0000000182A72AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Sequence { get => default; set {} } // 0x0000000182A725E0-0x0000000182A72680 0x0000000182A72E60-0x0000000182A72F00

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22626
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22627
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4954
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PrivateChatSetSequenceReq() {} // 0x0000000182A738B0-0x0000000182A73910
	static PrivateChatSetSequenceReq() {} // 0x0000000182A737F0-0x0000000182A738B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PrivateChatSetSequenceReq Clone() => default; // 0x0000000182A73080-0x0000000182A73170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PrivateChatSetSequenceReq ShallowCopy() => default; // 0x0000000182A72B30-0x0000000182A72BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182A72590-0x0000000182A725E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182A73290-0x0000000182A732E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182A732E0-0x0000000182A73330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182A72680-0x0000000182A726F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182A726F0-0x0000000182A727C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PrivateChatSetSequenceReq other) => default; // 0x0000000182A727C0-0x0000000182A728E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182A72CC0-0x0000000182A72DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182A735F0-0x0000000182A737F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182A73390-0x0000000182A734B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182A728E0-0x0000000182A72A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PrivateChatSetSequenceReq other) {} // 0x0000000182A72460-0x0000000182A72590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182A72300-0x0000000182A72400
}

