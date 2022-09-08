/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MassiveEntityElementOpBatchNotify : MessageBase, IMessage<MassiveEntityElementOpBatchNotify> // TypeDefIndex: 23138
{
	// Fields
	private static readonly MessageParser<MassiveEntityElementOpBatchNotify> _parser; // 0x00
	public const int UserIdFieldNumber = 1; // Metadata: 0x00B0345B
	private uint userId_; // 0x18
	public const int AttackerIdFieldNumber = 2; // Metadata: 0x00B0345F
	private uint attackerId_; // 0x1C
	public const int AttackElementDurabilityFieldNumber = 3; // Metadata: 0x00B03463
	private float attackElementDurability_; // 0x20
	public const int SourceElementTypeFieldNumber = 4; // Metadata: 0x00B03467
	private int sourceElementType_; // 0x24
	public const int ReactionSourceTypeFieldNumber = 5; // Metadata: 0x00B0346B
	private int reactionSourceType_; // 0x28
	public const int EntityTypeFieldNumber = 6; // Metadata: 0x00B0346F
	private int entityType_; // 0x2C
	public const int ShapeSphereFieldNumber = 7; // Metadata: 0x00B03473
	public const int ShapeBoxFieldNumber = 8; // Metadata: 0x00B03477
	public const int OpIdxFieldNumber = 9; // Metadata: 0x00B0347B
	private uint opIdx_; // 0x30
	private object checkShape_; // 0x38
	private CheckShapeOneofCase checkShapeCase_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MassiveEntityElementOpBatchNotify> Parser { get => default; } // 0x0000000183173780-0x0000000183173810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183173190-0x0000000183173220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183172D30-0x0000000183172DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183171C70-0x0000000183171CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183174200-0x00000001831742F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183173BB0-0x0000000183173C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001831733C0-0x00000001831734B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183173F40-0x0000000183173F90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183172E50-0x0000000183172F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint UserId { get => default; set {} } // 0x0000000183173640-0x00000001831736E0 0x0000000183172490-0x0000000183172530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AttackerId { get => default; set {} } // 0x00000001831736E0-0x0000000183173780 0x0000000183171CD0-0x0000000183171D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float AttackElementDurability { get => default; set {} } // 0x0000000183173320-0x00000001831733C0 0x00000001831735A0-0x0000000183173640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int SourceElementType { get => default; set {} } // 0x0000000183172C90-0x0000000183172D30 0x00000001831725F0-0x0000000183172690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int ReactionSourceType { get => default; set {} } // 0x0000000183174160-0x0000000183174200 0x00000001831742F0-0x0000000183174390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int EntityType { get => default; set {} } // 0x00000001831722D0-0x0000000183172370 0x0000000183171F80-0x0000000183172020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShapeSphere ShapeSphere { get => default; set {} } // 0x00000001831739C0-0x0000000183173A90 0x0000000183171E40-0x0000000183171EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShapeBox ShapeBox { get => default; set {} } // 0x0000000183171D70-0x0000000183171E40 0x0000000183173280-0x0000000183173320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OpIdx { get => default; set {} } // 0x0000000183174390-0x0000000183174430 0x0000000183171EE0-0x0000000183171F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CheckShapeOneofCase CheckShapeCase { get => default; } // 0x0000000183173EE0-0x0000000183173F40 

	// Nested types
	public enum CheckShapeOneofCase // TypeDefIndex: 23139
	{
		None = 0,
		ShapeSphere = 7,
		ShapeBox = 8
	}

	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23140
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23141
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 353
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassiveEntityElementOpBatchNotify() {} // 0x0000000183174B90-0x0000000183174C00
	static MassiveEntityElementOpBatchNotify() {} // 0x0000000183174AD0-0x0000000183174B90

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassiveEntityElementOpBatchNotify Clone() => default; // 0x00000001831734B0-0x00000001831735A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassiveEntityElementOpBatchNotify ShallowCopy() => default; // 0x0000000183172DB0-0x0000000183172E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183172370-0x0000000183172490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831738A0-0x00000001831739C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183173A90-0x0000000183173BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183172530-0x00000001831725F0
	public void resetCheckShape() {} // 0x0000000183173F90-0x0000000183174160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearCheckShape() {} // 0x0000000183173220-0x0000000183173280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001831728D0-0x00000001831729A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MassiveEntityElementOpBatchNotify other) => default; // 0x0000000183172690-0x00000001831728D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183172F40-0x0000000183173190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183174430-0x0000000183174AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183173C10-0x0000000183173EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001831729A0-0x0000000183172C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MassiveEntityElementOpBatchNotify other) {} // 0x0000000183172020-0x00000001831722D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001831719A0-0x0000000183171C70
}

