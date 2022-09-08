/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityMoveRoomNotify : MessageBase, IMessage<EntityMoveRoomNotify> // TypeDefIndex: 25233
{
	// Fields
	private static readonly MessageParser<EntityMoveRoomNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B08443
	private uint entityId_; // 0x18
	public const int DestRoomIdFieldNumber = 2; // Metadata: 0x00B08447
	private uint destRoomId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EntityMoveRoomNotify> Parser { get => default; } // 0x0000000181EDEA80-0x0000000181EDEB10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181EDE770-0x0000000181EDE800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181EDE3C0-0x0000000181EDE440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181EDDE50-0x0000000181EDDEB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181EDEEB0-0x0000000181EDEFA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181EDECE0-0x0000000181EDED40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181EDE800-0x0000000181EDE8F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181EDEE60-0x0000000181EDEEB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181EDE4E0-0x0000000181EDE5D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000181EDEC40-0x0000000181EDECE0 0x0000000181EDEFA0-0x0000000181EDF040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DestRoomId { get => default; set {} } // 0x0000000181EDE6D0-0x0000000181EDE770 0x0000000181EDE9E0-0x0000000181EDEA80

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25234
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25235
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 3014
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityMoveRoomNotify() {} // 0x0000000181EDF300-0x0000000181EDF360
	static EntityMoveRoomNotify() {} // 0x0000000181EDF240-0x0000000181EDF300

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityMoveRoomNotify Clone() => default; // 0x0000000181EDE8F0-0x0000000181EDE9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityMoveRoomNotify ShallowCopy() => default; // 0x0000000181EDE440-0x0000000181EDE4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181EDDFE0-0x0000000181EDE030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181EDEBA0-0x0000000181EDEBF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181EDEBF0-0x0000000181EDEC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181EDE030-0x0000000181EDE0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181EDE0A0-0x0000000181EDE170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EntityMoveRoomNotify other) => default; // 0x0000000181EDE170-0x0000000181EDE290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181EDE5D0-0x0000000181EDE6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181EDF040-0x0000000181EDF240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181EDED40-0x0000000181EDEE60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181EDE290-0x0000000181EDE3C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EntityMoveRoomNotify other) {} // 0x0000000181EDDEB0-0x0000000181EDDFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181EDDD50-0x0000000181EDDE50
}

