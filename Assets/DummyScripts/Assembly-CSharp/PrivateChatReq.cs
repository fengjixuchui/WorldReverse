/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PrivateChatReq : MessageBase, IMessage<PrivateChatReq> // TypeDefIndex: 22615
{
	// Fields
	private static readonly MessageParser<PrivateChatReq> _parser; // 0x00
	public const int TargetUidFieldNumber = 1; // Metadata: 0x00B01FFB
	private uint targetUid_; // 0x18
	public const int TextFieldNumber = 2; // Metadata: 0x00B01FFF
	public const int IconFieldNumber = 3; // Metadata: 0x00B02003
	private object content_; // 0x20
	private ContentOneofCase contentCase_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PrivateChatReq> Parser { get => default; } // 0x000000018513DD60-0x000000018513DDF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018513DA30-0x000000018513DAC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018513D500-0x000000018513D580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018513CBF0-0x000000018513CC50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018513E120-0x000000018513E210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018513DF20-0x000000018513DF80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018513DAC0-0x000000018513DBB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018513E0D0-0x000000018513E120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018513D6A0-0x000000018513D790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetUid { get => default; set {} } // 0x000000018513D8C0-0x000000018513D960 0x000000018513D460-0x000000018513D500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Text { get => default; set {} } // 0x000000018513D960-0x000000018513DA30 0x000000018513DCA0-0x000000018513DD60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Icon { get => default; set {} } // 0x000000018513CF50-0x000000018513D020 0x000000018513CC50-0x000000018513CD00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ContentOneofCase ContentCase { get => default; } // 0x000000018513E210-0x000000018513E270 

	// Nested types
	public enum ContentOneofCase // TypeDefIndex: 22616
	{
		None = 0,
		Text = 2,
		Icon = 3
	}

	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22617
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22618
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4951
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PrivateChatReq() {} // 0x000000018513E5E0-0x000000018513E650
	static PrivateChatReq() {} // 0x000000018513E520-0x000000018513E5E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PrivateChatReq Clone() => default; // 0x000000018513DBB0-0x000000018513DCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PrivateChatReq ShallowCopy() => default; // 0x000000018513D580-0x000000018513D620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018513CF00-0x000000018513CF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018513DE80-0x000000018513DED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018513DED0-0x000000018513DF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018513D020-0x000000018513D090
	public void resetContent() {} // 0x000000018513D620-0x000000018513D6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearContent() {} // 0x000000018513CD00-0x000000018513CD60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018513D090-0x000000018513D160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PrivateChatReq other) => default; // 0x000000018513D160-0x000000018513D2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018513D790-0x000000018513D8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018513E270-0x000000018513E520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018513DF80-0x000000018513E0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018513D2F0-0x000000018513D460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PrivateChatReq other) {} // 0x000000018513CD60-0x000000018513CF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018513CAE0-0x000000018513CBF0
}

