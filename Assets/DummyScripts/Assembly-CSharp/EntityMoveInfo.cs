/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityMoveInfo : MessageBase, IMessage<EntityMoveInfo> // TypeDefIndex: 26008
{
	// Fields
	private static readonly MessageParser<EntityMoveInfo> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B0AA5F
	private uint entityId_; // 0x18
	public const int MotionInfoFieldNumber = 2; // Metadata: 0x00B0AA63
	private MotionInfo motionInfo_; // 0x20
	public const int SceneTimeFieldNumber = 3; // Metadata: 0x00B0AA67
	private uint sceneTime_; // 0x28
	public const int ReliableSeqFieldNumber = 4; // Metadata: 0x00B0AA6B
	private uint reliableSeq_; // 0x2C
	public const int IsReliableFieldNumber = 5; // Metadata: 0x00B0AA6F
	private bool isReliable_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EntityMoveInfo> Parser { get => default; } // 0x0000000181C82C50-0x0000000181C82CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181C828A0-0x0000000181C82930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181C823E0-0x0000000181C82460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181C81A60-0x0000000181C81AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181C83420-0x0000000181C83510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181C830F0-0x0000000181C83150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181C82A70-0x0000000181C82B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181C83330-0x0000000181C83380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181C825A0-0x0000000181C82690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000181C82FB0-0x0000000181C83050 0x0000000181C83510-0x0000000181C835B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MotionInfo MotionInfo { get => default; set {} } // 0x0000000181C83050-0x0000000181C830F0 0x0000000181C82E10-0x0000000181C82EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneTime { get => default; set {} } // 0x0000000181C829D0-0x0000000181C82A70 0x0000000181C83380-0x0000000181C83420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ReliableSeq { get => default; set {} } // 0x0000000181C82D70-0x0000000181C82E10 0x0000000181C81CC0-0x0000000181C81D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsReliable { get => default; set {} } // 0x0000000181C82500-0x0000000181C825A0 0x0000000181C82930-0x0000000181C829D0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityMoveInfo() {} // 0x0000000181C83A00-0x0000000181C83A60
	static EntityMoveInfo() {} // 0x0000000181C83940-0x0000000181C83A00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityMoveInfo Clone() => default; // 0x0000000181C82B60-0x0000000181C82C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityMoveInfo ShallowCopy() => default; // 0x0000000181C82460-0x0000000181C82500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181C81D60-0x0000000181C81DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181C82EB0-0x0000000181C82F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181C82F30-0x0000000181C82FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181C81DE0-0x0000000181C81F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181C81F40-0x0000000181C82010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EntityMoveInfo other) => default; // 0x0000000181C82010-0x0000000181C821A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181C82690-0x0000000181C828A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181C835B0-0x0000000181C83940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181C83150-0x0000000181C83330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181C821A0-0x0000000181C823E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EntityMoveInfo other) {} // 0x0000000181C81AC0-0x0000000181C81CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181C818D0-0x0000000181C81A60
}

