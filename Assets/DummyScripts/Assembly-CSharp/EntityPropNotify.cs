/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityPropNotify : MessageBase, IMessage<EntityPropNotify> // TypeDefIndex: 24525
{
	// Fields
	private static readonly MessageParser<EntityPropNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B06A03
	private uint entityId_; // 0x18
	public const int PropMapFieldNumber = 2; // Metadata: 0x00B06A07
	private static readonly MapField<uint, PropValue> _map_propMap_codec; // 0x08
	private readonly MapField<uint, PropValue> propMap_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EntityPropNotify> Parser { get => default; } // 0x00000001810FBE30-0x00000001810FBEC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001810FBBC0-0x00000001810FBC50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001810FB870-0x00000001810FB8F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001810FB280-0x00000001810FB2E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001810FC280-0x00000001810FC370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001810FC090-0x00000001810FC0F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001810FBC50-0x00000001810FBD40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001810FC230-0x00000001810FC280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001810FB990-0x00000001810FBA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x00000001810FBFF0-0x00000001810FC090 0x00000001810FC370-0x00000001810FC410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, PropValue> PropMap { get => default; } // 0x00000001810FC410-0x00000001810FC470 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24526
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24527
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1201
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityPropNotify() {} // 0x00000001810FC7B0-0x00000001810FC840
	static EntityPropNotify() {} // 0x00000001810FC650-0x00000001810FC7B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityPropNotify Clone() => default; // 0x00000001810FBD40-0x00000001810FBE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityPropNotify ShallowCopy() => default; // 0x00000001810FB8F0-0x00000001810FB990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001810FB410-0x00000001810FB460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001810FBF50-0x00000001810FBFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001810FBFA0-0x00000001810FBFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001810FB460-0x00000001810FB520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001810FB660-0x00000001810FB730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EntityPropNotify other) => default; // 0x00000001810FB520-0x00000001810FB660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001810FBA80-0x00000001810FBBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001810FC470-0x00000001810FC650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001810FC0F0-0x00000001810FC230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001810FB730-0x00000001810FB870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EntityPropNotify other) {} // 0x00000001810FB2E0-0x00000001810FB410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001810FB120-0x00000001810FB280
}

