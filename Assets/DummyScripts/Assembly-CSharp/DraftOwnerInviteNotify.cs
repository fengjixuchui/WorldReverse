/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DraftOwnerInviteNotify : MessageBase, IMessage<DraftOwnerInviteNotify> // TypeDefIndex: 22770
{
	// Fields
	private static readonly MessageParser<DraftOwnerInviteNotify> _parser; // 0x00
	public const int DraftIdFieldNumber = 1; // Metadata: 0x00B0254B
	private uint draftId_; // 0x18
	public const int InviteDeadlineTimeFieldNumber = 2; // Metadata: 0x00B0254F
	private uint inviteDeadlineTime_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DraftOwnerInviteNotify> Parser { get => default; } // 0x0000000182578B50-0x0000000182578BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182578840-0x00000001825788D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182578530-0x00000001825785B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182577E80-0x0000000182577EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182578F80-0x0000000182579070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182578DB0-0x0000000182578E10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001825788D0-0x00000001825789C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182578F30-0x0000000182578F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182578650-0x0000000182578740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DraftId { get => default; set {} } // 0x0000000182578170-0x0000000182578210 0x0000000182578CC0-0x0000000182578D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint InviteDeadlineTime { get => default; set {} } // 0x00000001825780D0-0x0000000182578170 0x00000001825789C0-0x0000000182578A60

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22771
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22772
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5405
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftOwnerInviteNotify() {} // 0x0000000182579330-0x0000000182579390
	static DraftOwnerInviteNotify() {} // 0x0000000182579270-0x0000000182579330

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftOwnerInviteNotify Clone() => default; // 0x0000000182578A60-0x0000000182578B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftOwnerInviteNotify ShallowCopy() => default; // 0x00000001825785B0-0x0000000182578650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182578010-0x0000000182578060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182578C70-0x0000000182578CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182578D60-0x0000000182578DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182578060-0x00000001825780D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182578330-0x0000000182578400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DraftOwnerInviteNotify other) => default; // 0x0000000182578210-0x0000000182578330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182578740-0x0000000182578840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182579070-0x0000000182579270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182578E10-0x0000000182578F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182578400-0x0000000182578530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DraftOwnerInviteNotify other) {} // 0x0000000182577EE0-0x0000000182578010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182577D80-0x0000000182577E80
}

