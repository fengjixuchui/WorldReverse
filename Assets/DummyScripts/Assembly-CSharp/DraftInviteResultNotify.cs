/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DraftInviteResultNotify : MessageBase, IMessage<DraftInviteResultNotify> // TypeDefIndex: 22782
{
	// Fields
	private static readonly MessageParser<DraftInviteResultNotify> _parser; // 0x00
	public const int DraftIdFieldNumber = 1; // Metadata: 0x00B025B7
	private uint draftId_; // 0x18
	public const int IsAllArgeeFieldNumber = 2; // Metadata: 0x00B025BB
	private bool isAllArgee_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DraftInviteResultNotify> Parser { get => default; } // 0x0000000182E928A0-0x0000000182E92930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182E92630-0x0000000182E926C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182E92310-0x0000000182E92390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182E91C90-0x0000000182E91CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182E92D70-0x0000000182E92E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182E92BA0-0x0000000182E92C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182E926C0-0x0000000182E927B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182E92D20-0x0000000182E92D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182E92430-0x0000000182E92520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DraftId { get => default; set {} } // 0x0000000182E91EE0-0x0000000182E91F80 0x0000000182E92A10-0x0000000182E92AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAllArgee { get => default; set {} } // 0x0000000182E92270-0x0000000182E92310 0x0000000182E92B00-0x0000000182E92BA0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22783
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22784
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5409
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftInviteResultNotify() {} // 0x0000000182E93120-0x0000000182E93180
	static DraftInviteResultNotify() {} // 0x0000000182E93060-0x0000000182E93120

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftInviteResultNotify Clone() => default; // 0x0000000182E927B0-0x0000000182E928A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftInviteResultNotify ShallowCopy() => default; // 0x0000000182E92390-0x0000000182E92430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182E91E20-0x0000000182E91E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E929C0-0x0000000182E92A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E92AB0-0x0000000182E92B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182E91E70-0x0000000182E91EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182E91F80-0x0000000182E92050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DraftInviteResultNotify other) => default; // 0x0000000182E92050-0x0000000182E92170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182E92520-0x0000000182E92630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182E92E60-0x0000000182E93060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182E92C00-0x0000000182E92D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182E92170-0x0000000182E92270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DraftInviteResultNotify other) {} // 0x0000000182E91CF0-0x0000000182E91E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182E91B90-0x0000000182E91C90
}

