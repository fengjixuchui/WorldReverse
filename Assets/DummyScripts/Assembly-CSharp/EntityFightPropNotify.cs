/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityFightPropNotify : MessageBase, IMessage<EntityFightPropNotify> // TypeDefIndex: 24531
{
	// Fields
	private static readonly MessageParser<EntityFightPropNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B06A43
	private uint entityId_; // 0x18
	public const int FightPropMapFieldNumber = 2; // Metadata: 0x00B06A47
	private static readonly MapField<uint, float> _map_fightPropMap_codec; // 0x08
	private readonly MapField<uint, float> fightPropMap_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EntityFightPropNotify> Parser { get => default; } // 0x00000001852A0D60-0x00000001852A0DF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001852A0AF0-0x00000001852A0B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001852A07A0-0x00000001852A0820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001852A0150-0x00000001852A01B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001852A11B0-0x00000001852A12A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001852A0FC0-0x00000001852A1020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001852A0B80-0x00000001852A0C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001852A1160-0x00000001852A11B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001852A08C0-0x00000001852A09B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x00000001852A0F20-0x00000001852A0FC0 0x00000001852A12A0-0x00000001852A1340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, float> FightPropMap { get => default; } // 0x00000001852A01B0-0x00000001852A0210 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24532
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24533
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1203
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityFightPropNotify() {} // 0x00000001852A1650-0x00000001852A16E0
	static EntityFightPropNotify() {} // 0x00000001852A1520-0x00000001852A1650

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityFightPropNotify Clone() => default; // 0x00000001852A0C70-0x00000001852A0D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityFightPropNotify ShallowCopy() => default; // 0x00000001852A0820-0x00000001852A08C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001852A0340-0x00000001852A0390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001852A0E80-0x00000001852A0ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001852A0ED0-0x00000001852A0F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001852A0390-0x00000001852A0450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001852A0450-0x00000001852A0520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EntityFightPropNotify other) => default; // 0x00000001852A0520-0x00000001852A0660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001852A09B0-0x00000001852A0AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001852A1340-0x00000001852A1520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001852A1020-0x00000001852A1160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001852A0660-0x00000001852A07A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EntityFightPropNotify other) {} // 0x00000001852A0210-0x00000001852A0340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018529FFF0-0x00000001852A0150
}

