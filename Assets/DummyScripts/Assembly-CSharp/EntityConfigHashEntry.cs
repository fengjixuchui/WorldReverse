/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityConfigHashEntry : MessageBase, IMessage<EntityConfigHashEntry> // TypeDefIndex: 25333
{
	// Fields
	private static readonly MessageParser<EntityConfigHashEntry> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B0879B
	private uint entityId_; // 0x18
	public const int HashValueFieldNumber = 2; // Metadata: 0x00B0879F
	private int hashValue_; // 0x1C
	public const int JobIdFieldNumber = 3; // Metadata: 0x00B087A3
	private uint jobId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EntityConfigHashEntry> Parser { get => default; } // 0x0000000183990E40-0x0000000183990ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183990BD0-0x0000000183990C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183990890-0x0000000183990910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183990090-0x00000001839900F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001839912B0-0x00000001839913A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001839910A0-0x0000000183991100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183990C60-0x0000000183990D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183991260-0x00000001839912B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001839909B0-0x0000000183990AA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000183991000-0x00000001839910A0 0x00000001839913A0-0x0000000183991440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int HashValue { get => default; set {} } // 0x00000001839900F0-0x0000000183990190 0x0000000183991440-0x00000001839914E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint JobId { get => default; set {} } // 0x00000001839905D0-0x0000000183990670 0x00000001839907F0-0x0000000183990890

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityConfigHashEntry() {} // 0x0000000183991830-0x0000000183991890
	static EntityConfigHashEntry() {} // 0x0000000183991770-0x0000000183991830

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityConfigHashEntry Clone() => default; // 0x0000000183990D50-0x0000000183990E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityConfigHashEntry ShallowCopy() => default; // 0x0000000183990910-0x00000001839909B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001839902F0-0x0000000183990340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183990F60-0x0000000183990FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183990FB0-0x0000000183991000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183990340-0x00000001839903C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183990500-0x00000001839905D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EntityConfigHashEntry other) => default; // 0x00000001839903C0-0x0000000183990500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183990AA0-0x0000000183990BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001839914E0-0x0000000183991770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183991100-0x0000000183991260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183990670-0x00000001839907F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EntityConfigHashEntry other) {} // 0x0000000183990190-0x00000001839902F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018398FF80-0x0000000183990090
}

