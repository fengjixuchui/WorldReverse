/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChatChannelUpdateNotify : MessageBase, IMessage<ChatChannelUpdateNotify> // TypeDefIndex: 22649
{
	// Fields
	private static readonly MessageParser<ChatChannelUpdateNotify> _parser; // 0x00
	public const int ChannelIdFieldNumber = 1; // Metadata: 0x00B0211B
	private uint channelId_; // 0x18
	public const int IsCreateFieldNumber = 2; // Metadata: 0x00B0211F
	private bool isCreate_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChatChannelUpdateNotify> Parser { get => default; } // 0x00000001829FC170-0x00000001829FC200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001829FBF00-0x00000001829FBF90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001829FBBE0-0x00000001829FBC60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001829FB4C0-0x00000001829FB520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001829FC5A0-0x00000001829FC690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001829FC3D0-0x00000001829FC430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001829FBF90-0x00000001829FC080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001829FC550-0x00000001829FC5A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001829FBD00-0x00000001829FBDF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChannelId { get => default; set {} } // 0x00000001829FB7B0-0x00000001829FB850 0x00000001829FC330-0x00000001829FC3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsCreate { get => default; set {} } // 0x00000001829FBB40-0x00000001829FBBE0 0x00000001829FB650-0x00000001829FB6F0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22650
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22651
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4962
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChatChannelUpdateNotify() {} // 0x00000001829FC950-0x00000001829FC9B0
	static ChatChannelUpdateNotify() {} // 0x00000001829FC890-0x00000001829FC950

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChatChannelUpdateNotify Clone() => default; // 0x00000001829FC080-0x00000001829FC170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChatChannelUpdateNotify ShallowCopy() => default; // 0x00000001829FBC60-0x00000001829FBD00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001829FB6F0-0x00000001829FB740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001829FC290-0x00000001829FC2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001829FC2E0-0x00000001829FC330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001829FB740-0x00000001829FB7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001829FB970-0x00000001829FBA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChatChannelUpdateNotify other) => default; // 0x00000001829FB850-0x00000001829FB970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001829FBDF0-0x00000001829FBF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001829FC690-0x00000001829FC890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001829FC430-0x00000001829FC550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001829FBA40-0x00000001829FBB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChatChannelUpdateNotify other) {} // 0x00000001829FB520-0x00000001829FB650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001829FB3C0-0x00000001829FB4C0
}

