/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChatHistoryNotify : MessageBase, IMessage<ChatHistoryNotify> // TypeDefIndex: 25262
{
	// Fields
	private static readonly MessageParser<ChatHistoryNotify> _parser; // 0x00
	public const int ChannelIdFieldNumber = 1; // Metadata: 0x00B0854B
	private uint channelId_; // 0x18
	public const int ChatInfoFieldNumber = 2; // Metadata: 0x00B0854F
	private static readonly FieldCodec<ChatInfo> _repeated_chatInfo_codec; // 0x08
	private readonly RepeatedMessageField<ChatInfo> chatInfo_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChatHistoryNotify> Parser { get => default; } // 0x00000001825BCBC0-0x00000001825BCC50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001825BC950-0x00000001825BC9E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001825BC640-0x00000001825BC6C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001825BBF70-0x00000001825BBFD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001825BD0F0-0x00000001825BD1E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001825BCEA0-0x00000001825BCF00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001825BC9E0-0x00000001825BCAD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001825BD0A0-0x00000001825BD0F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001825BC760-0x00000001825BC850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChannelId { get => default; set {} } // 0x00000001825BC260-0x00000001825BC300 0x00000001825BCE00-0x00000001825BCEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ChatInfo> ChatInfo { get => default; } // 0x00000001825BCF00-0x00000001825BCF60 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25263
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25264
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3022
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChatHistoryNotify() {} // 0x00000001825BD4D0-0x00000001825BD560
	static ChatHistoryNotify() {} // 0x00000001825BD3C0-0x00000001825BD4D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChatHistoryNotify Clone() => default; // 0x00000001825BCAD0-0x00000001825BCBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChatHistoryNotify ShallowCopy() => default; // 0x00000001825BC6C0-0x00000001825BC760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001825BC130-0x00000001825BC180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001825BCCE0-0x00000001825BCD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001825BCD70-0x00000001825BCE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001825BC180-0x00000001825BC260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001825BC300-0x00000001825BC3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChatHistoryNotify other) => default; // 0x00000001825BC3D0-0x00000001825BC500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001825BC850-0x00000001825BC950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001825BD1E0-0x00000001825BD3C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001825BCF60-0x00000001825BD0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001825BC500-0x00000001825BC640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChatHistoryNotify other) {} // 0x00000001825BBFD0-0x00000001825BC130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001825BBE10-0x00000001825BBF70
}

