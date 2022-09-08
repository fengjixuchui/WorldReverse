/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PrivateChatNotify : MessageBase, IMessage<PrivateChatNotify> // TypeDefIndex: 22622
{
	// Fields
	private static readonly MessageParser<PrivateChatNotify> _parser; // 0x00
	public const int ChatInfoFieldNumber = 1; // Metadata: 0x00B0203F
	private ChatInfo chatInfo_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PrivateChatNotify> Parser { get => default; } // 0x0000000184499160-0x00000001844991F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184498EF0-0x0000000184498F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184498B90-0x0000000184498C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184498500-0x0000000184498560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184499650-0x0000000184499740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184499380-0x00000001844993E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184498F80-0x0000000184499070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184499600-0x0000000184499650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184498CB0-0x0000000184498DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChatInfo ChatInfo { get => default; set {} } // 0x00000001844993E0-0x0000000184499480 0x0000000184499480-0x0000000184499520

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22623
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22624
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4953
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PrivateChatNotify() {} // 0x0000000184499950-0x00000001844999B0
	static PrivateChatNotify() {} // 0x0000000184499890-0x0000000184499950

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PrivateChatNotify Clone() => default; // 0x0000000184499070-0x0000000184499160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PrivateChatNotify ShallowCopy() => default; // 0x0000000184498C10-0x0000000184498CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001844986C0-0x0000000184498740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184499280-0x0000000184499300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184499300-0x0000000184499380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184498740-0x0000000184498860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184498970-0x0000000184498A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PrivateChatNotify other) => default; // 0x0000000184498860-0x0000000184498970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184498DA0-0x0000000184498EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184499740-0x0000000184499890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184499520-0x0000000184499600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184498A40-0x0000000184498B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PrivateChatNotify other) {} // 0x0000000184498560-0x00000001844986C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001844983F0-0x0000000184498500
}

