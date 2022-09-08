/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DeleteFriendNotify : MessageBase, IMessage<DeleteFriendNotify> // TypeDefIndex: 25585
{
	// Fields
	private static readonly MessageParser<DeleteFriendNotify> _parser; // 0x00
	public const int TargetUidFieldNumber = 1; // Metadata: 0x00B09203
	private uint targetUid_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DeleteFriendNotify> Parser { get => default; } // 0x0000000182AA1D10-0x0000000182AA1DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182AA1AA0-0x0000000182AA1B30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182AA1710-0x0000000182AA1790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182AA1180-0x0000000182AA11E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182AA2060-0x0000000182AA2150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182AA1ED0-0x0000000182AA1F30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182AA1B30-0x0000000182AA1C20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182AA2010-0x0000000182AA2060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182AA1830-0x0000000182AA1920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetUid { get => default; set {} } // 0x0000000182AA1A00-0x0000000182AA1AA0 0x0000000182AA1670-0x0000000182AA1710

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25586
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25587
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4020
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DeleteFriendNotify() {} // 0x0000000182AA2380-0x0000000182AA23E0
	static DeleteFriendNotify() {} // 0x0000000182AA22C0-0x0000000182AA2380

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DeleteFriendNotify Clone() => default; // 0x0000000182AA1C20-0x0000000182AA1D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DeleteFriendNotify ShallowCopy() => default; // 0x0000000182AA1790-0x0000000182AA1830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182AA12F0-0x0000000182AA1340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182AA1E30-0x0000000182AA1E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182AA1E80-0x0000000182AA1ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182AA1340-0x0000000182AA13B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182AA13B0-0x0000000182AA1480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DeleteFriendNotify other) => default; // 0x0000000182AA1480-0x0000000182AA1580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182AA1920-0x0000000182AA1A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182AA2150-0x0000000182AA22C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182AA1F30-0x0000000182AA2010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182AA1580-0x0000000182AA1670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DeleteFriendNotify other) {} // 0x0000000182AA11E0-0x0000000182AA12F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182AA10A0-0x0000000182AA1180
}

