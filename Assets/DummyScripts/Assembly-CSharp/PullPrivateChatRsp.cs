/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PullPrivateChatRsp : MessageBase, IMessage<PullPrivateChatRsp> // TypeDefIndex: 22634
{
	// Fields
	private static readonly MessageParser<PullPrivateChatRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B020A3
	private int retcode_; // 0x18
	public const int ChatInfoFieldNumber = 2; // Metadata: 0x00B020A7
	private static readonly FieldCodec<ChatInfo> _repeated_chatInfo_codec; // 0x08
	private readonly RepeatedMessageField<ChatInfo> chatInfo_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PullPrivateChatRsp> Parser { get => default; } // 0x0000000182D69230-0x0000000182D692C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182D68FC0-0x0000000182D69050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182D68CB0-0x0000000182D68D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182D68540-0x0000000182D685A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182D696C0-0x0000000182D697B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182D69470-0x0000000182D694D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182D69050-0x0000000182D69140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182D69670-0x0000000182D696C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182D68DD0-0x0000000182D68EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182D68C10-0x0000000182D68CB0 0x0000000182D68830-0x0000000182D688D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ChatInfo> ChatInfo { get => default; } // 0x0000000182D694D0-0x0000000182D69530 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22635
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22636
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4957
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PullPrivateChatRsp() {} // 0x0000000182D69AA0-0x0000000182D69B30
	static PullPrivateChatRsp() {} // 0x0000000182D69990-0x0000000182D69AA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PullPrivateChatRsp Clone() => default; // 0x0000000182D69140-0x0000000182D69230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PullPrivateChatRsp ShallowCopy() => default; // 0x0000000182D68D30-0x0000000182D68DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182D68700-0x0000000182D68750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D69350-0x0000000182D693E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D693E0-0x0000000182D69470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182D68750-0x0000000182D68830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182D68A00-0x0000000182D68AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PullPrivateChatRsp other) => default; // 0x0000000182D688D0-0x0000000182D68A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182D68EC0-0x0000000182D68FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182D697B0-0x0000000182D69990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182D69530-0x0000000182D69670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182D68AD0-0x0000000182D68C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PullPrivateChatRsp other) {} // 0x0000000182D685A0-0x0000000182D68700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182D683E0-0x0000000182D68540
}

