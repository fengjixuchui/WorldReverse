/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GadgetPlayDataNotify : MessageBase, IMessage<GadgetPlayDataNotify> // TypeDefIndex: 23207
{
	// Fields
	private static readonly MessageParser<GadgetPlayDataNotify> _parser; // 0x00
	public const int PlayTypeFieldNumber = 1; // Metadata: 0x00B037C3
	private uint playType_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B037C7
	private uint entityId_; // 0x1C
	public const int ProgressFieldNumber = 3; // Metadata: 0x00B037CB
	private uint progress_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GadgetPlayDataNotify> Parser { get => default; } // 0x00000001830B65B0-0x00000001830B6640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001830B62A0-0x00000001830B6330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001830B5EC0-0x00000001830B5F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001830B5800-0x00000001830B5860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001830B6AC0-0x00000001830B6BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001830B6810-0x00000001830B6870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001830B63D0-0x00000001830B64C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001830B6A70-0x00000001830B6AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001830B6080-0x00000001830B6170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayType { get => default; set {} } // 0x00000001830B6870-0x00000001830B6910 0x00000001830B5A90-0x00000001830B5B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x00000001830B6770-0x00000001830B6810 0x00000001830B6BB0-0x00000001830B6C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Progress { get => default; set {} } // 0x00000001830B6330-0x00000001830B63D0 0x00000001830B5FE0-0x00000001830B6080

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23208
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23209
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 811
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetPlayDataNotify() {} // 0x00000001830B6FA0-0x00000001830B7000
	static GadgetPlayDataNotify() {} // 0x00000001830B6EE0-0x00000001830B6FA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetPlayDataNotify Clone() => default; // 0x00000001830B64C0-0x00000001830B65B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetPlayDataNotify ShallowCopy() => default; // 0x00000001830B5F40-0x00000001830B5FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001830B59C0-0x00000001830B5A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001830B66D0-0x00000001830B6720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001830B6720-0x00000001830B6770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001830B5A10-0x00000001830B5A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001830B5B30-0x00000001830B5C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GadgetPlayDataNotify other) => default; // 0x00000001830B5C00-0x00000001830B5D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001830B6170-0x00000001830B62A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001830B6C50-0x00000001830B6EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001830B6910-0x00000001830B6A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001830B5D40-0x00000001830B5EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GadgetPlayDataNotify other) {} // 0x00000001830B5860-0x00000001830B59C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001830B56F0-0x00000001830B5800
}

