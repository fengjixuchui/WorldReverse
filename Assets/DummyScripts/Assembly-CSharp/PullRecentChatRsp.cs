/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PullRecentChatRsp : MessageBase, IMessage<PullRecentChatRsp> // TypeDefIndex: 22640
{
	// Fields
	private static readonly MessageParser<PullRecentChatRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B020D7
	private int retcode_; // 0x18
	public const int ChatInfoFieldNumber = 2; // Metadata: 0x00B020DB
	private static readonly FieldCodec<ChatInfo> _repeated_chatInfo_codec; // 0x08
	private readonly RepeatedMessageField<ChatInfo> chatInfo_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PullRecentChatRsp> Parser { get => default; } // 0x00000001833FFFB0-0x0000000183400040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001833FFD40-0x00000001833FFDD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001833FFA30-0x00000001833FFAB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001833FF2C0-0x00000001833FF320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183400440-0x0000000183400530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001834001F0-0x0000000183400250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001833FFDD0-0x00000001833FFEC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001834003F0-0x0000000183400440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001833FFB50-0x00000001833FFC40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001833FF990-0x00000001833FFA30 0x00000001833FF5B0-0x00000001833FF650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ChatInfo> ChatInfo { get => default; } // 0x0000000183400250-0x00000001834002B0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22641
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22642
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4959
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PullRecentChatRsp() {} // 0x0000000183400820-0x00000001834008B0
	static PullRecentChatRsp() {} // 0x0000000183400710-0x0000000183400820

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PullRecentChatRsp Clone() => default; // 0x00000001833FFEC0-0x00000001833FFFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PullRecentChatRsp ShallowCopy() => default; // 0x00000001833FFAB0-0x00000001833FFB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001833FF480-0x00000001833FF4D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001834000D0-0x0000000183400160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183400160-0x00000001834001F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001833FF4D0-0x00000001833FF5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001833FF780-0x00000001833FF850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PullRecentChatRsp other) => default; // 0x00000001833FF650-0x00000001833FF780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001833FFC40-0x00000001833FFD40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183400530-0x0000000183400710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001834002B0-0x00000001834003F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001833FF850-0x00000001833FF990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PullRecentChatRsp other) {} // 0x00000001833FF320-0x00000001833FF480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001833FF160-0x00000001833FF2C0
}

