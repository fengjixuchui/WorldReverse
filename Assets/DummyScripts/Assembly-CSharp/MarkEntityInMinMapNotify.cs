/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MarkEntityInMinMapNotify : MessageBase, IMessage<MarkEntityInMinMapNotify> // TypeDefIndex: 25040
{
	// Fields
	private static readonly MessageParser<MarkEntityInMinMapNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B07D7B
	private uint entityId_; // 0x18
	public const int PositionFieldNumber = 2; // Metadata: 0x00B07D7F
	private Vector position_; // 0x20
	public const int MonsterIdFieldNumber = 3; // Metadata: 0x00B07D83
	private uint monsterId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MarkEntityInMinMapNotify> Parser { get => default; } // 0x00000001849F5930-0x00000001849F59C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001849F5580-0x00000001849F5610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001849F5120-0x00000001849F51A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001849F48B0-0x00000001849F4910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001849F5E00-0x00000001849F5EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001849F5BF0-0x00000001849F5C50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001849F5610-0x00000001849F5700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001849F5DB0-0x00000001849F5E00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001849F52E0-0x00000001849F53D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x00000001849F5B50-0x00000001849F5BF0 0x00000001849F5EF0-0x00000001849F5F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Position { get => default; set {} } // 0x00000001849F5240-0x00000001849F52E0 0x00000001849F57F0-0x00000001849F5890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MonsterId { get => default; set {} } // 0x00000001849F5890-0x00000001849F5930 0x00000001849F4910-0x00000001849F49B0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25041
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25042
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 249
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MarkEntityInMinMapNotify() {} // 0x00000001849F62C0-0x00000001849F6320
	static MarkEntityInMinMapNotify() {} // 0x00000001849F6200-0x00000001849F62C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MarkEntityInMinMapNotify Clone() => default; // 0x00000001849F5700-0x00000001849F57F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MarkEntityInMinMapNotify ShallowCopy() => default; // 0x00000001849F51A0-0x00000001849F5240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001849F4B60-0x00000001849F4BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849F5A50-0x00000001849F5AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849F5AD0-0x00000001849F5B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001849F4BE0-0x00000001849F4D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001849F4E70-0x00000001849F4F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MarkEntityInMinMapNotify other) => default; // 0x00000001849F4D20-0x00000001849F4E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001849F53D0-0x00000001849F5580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001849F5F90-0x00000001849F6200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001849F5C50-0x00000001849F5DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001849F4F40-0x00000001849F5120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MarkEntityInMinMapNotify other) {} // 0x00000001849F49B0-0x00000001849F4B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001849F4750-0x00000001849F48B0
}

